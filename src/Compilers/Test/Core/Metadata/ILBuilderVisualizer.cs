// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Microsoft.Metadata.Tools;
using Roslyn.Utilities;
using Cci = Microsoft.Cci;

namespace Roslyn.Test.Utilities
{
    internal sealed class ILBuilderVisualizer(CommonPEModuleBuilder module, SymbolDisplayFormat? symbolDisplayFormat = null) : ILVisualizer
    {
        private readonly CommonPEModuleBuilder _module = module;
        private readonly SymbolDisplayFormat _symbolDisplayFormat = symbolDisplayFormat ?? SymbolDisplayFormat.ILVisualizationFormat;

        public override string VisualizeUserString(uint token)
        {
            // Check for an encoding of the spelling of the current module's module version ID.
            if (token == 0x80000000)
            {
                return "##MVID##";
            }

            return "\"" + _module.GetStringFromToken(token) + "\"";
        }

        public override string VisualizeSymbol(uint token, OperandType operandType)
        {
            if (operandType == OperandType.InlineTok)
            {
                switch ((Cci.MetadataWriter.RawTokenEncoding)(token >> 24))
                {
                    case Cci.MetadataWriter.RawTokenEncoding.GreatestMethodDefinitionRowId:
                        return "Max Method Token Index";

                    case Cci.MetadataWriter.RawTokenEncoding.DocumentRowId:
                        return "Source Document " + (token & 0x00ffffff).ToString();
                }

                token &= 0xffffff;
            }

            object reference = _module.GetReferenceFromToken(token);
            ISymbol? symbol = ((reference as ISymbolInternal) ?? (reference as Cci.IReference)?.GetInternalSymbol())?.GetISymbol();
            return string.Format("\"{0}\"", symbol == null ? (object)reference : symbol.ToDisplayString(_symbolDisplayFormat));
        }

        public override string? VisualizeLocalType(object type)
        {
            return (((type as ISymbolInternal) ?? (type as Cci.IReference)?.GetInternalSymbol()) is ISymbolInternal symbol) ? symbol.GetISymbol().ToDisplayString(_symbolDisplayFormat) : type.ToString();
        }

        /// <summary>
        /// Determine the list of spans ordered by handler
        /// block start, with outer handlers before inner.
        /// </summary>
        private static List<HandlerSpan>? GetHandlerSpans(ImmutableArray<Cci.ExceptionHandlerRegion> regions)
        {
            if (regions.IsDefaultOrEmpty)
            {
                return null;
            }

            var spans = new List<HandlerSpan>();

            // Add unique try blocks.
            foreach (Cci.ExceptionHandlerRegion region in regions)
            {
                var span = new HandlerSpan(HandlerKind.Try, null, region.TryStartOffset, region.TryEndOffset);

                int n = spans.Count;
                if (n == 0 || span.CompareTo(spans[n - 1]) != 0)
                {
                    spans.Add(span);
                }
            }

            // Add all handler blocks.
            foreach (Cci.ExceptionHandlerRegion region in regions)
            {
                HandlerSpan span;

                if (region.HandlerKind == System.Reflection.Metadata.ExceptionRegionKind.Filter)
                {
                    span = new HandlerSpan(HandlerKind.Filter, null, region.FilterDecisionStartOffset, region.HandlerEndOffset, region.HandlerStartOffset);
                }
                else
                {
                    var kind = region.HandlerKind switch
                    {
                        System.Reflection.Metadata.ExceptionRegionKind.Catch => HandlerKind.Catch,
                        System.Reflection.Metadata.ExceptionRegionKind.Fault => HandlerKind.Fault,
                        System.Reflection.Metadata.ExceptionRegionKind.Filter => HandlerKind.Filter,
                        _ => HandlerKind.Finally,
                    };
                    span = new HandlerSpan(kind, region.ExceptionType, region.HandlerStartOffset, region.HandlerEndOffset);
                }
                spans.Add(span);
            }

            spans.Sort();
            return spans;
        }

