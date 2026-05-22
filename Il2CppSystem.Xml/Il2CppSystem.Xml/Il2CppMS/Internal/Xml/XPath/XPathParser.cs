using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Xml.XPath;

namespace Il2CppMS.Internal.Xml.XPath
{
	// Token: 0x0200000E RID: 14
	public class XPathParser : Object
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00015A80 File Offset: 0x00013C80
		// Note: this type is marked as 'beforefieldinit'.
		static XPathParser()
		{
			Il2CppClassPointerStore<XPathParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "XPathParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathParser>.NativeClassPtr);
			XPathParser.NativeFieldInfoPtr_scanner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "scanner");
			XPathParser.NativeFieldInfoPtr_parseDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "parseDepth");
			XPathParser.NativeFieldInfoPtr_temparray1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "temparray1");
			XPathParser.NativeFieldInfoPtr_temparray2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "temparray2");
			XPathParser.NativeFieldInfoPtr_temparray3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "temparray3");
			XPathParser.NativeFieldInfoPtr_temparray4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "temparray4");
			XPathParser.NativeFieldInfoPtr_temparray5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "temparray5");
			XPathParser.NativeFieldInfoPtr_temparray6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "temparray6");
			XPathParser.NativeFieldInfoPtr_temparray7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "temparray7");
			XPathParser.NativeFieldInfoPtr_temparray8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "temparray8");
			XPathParser.NativeFieldInfoPtr_temparray9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "temparray9");
			XPathParser.NativeFieldInfoPtr_functionTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "functionTable");
			XPathParser.NativeFieldInfoPtr_AxesTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "AxesTable");
			XPathParser.NativeMethodInfoPtr__ctor_Private_Void_XPathScanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663343);
			XPathParser.NativeMethodInfoPtr_ParseXPathExpresion_Public_Static_AstNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663344);
			XPathParser.NativeMethodInfoPtr_ParseExpresion_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663345);
			XPathParser.NativeMethodInfoPtr_ParseOrExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663346);
			XPathParser.NativeMethodInfoPtr_ParseAndExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663347);
			XPathParser.NativeMethodInfoPtr_ParseEqualityExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663348);
			XPathParser.NativeMethodInfoPtr_ParseRelationalExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663349);
			XPathParser.NativeMethodInfoPtr_ParseAdditiveExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663350);
			XPathParser.NativeMethodInfoPtr_ParseMultiplicativeExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663351);
			XPathParser.NativeMethodInfoPtr_ParseUnaryExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663352);
			XPathParser.NativeMethodInfoPtr_ParseUnionExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663353);
			XPathParser.NativeMethodInfoPtr_IsNodeType_Private_Static_Boolean_XPathScanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663354);
			XPathParser.NativeMethodInfoPtr_ParsePathExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663355);
			XPathParser.NativeMethodInfoPtr_ParseFilterExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663356);
			XPathParser.NativeMethodInfoPtr_ParsePredicate_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663357);
			XPathParser.NativeMethodInfoPtr_ParseLocationPath_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663358);
			XPathParser.NativeMethodInfoPtr_ParseRelativeLocationPath_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663359);
			XPathParser.NativeMethodInfoPtr_IsStep_Private_Static_Boolean_LexKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663360);
			XPathParser.NativeMethodInfoPtr_ParseStep_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663361);
			XPathParser.NativeMethodInfoPtr_ParseNodeTest_Private_AstNode_AstNode_AxisType_XPathNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663362);
			XPathParser.NativeMethodInfoPtr_IsPrimaryExpr_Private_Static_Boolean_XPathScanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663363);
			XPathParser.NativeMethodInfoPtr_ParsePrimaryExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663364);
			XPathParser.NativeMethodInfoPtr_ParseMethod_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663365);
			XPathParser.NativeMethodInfoPtr_CheckToken_Private_Void_LexKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663366);
			XPathParser.NativeMethodInfoPtr_PassToken_Private_Void_LexKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663367);
			XPathParser.NativeMethodInfoPtr_NextLex_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663368);
			XPathParser.NativeMethodInfoPtr_TestOp_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663369);
			XPathParser.NativeMethodInfoPtr_CheckNodeSet_Private_Void_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663370);
			XPathParser.NativeMethodInfoPtr_CreateFunctionTable_Private_Static_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663371);
			XPathParser.NativeMethodInfoPtr_CreateAxesTable_Private_Static_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663372);
			XPathParser.NativeMethodInfoPtr_GetAxis_Private_AxisType_XPathScanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100663373);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00015E20 File Offset: 0x00014020
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathParser(XPathScanner scanner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scanner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr__ctor_Private_Void_XPathScanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00015E6C File Offset: 0x0001406C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388826, RefRangeEnd = 388827, XrefRangeStart = 388816, XrefRangeEnd = 388826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AstNode ParseXPathExpresion(string xpathExpresion)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xpathExpresion);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseXPathExpresion_Public_Static_AstNode_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00015EB0 File Offset: 0x000140B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 388839, RefRangeEnd = 388846, XrefRangeStart = 388827, XrefRangeEnd = 388839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseExpresion(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseExpresion_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00015F00 File Offset: 0x00014100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388846, XrefRangeEnd = 388858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseOrExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseOrExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00015F50 File Offset: 0x00014150
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 388870, RefRangeEnd = 388874, XrefRangeStart = 388858, XrefRangeEnd = 388870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseAndExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseAndExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00015FA0 File Offset: 0x000141A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388883, RefRangeEnd = 388885, XrefRangeStart = 388874, XrefRangeEnd = 388883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseEqualityExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseEqualityExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00015FF0 File Offset: 0x000141F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388896, RefRangeEnd = 388898, XrefRangeStart = 388885, XrefRangeEnd = 388896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseRelationalExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseRelationalExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00016040 File Offset: 0x00014240
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388907, RefRangeEnd = 388909, XrefRangeStart = 388898, XrefRangeEnd = 388907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseAdditiveExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseAdditiveExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00016090 File Offset: 0x00014290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388925, RefRangeEnd = 388927, XrefRangeStart = 388909, XrefRangeEnd = 388925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseMultiplicativeExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseMultiplicativeExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000160E0 File Offset: 0x000142E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388938, RefRangeEnd = 388940, XrefRangeStart = 388927, XrefRangeEnd = 388938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseUnaryExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseUnaryExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00016130 File Offset: 0x00014330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388948, RefRangeEnd = 388949, XrefRangeStart = 388940, XrefRangeEnd = 388948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseUnionExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseUnionExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00016180 File Offset: 0x00014380
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 388953, RefRangeEnd = 388957, XrefRangeStart = 388949, XrefRangeEnd = 388953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNodeType(XPathScanner scaner)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_IsNodeType_Private_Static_Boolean_XPathScanner_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000161C4 File Offset: 0x000143C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 388990, RefRangeEnd = 388992, XrefRangeStart = 388957, XrefRangeEnd = 388990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParsePathExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParsePathExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00016214 File Offset: 0x00014414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389001, RefRangeEnd = 389002, XrefRangeStart = 388992, XrefRangeEnd = 389001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseFilterExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseFilterExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00016264 File Offset: 0x00014464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389002, XrefRangeEnd = 389008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParsePredicate(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParsePredicate_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000162B4 File Offset: 0x000144B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389008, XrefRangeEnd = 389025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseLocationPath(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseLocationPath_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00016304 File Offset: 0x00014504
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 389037, RefRangeEnd = 389040, XrefRangeStart = 389025, XrefRangeEnd = 389037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseRelativeLocationPath(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseRelativeLocationPath_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00016354 File Offset: 0x00014554
		[CallerCount(0)]
		public unsafe static bool IsStep(XPathScanner.LexKind lexKind)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lexKind;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_IsStep_Private_Static_Boolean_LexKind_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00016394 File Offset: 0x00014594
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 389067, RefRangeEnd = 389069, XrefRangeStart = 389040, XrefRangeEnd = 389067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseStep(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseStep_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000163E4 File Offset: 0x000145E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389105, RefRangeEnd = 389106, XrefRangeStart = 389069, XrefRangeEnd = 389105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseNodeTest_Private_AstNode_AstNode_AxisType_XPathNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00016450 File Offset: 0x00014650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389106, XrefRangeEnd = 389110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrimaryExpr(XPathScanner scanner)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scanner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_IsPrimaryExpr_Private_Static_Boolean_XPathScanner_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00016494 File Offset: 0x00014694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389137, RefRangeEnd = 389138, XrefRangeStart = 389110, XrefRangeEnd = 389137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParsePrimaryExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParsePrimaryExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000164E4 File Offset: 0x000146E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389186, RefRangeEnd = 389187, XrefRangeStart = 389138, XrefRangeEnd = 389186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseMethod(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseMethod_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00016534 File Offset: 0x00014734
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 389187, RefRangeEnd = 389197, XrefRangeStart = 389187, XrefRangeEnd = 389187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckToken(XPathScanner.LexKind t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_CheckToken_Private_Void_LexKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00016574 File Offset: 0x00014774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389197, XrefRangeEnd = 389200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PassToken(XPathScanner.LexKind t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_PassToken_Private_Void_LexKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000165B4 File Offset: 0x000147B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389200, XrefRangeEnd = 389202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NextLex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_NextLex_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000165E8 File Offset: 0x000147E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 389202, RefRangeEnd = 389209, XrefRangeStart = 389202, XrefRangeEnd = 389202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TestOp(string op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_TestOp_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00016638 File Offset: 0x00014838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389209, RefRangeEnd = 389210, XrefRangeStart = 389209, XrefRangeEnd = 389209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNodeSet(XPathResultType t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_CheckNodeSet_Private_Void_XPathResultType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00016678 File Offset: 0x00014878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389210, XrefRangeEnd = 389353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Hashtable CreateFunctionTable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_CreateFunctionTable_Private_Static_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000166AC File Offset: 0x000148AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389353, XrefRangeEnd = 389410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Hashtable CreateAxesTable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_CreateAxesTable_Private_Static_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000166E0 File Offset: 0x000148E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389410, XrefRangeEnd = 389416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Axis.AxisType GetAxis(XPathScanner scaner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_GetAxis_Private_AxisType_XPathScanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000023E2 File Offset: 0x000005E2
		public XPathParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00016730 File Offset: 0x00014930
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000023EB File Offset: 0x000005EB
		public unsafe XPathScanner scanner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.NativeFieldInfoPtr_scanner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XPathScanner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.NativeFieldInfoPtr_scanner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00016760 File Offset: 0x00014960
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000240A File Offset: 0x0000060A
		public unsafe int parseDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.NativeFieldInfoPtr_parseDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.NativeFieldInfoPtr_parseDepth)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00016788 File Offset: 0x00014988
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002425 File Offset: 0x00000625
		public unsafe static Il2CppStructArray<XPathResultType> temparray1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_temparray1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_temparray1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000167B0 File Offset: 0x000149B0
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002437 File Offset: 0x00000637
		public unsafe static Il2CppStructArray<XPathResultType> temparray2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_temparray2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_temparray2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000167D8 File Offset: 0x000149D8
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002449 File Offset: 0x00000649
		public unsafe static Il2CppStructArray<XPathResultType> temparray3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_temparray3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_temparray3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00016800 File Offset: 0x00014A00
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000245B File Offset: 0x0000065B
		public unsafe static Il2CppStructArray<XPathResultType> temparray4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_temparray4, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_temparray4, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00016828 File Offset: 0x00014A28
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000246D File Offset: 0x0000066D
		public unsafe static Il2CppStructArray<XPathResultType> temparray5
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_temparray5, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_temparray5, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00016850 File Offset: 0x00014A50
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000247F File Offset: 0x0000067F
		public unsafe static Il2CppStructArray<XPathResultType> temparray6
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_temparray6, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_temparray6, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00016878 File Offset: 0x00014A78
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002491 File Offset: 0x00000691
		public unsafe static Il2CppStructArray<XPathResultType> temparray7
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_temparray7, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_temparray7, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000168A0 File Offset: 0x00014AA0
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000024A3 File Offset: 0x000006A3
		public unsafe static Il2CppStructArray<XPathResultType> temparray8
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_temparray8, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_temparray8, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000168C8 File Offset: 0x00014AC8
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000024B5 File Offset: 0x000006B5
		public unsafe static Il2CppStructArray<XPathResultType> temparray9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_temparray9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_temparray9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000168F0 File Offset: 0x00014AF0
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000024C7 File Offset: 0x000006C7
		public unsafe static Hashtable functionTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_functionTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_functionTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00016918 File Offset: 0x00014B18
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000024D9 File Offset: 0x000006D9
		public unsafe static Hashtable AxesTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_AxesTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_AxesTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_scanner;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_parseDepth;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_temparray1;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_temparray2;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_temparray3;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_temparray4;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_temparray5;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_temparray6;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_temparray7;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_temparray8;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_temparray9;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_functionTable;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_AxesTable;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_XPathScanner_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_ParseXPathExpresion_Public_Static_AstNode_String_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_ParseExpresion_Private_AstNode_AstNode_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_ParseOrExpr_Private_AstNode_AstNode_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_ParseAndExpr_Private_AstNode_AstNode_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_ParseEqualityExpr_Private_AstNode_AstNode_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_ParseRelationalExpr_Private_AstNode_AstNode_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_ParseAdditiveExpr_Private_AstNode_AstNode_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_ParseMultiplicativeExpr_Private_AstNode_AstNode_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnaryExpr_Private_AstNode_AstNode_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnionExpr_Private_AstNode_AstNode_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_IsNodeType_Private_Static_Boolean_XPathScanner_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_ParsePathExpr_Private_AstNode_AstNode_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_ParseFilterExpr_Private_AstNode_AstNode_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_ParsePredicate_Private_AstNode_AstNode_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_ParseLocationPath_Private_AstNode_AstNode_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_ParseRelativeLocationPath_Private_AstNode_AstNode_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_IsStep_Private_Static_Boolean_LexKind_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_ParseStep_Private_AstNode_AstNode_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_ParseNodeTest_Private_AstNode_AstNode_AxisType_XPathNodeType_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimaryExpr_Private_Static_Boolean_XPathScanner_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_ParsePrimaryExpr_Private_AstNode_AstNode_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_ParseMethod_Private_AstNode_AstNode_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_CheckToken_Private_Void_LexKind_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_PassToken_Private_Void_LexKind_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_NextLex_Private_Void_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_TestOp_Private_Boolean_String_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_CheckNodeSet_Private_Void_XPathResultType_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_CreateFunctionTable_Private_Static_Hashtable_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_CreateAxesTable_Private_Static_Hashtable_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis_Private_AxisType_XPathScanner_0;

		// Token: 0x020001F5 RID: 501
		public class ParamInfo : Object
		{
			// Token: 0x06002A17 RID: 10775 RVA: 0x000BF6AC File Offset: 0x000BD8AC
			// Note: this type is marked as 'beforefieldinit'.
			static ParamInfo()
			{
				Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "ParamInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr);
				XPathParser.ParamInfo.NativeFieldInfoPtr_ftype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, "ftype");
				XPathParser.ParamInfo.NativeFieldInfoPtr_minargs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, "minargs");
				XPathParser.ParamInfo.NativeFieldInfoPtr_maxargs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, "maxargs");
				XPathParser.ParamInfo.NativeFieldInfoPtr_argTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, "argTypes");
				XPathParser.ParamInfo.NativeMethodInfoPtr_get_FType_Public_get_FunctionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, 100663375);
				XPathParser.ParamInfo.NativeMethodInfoPtr_get_Minargs_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, 100663376);
				XPathParser.ParamInfo.NativeMethodInfoPtr_get_Maxargs_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, 100663377);
				XPathParser.ParamInfo.NativeMethodInfoPtr_get_ArgTypes_Public_get_Il2CppStructArray_1_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, 100663378);
				XPathParser.ParamInfo.NativeMethodInfoPtr__ctor_Internal_Void_FunctionType_Int32_Int32_Il2CppStructArray_1_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, 100663379);
			}

			// Token: 0x17000E5A RID: 3674
			// (get) Token: 0x06002A18 RID: 10776 RVA: 0x000BF78C File Offset: 0x000BD98C
			public unsafe Function.FunctionType FType
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.ParamInfo.NativeMethodInfoPtr_get_FType_Public_get_FunctionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E5B RID: 3675
			// (get) Token: 0x06002A19 RID: 10777 RVA: 0x000BF7C8 File Offset: 0x000BD9C8
			public unsafe int Minargs
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.ParamInfo.NativeMethodInfoPtr_get_Minargs_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E5C RID: 3676
			// (get) Token: 0x06002A1A RID: 10778 RVA: 0x000BF804 File Offset: 0x000BDA04
			public unsafe int Maxargs
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.ParamInfo.NativeMethodInfoPtr_get_Maxargs_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E5D RID: 3677
			// (get) Token: 0x06002A1B RID: 10779 RVA: 0x000BF840 File Offset: 0x000BDA40
			public unsafe Il2CppStructArray<XPathResultType> ArgTypes
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.ParamInfo.NativeMethodInfoPtr_get_ArgTypes_Public_get_Il2CppStructArray_1_XPathResultType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr3) : null;
				}
			}

			// Token: 0x06002A1C RID: 10780 RVA: 0x000BF880 File Offset: 0x000BDA80
			[CallerCount(0)]
			public unsafe ParamInfo(Function.FunctionType ftype, int minargs, int maxargs, Il2CppStructArray<XPathResultType> argTypes)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ftype;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minargs;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxargs;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argTypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.ParamInfo.NativeMethodInfoPtr__ctor_Internal_Void_FunctionType_Int32_Int32_Il2CppStructArray_1_XPathResultType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A1D RID: 10781 RVA: 0x00011C42 File Offset: 0x0000FE42
			public ParamInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E56 RID: 3670
			// (get) Token: 0x06002A1E RID: 10782 RVA: 0x000BF8F8 File Offset: 0x000BDAF8
			// (set) Token: 0x06002A1F RID: 10783 RVA: 0x00011C4B File Offset: 0x0000FE4B
			public unsafe Function.FunctionType ftype
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.ParamInfo.NativeFieldInfoPtr_ftype);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.ParamInfo.NativeFieldInfoPtr_ftype)) = value;
				}
			}

			// Token: 0x17000E57 RID: 3671
			// (get) Token: 0x06002A20 RID: 10784 RVA: 0x000BF920 File Offset: 0x000BDB20
			// (set) Token: 0x06002A21 RID: 10785 RVA: 0x00011C66 File Offset: 0x0000FE66
			public unsafe int minargs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.ParamInfo.NativeFieldInfoPtr_minargs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.ParamInfo.NativeFieldInfoPtr_minargs)) = value;
				}
			}

			// Token: 0x17000E58 RID: 3672
			// (get) Token: 0x06002A22 RID: 10786 RVA: 0x000BF948 File Offset: 0x000BDB48
			// (set) Token: 0x06002A23 RID: 10787 RVA: 0x00011C81 File Offset: 0x0000FE81
			public unsafe int maxargs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.ParamInfo.NativeFieldInfoPtr_maxargs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.ParamInfo.NativeFieldInfoPtr_maxargs)) = value;
				}
			}

			// Token: 0x17000E59 RID: 3673
			// (get) Token: 0x06002A24 RID: 10788 RVA: 0x000BF970 File Offset: 0x000BDB70
			// (set) Token: 0x06002A25 RID: 10789 RVA: 0x00011C9C File Offset: 0x0000FE9C
			public unsafe Il2CppStructArray<XPathResultType> argTypes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.ParamInfo.NativeFieldInfoPtr_argTypes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.ParamInfo.NativeFieldInfoPtr_argTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FEA RID: 8170
			private static readonly IntPtr NativeFieldInfoPtr_ftype;

			// Token: 0x04001FEB RID: 8171
			private static readonly IntPtr NativeFieldInfoPtr_minargs;

			// Token: 0x04001FEC RID: 8172
			private static readonly IntPtr NativeFieldInfoPtr_maxargs;

			// Token: 0x04001FED RID: 8173
			private static readonly IntPtr NativeFieldInfoPtr_argTypes;

			// Token: 0x04001FEE RID: 8174
			private static readonly IntPtr NativeMethodInfoPtr_get_FType_Public_get_FunctionType_0;

			// Token: 0x04001FEF RID: 8175
			private static readonly IntPtr NativeMethodInfoPtr_get_Minargs_Public_get_Int32_0;

			// Token: 0x04001FF0 RID: 8176
			private static readonly IntPtr NativeMethodInfoPtr_get_Maxargs_Public_get_Int32_0;

			// Token: 0x04001FF1 RID: 8177
			private static readonly IntPtr NativeMethodInfoPtr_get_ArgTypes_Public_get_Il2CppStructArray_1_XPathResultType_0;

			// Token: 0x04001FF2 RID: 8178
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_FunctionType_Int32_Int32_Il2CppStructArray_1_XPathResultType_0;
		}
	}
}
