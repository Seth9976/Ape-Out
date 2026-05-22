using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppRewired
{
	// Token: 0x02000098 RID: 152
	public class ControllerTemplateMap : Object
	{
		// Token: 0x0600118A RID: 4490 RVA: 0x0006EAEC File Offset: 0x0006CCEC
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerTemplateMap()
		{
			Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerTemplateMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr);
			ControllerTemplateMap.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, "SBmxkshsppDFZPZvftqYxbMuemu");
			ControllerTemplateMap.NativeFieldInfoPtr_CbRqAjZxgMVAIemGtzhaFTknHqR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, "CbRqAjZxgMVAIemGtzhaFTknHqR");
			ControllerTemplateMap.NativeFieldInfoPtr_gAHjParQJCfPOgtZnguPbTUKLvQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, "gAHjParQJCfPOgtZnguPbTUKLvQ");
			ControllerTemplateMap.NativeFieldInfoPtr_vNLRRtbTtQWSrFeNJGhWAHRbHrT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, "vNLRRtbTtQWSrFeNJGhWAHRbHrT");
			ControllerTemplateMap.NativeFieldInfoPtr_CJzdYSgcJwptZanyMrTgTorIooPh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, "CJzdYSgcJwptZanyMrTgTorIooPh");
			ControllerTemplateMap.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, "kOIBhhDgDUQCZtioVlUwqEtbkMdb");
			ControllerTemplateMap.NativeFieldInfoPtr_ighjLmmHyvChIzNQwlhTdKVKDLJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, "ighjLmmHyvChIzNQwlhTdKVKDLJ");
			ControllerTemplateMap.NativeFieldInfoPtr_RmIbSKPcjgiNGfzBrafKbycCZNGx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, "RmIbSKPcjgiNGfzBrafKbycCZNGx");
			ControllerTemplateMap.NativeFieldInfoPtr_cQICCKdKRRzMZmpgIYsnjrcCHvVd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, "cQICCKdKRRzMZmpgIYsnjrcCHvVd");
			ControllerTemplateMap.NativeFieldInfoPtr_zKqJBKyxmnStZNprizVDOvVBTKr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, "zKqJBKyxmnStZNprizVDOvVBTKr");
			ControllerTemplateMap.NativeMethodInfoPtr__ctor_Internal_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666169);
			ControllerTemplateMap.NativeMethodInfoPtr__ctor_Internal_Void_Guid_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666170);
			ControllerTemplateMap.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666171);
			ControllerTemplateMap.NativeMethodInfoPtr_get_templateTypeGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666172);
			ControllerTemplateMap.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666173);
			ControllerTemplateMap.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666174);
			ControllerTemplateMap.NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666175);
			ControllerTemplateMap.NativeMethodInfoPtr_set_categoryId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666176);
			ControllerTemplateMap.NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666177);
			ControllerTemplateMap.NativeMethodInfoPtr_set_layoutId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666178);
			ControllerTemplateMap.NativeMethodInfoPtr_get_ElementMaps_Public_get_IList_1_ControllerTemplateActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666179);
			ControllerTemplateMap.NativeMethodInfoPtr_ToXmlString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666180);
			ControllerTemplateMap.NativeMethodInfoPtr_ToJsonString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666181);
			ControllerTemplateMap.NativeMethodInfoPtr_ToControllerMap_Public_ControllerMap_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666182);
			ControllerTemplateMap.NativeMethodInfoPtr_oNyGkjXkFDvVnHlPrDgpKRwoJAQ_Internal_Virtual_New_Void_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666183);
			ControllerTemplateMap.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Internal_Virtual_New_Void_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666184);
			ControllerTemplateMap.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666185);
			ControllerTemplateMap.NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Private_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666186);
			ControllerTemplateMap.NativeMethodInfoPtr_DCtffHijKLZaPrLAwgPZFXWxlNXc_Internal_Void_ControllerTemplateActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666187);
			ControllerTemplateMap.NativeMethodInfoPtr_RNPllbpMQlfiwourhkkCuQfxQtz_Internal_Static_ControllerTemplateMap_IControllerTemplate_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666188);
			ControllerTemplateMap.NativeMethodInfoPtr_FromXml_Public_Static_ControllerTemplateMap_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666189);
			ControllerTemplateMap.NativeMethodInfoPtr_FromJson_Public_Static_ControllerTemplateMap_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666190);
			ControllerTemplateMap.NativeMethodInfoPtr_SganjcIBroLCdQCGTLkdytdcFLJ_Private_Static_ControllerTemplateMap_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr, 100666191);
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0006EDB0 File Offset: 0x0006CFB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 260246, RefRangeEnd = 260250, XrefRangeStart = 260228, XrefRangeEnd = 260246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateMap(Guid templateTypeGuid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref templateTypeGuid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr__ctor_Internal_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0006EDF8 File Offset: 0x0006CFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260250, XrefRangeEnd = 260251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateMap(Guid templateTypeGuid, int categoryId, int layoutId, int sourceMapId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref templateTypeGuid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layoutId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceMapId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr__ctor_Internal_Void_Guid_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x0006EE6C File Offset: 0x0006D06C
		public unsafe int id
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260251, XrefRangeEnd = 260255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x0006EEA8 File Offset: 0x0006D0A8
		public unsafe Guid templateTypeGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260255, XrefRangeEnd = 260266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_get_templateTypeGuid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x0006EEE4 File Offset: 0x0006D0E4
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x0006EF20 File Offset: 0x0006D120
		public unsafe bool enabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260266, XrefRangeEnd = 260270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x0006EF60 File Offset: 0x0006D160
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x0006EF9C File Offset: 0x0006D19C
		public unsafe int categoryId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260270, XrefRangeEnd = 260274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_set_categoryId_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x0006EFDC File Offset: 0x0006D1DC
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x0006F018 File Offset: 0x0006D218
		public unsafe int layoutId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260274, XrefRangeEnd = 260278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_set_layoutId_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x0006F058 File Offset: 0x0006D258
		public unsafe IList<ControllerTemplateActionElementMap> ElementMaps
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260278, XrefRangeEnd = 260283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_get_ElementMaps_Public_get_IList_1_ControllerTemplateActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ControllerTemplateActionElementMap>>(intPtr3) : null;
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x0006F098 File Offset: 0x0006D298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260283, XrefRangeEnd = 260297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToXmlString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_ToXmlString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0006F0D0 File Offset: 0x0006D2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260297, XrefRangeEnd = 260311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToJsonString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_ToJsonString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0006F108 File Offset: 0x0006D308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260311, XrefRangeEnd = 260344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMap ToControllerMap(Controller controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_ToControllerMap_Public_ControllerMap_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr3) : null;
			}
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0006F158 File Offset: 0x0006D358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260344, XrefRangeEnd = 260457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void oNyGkjXkFDvVnHlPrDgpKRwoJAQ(SerializedObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplateMap.NativeMethodInfoPtr_oNyGkjXkFDvVnHlPrDgpKRwoJAQ_Internal_Virtual_New_Void_SerializedObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0006F1A8 File Offset: 0x0006D3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260457, XrefRangeEnd = 260509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void qMMTpeQwXdHPjVTnNgIqFdgetDa(SerializedObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplateMap.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Internal_Virtual_New_Void_SerializedObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0006F1F8 File Offset: 0x0006D3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260509, XrefRangeEnd = 260511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GMFpQqtyJcjzYToWCrZsZQAhPYh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x0006F22C File Offset: 0x0006D42C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 260516, RefRangeEnd = 260518, XrefRangeStart = 260511, XrefRangeEnd = 260516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedObject TUpbRFbZCQXGnqKfXoSpZTimZpRE()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Private_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedObject>(intPtr3) : null;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0006F26C File Offset: 0x0006D46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260518, XrefRangeEnd = 260521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DCtffHijKLZaPrLAwgPZFXWxlNXc(ControllerTemplateActionElementMap A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_DCtffHijKLZaPrLAwgPZFXWxlNXc_Internal_Void_ControllerTemplateActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0006F2B0 File Offset: 0x0006D4B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260579, RefRangeEnd = 260582, XrefRangeStart = 260521, XrefRangeEnd = 260579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerTemplateMap RNPllbpMQlfiwourhkkCuQfxQtz(IControllerTemplate A_0, ControllerMap A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_RNPllbpMQlfiwourhkkCuQfxQtz_Internal_Static_ControllerTemplateMap_IControllerTemplate_ControllerMap_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerTemplateMap>(intPtr3) : null;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0006F308 File Offset: 0x0006D508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260582, XrefRangeEnd = 260600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerTemplateMap FromXml(string xmlString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_FromXml_Public_Static_ControllerTemplateMap_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerTemplateMap>(intPtr3) : null;
			}
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0006F34C File Offset: 0x0006D54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260600, XrefRangeEnd = 260618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerTemplateMap FromJson(string jsonString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(jsonString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_FromJson_Public_Static_ControllerTemplateMap_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerTemplateMap>(intPtr3) : null;
			}
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0006F390 File Offset: 0x0006D590
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 260635, RefRangeEnd = 260637, XrefRangeStart = 260618, XrefRangeEnd = 260635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerTemplateMap SganjcIBroLCdQCGTLkdytdcFLJ(SerializedObject A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateMap.NativeMethodInfoPtr_SganjcIBroLCdQCGTLkdytdcFLJ_Private_Static_ControllerTemplateMap_SerializedObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerTemplateMap>(intPtr3) : null;
			}
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00007C3A File Offset: 0x00005E3A
		public ControllerTemplateMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x0006F3D4 File Offset: 0x0006D5D4
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x00007C43 File Offset: 0x00005E43
		public unsafe int SBmxkshsppDFZPZvftqYxbMuemu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu)) = value;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x0006F3FC File Offset: 0x0006D5FC
		// (set) Token: 0x060011A6 RID: 4518 RVA: 0x00007C5E File Offset: 0x00005E5E
		public unsafe int CbRqAjZxgMVAIemGtzhaFTknHqR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_CbRqAjZxgMVAIemGtzhaFTknHqR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_CbRqAjZxgMVAIemGtzhaFTknHqR)) = value;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x0006F424 File Offset: 0x0006D624
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x00007C79 File Offset: 0x00005E79
		public unsafe Guid gAHjParQJCfPOgtZnguPbTUKLvQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_gAHjParQJCfPOgtZnguPbTUKLvQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_gAHjParQJCfPOgtZnguPbTUKLvQ)) = value;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x0006F44C File Offset: 0x0006D64C
		// (set) Token: 0x060011AA RID: 4522 RVA: 0x00007C94 File Offset: 0x00005E94
		public unsafe List<ControllerTemplateActionElementMap> vNLRRtbTtQWSrFeNJGhWAHRbHrT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_vNLRRtbTtQWSrFeNJGhWAHRbHrT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ControllerTemplateActionElementMap>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_vNLRRtbTtQWSrFeNJGhWAHRbHrT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x0006F47C File Offset: 0x0006D67C
		// (set) Token: 0x060011AC RID: 4524 RVA: 0x00007CB3 File Offset: 0x00005EB3
		public unsafe ReadOnlyCollection<ControllerTemplateActionElementMap> CJzdYSgcJwptZanyMrTgTorIooPh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_CJzdYSgcJwptZanyMrTgTorIooPh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ControllerTemplateActionElementMap>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_CJzdYSgcJwptZanyMrTgTorIooPh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x0006F4AC File Offset: 0x0006D6AC
		// (set) Token: 0x060011AE RID: 4526 RVA: 0x00007CD2 File Offset: 0x00005ED2
		public unsafe bool kOIBhhDgDUQCZtioVlUwqEtbkMdb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb)) = value;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x0006F4D4 File Offset: 0x0006D6D4
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x00007CED File Offset: 0x00005EED
		public unsafe int ighjLmmHyvChIzNQwlhTdKVKDLJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_ighjLmmHyvChIzNQwlhTdKVKDLJ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_ighjLmmHyvChIzNQwlhTdKVKDLJ)) = value;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x0006F4FC File Offset: 0x0006D6FC
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x00007D08 File Offset: 0x00005F08
		public unsafe int RmIbSKPcjgiNGfzBrafKbycCZNGx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_RmIbSKPcjgiNGfzBrafKbycCZNGx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_RmIbSKPcjgiNGfzBrafKbycCZNGx)) = value;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x0006F524 File Offset: 0x0006D724
		// (set) Token: 0x060011B4 RID: 4532 RVA: 0x00007D23 File Offset: 0x00005F23
		public unsafe int cQICCKdKRRzMZmpgIYsnjrcCHvVd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_cQICCKdKRRzMZmpgIYsnjrcCHvVd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateMap.NativeFieldInfoPtr_cQICCKdKRRzMZmpgIYsnjrcCHvVd)) = value;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x0006F54C File Offset: 0x0006D74C
		// (set) Token: 0x060011B6 RID: 4534 RVA: 0x00007D3E File Offset: 0x00005F3E
		public unsafe static int zKqJBKyxmnStZNprizVDOvVBTKr
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ControllerTemplateMap.NativeFieldInfoPtr_zKqJBKyxmnStZNprizVDOvVBTKr, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ControllerTemplateMap.NativeFieldInfoPtr_zKqJBKyxmnStZNprizVDOvVBTKr, (void*)(&value));
			}
		}

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeFieldInfoPtr_CbRqAjZxgMVAIemGtzhaFTknHqR;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeFieldInfoPtr_gAHjParQJCfPOgtZnguPbTUKLvQ;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeFieldInfoPtr_vNLRRtbTtQWSrFeNJGhWAHRbHrT;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeFieldInfoPtr_CJzdYSgcJwptZanyMrTgTorIooPh;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeFieldInfoPtr_ighjLmmHyvChIzNQwlhTdKVKDLJ;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeFieldInfoPtr_RmIbSKPcjgiNGfzBrafKbycCZNGx;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeFieldInfoPtr_cQICCKdKRRzMZmpgIYsnjrcCHvVd;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeFieldInfoPtr_zKqJBKyxmnStZNprizVDOvVBTKr;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Guid_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Guid_Int32_Int32_Int32_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_get_templateTypeGuid_Public_get_Guid_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr_set_categoryId_Internal_set_Void_Int32_0;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_set_layoutId_Internal_set_Void_Int32_0;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementMaps_Public_get_IList_1_ControllerTemplateActionElementMap_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Public_String_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_ToJsonString_Public_String_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_ToControllerMap_Public_ControllerMap_Controller_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_oNyGkjXkFDvVnHlPrDgpKRwoJAQ_Internal_Virtual_New_Void_SerializedObject_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Internal_Virtual_New_Void_SerializedObject_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Private_Void_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Private_SerializedObject_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_DCtffHijKLZaPrLAwgPZFXWxlNXc_Internal_Void_ControllerTemplateActionElementMap_0;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr_RNPllbpMQlfiwourhkkCuQfxQtz_Internal_Static_ControllerTemplateMap_IControllerTemplate_ControllerMap_0;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeMethodInfoPtr_FromXml_Public_Static_ControllerTemplateMap_String_0;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeMethodInfoPtr_FromJson_Public_Static_ControllerTemplateMap_String_0;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeMethodInfoPtr_SganjcIBroLCdQCGTLkdytdcFLJ_Private_Static_ControllerTemplateMap_SerializedObject_0;
	}
}