        /// <remarks>
        /// Invoked via Reflection from <see cref="ILBuilder"/><c>.GetDebuggerDisplay()</c>.
        /// </remarks>
        internal static string ILBuilderToString(
            ILBuilder builder,
            Func<Cci.ILocalDefinition, LocalInfo>? mapLocal = null,
            IReadOnlyDictionary<int, string>? markers = null,
            SymbolDisplayFormat? ilFormat = null)
        {
            Debug.Assert(builder.LocalSlotManager != null);

            var sb = new StringBuilder();

            var ilStream = builder.RealizedIL;
            if (mapLocal == null)
            {
                mapLocal = local => new LocalInfo(local.Name, local.Type, local.IsPinned, local.IsReference);
            }

            var locals = builder.LocalSlotManager.LocalsInOrder().SelectAsArray(mapLocal);
            var visualizer = new ILBuilderVisualizer(builder.module, ilFormat);

            if (!ilStream.IsDefault)
            {
                visualizer.DumpMethod(sb, builder.MaxStack, ilStream, locals, GetHandlerSpans(builder.RealizedExceptionHandlers), markers, builder.AreLocalsZeroed);
            }
            else
            {
                sb.AppendLine("{");

                visualizer.VisualizeHeader(sb, 0, builder.MaxStack, locals);
                // serialize blocks as-is
                var current = builder.leaderBlock;
                while (current != null)
                {
                    DumpBlockIL(current, sb);
                    current = current.NextBlock;
                }

                sb.AppendLine("}");
            }

            return sb.ToString();
        }

        internal static string LocalSignatureToString(
            ILBuilder builder,
            Func<Cci.ILocalDefinition, LocalInfo>? mapLocal = null)
        {
            Debug.Assert(builder.LocalSlotManager != null);

            var sb = new StringBuilder();

            if (mapLocal == null)
            {
                mapLocal = local => new LocalInfo(local.Name, local.Type, local.IsPinned, local.IsReference);
            }

            var locals = builder.LocalSlotManager.LocalsInOrder().SelectAsArray(mapLocal);
            var visualizer = new ILBuilderVisualizer(builder.module);

            visualizer.VisualizeHeader(sb, -1, -1, locals);
            return sb.ToString();
        }

#pragma warning disable IDE0051 // Remove unused private members, used for debugger display of BasicBlock via reflection
        private static string BasicBlockToString(ILBuilder.BasicBlock block)
#pragma warning restore IDE0051 // Remove unused private members
        {
            StringBuilder sb = new StringBuilder();
            DumpBlockIL(block, sb);
            return sb.ToString();
        }

        private static void DumpBlockIL(ILBuilder.BasicBlock block, StringBuilder sb)
        {
            if (block is ILBuilder.SwitchBlock switchBlock)
            {
                DumpSwitchBlockIL(switchBlock, sb);
            }
            else
            {
                DumpBasicBlockIL(block, sb);
            }
        }

        private static void DumpBasicBlockIL(ILBuilder.BasicBlock block, StringBuilder sb)
        {
            var instrCnt = block.RegularInstructionsLength;
            if (instrCnt != 0)
            {
                var il = block.RegularInstructions.ToImmutableArray();
                new ILBuilderVisualizer(block.builder.module).DumpILBlock(il, instrCnt, sb, Array.Empty<ILVisualizer.HandlerSpan>(), block.Start);
            }

            if (block.BranchCode != ILOpCode.Nop)
            {
                sb.Append(string.Format("  IL_{0:x4}:", block.RegularInstructionsLength + block.Start));
                sb.Append(string.Format("  {0,-10}", GetInstructionName(block.BranchCode)));

                if (block.BranchCode.IsBranch())
                {
                    var branchBlock = block.BranchBlock;
                    if (branchBlock == null)
                    {
                        // this happens if label is not yet marked.
                        sb.Append(" <unmarked label>");
                    }
                    else
                    {
                        sb.Append(string.Format(" IL_{0:x4}", branchBlock.Start));
                    }
                }

                sb.AppendLine();
            }
        }

        private static void DumpSwitchBlockIL(ILBuilder.SwitchBlock block, StringBuilder sb)
        {
            var il = block.RegularInstructions.ToImmutableArray();
            new ILBuilderVisualizer(block.builder.module).DumpILBlock(il, il.Length, sb, Array.Empty<HandlerSpan>(), block.Start);

            // switch (N, t1, t2... tN)
            //  IL ==> ILOpCode.Switch < unsigned int32 > < int32 >... < int32 >

            sb.Append(string.Format("  IL_{0:x4}:", block.RegularInstructionsLength + block.Start));
            sb.Append(string.Format("  {0,-10}", GetInstructionName(block.BranchCode)));
            sb.Append(string.Format("  IL_{0:x4}:", block.BranchesCount));

            var blockBuilder = ArrayBuilder<ILBuilder.BasicBlock>.GetInstance();
            block.GetBranchBlocks(blockBuilder);

            foreach (var branchBlock in blockBuilder)
            {
                if (branchBlock == null)
                {
                    // this happens if label is not yet marked.
                    sb.Append(" <unmarked label>");
                }
                else
                {
                    sb.Append(string.Format(" IL_{0:x4}", branchBlock.Start));
                }
            }

            blockBuilder.Free();

            sb.AppendLine();
        }

