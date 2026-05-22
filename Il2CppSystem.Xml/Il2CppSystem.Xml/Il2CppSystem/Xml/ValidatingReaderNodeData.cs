using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000043 RID: 67
	public class ValidatingReaderNodeData : Object
	{
		// Token: 0x06000351 RID: 849 RVA: 0x00021438 File Offset: 0x0001F638
		// Note: this type is marked as 'beforefieldinit'.
		static ValidatingReaderNodeData()
		{
			Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "ValidatingReaderNodeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr);
			ValidatingReaderNodeData.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "localName");
			ValidatingReaderNodeData.NativeFieldInfoPtr_namespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "namespaceUri");
			ValidatingReaderNodeData.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "prefix");
			ValidatingReaderNodeData.NativeFieldInfoPtr_nameWPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "nameWPrefix");
			ValidatingReaderNodeData.NativeFieldInfoPtr_rawValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "rawValue");
			ValidatingReaderNodeData.NativeFieldInfoPtr_originalStringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "originalStringValue");
			ValidatingReaderNodeData.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "depth");
			ValidatingReaderNodeData.NativeFieldInfoPtr_attributePSVIInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "attributePSVIInfo");
			ValidatingReaderNodeData.NativeFieldInfoPtr_nodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "nodeType");
			ValidatingReaderNodeData.NativeFieldInfoPtr_lineNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "lineNo");
			ValidatingReaderNodeData.NativeFieldInfoPtr_linePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "linePos");
			ValidatingReaderNodeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663730);
			ValidatingReaderNodeData.NativeMethodInfoPtr__ctor_Public_Void_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663731);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_LocalName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663732);
			ValidatingReaderNodeData.NativeMethodInfoPtr_set_LocalName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663733);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663734);
			ValidatingReaderNodeData.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663735);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663736);
			ValidatingReaderNodeData.NativeMethodInfoPtr_set_Prefix_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663737);
			ValidatingReaderNodeData.NativeMethodInfoPtr_GetAtomizedNameWPrefix_Public_String_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663738);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_Depth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663739);
			ValidatingReaderNodeData.NativeMethodInfoPtr_set_Depth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663740);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_RawValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663741);
			ValidatingReaderNodeData.NativeMethodInfoPtr_set_RawValue_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663742);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_OriginalStringValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663743);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_NodeType_Public_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663744);
			ValidatingReaderNodeData.NativeMethodInfoPtr_set_NodeType_Public_set_Void_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663745);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_AttInfo_Public_get_AttributePSVIInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663746);
			ValidatingReaderNodeData.NativeMethodInfoPtr_set_AttInfo_Public_set_Void_AttributePSVIInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663747);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663748);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663749);
			ValidatingReaderNodeData.NativeMethodInfoPtr_Clear_Internal_Void_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663750);
			ValidatingReaderNodeData.NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663751);
			ValidatingReaderNodeData.NativeMethodInfoPtr_SetLineInfo_Internal_Void_IXmlLineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663752);
			ValidatingReaderNodeData.NativeMethodInfoPtr_SetItemData_Internal_Void_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663753);
			ValidatingReaderNodeData.NativeMethodInfoPtr_SetItemData_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663754);
			ValidatingReaderNodeData.NativeMethodInfoPtr_SetItemData_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663755);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0002174C File Offset: 0x0001F94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390245, XrefRangeEnd = 390246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidatingReaderNodeData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00021788 File Offset: 0x0001F988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390246, XrefRangeEnd = 390247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidatingReaderNodeData(XmlNodeType nodeType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr__ctor_Public_Void_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000354 RID: 852 RVA: 0x000217D0 File Offset: 0x0001F9D0
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00021808 File Offset: 0x0001FA08
		public unsafe string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_LocalName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_set_LocalName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0002184C File Offset: 0x0001FA4C
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00021884 File Offset: 0x0001FA84
		public unsafe string Namespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000358 RID: 856 RVA: 0x000218C8 File Offset: 0x0001FAC8
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00021900 File Offset: 0x0001FB00
		public unsafe string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_set_Prefix_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00021944 File Offset: 0x0001FB44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 390251, RefRangeEnd = 390254, XrefRangeStart = 390247, XrefRangeEnd = 390251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAtomizedNameWPrefix(XmlNameTable nameTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_GetAtomizedNameWPrefix_Public_String_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0002198C File Offset: 0x0001FB8C
		// (set) Token: 0x0600035C RID: 860 RVA: 0x000219C8 File Offset: 0x0001FBC8
		public unsafe int Depth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_Depth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_set_Depth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00021A08 File Offset: 0x0001FC08
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00021A40 File Offset: 0x0001FC40
		public unsafe string RawValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_RawValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_set_RawValue_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00021A84 File Offset: 0x0001FC84
		public unsafe string OriginalStringValue
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_OriginalStringValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00021ABC File Offset: 0x0001FCBC
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00021AF8 File Offset: 0x0001FCF8
		public unsafe XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_NodeType_Public_get_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_set_NodeType_Public_set_Void_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00021B38 File Offset: 0x0001FD38
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00021B78 File Offset: 0x0001FD78
		public unsafe AttributePSVIInfo AttInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_AttInfo_Public_get_AttributePSVIInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributePSVIInfo>(intPtr3) : null;
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14747, RefRangeEnd = 14763, XrefRangeStart = 14747, XrefRangeEnd = 14763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_set_AttInfo_Public_set_Void_AttributePSVIInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00021BBC File Offset: 0x0001FDBC
		public unsafe int LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00021BF8 File Offset: 0x0001FDF8
		public unsafe int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00021C34 File Offset: 0x0001FE34
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 390260, RefRangeEnd = 390268, XrefRangeStart = 390254, XrefRangeEnd = 390260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(XmlNodeType nodeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_Clear_Internal_Void_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00021C74 File Offset: 0x0001FE74
		[CallerCount(0)]
		public unsafe void SetLineInfo(int lineNo, int linePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineNo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00021CC0 File Offset: 0x0001FEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390268, XrefRangeEnd = 390273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLineInfo(IXmlLineInfo lineInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lineInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_SetLineInfo_Internal_Void_IXmlLineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00021D04 File Offset: 0x0001FF04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 390275, RefRangeEnd = 390278, XrefRangeStart = 390273, XrefRangeEnd = 390275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemData(string localName, string prefix, string ns, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_SetItemData_Internal_Void_String_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00021D78 File Offset: 0x0001FF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390278, XrefRangeEnd = 390279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemData(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_SetItemData_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00021DBC File Offset: 0x0001FFBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 390279, RefRangeEnd = 390282, XrefRangeStart = 390279, XrefRangeEnd = 390279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemData(string value, string originalStringValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalStringValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_SetItemData_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00003347 File Offset: 0x00001547
		public ValidatingReaderNodeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00021E10 File Offset: 0x00020010
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00003350 File Offset: 0x00001550
		public unsafe string localName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_localName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00021E38 File Offset: 0x00020038
		// (set) Token: 0x06000370 RID: 880 RVA: 0x0000336F File Offset: 0x0000156F
		public unsafe string namespaceUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_namespaceUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_namespaceUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00021E60 File Offset: 0x00020060
		// (set) Token: 0x06000372 RID: 882 RVA: 0x0000338E File Offset: 0x0000158E
		public unsafe string prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00021E88 File Offset: 0x00020088
		// (set) Token: 0x06000374 RID: 884 RVA: 0x000033AD File Offset: 0x000015AD
		public unsafe string nameWPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_nameWPrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_nameWPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00021EB0 File Offset: 0x000200B0
		// (set) Token: 0x06000376 RID: 886 RVA: 0x000033CC File Offset: 0x000015CC
		public unsafe string rawValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_rawValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_rawValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00021ED8 File Offset: 0x000200D8
		// (set) Token: 0x06000378 RID: 888 RVA: 0x000033EB File Offset: 0x000015EB
		public unsafe string originalStringValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_originalStringValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_originalStringValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00021F00 File Offset: 0x00020100
		// (set) Token: 0x0600037A RID: 890 RVA: 0x0000340A File Offset: 0x0000160A
		public unsafe int depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_depth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_depth)) = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00021F28 File Offset: 0x00020128
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00003425 File Offset: 0x00001625
		public unsafe AttributePSVIInfo attributePSVIInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_attributePSVIInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributePSVIInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_attributePSVIInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00021F58 File Offset: 0x00020158
		// (set) Token: 0x0600037E RID: 894 RVA: 0x00003444 File Offset: 0x00001644
		public unsafe XmlNodeType nodeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_nodeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_nodeType)) = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00021F80 File Offset: 0x00020180
		// (set) Token: 0x06000380 RID: 896 RVA: 0x0000345F File Offset: 0x0000165F
		public unsafe int lineNo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_lineNo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_lineNo)) = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00021FA8 File Offset: 0x000201A8
		// (set) Token: 0x06000382 RID: 898 RVA: 0x0000347A File Offset: 0x0000167A
		public unsafe int linePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_linePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_linePos)) = value;
			}
		}

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr_localName;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeFieldInfoPtr_namespaceUri;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeFieldInfoPtr_prefix;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeFieldInfoPtr_nameWPrefix;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeFieldInfoPtr_rawValue;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeFieldInfoPtr_originalStringValue;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeFieldInfoPtr_depth;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeFieldInfoPtr_attributePSVIInfo;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeFieldInfoPtr_nodeType;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeFieldInfoPtr_lineNo;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr_linePos;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNodeType_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_get_String_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalName_Public_set_Void_String_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_set_Prefix_Public_set_Void_String_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_GetAtomizedNameWPrefix_Public_String_XmlNameTable_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_get_Depth_Public_get_Int32_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_set_Depth_Public_set_Void_Int32_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_get_RawValue_Public_get_String_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_set_RawValue_Public_set_Void_String_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalStringValue_Public_get_String_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_get_XmlNodeType_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_set_NodeType_Public_set_Void_XmlNodeType_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_get_AttInfo_Public_get_AttributePSVIInfo_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_set_AttInfo_Public_set_Void_AttributePSVIInfo_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_XmlNodeType_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_SetLineInfo_Internal_Void_IXmlLineInfo_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_SetItemData_Internal_Void_String_String_String_Int32_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_SetItemData_Internal_Void_String_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_SetItemData_Internal_Void_String_String_0;
	}
}
