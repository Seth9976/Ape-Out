using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Interfaces;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x020000AE RID: 174
	public sealed class HardwareJoystickTemplateMap : HardwareControllerTemplateMap
	{
		// Token: 0x0600151F RID: 5407 RVA: 0x0007C06C File Offset: 0x0007A26C
		// Note: this type is marked as 'beforefieldinit'.
		static HardwareJoystickTemplateMap()
		{
			Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "HardwareJoystickTemplateMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr);
			HardwareJoystickTemplateMap.NativeFieldInfoPtr_controllerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, "controllerName");
			HardwareJoystickTemplateMap.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, "description");
			HardwareJoystickTemplateMap.NativeFieldInfoPtr_templateGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, "templateGuid");
			HardwareJoystickTemplateMap.NativeFieldInfoPtr_className = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, "className");
			HardwareJoystickTemplateMap.NativeFieldInfoPtr_elementIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, "elementIdentifiers");
			HardwareJoystickTemplateMap.NativeFieldInfoPtr_joysticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, "joysticks");
			HardwareJoystickTemplateMap.NativeFieldInfoPtr_specialElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, "specialElements");
			HardwareJoystickTemplateMap.NativeFieldInfoPtr_elementIdentifierIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, "elementIdentifierIdCounter");
			HardwareJoystickTemplateMap.NativeFieldInfoPtr_joystickIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, "joystickIdCounter");
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_get_Guid_Public_Virtual_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668304);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_get_ControllerName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668305);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_get_ClassName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668306);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_get_ElementIdentifiers_Public_get_IEnumerable_1_ControllerTemplateElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668307);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetElementIdentifier_Public_ControllerTemplateElementIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668308);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_ContainsElementIdentifier_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668309);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetElementIdentifierNames_Public_Virtual_Final_New_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668310);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetElementIdentifierIds_Public_Virtual_Final_New_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668311);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetElementIdentifierScriptingNames_Internal_Il2CppStringArray_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668312);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetMappableElementIdentifierInfo_Public_Virtual_Final_New_Int32_byref_Il2CppStringArray_byref_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668313);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetNonMappableElementIdentifierInfo_Public_Int32_byref_Il2CppStringArray_byref_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668314);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetJoystickNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668315);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetJoystickIds_Public_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668316);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetJoystickGuid_Public_Guid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668317);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetJoystickId_Public_Int32_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668318);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetJoystickFileGuidString_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668319);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_FjhknKpOUlmHnJxDXDOeqsiKvqf_Internal_Boolean_ControllerMap_Editor_HardwareJoystickMap_Guid_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668320);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_HNLaMRubbTAghBKMdsbfmrtNAHe_Internal_ControllerTemplateElementIdentifier_Guid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668321);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetSpecialElementsOrig_Internal_Il2CppReferenceArray_1_SpecialElementEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668322);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_RxkiVRWQqbkLiUtbKleEwYnMcQz_Private_Entry_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668323);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_iSUZjCWjNUwswFVqrCrSkbngmig_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668324);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_Rewired_Data_Mapping_IHardwareControllerMap_Internal_get_ElementIdentifiers_Private_Virtual_Final_New_get_IEnumerable_1_IControllerElementIdentifierCommon_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668325);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_ElIuNranUoEcfBgnrdEaIDBvhZrF_Private_Virtual_Final_New_IControllerElementIdentifierCommon_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668326);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_Rewired_Data_Mapping_IHardwareControllerTemplateMap_Internal_get_name_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668327);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_Rewired_Data_Mapping_IHardwareControllerTemplateMap_Internal_get_typeGuid_Private_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668328);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_oWWLtavmNHJNjkUsVsbrKFoyGRUA_Private_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668329);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_xaqjVtaJTNcoizxqURVjFpfLTdCf_Private_Virtual_Final_New_IControllerTemplateElementIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668330);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_KQMkJSTOpifUWukwEEotPiSFsCR_Private_Virtual_Final_New_IControllerTemplateElementIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668331);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_zbrZqSIDwjLZcmGlTvGkhygNNbn_Private_Virtual_Final_New_IControllerTemplateMapSpecialElement_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668332);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_PpQPEQlqbyhTmlXJIcLCNLiejmCd_Private_Virtual_Final_New_FTRbVIakQDtduAElaDZqEnVrNpq_Controller_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668333);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr_cSMYzmAFCCMFMljnYRwLYqPOWSX_Private_Virtual_Final_New_FTRbVIakQDtduAElaDZqEnVrNpq_Controller_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668334);
			HardwareJoystickTemplateMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, 100668335);
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x0007C3D0 File Offset: 0x0007A5D0
		public unsafe override Guid Guid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271205, XrefRangeEnd = 271209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_get_Guid_Public_Virtual_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x0007C40C File Offset: 0x0007A60C
		public unsafe string ControllerName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_get_ControllerName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x0007C444 File Offset: 0x0007A644
		public unsafe string ClassName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_get_ClassName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x0007C47C File Offset: 0x0007A67C
		public unsafe IEnumerable<ControllerTemplateElementIdentifier> ElementIdentifiers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271209, XrefRangeEnd = 271214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_get_ElementIdentifiers_Public_get_IEnumerable_1_ControllerTemplateElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerTemplateElementIdentifier>>(intPtr3) : null;
			}
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0007C4BC File Offset: 0x0007A6BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 271215, RefRangeEnd = 271220, XrefRangeStart = 271214, XrefRangeEnd = 271215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateElementIdentifier GetElementIdentifier(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetElementIdentifier_Public_ControllerTemplateElementIdentifier_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerTemplateElementIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0007C508 File Offset: 0x0007A708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271220, XrefRangeEnd = 271221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsElementIdentifier(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_ContainsElementIdentifier_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0007C554 File Offset: 0x0007A754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271221, XrefRangeEnd = 271228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetElementIdentifierNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetElementIdentifierNames_Public_Virtual_Final_New_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0007C594 File Offset: 0x0007A794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271228, XrefRangeEnd = 271231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetElementIdentifierIds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetElementIdentifierIds_Public_Virtual_Final_New_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0007C5D4 File Offset: 0x0007A7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271231, XrefRangeEnd = 271239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetElementIdentifierScriptingNames(bool useAlternate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useAlternate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetElementIdentifierScriptingNames_Internal_Il2CppStringArray_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0007C620 File Offset: 0x0007A820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271239, XrefRangeEnd = 271265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMappableElementIdentifierInfo(out Il2CppStringArray names, out Il2CppStructArray<int> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetMappableElementIdentifierInfo_Public_Virtual_Final_New_Int32_byref_Il2CppStringArray_byref_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			names = ((intPtr5 == 0) ? null : new Il2CppStringArray(intPtr5));
			IntPtr intPtr6 = intPtr2;
			ids = ((intPtr6 == 0) ? null : new Il2CppStructArray<int>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0007C6A4 File Offset: 0x0007A8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271265, XrefRangeEnd = 271291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNonMappableElementIdentifierInfo(out Il2CppStringArray names, out Il2CppStructArray<int> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetNonMappableElementIdentifierInfo_Public_Int32_byref_Il2CppStringArray_byref_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			names = ((intPtr5 == 0) ? null : new Il2CppStringArray(intPtr5));
			IntPtr intPtr6 = intPtr2;
			ids = ((intPtr6 == 0) ? null : new Il2CppStructArray<int>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0007C728 File Offset: 0x0007A928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271291, XrefRangeEnd = 271300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetJoystickNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetJoystickNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0007C768 File Offset: 0x0007A968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271300, XrefRangeEnd = 271305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetJoystickIds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetJoystickIds_Public_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0007C7A8 File Offset: 0x0007A9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271305, XrefRangeEnd = 271317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Guid GetJoystickGuid(int joystickId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref joystickId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetJoystickGuid_Public_Guid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0007C7F4 File Offset: 0x0007A9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271317, XrefRangeEnd = 271328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetJoystickId(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref guid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetJoystickId_Public_Int32_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0007C840 File Offset: 0x0007AA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271328, XrefRangeEnd = 271332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetJoystickFileGuidString(int joystickId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref joystickId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetJoystickFileGuidString_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0007C884 File Offset: 0x0007AA84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271409, RefRangeEnd = 271410, XrefRangeStart = 271332, XrefRangeEnd = 271409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FjhknKpOUlmHnJxDXDOeqsiKvqf(ControllerMap_Editor A_1, HardwareJoystickMap A_2, Guid A_3, out string A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_FjhknKpOUlmHnJxDXDOeqsiKvqf_Internal_Boolean_ControllerMap_Editor_HardwareJoystickMap_Guid_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			A_4 = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0007C910 File Offset: 0x0007AB10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271427, RefRangeEnd = 271428, XrefRangeStart = 271410, XrefRangeEnd = 271427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateElementIdentifier HNLaMRubbTAghBKMdsbfmrtNAHe(Guid A_1, int A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_HNLaMRubbTAghBKMdsbfmrtNAHe_Internal_ControllerTemplateElementIdentifier_Guid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerTemplateElementIdentifier>(intPtr3) : null;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0007C96C File Offset: 0x0007AB6C
		[CallerCount(0)]
		public unsafe Il2CppReferenceArray<HardwareJoystickTemplateMap.SpecialElementEntry> GetSpecialElementsOrig()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_GetSpecialElementsOrig_Internal_Il2CppReferenceArray_1_SpecialElementEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HardwareJoystickTemplateMap.SpecialElementEntry>>(intPtr3) : null;
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0007C9AC File Offset: 0x0007ABAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 271437, RefRangeEnd = 271440, XrefRangeStart = 271428, XrefRangeEnd = 271437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareJoystickTemplateMap.Entry RxkiVRWQqbkLiUtbKleEwYnMcQz(Guid A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_RxkiVRWQqbkLiUtbKleEwYnMcQz_Private_Entry_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareJoystickTemplateMap.Entry>(intPtr3) : null;
			}
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0007C9F8 File Offset: 0x0007ABF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271441, RefRangeEnd = 271442, XrefRangeStart = 271440, XrefRangeEnd = 271441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int iSUZjCWjNUwswFVqrCrSkbngmig(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_iSUZjCWjNUwswFVqrCrSkbngmig_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x0007CA44 File Offset: 0x0007AC44
		public unsafe IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired.Data.Mapping.IHardwareControllerMap_Internal.ElementIdentifiers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271442, XrefRangeEnd = 271447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_Rewired_Data_Mapping_IHardwareControllerMap_Internal_get_ElementIdentifiers_Private_Virtual_Final_New_get_IEnumerable_1_IControllerElementIdentifierCommon_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IControllerElementIdentifierCommon_Internal>>(intPtr3) : null;
			}
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0007CA84 File Offset: 0x0007AC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271447, XrefRangeEnd = 271448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IControllerElementIdentifierCommon_Internal ElIuNranUoEcfBgnrdEaIDBvhZrF(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_ElIuNranUoEcfBgnrdEaIDBvhZrF_Private_Virtual_Final_New_IControllerElementIdentifierCommon_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerElementIdentifierCommon_Internal>(intPtr3) : null;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x0007CAD0 File Offset: 0x0007ACD0
		public unsafe string Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_Rewired_Data_Mapping_IHardwareControllerTemplateMap_Internal_get_name_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x0007CB08 File Offset: 0x0007AD08
		public unsafe Guid Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.typeGuid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_Rewired_Data_Mapping_IHardwareControllerTemplateMap_Internal_get_typeGuid_Private_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0007CB44 File Offset: 0x0007AD44
		[CallerCount(0)]
		public unsafe int oWWLtavmNHJNjkUsVsbrKFoyGRUA()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_oWWLtavmNHJNjkUsVsbrKFoyGRUA_Private_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0007CB80 File Offset: 0x0007AD80
		[CallerCount(0)]
		public unsafe IControllerTemplateElementIdentifier xaqjVtaJTNcoizxqURVjFpfLTdCf(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_xaqjVtaJTNcoizxqURVjFpfLTdCf_Private_Virtual_Final_New_IControllerTemplateElementIdentifier_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElementIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0007CBCC File Offset: 0x0007ADCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IControllerTemplateElementIdentifier KQMkJSTOpifUWukwEEotPiSFsCR(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_KQMkJSTOpifUWukwEEotPiSFsCR_Private_Virtual_Final_New_IControllerTemplateElementIdentifier_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElementIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0007CC18 File Offset: 0x0007AE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271448, XrefRangeEnd = 271449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IControllerTemplateMapSpecialElement_Internal zbrZqSIDwjLZcmGlTvGkhygNNbn(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_zbrZqSIDwjLZcmGlTvGkhygNNbn_Private_Virtual_Final_New_IControllerTemplateMapSpecialElement_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateMapSpecialElement_Internal>(intPtr3) : null;
			}
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0007CC64 File Offset: 0x0007AE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271449, XrefRangeEnd = 271455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FTRbVIakQDtduAElaDZqEnVrNpq PpQPEQlqbyhTmlXJIcLCNLiejmCd(Controller A_1, int A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_PpQPEQlqbyhTmlXJIcLCNLiejmCd_Private_Virtual_Final_New_FTRbVIakQDtduAElaDZqEnVrNpq_Controller_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FTRbVIakQDtduAElaDZqEnVrNpq>(intPtr3) : null;
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0007CCC4 File Offset: 0x0007AEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271455, XrefRangeEnd = 271461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FTRbVIakQDtduAElaDZqEnVrNpq cSMYzmAFCCMFMljnYRwLYqPOWSX(Controller A_1, int A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr_cSMYzmAFCCMFMljnYRwLYqPOWSX_Private_Virtual_Final_New_FTRbVIakQDtduAElaDZqEnVrNpq_Controller_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FTRbVIakQDtduAElaDZqEnVrNpq>(intPtr3) : null;
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x0007CD24 File Offset: 0x0007AF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271461, XrefRangeEnd = 271465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareJoystickTemplateMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0000944E File Offset: 0x0000764E
		public HardwareJoystickTemplateMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x0007CD60 File Offset: 0x0007AF60
		// (set) Token: 0x06001542 RID: 5442 RVA: 0x00009457 File Offset: 0x00007657
		public unsafe string controllerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_controllerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_controllerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x0007CD88 File Offset: 0x0007AF88
		// (set) Token: 0x06001544 RID: 5444 RVA: 0x00009476 File Offset: 0x00007676
		public unsafe string description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x0007CDB0 File Offset: 0x0007AFB0
		// (set) Token: 0x06001546 RID: 5446 RVA: 0x00009495 File Offset: 0x00007695
		public unsafe string templateGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_templateGuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_templateGuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x0007CDD8 File Offset: 0x0007AFD8
		// (set) Token: 0x06001548 RID: 5448 RVA: 0x000094B4 File Offset: 0x000076B4
		public unsafe string className
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_className);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_className), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x0007CE00 File Offset: 0x0007B000
		// (set) Token: 0x0600154A RID: 5450 RVA: 0x000094D3 File Offset: 0x000076D3
		public unsafe Il2CppReferenceArray<ControllerTemplateElementIdentifier_Editor> elementIdentifiers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_elementIdentifiers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControllerTemplateElementIdentifier_Editor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_elementIdentifiers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x0007CE30 File Offset: 0x0007B030
		// (set) Token: 0x0600154C RID: 5452 RVA: 0x000094F2 File Offset: 0x000076F2
		public unsafe List<HardwareJoystickTemplateMap.Entry> joysticks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_joysticks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HardwareJoystickTemplateMap.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_joysticks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x0007CE60 File Offset: 0x0007B060
		// (set) Token: 0x0600154E RID: 5454 RVA: 0x00009511 File Offset: 0x00007711
		public unsafe Il2CppReferenceArray<HardwareJoystickTemplateMap.SpecialElementEntry> specialElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_specialElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HardwareJoystickTemplateMap.SpecialElementEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_specialElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x0007CE90 File Offset: 0x0007B090
		// (set) Token: 0x06001550 RID: 5456 RVA: 0x00009530 File Offset: 0x00007730
		public unsafe int elementIdentifierIdCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_elementIdentifierIdCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_elementIdentifierIdCounter)) = value;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x0007CEB8 File Offset: 0x0007B0B8
		// (set) Token: 0x06001552 RID: 5458 RVA: 0x0000954B File Offset: 0x0000774B
		public unsafe int joystickIdCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_joystickIdCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.NativeFieldInfoPtr_joystickIdCounter)) = value;
			}
		}

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeFieldInfoPtr_controllerName;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeFieldInfoPtr_templateGuid;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeFieldInfoPtr_className;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeFieldInfoPtr_elementIdentifiers;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeFieldInfoPtr_joysticks;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeFieldInfoPtr_specialElements;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeFieldInfoPtr_elementIdentifierIdCounter;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeFieldInfoPtr_joystickIdCounter;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_get_Guid_Public_Virtual_get_Guid_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr_get_ControllerName_Public_get_String_0;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr_get_ClassName_Public_get_String_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementIdentifiers_Public_get_IEnumerable_1_ControllerTemplateElementIdentifier_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifier_Public_ControllerTemplateElementIdentifier_Int32_0;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr_ContainsElementIdentifier_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierNames_Public_Virtual_Final_New_Il2CppStringArray_0;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierIds_Public_Virtual_Final_New_Il2CppStructArray_1_Int32_0;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierScriptingNames_Internal_Il2CppStringArray_Boolean_0;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr_GetMappableElementIdentifierInfo_Public_Virtual_Final_New_Int32_byref_Il2CppStringArray_byref_Il2CppStructArray_1_Int32_0;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeMethodInfoPtr_GetNonMappableElementIdentifierInfo_Public_Int32_byref_Il2CppStringArray_byref_Il2CppStructArray_1_Int32_0;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickNames_Public_Il2CppStringArray_0;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickIds_Public_Il2CppStructArray_1_Int32_0;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickGuid_Public_Guid_Int32_0;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickId_Public_Int32_Guid_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickFileGuidString_Public_String_Int32_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_FjhknKpOUlmHnJxDXDOeqsiKvqf_Internal_Boolean_ControllerMap_Editor_HardwareJoystickMap_Guid_byref_String_0;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_HNLaMRubbTAghBKMdsbfmrtNAHe_Internal_ControllerTemplateElementIdentifier_Guid_Int32_0;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialElementsOrig_Internal_Il2CppReferenceArray_1_SpecialElementEntry_0;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr_RxkiVRWQqbkLiUtbKleEwYnMcQz_Private_Entry_Guid_0;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeMethodInfoPtr_iSUZjCWjNUwswFVqrCrSkbngmig_Private_Int32_Int32_0;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Data_Mapping_IHardwareControllerMap_Internal_get_ElementIdentifiers_Private_Virtual_Final_New_get_IEnumerable_1_IControllerElementIdentifierCommon_Internal_0;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeMethodInfoPtr_ElIuNranUoEcfBgnrdEaIDBvhZrF_Private_Virtual_Final_New_IControllerElementIdentifierCommon_Internal_Int32_0;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Data_Mapping_IHardwareControllerTemplateMap_Internal_get_name_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Data_Mapping_IHardwareControllerTemplateMap_Internal_get_typeGuid_Private_Virtual_Final_New_get_Guid_0;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeMethodInfoPtr_oWWLtavmNHJNjkUsVsbrKFoyGRUA_Private_Virtual_Final_New_Int32_0;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_xaqjVtaJTNcoizxqURVjFpfLTdCf_Private_Virtual_Final_New_IControllerTemplateElementIdentifier_Int32_0;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr_KQMkJSTOpifUWukwEEotPiSFsCR_Private_Virtual_Final_New_IControllerTemplateElementIdentifier_Int32_0;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeMethodInfoPtr_zbrZqSIDwjLZcmGlTvGkhygNNbn_Private_Virtual_Final_New_IControllerTemplateMapSpecialElement_Internal_Int32_0;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeMethodInfoPtr_PpQPEQlqbyhTmlXJIcLCNLiejmCd_Private_Virtual_Final_New_FTRbVIakQDtduAElaDZqEnVrNpq_Controller_Int32_0;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeMethodInfoPtr_cSMYzmAFCCMFMljnYRwLYqPOWSX_Private_Virtual_Final_New_FTRbVIakQDtduAElaDZqEnVrNpq_Controller_Int32_0;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000307 RID: 775
		[Serializable]
		public sealed class Entry : Object
		{
			// Token: 0x06004234 RID: 16948 RVA: 0x0013A134 File Offset: 0x00138334
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<HardwareJoystickTemplateMap.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardwareJoystickTemplateMap.Entry>.NativeClassPtr);
				HardwareJoystickTemplateMap.Entry.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.Entry>.NativeClassPtr, "id");
				HardwareJoystickTemplateMap.Entry.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.Entry>.NativeClassPtr, "name");
				HardwareJoystickTemplateMap.Entry.NativeFieldInfoPtr_joystickGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.Entry>.NativeClassPtr, "joystickGuid");
				HardwareJoystickTemplateMap.Entry.NativeFieldInfoPtr_fileGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.Entry>.NativeClassPtr, "fileGuid");
				HardwareJoystickTemplateMap.Entry.NativeFieldInfoPtr_elementIdentifierMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.Entry>.NativeClassPtr, "elementIdentifierMappings");
				HardwareJoystickTemplateMap.Entry.NativeMethodInfoPtr_get_JoystickGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.Entry>.NativeClassPtr, 100668336);
				HardwareJoystickTemplateMap.Entry.NativeMethodInfoPtr_GetJoystickElementId_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.Entry>.NativeClassPtr, 100668337);
				HardwareJoystickTemplateMap.Entry.NativeMethodInfoPtr_GetTemplateElementId_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.Entry>.NativeClassPtr, 100668338);
				HardwareJoystickTemplateMap.Entry.NativeMethodInfoPtr_GetElementIdentifierMap_Public_ElementIdentifierMap_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.Entry>.NativeClassPtr, 100668339);
				HardwareJoystickTemplateMap.Entry.NativeMethodInfoPtr_GetElementIdentifierMaps_Public_Void_Int32_List_1_ElementIdentifierMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.Entry>.NativeClassPtr, 100668340);
				HardwareJoystickTemplateMap.Entry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.Entry>.NativeClassPtr, 100668341);
			}

			// Token: 0x17001491 RID: 5265
			// (get) Token: 0x06004235 RID: 16949 RVA: 0x0013A23C File Offset: 0x0013843C
			public unsafe Guid JoystickGuid
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 271168, RefRangeEnd = 271170, XrefRangeStart = 271157, XrefRangeEnd = 271168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.Entry.NativeMethodInfoPtr_get_JoystickGuid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004236 RID: 16950 RVA: 0x0013A278 File Offset: 0x00138478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271170, XrefRangeEnd = 271173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetJoystickElementId(int templateElementId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref templateElementId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.Entry.NativeMethodInfoPtr_GetJoystickElementId_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004237 RID: 16951 RVA: 0x0013A2C4 File Offset: 0x001384C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271173, XrefRangeEnd = 271176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetTemplateElementId(int joystickElementId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref joystickElementId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.Entry.NativeMethodInfoPtr_GetTemplateElementId_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004238 RID: 16952 RVA: 0x0013A310 File Offset: 0x00138510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271176, XrefRangeEnd = 271179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HardwareJoystickTemplateMap.ElementIdentifierMap GetElementIdentifierMap(int templateId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref templateId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.Entry.NativeMethodInfoPtr_GetElementIdentifierMap_Public_ElementIdentifierMap_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareJoystickTemplateMap.ElementIdentifierMap>(intPtr3) : null;
				}
			}

			// Token: 0x06004239 RID: 16953 RVA: 0x0013A35C File Offset: 0x0013855C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271179, XrefRangeEnd = 271185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetElementIdentifierMaps(int templateId, List<HardwareJoystickTemplateMap.ElementIdentifierMap> results)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref templateId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.Entry.NativeMethodInfoPtr_GetElementIdentifierMaps_Public_Void_Int32_List_1_ElementIdentifierMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600423A RID: 16954 RVA: 0x0013A3AC File Offset: 0x001385AC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareJoystickTemplateMap.Entry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.Entry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600423B RID: 16955 RVA: 0x0001755E File Offset: 0x0001575E
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700148C RID: 5260
			// (get) Token: 0x0600423C RID: 16956 RVA: 0x0013A3E8 File Offset: 0x001385E8
			// (set) Token: 0x0600423D RID: 16957 RVA: 0x00017567 File Offset: 0x00015767
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.Entry.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.Entry.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x1700148D RID: 5261
			// (get) Token: 0x0600423E RID: 16958 RVA: 0x0013A410 File Offset: 0x00138610
			// (set) Token: 0x0600423F RID: 16959 RVA: 0x00017582 File Offset: 0x00015782
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.Entry.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.Entry.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700148E RID: 5262
			// (get) Token: 0x06004240 RID: 16960 RVA: 0x0013A438 File Offset: 0x00138638
			// (set) Token: 0x06004241 RID: 16961 RVA: 0x000175A1 File Offset: 0x000157A1
			public unsafe string joystickGuid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.Entry.NativeFieldInfoPtr_joystickGuid);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.Entry.NativeFieldInfoPtr_joystickGuid), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700148F RID: 5263
			// (get) Token: 0x06004242 RID: 16962 RVA: 0x0013A460 File Offset: 0x00138660
			// (set) Token: 0x06004243 RID: 16963 RVA: 0x000175C0 File Offset: 0x000157C0
			public unsafe string fileGuid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.Entry.NativeFieldInfoPtr_fileGuid);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.Entry.NativeFieldInfoPtr_fileGuid), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001490 RID: 5264
			// (get) Token: 0x06004244 RID: 16964 RVA: 0x0013A488 File Offset: 0x00138688
			// (set) Token: 0x06004245 RID: 16965 RVA: 0x000175DF File Offset: 0x000157DF
			public unsafe List<HardwareJoystickTemplateMap.ElementIdentifierMap> elementIdentifierMappings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.Entry.NativeFieldInfoPtr_elementIdentifierMappings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HardwareJoystickTemplateMap.ElementIdentifierMap>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.Entry.NativeFieldInfoPtr_elementIdentifierMappings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036AB RID: 13995
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040036AC RID: 13996
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040036AD RID: 13997
			private static readonly IntPtr NativeFieldInfoPtr_joystickGuid;

			// Token: 0x040036AE RID: 13998
			private static readonly IntPtr NativeFieldInfoPtr_fileGuid;

			// Token: 0x040036AF RID: 13999
			private static readonly IntPtr NativeFieldInfoPtr_elementIdentifierMappings;

			// Token: 0x040036B0 RID: 14000
			private static readonly IntPtr NativeMethodInfoPtr_get_JoystickGuid_Public_get_Guid_0;

			// Token: 0x040036B1 RID: 14001
			private static readonly IntPtr NativeMethodInfoPtr_GetJoystickElementId_Public_Int32_Int32_0;

			// Token: 0x040036B2 RID: 14002
			private static readonly IntPtr NativeMethodInfoPtr_GetTemplateElementId_Public_Int32_Int32_0;

			// Token: 0x040036B3 RID: 14003
			private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierMap_Public_ElementIdentifierMap_Int32_0;

			// Token: 0x040036B4 RID: 14004
			private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierMaps_Public_Void_Int32_List_1_ElementIdentifierMap_0;

			// Token: 0x040036B5 RID: 14005
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000308 RID: 776
		[Serializable]
		public sealed class ElementIdentifierMap : Object
		{
			// Token: 0x06004246 RID: 16966 RVA: 0x0013A4B8 File Offset: 0x001386B8
			// Note: this type is marked as 'beforefieldinit'.
			static ElementIdentifierMap()
			{
				Il2CppClassPointerStore<HardwareJoystickTemplateMap.ElementIdentifierMap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, "ElementIdentifierMap");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardwareJoystickTemplateMap.ElementIdentifierMap>.NativeClassPtr);
				HardwareJoystickTemplateMap.ElementIdentifierMap.NativeFieldInfoPtr_templateId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.ElementIdentifierMap>.NativeClassPtr, "templateId");
				HardwareJoystickTemplateMap.ElementIdentifierMap.NativeFieldInfoPtr_joystickId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.ElementIdentifierMap>.NativeClassPtr, "joystickId");
				HardwareJoystickTemplateMap.ElementIdentifierMap.NativeFieldInfoPtr_joystickId2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.ElementIdentifierMap>.NativeClassPtr, "joystickId2");
				HardwareJoystickTemplateMap.ElementIdentifierMap.NativeFieldInfoPtr_splitAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.ElementIdentifierMap>.NativeClassPtr, "splitAxis");
				HardwareJoystickTemplateMap.ElementIdentifierMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.ElementIdentifierMap>.NativeClassPtr, 100668342);
			}

			// Token: 0x06004247 RID: 16967 RVA: 0x0013A548 File Offset: 0x00138748
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ElementIdentifierMap()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareJoystickTemplateMap.ElementIdentifierMap>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.ElementIdentifierMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004248 RID: 16968 RVA: 0x000175FE File Offset: 0x000157FE
			public ElementIdentifierMap(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001492 RID: 5266
			// (get) Token: 0x06004249 RID: 16969 RVA: 0x0013A584 File Offset: 0x00138784
			// (set) Token: 0x0600424A RID: 16970 RVA: 0x00017607 File Offset: 0x00015807
			public unsafe int templateId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.ElementIdentifierMap.NativeFieldInfoPtr_templateId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.ElementIdentifierMap.NativeFieldInfoPtr_templateId)) = value;
				}
			}

			// Token: 0x17001493 RID: 5267
			// (get) Token: 0x0600424B RID: 16971 RVA: 0x0013A5AC File Offset: 0x001387AC
			// (set) Token: 0x0600424C RID: 16972 RVA: 0x00017622 File Offset: 0x00015822
			public unsafe int joystickId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.ElementIdentifierMap.NativeFieldInfoPtr_joystickId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.ElementIdentifierMap.NativeFieldInfoPtr_joystickId)) = value;
				}
			}

			// Token: 0x17001494 RID: 5268
			// (get) Token: 0x0600424D RID: 16973 RVA: 0x0013A5D4 File Offset: 0x001387D4
			// (set) Token: 0x0600424E RID: 16974 RVA: 0x0001763D File Offset: 0x0001583D
			public unsafe int joystickId2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.ElementIdentifierMap.NativeFieldInfoPtr_joystickId2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.ElementIdentifierMap.NativeFieldInfoPtr_joystickId2)) = value;
				}
			}

			// Token: 0x17001495 RID: 5269
			// (get) Token: 0x0600424F RID: 16975 RVA: 0x0013A5FC File Offset: 0x001387FC
			// (set) Token: 0x06004250 RID: 16976 RVA: 0x00017658 File Offset: 0x00015858
			public unsafe bool splitAxis
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.ElementIdentifierMap.NativeFieldInfoPtr_splitAxis);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.ElementIdentifierMap.NativeFieldInfoPtr_splitAxis)) = value;
				}
			}

			// Token: 0x040036B6 RID: 14006
			private static readonly IntPtr NativeFieldInfoPtr_templateId;

			// Token: 0x040036B7 RID: 14007
			private static readonly IntPtr NativeFieldInfoPtr_joystickId;

			// Token: 0x040036B8 RID: 14008
			private static readonly IntPtr NativeFieldInfoPtr_joystickId2;

			// Token: 0x040036B9 RID: 14009
			private static readonly IntPtr NativeFieldInfoPtr_splitAxis;

			// Token: 0x040036BA RID: 14010
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000309 RID: 777
		[Serializable]
		public sealed class SpecialElementEntry : Object
		{
			// Token: 0x06004251 RID: 16977 RVA: 0x0013A624 File Offset: 0x00138824
			// Note: this type is marked as 'beforefieldinit'.
			static SpecialElementEntry()
			{
				Il2CppClassPointerStore<HardwareJoystickTemplateMap.SpecialElementEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, "SpecialElementEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardwareJoystickTemplateMap.SpecialElementEntry>.NativeClassPtr);
				HardwareJoystickTemplateMap.SpecialElementEntry.NativeFieldInfoPtr_elementIdentifierId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.SpecialElementEntry>.NativeClassPtr, "elementIdentifierId");
				HardwareJoystickTemplateMap.SpecialElementEntry.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.SpecialElementEntry>.NativeClassPtr, "data");
				HardwareJoystickTemplateMap.SpecialElementEntry.NativeMethodInfoPtr_KlhgnhXplPACQcyFQECCfzOgSGLu_Private_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.SpecialElementEntry>.NativeClassPtr, 100668343);
				HardwareJoystickTemplateMap.SpecialElementEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.SpecialElementEntry>.NativeClassPtr, 100668344);
			}

			// Token: 0x06004252 RID: 16978 RVA: 0x0013A6A0 File Offset: 0x001388A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271185, XrefRangeEnd = 271188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T KlhgnhXplPACQcyFQECCfzOgSGLu<T>() where T : ControllerTemplateSpecialElementMapping
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.SpecialElementEntry.MethodInfoStoreGeneric_KlhgnhXplPACQcyFQECCfzOgSGLu_Private_Virtual_Final_New_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x06004253 RID: 16979 RVA: 0x0013A6DC File Offset: 0x001388DC
			[CallerCount(0)]
			public unsafe SpecialElementEntry()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareJoystickTemplateMap.SpecialElementEntry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.SpecialElementEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004254 RID: 16980 RVA: 0x00017673 File Offset: 0x00015873
			public SpecialElementEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001496 RID: 5270
			// (get) Token: 0x06004255 RID: 16981 RVA: 0x0013A718 File Offset: 0x00138918
			// (set) Token: 0x06004256 RID: 16982 RVA: 0x0001767C File Offset: 0x0001587C
			public unsafe int elementIdentifierId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.SpecialElementEntry.NativeFieldInfoPtr_elementIdentifierId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.SpecialElementEntry.NativeFieldInfoPtr_elementIdentifierId)) = value;
				}
			}

			// Token: 0x17001497 RID: 5271
			// (get) Token: 0x06004257 RID: 16983 RVA: 0x0013A740 File Offset: 0x00138940
			// (set) Token: 0x06004258 RID: 16984 RVA: 0x00017697 File Offset: 0x00015897
			public unsafe string data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.SpecialElementEntry.NativeFieldInfoPtr_data);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.SpecialElementEntry.NativeFieldInfoPtr_data), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040036BB RID: 14011
			private static readonly IntPtr NativeFieldInfoPtr_elementIdentifierId;

			// Token: 0x040036BC RID: 14012
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040036BD RID: 14013
			private static readonly IntPtr NativeMethodInfoPtr_KlhgnhXplPACQcyFQECCfzOgSGLu_Private_Virtual_Final_New_T_0;

			// Token: 0x040036BE RID: 14014
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000559 RID: 1369
			private sealed class MethodInfoStoreGeneric_KlhgnhXplPACQcyFQECCfzOgSGLu_Private_Virtual_Final_New_T_0<T>
			{
				// Token: 0x04004AB7 RID: 19127
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HardwareJoystickTemplateMap.SpecialElementEntry.NativeMethodInfoPtr_KlhgnhXplPACQcyFQECCfzOgSGLu_Private_Virtual_Final_New_T_0, Il2CppClassPointerStore<HardwareJoystickTemplateMap.SpecialElementEntry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x0200030A RID: 778
		public sealed class mtbdmcyjPVGzjAszmuCoJiTrhhf : Object
		{
			// Token: 0x06004259 RID: 16985 RVA: 0x0013A768 File Offset: 0x00138968
			// Note: this type is marked as 'beforefieldinit'.
			static mtbdmcyjPVGzjAszmuCoJiTrhhf()
			{
				Il2CppClassPointerStore<HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, "mtbdmcyjPVGzjAszmuCoJiTrhhf");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf>.NativeClassPtr);
				HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf>.NativeClassPtr, "kUBcJcFfgoKKiApkBmiZbFhcTlkZ");
				HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerTemplateElementIdentifier__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerTemplateElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf>.NativeClassPtr, 100668345);
				HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf>.NativeClassPtr, 100668346);
				HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf>.NativeClassPtr, 100668347);
				HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerTemplateElementIdentifier__get_Current_Private_Virtual_Final_New_get_ControllerTemplateElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf>.NativeClassPtr, 100668348);
				HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf>.NativeClassPtr, 100668349);
				HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf>.NativeClassPtr, 100668350);
				HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf>.NativeClassPtr, 100668351);
				HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf>.NativeClassPtr, 100668352);
			}

			// Token: 0x0600425A RID: 16986 RVA: 0x0013A898 File Offset: 0x00138A98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271188, XrefRangeEnd = 271191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ControllerTemplateElementIdentifier> System_Collections_Generic_IEnumerable_Rewired_ControllerTemplateElementIdentifier__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerTemplateElementIdentifier__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerTemplateElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ControllerTemplateElementIdentifier>>(intPtr3) : null;
			}

			// Token: 0x0600425B RID: 16987 RVA: 0x0013A8D8 File Offset: 0x00138AD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600425C RID: 16988 RVA: 0x0013A918 File Offset: 0x00138B18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271191, XrefRangeEnd = 271192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700149D RID: 5277
			// (get) Token: 0x0600425D RID: 16989 RVA: 0x0013A954 File Offset: 0x00138B54
			public unsafe ControllerTemplateElementIdentifier fyERWMJmbizLnGLIHfnYVZxEmd
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerTemplateElementIdentifier__get_Current_Private_Virtual_Final_New_get_ControllerTemplateElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerTemplateElementIdentifier>(intPtr3) : null;
				}
			}

			// Token: 0x0600425E RID: 16990 RVA: 0x0013A994 File Offset: 0x00138B94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271192, XrefRangeEnd = 271197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600425F RID: 16991 RVA: 0x0013A9C8 File Offset: 0x00138BC8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700149E RID: 5278
			// (get) Token: 0x06004260 RID: 16992 RVA: 0x0013A9FC File Offset: 0x00138BFC
			public unsafe Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004261 RID: 16993 RVA: 0x0013AA3C File Offset: 0x00138C3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe mtbdmcyjPVGzjAszmuCoJiTrhhf(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004262 RID: 16994 RVA: 0x000176B6 File Offset: 0x000158B6
			public mtbdmcyjPVGzjAszmuCoJiTrhhf(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001498 RID: 5272
			// (get) Token: 0x06004263 RID: 16995 RVA: 0x0013AA84 File Offset: 0x00138C84
			// (set) Token: 0x06004264 RID: 16996 RVA: 0x000176BF File Offset: 0x000158BF
			public unsafe ControllerTemplateElementIdentifier NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerTemplateElementIdentifier>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001499 RID: 5273
			// (get) Token: 0x06004265 RID: 16997 RVA: 0x0013AAB4 File Offset: 0x00138CB4
			// (set) Token: 0x06004266 RID: 16998 RVA: 0x000176DE File Offset: 0x000158DE
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x1700149A RID: 5274
			// (get) Token: 0x06004267 RID: 16999 RVA: 0x0013AADC File Offset: 0x00138CDC
			// (set) Token: 0x06004268 RID: 17000 RVA: 0x000176F9 File Offset: 0x000158F9
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x1700149B RID: 5275
			// (get) Token: 0x06004269 RID: 17001 RVA: 0x0013AB04 File Offset: 0x00138D04
			// (set) Token: 0x0600426A RID: 17002 RVA: 0x00017714 File Offset: 0x00015914
			public unsafe HardwareJoystickTemplateMap HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HardwareJoystickTemplateMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700149C RID: 5276
			// (get) Token: 0x0600426B RID: 17003 RVA: 0x0013AB34 File Offset: 0x00138D34
			// (set) Token: 0x0600426C RID: 17004 RVA: 0x00017733 File Offset: 0x00015933
			public unsafe int kUBcJcFfgoKKiApkBmiZbFhcTlkZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.mtbdmcyjPVGzjAszmuCoJiTrhhf.NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ)) = value;
				}
			}

			// Token: 0x040036BF RID: 14015
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x040036C0 RID: 14016
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x040036C1 RID: 14017
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x040036C2 RID: 14018
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x040036C3 RID: 14019
			private static readonly IntPtr NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ;

			// Token: 0x040036C4 RID: 14020
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ControllerTemplateElementIdentifier__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ControllerTemplateElementIdentifier_0;

			// Token: 0x040036C5 RID: 14021
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x040036C6 RID: 14022
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040036C7 RID: 14023
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ControllerTemplateElementIdentifier__get_Current_Private_Virtual_Final_New_get_ControllerTemplateElementIdentifier_0;

			// Token: 0x040036C8 RID: 14024
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036C9 RID: 14025
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036CA RID: 14026
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040036CB RID: 14027
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}

		// Token: 0x0200030B RID: 779
		public sealed class owwUuGubnMQpPQGvCgadZPqFSfu : Object
		{
			// Token: 0x0600426D RID: 17005 RVA: 0x0013AB5C File Offset: 0x00138D5C
			// Note: this type is marked as 'beforefieldinit'.
			static owwUuGubnMQpPQGvCgadZPqFSfu()
			{
				Il2CppClassPointerStore<HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HardwareJoystickTemplateMap>.NativeClassPtr, "owwUuGubnMQpPQGvCgadZPqFSfu");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu>.NativeClassPtr);
				HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeFieldInfoPtr_wPmMLfqzwVhLTCmBhsIefDGBOmO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu>.NativeClassPtr, "wPmMLfqzwVhLTCmBhsIefDGBOmO");
				HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IControllerElementIdentifierCommon_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu>.NativeClassPtr, 100668353);
				HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu>.NativeClassPtr, 100668354);
				HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu>.NativeClassPtr, 100668355);
				HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal__get_Current_Private_Virtual_Final_New_get_IControllerElementIdentifierCommon_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu>.NativeClassPtr, 100668356);
				HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu>.NativeClassPtr, 100668357);
				HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu>.NativeClassPtr, 100668358);
				HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu>.NativeClassPtr, 100668359);
				HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu>.NativeClassPtr, 100668360);
			}

			// Token: 0x0600426E RID: 17006 RVA: 0x0013AC8C File Offset: 0x00138E8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271197, XrefRangeEnd = 271200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IControllerElementIdentifierCommon_Internal> System_Collections_Generic_IEnumerable_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IControllerElementIdentifierCommon_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IControllerElementIdentifierCommon_Internal>>(intPtr3) : null;
			}

			// Token: 0x0600426F RID: 17007 RVA: 0x0013ACCC File Offset: 0x00138ECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004270 RID: 17008 RVA: 0x0013AD0C File Offset: 0x00138F0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170014A4 RID: 5284
			// (get) Token: 0x06004271 RID: 17009 RVA: 0x0013AD48 File Offset: 0x00138F48
			public unsafe IControllerElementIdentifierCommon_Internal JPqBVVcAmNgggyzogEcGWogAZJWp
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal__get_Current_Private_Virtual_Final_New_get_IControllerElementIdentifierCommon_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerElementIdentifierCommon_Internal>(intPtr3) : null;
				}
			}

			// Token: 0x06004272 RID: 17010 RVA: 0x0013AD88 File Offset: 0x00138F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271200, XrefRangeEnd = 271205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004273 RID: 17011 RVA: 0x0013ADBC File Offset: 0x00138FBC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170014A5 RID: 5285
			// (get) Token: 0x06004274 RID: 17012 RVA: 0x0013ADF0 File Offset: 0x00138FF0
			public unsafe Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004275 RID: 17013 RVA: 0x0013AE30 File Offset: 0x00139030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe owwUuGubnMQpPQGvCgadZPqFSfu(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004276 RID: 17014 RVA: 0x0001774E File Offset: 0x0001594E
			public owwUuGubnMQpPQGvCgadZPqFSfu(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700149F RID: 5279
			// (get) Token: 0x06004277 RID: 17015 RVA: 0x0013AE78 File Offset: 0x00139078
			// (set) Token: 0x06004278 RID: 17016 RVA: 0x00017757 File Offset: 0x00015957
			public unsafe IControllerElementIdentifierCommon_Internal NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IControllerElementIdentifierCommon_Internal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014A0 RID: 5280
			// (get) Token: 0x06004279 RID: 17017 RVA: 0x0013AEA8 File Offset: 0x001390A8
			// (set) Token: 0x0600427A RID: 17018 RVA: 0x00017776 File Offset: 0x00015976
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x170014A1 RID: 5281
			// (get) Token: 0x0600427B RID: 17019 RVA: 0x0013AED0 File Offset: 0x001390D0
			// (set) Token: 0x0600427C RID: 17020 RVA: 0x00017791 File Offset: 0x00015991
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x170014A2 RID: 5282
			// (get) Token: 0x0600427D RID: 17021 RVA: 0x0013AEF8 File Offset: 0x001390F8
			// (set) Token: 0x0600427E RID: 17022 RVA: 0x000177AC File Offset: 0x000159AC
			public unsafe HardwareJoystickTemplateMap HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HardwareJoystickTemplateMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014A3 RID: 5283
			// (get) Token: 0x0600427F RID: 17023 RVA: 0x0013AF28 File Offset: 0x00139128
			// (set) Token: 0x06004280 RID: 17024 RVA: 0x000177CB File Offset: 0x000159CB
			public unsafe int wPmMLfqzwVhLTCmBhsIefDGBOmO
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeFieldInfoPtr_wPmMLfqzwVhLTCmBhsIefDGBOmO);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickTemplateMap.owwUuGubnMQpPQGvCgadZPqFSfu.NativeFieldInfoPtr_wPmMLfqzwVhLTCmBhsIefDGBOmO)) = value;
				}
			}

			// Token: 0x040036CC RID: 14028
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x040036CD RID: 14029
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x040036CE RID: 14030
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x040036CF RID: 14031
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x040036D0 RID: 14032
			private static readonly IntPtr NativeFieldInfoPtr_wPmMLfqzwVhLTCmBhsIefDGBOmO;

			// Token: 0x040036D1 RID: 14033
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IControllerElementIdentifierCommon_Internal_0;

			// Token: 0x040036D2 RID: 14034
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x040036D3 RID: 14035
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040036D4 RID: 14036
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal__get_Current_Private_Virtual_Final_New_get_IControllerElementIdentifierCommon_Internal_0;

			// Token: 0x040036D5 RID: 14037
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036D6 RID: 14038
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040036D7 RID: 14039
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040036D8 RID: 14040
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}
	}
}
