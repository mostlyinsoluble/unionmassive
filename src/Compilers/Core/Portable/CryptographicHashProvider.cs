// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal abstract class CryptographicHashProvider
    {
        private ImmutableArray<byte> _lazySHA1Hash;
        private ImmutableArray<byte> _lazySHA256Hash;
        private ImmutableArray<byte> _lazySHA384Hash;
        private ImmutableArray<byte> _lazySHA512Hash;
        private ImmutableArray<byte> _lazyMD5Hash;

        internal abstract ImmutableArray<byte> ComputeHash(HashAlgorithm algorithm);

        internal ImmutableArray<byte> GetHash(AssemblyHashAlgorithm algorithmId)
        {
            using (HashAlgorithm? algorithm = TryGetAlgorithm(algorithmId))
            {
                // ERR_CryptoHashFailed has already been reported:
                if (algorithm == null)
                {
                    return ImmutableArray.Create<byte>();
                }

                return algorithmId switch
                {
                    AssemblyHashAlgorithm.None or AssemblyHashAlgorithm.Sha1 => GetHash(ref _lazySHA1Hash, algorithm),
                    AssemblyHashAlgorithm.Sha256 => GetHash(ref _lazySHA256Hash, algorithm),
                    AssemblyHashAlgorithm.Sha384 => GetHash(ref _lazySHA384Hash, algorithm),
                    AssemblyHashAlgorithm.Sha512 => GetHash(ref _lazySHA512Hash, algorithm),
                    AssemblyHashAlgorithm.MD5 => GetHash(ref _lazyMD5Hash, algorithm),
                    _ => throw ExceptionUtilities.UnexpectedValue(algorithmId),
                };
            }
        }

        internal static int GetHashSize(SourceHashAlgorithm algorithmId)
        {
            return algorithmId switch
            {
                SourceHashAlgorithm.Sha1 => 160 / 8,
                SourceHashAlgorithm.Sha256 => 256 / 8,
                SourceHashAlgorithm.Sha384 => 384 / 8,
                SourceHashAlgorithm.Sha512 => 512 / 8,
                _ => throw ExceptionUtilities.UnexpectedValue(algorithmId),
            };
        }

        internal static HashAlgorithm? TryGetAlgorithm(SourceHashAlgorithm algorithmId)
        {
            return algorithmId switch
            {
                SourceHashAlgorithm.Sha1 => SHA1.Create(),// CodeQL [SM02196] This is not enabled by default but exists as a compat option for existing builds.
                SourceHashAlgorithm.Sha256 => SHA256.Create(),
                SourceHashAlgorithm.Sha384 => SHA384.Create(),
                SourceHashAlgorithm.Sha512 => SHA512.Create(),
                _ => null,
            };
        }

        internal static HashAlgorithmName GetAlgorithmName(SourceHashAlgorithm algorithmId)
        {
            return algorithmId switch
            {
                SourceHashAlgorithm.Sha1 => HashAlgorithmName.SHA1,// CodeQL [SM02196] This is not enabled by default but exists as a compat option for existing builds.
                SourceHashAlgorithm.Sha256 => HashAlgorithmName.SHA256,
                SourceHashAlgorithm.Sha384 => HashAlgorithmName.SHA384,
                SourceHashAlgorithm.Sha512 => HashAlgorithmName.SHA512,
                _ => throw ExceptionUtilities.UnexpectedValue(algorithmId),
            };
        }

        internal static HashAlgorithm? TryGetAlgorithm(AssemblyHashAlgorithm algorithmId)
        {
            return algorithmId switch
            {
                AssemblyHashAlgorithm.None or AssemblyHashAlgorithm.Sha1 => SHA1.Create(),// CodeQL [SM02196] ECMA-335 requires us to support SHA-1
                AssemblyHashAlgorithm.Sha256 => SHA256.Create(),
                AssemblyHashAlgorithm.Sha384 => SHA384.Create(),
                AssemblyHashAlgorithm.Sha512 => SHA512.Create(),
                AssemblyHashAlgorithm.MD5 => MD5.Create(),// CodeQL [SM02196] This is supported by the underlying ECMA-335 APIs (System.Reflection.Metadata) and as consumers we must also support it.
                _ => null,
            };
        }

        internal static bool IsSupportedAlgorithm(AssemblyHashAlgorithm algorithmId)
        {
            return algorithmId switch
            {
                AssemblyHashAlgorithm.None or AssemblyHashAlgorithm.Sha1 or AssemblyHashAlgorithm.Sha256 or AssemblyHashAlgorithm.Sha384 or AssemblyHashAlgorithm.Sha512 or AssemblyHashAlgorithm.MD5 => true,
                _ => false,
            };
        }

        private ImmutableArray<byte> GetHash(ref ImmutableArray<byte> lazyHash, HashAlgorithm algorithm)
        {
            if (lazyHash.IsDefault)
            {
                ImmutableInterlocked.InterlockedCompareExchange(ref lazyHash, ComputeHash(algorithm), default);
            }

            return lazyHash;
        }

        internal const int Sha1HashSize = 20;

        internal static ImmutableArray<byte> ComputeSha1(Stream stream)
        {
            if (stream != null)
            {
                stream.Seek(0, SeekOrigin.Begin);

                // CodeQL [SM02196] ECMA-335 requires us to use SHA-1 and there is no alternative.
                using (var hashProvider = SHA1.Create())
                {
                    return ImmutableArray.Create(hashProvider.ComputeHash(stream));
                }
            }

            return ImmutableArray<byte>.Empty;
        }

        internal static ImmutableArray<byte> ComputeSha1(ImmutableArray<byte> bytes)
        {
            return ComputeSha1(bytes.ToArray());
        }

        internal static ImmutableArray<byte> ComputeSha1(byte[] bytes)
        {
            // CodeQL [SM02196] ECMA-335 requires us to use SHA-1 and there is no alternative.
            using (var hashProvider = SHA1.Create())
            {
                return ImmutableArray.Create(hashProvider.ComputeHash(bytes));
            }
        }

        internal static ImmutableArray<byte> ComputeHash(HashAlgorithmName algorithmName, IEnumerable<Blob> bytes)
        {
            using (var incrementalHash = IncrementalHash.CreateHash(algorithmName))
            {
                incrementalHash.AppendData(bytes);
                return ImmutableArray.Create(incrementalHash.GetHashAndReset());
            }
        }

        internal static ImmutableArray<byte> ComputeHash(HashAlgorithmName algorithmName, IEnumerable<ArraySegment<byte>> bytes)
        {
            using (var incrementalHash = IncrementalHash.CreateHash(algorithmName))
            {
                incrementalHash.AppendData(bytes);
                return ImmutableArray.Create(incrementalHash.GetHashAndReset());
            }
        }

        internal static ImmutableArray<byte> ComputeSourceHash(ImmutableArray<byte> bytes, SourceHashAlgorithm hashAlgorithm = SourceHashAlgorithms.Default)
        {
            var algorithmName = GetAlgorithmName(hashAlgorithm);
            using (var incrementalHash = IncrementalHash.CreateHash(algorithmName))
            {
                incrementalHash.AppendData(bytes.ToArray());
                return ImmutableArray.Create(incrementalHash.GetHashAndReset());
            }
        }

        static readonly byte[] _singleZeroByteArray = new byte[1] { 0 };

        internal static ImmutableArray<byte> ComputeSourceHash(ImmutableArray<ConstantValue> constants, SourceHashAlgorithm hashAlgorithm = SourceHashAlgorithms.Default)
        {
            var algorithmName = GetAlgorithmName(hashAlgorithm);
            using var incrementalHash = IncrementalHash.CreateHash(algorithmName);

            foreach (var constant in constants)
            {
                incrementalHash.AppendData(getBytes(constant));
            }

            return ImmutableArray.Create(incrementalHash.GetHashAndReset());

            static byte[] getBytes(ConstantValue constant)
            {
                switch (constant.Discriminator)
                {
                    case ConstantValueTypeDiscriminator.Null:
                        return _singleZeroByteArray;

                    case ConstantValueTypeDiscriminator.String:
                        return Encoding.Unicode.GetBytes(constant.StringValue!);

                    case ConstantValueTypeDiscriminator.NInt:
                        return getBytes(constant.UInt32Value);

                    case ConstantValueTypeDiscriminator.NUInt:
                        return getBytes(constant.UInt32Value);

                    case ConstantValueTypeDiscriminator.Decimal:
                        int[] bits = decimal.GetBits(constant.DecimalValue);
                        Debug.Assert(bits.Length == 4);

                        byte[] bytes = new byte[16];
                        Span<byte> span = bytes;
                        BinaryPrimitives.WriteInt32LittleEndian(span, bits[0]);
                        BinaryPrimitives.WriteInt32LittleEndian(span.Slice(4), bits[1]);
                        BinaryPrimitives.WriteInt32LittleEndian(span.Slice(8), bits[2]);
                        BinaryPrimitives.WriteInt32LittleEndian(span.Slice(12), bits[3]);

                        return bytes;

                    default:
                        throw ExceptionUtilities.UnexpectedValue(constant.Discriminator);
                }

                static byte[] getBytes(uint value)
                {
                    var bytes = new byte[4];
                    BinaryPrimitives.WriteUInt32LittleEndian(bytes, value);
                    return bytes;
                }
            }
        }

        internal static ImmutableArray<byte> ComputeSourceHash(IEnumerable<Blob> bytes, SourceHashAlgorithm hashAlgorithm = SourceHashAlgorithms.Default)
        {
            return ComputeHash(GetAlgorithmName(hashAlgorithm), bytes);
        }
    }
}
