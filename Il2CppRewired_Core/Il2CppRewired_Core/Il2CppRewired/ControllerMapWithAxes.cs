using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppRewired
{
	// Token: 0x0200014D RID: 333
	public class ControllerMapWithAxes : ControllerMap
	{
		// Token: 0x060024FC RID: 9468 RVA: 0x000BC7B8 File Offset: 0x000BA9B8
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerMapWithAxes()
		{
			Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerMapWithAxes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr);
			ControllerMapWithAxes.NativeFieldInfoPtr_FcQLJjvGMseogJykVTxLDaZznnIb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, "FcQLJjvGMseogJykVTxLDaZznnIb");
			ControllerMapWithAxes.NativeFieldInfoPtr_yHwTsVrrptIRSKZhjwagtrFHVp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, "yHwTsVrrptIRSKZhjwagtrFHVp");
			ControllerMapWithAxes.NativeMethodInfoPtr_get_axisMapCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671315);
			ControllerMapWithAxes.NativeMethodInfoPtr_get_AxisMaps_Public_get_IList_1_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671316);
			ControllerMapWithAxes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671317);
			ControllerMapWithAxes.NativeMethodInfoPtr__ctor_Public_Void_ControllerMapWithAxes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671318);
			ControllerMapWithAxes.NativeMethodInfoPtr_ContainsAction_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671319);
			ControllerMapWithAxes.NativeMethodInfoPtr_CreateElementMap_Public_Virtual_Boolean_Int32_Pole_Int32_ControllerElementType_AxisRange_Boolean_byref_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671320);
			ControllerMapWithAxes.NativeMethodInfoPtr_ReplaceElementMap_Public_Virtual_Boolean_Int32_Int32_Pole_Int32_ControllerElementType_AxisRange_Boolean_byref_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671321);
			ControllerMapWithAxes.NativeMethodInfoPtr_DeleteElementMap_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671322);
			ControllerMapWithAxes.NativeMethodInfoPtr_DeleteElementMapsWithAction_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671323);
			ControllerMapWithAxes.NativeMethodInfoPtr_DeleteElementMapsWithAction_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671324);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetElementMap_Public_Virtual_ActionElementMap_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671325);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetFirstElementMapWithAction_Public_Virtual_ActionElementMap_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671326);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetFirstElementMapWithAction_Public_Virtual_ActionElementMap_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671327);
			ControllerMapWithAxes.NativeMethodInfoPtr_QSBalQiqduUdRvmxdfYovGyJOxiP_Internal_Virtual_ActionElementMap_Predicate_1_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671328);
			ControllerMapWithAxes.NativeMethodInfoPtr_aegqTNsHvLTdITDAEjZRkMSDAOWk_Internal_Virtual_Int32_Predicate_1_ActionElementMap_Boolean_List_1_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671329);
			ControllerMapWithAxes.NativeMethodInfoPtr_ClearElementMaps_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671330);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMap_Public_ActionElementMap_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671331);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMaps_Public_Il2CppReferenceArray_1_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671332);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMaps_Public_Il2CppReferenceArray_1_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671333);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMaps_Public_Int32_Boolean_List_1_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671334);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Il2CppReferenceArray_1_ActionElementMap_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671335);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Il2CppReferenceArray_1_ActionElementMap_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671336);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Il2CppReferenceArray_1_ActionElementMap_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671337);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Il2CppReferenceArray_1_ActionElementMap_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671338);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Int32_String_List_1_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671339);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Int32_Int32_List_1_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671340);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Int32_String_Boolean_List_1_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671341);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Int32_Int32_Boolean_List_1_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671342);
			ControllerMapWithAxes.NativeMethodInfoPtr_AxisMapsWithAction_Public_IEnumerable_1_ActionElementMap_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671343);
			ControllerMapWithAxes.NativeMethodInfoPtr_AxisMapsWithAction_Public_IEnumerable_1_ActionElementMap_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671344);
			ControllerMapWithAxes.NativeMethodInfoPtr_AxisMapsWithAction_Public_IEnumerable_1_ActionElementMap_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671345);
			ControllerMapWithAxes.NativeMethodInfoPtr_AxisMapsWithAction_Public_IEnumerable_1_ActionElementMap_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671346);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetFirstAxisMapWithAction_Public_ActionElementMap_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671347);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetFirstAxisMapWithAction_Public_ActionElementMap_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671348);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetFirstAxisMapWithAction_Public_ActionElementMap_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671349);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetFirstAxisMapWithAction_Public_ActionElementMap_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671350);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetFirstAxisMapMatch_Public_ActionElementMap_Predicate_1_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671351);
			ControllerMapWithAxes.NativeMethodInfoPtr_gsBQZMDqHonJLMKIcuisINjEZTK_Internal_ActionElementMap_Predicate_1_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671352);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapMatches_Public_Int32_Predicate_1_ActionElementMap_List_1_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671353);
			ControllerMapWithAxes.NativeMethodInfoPtr_aLZheiXCOPNPsutBmesEwddMfuvd_Internal_Int32_Predicate_1_ActionElementMap_Boolean_List_1_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671354);
			ControllerMapWithAxes.NativeMethodInfoPtr_ForEachAxisMapMatch_Public_Void_Predicate_1_ActionElementMap_Action_1_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671355);
			ControllerMapWithAxes.NativeMethodInfoPtr_DeleteAxisMapsWithAction_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671356);
			ControllerMapWithAxes.NativeMethodInfoPtr_DeleteAxisMapsWithAction_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671357);
			ControllerMapWithAxes.NativeMethodInfoPtr_SetAllAxisMapsEnabled_Public_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671358);
			ControllerMapWithAxes.NativeMethodInfoPtr_DoesElementAssignmentConflict_Public_Virtual_Boolean_ControllerMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671359);
			ControllerMapWithAxes.NativeMethodInfoPtr_DoesElementAssignmentConflict_Public_Virtual_Boolean_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671360);
			ControllerMapWithAxes.NativeMethodInfoPtr_DoesElementAssignmentConflict_Public_Virtual_Boolean_ElementAssignmentConflictCheck_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671361);
			ControllerMapWithAxes.NativeMethodInfoPtr_ElementAssignmentConflicts_Public_Virtual_IEnumerable_1_ElementAssignmentConflictInfo_ControllerMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671362);
			ControllerMapWithAxes.NativeMethodInfoPtr_ElementAssignmentConflicts_Public_Virtual_IEnumerable_1_ElementAssignmentConflictInfo_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671363);
			ControllerMapWithAxes.NativeMethodInfoPtr_ElementAssignmentConflicts_Public_Virtual_IEnumerable_1_ElementAssignmentConflictInfo_ElementAssignmentConflictCheck_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671364);
			ControllerMapWithAxes.NativeMethodInfoPtr_RemoveElementAssignmentConflicts_Public_Virtual_Int32_ControllerMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671365);
			ControllerMapWithAxes.NativeMethodInfoPtr_RemoveElementAssignmentConflicts_Public_Virtual_Int32_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671366);
			ControllerMapWithAxes.NativeMethodInfoPtr_RemoveElementAssignmentConflicts_Public_Virtual_Int32_ElementAssignmentConflictCheck_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671367);
			ControllerMapWithAxes.NativeMethodInfoPtr_xsYhlPPJRgBvzsYlltDclbtuhko_Internal_Virtual_Int32_ControllerMap_Boolean_List_1_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671368);
			ControllerMapWithAxes.NativeMethodInfoPtr_xsYhlPPJRgBvzsYlltDclbtuhko_Internal_Virtual_Int32_ActionElementMap_Boolean_List_1_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671369);
			ControllerMapWithAxes.NativeMethodInfoPtr_xsYhlPPJRgBvzsYlltDclbtuhko_Internal_Virtual_Int32_ElementAssignmentConflictCheck_Boolean_List_1_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671370);
			ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671371);
			ControllerMapWithAxes.NativeMethodInfoPtr_get_AxisMaps_orig_Internal_get_AList_1_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671372);
			ControllerMapWithAxes.NativeMethodInfoPtr_bSFRctRNbUtpIPCEYIDqZnOAPwB_Internal_Virtual_Boolean_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671373);
			ControllerMapWithAxes.NativeMethodInfoPtr_OcNdzHyncEJGLQZxrJAfECCljAu_Internal_Virtual_Int32_List_1_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671374);
			ControllerMapWithAxes.NativeMethodInfoPtr_vtqdkqhtGoVpIfYQRzwYDqGuOuoB_Internal_Virtual_ActionElementMap_Int32_Int32_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671375);
			ControllerMapWithAxes.NativeMethodInfoPtr_SiIapBCXxCcaBcNAzTqjqCABediB_Internal_Virtual_Int32_Int32_List_1_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671376);
			ControllerMapWithAxes.NativeMethodInfoPtr_AsVROrbDObOiqzSvvgiEvZsMzFs_Internal_Virtual_Boolean_Int32_Int32_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671377);
			ControllerMapWithAxes.NativeMethodInfoPtr_teqztrbAqTZVCCoFEjwvvSHRGEk_Internal_Virtual_Int32_Int32_Int32_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671378);
			ControllerMapWithAxes.NativeMethodInfoPtr_JdVUVNJPHwHxPyXczWRByiOaIXUh_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671379);
			ControllerMapWithAxes.NativeMethodInfoPtr_KCTHKrAKfHHIDNmtElTQsSmTJvlX_Internal_Int32_Boolean_List_1_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671380);
			ControllerMapWithAxes.NativeMethodInfoPtr_HEXOuPoKoHyxHgHXyJRnCQvdupe_Internal_Int32_Int32_Boolean_List_1_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671381);
			ControllerMapWithAxes.NativeMethodInfoPtr_iSFhwfbfHUyTcHLybWtLmKOPtJn_Internal_Virtual_Int32_Int32_Boolean_List_1_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671382);
			ControllerMapWithAxes.NativeMethodInfoPtr_StkmVggnjXvZWLSLaheVvITrMyC_Internal_Virtual_ActionElementMap_IControllerElementTarget_Boolean_Int32_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671383);
			ControllerMapWithAxes.NativeMethodInfoPtr_GbOyZMpluwEpxUBMojKQUpmNtct_Internal_Virtual_Int32_IControllerElementTarget_Boolean_Int32_Boolean_List_1_ActionElementMap_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671384);
			ControllerMapWithAxes.NativeMethodInfoPtr_DCtffHijKLZaPrLAwgPZFXWxlNXc_Internal_Virtual_Boolean_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671385);
			ControllerMapWithAxes.NativeMethodInfoPtr_gOOUajsGtGwFwgTJjaYiHDzwknI_Private_Boolean_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671386);
			ControllerMapWithAxes.NativeMethodInfoPtr_rIfujbvLzSoLSXnvSrqNTFRRMnE_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671387);
			ControllerMapWithAxes.NativeMethodInfoPtr_ZtEARADKZGFfwQXAhIWnuGbWAJeB_Private_Void_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671388);
			ControllerMapWithAxes.NativeMethodInfoPtr_MvMEtBCKneGwsctbkRMkgoiiCwMr_Private_Void_ActionElementMap_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671389);
			ControllerMapWithAxes.NativeMethodInfoPtr_oNyGkjXkFDvVnHlPrDgpKRwoJAQ_Internal_Virtual_Void_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671390);
			ControllerMapWithAxes.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Internal_Virtual_Boolean_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671391);
			ControllerMapWithAxes.NativeMethodInfoPtr_ZkpWgLgYsqnxQihYOYbxIAFsQgq_Private_IEnumerable_1_ElementAssignmentConflictInfo_ControllerMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671392);
			ControllerMapWithAxes.NativeMethodInfoPtr_iNrcnvfDVrkICGaxLpkdmahQogKF_Private_IEnumerable_1_ElementAssignmentConflictInfo_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671393);
			ControllerMapWithAxes.NativeMethodInfoPtr_amYHqIYDeIuIymhAspddaEDccPk_Private_IEnumerable_1_ElementAssignmentConflictInfo_ElementAssignmentConflictCheck_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, 100671394);
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x000BCE50 File Offset: 0x000BB050
		public unsafe int axisMapCount
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 293001, RefRangeEnd = 293017, XrefRangeStart = 292992, XrefRangeEnd = 293001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_get_axisMapCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x060024FE RID: 9470 RVA: 0x000BCE8C File Offset: 0x000BB08C
		public unsafe IList<ActionElementMap> AxisMaps
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 293022, RefRangeEnd = 293033, XrefRangeStart = 293017, XrefRangeEnd = 293022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_get_AxisMaps_Public_get_IList_1_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ActionElementMap>>(intPtr3) : null;
			}
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x000BCECC File Offset: 0x000BB0CC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 293046, RefRangeEnd = 293058, XrefRangeStart = 293033, XrefRangeEnd = 293046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapWithAxes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x000BCF08 File Offset: 0x000BB108
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 293087, RefRangeEnd = 293090, XrefRangeStart = 293058, XrefRangeEnd = 293087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapWithAxes(ControllerMapWithAxes controllerMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controllerMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr__ctor_Public_Void_ControllerMapWithAxes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x000BCF54 File Offset: 0x000BB154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293090, XrefRangeEnd = 293110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ContainsAction(int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_ContainsAction_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x000BCFA8 File Offset: 0x000BB1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293110, XrefRangeEnd = 293127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisContribution;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisRange;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_CreateElementMap_Public_Virtual_Boolean_Int32_Pole_Int32_ControllerElementType_AxisRange_Boolean_byref_ActionElementMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new ActionElementMap(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x000BD068 File Offset: 0x000BB268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293127, XrefRangeEnd = 293145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementMapId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisContribution;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisRange;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_ReplaceElementMap_Public_Virtual_Boolean_Int32_Int32_Pole_Int32_ControllerElementType_AxisRange_Boolean_byref_ActionElementMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new ActionElementMap(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x000BD134 File Offset: 0x000BB334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293145, XrefRangeEnd = 293155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DeleteElementMap(int elementMapId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementMapId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_DeleteElementMap_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x000BD188 File Offset: 0x000BB388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293155, XrefRangeEnd = 293164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DeleteElementMapsWithAction(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_DeleteElementMapsWithAction_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x000BD1E0 File Offset: 0x000BB3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293164, XrefRangeEnd = 293170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DeleteElementMapsWithAction(int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_DeleteElementMapsWithAction_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x000BD234 File Offset: 0x000BB434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293170, XrefRangeEnd = 293187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ActionElementMap GetElementMap(int elementMapId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementMapId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_GetElementMap_Public_Virtual_ActionElementMap_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
			}
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x000BD28C File Offset: 0x000BB48C
		[CallerCount(0)]
		public unsafe override ActionElementMap GetFirstElementMapWithAction(int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_GetFirstElementMapWithAction_Public_Virtual_ActionElementMap_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
			}
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x000BD2E4 File Offset: 0x000BB4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293187, XrefRangeEnd = 293206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_GetFirstElementMapWithAction_Public_Virtual_ActionElementMap_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x000BD34C File Offset: 0x000BB54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293206, XrefRangeEnd = 293208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ActionElementMap QSBalQiqduUdRvmxdfYovGyJOxiP(Predicate<ActionElementMap> A_1, bool A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_QSBalQiqduUdRvmxdfYovGyJOxiP_Internal_Virtual_ActionElementMap_Predicate_1_ActionElementMap_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x000BD3B8 File Offset: 0x000BB5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293208, XrefRangeEnd = 293210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int aegqTNsHvLTdITDAEjZRkMSDAOWk(Predicate<ActionElementMap> A_1, bool A_2, List<ActionElementMap> A_3, bool A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_aegqTNsHvLTdITDAEjZRkMSDAOWk_Internal_Virtual_Int32_Predicate_1_ActionElementMap_Boolean_List_1_ActionElementMap_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x000BD440 File Offset: 0x000BB640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293210, XrefRangeEnd = 293230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearElementMaps()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_ClearElementMaps_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x000BD47C File Offset: 0x000BB67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293230, XrefRangeEnd = 293241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap GetAxisMap(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMap_Public_ActionElementMap_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
			}
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x000BD4C8 File Offset: 0x000BB6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293241, XrefRangeEnd = 293251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<ActionElementMap> GetAxisMaps()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMaps_Public_Il2CppReferenceArray_1_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ActionElementMap>>(intPtr3) : null;
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x000BD508 File Offset: 0x000BB708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293275, RefRangeEnd = 293276, XrefRangeStart = 293251, XrefRangeEnd = 293275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<ActionElementMap> GetAxisMaps(bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipDisabledMaps;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMaps_Public_Il2CppReferenceArray_1_ActionElementMap_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ActionElementMap>>(intPtr3) : null;
			}
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x000BD554 File Offset: 0x000BB754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293276, XrefRangeEnd = 293284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAxisMaps(bool skipDisabledMaps, List<ActionElementMap> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipDisabledMaps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMaps_Public_Int32_Boolean_List_1_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x000BD5B0 File Offset: 0x000BB7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293284, XrefRangeEnd = 293298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<ActionElementMap> GetAxisMapsWithAction(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Il2CppReferenceArray_1_ActionElementMap_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ActionElementMap>>(intPtr3) : null;
			}
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x000BD600 File Offset: 0x000BB800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293298, XrefRangeEnd = 293299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<ActionElementMap> GetAxisMapsWithAction(int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Il2CppReferenceArray_1_ActionElementMap_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ActionElementMap>>(intPtr3) : null;
			}
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x000BD64C File Offset: 0x000BB84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293299, XrefRangeEnd = 293313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<ActionElementMap> GetAxisMapsWithAction(string actionName, bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Il2CppReferenceArray_1_ActionElementMap_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ActionElementMap>>(intPtr3) : null;
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x000BD6AC File Offset: 0x000BB8AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 293332, RefRangeEnd = 293335, XrefRangeStart = 293313, XrefRangeEnd = 293332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<ActionElementMap> GetAxisMapsWithAction(int actionId, bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Il2CppReferenceArray_1_ActionElementMap_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ActionElementMap>>(intPtr3) : null;
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x000BD708 File Offset: 0x000BB908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293335, XrefRangeEnd = 293351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAxisMapsWithAction(string actionName, List<ActionElementMap> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Int32_String_List_1_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x000BD768 File Offset: 0x000BB968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293351, XrefRangeEnd = 293352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAxisMapsWithAction(int actionId, List<ActionElementMap> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Int32_Int32_List_1_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x000BD7C4 File Offset: 0x000BB9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293352, XrefRangeEnd = 293368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAxisMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Int32_String_Boolean_List_1_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x000BD834 File Offset: 0x000BBA34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 293376, RefRangeEnd = 293379, XrefRangeStart = 293368, XrefRangeEnd = 293376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAxisMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Int32_Int32_Boolean_List_1_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x000BD8A0 File Offset: 0x000BBAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293379, XrefRangeEnd = 293393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ActionElementMap> AxisMapsWithAction(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_AxisMapsWithAction_Public_IEnumerable_1_ActionElementMap_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ActionElementMap>>(intPtr3) : null;
			}
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x000BD8F0 File Offset: 0x000BBAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293393, XrefRangeEnd = 293394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ActionElementMap> AxisMapsWithAction(int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_AxisMapsWithAction_Public_IEnumerable_1_ActionElementMap_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ActionElementMap>>(intPtr3) : null;
			}
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x000BD93C File Offset: 0x000BBB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293394, XrefRangeEnd = 293401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ActionElementMap> AxisMapsWithAction(string actionName, bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_AxisMapsWithAction_Public_IEnumerable_1_ActionElementMap_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ActionElementMap>>(intPtr3) : null;
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x000BD99C File Offset: 0x000BBB9C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 293406, RefRangeEnd = 293412, XrefRangeStart = 293401, XrefRangeEnd = 293406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ActionElementMap> AxisMapsWithAction(int actionId, bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_AxisMapsWithAction_Public_IEnumerable_1_ActionElementMap_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ActionElementMap>>(intPtr3) : null;
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x000BD9F8 File Offset: 0x000BBBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293412, XrefRangeEnd = 293419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap GetFirstAxisMapWithAction(int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetFirstAxisMapWithAction_Public_ActionElementMap_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
			}
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x000BDA44 File Offset: 0x000BBC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293419, XrefRangeEnd = 293433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap GetFirstAxisMapWithAction(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetFirstAxisMapWithAction_Public_ActionElementMap_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
			}
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x000BDA94 File Offset: 0x000BBC94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 293443, RefRangeEnd = 293448, XrefRangeStart = 293433, XrefRangeEnd = 293443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap GetFirstAxisMapWithAction(int actionId, bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetFirstAxisMapWithAction_Public_ActionElementMap_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x000BDAF0 File Offset: 0x000BBCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293448, XrefRangeEnd = 293459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap GetFirstAxisMapWithAction(string actionName, bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetFirstAxisMapWithAction_Public_ActionElementMap_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x000BDB50 File Offset: 0x000BBD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293459, XrefRangeEnd = 293466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap GetFirstAxisMapMatch(Predicate<ActionElementMap> predicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetFirstAxisMapMatch_Public_ActionElementMap_Predicate_1_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
			}
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x000BDBA0 File Offset: 0x000BBDA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293474, RefRangeEnd = 293476, XrefRangeStart = 293466, XrefRangeEnd = 293474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap gsBQZMDqHonJLMKIcuisINjEZTK(Predicate<ActionElementMap> A_1, bool A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_gsBQZMDqHonJLMKIcuisINjEZTK_Internal_ActionElementMap_Predicate_1_ActionElementMap_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x000BDC00 File Offset: 0x000BBE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293476, XrefRangeEnd = 293484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAxisMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisMapMatches_Public_Int32_Predicate_1_ActionElementMap_List_1_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x000BDC60 File Offset: 0x000BBE60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293508, RefRangeEnd = 293510, XrefRangeStart = 293484, XrefRangeEnd = 293508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int aLZheiXCOPNPsutBmesEwddMfuvd(Predicate<ActionElementMap> A_1, bool A_2, List<ActionElementMap> A_3, bool A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_aLZheiXCOPNPsutBmesEwddMfuvd_Internal_Int32_Predicate_1_ActionElementMap_Boolean_List_1_ActionElementMap_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x000BDCDC File Offset: 0x000BBEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293510, XrefRangeEnd = 293536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForEachAxisMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionToPerform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_ForEachAxisMapMatch_Public_Void_Predicate_1_ActionElementMap_Action_1_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x000BDD30 File Offset: 0x000BBF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293536, XrefRangeEnd = 293543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeleteAxisMapsWithAction(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_DeleteAxisMapsWithAction_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x000BDD80 File Offset: 0x000BBF80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293554, RefRangeEnd = 293556, XrefRangeStart = 293543, XrefRangeEnd = 293554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeleteAxisMapsWithAction(int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_DeleteAxisMapsWithAction_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x000BDDCC File Offset: 0x000BBFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293556, XrefRangeEnd = 293566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SetAllAxisMapsEnabled(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_SetAllAxisMapsEnabled_Public_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x000BDE18 File Offset: 0x000BC018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293566, XrefRangeEnd = 293583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesElementAssignmentConflict(ControllerMap controllerMap, bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controllerMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_DoesElementAssignmentConflict_Public_Virtual_Boolean_ControllerMap_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x000BDE80 File Offset: 0x000BC080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293583, XrefRangeEnd = 293606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesElementAssignmentConflict(ActionElementMap actionElementMap, bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actionElementMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_DoesElementAssignmentConflict_Public_Virtual_Boolean_ActionElementMap_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x000BDEE8 File Offset: 0x000BC0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293606, XrefRangeEnd = 293619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref conflictCheck;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_DoesElementAssignmentConflict_Public_Virtual_Boolean_ElementAssignmentConflictCheck_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x000BDF4C File Offset: 0x000BC14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293619, XrefRangeEnd = 293624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controllerMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_ElementAssignmentConflicts_Public_Virtual_IEnumerable_1_ElementAssignmentConflictInfo_ControllerMap_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ElementAssignmentConflictInfo>>(intPtr3) : null;
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x000BDFB8 File Offset: 0x000BC1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293624, XrefRangeEnd = 293629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actionElementMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_ElementAssignmentConflicts_Public_Virtual_IEnumerable_1_ElementAssignmentConflictInfo_ActionElementMap_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ElementAssignmentConflictInfo>>(intPtr3) : null;
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x000BE024 File Offset: 0x000BC224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293629, XrefRangeEnd = 293634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref conflictCheck;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_ElementAssignmentConflicts_Public_Virtual_IEnumerable_1_ElementAssignmentConflictInfo_ElementAssignmentConflictCheck_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ElementAssignmentConflictInfo>>(intPtr3) : null;
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x000BE08C File Offset: 0x000BC28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293634, XrefRangeEnd = 293659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int RemoveElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controllerMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_RemoveElementAssignmentConflicts_Public_Virtual_Int32_ControllerMap_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x000BE0F4 File Offset: 0x000BC2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293659, XrefRangeEnd = 293675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actionElementMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_RemoveElementAssignmentConflicts_Public_Virtual_Int32_ActionElementMap_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x000BE15C File Offset: 0x000BC35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293675, XrefRangeEnd = 293693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref conflictCheck;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabledMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_RemoveElementAssignmentConflicts_Public_Virtual_Int32_ElementAssignmentConflictCheck_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x000BE1C0 File Offset: 0x000BC3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293693, XrefRangeEnd = 293715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int xsYhlPPJRgBvzsYlltDclbtuhko(ControllerMap A_1, bool A_2, List<ActionElementMap> A_3, bool A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_xsYhlPPJRgBvzsYlltDclbtuhko_Internal_Virtual_Int32_ControllerMap_Boolean_List_1_ActionElementMap_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x000BE248 File Offset: 0x000BC448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293715, XrefRangeEnd = 293729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int xsYhlPPJRgBvzsYlltDclbtuhko(ActionElementMap A_1, bool A_2, List<ActionElementMap> A_3, bool A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_xsYhlPPJRgBvzsYlltDclbtuhko_Internal_Virtual_Int32_ActionElementMap_Boolean_List_1_ActionElementMap_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x000BE2D0 File Offset: 0x000BC4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293729, XrefRangeEnd = 293746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int xsYhlPPJRgBvzsYlltDclbtuhko(ElementAssignmentConflictCheck A_1, bool A_2, List<ActionElementMap> A_3, bool A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_xsYhlPPJRgBvzsYlltDclbtuhko_Internal_Virtual_Int32_ElementAssignmentConflictCheck_Boolean_List_1_ActionElementMap_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x000BE354 File Offset: 0x000BC554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293746, XrefRangeEnd = 293764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetAxisNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_GetAxisNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06002536 RID: 9526 RVA: 0x000BE394 File Offset: 0x000BC594
		public unsafe AList<ActionElementMap> AxisMaps_orig
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293766, RefRangeEnd = 293768, XrefRangeStart = 293764, XrefRangeEnd = 293766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_get_AxisMaps_orig_Internal_get_AList_1_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AList<ActionElementMap>>(intPtr3) : null;
			}
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000BE3D4 File Offset: 0x000BC5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293768, XrefRangeEnd = 293772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool bSFRctRNbUtpIPCEYIDqZnOAPwB(ActionElementMap A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_bSFRctRNbUtpIPCEYIDqZnOAPwB_Internal_Virtual_Boolean_ActionElementMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x000BE42C File Offset: 0x000BC62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293772, XrefRangeEnd = 293792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int OcNdzHyncEJGLQZxrJAfECCljAu(List<ActionElementMap> A_1, bool A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_OcNdzHyncEJGLQZxrJAfECCljAu_Internal_Virtual_Int32_List_1_ActionElementMap_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x000BE494 File Offset: 0x000BC694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293792, XrefRangeEnd = 293796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ActionElementMap vtqdkqhtGoVpIfYQRzwYDqGuOuoB(int A_1, int A_2, ControllerElementType A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_vtqdkqhtGoVpIfYQRzwYDqGuOuoB_Internal_Virtual_ActionElementMap_Int32_Int32_ControllerElementType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x000BE508 File Offset: 0x000BC708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293796, XrefRangeEnd = 293809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int SiIapBCXxCcaBcNAzTqjqCABediB(int A_1, List<ActionElementMap> A_2, bool A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_SiIapBCXxCcaBcNAzTqjqCABediB_Internal_Virtual_Int32_Int32_List_1_ActionElementMap_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x000BE57C File Offset: 0x000BC77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293809, XrefRangeEnd = 293817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool AsVROrbDObOiqzSvvgiEvZsMzFs(int A_1, int A_2, ControllerElementType A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_AsVROrbDObOiqzSvvgiEvZsMzFs_Internal_Virtual_Boolean_Int32_Int32_ControllerElementType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x000BE5EC File Offset: 0x000BC7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293817, XrefRangeEnd = 293825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int teqztrbAqTZVCCoFEjwvvSHRGEk(int A_1, int A_2, ControllerElementType A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_teqztrbAqTZVCCoFEjwvvSHRGEk_Internal_Virtual_Int32_Int32_Int32_ControllerElementType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x000BE65C File Offset: 0x000BC85C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293830, RefRangeEnd = 293831, XrefRangeStart = 293825, XrefRangeEnd = 293830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int JdVUVNJPHwHxPyXczWRByiOaIXUh(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_JdVUVNJPHwHxPyXczWRByiOaIXUh_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x000BE6A8 File Offset: 0x000BC8A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293840, RefRangeEnd = 293841, XrefRangeStart = 293831, XrefRangeEnd = 293840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int KCTHKrAKfHHIDNmtElTQsSmTJvlX(bool A_1, List<ActionElementMap> A_2, bool A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_KCTHKrAKfHHIDNmtElTQsSmTJvlX_Internal_Int32_Boolean_List_1_ActionElementMap_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x000BE714 File Offset: 0x000BC914
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 293850, RefRangeEnd = 293854, XrefRangeStart = 293841, XrefRangeEnd = 293850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int HEXOuPoKoHyxHgHXyJRnCQvdupe(int A_1, bool A_2, List<ActionElementMap> A_3, bool A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_HEXOuPoKoHyxHgHXyJRnCQvdupe_Internal_Int32_Int32_Boolean_List_1_ActionElementMap_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x000BE78C File Offset: 0x000BC98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293854, XrefRangeEnd = 293862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int iSFhwfbfHUyTcHLybWtLmKOPtJn(int A_1, bool A_2, List<ActionElementMap> A_3, bool A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_iSFhwfbfHUyTcHLybWtLmKOPtJn_Internal_Virtual_Int32_Int32_Boolean_List_1_ActionElementMap_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x000BE810 File Offset: 0x000BCA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293862, XrefRangeEnd = 293874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ActionElementMap StkmVggnjXvZWLSLaheVvITrMyC(IControllerElementTarget A_1, bool A_2, int A_3, bool A_4, out bool A_5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_5;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_StkmVggnjXvZWLSLaheVvITrMyC_Internal_Virtual_ActionElementMap_IControllerElementTarget_Boolean_Int32_Boolean_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x000BE8A4 File Offset: 0x000BCAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293874, XrefRangeEnd = 293890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GbOyZMpluwEpxUBMojKQUpmNtct(IControllerElementTarget A_1, bool A_2, int A_3, bool A_4, List<ActionElementMap> A_5, bool A_6, out bool A_7)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_5);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_6;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_GbOyZMpluwEpxUBMojKQUpmNtct_Internal_Virtual_Int32_IControllerElementTarget_Boolean_Int32_Boolean_List_1_ActionElementMap_Boolean_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x000BE958 File Offset: 0x000BCB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293890, XrefRangeEnd = 293897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DCtffHijKLZaPrLAwgPZFXWxlNXc(ActionElementMap A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_DCtffHijKLZaPrLAwgPZFXWxlNXc_Internal_Virtual_Boolean_ActionElementMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x000BE9B0 File Offset: 0x000BCBB0
		[CallerCount(0)]
		public new unsafe bool gOOUajsGtGwFwgTJjaYiHDzwknI(ControllerElementType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_gOOUajsGtGwFwgTJjaYiHDzwknI_Private_Boolean_ControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x000BE9FC File Offset: 0x000BCBFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 293904, RefRangeEnd = 293908, XrefRangeStart = 293897, XrefRangeEnd = 293904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void rIfujbvLzSoLSXnvSrqNTFRRMnE(int A_1, int A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_rIfujbvLzSoLSXnvSrqNTFRRMnE_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x000BEA48 File Offset: 0x000BCC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293908, XrefRangeEnd = 293911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZtEARADKZGFfwQXAhIWnuGbWAJeB(ActionElementMap A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_ZtEARADKZGFfwQXAhIWnuGbWAJeB_Private_Void_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x000BEA8C File Offset: 0x000BCC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293911, XrefRangeEnd = 293917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MvMEtBCKneGwsctbkRMkgoiiCwMr(ActionElementMap A_1, int A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_MvMEtBCKneGwsctbkRMkgoiiCwMr_Private_Void_ActionElementMap_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x000BEADC File Offset: 0x000BCCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293917, XrefRangeEnd = 293938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void oNyGkjXkFDvVnHlPrDgpKRwoJAQ(SerializedObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_oNyGkjXkFDvVnHlPrDgpKRwoJAQ_Internal_Virtual_Void_SerializedObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x000BEB2C File Offset: 0x000BCD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293938, XrefRangeEnd = 293959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool qMMTpeQwXdHPjVTnNgIqFdgetDa(SerializedObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerMapWithAxes.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Internal_Virtual_Boolean_SerializedObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x000BEB84 File Offset: 0x000BCD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ElementAssignmentConflictInfo> ZkpWgLgYsqnxQihYOYbxIAFsQgq(ControllerMap A_1, bool A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_ZkpWgLgYsqnxQihYOYbxIAFsQgq_Private_IEnumerable_1_ElementAssignmentConflictInfo_ControllerMap_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ElementAssignmentConflictInfo>>(intPtr3) : null;
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x000BEBE4 File Offset: 0x000BCDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ElementAssignmentConflictInfo> iNrcnvfDVrkICGaxLpkdmahQogKF(ActionElementMap A_1, bool A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_iNrcnvfDVrkICGaxLpkdmahQogKF_Private_IEnumerable_1_ElementAssignmentConflictInfo_ActionElementMap_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ElementAssignmentConflictInfo>>(intPtr3) : null;
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x000BEC44 File Offset: 0x000BCE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ElementAssignmentConflictInfo> amYHqIYDeIuIymhAspddaEDccPk(ElementAssignmentConflictCheck A_1, bool A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NativeMethodInfoPtr_amYHqIYDeIuIymhAspddaEDccPk_Private_IEnumerable_1_ElementAssignmentConflictInfo_ElementAssignmentConflictCheck_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ElementAssignmentConflictInfo>>(intPtr3) : null;
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x0000E932 File Offset: 0x0000CB32
		public ControllerMapWithAxes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x0600254E RID: 9550 RVA: 0x000BECA0 File Offset: 0x000BCEA0
		// (set) Token: 0x0600254F RID: 9551 RVA: 0x0000E93B File Offset: 0x0000CB3B
		public unsafe IList<ActionElementMap> FcQLJjvGMseogJykVTxLDaZznnIb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NativeFieldInfoPtr_FcQLJjvGMseogJykVTxLDaZznnIb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ActionElementMap>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NativeFieldInfoPtr_FcQLJjvGMseogJykVTxLDaZznnIb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06002550 RID: 9552 RVA: 0x000BECD0 File Offset: 0x000BCED0
		// (set) Token: 0x06002551 RID: 9553 RVA: 0x0000E95A File Offset: 0x0000CB5A
		public unsafe ReadOnlyCollection<ActionElementMap> yHwTsVrrptIRSKZhjwagtrFHVp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NativeFieldInfoPtr_yHwTsVrrptIRSKZhjwagtrFHVp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ActionElementMap>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NativeFieldInfoPtr_yHwTsVrrptIRSKZhjwagtrFHVp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E73 RID: 7795
		private static readonly IntPtr NativeFieldInfoPtr_FcQLJjvGMseogJykVTxLDaZznnIb;

		// Token: 0x04001E74 RID: 7796
		private static readonly IntPtr NativeFieldInfoPtr_yHwTsVrrptIRSKZhjwagtrFHVp;

		// Token: 0x04001E75 RID: 7797
		private static readonly IntPtr NativeMethodInfoPtr_get_axisMapCount_Public_get_Int32_0;

		// Token: 0x04001E76 RID: 7798
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisMaps_Public_get_IList_1_ActionElementMap_0;

		// Token: 0x04001E77 RID: 7799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E78 RID: 7800
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ControllerMapWithAxes_0;

		// Token: 0x04001E79 RID: 7801
		private static readonly IntPtr NativeMethodInfoPtr_ContainsAction_Public_Virtual_Boolean_Int32_0;

		// Token: 0x04001E7A RID: 7802
		private static readonly IntPtr NativeMethodInfoPtr_CreateElementMap_Public_Virtual_Boolean_Int32_Pole_Int32_ControllerElementType_AxisRange_Boolean_byref_ActionElementMap_0;

		// Token: 0x04001E7B RID: 7803
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceElementMap_Public_Virtual_Boolean_Int32_Int32_Pole_Int32_ControllerElementType_AxisRange_Boolean_byref_ActionElementMap_0;

		// Token: 0x04001E7C RID: 7804
		private static readonly IntPtr NativeMethodInfoPtr_DeleteElementMap_Public_Virtual_Boolean_Int32_0;

		// Token: 0x04001E7D RID: 7805
		private static readonly IntPtr NativeMethodInfoPtr_DeleteElementMapsWithAction_Public_Virtual_Boolean_String_0;

		// Token: 0x04001E7E RID: 7806
		private static readonly IntPtr NativeMethodInfoPtr_DeleteElementMapsWithAction_Public_Virtual_Boolean_Int32_0;

		// Token: 0x04001E7F RID: 7807
		private static readonly IntPtr NativeMethodInfoPtr_GetElementMap_Public_Virtual_ActionElementMap_Int32_0;

		// Token: 0x04001E80 RID: 7808
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstElementMapWithAction_Public_Virtual_ActionElementMap_Int32_0;

		// Token: 0x04001E81 RID: 7809
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstElementMapWithAction_Public_Virtual_ActionElementMap_Int32_Boolean_0;

		// Token: 0x04001E82 RID: 7810
		private static readonly IntPtr NativeMethodInfoPtr_QSBalQiqduUdRvmxdfYovGyJOxiP_Internal_Virtual_ActionElementMap_Predicate_1_ActionElementMap_Boolean_0;

		// Token: 0x04001E83 RID: 7811
		private static readonly IntPtr NativeMethodInfoPtr_aegqTNsHvLTdITDAEjZRkMSDAOWk_Internal_Virtual_Int32_Predicate_1_ActionElementMap_Boolean_List_1_ActionElementMap_Boolean_0;

		// Token: 0x04001E84 RID: 7812
		private static readonly IntPtr NativeMethodInfoPtr_ClearElementMaps_Public_Virtual_Void_0;

		// Token: 0x04001E85 RID: 7813
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisMap_Public_ActionElementMap_Int32_0;

		// Token: 0x04001E86 RID: 7814
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisMaps_Public_Il2CppReferenceArray_1_ActionElementMap_0;

		// Token: 0x04001E87 RID: 7815
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisMaps_Public_Il2CppReferenceArray_1_ActionElementMap_Boolean_0;

		// Token: 0x04001E88 RID: 7816
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisMaps_Public_Int32_Boolean_List_1_ActionElementMap_0;

		// Token: 0x04001E89 RID: 7817
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Il2CppReferenceArray_1_ActionElementMap_String_0;

		// Token: 0x04001E8A RID: 7818
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Il2CppReferenceArray_1_ActionElementMap_Int32_0;

		// Token: 0x04001E8B RID: 7819
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Il2CppReferenceArray_1_ActionElementMap_String_Boolean_0;

		// Token: 0x04001E8C RID: 7820
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Il2CppReferenceArray_1_ActionElementMap_Int32_Boolean_0;

		// Token: 0x04001E8D RID: 7821
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Int32_String_List_1_ActionElementMap_0;

		// Token: 0x04001E8E RID: 7822
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Int32_Int32_List_1_ActionElementMap_0;

		// Token: 0x04001E8F RID: 7823
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Int32_String_Boolean_List_1_ActionElementMap_0;

		// Token: 0x04001E90 RID: 7824
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisMapsWithAction_Public_Int32_Int32_Boolean_List_1_ActionElementMap_0;

		// Token: 0x04001E91 RID: 7825
		private static readonly IntPtr NativeMethodInfoPtr_AxisMapsWithAction_Public_IEnumerable_1_ActionElementMap_String_0;

		// Token: 0x04001E92 RID: 7826
		private static readonly IntPtr NativeMethodInfoPtr_AxisMapsWithAction_Public_IEnumerable_1_ActionElementMap_Int32_0;

		// Token: 0x04001E93 RID: 7827
		private static readonly IntPtr NativeMethodInfoPtr_AxisMapsWithAction_Public_IEnumerable_1_ActionElementMap_String_Boolean_0;

		// Token: 0x04001E94 RID: 7828
		private static readonly IntPtr NativeMethodInfoPtr_AxisMapsWithAction_Public_IEnumerable_1_ActionElementMap_Int32_Boolean_0;

		// Token: 0x04001E95 RID: 7829
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstAxisMapWithAction_Public_ActionElementMap_Int32_0;

		// Token: 0x04001E96 RID: 7830
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstAxisMapWithAction_Public_ActionElementMap_String_0;

		// Token: 0x04001E97 RID: 7831
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstAxisMapWithAction_Public_ActionElementMap_Int32_Boolean_0;

		// Token: 0x04001E98 RID: 7832
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstAxisMapWithAction_Public_ActionElementMap_String_Boolean_0;

		// Token: 0x04001E99 RID: 7833
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstAxisMapMatch_Public_ActionElementMap_Predicate_1_ActionElementMap_0;

		// Token: 0x04001E9A RID: 7834
		private static readonly IntPtr NativeMethodInfoPtr_gsBQZMDqHonJLMKIcuisINjEZTK_Internal_ActionElementMap_Predicate_1_ActionElementMap_Boolean_0;

		// Token: 0x04001E9B RID: 7835
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisMapMatches_Public_Int32_Predicate_1_ActionElementMap_List_1_ActionElementMap_0;

		// Token: 0x04001E9C RID: 7836
		private static readonly IntPtr NativeMethodInfoPtr_aLZheiXCOPNPsutBmesEwddMfuvd_Internal_Int32_Predicate_1_ActionElementMap_Boolean_List_1_ActionElementMap_Boolean_0;

		// Token: 0x04001E9D RID: 7837
		private static readonly IntPtr NativeMethodInfoPtr_ForEachAxisMapMatch_Public_Void_Predicate_1_ActionElementMap_Action_1_ActionElementMap_0;

		// Token: 0x04001E9E RID: 7838
		private static readonly IntPtr NativeMethodInfoPtr_DeleteAxisMapsWithAction_Public_Boolean_String_0;

		// Token: 0x04001E9F RID: 7839
		private static readonly IntPtr NativeMethodInfoPtr_DeleteAxisMapsWithAction_Public_Boolean_Int32_0;

		// Token: 0x04001EA0 RID: 7840
		private static readonly IntPtr NativeMethodInfoPtr_SetAllAxisMapsEnabled_Public_Int32_Boolean_0;

		// Token: 0x04001EA1 RID: 7841
		private static readonly IntPtr NativeMethodInfoPtr_DoesElementAssignmentConflict_Public_Virtual_Boolean_ControllerMap_Boolean_0;

		// Token: 0x04001EA2 RID: 7842
		private static readonly IntPtr NativeMethodInfoPtr_DoesElementAssignmentConflict_Public_Virtual_Boolean_ActionElementMap_Boolean_0;

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeMethodInfoPtr_DoesElementAssignmentConflict_Public_Virtual_Boolean_ElementAssignmentConflictCheck_Boolean_0;

		// Token: 0x04001EA4 RID: 7844
		private static readonly IntPtr NativeMethodInfoPtr_ElementAssignmentConflicts_Public_Virtual_IEnumerable_1_ElementAssignmentConflictInfo_ControllerMap_Boolean_0;

		// Token: 0x04001EA5 RID: 7845
		private static readonly IntPtr NativeMethodInfoPtr_ElementAssignmentConflicts_Public_Virtual_IEnumerable_1_ElementAssignmentConflictInfo_ActionElementMap_Boolean_0;

		// Token: 0x04001EA6 RID: 7846
		private static readonly IntPtr NativeMethodInfoPtr_ElementAssignmentConflicts_Public_Virtual_IEnumerable_1_ElementAssignmentConflictInfo_ElementAssignmentConflictCheck_Boolean_0;

		// Token: 0x04001EA7 RID: 7847
		private static readonly IntPtr NativeMethodInfoPtr_RemoveElementAssignmentConflicts_Public_Virtual_Int32_ControllerMap_Boolean_0;

		// Token: 0x04001EA8 RID: 7848
		private static readonly IntPtr NativeMethodInfoPtr_RemoveElementAssignmentConflicts_Public_Virtual_Int32_ActionElementMap_Boolean_0;

		// Token: 0x04001EA9 RID: 7849
		private static readonly IntPtr NativeMethodInfoPtr_RemoveElementAssignmentConflicts_Public_Virtual_Int32_ElementAssignmentConflictCheck_Boolean_0;

		// Token: 0x04001EAA RID: 7850
		private static readonly IntPtr NativeMethodInfoPtr_xsYhlPPJRgBvzsYlltDclbtuhko_Internal_Virtual_Int32_ControllerMap_Boolean_List_1_ActionElementMap_Boolean_0;

		// Token: 0x04001EAB RID: 7851
		private static readonly IntPtr NativeMethodInfoPtr_xsYhlPPJRgBvzsYlltDclbtuhko_Internal_Virtual_Int32_ActionElementMap_Boolean_List_1_ActionElementMap_Boolean_0;

		// Token: 0x04001EAC RID: 7852
		private static readonly IntPtr NativeMethodInfoPtr_xsYhlPPJRgBvzsYlltDclbtuhko_Internal_Virtual_Int32_ElementAssignmentConflictCheck_Boolean_List_1_ActionElementMap_Boolean_0;

		// Token: 0x04001EAD RID: 7853
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisNames_Public_Il2CppStringArray_0;

		// Token: 0x04001EAE RID: 7854
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisMaps_orig_Internal_get_AList_1_ActionElementMap_0;

		// Token: 0x04001EAF RID: 7855
		private static readonly IntPtr NativeMethodInfoPtr_bSFRctRNbUtpIPCEYIDqZnOAPwB_Internal_Virtual_Boolean_ActionElementMap_0;

		// Token: 0x04001EB0 RID: 7856
		private static readonly IntPtr NativeMethodInfoPtr_OcNdzHyncEJGLQZxrJAfECCljAu_Internal_Virtual_Int32_List_1_ActionElementMap_Boolean_0;

		// Token: 0x04001EB1 RID: 7857
		private static readonly IntPtr NativeMethodInfoPtr_vtqdkqhtGoVpIfYQRzwYDqGuOuoB_Internal_Virtual_ActionElementMap_Int32_Int32_ControllerElementType_0;

		// Token: 0x04001EB2 RID: 7858
		private static readonly IntPtr NativeMethodInfoPtr_SiIapBCXxCcaBcNAzTqjqCABediB_Internal_Virtual_Int32_Int32_List_1_ActionElementMap_Boolean_0;

		// Token: 0x04001EB3 RID: 7859
		private static readonly IntPtr NativeMethodInfoPtr_AsVROrbDObOiqzSvvgiEvZsMzFs_Internal_Virtual_Boolean_Int32_Int32_ControllerElementType_0;

		// Token: 0x04001EB4 RID: 7860
		private static readonly IntPtr NativeMethodInfoPtr_teqztrbAqTZVCCoFEjwvvSHRGEk_Internal_Virtual_Int32_Int32_Int32_ControllerElementType_0;

		// Token: 0x04001EB5 RID: 7861
		private static readonly IntPtr NativeMethodInfoPtr_JdVUVNJPHwHxPyXczWRByiOaIXUh_Internal_Int32_Int32_0;

		// Token: 0x04001EB6 RID: 7862
		private static readonly IntPtr NativeMethodInfoPtr_KCTHKrAKfHHIDNmtElTQsSmTJvlX_Internal_Int32_Boolean_List_1_ActionElementMap_Boolean_0;

		// Token: 0x04001EB7 RID: 7863
		private static readonly IntPtr NativeMethodInfoPtr_HEXOuPoKoHyxHgHXyJRnCQvdupe_Internal_Int32_Int32_Boolean_List_1_ActionElementMap_Boolean_0;

		// Token: 0x04001EB8 RID: 7864
		private static readonly IntPtr NativeMethodInfoPtr_iSFhwfbfHUyTcHLybWtLmKOPtJn_Internal_Virtual_Int32_Int32_Boolean_List_1_ActionElementMap_Boolean_0;

		// Token: 0x04001EB9 RID: 7865
		private static readonly IntPtr NativeMethodInfoPtr_StkmVggnjXvZWLSLaheVvITrMyC_Internal_Virtual_ActionElementMap_IControllerElementTarget_Boolean_Int32_Boolean_byref_Boolean_0;

		// Token: 0x04001EBA RID: 7866
		private static readonly IntPtr NativeMethodInfoPtr_GbOyZMpluwEpxUBMojKQUpmNtct_Internal_Virtual_Int32_IControllerElementTarget_Boolean_Int32_Boolean_List_1_ActionElementMap_Boolean_byref_Boolean_0;

		// Token: 0x04001EBB RID: 7867
		private static readonly IntPtr NativeMethodInfoPtr_DCtffHijKLZaPrLAwgPZFXWxlNXc_Internal_Virtual_Boolean_ActionElementMap_0;

		// Token: 0x04001EBC RID: 7868
		private static readonly IntPtr NativeMethodInfoPtr_gOOUajsGtGwFwgTJjaYiHDzwknI_Private_Boolean_ControllerElementType_0;

		// Token: 0x04001EBD RID: 7869
		private static readonly IntPtr NativeMethodInfoPtr_rIfujbvLzSoLSXnvSrqNTFRRMnE_Private_Void_Int32_Int32_0;

		// Token: 0x04001EBE RID: 7870
		private static readonly IntPtr NativeMethodInfoPtr_ZtEARADKZGFfwQXAhIWnuGbWAJeB_Private_Void_ActionElementMap_0;

		// Token: 0x04001EBF RID: 7871
		private static readonly IntPtr NativeMethodInfoPtr_MvMEtBCKneGwsctbkRMkgoiiCwMr_Private_Void_ActionElementMap_Int32_0;

		// Token: 0x04001EC0 RID: 7872
		private static readonly IntPtr NativeMethodInfoPtr_oNyGkjXkFDvVnHlPrDgpKRwoJAQ_Internal_Virtual_Void_SerializedObject_0;

		// Token: 0x04001EC1 RID: 7873
		private static readonly IntPtr NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Internal_Virtual_Boolean_SerializedObject_0;

		// Token: 0x04001EC2 RID: 7874
		private static readonly IntPtr NativeMethodInfoPtr_ZkpWgLgYsqnxQihYOYbxIAFsQgq_Private_IEnumerable_1_ElementAssignmentConflictInfo_ControllerMap_Boolean_0;

		// Token: 0x04001EC3 RID: 7875
		private static readonly IntPtr NativeMethodInfoPtr_iNrcnvfDVrkICGaxLpkdmahQogKF_Private_IEnumerable_1_ElementAssignmentConflictInfo_ActionElementMap_Boolean_0;

		// Token: 0x04001EC4 RID: 7876
		private static readonly IntPtr NativeMethodInfoPtr_amYHqIYDeIuIymhAspddaEDccPk_Private_IEnumerable_1_ElementAssignmentConflictInfo_ElementAssignmentConflictCheck_Boolean_0;

		// Token: 0x0200036F RID: 879
		public sealed class AsmwnTUUhyRueHEVRDDQiPdVTUa : Object
		{
			// Token: 0x0600490D RID: 18701 RVA: 0x0015022C File Offset: 0x0014E42C
			// Note: this type is marked as 'beforefieldinit'.
			static AsmwnTUUhyRueHEVRDDQiPdVTUa()
			{
				Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, "AsmwnTUUhyRueHEVRDDQiPdVTUa");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr);
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_jNQTdRTTjCCEILGnXmvKFjBTfEZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, "jNQTdRTTjCCEILGnXmvKFjBTfEZ");
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_nLzdDJIvQCKPOrrnfJeNsrxGBBe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, "nLzdDJIvQCKPOrrnfJeNsrxGBBe");
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_JgrRRPnIJYeRFKDvcRjGruwTBfWB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, "JgrRRPnIJYeRFKDvcRjGruwTBfWB");
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_QqLdfsBGGoMLKzXMnVICRmVbbela = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, "QqLdfsBGGoMLKzXMnVICRmVbbela");
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_BuonUWIgeUmBokGZpJGTazDuytS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, "BuonUWIgeUmBokGZpJGTazDuytS");
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_rhchZhdRnkBjBoQiOTCFSPbVEZSJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, "rhchZhdRnkBjBoQiOTCFSPbVEZSJ");
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ActionElementMap__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, 100671395);
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, 100671396);
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, 100671397);
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ActionElementMap__get_Current_Private_Virtual_Final_New_get_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, 100671398);
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, 100671399);
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, 100671400);
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, 100671401);
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, 100671402);
				ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr_diNflMjytoHkqhmxMyhXfXhJqKKt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr, 100671403);
			}

			// Token: 0x0600490E RID: 18702 RVA: 0x001503D4 File Offset: 0x0014E5D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292748, XrefRangeEnd = 292756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ActionElementMap> System_Collections_Generic_IEnumerable_Rewired_ActionElementMap__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ActionElementMap__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ActionElementMap>>(intPtr3) : null;
			}

			// Token: 0x0600490F RID: 18703 RVA: 0x00150414 File Offset: 0x0014E614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004910 RID: 18704 RVA: 0x00150454 File Offset: 0x0014E654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292756, XrefRangeEnd = 292777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170016E2 RID: 5858
			// (get) Token: 0x06004911 RID: 18705 RVA: 0x00150490 File Offset: 0x0014E690
			public unsafe ActionElementMap HnmefHEcpMxYCxZVnKBQTKoYjyM
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ActionElementMap__get_Current_Private_Virtual_Final_New_get_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
				}
			}

			// Token: 0x06004912 RID: 18706 RVA: 0x001504D0 File Offset: 0x0014E6D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292777, XrefRangeEnd = 292782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004913 RID: 18707 RVA: 0x00150504 File Offset: 0x0014E704
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 292785, RefRangeEnd = 292786, XrefRangeStart = 292782, XrefRangeEnd = 292785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170016E3 RID: 5859
			// (get) Token: 0x06004914 RID: 18708 RVA: 0x00150538 File Offset: 0x0014E738
			public unsafe Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004915 RID: 18709 RVA: 0x00150578 File Offset: 0x0014E778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsmwnTUUhyRueHEVRDDQiPdVTUa(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004916 RID: 18710 RVA: 0x001505C0 File Offset: 0x0014E7C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 292789, RefRangeEnd = 292790, XrefRangeStart = 292786, XrefRangeEnd = 292789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void diNflMjytoHkqhmxMyhXfXhJqKKt()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeMethodInfoPtr_diNflMjytoHkqhmxMyhXfXhJqKKt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004917 RID: 18711 RVA: 0x0001AAF2 File Offset: 0x00018CF2
			public AsmwnTUUhyRueHEVRDDQiPdVTUa(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016D8 RID: 5848
			// (get) Token: 0x06004918 RID: 18712 RVA: 0x001505F4 File Offset: 0x0014E7F4
			// (set) Token: 0x06004919 RID: 18713 RVA: 0x0001AAFB File Offset: 0x00018CFB
			public unsafe ActionElementMap NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016D9 RID: 5849
			// (get) Token: 0x0600491A RID: 18714 RVA: 0x00150624 File Offset: 0x0014E824
			// (set) Token: 0x0600491B RID: 18715 RVA: 0x0001AB1A File Offset: 0x00018D1A
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x170016DA RID: 5850
			// (get) Token: 0x0600491C RID: 18716 RVA: 0x0015064C File Offset: 0x0014E84C
			// (set) Token: 0x0600491D RID: 18717 RVA: 0x0001AB35 File Offset: 0x00018D35
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x170016DB RID: 5851
			// (get) Token: 0x0600491E RID: 18718 RVA: 0x00150674 File Offset: 0x0014E874
			// (set) Token: 0x0600491F RID: 18719 RVA: 0x0001AB50 File Offset: 0x00018D50
			public unsafe ControllerMapWithAxes HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMapWithAxes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016DC RID: 5852
			// (get) Token: 0x06004920 RID: 18720 RVA: 0x001506A4 File Offset: 0x0014E8A4
			// (set) Token: 0x06004921 RID: 18721 RVA: 0x0001AB6F File Offset: 0x00018D6F
			public unsafe int jNQTdRTTjCCEILGnXmvKFjBTfEZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_jNQTdRTTjCCEILGnXmvKFjBTfEZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_jNQTdRTTjCCEILGnXmvKFjBTfEZ)) = value;
				}
			}

			// Token: 0x170016DD RID: 5853
			// (get) Token: 0x06004922 RID: 18722 RVA: 0x001506CC File Offset: 0x0014E8CC
			// (set) Token: 0x06004923 RID: 18723 RVA: 0x0001AB8A File Offset: 0x00018D8A
			public unsafe int nLzdDJIvQCKPOrrnfJeNsrxGBBe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_nLzdDJIvQCKPOrrnfJeNsrxGBBe);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_nLzdDJIvQCKPOrrnfJeNsrxGBBe)) = value;
				}
			}

			// Token: 0x170016DE RID: 5854
			// (get) Token: 0x06004924 RID: 18724 RVA: 0x001506F4 File Offset: 0x0014E8F4
			// (set) Token: 0x06004925 RID: 18725 RVA: 0x0001ABA5 File Offset: 0x00018DA5
			public unsafe bool JgrRRPnIJYeRFKDvcRjGruwTBfWB
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_JgrRRPnIJYeRFKDvcRjGruwTBfWB);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_JgrRRPnIJYeRFKDvcRjGruwTBfWB)) = value;
				}
			}

			// Token: 0x170016DF RID: 5855
			// (get) Token: 0x06004926 RID: 18726 RVA: 0x0015071C File Offset: 0x0014E91C
			// (set) Token: 0x06004927 RID: 18727 RVA: 0x0001ABC0 File Offset: 0x00018DC0
			public unsafe bool QqLdfsBGGoMLKzXMnVICRmVbbela
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_QqLdfsBGGoMLKzXMnVICRmVbbela);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_QqLdfsBGGoMLKzXMnVICRmVbbela)) = value;
				}
			}

			// Token: 0x170016E0 RID: 5856
			// (get) Token: 0x06004928 RID: 18728 RVA: 0x00150744 File Offset: 0x0014E944
			// (set) Token: 0x06004929 RID: 18729 RVA: 0x0001ABDB File Offset: 0x00018DDB
			public unsafe ActionElementMap BuonUWIgeUmBokGZpJGTazDuytS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_BuonUWIgeUmBokGZpJGTazDuytS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_BuonUWIgeUmBokGZpJGTazDuytS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016E1 RID: 5857
			// (get) Token: 0x0600492A RID: 18730 RVA: 0x00150774 File Offset: 0x0014E974
			// (set) Token: 0x0600492B RID: 18731 RVA: 0x0001ABFA File Offset: 0x00018DFA
			public unsafe IEnumerator<ActionElementMap> rhchZhdRnkBjBoQiOTCFSPbVEZSJ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_rhchZhdRnkBjBoQiOTCFSPbVEZSJ);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<ActionElementMap>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.AsmwnTUUhyRueHEVRDDQiPdVTUa.NativeFieldInfoPtr_rhchZhdRnkBjBoQiOTCFSPbVEZSJ), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B4A RID: 15178
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04003B4B RID: 15179
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04003B4C RID: 15180
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x04003B4D RID: 15181
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x04003B4E RID: 15182
			private static readonly IntPtr NativeFieldInfoPtr_jNQTdRTTjCCEILGnXmvKFjBTfEZ;

			// Token: 0x04003B4F RID: 15183
			private static readonly IntPtr NativeFieldInfoPtr_nLzdDJIvQCKPOrrnfJeNsrxGBBe;

			// Token: 0x04003B50 RID: 15184
			private static readonly IntPtr NativeFieldInfoPtr_JgrRRPnIJYeRFKDvcRjGruwTBfWB;

			// Token: 0x04003B51 RID: 15185
			private static readonly IntPtr NativeFieldInfoPtr_QqLdfsBGGoMLKzXMnVICRmVbbela;

			// Token: 0x04003B52 RID: 15186
			private static readonly IntPtr NativeFieldInfoPtr_BuonUWIgeUmBokGZpJGTazDuytS;

			// Token: 0x04003B53 RID: 15187
			private static readonly IntPtr NativeFieldInfoPtr_rhchZhdRnkBjBoQiOTCFSPbVEZSJ;

			// Token: 0x04003B54 RID: 15188
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ActionElementMap__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ActionElementMap_0;

			// Token: 0x04003B55 RID: 15189
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04003B56 RID: 15190
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003B57 RID: 15191
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ActionElementMap__get_Current_Private_Virtual_Final_New_get_ActionElementMap_0;

			// Token: 0x04003B58 RID: 15192
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B59 RID: 15193
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B5A RID: 15194
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003B5B RID: 15195
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003B5C RID: 15196
			private static readonly IntPtr NativeMethodInfoPtr_diNflMjytoHkqhmxMyhXfXhJqKKt_Private_Void_0;
		}

		// Token: 0x02000370 RID: 880
		public sealed class JcjvjDiaIDJlgDVGvEUbVqvDdjl : Object
		{
			// Token: 0x0600492C RID: 18732 RVA: 0x001507A4 File Offset: 0x0014E9A4
			// Note: this type is marked as 'beforefieldinit'.
			static JcjvjDiaIDJlgDVGvEUbVqvDdjl()
			{
				Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, "JcjvjDiaIDJlgDVGvEUbVqvDdjl");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr);
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_wCYpVdLjaxZjWfQGGAeANYlMhdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "wCYpVdLjaxZjWfQGGAeANYlMhdr");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_nwrYBLWBwzcJOlYSYhlLHQEGbyZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "nwrYBLWBwzcJOlYSYhlLHQEGbyZ");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_JgrRRPnIJYeRFKDvcRjGruwTBfWB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "JgrRRPnIJYeRFKDvcRjGruwTBfWB");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_QqLdfsBGGoMLKzXMnVICRmVbbela = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "QqLdfsBGGoMLKzXMnVICRmVbbela");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_bLPGfELsppZJrGZxWmbFAooniHA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "bLPGfELsppZJrGZxWmbFAooniHA");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_pUSgQnMOxHDzfFdAuAXUJxUUPTP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "pUSgQnMOxHDzfFdAuAXUJxUUPTP");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_ZoKRexnYYxAeFrNikFWhVsBtrKJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "ZoKRexnYYxAeFrNikFWhVsBtrKJ");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_DAhlDpakCJMcoZXBBKDPCwBgmYo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "DAhlDpakCJMcoZXBBKDPCwBgmYo");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_ZbbwwonUZApjcsYMrktbTOlytb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "ZbbwwonUZApjcsYMrktbTOlytb");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_zIVwGmoeOJFjtmrPyURrvkSrhk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "zIVwGmoeOJFjtmrPyURrvkSrhk");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_uxypMxxmiyTuIhctmYNxLrnpUuH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "uxypMxxmiyTuIhctmYNxLrnpUuH");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_qWdOKVbpLjoqAiXPHxWzflXerVm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "qWdOKVbpLjoqAiXPHxWzflXerVm");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_NQCAcSEbWyXboGJHalZSbUuDHmFS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, "NQCAcSEbWyXboGJHalZSbUuDHmFS");
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ElementAssignmentConflictInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ElementAssignmentConflictInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, 100671404);
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, 100671405);
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, 100671406);
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ElementAssignmentConflictInfo__get_Current_Private_Virtual_Final_New_get_ElementAssignmentConflictInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, 100671407);
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, 100671408);
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, 100671409);
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, 100671410);
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, 100671411);
				ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr_agwJmkDDUPobHOhcpdLRunRaqeG_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr, 100671412);
			}

			// Token: 0x0600492D RID: 18733 RVA: 0x001509D8 File Offset: 0x0014EBD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292790, XrefRangeEnd = 292798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ElementAssignmentConflictInfo> System_Collections_Generic_IEnumerable_Rewired_ElementAssignmentConflictInfo__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ElementAssignmentConflictInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ElementAssignmentConflictInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ElementAssignmentConflictInfo>>(intPtr3) : null;
			}

			// Token: 0x0600492E RID: 18734 RVA: 0x00150A18 File Offset: 0x0014EC18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600492F RID: 18735 RVA: 0x00150A58 File Offset: 0x0014EC58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292798, XrefRangeEnd = 292846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170016F5 RID: 5877
			// (get) Token: 0x06004930 RID: 18736 RVA: 0x00150A94 File Offset: 0x0014EC94
			public unsafe ElementAssignmentConflictInfo qVRQfYTrRfWCLbEbcWFmEUokinl
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ElementAssignmentConflictInfo__get_Current_Private_Virtual_Final_New_get_ElementAssignmentConflictInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004931 RID: 18737 RVA: 0x00150AD0 File Offset: 0x0014ECD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292846, XrefRangeEnd = 292851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004932 RID: 18738 RVA: 0x00150B04 File Offset: 0x0014ED04
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 292854, RefRangeEnd = 292855, XrefRangeStart = 292851, XrefRangeEnd = 292854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170016F6 RID: 5878
			// (get) Token: 0x06004933 RID: 18739 RVA: 0x00150B38 File Offset: 0x0014ED38
			public unsafe Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292855, XrefRangeEnd = 292858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004934 RID: 18740 RVA: 0x00150B78 File Offset: 0x0014ED78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe JcjvjDiaIDJlgDVGvEUbVqvDdjl(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004935 RID: 18741 RVA: 0x00150BC0 File Offset: 0x0014EDC0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 292861, RefRangeEnd = 292862, XrefRangeStart = 292858, XrefRangeEnd = 292861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void agwJmkDDUPobHOhcpdLRunRaqeG()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeMethodInfoPtr_agwJmkDDUPobHOhcpdLRunRaqeG_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004936 RID: 18742 RVA: 0x0001AC19 File Offset: 0x00018E19
			public JcjvjDiaIDJlgDVGvEUbVqvDdjl(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016E4 RID: 5860
			// (get) Token: 0x06004937 RID: 18743 RVA: 0x00150BF4 File Offset: 0x0014EDF4
			// (set) Token: 0x06004938 RID: 18744 RVA: 0x0001AC22 File Offset: 0x00018E22
			public unsafe ElementAssignmentConflictInfo NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG)) = value;
				}
			}

			// Token: 0x170016E5 RID: 5861
			// (get) Token: 0x06004939 RID: 18745 RVA: 0x00150C1C File Offset: 0x0014EE1C
			// (set) Token: 0x0600493A RID: 18746 RVA: 0x0001AC3D File Offset: 0x00018E3D
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x170016E6 RID: 5862
			// (get) Token: 0x0600493B RID: 18747 RVA: 0x00150C44 File Offset: 0x0014EE44
			// (set) Token: 0x0600493C RID: 18748 RVA: 0x0001AC58 File Offset: 0x00018E58
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x170016E7 RID: 5863
			// (get) Token: 0x0600493D RID: 18749 RVA: 0x00150C6C File Offset: 0x0014EE6C
			// (set) Token: 0x0600493E RID: 18750 RVA: 0x0001AC73 File Offset: 0x00018E73
			public unsafe ControllerMapWithAxes HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMapWithAxes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016E8 RID: 5864
			// (get) Token: 0x0600493F RID: 18751 RVA: 0x00150C9C File Offset: 0x0014EE9C
			// (set) Token: 0x06004940 RID: 18752 RVA: 0x0001AC92 File Offset: 0x00018E92
			public unsafe ControllerMap wCYpVdLjaxZjWfQGGAeANYlMhdr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_wCYpVdLjaxZjWfQGGAeANYlMhdr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_wCYpVdLjaxZjWfQGGAeANYlMhdr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016E9 RID: 5865
			// (get) Token: 0x06004941 RID: 18753 RVA: 0x00150CCC File Offset: 0x0014EECC
			// (set) Token: 0x06004942 RID: 18754 RVA: 0x0001ACB1 File Offset: 0x00018EB1
			public unsafe ControllerMap nwrYBLWBwzcJOlYSYhlLHQEGbyZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_nwrYBLWBwzcJOlYSYhlLHQEGbyZ);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_nwrYBLWBwzcJOlYSYhlLHQEGbyZ), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016EA RID: 5866
			// (get) Token: 0x06004943 RID: 18755 RVA: 0x00150CFC File Offset: 0x0014EEFC
			// (set) Token: 0x06004944 RID: 18756 RVA: 0x0001ACD0 File Offset: 0x00018ED0
			public unsafe bool JgrRRPnIJYeRFKDvcRjGruwTBfWB
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_JgrRRPnIJYeRFKDvcRjGruwTBfWB);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_JgrRRPnIJYeRFKDvcRjGruwTBfWB)) = value;
				}
			}

			// Token: 0x170016EB RID: 5867
			// (get) Token: 0x06004945 RID: 18757 RVA: 0x00150D24 File Offset: 0x0014EF24
			// (set) Token: 0x06004946 RID: 18758 RVA: 0x0001ACEB File Offset: 0x00018EEB
			public unsafe bool QqLdfsBGGoMLKzXMnVICRmVbbela
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_QqLdfsBGGoMLKzXMnVICRmVbbela);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_QqLdfsBGGoMLKzXMnVICRmVbbela)) = value;
				}
			}

			// Token: 0x170016EC RID: 5868
			// (get) Token: 0x06004947 RID: 18759 RVA: 0x00150D4C File Offset: 0x0014EF4C
			// (set) Token: 0x06004948 RID: 18760 RVA: 0x0001AD06 File Offset: 0x00018F06
			public unsafe ElementAssignmentConflictInfo bLPGfELsppZJrGZxWmbFAooniHA
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_bLPGfELsppZJrGZxWmbFAooniHA);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_bLPGfELsppZJrGZxWmbFAooniHA)) = value;
				}
			}

			// Token: 0x170016ED RID: 5869
			// (get) Token: 0x06004949 RID: 18761 RVA: 0x00150D74 File Offset: 0x0014EF74
			// (set) Token: 0x0600494A RID: 18762 RVA: 0x0001AD21 File Offset: 0x00018F21
			public unsafe ControllerMapWithAxes pUSgQnMOxHDzfFdAuAXUJxUUPTP
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_pUSgQnMOxHDzfFdAuAXUJxUUPTP);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMapWithAxes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_pUSgQnMOxHDzfFdAuAXUJxUUPTP), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016EE RID: 5870
			// (get) Token: 0x0600494B RID: 18763 RVA: 0x00150DA4 File Offset: 0x0014EFA4
			// (set) Token: 0x0600494C RID: 18764 RVA: 0x0001AD40 File Offset: 0x00018F40
			public unsafe IList<ActionElementMap> ZoKRexnYYxAeFrNikFWhVsBtrKJ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_ZoKRexnYYxAeFrNikFWhVsBtrKJ);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ActionElementMap>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_ZoKRexnYYxAeFrNikFWhVsBtrKJ), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016EF RID: 5871
			// (get) Token: 0x0600494D RID: 18765 RVA: 0x00150DD4 File Offset: 0x0014EFD4
			// (set) Token: 0x0600494E RID: 18766 RVA: 0x0001AD5F File Offset: 0x00018F5F
			public unsafe int DAhlDpakCJMcoZXBBKDPCwBgmYo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_DAhlDpakCJMcoZXBBKDPCwBgmYo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_DAhlDpakCJMcoZXBBKDPCwBgmYo)) = value;
				}
			}

			// Token: 0x170016F0 RID: 5872
			// (get) Token: 0x0600494F RID: 18767 RVA: 0x00150DFC File Offset: 0x0014EFFC
			// (set) Token: 0x06004950 RID: 18768 RVA: 0x0001AD7A File Offset: 0x00018F7A
			public unsafe int ZbbwwonUZApjcsYMrktbTOlytb
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_ZbbwwonUZApjcsYMrktbTOlytb);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_ZbbwwonUZApjcsYMrktbTOlytb)) = value;
				}
			}

			// Token: 0x170016F1 RID: 5873
			// (get) Token: 0x06004951 RID: 18769 RVA: 0x00150E24 File Offset: 0x0014F024
			// (set) Token: 0x06004952 RID: 18770 RVA: 0x0001AD95 File Offset: 0x00018F95
			public unsafe ActionElementMap zIVwGmoeOJFjtmrPyURrvkSrhk
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_zIVwGmoeOJFjtmrPyURrvkSrhk);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_zIVwGmoeOJFjtmrPyURrvkSrhk), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016F2 RID: 5874
			// (get) Token: 0x06004953 RID: 18771 RVA: 0x00150E54 File Offset: 0x0014F054
			// (set) Token: 0x06004954 RID: 18772 RVA: 0x0001ADB4 File Offset: 0x00018FB4
			public unsafe int uxypMxxmiyTuIhctmYNxLrnpUuH
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_uxypMxxmiyTuIhctmYNxLrnpUuH);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_uxypMxxmiyTuIhctmYNxLrnpUuH)) = value;
				}
			}

			// Token: 0x170016F3 RID: 5875
			// (get) Token: 0x06004955 RID: 18773 RVA: 0x00150E7C File Offset: 0x0014F07C
			// (set) Token: 0x06004956 RID: 18774 RVA: 0x0001ADCF File Offset: 0x00018FCF
			public unsafe ActionElementMap qWdOKVbpLjoqAiXPHxWzflXerVm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_qWdOKVbpLjoqAiXPHxWzflXerVm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_qWdOKVbpLjoqAiXPHxWzflXerVm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016F4 RID: 5876
			// (get) Token: 0x06004957 RID: 18775 RVA: 0x00150EAC File Offset: 0x0014F0AC
			// (set) Token: 0x06004958 RID: 18776 RVA: 0x0001ADEE File Offset: 0x00018FEE
			public unsafe IEnumerator<ElementAssignmentConflictInfo> NQCAcSEbWyXboGJHalZSbUuDHmFS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_NQCAcSEbWyXboGJHalZSbUuDHmFS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<ElementAssignmentConflictInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.JcjvjDiaIDJlgDVGvEUbVqvDdjl.NativeFieldInfoPtr_NQCAcSEbWyXboGJHalZSbUuDHmFS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B5D RID: 15197
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04003B5E RID: 15198
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04003B5F RID: 15199
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x04003B60 RID: 15200
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x04003B61 RID: 15201
			private static readonly IntPtr NativeFieldInfoPtr_wCYpVdLjaxZjWfQGGAeANYlMhdr;

			// Token: 0x04003B62 RID: 15202
			private static readonly IntPtr NativeFieldInfoPtr_nwrYBLWBwzcJOlYSYhlLHQEGbyZ;

			// Token: 0x04003B63 RID: 15203
			private static readonly IntPtr NativeFieldInfoPtr_JgrRRPnIJYeRFKDvcRjGruwTBfWB;

			// Token: 0x04003B64 RID: 15204
			private static readonly IntPtr NativeFieldInfoPtr_QqLdfsBGGoMLKzXMnVICRmVbbela;

			// Token: 0x04003B65 RID: 15205
			private static readonly IntPtr NativeFieldInfoPtr_bLPGfELsppZJrGZxWmbFAooniHA;

			// Token: 0x04003B66 RID: 15206
			private static readonly IntPtr NativeFieldInfoPtr_pUSgQnMOxHDzfFdAuAXUJxUUPTP;

			// Token: 0x04003B67 RID: 15207
			private static readonly IntPtr NativeFieldInfoPtr_ZoKRexnYYxAeFrNikFWhVsBtrKJ;

			// Token: 0x04003B68 RID: 15208
			private static readonly IntPtr NativeFieldInfoPtr_DAhlDpakCJMcoZXBBKDPCwBgmYo;

			// Token: 0x04003B69 RID: 15209
			private static readonly IntPtr NativeFieldInfoPtr_ZbbwwonUZApjcsYMrktbTOlytb;

			// Token: 0x04003B6A RID: 15210
			private static readonly IntPtr NativeFieldInfoPtr_zIVwGmoeOJFjtmrPyURrvkSrhk;

			// Token: 0x04003B6B RID: 15211
			private static readonly IntPtr NativeFieldInfoPtr_uxypMxxmiyTuIhctmYNxLrnpUuH;

			// Token: 0x04003B6C RID: 15212
			private static readonly IntPtr NativeFieldInfoPtr_qWdOKVbpLjoqAiXPHxWzflXerVm;

			// Token: 0x04003B6D RID: 15213
			private static readonly IntPtr NativeFieldInfoPtr_NQCAcSEbWyXboGJHalZSbUuDHmFS;

			// Token: 0x04003B6E RID: 15214
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ElementAssignmentConflictInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ElementAssignmentConflictInfo_0;

			// Token: 0x04003B6F RID: 15215
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04003B70 RID: 15216
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003B71 RID: 15217
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ElementAssignmentConflictInfo__get_Current_Private_Virtual_Final_New_get_ElementAssignmentConflictInfo_0;

			// Token: 0x04003B72 RID: 15218
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B73 RID: 15219
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B74 RID: 15220
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003B75 RID: 15221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003B76 RID: 15222
			private static readonly IntPtr NativeMethodInfoPtr_agwJmkDDUPobHOhcpdLRunRaqeG_Private_Void_0;
		}

		// Token: 0x02000371 RID: 881
		public sealed class NCMDkUqDniAsShrXjaHGppsAzDQ : Object
		{
			// Token: 0x06004959 RID: 18777 RVA: 0x00150EDC File Offset: 0x0014F0DC
			// Note: this type is marked as 'beforefieldinit'.
			static NCMDkUqDniAsShrXjaHGppsAzDQ()
			{
				Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, "NCMDkUqDniAsShrXjaHGppsAzDQ");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr);
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_MNfOOTXlcukNfUlKQuDAwlepEAK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, "MNfOOTXlcukNfUlKQuDAwlepEAK");
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_huNaLVeIBnybyolpmXMKELXPZCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, "huNaLVeIBnybyolpmXMKELXPZCE");
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_JgrRRPnIJYeRFKDvcRjGruwTBfWB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, "JgrRRPnIJYeRFKDvcRjGruwTBfWB");
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_QqLdfsBGGoMLKzXMnVICRmVbbela = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, "QqLdfsBGGoMLKzXMnVICRmVbbela");
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_SUXJDFzbMLFZMebAufTyshOIhopg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, "SUXJDFzbMLFZMebAufTyshOIhopg");
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_BnWiActbSIJyipCgUWmlhPeYfJR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, "BnWiActbSIJyipCgUWmlhPeYfJR");
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_YcjDhxhxBJYAJXJaCGJefXcwEin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, "YcjDhxhxBJYAJXJaCGJefXcwEin");
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_gGXFHYrvNigebaPpSpAtcXMeUaO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, "gGXFHYrvNigebaPpSpAtcXMeUaO");
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ElementAssignmentConflictInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ElementAssignmentConflictInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, 100671413);
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, 100671414);
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, 100671415);
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ElementAssignmentConflictInfo__get_Current_Private_Virtual_Final_New_get_ElementAssignmentConflictInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, 100671416);
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, 100671417);
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, 100671418);
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, 100671419);
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, 100671420);
				ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr_ZnZrEYOfiqhawWMLJeyHDsNqBpYT_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr, 100671421);
			}

			// Token: 0x0600495A RID: 18778 RVA: 0x001510AC File Offset: 0x0014F2AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292862, XrefRangeEnd = 292870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ElementAssignmentConflictInfo> System_Collections_Generic_IEnumerable_Rewired_ElementAssignmentConflictInfo__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ElementAssignmentConflictInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ElementAssignmentConflictInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ElementAssignmentConflictInfo>>(intPtr3) : null;
			}

			// Token: 0x0600495B RID: 18779 RVA: 0x001510EC File Offset: 0x0014F2EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600495C RID: 18780 RVA: 0x0015112C File Offset: 0x0014F32C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292870, XrefRangeEnd = 292911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001703 RID: 5891
			// (get) Token: 0x0600495D RID: 18781 RVA: 0x00151168 File Offset: 0x0014F368
			public unsafe ElementAssignmentConflictInfo qVRQfYTrRfWCLbEbcWFmEUokinl
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ElementAssignmentConflictInfo__get_Current_Private_Virtual_Final_New_get_ElementAssignmentConflictInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600495E RID: 18782 RVA: 0x001511A4 File Offset: 0x0014F3A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292911, XrefRangeEnd = 292916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600495F RID: 18783 RVA: 0x001511D8 File Offset: 0x0014F3D8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 292919, RefRangeEnd = 292920, XrefRangeStart = 292916, XrefRangeEnd = 292919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001704 RID: 5892
			// (get) Token: 0x06004960 RID: 18784 RVA: 0x0015120C File Offset: 0x0014F40C
			public unsafe Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292920, XrefRangeEnd = 292923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004961 RID: 18785 RVA: 0x0015124C File Offset: 0x0014F44C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NCMDkUqDniAsShrXjaHGppsAzDQ(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004962 RID: 18786 RVA: 0x00151294 File Offset: 0x0014F494
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 292926, RefRangeEnd = 292927, XrefRangeStart = 292923, XrefRangeEnd = 292926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ZnZrEYOfiqhawWMLJeyHDsNqBpYT()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeMethodInfoPtr_ZnZrEYOfiqhawWMLJeyHDsNqBpYT_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004963 RID: 18787 RVA: 0x0001AE0D File Offset: 0x0001900D
			public NCMDkUqDniAsShrXjaHGppsAzDQ(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016F7 RID: 5879
			// (get) Token: 0x06004964 RID: 18788 RVA: 0x001512C8 File Offset: 0x0014F4C8
			// (set) Token: 0x06004965 RID: 18789 RVA: 0x0001AE16 File Offset: 0x00019016
			public unsafe ElementAssignmentConflictInfo NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG)) = value;
				}
			}

			// Token: 0x170016F8 RID: 5880
			// (get) Token: 0x06004966 RID: 18790 RVA: 0x001512F0 File Offset: 0x0014F4F0
			// (set) Token: 0x06004967 RID: 18791 RVA: 0x0001AE31 File Offset: 0x00019031
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x170016F9 RID: 5881
			// (get) Token: 0x06004968 RID: 18792 RVA: 0x00151318 File Offset: 0x0014F518
			// (set) Token: 0x06004969 RID: 18793 RVA: 0x0001AE4C File Offset: 0x0001904C
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x170016FA RID: 5882
			// (get) Token: 0x0600496A RID: 18794 RVA: 0x00151340 File Offset: 0x0014F540
			// (set) Token: 0x0600496B RID: 18795 RVA: 0x0001AE67 File Offset: 0x00019067
			public unsafe ControllerMapWithAxes HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMapWithAxes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016FB RID: 5883
			// (get) Token: 0x0600496C RID: 18796 RVA: 0x00151370 File Offset: 0x0014F570
			// (set) Token: 0x0600496D RID: 18797 RVA: 0x0001AE86 File Offset: 0x00019086
			public unsafe ActionElementMap MNfOOTXlcukNfUlKQuDAwlepEAK
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_MNfOOTXlcukNfUlKQuDAwlepEAK);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_MNfOOTXlcukNfUlKQuDAwlepEAK), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016FC RID: 5884
			// (get) Token: 0x0600496E RID: 18798 RVA: 0x001513A0 File Offset: 0x0014F5A0
			// (set) Token: 0x0600496F RID: 18799 RVA: 0x0001AEA5 File Offset: 0x000190A5
			public unsafe ActionElementMap huNaLVeIBnybyolpmXMKELXPZCE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_huNaLVeIBnybyolpmXMKELXPZCE);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_huNaLVeIBnybyolpmXMKELXPZCE), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016FD RID: 5885
			// (get) Token: 0x06004970 RID: 18800 RVA: 0x001513D0 File Offset: 0x0014F5D0
			// (set) Token: 0x06004971 RID: 18801 RVA: 0x0001AEC4 File Offset: 0x000190C4
			public unsafe bool JgrRRPnIJYeRFKDvcRjGruwTBfWB
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_JgrRRPnIJYeRFKDvcRjGruwTBfWB);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_JgrRRPnIJYeRFKDvcRjGruwTBfWB)) = value;
				}
			}

			// Token: 0x170016FE RID: 5886
			// (get) Token: 0x06004972 RID: 18802 RVA: 0x001513F8 File Offset: 0x0014F5F8
			// (set) Token: 0x06004973 RID: 18803 RVA: 0x0001AEDF File Offset: 0x000190DF
			public unsafe bool QqLdfsBGGoMLKzXMnVICRmVbbela
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_QqLdfsBGGoMLKzXMnVICRmVbbela);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_QqLdfsBGGoMLKzXMnVICRmVbbela)) = value;
				}
			}

			// Token: 0x170016FF RID: 5887
			// (get) Token: 0x06004974 RID: 18804 RVA: 0x00151420 File Offset: 0x0014F620
			// (set) Token: 0x06004975 RID: 18805 RVA: 0x0001AEFA File Offset: 0x000190FA
			public unsafe ElementAssignmentConflictInfo SUXJDFzbMLFZMebAufTyshOIhopg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_SUXJDFzbMLFZMebAufTyshOIhopg);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_SUXJDFzbMLFZMebAufTyshOIhopg)) = value;
				}
			}

			// Token: 0x17001700 RID: 5888
			// (get) Token: 0x06004976 RID: 18806 RVA: 0x00151448 File Offset: 0x0014F648
			// (set) Token: 0x06004977 RID: 18807 RVA: 0x0001AF15 File Offset: 0x00019115
			public unsafe int BnWiActbSIJyipCgUWmlhPeYfJR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_BnWiActbSIJyipCgUWmlhPeYfJR);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_BnWiActbSIJyipCgUWmlhPeYfJR)) = value;
				}
			}

			// Token: 0x17001701 RID: 5889
			// (get) Token: 0x06004978 RID: 18808 RVA: 0x00151470 File Offset: 0x0014F670
			// (set) Token: 0x06004979 RID: 18809 RVA: 0x0001AF30 File Offset: 0x00019130
			public unsafe ActionElementMap YcjDhxhxBJYAJXJaCGJefXcwEin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_YcjDhxhxBJYAJXJaCGJefXcwEin);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_YcjDhxhxBJYAJXJaCGJefXcwEin), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001702 RID: 5890
			// (get) Token: 0x0600497A RID: 18810 RVA: 0x001514A0 File Offset: 0x0014F6A0
			// (set) Token: 0x0600497B RID: 18811 RVA: 0x0001AF4F File Offset: 0x0001914F
			public unsafe IEnumerator<ElementAssignmentConflictInfo> gGXFHYrvNigebaPpSpAtcXMeUaO
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_gGXFHYrvNigebaPpSpAtcXMeUaO);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<ElementAssignmentConflictInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.NCMDkUqDniAsShrXjaHGppsAzDQ.NativeFieldInfoPtr_gGXFHYrvNigebaPpSpAtcXMeUaO), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B77 RID: 15223
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04003B78 RID: 15224
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04003B79 RID: 15225
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x04003B7A RID: 15226
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x04003B7B RID: 15227
			private static readonly IntPtr NativeFieldInfoPtr_MNfOOTXlcukNfUlKQuDAwlepEAK;

			// Token: 0x04003B7C RID: 15228
			private static readonly IntPtr NativeFieldInfoPtr_huNaLVeIBnybyolpmXMKELXPZCE;

			// Token: 0x04003B7D RID: 15229
			private static readonly IntPtr NativeFieldInfoPtr_JgrRRPnIJYeRFKDvcRjGruwTBfWB;

			// Token: 0x04003B7E RID: 15230
			private static readonly IntPtr NativeFieldInfoPtr_QqLdfsBGGoMLKzXMnVICRmVbbela;

			// Token: 0x04003B7F RID: 15231
			private static readonly IntPtr NativeFieldInfoPtr_SUXJDFzbMLFZMebAufTyshOIhopg;

			// Token: 0x04003B80 RID: 15232
			private static readonly IntPtr NativeFieldInfoPtr_BnWiActbSIJyipCgUWmlhPeYfJR;

			// Token: 0x04003B81 RID: 15233
			private static readonly IntPtr NativeFieldInfoPtr_YcjDhxhxBJYAJXJaCGJefXcwEin;

			// Token: 0x04003B82 RID: 15234
			private static readonly IntPtr NativeFieldInfoPtr_gGXFHYrvNigebaPpSpAtcXMeUaO;

			// Token: 0x04003B83 RID: 15235
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ElementAssignmentConflictInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ElementAssignmentConflictInfo_0;

			// Token: 0x04003B84 RID: 15236
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04003B85 RID: 15237
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003B86 RID: 15238
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ElementAssignmentConflictInfo__get_Current_Private_Virtual_Final_New_get_ElementAssignmentConflictInfo_0;

			// Token: 0x04003B87 RID: 15239
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B88 RID: 15240
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B89 RID: 15241
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003B8A RID: 15242
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003B8B RID: 15243
			private static readonly IntPtr NativeMethodInfoPtr_ZnZrEYOfiqhawWMLJeyHDsNqBpYT_Private_Void_0;
		}

		// Token: 0x02000372 RID: 882
		public sealed class cJlGpWGvsGWczeRBrbeUjnUdfMf : Object
		{
			// Token: 0x0600497C RID: 18812 RVA: 0x001514D0 File Offset: 0x0014F6D0
			// Note: this type is marked as 'beforefieldinit'.
			static cJlGpWGvsGWczeRBrbeUjnUdfMf()
			{
				Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerMapWithAxes>.NativeClassPtr, "cJlGpWGvsGWczeRBrbeUjnUdfMf");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr);
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_TEjsPiovmqqLiqdLHyQUHZFLIIk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, "TEjsPiovmqqLiqdLHyQUHZFLIIk");
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_IboaiSkevXOHhoadJbKODxLAGzyj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, "IboaiSkevXOHhoadJbKODxLAGzyj");
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_JgrRRPnIJYeRFKDvcRjGruwTBfWB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, "JgrRRPnIJYeRFKDvcRjGruwTBfWB");
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_QqLdfsBGGoMLKzXMnVICRmVbbela = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, "QqLdfsBGGoMLKzXMnVICRmVbbela");
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_qcFVlOSntAKcYVOIjEClJOqzzgN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, "qcFVlOSntAKcYVOIjEClJOqzzgN");
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_EYaDQQlximbrjEUMpBJVTssmNjP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, "EYaDQQlximbrjEUMpBJVTssmNjP");
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_nchCGqFEMusQvMhjRnVTVFDLovu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, "nchCGqFEMusQvMhjRnVTVFDLovu");
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_BhdeBECHQoCpoYmTnWakwqYVMjn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, "BhdeBECHQoCpoYmTnWakwqYVMjn");
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_KqpUtWoMfhUFauvzJlUNkTvydyK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, "KqpUtWoMfhUFauvzJlUNkTvydyK");
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ElementAssignmentConflictInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ElementAssignmentConflictInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, 100671422);
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, 100671423);
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, 100671424);
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ElementAssignmentConflictInfo__get_Current_Private_Virtual_Final_New_get_ElementAssignmentConflictInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, 100671425);
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, 100671426);
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, 100671427);
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, 100671428);
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, 100671429);
				ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr_qwEgByCNWRTwDisYCYccGLhthdz_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr, 100671430);
			}

			// Token: 0x0600497D RID: 18813 RVA: 0x001516B4 File Offset: 0x0014F8B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292927, XrefRangeEnd = 292935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ElementAssignmentConflictInfo> System_Collections_Generic_IEnumerable_Rewired_ElementAssignmentConflictInfo__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ElementAssignmentConflictInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ElementAssignmentConflictInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ElementAssignmentConflictInfo>>(intPtr3) : null;
			}

			// Token: 0x0600497E RID: 18814 RVA: 0x001516F4 File Offset: 0x0014F8F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600497F RID: 18815 RVA: 0x00151734 File Offset: 0x0014F934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292935, XrefRangeEnd = 292976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001712 RID: 5906
			// (get) Token: 0x06004980 RID: 18816 RVA: 0x00151770 File Offset: 0x0014F970
			public unsafe ElementAssignmentConflictInfo qVRQfYTrRfWCLbEbcWFmEUokinl
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ElementAssignmentConflictInfo__get_Current_Private_Virtual_Final_New_get_ElementAssignmentConflictInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004981 RID: 18817 RVA: 0x001517AC File Offset: 0x0014F9AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292976, XrefRangeEnd = 292981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004982 RID: 18818 RVA: 0x001517E0 File Offset: 0x0014F9E0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 292984, RefRangeEnd = 292985, XrefRangeStart = 292981, XrefRangeEnd = 292984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001713 RID: 5907
			// (get) Token: 0x06004983 RID: 18819 RVA: 0x00151814 File Offset: 0x0014FA14
			public unsafe Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292985, XrefRangeEnd = 292988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004984 RID: 18820 RVA: 0x00151854 File Offset: 0x0014FA54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe cJlGpWGvsGWczeRBrbeUjnUdfMf(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004985 RID: 18821 RVA: 0x0015189C File Offset: 0x0014FA9C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 292991, RefRangeEnd = 292992, XrefRangeStart = 292988, XrefRangeEnd = 292991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void qwEgByCNWRTwDisYCYccGLhthdz()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeMethodInfoPtr_qwEgByCNWRTwDisYCYccGLhthdz_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004986 RID: 18822 RVA: 0x0001AF6E File Offset: 0x0001916E
			public cJlGpWGvsGWczeRBrbeUjnUdfMf(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001705 RID: 5893
			// (get) Token: 0x06004987 RID: 18823 RVA: 0x001518D0 File Offset: 0x0014FAD0
			// (set) Token: 0x06004988 RID: 18824 RVA: 0x0001AF77 File Offset: 0x00019177
			public unsafe ElementAssignmentConflictInfo NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG)) = value;
				}
			}

			// Token: 0x17001706 RID: 5894
			// (get) Token: 0x06004989 RID: 18825 RVA: 0x001518F8 File Offset: 0x0014FAF8
			// (set) Token: 0x0600498A RID: 18826 RVA: 0x0001AF92 File Offset: 0x00019192
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x17001707 RID: 5895
			// (get) Token: 0x0600498B RID: 18827 RVA: 0x00151920 File Offset: 0x0014FB20
			// (set) Token: 0x0600498C RID: 18828 RVA: 0x0001AFAD File Offset: 0x000191AD
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x17001708 RID: 5896
			// (get) Token: 0x0600498D RID: 18829 RVA: 0x00151948 File Offset: 0x0014FB48
			// (set) Token: 0x0600498E RID: 18830 RVA: 0x0001AFC8 File Offset: 0x000191C8
			public unsafe ControllerMapWithAxes HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMapWithAxes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001709 RID: 5897
			// (get) Token: 0x0600498F RID: 18831 RVA: 0x00151978 File Offset: 0x0014FB78
			// (set) Token: 0x06004990 RID: 18832 RVA: 0x0001AFE7 File Offset: 0x000191E7
			public unsafe ElementAssignmentConflictCheck TEjsPiovmqqLiqdLHyQUHZFLIIk
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_TEjsPiovmqqLiqdLHyQUHZFLIIk);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_TEjsPiovmqqLiqdLHyQUHZFLIIk)) = value;
				}
			}

			// Token: 0x1700170A RID: 5898
			// (get) Token: 0x06004991 RID: 18833 RVA: 0x001519A0 File Offset: 0x0014FBA0
			// (set) Token: 0x06004992 RID: 18834 RVA: 0x0001B002 File Offset: 0x00019202
			public unsafe ElementAssignmentConflictCheck IboaiSkevXOHhoadJbKODxLAGzyj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_IboaiSkevXOHhoadJbKODxLAGzyj);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_IboaiSkevXOHhoadJbKODxLAGzyj)) = value;
				}
			}

			// Token: 0x1700170B RID: 5899
			// (get) Token: 0x06004993 RID: 18835 RVA: 0x001519C8 File Offset: 0x0014FBC8
			// (set) Token: 0x06004994 RID: 18836 RVA: 0x0001B01D File Offset: 0x0001921D
			public unsafe bool JgrRRPnIJYeRFKDvcRjGruwTBfWB
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_JgrRRPnIJYeRFKDvcRjGruwTBfWB);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_JgrRRPnIJYeRFKDvcRjGruwTBfWB)) = value;
				}
			}

			// Token: 0x1700170C RID: 5900
			// (get) Token: 0x06004995 RID: 18837 RVA: 0x001519F0 File Offset: 0x0014FBF0
			// (set) Token: 0x06004996 RID: 18838 RVA: 0x0001B038 File Offset: 0x00019238
			public unsafe bool QqLdfsBGGoMLKzXMnVICRmVbbela
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_QqLdfsBGGoMLKzXMnVICRmVbbela);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_QqLdfsBGGoMLKzXMnVICRmVbbela)) = value;
				}
			}

			// Token: 0x1700170D RID: 5901
			// (get) Token: 0x06004997 RID: 18839 RVA: 0x00151A18 File Offset: 0x0014FC18
			// (set) Token: 0x06004998 RID: 18840 RVA: 0x0001B053 File Offset: 0x00019253
			public unsafe ElementAssignmentConflictInfo qcFVlOSntAKcYVOIjEClJOqzzgN
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_qcFVlOSntAKcYVOIjEClJOqzzgN);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_qcFVlOSntAKcYVOIjEClJOqzzgN)) = value;
				}
			}

			// Token: 0x1700170E RID: 5902
			// (get) Token: 0x06004999 RID: 18841 RVA: 0x00151A40 File Offset: 0x0014FC40
			// (set) Token: 0x0600499A RID: 18842 RVA: 0x0001B06E File Offset: 0x0001926E
			public unsafe ElementAssignment EYaDQQlximbrjEUMpBJVTssmNjP
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_EYaDQQlximbrjEUMpBJVTssmNjP);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_EYaDQQlximbrjEUMpBJVTssmNjP)) = value;
				}
			}

			// Token: 0x1700170F RID: 5903
			// (get) Token: 0x0600499B RID: 18843 RVA: 0x00151A68 File Offset: 0x0014FC68
			// (set) Token: 0x0600499C RID: 18844 RVA: 0x0001B089 File Offset: 0x00019289
			public unsafe int nchCGqFEMusQvMhjRnVTVFDLovu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_nchCGqFEMusQvMhjRnVTVFDLovu);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_nchCGqFEMusQvMhjRnVTVFDLovu)) = value;
				}
			}

			// Token: 0x17001710 RID: 5904
			// (get) Token: 0x0600499D RID: 18845 RVA: 0x00151A90 File Offset: 0x0014FC90
			// (set) Token: 0x0600499E RID: 18846 RVA: 0x0001B0A4 File Offset: 0x000192A4
			public unsafe ActionElementMap BhdeBECHQoCpoYmTnWakwqYVMjn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_BhdeBECHQoCpoYmTnWakwqYVMjn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_BhdeBECHQoCpoYmTnWakwqYVMjn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001711 RID: 5905
			// (get) Token: 0x0600499F RID: 18847 RVA: 0x00151AC0 File Offset: 0x0014FCC0
			// (set) Token: 0x060049A0 RID: 18848 RVA: 0x0001B0C3 File Offset: 0x000192C3
			public unsafe IEnumerator<ElementAssignmentConflictInfo> KqpUtWoMfhUFauvzJlUNkTvydyK
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_KqpUtWoMfhUFauvzJlUNkTvydyK);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<ElementAssignmentConflictInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapWithAxes.cJlGpWGvsGWczeRBrbeUjnUdfMf.NativeFieldInfoPtr_KqpUtWoMfhUFauvzJlUNkTvydyK), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B8C RID: 15244
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04003B8D RID: 15245
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04003B8E RID: 15246
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x04003B8F RID: 15247
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x04003B90 RID: 15248
			private static readonly IntPtr NativeFieldInfoPtr_TEjsPiovmqqLiqdLHyQUHZFLIIk;

			// Token: 0x04003B91 RID: 15249
			private static readonly IntPtr NativeFieldInfoPtr_IboaiSkevXOHhoadJbKODxLAGzyj;

			// Token: 0x04003B92 RID: 15250
			private static readonly IntPtr NativeFieldInfoPtr_JgrRRPnIJYeRFKDvcRjGruwTBfWB;

			// Token: 0x04003B93 RID: 15251
			private static readonly IntPtr NativeFieldInfoPtr_QqLdfsBGGoMLKzXMnVICRmVbbela;

			// Token: 0x04003B94 RID: 15252
			private static readonly IntPtr NativeFieldInfoPtr_qcFVlOSntAKcYVOIjEClJOqzzgN;

			// Token: 0x04003B95 RID: 15253
			private static readonly IntPtr NativeFieldInfoPtr_EYaDQQlximbrjEUMpBJVTssmNjP;

			// Token: 0x04003B96 RID: 15254
			private static readonly IntPtr NativeFieldInfoPtr_nchCGqFEMusQvMhjRnVTVFDLovu;

			// Token: 0x04003B97 RID: 15255
			private static readonly IntPtr NativeFieldInfoPtr_BhdeBECHQoCpoYmTnWakwqYVMjn;

			// Token: 0x04003B98 RID: 15256
			private static readonly IntPtr NativeFieldInfoPtr_KqpUtWoMfhUFauvzJlUNkTvydyK;

			// Token: 0x04003B99 RID: 15257
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ElementAssignmentConflictInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ElementAssignmentConflictInfo_0;

			// Token: 0x04003B9A RID: 15258
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04003B9B RID: 15259
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003B9C RID: 15260
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ElementAssignmentConflictInfo__get_Current_Private_Virtual_Final_New_get_ElementAssignmentConflictInfo_0;

			// Token: 0x04003B9D RID: 15261
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B9E RID: 15262
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003B9F RID: 15263
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003BA0 RID: 15264
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003BA1 RID: 15265
			private static readonly IntPtr NativeMethodInfoPtr_qwEgByCNWRTwDisYCYccGLhthdz_Private_Void_0;
		}
	}
}
