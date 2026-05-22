using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppRewired.Dev.Tools
{
	// Token: 0x020001AD RID: 429
	public class DebugInformation : MonoBehaviour
	{
		// Token: 0x06002C2F RID: 11311 RVA: 0x000DB204 File Offset: 0x000D9404
		// Note: this type is marked as 'beforefieldinit'.
		static DebugInformation()
		{
			Il2CppClassPointerStore<DebugInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Dev.Tools", "DebugInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr);
			DebugInformation.NativeFieldInfoPtr_lFmHzLaCiGBoLFCbgQDRIsjJUAhC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, "lFmHzLaCiGBoLFCbgQDRIsjJUAhC");
			DebugInformation.NativeFieldInfoPtr_PlbdBSTNvSpnelPLrrTTyDkhAOjE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, "PlbdBSTNvSpnelPLrrTTyDkhAOjE");
			DebugInformation.NativeFieldInfoPtr_vqLhPoTYZzgPMykoZQisqPtOwtj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, "vqLhPoTYZzgPMykoZQisqPtOwtj");
			DebugInformation.NativeFieldInfoPtr__fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, "_fontSize");
			DebugInformation.NativeFieldInfoPtr_XyqokkixUDriKluQAnhJmFAptV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, "XyqokkixUDriKluQAnhJmFAptV");
			DebugInformation.NativeFieldInfoPtr_mgzWysDBvhQUlXBdczneWLDPFna = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, "mgzWysDBvhQUlXBdczneWLDPFna");
			DebugInformation.NativeFieldInfoPtr_CUnzDgGkPoTxNZAlMOrgHUktxRj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, "CUnzDgGkPoTxNZAlMOrgHUktxRj");
			DebugInformation.NativeFieldInfoPtr_hRRCAvTXaohSDOjAwutEXPOoSLx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, "hRRCAvTXaohSDOjAwutEXPOoSLx");
			DebugInformation.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674690);
			DebugInformation.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674691);
			DebugInformation.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674692);
			DebugInformation.NativeMethodInfoPtr_DrawDebugInformation_Public_Static_Void_Boolean_IDictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674693);
			DebugInformation.NativeMethodInfoPtr_XFMlHipItUrOMLGWzbDHFnZrFPDz_Private_Static_Void_Boolean_IDictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674694);
			DebugInformation.NativeMethodInfoPtr_fkCsgBeNklizQmgRoURVAJjeQFY_Private_Static_Void_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674695);
			DebugInformation.NativeMethodInfoPtr_BVUFZXHAEwKMUnhetAksVTjnNnHY_Private_Static_Void_IList_1_Joystick_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674696);
			DebugInformation.NativeMethodInfoPtr_OKKcvCacRKKWAOsEGdhVuDNHFvNf_Private_Static_Void_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674697);
			DebugInformation.NativeMethodInfoPtr_wTYJbwvdArqJdYJvyGFPhWNpydX_Private_Static_Void_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674698);
			DebugInformation.NativeMethodInfoPtr_HMZYRMmiIHhNIKgVlPQxiQzNlFa_Private_Static_Void_IList_1_CustomController_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674699);
			DebugInformation.NativeMethodInfoPtr_ptRivoTVCChFntjoDtMHzcCWsCP_Private_Static_Void_Player_Int32_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674700);
			DebugInformation.NativeMethodInfoPtr_olTrmAjstLxolIFEZmfuwyerDmi_Private_Static_Void_IList_1_InputBehavior_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674701);
			DebugInformation.NativeMethodInfoPtr_uWYYOEfLZqaXkqcDSiGjaFSQhQj_Private_Static_Void_InputBehavior_Int32_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674702);
			DebugInformation.NativeMethodInfoPtr_fHsvTGXAzIzDXnAjSYjxQozqthG_Private_Static_Void_Controller_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674703);
			DebugInformation.NativeMethodInfoPtr_TEaawutsbzicRTNpgArxuiOzoOu_Private_Static_Void_IList_1_Button_ControllerType_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674704);
			DebugInformation.NativeMethodInfoPtr_HpMmHCxaglFAyshhEgPaVYeVUea_Private_Static_Void_IList_1_Axis_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674705);
			DebugInformation.NativeMethodInfoPtr_riWeJzhahvDhVnOwQKUnGUEOqiX_Private_Static_Void_ControllerType_IList_1_T_String_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674706);
			DebugInformation.NativeMethodInfoPtr_qrgWEnrZWqQUUizeLuJOIiOHBJy_Private_Static_Void_ControllerMap_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674707);
			DebugInformation.NativeMethodInfoPtr_qrgWEnrZWqQUUizeLuJOIiOHBJy_Private_Static_Void_ControllerMapWithAxes_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674708);
			DebugInformation.NativeMethodInfoPtr_pPWceXFlnbqDjgcrISXEKgvYAYQe_Private_Static_Void_ControllerType_ActionElementMap_Int32_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674709);
			DebugInformation.NativeMethodInfoPtr_hDgOByaaIvOBggBQXBoTKUxSqcZU_Private_Static_String_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674710);
			DebugInformation.NativeMethodInfoPtr_AYnvzUExjhGJpUdTWYlLtzdTbok_Private_Static_Void_ControllerMapLayoutManager_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674711);
			DebugInformation.NativeMethodInfoPtr_SlrncdHgEgkpmqVnFhCeSAGWhdoj_Private_Static_Void_RuleSet_Int32_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674712);
			DebugInformation.NativeMethodInfoPtr_PaehhbDsFxPvjbWmXAwWfJVgqGxU_Private_Static_Void_ControllerMapEnabler_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674713);
			DebugInformation.NativeMethodInfoPtr_tmYIgYgxpQhFebYxsNtiPDqdQBh_Private_Static_Void_RuleSet_Int32_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674714);
			DebugInformation.NativeMethodInfoPtr_SPYlnQzwQzbZDhpXYrHMYTqYipM_Private_Static_Void_ControllerSetSelector_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674715);
			DebugInformation.NativeMethodInfoPtr_CDBQmyohPqbhrfwbHytALuyDgFT_Private_Static_Void_Controller_IDictionary_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674716);
			DebugInformation.NativeMethodInfoPtr_YuDUPHTMXMNJZRVIyTpIiUTAKOQ_Private_Static_Void_IControllerTemplate_Int32_String_IDictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674717);
			DebugInformation.NativeMethodInfoPtr_XdTksTLooAsdsEXTCJAcdiGjWil_Private_Static_Void_IControllerTemplateElement_Int32_String_IDictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674718);
			DebugInformation.NativeMethodInfoPtr_YfyiaNBLKKkiBGNJLXJislqupnN_Private_Static_Void_IControllerTemplateAxis_String_String_IDictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674719);
			DebugInformation.NativeMethodInfoPtr_yXCdtphVIekupRQFTJsbOHXMrixf_Private_Static_Void_IControllerTemplateButton_String_String_IDictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674720);
			DebugInformation.NativeMethodInfoPtr_NvVJuLLxIEabrIUflqiEuGCfNYI_Private_Static_Void_IControllerTemplateAxis_String_IDictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674721);
			DebugInformation.NativeMethodInfoPtr_EfeTwhytxaKBgYJzhoqPvqvTMSB_Private_Static_Void_IControllerTemplateButton_String_IDictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674722);
			DebugInformation.NativeMethodInfoPtr_NcjUAdOoeNQhPbteLBgYMlhTxDv_Private_Static_Void_IControllerTemplateAxisSource_String_String_IDictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674723);
			DebugInformation.NativeMethodInfoPtr_fBDMmQglACdzmCPNwFllJRDgdpfJ_Private_Static_Void_IControllerTemplateButtonSource_String_String_IDictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674724);
			DebugInformation.NativeMethodInfoPtr_dBpCTrkhWClfnoBSSITHncXAhfFk_Private_Static_Void_IControllerElementTarget_String_String_IDictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674725);
			DebugInformation.NativeMethodInfoPtr_tfBSlsupsKqYFeRiGxZCFmrjxRK_Private_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674726);
			DebugInformation.NativeMethodInfoPtr_zgfUildcBmHBEkwrBUZjAgtJUkH_Private_Static_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674727);
			DebugInformation.NativeMethodInfoPtr_GetToggleStyle_Public_Static_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674728);
			DebugInformation.NativeMethodInfoPtr_aJDdpcVSrWmPovOHOCIscYqFBlJ_Private_Static_GUIStyle_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674729);
			DebugInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674730);
			DebugInformation.NativeMethodInfoPtr_JobhRxIKGHttaEIrCbWHNXsdebLo_Private_Static_Int32_InputAction_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, 100674731);
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x000DB61C File Offset: 0x000D981C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325103, XrefRangeEnd = 325112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x000DB650 File Offset: 0x000D9850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325112, XrefRangeEnd = 325131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x000DB684 File Offset: 0x000D9884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325131, XrefRangeEnd = 325163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x000DB6B8 File Offset: 0x000D98B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325213, RefRangeEnd = 325214, XrefRangeStart = 325163, XrefRangeEnd = 325213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawDebugInformation(bool enabled, IDictionary<string, bool> foldouts)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(foldouts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_DrawDebugInformation_Public_Static_Void_Boolean_IDictionary_2_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x000DB6FC File Offset: 0x000D98FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325291, RefRangeEnd = 325292, XrefRangeStart = 325214, XrefRangeEnd = 325291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XFMlHipItUrOMLGWzbDHFnZrFPDz(bool A_0, IDictionary<string, bool> A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_XFMlHipItUrOMLGWzbDHFnZrFPDz_Private_Static_Void_Boolean_IDictionary_2_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x000DB740 File Offset: 0x000D9940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325332, RefRangeEnd = 325333, XrefRangeStart = 325292, XrefRangeEnd = 325332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void fkCsgBeNklizQmgRoURVAJjeQFY(IDictionary<string, bool> A_0, string A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_fkCsgBeNklizQmgRoURVAJjeQFY_Private_Static_Void_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x000DB788 File Offset: 0x000D9988
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325689, RefRangeEnd = 325691, XrefRangeStart = 325333, XrefRangeEnd = 325689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BVUFZXHAEwKMUnhetAksVTjnNnHY(IList<Joystick> A_0, IDictionary<string, bool> A_1, string A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_BVUFZXHAEwKMUnhetAksVTjnNnHY_Private_Static_Void_IList_1_Joystick_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x000DB7E4 File Offset: 0x000D99E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325787, RefRangeEnd = 325788, XrefRangeStart = 325691, XrefRangeEnd = 325787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OKKcvCacRKKWAOsEGdhVuDNHFvNf(IDictionary<string, bool> A_0, string A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_OKKcvCacRKKWAOsEGdhVuDNHFvNf_Private_Static_Void_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x000DB82C File Offset: 0x000D9A2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325851, RefRangeEnd = 325852, XrefRangeStart = 325788, XrefRangeEnd = 325851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void wTYJbwvdArqJdYJvyGFPhWNpydX(IDictionary<string, bool> A_0, string A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_wTYJbwvdArqJdYJvyGFPhWNpydX_Private_Static_Void_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x000DB874 File Offset: 0x000D9A74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 326308, RefRangeEnd = 326310, XrefRangeStart = 325852, XrefRangeEnd = 326308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HMZYRMmiIHhNIKgVlPQxiQzNlFa(IList<CustomController> A_0, IDictionary<string, bool> A_1, string A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_HMZYRMmiIHhNIKgVlPQxiQzNlFa_Private_Static_Void_IList_1_CustomController_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x000DB8D0 File Offset: 0x000D9AD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 326854, RefRangeEnd = 326856, XrefRangeStart = 326310, XrefRangeEnd = 326854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ptRivoTVCChFntjoDtMHzcCWsCP(Player A_0, int A_1, IDictionary<string, bool> A_2, string A_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_ptRivoTVCChFntjoDtMHzcCWsCP_Private_Static_Void_Player_Int32_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x000DB938 File Offset: 0x000D9B38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326888, RefRangeEnd = 326889, XrefRangeStart = 326856, XrefRangeEnd = 326888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void olTrmAjstLxolIFEZmfuwyerDmi(IList<InputBehavior> A_0, IDictionary<string, bool> A_1, string A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_olTrmAjstLxolIFEZmfuwyerDmi_Private_Static_Void_IList_1_InputBehavior_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x000DB994 File Offset: 0x000D9B94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327057, RefRangeEnd = 327058, XrefRangeStart = 326889, XrefRangeEnd = 327057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void uWYYOEfLZqaXkqcDSiGjaFSQhQj(InputBehavior A_0, int A_1, IDictionary<string, bool> A_2, string A_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_uWYYOEfLZqaXkqcDSiGjaFSQhQj_Private_Static_Void_InputBehavior_Int32_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x000DB9FC File Offset: 0x000D9BFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 327247, RefRangeEnd = 327250, XrefRangeStart = 327058, XrefRangeEnd = 327247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void fHsvTGXAzIzDXnAjSYjxQozqthG(Controller A_0, IDictionary<string, bool> A_1, string A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_fHsvTGXAzIzDXnAjSYjxQozqthG_Private_Static_Void_Controller_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x000DBA58 File Offset: 0x000D9C58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 327477, RefRangeEnd = 327481, XrefRangeStart = 327250, XrefRangeEnd = 327477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TEaawutsbzicRTNpgArxuiOzoOu(IList<Controller.Button> A_0, ControllerType A_1, IDictionary<string, bool> A_2, string A_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_TEaawutsbzicRTNpgArxuiOzoOu_Private_Static_Void_IList_1_Button_ControllerType_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x000DBAC0 File Offset: 0x000D9CC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 327696, RefRangeEnd = 327699, XrefRangeStart = 327481, XrefRangeEnd = 327696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HpMmHCxaglFAyshhEgPaVYeVUea(IList<Controller.Axis> A_0, IDictionary<string, bool> A_1, string A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_HpMmHCxaglFAyshhEgPaVYeVUea_Private_Static_Void_IList_1_Axis_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x000DBB1C File Offset: 0x000D9D1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 327825, RefRangeEnd = 327829, XrefRangeStart = 327699, XrefRangeEnd = 327825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void riWeJzhahvDhVnOwQKUnGUEOqiX<T>(ControllerType A_0, IList<T> A_1, string A_2, IDictionary<string, bool> A_3, string A_4) where T : ControllerMap
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_4);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.MethodInfoStoreGeneric_riWeJzhahvDhVnOwQKUnGUEOqiX_Private_Static_Void_ControllerType_IList_1_T_String_IDictionary_2_String_Boolean_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x000DBB98 File Offset: 0x000D9D98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 327934, RefRangeEnd = 327936, XrefRangeStart = 327829, XrefRangeEnd = 327934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void qrgWEnrZWqQUUizeLuJOIiOHBJy(ControllerMap A_0, IDictionary<string, bool> A_1, string A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_qrgWEnrZWqQUUizeLuJOIiOHBJy_Private_Static_Void_ControllerMap_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x000DBBF4 File Offset: 0x000D9DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327973, RefRangeEnd = 327974, XrefRangeStart = 327936, XrefRangeEnd = 327973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void qrgWEnrZWqQUUizeLuJOIiOHBJy(ControllerMapWithAxes A_0, IDictionary<string, bool> A_1, string A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_qrgWEnrZWqQUUizeLuJOIiOHBJy_Private_Static_Void_ControllerMapWithAxes_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x000DBC50 File Offset: 0x000D9E50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328132, RefRangeEnd = 328134, XrefRangeStart = 327974, XrefRangeEnd = 328132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void pPWceXFlnbqDjgcrISXEKgvYAYQe(ControllerType A_0, ActionElementMap A_1, int A_2, IDictionary<string, bool> A_3, string A_4)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_4);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_pPWceXFlnbqDjgcrISXEKgvYAYQe_Private_Static_Void_ControllerType_ActionElementMap_Int32_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x000DBCC8 File Offset: 0x000D9EC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328143, RefRangeEnd = 328144, XrefRangeStart = 328134, XrefRangeEnd = 328143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string hDgOByaaIvOBggBQXBoTKUxSqcZU(ActionElementMap A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_hDgOByaaIvOBggBQXBoTKUxSqcZU_Private_Static_String_ActionElementMap_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x000DBD04 File Offset: 0x000D9F04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328188, RefRangeEnd = 328189, XrefRangeStart = 328144, XrefRangeEnd = 328188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AYnvzUExjhGJpUdTWYlLtzdTbok(ControllerMapLayoutManager A_0, IDictionary<string, bool> A_1, string A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_AYnvzUExjhGJpUdTWYlLtzdTbok_Private_Static_Void_ControllerMapLayoutManager_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x000DBD60 File Offset: 0x000D9F60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328368, RefRangeEnd = 328369, XrefRangeStart = 328189, XrefRangeEnd = 328368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SlrncdHgEgkpmqVnFhCeSAGWhdoj(ControllerMapLayoutManager.RuleSet A_0, int A_1, IDictionary<string, bool> A_2, string A_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_SlrncdHgEgkpmqVnFhCeSAGWhdoj_Private_Static_Void_RuleSet_Int32_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x000DBDC8 File Offset: 0x000D9FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328406, RefRangeEnd = 328407, XrefRangeStart = 328369, XrefRangeEnd = 328406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PaehhbDsFxPvjbWmXAwWfJVgqGxU(ControllerMapEnabler A_0, IDictionary<string, bool> A_1, string A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_PaehhbDsFxPvjbWmXAwWfJVgqGxU_Private_Static_Void_ControllerMapEnabler_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x000DBE24 File Offset: 0x000DA024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328632, RefRangeEnd = 328633, XrefRangeStart = 328407, XrefRangeEnd = 328632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void tmYIgYgxpQhFebYxsNtiPDqdQBh(ControllerMapEnabler.RuleSet A_0, int A_1, IDictionary<string, bool> A_2, string A_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_tmYIgYgxpQhFebYxsNtiPDqdQBh_Private_Static_Void_RuleSet_Int32_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x000DBE8C File Offset: 0x000DA08C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328703, RefRangeEnd = 328705, XrefRangeStart = 328633, XrefRangeEnd = 328703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SPYlnQzwQzbZDhpXYrHMYTqYipM(ControllerSetSelector A_0, IDictionary<string, bool> A_1, string A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_SPYlnQzwQzbZDhpXYrHMYTqYipM_Private_Static_Void_ControllerSetSelector_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x000DBEE8 File Offset: 0x000DA0E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 328735, RefRangeEnd = 328739, XrefRangeStart = 328705, XrefRangeEnd = 328735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CDBQmyohPqbhrfwbHytALuyDgFT(Controller A_0, IDictionary<string, bool> A_1, string A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_CDBQmyohPqbhrfwbHytALuyDgFT_Private_Static_Void_Controller_IDictionary_2_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x000DBF44 File Offset: 0x000DA144
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328813, RefRangeEnd = 328814, XrefRangeStart = 328739, XrefRangeEnd = 328813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YuDUPHTMXMNJZRVIyTpIiUTAKOQ(IControllerTemplate A_0, int A_1, string A_2, IDictionary<string, bool> A_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_YuDUPHTMXMNJZRVIyTpIiUTAKOQ_Private_Static_Void_IControllerTemplate_Int32_String_IDictionary_2_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x000DBFAC File Offset: 0x000DA1AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329188, RefRangeEnd = 329189, XrefRangeStart = 328814, XrefRangeEnd = 329188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XdTksTLooAsdsEXTCJAcdiGjWil(IControllerTemplateElement A_0, int A_1, string A_2, IDictionary<string, bool> A_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_XdTksTLooAsdsEXTCJAcdiGjWil_Private_Static_Void_IControllerTemplateElement_Int32_String_IDictionary_2_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x000DC014 File Offset: 0x000DA214
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 329205, RefRangeEnd = 329219, XrefRangeStart = 329189, XrefRangeEnd = 329205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void YfyiaNBLKKkiBGNJLXJislqupnN(IControllerTemplateAxis A_0, string A_1, string A_2, IDictionary<string, bool> A_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_YfyiaNBLKKkiBGNJLXJislqupnN_Private_Static_Void_IControllerTemplateAxis_String_String_IDictionary_2_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x000DC080 File Offset: 0x000DA280
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 329235, RefRangeEnd = 329249, XrefRangeStart = 329219, XrefRangeEnd = 329235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void yXCdtphVIekupRQFTJsbOHXMrixf(IControllerTemplateButton A_0, string A_1, string A_2, IDictionary<string, bool> A_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_yXCdtphVIekupRQFTJsbOHXMrixf_Private_Static_Void_IControllerTemplateButton_String_String_IDictionary_2_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x000DC0EC File Offset: 0x000DA2EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 329275, RefRangeEnd = 329277, XrefRangeStart = 329249, XrefRangeEnd = 329275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NvVJuLLxIEabrIUflqiEuGCfNYI(IControllerTemplateAxis A_0, string A_1, IDictionary<string, bool> A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_NvVJuLLxIEabrIUflqiEuGCfNYI_Private_Static_Void_IControllerTemplateAxis_String_IDictionary_2_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x000DC148 File Offset: 0x000DA348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 329347, RefRangeEnd = 329349, XrefRangeStart = 329277, XrefRangeEnd = 329347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EfeTwhytxaKBgYJzhoqPvqvTMSB(IControllerTemplateButton A_0, string A_1, IDictionary<string, bool> A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_EfeTwhytxaKBgYJzhoqPvqvTMSB_Private_Static_Void_IControllerTemplateButton_String_IDictionary_2_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x000DC1A4 File Offset: 0x000DA3A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329387, RefRangeEnd = 329388, XrefRangeStart = 329349, XrefRangeEnd = 329387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NcjUAdOoeNQhPbteLBgYMlhTxDv(IControllerTemplateAxisSource A_0, string A_1, string A_2, IDictionary<string, bool> A_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_NcjUAdOoeNQhPbteLBgYMlhTxDv_Private_Static_Void_IControllerTemplateAxisSource_String_String_IDictionary_2_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x000DC210 File Offset: 0x000DA410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329388, XrefRangeEnd = 329398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void fBDMmQglACdzmCPNwFllJRDgdpfJ(IControllerTemplateButtonSource A_0, string A_1, string A_2, IDictionary<string, bool> A_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_fBDMmQglACdzmCPNwFllJRDgdpfJ_Private_Static_Void_IControllerTemplateButtonSource_String_String_IDictionary_2_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x000DC27C File Offset: 0x000DA47C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 329445, RefRangeEnd = 329450, XrefRangeStart = 329398, XrefRangeEnd = 329445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void dBpCTrkhWClfnoBSSITHncXAhfFk(IControllerElementTarget A_0, string A_1, string A_2, IDictionary<string, bool> A_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_dBpCTrkhWClfnoBSSITHncXAhfFk_Private_Static_Void_IControllerElementTarget_String_String_IDictionary_2_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x000DC2E8 File Offset: 0x000DA4E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 329455, RefRangeEnd = 329458, XrefRangeStart = 329450, XrefRangeEnd = 329455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool tfBSlsupsKqYFeRiGxZCFmrjxRK(string A_0, bool A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_tfBSlsupsKqYFeRiGxZCFmrjxRK_Private_Static_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x000DC338 File Offset: 0x000DA538
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 329484, RefRangeEnd = 329488, XrefRangeStart = 329458, XrefRangeEnd = 329484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUIStyle zgfUildcBmHBEkwrBUZjAgtJUkH()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_zgfUildcBmHBEkwrBUZjAgtJUkH_Private_Static_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x000DC36C File Offset: 0x000DA56C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 329507, RefRangeEnd = 329509, XrefRangeStart = 329488, XrefRangeEnd = 329507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUIStyle GetToggleStyle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_GetToggleStyle_Public_Static_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x000DC3A0 File Offset: 0x000DA5A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 329518, RefRangeEnd = 329520, XrefRangeStart = 329509, XrefRangeEnd = 329518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUIStyle aJDdpcVSrWmPovOHOCIscYqFBlJ(GUIStyle A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_aJDdpcVSrWmPovOHOCIscYqFBlJ_Private_Static_GUIStyle_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x000DC3E4 File Offset: 0x000DA5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329520, XrefRangeEnd = 329528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x000DC420 File Offset: 0x000DA620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329528, XrefRangeEnd = 329530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int JobhRxIKGHttaEIrCbWHNXsdebLo(InputAction A_0, InputAction A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.NativeMethodInfoPtr_JobhRxIKGHttaEIrCbWHNXsdebLo_Private_Static_Int32_InputAction_InputAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x00010946 File Offset: 0x0000EB46
		public DebugInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x000DC474 File Offset: 0x000DA674
		// (set) Token: 0x06002C5C RID: 11356 RVA: 0x0001094F File Offset: 0x0000EB4F
		public unsafe static string lFmHzLaCiGBoLFCbgQDRIsjJUAhC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugInformation.NativeFieldInfoPtr_lFmHzLaCiGBoLFCbgQDRIsjJUAhC, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugInformation.NativeFieldInfoPtr_lFmHzLaCiGBoLFCbgQDRIsjJUAhC, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06002C5D RID: 11357 RVA: 0x000DC494 File Offset: 0x000DA694
		// (set) Token: 0x06002C5E RID: 11358 RVA: 0x00010961 File Offset: 0x0000EB61
		public unsafe static string PlbdBSTNvSpnelPLrrTTyDkhAOjE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugInformation.NativeFieldInfoPtr_PlbdBSTNvSpnelPLrrTTyDkhAOjE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugInformation.NativeFieldInfoPtr_PlbdBSTNvSpnelPLrrTTyDkhAOjE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06002C5F RID: 11359 RVA: 0x000DC4B4 File Offset: 0x000DA6B4
		// (set) Token: 0x06002C60 RID: 11360 RVA: 0x00010973 File Offset: 0x0000EB73
		public unsafe static int vqLhPoTYZzgPMykoZQisqPtOwtj
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugInformation.NativeFieldInfoPtr_vqLhPoTYZzgPMykoZQisqPtOwtj, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugInformation.NativeFieldInfoPtr_vqLhPoTYZzgPMykoZQisqPtOwtj, (void*)(&value));
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06002C61 RID: 11361 RVA: 0x000DC4D0 File Offset: 0x000DA6D0
		// (set) Token: 0x06002C62 RID: 11362 RVA: 0x00010981 File Offset: 0x0000EB81
		public unsafe int _fontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInformation.NativeFieldInfoPtr__fontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInformation.NativeFieldInfoPtr__fontSize)) = value;
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06002C63 RID: 11363 RVA: 0x000DC4F8 File Offset: 0x000DA6F8
		// (set) Token: 0x06002C64 RID: 11364 RVA: 0x0001099C File Offset: 0x0000EB9C
		public unsafe static DebugInformation XyqokkixUDriKluQAnhJmFAptV
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugInformation.NativeFieldInfoPtr_XyqokkixUDriKluQAnhJmFAptV, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugInformation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugInformation.NativeFieldInfoPtr_XyqokkixUDriKluQAnhJmFAptV, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x000DC520 File Offset: 0x000DA720
		// (set) Token: 0x06002C66 RID: 11366 RVA: 0x000109AE File Offset: 0x0000EBAE
		public unsafe IDictionary<string, bool> mgzWysDBvhQUlXBdczneWLDPFna
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInformation.NativeFieldInfoPtr_mgzWysDBvhQUlXBdczneWLDPFna);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInformation.NativeFieldInfoPtr_mgzWysDBvhQUlXBdczneWLDPFna), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x000DC550 File Offset: 0x000DA750
		// (set) Token: 0x06002C68 RID: 11368 RVA: 0x000109CD File Offset: 0x0000EBCD
		public unsafe static Vector2 CUnzDgGkPoTxNZAlMOrgHUktxRj
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(DebugInformation.NativeFieldInfoPtr_CUnzDgGkPoTxNZAlMOrgHUktxRj, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugInformation.NativeFieldInfoPtr_CUnzDgGkPoTxNZAlMOrgHUktxRj, (void*)(&value));
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x000DC56C File Offset: 0x000DA76C
		// (set) Token: 0x06002C6A RID: 11370 RVA: 0x000109DB File Offset: 0x0000EBDB
		public unsafe static Comparison<InputAction> hRRCAvTXaohSDOjAwutEXPOoSLx
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugInformation.NativeFieldInfoPtr_hRRCAvTXaohSDOjAwutEXPOoSLx, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<InputAction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugInformation.NativeFieldInfoPtr_hRRCAvTXaohSDOjAwutEXPOoSLx, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400257D RID: 9597
		private static readonly IntPtr NativeFieldInfoPtr_lFmHzLaCiGBoLFCbgQDRIsjJUAhC;

		// Token: 0x0400257E RID: 9598
		private static readonly IntPtr NativeFieldInfoPtr_PlbdBSTNvSpnelPLrrTTyDkhAOjE;

		// Token: 0x0400257F RID: 9599
		private static readonly IntPtr NativeFieldInfoPtr_vqLhPoTYZzgPMykoZQisqPtOwtj;

		// Token: 0x04002580 RID: 9600
		private static readonly IntPtr NativeFieldInfoPtr__fontSize;

		// Token: 0x04002581 RID: 9601
		private static readonly IntPtr NativeFieldInfoPtr_XyqokkixUDriKluQAnhJmFAptV;

		// Token: 0x04002582 RID: 9602
		private static readonly IntPtr NativeFieldInfoPtr_mgzWysDBvhQUlXBdczneWLDPFna;

		// Token: 0x04002583 RID: 9603
		private static readonly IntPtr NativeFieldInfoPtr_CUnzDgGkPoTxNZAlMOrgHUktxRj;

		// Token: 0x04002584 RID: 9604
		private static readonly IntPtr NativeFieldInfoPtr_hRRCAvTXaohSDOjAwutEXPOoSLx;

		// Token: 0x04002585 RID: 9605
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04002586 RID: 9606
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04002587 RID: 9607
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x04002588 RID: 9608
		private static readonly IntPtr NativeMethodInfoPtr_DrawDebugInformation_Public_Static_Void_Boolean_IDictionary_2_String_Boolean_0;

		// Token: 0x04002589 RID: 9609
		private static readonly IntPtr NativeMethodInfoPtr_XFMlHipItUrOMLGWzbDHFnZrFPDz_Private_Static_Void_Boolean_IDictionary_2_String_Boolean_0;

		// Token: 0x0400258A RID: 9610
		private static readonly IntPtr NativeMethodInfoPtr_fkCsgBeNklizQmgRoURVAJjeQFY_Private_Static_Void_IDictionary_2_String_Boolean_String_0;

		// Token: 0x0400258B RID: 9611
		private static readonly IntPtr NativeMethodInfoPtr_BVUFZXHAEwKMUnhetAksVTjnNnHY_Private_Static_Void_IList_1_Joystick_IDictionary_2_String_Boolean_String_0;

		// Token: 0x0400258C RID: 9612
		private static readonly IntPtr NativeMethodInfoPtr_OKKcvCacRKKWAOsEGdhVuDNHFvNf_Private_Static_Void_IDictionary_2_String_Boolean_String_0;

		// Token: 0x0400258D RID: 9613
		private static readonly IntPtr NativeMethodInfoPtr_wTYJbwvdArqJdYJvyGFPhWNpydX_Private_Static_Void_IDictionary_2_String_Boolean_String_0;

		// Token: 0x0400258E RID: 9614
		private static readonly IntPtr NativeMethodInfoPtr_HMZYRMmiIHhNIKgVlPQxiQzNlFa_Private_Static_Void_IList_1_CustomController_IDictionary_2_String_Boolean_String_0;

		// Token: 0x0400258F RID: 9615
		private static readonly IntPtr NativeMethodInfoPtr_ptRivoTVCChFntjoDtMHzcCWsCP_Private_Static_Void_Player_Int32_IDictionary_2_String_Boolean_String_0;

		// Token: 0x04002590 RID: 9616
		private static readonly IntPtr NativeMethodInfoPtr_olTrmAjstLxolIFEZmfuwyerDmi_Private_Static_Void_IList_1_InputBehavior_IDictionary_2_String_Boolean_String_0;

		// Token: 0x04002591 RID: 9617
		private static readonly IntPtr NativeMethodInfoPtr_uWYYOEfLZqaXkqcDSiGjaFSQhQj_Private_Static_Void_InputBehavior_Int32_IDictionary_2_String_Boolean_String_0;

		// Token: 0x04002592 RID: 9618
		private static readonly IntPtr NativeMethodInfoPtr_fHsvTGXAzIzDXnAjSYjxQozqthG_Private_Static_Void_Controller_IDictionary_2_String_Boolean_String_0;

		// Token: 0x04002593 RID: 9619
		private static readonly IntPtr NativeMethodInfoPtr_TEaawutsbzicRTNpgArxuiOzoOu_Private_Static_Void_IList_1_Button_ControllerType_IDictionary_2_String_Boolean_String_0;

		// Token: 0x04002594 RID: 9620
		private static readonly IntPtr NativeMethodInfoPtr_HpMmHCxaglFAyshhEgPaVYeVUea_Private_Static_Void_IList_1_Axis_IDictionary_2_String_Boolean_String_0;

		// Token: 0x04002595 RID: 9621
		private static readonly IntPtr NativeMethodInfoPtr_riWeJzhahvDhVnOwQKUnGUEOqiX_Private_Static_Void_ControllerType_IList_1_T_String_IDictionary_2_String_Boolean_String_0;

		// Token: 0x04002596 RID: 9622
		private static readonly IntPtr NativeMethodInfoPtr_qrgWEnrZWqQUUizeLuJOIiOHBJy_Private_Static_Void_ControllerMap_IDictionary_2_String_Boolean_String_0;

		// Token: 0x04002597 RID: 9623
		private static readonly IntPtr NativeMethodInfoPtr_qrgWEnrZWqQUUizeLuJOIiOHBJy_Private_Static_Void_ControllerMapWithAxes_IDictionary_2_String_Boolean_String_0;

		// Token: 0x04002598 RID: 9624
		private static readonly IntPtr NativeMethodInfoPtr_pPWceXFlnbqDjgcrISXEKgvYAYQe_Private_Static_Void_ControllerType_ActionElementMap_Int32_IDictionary_2_String_Boolean_String_0;

		// Token: 0x04002599 RID: 9625
		private static readonly IntPtr NativeMethodInfoPtr_hDgOByaaIvOBggBQXBoTKUxSqcZU_Private_Static_String_ActionElementMap_0;

		// Token: 0x0400259A RID: 9626
		private static readonly IntPtr NativeMethodInfoPtr_AYnvzUExjhGJpUdTWYlLtzdTbok_Private_Static_Void_ControllerMapLayoutManager_IDictionary_2_String_Boolean_String_0;

		// Token: 0x0400259B RID: 9627
		private static readonly IntPtr NativeMethodInfoPtr_SlrncdHgEgkpmqVnFhCeSAGWhdoj_Private_Static_Void_RuleSet_Int32_IDictionary_2_String_Boolean_String_0;

		// Token: 0x0400259C RID: 9628
		private static readonly IntPtr NativeMethodInfoPtr_PaehhbDsFxPvjbWmXAwWfJVgqGxU_Private_Static_Void_ControllerMapEnabler_IDictionary_2_String_Boolean_String_0;

		// Token: 0x0400259D RID: 9629
		private static readonly IntPtr NativeMethodInfoPtr_tmYIgYgxpQhFebYxsNtiPDqdQBh_Private_Static_Void_RuleSet_Int32_IDictionary_2_String_Boolean_String_0;

		// Token: 0x0400259E RID: 9630
		private static readonly IntPtr NativeMethodInfoPtr_SPYlnQzwQzbZDhpXYrHMYTqYipM_Private_Static_Void_ControllerSetSelector_IDictionary_2_String_Boolean_String_0;

		// Token: 0x0400259F RID: 9631
		private static readonly IntPtr NativeMethodInfoPtr_CDBQmyohPqbhrfwbHytALuyDgFT_Private_Static_Void_Controller_IDictionary_2_String_Boolean_String_0;

		// Token: 0x040025A0 RID: 9632
		private static readonly IntPtr NativeMethodInfoPtr_YuDUPHTMXMNJZRVIyTpIiUTAKOQ_Private_Static_Void_IControllerTemplate_Int32_String_IDictionary_2_String_Boolean_0;

		// Token: 0x040025A1 RID: 9633
		private static readonly IntPtr NativeMethodInfoPtr_XdTksTLooAsdsEXTCJAcdiGjWil_Private_Static_Void_IControllerTemplateElement_Int32_String_IDictionary_2_String_Boolean_0;

		// Token: 0x040025A2 RID: 9634
		private static readonly IntPtr NativeMethodInfoPtr_YfyiaNBLKKkiBGNJLXJislqupnN_Private_Static_Void_IControllerTemplateAxis_String_String_IDictionary_2_String_Boolean_0;

		// Token: 0x040025A3 RID: 9635
		private static readonly IntPtr NativeMethodInfoPtr_yXCdtphVIekupRQFTJsbOHXMrixf_Private_Static_Void_IControllerTemplateButton_String_String_IDictionary_2_String_Boolean_0;

		// Token: 0x040025A4 RID: 9636
		private static readonly IntPtr NativeMethodInfoPtr_NvVJuLLxIEabrIUflqiEuGCfNYI_Private_Static_Void_IControllerTemplateAxis_String_IDictionary_2_String_Boolean_0;

		// Token: 0x040025A5 RID: 9637
		private static readonly IntPtr NativeMethodInfoPtr_EfeTwhytxaKBgYJzhoqPvqvTMSB_Private_Static_Void_IControllerTemplateButton_String_IDictionary_2_String_Boolean_0;

		// Token: 0x040025A6 RID: 9638
		private static readonly IntPtr NativeMethodInfoPtr_NcjUAdOoeNQhPbteLBgYMlhTxDv_Private_Static_Void_IControllerTemplateAxisSource_String_String_IDictionary_2_String_Boolean_0;

		// Token: 0x040025A7 RID: 9639
		private static readonly IntPtr NativeMethodInfoPtr_fBDMmQglACdzmCPNwFllJRDgdpfJ_Private_Static_Void_IControllerTemplateButtonSource_String_String_IDictionary_2_String_Boolean_0;

		// Token: 0x040025A8 RID: 9640
		private static readonly IntPtr NativeMethodInfoPtr_dBpCTrkhWClfnoBSSITHncXAhfFk_Private_Static_Void_IControllerElementTarget_String_String_IDictionary_2_String_Boolean_0;

		// Token: 0x040025A9 RID: 9641
		private static readonly IntPtr NativeMethodInfoPtr_tfBSlsupsKqYFeRiGxZCFmrjxRK_Private_Static_Boolean_String_Boolean_0;

		// Token: 0x040025AA RID: 9642
		private static readonly IntPtr NativeMethodInfoPtr_zgfUildcBmHBEkwrBUZjAgtJUkH_Private_Static_GUIStyle_0;

		// Token: 0x040025AB RID: 9643
		private static readonly IntPtr NativeMethodInfoPtr_GetToggleStyle_Public_Static_GUIStyle_0;

		// Token: 0x040025AC RID: 9644
		private static readonly IntPtr NativeMethodInfoPtr_aJDdpcVSrWmPovOHOCIscYqFBlJ_Private_Static_GUIStyle_GUIStyle_0;

		// Token: 0x040025AD RID: 9645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040025AE RID: 9646
		private static readonly IntPtr NativeMethodInfoPtr_JobhRxIKGHttaEIrCbWHNXsdebLo_Private_Static_Int32_InputAction_InputAction_0;

		// Token: 0x020003C4 RID: 964
		public class LROVzuKDcewtHvQofblLSRNtTxk : global::Il2CppSystem.Object
		{
			// Token: 0x06004F47 RID: 20295 RVA: 0x00168CDC File Offset: 0x00166EDC
			// Note: this type is marked as 'beforefieldinit'.
			static LROVzuKDcewtHvQofblLSRNtTxk()
			{
				Il2CppClassPointerStore<DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, "LROVzuKDcewtHvQofblLSRNtTxk");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk>.NativeClassPtr);
				DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk.NativeFieldInfoPtr_CEiBiUGlOOODuFTHelqAzLHfQUBR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk>.NativeClassPtr, "CEiBiUGlOOODuFTHelqAzLHfQUBR");
				DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk.NativeMethodInfoPtr__ctor_Public_Void_String_String_IDictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk>.NativeClassPtr, 100674732);
				DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk.NativeMethodInfoPtr_PKSRjXBSsmTROMRNUOlGssZCZWx_Private_Boolean_String_String_IDictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk>.NativeClassPtr, 100674733);
				DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk.NativeMethodInfoPtr_rjzVHbjunOKVZETRQSaiQPoMaIg_Private_Boolean_String_IDictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk>.NativeClassPtr, 100674734);
				DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk.NativeMethodInfoPtr_FZPJjvmxsnQJHgQFiazOrNEujhq_Private_Boolean_String_Boolean_IDictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk>.NativeClassPtr, 100674735);
				DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk>.NativeClassPtr, 100674736);
			}

			// Token: 0x06004F48 RID: 20296 RVA: 0x00168D80 File Offset: 0x00166F80
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 324718, RefRangeEnd = 324782, XrefRangeStart = 324695, XrefRangeEnd = 324718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LROVzuKDcewtHvQofblLSRNtTxk(string label, string key, IDictionary<string, bool> foldouts)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(foldouts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk.NativeMethodInfoPtr__ctor_Public_Void_String_String_IDictionary_2_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F49 RID: 20297 RVA: 0x00168DF0 File Offset: 0x00166FF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324782, XrefRangeEnd = 324801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool PKSRjXBSsmTROMRNUOlGssZCZWx(string A_1, string A_2, IDictionary<string, bool> A_3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk.NativeMethodInfoPtr_PKSRjXBSsmTROMRNUOlGssZCZWx_Private_Boolean_String_String_IDictionary_2_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F4A RID: 20298 RVA: 0x00168E64 File Offset: 0x00167064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324801, XrefRangeEnd = 324808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool rjzVHbjunOKVZETRQSaiQPoMaIg(string A_1, IDictionary<string, bool> A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk.NativeMethodInfoPtr_rjzVHbjunOKVZETRQSaiQPoMaIg_Private_Boolean_String_IDictionary_2_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F4B RID: 20299 RVA: 0x00168EC4 File Offset: 0x001670C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324808, XrefRangeEnd = 324812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool FZPJjvmxsnQJHgQFiazOrNEujhq(string A_1, bool A_2, IDictionary<string, bool> A_3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk.NativeMethodInfoPtr_FZPJjvmxsnQJHgQFiazOrNEujhq_Private_Boolean_String_Boolean_IDictionary_2_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F4C RID: 20300 RVA: 0x00168F34 File Offset: 0x00167134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324812, XrefRangeEnd = 324816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F4D RID: 20301 RVA: 0x0001CE32 File Offset: 0x0001B032
			public LROVzuKDcewtHvQofblLSRNtTxk(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700189B RID: 6299
			// (get) Token: 0x06004F4E RID: 20302 RVA: 0x00168F68 File Offset: 0x00167168
			// (set) Token: 0x06004F4F RID: 20303 RVA: 0x0001CE3B File Offset: 0x0001B03B
			public unsafe bool CEiBiUGlOOODuFTHelqAzLHfQUBR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk.NativeFieldInfoPtr_CEiBiUGlOOODuFTHelqAzLHfQUBR);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInformation.LROVzuKDcewtHvQofblLSRNtTxk.NativeFieldInfoPtr_CEiBiUGlOOODuFTHelqAzLHfQUBR)) = value;
				}
			}

			// Token: 0x04004227 RID: 16935
			private static readonly IntPtr NativeFieldInfoPtr_CEiBiUGlOOODuFTHelqAzLHfQUBR;

			// Token: 0x04004228 RID: 16936
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_IDictionary_2_String_Boolean_0;

			// Token: 0x04004229 RID: 16937
			private static readonly IntPtr NativeMethodInfoPtr_PKSRjXBSsmTROMRNUOlGssZCZWx_Private_Boolean_String_String_IDictionary_2_String_Boolean_0;

			// Token: 0x0400422A RID: 16938
			private static readonly IntPtr NativeMethodInfoPtr_rjzVHbjunOKVZETRQSaiQPoMaIg_Private_Boolean_String_IDictionary_2_String_Boolean_0;

			// Token: 0x0400422B RID: 16939
			private static readonly IntPtr NativeMethodInfoPtr_FZPJjvmxsnQJHgQFiazOrNEujhq_Private_Boolean_String_Boolean_IDictionary_2_String_Boolean_0;

			// Token: 0x0400422C RID: 16940
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x020003C5 RID: 965
		public static class JPZFdansVeeEnVytsiktkrfuMFu : global::Il2CppSystem.Object
		{
			// Token: 0x06004F50 RID: 20304 RVA: 0x00168F90 File Offset: 0x00167190
			// Note: this type is marked as 'beforefieldinit'.
			static JPZFdansVeeEnVytsiktkrfuMFu()
			{
				Il2CppClassPointerStore<DebugInformation.JPZFdansVeeEnVytsiktkrfuMFu>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, "JPZFdansVeeEnVytsiktkrfuMFu");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugInformation.JPZFdansVeeEnVytsiktkrfuMFu>.NativeClassPtr);
				DebugInformation.JPZFdansVeeEnVytsiktkrfuMFu.NativeFieldInfoPtr_sNfkDuVNbNdOBQvoCkslToCvCBI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInformation.JPZFdansVeeEnVytsiktkrfuMFu>.NativeClassPtr, "sNfkDuVNbNdOBQvoCkslToCvCBI");
				DebugInformation.JPZFdansVeeEnVytsiktkrfuMFu.NativeMethodInfoPtr_get_indentLevel_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.JPZFdansVeeEnVytsiktkrfuMFu>.NativeClassPtr, 100674737);
				DebugInformation.JPZFdansVeeEnVytsiktkrfuMFu.NativeMethodInfoPtr_set_indentLevel_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.JPZFdansVeeEnVytsiktkrfuMFu>.NativeClassPtr, 100674738);
			}

			// Token: 0x1700189D RID: 6301
			// (get) Token: 0x06004F51 RID: 20305 RVA: 0x00168FF8 File Offset: 0x001671F8
			// (set) Token: 0x06004F52 RID: 20306 RVA: 0x00169028 File Offset: 0x00167228
			public unsafe static int rynMfYvoAjVePsBGPWvmtfOiuXO
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324816, XrefRangeEnd = 324818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.JPZFdansVeeEnVytsiktkrfuMFu.NativeMethodInfoPtr_get_indentLevel_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324818, XrefRangeEnd = 324820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.JPZFdansVeeEnVytsiktkrfuMFu.NativeMethodInfoPtr_set_indentLevel_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004F53 RID: 20307 RVA: 0x0001CE56 File Offset: 0x0001B056
			public JPZFdansVeeEnVytsiktkrfuMFu(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700189C RID: 6300
			// (get) Token: 0x06004F54 RID: 20308 RVA: 0x0016905C File Offset: 0x0016725C
			// (set) Token: 0x06004F55 RID: 20309 RVA: 0x0001CE5F File Offset: 0x0001B05F
			public unsafe static int sNfkDuVNbNdOBQvoCkslToCvCBI
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DebugInformation.JPZFdansVeeEnVytsiktkrfuMFu.NativeFieldInfoPtr_sNfkDuVNbNdOBQvoCkslToCvCBI, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugInformation.JPZFdansVeeEnVytsiktkrfuMFu.NativeFieldInfoPtr_sNfkDuVNbNdOBQvoCkslToCvCBI, (void*)(&value));
				}
			}

			// Token: 0x0400422D RID: 16941
			private static readonly IntPtr NativeFieldInfoPtr_sNfkDuVNbNdOBQvoCkslToCvCBI;

			// Token: 0x0400422E RID: 16942
			private static readonly IntPtr NativeMethodInfoPtr_get_indentLevel_Public_Static_get_Int32_0;

			// Token: 0x0400422F RID: 16943
			private static readonly IntPtr NativeMethodInfoPtr_set_indentLevel_Public_Static_set_Void_Int32_0;
		}

		// Token: 0x020003C6 RID: 966
		public static class YRWNfcZdhIrlcYZUpFkQOSMGPQr : global::Il2CppSystem.Object
		{
			// Token: 0x06004F56 RID: 20310 RVA: 0x00169078 File Offset: 0x00167278
			// Note: this type is marked as 'beforefieldinit'.
			static YRWNfcZdhIrlcYZUpFkQOSMGPQr()
			{
				Il2CppClassPointerStore<DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, "YRWNfcZdhIrlcYZUpFkQOSMGPQr");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr>.NativeClassPtr);
				DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr.NativeMethodInfoPtr_KFGlxCsSrNaMpVgJBTBYpewSzFW_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr>.NativeClassPtr, 100674739);
				DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr.NativeMethodInfoPtr_FqfcWRDFtNJbKQLslRFTmLHjmjYN_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr>.NativeClassPtr, 100674740);
				DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr.NativeMethodInfoPtr_FlEEbNyPNRbbHlYotmefPxCMHuI_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr>.NativeClassPtr, 100674741);
				DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr.NativeMethodInfoPtr_xPXCJyxOOBEMWElPGjlpKtafBwXb_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr>.NativeClassPtr, 100674742);
				DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr.NativeMethodInfoPtr_eFZGxbMvbPVJbEEfDoHzeqkyEZl_Public_Static_Void_String_GxlkqOEnnxFPvZgVjuBpEASHFHy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr>.NativeClassPtr, 100674743);
				DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr.NativeMethodInfoPtr_gtWUgivFGGCzWaoaAgGPAnMCqEQe_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr>.NativeClassPtr, 100674744);
				DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr.NativeMethodInfoPtr_EpqugivNuOnBDljVtlJtcgzrRQk_Public_Static_Void_String_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr>.NativeClassPtr, 100674745);
				DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr.NativeMethodInfoPtr_tfBSlsupsKqYFeRiGxZCFmrjxRK_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr>.NativeClassPtr, 100674746);
			}

			// Token: 0x06004F57 RID: 20311 RVA: 0x00169144 File Offset: 0x00167344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324820, XrefRangeEnd = 324824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void KFGlxCsSrNaMpVgJBTBYpewSzFW()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr.NativeMethodInfoPtr_KFGlxCsSrNaMpVgJBTBYpewSzFW_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F58 RID: 20312 RVA: 0x0016916C File Offset: 0x0016736C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 324828, RefRangeEnd = 324835, XrefRangeStart = 324824, XrefRangeEnd = 324828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void FqfcWRDFtNJbKQLslRFTmLHjmjYN()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr.NativeMethodInfoPtr_FqfcWRDFtNJbKQLslRFTmLHjmjYN_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F59 RID: 20313 RVA: 0x00169194 File Offset: 0x00167394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324835, XrefRangeEnd = 324839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void FlEEbNyPNRbbHlYotmefPxCMHuI()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr.NativeMethodInfoPtr_FlEEbNyPNRbbHlYotmefPxCMHuI_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F5A RID: 20314 RVA: 0x001691BC File Offset: 0x001673BC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 324843, RefRangeEnd = 324845, XrefRangeStart = 324839, XrefRangeEnd = 324843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void xPXCJyxOOBEMWElPGjlpKtafBwXb()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr.NativeMethodInfoPtr_xPXCJyxOOBEMWElPGjlpKtafBwXb_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F5B RID: 20315 RVA: 0x001691E4 File Offset: 0x001673E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324845, XrefRangeEnd = 324850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void eFZGxbMvbPVJbEEfDoHzeqkyEZl(string A_0, DebugInformation.GxlkqOEnnxFPvZgVjuBpEASHFHy A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr.NativeMethodInfoPtr_eFZGxbMvbPVJbEEfDoHzeqkyEZl_Public_Static_Void_String_GxlkqOEnnxFPvZgVjuBpEASHFHy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F5C RID: 20316 RVA: 0x00169228 File Offset: 0x00167428
			[CallerCount(223)]
			[CachedScanResults(RefRangeStart = 324858, RefRangeEnd = 325081, XrefRangeStart = 324850, XrefRangeEnd = 324858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void gtWUgivFGGCzWaoaAgGPAnMCqEQe(string A_0, string A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr.NativeMethodInfoPtr_gtWUgivFGGCzWaoaAgGPAnMCqEQe_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F5D RID: 20317 RVA: 0x00169270 File Offset: 0x00167470
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 325088, RefRangeEnd = 325090, XrefRangeStart = 325081, XrefRangeEnd = 325088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void EpqugivNuOnBDljVtlJtcgzrRQk(string A_0, AnimationCurve A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr.NativeMethodInfoPtr_EpqugivNuOnBDljVtlJtcgzrRQk_Public_Static_Void_String_AnimationCurve_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F5E RID: 20318 RVA: 0x001692B8 File Offset: 0x001674B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325090, XrefRangeEnd = 325095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool tfBSlsupsKqYFeRiGxZCFmrjxRK(string A_0, bool A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.YRWNfcZdhIrlcYZUpFkQOSMGPQr.NativeMethodInfoPtr_tfBSlsupsKqYFeRiGxZCFmrjxRK_Public_Static_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F5F RID: 20319 RVA: 0x0001CE6D File Offset: 0x0001B06D
			public YRWNfcZdhIrlcYZUpFkQOSMGPQr(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004230 RID: 16944
			private static readonly IntPtr NativeMethodInfoPtr_KFGlxCsSrNaMpVgJBTBYpewSzFW_Public_Static_Void_0;

			// Token: 0x04004231 RID: 16945
			private static readonly IntPtr NativeMethodInfoPtr_FqfcWRDFtNJbKQLslRFTmLHjmjYN_Public_Static_Void_0;

			// Token: 0x04004232 RID: 16946
			private static readonly IntPtr NativeMethodInfoPtr_FlEEbNyPNRbbHlYotmefPxCMHuI_Public_Static_Void_0;

			// Token: 0x04004233 RID: 16947
			private static readonly IntPtr NativeMethodInfoPtr_xPXCJyxOOBEMWElPGjlpKtafBwXb_Public_Static_Void_0;

			// Token: 0x04004234 RID: 16948
			private static readonly IntPtr NativeMethodInfoPtr_eFZGxbMvbPVJbEEfDoHzeqkyEZl_Public_Static_Void_String_GxlkqOEnnxFPvZgVjuBpEASHFHy_0;

			// Token: 0x04004235 RID: 16949
			private static readonly IntPtr NativeMethodInfoPtr_gtWUgivFGGCzWaoaAgGPAnMCqEQe_Public_Static_Void_String_String_0;

			// Token: 0x04004236 RID: 16950
			private static readonly IntPtr NativeMethodInfoPtr_EpqugivNuOnBDljVtlJtcgzrRQk_Public_Static_Void_String_AnimationCurve_0;

			// Token: 0x04004237 RID: 16951
			private static readonly IntPtr NativeMethodInfoPtr_tfBSlsupsKqYFeRiGxZCFmrjxRK_Public_Static_Boolean_String_Boolean_0;
		}

		// Token: 0x020003C7 RID: 967
		public static class wlLYkAXWehZpJpQvNXFKxvfenCF : global::Il2CppSystem.Object
		{
			// Token: 0x06004F60 RID: 20320 RVA: 0x00169308 File Offset: 0x00167508
			// Note: this type is marked as 'beforefieldinit'.
			static wlLYkAXWehZpJpQvNXFKxvfenCF()
			{
				Il2CppClassPointerStore<DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, "wlLYkAXWehZpJpQvNXFKxvfenCF");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF>.NativeClassPtr);
				DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF.NativeFieldInfoPtr_fvxnPKNNYkzhhUoDhqDHyGaLduD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF>.NativeClassPtr, "fvxnPKNNYkzhhUoDhqDHyGaLduD");
				DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF.NativeFieldInfoPtr_bdZPJiDXqUbFyRDSGWZQbrxiEmH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF>.NativeClassPtr, "bdZPJiDXqUbFyRDSGWZQbrxiEmH");
				DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF.NativeMethodInfoPtr_get_labelWidth_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF>.NativeClassPtr, 100674747);
				DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF.NativeMethodInfoPtr_set_labelWidth_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF>.NativeClassPtr, 100674748);
				DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF.NativeMethodInfoPtr_get_fieldWidth_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF>.NativeClassPtr, 100674749);
				DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF.NativeMethodInfoPtr_set_fieldWidth_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF>.NativeClassPtr, 100674750);
			}

			// Token: 0x170018A0 RID: 6304
			// (get) Token: 0x06004F61 RID: 20321 RVA: 0x001693AC File Offset: 0x001675AC
			// (set) Token: 0x06004F62 RID: 20322 RVA: 0x001693DC File Offset: 0x001675DC
			public unsafe static float ahxbwVnjjlYQIcWnXXhjUJyiTfw
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325095, XrefRangeEnd = 325097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF.NativeMethodInfoPtr_get_labelWidth_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325097, XrefRangeEnd = 325099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF.NativeMethodInfoPtr_set_labelWidth_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170018A1 RID: 6305
			// (get) Token: 0x06004F63 RID: 20323 RVA: 0x00169410 File Offset: 0x00167610
			// (set) Token: 0x06004F64 RID: 20324 RVA: 0x00169440 File Offset: 0x00167640
			public unsafe static float bgwUENcossQhbMJjHIqgZuUbMDO
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325099, XrefRangeEnd = 325101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF.NativeMethodInfoPtr_get_fieldWidth_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325101, XrefRangeEnd = 325103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF.NativeMethodInfoPtr_set_fieldWidth_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004F65 RID: 20325 RVA: 0x0001CE76 File Offset: 0x0001B076
			public wlLYkAXWehZpJpQvNXFKxvfenCF(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700189E RID: 6302
			// (get) Token: 0x06004F66 RID: 20326 RVA: 0x00169474 File Offset: 0x00167674
			// (set) Token: 0x06004F67 RID: 20327 RVA: 0x0001CE7F File Offset: 0x0001B07F
			public unsafe static float fvxnPKNNYkzhhUoDhqDHyGaLduD
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF.NativeFieldInfoPtr_fvxnPKNNYkzhhUoDhqDHyGaLduD, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF.NativeFieldInfoPtr_fvxnPKNNYkzhhUoDhqDHyGaLduD, (void*)(&value));
				}
			}

			// Token: 0x1700189F RID: 6303
			// (get) Token: 0x06004F68 RID: 20328 RVA: 0x00169490 File Offset: 0x00167690
			// (set) Token: 0x06004F69 RID: 20329 RVA: 0x0001CE8D File Offset: 0x0001B08D
			public unsafe static float bdZPJiDXqUbFyRDSGWZQbrxiEmH
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF.NativeFieldInfoPtr_bdZPJiDXqUbFyRDSGWZQbrxiEmH, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugInformation.wlLYkAXWehZpJpQvNXFKxvfenCF.NativeFieldInfoPtr_bdZPJiDXqUbFyRDSGWZQbrxiEmH, (void*)(&value));
				}
			}

			// Token: 0x04004238 RID: 16952
			private static readonly IntPtr NativeFieldInfoPtr_fvxnPKNNYkzhhUoDhqDHyGaLduD;

			// Token: 0x04004239 RID: 16953
			private static readonly IntPtr NativeFieldInfoPtr_bdZPJiDXqUbFyRDSGWZQbrxiEmH;

			// Token: 0x0400423A RID: 16954
			private static readonly IntPtr NativeMethodInfoPtr_get_labelWidth_Public_Static_get_Single_0;

			// Token: 0x0400423B RID: 16955
			private static readonly IntPtr NativeMethodInfoPtr_set_labelWidth_Public_Static_set_Void_Single_0;

			// Token: 0x0400423C RID: 16956
			private static readonly IntPtr NativeMethodInfoPtr_get_fieldWidth_Public_Static_get_Single_0;

			// Token: 0x0400423D RID: 16957
			private static readonly IntPtr NativeMethodInfoPtr_set_fieldWidth_Public_Static_set_Void_Single_0;
		}

		// Token: 0x020003C8 RID: 968
		[OriginalName("Rewired_Core.dll", "", "GxlkqOEnnxFPvZgVjuBpEASHFHy")]
		public enum GxlkqOEnnxFPvZgVjuBpEASHFHy
		{
			// Token: 0x0400423F RID: 16959
			urhBwQidoSAKHIhcxeCWNbALMhkh,
			// Token: 0x04004240 RID: 16960
			szRMWGOMVKgdfHnYafWRKaXvwwg,
			// Token: 0x04004241 RID: 16961
			RxKEHekzpweiKtPMQTINfzipbiGn,
			// Token: 0x04004242 RID: 16962
			ichYuhKAMOKZuOYdULWGKyNWwBv
		}

		// Token: 0x020003C9 RID: 969
		public sealed class ibXiMIAtLDySTZsZBIUFPqySDnx : global::Il2CppSystem.Object
		{
			// Token: 0x06004F6A RID: 20330 RVA: 0x001694AC File Offset: 0x001676AC
			// Note: this type is marked as 'beforefieldinit'.
			static ibXiMIAtLDySTZsZBIUFPqySDnx()
			{
				Il2CppClassPointerStore<DebugInformation.ibXiMIAtLDySTZsZBIUFPqySDnx>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugInformation>.NativeClassPtr, "ibXiMIAtLDySTZsZBIUFPqySDnx");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugInformation.ibXiMIAtLDySTZsZBIUFPqySDnx>.NativeClassPtr);
				DebugInformation.ibXiMIAtLDySTZsZBIUFPqySDnx.NativeFieldInfoPtr_PxvfCfyrUMGbbsirHLwiZfjromF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInformation.ibXiMIAtLDySTZsZBIUFPqySDnx>.NativeClassPtr, "PxvfCfyrUMGbbsirHLwiZfjromF");
				DebugInformation.ibXiMIAtLDySTZsZBIUFPqySDnx.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.ibXiMIAtLDySTZsZBIUFPqySDnx>.NativeClassPtr, 100674751);
				DebugInformation.ibXiMIAtLDySTZsZBIUFPqySDnx.NativeMethodInfoPtr_dtwdUABCkdaGgpgwyZTNtSKmILeV_Public_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInformation.ibXiMIAtLDySTZsZBIUFPqySDnx>.NativeClassPtr, 100674752);
			}

			// Token: 0x06004F6B RID: 20331 RVA: 0x00169514 File Offset: 0x00167714
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ibXiMIAtLDySTZsZBIUFPqySDnx()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugInformation.ibXiMIAtLDySTZsZBIUFPqySDnx>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.ibXiMIAtLDySTZsZBIUFPqySDnx.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F6C RID: 20332 RVA: 0x00169550 File Offset: 0x00167750
			[CallerCount(0)]
			public unsafe bool dtwdUABCkdaGgpgwyZTNtSKmILeV(InputAction A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInformation.ibXiMIAtLDySTZsZBIUFPqySDnx.NativeMethodInfoPtr_dtwdUABCkdaGgpgwyZTNtSKmILeV_Public_Boolean_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F6D RID: 20333 RVA: 0x0001CE9B File Offset: 0x0001B09B
			public ibXiMIAtLDySTZsZBIUFPqySDnx(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018A2 RID: 6306
			// (get) Token: 0x06004F6E RID: 20334 RVA: 0x001695A0 File Offset: 0x001677A0
			// (set) Token: 0x06004F6F RID: 20335 RVA: 0x0001CEA4 File Offset: 0x0001B0A4
			public unsafe InputCategory PxvfCfyrUMGbbsirHLwiZfjromF
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInformation.ibXiMIAtLDySTZsZBIUFPqySDnx.NativeFieldInfoPtr_PxvfCfyrUMGbbsirHLwiZfjromF);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputCategory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInformation.ibXiMIAtLDySTZsZBIUFPqySDnx.NativeFieldInfoPtr_PxvfCfyrUMGbbsirHLwiZfjromF), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004243 RID: 16963
			private static readonly IntPtr NativeFieldInfoPtr_PxvfCfyrUMGbbsirHLwiZfjromF;

			// Token: 0x04004244 RID: 16964
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004245 RID: 16965
			private static readonly IntPtr NativeMethodInfoPtr_dtwdUABCkdaGgpgwyZTNtSKmILeV_Public_Boolean_InputAction_0;
		}

		// Token: 0x020003CA RID: 970
		private sealed class MethodInfoStoreGeneric_riWeJzhahvDhVnOwQKUnGUEOqiX_Private_Static_Void_ControllerType_IList_1_T_String_IDictionary_2_String_Boolean_String_0<T>
		{
			// Token: 0x04004246 RID: 16966
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DebugInformation.NativeMethodInfoPtr_riWeJzhahvDhVnOwQKUnGUEOqiX_Private_Static_Void_ControllerType_IList_1_T_String_IDictionary_2_String_Boolean_String_0, Il2CppClassPointerStore<DebugInformation>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
