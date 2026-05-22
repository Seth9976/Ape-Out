using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000050 RID: 80
	public class XmlParserContext : Object
	{
		// Token: 0x0600050E RID: 1294 RVA: 0x000294B8 File Offset: 0x000276B8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlParserContext()
		{
			Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlParserContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr);
			XmlParserContext.NativeFieldInfoPtr__nt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_nt");
			XmlParserContext.NativeFieldInfoPtr__nsMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_nsMgr");
			XmlParserContext.NativeFieldInfoPtr__docTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_docTypeName");
			XmlParserContext.NativeFieldInfoPtr__pubId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_pubId");
			XmlParserContext.NativeFieldInfoPtr__sysId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_sysId");
			XmlParserContext.NativeFieldInfoPtr__internalSubset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_internalSubset");
			XmlParserContext.NativeFieldInfoPtr__xmlLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_xmlLang");
			XmlParserContext.NativeFieldInfoPtr__xmlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_xmlSpace");
			XmlParserContext.NativeFieldInfoPtr__baseURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_baseURI");
			XmlParserContext.NativeFieldInfoPtr__encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_encoding");
			XmlParserContext.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664026);
			XmlParserContext.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664027);
			XmlParserContext.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664028);
			XmlParserContext.NativeMethodInfoPtr_get_NamespaceManager_Public_get_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664029);
			XmlParserContext.NativeMethodInfoPtr_get_DocTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664030);
			XmlParserContext.NativeMethodInfoPtr_get_PublicId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664031);
			XmlParserContext.NativeMethodInfoPtr_get_SystemId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664032);
			XmlParserContext.NativeMethodInfoPtr_get_BaseURI_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664033);
			XmlParserContext.NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664034);
			XmlParserContext.NativeMethodInfoPtr_get_XmlLang_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664035);
			XmlParserContext.NativeMethodInfoPtr_get_XmlSpace_Public_get_XmlSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664036);
			XmlParserContext.NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664037);
			XmlParserContext.NativeMethodInfoPtr_get_HasDtdInfo_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664038);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x000296B4 File Offset: 0x000278B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391458, XrefRangeEnd = 391459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsMgr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(docTypeName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pubId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sysId);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseURI);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlLang);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xmlSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00029794 File Offset: 0x00027994
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 391475, RefRangeEnd = 391478, XrefRangeStart = 391459, XrefRangeEnd = 391475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsMgr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(docTypeName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pubId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sysId);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseURI);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlLang);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xmlSpace;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00029888 File Offset: 0x00027A88
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x000298C8 File Offset: 0x00027AC8
		public unsafe XmlNamespaceManager NamespaceManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_NamespaceManager_Public_get_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr3) : null;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00029908 File Offset: 0x00027B08
		public unsafe string DocTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_DocTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00029940 File Offset: 0x00027B40
		public unsafe string PublicId
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_PublicId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00029978 File Offset: 0x00027B78
		public unsafe string SystemId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_SystemId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x000299B0 File Offset: 0x00027BB0
		public unsafe string BaseURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_BaseURI_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x000299E8 File Offset: 0x00027BE8
		public unsafe string InternalSubset
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00029A20 File Offset: 0x00027C20
		public unsafe string XmlLang
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_XmlLang_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00029A58 File Offset: 0x00027C58
		public unsafe XmlSpace XmlSpace
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 93966, RefRangeEnd = 93969, XrefRangeStart = 93966, XrefRangeEnd = 93969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_XmlSpace_Public_get_XmlSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00029A94 File Offset: 0x00027C94
		public unsafe Encoding Encoding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00029AD4 File Offset: 0x00027CD4
		public unsafe bool HasDtdInfo
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 391480, RefRangeEnd = 391484, XrefRangeStart = 391478, XrefRangeEnd = 391480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_HasDtdInfo_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00003BA3 File Offset: 0x00001DA3
		public XmlParserContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00029B10 File Offset: 0x00027D10
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00003BAC File Offset: 0x00001DAC
		public unsafe XmlNameTable _nt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__nt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__nt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00029B40 File Offset: 0x00027D40
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00003BCB File Offset: 0x00001DCB
		public unsafe XmlNamespaceManager _nsMgr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__nsMgr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__nsMgr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00029B70 File Offset: 0x00027D70
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00003BEA File Offset: 0x00001DEA
		public unsafe string _docTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__docTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__docTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00029B98 File Offset: 0x00027D98
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00003C09 File Offset: 0x00001E09
		public unsafe string _pubId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__pubId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__pubId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00029BC0 File Offset: 0x00027DC0
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00003C28 File Offset: 0x00001E28
		public unsafe string _sysId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__sysId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__sysId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00029BE8 File Offset: 0x00027DE8
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00003C47 File Offset: 0x00001E47
		public unsafe string _internalSubset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__internalSubset);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__internalSubset), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00029C10 File Offset: 0x00027E10
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00003C66 File Offset: 0x00001E66
		public unsafe string _xmlLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__xmlLang);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__xmlLang), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00029C38 File Offset: 0x00027E38
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00003C85 File Offset: 0x00001E85
		public unsafe XmlSpace _xmlSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__xmlSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__xmlSpace)) = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00029C60 File Offset: 0x00027E60
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x00003CA0 File Offset: 0x00001EA0
		public unsafe string _baseURI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__baseURI);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__baseURI), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00029C88 File Offset: 0x00027E88
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x00003CBF File Offset: 0x00001EBF
		public unsafe Encoding _encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr__nt;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr__nsMgr;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr__docTypeName;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr__pubId;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr__sysId;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeFieldInfoPtr__internalSubset;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr__xmlLang;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr__xmlSpace;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeFieldInfoPtr__baseURI;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeFieldInfoPtr__encoding;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_Encoding_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceManager_Public_get_XmlNamespaceManager_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_get_DocTypeName_Public_get_String_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicId_Public_get_String_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemId_Public_get_String_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_get_String_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlLang_Public_get_String_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlSpace_Public_get_XmlSpace_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDtdInfo_Internal_get_Boolean_0;
	}
}