        private static string GetInstructionName(ILOpCode opcode)
        {
            return opcode switch
            {
                ILOpCode.Nop => "nop",
                ILOpCode.Break => "break",
                ILOpCode.Ldarg_0 => "ldarg.0",
                ILOpCode.Ldarg_1 => "ldarg.1",
                ILOpCode.Ldarg_2 => "ldarg.2",
                ILOpCode.Ldarg_3 => "ldarg.3",
                ILOpCode.Ldloc_0 => "ldloc.0",
                ILOpCode.Ldloc_1 => "ldloc.1",
                ILOpCode.Ldloc_2 => "ldloc.2",
                ILOpCode.Ldloc_3 => "ldloc.3",
                ILOpCode.Stloc_0 => "stloc.0",
                ILOpCode.Stloc_1 => "stloc.1",
                ILOpCode.Stloc_2 => "stloc.2",
                ILOpCode.Stloc_3 => "stloc.3",
                ILOpCode.Ldarg_s => "ldarg.s",
                ILOpCode.Ldarga_s => "ldarga.s",
                ILOpCode.Starg_s => "starg.s",
                ILOpCode.Ldloc_s => "ldloc.s",
                ILOpCode.Ldloca_s => "ldloca.s",
                ILOpCode.Stloc_s => "stloc.s",
                ILOpCode.Ldnull => "ldnull",
                ILOpCode.Ldc_i4_m1 => "ldc.i4.m1",
                ILOpCode.Ldc_i4_0 => "ldc.i4.0",
                ILOpCode.Ldc_i4_1 => "ldc.i4.1",
                ILOpCode.Ldc_i4_2 => "ldc.i4.2",
                ILOpCode.Ldc_i4_3 => "ldc.i4.3",
                ILOpCode.Ldc_i4_4 => "ldc.i4.4",
                ILOpCode.Ldc_i4_5 => "ldc.i4.5",
                ILOpCode.Ldc_i4_6 => "ldc.i4.6",
                ILOpCode.Ldc_i4_7 => "ldc.i4.7",
                ILOpCode.Ldc_i4_8 => "ldc.i4.8",
                ILOpCode.Ldc_i4_s => "ldc.i4.s",
                ILOpCode.Ldc_i4 => "ldc.i4",
                ILOpCode.Ldc_i8 => "ldc.i8",
                ILOpCode.Ldc_r4 => "ldc.r4",
                ILOpCode.Ldc_r8 => "ldc.r8",
                ILOpCode.Dup => "dup",
                ILOpCode.Pop => "pop",
                ILOpCode.Jmp => "jmp",
                ILOpCode.Call => "call",
                ILOpCode.Calli => "calli",
                ILOpCode.Ret => "ret",
                ILOpCode.Br_s => "br.s",
                ILOpCode.Brfalse_s => "brfalse.s",
                ILOpCode.Brtrue_s => "brtrue.s",
                ILOpCode.Beq_s => "beq.s",
                ILOpCode.Bge_s => "bge.s",
                ILOpCode.Bgt_s => "bgt.s",
                ILOpCode.Ble_s => "ble.s",
                ILOpCode.Blt_s => "blt.s",
                ILOpCode.Bne_un_s => "bne.un.s",
                ILOpCode.Bge_un_s => "bge.un.s",
                ILOpCode.Bgt_un_s => "bgt.un.s",
                ILOpCode.Ble_un_s => "ble.un.s",
                ILOpCode.Blt_un_s => "blt.un.s",
                ILOpCode.Br => "br",
                ILOpCode.Brfalse => "brfalse",
                ILOpCode.Brtrue => "brtrue",
                ILOpCode.Beq => "beq",
                ILOpCode.Bge => "bge",
                ILOpCode.Bgt => "bgt",
                ILOpCode.Ble => "ble",
                ILOpCode.Blt => "blt",
                ILOpCode.Bne_un => "bne.un",
                ILOpCode.Bge_un => "bge.un",
                ILOpCode.Bgt_un => "bgt.un",
                ILOpCode.Ble_un => "ble.un",
                ILOpCode.Blt_un => "blt.un",
                ILOpCode.Switch => "switch",
                ILOpCode.Ldind_i1 => "ldind.i1",
                ILOpCode.Ldind_u1 => "ldind.u1",
                ILOpCode.Ldind_i2 => "ldind.i2",
                ILOpCode.Ldind_u2 => "ldind.u2",
                ILOpCode.Ldind_i4 => "ldind.i4",
                ILOpCode.Ldind_u4 => "ldind.u4",
                ILOpCode.Ldind_i8 => "ldind.i8",
                ILOpCode.Ldind_i => "ldind.i",
                ILOpCode.Ldind_r4 => "ldind.r4",
                ILOpCode.Ldind_r8 => "ldind.r8",
                ILOpCode.Ldind_ref => "ldind.ref",
                ILOpCode.Stind_ref => "stind.ref",
                ILOpCode.Stind_i1 => "stind.i1",
                ILOpCode.Stind_i2 => "stind.i2",
                ILOpCode.Stind_i4 => "stind.i4",
                ILOpCode.Stind_i8 => "stind.i8",
                ILOpCode.Stind_r4 => "stind.r4",
                ILOpCode.Stind_r8 => "stind.r8",
                ILOpCode.Add => "add",
                ILOpCode.Sub => "sub",
                ILOpCode.Mul => "mul",
                ILOpCode.Div => "div",
                ILOpCode.Div_un => "div.un",
                ILOpCode.Rem => "rem",
                ILOpCode.Rem_un => "rem.un",
                ILOpCode.And => "and",
                ILOpCode.Or => "or",
                ILOpCode.Xor => "xor",
                ILOpCode.Shl => "shl",
                ILOpCode.Shr => "shr",
                ILOpCode.Shr_un => "shr.un",
                ILOpCode.Neg => "neg",
                ILOpCode.Not => "not",
                ILOpCode.Conv_i1 => "conv.i1",
                ILOpCode.Conv_i2 => "conv.i2",
                ILOpCode.Conv_i4 => "conv.i4",
                ILOpCode.Conv_i8 => "conv.i8",
                ILOpCode.Conv_r4 => "conv.r4",
                ILOpCode.Conv_r8 => "conv.r8",
                ILOpCode.Conv_u4 => "conv.u4",
                ILOpCode.Conv_u8 => "conv.u8",
                ILOpCode.Callvirt => "callvirt",
                ILOpCode.Cpobj => "cpobj",
                ILOpCode.Ldobj => "ldobj",
                ILOpCode.Ldstr => "ldstr",
                ILOpCode.Newobj => "newobj",
                ILOpCode.Castclass => "castclass",
                ILOpCode.Isinst => "isinst",
                ILOpCode.Conv_r_un => "conv.r.un",
                ILOpCode.Unbox => "unbox",
                ILOpCode.Throw => "throw",
                ILOpCode.Ldfld => "ldfld",
                ILOpCode.Ldflda => "ldflda",
                ILOpCode.Stfld => "stfld",
                ILOpCode.Ldsfld => "ldsfld",
                ILOpCode.Ldsflda => "ldsflda",
                ILOpCode.Stsfld => "stsfld",
                ILOpCode.Stobj => "stobj",
                ILOpCode.Conv_ovf_i1_un => "conv.ovf.i1.un",
                ILOpCode.Conv_ovf_i2_un => "conv.ovf.i2.un",
                ILOpCode.Conv_ovf_i4_un => "conv.ovf.i4.un",
                ILOpCode.Conv_ovf_i8_un => "conv.ovf.i8.un",
                ILOpCode.Conv_ovf_u1_un => "conv.ovf.u1.un",
                ILOpCode.Conv_ovf_u2_un => "conv.ovf.u2.un",
                ILOpCode.Conv_ovf_u4_un => "conv.ovf.u4.un",
                ILOpCode.Conv_ovf_u8_un => "conv.ovf.u8.un",
                ILOpCode.Conv_ovf_i_un => "conv.ovf.i.un",
                ILOpCode.Conv_ovf_u_un => "conv.ovf.u.un",
                ILOpCode.Box => "box",
                ILOpCode.Newarr => "newarr",
                ILOpCode.Ldlen => "ldlen",
                ILOpCode.Ldelema => "ldelema",
                ILOpCode.Ldelem_i1 => "ldelem.i1",
                ILOpCode.Ldelem_u1 => "ldelem.u1",
                ILOpCode.Ldelem_i2 => "ldelem.i2",
                ILOpCode.Ldelem_u2 => "ldelem.u2",
                ILOpCode.Ldelem_i4 => "ldelem.i4",
                ILOpCode.Ldelem_u4 => "ldelem.u4",
                ILOpCode.Ldelem_i8 => "ldelem.i8",
                ILOpCode.Ldelem_i => "ldelem.i",
                ILOpCode.Ldelem_r4 => "ldelem.r4",
                ILOpCode.Ldelem_r8 => "ldelem.r8",
                ILOpCode.Ldelem_ref => "ldelem.ref",
                ILOpCode.Stelem_i => "stelem.i",
                ILOpCode.Stelem_i1 => "stelem.i1",
                ILOpCode.Stelem_i2 => "stelem.i2",
                ILOpCode.Stelem_i4 => "stelem.i4",
                ILOpCode.Stelem_i8 => "stelem.i8",
                ILOpCode.Stelem_r4 => "stelem.r4",
                ILOpCode.Stelem_r8 => "stelem.r8",
                ILOpCode.Stelem_ref => "stelem.ref",
                ILOpCode.Ldelem => "ldelem",
                ILOpCode.Stelem => "stelem",
                ILOpCode.Unbox_any => "unbox.any",
                ILOpCode.Conv_ovf_i1 => "conv.ovf.i1",
                ILOpCode.Conv_ovf_u1 => "conv.ovf.u1",
                ILOpCode.Conv_ovf_i2 => "conv.ovf.i2",
                ILOpCode.Conv_ovf_u2 => "conv.ovf.u2",
                ILOpCode.Conv_ovf_i4 => "conv.ovf.i4",
                ILOpCode.Conv_ovf_u4 => "conv.ovf.u4",
                ILOpCode.Conv_ovf_i8 => "conv.ovf.i8",
                ILOpCode.Conv_ovf_u8 => "conv.ovf.u8",
                ILOpCode.Refanyval => "refanyval",
                ILOpCode.Ckfinite => "ckfinite",
                ILOpCode.Mkrefany => "mkrefany",
                ILOpCode.Ldtoken => "ldtoken",
                ILOpCode.Conv_u2 => "conv.u2",
                ILOpCode.Conv_u1 => "conv.u1",
                ILOpCode.Conv_i => "conv.i",
                ILOpCode.Conv_ovf_i => "conv.ovf.i",
                ILOpCode.Conv_ovf_u => "conv.ovf.u",
                ILOpCode.Add_ovf => "add.ovf",
                ILOpCode.Add_ovf_un => "add.ovf.un",
                ILOpCode.Mul_ovf => "mul.ovf",
                ILOpCode.Mul_ovf_un => "mul.ovf.un",
                ILOpCode.Sub_ovf => "sub.ovf",
                ILOpCode.Sub_ovf_un => "sub.ovf.un",
                ILOpCode.Endfinally => "endfinally",
                ILOpCode.Leave => "leave",
                ILOpCode.Leave_s => "leave.s",
                ILOpCode.Stind_i => "stind.i",
                ILOpCode.Conv_u => "conv.u",
                ILOpCode.Arglist => "arglist",
                ILOpCode.Ceq => "ceq",
                ILOpCode.Cgt => "cgt",
                ILOpCode.Cgt_un => "cgt.un",
                ILOpCode.Clt => "clt",
                ILOpCode.Clt_un => "clt.un",
                ILOpCode.Ldftn => "ldftn",
                ILOpCode.Ldvirtftn => "ldvirtftn",
                ILOpCode.Ldarg => "ldarg",
                ILOpCode.Ldarga => "ldarga",
                ILOpCode.Starg => "starg",
                ILOpCode.Ldloc => "ldloc",
                ILOpCode.Ldloca => "ldloca",
                ILOpCode.Stloc => "stloc",
                ILOpCode.Localloc => "localloc",
                ILOpCode.Endfilter => "endfilter",
                ILOpCode.Unaligned => "unaligned.",
                ILOpCode.Volatile => "volatile.",
                ILOpCode.Tail => "tail.",
                ILOpCode.Initobj => "initobj",
                ILOpCode.Constrained => "constrained.",
                ILOpCode.Cpblk => "cpblk",
                ILOpCode.Initblk => "initblk",
                ILOpCode.Rethrow => "rethrow",
                ILOpCode.Sizeof => "sizeof",
                ILOpCode.Refanytype => "refanytype",
                ILOpCode.Readonly => "readonly.",
                _ => throw ExceptionUtilities.UnexpectedValue(opcode),
            };
        }
    }
}
