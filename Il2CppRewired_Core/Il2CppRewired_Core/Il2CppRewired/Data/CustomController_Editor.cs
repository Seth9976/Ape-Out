using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Data.Mapping;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppRewired.Data
{
	// Token: 0x0200009F RID: 159
	[Serializable]
	public sealed class CustomController_Editor : global::Il2CppSystem.Object
	{
		// Token: 0x060013C7 RID: 5063 RVA: 0x00076DDC File Offset: 0x00074FDC
		// Note: this type is marked as 'beforefieldinit'.
		static CustomController_Editor()
		{
			Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data", "CustomController_Editor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr);
			CustomController_Editor.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, "_name");
			CustomController_Editor.NativeFieldInfoPtr__descriptiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, "_descriptiveName");
			CustomController_Editor.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, "_id");
			CustomController_Editor.NativeFieldInfoPtr__typeGuidString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, "_typeGuidString");
			CustomController_Editor.NativeFieldInfoPtr__elementIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, "_elementIdentifiers");
			CustomController_Editor.NativeFieldInfoPtr__axes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, "_axes");
			CustomController_Editor.NativeFieldInfoPtr__buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, "_buttons");
			CustomController_Editor.NativeFieldInfoPtr__elementIdentifierIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, "_elementIdentifierIdCounter");
			CustomController_Editor.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666594);
			CustomController_Editor.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666595);
			CustomController_Editor.NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666596);
			CustomController_Editor.NativeMethodInfoPtr_set_descriptiveName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666597);
			CustomController_Editor.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666598);
			CustomController_Editor.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666599);
			CustomController_Editor.NativeMethodInfoPtr_get_typeGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666600);
			CustomController_Editor.NativeMethodInfoPtr_set_typeGuid_Internal_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666601);
			CustomController_Editor.NativeMethodInfoPtr_get_typeGuidString_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666602);
			CustomController_Editor.NativeMethodInfoPtr_set_typeGuidString_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666603);
			CustomController_Editor.NativeMethodInfoPtr_get_elementIdentifiers_Public_get_List_1_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666604);
			CustomController_Editor.NativeMethodInfoPtr_set_elementIdentifiers_Internal_set_Void_List_1_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666605);
			CustomController_Editor.NativeMethodInfoPtr_get_axes_Public_get_List_1_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666606);
			CustomController_Editor.NativeMethodInfoPtr_get_buttons_Public_get_List_1_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666607);
			CustomController_Editor.NativeMethodInfoPtr_get_buttonCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666608);
			CustomController_Editor.NativeMethodInfoPtr_get_axisCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666609);
			CustomController_Editor.NativeMethodInfoPtr_get_ElementIdentifiers_Public_get_IEnumerable_1_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666610);
			CustomController_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666611);
			CustomController_Editor.NativeMethodInfoPtr__ctor_Public_Void_CustomController_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666612);
			CustomController_Editor.NativeMethodInfoPtr_Clone_Public_CustomController_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666613);
			CustomController_Editor.NativeMethodInfoPtr_GetElementIdentifierNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666614);
			CustomController_Editor.NativeMethodInfoPtr_GetElementIdentifierIds_Public_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666615);
			CustomController_Editor.NativeMethodInfoPtr_GetElementIdentifierNamesTypeSorted_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666616);
			CustomController_Editor.NativeMethodInfoPtr_GetElementIdentifierIdsTypeSorted_Public_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666617);
			CustomController_Editor.NativeMethodInfoPtr_GetElementIdentifiersTypeSorted_Public_Il2CppReferenceArray_1_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666618);
			CustomController_Editor.NativeMethodInfoPtr_ContainsElementIdentifier_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666619);
			CustomController_Editor.NativeMethodInfoPtr_IndexOfElementIdentifier_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666620);
			CustomController_Editor.NativeMethodInfoPtr_GetElementIdentifier_Public_ControllerElementIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666621);
			CustomController_Editor.NativeMethodInfoPtr_YBZutuvpvEhZLzyJADroOiOFFljB_Internal_ControllerElementType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666622);
			CustomController_Editor.NativeMethodInfoPtr_MTLcHMfpLnxiOprVuLRiiTySMCxX_Internal_Boolean_Int32_byref_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666623);
			CustomController_Editor.NativeMethodInfoPtr_GetButtonNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666624);
			CustomController_Editor.NativeMethodInfoPtr_GetButtonElementIdentifierIds_Public_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666625);
			CustomController_Editor.NativeMethodInfoPtr_GetAxisNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666626);
			CustomController_Editor.NativeMethodInfoPtr_GetAxisElementIdentifierIds_Public_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666627);
			CustomController_Editor.NativeMethodInfoPtr_GetElementNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666628);
			CustomController_Editor.NativeMethodInfoPtr_GetElementNames_Public_Il2CppStringArray_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666629);
			CustomController_Editor.NativeMethodInfoPtr_GetElementElementIdentifierIds_Public_Il2CppStructArray_1_Int32_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666630);
			CustomController_Editor.NativeMethodInfoPtr_GetElement_Public_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666631);
			CustomController_Editor.NativeMethodInfoPtr_AddElement_Public_Void_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666632);
			CustomController_Editor.NativeMethodInfoPtr_AddAxis_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666633);
			CustomController_Editor.NativeMethodInfoPtr_AddButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666634);
			CustomController_Editor.NativeMethodInfoPtr_InsertElement_Public_Void_ControllerElementType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666635);
			CustomController_Editor.NativeMethodInfoPtr_InsertAxis_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666636);
			CustomController_Editor.NativeMethodInfoPtr_InsertButton_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666637);
			CustomController_Editor.NativeMethodInfoPtr_DeleteElement_Public_Void_ControllerElementType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666638);
			CustomController_Editor.NativeMethodInfoPtr_DeleteElement_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666639);
			CustomController_Editor.NativeMethodInfoPtr_ReorderElement_Public_Boolean_ControllerElementType_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666640);
			CustomController_Editor.NativeMethodInfoPtr_DuplicateElement_Public_Void_ControllerElementType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666641);
			CustomController_Editor.NativeMethodInfoPtr_zeWQIQXHGFOUqHHvsmnzTtVHPUf_Private_Void_Int32_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666642);
			CustomController_Editor.NativeMethodInfoPtr_uWyqlTipkyNhWLHQZWPQihpAOdE_Private_ControllerElementIdentifier_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666643);
			CustomController_Editor.NativeMethodInfoPtr_eJLOKewIqNSmggJRDJZMhWJiOvx_Private_Element_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666644);
			CustomController_Editor.NativeMethodInfoPtr_bOVirPEWpfDKpNWDgKHNBIGtAwx_Private_ControllerElementIdentifier_ControllerElementType_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666645);
			CustomController_Editor.NativeMethodInfoPtr_btFwWIOMqbTqeObDSGaMdRsTTCw_Internal_HardwareControllerMap_Game_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, 100666646);
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x000772D0 File Offset: 0x000754D0
		// (set) Token: 0x060013C9 RID: 5065 RVA: 0x00077308 File Offset: 0x00075508
		public unsafe string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x0007734C File Offset: 0x0007554C
		// (set) Token: 0x060013CB RID: 5067 RVA: 0x00077384 File Offset: 0x00075584
		public unsafe string descriptiveName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_set_descriptiveName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x000773C8 File Offset: 0x000755C8
		// (set) Token: 0x060013CD RID: 5069 RVA: 0x00077404 File Offset: 0x00075604
		public unsafe int id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x00077444 File Offset: 0x00075644
		// (set) Token: 0x060013CF RID: 5071 RVA: 0x00077480 File Offset: 0x00075680
		public unsafe Guid typeGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264417, XrefRangeEnd = 264421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_get_typeGuid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 264424, RefRangeEnd = 264425, XrefRangeStart = 264421, XrefRangeEnd = 264424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_set_typeGuid_Internal_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x000774C0 File Offset: 0x000756C0
		// (set) Token: 0x060013D1 RID: 5073 RVA: 0x000774F8 File Offset: 0x000756F8
		public unsafe string typeGuidString
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_get_typeGuidString_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_set_typeGuidString_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x0007753C File Offset: 0x0007573C
		// (set) Token: 0x060013D3 RID: 5075 RVA: 0x0007757C File Offset: 0x0007577C
		public unsafe List<ControllerElementIdentifier> elementIdentifiers
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_get_elementIdentifiers_Public_get_List_1_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ControllerElementIdentifier>>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_set_elementIdentifiers_Internal_set_Void_List_1_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x000775C0 File Offset: 0x000757C0
		public unsafe List<CustomController_Editor.Axis> axes
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_get_axes_Public_get_List_1_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CustomController_Editor.Axis>>(intPtr3) : null;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x00077600 File Offset: 0x00075800
		public unsafe List<CustomController_Editor.Button> buttons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_get_buttons_Public_get_List_1_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CustomController_Editor.Button>>(intPtr3) : null;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x00077640 File Offset: 0x00075840
		public unsafe int buttonCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 264426, RefRangeEnd = 264427, XrefRangeStart = 264425, XrefRangeEnd = 264426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_get_buttonCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0007767C File Offset: 0x0007587C
		public unsafe int axisCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 264428, RefRangeEnd = 264429, XrefRangeStart = 264427, XrefRangeEnd = 264428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_get_axisCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x000776B8 File Offset: 0x000758B8
		public unsafe IEnumerable<ControllerElementIdentifier> ElementIdentifiers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264429, XrefRangeEnd = 264434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_get_ElementIdentifiers_Public_get_IEnumerable_1_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerElementIdentifier>>(intPtr3) : null;
			}
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x000776F8 File Offset: 0x000758F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264452, RefRangeEnd = 264453, XrefRangeStart = 264434, XrefRangeEnd = 264452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomController_Editor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00077734 File Offset: 0x00075934
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264497, RefRangeEnd = 264499, XrefRangeStart = 264453, XrefRangeEnd = 264497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomController_Editor(CustomController_Editor source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr__ctor_Public_Void_CustomController_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x00077780 File Offset: 0x00075980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264499, XrefRangeEnd = 264503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomController_Editor Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_Clone_Public_CustomController_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomController_Editor>(intPtr3) : null;
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x000777C0 File Offset: 0x000759C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264512, RefRangeEnd = 264513, XrefRangeStart = 264503, XrefRangeEnd = 264512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetElementIdentifierNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_GetElementIdentifierNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x00077800 File Offset: 0x00075A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264513, XrefRangeEnd = 264518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetElementIdentifierIds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_GetElementIdentifierIds_Public_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00077840 File Offset: 0x00075A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264518, XrefRangeEnd = 264550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetElementIdentifierNamesTypeSorted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_GetElementIdentifierNamesTypeSorted_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x00077880 File Offset: 0x00075A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264550, XrefRangeEnd = 264578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetElementIdentifierIdsTypeSorted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_GetElementIdentifierIdsTypeSorted_Public_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x000778C0 File Offset: 0x00075AC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264610, RefRangeEnd = 264611, XrefRangeStart = 264578, XrefRangeEnd = 264610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<ControllerElementIdentifier> GetElementIdentifiersTypeSorted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_GetElementIdentifiersTypeSorted_Public_Il2CppReferenceArray_1_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControllerElementIdentifier>>(intPtr3) : null;
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00077900 File Offset: 0x00075B00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264613, RefRangeEnd = 264615, XrefRangeStart = 264611, XrefRangeEnd = 264613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsElementIdentifier(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_ContainsElementIdentifier_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0007794C File Offset: 0x00075B4C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 264617, RefRangeEnd = 264623, XrefRangeStart = 264615, XrefRangeEnd = 264617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfElementIdentifier(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_IndexOfElementIdentifier_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00077998 File Offset: 0x00075B98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 264625, RefRangeEnd = 264628, XrefRangeStart = 264623, XrefRangeEnd = 264625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementIdentifier GetElementIdentifier(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_GetElementIdentifier_Public_ControllerElementIdentifier_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x000779E4 File Offset: 0x00075BE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264639, RefRangeEnd = 264640, XrefRangeStart = 264628, XrefRangeEnd = 264639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementType YBZutuvpvEhZLzyJADroOiOFFljB(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_YBZutuvpvEhZLzyJADroOiOFFljB_Internal_ControllerElementType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00077A30 File Offset: 0x00075C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264647, RefRangeEnd = 264648, XrefRangeStart = 264640, XrefRangeEnd = 264647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MTLcHMfpLnxiOprVuLRiiTySMCxX(int A_1, out AxisRange A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_MTLcHMfpLnxiOprVuLRiiTySMCxX_Internal_Boolean_Int32_byref_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00077A88 File Offset: 0x00075C88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 264657, RefRangeEnd = 264660, XrefRangeStart = 264648, XrefRangeEnd = 264657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetButtonNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_GetButtonNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00077AC8 File Offset: 0x00075CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264660, XrefRangeEnd = 264665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetButtonElementIdentifierIds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_GetButtonElementIdentifierIds_Public_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00077B08 File Offset: 0x00075D08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264674, RefRangeEnd = 264676, XrefRangeStart = 264665, XrefRangeEnd = 264674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetAxisNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_GetAxisNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00077B48 File Offset: 0x00075D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264676, XrefRangeEnd = 264681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetAxisElementIdentifierIds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_GetAxisElementIdentifierIds_Public_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00077B88 File Offset: 0x00075D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264681, XrefRangeEnd = 264702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetElementNames<T>() where T : CustomController_Editor.Element
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.MethodInfoStoreGeneric_GetElementNames_Public_Il2CppStringArray_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00077BC8 File Offset: 0x00075DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264702, XrefRangeEnd = 264709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetElementNames(ControllerElementType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_GetElementNames_Public_Il2CppStringArray_ControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00077C14 File Offset: 0x00075E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264709, XrefRangeEnd = 264714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetElementElementIdentifierIds(ControllerElementType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_GetElementElementIdentifierIds_Public_Il2CppStructArray_1_Int32_ControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00077C60 File Offset: 0x00075E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264714, XrefRangeEnd = 264741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetElement<T>(int index) where T : CustomController_Editor.Element
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.MethodInfoStoreGeneric_GetElement_Public_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00077CA8 File Offset: 0x00075EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264741, XrefRangeEnd = 264756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddElement(ControllerElementType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_AddElement_Public_Void_ControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00077CE8 File Offset: 0x00075EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264756, XrefRangeEnd = 264764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAxis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_AddAxis_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00077D1C File Offset: 0x00075F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264764, XrefRangeEnd = 264772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_AddButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00077D50 File Offset: 0x00075F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264772, XrefRangeEnd = 264801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertElement(ControllerElementType type, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_InsertElement_Public_Void_ControllerElementType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00077D9C File Offset: 0x00075F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264801, XrefRangeEnd = 264816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertAxis(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_InsertAxis_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00077DDC File Offset: 0x00075FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264816, XrefRangeEnd = 264831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertButton(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_InsertButton_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00077E1C File Offset: 0x0007601C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264831, XrefRangeEnd = 264842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteElement(ControllerElementType type, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_DeleteElement_Public_Void_ControllerElementType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00077E68 File Offset: 0x00076068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264880, RefRangeEnd = 264881, XrefRangeStart = 264842, XrefRangeEnd = 264880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteElement<T>(int index) where T : CustomController_Editor.Element
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.MethodInfoStoreGeneric_DeleteElement_Public_Void_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00077EA8 File Offset: 0x000760A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264881, XrefRangeEnd = 264890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReorderElement(ControllerElementType type, int index, bool offsetDown, bool offsetNow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetDown;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetNow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_ReorderElement_Public_Boolean_ControllerElementType_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00077F1C File Offset: 0x0007611C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264890, XrefRangeEnd = 264901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DuplicateElement(ControllerElementType type, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_DuplicateElement_Public_Void_ControllerElementType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00077F68 File Offset: 0x00076168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264910, RefRangeEnd = 264911, XrefRangeStart = 264901, XrefRangeEnd = 264910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void zeWQIQXHGFOUqHHvsmnzTtVHPUf<T>(int A_1, List<T> A_2) where T : CustomController_Editor.Element
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.MethodInfoStoreGeneric_zeWQIQXHGFOUqHHvsmnzTtVHPUf_Private_Void_Int32_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00077FB8 File Offset: 0x000761B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264926, RefRangeEnd = 264927, XrefRangeStart = 264911, XrefRangeEnd = 264926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementIdentifier uWyqlTipkyNhWLHQZWPQihpAOdE(int A_1, string A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_uWyqlTipkyNhWLHQZWPQihpAOdE_Private_ControllerElementIdentifier_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr3) : null;
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00078018 File Offset: 0x00076218
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 264942, RefRangeEnd = 264950, XrefRangeStart = 264927, XrefRangeEnd = 264942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomController_Editor.Element eJLOKewIqNSmggJRDJZMhWJiOvx(ControllerElementType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_eJLOKewIqNSmggJRDJZMhWJiOvx_Private_Element_ControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomController_Editor.Element>(intPtr3) : null;
			}
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00078064 File Offset: 0x00076264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264957, RefRangeEnd = 264958, XrefRangeStart = 264950, XrefRangeEnd = 264957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementIdentifier bOVirPEWpfDKpNWDgKHNBIGtAwx(ControllerElementType A_1, string A_2, string A_3, string A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_3);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_4);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_bOVirPEWpfDKpNWDgKHNBIGtAwx_Private_ControllerElementIdentifier_ControllerElementType_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr3) : null;
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x000780E8 File Offset: 0x000762E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 265008, RefRangeEnd = 265011, XrefRangeStart = 264958, XrefRangeEnd = 265008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareControllerMap_Game btFwWIOMqbTqeObDSGaMdRsTTCw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.NativeMethodInfoPtr_btFwWIOMqbTqeObDSGaMdRsTTCw_Internal_HardwareControllerMap_Game_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareControllerMap_Game>(intPtr3) : null;
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00008AE4 File Offset: 0x00006CE4
		public CustomController_Editor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x00078128 File Offset: 0x00076328
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x00008AED File Offset: 0x00006CED
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x00078150 File Offset: 0x00076350
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x00008B0C File Offset: 0x00006D0C
		public unsafe string _descriptiveName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.NativeFieldInfoPtr__descriptiveName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.NativeFieldInfoPtr__descriptiveName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x00078178 File Offset: 0x00076378
		// (set) Token: 0x06001403 RID: 5123 RVA: 0x00008B2B File Offset: 0x00006D2B
		public unsafe int _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x000781A0 File Offset: 0x000763A0
		// (set) Token: 0x06001405 RID: 5125 RVA: 0x00008B46 File Offset: 0x00006D46
		public unsafe string _typeGuidString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.NativeFieldInfoPtr__typeGuidString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.NativeFieldInfoPtr__typeGuidString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x000781C8 File Offset: 0x000763C8
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x00008B65 File Offset: 0x00006D65
		public unsafe List<ControllerElementIdentifier> _elementIdentifiers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.NativeFieldInfoPtr__elementIdentifiers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ControllerElementIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.NativeFieldInfoPtr__elementIdentifiers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x000781F8 File Offset: 0x000763F8
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x00008B84 File Offset: 0x00006D84
		public unsafe List<CustomController_Editor.Axis> _axes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.NativeFieldInfoPtr__axes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CustomController_Editor.Axis>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.NativeFieldInfoPtr__axes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x00078228 File Offset: 0x00076428
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x00008BA3 File Offset: 0x00006DA3
		public unsafe List<CustomController_Editor.Button> _buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.NativeFieldInfoPtr__buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CustomController_Editor.Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.NativeFieldInfoPtr__buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x00078258 File Offset: 0x00076458
		// (set) Token: 0x0600140D RID: 5133 RVA: 0x00008BC2 File Offset: 0x00006DC2
		public unsafe int _elementIdentifierIdCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.NativeFieldInfoPtr__elementIdentifierIdCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.NativeFieldInfoPtr__elementIdentifierIdCounter)) = value;
			}
		}

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeFieldInfoPtr__descriptiveName;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeFieldInfoPtr__typeGuidString;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeFieldInfoPtr__elementIdentifiers;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeFieldInfoPtr__axes;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeFieldInfoPtr__buttons;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeFieldInfoPtr__elementIdentifierIdCounter;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Internal_set_Void_String_0;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0;

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeMethodInfoPtr_set_descriptiveName_Internal_set_Void_String_0;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0;

		// Token: 0x04001005 RID: 4101
		private static readonly IntPtr NativeMethodInfoPtr_get_typeGuid_Public_get_Guid_0;

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeMethodInfoPtr_set_typeGuid_Internal_set_Void_Guid_0;

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeMethodInfoPtr_get_typeGuidString_Internal_get_String_0;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeMethodInfoPtr_set_typeGuidString_Internal_set_Void_String_0;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeMethodInfoPtr_get_elementIdentifiers_Public_get_List_1_ControllerElementIdentifier_0;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeMethodInfoPtr_set_elementIdentifiers_Internal_set_Void_List_1_ControllerElementIdentifier_0;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeMethodInfoPtr_get_axes_Public_get_List_1_Axis_0;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeMethodInfoPtr_get_buttons_Public_get_List_1_Button_0;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonCount_Public_get_Int32_0;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeMethodInfoPtr_get_axisCount_Public_get_Int32_0;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementIdentifiers_Public_get_IEnumerable_1_ControllerElementIdentifier_0;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CustomController_Editor_0;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_CustomController_Editor_0;

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierNames_Public_Il2CppStringArray_0;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierIds_Public_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierNamesTypeSorted_Public_Il2CppStringArray_0;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierIdsTypeSorted_Public_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifiersTypeSorted_Public_Il2CppReferenceArray_1_ControllerElementIdentifier_0;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeMethodInfoPtr_ContainsElementIdentifier_Public_Boolean_Int32_0;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfElementIdentifier_Public_Int32_Int32_0;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifier_Public_ControllerElementIdentifier_Int32_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_YBZutuvpvEhZLzyJADroOiOFFljB_Internal_ControllerElementType_Int32_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_MTLcHMfpLnxiOprVuLRiiTySMCxX_Internal_Boolean_Int32_byref_AxisRange_0;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonNames_Public_Il2CppStringArray_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonElementIdentifierIds_Public_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisNames_Public_Il2CppStringArray_0;

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisElementIdentifierIds_Public_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeMethodInfoPtr_GetElementNames_Public_Il2CppStringArray_0;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeMethodInfoPtr_GetElementNames_Public_Il2CppStringArray_ControllerElementType_0;

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeMethodInfoPtr_GetElementElementIdentifierIds_Public_Il2CppStructArray_1_Int32_ControllerElementType_0;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_T_Int32_0;

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeMethodInfoPtr_AddElement_Public_Void_ControllerElementType_0;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeMethodInfoPtr_AddAxis_Public_Void_0;

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeMethodInfoPtr_AddButton_Public_Void_0;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeMethodInfoPtr_InsertElement_Public_Void_ControllerElementType_Int32_0;

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeMethodInfoPtr_InsertAxis_Public_Void_Int32_0;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeMethodInfoPtr_InsertButton_Public_Void_Int32_0;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeMethodInfoPtr_DeleteElement_Public_Void_ControllerElementType_Int32_0;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeMethodInfoPtr_DeleteElement_Public_Void_Int32_0;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeMethodInfoPtr_ReorderElement_Public_Boolean_ControllerElementType_Int32_Boolean_Boolean_0;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateElement_Public_Void_ControllerElementType_Int32_0;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeMethodInfoPtr_zeWQIQXHGFOUqHHvsmnzTtVHPUf_Private_Void_Int32_List_1_T_0;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr_uWyqlTipkyNhWLHQZWPQihpAOdE_Private_ControllerElementIdentifier_Int32_String_0;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr_eJLOKewIqNSmggJRDJZMhWJiOvx_Private_Element_ControllerElementType_0;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeMethodInfoPtr_bOVirPEWpfDKpNWDgKHNBIGtAwx_Private_ControllerElementIdentifier_ControllerElementType_String_String_String_0;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeMethodInfoPtr_btFwWIOMqbTqeObDSGaMdRsTTCw_Internal_HardwareControllerMap_Game_0;

		// Token: 0x020002C4 RID: 708
		[Serializable]
		public class Element : global::Il2CppSystem.Object
		{
			// Token: 0x06003DF7 RID: 15863 RVA: 0x00125E68 File Offset: 0x00124068
			// Note: this type is marked as 'beforefieldinit'.
			static Element()
			{
				Il2CppClassPointerStore<CustomController_Editor.Element>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, "Element");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomController_Editor.Element>.NativeClassPtr);
				CustomController_Editor.Element.NativeFieldInfoPtr_elementIdentifierId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.Element>.NativeClassPtr, "elementIdentifierId");
				CustomController_Editor.Element.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.Element>.NativeClassPtr, "name");
				CustomController_Editor.Element.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.Element>.NativeClassPtr, 100666647);
				CustomController_Editor.Element.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.Element>.NativeClassPtr, 100666648);
				CustomController_Editor.Element.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.Element>.NativeClassPtr, 100666649);
			}

			// Token: 0x06003DF8 RID: 15864 RVA: 0x00125EF8 File Offset: 0x001240F8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Element()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController_Editor.Element>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.Element.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003DF9 RID: 15865 RVA: 0x00125F34 File Offset: 0x00124134
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 19461, RefRangeEnd = 19470, XrefRangeStart = 19461, XrefRangeEnd = 19470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Element(string name, int elementIdentifierId)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController_Editor.Element>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.Element.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003DFA RID: 15866 RVA: 0x00125F90 File Offset: 0x00124190
			[CallerCount(0)]
			public unsafe virtual CustomController_Editor.Element Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomController_Editor.Element.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Element_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomController_Editor.Element>(intPtr3) : null;
			}

			// Token: 0x06003DFB RID: 15867 RVA: 0x000163CB File Offset: 0x000145CB
			public Element(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700130B RID: 4875
			// (get) Token: 0x06003DFC RID: 15868 RVA: 0x00125FDC File Offset: 0x001241DC
			// (set) Token: 0x06003DFD RID: 15869 RVA: 0x000163D4 File Offset: 0x000145D4
			public unsafe int elementIdentifierId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Element.NativeFieldInfoPtr_elementIdentifierId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Element.NativeFieldInfoPtr_elementIdentifierId)) = value;
				}
			}

			// Token: 0x1700130C RID: 4876
			// (get) Token: 0x06003DFE RID: 15870 RVA: 0x00126004 File Offset: 0x00124204
			// (set) Token: 0x06003DFF RID: 15871 RVA: 0x000163EF File Offset: 0x000145EF
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Element.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Element.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400334F RID: 13135
			private static readonly IntPtr NativeFieldInfoPtr_elementIdentifierId;

			// Token: 0x04003350 RID: 13136
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04003351 RID: 13137
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003352 RID: 13138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

			// Token: 0x04003353 RID: 13139
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Element_0;
		}

		// Token: 0x020002C5 RID: 709
		[Serializable]
		public sealed class Button : CustomController_Editor.Element
		{
			// Token: 0x06003E00 RID: 15872 RVA: 0x0012602C File Offset: 0x0012422C
			// Note: this type is marked as 'beforefieldinit'.
			static Button()
			{
				Il2CppClassPointerStore<CustomController_Editor.Button>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, "Button");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomController_Editor.Button>.NativeClassPtr);
				CustomController_Editor.Button.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.Button>.NativeClassPtr, 100666650);
				CustomController_Editor.Button.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.Button>.NativeClassPtr, 100666651);
				CustomController_Editor.Button.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.Button>.NativeClassPtr, 100666652);
				CustomController_Editor.Button.NativeMethodInfoPtr__ctor_Public_Void_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.Button>.NativeClassPtr, 100666653);
				CustomController_Editor.Button.NativeMethodInfoPtr_Clone_Public_Virtual_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.Button>.NativeClassPtr, 100666654);
			}

			// Token: 0x06003E01 RID: 15873 RVA: 0x001260BC File Offset: 0x001242BC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Button()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController_Editor.Button>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.Button.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E02 RID: 15874 RVA: 0x001260F8 File Offset: 0x001242F8
			[CallerCount(0)]
			public unsafe Button(string name)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController_Editor.Button>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.Button.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E03 RID: 15875 RVA: 0x00126144 File Offset: 0x00124344
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 19461, RefRangeEnd = 19470, XrefRangeStart = 19461, XrefRangeEnd = 19470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Button(string name, int elementIdentifierId)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController_Editor.Button>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.Button.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E04 RID: 15876 RVA: 0x001261A0 File Offset: 0x001243A0
			[CallerCount(0)]
			public unsafe Button(CustomController_Editor.Button source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController_Editor.Button>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.Button.NativeMethodInfoPtr__ctor_Public_Void_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E05 RID: 15877 RVA: 0x001261EC File Offset: 0x001243EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264357, XrefRangeEnd = 264360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override CustomController_Editor.Element Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.Button.NativeMethodInfoPtr_Clone_Public_Virtual_Element_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomController_Editor.Element>(intPtr3) : null;
			}

			// Token: 0x06003E06 RID: 15878 RVA: 0x0001640E File Offset: 0x0001460E
			public Button(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003354 RID: 13140
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003355 RID: 13141
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x04003356 RID: 13142
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

			// Token: 0x04003357 RID: 13143
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Button_0;

			// Token: 0x04003358 RID: 13144
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Element_0;
		}

		// Token: 0x020002C6 RID: 710
		[Serializable]
		public sealed class Axis : CustomController_Editor.Element
		{
			// Token: 0x06003E07 RID: 15879 RVA: 0x0012622C File Offset: 0x0012442C
			// Note: this type is marked as 'beforefieldinit'.
			static Axis()
			{
				Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, "Axis");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr);
				CustomController_Editor.Axis.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr, "range");
				CustomController_Editor.Axis.NativeFieldInfoPtr_invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr, "invert");
				CustomController_Editor.Axis.NativeFieldInfoPtr_deadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr, "deadZone");
				CustomController_Editor.Axis.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr, "zero");
				CustomController_Editor.Axis.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr, "min");
				CustomController_Editor.Axis.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr, "max");
				CustomController_Editor.Axis.NativeFieldInfoPtr_doNotCalibrateRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr, "doNotCalibrateRange");
				CustomController_Editor.Axis.NativeFieldInfoPtr_sensitivityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr, "sensitivityType");
				CustomController_Editor.Axis.NativeFieldInfoPtr_sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr, "sensitivity");
				CustomController_Editor.Axis.NativeFieldInfoPtr_sensitivityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr, "sensitivityCurve");
				CustomController_Editor.Axis.NativeFieldInfoPtr_axisInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr, "axisInfo");
				CustomController_Editor.Axis.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr, 100666655);
				CustomController_Editor.Axis.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr, 100666656);
				CustomController_Editor.Axis.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_AxisRange_Boolean_Single_Single_Single_Single_Boolean_HardwareAxisInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr, 100666657);
				CustomController_Editor.Axis.NativeMethodInfoPtr__ctor_Public_Void_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr, 100666658);
				CustomController_Editor.Axis.NativeMethodInfoPtr_Clone_Public_Virtual_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr, 100666659);
			}

			// Token: 0x06003E08 RID: 15880 RVA: 0x00126398 File Offset: 0x00124598
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264360, XrefRangeEnd = 264363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Axis()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.Axis.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E09 RID: 15881 RVA: 0x001263D4 File Offset: 0x001245D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264363, XrefRangeEnd = 264370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Axis(string name)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.Axis.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E0A RID: 15882 RVA: 0x00126420 File Offset: 0x00124620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264370, XrefRangeEnd = 264383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Axis(string name, string positiveName, string negativeName, int elementIdentifierId, AxisRange range, bool invert, float deadZone, float zero, float min, float max, bool doNotCalibrateRange, HardwareAxisInfo axisInfo)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(positiveName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(negativeName);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref range;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deadZone;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zero;
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doNotCalibrateRange;
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.Axis.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_AxisRange_Boolean_Single_Single_Single_Single_Boolean_HardwareAxisInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E0B RID: 15883 RVA: 0x00126518 File Offset: 0x00124718
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 264399, RefRangeEnd = 264400, XrefRangeStart = 264383, XrefRangeEnd = 264399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Axis(CustomController_Editor.Axis source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController_Editor.Axis>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.Axis.NativeMethodInfoPtr__ctor_Public_Void_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E0C RID: 15884 RVA: 0x00126564 File Offset: 0x00124764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264400, XrefRangeEnd = 264404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override CustomController_Editor.Element Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.Axis.NativeMethodInfoPtr_Clone_Public_Virtual_Element_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomController_Editor.Element>(intPtr3) : null;
			}

			// Token: 0x06003E0D RID: 15885 RVA: 0x00016417 File Offset: 0x00014617
			public Axis(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700130D RID: 4877
			// (get) Token: 0x06003E0E RID: 15886 RVA: 0x001265A4 File Offset: 0x001247A4
			// (set) Token: 0x06003E0F RID: 15887 RVA: 0x00016420 File Offset: 0x00014620
			public unsafe AxisRange range
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_range);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_range)) = value;
				}
			}

			// Token: 0x1700130E RID: 4878
			// (get) Token: 0x06003E10 RID: 15888 RVA: 0x001265CC File Offset: 0x001247CC
			// (set) Token: 0x06003E11 RID: 15889 RVA: 0x0001643B File Offset: 0x0001463B
			public unsafe bool invert
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_invert);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_invert)) = value;
				}
			}

			// Token: 0x1700130F RID: 4879
			// (get) Token: 0x06003E12 RID: 15890 RVA: 0x001265F4 File Offset: 0x001247F4
			// (set) Token: 0x06003E13 RID: 15891 RVA: 0x00016456 File Offset: 0x00014656
			public unsafe float deadZone
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_deadZone);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_deadZone)) = value;
				}
			}

			// Token: 0x17001310 RID: 4880
			// (get) Token: 0x06003E14 RID: 15892 RVA: 0x0012661C File Offset: 0x0012481C
			// (set) Token: 0x06003E15 RID: 15893 RVA: 0x00016471 File Offset: 0x00014671
			public unsafe float zero
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_zero);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_zero)) = value;
				}
			}

			// Token: 0x17001311 RID: 4881
			// (get) Token: 0x06003E16 RID: 15894 RVA: 0x00126644 File Offset: 0x00124844
			// (set) Token: 0x06003E17 RID: 15895 RVA: 0x0001648C File Offset: 0x0001468C
			public unsafe float min
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_min);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_min)) = value;
				}
			}

			// Token: 0x17001312 RID: 4882
			// (get) Token: 0x06003E18 RID: 15896 RVA: 0x0012666C File Offset: 0x0012486C
			// (set) Token: 0x06003E19 RID: 15897 RVA: 0x000164A7 File Offset: 0x000146A7
			public unsafe float max
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_max);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_max)) = value;
				}
			}

			// Token: 0x17001313 RID: 4883
			// (get) Token: 0x06003E1A RID: 15898 RVA: 0x00126694 File Offset: 0x00124894
			// (set) Token: 0x06003E1B RID: 15899 RVA: 0x000164C2 File Offset: 0x000146C2
			public unsafe bool doNotCalibrateRange
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_doNotCalibrateRange);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_doNotCalibrateRange)) = value;
				}
			}

			// Token: 0x17001314 RID: 4884
			// (get) Token: 0x06003E1C RID: 15900 RVA: 0x001266BC File Offset: 0x001248BC
			// (set) Token: 0x06003E1D RID: 15901 RVA: 0x000164DD File Offset: 0x000146DD
			public unsafe AxisSensitivityType sensitivityType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_sensitivityType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_sensitivityType)) = value;
				}
			}

			// Token: 0x17001315 RID: 4885
			// (get) Token: 0x06003E1E RID: 15902 RVA: 0x001266E4 File Offset: 0x001248E4
			// (set) Token: 0x06003E1F RID: 15903 RVA: 0x000164F8 File Offset: 0x000146F8
			public unsafe float sensitivity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_sensitivity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_sensitivity)) = value;
				}
			}

			// Token: 0x17001316 RID: 4886
			// (get) Token: 0x06003E20 RID: 15904 RVA: 0x0012670C File Offset: 0x0012490C
			// (set) Token: 0x06003E21 RID: 15905 RVA: 0x00016513 File Offset: 0x00014713
			public unsafe AnimationCurve sensitivityCurve
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_sensitivityCurve);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_sensitivityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001317 RID: 4887
			// (get) Token: 0x06003E22 RID: 15906 RVA: 0x0012673C File Offset: 0x0012493C
			// (set) Token: 0x06003E23 RID: 15907 RVA: 0x00016532 File Offset: 0x00014732
			public unsafe HardwareAxisInfo axisInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_axisInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HardwareAxisInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.Axis.NativeFieldInfoPtr_axisInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003359 RID: 13145
			private static readonly IntPtr NativeFieldInfoPtr_range;

			// Token: 0x0400335A RID: 13146
			private static readonly IntPtr NativeFieldInfoPtr_invert;

			// Token: 0x0400335B RID: 13147
			private static readonly IntPtr NativeFieldInfoPtr_deadZone;

			// Token: 0x0400335C RID: 13148
			private static readonly IntPtr NativeFieldInfoPtr_zero;

			// Token: 0x0400335D RID: 13149
			private static readonly IntPtr NativeFieldInfoPtr_min;

			// Token: 0x0400335E RID: 13150
			private static readonly IntPtr NativeFieldInfoPtr_max;

			// Token: 0x0400335F RID: 13151
			private static readonly IntPtr NativeFieldInfoPtr_doNotCalibrateRange;

			// Token: 0x04003360 RID: 13152
			private static readonly IntPtr NativeFieldInfoPtr_sensitivityType;

			// Token: 0x04003361 RID: 13153
			private static readonly IntPtr NativeFieldInfoPtr_sensitivity;

			// Token: 0x04003362 RID: 13154
			private static readonly IntPtr NativeFieldInfoPtr_sensitivityCurve;

			// Token: 0x04003363 RID: 13155
			private static readonly IntPtr NativeFieldInfoPtr_axisInfo;

			// Token: 0x04003364 RID: 13156
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003365 RID: 13157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x04003366 RID: 13158
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_AxisRange_Boolean_Single_Single_Single_Single_Boolean_HardwareAxisInfo_0;

			// Token: 0x04003367 RID: 13159
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Axis_0;

			// Token: 0x04003368 RID: 13160
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Element_0;
		}

		// Token: 0x020002C7 RID: 711
		public sealed class BVukVTHBfHVTkKgnkOWZKlVXNTx : global::Il2CppSystem.Object
		{
			// Token: 0x06003E24 RID: 15908 RVA: 0x0012676C File Offset: 0x0012496C
			// Note: this type is marked as 'beforefieldinit'.
			static BVukVTHBfHVTkKgnkOWZKlVXNTx()
			{
				Il2CppClassPointerStore<CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr, "BVukVTHBfHVTkKgnkOWZKlVXNTx");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx>.NativeClassPtr);
				CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx>.NativeClassPtr, "kUBcJcFfgoKKiApkBmiZbFhcTlkZ");
				CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerElementIdentifier__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx>.NativeClassPtr, 100666660);
				CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx>.NativeClassPtr, 100666661);
				CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx>.NativeClassPtr, 100666662);
				CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerElementIdentifier__get_Current_Private_Virtual_Final_New_get_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx>.NativeClassPtr, 100666663);
				CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx>.NativeClassPtr, 100666664);
				CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx>.NativeClassPtr, 100666665);
				CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx>.NativeClassPtr, 100666666);
				CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx>.NativeClassPtr, 100666667);
			}

			// Token: 0x06003E25 RID: 15909 RVA: 0x0012689C File Offset: 0x00124A9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264404, XrefRangeEnd = 264407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ControllerElementIdentifier> System_Collections_Generic_IEnumerable_Rewired_ControllerElementIdentifier__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerElementIdentifier__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ControllerElementIdentifier>>(intPtr3) : null;
			}

			// Token: 0x06003E26 RID: 15910 RVA: 0x001268DC File Offset: 0x00124ADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003E27 RID: 15911 RVA: 0x0012691C File Offset: 0x00124B1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264407, XrefRangeEnd = 264410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700131D RID: 4893
			// (get) Token: 0x06003E28 RID: 15912 RVA: 0x00126958 File Offset: 0x00124B58
			public unsafe ControllerElementIdentifier zXOigVuXfNCUtZjhJmEMpYGFGwZ
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerElementIdentifier__get_Current_Private_Virtual_Final_New_get_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr3) : null;
				}
			}

			// Token: 0x06003E29 RID: 15913 RVA: 0x00126998 File Offset: 0x00124B98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264410, XrefRangeEnd = 264415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E2A RID: 15914 RVA: 0x001269CC File Offset: 0x00124BCC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700131E RID: 4894
			// (get) Token: 0x06003E2B RID: 15915 RVA: 0x00126A00 File Offset: 0x00124C00
			public unsafe global::Il2CppSystem.Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003E2C RID: 15916 RVA: 0x00126A40 File Offset: 0x00124C40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264415, XrefRangeEnd = 264417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BVukVTHBfHVTkKgnkOWZKlVXNTx(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E2D RID: 15917 RVA: 0x00016551 File Offset: 0x00014751
			public BVukVTHBfHVTkKgnkOWZKlVXNTx(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001318 RID: 4888
			// (get) Token: 0x06003E2E RID: 15918 RVA: 0x00126A88 File Offset: 0x00124C88
			// (set) Token: 0x06003E2F RID: 15919 RVA: 0x0001655A File Offset: 0x0001475A
			public unsafe ControllerElementIdentifier NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001319 RID: 4889
			// (get) Token: 0x06003E30 RID: 15920 RVA: 0x00126AB8 File Offset: 0x00124CB8
			// (set) Token: 0x06003E31 RID: 15921 RVA: 0x00016579 File Offset: 0x00014779
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x1700131A RID: 4890
			// (get) Token: 0x06003E32 RID: 15922 RVA: 0x00126AE0 File Offset: 0x00124CE0
			// (set) Token: 0x06003E33 RID: 15923 RVA: 0x00016594 File Offset: 0x00014794
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x1700131B RID: 4891
			// (get) Token: 0x06003E34 RID: 15924 RVA: 0x00126B08 File Offset: 0x00124D08
			// (set) Token: 0x06003E35 RID: 15925 RVA: 0x000165AF File Offset: 0x000147AF
			public unsafe CustomController_Editor HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomController_Editor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700131C RID: 4892
			// (get) Token: 0x06003E36 RID: 15926 RVA: 0x00126B38 File Offset: 0x00124D38
			// (set) Token: 0x06003E37 RID: 15927 RVA: 0x000165CE File Offset: 0x000147CE
			public unsafe int kUBcJcFfgoKKiApkBmiZbFhcTlkZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomController_Editor.BVukVTHBfHVTkKgnkOWZKlVXNTx.NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ)) = value;
				}
			}

			// Token: 0x04003369 RID: 13161
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x0400336A RID: 13162
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x0400336B RID: 13163
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x0400336C RID: 13164
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x0400336D RID: 13165
			private static readonly IntPtr NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ;

			// Token: 0x0400336E RID: 13166
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerElementIdentifier__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerElementIdentifier_0;

			// Token: 0x0400336F RID: 13167
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04003370 RID: 13168
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003371 RID: 13169
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerElementIdentifier__get_Current_Private_Virtual_Final_New_get_ControllerElementIdentifier_0;

			// Token: 0x04003372 RID: 13170
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003373 RID: 13171
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003374 RID: 13172
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003375 RID: 13173
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}

		// Token: 0x020002C8 RID: 712
		private sealed class MethodInfoStoreGeneric_GetElementNames_Public_Il2CppStringArray_0<T>
		{
			// Token: 0x04003376 RID: 13174
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomController_Editor.NativeMethodInfoPtr_GetElementNames_Public_Il2CppStringArray_0, Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002C9 RID: 713
		private sealed class MethodInfoStoreGeneric_GetElement_Public_T_Int32_0<T>
		{
			// Token: 0x04003377 RID: 13175
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomController_Editor.NativeMethodInfoPtr_GetElement_Public_T_Int32_0, Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002CA RID: 714
		private sealed class MethodInfoStoreGeneric_DeleteElement_Public_Void_Int32_0<T>
		{
			// Token: 0x04003378 RID: 13176
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomController_Editor.NativeMethodInfoPtr_DeleteElement_Public_Void_Int32_0, Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002CB RID: 715
		private sealed class MethodInfoStoreGeneric_zeWQIQXHGFOUqHHvsmnzTtVHPUf_Private_Void_Int32_List_1_T_0<T>
		{
			// Token: 0x04003379 RID: 13177
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomController_Editor.NativeMethodInfoPtr_zeWQIQXHGFOUqHHvsmnzTtVHPUf_Private_Void_Int32_List_1_T_0, Il2CppClassPointerStore<CustomController_Editor>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
