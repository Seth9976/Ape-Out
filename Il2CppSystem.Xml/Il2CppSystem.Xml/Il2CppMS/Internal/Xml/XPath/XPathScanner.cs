using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Xml;

namespace Il2CppMS.Internal.Xml.XPath
{
	// Token: 0x0200000F RID: 15
	public sealed class XPathScanner : Object
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x00016940 File Offset: 0x00014B40
		// Note: this type is marked as 'beforefieldinit'.
		static XPathScanner()
		{
			Il2CppClassPointerStore<XPathScanner>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "XPathScanner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr);
			XPathScanner.NativeFieldInfoPtr_xpathExpr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "xpathExpr");
			XPathScanner.NativeFieldInfoPtr_xpathExprIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "xpathExprIndex");
			XPathScanner.NativeFieldInfoPtr_kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "kind");
			XPathScanner.NativeFieldInfoPtr_currentChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "currentChar");
			XPathScanner.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "name");
			XPathScanner.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "prefix");
			XPathScanner.NativeFieldInfoPtr_stringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "stringValue");
			XPathScanner.NativeFieldInfoPtr_numberValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "numberValue");
			XPathScanner.NativeFieldInfoPtr_canBeFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "canBeFunction");
			XPathScanner.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "xmlCharType");
			XPathScanner.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100663380);
			XPathScanner.NativeMethodInfoPtr_get_SourceText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100663381);
			XPathScanner.NativeMethodInfoPtr_get_CurerntChar_Private_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100663382);
			XPathScanner.NativeMethodInfoPtr_NextChar_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100663383);
			XPathScanner.NativeMethodInfoPtr_get_Kind_Public_get_LexKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100663384);
			XPathScanner.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100663385);
			XPathScanner.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100663386);
			XPathScanner.NativeMethodInfoPtr_get_StringValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100663387);
			XPathScanner.NativeMethodInfoPtr_get_NumberValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100663388);
			XPathScanner.NativeMethodInfoPtr_get_CanBeFunction_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100663389);
			XPathScanner.NativeMethodInfoPtr_SkipSpace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100663390);
			XPathScanner.NativeMethodInfoPtr_NextLex_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100663391);
			XPathScanner.NativeMethodInfoPtr_ScanNumber_Private_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100663392);
			XPathScanner.NativeMethodInfoPtr_ScanFraction_Private_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100663393);
			XPathScanner.NativeMethodInfoPtr_ScanString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100663394);
			XPathScanner.NativeMethodInfoPtr_ScanName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100663395);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00016B78 File Offset: 0x00014D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389416, XrefRangeEnd = 389426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathScanner(string xpathExpr)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xpathExpr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00016BC4 File Offset: 0x00014DC4
		public unsafe string SourceText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_get_SourceText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00016BFC File Offset: 0x00014DFC
		public unsafe char CurerntChar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_get_CurerntChar_Private_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00016C38 File Offset: 0x00014E38
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 389426, RefRangeEnd = 389434, XrefRangeStart = 389426, XrefRangeEnd = 389426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_NextChar_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00016C74 File Offset: 0x00014E74
		public unsafe XPathScanner.LexKind Kind
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_get_Kind_Public_get_LexKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00016CB0 File Offset: 0x00014EB0
		public unsafe string Name
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00016CE8 File Offset: 0x00014EE8
		public unsafe string Prefix
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00016D20 File Offset: 0x00014F20
		public unsafe string StringValue
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_get_StringValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00016D58 File Offset: 0x00014F58
		public unsafe double NumberValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_get_NumberValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00016D94 File Offset: 0x00014F94
		public unsafe bool CanBeFunction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_get_CanBeFunction_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00016DD0 File Offset: 0x00014FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389434, XrefRangeEnd = 389435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_SkipSpace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00016E04 File Offset: 0x00015004
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 389442, RefRangeEnd = 389485, XrefRangeStart = 389435, XrefRangeEnd = 389442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NextLex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_NextLex_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00016E40 File Offset: 0x00015040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389485, XrefRangeEnd = 389504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double ScanNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_ScanNumber_Private_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00016E7C File Offset: 0x0001507C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389504, XrefRangeEnd = 389516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double ScanFraction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_ScanFraction_Private_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00016EB8 File Offset: 0x000150B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389516, XrefRangeEnd = 389530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ScanString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_ScanString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00016EF0 File Offset: 0x000150F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389530, XrefRangeEnd = 389536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ScanName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_ScanName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000024EB File Offset: 0x000006EB
		public XPathScanner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00016F28 File Offset: 0x00015128
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x000024F4 File Offset: 0x000006F4
		public unsafe string xpathExpr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_xpathExpr);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_xpathExpr), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00016F50 File Offset: 0x00015150
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002513 File Offset: 0x00000713
		public unsafe int xpathExprIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_xpathExprIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_xpathExprIndex)) = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00016F78 File Offset: 0x00015178
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000252E File Offset: 0x0000072E
		public unsafe XPathScanner.LexKind kind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_kind);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_kind)) = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00016FA0 File Offset: 0x000151A0
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002549 File Offset: 0x00000749
		public unsafe char currentChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_currentChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_currentChar)) = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00016FC8 File Offset: 0x000151C8
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002564 File Offset: 0x00000764
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00016FF0 File Offset: 0x000151F0
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002583 File Offset: 0x00000783
		public unsafe string prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00017018 File Offset: 0x00015218
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000025A2 File Offset: 0x000007A2
		public unsafe string stringValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_stringValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_stringValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00017040 File Offset: 0x00015240
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x000025C1 File Offset: 0x000007C1
		public unsafe double numberValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_numberValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_numberValue)) = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00017068 File Offset: 0x00015268
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x000025DC File Offset: 0x000007DC
		public unsafe bool canBeFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_canBeFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_canBeFunction)) = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00017090 File Offset: 0x00015290
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x000025F7 File Offset: 0x000007F7
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_xpathExpr;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_xpathExprIndex;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_kind;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_currentChar;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_prefix;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_stringValue;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_numberValue;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_canBeFunction;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceText_Public_get_String_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_get_CurerntChar_Private_get_Char_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_NextChar_Private_Boolean_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_get_Kind_Public_get_LexKind_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_get_StringValue_Public_get_String_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberValue_Public_get_Double_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeFunction_Public_get_Boolean_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_SkipSpace_Private_Void_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_NextLex_Public_Boolean_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_ScanNumber_Private_Double_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_ScanFraction_Private_Double_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_ScanString_Private_String_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_ScanName_Private_String_0;

		// Token: 0x020001F6 RID: 502
		[OriginalName("System.Xml.dll", "", "LexKind")]
		public enum LexKind
		{
			// Token: 0x04001FF4 RID: 8180
			Comma = 44,
			// Token: 0x04001FF5 RID: 8181
			Slash = 47,
			// Token: 0x04001FF6 RID: 8182
			At = 64,
			// Token: 0x04001FF7 RID: 8183
			Dot = 46,
			// Token: 0x04001FF8 RID: 8184
			LParens = 40,
			// Token: 0x04001FF9 RID: 8185
			RParens,
			// Token: 0x04001FFA RID: 8186
			LBracket = 91,
			// Token: 0x04001FFB RID: 8187
			RBracket = 93,
			// Token: 0x04001FFC RID: 8188
			Star = 42,
			// Token: 0x04001FFD RID: 8189
			Plus,
			// Token: 0x04001FFE RID: 8190
			Minus = 45,
			// Token: 0x04001FFF RID: 8191
			Eq = 61,
			// Token: 0x04002000 RID: 8192
			Lt = 60,
			// Token: 0x04002001 RID: 8193
			Gt = 62,
			// Token: 0x04002002 RID: 8194
			Bang = 33,
			// Token: 0x04002003 RID: 8195
			Dollar = 36,
			// Token: 0x04002004 RID: 8196
			Apos = 39,
			// Token: 0x04002005 RID: 8197
			Quote = 34,
			// Token: 0x04002006 RID: 8198
			Union = 124,
			// Token: 0x04002007 RID: 8199
			Ne = 78,
			// Token: 0x04002008 RID: 8200
			Le = 76,
			// Token: 0x04002009 RID: 8201
			Ge = 71,
			// Token: 0x0400200A RID: 8202
			And = 65,
			// Token: 0x0400200B RID: 8203
			Or = 79,
			// Token: 0x0400200C RID: 8204
			DotDot = 68,
			// Token: 0x0400200D RID: 8205
			SlashSlash = 83,
			// Token: 0x0400200E RID: 8206
			Name = 110,
			// Token: 0x0400200F RID: 8207
			String = 115,
			// Token: 0x04002010 RID: 8208
			Number = 100,
			// Token: 0x04002011 RID: 8209
			Axe = 97,
			// Token: 0x04002012 RID: 8210
			Eof = 69
		}
	}
}
