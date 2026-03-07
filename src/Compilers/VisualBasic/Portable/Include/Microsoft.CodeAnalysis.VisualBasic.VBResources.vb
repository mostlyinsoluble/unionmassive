Imports System.Reflection


Namespace Microsoft.CodeAnalysis.VisualBasic
    Friend Partial Class VBResources
        Private Sub New
        End Sub
        
        Private Shared s_resourceManager As Global.System.Resources.ResourceManager
        Friend Shared ReadOnly Property ResourceManager As Global.System.Resources.ResourceManager
            Get
                If s_resourceManager Is Nothing Then
                    s_resourceManager = New Global.System.Resources.ResourceManager(GetType(VBResources))
                End If
                Return s_resourceManager
            End Get
        End Property
        Friend Shared Property Culture As Global.System.Globalization.CultureInfo
        <Global.System.Runtime.CompilerServices.MethodImpl(Global.System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)>
        Friend Shared Function GetResourceString(ByVal resourceKey As String, Optional ByVal defaultValue As String = Nothing) As String
            Return ResourceManager.GetString(resourceKey, Culture)
        End Function
        ''' <summary>trees({0}) must have root node with SyntaxKind.CompilationUnit.</summary>
        Friend Shared ReadOnly Property [TreesMustHaveRootNode] As String
          Get
            Return GetResourceString("TreesMustHaveRootNode")
          End Get
        End Property
        ''' <summary>Cannot add compiler special tree</summary>
        Friend Shared ReadOnly Property [CannotAddCompilerSpecialTree] As String
          Get
            Return GetResourceString("CannotAddCompilerSpecialTree")
          End Get
        End Property
        ''' <summary>Syntax tree already present</summary>
        Friend Shared ReadOnly Property [SyntaxTreeAlreadyPresent] As String
          Get
            Return GetResourceString("SyntaxTreeAlreadyPresent")
          End Get
        End Property
        ''' <summary>Submission can have at most one syntax tree.</summary>
        Friend Shared ReadOnly Property [SubmissionCanHaveAtMostOneSyntaxTree] As String
          Get
            Return GetResourceString("SubmissionCanHaveAtMostOneSyntaxTree")
          End Get
        End Property
        ''' <summary>Cannot remove compiler special tree</summary>
        Friend Shared ReadOnly Property [CannotRemoveCompilerSpecialTree] As String
          Get
            Return GetResourceString("CannotRemoveCompilerSpecialTree")
          End Get
        End Property
        ''' <summary>SyntaxTree '{0}' not found to remove</summary>
        Friend Shared ReadOnly Property [SyntaxTreeNotFoundToRemove] As String
          Get
            Return GetResourceString("SyntaxTreeNotFoundToRemove")
          End Get
        End Property
        ''' <summary>Tree must have a root node with SyntaxKind.CompilationUnit</summary>
        Friend Shared ReadOnly Property [TreeMustHaveARootNodeWithCompilationUnit] As String
          Get
            Return GetResourceString("TreeMustHaveARootNodeWithCompilationUnit")
          End Get
        End Property
        ''' <summary>Compilation (Visual Basic):</summary>
        Friend Shared ReadOnly Property [CompilationVisualBasic] As String
          Get
            Return GetResourceString("CompilationVisualBasic")
          End Get
        End Property
        ''' <summary>Node is not within syntax tree</summary>
        Friend Shared ReadOnly Property [NodeIsNotWithinSyntaxTree] As String
          Get
            Return GetResourceString("NodeIsNotWithinSyntaxTree")
          End Get
        End Property
        ''' <summary>Can't reference compilation of type '{0}' from {1} compilation.</summary>
        Friend Shared ReadOnly Property [CantReferenceCompilationFromTypes] As String
          Get
            Return GetResourceString("CantReferenceCompilationFromTypes")
          End Get
        End Property
        ''' <summary>position of type parameter too large</summary>
        Friend Shared ReadOnly Property [PositionOfTypeParameterTooLarge] As String
          Get
            Return GetResourceString("PositionOfTypeParameterTooLarge")
          End Get
        End Property
        ''' <summary>Associated type does not have type parameters</summary>
        Friend Shared ReadOnly Property [AssociatedTypeDoesNotHaveTypeParameters] As String
          Get
            Return GetResourceString("AssociatedTypeDoesNotHaveTypeParameters")
          End Get
        End Property
        ''' <summary>function return type</summary>
        Friend Shared ReadOnly Property [IDS_FunctionReturnType] As String
          Get
            Return GetResourceString("IDS_FunctionReturnType")
          End Get
        End Property
        ''' <summary>Type argument cannot be Nothing</summary>
        Friend Shared ReadOnly Property [TypeArgumentCannotBeNothing] As String
          Get
            Return GetResourceString("TypeArgumentCannotBeNothing")
          End Get
        End Property
        ''' <summary>Wrong number of type arguments</summary>
        Friend Shared ReadOnly Property [WrongNumberOfTypeArguments] As String
          Get
            Return GetResourceString("WrongNumberOfTypeArguments")
          End Get
        End Property
        ''' <summary>file '{0}' could not be found</summary>
        Friend Shared ReadOnly Property [ERR_FileNotFound] As String
          Get
            Return GetResourceString("ERR_FileNotFound")
          End Get
        End Property
        ''' <summary>unable to open response file '{0}'</summary>
        Friend Shared ReadOnly Property [ERR_NoResponseFile] As String
          Get
            Return GetResourceString("ERR_NoResponseFile")
          End Get
        End Property
        ''' <summary>option '{0}' requires '{1}'</summary>
        Friend Shared ReadOnly Property [ERR_ArgumentRequired] As String
          Get
            Return GetResourceString("ERR_ArgumentRequired")
          End Get
        End Property
        ''' <summary>option '{0}' can be followed only by '+' or '-'</summary>
        Friend Shared ReadOnly Property [ERR_SwitchNeedsBool] As String
          Get
            Return GetResourceString("ERR_SwitchNeedsBool")
          End Get
        End Property
        ''' <summary>the value '{1}' is invalid for option '{0}'</summary>
        Friend Shared ReadOnly Property [ERR_InvalidSwitchValue] As String
          Get
            Return GetResourceString("ERR_InvalidSwitchValue")
          End Get
        End Property
        ''' <summary>Compilation options '{0}' and '{1}' can't both be specified at the same time.</summary>
        Friend Shared ReadOnly Property [ERR_MutuallyExclusiveOptions] As String
          Get
            Return GetResourceString("ERR_MutuallyExclusiveOptions")
          End Get
        End Property
        ''' <summary>The language name '{0}' is invalid.</summary>
        Friend Shared ReadOnly Property [WRN_BadUILang] As String
          Get
            Return GetResourceString("WRN_BadUILang")
          End Get
        End Property
        ''' <summary>The language name for /preferreduilang is invalid</summary>
        Friend Shared ReadOnly Property [WRN_BadUILang_Title] As String
          Get
            Return GetResourceString("WRN_BadUILang_Title")
          End Get
        End Property
        ''' <summary>The options /vbruntime* and /target:module cannot be combined.</summary>
        Friend Shared ReadOnly Property [ERR_VBCoreNetModuleConflict] As String
          Get
            Return GetResourceString("ERR_VBCoreNetModuleConflict")
          End Get
        End Property
        ''' <summary>Command-line syntax error: Invalid Guid format '{0}' for option '{1}'</summary>
        Friend Shared ReadOnly Property [ERR_InvalidFormatForGuidForOption] As String
          Get
            Return GetResourceString("ERR_InvalidFormatForGuidForOption")
          End Get
        End Property
        ''' <summary>Command-line syntax error: Missing Guid for option '{1}'</summary>
        Friend Shared ReadOnly Property [ERR_MissingGuidForOption] As String
          Get
            Return GetResourceString("ERR_MissingGuidForOption")
          End Get
        End Property
        ''' <summary>Algorithm '{0}' is not supported</summary>
        Friend Shared ReadOnly Property [ERR_BadChecksumAlgorithm] As String
          Get
            Return GetResourceString("ERR_BadChecksumAlgorithm")
          End Get
        End Property
        ''' <summary>unrecognized option '{0}'; ignored</summary>
        Friend Shared ReadOnly Property [WRN_BadSwitch] As String
          Get
            Return GetResourceString("WRN_BadSwitch")
          End Get
        End Property
        ''' <summary>Unrecognized command-line option</summary>
        Friend Shared ReadOnly Property [WRN_BadSwitch_Title] As String
          Get
            Return GetResourceString("WRN_BadSwitch_Title")
          End Get
        End Property
        ''' <summary>no input sources specified</summary>
        Friend Shared ReadOnly Property [ERR_NoSources] As String
          Get
            Return GetResourceString("ERR_NoSources")
          End Get
        End Property
        ''' <summary>can't open '{0}' for writing: {1}</summary>
        Friend Shared ReadOnly Property [ERR_CantOpenFileWrite] As String
          Get
            Return GetResourceString("ERR_CantOpenFileWrite")
          End Get
        End Property
        ''' <summary>code page '{0}' is invalid or not installed</summary>
        Friend Shared ReadOnly Property [ERR_BadCodepage] As String
          Get
            Return GetResourceString("ERR_BadCodepage")
          End Get
        End Property
        ''' <summary>the file '{0}' is not a text file</summary>
        Friend Shared ReadOnly Property [ERR_BinaryFile] As String
          Get
            Return GetResourceString("ERR_BinaryFile")
          End Get
        End Property
        ''' <summary>could not find library '{0}'</summary>
        Friend Shared ReadOnly Property [ERR_LibNotFound] As String
          Get
            Return GetResourceString("ERR_LibNotFound")
          End Get
        End Property
        ''' <summary>Metadata references not supported.</summary>
        Friend Shared ReadOnly Property [ERR_MetadataReferencesNotSupported] As String
          Get
            Return GetResourceString("ERR_MetadataReferencesNotSupported")
          End Get
        End Property
        ''' <summary>cannot specify both /win32icon and /win32resource</summary>
        Friend Shared ReadOnly Property [ERR_IconFileAndWin32ResFile] As String
          Get
            Return GetResourceString("ERR_IconFileAndWin32ResFile")
          End Get
        End Property
        ''' <summary>ignoring /noconfig option because it was specified in a response file</summary>
        Friend Shared ReadOnly Property [WRN_NoConfigInResponseFile] As String
          Get
            Return GetResourceString("WRN_NoConfigInResponseFile")
          End Get
        End Property
        ''' <summary>Ignoring /noconfig option because it was specified in a response file</summary>
        Friend Shared ReadOnly Property [WRN_NoConfigInResponseFile_Title] As String
          Get
            Return GetResourceString("WRN_NoConfigInResponseFile_Title")
          End Get
        End Property
        ''' <summary>cannot infer an output file name from resource only input files; provide the '/out' option</summary>
        Friend Shared ReadOnly Property [ERR_NoSourcesOut] As String
          Get
            Return GetResourceString("ERR_NoSourcesOut")
          End Get
        End Property
        ''' <summary>the /moduleassemblyname option may only be specified when building a target of type 'module'</summary>
        Friend Shared ReadOnly Property [ERR_NeedModule] As String
          Get
            Return GetResourceString("ERR_NeedModule")
          End Get
        End Property
        ''' <summary>'{0}' is not a valid value for /moduleassemblyname</summary>
        Friend Shared ReadOnly Property [ERR_InvalidAssemblyName] As String
          Get
            Return GetResourceString("ERR_InvalidAssemblyName")
          End Get
        End Property
        ''' <summary>Error embedding Win32 manifest: Option /win32manifest conflicts with /nowin32manifest.</summary>
        Friend Shared ReadOnly Property [ERR_ConflictingManifestSwitches] As String
          Get
            Return GetResourceString("ERR_ConflictingManifestSwitches")
          End Get
        End Property
        ''' <summary>Option /win32manifest ignored. It can be specified only when the target is an assembly.</summary>
        Friend Shared ReadOnly Property [WRN_IgnoreModuleManifest] As String
          Get
            Return GetResourceString("WRN_IgnoreModuleManifest")
          End Get
        End Property
        ''' <summary>Option /win32manifest ignored</summary>
        Friend Shared ReadOnly Property [WRN_IgnoreModuleManifest_Title] As String
          Get
            Return GetResourceString("WRN_IgnoreModuleManifest_Title")
          End Get
        End Property
        ''' <summary>File name '{0}' is empty, contains invalid characters, has a drive specification without an absolute path, or is too long</summary>
        Friend Shared ReadOnly Property [FTL_InvalidInputFileName] As String
          Get
            Return GetResourceString("FTL_InvalidInputFileName")
          End Get
        End Property
        ''' <summary>Statement is not valid in a namespace.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidInNamespace] As String
          Get
            Return GetResourceString("ERR_InvalidInNamespace")
          End Get
        End Property
        ''' <summary>Type '{0}' is not defined.</summary>
        Friend Shared ReadOnly Property [ERR_UndefinedType1] As String
          Get
            Return GetResourceString("ERR_UndefinedType1")
          End Get
        End Property
        ''' <summary>'Next' expected.</summary>
        Friend Shared ReadOnly Property [ERR_MissingNext] As String
          Get
            Return GetResourceString("ERR_MissingNext")
          End Get
        End Property
        ''' <summary>Character constant must contain exactly one character.</summary>
        Friend Shared ReadOnly Property [ERR_IllegalCharConstant] As String
          Get
            Return GetResourceString("ERR_IllegalCharConstant")
          End Get
        End Property
        ''' <summary>Reference required to assembly '{0}' containing the definition for event '{1}'. Add one to your project.</summary>
        Friend Shared ReadOnly Property [ERR_UnreferencedAssemblyEvent3] As String
          Get
            Return GetResourceString("ERR_UnreferencedAssemblyEvent3")
          End Get
        End Property
        ''' <summary>Reference required to module '{0}' containing the definition for event '{1}'. Add one to your project.</summary>
        Friend Shared ReadOnly Property [ERR_UnreferencedModuleEvent3] As String
          Get
            Return GetResourceString("ERR_UnreferencedModuleEvent3")
          End Get
        End Property
        ''' <summary>'#If' block must end with a matching '#End If'.</summary>
        Friend Shared ReadOnly Property [ERR_LbExpectedEndIf] As String
          Get
            Return GetResourceString("ERR_LbExpectedEndIf")
          End Get
        End Property
        ''' <summary>'#ElseIf', '#Else', or '#End If' must be preceded by a matching '#If'.</summary>
        Friend Shared ReadOnly Property [ERR_LbNoMatchingIf] As String
          Get
            Return GetResourceString("ERR_LbNoMatchingIf")
          End Get
        End Property
        ''' <summary>'#ElseIf' must be preceded by a matching '#If' or '#ElseIf'.</summary>
        Friend Shared ReadOnly Property [ERR_LbBadElseif] As String
          Get
            Return GetResourceString("ERR_LbBadElseif")
          End Get
        End Property
        ''' <summary>Inheriting from '{0}' is not valid.</summary>
        Friend Shared ReadOnly Property [ERR_InheritsFromRestrictedType1] As String
          Get
            Return GetResourceString("ERR_InheritsFromRestrictedType1")
          End Get
        End Property
        ''' <summary>Labels are not valid outside methods.</summary>
        Friend Shared ReadOnly Property [ERR_InvOutsideProc] As String
          Get
            Return GetResourceString("ERR_InvOutsideProc")
          End Get
        End Property
        ''' <summary>Delegates cannot implement interface methods.</summary>
        Friend Shared ReadOnly Property [ERR_DelegateCantImplement] As String
          Get
            Return GetResourceString("ERR_DelegateCantImplement")
          End Get
        End Property
        ''' <summary>Delegates cannot handle events.</summary>
        Friend Shared ReadOnly Property [ERR_DelegateCantHandleEvents] As String
          Get
            Return GetResourceString("ERR_DelegateCantHandleEvents")
          End Get
        End Property
        ''' <summary>'Is' operator does not accept operands of type '{0}'. Operands must be reference or nullable types.</summary>
        Friend Shared ReadOnly Property [ERR_IsOperatorRequiresReferenceTypes1] As String
          Get
            Return GetResourceString("ERR_IsOperatorRequiresReferenceTypes1")
          End Get
        End Property
        ''' <summary>'TypeOf ... Is' requires its left operand to have a reference type, but this operand has the value type '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_TypeOfRequiresReferenceType1] As String
          Get
            Return GetResourceString("ERR_TypeOfRequiresReferenceType1")
          End Get
        End Property
        ''' <summary>Properties declared 'ReadOnly' cannot have a 'Set'.</summary>
        Friend Shared ReadOnly Property [ERR_ReadOnlyHasSet] As String
          Get
            Return GetResourceString("ERR_ReadOnlyHasSet")
          End Get
        End Property
        ''' <summary>Properties declared 'WriteOnly' cannot have a 'Get'.</summary>
        Friend Shared ReadOnly Property [ERR_WriteOnlyHasGet] As String
          Get
            Return GetResourceString("ERR_WriteOnlyHasGet")
          End Get
        End Property
        ''' <summary>Statement is not valid inside a method.</summary>
        Friend Shared ReadOnly Property [ERR_InvInsideProc] As String
          Get
            Return GetResourceString("ERR_InvInsideProc")
          End Get
        End Property
        ''' <summary>Statement is not valid inside '{0}' block.</summary>
        Friend Shared ReadOnly Property [ERR_InvInsideBlock] As String
          Get
            Return GetResourceString("ERR_InvInsideBlock")
          End Get
        End Property
        ''' <summary>Expression statement is only allowed at the end of an interactive submission.</summary>
        Friend Shared ReadOnly Property [ERR_UnexpectedExpressionStatement] As String
          Get
            Return GetResourceString("ERR_UnexpectedExpressionStatement")
          End Get
        End Property
        ''' <summary>Property missing 'End Property'.</summary>
        Friend Shared ReadOnly Property [ERR_EndProp] As String
          Get
            Return GetResourceString("ERR_EndProp")
          End Get
        End Property
        ''' <summary>'End Sub' expected.</summary>
        Friend Shared ReadOnly Property [ERR_EndSubExpected] As String
          Get
            Return GetResourceString("ERR_EndSubExpected")
          End Get
        End Property
        ''' <summary>'End Function' expected.</summary>
        Friend Shared ReadOnly Property [ERR_EndFunctionExpected] As String
          Get
            Return GetResourceString("ERR_EndFunctionExpected")
          End Get
        End Property
        ''' <summary>'#Else' must be preceded by a matching '#If' or '#ElseIf'.</summary>
        Friend Shared ReadOnly Property [ERR_LbElseNoMatchingIf] As String
          Get
            Return GetResourceString("ERR_LbElseNoMatchingIf")
          End Get
        End Property
        ''' <summary>Derived classes cannot raise base class events.</summary>
        Friend Shared ReadOnly Property [ERR_CantRaiseBaseEvent] As String
          Get
            Return GetResourceString("ERR_CantRaiseBaseEvent")
          End Get
        End Property
        ''' <summary>Try must have at least one 'Catch' or a 'Finally'.</summary>
        Friend Shared ReadOnly Property [ERR_TryWithoutCatchOrFinally] As String
          Get
            Return GetResourceString("ERR_TryWithoutCatchOrFinally")
          End Get
        End Property
        ''' <summary>Events cannot have a return type.</summary>
        Friend Shared ReadOnly Property [ERR_EventsCantBeFunctions] As String
          Get
            Return GetResourceString("ERR_EventsCantBeFunctions")
          End Get
        End Property
        ''' <summary>Bracketed identifier is missing closing ']'.</summary>
        Friend Shared ReadOnly Property [ERR_MissingEndBrack] As String
          Get
            Return GetResourceString("ERR_MissingEndBrack")
          End Get
        End Property
        ''' <summary>Syntax error.</summary>
        Friend Shared ReadOnly Property [ERR_Syntax] As String
          Get
            Return GetResourceString("ERR_Syntax")
          End Get
        End Property
        ''' <summary>Overflow.</summary>
        Friend Shared ReadOnly Property [ERR_Overflow] As String
          Get
            Return GetResourceString("ERR_Overflow")
          End Get
        End Property
        ''' <summary>Character is not valid.</summary>
        Friend Shared ReadOnly Property [ERR_IllegalChar] As String
          Get
            Return GetResourceString("ERR_IllegalChar")
          End Get
        End Property
        ''' <summary>Option Strict On prohibits operands of type Object for operator '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_StrictDisallowsObjectOperand1] As String
          Get
            Return GetResourceString("ERR_StrictDisallowsObjectOperand1")
          End Get
        End Property
        ''' <summary>Loop control variable cannot be a property or a late-bound indexed array.</summary>
        Friend Shared ReadOnly Property [ERR_LoopControlMustNotBeProperty] As String
          Get
            Return GetResourceString("ERR_LoopControlMustNotBeProperty")
          End Get
        End Property
        ''' <summary>First statement of a method body cannot be on the same line as the method declaration.</summary>
        Friend Shared ReadOnly Property [ERR_MethodBodyNotAtLineStart] As String
          Get
            Return GetResourceString("ERR_MethodBodyNotAtLineStart")
          End Get
        End Property
        ''' <summary>Maximum number of errors has been exceeded.</summary>
        Friend Shared ReadOnly Property [ERR_MaximumNumberOfErrors] As String
          Get
            Return GetResourceString("ERR_MaximumNumberOfErrors")
          End Get
        End Property
        ''' <summary>'{0}' is valid only within an instance method.</summary>
        Friend Shared ReadOnly Property [ERR_UseOfKeywordNotInInstanceMethod1] As String
          Get
            Return GetResourceString("ERR_UseOfKeywordNotInInstanceMethod1")
          End Get
        End Property
        ''' <summary>'{0}' is not valid within a structure.</summary>
        Friend Shared ReadOnly Property [ERR_UseOfKeywordFromStructure1] As String
          Get
            Return GetResourceString("ERR_UseOfKeywordFromStructure1")
          End Get
        End Property
        ''' <summary>Attribute constructor has a parameter of type '{0}', which is not an integral, floating-point or Enum type or one of Object, Char, String, Boolean, System.Type or 1-dimensional array of these types.</summary>
        Friend Shared ReadOnly Property [ERR_BadAttributeConstructor1] As String
          Get
            Return GetResourceString("ERR_BadAttributeConstructor1")
          End Get
        End Property
        ''' <summary>Method cannot have both a ParamArray and Optional parameters.</summary>
        Friend Shared ReadOnly Property [ERR_ParamArrayWithOptArgs] As String
          Get
            Return GetResourceString("ERR_ParamArrayWithOptArgs")
          End Get
        End Property
        ''' <summary>'{0}' statement requires an array.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedArray1] As String
          Get
            Return GetResourceString("ERR_ExpectedArray1")
          End Get
        End Property
        ''' <summary>ParamArray parameter must be an array.</summary>
        Friend Shared ReadOnly Property [ERR_ParamArrayNotArray] As String
          Get
            Return GetResourceString("ERR_ParamArrayNotArray")
          End Get
        End Property
        ''' <summary>ParamArray parameter must be a one-dimensional array.</summary>
        Friend Shared ReadOnly Property [ERR_ParamArrayRank] As String
          Get
            Return GetResourceString("ERR_ParamArrayRank")
          End Get
        End Property
        ''' <summary>Array exceeds the limit of 32 dimensions.</summary>
        Friend Shared ReadOnly Property [ERR_ArrayRankLimit] As String
          Get
            Return GetResourceString("ERR_ArrayRankLimit")
          End Get
        End Property
        ''' <summary>Arrays cannot be declared with 'New'.</summary>
        Friend Shared ReadOnly Property [ERR_AsNewArray] As String
          Get
            Return GetResourceString("ERR_AsNewArray")
          End Get
        End Property
        ''' <summary>Too many arguments to '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_TooManyArgs1] As String
          Get
            Return GetResourceString("ERR_TooManyArgs1")
          End Get
        End Property
        ''' <summary>Statements and labels are not valid between 'Select Case' and first 'Case'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedCase] As String
          Get
            Return GetResourceString("ERR_ExpectedCase")
          End Get
        End Property
        ''' <summary>Constant expression is required.</summary>
        Friend Shared ReadOnly Property [ERR_RequiredConstExpr] As String
          Get
            Return GetResourceString("ERR_RequiredConstExpr")
          End Get
        End Property
        ''' <summary>Conversion from '{0}' to '{1}' cannot occur in a constant expression.</summary>
        Friend Shared ReadOnly Property [ERR_RequiredConstConversion2] As String
          Get
            Return GetResourceString("ERR_RequiredConstConversion2")
          End Get
        End Property
        ''' <summary>'Me' cannot be the target of an assignment.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidMe] As String
          Get
            Return GetResourceString("ERR_InvalidMe")
          End Get
        End Property
        ''' <summary>'ReadOnly' variable cannot be the target of an assignment.</summary>
        Friend Shared ReadOnly Property [ERR_ReadOnlyAssignment] As String
          Get
            Return GetResourceString("ERR_ReadOnlyAssignment")
          End Get
        End Property
        ''' <summary>'Exit Sub' is not valid in a Function or Property.</summary>
        Friend Shared ReadOnly Property [ERR_ExitSubOfFunc] As String
          Get
            Return GetResourceString("ERR_ExitSubOfFunc")
          End Get
        End Property
        ''' <summary>'Exit Property' is not valid in a Function or Sub.</summary>
        Friend Shared ReadOnly Property [ERR_ExitPropNot] As String
          Get
            Return GetResourceString("ERR_ExitPropNot")
          End Get
        End Property
        ''' <summary>'Exit Function' is not valid in a Sub or Property.</summary>
        Friend Shared ReadOnly Property [ERR_ExitFuncOfSub] As String
          Get
            Return GetResourceString("ERR_ExitFuncOfSub")
          End Get
        End Property
        ''' <summary>Expression is a value and therefore cannot be the target of an assignment.</summary>
        Friend Shared ReadOnly Property [ERR_LValueRequired] As String
          Get
            Return GetResourceString("ERR_LValueRequired")
          End Get
        End Property
        ''' <summary>For loop control variable '{0}' already in use by an enclosing For loop.</summary>
        Friend Shared ReadOnly Property [ERR_ForIndexInUse1] As String
          Get
            Return GetResourceString("ERR_ForIndexInUse1")
          End Get
        End Property
        ''' <summary>Next control variable does not match For loop control variable '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_NextForMismatch1] As String
          Get
            Return GetResourceString("ERR_NextForMismatch1")
          End Get
        End Property
        ''' <summary>'Case Else' can only appear inside a 'Select Case' statement.</summary>
        Friend Shared ReadOnly Property [ERR_CaseElseNoSelect] As String
          Get
            Return GetResourceString("ERR_CaseElseNoSelect")
          End Get
        End Property
        ''' <summary>'Case' can only appear inside a 'Select Case' statement.</summary>
        Friend Shared ReadOnly Property [ERR_CaseNoSelect] As String
          Get
            Return GetResourceString("ERR_CaseNoSelect")
          End Get
        End Property
        ''' <summary>Constant cannot be the target of an assignment.</summary>
        Friend Shared ReadOnly Property [ERR_CantAssignToConst] As String
          Get
            Return GetResourceString("ERR_CantAssignToConst")
          End Get
        End Property
        ''' <summary>Named arguments are not valid as array subscripts.</summary>
        Friend Shared ReadOnly Property [ERR_NamedSubscript] As String
          Get
            Return GetResourceString("ERR_NamedSubscript")
          End Get
        End Property
        ''' <summary>'If' must end with a matching 'End If'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEndIf] As String
          Get
            Return GetResourceString("ERR_ExpectedEndIf")
          End Get
        End Property
        ''' <summary>'While' must end with a matching 'End While'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEndWhile] As String
          Get
            Return GetResourceString("ERR_ExpectedEndWhile")
          End Get
        End Property
        ''' <summary>'Do' must end with a matching 'Loop'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedLoop] As String
          Get
            Return GetResourceString("ERR_ExpectedLoop")
          End Get
        End Property
        ''' <summary>'For' must end with a matching 'Next'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedNext] As String
          Get
            Return GetResourceString("ERR_ExpectedNext")
          End Get
        End Property
        ''' <summary>'With' must end with a matching 'End With'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEndWith] As String
          Get
            Return GetResourceString("ERR_ExpectedEndWith")
          End Get
        End Property
        ''' <summary>'Else' must be preceded by a matching 'If' or 'ElseIf'.</summary>
        Friend Shared ReadOnly Property [ERR_ElseNoMatchingIf] As String
          Get
            Return GetResourceString("ERR_ElseNoMatchingIf")
          End Get
        End Property
        ''' <summary>'End If' must be preceded by a matching 'If'.</summary>
        Friend Shared ReadOnly Property [ERR_EndIfNoMatchingIf] As String
          Get
            Return GetResourceString("ERR_EndIfNoMatchingIf")
          End Get
        End Property
        ''' <summary>'End Select' must be preceded by a matching 'Select Case'.</summary>
        Friend Shared ReadOnly Property [ERR_EndSelectNoSelect] As String
          Get
            Return GetResourceString("ERR_EndSelectNoSelect")
          End Get
        End Property
        ''' <summary>'Exit Do' can only appear inside a 'Do' statement.</summary>
        Friend Shared ReadOnly Property [ERR_ExitDoNotWithinDo] As String
          Get
            Return GetResourceString("ERR_ExitDoNotWithinDo")
          End Get
        End Property
        ''' <summary>'End While' must be preceded by a matching 'While'.</summary>
        Friend Shared ReadOnly Property [ERR_EndWhileNoWhile] As String
          Get
            Return GetResourceString("ERR_EndWhileNoWhile")
          End Get
        End Property
        ''' <summary>'Loop' must be preceded by a matching 'Do'.</summary>
        Friend Shared ReadOnly Property [ERR_LoopNoMatchingDo] As String
          Get
            Return GetResourceString("ERR_LoopNoMatchingDo")
          End Get
        End Property
        ''' <summary>'Next' must be preceded by a matching 'For'.</summary>
        Friend Shared ReadOnly Property [ERR_NextNoMatchingFor] As String
          Get
            Return GetResourceString("ERR_NextNoMatchingFor")
          End Get
        End Property
        ''' <summary>'End With' must be preceded by a matching 'With'.</summary>
        Friend Shared ReadOnly Property [ERR_EndWithWithoutWith] As String
          Get
            Return GetResourceString("ERR_EndWithWithoutWith")
          End Get
        End Property
        ''' <summary>Label '{0}' is already defined in the current method.</summary>
        Friend Shared ReadOnly Property [ERR_MultiplyDefined1] As String
          Get
            Return GetResourceString("ERR_MultiplyDefined1")
          End Get
        End Property
        ''' <summary>'Select Case' must end with a matching 'End Select'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEndSelect] As String
          Get
            Return GetResourceString("ERR_ExpectedEndSelect")
          End Get
        End Property
        ''' <summary>'Exit For' can only appear inside a 'For' statement.</summary>
        Friend Shared ReadOnly Property [ERR_ExitForNotWithinFor] As String
          Get
            Return GetResourceString("ERR_ExitForNotWithinFor")
          End Get
        End Property
        ''' <summary>'Exit While' can only appear inside a 'While' statement.</summary>
        Friend Shared ReadOnly Property [ERR_ExitWhileNotWithinWhile] As String
          Get
            Return GetResourceString("ERR_ExitWhileNotWithinWhile")
          End Get
        End Property
        ''' <summary>'ReadOnly' property '{0}' cannot be the target of an assignment.</summary>
        Friend Shared ReadOnly Property [ERR_ReadOnlyProperty1] As String
          Get
            Return GetResourceString("ERR_ReadOnlyProperty1")
          End Get
        End Property
        ''' <summary>'Exit Select' can only appear inside a 'Select' statement.</summary>
        Friend Shared ReadOnly Property [ERR_ExitSelectNotWithinSelect] As String
          Get
            Return GetResourceString("ERR_ExitSelectNotWithinSelect")
          End Get
        End Property
        ''' <summary>Branching out of a 'Finally' is not valid.</summary>
        Friend Shared ReadOnly Property [ERR_BranchOutOfFinally] As String
          Get
            Return GetResourceString("ERR_BranchOutOfFinally")
          End Get
        End Property
        ''' <summary>'!' requires its left operand to have a type parameter, class or interface type, but this operand has the type '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_QualNotObjectRecord1] As String
          Get
            Return GetResourceString("ERR_QualNotObjectRecord1")
          End Get
        End Property
        ''' <summary>Number of indices is less than the number of dimensions of the indexed array.</summary>
        Friend Shared ReadOnly Property [ERR_TooFewIndices] As String
          Get
            Return GetResourceString("ERR_TooFewIndices")
          End Get
        End Property
        ''' <summary>Number of indices exceeds the number of dimensions of the indexed array.</summary>
        Friend Shared ReadOnly Property [ERR_TooManyIndices] As String
          Get
            Return GetResourceString("ERR_TooManyIndices")
          End Get
        End Property
        ''' <summary>'{0}' is an Enum type and cannot be used as an expression.</summary>
        Friend Shared ReadOnly Property [ERR_EnumNotExpression1] As String
          Get
            Return GetResourceString("ERR_EnumNotExpression1")
          End Get
        End Property
        ''' <summary>'{0}' is a type and cannot be used as an expression.</summary>
        Friend Shared ReadOnly Property [ERR_TypeNotExpression1] As String
          Get
            Return GetResourceString("ERR_TypeNotExpression1")
          End Get
        End Property
        ''' <summary>'{0}' is a class type and cannot be used as an expression.</summary>
        Friend Shared ReadOnly Property [ERR_ClassNotExpression1] As String
          Get
            Return GetResourceString("ERR_ClassNotExpression1")
          End Get
        End Property
        ''' <summary>'{0}' is a structure type and cannot be used as an expression.</summary>
        Friend Shared ReadOnly Property [ERR_StructureNotExpression1] As String
          Get
            Return GetResourceString("ERR_StructureNotExpression1")
          End Get
        End Property
        ''' <summary>'{0}' is an interface type and cannot be used as an expression.</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceNotExpression1] As String
          Get
            Return GetResourceString("ERR_InterfaceNotExpression1")
          End Get
        End Property
        ''' <summary>'{0}' is a namespace and cannot be used as an expression.</summary>
        Friend Shared ReadOnly Property [ERR_NamespaceNotExpression1] As String
          Get
            Return GetResourceString("ERR_NamespaceNotExpression1")
          End Get
        End Property
        ''' <summary>'{0}' is not a valid name and cannot be used as the root namespace name.</summary>
        Friend Shared ReadOnly Property [ERR_BadNamespaceName1] As String
          Get
            Return GetResourceString("ERR_BadNamespaceName1")
          End Get
        End Property
        ''' <summary>'{0}' is an XML prefix and cannot be used as an expression.  Use the GetXmlNamespace operator to create a namespace object.</summary>
        Friend Shared ReadOnly Property [ERR_XmlPrefixNotExpression] As String
          Get
            Return GetResourceString("ERR_XmlPrefixNotExpression")
          End Get
        End Property
        ''' <summary>'Inherits' can appear only once within a 'Class' statement and can only specify one class.</summary>
        Friend Shared ReadOnly Property [ERR_MultipleExtends] As String
          Get
            Return GetResourceString("ERR_MultipleExtends")
          End Get
        End Property
        ''' <summary>Property without a 'ReadOnly' or 'WriteOnly' specifier must provide both a 'Get' and a 'Set'.</summary>
        Friend Shared ReadOnly Property [ERR_PropMustHaveGetSet] As String
          Get
            Return GetResourceString("ERR_PropMustHaveGetSet")
          End Get
        End Property
        ''' <summary>'WriteOnly' property must provide a 'Set'.</summary>
        Friend Shared ReadOnly Property [ERR_WriteOnlyHasNoWrite] As String
          Get
            Return GetResourceString("ERR_WriteOnlyHasNoWrite")
          End Get
        End Property
        ''' <summary>'ReadOnly' property must provide a 'Get'.</summary>
        Friend Shared ReadOnly Property [ERR_ReadOnlyHasNoGet] As String
          Get
            Return GetResourceString("ERR_ReadOnlyHasNoGet")
          End Get
        End Property
        ''' <summary>Attribute '{0}' is not valid: Incorrect argument value.</summary>
        Friend Shared ReadOnly Property [ERR_BadAttribute1] As String
          Get
            Return GetResourceString("ERR_BadAttribute1")
          End Get
        End Property
        ''' <summary>Label '{0}' is not defined.</summary>
        Friend Shared ReadOnly Property [ERR_LabelNotDefined1] As String
          Get
            Return GetResourceString("ERR_LabelNotDefined1")
          End Get
        End Property
        ''' <summary>Error creating Win32 resources: {0}</summary>
        Friend Shared ReadOnly Property [ERR_ErrorCreatingWin32ResourceFile] As String
          Get
            Return GetResourceString("ERR_ErrorCreatingWin32ResourceFile")
          End Get
        End Property
        ''' <summary>Cannot create temporary file: {0}</summary>
        Friend Shared ReadOnly Property [ERR_UnableToCreateTempFile] As String
          Get
            Return GetResourceString("ERR_UnableToCreateTempFile")
          End Get
        End Property
        ''' <summary>First statement of this 'Sub New' must be a call to 'MyBase.New' or 'MyClass.New' because base class '{0}' of '{1}' does not have an accessible 'Sub New' that can be called with no arguments.</summary>
        Friend Shared ReadOnly Property [ERR_RequiredNewCall2] As String
          Get
            Return GetResourceString("ERR_RequiredNewCall2")
          End Get
        End Property
        ''' <summary>{0} '{1}' must implement '{2}' for interface '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_UnimplementedMember3] As String
          Get
            Return GetResourceString("ERR_UnimplementedMember3")
          End Get
        End Property
        ''' <summary>Leading '.' or '!' can only appear inside a 'With' statement.</summary>
        Friend Shared ReadOnly Property [ERR_BadWithRef] As String
          Get
            Return GetResourceString("ERR_BadWithRef")
          End Get
        End Property
        ''' <summary>Only one of 'Public', 'Private', 'Protected', 'Friend', 'Protected Friend', or 'Private Protected' can be specified.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateAccessCategoryUsed] As String
          Get
            Return GetResourceString("ERR_DuplicateAccessCategoryUsed")
          End Get
        End Property
        ''' <summary>Only one of 'NotOverridable', 'MustOverride', or 'Overridable' can be specified.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateModifierCategoryUsed] As String
          Get
            Return GetResourceString("ERR_DuplicateModifierCategoryUsed")
          End Get
        End Property
        ''' <summary>Specifier is duplicated.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateSpecifier] As String
          Get
            Return GetResourceString("ERR_DuplicateSpecifier")
          End Get
        End Property
        ''' <summary>{0} '{1}' and {2} '{3}' conflict in {4} '{5}'.</summary>
        Friend Shared ReadOnly Property [ERR_TypeConflict6] As String
          Get
            Return GetResourceString("ERR_TypeConflict6")
          End Get
        End Property
        ''' <summary>Keyword does not name a type.</summary>
        Friend Shared ReadOnly Property [ERR_UnrecognizedTypeKeyword] As String
          Get
            Return GetResourceString("ERR_UnrecognizedTypeKeyword")
          End Get
        End Property
        ''' <summary>Specifiers valid only at the beginning of a declaration.</summary>
        Friend Shared ReadOnly Property [ERR_ExtraSpecifiers] As String
          Get
            Return GetResourceString("ERR_ExtraSpecifiers")
          End Get
        End Property
        ''' <summary>Type expected.</summary>
        Friend Shared ReadOnly Property [ERR_UnrecognizedType] As String
          Get
            Return GetResourceString("ERR_UnrecognizedType")
          End Get
        End Property
        ''' <summary>Keyword is not valid as an identifier.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidUseOfKeyword] As String
          Get
            Return GetResourceString("ERR_InvalidUseOfKeyword")
          End Get
        End Property
        ''' <summary>'End Enum' must be preceded by a matching 'Enum'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidEndEnum] As String
          Get
            Return GetResourceString("ERR_InvalidEndEnum")
          End Get
        End Property
        ''' <summary>'Enum' must end with a matching 'End Enum'.</summary>
        Friend Shared ReadOnly Property [ERR_MissingEndEnum] As String
          Get
            Return GetResourceString("ERR_MissingEndEnum")
          End Get
        End Property
        ''' <summary>Declaration expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedDeclaration] As String
          Get
            Return GetResourceString("ERR_ExpectedDeclaration")
          End Get
        End Property
        ''' <summary>End of parameter list expected. Cannot define parameters after a paramarray parameter.</summary>
        Friend Shared ReadOnly Property [ERR_ParamArrayMustBeLast] As String
          Get
            Return GetResourceString("ERR_ParamArrayMustBeLast")
          End Get
        End Property
        ''' <summary>Specifiers and attributes are not valid on this statement.</summary>
        Friend Shared ReadOnly Property [ERR_SpecifiersInvalidOnInheritsImplOpt] As String
          Get
            Return GetResourceString("ERR_SpecifiersInvalidOnInheritsImplOpt")
          End Get
        End Property
        ''' <summary>Expected one of 'Dim', 'Const', 'Public', 'Private', 'Protected', 'Friend', 'Shadows', 'ReadOnly' or 'Shared'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedSpecifier] As String
          Get
            Return GetResourceString("ERR_ExpectedSpecifier")
          End Get
        End Property
        ''' <summary>Comma expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedComma] As String
          Get
            Return GetResourceString("ERR_ExpectedComma")
          End Get
        End Property
        ''' <summary>'As' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedAs] As String
          Get
            Return GetResourceString("ERR_ExpectedAs")
          End Get
        End Property
        ''' <summary>')' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedRparen] As String
          Get
            Return GetResourceString("ERR_ExpectedRparen")
          End Get
        End Property
        ''' <summary>'(' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedLparen] As String
          Get
            Return GetResourceString("ERR_ExpectedLparen")
          End Get
        End Property
        ''' <summary>'New' is not valid in this context.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidNewInType] As String
          Get
            Return GetResourceString("ERR_InvalidNewInType")
          End Get
        End Property
        ''' <summary>Expression expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedExpression] As String
          Get
            Return GetResourceString("ERR_ExpectedExpression")
          End Get
        End Property
        ''' <summary>'Optional' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedOptional] As String
          Get
            Return GetResourceString("ERR_ExpectedOptional")
          End Get
        End Property
        ''' <summary>Identifier expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedIdentifier] As String
          Get
            Return GetResourceString("ERR_ExpectedIdentifier")
          End Get
        End Property
        ''' <summary>Integer constant expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedIntLiteral] As String
          Get
            Return GetResourceString("ERR_ExpectedIntLiteral")
          End Get
        End Property
        ''' <summary>End of statement expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEOS] As String
          Get
            Return GetResourceString("ERR_ExpectedEOS")
          End Get
        End Property
        ''' <summary>'Option' must be followed by 'Compare', 'Explicit', 'Infer', or 'Strict'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedForOptionStmt] As String
          Get
            Return GetResourceString("ERR_ExpectedForOptionStmt")
          End Get
        End Property
        ''' <summary>'Option Compare' must be followed by 'Text' or 'Binary'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidOptionCompare] As String
          Get
            Return GetResourceString("ERR_InvalidOptionCompare")
          End Get
        End Property
        ''' <summary>'Compare' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedOptionCompare] As String
          Get
            Return GetResourceString("ERR_ExpectedOptionCompare")
          End Get
        End Property
        ''' <summary>Option Strict On requires all variable declarations to have an 'As' clause.</summary>
        Friend Shared ReadOnly Property [ERR_StrictDisallowImplicitObject] As String
          Get
            Return GetResourceString("ERR_StrictDisallowImplicitObject")
          End Get
        End Property
        ''' <summary>Option Strict On requires all Function, Property, and Operator declarations to have an 'As' clause.</summary>
        Friend Shared ReadOnly Property [ERR_StrictDisallowsImplicitProc] As String
          Get
            Return GetResourceString("ERR_StrictDisallowsImplicitProc")
          End Get
        End Property
        ''' <summary>Option Strict On requires that all method parameters have an 'As' clause.</summary>
        Friend Shared ReadOnly Property [ERR_StrictDisallowsImplicitArgs] As String
          Get
            Return GetResourceString("ERR_StrictDisallowsImplicitArgs")
          End Get
        End Property
        ''' <summary>Comma or ')' expected.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidParameterSyntax] As String
          Get
            Return GetResourceString("ERR_InvalidParameterSyntax")
          End Get
        End Property
        ''' <summary>'Sub' or 'Function' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedSubFunction] As String
          Get
            Return GetResourceString("ERR_ExpectedSubFunction")
          End Get
        End Property
        ''' <summary>String constant expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedStringLiteral] As String
          Get
            Return GetResourceString("ERR_ExpectedStringLiteral")
          End Get
        End Property
        ''' <summary>'Lib' expected.</summary>
        Friend Shared ReadOnly Property [ERR_MissingLibInDeclare] As String
          Get
            Return GetResourceString("ERR_MissingLibInDeclare")
          End Get
        End Property
        ''' <summary>Delegate class '{0}' has no Invoke method, so an expression of this type cannot be the target of a method call.</summary>
        Friend Shared ReadOnly Property [ERR_DelegateNoInvoke1] As String
          Get
            Return GetResourceString("ERR_DelegateNoInvoke1")
          End Get
        End Property
        ''' <summary>'Is' expected.</summary>
        Friend Shared ReadOnly Property [ERR_MissingIsInTypeOf] As String
          Get
            Return GetResourceString("ERR_MissingIsInTypeOf")
          End Get
        End Property
        ''' <summary>'Option {0}' statement can only appear once per file.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateOption1] As String
          Get
            Return GetResourceString("ERR_DuplicateOption1")
          End Get
        End Property
        ''' <summary>'Inherits' not valid in Modules.</summary>
        Friend Shared ReadOnly Property [ERR_ModuleCantInherit] As String
          Get
            Return GetResourceString("ERR_ModuleCantInherit")
          End Get
        End Property
        ''' <summary>'Implements' not valid in Modules.</summary>
        Friend Shared ReadOnly Property [ERR_ModuleCantImplement] As String
          Get
            Return GetResourceString("ERR_ModuleCantImplement")
          End Get
        End Property
        ''' <summary>Implemented type must be an interface.</summary>
        Friend Shared ReadOnly Property [ERR_BadImplementsType] As String
          Get
            Return GetResourceString("ERR_BadImplementsType")
          End Get
        End Property
        ''' <summary>'{0}' is not valid on a constant declaration.</summary>
        Friend Shared ReadOnly Property [ERR_BadConstFlags1] As String
          Get
            Return GetResourceString("ERR_BadConstFlags1")
          End Get
        End Property
        ''' <summary>'{0}' is not valid on a WithEvents declaration.</summary>
        Friend Shared ReadOnly Property [ERR_BadWithEventsFlags1] As String
          Get
            Return GetResourceString("ERR_BadWithEventsFlags1")
          End Get
        End Property
        ''' <summary>'{0}' is not valid on a member variable declaration.</summary>
        Friend Shared ReadOnly Property [ERR_BadDimFlags1] As String
          Get
            Return GetResourceString("ERR_BadDimFlags1")
          End Get
        End Property
        ''' <summary>Parameter already declared with name '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateParamName1] As String
          Get
            Return GetResourceString("ERR_DuplicateParamName1")
          End Get
        End Property
        ''' <summary>'Loop' cannot have a condition if matching 'Do' has one.</summary>
        Friend Shared ReadOnly Property [ERR_LoopDoubleCondition] As String
          Get
            Return GetResourceString("ERR_LoopDoubleCondition")
          End Get
        End Property
        ''' <summary>Relational operator expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedRelational] As String
          Get
            Return GetResourceString("ERR_ExpectedRelational")
          End Get
        End Property
        ''' <summary>'Exit' must be followed by 'Sub', 'Function', 'Property', 'Do', 'For', 'While', 'Select', or 'Try'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedExitKind] As String
          Get
            Return GetResourceString("ERR_ExpectedExitKind")
          End Get
        End Property
        ''' <summary>Named argument expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedNamedArgumentInAttributeList] As String
          Get
            Return GetResourceString("ERR_ExpectedNamedArgumentInAttributeList")
          End Get
        End Property
        ''' <summary>Named argument specifications must appear after all fixed arguments have been specified in a late bound invocation.</summary>
        Friend Shared ReadOnly Property [ERR_NamedArgumentSpecificationBeforeFixedArgumentInLateboundInvocation] As String
          Get
            Return GetResourceString("ERR_NamedArgumentSpecificationBeforeFixedArgumentInLateboundInvocation")
          End Get
        End Property
        ''' <summary>Named argument expected. Please use language version {0} or greater to use non-trailing named arguments.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedNamedArgument] As String
          Get
            Return GetResourceString("ERR_ExpectedNamedArgument")
          End Get
        End Property
        ''' <summary>'{0}' is not valid on a method declaration.</summary>
        Friend Shared ReadOnly Property [ERR_BadMethodFlags1] As String
          Get
            Return GetResourceString("ERR_BadMethodFlags1")
          End Get
        End Property
        ''' <summary>'{0}' is not valid on an event declaration.</summary>
        Friend Shared ReadOnly Property [ERR_BadEventFlags1] As String
          Get
            Return GetResourceString("ERR_BadEventFlags1")
          End Get
        End Property
        ''' <summary>'{0}' is not valid on a Declare.</summary>
        Friend Shared ReadOnly Property [ERR_BadDeclareFlags1] As String
          Get
            Return GetResourceString("ERR_BadDeclareFlags1")
          End Get
        End Property
        ''' <summary>'{0}' is not valid on a local constant declaration.</summary>
        Friend Shared ReadOnly Property [ERR_BadLocalConstFlags1] As String
          Get
            Return GetResourceString("ERR_BadLocalConstFlags1")
          End Get
        End Property
        ''' <summary>'{0}' is not valid on a local variable declaration.</summary>
        Friend Shared ReadOnly Property [ERR_BadLocalDimFlags1] As String
          Get
            Return GetResourceString("ERR_BadLocalDimFlags1")
          End Get
        End Property
        ''' <summary>'If', 'ElseIf', 'Else', 'Const', 'Region', 'ExternalSource', 'ExternalChecksum', 'Enable', 'Disable', 'End' or 'R' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedConditionalDirective] As String
          Get
            Return GetResourceString("ERR_ExpectedConditionalDirective")
          End Get
        End Property
        ''' <summary>'=' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEQ] As String
          Get
            Return GetResourceString("ERR_ExpectedEQ")
          End Get
        End Property
        ''' <summary>Type '{0}' has no constructors.</summary>
        Friend Shared ReadOnly Property [ERR_ConstructorNotFound1] As String
          Get
            Return GetResourceString("ERR_ConstructorNotFound1")
          End Get
        End Property
        ''' <summary>'End Interface' must be preceded by a matching 'Interface'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidEndInterface] As String
          Get
            Return GetResourceString("ERR_InvalidEndInterface")
          End Get
        End Property
        ''' <summary>'Interface' must end with a matching 'End Interface'.</summary>
        Friend Shared ReadOnly Property [ERR_MissingEndInterface] As String
          Get
            Return GetResourceString("ERR_MissingEndInterface")
          End Get
        End Property
        ''' <summary>'{0}' inherits from '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_InheritsFrom2] As String
          Get
            Return GetResourceString("ERR_InheritsFrom2")
          End Get
        End Property
        ''' <summary>'{0}' is nested in '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_IsNestedIn2] As String
          Get
            Return GetResourceString("ERR_IsNestedIn2")
          End Get
        End Property
        ''' <summary>Class '{0}' cannot inherit from itself: {1}</summary>
        Friend Shared ReadOnly Property [ERR_InheritanceCycle1] As String
          Get
            Return GetResourceString("ERR_InheritanceCycle1")
          End Get
        End Property
        ''' <summary>Classes can inherit only from other classes.</summary>
        Friend Shared ReadOnly Property [ERR_InheritsFromNonClass] As String
          Get
            Return GetResourceString("ERR_InheritsFromNonClass")
          End Get
        End Property
        ''' <summary>'{0}' is already declared as '{1}' in this {2}.</summary>
        Friend Shared ReadOnly Property [ERR_MultiplyDefinedType3] As String
          Get
            Return GetResourceString("ERR_MultiplyDefinedType3")
          End Get
        End Property
        ''' <summary>'{0}' cannot override '{1}' because they have different access levels.</summary>
        Friend Shared ReadOnly Property [ERR_BadOverrideAccess2] As String
          Get
            Return GetResourceString("ERR_BadOverrideAccess2")
          End Get
        End Property
        ''' <summary>'{0}' cannot override '{1}' because it is declared 'NotOverridable'.</summary>
        Friend Shared ReadOnly Property [ERR_CantOverrideNotOverridable2] As String
          Get
            Return GetResourceString("ERR_CantOverrideNotOverridable2")
          End Get
        End Property
        ''' <summary>'{0}' has multiple definitions with identical signatures.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateProcDef1] As String
          Get
            Return GetResourceString("ERR_DuplicateProcDef1")
          End Get
        End Property
        ''' <summary>'{0}' has multiple definitions with identical signatures with different tuple element names, including '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateProcDefWithDifferentTupleNames2] As String
          Get
            Return GetResourceString("ERR_DuplicateProcDefWithDifferentTupleNames2")
          End Get
        End Property
        ''' <summary>'{0}' is not valid on an interface method declaration.</summary>
        Friend Shared ReadOnly Property [ERR_BadInterfaceMethodFlags1] As String
          Get
            Return GetResourceString("ERR_BadInterfaceMethodFlags1")
          End Get
        End Property
        ''' <summary>'{0}' is not a parameter of '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_NamedParamNotFound2] As String
          Get
            Return GetResourceString("ERR_NamedParamNotFound2")
          End Get
        End Property
        ''' <summary>'{0}' is not valid on an interface property declaration.</summary>
        Friend Shared ReadOnly Property [ERR_BadInterfacePropertyFlags1] As String
          Get
            Return GetResourceString("ERR_BadInterfacePropertyFlags1")
          End Get
        End Property
        ''' <summary>Parameter '{0}' of '{1}' already has a matching argument.</summary>
        Friend Shared ReadOnly Property [ERR_NamedArgUsedTwice2] As String
          Get
            Return GetResourceString("ERR_NamedArgUsedTwice2")
          End Get
        End Property
        ''' <summary>'{0}' is not valid on an interface event declaration.</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceCantUseEventSpecifier1] As String
          Get
            Return GetResourceString("ERR_InterfaceCantUseEventSpecifier1")
          End Get
        End Property
        ''' <summary>Type character '{0}' does not match declared data type '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_TypecharNoMatch2] As String
          Get
            Return GetResourceString("ERR_TypecharNoMatch2")
          End Get
        End Property
        ''' <summary>'Sub' or 'Function' expected after 'Delegate'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedSubOrFunction] As String
          Get
            Return GetResourceString("ERR_ExpectedSubOrFunction")
          End Get
        End Property
        ''' <summary>Enum '{0}' must contain at least one member.</summary>
        Friend Shared ReadOnly Property [ERR_BadEmptyEnum1] As String
          Get
            Return GetResourceString("ERR_BadEmptyEnum1")
          End Get
        End Property
        ''' <summary>Constructor call is valid only as the first statement in an instance constructor.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidConstructorCall] As String
          Get
            Return GetResourceString("ERR_InvalidConstructorCall")
          End Get
        End Property
        ''' <summary>'Sub New' cannot be declared 'Overrides'.</summary>
        Friend Shared ReadOnly Property [ERR_CantOverrideConstructor] As String
          Get
            Return GetResourceString("ERR_CantOverrideConstructor")
          End Get
        End Property
        ''' <summary>'Sub New' cannot be declared 'Partial'.</summary>
        Friend Shared ReadOnly Property [ERR_ConstructorCannotBeDeclaredPartial] As String
          Get
            Return GetResourceString("ERR_ConstructorCannotBeDeclaredPartial")
          End Get
        End Property
        ''' <summary>Failed to emit module '{0}': {1}</summary>
        Friend Shared ReadOnly Property [ERR_ModuleEmitFailure] As String
          Get
            Return GetResourceString("ERR_ModuleEmitFailure")
          End Get
        End Property
        ''' <summary>Cannot update '{0}'; attribute '{1}' is missing.</summary>
        Friend Shared ReadOnly Property [ERR_EncUpdateFailedMissingSymbol] As String
          Get
            Return GetResourceString("ERR_EncUpdateFailedMissingSymbol")
          End Get
        End Property
        ''' <summary>{0} '{1}' cannot be declared 'Overrides' because it does not override a {0} in a base class.</summary>
        Friend Shared ReadOnly Property [ERR_OverrideNotNeeded3] As String
          Get
            Return GetResourceString("ERR_OverrideNotNeeded3")
          End Get
        End Property
        ''' <summary>'.' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedDot] As String
          Get
            Return GetResourceString("ERR_ExpectedDot")
          End Get
        End Property
        ''' <summary>Local variable '{0}' is already declared in the current block.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateLocals1] As String
          Get
            Return GetResourceString("ERR_DuplicateLocals1")
          End Get
        End Property
        ''' <summary>Statement cannot appear within a method body. End of method assumed.</summary>
        Friend Shared ReadOnly Property [ERR_InvInsideEndsProc] As String
          Get
            Return GetResourceString("ERR_InvInsideEndsProc")
          End Get
        End Property
        ''' <summary>Local variable cannot have the same name as the function containing it.</summary>
        Friend Shared ReadOnly Property [ERR_LocalSameAsFunc] As String
          Get
            Return GetResourceString("ERR_LocalSameAsFunc")
          End Get
        End Property
        ''' <summary>'{0}' contains '{1}' (variable '{2}').</summary>
        Friend Shared ReadOnly Property [ERR_RecordEmbeds2] As String
          Get
            Return GetResourceString("ERR_RecordEmbeds2")
          End Get
        End Property
        ''' <summary>Structure '{0}' cannot contain an instance of itself: {1}</summary>
        Friend Shared ReadOnly Property [ERR_RecordCycle2] As String
          Get
            Return GetResourceString("ERR_RecordCycle2")
          End Get
        End Property
        ''' <summary>Interface '{0}' cannot inherit from itself: {1}</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceCycle1] As String
          Get
            Return GetResourceString("ERR_InterfaceCycle1")
          End Get
        End Property
        ''' <summary>'{0}' calls '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_SubNewCycle2] As String
          Get
            Return GetResourceString("ERR_SubNewCycle2")
          End Get
        End Property
        ''' <summary>Constructor '{0}' cannot call itself: {1}</summary>
        Friend Shared ReadOnly Property [ERR_SubNewCycle1] As String
          Get
            Return GetResourceString("ERR_SubNewCycle1")
          End Get
        End Property
        ''' <summary>'{0}' cannot inherit from {2} '{1}' because '{1}' is declared 'NotInheritable'.</summary>
        Friend Shared ReadOnly Property [ERR_InheritsFromCantInherit3] As String
          Get
            Return GetResourceString("ERR_InheritsFromCantInherit3")
          End Get
        End Property
        ''' <summary>'{0}' and '{1}' cannot overload each other because they differ only by optional parameters.</summary>
        Friend Shared ReadOnly Property [ERR_OverloadWithOptional2] As String
          Get
            Return GetResourceString("ERR_OverloadWithOptional2")
          End Get
        End Property
        ''' <summary>'{0}' and '{1}' cannot overload each other because they differ only by return types.</summary>
        Friend Shared ReadOnly Property [ERR_OverloadWithReturnType2] As String
          Get
            Return GetResourceString("ERR_OverloadWithReturnType2")
          End Get
        End Property
        ''' <summary>Type character '{0}' cannot be used in a declaration with an explicit type.</summary>
        Friend Shared ReadOnly Property [ERR_TypeCharWithType1] As String
          Get
            Return GetResourceString("ERR_TypeCharWithType1")
          End Get
        End Property
        ''' <summary>Type character cannot be used in a 'Sub' declaration because a 'Sub' doesn't return a value.</summary>
        Friend Shared ReadOnly Property [ERR_TypeCharOnSub] As String
          Get
            Return GetResourceString("ERR_TypeCharOnSub")
          End Get
        End Property
        ''' <summary>'{0}' and '{1}' cannot overload each other because they differ only by the default values of optional parameters.</summary>
        Friend Shared ReadOnly Property [ERR_OverloadWithDefault2] As String
          Get
            Return GetResourceString("ERR_OverloadWithDefault2")
          End Get
        End Property
        ''' <summary>Array subscript expression missing.</summary>
        Friend Shared ReadOnly Property [ERR_MissingSubscript] As String
          Get
            Return GetResourceString("ERR_MissingSubscript")
          End Get
        End Property
        ''' <summary>'{0}' cannot override '{1}' because they differ by the default values of optional parameters.</summary>
        Friend Shared ReadOnly Property [ERR_OverrideWithDefault2] As String
          Get
            Return GetResourceString("ERR_OverrideWithDefault2")
          End Get
        End Property
        ''' <summary>'{0}' cannot override '{1}' because they differ by optional parameters.</summary>
        Friend Shared ReadOnly Property [ERR_OverrideWithOptional2] As String
          Get
            Return GetResourceString("ERR_OverrideWithOptional2")
          End Get
        End Property
        ''' <summary>Cannot refer to '{0}' because it is a member of the value-typed field '{1}' of class '{2}' which has 'System.MarshalByRefObject' as a base class.</summary>
        Friend Shared ReadOnly Property [ERR_FieldOfValueFieldOfMarshalByRef3] As String
          Get
            Return GetResourceString("ERR_FieldOfValueFieldOfMarshalByRef3")
          End Get
        End Property
        ''' <summary>Value of type '{0}' cannot be converted to '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_TypeMismatch2] As String
          Get
            Return GetResourceString("ERR_TypeMismatch2")
          End Get
        End Property
        ''' <summary>'Case' cannot follow a 'Case Else' in the same 'Select' statement.</summary>
        Friend Shared ReadOnly Property [ERR_CaseAfterCaseElse] As String
          Get
            Return GetResourceString("ERR_CaseAfterCaseElse")
          End Get
        End Property
        ''' <summary>Value of type '{0}' cannot be converted to '{1}' because '{2}' is not derived from '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_ConvertArrayMismatch4] As String
          Get
            Return GetResourceString("ERR_ConvertArrayMismatch4")
          End Get
        End Property
        ''' <summary>Value of type '{0}' cannot be converted to '{1}' because '{2}' is not a reference type.</summary>
        Friend Shared ReadOnly Property [ERR_ConvertObjectArrayMismatch3] As String
          Get
            Return GetResourceString("ERR_ConvertObjectArrayMismatch3")
          End Get
        End Property
        ''' <summary>'For' loop control variable cannot be of type '{0}' because the type does not support the required operators.</summary>
        Friend Shared ReadOnly Property [ERR_ForLoopType1] As String
          Get
            Return GetResourceString("ERR_ForLoopType1")
          End Get
        End Property
        ''' <summary>'{0}' and '{1}' cannot overload each other because they differ only by parameters declared 'ByRef' or 'ByVal'.</summary>
        Friend Shared ReadOnly Property [ERR_OverloadWithByref2] As String
          Get
            Return GetResourceString("ERR_OverloadWithByref2")
          End Get
        End Property
        ''' <summary>Interface can inherit only from another interface.</summary>
        Friend Shared ReadOnly Property [ERR_InheritsFromNonInterface] As String
          Get
            Return GetResourceString("ERR_InheritsFromNonInterface")
          End Get
        End Property
        ''' <summary>'Inherits' statements must precede all declarations in an interface.</summary>
        Friend Shared ReadOnly Property [ERR_BadInterfaceOrderOnInherits] As String
          Get
            Return GetResourceString("ERR_BadInterfaceOrderOnInherits")
          End Get
        End Property
        ''' <summary>'Default' can be applied to only one property name in a {0}.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateDefaultProps1] As String
          Get
            Return GetResourceString("ERR_DuplicateDefaultProps1")
          End Get
        End Property
        ''' <summary>'{0}' and '{1}' cannot overload each other because only one is declared 'Default'.</summary>
        Friend Shared ReadOnly Property [ERR_DefaultMissingFromProperty2] As String
          Get
            Return GetResourceString("ERR_DefaultMissingFromProperty2")
          End Get
        End Property
        ''' <summary>'{0}' cannot override '{1}' because they differ by 'ReadOnly' or 'WriteOnly'.</summary>
        Friend Shared ReadOnly Property [ERR_OverridingPropertyKind2] As String
          Get
            Return GetResourceString("ERR_OverridingPropertyKind2")
          End Get
        End Property
        ''' <summary>'Sub New' cannot be declared in an interface.</summary>
        Friend Shared ReadOnly Property [ERR_NewInInterface] As String
          Get
            Return GetResourceString("ERR_NewInInterface")
          End Get
        End Property
        ''' <summary>'Sub New' cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadFlagsOnNew1] As String
          Get
            Return GetResourceString("ERR_BadFlagsOnNew1")
          End Get
        End Property
        ''' <summary>'{0}' and '{1}' cannot overload each other because they differ only by 'ReadOnly' or 'WriteOnly'.</summary>
        Friend Shared ReadOnly Property [ERR_OverloadingPropertyKind2] As String
          Get
            Return GetResourceString("ERR_OverloadingPropertyKind2")
          End Get
        End Property
        ''' <summary>Class '{0}' cannot be indexed because it has no default property.</summary>
        Friend Shared ReadOnly Property [ERR_NoDefaultNotExtend1] As String
          Get
            Return GetResourceString("ERR_NoDefaultNotExtend1")
          End Get
        End Property
        ''' <summary>'{0}' and '{1}' cannot overload each other because they differ only by parameters declared 'ParamArray'.</summary>
        Friend Shared ReadOnly Property [ERR_OverloadWithArrayVsParamArray2] As String
          Get
            Return GetResourceString("ERR_OverloadWithArrayVsParamArray2")
          End Get
        End Property
        ''' <summary>Cannot refer to an instance member of a class from within a shared method or shared member initializer without an explicit instance of the class.</summary>
        Friend Shared ReadOnly Property [ERR_BadInstanceMemberAccess] As String
          Get
            Return GetResourceString("ERR_BadInstanceMemberAccess")
          End Get
        End Property
        ''' <summary>'}' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedRbrace] As String
          Get
            Return GetResourceString("ERR_ExpectedRbrace")
          End Get
        End Property
        ''' <summary>Module '{0}' cannot be used as a type.</summary>
        Friend Shared ReadOnly Property [ERR_ModuleAsType1] As String
          Get
            Return GetResourceString("ERR_ModuleAsType1")
          End Get
        End Property
        ''' <summary>'New' cannot be used on an interface.</summary>
        Friend Shared ReadOnly Property [ERR_NewIfNullOnNonClass] As String
          Get
            Return GetResourceString("ERR_NewIfNullOnNonClass")
          End Get
        End Property
        ''' <summary>'Catch' cannot appear after 'Finally' within a 'Try' statement.</summary>
        Friend Shared ReadOnly Property [ERR_CatchAfterFinally] As String
          Get
            Return GetResourceString("ERR_CatchAfterFinally")
          End Get
        End Property
        ''' <summary>'Catch' cannot appear outside a 'Try' statement.</summary>
        Friend Shared ReadOnly Property [ERR_CatchNoMatchingTry] As String
          Get
            Return GetResourceString("ERR_CatchNoMatchingTry")
          End Get
        End Property
        ''' <summary>'Finally' can only appear once in a 'Try' statement.</summary>
        Friend Shared ReadOnly Property [ERR_FinallyAfterFinally] As String
          Get
            Return GetResourceString("ERR_FinallyAfterFinally")
          End Get
        End Property
        ''' <summary>'Finally' cannot appear outside a 'Try' statement.</summary>
        Friend Shared ReadOnly Property [ERR_FinallyNoMatchingTry] As String
          Get
            Return GetResourceString("ERR_FinallyNoMatchingTry")
          End Get
        End Property
        ''' <summary>'End Try' must be preceded by a matching 'Try'.</summary>
        Friend Shared ReadOnly Property [ERR_EndTryNoTry] As String
          Get
            Return GetResourceString("ERR_EndTryNoTry")
          End Get
        End Property
        ''' <summary>'Try' must end with a matching 'End Try'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEndTry] As String
          Get
            Return GetResourceString("ERR_ExpectedEndTry")
          End Get
        End Property
        ''' <summary>'{0}' is not valid on a Delegate declaration.</summary>
        Friend Shared ReadOnly Property [ERR_BadDelegateFlags1] As String
          Get
            Return GetResourceString("ERR_BadDelegateFlags1")
          End Get
        End Property
        ''' <summary>Class '{0}' must declare a 'Sub New' because its base class '{1}' does not have an accessible 'Sub New' that can be called with no arguments.</summary>
        Friend Shared ReadOnly Property [ERR_NoConstructorOnBase2] As String
          Get
            Return GetResourceString("ERR_NoConstructorOnBase2")
          End Get
        End Property
        ''' <summary>'{0}' is not accessible in this context because it is '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_InaccessibleSymbol2] As String
          Get
            Return GetResourceString("ERR_InaccessibleSymbol2")
          End Get
        End Property
        ''' <summary>'{0}.{1}' is not accessible in this context because it is '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_InaccessibleMember3] As String
          Get
            Return GetResourceString("ERR_InaccessibleMember3")
          End Get
        End Property
        ''' <summary>'Catch' cannot catch type '{0}' because it is not 'System.Exception' or a class that inherits from 'System.Exception'.</summary>
        Friend Shared ReadOnly Property [ERR_CatchNotException1] As String
          Get
            Return GetResourceString("ERR_CatchNotException1")
          End Get
        End Property
        ''' <summary>'Exit Try' can only appear inside a 'Try' statement.</summary>
        Friend Shared ReadOnly Property [ERR_ExitTryNotWithinTry] As String
          Get
            Return GetResourceString("ERR_ExitTryNotWithinTry")
          End Get
        End Property
        ''' <summary>'{0}' is not valid on a Structure declaration.</summary>
        Friend Shared ReadOnly Property [ERR_BadRecordFlags1] As String
          Get
            Return GetResourceString("ERR_BadRecordFlags1")
          End Get
        End Property
        ''' <summary>'{0}' is not valid on an Enum declaration.</summary>
        Friend Shared ReadOnly Property [ERR_BadEnumFlags1] As String
          Get
            Return GetResourceString("ERR_BadEnumFlags1")
          End Get
        End Property
        ''' <summary>'{0}' is not valid on an Interface declaration.</summary>
        Friend Shared ReadOnly Property [ERR_BadInterfaceFlags1] As String
          Get
            Return GetResourceString("ERR_BadInterfaceFlags1")
          End Get
        End Property
        ''' <summary>'{0}' cannot override '{1}' because they differ by a parameter that is marked as 'ByRef' versus 'ByVal'.</summary>
        Friend Shared ReadOnly Property [ERR_OverrideWithByref2] As String
          Get
            Return GetResourceString("ERR_OverrideWithByref2")
          End Get
        End Property
        ''' <summary>'MyBase' cannot be used with method '{0}' because it is declared 'MustOverride'.</summary>
        Friend Shared ReadOnly Property [ERR_MyBaseAbstractCall1] As String
          Get
            Return GetResourceString("ERR_MyBaseAbstractCall1")
          End Get
        End Property
        ''' <summary>'{0}' cannot implement '{1}' because there is no matching {2} on interface '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_IdentNotMemberOfInterface4] As String
          Get
            Return GetResourceString("ERR_IdentNotMemberOfInterface4")
          End Get
        End Property
        ''' <summary>'{0}' cannot implement {1} '{2}' on interface '{3}' because the tuple element names in '{4}' do not match those in '{5}'.</summary>
        Friend Shared ReadOnly Property [ERR_ImplementingInterfaceWithDifferentTupleNames5] As String
          Get
            Return GetResourceString("ERR_ImplementingInterfaceWithDifferentTupleNames5")
          End Get
        End Property
        ''' <summary>'WithEvents' variables must have an 'As' clause.</summary>
        Friend Shared ReadOnly Property [ERR_WithEventsRequiresClass] As String
          Get
            Return GetResourceString("ERR_WithEventsRequiresClass")
          End Get
        End Property
        ''' <summary>'WithEvents' variables can only be typed as classes, interfaces or type parameters with class constraints.</summary>
        Friend Shared ReadOnly Property [ERR_WithEventsAsStruct] As String
          Get
            Return GetResourceString("ERR_WithEventsAsStruct")
          End Get
        End Property
        ''' <summary>Value of type '{0}' cannot be converted to '{1}' because the array types have different numbers of dimensions.</summary>
        Friend Shared ReadOnly Property [ERR_ConvertArrayRankMismatch2] As String
          Get
            Return GetResourceString("ERR_ConvertArrayRankMismatch2")
          End Get
        End Property
        ''' <summary>'ReDim' cannot change the number of dimensions of an array.</summary>
        Friend Shared ReadOnly Property [ERR_RedimRankMismatch] As String
          Get
            Return GetResourceString("ERR_RedimRankMismatch")
          End Get
        End Property
        ''' <summary>'Sub Main' was not found in '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_StartupCodeNotFound1] As String
          Get
            Return GetResourceString("ERR_StartupCodeNotFound1")
          End Get
        End Property
        ''' <summary>Constants must be of an intrinsic or enumerated type, not a class, structure, type parameter, or array type.</summary>
        Friend Shared ReadOnly Property [ERR_ConstAsNonConstant] As String
          Get
            Return GetResourceString("ERR_ConstAsNonConstant")
          End Get
        End Property
        ''' <summary>'End Sub' must be preceded by a matching 'Sub'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidEndSub] As String
          Get
            Return GetResourceString("ERR_InvalidEndSub")
          End Get
        End Property
        ''' <summary>'End Function' must be preceded by a matching 'Function'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidEndFunction] As String
          Get
            Return GetResourceString("ERR_InvalidEndFunction")
          End Get
        End Property
        ''' <summary>'End Property' must be preceded by a matching 'Property'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidEndProperty] As String
          Get
            Return GetResourceString("ERR_InvalidEndProperty")
          End Get
        End Property
        ''' <summary>Methods in a Module cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_ModuleCantUseMethodSpecifier1] As String
          Get
            Return GetResourceString("ERR_ModuleCantUseMethodSpecifier1")
          End Get
        End Property
        ''' <summary>Events in a Module cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_ModuleCantUseEventSpecifier1] As String
          Get
            Return GetResourceString("ERR_ModuleCantUseEventSpecifier1")
          End Get
        End Property
        ''' <summary>Members in a Structure cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_StructCantUseVarSpecifier1] As String
          Get
            Return GetResourceString("ERR_StructCantUseVarSpecifier1")
          End Get
        End Property
        ''' <summary>'{0}' cannot override '{1}' because they differ by their return types.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidOverrideDueToReturn2] As String
          Get
            Return GetResourceString("ERR_InvalidOverrideDueToReturn2")
          End Get
        End Property
        ''' <summary>'{0}' cannot override '{1}' because they differ by their tuple element names.</summary>
        Friend Shared ReadOnly Property [WRN_InvalidOverrideDueToTupleNames2] As String
          Get
            Return GetResourceString("WRN_InvalidOverrideDueToTupleNames2")
          End Get
        End Property
        ''' <summary>Member cannot override because it differs by its tuple element names.</summary>
        Friend Shared ReadOnly Property [WRN_InvalidOverrideDueToTupleNames2_Title] As String
          Get
            Return GetResourceString("WRN_InvalidOverrideDueToTupleNames2_Title")
          End Get
        End Property
        ''' <summary>Constants must have a value.</summary>
        Friend Shared ReadOnly Property [ERR_ConstantWithNoValue] As String
          Get
            Return GetResourceString("ERR_ConstantWithNoValue")
          End Get
        End Property
        ''' <summary>Constant expression not representable in type '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpressionOverflow1] As String
          Get
            Return GetResourceString("ERR_ExpressionOverflow1")
          End Get
        End Property
        ''' <summary>'Get' is already declared.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicatePropertyGet] As String
          Get
            Return GetResourceString("ERR_DuplicatePropertyGet")
          End Get
        End Property
        ''' <summary>'Set' is already declared.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicatePropertySet] As String
          Get
            Return GetResourceString("ERR_DuplicatePropertySet")
          End Get
        End Property
        ''' <summary>'{0}' is not declared. It may be inaccessible due to its protection level.</summary>
        Friend Shared ReadOnly Property [ERR_NameNotDeclared1] As String
          Get
            Return GetResourceString("ERR_NameNotDeclared1")
          End Get
        End Property
        ''' <summary>Operator '{0}' is not defined for types '{1}' and '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_BinaryOperands3] As String
          Get
            Return GetResourceString("ERR_BinaryOperands3")
          End Get
        End Property
        ''' <summary>Expression is not a method.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedProcedure] As String
          Get
            Return GetResourceString("ERR_ExpectedProcedure")
          End Get
        End Property
        ''' <summary>Argument not specified for parameter '{0}' of '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_OmittedArgument2] As String
          Get
            Return GetResourceString("ERR_OmittedArgument2")
          End Get
        End Property
        ''' <summary>'{0}' is not a member of '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_NameNotMember2] As String
          Get
            Return GetResourceString("ERR_NameNotMember2")
          End Get
        End Property
        ''' <summary>'End Class' must be preceded by a matching 'Class'.</summary>
        Friend Shared ReadOnly Property [ERR_EndClassNoClass] As String
          Get
            Return GetResourceString("ERR_EndClassNoClass")
          End Get
        End Property
        ''' <summary>Classes cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadClassFlags1] As String
          Get
            Return GetResourceString("ERR_BadClassFlags1")
          End Get
        End Property
        ''' <summary>'Imports' statements must precede any declarations.</summary>
        Friend Shared ReadOnly Property [ERR_ImportsMustBeFirst] As String
          Get
            Return GetResourceString("ERR_ImportsMustBeFirst")
          End Get
        End Property
        ''' <summary>'{1}' for the Imports '{0}' does not refer to a Namespace, Class, Structure, Enum or Module.</summary>
        Friend Shared ReadOnly Property [ERR_NonNamespaceOrClassOnImport2] As String
          Get
            Return GetResourceString("ERR_NonNamespaceOrClassOnImport2")
          End Get
        End Property
        ''' <summary>Type declaration characters are not valid in this context.</summary>
        Friend Shared ReadOnly Property [ERR_TypecharNotallowed] As String
          Get
            Return GetResourceString("ERR_TypecharNotallowed")
          End Get
        End Property
        ''' <summary>Reference to a non-shared member requires an object reference.</summary>
        Friend Shared ReadOnly Property [ERR_ObjectReferenceNotSupplied] As String
          Get
            Return GetResourceString("ERR_ObjectReferenceNotSupplied")
          End Get
        End Property
        ''' <summary>'MyClass' cannot be used outside of a class.</summary>
        Friend Shared ReadOnly Property [ERR_MyClassNotInClass] As String
          Get
            Return GetResourceString("ERR_MyClassNotInClass")
          End Get
        End Property
        ''' <summary>Expression is not an array or a method, and cannot have an argument list.</summary>
        Friend Shared ReadOnly Property [ERR_IndexedNotArrayOrProc] As String
          Get
            Return GetResourceString("ERR_IndexedNotArrayOrProc")
          End Get
        End Property
        ''' <summary>'WithEvents' variables cannot be typed as arrays.</summary>
        Friend Shared ReadOnly Property [ERR_EventSourceIsArray] As String
          Get
            Return GetResourceString("ERR_EventSourceIsArray")
          End Get
        End Property
        ''' <summary>Shared 'Sub New' cannot have any parameters.</summary>
        Friend Shared ReadOnly Property [ERR_SharedConstructorWithParams] As String
          Get
            Return GetResourceString("ERR_SharedConstructorWithParams")
          End Get
        End Property
        ''' <summary>Shared 'Sub New' cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_SharedConstructorIllegalSpec1] As String
          Get
            Return GetResourceString("ERR_SharedConstructorIllegalSpec1")
          End Get
        End Property
        ''' <summary>'Class' statement must end with a matching 'End Class'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEndClass] As String
          Get
            Return GetResourceString("ERR_ExpectedEndClass")
          End Get
        End Property
        ''' <summary>Operator '{0}' is not defined for type '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_UnaryOperand2] As String
          Get
            Return GetResourceString("ERR_UnaryOperand2")
          End Get
        End Property
        ''' <summary>'Default' cannot be combined with '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadFlagsWithDefault1] As String
          Get
            Return GetResourceString("ERR_BadFlagsWithDefault1")
          End Get
        End Property
        ''' <summary>Expression does not produce a value.</summary>
        Friend Shared ReadOnly Property [ERR_VoidValue] As String
          Get
            Return GetResourceString("ERR_VoidValue")
          End Get
        End Property
        ''' <summary>Constructor must be declared as a Sub, not as a Function.</summary>
        Friend Shared ReadOnly Property [ERR_ConstructorFunction] As String
          Get
            Return GetResourceString("ERR_ConstructorFunction")
          End Get
        End Property
        ''' <summary>Exponent is not valid.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidLiteralExponent] As String
          Get
            Return GetResourceString("ERR_InvalidLiteralExponent")
          End Get
        End Property
        ''' <summary>'Sub New' cannot handle events.</summary>
        Friend Shared ReadOnly Property [ERR_NewCannotHandleEvents] As String
          Get
            Return GetResourceString("ERR_NewCannotHandleEvents")
          End Get
        End Property
        ''' <summary>Constant '{0}' cannot depend on its own value.</summary>
        Friend Shared ReadOnly Property [ERR_CircularEvaluation1] As String
          Get
            Return GetResourceString("ERR_CircularEvaluation1")
          End Get
        End Property
        ''' <summary>'Shared' cannot be combined with '{0}' on a method declaration.</summary>
        Friend Shared ReadOnly Property [ERR_BadFlagsOnSharedMeth1] As String
          Get
            Return GetResourceString("ERR_BadFlagsOnSharedMeth1")
          End Get
        End Property
        ''' <summary>'Shared' cannot be combined with '{0}' on a property declaration.</summary>
        Friend Shared ReadOnly Property [ERR_BadFlagsOnSharedProperty1] As String
          Get
            Return GetResourceString("ERR_BadFlagsOnSharedProperty1")
          End Get
        End Property
        ''' <summary>Properties in a Module cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadFlagsOnStdModuleProperty1] As String
          Get
            Return GetResourceString("ERR_BadFlagsOnStdModuleProperty1")
          End Get
        End Property
        ''' <summary>Methods or events that implement interface members cannot be declared 'Shared'.</summary>
        Friend Shared ReadOnly Property [ERR_SharedOnProcThatImpl] As String
          Get
            Return GetResourceString("ERR_SharedOnProcThatImpl")
          End Get
        End Property
        ''' <summary>Handles clause requires a WithEvents variable defined in the containing type or one of its base types.</summary>
        Friend Shared ReadOnly Property [ERR_NoWithEventsVarOnHandlesList] As String
          Get
            Return GetResourceString("ERR_NoWithEventsVarOnHandlesList")
          End Get
        End Property
        ''' <summary>'{0}' cannot inherit from {1} '{2}' because it expands the access of the base {1} to {3} '{4}'.</summary>
        Friend Shared ReadOnly Property [ERR_InheritanceAccessMismatch5] As String
          Get
            Return GetResourceString("ERR_InheritanceAccessMismatch5")
          End Get
        End Property
        ''' <summary>Option Strict On disallows implicit conversions from '{0}' to '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_NarrowingConversionDisallowed2] As String
          Get
            Return GetResourceString("ERR_NarrowingConversionDisallowed2")
          End Get
        End Property
        ''' <summary>Overload resolution failed because no accessible '{0}' accepts this number of arguments.</summary>
        Friend Shared ReadOnly Property [ERR_NoArgumentCountOverloadCandidates1] As String
          Get
            Return GetResourceString("ERR_NoArgumentCountOverloadCandidates1")
          End Get
        End Property
        ''' <summary>Overload resolution failed because no '{0}' is accessible.</summary>
        Friend Shared ReadOnly Property [ERR_NoViableOverloadCandidates1] As String
          Get
            Return GetResourceString("ERR_NoViableOverloadCandidates1")
          End Get
        End Property
        ''' <summary>Overload resolution failed because no accessible '{0}' can be called with these arguments:{1}</summary>
        Friend Shared ReadOnly Property [ERR_NoCallableOverloadCandidates2] As String
          Get
            Return GetResourceString("ERR_NoCallableOverloadCandidates2")
          End Get
        End Property
        ''' <summary>Overload resolution failed because no accessible '{0}' can be called:{1}</summary>
        Friend Shared ReadOnly Property [ERR_BadOverloadCandidates2] As String
          Get
            Return GetResourceString("ERR_BadOverloadCandidates2")
          End Get
        End Property
        ''' <summary>Overload resolution failed because no accessible '{0}' can be called without a narrowing conversion:{1}</summary>
        Friend Shared ReadOnly Property [ERR_NoNonNarrowingOverloadCandidates2] As String
          Get
            Return GetResourceString("ERR_NoNonNarrowingOverloadCandidates2")
          End Get
        End Property
        ''' <summary>Argument matching parameter '{0}' narrows from '{1}' to '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_ArgumentNarrowing3] As String
          Get
            Return GetResourceString("ERR_ArgumentNarrowing3")
          End Get
        End Property
        ''' <summary>Overload resolution failed because no accessible '{0}' is most specific for these arguments:{1}</summary>
        Friend Shared ReadOnly Property [ERR_NoMostSpecificOverload2] As String
          Get
            Return GetResourceString("ERR_NoMostSpecificOverload2")
          End Get
        End Property
        ''' <summary>Not most specific.</summary>
        Friend Shared ReadOnly Property [ERR_NotMostSpecificOverload] As String
          Get
            Return GetResourceString("ERR_NotMostSpecificOverload")
          End Get
        End Property
        ''' <summary>'{0}': {1}</summary>
        Friend Shared ReadOnly Property [ERR_OverloadCandidate2] As String
          Get
            Return GetResourceString("ERR_OverloadCandidate2")
          End Get
        End Property
        ''' <summary>Property '{0}' is 'WriteOnly'.</summary>
        Friend Shared ReadOnly Property [ERR_NoGetProperty1] As String
          Get
            Return GetResourceString("ERR_NoGetProperty1")
          End Get
        End Property
        ''' <summary>Property '{0}' is 'ReadOnly'.</summary>
        Friend Shared ReadOnly Property [ERR_NoSetProperty1] As String
          Get
            Return GetResourceString("ERR_NoSetProperty1")
          End Get
        End Property
        ''' <summary>All parameters must be explicitly typed if any of them are explicitly typed.</summary>
        Friend Shared ReadOnly Property [ERR_ParamTypingInconsistency] As String
          Get
            Return GetResourceString("ERR_ParamTypingInconsistency")
          End Get
        End Property
        ''' <summary>Parameter cannot have the same name as its defining function.</summary>
        Friend Shared ReadOnly Property [ERR_ParamNameFunctionNameCollision] As String
          Get
            Return GetResourceString("ERR_ParamNameFunctionNameCollision")
          End Get
        End Property
        ''' <summary>Conversion from 'Date' to 'Double' requires calling the 'Date.ToOADate' method.</summary>
        Friend Shared ReadOnly Property [ERR_DateToDoubleConversion] As String
          Get
            Return GetResourceString("ERR_DateToDoubleConversion")
          End Get
        End Property
        ''' <summary>Conversion from 'Double' to 'Date' requires calling the 'Date.FromOADate' method.</summary>
        Friend Shared ReadOnly Property [ERR_DoubleToDateConversion] As String
          Get
            Return GetResourceString("ERR_DoubleToDateConversion")
          End Get
        End Property
        ''' <summary>Division by zero occurred while evaluating this expression.</summary>
        Friend Shared ReadOnly Property [ERR_ZeroDivide] As String
          Get
            Return GetResourceString("ERR_ZeroDivide")
          End Get
        End Property
        ''' <summary>Method cannot contain both a 'Try' statement and an 'On Error' or 'Resume' statement.</summary>
        Friend Shared ReadOnly Property [ERR_TryAndOnErrorDoNotMix] As String
          Get
            Return GetResourceString("ERR_TryAndOnErrorDoNotMix")
          End Get
        End Property
        ''' <summary>Property access must assign to the property or use its value.</summary>
        Friend Shared ReadOnly Property [ERR_PropertyAccessIgnored] As String
          Get
            Return GetResourceString("ERR_PropertyAccessIgnored")
          End Get
        End Property
        ''' <summary>'{0}' cannot be indexed because it has no default property.</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceNoDefault1] As String
          Get
            Return GetResourceString("ERR_InterfaceNoDefault1")
          End Get
        End Property
        ''' <summary>Attribute '{0}' cannot be applied to an assembly.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidAssemblyAttribute1] As String
          Get
            Return GetResourceString("ERR_InvalidAssemblyAttribute1")
          End Get
        End Property
        ''' <summary>Attribute '{0}' cannot be applied to a module.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidModuleAttribute1] As String
          Get
            Return GetResourceString("ERR_InvalidModuleAttribute1")
          End Get
        End Property
        ''' <summary>'{0}' is ambiguous.</summary>
        Friend Shared ReadOnly Property [ERR_AmbiguousInUnnamedNamespace1] As String
          Get
            Return GetResourceString("ERR_AmbiguousInUnnamedNamespace1")
          End Get
        End Property
        ''' <summary>Default member of '{0}' is not a property.</summary>
        Friend Shared ReadOnly Property [ERR_DefaultMemberNotProperty1] As String
          Get
            Return GetResourceString("ERR_DefaultMemberNotProperty1")
          End Get
        End Property
        ''' <summary>'{0}' is ambiguous in the namespace '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_AmbiguousInNamespace2] As String
          Get
            Return GetResourceString("ERR_AmbiguousInNamespace2")
          End Get
        End Property
        ''' <summary>'{0}' is ambiguous, imported from the namespaces or types '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_AmbiguousInImports2] As String
          Get
            Return GetResourceString("ERR_AmbiguousInImports2")
          End Get
        End Property
        ''' <summary>'{0}' is ambiguous between declarations in Modules '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_AmbiguousInModules2] As String
          Get
            Return GetResourceString("ERR_AmbiguousInModules2")
          End Get
        End Property
        ''' <summary>'{0}' is ambiguous between declarations in namespaces '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_AmbiguousInNamespaces2] As String
          Get
            Return GetResourceString("ERR_AmbiguousInNamespaces2")
          End Get
        End Property
        ''' <summary>Array initializer has too few dimensions.</summary>
        Friend Shared ReadOnly Property [ERR_ArrayInitializerTooFewDimensions] As String
          Get
            Return GetResourceString("ERR_ArrayInitializerTooFewDimensions")
          End Get
        End Property
        ''' <summary>Array initializer has too many dimensions.</summary>
        Friend Shared ReadOnly Property [ERR_ArrayInitializerTooManyDimensions] As String
          Get
            Return GetResourceString("ERR_ArrayInitializerTooManyDimensions")
          End Get
        End Property
        ''' <summary>Array initializer is missing {0} elements.</summary>
        Friend Shared ReadOnly Property [ERR_InitializerTooFewElements1] As String
          Get
            Return GetResourceString("ERR_InitializerTooFewElements1")
          End Get
        End Property
        ''' <summary>Array initializer has {0} too many elements.</summary>
        Friend Shared ReadOnly Property [ERR_InitializerTooManyElements1] As String
          Get
            Return GetResourceString("ERR_InitializerTooManyElements1")
          End Get
        End Property
        ''' <summary>'New' cannot be used on a class that is declared 'MustInherit'.</summary>
        Friend Shared ReadOnly Property [ERR_NewOnAbstractClass] As String
          Get
            Return GetResourceString("ERR_NewOnAbstractClass")
          End Get
        End Property
        ''' <summary>Alias '{0}' is already declared.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateNamedImportAlias1] As String
          Get
            Return GetResourceString("ERR_DuplicateNamedImportAlias1")
          End Get
        End Property
        ''' <summary>XML namespace prefix '{0}' is already declared.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicatePrefix] As String
          Get
            Return GetResourceString("ERR_DuplicatePrefix")
          End Get
        End Property
        ''' <summary>stdin argument '-' is specified, but input has not been redirected from the standard input stream.</summary>
        Friend Shared ReadOnly Property [ERR_StdInOptionProvidedButConsoleInputIsNotRedirected] As String
          Get
            Return GetResourceString("ERR_StdInOptionProvidedButConsoleInputIsNotRedirected")
          End Get
        End Property
        ''' <summary>Option Strict On disallows late binding.</summary>
        Friend Shared ReadOnly Property [ERR_StrictDisallowsLateBinding] As String
          Get
            Return GetResourceString("ERR_StrictDisallowsLateBinding")
          End Get
        End Property
        ''' <summary>'AddressOf' operand must be the name of a method (without parentheses).</summary>
        Friend Shared ReadOnly Property [ERR_AddressOfOperandNotMethod] As String
          Get
            Return GetResourceString("ERR_AddressOfOperandNotMethod")
          End Get
        End Property
        ''' <summary>'#End ExternalSource' must be preceded by a matching '#ExternalSource'.</summary>
        Friend Shared ReadOnly Property [ERR_EndExternalSource] As String
          Get
            Return GetResourceString("ERR_EndExternalSource")
          End Get
        End Property
        ''' <summary>'#ExternalSource' statement must end with a matching '#End ExternalSource'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEndExternalSource] As String
          Get
            Return GetResourceString("ERR_ExpectedEndExternalSource")
          End Get
        End Property
        ''' <summary>'#ExternalSource' directives cannot be nested.</summary>
        Friend Shared ReadOnly Property [ERR_NestedExternalSource] As String
          Get
            Return GetResourceString("ERR_NestedExternalSource")
          End Get
        End Property
        ''' <summary>'AddressOf' expression cannot be converted to '{0}' because '{0}' is not a delegate type.</summary>
        Friend Shared ReadOnly Property [ERR_AddressOfNotDelegate1] As String
          Get
            Return GetResourceString("ERR_AddressOfNotDelegate1")
          End Get
        End Property
        ''' <summary>'SyncLock' operand cannot be of type '{0}' because '{0}' is not a reference type.</summary>
        Friend Shared ReadOnly Property [ERR_SyncLockRequiresReferenceType1] As String
          Get
            Return GetResourceString("ERR_SyncLockRequiresReferenceType1")
          End Get
        End Property
        ''' <summary>'{0}.{1}' cannot be implemented more than once.</summary>
        Friend Shared ReadOnly Property [ERR_MethodAlreadyImplemented2] As String
          Get
            Return GetResourceString("ERR_MethodAlreadyImplemented2")
          End Get
        End Property
        ''' <summary>'{0}' cannot be inherited more than once.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateInInherits1] As String
          Get
            Return GetResourceString("ERR_DuplicateInInherits1")
          End Get
        End Property
        ''' <summary>Named argument cannot match a ParamArray parameter.</summary>
        Friend Shared ReadOnly Property [ERR_NamedParamArrayArgument] As String
          Get
            Return GetResourceString("ERR_NamedParamArrayArgument")
          End Get
        End Property
        ''' <summary>Omitted argument cannot match a ParamArray parameter.</summary>
        Friend Shared ReadOnly Property [ERR_OmittedParamArrayArgument] As String
          Get
            Return GetResourceString("ERR_OmittedParamArrayArgument")
          End Get
        End Property
        ''' <summary>Argument cannot match a ParamArray parameter.</summary>
        Friend Shared ReadOnly Property [ERR_ParamArrayArgumentMismatch] As String
          Get
            Return GetResourceString("ERR_ParamArrayArgumentMismatch")
          End Get
        End Property
        ''' <summary>Event '{0}' cannot be found.</summary>
        Friend Shared ReadOnly Property [ERR_EventNotFound1] As String
          Get
            Return GetResourceString("ERR_EventNotFound1")
          End Get
        End Property
        ''' <summary>Variables in Modules cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_ModuleCantUseVariableSpecifier1] As String
          Get
            Return GetResourceString("ERR_ModuleCantUseVariableSpecifier1")
          End Get
        End Property
        ''' <summary>Events of shared WithEvents variables cannot be handled by non-shared methods.</summary>
        Friend Shared ReadOnly Property [ERR_SharedEventNeedsSharedHandler] As String
          Get
            Return GetResourceString("ERR_SharedEventNeedsSharedHandler")
          End Get
        End Property
        ''' <summary>Events of shared WithEvents variables cannot be handled by methods in a different type.</summary>
        Friend Shared ReadOnly Property [ERR_SharedEventNeedsHandlerInTheSameType] As String
          Get
            Return GetResourceString("ERR_SharedEventNeedsHandlerInTheSameType")
          End Get
        End Property
        ''' <summary>'-' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedMinus] As String
          Get
            Return GetResourceString("ERR_ExpectedMinus")
          End Get
        End Property
        ''' <summary>Interface members must be methods, properties, events, or type definitions.</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceMemberSyntax] As String
          Get
            Return GetResourceString("ERR_InterfaceMemberSyntax")
          End Get
        End Property
        ''' <summary>Statement cannot appear within an interface body.</summary>
        Friend Shared ReadOnly Property [ERR_InvInsideInterface] As String
          Get
            Return GetResourceString("ERR_InvInsideInterface")
          End Get
        End Property
        ''' <summary>Statement cannot appear within an interface body. End of interface assumed.</summary>
        Friend Shared ReadOnly Property [ERR_InvInsideEndsInterface] As String
          Get
            Return GetResourceString("ERR_InvInsideEndsInterface")
          End Get
        End Property
        ''' <summary>'NotInheritable' classes cannot have members declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadFlagsInNotInheritableClass1] As String
          Get
            Return GetResourceString("ERR_BadFlagsInNotInheritableClass1")
          End Get
        End Property
        ''' <summary>Class '{0}' must either be declared 'MustInherit' or override the following inherited 'MustOverride' member(s): {1}.</summary>
        Friend Shared ReadOnly Property [ERR_BaseOnlyClassesMustBeExplicit2] As String
          Get
            Return GetResourceString("ERR_BaseOnlyClassesMustBeExplicit2")
          End Get
        End Property
        ''' <summary>'{0}' is a MustOverride event in the base class '{1}'. Visual Basic does not support event overriding. You must either provide an implementation for the event in the base class, or make class '{2}' MustInherit.</summary>
        Friend Shared ReadOnly Property [ERR_MustInheritEventNotOverridden] As String
          Get
            Return GetResourceString("ERR_MustInheritEventNotOverridden")
          End Get
        End Property
        ''' <summary>Array dimensions cannot have a negative size.</summary>
        Friend Shared ReadOnly Property [ERR_NegativeArraySize] As String
          Get
            Return GetResourceString("ERR_NegativeArraySize")
          End Get
        End Property
        ''' <summary>'MustOverride' method '{0}' cannot be called with 'MyClass'.</summary>
        Friend Shared ReadOnly Property [ERR_MyClassAbstractCall1] As String
          Get
            Return GetResourceString("ERR_MyClassAbstractCall1")
          End Get
        End Property
        ''' <summary>'End' statement cannot be used in class library projects.</summary>
        Friend Shared ReadOnly Property [ERR_EndDisallowedInDllProjects] As String
          Get
            Return GetResourceString("ERR_EndDisallowedInDllProjects")
          End Get
        End Property
        ''' <summary>Variable '{0}' hides a variable in an enclosing block.</summary>
        Friend Shared ReadOnly Property [ERR_BlockLocalShadowing1] As String
          Get
            Return GetResourceString("ERR_BlockLocalShadowing1")
          End Get
        End Property
        ''' <summary>'Module' statements can occur only at file or namespace level.</summary>
        Friend Shared ReadOnly Property [ERR_ModuleNotAtNamespace] As String
          Get
            Return GetResourceString("ERR_ModuleNotAtNamespace")
          End Get
        End Property
        ''' <summary>'Namespace' statements can occur only at file or namespace level.</summary>
        Friend Shared ReadOnly Property [ERR_NamespaceNotAtNamespace] As String
          Get
            Return GetResourceString("ERR_NamespaceNotAtNamespace")
          End Get
        End Property
        ''' <summary>Statement cannot appear within an Enum body.</summary>
        Friend Shared ReadOnly Property [ERR_InvInsideEnum] As String
          Get
            Return GetResourceString("ERR_InvInsideEnum")
          End Get
        End Property
        ''' <summary>Statement cannot appear within an Enum body. End of Enum assumed.</summary>
        Friend Shared ReadOnly Property [ERR_InvInsideEndsEnum] As String
          Get
            Return GetResourceString("ERR_InvInsideEndsEnum")
          End Get
        End Property
        ''' <summary>'Option Strict' can be followed only by 'On' or 'Off'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidOptionStrict] As String
          Get
            Return GetResourceString("ERR_InvalidOptionStrict")
          End Get
        End Property
        ''' <summary>'End Structure' must be preceded by a matching 'Structure'.</summary>
        Friend Shared ReadOnly Property [ERR_EndStructureNoStructure] As String
          Get
            Return GetResourceString("ERR_EndStructureNoStructure")
          End Get
        End Property
        ''' <summary>'End Module' must be preceded by a matching 'Module'.</summary>
        Friend Shared ReadOnly Property [ERR_EndModuleNoModule] As String
          Get
            Return GetResourceString("ERR_EndModuleNoModule")
          End Get
        End Property
        ''' <summary>'End Namespace' must be preceded by a matching 'Namespace'.</summary>
        Friend Shared ReadOnly Property [ERR_EndNamespaceNoNamespace] As String
          Get
            Return GetResourceString("ERR_EndNamespaceNoNamespace")
          End Get
        End Property
        ''' <summary>'Structure' statement must end with a matching 'End Structure'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEndStructure] As String
          Get
            Return GetResourceString("ERR_ExpectedEndStructure")
          End Get
        End Property
        ''' <summary>'Module' statement must end with a matching 'End Module'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEndModule] As String
          Get
            Return GetResourceString("ERR_ExpectedEndModule")
          End Get
        End Property
        ''' <summary>'Namespace' statement must end with a matching 'End Namespace'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEndNamespace] As String
          Get
            Return GetResourceString("ERR_ExpectedEndNamespace")
          End Get
        End Property
        ''' <summary>'Option' statements must precede any declarations or 'Imports' statements.</summary>
        Friend Shared ReadOnly Property [ERR_OptionStmtWrongOrder] As String
          Get
            Return GetResourceString("ERR_OptionStmtWrongOrder")
          End Get
        End Property
        ''' <summary>Structures cannot have 'Inherits' statements.</summary>
        Friend Shared ReadOnly Property [ERR_StructCantInherit] As String
          Get
            Return GetResourceString("ERR_StructCantInherit")
          End Get
        End Property
        ''' <summary>Structures cannot declare a non-shared 'Sub New' with no parameters.</summary>
        Friend Shared ReadOnly Property [ERR_NewInStruct] As String
          Get
            Return GetResourceString("ERR_NewInStruct")
          End Get
        End Property
        ''' <summary>'End Get' must be preceded by a matching 'Get'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidEndGet] As String
          Get
            Return GetResourceString("ERR_InvalidEndGet")
          End Get
        End Property
        ''' <summary>'Get' statement must end with a matching 'End Get'.</summary>
        Friend Shared ReadOnly Property [ERR_MissingEndGet] As String
          Get
            Return GetResourceString("ERR_MissingEndGet")
          End Get
        End Property
        ''' <summary>'End Set' must be preceded by a matching 'Set'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidEndSet] As String
          Get
            Return GetResourceString("ERR_InvalidEndSet")
          End Get
        End Property
        ''' <summary>'Set' statement must end with a matching 'End Set'.</summary>
        Friend Shared ReadOnly Property [ERR_MissingEndSet] As String
          Get
            Return GetResourceString("ERR_MissingEndSet")
          End Get
        End Property
        ''' <summary>Statement cannot appear within a property body. End of property assumed.</summary>
        Friend Shared ReadOnly Property [ERR_InvInsideEndsProperty] As String
          Get
            Return GetResourceString("ERR_InvInsideEndsProperty")
          End Get
        End Property
        ''' <summary>'ReadOnly' and 'WriteOnly' cannot be combined.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateWriteabilityCategoryUsed] As String
          Get
            Return GetResourceString("ERR_DuplicateWriteabilityCategoryUsed")
          End Get
        End Property
        ''' <summary>'&gt;' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedGreater] As String
          Get
            Return GetResourceString("ERR_ExpectedGreater")
          End Get
        End Property
        ''' <summary>Assembly or Module attribute statements must precede any declarations in a file.</summary>
        Friend Shared ReadOnly Property [ERR_AttributeStmtWrongOrder] As String
          Get
            Return GetResourceString("ERR_AttributeStmtWrongOrder")
          End Get
        End Property
        ''' <summary>Array bounds cannot appear in type specifiers.</summary>
        Friend Shared ReadOnly Property [ERR_NoExplicitArraySizes] As String
          Get
            Return GetResourceString("ERR_NoExplicitArraySizes")
          End Get
        End Property
        ''' <summary>Properties cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadPropertyFlags1] As String
          Get
            Return GetResourceString("ERR_BadPropertyFlags1")
          End Get
        End Property
        ''' <summary>'Option Explicit' can be followed only by 'On' or 'Off'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidOptionExplicit] As String
          Get
            Return GetResourceString("ERR_InvalidOptionExplicit")
          End Get
        End Property
        ''' <summary>'ByVal' and 'ByRef' cannot be combined.</summary>
        Friend Shared ReadOnly Property [ERR_MultipleParameterSpecifiers] As String
          Get
            Return GetResourceString("ERR_MultipleParameterSpecifiers")
          End Get
        End Property
        ''' <summary>'Optional' and 'ParamArray' cannot be combined.</summary>
        Friend Shared ReadOnly Property [ERR_MultipleOptionalParameterSpecifiers] As String
          Get
            Return GetResourceString("ERR_MultipleOptionalParameterSpecifiers")
          End Get
        End Property
        ''' <summary>Property '{0}' is of an unsupported type.</summary>
        Friend Shared ReadOnly Property [ERR_UnsupportedProperty1] As String
          Get
            Return GetResourceString("ERR_UnsupportedProperty1")
          End Get
        End Property
        ''' <summary>Attribute '{0}' cannot be applied to a method with optional parameters.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidOptionalParameterUsage1] As String
          Get
            Return GetResourceString("ERR_InvalidOptionalParameterUsage1")
          End Get
        End Property
        ''' <summary>'Return' statement in a Sub or a Set cannot return a value.</summary>
        Friend Shared ReadOnly Property [ERR_ReturnFromNonFunction] As String
          Get
            Return GetResourceString("ERR_ReturnFromNonFunction")
          End Get
        End Property
        ''' <summary>String constants must end with a double quote.</summary>
        Friend Shared ReadOnly Property [ERR_UnterminatedStringLiteral] As String
          Get
            Return GetResourceString("ERR_UnterminatedStringLiteral")
          End Get
        End Property
        ''' <summary>'{0}' is an unsupported type.</summary>
        Friend Shared ReadOnly Property [ERR_UnsupportedType1] As String
          Get
            Return GetResourceString("ERR_UnsupportedType1")
          End Get
        End Property
        ''' <summary>Enums must be declared as an integral type.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidEnumBase] As String
          Get
            Return GetResourceString("ERR_InvalidEnumBase")
          End Get
        End Property
        ''' <summary>{0} parameters cannot be declared 'ByRef'.</summary>
        Friend Shared ReadOnly Property [ERR_ByRefIllegal1] As String
          Get
            Return GetResourceString("ERR_ByRefIllegal1")
          End Get
        End Property
        ''' <summary>Reference required to assembly '{0}' containing the type '{1}'. Add one to your project.</summary>
        Friend Shared ReadOnly Property [ERR_UnreferencedAssembly3] As String
          Get
            Return GetResourceString("ERR_UnreferencedAssembly3")
          End Get
        End Property
        ''' <summary>Reference required to module '{0}' containing the type '{1}'. Add one to your project.</summary>
        Friend Shared ReadOnly Property [ERR_UnreferencedModule3] As String
          Get
            Return GetResourceString("ERR_UnreferencedModule3")
          End Get
        End Property
        ''' <summary>'Return' statement in a Function, Get, or Operator must return a value.</summary>
        Friend Shared ReadOnly Property [ERR_ReturnWithoutValue] As String
          Get
            Return GetResourceString("ERR_ReturnWithoutValue")
          End Get
        End Property
        ''' <summary>Field '{0}' is of an unsupported type.</summary>
        Friend Shared ReadOnly Property [ERR_UnsupportedField1] As String
          Get
            Return GetResourceString("ERR_UnsupportedField1")
          End Get
        End Property
        ''' <summary>'{0}' has a return type that is not supported or parameter types that are not supported.</summary>
        Friend Shared ReadOnly Property [ERR_UnsupportedMethod1] As String
          Get
            Return GetResourceString("ERR_UnsupportedMethod1")
          End Get
        End Property
        ''' <summary>Property '{0}' with no parameters cannot be found.</summary>
        Friend Shared ReadOnly Property [ERR_NoNonIndexProperty1] As String
          Get
            Return GetResourceString("ERR_NoNonIndexProperty1")
          End Get
        End Property
        ''' <summary>Property or field '{0}' does not have a valid attribute type.</summary>
        Friend Shared ReadOnly Property [ERR_BadAttributePropertyType1] As String
          Get
            Return GetResourceString("ERR_BadAttributePropertyType1")
          End Get
        End Property
        ''' <summary>Attributes cannot be applied to local variables.</summary>
        Friend Shared ReadOnly Property [ERR_LocalsCannotHaveAttributes] As String
          Get
            Return GetResourceString("ERR_LocalsCannotHaveAttributes")
          End Get
        End Property
        ''' <summary>Field or property '{0}' is not found.</summary>
        Friend Shared ReadOnly Property [ERR_PropertyOrFieldNotDefined1] As String
          Get
            Return GetResourceString("ERR_PropertyOrFieldNotDefined1")
          End Get
        End Property
        ''' <summary>Attribute '{0}' cannot be applied to '{1}' because the attribute is not valid on this declaration type.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidAttributeUsage2] As String
          Get
            Return GetResourceString("ERR_InvalidAttributeUsage2")
          End Get
        End Property
        ''' <summary>Attribute '{0}' cannot be applied to '{1}' of '{2}' because the attribute is not valid on this declaration type.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidAttributeUsageOnAccessor] As String
          Get
            Return GetResourceString("ERR_InvalidAttributeUsageOnAccessor")
          End Get
        End Property
        ''' <summary>Class '{0}' cannot reference its nested type '{1}' in Inherits clause.</summary>
        Friend Shared ReadOnly Property [ERR_NestedTypeInInheritsClause2] As String
          Get
            Return GetResourceString("ERR_NestedTypeInInheritsClause2")
          End Get
        End Property
        ''' <summary>Class '{0}' cannot reference itself in Inherits clause.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInItsInheritsClause1] As String
          Get
            Return GetResourceString("ERR_TypeInItsInheritsClause1")
          End Get
        End Property
        ''' <summary>Base type of '{0}' needs '{1}' to be resolved.</summary>
        Friend Shared ReadOnly Property [ERR_BaseTypeReferences2] As String
          Get
            Return GetResourceString("ERR_BaseTypeReferences2")
          End Get
        End Property
        ''' <summary>Inherits clause of {0} '{1}' causes cyclic dependency: {2}</summary>
        Friend Shared ReadOnly Property [ERR_IllegalBaseTypeReferences3] As String
          Get
            Return GetResourceString("ERR_IllegalBaseTypeReferences3")
          End Get
        End Property
        ''' <summary>Attribute '{0}' cannot be applied multiple times.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidMultipleAttributeUsage1] As String
          Get
            Return GetResourceString("ERR_InvalidMultipleAttributeUsage1")
          End Get
        End Property
        ''' <summary>Attribute '{0}' in '{1}' cannot be applied multiple times.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidMultipleAttributeUsageInNetModule2] As String
          Get
            Return GetResourceString("ERR_InvalidMultipleAttributeUsageInNetModule2")
          End Get
        End Property
        ''' <summary>'Throw' operand must derive from 'System.Exception'.</summary>
        Friend Shared ReadOnly Property [ERR_CantThrowNonException] As String
          Get
            Return GetResourceString("ERR_CantThrowNonException")
          End Get
        End Property
        ''' <summary>'Throw' statement cannot omit operand outside a 'Catch' statement or inside a 'Finally' statement.</summary>
        Friend Shared ReadOnly Property [ERR_MustBeInCatchToRethrow] As String
          Get
            Return GetResourceString("ERR_MustBeInCatchToRethrow")
          End Get
        End Property
        ''' <summary>ParamArray parameters must be declared 'ByVal'.</summary>
        Friend Shared ReadOnly Property [ERR_ParamArrayMustBeByVal] As String
          Get
            Return GetResourceString("ERR_ParamArrayMustBeByVal")
          End Get
        End Property
        ''' <summary>'{0}' is obsolete: '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_UseOfObsoleteSymbol2] As String
          Get
            Return GetResourceString("ERR_UseOfObsoleteSymbol2")
          End Get
        End Property
        ''' <summary>'ReDim' statements require a parenthesized list of the new bounds of each dimension of the array.</summary>
        Friend Shared ReadOnly Property [ERR_RedimNoSizes] As String
          Get
            Return GetResourceString("ERR_RedimNoSizes")
          End Get
        End Property
        ''' <summary>Explicit initialization is not permitted with multiple variables declared with a single type specifier.</summary>
        Friend Shared ReadOnly Property [ERR_InitWithMultipleDeclarators] As String
          Get
            Return GetResourceString("ERR_InitWithMultipleDeclarators")
          End Get
        End Property
        ''' <summary>Explicit initialization is not permitted for arrays declared with explicit bounds.</summary>
        Friend Shared ReadOnly Property [ERR_InitWithExplicitArraySizes] As String
          Get
            Return GetResourceString("ERR_InitWithExplicitArraySizes")
          End Get
        End Property
        ''' <summary>'End SyncLock' must be preceded by a matching 'SyncLock'.</summary>
        Friend Shared ReadOnly Property [ERR_EndSyncLockNoSyncLock] As String
          Get
            Return GetResourceString("ERR_EndSyncLockNoSyncLock")
          End Get
        End Property
        ''' <summary>'SyncLock' statement must end with a matching 'End SyncLock'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEndSyncLock] As String
          Get
            Return GetResourceString("ERR_ExpectedEndSyncLock")
          End Get
        End Property
        ''' <summary>'{0}' is not an event of '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_NameNotEvent2] As String
          Get
            Return GetResourceString("ERR_NameNotEvent2")
          End Get
        End Property
        ''' <summary>'AddHandler' or 'RemoveHandler' statement event operand must be a dot-qualified expression or a simple name.</summary>
        Friend Shared ReadOnly Property [ERR_AddOrRemoveHandlerEvent] As String
          Get
            Return GetResourceString("ERR_AddOrRemoveHandlerEvent")
          End Get
        End Property
        ''' <summary>'End' statement not valid.</summary>
        Friend Shared ReadOnly Property [ERR_UnrecognizedEnd] As String
          Get
            Return GetResourceString("ERR_UnrecognizedEnd")
          End Get
        End Property
        ''' <summary>'#End Region' must be preceded by a matching '#Region'.</summary>
        Friend Shared ReadOnly Property [ERR_EndRegionNoRegion] As String
          Get
            Return GetResourceString("ERR_EndRegionNoRegion")
          End Get
        End Property
        ''' <summary>'#Region' statement must end with a matching '#End Region'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEndRegion] As String
          Get
            Return GetResourceString("ERR_ExpectedEndRegion")
          End Get
        End Property
        ''' <summary>'Inherits' statement must precede all declarations in a class.</summary>
        Friend Shared ReadOnly Property [ERR_InheritsStmtWrongOrder] As String
          Get
            Return GetResourceString("ERR_InheritsStmtWrongOrder")
          End Get
        End Property
        ''' <summary>'{0}' is ambiguous across the inherited interfaces '{1}' and '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_AmbiguousAcrossInterfaces3] As String
          Get
            Return GetResourceString("ERR_AmbiguousAcrossInterfaces3")
          End Get
        End Property
        ''' <summary>Default property access is ambiguous between the inherited interface members '{0}' of interface '{1}' and '{2}' of interface '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_DefaultPropertyAmbiguousAcrossInterfaces4] As String
          Get
            Return GetResourceString("ERR_DefaultPropertyAmbiguousAcrossInterfaces4")
          End Get
        End Property
        ''' <summary>Events in interfaces cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceEventCantUse1] As String
          Get
            Return GetResourceString("ERR_InterfaceEventCantUse1")
          End Get
        End Property
        ''' <summary>Statement cannot appear outside of a method body.</summary>
        Friend Shared ReadOnly Property [ERR_ExecutableAsDeclaration] As String
          Get
            Return GetResourceString("ERR_ExecutableAsDeclaration")
          End Get
        End Property
        ''' <summary>Structure '{0}' cannot be indexed because it has no default property.</summary>
        Friend Shared ReadOnly Property [ERR_StructureNoDefault1] As String
          Get
            Return GetResourceString("ERR_StructureNoDefault1")
          End Get
        End Property
        ''' <summary>{0} '{1}' must be declared 'Shadows' because another member with this name is declared 'Shadows'.</summary>
        Friend Shared ReadOnly Property [ERR_MustShadow2] As String
          Get
            Return GetResourceString("ERR_MustShadow2")
          End Get
        End Property
        ''' <summary>'{0}' cannot override '{1}' because they differ by the types of optional parameters.</summary>
        Friend Shared ReadOnly Property [ERR_OverrideWithOptionalTypes2] As String
          Get
            Return GetResourceString("ERR_OverrideWithOptionalTypes2")
          End Get
        End Property
        ''' <summary>End of expression expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEndOfExpression] As String
          Get
            Return GetResourceString("ERR_ExpectedEndOfExpression")
          End Get
        End Property
        ''' <summary>Methods declared in structures cannot have 'Handles' clauses.</summary>
        Friend Shared ReadOnly Property [ERR_StructsCannotHandleEvents] As String
          Get
            Return GetResourceString("ERR_StructsCannotHandleEvents")
          End Get
        End Property
        ''' <summary>Methods declared 'Overrides' cannot be declared 'Overridable' because they are implicitly overridable.</summary>
        Friend Shared ReadOnly Property [ERR_OverridesImpliesOverridable] As String
          Get
            Return GetResourceString("ERR_OverridesImpliesOverridable")
          End Get
        End Property
        ''' <summary>'{0}' is already declared as a parameter of this method.</summary>
        Friend Shared ReadOnly Property [ERR_LocalNamedSameAsParam1] As String
          Get
            Return GetResourceString("ERR_LocalNamedSameAsParam1")
          End Get
        End Property
        ''' <summary>Variable '{0}' is already declared as a parameter of this or an enclosing lambda expression.</summary>
        Friend Shared ReadOnly Property [ERR_LocalNamedSameAsParamInLambda1] As String
          Get
            Return GetResourceString("ERR_LocalNamedSameAsParamInLambda1")
          End Get
        End Property
        ''' <summary>Type in a Module cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_ModuleCantUseTypeSpecifier1] As String
          Get
            Return GetResourceString("ERR_ModuleCantUseTypeSpecifier1")
          End Get
        End Property
        ''' <summary>No accessible 'Main' method with an appropriate signature was found in '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_InValidSubMainsFound1] As String
          Get
            Return GetResourceString("ERR_InValidSubMainsFound1")
          End Get
        End Property
        ''' <summary>'Sub Main' is declared more than once in '{0}': {1}</summary>
        Friend Shared ReadOnly Property [ERR_MoreThanOneValidMainWasFound2] As String
          Get
            Return GetResourceString("ERR_MoreThanOneValidMainWasFound2")
          End Get
        End Property
        ''' <summary>Value '{0}' cannot be converted to '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_CannotConvertValue2] As String
          Get
            Return GetResourceString("ERR_CannotConvertValue2")
          End Get
        End Property
        ''' <summary>'On Error' statements are not valid within 'SyncLock' statements.</summary>
        Friend Shared ReadOnly Property [ERR_OnErrorInSyncLock] As String
          Get
            Return GetResourceString("ERR_OnErrorInSyncLock")
          End Get
        End Property
        ''' <summary>Option Strict On disallows implicit conversions from '{0}' to '{1}'; the Visual Basic 6.0 collection type is not compatible with the .NET Framework collection type.</summary>
        Friend Shared ReadOnly Property [ERR_NarrowingConversionCollection2] As String
          Get
            Return GetResourceString("ERR_NarrowingConversionCollection2")
          End Get
        End Property
        ''' <summary>'GoTo {0}' is not valid because '{0}' is inside a 'Try', 'Catch' or 'Finally' statement that does not contain this statement.</summary>
        Friend Shared ReadOnly Property [ERR_GotoIntoTryHandler] As String
          Get
            Return GetResourceString("ERR_GotoIntoTryHandler")
          End Get
        End Property
        ''' <summary>'GoTo {0}' is not valid because '{0}' is inside a 'SyncLock' statement that does not contain this statement.</summary>
        Friend Shared ReadOnly Property [ERR_GotoIntoSyncLock] As String
          Get
            Return GetResourceString("ERR_GotoIntoSyncLock")
          End Get
        End Property
        ''' <summary>'GoTo {0}' is not valid because '{0}' is inside a 'With' statement that does not contain this statement.</summary>
        Friend Shared ReadOnly Property [ERR_GotoIntoWith] As String
          Get
            Return GetResourceString("ERR_GotoIntoWith")
          End Get
        End Property
        ''' <summary>'GoTo {0}' is not valid because '{0}' is inside a 'For' or 'For Each' statement that does not contain this statement.</summary>
        Friend Shared ReadOnly Property [ERR_GotoIntoFor] As String
          Get
            Return GetResourceString("ERR_GotoIntoFor")
          End Get
        End Property
        ''' <summary>Attribute cannot be used because it does not have a Public constructor.</summary>
        Friend Shared ReadOnly Property [ERR_BadAttributeNonPublicConstructor] As String
          Get
            Return GetResourceString("ERR_BadAttributeNonPublicConstructor")
          End Get
        End Property
        ''' <summary>Event '{0}' specified by the 'DefaultEvent' attribute is not a publicly accessible event for this class.</summary>
        Friend Shared ReadOnly Property [ERR_DefaultEventNotFound1] As String
          Get
            Return GetResourceString("ERR_DefaultEventNotFound1")
          End Get
        End Property
        ''' <summary>'NonSerialized' attribute will not have any effect on this member because its containing class is not exposed as 'Serializable'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidNonSerializedUsage] As String
          Get
            Return GetResourceString("ERR_InvalidNonSerializedUsage")
          End Get
        End Property
        ''' <summary>'Continue' must be followed by 'Do', 'For' or 'While'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedContinueKind] As String
          Get
            Return GetResourceString("ERR_ExpectedContinueKind")
          End Get
        End Property
        ''' <summary>'Continue Do' can only appear inside a 'Do' statement.</summary>
        Friend Shared ReadOnly Property [ERR_ContinueDoNotWithinDo] As String
          Get
            Return GetResourceString("ERR_ContinueDoNotWithinDo")
          End Get
        End Property
        ''' <summary>'Continue For' can only appear inside a 'For' statement.</summary>
        Friend Shared ReadOnly Property [ERR_ContinueForNotWithinFor] As String
          Get
            Return GetResourceString("ERR_ContinueForNotWithinFor")
          End Get
        End Property
        ''' <summary>'Continue While' can only appear inside a 'While' statement.</summary>
        Friend Shared ReadOnly Property [ERR_ContinueWhileNotWithinWhile] As String
          Get
            Return GetResourceString("ERR_ContinueWhileNotWithinWhile")
          End Get
        End Property
        ''' <summary>Parameter specifier is duplicated.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateParameterSpecifier] As String
          Get
            Return GetResourceString("ERR_DuplicateParameterSpecifier")
          End Get
        End Property
        ''' <summary>'Declare' statements in a Module cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_ModuleCantUseDLLDeclareSpecifier1] As String
          Get
            Return GetResourceString("ERR_ModuleCantUseDLLDeclareSpecifier1")
          End Get
        End Property
        ''' <summary>'Declare' statements in a structure cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_StructCantUseDLLDeclareSpecifier1] As String
          Get
            Return GetResourceString("ERR_StructCantUseDLLDeclareSpecifier1")
          End Get
        End Property
        ''' <summary>'TryCast' operand must be reference type, but '{0}' is a value type.</summary>
        Friend Shared ReadOnly Property [ERR_TryCastOfValueType1] As String
          Get
            Return GetResourceString("ERR_TryCastOfValueType1")
          End Get
        End Property
        ''' <summary>'TryCast' operands must be class-constrained type parameter, but '{0}' has no class constraint.</summary>
        Friend Shared ReadOnly Property [ERR_TryCastOfUnconstrainedTypeParam1] As String
          Get
            Return GetResourceString("ERR_TryCastOfUnconstrainedTypeParam1")
          End Get
        End Property
        ''' <summary>No accessible '{0}' is most specific: {1}</summary>
        Friend Shared ReadOnly Property [ERR_AmbiguousDelegateBinding2] As String
          Get
            Return GetResourceString("ERR_AmbiguousDelegateBinding2")
          End Get
        End Property
        ''' <summary>Non-shared members in a Structure cannot be declared 'New'.</summary>
        Friend Shared ReadOnly Property [ERR_SharedStructMemberCannotSpecifyNew] As String
          Get
            Return GetResourceString("ERR_SharedStructMemberCannotSpecifyNew")
          End Get
        End Property
        ''' <summary>None of the accessible 'Main' methods with the appropriate signatures found in '{0}' can be the startup method since they are all either generic or nested in generic types.</summary>
        Friend Shared ReadOnly Property [ERR_GenericSubMainsFound1] As String
          Get
            Return GetResourceString("ERR_GenericSubMainsFound1")
          End Get
        End Property
        ''' <summary>Error in project-level import '{0}' at '{1}' : {2}</summary>
        Friend Shared ReadOnly Property [ERR_GeneralProjectImportsError3] As String
          Get
            Return GetResourceString("ERR_GeneralProjectImportsError3")
          End Get
        End Property
        ''' <summary>'{1}' for the Imports alias to '{0}' does not refer to a Namespace, Class, Structure, Interface, Enum or Module.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidTypeForAliasesImport2] As String
          Get
            Return GetResourceString("ERR_InvalidTypeForAliasesImport2")
          End Get
        End Property
        ''' <summary>Field '{0}.{1}' has an invalid constant value.</summary>
        Friend Shared ReadOnly Property [ERR_UnsupportedConstant2] As String
          Get
            Return GetResourceString("ERR_UnsupportedConstant2")
          End Get
        End Property
        ''' <summary>Method arguments must be enclosed in parentheses.</summary>
        Friend Shared ReadOnly Property [ERR_ObsoleteArgumentsNeedParens] As String
          Get
            Return GetResourceString("ERR_ObsoleteArgumentsNeedParens")
          End Get
        End Property
        ''' <summary>Labels that are numbers must be followed by colons.</summary>
        Friend Shared ReadOnly Property [ERR_ObsoleteLineNumbersAreLabels] As String
          Get
            Return GetResourceString("ERR_ObsoleteLineNumbersAreLabels")
          End Get
        End Property
        ''' <summary>'Type' statements are no longer supported; use 'Structure' statements instead.</summary>
        Friend Shared ReadOnly Property [ERR_ObsoleteStructureNotType] As String
          Get
            Return GetResourceString("ERR_ObsoleteStructureNotType")
          End Get
        End Property
        ''' <summary>'Variant' is no longer a supported type; use the 'Object' type instead.</summary>
        Friend Shared ReadOnly Property [ERR_ObsoleteObjectNotVariant] As String
          Get
            Return GetResourceString("ERR_ObsoleteObjectNotVariant")
          End Get
        End Property
        ''' <summary>'Let' and 'Set' assignment statements are no longer supported.</summary>
        Friend Shared ReadOnly Property [ERR_ObsoleteLetSetNotNeeded] As String
          Get
            Return GetResourceString("ERR_ObsoleteLetSetNotNeeded")
          End Get
        End Property
        ''' <summary>Property Get/Let/Set are no longer supported; use the new Property declaration syntax.</summary>
        Friend Shared ReadOnly Property [ERR_ObsoletePropertyGetLetSet] As String
          Get
            Return GetResourceString("ERR_ObsoletePropertyGetLetSet")
          End Get
        End Property
        ''' <summary>'Wend' statements are no longer supported; use 'End While' statements instead.</summary>
        Friend Shared ReadOnly Property [ERR_ObsoleteWhileWend] As String
          Get
            Return GetResourceString("ERR_ObsoleteWhileWend")
          End Get
        End Property
        ''' <summary>'ReDim' statements can no longer be used to declare array variables.</summary>
        Friend Shared ReadOnly Property [ERR_ObsoleteRedimAs] As String
          Get
            Return GetResourceString("ERR_ObsoleteRedimAs")
          End Get
        End Property
        ''' <summary>Optional parameters must specify a default value.</summary>
        Friend Shared ReadOnly Property [ERR_ObsoleteOptionalWithoutValue] As String
          Get
            Return GetResourceString("ERR_ObsoleteOptionalWithoutValue")
          End Get
        End Property
        ''' <summary>'GoSub' statements are no longer supported.</summary>
        Friend Shared ReadOnly Property [ERR_ObsoleteGosub] As String
          Get
            Return GetResourceString("ERR_ObsoleteGosub")
          End Get
        End Property
        ''' <summary>'On GoTo' and 'On GoSub' statements are no longer supported.</summary>
        Friend Shared ReadOnly Property [ERR_ObsoleteOnGotoGosub] As String
          Get
            Return GetResourceString("ERR_ObsoleteOnGotoGosub")
          End Get
        End Property
        ''' <summary>'EndIf' statements are no longer supported; use 'End If' instead.</summary>
        Friend Shared ReadOnly Property [ERR_ObsoleteEndIf] As String
          Get
            Return GetResourceString("ERR_ObsoleteEndIf")
          End Get
        End Property
        ''' <summary>'D' can no longer be used to indicate an exponent, use 'E' instead.</summary>
        Friend Shared ReadOnly Property [ERR_ObsoleteExponent] As String
          Get
            Return GetResourceString("ERR_ObsoleteExponent")
          End Get
        End Property
        ''' <summary>'As Any' is not supported in 'Declare' statements.</summary>
        Friend Shared ReadOnly Property [ERR_ObsoleteAsAny] As String
          Get
            Return GetResourceString("ERR_ObsoleteAsAny")
          End Get
        End Property
        ''' <summary>'Get' statements are no longer supported. File I/O functionality is available in the 'Microsoft.VisualBasic' namespace.</summary>
        Friend Shared ReadOnly Property [ERR_ObsoleteGetStatement] As String
          Get
            Return GetResourceString("ERR_ObsoleteGetStatement")
          End Get
        End Property
        ''' <summary>'{0}' cannot override '{1}' because they differ by parameters declared 'ParamArray'.</summary>
        Friend Shared ReadOnly Property [ERR_OverrideWithArrayVsParamArray2] As String
          Get
            Return GetResourceString("ERR_OverrideWithArrayVsParamArray2")
          End Get
        End Property
        ''' <summary>This inheritance causes circular dependencies between {0} '{1}' and its nested or base type '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_CircularBaseDependencies4] As String
          Get
            Return GetResourceString("ERR_CircularBaseDependencies4")
          End Get
        End Property
        ''' <summary>{0} '{1}' cannot inherit from a type nested within it.</summary>
        Friend Shared ReadOnly Property [ERR_NestedBase2] As String
          Get
            Return GetResourceString("ERR_NestedBase2")
          End Get
        End Property
        ''' <summary>'{0}' cannot expose type '{1}' outside the project through {2} '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_AccessMismatchOutsideAssembly4] As String
          Get
            Return GetResourceString("ERR_AccessMismatchOutsideAssembly4")
          End Get
        End Property
        ''' <summary>'{0}' cannot inherit from {1} '{2}' because it expands the access of the base {1} outside the assembly.</summary>
        Friend Shared ReadOnly Property [ERR_InheritanceAccessMismatchOutside3] As String
          Get
            Return GetResourceString("ERR_InheritanceAccessMismatchOutside3")
          End Get
        End Property
        ''' <summary>'{0}' accessor of '{1}' is obsolete: '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_UseOfObsoletePropertyAccessor3] As String
          Get
            Return GetResourceString("ERR_UseOfObsoletePropertyAccessor3")
          End Get
        End Property
        ''' <summary>'{0}' accessor of '{1}' is obsolete.</summary>
        Friend Shared ReadOnly Property [ERR_UseOfObsoletePropertyAccessor2] As String
          Get
            Return GetResourceString("ERR_UseOfObsoletePropertyAccessor2")
          End Get
        End Property
        ''' <summary>'{0}' cannot expose the underlying delegate type '{1}' of the event it is implementing to {2} '{3}' through {4} '{5}'.</summary>
        Friend Shared ReadOnly Property [ERR_AccessMismatchImplementedEvent6] As String
          Get
            Return GetResourceString("ERR_AccessMismatchImplementedEvent6")
          End Get
        End Property
        ''' <summary>'{0}' cannot expose the underlying delegate type '{1}' of the event it is implementing outside the project through {2} '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_AccessMismatchImplementedEvent4] As String
          Get
            Return GetResourceString("ERR_AccessMismatchImplementedEvent4")
          End Get
        End Property
        ''' <summary>Type '{0}' is not supported because it either directly or indirectly inherits from itself.</summary>
        Friend Shared ReadOnly Property [ERR_InheritanceCycleInImportedType1] As String
          Get
            Return GetResourceString("ERR_InheritanceCycleInImportedType1")
          End Get
        End Property
        ''' <summary>Class '{0}' must declare a 'Sub New' because the '{1}' in its base class '{2}' is marked obsolete.</summary>
        Friend Shared ReadOnly Property [ERR_NoNonObsoleteConstructorOnBase3] As String
          Get
            Return GetResourceString("ERR_NoNonObsoleteConstructorOnBase3")
          End Get
        End Property
        ''' <summary>Class '{0}' must declare a 'Sub New' because the '{1}' in its base class '{2}' is marked obsolete: '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_NoNonObsoleteConstructorOnBase4] As String
          Get
            Return GetResourceString("ERR_NoNonObsoleteConstructorOnBase4")
          End Get
        End Property
        ''' <summary>First statement of this 'Sub New' must be an explicit call to 'MyBase.New' or 'MyClass.New' because the '{0}' in the base class '{1}' of '{2}' is marked obsolete.</summary>
        Friend Shared ReadOnly Property [ERR_RequiredNonObsoleteNewCall3] As String
          Get
            Return GetResourceString("ERR_RequiredNonObsoleteNewCall3")
          End Get
        End Property
        ''' <summary>First statement of this 'Sub New' must be an explicit call to 'MyBase.New' or 'MyClass.New' because the '{0}' in the base class '{1}' of '{2}' is marked obsolete: '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_RequiredNonObsoleteNewCall4] As String
          Get
            Return GetResourceString("ERR_RequiredNonObsoleteNewCall4")
          End Get
        End Property
        ''' <summary>'{0}' cannot inherit from {1} '{2}' because it expands the access of type '{3}' to {4} '{5}'.</summary>
        Friend Shared ReadOnly Property [ERR_InheritsTypeArgAccessMismatch7] As String
          Get
            Return GetResourceString("ERR_InheritsTypeArgAccessMismatch7")
          End Get
        End Property
        ''' <summary>'{0}' cannot inherit from {1} '{2}' because it expands the access of type '{3}' outside the assembly.</summary>
        Friend Shared ReadOnly Property [ERR_InheritsTypeArgAccessMismatchOutside5] As String
          Get
            Return GetResourceString("ERR_InheritsTypeArgAccessMismatchOutside5")
          End Get
        End Property
        ''' <summary>Specified access '{0}' for '{1}' does not match the access '{2}' specified on one of its other partial types.</summary>
        Friend Shared ReadOnly Property [ERR_PartialTypeAccessMismatch3] As String
          Get
            Return GetResourceString("ERR_PartialTypeAccessMismatch3")
          End Get
        End Property
        ''' <summary>'MustInherit' cannot be specified for partial type '{0}' because it cannot be combined with 'NotInheritable' specified for one of its other partial types.</summary>
        Friend Shared ReadOnly Property [ERR_PartialTypeBadMustInherit1] As String
          Get
            Return GetResourceString("ERR_PartialTypeBadMustInherit1")
          End Get
        End Property
        ''' <summary>'MustOverride' cannot be specified on this member because it is in a partial type that is declared 'NotInheritable' in another partial definition.</summary>
        Friend Shared ReadOnly Property [ERR_MustOverOnNotInheritPartClsMem1] As String
          Get
            Return GetResourceString("ERR_MustOverOnNotInheritPartClsMem1")
          End Get
        End Property
        ''' <summary>Base class '{0}' specified for class '{1}' cannot be different from the base class '{2}' of one of its other partial types.</summary>
        Friend Shared ReadOnly Property [ERR_BaseMismatchForPartialClass3] As String
          Get
            Return GetResourceString("ERR_BaseMismatchForPartialClass3")
          End Get
        End Property
        ''' <summary>Type parameter name '{0}' does not match the name '{1}' of the corresponding type parameter defined on one of the other partial types of '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_PartialTypeTypeParamNameMismatch3] As String
          Get
            Return GetResourceString("ERR_PartialTypeTypeParamNameMismatch3")
          End Get
        End Property
        ''' <summary>Constraints for this type parameter do not match the constraints on the corresponding type parameter defined on one of the other partial types of '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_PartialTypeConstraintMismatch1] As String
          Get
            Return GetResourceString("ERR_PartialTypeConstraintMismatch1")
          End Get
        End Property
        ''' <summary>Late bound overload resolution cannot be applied to '{0}' because the accessing instance is an interface type.</summary>
        Friend Shared ReadOnly Property [ERR_LateBoundOverloadInterfaceCall1] As String
          Get
            Return GetResourceString("ERR_LateBoundOverloadInterfaceCall1")
          End Get
        End Property
        ''' <summary>Conversion from '{0}' to '{1}' cannot occur in a constant expression used as an argument to an attribute.</summary>
        Friend Shared ReadOnly Property [ERR_RequiredAttributeConstConversion2] As String
          Get
            Return GetResourceString("ERR_RequiredAttributeConstConversion2")
          End Get
        End Property
        ''' <summary>Member '{0}' that matches this signature cannot be overridden because the class '{1}' contains multiple members with this same name and signature: {2}</summary>
        Friend Shared ReadOnly Property [ERR_AmbiguousOverrides3] As String
          Get
            Return GetResourceString("ERR_AmbiguousOverrides3")
          End Get
        End Property
        ''' <summary>'{0}'</summary>
        Friend Shared ReadOnly Property [ERR_OverriddenCandidate1] As String
          Get
            Return GetResourceString("ERR_OverriddenCandidate1")
          End Get
        End Property
        ''' <summary>Member '{0}.{1}' that matches this signature cannot be implemented because the interface '{2}' contains multiple members with this same name and signature:
        '''    '{3}'
        '''    '{4}'</summary>
        Friend Shared ReadOnly Property [ERR_AmbiguousImplements3] As String
          Get
            Return GetResourceString("ERR_AmbiguousImplements3")
          End Get
        End Property
        ''' <summary>'AddressOf' expression cannot be converted to '{0}' because type '{0}' is declared 'MustInherit' and cannot be created.</summary>
        Friend Shared ReadOnly Property [ERR_AddressOfNotCreatableDelegate1] As String
          Get
            Return GetResourceString("ERR_AddressOfNotCreatableDelegate1")
          End Get
        End Property
        ''' <summary>Generic methods cannot be exposed to COM.</summary>
        Friend Shared ReadOnly Property [ERR_ComClassGenericMethod] As String
          Get
            Return GetResourceString("ERR_ComClassGenericMethod")
          End Get
        End Property
        ''' <summary>Syntax error in cast operator; two arguments separated by comma are required.</summary>
        Friend Shared ReadOnly Property [ERR_SyntaxInCastOp] As String
          Get
            Return GetResourceString("ERR_SyntaxInCastOp")
          End Get
        End Property
        ''' <summary>Array initializer cannot be specified for a non constant dimension; use the empty initializer '{}'.</summary>
        Friend Shared ReadOnly Property [ERR_ArrayInitializerForNonConstDim] As String
          Get
            Return GetResourceString("ERR_ArrayInitializerForNonConstDim")
          End Get
        End Property
        ''' <summary>No accessible method '{0}' has a signature compatible with delegate '{1}':{2}</summary>
        Friend Shared ReadOnly Property [ERR_DelegateBindingFailure3] As String
          Get
            Return GetResourceString("ERR_DelegateBindingFailure3")
          End Get
        End Property
        ''' <summary>Attribute 'StructLayout' cannot be applied to a generic type.</summary>
        Friend Shared ReadOnly Property [ERR_StructLayoutAttributeNotAllowed] As String
          Get
            Return GetResourceString("ERR_StructLayoutAttributeNotAllowed")
          End Get
        End Property
        ''' <summary>Range variable '{0}' hides a variable in an enclosing block or a range variable previously defined in the query expression.</summary>
        Friend Shared ReadOnly Property [ERR_IterationVariableShadowLocal1] As String
          Get
            Return GetResourceString("ERR_IterationVariableShadowLocal1")
          End Get
        End Property
        ''' <summary>'Option Infer' can be followed only by 'On' or 'Off'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidOptionInfer] As String
          Get
            Return GetResourceString("ERR_InvalidOptionInfer")
          End Get
        End Property
        ''' <summary>Type of '{0}' cannot be inferred from an expression containing '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_CircularInference1] As String
          Get
            Return GetResourceString("ERR_CircularInference1")
          End Get
        End Property
        ''' <summary>'{0}' in class '{1}' cannot override '{2}' in class '{3}' because an intermediate class '{4}' overrides '{2}' in class '{3}' but is not accessible.</summary>
        Friend Shared ReadOnly Property [ERR_InAccessibleOverridingMethod5] As String
          Get
            Return GetResourceString("ERR_InAccessibleOverridingMethod5")
          End Get
        End Property
        ''' <summary>Type of '{0}' cannot be inferred because the loop bounds and the step clause do not convert to the same type.</summary>
        Friend Shared ReadOnly Property [ERR_NoSuitableWidestType1] As String
          Get
            Return GetResourceString("ERR_NoSuitableWidestType1")
          End Get
        End Property
        ''' <summary>Type of '{0}' is ambiguous because the loop bounds and the step clause do not convert to the same type.</summary>
        Friend Shared ReadOnly Property [ERR_AmbiguousWidestType3] As String
          Get
            Return GetResourceString("ERR_AmbiguousWidestType3")
          End Get
        End Property
        ''' <summary>'=' expected (object initializer).</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedAssignmentOperatorInInit] As String
          Get
            Return GetResourceString("ERR_ExpectedAssignmentOperatorInInit")
          End Get
        End Property
        ''' <summary>Name of field or property being initialized in an object initializer must start with '.'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedQualifiedNameInInit] As String
          Get
            Return GetResourceString("ERR_ExpectedQualifiedNameInInit")
          End Get
        End Property
        ''' <summary>'{' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedLbrace] As String
          Get
            Return GetResourceString("ERR_ExpectedLbrace")
          End Get
        End Property
        ''' <summary>Type or 'With' expected.</summary>
        Friend Shared ReadOnly Property [ERR_UnrecognizedTypeOrWith] As String
          Get
            Return GetResourceString("ERR_UnrecognizedTypeOrWith")
          End Get
        End Property
        ''' <summary>Multiple initializations of '{0}'.  Fields and properties can be initialized only once in an object initializer expression.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateAggrMemberInit1] As String
          Get
            Return GetResourceString("ERR_DuplicateAggrMemberInit1")
          End Get
        End Property
        ''' <summary>Member '{0}' cannot be initialized in an object initializer expression because it is not a field or property.</summary>
        Friend Shared ReadOnly Property [ERR_NonFieldPropertyAggrMemberInit1] As String
          Get
            Return GetResourceString("ERR_NonFieldPropertyAggrMemberInit1")
          End Get
        End Property
        ''' <summary>Member '{0}' cannot be initialized in an object initializer expression because it is shared.</summary>
        Friend Shared ReadOnly Property [ERR_SharedMemberAggrMemberInit1] As String
          Get
            Return GetResourceString("ERR_SharedMemberAggrMemberInit1")
          End Get
        End Property
        ''' <summary>Property '{0}' cannot be initialized in an object initializer expression because it requires arguments.</summary>
        Friend Shared ReadOnly Property [ERR_ParameterizedPropertyInAggrInit1] As String
          Get
            Return GetResourceString("ERR_ParameterizedPropertyInAggrInit1")
          End Get
        End Property
        ''' <summary>Property '{0}' cannot be initialized in an object initializer expression because all accessible overloads require arguments.</summary>
        Friend Shared ReadOnly Property [ERR_NoZeroCountArgumentInitCandidates1] As String
          Get
            Return GetResourceString("ERR_NoZeroCountArgumentInitCandidates1")
          End Get
        End Property
        ''' <summary>Object initializer syntax cannot be used to initialize an instance of 'System.Object'.</summary>
        Friend Shared ReadOnly Property [ERR_AggrInitInvalidForObject] As String
          Get
            Return GetResourceString("ERR_AggrInitInvalidForObject")
          End Get
        End Property
        ''' <summary>Initializer expected.</summary>
        Friend Shared ReadOnly Property [ERR_InitializerExpected] As String
          Get
            Return GetResourceString("ERR_InitializerExpected")
          End Get
        End Property
        ''' <summary>The line continuation character '_' must be preceded by at least one white space and it must be followed by a comment or the '_' must be the last character on the line.</summary>
        Friend Shared ReadOnly Property [ERR_LineContWithCommentOrNoPrecSpace] As String
          Get
            Return GetResourceString("ERR_LineContWithCommentOrNoPrecSpace")
          End Get
        End Property
        ''' <summary>Please use language version {0} or greater to use comments after line continuation character.</summary>
        Friend Shared ReadOnly Property [ERR_CommentsAfterLineContinuationNotAvailable1] As String
          Get
            Return GetResourceString("ERR_CommentsAfterLineContinuationNotAvailable1")
          End Get
        End Property
        ''' <summary>Unable to load module file '{0}': {1}</summary>
        Friend Shared ReadOnly Property [ERR_BadModuleFile1] As String
          Get
            Return GetResourceString("ERR_BadModuleFile1")
          End Get
        End Property
        ''' <summary>Unable to load referenced library '{0}': {1}</summary>
        Friend Shared ReadOnly Property [ERR_BadRefLib1] As String
          Get
            Return GetResourceString("ERR_BadRefLib1")
          End Get
        End Property
        ''' <summary>Method '{0}' cannot handle event '{1}' because they do not have a compatible signature.</summary>
        Friend Shared ReadOnly Property [ERR_EventHandlerSignatureIncompatible2] As String
          Get
            Return GetResourceString("ERR_EventHandlerSignatureIncompatible2")
          End Get
        End Property
        ''' <summary>Conditional compilation constant '{1}' is not valid: {0}</summary>
        Friend Shared ReadOnly Property [ERR_ConditionalCompilationConstantNotValid] As String
          Get
            Return GetResourceString("ERR_ConditionalCompilationConstantNotValid")
          End Get
        End Property
        ''' <summary>Interface '{0}' can be implemented only once by this type.</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceImplementedTwice1] As String
          Get
            Return GetResourceString("ERR_InterfaceImplementedTwice1")
          End Get
        End Property
        ''' <summary>Interface '{0}' can be implemented only once by this type, but already appears with different tuple element names, as '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceImplementedTwiceWithDifferentTupleNames2] As String
          Get
            Return GetResourceString("ERR_InterfaceImplementedTwiceWithDifferentTupleNames2")
          End Get
        End Property
        ''' <summary>Interface '{0}' can be implemented only once by this type, but already appears with different tuple element names, as '{1}' (via '{2}').</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceImplementedTwiceWithDifferentTupleNames3] As String
          Get
            Return GetResourceString("ERR_InterfaceImplementedTwiceWithDifferentTupleNames3")
          End Get
        End Property
        ''' <summary>Interface '{0}' (via '{1}') can be implemented only once by this type, but already appears with different tuple element names, as '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceImplementedTwiceWithDifferentTupleNamesReverse3] As String
          Get
            Return GetResourceString("ERR_InterfaceImplementedTwiceWithDifferentTupleNamesReverse3")
          End Get
        End Property
        ''' <summary>Interface '{0}' (via '{1}') can be implemented only once by this type, but already appears with different tuple element names, as '{2}' (via '{3}').</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceImplementedTwiceWithDifferentTupleNames4] As String
          Get
            Return GetResourceString("ERR_InterfaceImplementedTwiceWithDifferentTupleNames4")
          End Get
        End Property
        ''' <summary>Interface '{0}' can be inherited only once by this interface, but already appears with different tuple element names, as '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceInheritedTwiceWithDifferentTupleNames2] As String
          Get
            Return GetResourceString("ERR_InterfaceInheritedTwiceWithDifferentTupleNames2")
          End Get
        End Property
        ''' <summary>Interface '{0}' can be inherited only once by this interface, but already appears with different tuple element names, as '{1}' (via '{2}').</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceInheritedTwiceWithDifferentTupleNames3] As String
          Get
            Return GetResourceString("ERR_InterfaceInheritedTwiceWithDifferentTupleNames3")
          End Get
        End Property
        ''' <summary>Interface '{0}' (via '{1}') can be inherited only once by this interface, but already appears with different tuple element names, as '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceInheritedTwiceWithDifferentTupleNamesReverse3] As String
          Get
            Return GetResourceString("ERR_InterfaceInheritedTwiceWithDifferentTupleNamesReverse3")
          End Get
        End Property
        ''' <summary>Interface '{0}' (via '{1}') can be inherited only once by this interface, but already appears with different tuple element names, as '{2}' (via '{3}').</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceInheritedTwiceWithDifferentTupleNames4] As String
          Get
            Return GetResourceString("ERR_InterfaceInheritedTwiceWithDifferentTupleNames4")
          End Get
        End Property
        ''' <summary>Interface '{0}' is not implemented by this class.</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceNotImplemented1] As String
          Get
            Return GetResourceString("ERR_InterfaceNotImplemented1")
          End Get
        End Property
        ''' <summary>'{0}' exists in multiple base interfaces. Use the name of the interface that declares '{0}' in the 'Implements' clause instead of the name of the derived interface.</summary>
        Friend Shared ReadOnly Property [ERR_AmbiguousImplementsMember3] As String
          Get
            Return GetResourceString("ERR_AmbiguousImplementsMember3")
          End Get
        End Property
        ''' <summary>'Sub New' cannot implement interface members.</summary>
        Friend Shared ReadOnly Property [ERR_ImplementsOnNew] As String
          Get
            Return GetResourceString("ERR_ImplementsOnNew")
          End Get
        End Property
        ''' <summary>Arrays declared as structure members cannot be declared with an initial size.</summary>
        Friend Shared ReadOnly Property [ERR_ArrayInitInStruct] As String
          Get
            Return GetResourceString("ERR_ArrayInitInStruct")
          End Get
        End Property
        ''' <summary>Events declared with an 'As' clause must have a delegate type.</summary>
        Friend Shared ReadOnly Property [ERR_EventTypeNotDelegate] As String
          Get
            Return GetResourceString("ERR_EventTypeNotDelegate")
          End Get
        End Property
        ''' <summary>Protected types can only be declared inside of a class.</summary>
        Friend Shared ReadOnly Property [ERR_ProtectedTypeOutsideClass] As String
          Get
            Return GetResourceString("ERR_ProtectedTypeOutsideClass")
          End Get
        End Property
        ''' <summary>Properties with no required parameters cannot be declared 'Default'.</summary>
        Friend Shared ReadOnly Property [ERR_DefaultPropertyWithNoParams] As String
          Get
            Return GetResourceString("ERR_DefaultPropertyWithNoParams")
          End Get
        End Property
        ''' <summary>Initializers on structure members are valid only for 'Shared' members and constants.</summary>
        Friend Shared ReadOnly Property [ERR_InitializerInStruct] As String
          Get
            Return GetResourceString("ERR_InitializerInStruct")
          End Get
        End Property
        ''' <summary>Namespace or type '{0}' has already been imported.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateImport1] As String
          Get
            Return GetResourceString("ERR_DuplicateImport1")
          End Get
        End Property
        ''' <summary>Modules cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadModuleFlags1] As String
          Get
            Return GetResourceString("ERR_BadModuleFlags1")
          End Get
        End Property
        ''' <summary>'Implements' statements must follow any 'Inherits' statement and precede all declarations in a class.</summary>
        Friend Shared ReadOnly Property [ERR_ImplementsStmtWrongOrder] As String
          Get
            Return GetResourceString("ERR_ImplementsStmtWrongOrder")
          End Get
        End Property
        ''' <summary>{0} '{1}' implicitly defines '{2}', which conflicts with a member implicitly declared for {3} '{4}' in {5} '{6}'.</summary>
        Friend Shared ReadOnly Property [ERR_SynthMemberClashesWithSynth7] As String
          Get
            Return GetResourceString("ERR_SynthMemberClashesWithSynth7")
          End Get
        End Property
        ''' <summary>{0} '{1}' implicitly defines '{2}', which conflicts with a member of the same name in {3} '{4}'.</summary>
        Friend Shared ReadOnly Property [ERR_SynthMemberClashesWithMember5] As String
          Get
            Return GetResourceString("ERR_SynthMemberClashesWithMember5")
          End Get
        End Property
        ''' <summary>{0} '{1}' conflicts with a member implicitly declared for {2} '{3}' in {4} '{5}'.</summary>
        Friend Shared ReadOnly Property [ERR_MemberClashesWithSynth6] As String
          Get
            Return GetResourceString("ERR_MemberClashesWithSynth6")
          End Get
        End Property
        ''' <summary>{0} '{1}' conflicts with a Visual Basic Runtime {2} '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_TypeClashesWithVbCoreType4] As String
          Get
            Return GetResourceString("ERR_TypeClashesWithVbCoreType4")
          End Get
        End Property
        ''' <summary>First argument to a security attribute must be a valid SecurityAction.</summary>
        Friend Shared ReadOnly Property [ERR_SecurityAttributeMissingAction] As String
          Get
            Return GetResourceString("ERR_SecurityAttributeMissingAction")
          End Get
        End Property
        ''' <summary>Security attribute '{0}' has an invalid SecurityAction value '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_SecurityAttributeInvalidAction] As String
          Get
            Return GetResourceString("ERR_SecurityAttributeInvalidAction")
          End Get
        End Property
        ''' <summary>SecurityAction value '{0}' is invalid for security attributes applied to an assembly.</summary>
        Friend Shared ReadOnly Property [ERR_SecurityAttributeInvalidActionAssembly] As String
          Get
            Return GetResourceString("ERR_SecurityAttributeInvalidActionAssembly")
          End Get
        End Property
        ''' <summary>SecurityAction value '{0}' is invalid for security attributes applied to a type or a method.</summary>
        Friend Shared ReadOnly Property [ERR_SecurityAttributeInvalidActionTypeOrMethod] As String
          Get
            Return GetResourceString("ERR_SecurityAttributeInvalidActionTypeOrMethod")
          End Get
        End Property
        ''' <summary>SecurityAction value '{0}' is invalid for PrincipalPermission attribute.</summary>
        Friend Shared ReadOnly Property [ERR_PrincipalPermissionInvalidAction] As String
          Get
            Return GetResourceString("ERR_PrincipalPermissionInvalidAction")
          End Get
        End Property
        ''' <summary>Unable to resolve file path '{0}' specified for the named argument '{1}' for PermissionSet attribute.</summary>
        Friend Shared ReadOnly Property [ERR_PermissionSetAttributeInvalidFile] As String
          Get
            Return GetResourceString("ERR_PermissionSetAttributeInvalidFile")
          End Get
        End Property
        ''' <summary>Error reading file '{0}' specified for the named argument '{1}' for PermissionSet attribute: '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_PermissionSetAttributeFileReadError] As String
          Get
            Return GetResourceString("ERR_PermissionSetAttributeFileReadError")
          End Get
        End Property
        ''' <summary>'Set' method cannot have more than one parameter.</summary>
        Friend Shared ReadOnly Property [ERR_SetHasOnlyOneParam] As String
          Get
            Return GetResourceString("ERR_SetHasOnlyOneParam")
          End Get
        End Property
        ''' <summary>'Set' parameter must have the same type as the containing property.</summary>
        Friend Shared ReadOnly Property [ERR_SetValueNotPropertyType] As String
          Get
            Return GetResourceString("ERR_SetValueNotPropertyType")
          End Get
        End Property
        ''' <summary>'Set' parameter cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_SetHasToBeByVal1] As String
          Get
            Return GetResourceString("ERR_SetHasToBeByVal1")
          End Get
        End Property
        ''' <summary>Method in a structure cannot be declared 'Protected', 'Protected Friend', or 'Private Protected'.</summary>
        Friend Shared ReadOnly Property [ERR_StructureCantUseProtected] As String
          Get
            Return GetResourceString("ERR_StructureCantUseProtected")
          End Get
        End Property
        ''' <summary>Delegate in an interface cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadInterfaceDelegateSpecifier1] As String
          Get
            Return GetResourceString("ERR_BadInterfaceDelegateSpecifier1")
          End Get
        End Property
        ''' <summary>Enum in an interface cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadInterfaceEnumSpecifier1] As String
          Get
            Return GetResourceString("ERR_BadInterfaceEnumSpecifier1")
          End Get
        End Property
        ''' <summary>Class in an interface cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadInterfaceClassSpecifier1] As String
          Get
            Return GetResourceString("ERR_BadInterfaceClassSpecifier1")
          End Get
        End Property
        ''' <summary>Structure in an interface cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadInterfaceStructSpecifier1] As String
          Get
            Return GetResourceString("ERR_BadInterfaceStructSpecifier1")
          End Get
        End Property
        ''' <summary>Interface in an interface cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadInterfaceInterfaceSpecifier1] As String
          Get
            Return GetResourceString("ERR_BadInterfaceInterfaceSpecifier1")
          End Get
        End Property
        ''' <summary>'{0}' is obsolete.</summary>
        Friend Shared ReadOnly Property [ERR_UseOfObsoleteSymbolNoMessage1] As String
          Get
            Return GetResourceString("ERR_UseOfObsoleteSymbolNoMessage1")
          End Get
        End Property
        ''' <summary>'{0}' is a module and cannot be referenced as an assembly.</summary>
        Friend Shared ReadOnly Property [ERR_MetaDataIsNotAssembly] As String
          Get
            Return GetResourceString("ERR_MetaDataIsNotAssembly")
          End Get
        End Property
        ''' <summary>'{0}' is an assembly and cannot be referenced as a module.</summary>
        Friend Shared ReadOnly Property [ERR_MetaDataIsNotModule] As String
          Get
            Return GetResourceString("ERR_MetaDataIsNotModule")
          End Get
        End Property
        ''' <summary>Operator '{0}' is not defined for types '{1}' and '{2}'. Use 'Is' operator to compare two reference types.</summary>
        Friend Shared ReadOnly Property [ERR_ReferenceComparison3] As String
          Get
            Return GetResourceString("ERR_ReferenceComparison3")
          End Get
        End Property
        ''' <summary>'{0}' is not a local variable or parameter, and so cannot be used as a 'Catch' variable.</summary>
        Friend Shared ReadOnly Property [ERR_CatchVariableNotLocal1] As String
          Get
            Return GetResourceString("ERR_CatchVariableNotLocal1")
          End Get
        End Property
        ''' <summary>Members in a Module cannot implement interface members.</summary>
        Friend Shared ReadOnly Property [ERR_ModuleMemberCantImplement] As String
          Get
            Return GetResourceString("ERR_ModuleMemberCantImplement")
          End Get
        End Property
        ''' <summary>Events cannot be declared with a delegate type that has a return type.</summary>
        Friend Shared ReadOnly Property [ERR_EventDelegatesCantBeFunctions] As String
          Get
            Return GetResourceString("ERR_EventDelegatesCantBeFunctions")
          End Get
        End Property
        ''' <summary>Date constant is not valid.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidDate] As String
          Get
            Return GetResourceString("ERR_InvalidDate")
          End Get
        End Property
        ''' <summary>'{0}' cannot override '{1}' because it is not declared 'Overridable'.</summary>
        Friend Shared ReadOnly Property [ERR_CantOverride4] As String
          Get
            Return GetResourceString("ERR_CantOverride4")
          End Get
        End Property
        ''' <summary>Array modifiers cannot be specified on both a variable and its type.</summary>
        Friend Shared ReadOnly Property [ERR_CantSpecifyArraysOnBoth] As String
          Get
            Return GetResourceString("ERR_CantSpecifyArraysOnBoth")
          End Get
        End Property
        ''' <summary>'NotOverridable' cannot be specified for methods that do not override another method.</summary>
        Friend Shared ReadOnly Property [ERR_NotOverridableRequiresOverrides] As String
          Get
            Return GetResourceString("ERR_NotOverridableRequiresOverrides")
          End Get
        End Property
        ''' <summary>Types declared 'Private' must be inside another type.</summary>
        Friend Shared ReadOnly Property [ERR_PrivateTypeOutsideType] As String
          Get
            Return GetResourceString("ERR_PrivateTypeOutsideType")
          End Get
        End Property
        ''' <summary>Import of type '{0}' from assembly or module '{1}' failed.</summary>
        Friend Shared ReadOnly Property [ERR_TypeRefResolutionError3] As String
          Get
            Return GetResourceString("ERR_TypeRefResolutionError3")
          End Get
        End Property
        ''' <summary>Predefined type '{0}' is not defined or imported.</summary>
        Friend Shared ReadOnly Property [ERR_ValueTupleTypeRefResolutionError1] As String
          Get
            Return GetResourceString("ERR_ValueTupleTypeRefResolutionError1")
          End Get
        End Property
        ''' <summary>ParamArray parameters must have an array type.</summary>
        Friend Shared ReadOnly Property [ERR_ParamArrayWrongType] As String
          Get
            Return GetResourceString("ERR_ParamArrayWrongType")
          End Get
        End Property
        ''' <summary>Implementing class '{0}' for interface '{1}' cannot be found.</summary>
        Friend Shared ReadOnly Property [ERR_CoClassMissing2] As String
          Get
            Return GetResourceString("ERR_CoClassMissing2")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used as an implementing class.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidCoClass1] As String
          Get
            Return GetResourceString("ERR_InvalidCoClass1")
          End Get
        End Property
        ''' <summary>Reference to object under construction is not valid when calling another constructor.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidMeReference] As String
          Get
            Return GetResourceString("ERR_InvalidMeReference")
          End Get
        End Property
        ''' <summary>Implicit reference to object under construction is not valid when calling another constructor.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidImplicitMeReference] As String
          Get
            Return GetResourceString("ERR_InvalidImplicitMeReference")
          End Get
        End Property
        ''' <summary>Member '{0}' cannot be found in class '{1}'. This condition is usually the result of a mismatched 'Microsoft.VisualBasic.dll'.</summary>
        Friend Shared ReadOnly Property [ERR_RuntimeMemberNotFound2] As String
          Get
            Return GetResourceString("ERR_RuntimeMemberNotFound2")
          End Get
        End Property
        ''' <summary>Property accessors cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadPropertyAccessorFlags] As String
          Get
            Return GetResourceString("ERR_BadPropertyAccessorFlags")
          End Get
        End Property
        ''' <summary>Access modifier '{0}' is not valid. The access modifier of 'Get' and 'Set' should be more restrictive than the property access level.</summary>
        Friend Shared ReadOnly Property [ERR_BadPropertyAccessorFlagsRestrict] As String
          Get
            Return GetResourceString("ERR_BadPropertyAccessorFlagsRestrict")
          End Get
        End Property
        ''' <summary>Access modifier can only be applied to either 'Get' or 'Set', but not both.</summary>
        Friend Shared ReadOnly Property [ERR_OnlyOneAccessorForGetSet] As String
          Get
            Return GetResourceString("ERR_OnlyOneAccessorForGetSet")
          End Get
        End Property
        ''' <summary>'Set' accessor of property '{0}' is not accessible.</summary>
        Friend Shared ReadOnly Property [ERR_NoAccessibleSet] As String
          Get
            Return GetResourceString("ERR_NoAccessibleSet")
          End Get
        End Property
        ''' <summary>'Get' accessor of property '{0}' is not accessible.</summary>
        Friend Shared ReadOnly Property [ERR_NoAccessibleGet] As String
          Get
            Return GetResourceString("ERR_NoAccessibleGet")
          End Get
        End Property
        ''' <summary>'WriteOnly' properties cannot have an access modifier on 'Set'.</summary>
        Friend Shared ReadOnly Property [ERR_WriteOnlyNoAccessorFlag] As String
          Get
            Return GetResourceString("ERR_WriteOnlyNoAccessorFlag")
          End Get
        End Property
        ''' <summary>'ReadOnly' properties cannot have an access modifier on 'Get'.</summary>
        Friend Shared ReadOnly Property [ERR_ReadOnlyNoAccessorFlag] As String
          Get
            Return GetResourceString("ERR_ReadOnlyNoAccessorFlag")
          End Get
        End Property
        ''' <summary>Property accessors cannot be declared '{0}' in a 'NotOverridable' property.</summary>
        Friend Shared ReadOnly Property [ERR_BadPropertyAccessorFlags1] As String
          Get
            Return GetResourceString("ERR_BadPropertyAccessorFlags1")
          End Get
        End Property
        ''' <summary>Property accessors cannot be declared '{0}' in a 'Default' property.</summary>
        Friend Shared ReadOnly Property [ERR_BadPropertyAccessorFlags2] As String
          Get
            Return GetResourceString("ERR_BadPropertyAccessorFlags2")
          End Get
        End Property
        ''' <summary>Property cannot be declared '{0}' because it contains a 'Private' accessor.</summary>
        Friend Shared ReadOnly Property [ERR_BadPropertyAccessorFlags3] As String
          Get
            Return GetResourceString("ERR_BadPropertyAccessorFlags3")
          End Get
        End Property
        ''' <summary>Implementing class '{0}' for interface '{1}' is not accessible in this context because it is '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_InAccessibleCoClass3] As String
          Get
            Return GetResourceString("ERR_InAccessibleCoClass3")
          End Get
        End Property
        ''' <summary>Arrays used as attribute arguments are required to explicitly specify values for all elements.</summary>
        Friend Shared ReadOnly Property [ERR_MissingValuesForArraysInApplAttrs] As String
          Get
            Return GetResourceString("ERR_MissingValuesForArraysInApplAttrs")
          End Get
        End Property
        ''' <summary>'Exit AddHandler', 'Exit RemoveHandler' and 'Exit RaiseEvent' are not valid. Use 'Return' to exit from event members.</summary>
        Friend Shared ReadOnly Property [ERR_ExitEventMemberNotInvalid] As String
          Get
            Return GetResourceString("ERR_ExitEventMemberNotInvalid")
          End Get
        End Property
        ''' <summary>Statement cannot appear within an event body. End of event assumed.</summary>
        Friend Shared ReadOnly Property [ERR_InvInsideEndsEvent] As String
          Get
            Return GetResourceString("ERR_InvInsideEndsEvent")
          End Get
        End Property
        ''' <summary>'Custom Event' must end with a matching 'End Event'.</summary>
        Friend Shared ReadOnly Property [ERR_MissingEndEvent] As String
          Get
            Return GetResourceString("ERR_MissingEndEvent")
          End Get
        End Property
        ''' <summary>'AddHandler' declaration must end with a matching 'End AddHandler'.</summary>
        Friend Shared ReadOnly Property [ERR_MissingEndAddHandler] As String
          Get
            Return GetResourceString("ERR_MissingEndAddHandler")
          End Get
        End Property
        ''' <summary>'RemoveHandler' declaration must end with a matching 'End RemoveHandler'.</summary>
        Friend Shared ReadOnly Property [ERR_MissingEndRemoveHandler] As String
          Get
            Return GetResourceString("ERR_MissingEndRemoveHandler")
          End Get
        End Property
        ''' <summary>'RaiseEvent' declaration must end with a matching 'End RaiseEvent'.</summary>
        Friend Shared ReadOnly Property [ERR_MissingEndRaiseEvent] As String
          Get
            Return GetResourceString("ERR_MissingEndRaiseEvent")
          End Get
        End Property
        ''' <summary>'Custom' modifier is not valid on events declared in interfaces.</summary>
        Friend Shared ReadOnly Property [ERR_CustomEventInvInInterface] As String
          Get
            Return GetResourceString("ERR_CustomEventInvInInterface")
          End Get
        End Property
        ''' <summary>'Custom' modifier is not valid on events declared without explicit delegate types.</summary>
        Friend Shared ReadOnly Property [ERR_CustomEventRequiresAs] As String
          Get
            Return GetResourceString("ERR_CustomEventRequiresAs")
          End Get
        End Property
        ''' <summary>'End Event' must be preceded by a matching 'Custom Event'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidEndEvent] As String
          Get
            Return GetResourceString("ERR_InvalidEndEvent")
          End Get
        End Property
        ''' <summary>'End AddHandler' must be preceded by a matching 'AddHandler' declaration.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidEndAddHandler] As String
          Get
            Return GetResourceString("ERR_InvalidEndAddHandler")
          End Get
        End Property
        ''' <summary>'End RemoveHandler' must be preceded by a matching 'RemoveHandler' declaration.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidEndRemoveHandler] As String
          Get
            Return GetResourceString("ERR_InvalidEndRemoveHandler")
          End Get
        End Property
        ''' <summary>'End RaiseEvent' must be preceded by a matching 'RaiseEvent' declaration.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidEndRaiseEvent] As String
          Get
            Return GetResourceString("ERR_InvalidEndRaiseEvent")
          End Get
        End Property
        ''' <summary>'AddHandler' is already declared.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateAddHandlerDef] As String
          Get
            Return GetResourceString("ERR_DuplicateAddHandlerDef")
          End Get
        End Property
        ''' <summary>'RemoveHandler' is already declared.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateRemoveHandlerDef] As String
          Get
            Return GetResourceString("ERR_DuplicateRemoveHandlerDef")
          End Get
        End Property
        ''' <summary>'RaiseEvent' is already declared.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateRaiseEventDef] As String
          Get
            Return GetResourceString("ERR_DuplicateRaiseEventDef")
          End Get
        End Property
        ''' <summary>'AddHandler' definition missing for event '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_MissingAddHandlerDef1] As String
          Get
            Return GetResourceString("ERR_MissingAddHandlerDef1")
          End Get
        End Property
        ''' <summary>'RemoveHandler' definition missing for event '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_MissingRemoveHandlerDef1] As String
          Get
            Return GetResourceString("ERR_MissingRemoveHandlerDef1")
          End Get
        End Property
        ''' <summary>'RaiseEvent' definition missing for event '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_MissingRaiseEventDef1] As String
          Get
            Return GetResourceString("ERR_MissingRaiseEventDef1")
          End Get
        End Property
        ''' <summary>'AddHandler' and 'RemoveHandler' methods must have exactly one parameter.</summary>
        Friend Shared ReadOnly Property [ERR_EventAddRemoveHasOnlyOneParam] As String
          Get
            Return GetResourceString("ERR_EventAddRemoveHasOnlyOneParam")
          End Get
        End Property
        ''' <summary>'AddHandler' and 'RemoveHandler' method parameters cannot be declared 'ByRef'.</summary>
        Friend Shared ReadOnly Property [ERR_EventAddRemoveByrefParamIllegal] As String
          Get
            Return GetResourceString("ERR_EventAddRemoveByrefParamIllegal")
          End Get
        End Property
        ''' <summary>Specifiers are not valid on 'AddHandler', 'RemoveHandler' and 'RaiseEvent' methods.</summary>
        Friend Shared ReadOnly Property [ERR_SpecifiersInvOnEventMethod] As String
          Get
            Return GetResourceString("ERR_SpecifiersInvOnEventMethod")
          End Get
        End Property
        ''' <summary>'AddHandler' and 'RemoveHandler' method parameters must have the same delegate type as the containing event.</summary>
        Friend Shared ReadOnly Property [ERR_AddRemoveParamNotEventType] As String
          Get
            Return GetResourceString("ERR_AddRemoveParamNotEventType")
          End Get
        End Property
        ''' <summary>'RaiseEvent' method must have the same signature as the containing event's delegate type '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_RaiseEventShapeMismatch1] As String
          Get
            Return GetResourceString("ERR_RaiseEventShapeMismatch1")
          End Get
        End Property
        ''' <summary>'AddHandler', 'RemoveHandler' and 'RaiseEvent' method parameters cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_EventMethodOptionalParamIllegal1] As String
          Get
            Return GetResourceString("ERR_EventMethodOptionalParamIllegal1")
          End Get
        End Property
        ''' <summary>'{0}' cannot refer to itself through its default instance; use 'Me' instead.</summary>
        Friend Shared ReadOnly Property [ERR_CantReferToMyGroupInsideGroupType1] As String
          Get
            Return GetResourceString("ERR_CantReferToMyGroupInsideGroupType1")
          End Get
        End Property
        ''' <summary>'Custom' modifier can only be used immediately before an 'Event' declaration.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidUseOfCustomModifier] As String
          Get
            Return GetResourceString("ERR_InvalidUseOfCustomModifier")
          End Get
        End Property
        ''' <summary>Option Strict Custom can only be used as an option to the command-line compiler (vbc.exe).</summary>
        Friend Shared ReadOnly Property [ERR_InvalidOptionStrictCustom] As String
          Get
            Return GetResourceString("ERR_InvalidOptionStrictCustom")
          End Get
        End Property
        ''' <summary>'{0}' cannot be applied to the 'AddHandler', 'RemoveHandler', or 'RaiseEvent' definitions. If required, apply the attribute directly to the event.</summary>
        Friend Shared ReadOnly Property [ERR_ObsoleteInvalidOnEventMember] As String
          Get
            Return GetResourceString("ERR_ObsoleteInvalidOnEventMember")
          End Get
        End Property
        ''' <summary>Method '{0}' does not have a signature compatible with delegate '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_DelegateBindingIncompatible2] As String
          Get
            Return GetResourceString("ERR_DelegateBindingIncompatible2")
          End Get
        End Property
        ''' <summary>XML name expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedXmlName] As String
          Get
            Return GetResourceString("ERR_ExpectedXmlName")
          End Get
        End Property
        ''' <summary>XML namespace prefix '{0}' is not defined.</summary>
        Friend Shared ReadOnly Property [ERR_UndefinedXmlPrefix] As String
          Get
            Return GetResourceString("ERR_UndefinedXmlPrefix")
          End Get
        End Property
        ''' <summary>Duplicate XML attribute '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateXmlAttribute] As String
          Get
            Return GetResourceString("ERR_DuplicateXmlAttribute")
          End Get
        End Property
        ''' <summary>End tag &lt;/{0}{1}{2}&gt; expected.</summary>
        Friend Shared ReadOnly Property [ERR_MismatchedXmlEndTag] As String
          Get
            Return GetResourceString("ERR_MismatchedXmlEndTag")
          End Get
        End Property
        ''' <summary>Element is missing an end tag.</summary>
        Friend Shared ReadOnly Property [ERR_MissingXmlEndTag] As String
          Get
            Return GetResourceString("ERR_MissingXmlEndTag")
          End Get
        End Property
        ''' <summary>XML namespace prefix '{0}' is reserved for use by XML and the namespace URI cannot be changed.</summary>
        Friend Shared ReadOnly Property [ERR_ReservedXmlPrefix] As String
          Get
            Return GetResourceString("ERR_ReservedXmlPrefix")
          End Get
        End Property
        ''' <summary>Required attribute 'version' missing from XML declaration.</summary>
        Friend Shared ReadOnly Property [ERR_MissingVersionInXmlDecl] As String
          Get
            Return GetResourceString("ERR_MissingVersionInXmlDecl")
          End Get
        End Property
        ''' <summary>XML declaration does not allow attribute '{0}{1}{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_IllegalAttributeInXmlDecl] As String
          Get
            Return GetResourceString("ERR_IllegalAttributeInXmlDecl")
          End Get
        End Property
        ''' <summary>Embedded expression cannot appear inside a quoted attribute value.  Try removing quotes.</summary>
        Friend Shared ReadOnly Property [ERR_QuotedEmbeddedExpression] As String
          Get
            Return GetResourceString("ERR_QuotedEmbeddedExpression")
          End Get
        End Property
        ''' <summary>XML attribute 'version' must be the first attribute in XML declaration.</summary>
        Friend Shared ReadOnly Property [ERR_VersionMustBeFirstInXmlDecl] As String
          Get
            Return GetResourceString("ERR_VersionMustBeFirstInXmlDecl")
          End Get
        End Property
        ''' <summary>XML attribute '{0}' must appear before XML attribute '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_AttributeOrder] As String
          Get
            Return GetResourceString("ERR_AttributeOrder")
          End Get
        End Property
        ''' <summary>Expected closing '%&gt;' for embedded expression.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedXmlEndEmbedded] As String
          Get
            Return GetResourceString("ERR_ExpectedXmlEndEmbedded")
          End Get
        End Property
        ''' <summary>Expected closing '?&gt;' for XML processor instruction.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedXmlEndPI] As String
          Get
            Return GetResourceString("ERR_ExpectedXmlEndPI")
          End Get
        End Property
        ''' <summary>Expected closing '--&gt;' for XML comment.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedXmlEndComment] As String
          Get
            Return GetResourceString("ERR_ExpectedXmlEndComment")
          End Get
        End Property
        ''' <summary>Expected closing ']]&gt;' for XML CDATA section.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedXmlEndCData] As String
          Get
            Return GetResourceString("ERR_ExpectedXmlEndCData")
          End Get
        End Property
        ''' <summary>Expected matching closing single quote for XML attribute value.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedSQuote] As String
          Get
            Return GetResourceString("ERR_ExpectedSQuote")
          End Get
        End Property
        ''' <summary>Expected matching closing double quote for XML attribute value.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedQuote] As String
          Get
            Return GetResourceString("ERR_ExpectedQuote")
          End Get
        End Property
        ''' <summary>Expected beginning '&lt;' for an XML tag.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedLT] As String
          Get
            Return GetResourceString("ERR_ExpectedLT")
          End Get
        End Property
        ''' <summary>Expected quoted XML attribute value or embedded expression.</summary>
        Friend Shared ReadOnly Property [ERR_StartAttributeValue] As String
          Get
            Return GetResourceString("ERR_StartAttributeValue")
          End Get
        End Property
        ''' <summary>Expected '/' for XML end tag.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedDiv] As String
          Get
            Return GetResourceString("ERR_ExpectedDiv")
          End Get
        End Property
        ''' <summary>XML axis properties do not support late binding.</summary>
        Friend Shared ReadOnly Property [ERR_NoXmlAxesLateBinding] As String
          Get
            Return GetResourceString("ERR_NoXmlAxesLateBinding")
          End Get
        End Property
        ''' <summary>Character '{0}' ({1}) is not allowed at the beginning of an XML name.</summary>
        Friend Shared ReadOnly Property [ERR_IllegalXmlStartNameChar] As String
          Get
            Return GetResourceString("ERR_IllegalXmlStartNameChar")
          End Get
        End Property
        ''' <summary>Character '{0}' ({1}) is not allowed in an XML name.</summary>
        Friend Shared ReadOnly Property [ERR_IllegalXmlNameChar] As String
          Get
            Return GetResourceString("ERR_IllegalXmlNameChar")
          End Get
        End Property
        ''' <summary>Character sequence '--' is not allowed in an XML comment.</summary>
        Friend Shared ReadOnly Property [ERR_IllegalXmlCommentChar] As String
          Get
            Return GetResourceString("ERR_IllegalXmlCommentChar")
          End Get
        End Property
        ''' <summary>An embedded expression cannot be used here.</summary>
        Friend Shared ReadOnly Property [ERR_EmbeddedExpression] As String
          Get
            Return GetResourceString("ERR_EmbeddedExpression")
          End Get
        End Property
        ''' <summary>Missing required white space.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedXmlWhiteSpace] As String
          Get
            Return GetResourceString("ERR_ExpectedXmlWhiteSpace")
          End Get
        End Property
        ''' <summary>XML processing instruction name '{0}' is not valid.</summary>
        Friend Shared ReadOnly Property [ERR_IllegalProcessingInstructionName] As String
          Get
            Return GetResourceString("ERR_IllegalProcessingInstructionName")
          End Get
        End Property
        ''' <summary>XML DTDs are not supported.</summary>
        Friend Shared ReadOnly Property [ERR_DTDNotSupported] As String
          Get
            Return GetResourceString("ERR_DTDNotSupported")
          End Get
        End Property
        ''' <summary>White space cannot appear here.</summary>
        Friend Shared ReadOnly Property [ERR_IllegalXmlWhiteSpace] As String
          Get
            Return GetResourceString("ERR_IllegalXmlWhiteSpace")
          End Get
        End Property
        ''' <summary>Expected closing ';' for XML entity.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedSColon] As String
          Get
            Return GetResourceString("ERR_ExpectedSColon")
          End Get
        End Property
        ''' <summary>Expected '%=' at start of an embedded expression.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedXmlBeginEmbedded] As String
          Get
            Return GetResourceString("ERR_ExpectedXmlBeginEmbedded")
          End Get
        End Property
        ''' <summary>XML entity references are not supported.</summary>
        Friend Shared ReadOnly Property [ERR_XmlEntityReference] As String
          Get
            Return GetResourceString("ERR_XmlEntityReference")
          End Get
        End Property
        ''' <summary>Attribute value is not valid; expecting '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidAttributeValue1] As String
          Get
            Return GetResourceString("ERR_InvalidAttributeValue1")
          End Get
        End Property
        ''' <summary>Attribute value is not valid; expecting '{0}' or '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidAttributeValue2] As String
          Get
            Return GetResourceString("ERR_InvalidAttributeValue2")
          End Get
        End Property
        ''' <summary>Prefix '{0}' cannot be bound to namespace name reserved for '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_ReservedXmlNamespace] As String
          Get
            Return GetResourceString("ERR_ReservedXmlNamespace")
          End Get
        End Property
        ''' <summary>Namespace declaration with prefix cannot have an empty value inside an XML literal.</summary>
        Friend Shared ReadOnly Property [ERR_IllegalDefaultNamespace] As String
          Get
            Return GetResourceString("ERR_IllegalDefaultNamespace")
          End Get
        End Property
        ''' <summary>':' is not allowed. XML qualified names cannot be used in this context.</summary>
        Friend Shared ReadOnly Property [ERR_QualifiedNameNotAllowed] As String
          Get
            Return GetResourceString("ERR_QualifiedNameNotAllowed")
          End Get
        End Property
        ''' <summary>Namespace declaration must start with 'xmlns'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedXmlns] As String
          Get
            Return GetResourceString("ERR_ExpectedXmlns")
          End Get
        End Property
        ''' <summary>Element names cannot use the 'xmlns' prefix.</summary>
        Friend Shared ReadOnly Property [ERR_IllegalXmlnsPrefix] As String
          Get
            Return GetResourceString("ERR_IllegalXmlnsPrefix")
          End Get
        End Property
        ''' <summary>XML literals and XML axis properties are not available. Add references to System.Xml, System.Xml.Linq, and System.Core or other assemblies declaring System.Linq.Enumerable, System.Xml.Linq.XElement, System.Xml.Linq.XName, System.Xml.Linq.XAttribute and Sys ...</summary>
        Friend Shared ReadOnly Property [ERR_XmlFeaturesNotAvailable] As String
          Get
            Return GetResourceString("ERR_XmlFeaturesNotAvailable")
          End Get
        End Property
        ''' <summary>Unable to open Win32 manifest file '{0}' : {1}</summary>
        Friend Shared ReadOnly Property [ERR_UnableToReadUacManifest2] As String
          Get
            Return GetResourceString("ERR_UnableToReadUacManifest2")
          End Get
        End Property
        ''' <summary>Cannot convert '{0}' to '{1}'. You can use the 'Value' property to get the string value of the first element of '{2}'.</summary>
        Friend Shared ReadOnly Property [WRN_UseValueForXmlExpression3] As String
          Get
            Return GetResourceString("WRN_UseValueForXmlExpression3")
          End Get
        End Property
        ''' <summary>Cannot convert IEnumerable(Of XElement) to String</summary>
        Friend Shared ReadOnly Property [WRN_UseValueForXmlExpression3_Title] As String
          Get
            Return GetResourceString("WRN_UseValueForXmlExpression3_Title")
          End Get
        End Property
        ''' <summary>Value of type '{0}' cannot be converted to '{1}'. You can use the 'Value' property to get the string value of the first element of '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_TypeMismatchForXml3] As String
          Get
            Return GetResourceString("ERR_TypeMismatchForXml3")
          End Get
        End Property
        ''' <summary>Operator '{0}' is not defined for types '{1}' and '{2}'. You can use the 'Value' property to get the string value of the first element of '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_BinaryOperandsForXml4] As String
          Get
            Return GetResourceString("ERR_BinaryOperandsForXml4")
          End Get
        End Property
        ''' <summary>Full width characters are not valid as XML delimiters.</summary>
        Friend Shared ReadOnly Property [ERR_FullWidthAsXmlDelimiter] As String
          Get
            Return GetResourceString("ERR_FullWidthAsXmlDelimiter")
          End Get
        End Property
        ''' <summary>The value '{0}' is not a valid subsystem version. The version must be 6.02 or greater for ARM or AppContainerExe, and 4.00 or greater otherwise.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidSubsystemVersion] As String
          Get
            Return GetResourceString("ERR_InvalidSubsystemVersion")
          End Get
        End Property
        ''' <summary>Invalid file section alignment '{0}'</summary>
        Friend Shared ReadOnly Property [ERR_InvalidFileAlignment] As String
          Get
            Return GetResourceString("ERR_InvalidFileAlignment")
          End Get
        End Property
        ''' <summary>Invalid output name: {0}</summary>
        Friend Shared ReadOnly Property [ERR_InvalidOutputName] As String
          Get
            Return GetResourceString("ERR_InvalidOutputName")
          End Get
        End Property
        ''' <summary>Invalid debug information format: {0}</summary>
        Friend Shared ReadOnly Property [ERR_InvalidDebugInformationFormat] As String
          Get
            Return GetResourceString("ERR_InvalidDebugInformationFormat")
          End Get
        End Property
        ''' <summary>/platform:anycpu32bitpreferred can only be used with /t:exe, /t:winexe and /t:appcontainerexe.</summary>
        Friend Shared ReadOnly Property [ERR_LibAnycpu32bitPreferredConflict] As String
          Get
            Return GetResourceString("ERR_LibAnycpu32bitPreferredConflict")
          End Get
        End Property
        ''' <summary>Expression has the type '{0}' which is a restricted type and cannot be used to access members inherited from 'Object' or 'ValueType'.</summary>
        Friend Shared ReadOnly Property [ERR_RestrictedAccess] As String
          Get
            Return GetResourceString("ERR_RestrictedAccess")
          End Get
        End Property
        ''' <summary>Expression of type '{0}' cannot be converted to 'Object' or 'ValueType'.</summary>
        Friend Shared ReadOnly Property [ERR_RestrictedConversion1] As String
          Get
            Return GetResourceString("ERR_RestrictedConversion1")
          End Get
        End Property
        ''' <summary>Type characters are not allowed in label identifiers.</summary>
        Friend Shared ReadOnly Property [ERR_NoTypecharInLabel] As String
          Get
            Return GetResourceString("ERR_NoTypecharInLabel")
          End Get
        End Property
        ''' <summary>'{0}' cannot be made nullable, and cannot be used as the data type of an array element, field, anonymous type member, type argument, 'ByRef' parameter, or return statement.</summary>
        Friend Shared ReadOnly Property [ERR_RestrictedType1] As String
          Get
            Return GetResourceString("ERR_RestrictedType1")
          End Get
        End Property
        ''' <summary>Type characters are not allowed on Imports aliases.</summary>
        Friend Shared ReadOnly Property [ERR_NoTypecharInAlias] As String
          Get
            Return GetResourceString("ERR_NoTypecharInAlias")
          End Get
        End Property
        ''' <summary>Class '{0}' has no accessible 'Sub New' and cannot be inherited.</summary>
        Friend Shared ReadOnly Property [ERR_NoAccessibleConstructorOnBase] As String
          Get
            Return GetResourceString("ERR_NoAccessibleConstructorOnBase")
          End Get
        End Property
        ''' <summary>Local variables within methods of structures cannot be declared 'Static'.</summary>
        Friend Shared ReadOnly Property [ERR_BadStaticLocalInStruct] As String
          Get
            Return GetResourceString("ERR_BadStaticLocalInStruct")
          End Get
        End Property
        ''' <summary>Static local variable '{0}' is already declared.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateLocalStatic1] As String
          Get
            Return GetResourceString("ERR_DuplicateLocalStatic1")
          End Get
        End Property
        ''' <summary>Imports alias '{0}' conflicts with '{1}' declared in the root namespace.</summary>
        Friend Shared ReadOnly Property [ERR_ImportAliasConflictsWithType2] As String
          Get
            Return GetResourceString("ERR_ImportAliasConflictsWithType2")
          End Get
        End Property
        ''' <summary>'{0}' cannot shadow a method declared 'MustOverride'.</summary>
        Friend Shared ReadOnly Property [ERR_CantShadowAMustOverride1] As String
          Get
            Return GetResourceString("ERR_CantShadowAMustOverride1")
          End Get
        End Property
        ''' <summary>Event '{0}' cannot implement event '{2}.{1}' because its delegate type does not match the delegate type of another event implemented by '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_MultipleEventImplMismatch3] As String
          Get
            Return GetResourceString("ERR_MultipleEventImplMismatch3")
          End Get
        End Property
        ''' <summary>'{0}' and '{1}' cannot be combined.</summary>
        Friend Shared ReadOnly Property [ERR_BadSpecifierCombo2] As String
          Get
            Return GetResourceString("ERR_BadSpecifierCombo2")
          End Get
        End Property
        ''' <summary>{0} '{1}' must be declared 'Overloads' because another '{1}' is declared 'Overloads' or 'Overrides'.</summary>
        Friend Shared ReadOnly Property [ERR_MustBeOverloads2] As String
          Get
            Return GetResourceString("ERR_MustBeOverloads2")
          End Get
        End Property
        ''' <summary>'{0}' must be declared 'MustInherit' because it contains methods declared 'MustOverride'.</summary>
        Friend Shared ReadOnly Property [ERR_MustOverridesInClass1] As String
          Get
            Return GetResourceString("ERR_MustOverridesInClass1")
          End Get
        End Property
        ''' <summary>'Handles' in classes must specify a 'WithEvents' variable, 'MyBase', 'MyClass' or 'Me' qualified with a single identifier.</summary>
        Friend Shared ReadOnly Property [ERR_HandlesSyntaxInClass] As String
          Get
            Return GetResourceString("ERR_HandlesSyntaxInClass")
          End Get
        End Property
        ''' <summary>'{0}', implicitly declared for {1} '{2}', cannot shadow a 'MustOverride' method in the base {3} '{4}'.</summary>
        Friend Shared ReadOnly Property [ERR_SynthMemberShadowsMustOverride5] As String
          Get
            Return GetResourceString("ERR_SynthMemberShadowsMustOverride5")
          End Get
        End Property
        ''' <summary>'{0}' cannot override '{1}' because it is not accessible in this context.</summary>
        Friend Shared ReadOnly Property [ERR_CannotOverrideInAccessibleMember] As String
          Get
            Return GetResourceString("ERR_CannotOverrideInAccessibleMember")
          End Get
        End Property
        ''' <summary>'Handles' in modules must specify a 'WithEvents' variable qualified with a single identifier.</summary>
        Friend Shared ReadOnly Property [ERR_HandlesSyntaxInModule] As String
          Get
            Return GetResourceString("ERR_HandlesSyntaxInModule")
          End Get
        End Property
        ''' <summary>'IsNot' requires operands that have reference types, but this operand has the value type '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_IsNotOpRequiresReferenceTypes1] As String
          Get
            Return GetResourceString("ERR_IsNotOpRequiresReferenceTypes1")
          End Get
        End Property
        ''' <summary>'{0}' conflicts with the reserved member by this name that is implicitly declared in all enums.</summary>
        Friend Shared ReadOnly Property [ERR_ClashWithReservedEnumMember1] As String
          Get
            Return GetResourceString("ERR_ClashWithReservedEnumMember1")
          End Get
        End Property
        ''' <summary>'{0}' is already declared in this {1}.</summary>
        Friend Shared ReadOnly Property [ERR_MultiplyDefinedEnumMember2] As String
          Get
            Return GetResourceString("ERR_MultiplyDefinedEnumMember2")
          End Get
        End Property
        ''' <summary>'System.Void' can only be used in a GetType expression.</summary>
        Friend Shared ReadOnly Property [ERR_BadUseOfVoid] As String
          Get
            Return GetResourceString("ERR_BadUseOfVoid")
          End Get
        End Property
        ''' <summary>Event '{0}' cannot implement event '{1}' on interface '{2}' because their delegate types '{3}' and '{4}' do not match.</summary>
        Friend Shared ReadOnly Property [ERR_EventImplMismatch5] As String
          Get
            Return GetResourceString("ERR_EventImplMismatch5")
          End Get
        End Property
        ''' <summary>Type '{0}' in assembly '{1}' has been forwarded to assembly '{2}'. Either a reference to '{2}' is missing from your project or the type '{0}' is missing from assembly '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_ForwardedTypeUnavailable3] As String
          Get
            Return GetResourceString("ERR_ForwardedTypeUnavailable3")
          End Get
        End Property
        ''' <summary>'{0}' in assembly '{1}' has been forwarded to itself and so is an unsupported type.</summary>
        Friend Shared ReadOnly Property [ERR_TypeFwdCycle2] As String
          Get
            Return GetResourceString("ERR_TypeFwdCycle2")
          End Get
        End Property
        ''' <summary>Non-intrinsic type names are not allowed in conditional compilation expressions.</summary>
        Friend Shared ReadOnly Property [ERR_BadTypeInCCExpression] As String
          Get
            Return GetResourceString("ERR_BadTypeInCCExpression")
          End Get
        End Property
        ''' <summary>Syntax error in conditional compilation expression.</summary>
        Friend Shared ReadOnly Property [ERR_BadCCExpression] As String
          Get
            Return GetResourceString("ERR_BadCCExpression")
          End Get
        End Property
        ''' <summary>Arrays of type 'System.Void' are not allowed in this expression.</summary>
        Friend Shared ReadOnly Property [ERR_VoidArrayDisallowed] As String
          Get
            Return GetResourceString("ERR_VoidArrayDisallowed")
          End Get
        End Property
        ''' <summary>'{0}' is ambiguous because multiple kinds of members with this name exist in {1} '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_MetadataMembersAmbiguous3] As String
          Get
            Return GetResourceString("ERR_MetadataMembersAmbiguous3")
          End Get
        End Property
        ''' <summary>Expression of type '{0}' can never be of type '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_TypeOfExprAlwaysFalse2] As String
          Get
            Return GetResourceString("ERR_TypeOfExprAlwaysFalse2")
          End Get
        End Property
        ''' <summary>Partial methods must be declared 'Private' instead of '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_OnlyPrivatePartialMethods1] As String
          Get
            Return GetResourceString("ERR_OnlyPrivatePartialMethods1")
          End Get
        End Property
        ''' <summary>Partial methods must be declared 'Private'.</summary>
        Friend Shared ReadOnly Property [ERR_PartialMethodsMustBePrivate] As String
          Get
            Return GetResourceString("ERR_PartialMethodsMustBePrivate")
          End Get
        End Property
        ''' <summary>Method '{0}' cannot be declared 'Partial' because only one method '{1}' can be marked 'Partial'.</summary>
        Friend Shared ReadOnly Property [ERR_OnlyOnePartialMethodAllowed2] As String
          Get
            Return GetResourceString("ERR_OnlyOnePartialMethodAllowed2")
          End Get
        End Property
        ''' <summary>Method '{0}' cannot implement partial method '{1}' because '{2}' already implements it. Only one method can implement a partial method.</summary>
        Friend Shared ReadOnly Property [ERR_OnlyOneImplementingMethodAllowed3] As String
          Get
            Return GetResourceString("ERR_OnlyOneImplementingMethodAllowed3")
          End Get
        End Property
        ''' <summary>Partial methods must have empty method bodies.</summary>
        Friend Shared ReadOnly Property [ERR_PartialMethodMustBeEmpty] As String
          Get
            Return GetResourceString("ERR_PartialMethodMustBeEmpty")
          End Get
        End Property
        ''' <summary>'{0}' cannot be declared 'Partial' because partial methods must be Subs.</summary>
        Friend Shared ReadOnly Property [ERR_PartialMethodsMustBeSub1] As String
          Get
            Return GetResourceString("ERR_PartialMethodsMustBeSub1")
          End Get
        End Property
        ''' <summary>Method '{0}' does not have the same generic constraints as the partial method '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_PartialMethodGenericConstraints2] As String
          Get
            Return GetResourceString("ERR_PartialMethodGenericConstraints2")
          End Get
        End Property
        ''' <summary>Partial method '{0}' cannot use the 'Implements' keyword.</summary>
        Friend Shared ReadOnly Property [ERR_PartialDeclarationImplements1] As String
          Get
            Return GetResourceString("ERR_PartialDeclarationImplements1")
          End Get
        End Property
        ''' <summary>'AddressOf' cannot be applied to '{0}' because '{0}' is a partial method without an implementation.</summary>
        Friend Shared ReadOnly Property [ERR_NoPartialMethodInAddressOf1] As String
          Get
            Return GetResourceString("ERR_NoPartialMethodInAddressOf1")
          End Get
        End Property
        ''' <summary>Method '{0}' must be declared 'Private' in order to implement partial method '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_ImplementationMustBePrivate2] As String
          Get
            Return GetResourceString("ERR_ImplementationMustBePrivate2")
          End Get
        End Property
        ''' <summary>Parameter name '{0}' does not match the name of the corresponding parameter, '{1}', defined on the partial method declaration '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_PartialMethodParamNamesMustMatch3] As String
          Get
            Return GetResourceString("ERR_PartialMethodParamNamesMustMatch3")
          End Get
        End Property
        ''' <summary>Name of type parameter '{0}' does not match '{1}', the corresponding type parameter defined on the partial method declaration '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_PartialMethodTypeParamNameMismatch3] As String
          Get
            Return GetResourceString("ERR_PartialMethodTypeParamNameMismatch3")
          End Get
        End Property
        ''' <summary>'Shared' attribute property '{0}' cannot be the target of an assignment.</summary>
        Friend Shared ReadOnly Property [ERR_BadAttributeSharedProperty1] As String
          Get
            Return GetResourceString("ERR_BadAttributeSharedProperty1")
          End Get
        End Property
        ''' <summary>'ReadOnly' attribute property '{0}' cannot be the target of an assignment.</summary>
        Friend Shared ReadOnly Property [ERR_BadAttributeReadOnlyProperty1] As String
          Get
            Return GetResourceString("ERR_BadAttributeReadOnlyProperty1")
          End Get
        End Property
        ''' <summary>Resource name '{0}' cannot be used more than once.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateResourceName1] As String
          Get
            Return GetResourceString("ERR_DuplicateResourceName1")
          End Get
        End Property
        ''' <summary>Each linked resource and module must have a unique filename. Filename '{0}' is specified more than once in this assembly.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateResourceFileName1] As String
          Get
            Return GetResourceString("ERR_DuplicateResourceFileName1")
          End Get
        End Property
        ''' <summary>'{0}' cannot be used as an attribute because it is not a class.</summary>
        Friend Shared ReadOnly Property [ERR_AttributeMustBeClassNotStruct1] As String
          Get
            Return GetResourceString("ERR_AttributeMustBeClassNotStruct1")
          End Get
        End Property
        ''' <summary>'{0}' cannot be used as an attribute because it does not inherit from 'System.Attribute'.</summary>
        Friend Shared ReadOnly Property [ERR_AttributeMustInheritSysAttr] As String
          Get
            Return GetResourceString("ERR_AttributeMustInheritSysAttr")
          End Get
        End Property
        ''' <summary>'{0}' cannot be used as an attribute because it is declared 'MustInherit'.</summary>
        Friend Shared ReadOnly Property [ERR_AttributeCannotBeAbstract] As String
          Get
            Return GetResourceString("ERR_AttributeCannotBeAbstract")
          End Get
        End Property
        ''' <summary>Unable to open resource file '{0}': {1}</summary>
        Friend Shared ReadOnly Property [ERR_UnableToOpenResourceFile1] As String
          Get
            Return GetResourceString("ERR_UnableToOpenResourceFile1")
          End Get
        End Property
        ''' <summary>Attribute member '{0}' cannot be the target of an assignment because it is not declared 'Public'.</summary>
        Friend Shared ReadOnly Property [ERR_BadAttributeNonPublicProperty1] As String
          Get
            Return GetResourceString("ERR_BadAttributeNonPublicProperty1")
          End Get
        End Property
        ''' <summary>'System.STAThreadAttribute' and 'System.MTAThreadAttribute' cannot both be applied to the same method.</summary>
        Friend Shared ReadOnly Property [ERR_STAThreadAndMTAThread0] As String
          Get
            Return GetResourceString("ERR_STAThreadAndMTAThread0")
          End Get
        End Property
        ''' <summary>Project '{0}' makes an indirect reference to assembly '{1}', which contains '{2}'. Add a file reference to '{3}' to your project.</summary>
        Friend Shared ReadOnly Property [ERR_IndirectUnreferencedAssembly4] As String
          Get
            Return GetResourceString("ERR_IndirectUnreferencedAssembly4")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used in an attribute because it is not declared 'Public'.</summary>
        Friend Shared ReadOnly Property [ERR_BadAttributeNonPublicType1] As String
          Get
            Return GetResourceString("ERR_BadAttributeNonPublicType1")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used in an attribute because its container '{1}' is not declared 'Public'.</summary>
        Friend Shared ReadOnly Property [ERR_BadAttributeNonPublicContType2] As String
          Get
            Return GetResourceString("ERR_BadAttributeNonPublicContType2")
          End Get
        End Property
        ''' <summary>'System.Runtime.InteropServices.DllImportAttribute' cannot be applied to a Sub, Function, or Operator with a non-empty body.</summary>
        Friend Shared ReadOnly Property [ERR_DllImportOnNonEmptySubOrFunction] As String
          Get
            Return GetResourceString("ERR_DllImportOnNonEmptySubOrFunction")
          End Get
        End Property
        ''' <summary>'System.Runtime.InteropServices.DllImportAttribute' cannot be applied to a Declare.</summary>
        Friend Shared ReadOnly Property [ERR_DllImportNotLegalOnDeclare] As String
          Get
            Return GetResourceString("ERR_DllImportNotLegalOnDeclare")
          End Get
        End Property
        ''' <summary>'System.Runtime.InteropServices.DllImportAttribute' cannot be applied to a Get or Set.</summary>
        Friend Shared ReadOnly Property [ERR_DllImportNotLegalOnGetOrSet] As String
          Get
            Return GetResourceString("ERR_DllImportNotLegalOnGetOrSet")
          End Get
        End Property
        ''' <summary>'System.Runtime.InteropServices.DllImportAttribute' cannot be applied to a method that is generic or contained in a generic type.</summary>
        Friend Shared ReadOnly Property [ERR_DllImportOnGenericSubOrFunction] As String
          Get
            Return GetResourceString("ERR_DllImportOnGenericSubOrFunction")
          End Get
        End Property
        ''' <summary>'Microsoft.VisualBasic.ComClassAttribute' cannot be applied to a class that is generic or contained inside a generic type.</summary>
        Friend Shared ReadOnly Property [ERR_ComClassOnGeneric] As String
          Get
            Return GetResourceString("ERR_ComClassOnGeneric")
          End Get
        End Property
        ''' <summary>'System.Runtime.InteropServices.DllImportAttribute' cannot be applied to instance method.</summary>
        Friend Shared ReadOnly Property [ERR_DllImportOnInstanceMethod] As String
          Get
            Return GetResourceString("ERR_DllImportOnInstanceMethod")
          End Get
        End Property
        ''' <summary>'System.Runtime.InteropServices.DllImportAttribute' cannot be applied to interface methods.</summary>
        Friend Shared ReadOnly Property [ERR_DllImportOnInterfaceMethod] As String
          Get
            Return GetResourceString("ERR_DllImportOnInterfaceMethod")
          End Get
        End Property
        ''' <summary>'System.Runtime.InteropServices.DllImportAttribute' cannot be applied to 'AddHandler', 'RemoveHandler' or 'RaiseEvent' method.</summary>
        Friend Shared ReadOnly Property [ERR_DllImportNotLegalOnEventMethod] As String
          Get
            Return GetResourceString("ERR_DllImportNotLegalOnEventMethod")
          End Get
        End Property
        ''' <summary>Friend assembly reference '{0}' is invalid. InternalsVisibleTo declarations cannot have a version, culture, public key token, or processor architecture specified.</summary>
        Friend Shared ReadOnly Property [ERR_FriendAssemblyBadArguments] As String
          Get
            Return GetResourceString("ERR_FriendAssemblyBadArguments")
          End Get
        End Property
        ''' <summary>Friend assembly reference '{0}' is invalid. Strong-name signed assemblies must specify a public key in their InternalsVisibleTo declarations.</summary>
        Friend Shared ReadOnly Property [ERR_FriendAssemblyStrongNameRequired] As String
          Get
            Return GetResourceString("ERR_FriendAssemblyStrongNameRequired")
          End Get
        End Property
        ''' <summary>Friend declaration '{0}' is invalid and cannot be resolved.</summary>
        Friend Shared ReadOnly Property [ERR_FriendAssemblyNameInvalid] As String
          Get
            Return GetResourceString("ERR_FriendAssemblyNameInvalid")
          End Get
        End Property
        ''' <summary>Member '{0}' cannot override member '{1}' defined in another assembly/project because the access modifier 'Protected Friend' expands accessibility. Use 'Protected' instead.</summary>
        Friend Shared ReadOnly Property [ERR_FriendAssemblyBadAccessOverride2] As String
          Get
            Return GetResourceString("ERR_FriendAssemblyBadAccessOverride2")
          End Get
        End Property
        ''' <summary>Local variable '{0}' cannot be referred to before it is declared.</summary>
        Friend Shared ReadOnly Property [ERR_UseOfLocalBeforeDeclaration1] As String
          Get
            Return GetResourceString("ERR_UseOfLocalBeforeDeclaration1")
          End Get
        End Property
        ''' <summary>'{0}' is not valid within a Module.</summary>
        Friend Shared ReadOnly Property [ERR_UseOfKeywordFromModule1] As String
          Get
            Return GetResourceString("ERR_UseOfKeywordFromModule1")
          End Get
        End Property
        ''' <summary>Statement cannot end a block outside of a line 'If' statement.</summary>
        Friend Shared ReadOnly Property [ERR_BogusWithinLineIf] As String
          Get
            Return GetResourceString("ERR_BogusWithinLineIf")
          End Get
        End Property
        ''' <summary>'Char' values cannot be converted to '{0}'. Use 'Microsoft.VisualBasic.AscW' to interpret a character as a Unicode value or 'Microsoft.VisualBasic.Val' to interpret it as a digit.</summary>
        Friend Shared ReadOnly Property [ERR_CharToIntegralTypeMismatch1] As String
          Get
            Return GetResourceString("ERR_CharToIntegralTypeMismatch1")
          End Get
        End Property
        ''' <summary>'{0}' values cannot be converted to 'Char'. Use 'Microsoft.VisualBasic.ChrW' to interpret a numeric value as a Unicode character or first convert it to 'String' to produce a digit.</summary>
        Friend Shared ReadOnly Property [ERR_IntegralToCharTypeMismatch1] As String
          Get
            Return GetResourceString("ERR_IntegralToCharTypeMismatch1")
          End Get
        End Property
        ''' <summary>Delegate '{0}' requires an 'AddressOf' expression or lambda expression as the only argument to its constructor.</summary>
        Friend Shared ReadOnly Property [ERR_NoDirectDelegateConstruction1] As String
          Get
            Return GetResourceString("ERR_NoDirectDelegateConstruction1")
          End Get
        End Property
        ''' <summary>Method declaration statements must be the first statement on a logical line.</summary>
        Friend Shared ReadOnly Property [ERR_MethodMustBeFirstStatementOnLine] As String
          Get
            Return GetResourceString("ERR_MethodMustBeFirstStatementOnLine")
          End Get
        End Property
        ''' <summary>'{0}' cannot be named as a parameter in an attribute specifier because it is not a field or property.</summary>
        Friend Shared ReadOnly Property [ERR_AttrAssignmentNotFieldOrProp1] As String
          Get
            Return GetResourceString("ERR_AttrAssignmentNotFieldOrProp1")
          End Get
        End Property
        ''' <summary>Option Strict On disallows operands of type Object for operator '{0}'. Use the 'Is' operator to test for object identity.</summary>
        Friend Shared ReadOnly Property [ERR_StrictDisallowsObjectComparison1] As String
          Get
            Return GetResourceString("ERR_StrictDisallowsObjectComparison1")
          End Get
        End Property
        ''' <summary>Bounds can be specified only for the top-level array when initializing an array of arrays.</summary>
        Friend Shared ReadOnly Property [ERR_NoConstituentArraySizes] As String
          Get
            Return GetResourceString("ERR_NoConstituentArraySizes")
          End Get
        End Property
        ''' <summary>'Assembly' or 'Module' expected.</summary>
        Friend Shared ReadOnly Property [ERR_FileAttributeNotAssemblyOrModule] As String
          Get
            Return GetResourceString("ERR_FileAttributeNotAssemblyOrModule")
          End Get
        End Property
        ''' <summary>'{0}' has no parameters and its return type cannot be indexed.</summary>
        Friend Shared ReadOnly Property [ERR_FunctionResultCannotBeIndexed1] As String
          Get
            Return GetResourceString("ERR_FunctionResultCannotBeIndexed1")
          End Get
        End Property
        ''' <summary>Comma, ')', or a valid expression continuation expected.</summary>
        Friend Shared ReadOnly Property [ERR_ArgumentSyntax] As String
          Get
            Return GetResourceString("ERR_ArgumentSyntax")
          End Get
        End Property
        ''' <summary>'Resume' or 'GoTo' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedResumeOrGoto] As String
          Get
            Return GetResourceString("ERR_ExpectedResumeOrGoto")
          End Get
        End Property
        ''' <summary>'=' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedAssignmentOperator] As String
          Get
            Return GetResourceString("ERR_ExpectedAssignmentOperator")
          End Get
        End Property
        ''' <summary>Parameter '{0}' in '{1}' already has a matching omitted argument.</summary>
        Friend Shared ReadOnly Property [ERR_NamedArgAlsoOmitted2] As String
          Get
            Return GetResourceString("ERR_NamedArgAlsoOmitted2")
          End Get
        End Property
        ''' <summary>'{0}' is an event, and cannot be called directly. Use a 'RaiseEvent' statement to raise an event.</summary>
        Friend Shared ReadOnly Property [ERR_CannotCallEvent1] As String
          Get
            Return GetResourceString("ERR_CannotCallEvent1")
          End Get
        End Property
        ''' <summary>Expression is of type '{0}', which is not a collection type.</summary>
        Friend Shared ReadOnly Property [ERR_ForEachCollectionDesignPattern1] As String
          Get
            Return GetResourceString("ERR_ForEachCollectionDesignPattern1")
          End Get
        End Property
        ''' <summary>Default values cannot be supplied for parameters that are not declared 'Optional'.</summary>
        Friend Shared ReadOnly Property [ERR_DefaultValueForNonOptionalParam] As String
          Get
            Return GetResourceString("ERR_DefaultValueForNonOptionalParam")
          End Get
        End Property
        ''' <summary>'MyBase' must be followed by '.' and an identifier.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedDotAfterMyBase] As String
          Get
            Return GetResourceString("ERR_ExpectedDotAfterMyBase")
          End Get
        End Property
        ''' <summary>'MyClass' must be followed by '.' and an identifier.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedDotAfterMyClass] As String
          Get
            Return GetResourceString("ERR_ExpectedDotAfterMyClass")
          End Get
        End Property
        ''' <summary>Option Strict On disallows narrowing from type '{1}' to type '{2}' in copying the value of 'ByRef' parameter '{0}' back to the matching argument.</summary>
        Friend Shared ReadOnly Property [ERR_StrictArgumentCopyBackNarrowing3] As String
          Get
            Return GetResourceString("ERR_StrictArgumentCopyBackNarrowing3")
          End Get
        End Property
        ''' <summary>'#ElseIf' cannot follow '#Else' as part of a '#If' block.</summary>
        Friend Shared ReadOnly Property [ERR_LbElseifAfterElse] As String
          Get
            Return GetResourceString("ERR_LbElseifAfterElse")
          End Get
        End Property
        ''' <summary>Attribute specifier is not a complete statement. Use a line continuation to apply the attribute to the following statement.</summary>
        Friend Shared ReadOnly Property [ERR_StandaloneAttribute] As String
          Get
            Return GetResourceString("ERR_StandaloneAttribute")
          End Get
        End Property
        ''' <summary>Class '{0}' must declare a 'Sub New' because its base class '{1}' has more than one accessible 'Sub New' that can be called with no arguments.</summary>
        Friend Shared ReadOnly Property [ERR_NoUniqueConstructorOnBase2] As String
          Get
            Return GetResourceString("ERR_NoUniqueConstructorOnBase2")
          End Get
        End Property
        ''' <summary>'Next' statement names more variables than there are matching 'For' statements.</summary>
        Friend Shared ReadOnly Property [ERR_ExtraNextVariable] As String
          Get
            Return GetResourceString("ERR_ExtraNextVariable")
          End Get
        End Property
        ''' <summary>First statement of this 'Sub New' must be a call to 'MyBase.New' or 'MyClass.New' because base class '{0}' of '{1}' has more than one accessible 'Sub New' that can be called with no arguments.</summary>
        Friend Shared ReadOnly Property [ERR_RequiredNewCallTooMany2] As String
          Get
            Return GetResourceString("ERR_RequiredNewCallTooMany2")
          End Get
        End Property
        ''' <summary>Array declared as for loop control variable cannot be declared with an initial size.</summary>
        Friend Shared ReadOnly Property [ERR_ForCtlVarArraySizesSpecified] As String
          Get
            Return GetResourceString("ERR_ForCtlVarArraySizesSpecified")
          End Get
        End Property
        ''' <summary>The '{0}' keyword is used to overload inherited members; do not use the '{0}' keyword when overloading 'Sub New'.</summary>
        Friend Shared ReadOnly Property [ERR_BadFlagsOnNewOverloads] As String
          Get
            Return GetResourceString("ERR_BadFlagsOnNewOverloads")
          End Get
        End Property
        ''' <summary>Type character cannot be used in a type parameter declaration.</summary>
        Friend Shared ReadOnly Property [ERR_TypeCharOnGenericParam] As String
          Get
            Return GetResourceString("ERR_TypeCharOnGenericParam")
          End Get
        End Property
        ''' <summary>Too few type arguments to '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_TooFewGenericArguments1] As String
          Get
            Return GetResourceString("ERR_TooFewGenericArguments1")
          End Get
        End Property
        ''' <summary>Too many type arguments to '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_TooManyGenericArguments1] As String
          Get
            Return GetResourceString("ERR_TooManyGenericArguments1")
          End Get
        End Property
        ''' <summary>Type argument '{0}' does not inherit from or implement the constraint type '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_GenericConstraintNotSatisfied2] As String
          Get
            Return GetResourceString("ERR_GenericConstraintNotSatisfied2")
          End Get
        End Property
        ''' <summary>'{0}' has no type parameters and so cannot have type arguments.</summary>
        Friend Shared ReadOnly Property [ERR_TypeOrMemberNotGeneric1] As String
          Get
            Return GetResourceString("ERR_TypeOrMemberNotGeneric1")
          End Get
        End Property
        ''' <summary>'New' cannot be used on a type parameter that does not have a 'New' constraint.</summary>
        Friend Shared ReadOnly Property [ERR_NewIfNullOnGenericParam] As String
          Get
            Return GetResourceString("ERR_NewIfNullOnGenericParam")
          End Get
        End Property
        ''' <summary>Type parameter '{0}' can only have one constraint that is a class.</summary>
        Friend Shared ReadOnly Property [ERR_MultipleClassConstraints1] As String
          Get
            Return GetResourceString("ERR_MultipleClassConstraints1")
          End Get
        End Property
        ''' <summary>Type constraint '{0}' must be either a class, interface or type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_ConstNotClassInterfaceOrTypeParam1] As String
          Get
            Return GetResourceString("ERR_ConstNotClassInterfaceOrTypeParam1")
          End Get
        End Property
        ''' <summary>Type parameter already declared with name '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateTypeParamName1] As String
          Get
            Return GetResourceString("ERR_DuplicateTypeParamName1")
          End Get
        End Property
        ''' <summary>Type parameter '{0}' for '{1}' cannot be inferred.</summary>
        Friend Shared ReadOnly Property [ERR_UnboundTypeParam2] As String
          Get
            Return GetResourceString("ERR_UnboundTypeParam2")
          End Get
        End Property
        ''' <summary>'Is' operand of type '{0}' can be compared only to 'Nothing' because '{0}' is a type parameter with no class constraint.</summary>
        Friend Shared ReadOnly Property [ERR_IsOperatorGenericParam1] As String
          Get
            Return GetResourceString("ERR_IsOperatorGenericParam1")
          End Get
        End Property
        ''' <summary>Copying the value of 'ByRef' parameter '{0}' back to the matching argument narrows from type '{1}' to type '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_ArgumentCopyBackNarrowing3] As String
          Get
            Return GetResourceString("ERR_ArgumentCopyBackNarrowing3")
          End Get
        End Property
        ''' <summary>'{0}' has the same name as a type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_ShadowingGenericParamWithMember1] As String
          Get
            Return GetResourceString("ERR_ShadowingGenericParamWithMember1")
          End Get
        End Property
        ''' <summary>{0} '{1}' cannot inherit from a type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_GenericParamBase2] As String
          Get
            Return GetResourceString("ERR_GenericParamBase2")
          End Get
        End Property
        ''' <summary>Type parameter not allowed in 'Implements' clause.</summary>
        Friend Shared ReadOnly Property [ERR_ImplementsGenericParam] As String
          Get
            Return GetResourceString("ERR_ImplementsGenericParam")
          End Get
        End Property
        ''' <summary>Array lower bounds can be only '0'.</summary>
        Friend Shared ReadOnly Property [ERR_OnlyNullLowerBound] As String
          Get
            Return GetResourceString("ERR_OnlyNullLowerBound")
          End Get
        End Property
        ''' <summary>Type constraint cannot be a 'NotInheritable' class.</summary>
        Friend Shared ReadOnly Property [ERR_ClassConstraintNotInheritable1] As String
          Get
            Return GetResourceString("ERR_ClassConstraintNotInheritable1")
          End Get
        End Property
        ''' <summary>'{0}' cannot be used as a type constraint.</summary>
        Friend Shared ReadOnly Property [ERR_ConstraintIsRestrictedType1] As String
          Get
            Return GetResourceString("ERR_ConstraintIsRestrictedType1")
          End Get
        End Property
        ''' <summary>Type parameters cannot be specified on this declaration.</summary>
        Friend Shared ReadOnly Property [ERR_GenericParamsOnInvalidMember] As String
          Get
            Return GetResourceString("ERR_GenericParamsOnInvalidMember")
          End Get
        End Property
        ''' <summary>Type arguments are not valid because attributes cannot be generic.</summary>
        Friend Shared ReadOnly Property [ERR_GenericArgsOnAttributeSpecifier] As String
          Get
            Return GetResourceString("ERR_GenericArgsOnAttributeSpecifier")
          End Get
        End Property
        ''' <summary>Type parameters, generic types or types contained in generic types cannot be used as attributes.</summary>
        Friend Shared ReadOnly Property [ERR_AttrCannotBeGenerics] As String
          Get
            Return GetResourceString("ERR_AttrCannotBeGenerics")
          End Get
        End Property
        ''' <summary>Local variables within generic methods cannot be declared 'Static'.</summary>
        Friend Shared ReadOnly Property [ERR_BadStaticLocalInGenericMethod] As String
          Get
            Return GetResourceString("ERR_BadStaticLocalInGenericMethod")
          End Get
        End Property
        ''' <summary>{0} '{1}' implicitly defines a member '{2}' which has the same name as a type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_SyntMemberShadowsGenericParam3] As String
          Get
            Return GetResourceString("ERR_SyntMemberShadowsGenericParam3")
          End Get
        End Property
        ''' <summary>Constraint type '{0}' already specified for this type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_ConstraintAlreadyExists1] As String
          Get
            Return GetResourceString("ERR_ConstraintAlreadyExists1")
          End Get
        End Property
        ''' <summary>Cannot implement interface '{0}' because its implementation could conflict with the implementation of another implemented interface '{1}' for some type arguments.</summary>
        Friend Shared ReadOnly Property [ERR_InterfacePossiblyImplTwice2] As String
          Get
            Return GetResourceString("ERR_InterfacePossiblyImplTwice2")
          End Get
        End Property
        ''' <summary>Modules cannot be generic.</summary>
        Friend Shared ReadOnly Property [ERR_ModulesCannotBeGeneric] As String
          Get
            Return GetResourceString("ERR_ModulesCannotBeGeneric")
          End Get
        End Property
        ''' <summary>Classes that are generic or contained in a generic type cannot inherit from an attribute class.</summary>
        Friend Shared ReadOnly Property [ERR_GenericClassCannotInheritAttr] As String
          Get
            Return GetResourceString("ERR_GenericClassCannotInheritAttr")
          End Get
        End Property
        ''' <summary>'Declare' statements are not allowed in generic types or types contained in generic types.</summary>
        Friend Shared ReadOnly Property [ERR_DeclaresCantBeInGeneric] As String
          Get
            Return GetResourceString("ERR_DeclaresCantBeInGeneric")
          End Get
        End Property
        ''' <summary>'{0}' cannot override '{1}' because they differ by type parameter constraints.</summary>
        Friend Shared ReadOnly Property [ERR_OverrideWithConstraintMismatch2] As String
          Get
            Return GetResourceString("ERR_OverrideWithConstraintMismatch2")
          End Get
        End Property
        ''' <summary>'{0}' cannot implement '{1}.{2}' because they differ by type parameter constraints.</summary>
        Friend Shared ReadOnly Property [ERR_ImplementsWithConstraintMismatch3] As String
          Get
            Return GetResourceString("ERR_ImplementsWithConstraintMismatch3")
          End Get
        End Property
        ''' <summary>Type parameters or types constructed with type parameters are not allowed in attribute arguments.</summary>
        Friend Shared ReadOnly Property [ERR_OpenTypeDisallowed] As String
          Get
            Return GetResourceString("ERR_OpenTypeDisallowed")
          End Get
        End Property
        ''' <summary>Generic methods cannot use 'Handles' clause.</summary>
        Friend Shared ReadOnly Property [ERR_HandlesInvalidOnGenericMethod] As String
          Get
            Return GetResourceString("ERR_HandlesInvalidOnGenericMethod")
          End Get
        End Property
        ''' <summary>'New' constraint cannot be specified multiple times for the same type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_MultipleNewConstraints] As String
          Get
            Return GetResourceString("ERR_MultipleNewConstraints")
          End Get
        End Property
        ''' <summary>Type argument '{0}' is declared 'MustInherit' and does not satisfy the 'New' constraint for type parameter '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_MustInheritForNewConstraint2] As String
          Get
            Return GetResourceString("ERR_MustInheritForNewConstraint2")
          End Get
        End Property
        ''' <summary>Type argument '{0}' must have a public parameterless instance constructor to satisfy the 'New' constraint for type parameter '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_NoSuitableNewForNewConstraint2] As String
          Get
            Return GetResourceString("ERR_NoSuitableNewForNewConstraint2")
          End Get
        End Property
        ''' <summary>Type parameter '{0}' must have either a 'New' constraint or a 'Structure' constraint to satisfy the 'New' constraint for type parameter '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadGenericParamForNewConstraint2] As String
          Get
            Return GetResourceString("ERR_BadGenericParamForNewConstraint2")
          End Get
        End Property
        ''' <summary>Arguments cannot be passed to a 'New' used on a type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_NewArgsDisallowedForTypeParam] As String
          Get
            Return GetResourceString("ERR_NewArgsDisallowedForTypeParam")
          End Get
        End Property
        ''' <summary>Generic type '{0}' cannot be imported more than once.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateRawGenericTypeImport1] As String
          Get
            Return GetResourceString("ERR_DuplicateRawGenericTypeImport1")
          End Get
        End Property
        ''' <summary>Overload resolution failed because no accessible '{0}' accepts this number of type arguments.</summary>
        Friend Shared ReadOnly Property [ERR_NoTypeArgumentCountOverloadCand1] As String
          Get
            Return GetResourceString("ERR_NoTypeArgumentCountOverloadCand1")
          End Get
        End Property
        ''' <summary>Type arguments unexpected.</summary>
        Friend Shared ReadOnly Property [ERR_TypeArgsUnexpected] As String
          Get
            Return GetResourceString("ERR_TypeArgsUnexpected")
          End Get
        End Property
        ''' <summary>'{0}' is already declared as a type parameter of this method.</summary>
        Friend Shared ReadOnly Property [ERR_NameSameAsMethodTypeParam1] As String
          Get
            Return GetResourceString("ERR_NameSameAsMethodTypeParam1")
          End Get
        End Property
        ''' <summary>Type parameter cannot have the same name as its defining function.</summary>
        Friend Shared ReadOnly Property [ERR_TypeParamNameFunctionNameCollision] As String
          Get
            Return GetResourceString("ERR_TypeParamNameFunctionNameCollision")
          End Get
        End Property
        ''' <summary>Type or 'New' expected.</summary>
        Friend Shared ReadOnly Property [ERR_BadConstraintSyntax] As String
          Get
            Return GetResourceString("ERR_BadConstraintSyntax")
          End Get
        End Property
        ''' <summary>'Of' required when specifying type arguments for a generic type or method.</summary>
        Friend Shared ReadOnly Property [ERR_OfExpected] As String
          Get
            Return GetResourceString("ERR_OfExpected")
          End Get
        End Property
        ''' <summary>'(' unexpected. Arrays of uninstantiated generic types are not allowed.</summary>
        Friend Shared ReadOnly Property [ERR_ArrayOfRawGenericInvalid] As String
          Get
            Return GetResourceString("ERR_ArrayOfRawGenericInvalid")
          End Get
        End Property
        ''' <summary>'For Each' on type '{0}' is ambiguous because the type implements multiple instantiations of 'System.Collections.Generic.IEnumerable(Of T)'.</summary>
        Friend Shared ReadOnly Property [ERR_ForEachAmbiguousIEnumerable1] As String
          Get
            Return GetResourceString("ERR_ForEachAmbiguousIEnumerable1")
          End Get
        End Property
        ''' <summary>'IsNot' operand of type '{0}' can be compared only to 'Nothing' because '{0}' is a type parameter with no class constraint.</summary>
        Friend Shared ReadOnly Property [ERR_IsNotOperatorGenericParam1] As String
          Get
            Return GetResourceString("ERR_IsNotOperatorGenericParam1")
          End Get
        End Property
        ''' <summary>Type parameters cannot be used as qualifiers.</summary>
        Friend Shared ReadOnly Property [ERR_TypeParamQualifierDisallowed] As String
          Get
            Return GetResourceString("ERR_TypeParamQualifierDisallowed")
          End Get
        End Property
        ''' <summary>Comma or ')' expected.</summary>
        Friend Shared ReadOnly Property [ERR_TypeParamMissingCommaOrRParen] As String
          Get
            Return GetResourceString("ERR_TypeParamMissingCommaOrRParen")
          End Get
        End Property
        ''' <summary>'As', comma or ')' expected.</summary>
        Friend Shared ReadOnly Property [ERR_TypeParamMissingAsCommaOrRParen] As String
          Get
            Return GetResourceString("ERR_TypeParamMissingAsCommaOrRParen")
          End Get
        End Property
        ''' <summary>'Class' constraint cannot be specified multiple times for the same type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_MultipleReferenceConstraints] As String
          Get
            Return GetResourceString("ERR_MultipleReferenceConstraints")
          End Get
        End Property
        ''' <summary>'Structure' constraint cannot be specified multiple times for the same type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_MultipleValueConstraints] As String
          Get
            Return GetResourceString("ERR_MultipleValueConstraints")
          End Get
        End Property
        ''' <summary>'New' constraint and 'Structure' constraint cannot be combined.</summary>
        Friend Shared ReadOnly Property [ERR_NewAndValueConstraintsCombined] As String
          Get
            Return GetResourceString("ERR_NewAndValueConstraintsCombined")
          End Get
        End Property
        ''' <summary>'Class' constraint and 'Structure' constraint cannot be combined.</summary>
        Friend Shared ReadOnly Property [ERR_RefAndValueConstraintsCombined] As String
          Get
            Return GetResourceString("ERR_RefAndValueConstraintsCombined")
          End Get
        End Property
        ''' <summary>Type argument '{0}' does not satisfy the 'Structure' constraint for type parameter '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadTypeArgForStructConstraint2] As String
          Get
            Return GetResourceString("ERR_BadTypeArgForStructConstraint2")
          End Get
        End Property
        ''' <summary>Type argument '{0}' must be a non-nullable value type, along with all fields at any level of nesting, in order to use it as type parameter '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_UnmanagedConstraintNotSatisfied] As String
          Get
            Return GetResourceString("ERR_UnmanagedConstraintNotSatisfied")
          End Get
        End Property
        ''' <summary>Type argument '{0}' does not satisfy the 'Class' constraint for type parameter '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadTypeArgForRefConstraint2] As String
          Get
            Return GetResourceString("ERR_BadTypeArgForRefConstraint2")
          End Get
        End Property
        ''' <summary>'Class' constraint and a specific class type constraint cannot be combined.</summary>
        Friend Shared ReadOnly Property [ERR_RefAndClassTypeConstrCombined] As String
          Get
            Return GetResourceString("ERR_RefAndClassTypeConstrCombined")
          End Get
        End Property
        ''' <summary>'Structure' constraint and a specific class type constraint cannot be combined.</summary>
        Friend Shared ReadOnly Property [ERR_ValueAndClassTypeConstrCombined] As String
          Get
            Return GetResourceString("ERR_ValueAndClassTypeConstrCombined")
          End Get
        End Property
        ''' <summary>Indirect constraint '{0}' obtained from the type parameter constraint '{1}' conflicts with the indirect constraint '{2}' obtained from the type parameter constraint '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_ConstraintClashIndirectIndirect4] As String
          Get
            Return GetResourceString("ERR_ConstraintClashIndirectIndirect4")
          End Get
        End Property
        ''' <summary>Constraint '{0}' conflicts with the indirect constraint '{1}' obtained from the type parameter constraint '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_ConstraintClashDirectIndirect3] As String
          Get
            Return GetResourceString("ERR_ConstraintClashDirectIndirect3")
          End Get
        End Property
        ''' <summary>Indirect constraint '{0}' obtained from the type parameter constraint '{1}' conflicts with the constraint '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_ConstraintClashIndirectDirect3] As String
          Get
            Return GetResourceString("ERR_ConstraintClashIndirectDirect3")
          End Get
        End Property
        ''' <summary>'{0}' is constrained to '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_ConstraintCycleLink2] As String
          Get
            Return GetResourceString("ERR_ConstraintCycleLink2")
          End Get
        End Property
        ''' <summary>Type parameter '{0}' cannot be constrained to itself: {1}</summary>
        Friend Shared ReadOnly Property [ERR_ConstraintCycle2] As String
          Get
            Return GetResourceString("ERR_ConstraintCycle2")
          End Get
        End Property
        ''' <summary>Type parameter with a 'Structure' constraint cannot be used as a constraint.</summary>
        Friend Shared ReadOnly Property [ERR_TypeParamWithStructConstAsConst] As String
          Get
            Return GetResourceString("ERR_TypeParamWithStructConstAsConst")
          End Get
        End Property
        ''' <summary>'System.Nullable' does not satisfy the 'Structure' constraint for type parameter '{0}'. Only non-nullable 'Structure' types are allowed.</summary>
        Friend Shared ReadOnly Property [ERR_NullableDisallowedForStructConstr1] As String
          Get
            Return GetResourceString("ERR_NullableDisallowedForStructConstr1")
          End Get
        End Property
        ''' <summary>Constraint '{0}' conflicts with the constraint '{1}' already specified for type parameter '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_ConflictingDirectConstraints3] As String
          Get
            Return GetResourceString("ERR_ConflictingDirectConstraints3")
          End Get
        End Property
        ''' <summary>Cannot inherit interface '{0}' because it could be identical to interface '{1}' for some type arguments.</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceUnifiesWithInterface2] As String
          Get
            Return GetResourceString("ERR_InterfaceUnifiesWithInterface2")
          End Get
        End Property
        ''' <summary>Cannot inherit interface '{0}' because the interface '{1}' from which it inherits could be identical to interface '{2}' for some type arguments.</summary>
        Friend Shared ReadOnly Property [ERR_BaseUnifiesWithInterfaces3] As String
          Get
            Return GetResourceString("ERR_BaseUnifiesWithInterfaces3")
          End Get
        End Property
        ''' <summary>Cannot inherit interface '{0}' because the interface '{1}' from which it inherits could be identical to interface '{2}' from which the interface '{3}' inherits for some type arguments.</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceBaseUnifiesWithBase4] As String
          Get
            Return GetResourceString("ERR_InterfaceBaseUnifiesWithBase4")
          End Get
        End Property
        ''' <summary>Cannot inherit interface '{0}' because it could be identical to interface '{1}' from which the interface '{2}' inherits for some type arguments.</summary>
        Friend Shared ReadOnly Property [ERR_InterfaceUnifiesWithBase3] As String
          Get
            Return GetResourceString("ERR_InterfaceUnifiesWithBase3")
          End Get
        End Property
        ''' <summary>Cannot implement interface '{0}' because the interface '{1}' from which it inherits could be identical to implemented interface '{2}' for some type arguments.</summary>
        Friend Shared ReadOnly Property [ERR_ClassInheritsBaseUnifiesWithInterfaces3] As String
          Get
            Return GetResourceString("ERR_ClassInheritsBaseUnifiesWithInterfaces3")
          End Get
        End Property
        ''' <summary>Cannot implement interface '{0}' because the interface '{1}' from which it inherits could be identical to interface '{2}' from which the implemented interface '{3}' inherits for some type arguments.</summary>
        Friend Shared ReadOnly Property [ERR_ClassInheritsInterfaceBaseUnifiesWithBase4] As String
          Get
            Return GetResourceString("ERR_ClassInheritsInterfaceBaseUnifiesWithBase4")
          End Get
        End Property
        ''' <summary>Cannot implement interface '{0}' because it could be identical to interface '{1}' from which the implemented interface '{2}' inherits for some type arguments.</summary>
        Friend Shared ReadOnly Property [ERR_ClassInheritsInterfaceUnifiesWithBase3] As String
          Get
            Return GetResourceString("ERR_ClassInheritsInterfaceUnifiesWithBase3")
          End Get
        End Property
        ''' <summary>Generic parameters used as optional parameter types must be class constrained.</summary>
        Friend Shared ReadOnly Property [ERR_OptionalsCantBeStructGenericParams] As String
          Get
            Return GetResourceString("ERR_OptionalsCantBeStructGenericParams")
          End Get
        End Property
        ''' <summary>Methods of 'System.Nullable(Of T)' cannot be used as operands of the 'AddressOf' operator.</summary>
        Friend Shared ReadOnly Property [ERR_AddressOfNullableMethod] As String
          Get
            Return GetResourceString("ERR_AddressOfNullableMethod")
          End Get
        End Property
        ''' <summary>'Is' operand of type '{0}' can be compared only to 'Nothing' because '{0}' is a nullable type.</summary>
        Friend Shared ReadOnly Property [ERR_IsOperatorNullable1] As String
          Get
            Return GetResourceString("ERR_IsOperatorNullable1")
          End Get
        End Property
        ''' <summary>'IsNot' operand of type '{0}' can be compared only to 'Nothing' because '{0}' is a nullable type.</summary>
        Friend Shared ReadOnly Property [ERR_IsNotOperatorNullable1] As String
          Get
            Return GetResourceString("ERR_IsNotOperatorNullable1")
          End Get
        End Property
        ''' <summary>'{0}' cannot be declared 'Shadows' outside of a class, structure, or interface.</summary>
        Friend Shared ReadOnly Property [ERR_ShadowingTypeOutsideClass1] As String
          Get
            Return GetResourceString("ERR_ShadowingTypeOutsideClass1")
          End Get
        End Property
        ''' <summary>Property parameters cannot have the name 'Value'.</summary>
        Friend Shared ReadOnly Property [ERR_PropertySetParamCollisionWithValue] As String
          Get
            Return GetResourceString("ERR_PropertySetParamCollisionWithValue")
          End Get
        End Property
        ''' <summary>The project currently contains references to more than one version of '{0}', a direct reference to version {2} and an indirect reference to version {1}. Change the direct reference to use version {1} (or higher) of {0}.</summary>
        Friend Shared ReadOnly Property [ERR_SxSIndirectRefHigherThanDirectRef3] As String
          Get
            Return GetResourceString("ERR_SxSIndirectRefHigherThanDirectRef3")
          End Get
        End Property
        ''' <summary>Multiple assemblies with equivalent identity have been imported: '{0}' and '{1}'. Remove one of the duplicate references.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateReferenceStrong] As String
          Get
            Return GetResourceString("ERR_DuplicateReferenceStrong")
          End Get
        End Property
        ''' <summary>Project already has a reference to assembly '{0}'. A second reference to '{1}' cannot be added.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateReference2] As String
          Get
            Return GetResourceString("ERR_DuplicateReference2")
          End Get
        End Property
        ''' <summary>Illegal call expression or index expression.</summary>
        Friend Shared ReadOnly Property [ERR_IllegalCallOrIndex] As String
          Get
            Return GetResourceString("ERR_IllegalCallOrIndex")
          End Get
        End Property
        ''' <summary>Conflict between the default property and the 'DefaultMemberAttribute' defined on '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_ConflictDefaultPropertyAttribute] As String
          Get
            Return GetResourceString("ERR_ConflictDefaultPropertyAttribute")
          End Get
        End Property
        ''' <summary>'{0}' cannot be applied because the format of the GUID '{1}' is not correct.</summary>
        Friend Shared ReadOnly Property [ERR_BadAttributeUuid2] As String
          Get
            Return GetResourceString("ERR_BadAttributeUuid2")
          End Get
        End Property
        ''' <summary>'Microsoft.VisualBasic.ComClassAttribute' and '{0}' cannot both be applied to the same class.</summary>
        Friend Shared ReadOnly Property [ERR_ComClassAndReservedAttribute1] As String
          Get
            Return GetResourceString("ERR_ComClassAndReservedAttribute1")
          End Get
        End Property
        ''' <summary>'Microsoft.VisualBasic.ComClassAttribute' cannot be applied to '{0}' because its container '{1}' is not declared 'Public'.</summary>
        Friend Shared ReadOnly Property [ERR_ComClassRequiresPublicClass2] As String
          Get
            Return GetResourceString("ERR_ComClassRequiresPublicClass2")
          End Get
        End Property
        ''' <summary>'System.Runtime.InteropServices.DispIdAttribute' cannot be applied to '{0}' because 'Microsoft.VisualBasic.ComClassAttribute' reserves zero for the default property.</summary>
        Friend Shared ReadOnly Property [ERR_ComClassReservedDispIdZero1] As String
          Get
            Return GetResourceString("ERR_ComClassReservedDispIdZero1")
          End Get
        End Property
        ''' <summary>'System.Runtime.InteropServices.DispIdAttribute' cannot be applied to '{0}' because 'Microsoft.VisualBasic.ComClassAttribute' reserves values less than zero.</summary>
        Friend Shared ReadOnly Property [ERR_ComClassReservedDispId1] As String
          Get
            Return GetResourceString("ERR_ComClassReservedDispId1")
          End Get
        End Property
        ''' <summary>'InterfaceId' and 'EventsId' parameters for 'Microsoft.VisualBasic.ComClassAttribute' on '{0}' cannot have the same value.</summary>
        Friend Shared ReadOnly Property [ERR_ComClassDuplicateGuids1] As String
          Get
            Return GetResourceString("ERR_ComClassDuplicateGuids1")
          End Get
        End Property
        ''' <summary>'Microsoft.VisualBasic.ComClassAttribute' cannot be applied to a class that is declared 'MustInherit'.</summary>
        Friend Shared ReadOnly Property [ERR_ComClassCantBeAbstract0] As String
          Get
            Return GetResourceString("ERR_ComClassCantBeAbstract0")
          End Get
        End Property
        ''' <summary>'Microsoft.VisualBasic.ComClassAttribute' cannot be applied to '{0}' because it is not declared 'Public'.</summary>
        Friend Shared ReadOnly Property [ERR_ComClassRequiresPublicClass1] As String
          Get
            Return GetResourceString("ERR_ComClassRequiresPublicClass1")
          End Get
        End Property
        ''' <summary>Operator declaration must be one of:  +, -, *, \, /, ^, &amp;, Like, Mod, And, Or, Xor, Not, &lt;&lt;, &gt;&gt;, =, &lt;&gt;, &lt;, &lt;=, &gt;, &gt;=, CType, IsTrue, IsFalse.</summary>
        Friend Shared ReadOnly Property [ERR_UnknownOperator] As String
          Get
            Return GetResourceString("ERR_UnknownOperator")
          End Get
        End Property
        ''' <summary>'Widening' and 'Narrowing' cannot be combined.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateConversionCategoryUsed] As String
          Get
            Return GetResourceString("ERR_DuplicateConversionCategoryUsed")
          End Get
        End Property
        ''' <summary>Operator is not overloadable. Operator declaration must be one of:  +, -, *, \, /, ^, &amp;, Like, Mod, And, Or, Xor, Not, &lt;&lt;, &gt;&gt;, =, &lt;&gt;, &lt;, &lt;=, &gt;, &gt;=, CType, IsTrue, IsFalse.</summary>
        Friend Shared ReadOnly Property [ERR_OperatorNotOverloadable] As String
          Get
            Return GetResourceString("ERR_OperatorNotOverloadable")
          End Get
        End Property
        ''' <summary>'Handles' is not valid on operator declarations.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidHandles] As String
          Get
            Return GetResourceString("ERR_InvalidHandles")
          End Get
        End Property
        ''' <summary>'Implements' is not valid on operator declarations.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidImplements] As String
          Get
            Return GetResourceString("ERR_InvalidImplements")
          End Get
        End Property
        ''' <summary>'End Operator' expected.</summary>
        Friend Shared ReadOnly Property [ERR_EndOperatorExpected] As String
          Get
            Return GetResourceString("ERR_EndOperatorExpected")
          End Get
        End Property
        ''' <summary>'End Operator' must be the first statement on a line.</summary>
        Friend Shared ReadOnly Property [ERR_EndOperatorNotAtLineStart] As String
          Get
            Return GetResourceString("ERR_EndOperatorNotAtLineStart")
          End Get
        End Property
        ''' <summary>'End Operator' must be preceded by a matching 'Operator'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidEndOperator] As String
          Get
            Return GetResourceString("ERR_InvalidEndOperator")
          End Get
        End Property
        ''' <summary>'Exit Operator' is not valid. Use 'Return' to exit an operator.</summary>
        Friend Shared ReadOnly Property [ERR_ExitOperatorNotValid] As String
          Get
            Return GetResourceString("ERR_ExitOperatorNotValid")
          End Get
        End Property
        ''' <summary>'{0}' parameters cannot be declared 'ParamArray'.</summary>
        Friend Shared ReadOnly Property [ERR_ParamArrayIllegal1] As String
          Get
            Return GetResourceString("ERR_ParamArrayIllegal1")
          End Get
        End Property
        ''' <summary>'{0}' parameters cannot be declared 'Optional'.</summary>
        Friend Shared ReadOnly Property [ERR_OptionalIllegal1] As String
          Get
            Return GetResourceString("ERR_OptionalIllegal1")
          End Get
        End Property
        ''' <summary>Operators must be declared 'Public'.</summary>
        Friend Shared ReadOnly Property [ERR_OperatorMustBePublic] As String
          Get
            Return GetResourceString("ERR_OperatorMustBePublic")
          End Get
        End Property
        ''' <summary>Operators must be declared 'Shared'.</summary>
        Friend Shared ReadOnly Property [ERR_OperatorMustBeShared] As String
          Get
            Return GetResourceString("ERR_OperatorMustBeShared")
          End Get
        End Property
        ''' <summary>Operators cannot be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadOperatorFlags1] As String
          Get
            Return GetResourceString("ERR_BadOperatorFlags1")
          End Get
        End Property
        ''' <summary>Operator '{0}' must have one parameter.</summary>
        Friend Shared ReadOnly Property [ERR_OneParameterRequired1] As String
          Get
            Return GetResourceString("ERR_OneParameterRequired1")
          End Get
        End Property
        ''' <summary>Operator '{0}' must have two parameters.</summary>
        Friend Shared ReadOnly Property [ERR_TwoParametersRequired1] As String
          Get
            Return GetResourceString("ERR_TwoParametersRequired1")
          End Get
        End Property
        ''' <summary>Operator '{0}' must have either one or two parameters.</summary>
        Friend Shared ReadOnly Property [ERR_OneOrTwoParametersRequired1] As String
          Get
            Return GetResourceString("ERR_OneOrTwoParametersRequired1")
          End Get
        End Property
        ''' <summary>Conversion operators must be declared either 'Widening' or 'Narrowing'.</summary>
        Friend Shared ReadOnly Property [ERR_ConvMustBeWideningOrNarrowing] As String
          Get
            Return GetResourceString("ERR_ConvMustBeWideningOrNarrowing")
          End Get
        End Property
        ''' <summary>Operators cannot be declared in modules.</summary>
        Friend Shared ReadOnly Property [ERR_OperatorDeclaredInModule] As String
          Get
            Return GetResourceString("ERR_OperatorDeclaredInModule")
          End Get
        End Property
        ''' <summary>Only conversion operators can be declared '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidSpecifierOnNonConversion1] As String
          Get
            Return GetResourceString("ERR_InvalidSpecifierOnNonConversion1")
          End Get
        End Property
        ''' <summary>Parameter of this unary operator must be of the containing type '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_UnaryParamMustBeContainingType1] As String
          Get
            Return GetResourceString("ERR_UnaryParamMustBeContainingType1")
          End Get
        End Property
        ''' <summary>At least one parameter of this binary operator must be of the containing type '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BinaryParamMustBeContainingType1] As String
          Get
            Return GetResourceString("ERR_BinaryParamMustBeContainingType1")
          End Get
        End Property
        ''' <summary>Either the parameter type or the return type of this conversion operator must be of the containing type '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_ConvParamMustBeContainingType1] As String
          Get
            Return GetResourceString("ERR_ConvParamMustBeContainingType1")
          End Get
        End Property
        ''' <summary>Operator '{0}' must have a return type of Boolean.</summary>
        Friend Shared ReadOnly Property [ERR_OperatorRequiresBoolReturnType1] As String
          Get
            Return GetResourceString("ERR_OperatorRequiresBoolReturnType1")
          End Get
        End Property
        ''' <summary>Conversion operators cannot convert from a type to the same type.</summary>
        Friend Shared ReadOnly Property [ERR_ConversionToSameType] As String
          Get
            Return GetResourceString("ERR_ConversionToSameType")
          End Get
        End Property
        ''' <summary>Conversion operators cannot convert to an interface type.</summary>
        Friend Shared ReadOnly Property [ERR_ConversionToInterfaceType] As String
          Get
            Return GetResourceString("ERR_ConversionToInterfaceType")
          End Get
        End Property
        ''' <summary>Conversion operators cannot convert from a type to its base type.</summary>
        Friend Shared ReadOnly Property [ERR_ConversionToBaseType] As String
          Get
            Return GetResourceString("ERR_ConversionToBaseType")
          End Get
        End Property
        ''' <summary>Conversion operators cannot convert from a type to its derived type.</summary>
        Friend Shared ReadOnly Property [ERR_ConversionToDerivedType] As String
          Get
            Return GetResourceString("ERR_ConversionToDerivedType")
          End Get
        End Property
        ''' <summary>Conversion operators cannot convert to Object.</summary>
        Friend Shared ReadOnly Property [ERR_ConversionToObject] As String
          Get
            Return GetResourceString("ERR_ConversionToObject")
          End Get
        End Property
        ''' <summary>Conversion operators cannot convert from an interface type.</summary>
        Friend Shared ReadOnly Property [ERR_ConversionFromInterfaceType] As String
          Get
            Return GetResourceString("ERR_ConversionFromInterfaceType")
          End Get
        End Property
        ''' <summary>Conversion operators cannot convert from a base type.</summary>
        Friend Shared ReadOnly Property [ERR_ConversionFromBaseType] As String
          Get
            Return GetResourceString("ERR_ConversionFromBaseType")
          End Get
        End Property
        ''' <summary>Conversion operators cannot convert from a derived type.</summary>
        Friend Shared ReadOnly Property [ERR_ConversionFromDerivedType] As String
          Get
            Return GetResourceString("ERR_ConversionFromDerivedType")
          End Get
        End Property
        ''' <summary>Conversion operators cannot convert from Object.</summary>
        Friend Shared ReadOnly Property [ERR_ConversionFromObject] As String
          Get
            Return GetResourceString("ERR_ConversionFromObject")
          End Get
        End Property
        ''' <summary>Matching '{0}' operator is required for '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_MatchingOperatorExpected2] As String
          Get
            Return GetResourceString("ERR_MatchingOperatorExpected2")
          End Get
        End Property
        ''' <summary>Return and parameter types of '{0}' must be '{1}' to be used in a '{2}' expression.</summary>
        Friend Shared ReadOnly Property [ERR_UnacceptableLogicalOperator3] As String
          Get
            Return GetResourceString("ERR_UnacceptableLogicalOperator3")
          End Get
        End Property
        ''' <summary>Type '{0}' must define operator '{1}' to be used in a '{2}' expression.</summary>
        Friend Shared ReadOnly Property [ERR_ConditionOperatorRequired3] As String
          Get
            Return GetResourceString("ERR_ConditionOperatorRequired3")
          End Get
        End Property
        ''' <summary>Cannot copy the value of 'ByRef' parameter '{0}' back to the matching argument because type '{1}' cannot be converted to type '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_CopyBackTypeMismatch3] As String
          Get
            Return GetResourceString("ERR_CopyBackTypeMismatch3")
          End Get
        End Property
        ''' <summary>Type '{0}' must define operator '{1}' to be used in a 'For' statement.</summary>
        Friend Shared ReadOnly Property [ERR_ForLoopOperatorRequired2] As String
          Get
            Return GetResourceString("ERR_ForLoopOperatorRequired2")
          End Get
        End Property
        ''' <summary>Return and parameter types of '{0}' must be '{1}' to be used in a 'For' statement.</summary>
        Friend Shared ReadOnly Property [ERR_UnacceptableForLoopOperator2] As String
          Get
            Return GetResourceString("ERR_UnacceptableForLoopOperator2")
          End Get
        End Property
        ''' <summary>Parameter types of '{0}' must be '{1}' to be used in a 'For' statement.</summary>
        Friend Shared ReadOnly Property [ERR_UnacceptableForLoopRelOperator2] As String
          Get
            Return GetResourceString("ERR_UnacceptableForLoopRelOperator2")
          End Get
        End Property
        ''' <summary>Operator '{0}' must have a second parameter of type 'Integer' or 'Integer?'.</summary>
        Friend Shared ReadOnly Property [ERR_OperatorRequiresIntegerParameter1] As String
          Get
            Return GetResourceString("ERR_OperatorRequiresIntegerParameter1")
          End Get
        End Property
        ''' <summary>Nullable modifier cannot be specified on both a variable and its type.</summary>
        Friend Shared ReadOnly Property [ERR_CantSpecifyNullableOnBoth] As String
          Get
            Return GetResourceString("ERR_CantSpecifyNullableOnBoth")
          End Get
        End Property
        ''' <summary>Type '{0}' must be a value type or a type argument constrained to 'Structure' in order to be used with 'Nullable' or nullable modifier '?'.</summary>
        Friend Shared ReadOnly Property [ERR_BadTypeArgForStructConstraintNull] As String
          Get
            Return GetResourceString("ERR_BadTypeArgForStructConstraintNull")
          End Get
        End Property
        ''' <summary>Nullable modifier '?' and array modifiers '(' and ')' cannot be specified on both a variable and its type.</summary>
        Friend Shared ReadOnly Property [ERR_CantSpecifyArrayAndNullableOnBoth] As String
          Get
            Return GetResourceString("ERR_CantSpecifyArrayAndNullableOnBoth")
          End Get
        End Property
        ''' <summary>Expressions used with an 'If' expression cannot contain type characters.</summary>
        Friend Shared ReadOnly Property [ERR_CantSpecifyTypeCharacterOnIIF] As String
          Get
            Return GetResourceString("ERR_CantSpecifyTypeCharacterOnIIF")
          End Get
        End Property
        ''' <summary>'If' operands cannot be named arguments.</summary>
        Friend Shared ReadOnly Property [ERR_IllegalOperandInIIFName] As String
          Get
            Return GetResourceString("ERR_IllegalOperandInIIFName")
          End Get
        End Property
        ''' <summary>Cannot infer a common type for the second and third operands of the 'If' operator. One must have a widening conversion to the other.</summary>
        Friend Shared ReadOnly Property [ERR_IllegalOperandInIIFConversion] As String
          Get
            Return GetResourceString("ERR_IllegalOperandInIIFConversion")
          End Get
        End Property
        ''' <summary>First operand in a binary 'If' expression must be a nullable value type, a reference type, or an unconstrained generic type.</summary>
        Friend Shared ReadOnly Property [ERR_IllegalCondTypeInIIF] As String
          Get
            Return GetResourceString("ERR_IllegalCondTypeInIIF")
          End Get
        End Property
        ''' <summary>'If' operator cannot be used in a 'Call' statement.</summary>
        Friend Shared ReadOnly Property [ERR_CantCallIIF] As String
          Get
            Return GetResourceString("ERR_CantCallIIF")
          End Get
        End Property
        ''' <summary>Nullable modifier cannot be specified in variable declarations with 'As New'.</summary>
        Friend Shared ReadOnly Property [ERR_CantSpecifyAsNewAndNullable] As String
          Get
            Return GetResourceString("ERR_CantSpecifyAsNewAndNullable")
          End Get
        End Property
        ''' <summary>Cannot infer a common type for the first and second operands of the binary 'If' operator. One must have a widening conversion to the other.</summary>
        Friend Shared ReadOnly Property [ERR_IllegalOperandInIIFConversion2] As String
          Get
            Return GetResourceString("ERR_IllegalOperandInIIFConversion2")
          End Get
        End Property
        ''' <summary>Nullable types are not allowed in conditional compilation expressions.</summary>
        Friend Shared ReadOnly Property [ERR_BadNullTypeInCCExpression] As String
          Get
            Return GetResourceString("ERR_BadNullTypeInCCExpression")
          End Get
        End Property
        ''' <summary>Nullable modifier cannot be used with a variable whose implicit type is 'Object'.</summary>
        Friend Shared ReadOnly Property [ERR_NullableImplicit] As String
          Get
            Return GetResourceString("ERR_NullableImplicit")
          End Get
        End Property
        ''' <summary>Requested operation is not available because the runtime library function '{0}' is not defined.</summary>
        Friend Shared ReadOnly Property [ERR_MissingRuntimeHelper] As String
          Get
            Return GetResourceString("ERR_MissingRuntimeHelper")
          End Get
        End Property
        ''' <summary>'Global' must be followed by '.' and an identifier.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedDotAfterGlobalNameSpace] As String
          Get
            Return GetResourceString("ERR_ExpectedDotAfterGlobalNameSpace")
          End Get
        End Property
        ''' <summary>'Global' not allowed in this context; identifier expected.</summary>
        Friend Shared ReadOnly Property [ERR_NoGlobalExpectedIdentifier] As String
          Get
            Return GetResourceString("ERR_NoGlobalExpectedIdentifier")
          End Get
        End Property
        ''' <summary>'Global' not allowed in handles; local name expected.</summary>
        Friend Shared ReadOnly Property [ERR_NoGlobalInHandles] As String
          Get
            Return GetResourceString("ERR_NoGlobalInHandles")
          End Get
        End Property
        ''' <summary>'ElseIf' must be preceded by a matching 'If' or 'ElseIf'.</summary>
        Friend Shared ReadOnly Property [ERR_ElseIfNoMatchingIf] As String
          Get
            Return GetResourceString("ERR_ElseIfNoMatchingIf")
          End Get
        End Property
        ''' <summary>Attribute constructor has a 'ByRef' parameter of type '{0}'; cannot use constructors with byref parameters to apply the attribute.</summary>
        Friend Shared ReadOnly Property [ERR_BadAttributeConstructor2] As String
          Get
            Return GetResourceString("ERR_BadAttributeConstructor2")
          End Get
        End Property
        ''' <summary>'End Using' must be preceded by a matching 'Using'.</summary>
        Friend Shared ReadOnly Property [ERR_EndUsingWithoutUsing] As String
          Get
            Return GetResourceString("ERR_EndUsingWithoutUsing")
          End Get
        End Property
        ''' <summary>'Using' must end with a matching 'End Using'.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEndUsing] As String
          Get
            Return GetResourceString("ERR_ExpectedEndUsing")
          End Get
        End Property
        ''' <summary>'GoTo {0}' is not valid because '{0}' is inside a 'Using' statement that does not contain this statement.</summary>
        Friend Shared ReadOnly Property [ERR_GotoIntoUsing] As String
          Get
            Return GetResourceString("ERR_GotoIntoUsing")
          End Get
        End Property
        ''' <summary>'Using' operand of type '{0}' must implement 'System.IDisposable'.</summary>
        Friend Shared ReadOnly Property [ERR_UsingRequiresDisposePattern] As String
          Get
            Return GetResourceString("ERR_UsingRequiresDisposePattern")
          End Get
        End Property
        ''' <summary>'Using' resource variable must have an explicit initialization.</summary>
        Friend Shared ReadOnly Property [ERR_UsingResourceVarNeedsInitializer] As String
          Get
            Return GetResourceString("ERR_UsingResourceVarNeedsInitializer")
          End Get
        End Property
        ''' <summary>'Using' resource variable type can not be array type.</summary>
        Friend Shared ReadOnly Property [ERR_UsingResourceVarCantBeArray] As String
          Get
            Return GetResourceString("ERR_UsingResourceVarCantBeArray")
          End Get
        End Property
        ''' <summary>'On Error' statements are not valid within 'Using' statements.</summary>
        Friend Shared ReadOnly Property [ERR_OnErrorInUsing] As String
          Get
            Return GetResourceString("ERR_OnErrorInUsing")
          End Get
        End Property
        ''' <summary>'{0}' has the same name as a member used for type '{1}' exposed in a 'My' group. Rename the type or its enclosing namespace.</summary>
        Friend Shared ReadOnly Property [ERR_PropertyNameConflictInMyCollection] As String
          Get
            Return GetResourceString("ERR_PropertyNameConflictInMyCollection")
          End Get
        End Property
        ''' <summary>Implicit variable '{0}' is invalid because of '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidImplicitVar] As String
          Get
            Return GetResourceString("ERR_InvalidImplicitVar")
          End Get
        End Property
        ''' <summary>Object initializers require a field name to initialize.</summary>
        Friend Shared ReadOnly Property [ERR_ObjectInitializerRequiresFieldName] As String
          Get
            Return GetResourceString("ERR_ObjectInitializerRequiresFieldName")
          End Get
        End Property
        ''' <summary>'From' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedFrom] As String
          Get
            Return GetResourceString("ERR_ExpectedFrom")
          End Get
        End Property
        ''' <summary>Nested function does not have the same signature as delegate '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_LambdaBindingMismatch1] As String
          Get
            Return GetResourceString("ERR_LambdaBindingMismatch1")
          End Get
        End Property
        ''' <summary>Nested sub does not have a signature that is compatible with delegate '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_LambdaBindingMismatch2] As String
          Get
            Return GetResourceString("ERR_LambdaBindingMismatch2")
          End Get
        End Property
        ''' <summary>'ByRef' parameter '{0}' cannot be used in a query expression.</summary>
        Friend Shared ReadOnly Property [ERR_CannotLiftByRefParamQuery1] As String
          Get
            Return GetResourceString("ERR_CannotLiftByRefParamQuery1")
          End Get
        End Property
        ''' <summary>Expression cannot be converted into an expression tree.</summary>
        Friend Shared ReadOnly Property [ERR_ExpressionTreeNotSupported] As String
          Get
            Return GetResourceString("ERR_ExpressionTreeNotSupported")
          End Get
        End Property
        ''' <summary>Instance members and 'Me' cannot be used within query expressions in structures.</summary>
        Friend Shared ReadOnly Property [ERR_CannotLiftStructureMeQuery] As String
          Get
            Return GetResourceString("ERR_CannotLiftStructureMeQuery")
          End Get
        End Property
        ''' <summary>Variable cannot be initialized with non-array type '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_InferringNonArrayType1] As String
          Get
            Return GetResourceString("ERR_InferringNonArrayType1")
          End Get
        End Property
        ''' <summary>References to 'ByRef' parameters cannot be converted to an expression tree.</summary>
        Friend Shared ReadOnly Property [ERR_ByRefParamInExpressionTree] As String
          Get
            Return GetResourceString("ERR_ByRefParamInExpressionTree")
          End Get
        End Property
        ''' <summary>Anonymous type member or property '{0}' is already declared.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateAnonTypeMemberName1] As String
          Get
            Return GetResourceString("ERR_DuplicateAnonTypeMemberName1")
          End Get
        End Property
        ''' <summary>Cannot convert anonymous type to an expression tree because a property of the type is used to initialize another property.</summary>
        Friend Shared ReadOnly Property [ERR_BadAnonymousTypeForExprTree] As String
          Get
            Return GetResourceString("ERR_BadAnonymousTypeForExprTree")
          End Get
        End Property
        ''' <summary>Anonymous type property '{0}' cannot be used in the definition of a lambda expression within the same initialization list.</summary>
        Friend Shared ReadOnly Property [ERR_CannotLiftAnonymousType1] As String
          Get
            Return GetResourceString("ERR_CannotLiftAnonymousType1")
          End Get
        End Property
        ''' <summary>'Extension' attribute can be applied only to 'Module', 'Sub', or 'Function' declarations.</summary>
        Friend Shared ReadOnly Property [ERR_ExtensionOnlyAllowedOnModuleSubOrFunction] As String
          Get
            Return GetResourceString("ERR_ExtensionOnlyAllowedOnModuleSubOrFunction")
          End Get
        End Property
        ''' <summary>Extension methods can be defined only in modules.</summary>
        Friend Shared ReadOnly Property [ERR_ExtensionMethodNotInModule] As String
          Get
            Return GetResourceString("ERR_ExtensionMethodNotInModule")
          End Get
        End Property
        ''' <summary>Extension methods must declare at least one parameter. The first parameter specifies which type to extend.</summary>
        Friend Shared ReadOnly Property [ERR_ExtensionMethodNoParams] As String
          Get
            Return GetResourceString("ERR_ExtensionMethodNoParams")
          End Get
        End Property
        ''' <summary>'Optional' cannot be applied to the first parameter of an extension method. The first parameter specifies which type to extend.</summary>
        Friend Shared ReadOnly Property [ERR_ExtensionMethodOptionalFirstArg] As String
          Get
            Return GetResourceString("ERR_ExtensionMethodOptionalFirstArg")
          End Get
        End Property
        ''' <summary>'ParamArray' cannot be applied to the first parameter of an extension method. The first parameter specifies which type to extend.</summary>
        Friend Shared ReadOnly Property [ERR_ExtensionMethodParamArrayFirstArg] As String
          Get
            Return GetResourceString("ERR_ExtensionMethodParamArrayFirstArg")
          End Get
        End Property
        ''' <summary>Anonymous type member name can be inferred only from a simple or qualified name with no arguments.</summary>
        Friend Shared ReadOnly Property [ERR_AnonymousTypeFieldNameInference] As String
          Get
            Return GetResourceString("ERR_AnonymousTypeFieldNameInference")
          End Get
        End Property
        ''' <summary>'{0}' is not a member of '{1}'; it does not exist in the current context.</summary>
        Friend Shared ReadOnly Property [ERR_NameNotMemberOfAnonymousType2] As String
          Get
            Return GetResourceString("ERR_NameNotMemberOfAnonymousType2")
          End Get
        End Property
        ''' <summary>The custom-designed version of 'System.Runtime.CompilerServices.ExtensionAttribute' found by the compiler is not valid. Its attribute usage flags must be set to allow assemblies, classes, and methods.</summary>
        Friend Shared ReadOnly Property [ERR_ExtensionAttributeInvalid] As String
          Get
            Return GetResourceString("ERR_ExtensionAttributeInvalid")
          End Get
        End Property
        ''' <summary>Anonymous type member property '{0}' cannot be used to infer the type of another member property because the type of '{0}' is not yet established.</summary>
        Friend Shared ReadOnly Property [ERR_AnonymousTypePropertyOutOfOrder1] As String
          Get
            Return GetResourceString("ERR_AnonymousTypePropertyOutOfOrder1")
          End Get
        End Property
        ''' <summary>Type characters cannot be used in anonymous type declarations.</summary>
        Friend Shared ReadOnly Property [ERR_AnonymousTypeDisallowsTypeChar] As String
          Get
            Return GetResourceString("ERR_AnonymousTypeDisallowsTypeChar")
          End Get
        End Property
        ''' <summary>Type characters cannot be used in tuple literals.</summary>
        Friend Shared ReadOnly Property [ERR_TupleLiteralDisallowsTypeChar] As String
          Get
            Return GetResourceString("ERR_TupleLiteralDisallowsTypeChar")
          End Get
        End Property
        ''' <summary>'New' cannot be used with tuple type. Use a tuple literal expression instead.</summary>
        Friend Shared ReadOnly Property [ERR_NewWithTupleTypeSyntax] As String
          Get
            Return GetResourceString("ERR_NewWithTupleTypeSyntax")
          End Get
        End Property
        ''' <summary>Predefined type '{0}' must be a structure.</summary>
        Friend Shared ReadOnly Property [ERR_PredefinedValueTupleTypeMustBeStruct] As String
          Get
            Return GetResourceString("ERR_PredefinedValueTupleTypeMustBeStruct")
          End Get
        End Property
        ''' <summary>Extension method '{0}' has type constraints that can never be satisfied.</summary>
        Friend Shared ReadOnly Property [ERR_ExtensionMethodUncallable1] As String
          Get
            Return GetResourceString("ERR_ExtensionMethodUncallable1")
          End Get
        End Property
        ''' <summary>Extension method '{0}' defined in '{1}': {2}</summary>
        Friend Shared ReadOnly Property [ERR_ExtensionMethodOverloadCandidate3] As String
          Get
            Return GetResourceString("ERR_ExtensionMethodOverloadCandidate3")
          End Get
        End Property
        ''' <summary>Method does not have a signature compatible with the delegate.</summary>
        Friend Shared ReadOnly Property [ERR_DelegateBindingMismatch] As String
          Get
            Return GetResourceString("ERR_DelegateBindingMismatch")
          End Get
        End Property
        ''' <summary>Type arguments could not be inferred from the delegate.</summary>
        Friend Shared ReadOnly Property [ERR_DelegateBindingTypeInferenceFails] As String
          Get
            Return GetResourceString("ERR_DelegateBindingTypeInferenceFails")
          End Get
        End Property
        ''' <summary>Too many arguments.</summary>
        Friend Shared ReadOnly Property [ERR_TooManyArgs] As String
          Get
            Return GetResourceString("ERR_TooManyArgs")
          End Get
        End Property
        ''' <summary>Parameter '{0}' already has a matching omitted argument.</summary>
        Friend Shared ReadOnly Property [ERR_NamedArgAlsoOmitted1] As String
          Get
            Return GetResourceString("ERR_NamedArgAlsoOmitted1")
          End Get
        End Property
        ''' <summary>Parameter '{0}' already has a matching argument.</summary>
        Friend Shared ReadOnly Property [ERR_NamedArgUsedTwice1] As String
          Get
            Return GetResourceString("ERR_NamedArgUsedTwice1")
          End Get
        End Property
        ''' <summary>'{0}' is not a method parameter.</summary>
        Friend Shared ReadOnly Property [ERR_NamedParamNotFound1] As String
          Get
            Return GetResourceString("ERR_NamedParamNotFound1")
          End Get
        End Property
        ''' <summary>Argument not specified for parameter '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_OmittedArgument1] As String
          Get
            Return GetResourceString("ERR_OmittedArgument1")
          End Get
        End Property
        ''' <summary>Type parameter '{0}' cannot be inferred.</summary>
        Friend Shared ReadOnly Property [ERR_UnboundTypeParam1] As String
          Get
            Return GetResourceString("ERR_UnboundTypeParam1")
          End Get
        End Property
        ''' <summary>Extension method '{0}' defined in '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_ExtensionMethodOverloadCandidate2] As String
          Get
            Return GetResourceString("ERR_ExtensionMethodOverloadCandidate2")
          End Get
        End Property
        ''' <summary>Anonymous type must contain at least one member.</summary>
        Friend Shared ReadOnly Property [ERR_AnonymousTypeNeedField] As String
          Get
            Return GetResourceString("ERR_AnonymousTypeNeedField")
          End Get
        End Property
        ''' <summary>Anonymous type member name must be preceded by a period.</summary>
        Friend Shared ReadOnly Property [ERR_AnonymousTypeNameWithoutPeriod] As String
          Get
            Return GetResourceString("ERR_AnonymousTypeNameWithoutPeriod")
          End Get
        End Property
        ''' <summary>Identifier expected, preceded with a period.</summary>
        Friend Shared ReadOnly Property [ERR_AnonymousTypeExpectedIdentifier] As String
          Get
            Return GetResourceString("ERR_AnonymousTypeExpectedIdentifier")
          End Get
        End Property
        ''' <summary>Too many arguments to extension method '{0}' defined in '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_TooManyArgs2] As String
          Get
            Return GetResourceString("ERR_TooManyArgs2")
          End Get
        End Property
        ''' <summary>Parameter '{0}' in extension method '{1}' defined in '{2}' already has a matching omitted argument.</summary>
        Friend Shared ReadOnly Property [ERR_NamedArgAlsoOmitted3] As String
          Get
            Return GetResourceString("ERR_NamedArgAlsoOmitted3")
          End Get
        End Property
        ''' <summary>Parameter '{0}' of extension method '{1}' defined in '{2}' already has a matching argument.</summary>
        Friend Shared ReadOnly Property [ERR_NamedArgUsedTwice3] As String
          Get
            Return GetResourceString("ERR_NamedArgUsedTwice3")
          End Get
        End Property
        ''' <summary>'{0}' is not a parameter of extension method '{1}' defined in '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_NamedParamNotFound3] As String
          Get
            Return GetResourceString("ERR_NamedParamNotFound3")
          End Get
        End Property
        ''' <summary>Argument not specified for parameter '{0}' of extension method '{1}' defined in '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_OmittedArgument3] As String
          Get
            Return GetResourceString("ERR_OmittedArgument3")
          End Get
        End Property
        ''' <summary>Type parameter '{0}' for extension method '{1}' defined in '{2}' cannot be inferred.</summary>
        Friend Shared ReadOnly Property [ERR_UnboundTypeParam3] As String
          Get
            Return GetResourceString("ERR_UnboundTypeParam3")
          End Get
        End Property
        ''' <summary>Too few type arguments to extension method '{0}' defined in '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_TooFewGenericArguments2] As String
          Get
            Return GetResourceString("ERR_TooFewGenericArguments2")
          End Get
        End Property
        ''' <summary>Too many type arguments to extension method '{0}' defined in '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_TooManyGenericArguments2] As String
          Get
            Return GetResourceString("ERR_TooManyGenericArguments2")
          End Get
        End Property
        ''' <summary>'In' or '=' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedInOrEq] As String
          Get
            Return GetResourceString("ERR_ExpectedInOrEq")
          End Get
        End Property
        ''' <summary>Expression of type '{0}' is not queryable. Make sure you are not missing an assembly reference and/or namespace import for the LINQ provider.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedQueryableSource] As String
          Get
            Return GetResourceString("ERR_ExpectedQueryableSource")
          End Get
        End Property
        ''' <summary>Definition of method '{0}' is not accessible in this context.</summary>
        Friend Shared ReadOnly Property [ERR_QueryOperatorNotFound] As String
          Get
            Return GetResourceString("ERR_QueryOperatorNotFound")
          End Get
        End Property
        ''' <summary>Method cannot contain both a '{0}' statement and a definition of a variable that is used in a lambda or query expression.</summary>
        Friend Shared ReadOnly Property [ERR_CannotUseOnErrorGotoWithClosure] As String
          Get
            Return GetResourceString("ERR_CannotUseOnErrorGotoWithClosure")
          End Get
        End Property
        ''' <summary>'{0}{1}' is not valid because '{2}' is inside a scope that defines a variable that is used in a lambda or query expression.</summary>
        Friend Shared ReadOnly Property [ERR_CannotGotoNonScopeBlocksWithClosure] As String
          Get
            Return GetResourceString("ERR_CannotGotoNonScopeBlocksWithClosure")
          End Get
        End Property
        ''' <summary>Instance of restricted type '{0}' cannot be used in a query expression.</summary>
        Friend Shared ReadOnly Property [ERR_CannotLiftRestrictedTypeQuery] As String
          Get
            Return GetResourceString("ERR_CannotLiftRestrictedTypeQuery")
          End Get
        End Property
        ''' <summary>Range variable name can be inferred only from a simple or qualified name with no arguments.</summary>
        Friend Shared ReadOnly Property [ERR_QueryAnonymousTypeFieldNameInference] As String
          Get
            Return GetResourceString("ERR_QueryAnonymousTypeFieldNameInference")
          End Get
        End Property
        ''' <summary>Range variable '{0}' is already declared.</summary>
        Friend Shared ReadOnly Property [ERR_QueryDuplicateAnonTypeMemberName1] As String
          Get
            Return GetResourceString("ERR_QueryDuplicateAnonTypeMemberName1")
          End Get
        End Property
        ''' <summary>Type characters cannot be used in range variable declarations.</summary>
        Friend Shared ReadOnly Property [ERR_QueryAnonymousTypeDisallowsTypeChar] As String
          Get
            Return GetResourceString("ERR_QueryAnonymousTypeDisallowsTypeChar")
          End Get
        End Property
        ''' <summary>'ReadOnly' variable cannot be the target of an assignment in a lambda expression inside a constructor.</summary>
        Friend Shared ReadOnly Property [ERR_ReadOnlyInClosure] As String
          Get
            Return GetResourceString("ERR_ReadOnlyInClosure")
          End Get
        End Property
        ''' <summary>Multi-dimensional array cannot be converted to an expression tree.</summary>
        Friend Shared ReadOnly Property [ERR_ExprTreeNoMultiDimArrayCreation] As String
          Get
            Return GetResourceString("ERR_ExprTreeNoMultiDimArrayCreation")
          End Get
        End Property
        ''' <summary>Late binding operations cannot be converted to an expression tree.</summary>
        Friend Shared ReadOnly Property [ERR_ExprTreeNoLateBind] As String
          Get
            Return GetResourceString("ERR_ExprTreeNoLateBind")
          End Get
        End Property
        ''' <summary>'By' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedBy] As String
          Get
            Return GetResourceString("ERR_ExpectedBy")
          End Get
        End Property
        ''' <summary>Range variable name cannot match the name of a member of the 'Object' class.</summary>
        Friend Shared ReadOnly Property [ERR_QueryInvalidControlVariableName1] As String
          Get
            Return GetResourceString("ERR_QueryInvalidControlVariableName1")
          End Get
        End Property
        ''' <summary>'In' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedIn] As String
          Get
            Return GetResourceString("ERR_ExpectedIn")
          End Get
        End Property
        ''' <summary>Name '{0}' is either not declared or not in the current scope.</summary>
        Friend Shared ReadOnly Property [ERR_QueryNameNotDeclared] As String
          Get
            Return GetResourceString("ERR_QueryNameNotDeclared")
          End Get
        End Property
        ''' <summary>Return type of nested function matching parameter '{0}' narrows from '{1}' to '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_NestedFunctionArgumentNarrowing3] As String
          Get
            Return GetResourceString("ERR_NestedFunctionArgumentNarrowing3")
          End Get
        End Property
        ''' <summary>Anonymous type member name cannot be inferred from an XML identifier that is not a valid Visual Basic identifier.</summary>
        Friend Shared ReadOnly Property [ERR_AnonTypeFieldXMLNameInference] As String
          Get
            Return GetResourceString("ERR_AnonTypeFieldXMLNameInference")
          End Get
        End Property
        ''' <summary>Range variable name cannot be inferred from an XML identifier that is not a valid Visual Basic identifier.</summary>
        Friend Shared ReadOnly Property [ERR_QueryAnonTypeFieldXMLNameInference] As String
          Get
            Return GetResourceString("ERR_QueryAnonTypeFieldXMLNameInference")
          End Get
        End Property
        ''' <summary>'Into' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedInto] As String
          Get
            Return GetResourceString("ERR_ExpectedInto")
          End Get
        End Property
        ''' <summary>Aggregate function name cannot be used with a type character.</summary>
        Friend Shared ReadOnly Property [ERR_TypeCharOnAggregation] As String
          Get
            Return GetResourceString("ERR_TypeCharOnAggregation")
          End Get
        End Property
        ''' <summary>'On' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedOn] As String
          Get
            Return GetResourceString("ERR_ExpectedOn")
          End Get
        End Property
        ''' <summary>'Equals' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedEquals] As String
          Get
            Return GetResourceString("ERR_ExpectedEquals")
          End Get
        End Property
        ''' <summary>'And' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedAnd] As String
          Get
            Return GetResourceString("ERR_ExpectedAnd")
          End Get
        End Property
        ''' <summary>'Equals' cannot compare a value of type '{0}' with a value of type '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_EqualsTypeMismatch] As String
          Get
            Return GetResourceString("ERR_EqualsTypeMismatch")
          End Get
        End Property
        ''' <summary>You must reference at least one range variable on both sides of the 'Equals' operator. Range variable(s) {0} must appear on one side of the 'Equals' operator, and range variable(s) {1} must appear on the other.</summary>
        Friend Shared ReadOnly Property [ERR_EqualsOperandIsBad] As String
          Get
            Return GetResourceString("ERR_EqualsOperandIsBad")
          End Get
        End Property
        ''' <summary>Lambda expression cannot be converted to '{0}' because '{0}' is not a delegate type.</summary>
        Friend Shared ReadOnly Property [ERR_LambdaNotDelegate1] As String
          Get
            Return GetResourceString("ERR_LambdaNotDelegate1")
          End Get
        End Property
        ''' <summary>Lambda expression cannot be converted to '{0}' because type '{0}' is declared 'MustInherit' and cannot be created.</summary>
        Friend Shared ReadOnly Property [ERR_LambdaNotCreatableDelegate1] As String
          Get
            Return GetResourceString("ERR_LambdaNotCreatableDelegate1")
          End Get
        End Property
        ''' <summary>A nullable type cannot be inferred for variable '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_CannotInferNullableForVariable1] As String
          Get
            Return GetResourceString("ERR_CannotInferNullableForVariable1")
          End Get
        End Property
        ''' <summary>Nullable type inference is not supported in this context.</summary>
        Friend Shared ReadOnly Property [ERR_NullableTypeInferenceNotSupported] As String
          Get
            Return GetResourceString("ERR_NullableTypeInferenceNotSupported")
          End Get
        End Property
        ''' <summary>'Join' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedJoin] As String
          Get
            Return GetResourceString("ERR_ExpectedJoin")
          End Get
        End Property
        ''' <summary>Nullable parameters must specify a type.</summary>
        Friend Shared ReadOnly Property [ERR_NullableParameterMustSpecifyType] As String
          Get
            Return GetResourceString("ERR_NullableParameterMustSpecifyType")
          End Get
        End Property
        ''' <summary>Range variable '{0}' hides a variable in an enclosing block, a previously defined range variable, or an implicitly declared variable in a query expression.</summary>
        Friend Shared ReadOnly Property [ERR_IterationVariableShadowLocal2] As String
          Get
            Return GetResourceString("ERR_IterationVariableShadowLocal2")
          End Get
        End Property
        ''' <summary>Attributes cannot be applied to parameters of lambda expressions.</summary>
        Friend Shared ReadOnly Property [ERR_LambdasCannotHaveAttributes] As String
          Get
            Return GetResourceString("ERR_LambdasCannotHaveAttributes")
          End Get
        End Property
        ''' <summary>Lambda expressions are not valid in the first expression of a 'Select Case' statement.</summary>
        Friend Shared ReadOnly Property [ERR_LambdaInSelectCaseExpr] As String
          Get
            Return GetResourceString("ERR_LambdaInSelectCaseExpr")
          End Get
        End Property
        ''' <summary>'AddressOf' expressions are not valid in the first expression of a 'Select Case' statement.</summary>
        Friend Shared ReadOnly Property [ERR_AddressOfInSelectCaseExpr] As String
          Get
            Return GetResourceString("ERR_AddressOfInSelectCaseExpr")
          End Get
        End Property
        ''' <summary>The '?' character cannot be used here.</summary>
        Friend Shared ReadOnly Property [ERR_NullableCharNotSupported] As String
          Get
            Return GetResourceString("ERR_NullableCharNotSupported")
          End Get
        End Property
        ''' <summary>Instance members and 'Me' cannot be used within a lambda expression in structures.</summary>
        Friend Shared ReadOnly Property [ERR_CannotLiftStructureMeLambda] As String
          Get
            Return GetResourceString("ERR_CannotLiftStructureMeLambda")
          End Get
        End Property
        ''' <summary>'ByRef' parameter '{0}' cannot be used in a lambda expression.</summary>
        Friend Shared ReadOnly Property [ERR_CannotLiftByRefParamLambda1] As String
          Get
            Return GetResourceString("ERR_CannotLiftByRefParamLambda1")
          End Get
        End Property
        ''' <summary>Instance of restricted type '{0}' cannot be used in a lambda expression.</summary>
        Friend Shared ReadOnly Property [ERR_CannotLiftRestrictedTypeLambda] As String
          Get
            Return GetResourceString("ERR_CannotLiftRestrictedTypeLambda")
          End Get
        End Property
        ''' <summary>Lambda parameter '{0}' hides a variable in an enclosing block, a previously defined range variable, or an implicitly declared variable in a query expression.</summary>
        Friend Shared ReadOnly Property [ERR_LambdaParamShadowLocal1] As String
          Get
            Return GetResourceString("ERR_LambdaParamShadowLocal1")
          End Get
        End Property
        ''' <summary>Option Strict On requires each lambda expression parameter to be declared with an 'As' clause if its type cannot be inferred.</summary>
        Friend Shared ReadOnly Property [ERR_StrictDisallowImplicitObjectLambda] As String
          Get
            Return GetResourceString("ERR_StrictDisallowImplicitObjectLambda")
          End Get
        End Property
        ''' <summary>Array modifiers cannot be specified on lambda expression parameter name. They must be specified on its type.</summary>
        Friend Shared ReadOnly Property [ERR_CantSpecifyParamsOnLambdaParamNoType] As String
          Get
            Return GetResourceString("ERR_CantSpecifyParamsOnLambdaParamNoType")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) cannot be inferred from these arguments. Specifying the data type(s) explicitly might correct this error.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailure1] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailure1")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) in method '{0}' cannot be inferred from these arguments. Specifying the data type(s) explicitly might correct this error.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailure2] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailure2")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) in extension method '{0}' defined in '{1}' cannot be inferred from these arguments. Specifying the data type(s) explicitly might correct this error.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailure3] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailure3")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) cannot be inferred from these arguments.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailureNoExplicit1] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailureNoExplicit1")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) in method '{0}' cannot be inferred from these arguments.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailureNoExplicit2] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailureNoExplicit2")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) in extension method '{0}' defined in '{1}' cannot be inferred from these arguments.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailureNoExplicit3] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailureNoExplicit3")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) cannot be inferred from these arguments because more than one type is possible. Specifying the data type(s) explicitly might correct this error.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailureAmbiguous1] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailureAmbiguous1")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) in method '{0}' cannot be inferred from these arguments because more than one type is possible. Specifying the data type(s) explicitly might correct this error.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailureAmbiguous2] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailureAmbiguous2")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) in extension method '{0}' defined in '{1}' cannot be inferred from these arguments because more than one type is possible. Specifying the data type(s) explicitly might correct this error.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailureAmbiguous3] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailureAmbiguous3")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) cannot be inferred from these arguments because more than one type is possible.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailureNoExplicitAmbiguous1] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailureNoExplicitAmbiguous1")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) in method '{0}' cannot be inferred from these arguments because more than one type is possible.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailureNoExplicitAmbiguous2] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailureNoExplicitAmbiguous2")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) in extension method '{0}' defined in '{1}' cannot be inferred from these arguments because more than one type is possible.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailureNoExplicitAmbiguous3] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailureNoExplicitAmbiguous3")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) cannot be inferred from these arguments because they do not convert to the same type. Specifying the data type(s) explicitly might correct this error.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailureNoBest1] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailureNoBest1")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) in method '{0}' cannot be inferred from these arguments because they do not convert to the same type. Specifying the data type(s) explicitly might correct this error.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailureNoBest2] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailureNoBest2")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) in extension method '{0}' defined in '{1}' cannot be inferred from these arguments because they do not convert to the same type. Specifying the data type(s) explicitly might correct this error.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailureNoBest3] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailureNoBest3")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) cannot be inferred from these arguments because they do not convert to the same type.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailureNoExplicitNoBest1] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailureNoExplicitNoBest1")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) in method '{0}' cannot be inferred from these arguments because they do not convert to the same type.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailureNoExplicitNoBest2] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailureNoExplicitNoBest2")
          End Get
        End Property
        ''' <summary>Data type(s) of the type parameter(s) in extension method '{0}' defined in '{1}' cannot be inferred from these arguments because they do not convert to the same type.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceFailureNoExplicitNoBest3] As String
          Get
            Return GetResourceString("ERR_TypeInferenceFailureNoExplicitNoBest3")
          End Get
        End Property
        ''' <summary>Option Strict On does not allow narrowing in implicit type conversions between method '{0}' and delegate '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_DelegateBindingMismatchStrictOff2] As String
          Get
            Return GetResourceString("ERR_DelegateBindingMismatchStrictOff2")
          End Get
        End Property
        ''' <summary>'{0}' is not accessible in this context because the return type is not accessible.</summary>
        Friend Shared ReadOnly Property [ERR_InaccessibleReturnTypeOfMember2] As String
          Get
            Return GetResourceString("ERR_InaccessibleReturnTypeOfMember2")
          End Get
        End Property
        ''' <summary>'Group' or an identifier expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedIdentifierOrGroup] As String
          Get
            Return GetResourceString("ERR_ExpectedIdentifierOrGroup")
          End Get
        End Property
        ''' <summary>'Group' not allowed in this context; identifier expected.</summary>
        Friend Shared ReadOnly Property [ERR_UnexpectedGroup] As String
          Get
            Return GetResourceString("ERR_UnexpectedGroup")
          End Get
        End Property
        ''' <summary>Option Strict On does not allow narrowing in implicit type conversions between extension method '{0}' defined in '{2}' and delegate '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_DelegateBindingMismatchStrictOff3] As String
          Get
            Return GetResourceString("ERR_DelegateBindingMismatchStrictOff3")
          End Get
        End Property
        ''' <summary>Extension Method '{0}' defined in '{2}' does not have a signature compatible with delegate '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_DelegateBindingIncompatible3] As String
          Get
            Return GetResourceString("ERR_DelegateBindingIncompatible3")
          End Get
        End Property
        ''' <summary>Argument matching parameter '{0}' narrows to '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_ArgumentNarrowing2] As String
          Get
            Return GetResourceString("ERR_ArgumentNarrowing2")
          End Get
        End Property
        ''' <summary>{0}</summary>
        Friend Shared ReadOnly Property [ERR_OverloadCandidate1] As String
          Get
            Return GetResourceString("ERR_OverloadCandidate1")
          End Get
        End Property
        ''' <summary>Auto-implemented Properties contained in Structures cannot have initializers unless they are marked 'Shared'.</summary>
        Friend Shared ReadOnly Property [ERR_AutoPropertyInitializedInStructure] As String
          Get
            Return GetResourceString("ERR_AutoPropertyInitializedInStructure")
          End Get
        End Property
        ''' <summary>XML elements cannot be selected from type '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_TypeDisallowsElements] As String
          Get
            Return GetResourceString("ERR_TypeDisallowsElements")
          End Get
        End Property
        ''' <summary>XML attributes cannot be selected from type '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_TypeDisallowsAttributes] As String
          Get
            Return GetResourceString("ERR_TypeDisallowsAttributes")
          End Get
        End Property
        ''' <summary>XML descendant elements cannot be selected from type '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_TypeDisallowsDescendants] As String
          Get
            Return GetResourceString("ERR_TypeDisallowsDescendants")
          End Get
        End Property
        ''' <summary>Extension method '{0}' defined in '{1}' is not generic (or has no free type parameters) and so cannot have type arguments.</summary>
        Friend Shared ReadOnly Property [ERR_TypeOrMemberNotGeneric2] As String
          Get
            Return GetResourceString("ERR_TypeOrMemberNotGeneric2")
          End Get
        End Property
        ''' <summary>Late-bound extension methods are not supported.</summary>
        Friend Shared ReadOnly Property [ERR_ExtensionMethodCannotBeLateBound] As String
          Get
            Return GetResourceString("ERR_ExtensionMethodCannotBeLateBound")
          End Get
        End Property
        ''' <summary>Cannot infer a data type for '{0}' because the array dimensions do not match.</summary>
        Friend Shared ReadOnly Property [ERR_TypeInferenceArrayRankMismatch1] As String
          Get
            Return GetResourceString("ERR_TypeInferenceArrayRankMismatch1")
          End Get
        End Property
        ''' <summary>Type of the range variable cannot be inferred, and late binding is not allowed with Option Strict on. Use an 'As' clause to specify the type.</summary>
        Friend Shared ReadOnly Property [ERR_QueryStrictDisallowImplicitObject] As String
          Get
            Return GetResourceString("ERR_QueryStrictDisallowImplicitObject")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be embedded because it has generic argument. Consider disabling the embedding of interop types.</summary>
        Friend Shared ReadOnly Property [ERR_CannotEmbedInterfaceWithGeneric] As String
          Get
            Return GetResourceString("ERR_CannotEmbedInterfaceWithGeneric")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used across assembly boundaries because it has a generic type argument that is an embedded interop type.</summary>
        Friend Shared ReadOnly Property [ERR_CannotUseGenericTypeAcrossAssemblyBoundaries] As String
          Get
            Return GetResourceString("ERR_CannotUseGenericTypeAcrossAssemblyBoundaries")
          End Get
        End Property
        ''' <summary>'{0}' is obsolete: '{1}'.</summary>
        Friend Shared ReadOnly Property [WRN_UseOfObsoleteSymbol2] As String
          Get
            Return GetResourceString("WRN_UseOfObsoleteSymbol2")
          End Get
        End Property
        ''' <summary>Type or member is obsolete</summary>
        Friend Shared ReadOnly Property [WRN_UseOfObsoleteSymbol2_Title] As String
          Get
            Return GetResourceString("WRN_UseOfObsoleteSymbol2_Title")
          End Get
        End Property
        ''' <summary>{0} '{1}' shadows an overloadable member declared in the base {2} '{3}'.  If you want to overload the base method, this method must be declared 'Overloads'.</summary>
        Friend Shared ReadOnly Property [WRN_MustOverloadBase4] As String
          Get
            Return GetResourceString("WRN_MustOverloadBase4")
          End Get
        End Property
        ''' <summary>Member shadows an overloadable member declared in the base type</summary>
        Friend Shared ReadOnly Property [WRN_MustOverloadBase4_Title] As String
          Get
            Return GetResourceString("WRN_MustOverloadBase4_Title")
          End Get
        End Property
        ''' <summary>{0} '{1}' conflicts with {2} '{1}' in the base {3} '{4}' and should be declared 'Shadows'.</summary>
        Friend Shared ReadOnly Property [WRN_OverrideType5] As String
          Get
            Return GetResourceString("WRN_OverrideType5")
          End Get
        End Property
        ''' <summary>Member conflicts with member in the base type and should be declared 'Shadows'</summary>
        Friend Shared ReadOnly Property [WRN_OverrideType5_Title] As String
          Get
            Return GetResourceString("WRN_OverrideType5_Title")
          End Get
        End Property
        ''' <summary>{0} '{1}' shadows an overridable method in the base {2} '{3}'. To override the base method, this method must be declared 'Overrides'.</summary>
        Friend Shared ReadOnly Property [WRN_MustOverride2] As String
          Get
            Return GetResourceString("WRN_MustOverride2")
          End Get
        End Property
        ''' <summary>Member shadows an overridable method in the base type</summary>
        Friend Shared ReadOnly Property [WRN_MustOverride2_Title] As String
          Get
            Return GetResourceString("WRN_MustOverride2_Title")
          End Get
        End Property
        ''' <summary>Default property '{0}' conflicts with the default property '{1}' in the base {2} '{3}'. '{0}' will be the default property. '{0}' should be declared 'Shadows'.</summary>
        Friend Shared ReadOnly Property [WRN_DefaultnessShadowed4] As String
          Get
            Return GetResourceString("WRN_DefaultnessShadowed4")
          End Get
        End Property
        ''' <summary>Default property conflicts with the default property in the base type</summary>
        Friend Shared ReadOnly Property [WRN_DefaultnessShadowed4_Title] As String
          Get
            Return GetResourceString("WRN_DefaultnessShadowed4_Title")
          End Get
        End Property
        ''' <summary>'{0}' is obsolete.</summary>
        Friend Shared ReadOnly Property [WRN_UseOfObsoleteSymbolNoMessage1] As String
          Get
            Return GetResourceString("WRN_UseOfObsoleteSymbolNoMessage1")
          End Get
        End Property
        ''' <summary>Type or member is obsolete</summary>
        Friend Shared ReadOnly Property [WRN_UseOfObsoleteSymbolNoMessage1_Title] As String
          Get
            Return GetResourceString("WRN_UseOfObsoleteSymbolNoMessage1_Title")
          End Get
        End Property
        ''' <summary>Possible problem detected while building assembly: {0}</summary>
        Friend Shared ReadOnly Property [WRN_AssemblyGeneration0] As String
          Get
            Return GetResourceString("WRN_AssemblyGeneration0")
          End Get
        End Property
        ''' <summary>Possible problem detected while building assembly</summary>
        Friend Shared ReadOnly Property [WRN_AssemblyGeneration0_Title] As String
          Get
            Return GetResourceString("WRN_AssemblyGeneration0_Title")
          End Get
        End Property
        ''' <summary>Possible problem detected while building assembly '{0}': {1}</summary>
        Friend Shared ReadOnly Property [WRN_AssemblyGeneration1] As String
          Get
            Return GetResourceString("WRN_AssemblyGeneration1")
          End Get
        End Property
        ''' <summary>Possible problem detected while building assembly</summary>
        Friend Shared ReadOnly Property [WRN_AssemblyGeneration1_Title] As String
          Get
            Return GetResourceString("WRN_AssemblyGeneration1_Title")
          End Get
        End Property
        ''' <summary>'Microsoft.VisualBasic.ComClassAttribute' is specified for class '{0}' but '{0}' has no public members that can be exposed to COM; therefore, no COM interfaces are generated.</summary>
        Friend Shared ReadOnly Property [WRN_ComClassNoMembers1] As String
          Get
            Return GetResourceString("WRN_ComClassNoMembers1")
          End Get
        End Property
        ''' <summary>'Microsoft.VisualBasic.ComClassAttribute' is specified for class but class has no public members that can be exposed to COM</summary>
        Friend Shared ReadOnly Property [WRN_ComClassNoMembers1_Title] As String
          Get
            Return GetResourceString("WRN_ComClassNoMembers1_Title")
          End Get
        End Property
        ''' <summary>{0} '{1}' implicitly declares '{2}', which conflicts with a member in the base {3} '{4}', and so the {0} should be declared 'Shadows'.</summary>
        Friend Shared ReadOnly Property [WRN_SynthMemberShadowsMember5] As String
          Get
            Return GetResourceString("WRN_SynthMemberShadowsMember5")
          End Get
        End Property
        ''' <summary>Property or event implicitly declares type or member that conflicts with a member in the base type</summary>
        Friend Shared ReadOnly Property [WRN_SynthMemberShadowsMember5_Title] As String
          Get
            Return GetResourceString("WRN_SynthMemberShadowsMember5_Title")
          End Get
        End Property
        ''' <summary>{0} '{1}' conflicts with a member implicitly declared for {2} '{3}' in the base {4} '{5}' and should be declared 'Shadows'.</summary>
        Friend Shared ReadOnly Property [WRN_MemberShadowsSynthMember6] As String
          Get
            Return GetResourceString("WRN_MemberShadowsSynthMember6")
          End Get
        End Property
        ''' <summary>Member conflicts with a member implicitly declared for property or event in the base type</summary>
        Friend Shared ReadOnly Property [WRN_MemberShadowsSynthMember6_Title] As String
          Get
            Return GetResourceString("WRN_MemberShadowsSynthMember6_Title")
          End Get
        End Property
        ''' <summary>{0} '{1}' implicitly declares '{2}', which conflicts with a member implicitly declared for {3} '{4}' in the base {5} '{6}'. {0} should be declared 'Shadows'.</summary>
        Friend Shared ReadOnly Property [WRN_SynthMemberShadowsSynthMember7] As String
          Get
            Return GetResourceString("WRN_SynthMemberShadowsSynthMember7")
          End Get
        End Property
        ''' <summary>Property or event implicitly declares member, which conflicts with a member implicitly declared for property or event in the base type</summary>
        Friend Shared ReadOnly Property [WRN_SynthMemberShadowsSynthMember7_Title] As String
          Get
            Return GetResourceString("WRN_SynthMemberShadowsSynthMember7_Title")
          End Get
        End Property
        ''' <summary>'{0}' accessor of '{1}' is obsolete: '{2}'.</summary>
        Friend Shared ReadOnly Property [WRN_UseOfObsoletePropertyAccessor3] As String
          Get
            Return GetResourceString("WRN_UseOfObsoletePropertyAccessor3")
          End Get
        End Property
        ''' <summary>Property accessor is obsolete</summary>
        Friend Shared ReadOnly Property [WRN_UseOfObsoletePropertyAccessor3_Title] As String
          Get
            Return GetResourceString("WRN_UseOfObsoletePropertyAccessor3_Title")
          End Get
        End Property
        ''' <summary>'{0}' accessor of '{1}' is obsolete.</summary>
        Friend Shared ReadOnly Property [WRN_UseOfObsoletePropertyAccessor2] As String
          Get
            Return GetResourceString("WRN_UseOfObsoletePropertyAccessor2")
          End Get
        End Property
        ''' <summary>Property accessor is obsolete</summary>
        Friend Shared ReadOnly Property [WRN_UseOfObsoletePropertyAccessor2_Title] As String
          Get
            Return GetResourceString("WRN_UseOfObsoletePropertyAccessor2_Title")
          End Get
        End Property
        ''' <summary>Type of member '{0}' is not CLS-compliant.</summary>
        Friend Shared ReadOnly Property [WRN_FieldNotCLSCompliant1] As String
          Get
            Return GetResourceString("WRN_FieldNotCLSCompliant1")
          End Get
        End Property
        ''' <summary>Type of member is not CLS-compliant</summary>
        Friend Shared ReadOnly Property [WRN_FieldNotCLSCompliant1_Title] As String
          Get
            Return GetResourceString("WRN_FieldNotCLSCompliant1_Title")
          End Get
        End Property
        ''' <summary>'{0}' is not CLS-compliant because it derives from '{1}', which is not CLS-compliant.</summary>
        Friend Shared ReadOnly Property [WRN_BaseClassNotCLSCompliant2] As String
          Get
            Return GetResourceString("WRN_BaseClassNotCLSCompliant2")
          End Get
        End Property
        ''' <summary>Type is not CLS-compliant because it derives from base type that is not CLS-compliant</summary>
        Friend Shared ReadOnly Property [WRN_BaseClassNotCLSCompliant2_Title] As String
          Get
            Return GetResourceString("WRN_BaseClassNotCLSCompliant2_Title")
          End Get
        End Property
        ''' <summary>Return type of function '{0}' is not CLS-compliant.</summary>
        Friend Shared ReadOnly Property [WRN_ProcTypeNotCLSCompliant1] As String
          Get
            Return GetResourceString("WRN_ProcTypeNotCLSCompliant1")
          End Get
        End Property
        ''' <summary>Return type of function is not CLS-compliant</summary>
        Friend Shared ReadOnly Property [WRN_ProcTypeNotCLSCompliant1_Title] As String
          Get
            Return GetResourceString("WRN_ProcTypeNotCLSCompliant1_Title")
          End Get
        End Property
        ''' <summary>Type of parameter '{0}' is not CLS-compliant.</summary>
        Friend Shared ReadOnly Property [WRN_ParamNotCLSCompliant1] As String
          Get
            Return GetResourceString("WRN_ParamNotCLSCompliant1")
          End Get
        End Property
        ''' <summary>Type of parameter is not CLS-compliant</summary>
        Friend Shared ReadOnly Property [WRN_ParamNotCLSCompliant1_Title] As String
          Get
            Return GetResourceString("WRN_ParamNotCLSCompliant1_Title")
          End Get
        End Property
        ''' <summary>'{0}' is not CLS-compliant because the interface '{1}' it inherits from is not CLS-compliant.</summary>
        Friend Shared ReadOnly Property [WRN_InheritedInterfaceNotCLSCompliant2] As String
          Get
            Return GetResourceString("WRN_InheritedInterfaceNotCLSCompliant2")
          End Get
        End Property
        ''' <summary>Type is not CLS-compliant because the interface it inherits from is not CLS-compliant</summary>
        Friend Shared ReadOnly Property [WRN_InheritedInterfaceNotCLSCompliant2_Title] As String
          Get
            Return GetResourceString("WRN_InheritedInterfaceNotCLSCompliant2_Title")
          End Get
        End Property
        ''' <summary>{0} '{1}' cannot be marked CLS-compliant because its containing type '{2}' is not CLS-compliant.</summary>
        Friend Shared ReadOnly Property [WRN_CLSMemberInNonCLSType3] As String
          Get
            Return GetResourceString("WRN_CLSMemberInNonCLSType3")
          End Get
        End Property
        ''' <summary>Member cannot be marked CLS-compliant because its containing type is not CLS-compliant</summary>
        Friend Shared ReadOnly Property [WRN_CLSMemberInNonCLSType3_Title] As String
          Get
            Return GetResourceString("WRN_CLSMemberInNonCLSType3_Title")
          End Get
        End Property
        ''' <summary>Name '{0}' is not CLS-compliant.</summary>
        Friend Shared ReadOnly Property [WRN_NameNotCLSCompliant1] As String
          Get
            Return GetResourceString("WRN_NameNotCLSCompliant1")
          End Get
        End Property
        ''' <summary>Name is not CLS-compliant</summary>
        Friend Shared ReadOnly Property [WRN_NameNotCLSCompliant1_Title] As String
          Get
            Return GetResourceString("WRN_NameNotCLSCompliant1_Title")
          End Get
        End Property
        ''' <summary>Underlying type '{0}' of Enum is not CLS-compliant.</summary>
        Friend Shared ReadOnly Property [WRN_EnumUnderlyingTypeNotCLS1] As String
          Get
            Return GetResourceString("WRN_EnumUnderlyingTypeNotCLS1")
          End Get
        End Property
        ''' <summary>Underlying type of Enum is not CLS-compliant</summary>
        Friend Shared ReadOnly Property [WRN_EnumUnderlyingTypeNotCLS1_Title] As String
          Get
            Return GetResourceString("WRN_EnumUnderlyingTypeNotCLS1_Title")
          End Get
        End Property
        ''' <summary>Non CLS-compliant '{0}' is not allowed in a CLS-compliant interface.</summary>
        Friend Shared ReadOnly Property [WRN_NonCLSMemberInCLSInterface1] As String
          Get
            Return GetResourceString("WRN_NonCLSMemberInCLSInterface1")
          End Get
        End Property
        ''' <summary>Non CLS-compliant member is not allowed in a CLS-compliant interface</summary>
        Friend Shared ReadOnly Property [WRN_NonCLSMemberInCLSInterface1_Title] As String
          Get
            Return GetResourceString("WRN_NonCLSMemberInCLSInterface1_Title")
          End Get
        End Property
        ''' <summary>Non CLS-compliant 'MustOverride' member is not allowed in CLS-compliant type '{0}'.</summary>
        Friend Shared ReadOnly Property [WRN_NonCLSMustOverrideInCLSType1] As String
          Get
            Return GetResourceString("WRN_NonCLSMustOverrideInCLSType1")
          End Get
        End Property
        ''' <summary>Non CLS-compliant 'MustOverride' member is not allowed in CLS-compliant type</summary>
        Friend Shared ReadOnly Property [WRN_NonCLSMustOverrideInCLSType1_Title] As String
          Get
            Return GetResourceString("WRN_NonCLSMustOverrideInCLSType1_Title")
          End Get
        End Property
        ''' <summary>'{0}' is not CLS-compliant because it overloads '{1}' which differs from it only by array of array parameter types or by the rank of the array parameter types.</summary>
        Friend Shared ReadOnly Property [WRN_ArrayOverloadsNonCLS2] As String
          Get
            Return GetResourceString("WRN_ArrayOverloadsNonCLS2")
          End Get
        End Property
        ''' <summary>Method is not CLS-compliant because it overloads method which differs from it only by array of array parameter types or by the rank of the array parameter types</summary>
        Friend Shared ReadOnly Property [WRN_ArrayOverloadsNonCLS2_Title] As String
          Get
            Return GetResourceString("WRN_ArrayOverloadsNonCLS2_Title")
          End Get
        End Property
        ''' <summary>Root namespace '{0}' is not CLS-compliant.</summary>
        Friend Shared ReadOnly Property [WRN_RootNamespaceNotCLSCompliant1] As String
          Get
            Return GetResourceString("WRN_RootNamespaceNotCLSCompliant1")
          End Get
        End Property
        ''' <summary>Root namespace is not CLS-compliant</summary>
        Friend Shared ReadOnly Property [WRN_RootNamespaceNotCLSCompliant1_Title] As String
          Get
            Return GetResourceString("WRN_RootNamespaceNotCLSCompliant1_Title")
          End Get
        End Property
        ''' <summary>Name '{0}' in the root namespace '{1}' is not CLS-compliant.</summary>
        Friend Shared ReadOnly Property [WRN_RootNamespaceNotCLSCompliant2] As String
          Get
            Return GetResourceString("WRN_RootNamespaceNotCLSCompliant2")
          End Get
        End Property
        ''' <summary>Part of the root namespace is not CLS-compliant</summary>
        Friend Shared ReadOnly Property [WRN_RootNamespaceNotCLSCompliant2_Title] As String
          Get
            Return GetResourceString("WRN_RootNamespaceNotCLSCompliant2_Title")
          End Get
        End Property
        ''' <summary>Generic parameter constraint type '{0}' is not CLS-compliant.</summary>
        Friend Shared ReadOnly Property [WRN_GenericConstraintNotCLSCompliant1] As String
          Get
            Return GetResourceString("WRN_GenericConstraintNotCLSCompliant1")
          End Get
        End Property
        ''' <summary>Generic parameter constraint type is not CLS-compliant</summary>
        Friend Shared ReadOnly Property [WRN_GenericConstraintNotCLSCompliant1_Title] As String
          Get
            Return GetResourceString("WRN_GenericConstraintNotCLSCompliant1_Title")
          End Get
        End Property
        ''' <summary>Type '{0}' is not CLS-compliant.</summary>
        Friend Shared ReadOnly Property [WRN_TypeNotCLSCompliant1] As String
          Get
            Return GetResourceString("WRN_TypeNotCLSCompliant1")
          End Get
        End Property
        ''' <summary>Type is not CLS-compliant</summary>
        Friend Shared ReadOnly Property [WRN_TypeNotCLSCompliant1_Title] As String
          Get
            Return GetResourceString("WRN_TypeNotCLSCompliant1_Title")
          End Get
        End Property
        ''' <summary>Type of optional value for optional parameter '{0}' is not CLS-compliant.</summary>
        Friend Shared ReadOnly Property [WRN_OptionalValueNotCLSCompliant1] As String
          Get
            Return GetResourceString("WRN_OptionalValueNotCLSCompliant1")
          End Get
        End Property
        ''' <summary>Type of optional value for optional parameter is not CLS-compliant</summary>
        Friend Shared ReadOnly Property [WRN_OptionalValueNotCLSCompliant1_Title] As String
          Get
            Return GetResourceString("WRN_OptionalValueNotCLSCompliant1_Title")
          End Get
        End Property
        ''' <summary>System.CLSCompliantAttribute cannot be applied to property 'Get' or 'Set'.</summary>
        Friend Shared ReadOnly Property [WRN_CLSAttrInvalidOnGetSet] As String
          Get
            Return GetResourceString("WRN_CLSAttrInvalidOnGetSet")
          End Get
        End Property
        ''' <summary>System.CLSCompliantAttribute cannot be applied to property 'Get' or 'Set'</summary>
        Friend Shared ReadOnly Property [WRN_CLSAttrInvalidOnGetSet_Title] As String
          Get
            Return GetResourceString("WRN_CLSAttrInvalidOnGetSet_Title")
          End Get
        End Property
        ''' <summary>{0} '{1}' and partial {2} '{3}' conflict in {4} '{5}', but are being merged because one of them is declared partial.</summary>
        Friend Shared ReadOnly Property [WRN_TypeConflictButMerged6] As String
          Get
            Return GetResourceString("WRN_TypeConflictButMerged6")
          End Get
        End Property
        ''' <summary>Type and partial type conflict, but are being merged because one of them is declared partial</summary>
        Friend Shared ReadOnly Property [WRN_TypeConflictButMerged6_Title] As String
          Get
            Return GetResourceString("WRN_TypeConflictButMerged6_Title")
          End Get
        End Property
        ''' <summary>Type parameter '{0}' has the same name as a type parameter of an enclosing type. Enclosing type's type parameter will be shadowed.</summary>
        Friend Shared ReadOnly Property [WRN_ShadowingGenericParamWithParam1] As String
          Get
            Return GetResourceString("WRN_ShadowingGenericParamWithParam1")
          End Get
        End Property
        ''' <summary>Type parameter has the same name as a type parameter of an enclosing type</summary>
        Friend Shared ReadOnly Property [WRN_ShadowingGenericParamWithParam1_Title] As String
          Get
            Return GetResourceString("WRN_ShadowingGenericParamWithParam1_Title")
          End Get
        End Property
        ''' <summary>Could not find standard library '{0}'.</summary>
        Friend Shared ReadOnly Property [WRN_CannotFindStandardLibrary1] As String
          Get
            Return GetResourceString("WRN_CannotFindStandardLibrary1")
          End Get
        End Property
        ''' <summary>Could not find standard library</summary>
        Friend Shared ReadOnly Property [WRN_CannotFindStandardLibrary1_Title] As String
          Get
            Return GetResourceString("WRN_CannotFindStandardLibrary1_Title")
          End Get
        End Property
        ''' <summary>Delegate type '{0}' of event '{1}' is not CLS-compliant.</summary>
        Friend Shared ReadOnly Property [WRN_EventDelegateTypeNotCLSCompliant2] As String
          Get
            Return GetResourceString("WRN_EventDelegateTypeNotCLSCompliant2")
          End Get
        End Property
        ''' <summary>Delegate type of event is not CLS-compliant</summary>
        Friend Shared ReadOnly Property [WRN_EventDelegateTypeNotCLSCompliant2_Title] As String
          Get
            Return GetResourceString("WRN_EventDelegateTypeNotCLSCompliant2_Title")
          End Get
        End Property
        ''' <summary>System.Diagnostics.DebuggerHiddenAttribute does not affect 'Get' or 'Set' when applied to the Property definition.  Apply the attribute directly to the 'Get' and 'Set' procedures as appropriate.</summary>
        Friend Shared ReadOnly Property [WRN_DebuggerHiddenIgnoredOnProperties] As String
          Get
            Return GetResourceString("WRN_DebuggerHiddenIgnoredOnProperties")
          End Get
        End Property
        ''' <summary>System.Diagnostics.DebuggerHiddenAttribute does not affect 'Get' or 'Set' when applied to the Property definition</summary>
        Friend Shared ReadOnly Property [WRN_DebuggerHiddenIgnoredOnProperties_Title] As String
          Get
            Return GetResourceString("WRN_DebuggerHiddenIgnoredOnProperties_Title")
          End Get
        End Property
        ''' <summary>Range specified for 'Case' statement is not valid. Make sure that the lower bound is less than or equal to the upper bound.</summary>
        Friend Shared ReadOnly Property [WRN_SelectCaseInvalidRange] As String
          Get
            Return GetResourceString("WRN_SelectCaseInvalidRange")
          End Get
        End Property
        ''' <summary>Range specified for 'Case' statement is not valid</summary>
        Friend Shared ReadOnly Property [WRN_SelectCaseInvalidRange_Title] As String
          Get
            Return GetResourceString("WRN_SelectCaseInvalidRange_Title")
          End Get
        End Property
        ''' <summary>'{0}' method for event '{1}' cannot be marked CLS compliant because its containing type '{2}' is not CLS compliant.</summary>
        Friend Shared ReadOnly Property [WRN_CLSEventMethodInNonCLSType3] As String
          Get
            Return GetResourceString("WRN_CLSEventMethodInNonCLSType3")
          End Get
        End Property
        ''' <summary>AddHandler or RemoveHandler method for event cannot be marked CLS compliant because its containing type is not CLS compliant</summary>
        Friend Shared ReadOnly Property [WRN_CLSEventMethodInNonCLSType3_Title] As String
          Get
            Return GetResourceString("WRN_CLSEventMethodInNonCLSType3_Title")
          End Get
        End Property
        ''' <summary>'{0}' in designer-generated type '{1}' should call InitializeComponent method.</summary>
        Friend Shared ReadOnly Property [WRN_ExpectedInitComponentCall2] As String
          Get
            Return GetResourceString("WRN_ExpectedInitComponentCall2")
          End Get
        End Property
        ''' <summary>Constructor in designer-generated type should call InitializeComponent method</summary>
        Friend Shared ReadOnly Property [WRN_ExpectedInitComponentCall2_Title] As String
          Get
            Return GetResourceString("WRN_ExpectedInitComponentCall2_Title")
          End Get
        End Property
        ''' <summary>Casing of namespace name '{0}' does not match casing of namespace name '{1}' in '{2}'.</summary>
        Friend Shared ReadOnly Property [WRN_NamespaceCaseMismatch3] As String
          Get
            Return GetResourceString("WRN_NamespaceCaseMismatch3")
          End Get
        End Property
        ''' <summary>Casing of namespace name does not match</summary>
        Friend Shared ReadOnly Property [WRN_NamespaceCaseMismatch3_Title] As String
          Get
            Return GetResourceString("WRN_NamespaceCaseMismatch3_Title")
          End Get
        End Property
        ''' <summary>Namespace or type specified in the Imports '{0}' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases.</summary>
        Friend Shared ReadOnly Property [WRN_UndefinedOrEmptyNamespaceOrClass1] As String
          Get
            Return GetResourceString("WRN_UndefinedOrEmptyNamespaceOrClass1")
          End Get
        End Property
        ''' <summary>Namespace or type specified in Imports statement doesn't contain any public member or cannot be found</summary>
        Friend Shared ReadOnly Property [WRN_UndefinedOrEmptyNamespaceOrClass1_Title] As String
          Get
            Return GetResourceString("WRN_UndefinedOrEmptyNamespaceOrClass1_Title")
          End Get
        End Property
        ''' <summary>Namespace or type specified in the project-level Imports '{0}' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any ...</summary>
        Friend Shared ReadOnly Property [WRN_UndefinedOrEmptyProjectNamespaceOrClass1] As String
          Get
            Return GetResourceString("WRN_UndefinedOrEmptyProjectNamespaceOrClass1")
          End Get
        End Property
        ''' <summary>Namespace or type imported at project level doesn't contain any public member or cannot be found</summary>
        Friend Shared ReadOnly Property [WRN_UndefinedOrEmptyProjectNamespaceOrClass1_Title] As String
          Get
            Return GetResourceString("WRN_UndefinedOrEmptyProjectNamespaceOrClass1_Title")
          End Get
        End Property
        ''' <summary>A reference was created to embedded interop assembly '{0}' because of an indirect reference to that assembly from assembly '{1}'. Consider changing the 'Embed Interop Types' property on either assembly.</summary>
        Friend Shared ReadOnly Property [WRN_IndirectRefToLinkedAssembly2] As String
          Get
            Return GetResourceString("WRN_IndirectRefToLinkedAssembly2")
          End Get
        End Property
        ''' <summary>A reference was created to embedded interop assembly because of an indirect reference to that assembly</summary>
        Friend Shared ReadOnly Property [WRN_IndirectRefToLinkedAssembly2_Title] As String
          Get
            Return GetResourceString("WRN_IndirectRefToLinkedAssembly2_Title")
          End Get
        End Property
        ''' <summary>Class '{0}' should declare a 'Sub New' because the '{1}' in its base class '{2}' is marked obsolete.</summary>
        Friend Shared ReadOnly Property [WRN_NoNonObsoleteConstructorOnBase3] As String
          Get
            Return GetResourceString("WRN_NoNonObsoleteConstructorOnBase3")
          End Get
        End Property
        ''' <summary>Class should declare a 'Sub New' because the constructor in its base class is marked obsolete</summary>
        Friend Shared ReadOnly Property [WRN_NoNonObsoleteConstructorOnBase3_Title] As String
          Get
            Return GetResourceString("WRN_NoNonObsoleteConstructorOnBase3_Title")
          End Get
        End Property
        ''' <summary>Class '{0}' should declare a 'Sub New' because the '{1}' in its base class '{2}' is marked obsolete: '{3}'.</summary>
        Friend Shared ReadOnly Property [WRN_NoNonObsoleteConstructorOnBase4] As String
          Get
            Return GetResourceString("WRN_NoNonObsoleteConstructorOnBase4")
          End Get
        End Property
        ''' <summary>Class should declare a 'Sub New' because the constructor in its base class is marked obsolete</summary>
        Friend Shared ReadOnly Property [WRN_NoNonObsoleteConstructorOnBase4_Title] As String
          Get
            Return GetResourceString("WRN_NoNonObsoleteConstructorOnBase4_Title")
          End Get
        End Property
        ''' <summary>First statement of this 'Sub New' should be an explicit call to 'MyBase.New' or 'MyClass.New' because the '{0}' in the base class '{1}' of '{2}' is marked obsolete.</summary>
        Friend Shared ReadOnly Property [WRN_RequiredNonObsoleteNewCall3] As String
          Get
            Return GetResourceString("WRN_RequiredNonObsoleteNewCall3")
          End Get
        End Property
        ''' <summary>First statement of this 'Sub New' should be an explicit call to 'MyBase.New' or 'MyClass.New' because the constructor in the base class is marked obsolete</summary>
        Friend Shared ReadOnly Property [WRN_RequiredNonObsoleteNewCall3_Title] As String
          Get
            Return GetResourceString("WRN_RequiredNonObsoleteNewCall3_Title")
          End Get
        End Property
        ''' <summary>First statement of this 'Sub New' should be an explicit call to 'MyBase.New' or 'MyClass.New' because the '{0}' in the base class '{1}' of '{2}' is marked obsolete: '{3}'</summary>
        Friend Shared ReadOnly Property [WRN_RequiredNonObsoleteNewCall4] As String
          Get
            Return GetResourceString("WRN_RequiredNonObsoleteNewCall4")
          End Get
        End Property
        ''' <summary>First statement of this 'Sub New' should be an explicit call to 'MyBase.New' or 'MyClass.New' because the constructor in the base class is marked obsolete</summary>
        Friend Shared ReadOnly Property [WRN_RequiredNonObsoleteNewCall4_Title] As String
          Get
            Return GetResourceString("WRN_RequiredNonObsoleteNewCall4_Title")
          End Get
        End Property
        ''' <summary>Operator without an 'As' clause; type of Object assumed.</summary>
        Friend Shared ReadOnly Property [WRN_MissingAsClauseinOperator] As String
          Get
            Return GetResourceString("WRN_MissingAsClauseinOperator")
          End Get
        End Property
        ''' <summary>Operator without an 'As' clause</summary>
        Friend Shared ReadOnly Property [WRN_MissingAsClauseinOperator_Title] As String
          Get
            Return GetResourceString("WRN_MissingAsClauseinOperator_Title")
          End Get
        End Property
        ''' <summary>Type arguments inferred for method '{0}' result in the following warnings :{1}</summary>
        Friend Shared ReadOnly Property [WRN_ConstraintsFailedForInferredArgs2] As String
          Get
            Return GetResourceString("WRN_ConstraintsFailedForInferredArgs2")
          End Get
        End Property
        ''' <summary>Type arguments inferred for method result in warnings</summary>
        Friend Shared ReadOnly Property [WRN_ConstraintsFailedForInferredArgs2_Title] As String
          Get
            Return GetResourceString("WRN_ConstraintsFailedForInferredArgs2_Title")
          End Get
        End Property
        ''' <summary>Attribute 'Conditional' is only valid on 'Sub' declarations.</summary>
        Friend Shared ReadOnly Property [WRN_ConditionalNotValidOnFunction] As String
          Get
            Return GetResourceString("WRN_ConditionalNotValidOnFunction")
          End Get
        End Property
        ''' <summary>Attribute 'Conditional' is only valid on 'Sub' declarations</summary>
        Friend Shared ReadOnly Property [WRN_ConditionalNotValidOnFunction_Title] As String
          Get
            Return GetResourceString("WRN_ConditionalNotValidOnFunction_Title")
          End Get
        End Property
        ''' <summary>Statement recursively calls the containing '{0}' for event '{1}'.</summary>
        Friend Shared ReadOnly Property [WRN_RecursiveAddHandlerCall] As String
          Get
            Return GetResourceString("WRN_RecursiveAddHandlerCall")
          End Get
        End Property
        ''' <summary>Statement recursively calls the event's containing AddHandler</summary>
        Friend Shared ReadOnly Property [WRN_RecursiveAddHandlerCall_Title] As String
          Get
            Return GetResourceString("WRN_RecursiveAddHandlerCall_Title")
          End Get
        End Property
        ''' <summary>Implicit conversion from '{1}' to '{2}' in copying the value of 'ByRef' parameter '{0}' back to the matching argument.</summary>
        Friend Shared ReadOnly Property [WRN_ImplicitConversionCopyBack] As String
          Get
            Return GetResourceString("WRN_ImplicitConversionCopyBack")
          End Get
        End Property
        ''' <summary>Implicit conversion in copying the value of 'ByRef' parameter back to the matching argument</summary>
        Friend Shared ReadOnly Property [WRN_ImplicitConversionCopyBack_Title] As String
          Get
            Return GetResourceString("WRN_ImplicitConversionCopyBack_Title")
          End Get
        End Property
        ''' <summary>{0} '{1}' conflicts with other members of the same name across the inheritance hierarchy and so should be declared 'Shadows'.</summary>
        Friend Shared ReadOnly Property [WRN_MustShadowOnMultipleInheritance2] As String
          Get
            Return GetResourceString("WRN_MustShadowOnMultipleInheritance2")
          End Get
        End Property
        ''' <summary>Method conflicts with other members of the same name across the inheritance hierarchy and so should be declared 'Shadows'</summary>
        Friend Shared ReadOnly Property [WRN_MustShadowOnMultipleInheritance2_Title] As String
          Get
            Return GetResourceString("WRN_MustShadowOnMultipleInheritance2_Title")
          End Get
        End Property
        ''' <summary>Expression recursively calls the containing Operator '{0}'.</summary>
        Friend Shared ReadOnly Property [WRN_RecursiveOperatorCall] As String
          Get
            Return GetResourceString("WRN_RecursiveOperatorCall")
          End Get
        End Property
        ''' <summary>Expression recursively calls the containing Operator</summary>
        Friend Shared ReadOnly Property [WRN_RecursiveOperatorCall_Title] As String
          Get
            Return GetResourceString("WRN_RecursiveOperatorCall_Title")
          End Get
        End Property
        ''' <summary>Implicit conversion from '{0}' to '{1}'.</summary>
        Friend Shared ReadOnly Property [WRN_ImplicitConversion2] As String
          Get
            Return GetResourceString("WRN_ImplicitConversion2")
          End Get
        End Property
        ''' <summary>Implicit conversion</summary>
        Friend Shared ReadOnly Property [WRN_ImplicitConversion2_Title] As String
          Get
            Return GetResourceString("WRN_ImplicitConversion2_Title")
          End Get
        End Property
        ''' <summary>Local variable '{0}' is read-only and its type is a structure. Invoking its members or passing it ByRef does not change its content and might lead to unexpected results. Consider declaring this variable outside of the 'Using' block.</summary>
        Friend Shared ReadOnly Property [WRN_MutableStructureInUsing] As String
          Get
            Return GetResourceString("WRN_MutableStructureInUsing")
          End Get
        End Property
        ''' <summary>Local variable declared by Using statement is read-only and its type is a structure</summary>
        Friend Shared ReadOnly Property [WRN_MutableStructureInUsing_Title] As String
          Get
            Return GetResourceString("WRN_MutableStructureInUsing_Title")
          End Get
        End Property
        ''' <summary>Local variable '{0}' is read-only. When its type is a structure, invoking its members or passing it ByRef does not change its content and might lead to unexpected results. Consider declaring this variable outside of the 'Using' block.</summary>
        Friend Shared ReadOnly Property [WRN_MutableGenericStructureInUsing] As String
          Get
            Return GetResourceString("WRN_MutableGenericStructureInUsing")
          End Get
        End Property
        ''' <summary>Local variable declared by Using statement is read-only and its type may be a structure</summary>
        Friend Shared ReadOnly Property [WRN_MutableGenericStructureInUsing_Title] As String
          Get
            Return GetResourceString("WRN_MutableGenericStructureInUsing_Title")
          End Get
        End Property
        ''' <summary>{0}</summary>
        Friend Shared ReadOnly Property [WRN_ImplicitConversionSubst1] As String
          Get
            Return GetResourceString("WRN_ImplicitConversionSubst1")
          End Get
        End Property
        ''' <summary>Implicit conversion</summary>
        Friend Shared ReadOnly Property [WRN_ImplicitConversionSubst1_Title] As String
          Get
            Return GetResourceString("WRN_ImplicitConversionSubst1_Title")
          End Get
        End Property
        ''' <summary>Late bound resolution; runtime errors could occur.</summary>
        Friend Shared ReadOnly Property [WRN_LateBindingResolution] As String
          Get
            Return GetResourceString("WRN_LateBindingResolution")
          End Get
        End Property
        ''' <summary>Late bound resolution</summary>
        Friend Shared ReadOnly Property [WRN_LateBindingResolution_Title] As String
          Get
            Return GetResourceString("WRN_LateBindingResolution_Title")
          End Get
        End Property
        ''' <summary>Operands of type Object used for operator '{0}'; use the 'Is' operator to test object identity.</summary>
        Friend Shared ReadOnly Property [WRN_ObjectMath1] As String
          Get
            Return GetResourceString("WRN_ObjectMath1")
          End Get
        End Property
        ''' <summary>Operands of type Object used for operator</summary>
        Friend Shared ReadOnly Property [WRN_ObjectMath1_Title] As String
          Get
            Return GetResourceString("WRN_ObjectMath1_Title")
          End Get
        End Property
        ''' <summary>Operands of type Object used for operator '{0}'; runtime errors could occur.</summary>
        Friend Shared ReadOnly Property [WRN_ObjectMath2] As String
          Get
            Return GetResourceString("WRN_ObjectMath2")
          End Get
        End Property
        ''' <summary>Operands of type Object used for operator</summary>
        Friend Shared ReadOnly Property [WRN_ObjectMath2_Title] As String
          Get
            Return GetResourceString("WRN_ObjectMath2_Title")
          End Get
        End Property
        ''' <summary>{0}</summary>
        Friend Shared ReadOnly Property [WRN_ObjectAssumedVar1] As String
          Get
            Return GetResourceString("WRN_ObjectAssumedVar1")
          End Get
        End Property
        ''' <summary>Variable declaration without an 'As' clause</summary>
        Friend Shared ReadOnly Property [WRN_ObjectAssumedVar1_Title] As String
          Get
            Return GetResourceString("WRN_ObjectAssumedVar1_Title")
          End Get
        End Property
        ''' <summary>{0}</summary>
        Friend Shared ReadOnly Property [WRN_ObjectAssumed1] As String
          Get
            Return GetResourceString("WRN_ObjectAssumed1")
          End Get
        End Property
        ''' <summary>Function without an 'As' clause</summary>
        Friend Shared ReadOnly Property [WRN_ObjectAssumed1_Title] As String
          Get
            Return GetResourceString("WRN_ObjectAssumed1_Title")
          End Get
        End Property
        ''' <summary>{0}</summary>
        Friend Shared ReadOnly Property [WRN_ObjectAssumedProperty1] As String
          Get
            Return GetResourceString("WRN_ObjectAssumedProperty1")
          End Get
        End Property
        ''' <summary>Property without an 'As' clause</summary>
        Friend Shared ReadOnly Property [WRN_ObjectAssumedProperty1_Title] As String
          Get
            Return GetResourceString("WRN_ObjectAssumedProperty1_Title")
          End Get
        End Property
        ''' <summary>Variable declaration without an 'As' clause; type of Object assumed.</summary>
        Friend Shared ReadOnly Property [WRN_MissingAsClauseinVarDecl] As String
          Get
            Return GetResourceString("WRN_MissingAsClauseinVarDecl")
          End Get
        End Property
        ''' <summary>Variable declaration without an 'As' clause</summary>
        Friend Shared ReadOnly Property [WRN_MissingAsClauseinVarDecl_Title] As String
          Get
            Return GetResourceString("WRN_MissingAsClauseinVarDecl_Title")
          End Get
        End Property
        ''' <summary>Function without an 'As' clause; return type of Object assumed.</summary>
        Friend Shared ReadOnly Property [WRN_MissingAsClauseinFunction] As String
          Get
            Return GetResourceString("WRN_MissingAsClauseinFunction")
          End Get
        End Property
        ''' <summary>Function without an 'As' clause</summary>
        Friend Shared ReadOnly Property [WRN_MissingAsClauseinFunction_Title] As String
          Get
            Return GetResourceString("WRN_MissingAsClauseinFunction_Title")
          End Get
        End Property
        ''' <summary>Property without an 'As' clause; type of Object assumed.</summary>
        Friend Shared ReadOnly Property [WRN_MissingAsClauseinProperty] As String
          Get
            Return GetResourceString("WRN_MissingAsClauseinProperty")
          End Get
        End Property
        ''' <summary>Property without an 'As' clause</summary>
        Friend Shared ReadOnly Property [WRN_MissingAsClauseinProperty_Title] As String
          Get
            Return GetResourceString("WRN_MissingAsClauseinProperty_Title")
          End Get
        End Property
        ''' <summary>Unused local variable: '{0}'.</summary>
        Friend Shared ReadOnly Property [WRN_UnusedLocal] As String
          Get
            Return GetResourceString("WRN_UnusedLocal")
          End Get
        End Property
        ''' <summary>Unused local variable</summary>
        Friend Shared ReadOnly Property [WRN_UnusedLocal_Title] As String
          Get
            Return GetResourceString("WRN_UnusedLocal_Title")
          End Get
        End Property
        ''' <summary>Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated.</summary>
        Friend Shared ReadOnly Property [WRN_SharedMemberThroughInstance] As String
          Get
            Return GetResourceString("WRN_SharedMemberThroughInstance")
          End Get
        End Property
        ''' <summary>Access of shared member, constant member, enum member or nested type through an instance</summary>
        Friend Shared ReadOnly Property [WRN_SharedMemberThroughInstance_Title] As String
          Get
            Return GetResourceString("WRN_SharedMemberThroughInstance_Title")
          End Get
        End Property
        ''' <summary>Expression recursively calls the containing property '{0}'.</summary>
        Friend Shared ReadOnly Property [WRN_RecursivePropertyCall] As String
          Get
            Return GetResourceString("WRN_RecursivePropertyCall")
          End Get
        End Property
        ''' <summary>Expression recursively calls the containing property</summary>
        Friend Shared ReadOnly Property [WRN_RecursivePropertyCall_Title] As String
          Get
            Return GetResourceString("WRN_RecursivePropertyCall_Title")
          End Get
        End Property
        ''' <summary>'Catch' block never reached, because '{0}' inherits from '{1}'.</summary>
        Friend Shared ReadOnly Property [WRN_OverlappingCatch] As String
          Get
            Return GetResourceString("WRN_OverlappingCatch")
          End Get
        End Property
        ''' <summary>'Catch' block never reached; exception type's base type handled above in the same Try statement</summary>
        Friend Shared ReadOnly Property [WRN_OverlappingCatch_Title] As String
          Get
            Return GetResourceString("WRN_OverlappingCatch_Title")
          End Get
        End Property
        ''' <summary>Variable '{0}' is passed by reference before it has been assigned a value. A null reference exception could result at runtime.</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgUseNullRefByRef] As String
          Get
            Return GetResourceString("WRN_DefAsgUseNullRefByRef")
          End Get
        End Property
        ''' <summary>Variable is passed by reference before it has been assigned a value</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgUseNullRefByRef_Title] As String
          Get
            Return GetResourceString("WRN_DefAsgUseNullRefByRef_Title")
          End Get
        End Property
        ''' <summary>'Catch' block never reached; '{0}' handled above in the same Try statement.</summary>
        Friend Shared ReadOnly Property [WRN_DuplicateCatch] As String
          Get
            Return GetResourceString("WRN_DuplicateCatch")
          End Get
        End Property
        ''' <summary>'Catch' block never reached; exception type handled above in the same Try statement</summary>
        Friend Shared ReadOnly Property [WRN_DuplicateCatch_Title] As String
          Get
            Return GetResourceString("WRN_DuplicateCatch_Title")
          End Get
        End Property
        ''' <summary>Operands of type Object used for operator '{0}'; use the 'IsNot' operator to test object identity.</summary>
        Friend Shared ReadOnly Property [WRN_ObjectMath1Not] As String
          Get
            Return GetResourceString("WRN_ObjectMath1Not")
          End Get
        End Property
        ''' <summary>Operands of type Object used for operator &lt;&gt;</summary>
        Friend Shared ReadOnly Property [WRN_ObjectMath1Not_Title] As String
          Get
            Return GetResourceString("WRN_ObjectMath1Not_Title")
          End Get
        End Property
        ''' <summary>Bad checksum value, non hex digits or odd number of hex digits.</summary>
        Friend Shared ReadOnly Property [WRN_BadChecksumValExtChecksum] As String
          Get
            Return GetResourceString("WRN_BadChecksumValExtChecksum")
          End Get
        End Property
        ''' <summary>Bad checksum value, non hex digits or odd number of hex digits</summary>
        Friend Shared ReadOnly Property [WRN_BadChecksumValExtChecksum_Title] As String
          Get
            Return GetResourceString("WRN_BadChecksumValExtChecksum_Title")
          End Get
        End Property
        ''' <summary>File name already declared with a different GUID and checksum value.</summary>
        Friend Shared ReadOnly Property [WRN_MultipleDeclFileExtChecksum] As String
          Get
            Return GetResourceString("WRN_MultipleDeclFileExtChecksum")
          End Get
        End Property
        ''' <summary>File name already declared with a different GUID and checksum value</summary>
        Friend Shared ReadOnly Property [WRN_MultipleDeclFileExtChecksum_Title] As String
          Get
            Return GetResourceString("WRN_MultipleDeclFileExtChecksum_Title")
          End Get
        End Property
        ''' <summary>Bad GUID format.</summary>
        Friend Shared ReadOnly Property [WRN_BadGUIDFormatExtChecksum] As String
          Get
            Return GetResourceString("WRN_BadGUIDFormatExtChecksum")
          End Get
        End Property
        ''' <summary>Bad GUID format</summary>
        Friend Shared ReadOnly Property [WRN_BadGUIDFormatExtChecksum_Title] As String
          Get
            Return GetResourceString("WRN_BadGUIDFormatExtChecksum_Title")
          End Get
        End Property
        ''' <summary>Operands of type Object used in expressions for 'Select', 'Case' statements; runtime errors could occur.</summary>
        Friend Shared ReadOnly Property [WRN_ObjectMathSelectCase] As String
          Get
            Return GetResourceString("WRN_ObjectMathSelectCase")
          End Get
        End Property
        ''' <summary>Operands of type Object used in expressions for 'Select', 'Case' statements</summary>
        Friend Shared ReadOnly Property [WRN_ObjectMathSelectCase_Title] As String
          Get
            Return GetResourceString("WRN_ObjectMathSelectCase_Title")
          End Get
        End Property
        ''' <summary>This expression will always evaluate to Nothing (due to null propagation from the equals operator). To check if the value is null consider using 'Is Nothing'.</summary>
        Friend Shared ReadOnly Property [WRN_EqualToLiteralNothing] As String
          Get
            Return GetResourceString("WRN_EqualToLiteralNothing")
          End Get
        End Property
        ''' <summary>This expression will always evaluate to Nothing</summary>
        Friend Shared ReadOnly Property [WRN_EqualToLiteralNothing_Title] As String
          Get
            Return GetResourceString("WRN_EqualToLiteralNothing_Title")
          End Get
        End Property
        ''' <summary>This expression will always evaluate to Nothing (due to null propagation from the equals operator). To check if the value is not null consider using 'IsNot Nothing'.</summary>
        Friend Shared ReadOnly Property [WRN_NotEqualToLiteralNothing] As String
          Get
            Return GetResourceString("WRN_NotEqualToLiteralNothing")
          End Get
        End Property
        ''' <summary>This expression will always evaluate to Nothing</summary>
        Friend Shared ReadOnly Property [WRN_NotEqualToLiteralNothing_Title] As String
          Get
            Return GetResourceString("WRN_NotEqualToLiteralNothing_Title")
          End Get
        End Property
        ''' <summary>Unused local constant: '{0}'.</summary>
        Friend Shared ReadOnly Property [WRN_UnusedLocalConst] As String
          Get
            Return GetResourceString("WRN_UnusedLocalConst")
          End Get
        End Property
        ''' <summary>Unused local constant</summary>
        Friend Shared ReadOnly Property [WRN_UnusedLocalConst_Title] As String
          Get
            Return GetResourceString("WRN_UnusedLocalConst_Title")
          End Get
        End Property
        ''' <summary>'Microsoft.VisualBasic.ComClassAttribute' on class '{0}' implicitly declares {1} '{2}', which conflicts with a member of the same name in {3} '{4}'. Use 'Microsoft.VisualBasic.ComClassAttribute(InterfaceShadows:=True)' if you want to hide the name on the b ...</summary>
        Friend Shared ReadOnly Property [WRN_ComClassInterfaceShadows5] As String
          Get
            Return GetResourceString("WRN_ComClassInterfaceShadows5")
          End Get
        End Property
        ''' <summary>'Microsoft.VisualBasic.ComClassAttribute' on class implicitly declares member, which conflicts with a member of the same name</summary>
        Friend Shared ReadOnly Property [WRN_ComClassInterfaceShadows5_Title] As String
          Get
            Return GetResourceString("WRN_ComClassInterfaceShadows5_Title")
          End Get
        End Property
        ''' <summary>'{0}' cannot be exposed to COM as a property 'Let'. You will not be able to assign non-object values (such as numbers or strings) to this property from Visual Basic 6.0 using a 'Let' statement.</summary>
        Friend Shared ReadOnly Property [WRN_ComClassPropertySetObject1] As String
          Get
            Return GetResourceString("WRN_ComClassPropertySetObject1")
          End Get
        End Property
        ''' <summary>Property cannot be exposed to COM as a property 'Let'</summary>
        Friend Shared ReadOnly Property [WRN_ComClassPropertySetObject1_Title] As String
          Get
            Return GetResourceString("WRN_ComClassPropertySetObject1_Title")
          End Get
        End Property
        ''' <summary>Variable '{0}' is used before it has been assigned a value. A null reference exception could result at runtime.</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgUseNullRef] As String
          Get
            Return GetResourceString("WRN_DefAsgUseNullRef")
          End Get
        End Property
        ''' <summary>Variable is used before it has been assigned a value</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgUseNullRef_Title] As String
          Get
            Return GetResourceString("WRN_DefAsgUseNullRef_Title")
          End Get
        End Property
        ''' <summary>Function '{0}' doesn't return a value on all code paths. A null reference exception could occur at run time when the result is used.</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgNoRetValFuncRef1] As String
          Get
            Return GetResourceString("WRN_DefAsgNoRetValFuncRef1")
          End Get
        End Property
        ''' <summary>Function doesn't return a value on all code paths</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgNoRetValFuncRef1_Title] As String
          Get
            Return GetResourceString("WRN_DefAsgNoRetValFuncRef1_Title")
          End Get
        End Property
        ''' <summary>Operator '{0}' doesn't return a value on all code paths. A null reference exception could occur at run time when the result is used.</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgNoRetValOpRef1] As String
          Get
            Return GetResourceString("WRN_DefAsgNoRetValOpRef1")
          End Get
        End Property
        ''' <summary>Operator doesn't return a value on all code paths</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgNoRetValOpRef1_Title] As String
          Get
            Return GetResourceString("WRN_DefAsgNoRetValOpRef1_Title")
          End Get
        End Property
        ''' <summary>Property '{0}' doesn't return a value on all code paths. A null reference exception could occur at run time when the result is used.</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgNoRetValPropRef1] As String
          Get
            Return GetResourceString("WRN_DefAsgNoRetValPropRef1")
          End Get
        End Property
        ''' <summary>Property doesn't return a value on all code paths</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgNoRetValPropRef1_Title] As String
          Get
            Return GetResourceString("WRN_DefAsgNoRetValPropRef1_Title")
          End Get
        End Property
        ''' <summary>Variable '{0}' is passed by reference before it has been assigned a value. A null reference exception could result at runtime. Make sure the structure or all the reference members are initialized before use</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgUseNullRefByRefStr] As String
          Get
            Return GetResourceString("WRN_DefAsgUseNullRefByRefStr")
          End Get
        End Property
        ''' <summary>Variable is passed by reference before it has been assigned a value</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgUseNullRefByRefStr_Title] As String
          Get
            Return GetResourceString("WRN_DefAsgUseNullRefByRefStr_Title")
          End Get
        End Property
        ''' <summary>Variable '{0}' is used before it has been assigned a value. A null reference exception could result at runtime. Make sure the structure or all the reference members are initialized before use</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgUseNullRefStr] As String
          Get
            Return GetResourceString("WRN_DefAsgUseNullRefStr")
          End Get
        End Property
        ''' <summary>Variable is used before it has been assigned a value</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgUseNullRefStr_Title] As String
          Get
            Return GetResourceString("WRN_DefAsgUseNullRefStr_Title")
          End Get
        End Property
        ''' <summary>Static variable declared without an 'As' clause; type of Object assumed.</summary>
        Friend Shared ReadOnly Property [WRN_StaticLocalNoInference] As String
          Get
            Return GetResourceString("WRN_StaticLocalNoInference")
          End Get
        End Property
        ''' <summary>Static variable declared without an 'As' clause</summary>
        Friend Shared ReadOnly Property [WRN_StaticLocalNoInference_Title] As String
          Get
            Return GetResourceString("WRN_StaticLocalNoInference_Title")
          End Get
        End Property
        ''' <summary>Assembly reference '{0}' is invalid and cannot be resolved.</summary>
        Friend Shared ReadOnly Property [WRN_InvalidAssemblyName] As String
          Get
            Return GetResourceString("WRN_InvalidAssemblyName")
          End Get
        End Property
        ''' <summary>Assembly reference is invalid and cannot be resolved</summary>
        Friend Shared ReadOnly Property [WRN_InvalidAssemblyName_Title] As String
          Get
            Return GetResourceString("WRN_InvalidAssemblyName_Title")
          End Get
        End Property
        ''' <summary>XML comment block must immediately precede the language element to which it applies. XML comment will be ignored.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocBadXMLLine] As String
          Get
            Return GetResourceString("WRN_XMLDocBadXMLLine")
          End Get
        End Property
        ''' <summary>XML comment block must immediately precede the language element to which it applies</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocBadXMLLine_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocBadXMLLine_Title")
          End Get
        End Property
        ''' <summary>Only one XML comment block is allowed per language element.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocMoreThanOneCommentBlock] As String
          Get
            Return GetResourceString("WRN_XMLDocMoreThanOneCommentBlock")
          End Get
        End Property
        ''' <summary>Only one XML comment block is allowed per language element</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocMoreThanOneCommentBlock_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocMoreThanOneCommentBlock_Title")
          End Get
        End Property
        ''' <summary>XML comment must be the first statement on a line. XML comment will be ignored.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocNotFirstOnLine] As String
          Get
            Return GetResourceString("WRN_XMLDocNotFirstOnLine")
          End Get
        End Property
        ''' <summary>XML comment must be the first statement on a line</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocNotFirstOnLine_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocNotFirstOnLine_Title")
          End Get
        End Property
        ''' <summary>XML comment cannot appear within a method or a property. XML comment will be ignored.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocInsideMethod] As String
          Get
            Return GetResourceString("WRN_XMLDocInsideMethod")
          End Get
        End Property
        ''' <summary>XML comment cannot appear within a method or a property</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocInsideMethod_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocInsideMethod_Title")
          End Get
        End Property
        ''' <summary>XML documentation parse error: {0} XML comment will be ignored.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocParseError1] As String
          Get
            Return GetResourceString("WRN_XMLDocParseError1")
          End Get
        End Property
        ''' <summary>XML documentation parse error</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocParseError1_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocParseError1_Title")
          End Get
        End Property
        ''' <summary>XML comment tag '{0}' appears with identical attributes more than once in the same XML comment block.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocDuplicateXMLNode1] As String
          Get
            Return GetResourceString("WRN_XMLDocDuplicateXMLNode1")
          End Get
        End Property
        ''' <summary>XML comment tag appears with identical attributes more than once in the same XML comment block</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocDuplicateXMLNode1_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocDuplicateXMLNode1_Title")
          End Get
        End Property
        ''' <summary>XML comment tag '{0}' is not permitted on a '{1}' language element.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocIllegalTagOnElement2] As String
          Get
            Return GetResourceString("WRN_XMLDocIllegalTagOnElement2")
          End Get
        End Property
        ''' <summary>XML comment tag is not permitted on language element</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocIllegalTagOnElement2_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocIllegalTagOnElement2_Title")
          End Get
        End Property
        ''' <summary>XML comment parameter '{0}' does not match a parameter on the corresponding '{1}' statement.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocBadParamTag2] As String
          Get
            Return GetResourceString("WRN_XMLDocBadParamTag2")
          End Get
        End Property
        ''' <summary>XML comment parameter does not match a parameter on the corresponding declaration statement</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocBadParamTag2_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocBadParamTag2_Title")
          End Get
        End Property
        ''' <summary>XML comment parameter must have a 'name' attribute.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocParamTagWithoutName] As String
          Get
            Return GetResourceString("WRN_XMLDocParamTagWithoutName")
          End Get
        End Property
        ''' <summary>XML comment parameter must have a 'name' attribute</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocParamTagWithoutName_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocParamTagWithoutName_Title")
          End Get
        End Property
        ''' <summary>XML comment has a tag with a 'cref' attribute '{0}' that could not be resolved.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocCrefAttributeNotFound1] As String
          Get
            Return GetResourceString("WRN_XMLDocCrefAttributeNotFound1")
          End Get
        End Property
        ''' <summary>XML comment has a tag with a 'cref' attribute that could not be resolved</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocCrefAttributeNotFound1_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocCrefAttributeNotFound1_Title")
          End Get
        End Property
        ''' <summary>XML comment tag 'include' must have a '{0}' attribute. XML comment will be ignored.</summary>
        Friend Shared ReadOnly Property [WRN_XMLMissingFileOrPathAttribute1] As String
          Get
            Return GetResourceString("WRN_XMLMissingFileOrPathAttribute1")
          End Get
        End Property
        ''' <summary>XML comment tag 'include' must have 'file' and 'path' attributes</summary>
        Friend Shared ReadOnly Property [WRN_XMLMissingFileOrPathAttribute1_Title] As String
          Get
            Return GetResourceString("WRN_XMLMissingFileOrPathAttribute1_Title")
          End Get
        End Property
        ''' <summary>Unable to create XML documentation file '{0}': {1}</summary>
        Friend Shared ReadOnly Property [WRN_XMLCannotWriteToXMLDocFile2] As String
          Get
            Return GetResourceString("WRN_XMLCannotWriteToXMLDocFile2")
          End Get
        End Property
        ''' <summary>Unable to create XML documentation file</summary>
        Friend Shared ReadOnly Property [WRN_XMLCannotWriteToXMLDocFile2_Title] As String
          Get
            Return GetResourceString("WRN_XMLCannotWriteToXMLDocFile2_Title")
          End Get
        End Property
        ''' <summary>XML documentation comments must precede member or type declarations.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocWithoutLanguageElement] As String
          Get
            Return GetResourceString("WRN_XMLDocWithoutLanguageElement")
          End Get
        End Property
        ''' <summary>XML documentation comments must precede member or type declarations</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocWithoutLanguageElement_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocWithoutLanguageElement_Title")
          End Get
        End Property
        ''' <summary>XML comment tag 'returns' is not permitted on a 'WriteOnly' Property.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocReturnsOnWriteOnlyProperty] As String
          Get
            Return GetResourceString("WRN_XMLDocReturnsOnWriteOnlyProperty")
          End Get
        End Property
        ''' <summary>XML comment tag 'returns' is not permitted on a 'WriteOnly' Property</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocReturnsOnWriteOnlyProperty_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocReturnsOnWriteOnlyProperty_Title")
          End Get
        End Property
        ''' <summary>XML comment cannot be applied more than once on a partial {0}. XML comments for this {0} will be ignored.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocOnAPartialType] As String
          Get
            Return GetResourceString("WRN_XMLDocOnAPartialType")
          End Get
        End Property
        ''' <summary>XML comment cannot be applied more than once on a partial type</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocOnAPartialType_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocOnAPartialType_Title")
          End Get
        End Property
        ''' <summary>XML comment tag 'returns' is not permitted on a 'declare sub' language element.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocReturnsOnADeclareSub] As String
          Get
            Return GetResourceString("WRN_XMLDocReturnsOnADeclareSub")
          End Get
        End Property
        ''' <summary>XML comment tag 'returns' is not permitted on a 'declare sub' language element</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocReturnsOnADeclareSub_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocReturnsOnADeclareSub_Title")
          End Get
        End Property
        ''' <summary>XML documentation parse error: Start tag '{0}' doesn't have a matching end tag. XML comment will be ignored.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocStartTagWithNoEndTag] As String
          Get
            Return GetResourceString("WRN_XMLDocStartTagWithNoEndTag")
          End Get
        End Property
        ''' <summary>XML documentation parse error: Start tag doesn't have a matching end tag</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocStartTagWithNoEndTag_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocStartTagWithNoEndTag_Title")
          End Get
        End Property
        ''' <summary>XML comment type parameter '{0}' does not match a type parameter on the corresponding '{1}' statement.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocBadGenericParamTag2] As String
          Get
            Return GetResourceString("WRN_XMLDocBadGenericParamTag2")
          End Get
        End Property
        ''' <summary>XML comment type parameter does not match a type parameter on the corresponding declaration statement</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocBadGenericParamTag2_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocBadGenericParamTag2_Title")
          End Get
        End Property
        ''' <summary>XML comment type parameter must have a 'name' attribute.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocGenericParamTagWithoutName] As String
          Get
            Return GetResourceString("WRN_XMLDocGenericParamTagWithoutName")
          End Get
        End Property
        ''' <summary>XML comment type parameter must have a 'name' attribute</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocGenericParamTagWithoutName_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocGenericParamTagWithoutName_Title")
          End Get
        End Property
        ''' <summary>XML comment exception must have a 'cref' attribute.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocExceptionTagWithoutCRef] As String
          Get
            Return GetResourceString("WRN_XMLDocExceptionTagWithoutCRef")
          End Get
        End Property
        ''' <summary>XML comment exception must have a 'cref' attribute</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocExceptionTagWithoutCRef_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocExceptionTagWithoutCRef_Title")
          End Get
        End Property
        ''' <summary>Unable to include XML fragment '{0}' of file '{1}'.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocInvalidXMLFragment] As String
          Get
            Return GetResourceString("WRN_XMLDocInvalidXMLFragment")
          End Get
        End Property
        ''' <summary>Unable to include XML fragment</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocInvalidXMLFragment_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocInvalidXMLFragment_Title")
          End Get
        End Property
        ''' <summary>Unable to include XML fragment '{1}' of file '{0}'. {2}</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocBadFormedXML] As String
          Get
            Return GetResourceString("WRN_XMLDocBadFormedXML")
          End Get
        End Property
        ''' <summary>Unable to include XML fragment</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocBadFormedXML_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocBadFormedXML_Title")
          End Get
        End Property
        ''' <summary>Runtime errors might occur when converting '{0}' to '{1}'.</summary>
        Friend Shared ReadOnly Property [WRN_InterfaceConversion2] As String
          Get
            Return GetResourceString("WRN_InterfaceConversion2")
          End Get
        End Property
        ''' <summary>Runtime errors might occur when converting to or from interface type</summary>
        Friend Shared ReadOnly Property [WRN_InterfaceConversion2_Title] As String
          Get
            Return GetResourceString("WRN_InterfaceConversion2_Title")
          End Get
        End Property
        ''' <summary>Using the iteration variable in a lambda expression may have unexpected results.  Instead, create a local variable within the loop and assign it the value of the iteration variable.</summary>
        Friend Shared ReadOnly Property [WRN_LiftControlVariableLambda] As String
          Get
            Return GetResourceString("WRN_LiftControlVariableLambda")
          End Get
        End Property
        ''' <summary>Using the iteration variable in a lambda expression may have unexpected results</summary>
        Friend Shared ReadOnly Property [WRN_LiftControlVariableLambda_Title] As String
          Get
            Return GetResourceString("WRN_LiftControlVariableLambda_Title")
          End Get
        End Property
        ''' <summary>Lambda expression will not be removed from this event handler. Assign the lambda expression to a variable and use the variable to add and remove the event.</summary>
        Friend Shared ReadOnly Property [WRN_LambdaPassedToRemoveHandler] As String
          Get
            Return GetResourceString("WRN_LambdaPassedToRemoveHandler")
          End Get
        End Property
        ''' <summary>Lambda expression will not be removed from this event handler</summary>
        Friend Shared ReadOnly Property [WRN_LambdaPassedToRemoveHandler_Title] As String
          Get
            Return GetResourceString("WRN_LambdaPassedToRemoveHandler_Title")
          End Get
        End Property
        ''' <summary>Using the iteration variable in a query expression may have unexpected results.  Instead, create a local variable within the loop and assign it the value of the iteration variable.</summary>
        Friend Shared ReadOnly Property [WRN_LiftControlVariableQuery] As String
          Get
            Return GetResourceString("WRN_LiftControlVariableQuery")
          End Get
        End Property
        ''' <summary>Using the iteration variable in a query expression may have unexpected results</summary>
        Friend Shared ReadOnly Property [WRN_LiftControlVariableQuery_Title] As String
          Get
            Return GetResourceString("WRN_LiftControlVariableQuery_Title")
          End Get
        End Property
        ''' <summary>The 'AddressOf' expression has no effect in this context because the method argument to 'AddressOf' requires a relaxed conversion to the delegate type of the event. Assign the 'AddressOf' expression to a variable, and use the variable to add or remove the  ...</summary>
        Friend Shared ReadOnly Property [WRN_RelDelegatePassedToRemoveHandler] As String
          Get
            Return GetResourceString("WRN_RelDelegatePassedToRemoveHandler")
          End Get
        End Property
        ''' <summary>The 'AddressOf' expression has no effect in this context because the method argument to 'AddressOf' requires a relaxed conversion to the delegate type of the event</summary>
        Friend Shared ReadOnly Property [WRN_RelDelegatePassedToRemoveHandler_Title] As String
          Get
            Return GetResourceString("WRN_RelDelegatePassedToRemoveHandler_Title")
          End Get
        End Property
        ''' <summary>Multiline lambda expression is missing 'End Function'.</summary>
        Friend Shared ReadOnly Property [ERR_MultilineLambdaMissingFunction] As String
          Get
            Return GetResourceString("ERR_MultilineLambdaMissingFunction")
          End Get
        End Property
        ''' <summary>Multiline lambda expression is missing 'End Sub'.</summary>
        Friend Shared ReadOnly Property [ERR_MultilineLambdaMissingSub] As String
          Get
            Return GetResourceString("ERR_MultilineLambdaMissingSub")
          End Get
        End Property
        ''' <summary>Attributes cannot be applied to return types of lambda expressions.</summary>
        Friend Shared ReadOnly Property [ERR_AttributeOnLambdaReturnType] As String
          Get
            Return GetResourceString("ERR_AttributeOnLambdaReturnType")
          End Get
        End Property
        ''' <summary>Statement is not valid inside a single-line statement lambda.</summary>
        Friend Shared ReadOnly Property [ERR_SubDisallowsStatement] As String
          Get
            Return GetResourceString("ERR_SubDisallowsStatement")
          End Get
        End Property
        ''' <summary>This single-line statement lambda must be enclosed in parentheses. For example: (Sub() &lt;statement&gt;)!key</summary>
        Friend Shared ReadOnly Property [ERR_SubRequiresParenthesesBang] As String
          Get
            Return GetResourceString("ERR_SubRequiresParenthesesBang")
          End Get
        End Property
        ''' <summary>This single-line statement lambda must be enclosed in parentheses. For example: (Sub() &lt;statement&gt;).Invoke()</summary>
        Friend Shared ReadOnly Property [ERR_SubRequiresParenthesesDot] As String
          Get
            Return GetResourceString("ERR_SubRequiresParenthesesDot")
          End Get
        End Property
        ''' <summary>This single-line statement lambda must be enclosed in parentheses. For example: Call (Sub() &lt;statement&gt;) ()</summary>
        Friend Shared ReadOnly Property [ERR_SubRequiresParenthesesLParen] As String
          Get
            Return GetResourceString("ERR_SubRequiresParenthesesLParen")
          End Get
        End Property
        ''' <summary>Single-line statement lambdas must include exactly one statement.</summary>
        Friend Shared ReadOnly Property [ERR_SubRequiresSingleStatement] As String
          Get
            Return GetResourceString("ERR_SubRequiresSingleStatement")
          End Get
        End Property
        ''' <summary>Static local variables cannot be declared inside lambda expressions.</summary>
        Friend Shared ReadOnly Property [ERR_StaticInLambda] As String
          Get
            Return GetResourceString("ERR_StaticInLambda")
          End Get
        End Property
        ''' <summary>Expanded Properties cannot be initialized.</summary>
        Friend Shared ReadOnly Property [ERR_InitializedExpandedProperty] As String
          Get
            Return GetResourceString("ERR_InitializedExpandedProperty")
          End Get
        End Property
        ''' <summary>Auto-implemented properties cannot have parameters.</summary>
        Friend Shared ReadOnly Property [ERR_AutoPropertyCantHaveParams] As String
          Get
            Return GetResourceString("ERR_AutoPropertyCantHaveParams")
          End Get
        End Property
        ''' <summary>Auto-implemented properties cannot be WriteOnly.</summary>
        Friend Shared ReadOnly Property [ERR_AutoPropertyCantBeWriteOnly] As String
          Get
            Return GetResourceString("ERR_AutoPropertyCantBeWriteOnly")
          End Get
        End Property
        ''' <summary>'If' operator requires either two or three operands.</summary>
        Friend Shared ReadOnly Property [ERR_IllegalOperandInIIFCount] As String
          Get
            Return GetResourceString("ERR_IllegalOperandInIIFCount")
          End Get
        End Property
        ''' <summary>Cannot initialize the type '{0}' with a collection initializer because it is not a collection type.</summary>
        Friend Shared ReadOnly Property [ERR_NotACollection1] As String
          Get
            Return GetResourceString("ERR_NotACollection1")
          End Get
        End Property
        ''' <summary>Cannot initialize the type '{0}' with a collection initializer because it does not have an accessible 'Add' method.</summary>
        Friend Shared ReadOnly Property [ERR_NoAddMethod1] As String
          Get
            Return GetResourceString("ERR_NoAddMethod1")
          End Get
        End Property
        ''' <summary>An Object Initializer and a Collection Initializer cannot be combined in the same initialization.</summary>
        Friend Shared ReadOnly Property [ERR_CantCombineInitializers] As String
          Get
            Return GetResourceString("ERR_CantCombineInitializers")
          End Get
        End Property
        ''' <summary>An aggregate collection initializer entry must contain at least one element.</summary>
        Friend Shared ReadOnly Property [ERR_EmptyAggregateInitializer] As String
          Get
            Return GetResourceString("ERR_EmptyAggregateInitializer")
          End Get
        End Property
        ''' <summary>XML end element must be preceded by a matching start element.</summary>
        Friend Shared ReadOnly Property [ERR_XmlEndElementNoMatchingStart] As String
          Get
            Return GetResourceString("ERR_XmlEndElementNoMatchingStart")
          End Get
        End Property
        ''' <summary>'On Error' and 'Resume' cannot appear inside a lambda expression.</summary>
        Friend Shared ReadOnly Property [ERR_MultilineLambdasCannotContainOnError] As String
          Get
            Return GetResourceString("ERR_MultilineLambdasCannotContainOnError")
          End Get
        End Property
        ''' <summary>Keywords 'Out' and 'In' can only be used in interface and delegate declarations.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceDisallowedHere] As String
          Get
            Return GetResourceString("ERR_VarianceDisallowedHere")
          End Get
        End Property
        ''' <summary>The literal string ']]&gt;' is not allowed in element content.</summary>
        Friend Shared ReadOnly Property [ERR_XmlEndCDataNotAllowedInContent] As String
          Get
            Return GetResourceString("ERR_XmlEndCDataNotAllowedInContent")
          End Get
        End Property
        ''' <summary>Inappropriate use of '{0}' keyword in a module.</summary>
        Friend Shared ReadOnly Property [ERR_OverloadsModifierInModule] As String
          Get
            Return GetResourceString("ERR_OverloadsModifierInModule")
          End Get
        End Property
        ''' <summary>Type or namespace '{0}' is not defined.</summary>
        Friend Shared ReadOnly Property [ERR_UndefinedTypeOrNamespace1] As String
          Get
            Return GetResourceString("ERR_UndefinedTypeOrNamespace1")
          End Get
        End Property
        ''' <summary>Using DirectCast operator to cast a floating-point value to the same type is not supported.</summary>
        Friend Shared ReadOnly Property [ERR_IdentityDirectCastForFloat] As String
          Get
            Return GetResourceString("ERR_IdentityDirectCastForFloat")
          End Get
        End Property
        ''' <summary>Using DirectCast operator to cast a value-type to the same type is obsolete.</summary>
        Friend Shared ReadOnly Property [WRN_ObsoleteIdentityDirectCastForValueType] As String
          Get
            Return GetResourceString("WRN_ObsoleteIdentityDirectCastForValueType")
          End Get
        End Property
        ''' <summary>Using DirectCast operator to cast a value-type to the same type is obsolete</summary>
        Friend Shared ReadOnly Property [WRN_ObsoleteIdentityDirectCastForValueType_Title] As String
          Get
            Return GetResourceString("WRN_ObsoleteIdentityDirectCastForValueType_Title")
          End Get
        End Property
        ''' <summary>Unreachable code detected.</summary>
        Friend Shared ReadOnly Property [WRN_UnreachableCode] As String
          Get
            Return GetResourceString("WRN_UnreachableCode")
          End Get
        End Property
        ''' <summary>Unreachable code detected</summary>
        Friend Shared ReadOnly Property [WRN_UnreachableCode_Title] As String
          Get
            Return GetResourceString("WRN_UnreachableCode_Title")
          End Get
        End Property
        ''' <summary>Function '{0}' doesn't return a value on all code paths. Are you missing a 'Return' statement?</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgNoRetValFuncVal1] As String
          Get
            Return GetResourceString("WRN_DefAsgNoRetValFuncVal1")
          End Get
        End Property
        ''' <summary>Function doesn't return a value on all code paths</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgNoRetValFuncVal1_Title] As String
          Get
            Return GetResourceString("WRN_DefAsgNoRetValFuncVal1_Title")
          End Get
        End Property
        ''' <summary>Operator '{0}' doesn't return a value on all code paths. Are you missing a 'Return' statement?</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgNoRetValOpVal1] As String
          Get
            Return GetResourceString("WRN_DefAsgNoRetValOpVal1")
          End Get
        End Property
        ''' <summary>Operator doesn't return a value on all code paths</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgNoRetValOpVal1_Title] As String
          Get
            Return GetResourceString("WRN_DefAsgNoRetValOpVal1_Title")
          End Get
        End Property
        ''' <summary>Property '{0}' doesn't return a value on all code paths. Are you missing a 'Return' statement?</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgNoRetValPropVal1] As String
          Get
            Return GetResourceString("WRN_DefAsgNoRetValPropVal1")
          End Get
        End Property
        ''' <summary>Property doesn't return a value on all code paths</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgNoRetValPropVal1_Title] As String
          Get
            Return GetResourceString("WRN_DefAsgNoRetValPropVal1_Title")
          End Get
        End Property
        ''' <summary>Global namespace may not be nested in another namespace.</summary>
        Friend Shared ReadOnly Property [ERR_NestedGlobalNamespace] As String
          Get
            Return GetResourceString("ERR_NestedGlobalNamespace")
          End Get
        End Property
        ''' <summary>'{0}' cannot expose type '{1}' in {2} '{3}' through {4} '{5}'.</summary>
        Friend Shared ReadOnly Property [ERR_AccessMismatch6] As String
          Get
            Return GetResourceString("ERR_AccessMismatch6")
          End Get
        End Property
        ''' <summary>'{0}' cannot be referenced because it is not a valid assembly.</summary>
        Friend Shared ReadOnly Property [ERR_BadMetaDataReference1] As String
          Get
            Return GetResourceString("ERR_BadMetaDataReference1")
          End Get
        End Property
        ''' <summary>'{0}' cannot be implemented by a {1} property.</summary>
        Friend Shared ReadOnly Property [ERR_PropertyDoesntImplementAllAccessors] As String
          Get
            Return GetResourceString("ERR_PropertyDoesntImplementAllAccessors")
          End Get
        End Property
        ''' <summary>{0}: {1}</summary>
        Friend Shared ReadOnly Property [ERR_UnimplementedMustOverride] As String
          Get
            Return GetResourceString("ERR_UnimplementedMustOverride")
          End Get
        End Property
        ''' <summary>Cannot infer a common type because more than one type is possible.</summary>
        Friend Shared ReadOnly Property [ERR_IfTooManyTypesObjectDisallowed] As String
          Get
            Return GetResourceString("ERR_IfTooManyTypesObjectDisallowed")
          End Get
        End Property
        ''' <summary>Cannot infer a common type because more than one type is possible; 'Object' assumed.</summary>
        Friend Shared ReadOnly Property [WRN_IfTooManyTypesObjectAssumed] As String
          Get
            Return GetResourceString("WRN_IfTooManyTypesObjectAssumed")
          End Get
        End Property
        ''' <summary>Cannot infer a common type because more than one type is possible</summary>
        Friend Shared ReadOnly Property [WRN_IfTooManyTypesObjectAssumed_Title] As String
          Get
            Return GetResourceString("WRN_IfTooManyTypesObjectAssumed_Title")
          End Get
        End Property
        ''' <summary>Cannot infer a common type, and Option Strict On does not allow 'Object' to be assumed.</summary>
        Friend Shared ReadOnly Property [ERR_IfNoTypeObjectDisallowed] As String
          Get
            Return GetResourceString("ERR_IfNoTypeObjectDisallowed")
          End Get
        End Property
        ''' <summary>Cannot infer a common type; 'Object' assumed.</summary>
        Friend Shared ReadOnly Property [WRN_IfNoTypeObjectAssumed] As String
          Get
            Return GetResourceString("WRN_IfNoTypeObjectAssumed")
          End Get
        End Property
        ''' <summary>Cannot infer a common type</summary>
        Friend Shared ReadOnly Property [WRN_IfNoTypeObjectAssumed_Title] As String
          Get
            Return GetResourceString("WRN_IfNoTypeObjectAssumed_Title")
          End Get
        End Property
        ''' <summary>Cannot infer a common type.</summary>
        Friend Shared ReadOnly Property [ERR_IfNoType] As String
          Get
            Return GetResourceString("ERR_IfNoType")
          End Get
        End Property
        ''' <summary>Error extracting public key from file '{0}': {1}</summary>
        Friend Shared ReadOnly Property [ERR_PublicKeyFileFailure] As String
          Get
            Return GetResourceString("ERR_PublicKeyFileFailure")
          End Get
        End Property
        ''' <summary>Error extracting public key from container '{0}': {1}</summary>
        Friend Shared ReadOnly Property [ERR_PublicKeyContainerFailure] As String
          Get
            Return GetResourceString("ERR_PublicKeyContainerFailure")
          End Get
        End Property
        ''' <summary>Friend access was granted by '{0}', but the public key of the output assembly does not match that specified by the attribute in the granting assembly.</summary>
        Friend Shared ReadOnly Property [ERR_FriendRefNotEqualToThis] As String
          Get
            Return GetResourceString("ERR_FriendRefNotEqualToThis")
          End Get
        End Property
        ''' <summary>Friend access was granted by '{0}', but the strong name signing state of the output assembly does not match that of the granting assembly.</summary>
        Friend Shared ReadOnly Property [ERR_FriendRefSigningMismatch] As String
          Get
            Return GetResourceString("ERR_FriendRefSigningMismatch")
          End Get
        End Property
        ''' <summary>Public sign was specified and requires a public key, but no public key was specified</summary>
        Friend Shared ReadOnly Property [ERR_PublicSignNoKey] As String
          Get
            Return GetResourceString("ERR_PublicSignNoKey")
          End Get
        End Property
        ''' <summary>Public signing is not supported for netmodules.</summary>
        Friend Shared ReadOnly Property [ERR_PublicSignNetModule] As String
          Get
            Return GetResourceString("ERR_PublicSignNetModule")
          End Get
        End Property
        ''' <summary>Attribute '{0}' is ignored when public signing is specified.</summary>
        Friend Shared ReadOnly Property [WRN_AttributeIgnoredWhenPublicSigning] As String
          Get
            Return GetResourceString("WRN_AttributeIgnoredWhenPublicSigning")
          End Get
        End Property
        ''' <summary>Attribute is ignored when public signing is specified.</summary>
        Friend Shared ReadOnly Property [WRN_AttributeIgnoredWhenPublicSigning_Title] As String
          Get
            Return GetResourceString("WRN_AttributeIgnoredWhenPublicSigning_Title")
          End Get
        End Property
        ''' <summary>Delay signing was specified and requires a public key, but no public key was specified.</summary>
        Friend Shared ReadOnly Property [WRN_DelaySignButNoKey] As String
          Get
            Return GetResourceString("WRN_DelaySignButNoKey")
          End Get
        End Property
        ''' <summary>Delay signing was specified and requires a public key, but no public key was specified</summary>
        Friend Shared ReadOnly Property [WRN_DelaySignButNoKey_Title] As String
          Get
            Return GetResourceString("WRN_DelaySignButNoKey_Title")
          End Get
        End Property
        ''' <summary>Key file '{0}' is missing the private key needed for signing.</summary>
        Friend Shared ReadOnly Property [ERR_SignButNoPrivateKey] As String
          Get
            Return GetResourceString("ERR_SignButNoPrivateKey")
          End Get
        End Property
        ''' <summary>Error signing assembly '{0}': {1}</summary>
        Friend Shared ReadOnly Property [ERR_FailureSigningAssembly] As String
          Get
            Return GetResourceString("ERR_FailureSigningAssembly")
          End Get
        End Property
        ''' <summary>The specified version string does not conform to the required format - major[.minor[.build|*[.revision|*]]]</summary>
        Friend Shared ReadOnly Property [ERR_InvalidVersionFormat] As String
          Get
            Return GetResourceString("ERR_InvalidVersionFormat")
          End Get
        End Property
        ''' <summary>The specified version string does not conform to the recommended format - major.minor.build.revision</summary>
        Friend Shared ReadOnly Property [WRN_InvalidVersionFormat] As String
          Get
            Return GetResourceString("WRN_InvalidVersionFormat")
          End Get
        End Property
        ''' <summary>The specified version string does not conform to the recommended format</summary>
        Friend Shared ReadOnly Property [WRN_InvalidVersionFormat_Title] As String
          Get
            Return GetResourceString("WRN_InvalidVersionFormat_Title")
          End Get
        End Property
        ''' <summary>The specified version string does not conform to the recommended format - major.minor.build.revision (without wildcards)</summary>
        Friend Shared ReadOnly Property [ERR_InvalidVersionFormat2] As String
          Get
            Return GetResourceString("ERR_InvalidVersionFormat2")
          End Get
        End Property
        ''' <summary>Executables cannot be satellite assemblies; culture should always be empty</summary>
        Friend Shared ReadOnly Property [ERR_InvalidAssemblyCultureForExe] As String
          Get
            Return GetResourceString("ERR_InvalidAssemblyCultureForExe")
          End Get
        End Property
        ''' <summary>The entry point of the program is global script code; ignoring '{0}' entry point.</summary>
        Friend Shared ReadOnly Property [WRN_MainIgnored] As String
          Get
            Return GetResourceString("WRN_MainIgnored")
          End Get
        End Property
        ''' <summary>The entry point of the program is global script code; ignoring entry point</summary>
        Friend Shared ReadOnly Property [WRN_MainIgnored_Title] As String
          Get
            Return GetResourceString("WRN_MainIgnored_Title")
          End Get
        End Property
        ''' <summary>The xmlns attribute has special meaning and should not be written with a prefix.</summary>
        Friend Shared ReadOnly Property [WRN_EmptyPrefixAndXmlnsLocalName] As String
          Get
            Return GetResourceString("WRN_EmptyPrefixAndXmlnsLocalName")
          End Get
        End Property
        ''' <summary>The xmlns attribute has special meaning and should not be written with a prefix</summary>
        Friend Shared ReadOnly Property [WRN_EmptyPrefixAndXmlnsLocalName_Title] As String
          Get
            Return GetResourceString("WRN_EmptyPrefixAndXmlnsLocalName_Title")
          End Get
        End Property
        ''' <summary>It is not recommended to have attributes named xmlns. Did you mean to write 'xmlns:{0}' to define a prefix named '{0}'?</summary>
        Friend Shared ReadOnly Property [WRN_PrefixAndXmlnsLocalName] As String
          Get
            Return GetResourceString("WRN_PrefixAndXmlnsLocalName")
          End Get
        End Property
        ''' <summary>It is not recommended to have attributes named xmlns</summary>
        Friend Shared ReadOnly Property [WRN_PrefixAndXmlnsLocalName_Title] As String
          Get
            Return GetResourceString("WRN_PrefixAndXmlnsLocalName_Title")
          End Get
        End Property
        ''' <summary>Expected a single script (.vbx file)</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedSingleScript] As String
          Get
            Return GetResourceString("ERR_ExpectedSingleScript")
          End Get
        End Property
        ''' <summary>The assembly name '{0}' is reserved and cannot be used as a reference in an interactive session</summary>
        Friend Shared ReadOnly Property [ERR_ReservedAssemblyName] As String
          Get
            Return GetResourceString("ERR_ReservedAssemblyName")
          End Get
        End Property
        ''' <summary>#R is only allowed in scripts</summary>
        Friend Shared ReadOnly Property [ERR_ReferenceDirectiveOnlyAllowedInScripts] As String
          Get
            Return GetResourceString("ERR_ReferenceDirectiveOnlyAllowedInScripts")
          End Get
        End Property
        ''' <summary>You cannot declare Namespace in script code</summary>
        Friend Shared ReadOnly Property [ERR_NamespaceNotAllowedInScript] As String
          Get
            Return GetResourceString("ERR_NamespaceNotAllowedInScript")
          End Get
        End Property
        ''' <summary>You cannot use '{0}' in top-level script code</summary>
        Friend Shared ReadOnly Property [ERR_KeywordNotAllowedInScript] As String
          Get
            Return GetResourceString("ERR_KeywordNotAllowedInScript")
          End Get
        End Property
        ''' <summary>Cannot infer a return type.  Consider adding an 'As' clause to specify the return type.</summary>
        Friend Shared ReadOnly Property [ERR_LambdaNoType] As String
          Get
            Return GetResourceString("ERR_LambdaNoType")
          End Get
        End Property
        ''' <summary>Cannot infer a return type; 'Object' assumed.</summary>
        Friend Shared ReadOnly Property [WRN_LambdaNoTypeObjectAssumed] As String
          Get
            Return GetResourceString("WRN_LambdaNoTypeObjectAssumed")
          End Get
        End Property
        ''' <summary>Cannot infer a return type</summary>
        Friend Shared ReadOnly Property [WRN_LambdaNoTypeObjectAssumed_Title] As String
          Get
            Return GetResourceString("WRN_LambdaNoTypeObjectAssumed_Title")
          End Get
        End Property
        ''' <summary>Cannot infer a return type because more than one type is possible; 'Object' assumed.</summary>
        Friend Shared ReadOnly Property [WRN_LambdaTooManyTypesObjectAssumed] As String
          Get
            Return GetResourceString("WRN_LambdaTooManyTypesObjectAssumed")
          End Get
        End Property
        ''' <summary>Cannot infer a return type because more than one type is possible</summary>
        Friend Shared ReadOnly Property [WRN_LambdaTooManyTypesObjectAssumed_Title] As String
          Get
            Return GetResourceString("WRN_LambdaTooManyTypesObjectAssumed_Title")
          End Get
        End Property
        ''' <summary>Cannot infer a return type. Consider adding an 'As' clause to specify the return type.</summary>
        Friend Shared ReadOnly Property [ERR_LambdaNoTypeObjectDisallowed] As String
          Get
            Return GetResourceString("ERR_LambdaNoTypeObjectDisallowed")
          End Get
        End Property
        ''' <summary>Cannot infer a return type because more than one type is possible. Consider adding an 'As' clause to specify the return type.</summary>
        Friend Shared ReadOnly Property [ERR_LambdaTooManyTypesObjectDisallowed] As String
          Get
            Return GetResourceString("ERR_LambdaTooManyTypesObjectDisallowed")
          End Get
        End Property
        ''' <summary>The command line switch '{0}' is not yet implemented and was ignored.</summary>
        Friend Shared ReadOnly Property [WRN_UnimplementedCommandLineSwitch] As String
          Get
            Return GetResourceString("WRN_UnimplementedCommandLineSwitch")
          End Get
        End Property
        ''' <summary>Command line switch is not yet implemented</summary>
        Friend Shared ReadOnly Property [WRN_UnimplementedCommandLineSwitch_Title] As String
          Get
            Return GetResourceString("WRN_UnimplementedCommandLineSwitch_Title")
          End Get
        End Property
        ''' <summary>Cannot infer an element type, and Option Strict On does not allow 'Object' to be assumed. Specifying the type of the array might correct this error.</summary>
        Friend Shared ReadOnly Property [ERR_ArrayInitNoTypeObjectDisallowed] As String
          Get
            Return GetResourceString("ERR_ArrayInitNoTypeObjectDisallowed")
          End Get
        End Property
        ''' <summary>Cannot infer an element type. Specifying the type of the array might correct this error.</summary>
        Friend Shared ReadOnly Property [ERR_ArrayInitNoType] As String
          Get
            Return GetResourceString("ERR_ArrayInitNoType")
          End Get
        End Property
        ''' <summary>Cannot infer an element type because more than one type is possible. Specifying the type of the array might correct this error.</summary>
        Friend Shared ReadOnly Property [ERR_ArrayInitTooManyTypesObjectDisallowed] As String
          Get
            Return GetResourceString("ERR_ArrayInitTooManyTypesObjectDisallowed")
          End Get
        End Property
        ''' <summary>Cannot infer an element type; 'Object' assumed.</summary>
        Friend Shared ReadOnly Property [WRN_ArrayInitNoTypeObjectAssumed] As String
          Get
            Return GetResourceString("WRN_ArrayInitNoTypeObjectAssumed")
          End Get
        End Property
        ''' <summary>Cannot infer an element type</summary>
        Friend Shared ReadOnly Property [WRN_ArrayInitNoTypeObjectAssumed_Title] As String
          Get
            Return GetResourceString("WRN_ArrayInitNoTypeObjectAssumed_Title")
          End Get
        End Property
        ''' <summary>Cannot infer an element type because more than one type is possible; 'Object' assumed.</summary>
        Friend Shared ReadOnly Property [WRN_ArrayInitTooManyTypesObjectAssumed] As String
          Get
            Return GetResourceString("WRN_ArrayInitTooManyTypesObjectAssumed")
          End Get
        End Property
        ''' <summary>Cannot infer an element type because more than one type is possible</summary>
        Friend Shared ReadOnly Property [WRN_ArrayInitTooManyTypesObjectAssumed_Title] As String
          Get
            Return GetResourceString("WRN_ArrayInitTooManyTypesObjectAssumed_Title")
          End Get
        End Property
        ''' <summary>Data type of '{0}' in '{1}' could not be inferred. '{2}' assumed.</summary>
        Friend Shared ReadOnly Property [WRN_TypeInferenceAssumed3] As String
          Get
            Return GetResourceString("WRN_TypeInferenceAssumed3")
          End Get
        End Property
        ''' <summary>Data type could not be inferred</summary>
        Friend Shared ReadOnly Property [WRN_TypeInferenceAssumed3_Title] As String
          Get
            Return GetResourceString("WRN_TypeInferenceAssumed3_Title")
          End Get
        End Property
        ''' <summary>Option Strict On does not allow implicit conversions from '{0}' to '{1}' because the conversion is ambiguous.</summary>
        Friend Shared ReadOnly Property [ERR_AmbiguousCastConversion2] As String
          Get
            Return GetResourceString("ERR_AmbiguousCastConversion2")
          End Get
        End Property
        ''' <summary>Conversion from '{0}' to '{1}' may be ambiguous.</summary>
        Friend Shared ReadOnly Property [WRN_AmbiguousCastConversion2] As String
          Get
            Return GetResourceString("WRN_AmbiguousCastConversion2")
          End Get
        End Property
        ''' <summary>Conversion may be ambiguous</summary>
        Friend Shared ReadOnly Property [WRN_AmbiguousCastConversion2_Title] As String
          Get
            Return GetResourceString("WRN_AmbiguousCastConversion2_Title")
          End Get
        End Property
        ''' <summary>'{0}' cannot be converted to '{1}'. Consider using '{2}' instead.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceIEnumerableSuggestion3] As String
          Get
            Return GetResourceString("ERR_VarianceIEnumerableSuggestion3")
          End Get
        End Property
        ''' <summary>'{0}' cannot be converted to '{1}'. Consider using '{2}' instead.</summary>
        Friend Shared ReadOnly Property [WRN_VarianceIEnumerableSuggestion3] As String
          Get
            Return GetResourceString("WRN_VarianceIEnumerableSuggestion3")
          End Get
        End Property
        ''' <summary>Type cannot be converted to target collection type</summary>
        Friend Shared ReadOnly Property [WRN_VarianceIEnumerableSuggestion3_Title] As String
          Get
            Return GetResourceString("WRN_VarianceIEnumerableSuggestion3_Title")
          End Get
        End Property
        ''' <summary>'{4}' cannot be converted to '{5}' because '{0}' is not derived from '{1}', as required for the 'In' generic parameter '{2}' in '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceConversionFailedIn6] As String
          Get
            Return GetResourceString("ERR_VarianceConversionFailedIn6")
          End Get
        End Property
        ''' <summary>'{4}' cannot be converted to '{5}' because '{0}' is not derived from '{1}', as required for the 'Out' generic parameter '{2}' in '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceConversionFailedOut6] As String
          Get
            Return GetResourceString("ERR_VarianceConversionFailedOut6")
          End Get
        End Property
        ''' <summary>Implicit conversion from '{4}' to '{5}'; this conversion may fail because '{0}' is not derived from '{1}', as required for the 'In' generic parameter '{2}' in '{3}'.</summary>
        Friend Shared ReadOnly Property [WRN_VarianceConversionFailedIn6] As String
          Get
            Return GetResourceString("WRN_VarianceConversionFailedIn6")
          End Get
        End Property
        ''' <summary>Implicit conversion; this conversion may fail because the target type is not derived from the source type, as required for 'In' generic parameter</summary>
        Friend Shared ReadOnly Property [WRN_VarianceConversionFailedIn6_Title] As String
          Get
            Return GetResourceString("WRN_VarianceConversionFailedIn6_Title")
          End Get
        End Property
        ''' <summary>Implicit conversion from '{4}' to '{5}'; this conversion may fail because '{0}' is not derived from '{1}', as required for the 'Out' generic parameter '{2}' in '{3}'.</summary>
        Friend Shared ReadOnly Property [WRN_VarianceConversionFailedOut6] As String
          Get
            Return GetResourceString("WRN_VarianceConversionFailedOut6")
          End Get
        End Property
        ''' <summary>Implicit conversion; this conversion may fail because the target type is not derived from the source type, as required for 'Out' generic parameter</summary>
        Friend Shared ReadOnly Property [WRN_VarianceConversionFailedOut6_Title] As String
          Get
            Return GetResourceString("WRN_VarianceConversionFailedOut6_Title")
          End Get
        End Property
        ''' <summary>'{0}' cannot be converted to '{1}'. Consider changing the '{2}' in the definition of '{3}' to an In type parameter, 'In {2}'.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceConversionFailedTryIn4] As String
          Get
            Return GetResourceString("ERR_VarianceConversionFailedTryIn4")
          End Get
        End Property
        ''' <summary>'{0}' cannot be converted to '{1}'. Consider changing the '{2}' in the definition of '{3}' to an Out type parameter, 'Out {2}'.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceConversionFailedTryOut4] As String
          Get
            Return GetResourceString("ERR_VarianceConversionFailedTryOut4")
          End Get
        End Property
        ''' <summary>'{0}' cannot be converted to '{1}'. Consider changing the '{2}' in the definition of '{3}' to an In type parameter, 'In {2}'.</summary>
        Friend Shared ReadOnly Property [WRN_VarianceConversionFailedTryIn4] As String
          Get
            Return GetResourceString("WRN_VarianceConversionFailedTryIn4")
          End Get
        End Property
        ''' <summary>Type cannot be converted to target type</summary>
        Friend Shared ReadOnly Property [WRN_VarianceConversionFailedTryIn4_Title] As String
          Get
            Return GetResourceString("WRN_VarianceConversionFailedTryIn4_Title")
          End Get
        End Property
        ''' <summary>'{0}' cannot be converted to '{1}'. Consider changing the '{2}' in the definition of '{3}' to an Out type parameter, 'Out {2}'.</summary>
        Friend Shared ReadOnly Property [WRN_VarianceConversionFailedTryOut4] As String
          Get
            Return GetResourceString("WRN_VarianceConversionFailedTryOut4")
          End Get
        End Property
        ''' <summary>Type cannot be converted to target type</summary>
        Friend Shared ReadOnly Property [WRN_VarianceConversionFailedTryOut4_Title] As String
          Get
            Return GetResourceString("WRN_VarianceConversionFailedTryOut4_Title")
          End Get
        End Property
        ''' <summary>Interface '{0}' is ambiguous with another implemented interface '{1}' due to the 'In' and 'Out' parameters in '{2}'.</summary>
        Friend Shared ReadOnly Property [WRN_VarianceDeclarationAmbiguous3] As String
          Get
            Return GetResourceString("WRN_VarianceDeclarationAmbiguous3")
          End Get
        End Property
        ''' <summary>Interface is ambiguous with another implemented interface due to 'In' and 'Out' parameters</summary>
        Friend Shared ReadOnly Property [WRN_VarianceDeclarationAmbiguous3_Title] As String
          Get
            Return GetResourceString("WRN_VarianceDeclarationAmbiguous3_Title")
          End Get
        End Property
        ''' <summary>Enumerations, classes, and structures cannot be declared in an interface that has an 'In' or 'Out' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceInterfaceNesting] As String
          Get
            Return GetResourceString("ERR_VarianceInterfaceNesting")
          End Get
        End Property
        ''' <summary>Event definitions with parameters are not allowed in an interface such as '{0}' that has 'In' or 'Out' type parameters. Consider declaring the event by using a delegate type which is not defined within '{0}'. For example, 'Event {1} As Action(Of ...)'.</summary>
        Friend Shared ReadOnly Property [ERR_VariancePreventsSynthesizedEvents2] As String
          Get
            Return GetResourceString("ERR_VariancePreventsSynthesizedEvents2")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used in this context because 'In' and 'Out' type parameters cannot be used for ByRef parameter types, and '{0}' is an 'In' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceInByRefDisallowed1] As String
          Get
            Return GetResourceString("ERR_VarianceInByRefDisallowed1")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used in '{1}' because 'In' and 'Out' type parameters cannot be made nullable, and '{0}' is an 'In' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceInNullableDisallowed2] As String
          Get
            Return GetResourceString("ERR_VarianceInNullableDisallowed2")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used in this context because '{0}' is an 'In' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceInParamDisallowed1] As String
          Get
            Return GetResourceString("ERR_VarianceInParamDisallowed1")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used for the '{1}' in '{2}' in this context because '{0}' is an 'In' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceInParamDisallowedForGeneric3] As String
          Get
            Return GetResourceString("ERR_VarianceInParamDisallowedForGeneric3")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used in '{1}' in this context because '{0}' is an 'In' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceInParamDisallowedHere2] As String
          Get
            Return GetResourceString("ERR_VarianceInParamDisallowedHere2")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used for the '{2}' of '{3}' in '{1}' in this context because '{0}' is an 'In' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceInParamDisallowedHereForGeneric4] As String
          Get
            Return GetResourceString("ERR_VarianceInParamDisallowedHereForGeneric4")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used as a property type in this context because '{0}' is an 'In' type parameter and the property is not marked WriteOnly.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceInPropertyDisallowed1] As String
          Get
            Return GetResourceString("ERR_VarianceInPropertyDisallowed1")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used as a ReadOnly property type because '{0}' is an 'In' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceInReadOnlyPropertyDisallowed1] As String
          Get
            Return GetResourceString("ERR_VarianceInReadOnlyPropertyDisallowed1")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used as a return type because '{0}' is an 'In' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceInReturnDisallowed1] As String
          Get
            Return GetResourceString("ERR_VarianceInReturnDisallowed1")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used in this context because 'In' and 'Out' type parameters cannot be used for ByRef parameter types, and '{0}' is an 'Out' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceOutByRefDisallowed1] As String
          Get
            Return GetResourceString("ERR_VarianceOutByRefDisallowed1")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used as a ByVal parameter type because '{0}' is an 'Out' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceOutByValDisallowed1] As String
          Get
            Return GetResourceString("ERR_VarianceOutByValDisallowed1")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used as a generic type constraint because '{0}' is an 'Out' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceOutConstraintDisallowed1] As String
          Get
            Return GetResourceString("ERR_VarianceOutConstraintDisallowed1")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used in '{1}' because 'In' and 'Out' type parameters cannot be made nullable, and '{0}' is an 'Out' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceOutNullableDisallowed2] As String
          Get
            Return GetResourceString("ERR_VarianceOutNullableDisallowed2")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used in this context because '{0}' is an 'Out' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceOutParamDisallowed1] As String
          Get
            Return GetResourceString("ERR_VarianceOutParamDisallowed1")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used for the '{1}' in '{2}' in this context because '{0}' is an 'Out' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceOutParamDisallowedForGeneric3] As String
          Get
            Return GetResourceString("ERR_VarianceOutParamDisallowedForGeneric3")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used in '{1}' in this context because '{0}' is an 'Out' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceOutParamDisallowedHere2] As String
          Get
            Return GetResourceString("ERR_VarianceOutParamDisallowedHere2")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used for the '{2}' of '{3}' in '{1}' in this context because '{0}' is an 'Out' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceOutParamDisallowedHereForGeneric4] As String
          Get
            Return GetResourceString("ERR_VarianceOutParamDisallowedHereForGeneric4")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used as a property type in this context because '{0}' is an 'Out' type parameter and the property is not marked ReadOnly.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceOutPropertyDisallowed1] As String
          Get
            Return GetResourceString("ERR_VarianceOutPropertyDisallowed1")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used as a WriteOnly property type because '{0}' is an 'Out' type parameter.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceOutWriteOnlyPropertyDisallowed1] As String
          Get
            Return GetResourceString("ERR_VarianceOutWriteOnlyPropertyDisallowed1")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used in this context because both the context and the definition of '{0}' are nested within interface '{1}', and '{1}' has 'In' or 'Out' type parameters. Consider moving the definition of '{0}' outside of '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceTypeDisallowed2] As String
          Get
            Return GetResourceString("ERR_VarianceTypeDisallowed2")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used for the '{2}' in '{3}' in this context because both the context and the definition of '{0}' are nested within interface '{1}', and '{1}' has 'In' or 'Out' type parameters. Consider moving the definition of '{0}' outside of '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceTypeDisallowedForGeneric4] As String
          Get
            Return GetResourceString("ERR_VarianceTypeDisallowedForGeneric4")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used in '{2}' in this context because both the context and the definition of '{0}' are nested within interface '{1}', and '{1}' has 'In' or 'Out' type parameters. Consider moving the definition of '{0}' outside of '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_VarianceTypeDisallowedHere3] As String
          Get
            Return GetResourceString("ERR_VarianceTypeDisallowedHere3")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be used for the '{3}' of '{4}' in '{2}' in this context because both the context and the definition of '{0}' are nested within interface '{1}', and '{1}' has 'In' or 'Out' type parameters. Consider moving the definition of '{0}' outside o ...</summary>
        Friend Shared ReadOnly Property [ERR_VarianceTypeDisallowedHereForGeneric5] As String
          Get
            Return GetResourceString("ERR_VarianceTypeDisallowedHereForGeneric5")
          End Get
        End Property
        ''' <summary>Parameter not valid for the specified unmanaged type.</summary>
        Friend Shared ReadOnly Property [ERR_ParameterNotValidForType] As String
          Get
            Return GetResourceString("ERR_ParameterNotValidForType")
          End Get
        End Property
        ''' <summary>Unmanaged type '{0}' not valid for fields.</summary>
        Friend Shared ReadOnly Property [ERR_MarshalUnmanagedTypeNotValidForFields] As String
          Get
            Return GetResourceString("ERR_MarshalUnmanagedTypeNotValidForFields")
          End Get
        End Property
        ''' <summary>Unmanaged type '{0}' is only valid for fields.</summary>
        Friend Shared ReadOnly Property [ERR_MarshalUnmanagedTypeOnlyValidForFields] As String
          Get
            Return GetResourceString("ERR_MarshalUnmanagedTypeOnlyValidForFields")
          End Get
        End Property
        ''' <summary>Attribute parameter '{0}' must be specified.</summary>
        Friend Shared ReadOnly Property [ERR_AttributeParameterRequired1] As String
          Get
            Return GetResourceString("ERR_AttributeParameterRequired1")
          End Get
        End Property
        ''' <summary>Attribute parameter '{0}' or '{1}' must be specified.</summary>
        Friend Shared ReadOnly Property [ERR_AttributeParameterRequired2] As String
          Get
            Return GetResourceString("ERR_AttributeParameterRequired2")
          End Get
        End Property
        ''' <summary>Conflicts with '{0}', which is implicitly declared for '{1}' in {2} '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_MemberConflictWithSynth4] As String
          Get
            Return GetResourceString("ERR_MemberConflictWithSynth4")
          End Get
        End Property
        ''' <summary>&lt;project settings&gt;</summary>
        Friend Shared ReadOnly Property [IDS_ProjectSettingsLocationName] As String
          Get
            Return GetResourceString("IDS_ProjectSettingsLocationName")
          End Get
        End Property
        ''' <summary>Attributes applied on a return type of a WriteOnly Property have no effect.</summary>
        Friend Shared ReadOnly Property [WRN_ReturnTypeAttributeOnWriteOnlyProperty] As String
          Get
            Return GetResourceString("WRN_ReturnTypeAttributeOnWriteOnlyProperty")
          End Get
        End Property
        ''' <summary>Attributes applied on a return type of a WriteOnly Property have no effect</summary>
        Friend Shared ReadOnly Property [WRN_ReturnTypeAttributeOnWriteOnlyProperty_Title] As String
          Get
            Return GetResourceString("WRN_ReturnTypeAttributeOnWriteOnlyProperty_Title")
          End Get
        End Property
        ''' <summary>Security attribute '{0}' is not valid on this declaration type. Security attributes are only valid on assembly, type and method declarations.</summary>
        Friend Shared ReadOnly Property [ERR_SecurityAttributeInvalidTarget] As String
          Get
            Return GetResourceString("ERR_SecurityAttributeInvalidTarget")
          End Get
        End Property
        ''' <summary>Cannot find the interop type that matches the embedded type '{0}'. Are you missing an assembly reference?</summary>
        Friend Shared ReadOnly Property [ERR_AbsentReferenceToPIA1] As String
          Get
            Return GetResourceString("ERR_AbsentReferenceToPIA1")
          End Get
        End Property
        ''' <summary>Reference to class '{0}' is not allowed when its assembly is configured to embed interop types.</summary>
        Friend Shared ReadOnly Property [ERR_CannotLinkClassWithNoPIA1] As String
          Get
            Return GetResourceString("ERR_CannotLinkClassWithNoPIA1")
          End Get
        End Property
        ''' <summary>Embedded interop structure '{0}' can contain only public instance fields.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidStructMemberNoPIA1] As String
          Get
            Return GetResourceString("ERR_InvalidStructMemberNoPIA1")
          End Get
        End Property
        ''' <summary>Interop type '{0}' cannot be embedded because it is missing the required '{1}' attribute.</summary>
        Friend Shared ReadOnly Property [ERR_NoPIAAttributeMissing2] As String
          Get
            Return GetResourceString("ERR_NoPIAAttributeMissing2")
          End Get
        End Property
        ''' <summary>Cannot embed interop types from assembly '{0}' because it is missing the '{1}' attribute.</summary>
        Friend Shared ReadOnly Property [ERR_PIAHasNoAssemblyGuid1] As String
          Get
            Return GetResourceString("ERR_PIAHasNoAssemblyGuid1")
          End Get
        End Property
        ''' <summary>Cannot embed interop type '{0}' found in both assembly '{1}' and '{2}'. Consider disabling the embedding of interop types.</summary>
        Friend Shared ReadOnly Property [ERR_DuplicateLocalTypes3] As String
          Get
            Return GetResourceString("ERR_DuplicateLocalTypes3")
          End Get
        End Property
        ''' <summary>Cannot embed interop types from assembly '{0}' because it is missing either the '{1}' attribute or the '{2}' attribute.</summary>
        Friend Shared ReadOnly Property [ERR_PIAHasNoTypeLibAttribute1] As String
          Get
            Return GetResourceString("ERR_PIAHasNoTypeLibAttribute1")
          End Get
        End Property
        ''' <summary>Interface '{0}' has an invalid source interface which is required to embed event '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_SourceInterfaceMustBeInterface] As String
          Get
            Return GetResourceString("ERR_SourceInterfaceMustBeInterface")
          End Get
        End Property
        ''' <summary>Source interface '{0}' is missing method '{1}', which is required to embed event '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_EventNoPIANoBackingMember] As String
          Get
            Return GetResourceString("ERR_EventNoPIANoBackingMember")
          End Get
        End Property
        ''' <summary>Nested type '{0}' cannot be embedded.</summary>
        Friend Shared ReadOnly Property [ERR_NestedInteropType] As String
          Get
            Return GetResourceString("ERR_NestedInteropType")
          End Get
        End Property
        ''' <summary>Embedding the interop type '{0}' from assembly '{1}' causes a name clash in the current assembly. Consider disabling the embedding of interop types.</summary>
        Friend Shared ReadOnly Property [ERR_LocalTypeNameClash2] As String
          Get
            Return GetResourceString("ERR_LocalTypeNameClash2")
          End Get
        End Property
        ''' <summary>Embedded interop method '{0}' contains a body.</summary>
        Friend Shared ReadOnly Property [ERR_InteropMethodWithBody1] As String
          Get
            Return GetResourceString("ERR_InteropMethodWithBody1")
          End Get
        End Property
        ''' <summary>'Await' may only be used in a query expression within the first collection expression of the initial 'From' clause or within the collection expression of a 'Join' clause.</summary>
        Friend Shared ReadOnly Property [ERR_BadAsyncInQuery] As String
          Get
            Return GetResourceString("ERR_BadAsyncInQuery")
          End Get
        End Property
        ''' <summary>'Await' requires that the type '{0}' have a suitable GetAwaiter method.</summary>
        Friend Shared ReadOnly Property [ERR_BadGetAwaiterMethod1] As String
          Get
            Return GetResourceString("ERR_BadGetAwaiterMethod1")
          End Get
        End Property
        ''' <summary>'Await' requires that the return type '{0}' of '{1}.GetAwaiter()' have suitable IsCompleted, OnCompleted and GetResult members, and implement INotifyCompletion or ICriticalNotifyCompletion.</summary>
        Friend Shared ReadOnly Property [ERR_BadIsCompletedOnCompletedGetResult2] As String
          Get
            Return GetResourceString("ERR_BadIsCompletedOnCompletedGetResult2")
          End Get
        End Property
        ''' <summary>'{0}' does not implement '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_DoesntImplementAwaitInterface2] As String
          Get
            Return GetResourceString("ERR_DoesntImplementAwaitInterface2")
          End Get
        End Property
        ''' <summary>Cannot await Nothing. Consider awaiting 'Task.Yield()' instead.</summary>
        Friend Shared ReadOnly Property [ERR_BadAwaitNothing] As String
          Get
            Return GetResourceString("ERR_BadAwaitNothing")
          End Get
        End Property
        ''' <summary>Async methods cannot have ByRef parameters.</summary>
        Friend Shared ReadOnly Property [ERR_BadAsyncByRefParam] As String
          Get
            Return GetResourceString("ERR_BadAsyncByRefParam")
          End Get
        End Property
        ''' <summary>'Async' and 'Iterator' modifiers cannot be used together.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidAsyncIteratorModifiers] As String
          Get
            Return GetResourceString("ERR_InvalidAsyncIteratorModifiers")
          End Get
        End Property
        ''' <summary>The implicit return variable of an Iterator or Async method cannot be accessed.</summary>
        Friend Shared ReadOnly Property [ERR_BadResumableAccessReturnVariable] As String
          Get
            Return GetResourceString("ERR_BadResumableAccessReturnVariable")
          End Get
        End Property
        ''' <summary>'Return' statements in this Async method cannot return a value since the return type of the function is 'Task'. Consider changing the function's return type to 'Task(Of T)'.</summary>
        Friend Shared ReadOnly Property [ERR_ReturnFromNonGenericTaskAsync] As String
          Get
            Return GetResourceString("ERR_ReturnFromNonGenericTaskAsync")
          End Get
        End Property
        ''' <summary>Since this is an async method, the return expression must be of type '{0}' rather than 'Task(Of {0})'.</summary>
        Friend Shared ReadOnly Property [ERR_BadAsyncReturnOperand1] As String
          Get
            Return GetResourceString("ERR_BadAsyncReturnOperand1")
          End Get
        End Property
        ''' <summary>The 'Async' modifier can only be used on Subs, or on Functions that return Task or Task(Of T).</summary>
        Friend Shared ReadOnly Property [ERR_BadAsyncReturn] As String
          Get
            Return GetResourceString("ERR_BadAsyncReturn")
          End Get
        End Property
        ''' <summary>'{0}' does not return a Task and cannot be awaited. Consider changing it to an Async Function.</summary>
        Friend Shared ReadOnly Property [ERR_CantAwaitAsyncSub1] As String
          Get
            Return GetResourceString("ERR_CantAwaitAsyncSub1")
          End Get
        End Property
        ''' <summary>'Only the 'Async' or 'Iterator' modifier is valid on a lambda.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidLambdaModifier] As String
          Get
            Return GetResourceString("ERR_InvalidLambdaModifier")
          End Get
        End Property
        ''' <summary>'Await' can only be used within an Async method. Consider marking this method with the 'Async' modifier and changing its return type to 'Task(Of {0})'.</summary>
        Friend Shared ReadOnly Property [ERR_BadAwaitInNonAsyncMethod] As String
          Get
            Return GetResourceString("ERR_BadAwaitInNonAsyncMethod")
          End Get
        End Property
        ''' <summary>'Await' can only be used within an Async method. Consider marking this method with the 'Async' modifier and changing its return type to 'Task'.</summary>
        Friend Shared ReadOnly Property [ERR_BadAwaitInNonAsyncVoidMethod] As String
          Get
            Return GetResourceString("ERR_BadAwaitInNonAsyncVoidMethod")
          End Get
        End Property
        ''' <summary>'Await' can only be used within an Async lambda expression. Consider marking this lambda expression with the 'Async' modifier.</summary>
        Friend Shared ReadOnly Property [ERR_BadAwaitInNonAsyncLambda] As String
          Get
            Return GetResourceString("ERR_BadAwaitInNonAsyncLambda")
          End Get
        End Property
        ''' <summary>'Await' can only be used when contained within a method or lambda expression marked with the 'Async' modifier.</summary>
        Friend Shared ReadOnly Property [ERR_BadAwaitNotInAsyncMethodOrLambda] As String
          Get
            Return GetResourceString("ERR_BadAwaitNotInAsyncMethodOrLambda")
          End Get
        End Property
        ''' <summary>Statement lambdas cannot be converted to expression trees.</summary>
        Friend Shared ReadOnly Property [ERR_StatementLambdaInExpressionTree] As String
          Get
            Return GetResourceString("ERR_StatementLambdaInExpressionTree")
          End Get
        End Property
        ''' <summary>Because this call is not awaited, execution of the current method continues before the call is completed. Consider applying the Await operator to the result of the call.</summary>
        Friend Shared ReadOnly Property [WRN_UnobservedAwaitableExpression] As String
          Get
            Return GetResourceString("WRN_UnobservedAwaitableExpression")
          End Get
        End Property
        ''' <summary>Because this call is not awaited, execution of the current method continues before the call is completed</summary>
        Friend Shared ReadOnly Property [WRN_UnobservedAwaitableExpression_Title] As String
          Get
            Return GetResourceString("WRN_UnobservedAwaitableExpression_Title")
          End Get
        End Property
        ''' <summary>Loop control variable cannot include an 'Await'.</summary>
        Friend Shared ReadOnly Property [ERR_LoopControlMustNotAwait] As String
          Get
            Return GetResourceString("ERR_LoopControlMustNotAwait")
          End Get
        End Property
        ''' <summary>Static variables cannot appear inside Async or Iterator methods.</summary>
        Friend Shared ReadOnly Property [ERR_BadStaticInitializerInResumable] As String
          Get
            Return GetResourceString("ERR_BadStaticInitializerInResumable")
          End Get
        End Property
        ''' <summary>'{0}' cannot be used as a parameter type for an Iterator or Async method.</summary>
        Friend Shared ReadOnly Property [ERR_RestrictedResumableType1] As String
          Get
            Return GetResourceString("ERR_RestrictedResumableType1")
          End Get
        End Property
        ''' <summary>Constructor must not have the 'Async' modifier.</summary>
        Friend Shared ReadOnly Property [ERR_ConstructorAsync] As String
          Get
            Return GetResourceString("ERR_ConstructorAsync")
          End Get
        End Property
        ''' <summary>'{0}' cannot be declared 'Partial' because it has the 'Async' modifier.</summary>
        Friend Shared ReadOnly Property [ERR_PartialMethodsMustNotBeAsync1] As String
          Get
            Return GetResourceString("ERR_PartialMethodsMustNotBeAsync1")
          End Get
        End Property
        ''' <summary>'On Error' and 'Resume' cannot appear inside async or iterator methods.</summary>
        Friend Shared ReadOnly Property [ERR_ResumablesCannotContainOnError] As String
          Get
            Return GetResourceString("ERR_ResumablesCannotContainOnError")
          End Get
        End Property
        ''' <summary>Lambdas with the 'Async' or 'Iterator' modifiers cannot be converted to expression trees.</summary>
        Friend Shared ReadOnly Property [ERR_ResumableLambdaInExpressionTree] As String
          Get
            Return GetResourceString("ERR_ResumableLambdaInExpressionTree")
          End Get
        End Property
        ''' <summary>Variable of restricted type '{0}' cannot be declared in an Async or Iterator method.</summary>
        Friend Shared ReadOnly Property [ERR_CannotLiftRestrictedTypeResumable1] As String
          Get
            Return GetResourceString("ERR_CannotLiftRestrictedTypeResumable1")
          End Get
        End Property
        ''' <summary>'Await' cannot be used inside a 'Catch' statement, a 'Finally' statement, or a 'SyncLock' statement.</summary>
        Friend Shared ReadOnly Property [ERR_BadAwaitInTryHandler] As String
          Get
            Return GetResourceString("ERR_BadAwaitInTryHandler")
          End Get
        End Property
        ''' <summary>This async method lacks 'Await' operators and so will run synchronously. Consider using the 'Await' operator to await non-blocking API calls, or 'Await Task.Run(...)' to do CPU-bound work on a background thread.</summary>
        Friend Shared ReadOnly Property [WRN_AsyncLacksAwaits] As String
          Get
            Return GetResourceString("WRN_AsyncLacksAwaits")
          End Get
        End Property
        ''' <summary>This async method lacks 'Await' operators and so will run synchronously</summary>
        Friend Shared ReadOnly Property [WRN_AsyncLacksAwaits_Title] As String
          Get
            Return GetResourceString("WRN_AsyncLacksAwaits_Title")
          End Get
        End Property
        ''' <summary>The Task returned from this Async Function will be dropped, and any exceptions in it ignored. Consider changing it to an Async Sub so its exceptions are propagated.</summary>
        Friend Shared ReadOnly Property [WRN_UnobservedAwaitableDelegate] As String
          Get
            Return GetResourceString("WRN_UnobservedAwaitableDelegate")
          End Get
        End Property
        ''' <summary>The Task returned from this Async Function will be dropped, and any exceptions in it ignored</summary>
        Friend Shared ReadOnly Property [WRN_UnobservedAwaitableDelegate_Title] As String
          Get
            Return GetResourceString("WRN_UnobservedAwaitableDelegate_Title")
          End Get
        End Property
        ''' <summary>Async and Iterator methods are not allowed in a [Class|Structure|Interface|Module] that has the 'SecurityCritical' or 'SecuritySafeCritical' attribute.</summary>
        Friend Shared ReadOnly Property [ERR_SecurityCriticalAsyncInClassOrStruct] As String
          Get
            Return GetResourceString("ERR_SecurityCriticalAsyncInClassOrStruct")
          End Get
        End Property
        ''' <summary>Security attribute '{0}' cannot be applied to an Async or Iterator method.</summary>
        Friend Shared ReadOnly Property [ERR_SecurityCriticalAsync] As String
          Get
            Return GetResourceString("ERR_SecurityCriticalAsync")
          End Get
        End Property
        ''' <summary>'System.Runtime.InteropServices.DllImportAttribute' cannot be applied to an Async or Iterator method.</summary>
        Friend Shared ReadOnly Property [ERR_DllImportOnResumableMethod] As String
          Get
            Return GetResourceString("ERR_DllImportOnResumableMethod")
          End Get
        End Property
        ''' <summary>'MethodImplOptions.Synchronized' cannot be applied to an Async method.</summary>
        Friend Shared ReadOnly Property [ERR_SynchronizedAsyncMethod] As String
          Get
            Return GetResourceString("ERR_SynchronizedAsyncMethod")
          End Get
        End Property
        ''' <summary>The 'Main' method cannot be marked 'Async'.</summary>
        Friend Shared ReadOnly Property [ERR_AsyncSubMain] As String
          Get
            Return GetResourceString("ERR_AsyncSubMain")
          End Get
        End Property
        ''' <summary>Some overloads here take an Async Function rather than an Async Sub. Consider either using an Async Function, or casting this Async Sub explicitly to the desired type.</summary>
        Friend Shared ReadOnly Property [WRN_AsyncSubCouldBeFunction] As String
          Get
            Return GetResourceString("WRN_AsyncSubCouldBeFunction")
          End Get
        End Property
        ''' <summary>Some overloads here take an Async Function rather than an Async Sub</summary>
        Friend Shared ReadOnly Property [WRN_AsyncSubCouldBeFunction_Title] As String
          Get
            Return GetResourceString("WRN_AsyncSubCouldBeFunction_Title")
          End Get
        End Property
        ''' <summary>MyGroupCollectionAttribute cannot be applied to itself.</summary>
        Friend Shared ReadOnly Property [ERR_MyGroupCollectionAttributeCycle] As String
          Get
            Return GetResourceString("ERR_MyGroupCollectionAttributeCycle")
          End Get
        End Property
        ''' <summary>Literal expected.</summary>
        Friend Shared ReadOnly Property [ERR_LiteralExpected] As String
          Get
            Return GetResourceString("ERR_LiteralExpected")
          End Get
        End Property
        ''' <summary>Event declarations that target WinMD must specify a delegate type.  Add an As clause to the event declaration.</summary>
        Friend Shared ReadOnly Property [ERR_WinRTEventWithoutDelegate] As String
          Get
            Return GetResourceString("ERR_WinRTEventWithoutDelegate")
          End Get
        End Property
        ''' <summary>Event '{0}' cannot implement a Windows Runtime event '{1}' and a regular .NET event '{2}'</summary>
        Friend Shared ReadOnly Property [ERR_MixingWinRTAndNETEvents] As String
          Get
            Return GetResourceString("ERR_MixingWinRTAndNETEvents")
          End Get
        End Property
        ''' <summary>Event '{0}' cannot implement event '{1}' on interface '{2}' because the parameters of their 'RemoveHandler' methods do not match.</summary>
        Friend Shared ReadOnly Property [ERR_EventImplRemoveHandlerParamWrong] As String
          Get
            Return GetResourceString("ERR_EventImplRemoveHandlerParamWrong")
          End Get
        End Property
        ''' <summary>The type of the 'AddHandler' method's parameter must be the same as the type of the event.</summary>
        Friend Shared ReadOnly Property [ERR_AddParamWrongForWinRT] As String
          Get
            Return GetResourceString("ERR_AddParamWrongForWinRT")
          End Get
        End Property
        ''' <summary>In a Windows Runtime event, the type of the 'RemoveHandler' method parameter must be 'EventRegistrationToken'</summary>
        Friend Shared ReadOnly Property [ERR_RemoveParamWrongForWinRT] As String
          Get
            Return GetResourceString("ERR_RemoveParamWrongForWinRT")
          End Get
        End Property
        ''' <summary>'{0}.{1}' from 'implements {2}' is already implemented by the base class '{3}'. Re-implementation of Windows Runtime Interface '{4}' is not allowed</summary>
        Friend Shared ReadOnly Property [ERR_ReImplementingWinRTInterface5] As String
          Get
            Return GetResourceString("ERR_ReImplementingWinRTInterface5")
          End Get
        End Property
        ''' <summary>'{0}.{1}' is already implemented by the base class '{2}'. Re-implementation of Windows Runtime Interface '{3}' is not allowed</summary>
        Friend Shared ReadOnly Property [ERR_ReImplementingWinRTInterface4] As String
          Get
            Return GetResourceString("ERR_ReImplementingWinRTInterface4")
          End Get
        End Property
        ''' <summary>Iterator methods cannot have ByRef parameters.</summary>
        Friend Shared ReadOnly Property [ERR_BadIteratorByRefParam] As String
          Get
            Return GetResourceString("ERR_BadIteratorByRefParam")
          End Get
        End Property
        ''' <summary>Single-line lambdas cannot have the 'Iterator' modifier. Use a multiline lambda instead.</summary>
        Friend Shared ReadOnly Property [ERR_BadIteratorExpressionLambda] As String
          Get
            Return GetResourceString("ERR_BadIteratorExpressionLambda")
          End Get
        End Property
        ''' <summary>Iterator functions must return either IEnumerable(Of T), or IEnumerator(Of T), or the non-generic forms IEnumerable or IEnumerator.</summary>
        Friend Shared ReadOnly Property [ERR_BadIteratorReturn] As String
          Get
            Return GetResourceString("ERR_BadIteratorReturn")
          End Get
        End Property
        ''' <summary>To return a value from an Iterator function, use 'Yield' rather than 'Return'.</summary>
        Friend Shared ReadOnly Property [ERR_BadReturnValueInIterator] As String
          Get
            Return GetResourceString("ERR_BadReturnValueInIterator")
          End Get
        End Property
        ''' <summary>'Yield' can only be used in a method marked with the 'Iterator' modifier.</summary>
        Friend Shared ReadOnly Property [ERR_BadYieldInNonIteratorMethod] As String
          Get
            Return GetResourceString("ERR_BadYieldInNonIteratorMethod")
          End Get
        End Property
        ''' <summary>'Yield' cannot be used inside a 'Catch' statement or a 'Finally' statement.</summary>
        Friend Shared ReadOnly Property [ERR_BadYieldInTryHandler] As String
          Get
            Return GetResourceString("ERR_BadYieldInTryHandler")
          End Get
        End Property
        ''' <summary>The AddHandler for Windows Runtime event '{0}' doesn't return a value on all code paths. Are you missing a 'Return' statement?</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgNoRetValWinRtEventVal1] As String
          Get
            Return GetResourceString("WRN_DefAsgNoRetValWinRtEventVal1")
          End Get
        End Property
        ''' <summary>The AddHandler for Windows Runtime event doesn't return a value on all code paths</summary>
        Friend Shared ReadOnly Property [WRN_DefAsgNoRetValWinRtEventVal1_Title] As String
          Get
            Return GetResourceString("WRN_DefAsgNoRetValWinRtEventVal1_Title")
          End Get
        End Property
        ''' <summary>Optional parameter of a method '{0}' does not have the same default value as the corresponding parameter of the partial method '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_PartialMethodDefaultParameterValueMismatch2] As String
          Get
            Return GetResourceString("ERR_PartialMethodDefaultParameterValueMismatch2")
          End Get
        End Property
        ''' <summary>Parameter of a method '{0}' differs by ParamArray modifier from the corresponding parameter of the partial method '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_PartialMethodParamArrayMismatch2] As String
          Get
            Return GetResourceString("ERR_PartialMethodParamArrayMismatch2")
          End Get
        End Property
        ''' <summary>Module name '{0}' stored in '{1}' must match its filename.</summary>
        Friend Shared ReadOnly Property [ERR_NetModuleNameMismatch] As String
          Get
            Return GetResourceString("ERR_NetModuleNameMismatch")
          End Get
        End Property
        ''' <summary>Invalid module name: {0}</summary>
        Friend Shared ReadOnly Property [ERR_BadModuleName] As String
          Get
            Return GetResourceString("ERR_BadModuleName")
          End Get
        End Property
        ''' <summary>Attribute '{0}' from module '{1}' will be ignored in favor of the instance appearing in source.</summary>
        Friend Shared ReadOnly Property [WRN_AssemblyAttributeFromModuleIsOverridden] As String
          Get
            Return GetResourceString("WRN_AssemblyAttributeFromModuleIsOverridden")
          End Get
        End Property
        ''' <summary>Attribute from module will be ignored in favor of the instance appearing in source</summary>
        Friend Shared ReadOnly Property [WRN_AssemblyAttributeFromModuleIsOverridden_Title] As String
          Get
            Return GetResourceString("WRN_AssemblyAttributeFromModuleIsOverridden_Title")
          End Get
        End Property
        ''' <summary>Attribute '{0}' given in a source file conflicts with option '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_CmdOptionConflictsSource] As String
          Get
            Return GetResourceString("ERR_CmdOptionConflictsSource")
          End Get
        End Property
        ''' <summary>Referenced assembly '{0}' does not have a strong name.</summary>
        Friend Shared ReadOnly Property [WRN_ReferencedAssemblyDoesNotHaveStrongName] As String
          Get
            Return GetResourceString("WRN_ReferencedAssemblyDoesNotHaveStrongName")
          End Get
        End Property
        ''' <summary>Referenced assembly does not have a strong name</summary>
        Friend Shared ReadOnly Property [WRN_ReferencedAssemblyDoesNotHaveStrongName_Title] As String
          Get
            Return GetResourceString("WRN_ReferencedAssemblyDoesNotHaveStrongName_Title")
          End Get
        End Property
        ''' <summary>Invalid signature public key specified in AssemblySignatureKeyAttribute.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidSignaturePublicKey] As String
          Get
            Return GetResourceString("ERR_InvalidSignaturePublicKey")
          End Get
        End Property
        ''' <summary>Type '{0}' conflicts with public type defined in added module '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_CollisionWithPublicTypeInModule] As String
          Get
            Return GetResourceString("ERR_CollisionWithPublicTypeInModule")
          End Get
        End Property
        ''' <summary>Type '{0}' exported from module '{1}' conflicts with type declared in primary module of this assembly.</summary>
        Friend Shared ReadOnly Property [ERR_ExportedTypeConflictsWithDeclaration] As String
          Get
            Return GetResourceString("ERR_ExportedTypeConflictsWithDeclaration")
          End Get
        End Property
        ''' <summary>Type '{0}' exported from module '{1}' conflicts with type '{2}' exported from module '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_ExportedTypesConflict] As String
          Get
            Return GetResourceString("ERR_ExportedTypesConflict")
          End Get
        End Property
        ''' <summary>Referenced assembly '{0}' has different culture setting of '{1}'.</summary>
        Friend Shared ReadOnly Property [WRN_RefCultureMismatch] As String
          Get
            Return GetResourceString("WRN_RefCultureMismatch")
          End Get
        End Property
        ''' <summary>Referenced assembly has different culture setting</summary>
        Friend Shared ReadOnly Property [WRN_RefCultureMismatch_Title] As String
          Get
            Return GetResourceString("WRN_RefCultureMismatch_Title")
          End Get
        End Property
        ''' <summary>Agnostic assembly cannot have a processor specific module '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_AgnosticToMachineModule] As String
          Get
            Return GetResourceString("ERR_AgnosticToMachineModule")
          End Get
        End Property
        ''' <summary>Assembly and module '{0}' cannot target different processors.</summary>
        Friend Shared ReadOnly Property [ERR_ConflictingMachineModule] As String
          Get
            Return GetResourceString("ERR_ConflictingMachineModule")
          End Get
        End Property
        ''' <summary>Referenced assembly '{0}' targets a different processor.</summary>
        Friend Shared ReadOnly Property [WRN_ConflictingMachineAssembly] As String
          Get
            Return GetResourceString("WRN_ConflictingMachineAssembly")
          End Get
        End Property
        ''' <summary>Referenced assembly targets a different processor</summary>
        Friend Shared ReadOnly Property [WRN_ConflictingMachineAssembly_Title] As String
          Get
            Return GetResourceString("WRN_ConflictingMachineAssembly_Title")
          End Get
        End Property
        ''' <summary>Cryptographic failure while creating hashes.</summary>
        Friend Shared ReadOnly Property [ERR_CryptoHashFailed] As String
          Get
            Return GetResourceString("ERR_CryptoHashFailed")
          End Get
        End Property
        ''' <summary>Conflicting options specified: Win32 resource file; Win32 manifest.</summary>
        Friend Shared ReadOnly Property [ERR_CantHaveWin32ResAndManifest] As String
          Get
            Return GetResourceString("ERR_CantHaveWin32ResAndManifest")
          End Get
        End Property
        ''' <summary>Forwarded type '{0}' conflicts with type declared in primary module of this assembly.</summary>
        Friend Shared ReadOnly Property [ERR_ForwardedTypeConflictsWithDeclaration] As String
          Get
            Return GetResourceString("ERR_ForwardedTypeConflictsWithDeclaration")
          End Get
        End Property
        ''' <summary>Type '{0}' forwarded to assembly '{1}' conflicts with type '{2}' forwarded to assembly '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_ForwardedTypesConflict] As String
          Get
            Return GetResourceString("ERR_ForwardedTypesConflict")
          End Get
        End Property
        ''' <summary>Name '{0}' exceeds the maximum length allowed in metadata.</summary>
        Friend Shared ReadOnly Property [ERR_TooLongMetadataName] As String
          Get
            Return GetResourceString("ERR_TooLongMetadataName")
          End Get
        End Property
        ''' <summary>Reference to '{0}' netmodule missing.</summary>
        Friend Shared ReadOnly Property [ERR_MissingNetModuleReference] As String
          Get
            Return GetResourceString("ERR_MissingNetModuleReference")
          End Get
        End Property
        ''' <summary>Module '{0}' is already defined in this assembly. Each module must have a unique filename.</summary>
        Friend Shared ReadOnly Property [ERR_NetModuleNameMustBeUnique] As String
          Get
            Return GetResourceString("ERR_NetModuleNameMustBeUnique")
          End Get
        End Property
        ''' <summary>Type '{0}' forwarded to assembly '{1}' conflicts with type '{2}' exported from module '{3}'.</summary>
        Friend Shared ReadOnly Property [ERR_ForwardedTypeConflictsWithExportedType] As String
          Get
            Return GetResourceString("ERR_ForwardedTypeConflictsWithExportedType")
          End Get
        End Property
        ''' <summary>Adding assembly reference '{0}'</summary>
        Friend Shared ReadOnly Property [IDS_MSG_ADDREFERENCE] As String
          Get
            Return GetResourceString("IDS_MSG_ADDREFERENCE")
          End Get
        End Property
        ''' <summary>Adding embedded assembly reference '{0}'</summary>
        Friend Shared ReadOnly Property [IDS_MSG_ADDLINKREFERENCE] As String
          Get
            Return GetResourceString("IDS_MSG_ADDLINKREFERENCE")
          End Get
        End Property
        ''' <summary>Adding module reference '{0}'</summary>
        Friend Shared ReadOnly Property [IDS_MSG_ADDMODULE] As String
          Get
            Return GetResourceString("IDS_MSG_ADDMODULE")
          End Get
        End Property
        ''' <summary>Type '{0}' does not inherit the generic type parameters of its container.</summary>
        Friend Shared ReadOnly Property [ERR_NestingViolatesCLS1] As String
          Get
            Return GetResourceString("ERR_NestingViolatesCLS1")
          End Get
        End Property
        ''' <summary>Failure writing debug information: {0}</summary>
        Friend Shared ReadOnly Property [ERR_PDBWritingFailed] As String
          Get
            Return GetResourceString("ERR_PDBWritingFailed")
          End Get
        End Property
        ''' <summary>The parameter has multiple distinct default values.</summary>
        Friend Shared ReadOnly Property [ERR_ParamDefaultValueDiffersFromAttribute] As String
          Get
            Return GetResourceString("ERR_ParamDefaultValueDiffersFromAttribute")
          End Get
        End Property
        ''' <summary>The field has multiple distinct constant values.</summary>
        Friend Shared ReadOnly Property [ERR_FieldHasMultipleDistinctConstantValues] As String
          Get
            Return GetResourceString("ERR_FieldHasMultipleDistinctConstantValues")
          End Get
        End Property
        ''' <summary>Cannot continue since the edit includes a reference to an embedded type: '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_EncNoPIAReference] As String
          Get
            Return GetResourceString("ERR_EncNoPIAReference")
          End Get
        End Property
        ''' <summary>Member '{0}' added during the current debug session can only be accessed from within its declaring assembly '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_EncReferenceToAddedMember] As String
          Get
            Return GetResourceString("ERR_EncReferenceToAddedMember")
          End Get
        End Property
        ''' <summary>'{0}' is an unsupported .NET module.</summary>
        Friend Shared ReadOnly Property [ERR_UnsupportedModule1] As String
          Get
            Return GetResourceString("ERR_UnsupportedModule1")
          End Get
        End Property
        ''' <summary>'{0}' is an unsupported event.</summary>
        Friend Shared ReadOnly Property [ERR_UnsupportedEvent1] As String
          Get
            Return GetResourceString("ERR_UnsupportedEvent1")
          End Get
        End Property
        ''' <summary>Update requires emitting explicit interface implementation, which is not supported by the runtime without restarting the application.</summary>
        Friend Shared ReadOnly Property [ERR_EncUpdateRequiresEmittingExplicitInterfaceImplementationNotSupportedByTheRuntime] As String
          Get
            Return GetResourceString("ERR_EncUpdateRequiresEmittingExplicitInterfaceImplementationNotSupportedByTheRuntime")
          End Get
        End Property
        ''' <summary>Properties can not have type arguments</summary>
        Friend Shared ReadOnly Property [PropertiesCanNotHaveTypeArguments] As String
          Get
            Return GetResourceString("PropertiesCanNotHaveTypeArguments")
          End Get
        End Property
        ''' <summary>IdentifierSyntax not within syntax tree</summary>
        Friend Shared ReadOnly Property [IdentifierSyntaxNotWithinSyntaxTree] As String
          Get
            Return GetResourceString("IdentifierSyntaxNotWithinSyntaxTree")
          End Get
        End Property
        ''' <summary>AnonymousObjectCreationExpressionSyntax not within syntax tree</summary>
        Friend Shared ReadOnly Property [AnonymousObjectCreationExpressionSyntaxNotWithinTree] As String
          Get
            Return GetResourceString("AnonymousObjectCreationExpressionSyntaxNotWithinTree")
          End Get
        End Property
        ''' <summary>FieldInitializerSyntax not within syntax tree</summary>
        Friend Shared ReadOnly Property [FieldInitializerSyntaxNotWithinSyntaxTree] As String
          Get
            Return GetResourceString("FieldInitializerSyntaxNotWithinSyntaxTree")
          End Get
        End Property
        ''' <summary>The system cannot find the path specified</summary>
        Friend Shared ReadOnly Property [IDS_TheSystemCannotFindThePathSpecified] As String
          Get
            Return GetResourceString("IDS_TheSystemCannotFindThePathSpecified")
          End Get
        End Property
        ''' <summary>There are no pointer types in VB.</summary>
        Friend Shared ReadOnly Property [ThereAreNoPointerTypesInVB] As String
          Get
            Return GetResourceString("ThereAreNoPointerTypesInVB")
          End Get
        End Property
        ''' <summary>There are no function pointer types in VB.</summary>
        Friend Shared ReadOnly Property [ThereAreNoFunctionPointerTypesInVB] As String
          Get
            Return GetResourceString("ThereAreNoFunctionPointerTypesInVB")
          End Get
        End Property
        ''' <summary>There is no dynamic type in VB.</summary>
        Friend Shared ReadOnly Property [ThereIsNoDynamicTypeInVB] As String
          Get
            Return GetResourceString("ThereIsNoDynamicTypeInVB")
          End Get
        End Property
        ''' <summary>There are no native integer types in VB.</summary>
        Friend Shared ReadOnly Property [ThereAreNoNativeIntegerTypesInVB] As String
          Get
            Return GetResourceString("ThereAreNoNativeIntegerTypesInVB")
          End Get
        End Property
        ''' <summary>variableSyntax not within syntax tree</summary>
        Friend Shared ReadOnly Property [VariableSyntaxNotWithinSyntaxTree] As String
          Get
            Return GetResourceString("VariableSyntaxNotWithinSyntaxTree")
          End Get
        End Property
        ''' <summary>AggregateSyntax not within syntax tree</summary>
        Friend Shared ReadOnly Property [AggregateSyntaxNotWithinSyntaxTree] As String
          Get
            Return GetResourceString("AggregateSyntaxNotWithinSyntaxTree")
          End Get
        End Property
        ''' <summary>FunctionSyntax not within syntax tree</summary>
        Friend Shared ReadOnly Property [FunctionSyntaxNotWithinSyntaxTree] As String
          Get
            Return GetResourceString("FunctionSyntaxNotWithinSyntaxTree")
          End Get
        End Property
        ''' <summary>Position is not within syntax tree</summary>
        Friend Shared ReadOnly Property [PositionIsNotWithinSyntax] As String
          Get
            Return GetResourceString("PositionIsNotWithinSyntax")
          End Get
        End Property
        ''' <summary>RangeVariableSyntax not within syntax tree</summary>
        Friend Shared ReadOnly Property [RangeVariableSyntaxNotWithinSyntaxTree] As String
          Get
            Return GetResourceString("RangeVariableSyntaxNotWithinSyntaxTree")
          End Get
        End Property
        ''' <summary>DeclarationSyntax not within syntax tree</summary>
        Friend Shared ReadOnly Property [DeclarationSyntaxNotWithinSyntaxTree] As String
          Get
            Return GetResourceString("DeclarationSyntaxNotWithinSyntaxTree")
          End Get
        End Property
        ''' <summary>StatementOrExpression is not an ExecutableStatementSyntax or an ExpressionSyntax</summary>
        Friend Shared ReadOnly Property [StatementOrExpressionIsNotAValidType] As String
          Get
            Return GetResourceString("StatementOrExpressionIsNotAValidType")
          End Get
        End Property
        ''' <summary>DeclarationSyntax not within tree</summary>
        Friend Shared ReadOnly Property [DeclarationSyntaxNotWithinTree] As String
          Get
            Return GetResourceString("DeclarationSyntaxNotWithinTree")
          End Get
        End Property
        ''' <summary>TypeParameter not within tree</summary>
        Friend Shared ReadOnly Property [TypeParameterNotWithinTree] As String
          Get
            Return GetResourceString("TypeParameterNotWithinTree")
          End Get
        End Property
        ''' <summary>not within tree</summary>
        Friend Shared ReadOnly Property [NotWithinTree] As String
          Get
            Return GetResourceString("NotWithinTree")
          End Get
        End Property
        ''' <summary>Location must be provided in order to provide minimal type qualification.</summary>
        Friend Shared ReadOnly Property [LocationMustBeProvided] As String
          Get
            Return GetResourceString("LocationMustBeProvided")
          End Get
        End Property
        ''' <summary>SemanticModel must be provided in order to provide minimal type qualification.</summary>
        Friend Shared ReadOnly Property [SemanticModelMustBeProvided] As String
          Get
            Return GetResourceString("SemanticModelMustBeProvided")
          End Get
        End Property
        ''' <summary>the number of type parameters and arguments should be the same</summary>
        Friend Shared ReadOnly Property [NumberOfTypeParametersAndArgumentsMustMatch] As String
          Get
            Return GetResourceString("NumberOfTypeParametersAndArgumentsMustMatch")
          End Get
        End Property
        ''' <summary>Cannot link resource files when building a module</summary>
        Friend Shared ReadOnly Property [ERR_ResourceInModule] As String
          Get
            Return GetResourceString("ERR_ResourceInModule")
          End Get
        End Property
        ''' <summary>Not a VB symbol.</summary>
        Friend Shared ReadOnly Property [NotAVbSymbol] As String
          Get
            Return GetResourceString("NotAVbSymbol")
          End Get
        End Property
        ''' <summary>Elements cannot be null.</summary>
        Friend Shared ReadOnly Property [ElementsCannotBeNull] As String
          Get
            Return GetResourceString("ElementsCannotBeNull")
          End Get
        End Property
        ''' <summary>Unused import clause.</summary>
        Friend Shared ReadOnly Property [HDN_UnusedImportClause] As String
          Get
            Return GetResourceString("HDN_UnusedImportClause")
          End Get
        End Property
        ''' <summary>Unused import statement.</summary>
        Friend Shared ReadOnly Property [HDN_UnusedImportStatement] As String
          Get
            Return GetResourceString("HDN_UnusedImportStatement")
          End Get
        End Property
        ''' <summary>Expected a {0} SemanticModel.</summary>
        Friend Shared ReadOnly Property [WrongSemanticModelType] As String
          Get
            Return GetResourceString("WrongSemanticModelType")
          End Get
        End Property
        ''' <summary>Position must be within span of the syntax tree.</summary>
        Friend Shared ReadOnly Property [PositionNotWithinTree] As String
          Get
            Return GetResourceString("PositionNotWithinTree")
          End Get
        End Property
        ''' <summary>Syntax node to be speculated cannot belong to a syntax tree from the current compilation.</summary>
        Friend Shared ReadOnly Property [SpeculatedSyntaxNodeCannotBelongToCurrentCompilation] As String
          Get
            Return GetResourceString("SpeculatedSyntaxNodeCannotBelongToCurrentCompilation")
          End Get
        End Property
        ''' <summary>Chaining speculative semantic model is not supported. You should create a speculative model from the non-speculative ParentModel.</summary>
        Friend Shared ReadOnly Property [ChainingSpeculativeModelIsNotSupported] As String
          Get
            Return GetResourceString("ChainingSpeculativeModelIsNotSupported")
          End Get
        End Property
        ''' <summary>Microsoft (R) Visual Basic Compiler</summary>
        Friend Shared ReadOnly Property [IDS_ToolName] As String
          Get
            Return GetResourceString("IDS_ToolName")
          End Get
        End Property
        ''' <summary>{0} version {1}</summary>
        Friend Shared ReadOnly Property [IDS_LogoLine1] As String
          Get
            Return GetResourceString("IDS_LogoLine1")
          End Get
        End Property
        ''' <summary>Copyright (C) Microsoft Corporation. All rights reserved.</summary>
        Friend Shared ReadOnly Property [IDS_LogoLine2] As String
          Get
            Return GetResourceString("IDS_LogoLine2")
          End Get
        End Property
        ''' <summary>Supported language versions:</summary>
        Friend Shared ReadOnly Property [IDS_LangVersions] As String
          Get
            Return GetResourceString("IDS_LangVersions")
          End Get
        End Property
        ''' <summary>Visual Basic Compiler Options
        ''' 
        '''                                   - OUTPUT FILE -
        ''' -out:&lt;file&gt;                       Specifies the output file name.
        ''' -target:exe                       Create a console application (default).
        '''                                   ( ...</summary>
        Friend Shared ReadOnly Property [IDS_VBCHelp] As String
          Get
            Return GetResourceString("IDS_VBCHelp")
          End Get
        End Property
        ''' <summary>Local name '{0}' is too long for PDB.  Consider shortening or compiling without /debug.</summary>
        Friend Shared ReadOnly Property [WRN_PdbLocalNameTooLong] As String
          Get
            Return GetResourceString("WRN_PdbLocalNameTooLong")
          End Get
        End Property
        ''' <summary>Local name is too long for PDB</summary>
        Friend Shared ReadOnly Property [WRN_PdbLocalNameTooLong_Title] As String
          Get
            Return GetResourceString("WRN_PdbLocalNameTooLong_Title")
          End Get
        End Property
        ''' <summary>Import string '{0}' is too long for PDB.  Consider shortening or compiling without /debug.</summary>
        Friend Shared ReadOnly Property [WRN_PdbUsingNameTooLong] As String
          Get
            Return GetResourceString("WRN_PdbUsingNameTooLong")
          End Get
        End Property
        ''' <summary>Import string is too long for PDB</summary>
        Friend Shared ReadOnly Property [WRN_PdbUsingNameTooLong_Title] As String
          Get
            Return GetResourceString("WRN_PdbUsingNameTooLong_Title")
          End Get
        End Property
        ''' <summary>XML comment has a tag with a 'cref' attribute '{0}' that bound to a type parameter.  Use the &lt;typeparamref&gt; tag instead.</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocCrefToTypeParameter] As String
          Get
            Return GetResourceString("WRN_XMLDocCrefToTypeParameter")
          End Get
        End Property
        ''' <summary>XML comment has a tag with a 'cref' attribute that bound to a type parameter</summary>
        Friend Shared ReadOnly Property [WRN_XMLDocCrefToTypeParameter_Title] As String
          Get
            Return GetResourceString("WRN_XMLDocCrefToTypeParameter_Title")
          End Get
        End Property
        ''' <summary>Linked netmodule metadata must provide a full PE image: '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_LinkedNetmoduleMetadataMustProvideFullPEImage] As String
          Get
            Return GetResourceString("ERR_LinkedNetmoduleMetadataMustProvideFullPEImage")
          End Get
        End Property
        ''' <summary>An instance of analyzer {0} cannot be created from {1} : {2}.</summary>
        Friend Shared ReadOnly Property [WRN_AnalyzerCannotBeCreated] As String
          Get
            Return GetResourceString("WRN_AnalyzerCannotBeCreated")
          End Get
        End Property
        ''' <summary>Instance of analyzer cannot be created</summary>
        Friend Shared ReadOnly Property [WRN_AnalyzerCannotBeCreated_Title] As String
          Get
            Return GetResourceString("WRN_AnalyzerCannotBeCreated_Title")
          End Get
        End Property
        ''' <summary>The assembly {0} does not contain any analyzers.</summary>
        Friend Shared ReadOnly Property [WRN_NoAnalyzerInAssembly] As String
          Get
            Return GetResourceString("WRN_NoAnalyzerInAssembly")
          End Get
        End Property
        ''' <summary>Assembly does not contain any analyzers</summary>
        Friend Shared ReadOnly Property [WRN_NoAnalyzerInAssembly_Title] As String
          Get
            Return GetResourceString("WRN_NoAnalyzerInAssembly_Title")
          End Get
        End Property
        ''' <summary>Unable to load analyzer assembly {0} : {1}.</summary>
        Friend Shared ReadOnly Property [WRN_UnableToLoadAnalyzer] As String
          Get
            Return GetResourceString("WRN_UnableToLoadAnalyzer")
          End Get
        End Property
        ''' <summary>Unable to load analyzer assembly</summary>
        Friend Shared ReadOnly Property [WRN_UnableToLoadAnalyzer_Title] As String
          Get
            Return GetResourceString("WRN_UnableToLoadAnalyzer_Title")
          End Get
        End Property
        ''' <summary>Skipping some types in analyzer assembly {0} due to a ReflectionTypeLoadException : {1}.</summary>
        Friend Shared ReadOnly Property [INF_UnableToLoadSomeTypesInAnalyzer] As String
          Get
            Return GetResourceString("INF_UnableToLoadSomeTypesInAnalyzer")
          End Get
        End Property
        ''' <summary>Skip loading types in analyzer assembly that fail due to a ReflectionTypeLoadException</summary>
        Friend Shared ReadOnly Property [INF_UnableToLoadSomeTypesInAnalyzer_Title] As String
          Get
            Return GetResourceString("INF_UnableToLoadSomeTypesInAnalyzer_Title")
          End Get
        End Property
        ''' <summary>Error reading ruleset file {0} - {1}</summary>
        Friend Shared ReadOnly Property [ERR_CantReadRulesetFile] As String
          Get
            Return GetResourceString("ERR_CantReadRulesetFile")
          End Get
        End Property
        ''' <summary>{0} is not supported in current project type.</summary>
        Friend Shared ReadOnly Property [ERR_PlatformDoesntSupport] As String
          Get
            Return GetResourceString("ERR_PlatformDoesntSupport")
          End Get
        End Property
        ''' <summary>The RequiredAttribute attribute is not permitted on Visual Basic types.</summary>
        Friend Shared ReadOnly Property [ERR_CantUseRequiredAttribute] As String
          Get
            Return GetResourceString("ERR_CantUseRequiredAttribute")
          End Get
        End Property
        ''' <summary>Cannot emit debug information for a source text without encoding.</summary>
        Friend Shared ReadOnly Property [ERR_EncodinglessSyntaxTree] As String
          Get
            Return GetResourceString("ERR_EncodinglessSyntaxTree")
          End Get
        End Property
        ''' <summary>'{0}' is not a valid format specifier</summary>
        Friend Shared ReadOnly Property [ERR_InvalidFormatSpecifier] As String
          Get
            Return GetResourceString("ERR_InvalidFormatSpecifier")
          End Get
        End Property
        ''' <summary>Preprocessor constant '{0}' of type '{1}' is not supported, only primitive types are allowed.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidPreprocessorConstantType] As String
          Get
            Return GetResourceString("ERR_InvalidPreprocessorConstantType")
          End Get
        End Property
        ''' <summary>'Warning' expected.</summary>
        Friend Shared ReadOnly Property [ERR_ExpectedWarningKeyword] As String
          Get
            Return GetResourceString("ERR_ExpectedWarningKeyword")
          End Get
        End Property
        ''' <summary>'{0}' cannot be made nullable.</summary>
        Friend Shared ReadOnly Property [ERR_CannotBeMadeNullable1] As String
          Get
            Return GetResourceString("ERR_CannotBeMadeNullable1")
          End Get
        End Property
        ''' <summary>Leading '?' can only appear inside a 'With' statement, but not inside an object member initializer.</summary>
        Friend Shared ReadOnly Property [ERR_BadConditionalWithRef] As String
          Get
            Return GetResourceString("ERR_BadConditionalWithRef")
          End Get
        End Property
        ''' <summary>A null propagating operator cannot be converted into an expression tree.</summary>
        Friend Shared ReadOnly Property [ERR_NullPropagatingOpInExpressionTree] As String
          Get
            Return GetResourceString("ERR_NullPropagatingOpInExpressionTree")
          End Get
        End Property
        ''' <summary>An expression is too long or complex to compile</summary>
        Friend Shared ReadOnly Property [ERR_TooLongOrComplexExpression] As String
          Get
            Return GetResourceString("ERR_TooLongOrComplexExpression")
          End Get
        End Property
        ''' <summary>This expression does not have a name.</summary>
        Friend Shared ReadOnly Property [ERR_ExpressionDoesntHaveName] As String
          Get
            Return GetResourceString("ERR_ExpressionDoesntHaveName")
          End Get
        End Property
        ''' <summary>This sub-expression cannot be used inside NameOf argument.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidNameOfSubExpression] As String
          Get
            Return GetResourceString("ERR_InvalidNameOfSubExpression")
          End Get
        End Property
        ''' <summary>Method type arguments unexpected.</summary>
        Friend Shared ReadOnly Property [ERR_MethodTypeArgsUnexpected] As String
          Get
            Return GetResourceString("ERR_MethodTypeArgsUnexpected")
          End Get
        End Property
        ''' <summary>SearchCriteria is expected.</summary>
        Friend Shared ReadOnly Property [NoNoneSearchCriteria] As String
          Get
            Return GetResourceString("NoNoneSearchCriteria")
          End Get
        End Property
        ''' <summary>Assembly culture strings may not contain embedded NUL characters.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidAssemblyCulture] As String
          Get
            Return GetResourceString("ERR_InvalidAssemblyCulture")
          End Get
        End Property
        ''' <summary>There is an error in a referenced assembly '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_InReferencedAssembly] As String
          Get
            Return GetResourceString("ERR_InReferencedAssembly")
          End Get
        End Property
        ''' <summary>Format specifier may not contain trailing whitespace.</summary>
        Friend Shared ReadOnly Property [ERR_InterpolationFormatWhitespace] As String
          Get
            Return GetResourceString("ERR_InterpolationFormatWhitespace")
          End Get
        End Property
        ''' <summary>Alignment value is outside of the supported range.</summary>
        Friend Shared ReadOnly Property [ERR_InterpolationAlignmentOutOfRange] As String
          Get
            Return GetResourceString("ERR_InterpolationAlignmentOutOfRange")
          End Get
        End Property
        ''' <summary>There were one or more errors emitting a call to {0}.{1}. Method or its return type may be missing or malformed.</summary>
        Friend Shared ReadOnly Property [ERR_InterpolatedStringFactoryError] As String
          Get
            Return GetResourceString("ERR_InterpolatedStringFactoryError")
          End Get
        End Property
        ''' <summary>Unused import clause</summary>
        Friend Shared ReadOnly Property [HDN_UnusedImportClause_Title] As String
          Get
            Return GetResourceString("HDN_UnusedImportClause_Title")
          End Get
        End Property
        ''' <summary>Unused import statement</summary>
        Friend Shared ReadOnly Property [HDN_UnusedImportStatement_Title] As String
          Get
            Return GetResourceString("HDN_UnusedImportStatement_Title")
          End Get
        End Property
        ''' <summary>Length of String constant resulting from concatenation exceeds System.Int32.MaxValue.  Try splitting the string into multiple constants.</summary>
        Friend Shared ReadOnly Property [ERR_ConstantStringTooLong] As String
          Get
            Return GetResourceString("ERR_ConstantStringTooLong")
          End Get
        End Property
        ''' <summary>Visual Basic {0} does not support {1}.</summary>
        Friend Shared ReadOnly Property [ERR_LanguageVersion] As String
          Get
            Return GetResourceString("ERR_LanguageVersion")
          End Get
        End Property
        ''' <summary>Error reading debug information for '{0}'</summary>
        Friend Shared ReadOnly Property [ERR_BadPdbData] As String
          Get
            Return GetResourceString("ERR_BadPdbData")
          End Get
        End Property
        ''' <summary>array literal expressions</summary>
        Friend Shared ReadOnly Property [FEATURE_ArrayLiterals] As String
          Get
            Return GetResourceString("FEATURE_ArrayLiterals")
          End Get
        End Property
        ''' <summary>async methods or lambdas</summary>
        Friend Shared ReadOnly Property [FEATURE_AsyncExpressions] As String
          Get
            Return GetResourceString("FEATURE_AsyncExpressions")
          End Get
        End Property
        ''' <summary>auto-implemented properties</summary>
        Friend Shared ReadOnly Property [FEATURE_AutoProperties] As String
          Get
            Return GetResourceString("FEATURE_AutoProperties")
          End Get
        End Property
        ''' <summary>readonly auto-implemented properties</summary>
        Friend Shared ReadOnly Property [FEATURE_ReadonlyAutoProperties] As String
          Get
            Return GetResourceString("FEATURE_ReadonlyAutoProperties")
          End Get
        End Property
        ''' <summary>variance</summary>
        Friend Shared ReadOnly Property [FEATURE_CoContraVariance] As String
          Get
            Return GetResourceString("FEATURE_CoContraVariance")
          End Get
        End Property
        ''' <summary>collection initializers</summary>
        Friend Shared ReadOnly Property [FEATURE_CollectionInitializers] As String
          Get
            Return GetResourceString("FEATURE_CollectionInitializers")
          End Get
        End Property
        ''' <summary>comments after line continuation</summary>
        Friend Shared ReadOnly Property [FEATURE_CommentsAfterLineContinuation] As String
          Get
            Return GetResourceString("FEATURE_CommentsAfterLineContinuation")
          End Get
        End Property
        ''' <summary>declaring a Global namespace</summary>
        Friend Shared ReadOnly Property [FEATURE_GlobalNamespace] As String
          Get
            Return GetResourceString("FEATURE_GlobalNamespace")
          End Get
        End Property
        ''' <summary>iterators</summary>
        Friend Shared ReadOnly Property [FEATURE_Iterators] As String
          Get
            Return GetResourceString("FEATURE_Iterators")
          End Get
        End Property
        ''' <summary>implicit line continuation</summary>
        Friend Shared ReadOnly Property [FEATURE_LineContinuation] As String
          Get
            Return GetResourceString("FEATURE_LineContinuation")
          End Get
        End Property
        ''' <summary>multi-line lambda expressions</summary>
        Friend Shared ReadOnly Property [FEATURE_StatementLambdas] As String
          Get
            Return GetResourceString("FEATURE_StatementLambdas")
          End Get
        End Property
        ''' <summary>'Sub' lambda expressions</summary>
        Friend Shared ReadOnly Property [FEATURE_SubLambdas] As String
          Get
            Return GetResourceString("FEATURE_SubLambdas")
          End Get
        End Property
        ''' <summary>null conditional operations</summary>
        Friend Shared ReadOnly Property [FEATURE_NullPropagatingOperator] As String
          Get
            Return GetResourceString("FEATURE_NullPropagatingOperator")
          End Get
        End Property
        ''' <summary>'nameof' expressions</summary>
        Friend Shared ReadOnly Property [FEATURE_NameOfExpressions] As String
          Get
            Return GetResourceString("FEATURE_NameOfExpressions")
          End Get
        End Property
        ''' <summary>region directives within method bodies or regions crossing boundaries of declaration blocks</summary>
        Friend Shared ReadOnly Property [FEATURE_RegionsEverywhere] As String
          Get
            Return GetResourceString("FEATURE_RegionsEverywhere")
          End Get
        End Property
        ''' <summary>multiline string literals</summary>
        Friend Shared ReadOnly Property [FEATURE_MultilineStringLiterals] As String
          Get
            Return GetResourceString("FEATURE_MultilineStringLiterals")
          End Get
        End Property
        ''' <summary>CObj in attribute arguments</summary>
        Friend Shared ReadOnly Property [FEATURE_CObjInAttributeArguments] As String
          Get
            Return GetResourceString("FEATURE_CObjInAttributeArguments")
          End Get
        End Property
        ''' <summary>line continuation comments</summary>
        Friend Shared ReadOnly Property [FEATURE_LineContinuationComments] As String
          Get
            Return GetResourceString("FEATURE_LineContinuationComments")
          End Get
        End Property
        ''' <summary>TypeOf IsNot expression</summary>
        Friend Shared ReadOnly Property [FEATURE_TypeOfIsNot] As String
          Get
            Return GetResourceString("FEATURE_TypeOfIsNot")
          End Get
        End Property
        ''' <summary>year-first date literals</summary>
        Friend Shared ReadOnly Property [FEATURE_YearFirstDateLiterals] As String
          Get
            Return GetResourceString("FEATURE_YearFirstDateLiterals")
          End Get
        End Property
        ''' <summary>warning directives</summary>
        Friend Shared ReadOnly Property [FEATURE_WarningDirectives] As String
          Get
            Return GetResourceString("FEATURE_WarningDirectives")
          End Get
        End Property
        ''' <summary>partial modules</summary>
        Friend Shared ReadOnly Property [FEATURE_PartialModules] As String
          Get
            Return GetResourceString("FEATURE_PartialModules")
          End Get
        End Property
        ''' <summary>partial interfaces</summary>
        Friend Shared ReadOnly Property [FEATURE_PartialInterfaces] As String
          Get
            Return GetResourceString("FEATURE_PartialInterfaces")
          End Get
        End Property
        ''' <summary>implementing read-only or write-only property with read-write property</summary>
        Friend Shared ReadOnly Property [FEATURE_ImplementingReadonlyOrWriteonlyPropertyWithReadwrite] As String
          Get
            Return GetResourceString("FEATURE_ImplementingReadonlyOrWriteonlyPropertyWithReadwrite")
          End Get
        End Property
        ''' <summary>digit separators</summary>
        Friend Shared ReadOnly Property [FEATURE_DigitSeparators] As String
          Get
            Return GetResourceString("FEATURE_DigitSeparators")
          End Get
        End Property
        ''' <summary>binary literals</summary>
        Friend Shared ReadOnly Property [FEATURE_BinaryLiterals] As String
          Get
            Return GetResourceString("FEATURE_BinaryLiterals")
          End Get
        End Property
        ''' <summary>tuples</summary>
        Friend Shared ReadOnly Property [FEATURE_Tuples] As String
          Get
            Return GetResourceString("FEATURE_Tuples")
          End Get
        End Property
        ''' <summary>Private Protected</summary>
        Friend Shared ReadOnly Property [FEATURE_PrivateProtected] As String
          Get
            Return GetResourceString("FEATURE_PrivateProtected")
          End Get
        End Property
        ''' <summary>Debug entry point must be a definition of a method declared in the current compilation.</summary>
        Friend Shared ReadOnly Property [ERR_DebugEntryPointNotSourceMethodDefinition] As String
          Get
            Return GetResourceString("ERR_DebugEntryPointNotSourceMethodDefinition")
          End Get
        End Property
        ''' <summary>The pathmap option was incorrectly formatted.</summary>
        Friend Shared ReadOnly Property [ERR_InvalidPathMap] As String
          Get
            Return GetResourceString("ERR_InvalidPathMap")
          End Get
        End Property
        ''' <summary>Syntax tree should be created from a submission.</summary>
        Friend Shared ReadOnly Property [SyntaxTreeIsNotASubmission] As String
          Get
            Return GetResourceString("SyntaxTreeIsNotASubmission")
          End Get
        End Property
        ''' <summary>Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string or XML literals.</summary>
        Friend Shared ReadOnly Property [ERR_TooManyUserStrings] As String
          Get
            Return GetResourceString("ERR_TooManyUserStrings")
          End Get
        End Property
        ''' <summary>Combined length of user strings used by the program exceeds allowed limit. Adding a string or XML literal requires restarting the application.</summary>
        Friend Shared ReadOnly Property [ERR_TooManyUserStrings_RestartRequired] As String
          Get
            Return GetResourceString("ERR_TooManyUserStrings_RestartRequired")
          End Get
        End Property
        ''' <summary>An error occurred while writing the output file: {0}</summary>
        Friend Shared ReadOnly Property [ERR_PeWritingFailure] As String
          Get
            Return GetResourceString("ERR_PeWritingFailure")
          End Get
        End Property
        ''' <summary>Option '{0}' must be an absolute path.</summary>
        Friend Shared ReadOnly Property [ERR_OptionMustBeAbsolutePath] As String
          Get
            Return GetResourceString("ERR_OptionMustBeAbsolutePath")
          End Get
        End Property
        ''' <summary>/sourcelink switch is only supported when emitting PDB.</summary>
        Friend Shared ReadOnly Property [ERR_SourceLinkRequiresPdb] As String
          Get
            Return GetResourceString("ERR_SourceLinkRequiresPdb")
          End Get
        End Property
        ''' <summary>Tuple element names must be unique.</summary>
        Friend Shared ReadOnly Property [ERR_TupleDuplicateElementName] As String
          Get
            Return GetResourceString("ERR_TupleDuplicateElementName")
          End Get
        End Property
        ''' <summary>The tuple element name '{0}' is ignored because a different name or no name is specified by the target type '{1}'.</summary>
        Friend Shared ReadOnly Property [WRN_TupleLiteralNameMismatch] As String
          Get
            Return GetResourceString("WRN_TupleLiteralNameMismatch")
          End Get
        End Property
        ''' <summary>The tuple element name is ignored because a different name or no name is specified by the assignment target.</summary>
        Friend Shared ReadOnly Property [WRN_TupleLiteralNameMismatch_Title] As String
          Get
            Return GetResourceString("WRN_TupleLiteralNameMismatch_Title")
          End Get
        End Property
        ''' <summary>Tuple element name '{0}' is only allowed at position {1}.</summary>
        Friend Shared ReadOnly Property [ERR_TupleReservedElementName] As String
          Get
            Return GetResourceString("ERR_TupleReservedElementName")
          End Get
        End Property
        ''' <summary>Tuple element name '{0}' is disallowed at any position.</summary>
        Friend Shared ReadOnly Property [ERR_TupleReservedElementNameAnyPosition] As String
          Get
            Return GetResourceString("ERR_TupleReservedElementNameAnyPosition")
          End Get
        End Property
        ''' <summary>Tuple must contain at least two elements.</summary>
        Friend Shared ReadOnly Property [ERR_TupleTooFewElements] As String
          Get
            Return GetResourceString("ERR_TupleTooFewElements")
          End Get
        End Property
        ''' <summary>Cannot define a class or member that utilizes tuples because the compiler required type '{0}' cannot be found. Are you missing a reference?</summary>
        Friend Shared ReadOnly Property [ERR_TupleElementNamesAttributeMissing] As String
          Get
            Return GetResourceString("ERR_TupleElementNamesAttributeMissing")
          End Get
        End Property
        ''' <summary>Cannot reference 'System.Runtime.CompilerServices.TupleElementNamesAttribute' explicitly. Use the tuple syntax to define tuple names.</summary>
        Friend Shared ReadOnly Property [ERR_ExplicitTupleElementNamesAttribute] As String
          Get
            Return GetResourceString("ERR_ExplicitTupleElementNamesAttribute")
          End Get
        End Property
        ''' <summary>An expression tree may not contain a call to a method or property that returns by reference.</summary>
        Friend Shared ReadOnly Property [ERR_RefReturningCallInExpressionTree] As String
          Get
            Return GetResourceString("ERR_RefReturningCallInExpressionTree")
          End Get
        End Property
        ''' <summary>/embed switch is only supported when emitting a PDB.</summary>
        Friend Shared ReadOnly Property [ERR_CannotEmbedWithoutPdb] As String
          Get
            Return GetResourceString("ERR_CannotEmbedWithoutPdb")
          End Get
        End Property
        ''' <summary>Invalid instrumentation kind: {0}</summary>
        Friend Shared ReadOnly Property [ERR_InvalidInstrumentationKind] As String
          Get
            Return GetResourceString("ERR_InvalidInstrumentationKind")
          End Get
        End Property
        ''' <summary>Invalid hash algorithm name: '{0}'</summary>
        Friend Shared ReadOnly Property [ERR_InvalidHashAlgorithmName] As String
          Get
            Return GetResourceString("ERR_InvalidHashAlgorithmName")
          End Get
        End Property
        ''' <summary>Error writing to XML documentation file: {0}</summary>
        Friend Shared ReadOnly Property [ERR_DocFileGen] As String
          Get
            Return GetResourceString("ERR_DocFileGen")
          End Get
        End Property
        ''' <summary>Invalid assembly name: {0}</summary>
        Friend Shared ReadOnly Property [ERR_BadAssemblyName] As String
          Get
            Return GetResourceString("ERR_BadAssemblyName")
          End Get
        End Property
        ''' <summary>Module '{0}' in assembly '{1}' is forwarding the type '{2}' to multiple assemblies: '{3}' and '{4}'.</summary>
        Friend Shared ReadOnly Property [ERR_TypeForwardedToMultipleAssemblies] As String
          Get
            Return GetResourceString("ERR_TypeForwardedToMultipleAssemblies")
          End Get
        End Property
        ''' <summary>Merge conflict marker encountered</summary>
        Friend Shared ReadOnly Property [ERR_Merge_conflict_marker_encountered] As String
          Get
            Return GetResourceString("ERR_Merge_conflict_marker_encountered")
          End Get
        End Property
        ''' <summary>Do not use refout when using refonly.</summary>
        Friend Shared ReadOnly Property [ERR_NoRefOutWhenRefOnly] As String
          Get
            Return GetResourceString("ERR_NoRefOutWhenRefOnly")
          End Get
        End Property
        ''' <summary>Cannot compile net modules when using /refout or /refonly.</summary>
        Friend Shared ReadOnly Property [ERR_NoNetModuleOutputWhenRefOutOrRefOnly] As String
          Get
            Return GetResourceString("ERR_NoNetModuleOutputWhenRefOutOrRefOnly")
          End Get
        End Property
        ''' <summary>Named argument '{0}' is used out-of-position but is followed by an unnamed argument</summary>
        Friend Shared ReadOnly Property [ERR_BadNonTrailingNamedArgument] As String
          Get
            Return GetResourceString("ERR_BadNonTrailingNamedArgument")
          End Get
        End Property
        ''' <summary>Provided documentation mode is unsupported or invalid: '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadDocumentationMode] As String
          Get
            Return GetResourceString("ERR_BadDocumentationMode")
          End Get
        End Property
        ''' <summary>Provided language version is unsupported or invalid: '{0}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadLanguageVersion] As String
          Get
            Return GetResourceString("ERR_BadLanguageVersion")
          End Get
        End Property
        ''' <summary>Provided source code kind is unsupported or invalid: '{0}'</summary>
        Friend Shared ReadOnly Property [ERR_BadSourceCodeKind] As String
          Get
            Return GetResourceString("ERR_BadSourceCodeKind")
          End Get
        End Property
        ''' <summary>Tuple element name '{0}' is inferred. Please use language version {1} or greater to access an element by its inferred name.</summary>
        Friend Shared ReadOnly Property [ERR_TupleInferredNamesNotAvailable] As String
          Get
            Return GetResourceString("ERR_TupleInferredNamesNotAvailable")
          End Get
        End Property
        ''' <summary>'{0}' is for evaluation purposes only and is subject to change or removal in future updates.</summary>
        Friend Shared ReadOnly Property [WRN_Experimental] As String
          Get
            Return GetResourceString("WRN_Experimental")
          End Get
        End Property
        ''' <summary>Type is for evaluation purposes only and is subject to change or removal in future updates.</summary>
        Friend Shared ReadOnly Property [WRN_Experimental_Title] As String
          Get
            Return GetResourceString("WRN_Experimental_Title")
          End Get
        End Property
        ''' <summary>'{0}' is for evaluation purposes only and is subject to change or removal in future updates: '{1}'.</summary>
        Friend Shared ReadOnly Property [WRN_ExperimentalWithMessage] As String
          Get
            Return GetResourceString("WRN_ExperimentalWithMessage")
          End Get
        End Property
        ''' <summary>Type is for evaluation purposes only and is subject to change or removal in future updates.</summary>
        Friend Shared ReadOnly Property [WRN_ExperimentalWithMessage_Title] As String
          Get
            Return GetResourceString("WRN_ExperimentalWithMessage_Title")
          End Get
        End Property
        ''' <summary>Unable to read debug information of method '{0}' (token 0x{1:X8}) from assembly '{2}': {3}</summary>
        Friend Shared ReadOnly Property [ERR_InvalidDebugInfo] As String
          Get
            Return GetResourceString("ERR_InvalidDebugInfo")
          End Get
        End Property
        ''' <summary>{0} is not a valid Visual Basic conversion expression</summary>
        Friend Shared ReadOnly Property [IConversionExpressionIsNotVisualBasicConversion] As String
          Get
            Return GetResourceString("IConversionExpressionIsNotVisualBasicConversion")
          End Get
        End Property
        ''' <summary>{0} is not a valid Visual Basic argument</summary>
        Friend Shared ReadOnly Property [IArgumentIsNotVisualBasicArgument] As String
          Get
            Return GetResourceString("IArgumentIsNotVisualBasicArgument")
          End Get
        End Property
        ''' <summary>leading digit separator</summary>
        Friend Shared ReadOnly Property [FEATURE_LeadingDigitSeparator] As String
          Get
            Return GetResourceString("FEATURE_LeadingDigitSeparator")
          End Get
        End Property
        ''' <summary>Predefined type '{0}' is declared in multiple referenced assemblies: '{1}' and '{2}'</summary>
        Friend Shared ReadOnly Property [ERR_ValueTupleResolutionAmbiguous3] As String
          Get
            Return GetResourceString("ERR_ValueTupleResolutionAmbiguous3")
          End Get
        End Property
        ''' <summary>{0} is not a valid Visual Basic compound assignment operation</summary>
        Friend Shared ReadOnly Property [ICompoundAssignmentOperationIsNotVisualBasicCompoundAssignment] As String
          Get
            Return GetResourceString("ICompoundAssignmentOperationIsNotVisualBasicCompoundAssignment")
          End Get
        End Property
        ''' <summary>interpolated strings</summary>
        Friend Shared ReadOnly Property [FEATURE_InterpolatedStrings] As String
          Get
            Return GetResourceString("FEATURE_InterpolatedStrings")
          End Get
        End Property
        ''' <summary>unconstrained type parameters in binary conditional expressions</summary>
        Friend Shared ReadOnly Property [FEATURE_UnconstrainedTypeParameterInConditional] As String
          Get
            Return GetResourceString("FEATURE_UnconstrainedTypeParameterInConditional")
          End Get
        End Property
        ''' <summary>Multiple analyzer config files cannot be in the same directory ('{0}').</summary>
        Friend Shared ReadOnly Property [ERR_MultipleAnalyzerConfigsInSameDir] As String
          Get
            Return GetResourceString("ERR_MultipleAnalyzerConfigsInSameDir")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be embedded because it has a non-abstract member. Consider setting the 'Embed Interop Types' property to false.</summary>
        Friend Shared ReadOnly Property [ERR_DefaultInterfaceImplementationInNoPIAType] As String
          Get
            Return GetResourceString("ERR_DefaultInterfaceImplementationInNoPIAType")
          End Get
        End Property
        ''' <summary>Type '{0}' cannot be embedded because it has a re-abstraction of a member from base interface. Consider setting the 'Embed Interop Types' property to false.</summary>
        Friend Shared ReadOnly Property [ERR_ReAbstractionInNoPIAType] As String
          Get
            Return GetResourceString("ERR_ReAbstractionInNoPIAType")
          End Get
        End Property
        ''' <summary>Command-line syntax error: '{0}' is not a valid value for the '{1}' option. The value must be of the form '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_BadSwitchValue] As String
          Get
            Return GetResourceString("ERR_BadSwitchValue")
          End Get
        End Property
        ''' <summary>Target runtime doesn't support default interface implementation.</summary>
        Friend Shared ReadOnly Property [ERR_RuntimeDoesNotSupportDefaultInterfaceImplementation] As String
          Get
            Return GetResourceString("ERR_RuntimeDoesNotSupportDefaultInterfaceImplementation")
          End Get
        End Property
        ''' <summary>Target runtime doesn't support 'Protected', 'Protected Friend', or 'Private Protected' accessibility for a member of an interface.</summary>
        Friend Shared ReadOnly Property [ERR_RuntimeDoesNotSupportProtectedAccessForInterfaceMember] As String
          Get
            Return GetResourceString("ERR_RuntimeDoesNotSupportProtectedAccessForInterfaceMember")
          End Get
        End Property
        ''' <summary>'{0}' is not supported in VB.</summary>
        Friend Shared ReadOnly Property [WRN_AttributeNotSupportedInVB] As String
          Get
            Return GetResourceString("WRN_AttributeNotSupportedInVB")
          End Get
        End Property
        ''' <summary>Attribute is not supported in VB</summary>
        Friend Shared ReadOnly Property [WRN_AttributeNotSupportedInVB_Title] As String
          Get
            Return GetResourceString("WRN_AttributeNotSupportedInVB_Title")
          End Get
        End Property
        ''' <summary>Generator '{0}' failed to generate source. It will not contribute to the output and compilation errors may occur as a result. Exception was of type '{1}' with message '{2}'.
        ''' {3}</summary>
        Friend Shared ReadOnly Property [WRN_GeneratorFailedDuringGeneration] As String
          Get
            Return GetResourceString("WRN_GeneratorFailedDuringGeneration")
          End Get
        End Property
        ''' <summary>Generator failed to generate source.</summary>
        Friend Shared ReadOnly Property [WRN_GeneratorFailedDuringGeneration_Title] As String
          Get
            Return GetResourceString("WRN_GeneratorFailedDuringGeneration_Title")
          End Get
        End Property
        ''' <summary>Generator '{0}' failed to initialize. It will not contribute to the output and compilation errors may occur as a result. Exception was of type '{1}' with message '{2}'.
        ''' {3}</summary>
        Friend Shared ReadOnly Property [WRN_GeneratorFailedDuringInitialization] As String
          Get
            Return GetResourceString("WRN_GeneratorFailedDuringInitialization")
          End Get
        End Property
        ''' <summary>Generator failed to initialize.</summary>
        Friend Shared ReadOnly Property [WRN_GeneratorFailedDuringInitialization_Title] As String
          Get
            Return GetResourceString("WRN_GeneratorFailedDuringInitialization_Title")
          End Get
        End Property
        ''' <summary>The assembly '{0}' containing type '{1}' references .NET Framework, which is not supported.</summary>
        Friend Shared ReadOnly Property [WRN_AnalyzerReferencesFramework] As String
          Get
            Return GetResourceString("WRN_AnalyzerReferencesFramework")
          End Get
        End Property
        ''' <summary>The loaded assembly references .NET Framework, which is not supported.</summary>
        Friend Shared ReadOnly Property [WRN_AnalyzerReferencesFramework_Title] As String
          Get
            Return GetResourceString("WRN_AnalyzerReferencesFramework_Title")
          End Get
        End Property
        ''' <summary>Analyzer assembly '{0}' cannot be used because it references version '{1}' of the compiler, which is newer than the currently running version '{2}'.</summary>
        Friend Shared ReadOnly Property [WRN_AnalyzerReferencesNewerCompiler] As String
          Get
            Return GetResourceString("WRN_AnalyzerReferencesNewerCompiler")
          End Get
        End Property
        ''' <summary>Analyzer assembly cannot be used because it references a newer version of the compiler than the currently running version.</summary>
        Friend Shared ReadOnly Property [WRN_AnalyzerReferencesNewerCompiler_Title] As String
          Get
            Return GetResourceString("WRN_AnalyzerReferencesNewerCompiler_Title")
          End Get
        End Property
        ''' <summary>assigning to or passing 'ByRef' properties with init-only setters</summary>
        Friend Shared ReadOnly Property [FEATURE_InitOnlySettersUsage] As String
          Get
            Return GetResourceString("FEATURE_InitOnlySettersUsage")
          End Get
        End Property
        ''' <summary>recognizing 'unmanaged' constraint</summary>
        Friend Shared ReadOnly Property [FEATURE_UnmanagedConstraint] As String
          Get
            Return GetResourceString("FEATURE_UnmanagedConstraint")
          End Get
        End Property
        ''' <summary>Init-only property '{0}' can only be assigned by an object member initializer, or on 'Me', 'MyClass` or 'MyBase' in an instance constructor.</summary>
        Friend Shared ReadOnly Property [ERR_AssignmentInitOnly] As String
          Get
            Return GetResourceString("ERR_AssignmentInitOnly")
          End Get
        End Property
        ''' <summary>'{0}' cannot override init-only '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_OverridingInitOnlyProperty] As String
          Get
            Return GetResourceString("ERR_OverridingInitOnlyProperty")
          End Get
        End Property
        ''' <summary>Init-only '{0}' cannot be implemented.</summary>
        Friend Shared ReadOnly Property [ERR_PropertyDoesntImplementInitOnly] As String
          Get
            Return GetResourceString("ERR_PropertyDoesntImplementInitOnly")
          End Get
        End Property
        ''' <summary>'UnmanagedCallersOnly' attribute is not supported.</summary>
        Friend Shared ReadOnly Property [ERR_UnmanagedCallersOnlyNotSupported] As String
          Get
            Return GetResourceString("ERR_UnmanagedCallersOnlyNotSupported")
          End Get
        End Property
        ''' <summary>caller argument expression</summary>
        Friend Shared ReadOnly Property [FEATURE_CallerArgumentExpression] As String
          Get
            Return GetResourceString("FEATURE_CallerArgumentExpression")
          End Get
        End Property
        ''' <summary>The CallerArgumentExpressionAttribute applied to parameter '{0}' will have no effect because it's self-referential.</summary>
        Friend Shared ReadOnly Property [WRN_CallerArgumentExpressionAttributeSelfReferential] As String
          Get
            Return GetResourceString("WRN_CallerArgumentExpressionAttributeSelfReferential")
          End Get
        End Property
        ''' <summary>The CallerArgumentExpressionAttribute applied to parameter will have no effect because it's self-referential.</summary>
        Friend Shared ReadOnly Property [WRN_CallerArgumentExpressionAttributeSelfReferential_Title] As String
          Get
            Return GetResourceString("WRN_CallerArgumentExpressionAttributeSelfReferential_Title")
          End Get
        End Property
        ''' <summary>The CallerArgumentExpressionAttribute applied to parameter '{0}' will have no effect. It is applied with an invalid parameter name.</summary>
        Friend Shared ReadOnly Property [WRN_CallerArgumentExpressionAttributeHasInvalidParameterName] As String
          Get
            Return GetResourceString("WRN_CallerArgumentExpressionAttributeHasInvalidParameterName")
          End Get
        End Property
        ''' <summary>The CallerArgumentExpressionAttribute applied to parameter will have no effect. It is applied with an invalid parameter name.</summary>
        Friend Shared ReadOnly Property [WRN_CallerArgumentExpressionAttributeHasInvalidParameterName_Title] As String
          Get
            Return GetResourceString("WRN_CallerArgumentExpressionAttributeHasInvalidParameterName_Title")
          End Get
        End Property
        ''' <summary>A shared abstract or virtual interface member cannot be accessed.</summary>
        Friend Shared ReadOnly Property [ERR_BadAbstractStaticMemberAccess] As String
          Get
            Return GetResourceString("ERR_BadAbstractStaticMemberAccess")
          End Get
        End Property
        ''' <summary>{0} '{1}' cannot implement interface '{3}' because it contains shared abstract or virtual '{2}'.</summary>
        Friend Shared ReadOnly Property [ERR_UnimplementedSharedMember] As String
          Get
            Return GetResourceString("ERR_UnimplementedSharedMember")
          End Get
        End Property
        ''' <summary>'{0}' requires compiler feature '{1}', which is not supported by this version of the Visual Basic compiler.</summary>
        Friend Shared ReadOnly Property [ERR_UnsupportedCompilerFeature] As String
          Get
            Return GetResourceString("ERR_UnsupportedCompilerFeature")
          End Get
        End Property
        ''' <summary>'System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute' is reserved for compiler usage only.</summary>
        Friend Shared ReadOnly Property [ERR_DoNotUseCompilerFeatureRequired] As String
          Get
            Return GetResourceString("ERR_DoNotUseCompilerFeatureRequired")
          End Get
        End Property
        ''' <summary>Analyzer reference '{0}' specified multiple times</summary>
        Friend Shared ReadOnly Property [WRN_DuplicateAnalyzerReference] As String
          Get
            Return GetResourceString("WRN_DuplicateAnalyzerReference")
          End Get
        End Property
        ''' <summary>Analyzer reference specified multiple times</summary>
        Friend Shared ReadOnly Property [WRN_DuplicateAnalyzerReference_Title] As String
          Get
            Return GetResourceString("WRN_DuplicateAnalyzerReference_Title")
          End Get
        End Property
        ''' <summary>Required member '{0}' must be set in the object initializer or attribute arguments.</summary>
        Friend Shared ReadOnly Property [ERR_RequiredMemberMustBeSet] As String
          Get
            Return GetResourceString("ERR_RequiredMemberMustBeSet")
          End Get
        End Property
        ''' <summary>Cannot inherit from '{0}' because it has required members.</summary>
        Friend Shared ReadOnly Property [ERR_CannotInheritFromTypeWithRequiredMembers] As String
          Get
            Return GetResourceString("ERR_CannotInheritFromTypeWithRequiredMembers")
          End Get
        End Property
        ''' <summary>The required members list for '{0}' is malformed and cannot be interpreted.</summary>
        Friend Shared ReadOnly Property [ERR_RequiredMembersInvalid] As String
          Get
            Return GetResourceString("ERR_RequiredMembersInvalid")
          End Get
        End Property
        ''' <summary>'{2}' cannot satisfy the 'New' constraint on parameter '{1}' in the generic type or or method '{0}' because '{2}' has required members.</summary>
        Friend Shared ReadOnly Property [ERR_NewConstraintCannotHaveRequiredMembers] As String
          Get
            Return GetResourceString("ERR_NewConstraintCannotHaveRequiredMembers")
          End Get
        End Property
        ''' <summary>'System.Runtime.CompilerServices.RequiredMemberAttribute' is reserved for compiler usage only.</summary>
        Friend Shared ReadOnly Property [ERR_DoNotUseRequiredMember] As String
          Get
            Return GetResourceString("ERR_DoNotUseRequiredMember")
          End Get
        End Property
        ''' <summary>A call to a method or property that returns by reference may not be used as 'With' statement expression in an async or iterator method, or if referenced implicitly in a lambda.</summary>
        Friend Shared ReadOnly Property [ERR_UnsupportedRefReturningCallInWithStatement] As String
          Get
            Return GetResourceString("ERR_UnsupportedRefReturningCallInWithStatement")
          End Get
        End Property
        ''' <summary>'{0}' is defined in assembly '{1}'.</summary>
        Friend Shared ReadOnly Property [ERR_SymbolDefinedInAssembly] As String
          Get
            Return GetResourceString("ERR_SymbolDefinedInAssembly")
          End Get
        End Property
        ''' <summary>The diagnosticId argument to the 'Experimental' attribute must be a valid identifier</summary>
        Friend Shared ReadOnly Property [ERR_InvalidExperimentalDiagID] As String
          Get
            Return GetResourceString("ERR_InvalidExperimentalDiagID")
          End Get
        End Property
        ''' <summary>A value of type 'System.Threading.Lock' is not supported in SyncLock. Consider manually calling 'Enter' and 'Exit' methods in a Try/Finally block instead.</summary>
        Friend Shared ReadOnly Property [ERR_LockTypeUnsupported] As String
          Get
            Return GetResourceString("ERR_LockTypeUnsupported")
          End Get
        End Property
        ''' <summary>A value of type 'System.Threading.Lock' converted to a different type will use likely unintended monitor-based locking in SyncLock statement.</summary>
        Friend Shared ReadOnly Property [WRN_ConvertingLock] As String
          Get
            Return GetResourceString("WRN_ConvertingLock")
          End Get
        End Property
        ''' <summary>A value of type 'System.Threading.Lock' converted to a different type will use likely unintended monitor-based locking in SyncLock statement.</summary>
        Friend Shared ReadOnly Property [WRN_ConvertingLock_Title] As String
          Get
            Return GetResourceString("WRN_ConvertingLock_Title")
          End Get
        End Property
        ''' <summary>The specified version string contains wildcards, which are not compatible with determinism. Either remove wildcards from the version string, or disable determinism for this compilation</summary>
        Friend Shared ReadOnly Property [ERR_InvalidVersionFormatDeterministic] As String
          Get
            Return GetResourceString("ERR_InvalidVersionFormatDeterministic")
          End Get
        End Property
        ''' <summary>The type name '{0}' is reserved to be used by the compiler.</summary>
        Friend Shared ReadOnly Property [ERR_TypeReserved] As String
          Get
            Return GetResourceString("ERR_TypeReserved")
          End Get
        End Property
        ''' <summary>Cannot use 'OverloadResolutionPriorityAttribute' on an overriding member.</summary>
        Friend Shared ReadOnly Property [ERR_CannotApplyOverloadResolutionPriorityToOverride] As String
          Get
            Return GetResourceString("ERR_CannotApplyOverloadResolutionPriorityToOverride")
          End Get
        End Property
        ''' <summary>Cannot use 'OverloadResolutionPriorityAttribute' on this member.</summary>
        Friend Shared ReadOnly Property [ERR_CannotApplyOverloadResolutionPriorityToMember] As String
          Get
            Return GetResourceString("ERR_CannotApplyOverloadResolutionPriorityToMember")
          End Get
        End Property
        ''' <summary>overload resolution priority</summary>
        Friend Shared ReadOnly Property [FEATURE_OverloadResolutionPriority] As String
          Get
            Return GetResourceString("FEATURE_OverloadResolutionPriority")
          End Get
        End Property
        ''' <summary>The type 'Microsoft.CodeAnalysis.EmbeddedAttribute' must be non-generic, Friend, NotInheritable, have a Public parameterless constructor, inherit from System.Attribute, and be able to be applied to any type</summary>
        Friend Shared ReadOnly Property [ERR_EmbeddedAttributeMustFollowPattern] As String
          Get
            Return GetResourceString("ERR_EmbeddedAttributeMustFollowPattern")
          End Get
        End Property
        ''' <summary>'MethodImplAttribute.Async' cannot be manually applied to methods.</summary>
        Friend Shared ReadOnly Property [ERR_MethodImplAttributeAsyncCannotBeUsed] As String
          Get
            Return GetResourceString("ERR_MethodImplAttributeAsyncCannotBeUsed")
          End Get
        End Property
        ''' <summary>'{0}' cannot be applied manually.</summary>
        Friend Shared ReadOnly Property [ERR_AttributeCannotBeAppliedManually] As String
          Get
            Return GetResourceString("ERR_AttributeCannotBeAppliedManually")
          End Get
        End Property
        ''' <summary>Use of 'StructLayoutAttribute' and 'ExtendedLayoutAttribute' on the same type is not allowed.</summary>
        Friend Shared ReadOnly Property [ERR_StructLayoutAndExtendedLayout] As String
          Get
            Return GetResourceString("ERR_StructLayoutAndExtendedLayout")
          End Get
        End Property
        ''' <summary>The target runtime does not support extended layout types.</summary>
        Friend Shared ReadOnly Property [ERR_RuntimeDoesNotSupportExtendedLayoutTypes] As String
          Get
            Return GetResourceString("ERR_RuntimeDoesNotSupportExtendedLayoutTypes")
          End Get
        End Property

    End Class
End Namespace
