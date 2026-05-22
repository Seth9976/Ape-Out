using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppRewired
{
	// Token: 0x0200015C RID: 348
	public sealed class InputMapper : Object
	{
		// Token: 0x06002723 RID: 10019 RVA: 0x000C6260 File Offset: 0x000C4460
		// Note: this type is marked as 'beforefieldinit'.
		static InputMapper()
		{
			Il2CppClassPointerStore<InputMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "InputMapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMapper>.NativeClassPtr);
			InputMapper.NativeFieldInfoPtr_uosTDNMCuodpKVbExRdngcDMBdu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "uosTDNMCuodpKVbExRdngcDMBdu");
			InputMapper.NativeFieldInfoPtr_RjwmYEibkfiaAGiWNMLelFqDjlh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "RjwmYEibkfiaAGiWNMLelFqDjlh");
			InputMapper.NativeFieldInfoPtr_keSsYQvXDfhyUGPCiygoFqkRVRw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "keSsYQvXDfhyUGPCiygoFqkRVRw");
			InputMapper.NativeFieldInfoPtr_wYbaLhihfFlnmCnjhVQVlAoxhxsZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "wYbaLhihfFlnmCnjhVQVlAoxhxsZ");
			InputMapper.NativeFieldInfoPtr_yoFTkMYePDFsNyheNnXFccpYDXs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "yoFTkMYePDFsNyheNnXFccpYDXs");
			InputMapper.NativeFieldInfoPtr_pvnMWcEaMfdHVEzYZcFstMNcIJG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "pvnMWcEaMfdHVEzYZcFstMNcIJG");
			InputMapper.NativeFieldInfoPtr_EolqjSEMIQCAaMZnTpWhdUKpDqz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "EolqjSEMIQCAaMZnTpWhdUKpDqz");
			InputMapper.NativeFieldInfoPtr_TnjGfActQoYxORiAJMZFVLKvzSqq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "TnjGfActQoYxORiAJMZFVLKvzSqq");
			InputMapper.NativeFieldInfoPtr_pYmiUPJPTBSAxkoTMtgdkKSPgMk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "pYmiUPJPTBSAxkoTMtgdkKSPgMk");
			InputMapper.NativeFieldInfoPtr_KZJeKGmVCCwOmDauLwTHFXaElVW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "KZJeKGmVCCwOmDauLwTHFXaElVW");
			InputMapper.NativeFieldInfoPtr_fLFpHVQnsuobZbdJnHTVVQDxIDpa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "fLFpHVQnsuobZbdJnHTVVQDxIDpa");
			InputMapper.NativeFieldInfoPtr_LitcOpIIbGBsPjdzYsPCbcRHIKWZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "LitcOpIIbGBsPjdzYsPCbcRHIKWZ");
			InputMapper.NativeFieldInfoPtr_gCuUadDmcMFLNzQinFNSXhAQJry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "gCuUadDmcMFLNzQinFNSXhAQJry");
			InputMapper.NativeFieldInfoPtr_xTJJtXbkAMcFJChaqXiRwULMHGnC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "xTJJtXbkAMcFJChaqXiRwULMHGnC");
			InputMapper.NativeMethodInfoPtr_get_Default_Public_Static_get_InputMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671692);
			InputMapper.NativeMethodInfoPtr_NeUlzCfjqhEJeQoacnyKmAJEMsC_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671693);
			InputMapper.NativeMethodInfoPtr_get_options_Public_get_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671694);
			InputMapper.NativeMethodInfoPtr_set_options_Public_set_Void_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671695);
			InputMapper.NativeMethodInfoPtr_get_mappingContext_Public_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671696);
			InputMapper.NativeMethodInfoPtr_get_status_Public_get_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671697);
			InputMapper.NativeMethodInfoPtr_get_timeRemaining_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671698);
			InputMapper.NativeMethodInfoPtr_get_id_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671699);
			InputMapper.NativeMethodInfoPtr_add_InputMappedEvent_Public_add_Void_Action_1_InputMappedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671700);
			InputMapper.NativeMethodInfoPtr_remove_InputMappedEvent_Public_rem_Void_Action_1_InputMappedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671701);
			InputMapper.NativeMethodInfoPtr_add_ErrorEvent_Public_add_Void_Action_1_ErrorEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671702);
			InputMapper.NativeMethodInfoPtr_remove_ErrorEvent_Public_rem_Void_Action_1_ErrorEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671703);
			InputMapper.NativeMethodInfoPtr_add_CanceledEvent_Public_add_Void_Action_1_CanceledEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671704);
			InputMapper.NativeMethodInfoPtr_remove_CanceledEvent_Public_rem_Void_Action_1_CanceledEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671705);
			InputMapper.NativeMethodInfoPtr_add_TimedOutEvent_Public_add_Void_Action_1_TimedOutEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671706);
			InputMapper.NativeMethodInfoPtr_remove_TimedOutEvent_Public_rem_Void_Action_1_TimedOutEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671707);
			InputMapper.NativeMethodInfoPtr_add_StartedEvent_Public_add_Void_Action_1_StartedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671708);
			InputMapper.NativeMethodInfoPtr_remove_StartedEvent_Public_rem_Void_Action_1_StartedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671709);
			InputMapper.NativeMethodInfoPtr_add_StoppedEvent_Public_add_Void_Action_1_StoppedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671710);
			InputMapper.NativeMethodInfoPtr_remove_StoppedEvent_Public_rem_Void_Action_1_StoppedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671711);
			InputMapper.NativeMethodInfoPtr_add_ConflictFoundEvent_Public_add_Void_Action_1_ConflictFoundEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671712);
			InputMapper.NativeMethodInfoPtr_remove_ConflictFoundEvent_Public_rem_Void_Action_1_ConflictFoundEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671713);
			InputMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671714);
			InputMapper.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671715);
			InputMapper.NativeMethodInfoPtr_RemoveEventListeners_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671716);
			InputMapper.NativeMethodInfoPtr_RemoveAllEventListeners_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671717);
			InputMapper.NativeMethodInfoPtr_GjrownYLLiHMbVoBqflPDINetZA_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671718);
			InputMapper.NativeMethodInfoPtr_sXEMNEyAzEzUEcjDLpsZpLDuuxP_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671719);
			InputMapper.NativeMethodInfoPtr_Start_Public_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671720);
			InputMapper.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671721);
			InputMapper.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671722);
			InputMapper.NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Private_Boolean_Context_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671723);
			InputMapper.NativeMethodInfoPtr_OUjQkTqHdKDKTdWxkgBYSsdbWWhi_Private_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671724);
			InputMapper.NativeMethodInfoPtr_lCXemqrZsgUhCfTWmorHVGADRQm_Private_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671725);
			InputMapper.NativeMethodInfoPtr_IrnxTVxqPjcTGlzgoFIbvuyffjY_Private_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671726);
			InputMapper.NativeMethodInfoPtr_zDobrlnHmPfIKQeOlUwOinjlkbw_Private_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671727);
			InputMapper.NativeMethodInfoPtr_FzEzswJkzejQdRpUhiufKOIkIkI_Private_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671728);
			InputMapper.NativeMethodInfoPtr_ZuqHJGGoTNCgnGBaVSljlbPfkoqz_Private_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671729);
			InputMapper.NativeMethodInfoPtr_DxbUuxuADcBTMJfmaXdaZItXTmN_Private_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, 100671730);
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x000C66B4 File Offset: 0x000C48B4
		public unsafe static InputMapper Default
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 296017, RefRangeEnd = 296018, XrefRangeStart = 296008, XrefRangeEnd = 296017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_get_Default_Public_Static_get_InputMapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputMapper>(intPtr3) : null;
			}
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x000C66E8 File Offset: 0x000C48E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296018, XrefRangeEnd = 296024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NeUlzCfjqhEJeQoacnyKmAJEMsC()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_NeUlzCfjqhEJeQoacnyKmAJEMsC_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002726 RID: 10022 RVA: 0x000C6718 File Offset: 0x000C4918
		// (set) Token: 0x06002727 RID: 10023 RVA: 0x000C6758 File Offset: 0x000C4958
		public unsafe InputMapper.Options options
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 296030, RefRangeEnd = 296044, XrefRangeStart = 296024, XrefRangeEnd = 296030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_get_options_Public_get_Options_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputMapper.Options>(intPtr3) : null;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_set_options_Public_set_Void_Options_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002728 RID: 10024 RVA: 0x000C679C File Offset: 0x000C499C
		public unsafe InputMapper.Context mappingContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_get_mappingContext_Public_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputMapper.Context>(intPtr3) : null;
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002729 RID: 10025 RVA: 0x000C67DC File Offset: 0x000C49DC
		public unsafe InputMapper.Status status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_get_status_Public_get_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x0600272A RID: 10026 RVA: 0x000C6818 File Offset: 0x000C4A18
		public unsafe float timeRemaining
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296044, XrefRangeEnd = 296046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_get_timeRemaining_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x000C6854 File Offset: 0x000C4A54
		public unsafe int id
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_get_id_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x000C6890 File Offset: 0x000C4A90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 296064, RefRangeEnd = 296067, XrefRangeStart = 296046, XrefRangeEnd = 296064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_InputMappedEvent(Action<InputMapper.InputMappedEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_add_InputMappedEvent_Public_add_Void_Action_1_InputMappedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x000C68D4 File Offset: 0x000C4AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296067, XrefRangeEnd = 296077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_InputMappedEvent(Action<InputMapper.InputMappedEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_remove_InputMappedEvent_Public_rem_Void_Action_1_InputMappedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x000C6918 File Offset: 0x000C4B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296077, XrefRangeEnd = 296095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ErrorEvent(Action<InputMapper.ErrorEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_add_ErrorEvent_Public_add_Void_Action_1_ErrorEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x000C695C File Offset: 0x000C4B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296095, XrefRangeEnd = 296105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ErrorEvent(Action<InputMapper.ErrorEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_remove_ErrorEvent_Public_rem_Void_Action_1_ErrorEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x000C69A0 File Offset: 0x000C4BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296105, XrefRangeEnd = 296123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CanceledEvent(Action<InputMapper.CanceledEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_add_CanceledEvent_Public_add_Void_Action_1_CanceledEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x000C69E4 File Offset: 0x000C4BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296123, XrefRangeEnd = 296133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CanceledEvent(Action<InputMapper.CanceledEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_remove_CanceledEvent_Public_rem_Void_Action_1_CanceledEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x000C6A28 File Offset: 0x000C4C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296133, XrefRangeEnd = 296151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_TimedOutEvent(Action<InputMapper.TimedOutEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_add_TimedOutEvent_Public_add_Void_Action_1_TimedOutEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x000C6A6C File Offset: 0x000C4C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296151, XrefRangeEnd = 296161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_TimedOutEvent(Action<InputMapper.TimedOutEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_remove_TimedOutEvent_Public_rem_Void_Action_1_TimedOutEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x000C6AB0 File Offset: 0x000C4CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296161, XrefRangeEnd = 296179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_StartedEvent(Action<InputMapper.StartedEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_add_StartedEvent_Public_add_Void_Action_1_StartedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x000C6AF4 File Offset: 0x000C4CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296179, XrefRangeEnd = 296189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_StartedEvent(Action<InputMapper.StartedEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_remove_StartedEvent_Public_rem_Void_Action_1_StartedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x000C6B38 File Offset: 0x000C4D38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 296207, RefRangeEnd = 296211, XrefRangeStart = 296189, XrefRangeEnd = 296207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_StoppedEvent(Action<InputMapper.StoppedEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_add_StoppedEvent_Public_add_Void_Action_1_StoppedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x000C6B7C File Offset: 0x000C4D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296211, XrefRangeEnd = 296221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_StoppedEvent(Action<InputMapper.StoppedEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_remove_StoppedEvent_Public_rem_Void_Action_1_StoppedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x000C6BC0 File Offset: 0x000C4DC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296239, RefRangeEnd = 296240, XrefRangeStart = 296221, XrefRangeEnd = 296239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ConflictFoundEvent(Action<InputMapper.ConflictFoundEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_add_ConflictFoundEvent_Public_add_Void_Action_1_ConflictFoundEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x000C6C04 File Offset: 0x000C4E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296240, XrefRangeEnd = 296250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ConflictFoundEvent(Action<InputMapper.ConflictFoundEventData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_remove_ConflictFoundEvent_Public_rem_Void_Action_1_ConflictFoundEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x000C6C48 File Offset: 0x000C4E48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 296261, RefRangeEnd = 296265, XrefRangeStart = 296250, XrefRangeEnd = 296261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputMapper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x000C6C84 File Offset: 0x000C4E84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296410, RefRangeEnd = 296412, XrefRangeStart = 296265, XrefRangeEnd = 296410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputMapper(bool isDefault)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isDefault;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x000C6CCC File Offset: 0x000C4ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296412, XrefRangeEnd = 296421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEventListeners(Object listenerOrParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listenerOrParent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_RemoveEventListeners_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x000C6D10 File Offset: 0x000C4F10
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 296430, RefRangeEnd = 296437, XrefRangeStart = 296421, XrefRangeEnd = 296430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAllEventListeners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_RemoveAllEventListeners_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x000C6D44 File Offset: 0x000C4F44
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GjrownYLLiHMbVoBqflPDINetZA(Object A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_GjrownYLLiHMbVoBqflPDINetZA_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x000C6D88 File Offset: 0x000C4F88
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void sXEMNEyAzEzUEcjDLpsZpLDuuxP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_sXEMNEyAzEzUEcjDLpsZpLDuuxP_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x000C6DBC File Offset: 0x000C4FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296444, RefRangeEnd = 296445, XrefRangeStart = 296437, XrefRangeEnd = 296444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Start(InputMapper.Context mappingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mappingContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_Start_Public_Boolean_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x000C6E0C File Offset: 0x000C500C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296445, XrefRangeEnd = 296448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x000C6E40 File Offset: 0x000C5040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296448, XrefRangeEnd = 296452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x000C6E74 File Offset: 0x000C5074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296481, RefRangeEnd = 296482, XrefRangeStart = 296452, XrefRangeEnd = 296481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool qeDEyDaZsAupdNZCUOgsfUHyXvg(InputMapper.Context A_1, InputMapper.Options A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Private_Boolean_Context_Options_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x000C6ED4 File Offset: 0x000C50D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296482, XrefRangeEnd = 296488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OUjQkTqHdKDKTdWxkgBYSsdbWWhi(Exception A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_OUjQkTqHdKDKTdWxkgBYSsdbWWhi_Private_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x000C6F0C File Offset: 0x000C510C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296488, XrefRangeEnd = 296494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void lCXemqrZsgUhCfTWmorHVGADRQm(Exception A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_lCXemqrZsgUhCfTWmorHVGADRQm_Private_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x000C6F44 File Offset: 0x000C5144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296494, XrefRangeEnd = 296500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IrnxTVxqPjcTGlzgoFIbvuyffjY(Exception A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_IrnxTVxqPjcTGlzgoFIbvuyffjY_Private_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x000C6F7C File Offset: 0x000C517C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296500, XrefRangeEnd = 296506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void zDobrlnHmPfIKQeOlUwOinjlkbw(Exception A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_zDobrlnHmPfIKQeOlUwOinjlkbw_Private_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x000C6FB4 File Offset: 0x000C51B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296506, XrefRangeEnd = 296512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FzEzswJkzejQdRpUhiufKOIkIkI(Exception A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_FzEzswJkzejQdRpUhiufKOIkIkI_Private_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x000C6FEC File Offset: 0x000C51EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296512, XrefRangeEnd = 296518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ZuqHJGGoTNCgnGBaVSljlbPfkoqz(Exception A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_ZuqHJGGoTNCgnGBaVSljlbPfkoqz_Private_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x000C7024 File Offset: 0x000C5224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296518, XrefRangeEnd = 296526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DxbUuxuADcBTMJfmaXdaZItXTmN(Exception A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.NativeMethodInfoPtr_DxbUuxuADcBTMJfmaXdaZItXTmN_Private_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x0000F528 File Offset: 0x0000D728
		public InputMapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x000C705C File Offset: 0x000C525C
		// (set) Token: 0x0600274D RID: 10061 RVA: 0x0000F531 File Offset: 0x0000D731
		public unsafe static InputMapper uosTDNMCuodpKVbExRdngcDMBdu
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputMapper.NativeFieldInfoPtr_uosTDNMCuodpKVbExRdngcDMBdu, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputMapper>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputMapper.NativeFieldInfoPtr_uosTDNMCuodpKVbExRdngcDMBdu, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x000C7084 File Offset: 0x000C5284
		// (set) Token: 0x0600274F RID: 10063 RVA: 0x0000F543 File Offset: 0x0000D743
		public unsafe static int RjwmYEibkfiaAGiWNMLelFqDjlh
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(InputMapper.NativeFieldInfoPtr_RjwmYEibkfiaAGiWNMLelFqDjlh, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputMapper.NativeFieldInfoPtr_RjwmYEibkfiaAGiWNMLelFqDjlh, (void*)(&value));
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x000C70A0 File Offset: 0x000C52A0
		// (set) Token: 0x06002751 RID: 10065 RVA: 0x0000F551 File Offset: 0x0000D751
		public unsafe int keSsYQvXDfhyUGPCiygoFqkRVRw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.NativeFieldInfoPtr_keSsYQvXDfhyUGPCiygoFqkRVRw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.NativeFieldInfoPtr_keSsYQvXDfhyUGPCiygoFqkRVRw)) = value;
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x000C70C8 File Offset: 0x000C52C8
		// (set) Token: 0x06002753 RID: 10067 RVA: 0x0000F56C File Offset: 0x0000D76C
		public unsafe bool wYbaLhihfFlnmCnjhVQVlAoxhxsZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.NativeFieldInfoPtr_wYbaLhihfFlnmCnjhVQVlAoxhxsZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.NativeFieldInfoPtr_wYbaLhihfFlnmCnjhVQVlAoxhxsZ)) = value;
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06002754 RID: 10068 RVA: 0x000C70F0 File Offset: 0x000C52F0
		// (set) Token: 0x06002755 RID: 10069 RVA: 0x0000F587 File Offset: 0x0000D787
		public unsafe InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG yoFTkMYePDFsNyheNnXFccpYDXs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.NativeFieldInfoPtr_yoFTkMYePDFsNyheNnXFccpYDXs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.NativeFieldInfoPtr_yoFTkMYePDFsNyheNnXFccpYDXs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06002756 RID: 10070 RVA: 0x000C7120 File Offset: 0x000C5320
		// (set) Token: 0x06002757 RID: 10071 RVA: 0x0000F5A6 File Offset: 0x0000D7A6
		public unsafe InputMapper.Options pvnMWcEaMfdHVEzYZcFstMNcIJG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.NativeFieldInfoPtr_pvnMWcEaMfdHVEzYZcFstMNcIJG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputMapper.Options>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.NativeFieldInfoPtr_pvnMWcEaMfdHVEzYZcFstMNcIJG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x000C7150 File Offset: 0x000C5350
		// (set) Token: 0x06002759 RID: 10073 RVA: 0x0000F5C5 File Offset: 0x0000D7C5
		public unsafe Dictionary<InputMapper.xmzqWiCayBPBPSZAElrMgoEAVbw, SafeDelegate> EolqjSEMIQCAaMZnTpWhdUKpDqz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.NativeFieldInfoPtr_EolqjSEMIQCAaMZnTpWhdUKpDqz);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<InputMapper.xmzqWiCayBPBPSZAElrMgoEAVbw, SafeDelegate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.NativeFieldInfoPtr_EolqjSEMIQCAaMZnTpWhdUKpDqz), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x000C7180 File Offset: 0x000C5380
		// (set) Token: 0x0600275B RID: 10075 RVA: 0x0000F5E4 File Offset: 0x0000D7E4
		public unsafe static Action<Exception> TnjGfActQoYxORiAJMZFVLKvzSqq
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputMapper.NativeFieldInfoPtr_TnjGfActQoYxORiAJMZFVLKvzSqq, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Exception>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputMapper.NativeFieldInfoPtr_TnjGfActQoYxORiAJMZFVLKvzSqq, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x000C71A8 File Offset: 0x000C53A8
		// (set) Token: 0x0600275D RID: 10077 RVA: 0x0000F5F6 File Offset: 0x0000D7F6
		public unsafe static Action<Exception> pYmiUPJPTBSAxkoTMtgdkKSPgMk
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputMapper.NativeFieldInfoPtr_pYmiUPJPTBSAxkoTMtgdkKSPgMk, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Exception>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputMapper.NativeFieldInfoPtr_pYmiUPJPTBSAxkoTMtgdkKSPgMk, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x000C71D0 File Offset: 0x000C53D0
		// (set) Token: 0x0600275F RID: 10079 RVA: 0x0000F608 File Offset: 0x0000D808
		public unsafe static Action<Exception> KZJeKGmVCCwOmDauLwTHFXaElVW
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputMapper.NativeFieldInfoPtr_KZJeKGmVCCwOmDauLwTHFXaElVW, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Exception>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputMapper.NativeFieldInfoPtr_KZJeKGmVCCwOmDauLwTHFXaElVW, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x000C71F8 File Offset: 0x000C53F8
		// (set) Token: 0x06002761 RID: 10081 RVA: 0x0000F61A File Offset: 0x0000D81A
		public unsafe static Action<Exception> fLFpHVQnsuobZbdJnHTVVQDxIDpa
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputMapper.NativeFieldInfoPtr_fLFpHVQnsuobZbdJnHTVVQDxIDpa, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Exception>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputMapper.NativeFieldInfoPtr_fLFpHVQnsuobZbdJnHTVVQDxIDpa, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x000C7220 File Offset: 0x000C5420
		// (set) Token: 0x06002763 RID: 10083 RVA: 0x0000F62C File Offset: 0x0000D82C
		public unsafe static Action<Exception> LitcOpIIbGBsPjdzYsPCbcRHIKWZ
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputMapper.NativeFieldInfoPtr_LitcOpIIbGBsPjdzYsPCbcRHIKWZ, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Exception>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputMapper.NativeFieldInfoPtr_LitcOpIIbGBsPjdzYsPCbcRHIKWZ, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x000C7248 File Offset: 0x000C5448
		// (set) Token: 0x06002765 RID: 10085 RVA: 0x0000F63E File Offset: 0x0000D83E
		public unsafe static Action<Exception> gCuUadDmcMFLNzQinFNSXhAQJry
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputMapper.NativeFieldInfoPtr_gCuUadDmcMFLNzQinFNSXhAQJry, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Exception>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputMapper.NativeFieldInfoPtr_gCuUadDmcMFLNzQinFNSXhAQJry, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x000C7270 File Offset: 0x000C5470
		// (set) Token: 0x06002767 RID: 10087 RVA: 0x0000F650 File Offset: 0x0000D850
		public unsafe static Action<Exception> xTJJtXbkAMcFJChaqXiRwULMHGnC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputMapper.NativeFieldInfoPtr_xTJJtXbkAMcFJChaqXiRwULMHGnC, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Exception>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputMapper.NativeFieldInfoPtr_xTJJtXbkAMcFJChaqXiRwULMHGnC, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002017 RID: 8215
		private static readonly IntPtr NativeFieldInfoPtr_uosTDNMCuodpKVbExRdngcDMBdu;

		// Token: 0x04002018 RID: 8216
		private static readonly IntPtr NativeFieldInfoPtr_RjwmYEibkfiaAGiWNMLelFqDjlh;

		// Token: 0x04002019 RID: 8217
		private static readonly IntPtr NativeFieldInfoPtr_keSsYQvXDfhyUGPCiygoFqkRVRw;

		// Token: 0x0400201A RID: 8218
		private static readonly IntPtr NativeFieldInfoPtr_wYbaLhihfFlnmCnjhVQVlAoxhxsZ;

		// Token: 0x0400201B RID: 8219
		private static readonly IntPtr NativeFieldInfoPtr_yoFTkMYePDFsNyheNnXFccpYDXs;

		// Token: 0x0400201C RID: 8220
		private static readonly IntPtr NativeFieldInfoPtr_pvnMWcEaMfdHVEzYZcFstMNcIJG;

		// Token: 0x0400201D RID: 8221
		private static readonly IntPtr NativeFieldInfoPtr_EolqjSEMIQCAaMZnTpWhdUKpDqz;

		// Token: 0x0400201E RID: 8222
		private static readonly IntPtr NativeFieldInfoPtr_TnjGfActQoYxORiAJMZFVLKvzSqq;

		// Token: 0x0400201F RID: 8223
		private static readonly IntPtr NativeFieldInfoPtr_pYmiUPJPTBSAxkoTMtgdkKSPgMk;

		// Token: 0x04002020 RID: 8224
		private static readonly IntPtr NativeFieldInfoPtr_KZJeKGmVCCwOmDauLwTHFXaElVW;

		// Token: 0x04002021 RID: 8225
		private static readonly IntPtr NativeFieldInfoPtr_fLFpHVQnsuobZbdJnHTVVQDxIDpa;

		// Token: 0x04002022 RID: 8226
		private static readonly IntPtr NativeFieldInfoPtr_LitcOpIIbGBsPjdzYsPCbcRHIKWZ;

		// Token: 0x04002023 RID: 8227
		private static readonly IntPtr NativeFieldInfoPtr_gCuUadDmcMFLNzQinFNSXhAQJry;

		// Token: 0x04002024 RID: 8228
		private static readonly IntPtr NativeFieldInfoPtr_xTJJtXbkAMcFJChaqXiRwULMHGnC;

		// Token: 0x04002025 RID: 8229
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_InputMapper_0;

		// Token: 0x04002026 RID: 8230
		private static readonly IntPtr NativeMethodInfoPtr_NeUlzCfjqhEJeQoacnyKmAJEMsC_Private_Static_Int32_0;

		// Token: 0x04002027 RID: 8231
		private static readonly IntPtr NativeMethodInfoPtr_get_options_Public_get_Options_0;

		// Token: 0x04002028 RID: 8232
		private static readonly IntPtr NativeMethodInfoPtr_set_options_Public_set_Void_Options_0;

		// Token: 0x04002029 RID: 8233
		private static readonly IntPtr NativeMethodInfoPtr_get_mappingContext_Public_get_Context_0;

		// Token: 0x0400202A RID: 8234
		private static readonly IntPtr NativeMethodInfoPtr_get_status_Public_get_Status_0;

		// Token: 0x0400202B RID: 8235
		private static readonly IntPtr NativeMethodInfoPtr_get_timeRemaining_Public_get_Single_0;

		// Token: 0x0400202C RID: 8236
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Internal_get_Int32_0;

		// Token: 0x0400202D RID: 8237
		private static readonly IntPtr NativeMethodInfoPtr_add_InputMappedEvent_Public_add_Void_Action_1_InputMappedEventData_0;

		// Token: 0x0400202E RID: 8238
		private static readonly IntPtr NativeMethodInfoPtr_remove_InputMappedEvent_Public_rem_Void_Action_1_InputMappedEventData_0;

		// Token: 0x0400202F RID: 8239
		private static readonly IntPtr NativeMethodInfoPtr_add_ErrorEvent_Public_add_Void_Action_1_ErrorEventData_0;

		// Token: 0x04002030 RID: 8240
		private static readonly IntPtr NativeMethodInfoPtr_remove_ErrorEvent_Public_rem_Void_Action_1_ErrorEventData_0;

		// Token: 0x04002031 RID: 8241
		private static readonly IntPtr NativeMethodInfoPtr_add_CanceledEvent_Public_add_Void_Action_1_CanceledEventData_0;

		// Token: 0x04002032 RID: 8242
		private static readonly IntPtr NativeMethodInfoPtr_remove_CanceledEvent_Public_rem_Void_Action_1_CanceledEventData_0;

		// Token: 0x04002033 RID: 8243
		private static readonly IntPtr NativeMethodInfoPtr_add_TimedOutEvent_Public_add_Void_Action_1_TimedOutEventData_0;

		// Token: 0x04002034 RID: 8244
		private static readonly IntPtr NativeMethodInfoPtr_remove_TimedOutEvent_Public_rem_Void_Action_1_TimedOutEventData_0;

		// Token: 0x04002035 RID: 8245
		private static readonly IntPtr NativeMethodInfoPtr_add_StartedEvent_Public_add_Void_Action_1_StartedEventData_0;

		// Token: 0x04002036 RID: 8246
		private static readonly IntPtr NativeMethodInfoPtr_remove_StartedEvent_Public_rem_Void_Action_1_StartedEventData_0;

		// Token: 0x04002037 RID: 8247
		private static readonly IntPtr NativeMethodInfoPtr_add_StoppedEvent_Public_add_Void_Action_1_StoppedEventData_0;

		// Token: 0x04002038 RID: 8248
		private static readonly IntPtr NativeMethodInfoPtr_remove_StoppedEvent_Public_rem_Void_Action_1_StoppedEventData_0;

		// Token: 0x04002039 RID: 8249
		private static readonly IntPtr NativeMethodInfoPtr_add_ConflictFoundEvent_Public_add_Void_Action_1_ConflictFoundEventData_0;

		// Token: 0x0400203A RID: 8250
		private static readonly IntPtr NativeMethodInfoPtr_remove_ConflictFoundEvent_Public_rem_Void_Action_1_ConflictFoundEventData_0;

		// Token: 0x0400203B RID: 8251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400203C RID: 8252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x0400203D RID: 8253
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEventListeners_Public_Void_Object_0;

		// Token: 0x0400203E RID: 8254
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAllEventListeners_Public_Void_0;

		// Token: 0x0400203F RID: 8255
		private static readonly IntPtr NativeMethodInfoPtr_GjrownYLLiHMbVoBqflPDINetZA_Internal_Void_Object_0;

		// Token: 0x04002040 RID: 8256
		private static readonly IntPtr NativeMethodInfoPtr_sXEMNEyAzEzUEcjDLpsZpLDuuxP_Internal_Void_0;

		// Token: 0x04002041 RID: 8257
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Boolean_Context_0;

		// Token: 0x04002042 RID: 8258
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04002043 RID: 8259
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002044 RID: 8260
		private static readonly IntPtr NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Private_Boolean_Context_Options_0;

		// Token: 0x04002045 RID: 8261
		private static readonly IntPtr NativeMethodInfoPtr_OUjQkTqHdKDKTdWxkgBYSsdbWWhi_Private_Static_Void_Exception_0;

		// Token: 0x04002046 RID: 8262
		private static readonly IntPtr NativeMethodInfoPtr_lCXemqrZsgUhCfTWmorHVGADRQm_Private_Static_Void_Exception_0;

		// Token: 0x04002047 RID: 8263
		private static readonly IntPtr NativeMethodInfoPtr_IrnxTVxqPjcTGlzgoFIbvuyffjY_Private_Static_Void_Exception_0;

		// Token: 0x04002048 RID: 8264
		private static readonly IntPtr NativeMethodInfoPtr_zDobrlnHmPfIKQeOlUwOinjlkbw_Private_Static_Void_Exception_0;

		// Token: 0x04002049 RID: 8265
		private static readonly IntPtr NativeMethodInfoPtr_FzEzswJkzejQdRpUhiufKOIkIkI_Private_Static_Void_Exception_0;

		// Token: 0x0400204A RID: 8266
		private static readonly IntPtr NativeMethodInfoPtr_ZuqHJGGoTNCgnGBaVSljlbPfkoqz_Private_Static_Void_Exception_0;

		// Token: 0x0400204B RID: 8267
		private static readonly IntPtr NativeMethodInfoPtr_DxbUuxuADcBTMJfmaXdaZItXTmN_Private_Static_Void_Exception_0;

		// Token: 0x0200037C RID: 892
		public class Context : Object
		{
			// Token: 0x060049E3 RID: 18915 RVA: 0x0015296C File Offset: 0x00150B6C
			// Note: this type is marked as 'beforefieldinit'.
			static Context()
			{
				Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "Context");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr);
				InputMapper.Context.NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, "HSNQHCcXgyznRFxfZdJonabrHRG");
				InputMapper.Context.NativeFieldInfoPtr_wQXdFKgaEVDIjgjfyWReFTcBhsTt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, "wQXdFKgaEVDIjgjfyWReFTcBhsTt");
				InputMapper.Context.NativeFieldInfoPtr_LDFHfWEfteRTINCbhXDPuGWlFrsr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, "LDFHfWEfteRTINCbhXDPuGWlFrsr");
				InputMapper.Context.NativeFieldInfoPtr_tDcSDkeHPPCfwfiDwsyGlaUhOOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, "tDcSDkeHPPCfwfiDwsyGlaUhOOn");
				InputMapper.Context.NativeFieldInfoPtr_HaBpMivpFGWfqAaGrZNSCbNTtAj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, "HaBpMivpFGWfqAaGrZNSCbNTtAj");
				InputMapper.Context.NativeMethodInfoPtr_get_actionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, 100671732);
				InputMapper.Context.NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, 100671733);
				InputMapper.Context.NativeMethodInfoPtr_get_actionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, 100671734);
				InputMapper.Context.NativeMethodInfoPtr_set_actionName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, 100671735);
				InputMapper.Context.NativeMethodInfoPtr_get_controllerMap_Public_get_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, 100671736);
				InputMapper.Context.NativeMethodInfoPtr_set_controllerMap_Public_set_Void_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, 100671737);
				InputMapper.Context.NativeMethodInfoPtr_get_actionElementMapToReplace_Public_get_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, 100671738);
				InputMapper.Context.NativeMethodInfoPtr_set_actionElementMapToReplace_Public_set_Void_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, 100671739);
				InputMapper.Context.NativeMethodInfoPtr_get_actionRange_Public_get_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, 100671740);
				InputMapper.Context.NativeMethodInfoPtr_set_actionRange_Public_set_Void_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, 100671741);
				InputMapper.Context.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, 100671742);
				InputMapper.Context.NativeMethodInfoPtr__ctor_Private_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, 100671743);
				InputMapper.Context.NativeMethodInfoPtr_Clone_Public_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, 100671744);
				InputMapper.Context.NativeMethodInfoPtr_CGpKSujxwsfBkjBIMXlCAzjipXg_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, 100671745);
				InputMapper.Context.NativeMethodInfoPtr_RAKumnNEYqctUAkbZwHVaYvnWpja_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, 100671746);
				InputMapper.Context.NativeMethodInfoPtr_Copy_Public_Static_Void_Context_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr, 100671747);
			}

			// Token: 0x1700172F RID: 5935
			// (get) Token: 0x060049E4 RID: 18916 RVA: 0x00152B3C File Offset: 0x00150D3C
			// (set) Token: 0x060049E5 RID: 18917 RVA: 0x00152B78 File Offset: 0x00150D78
			public unsafe int actionId
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Context.NativeMethodInfoPtr_get_actionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295101, XrefRangeEnd = 295104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Context.NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001730 RID: 5936
			// (get) Token: 0x060049E6 RID: 18918 RVA: 0x00152BB8 File Offset: 0x00150DB8
			// (set) Token: 0x060049E7 RID: 18919 RVA: 0x00152BF0 File Offset: 0x00150DF0
			public unsafe string actionName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295104, XrefRangeEnd = 295110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Context.NativeMethodInfoPtr_get_actionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295110, XrefRangeEnd = 295120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Context.NativeMethodInfoPtr_set_actionName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001731 RID: 5937
			// (get) Token: 0x060049E8 RID: 18920 RVA: 0x00152C34 File Offset: 0x00150E34
			// (set) Token: 0x060049E9 RID: 18921 RVA: 0x00152C74 File Offset: 0x00150E74
			public unsafe ControllerMap controllerMap
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Context.NativeMethodInfoPtr_get_controllerMap_Public_get_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 295123, RefRangeEnd = 295125, XrefRangeStart = 295120, XrefRangeEnd = 295123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Context.NativeMethodInfoPtr_set_controllerMap_Public_set_Void_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001732 RID: 5938
			// (get) Token: 0x060049EA RID: 18922 RVA: 0x00152CB8 File Offset: 0x00150EB8
			// (set) Token: 0x060049EB RID: 18923 RVA: 0x00152CF8 File Offset: 0x00150EF8
			public unsafe ActionElementMap actionElementMapToReplace
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Context.NativeMethodInfoPtr_get_actionElementMapToReplace_Public_get_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 295128, RefRangeEnd = 295129, XrefRangeStart = 295125, XrefRangeEnd = 295128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Context.NativeMethodInfoPtr_set_actionElementMapToReplace_Public_set_Void_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001733 RID: 5939
			// (get) Token: 0x060049EC RID: 18924 RVA: 0x00152D3C File Offset: 0x00150F3C
			// (set) Token: 0x060049ED RID: 18925 RVA: 0x00152D78 File Offset: 0x00150F78
			public unsafe AxisRange actionRange
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Context.NativeMethodInfoPtr_get_actionRange_Public_get_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295129, XrefRangeEnd = 295132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Context.NativeMethodInfoPtr_set_actionRange_Public_set_Void_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060049EE RID: 18926 RVA: 0x00152DB8 File Offset: 0x00150FB8
			[CallerCount(0)]
			public unsafe Context()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Context.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049EF RID: 18927 RVA: 0x00152DF4 File Offset: 0x00150FF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295132, XrefRangeEnd = 295134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Context(InputMapper.Context source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapper.Context>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Context.NativeMethodInfoPtr__ctor_Private_Void_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060049F0 RID: 18928 RVA: 0x00152E40 File Offset: 0x00151040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295134, XrefRangeEnd = 295139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputMapper.Context Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Context.NativeMethodInfoPtr_Clone_Public_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputMapper.Context>(intPtr3) : null;
			}

			// Token: 0x060049F1 RID: 18929 RVA: 0x00152E80 File Offset: 0x00151080
			[CallerCount(0)]
			public unsafe void CGpKSujxwsfBkjBIMXlCAzjipXg()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Context.NativeMethodInfoPtr_CGpKSujxwsfBkjBIMXlCAzjipXg_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049F2 RID: 18930 RVA: 0x00152EB4 File Offset: 0x001510B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295139, XrefRangeEnd = 295140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool RAKumnNEYqctUAkbZwHVaYvnWpja()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Context.NativeMethodInfoPtr_RAKumnNEYqctUAkbZwHVaYvnWpja_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060049F3 RID: 18931 RVA: 0x00152EF0 File Offset: 0x001510F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295140, XrefRangeEnd = 295142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Copy(InputMapper.Context source, InputMapper.Context destination)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Context.NativeMethodInfoPtr_Copy_Public_Static_Void_Context_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049F4 RID: 18932 RVA: 0x0001B2A6 File Offset: 0x000194A6
			public Context(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700172A RID: 5930
			// (get) Token: 0x060049F5 RID: 18933 RVA: 0x00152F38 File Offset: 0x00151138
			// (set) Token: 0x060049F6 RID: 18934 RVA: 0x0001B2AF File Offset: 0x000194AF
			public unsafe int HSNQHCcXgyznRFxfZdJonabrHRG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Context.NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Context.NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG)) = value;
				}
			}

			// Token: 0x1700172B RID: 5931
			// (get) Token: 0x060049F7 RID: 18935 RVA: 0x00152F60 File Offset: 0x00151160
			// (set) Token: 0x060049F8 RID: 18936 RVA: 0x0001B2CA File Offset: 0x000194CA
			public unsafe ControllerMap wQXdFKgaEVDIjgjfyWReFTcBhsTt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Context.NativeFieldInfoPtr_wQXdFKgaEVDIjgjfyWReFTcBhsTt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Context.NativeFieldInfoPtr_wQXdFKgaEVDIjgjfyWReFTcBhsTt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700172C RID: 5932
			// (get) Token: 0x060049F9 RID: 18937 RVA: 0x00152F90 File Offset: 0x00151190
			// (set) Token: 0x060049FA RID: 18938 RVA: 0x0001B2E9 File Offset: 0x000194E9
			public unsafe ActionElementMap LDFHfWEfteRTINCbhXDPuGWlFrsr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Context.NativeFieldInfoPtr_LDFHfWEfteRTINCbhXDPuGWlFrsr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Context.NativeFieldInfoPtr_LDFHfWEfteRTINCbhXDPuGWlFrsr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700172D RID: 5933
			// (get) Token: 0x060049FB RID: 18939 RVA: 0x00152FC0 File Offset: 0x001511C0
			// (set) Token: 0x060049FC RID: 18940 RVA: 0x0001B308 File Offset: 0x00019508
			public unsafe AxisRange tDcSDkeHPPCfwfiDwsyGlaUhOOn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Context.NativeFieldInfoPtr_tDcSDkeHPPCfwfiDwsyGlaUhOOn);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Context.NativeFieldInfoPtr_tDcSDkeHPPCfwfiDwsyGlaUhOOn)) = value;
				}
			}

			// Token: 0x1700172E RID: 5934
			// (get) Token: 0x060049FD RID: 18941 RVA: 0x00152FE8 File Offset: 0x001511E8
			// (set) Token: 0x060049FE RID: 18942 RVA: 0x0001B323 File Offset: 0x00019523
			public unsafe bool HaBpMivpFGWfqAaGrZNSCbNTtAj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Context.NativeFieldInfoPtr_HaBpMivpFGWfqAaGrZNSCbNTtAj);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Context.NativeFieldInfoPtr_HaBpMivpFGWfqAaGrZNSCbNTtAj)) = value;
				}
			}

			// Token: 0x04003BCE RID: 15310
			private static readonly IntPtr NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG;

			// Token: 0x04003BCF RID: 15311
			private static readonly IntPtr NativeFieldInfoPtr_wQXdFKgaEVDIjgjfyWReFTcBhsTt;

			// Token: 0x04003BD0 RID: 15312
			private static readonly IntPtr NativeFieldInfoPtr_LDFHfWEfteRTINCbhXDPuGWlFrsr;

			// Token: 0x04003BD1 RID: 15313
			private static readonly IntPtr NativeFieldInfoPtr_tDcSDkeHPPCfwfiDwsyGlaUhOOn;

			// Token: 0x04003BD2 RID: 15314
			private static readonly IntPtr NativeFieldInfoPtr_HaBpMivpFGWfqAaGrZNSCbNTtAj;

			// Token: 0x04003BD3 RID: 15315
			private static readonly IntPtr NativeMethodInfoPtr_get_actionId_Public_get_Int32_0;

			// Token: 0x04003BD4 RID: 15316
			private static readonly IntPtr NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0;

			// Token: 0x04003BD5 RID: 15317
			private static readonly IntPtr NativeMethodInfoPtr_get_actionName_Public_get_String_0;

			// Token: 0x04003BD6 RID: 15318
			private static readonly IntPtr NativeMethodInfoPtr_set_actionName_Public_set_Void_String_0;

			// Token: 0x04003BD7 RID: 15319
			private static readonly IntPtr NativeMethodInfoPtr_get_controllerMap_Public_get_ControllerMap_0;

			// Token: 0x04003BD8 RID: 15320
			private static readonly IntPtr NativeMethodInfoPtr_set_controllerMap_Public_set_Void_ControllerMap_0;

			// Token: 0x04003BD9 RID: 15321
			private static readonly IntPtr NativeMethodInfoPtr_get_actionElementMapToReplace_Public_get_ActionElementMap_0;

			// Token: 0x04003BDA RID: 15322
			private static readonly IntPtr NativeMethodInfoPtr_set_actionElementMapToReplace_Public_set_Void_ActionElementMap_0;

			// Token: 0x04003BDB RID: 15323
			private static readonly IntPtr NativeMethodInfoPtr_get_actionRange_Public_get_AxisRange_0;

			// Token: 0x04003BDC RID: 15324
			private static readonly IntPtr NativeMethodInfoPtr_set_actionRange_Public_set_Void_AxisRange_0;

			// Token: 0x04003BDD RID: 15325
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BDE RID: 15326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Context_0;

			// Token: 0x04003BDF RID: 15327
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Context_0;

			// Token: 0x04003BE0 RID: 15328
			private static readonly IntPtr NativeMethodInfoPtr_CGpKSujxwsfBkjBIMXlCAzjipXg_Internal_Void_0;

			// Token: 0x04003BE1 RID: 15329
			private static readonly IntPtr NativeMethodInfoPtr_RAKumnNEYqctUAkbZwHVaYvnWpja_Private_Boolean_0;

			// Token: 0x04003BE2 RID: 15330
			private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Context_Context_0;
		}

		// Token: 0x0200037D RID: 893
		[OriginalName("Rewired_Core.dll", "", "ConflictResponse")]
		public enum ConflictResponse
		{
			// Token: 0x04003BE4 RID: 15332
			Cancel,
			// Token: 0x04003BE5 RID: 15333
			Replace,
			// Token: 0x04003BE6 RID: 15334
			Add,
			// Token: 0x04003BE7 RID: 15335
			Ignore
		}

		// Token: 0x0200037E RID: 894
		public class EventData : Object
		{
			// Token: 0x060049FF RID: 18943 RVA: 0x00153010 File Offset: 0x00151210
			// Note: this type is marked as 'beforefieldinit'.
			static EventData()
			{
				Il2CppClassPointerStore<InputMapper.EventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "EventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMapper.EventData>.NativeClassPtr);
				InputMapper.EventData.NativeFieldInfoPtr_inputMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.EventData>.NativeClassPtr, "inputMapper");
				InputMapper.EventData.NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.EventData>.NativeClassPtr, 100671748);
			}

			// Token: 0x06004A00 RID: 18944 RVA: 0x00153064 File Offset: 0x00151264
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventData(InputMapper inputMapper)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapper.EventData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputMapper);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.EventData.NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A01 RID: 18945 RVA: 0x0001B33E File Offset: 0x0001953E
			public EventData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001734 RID: 5940
			// (get) Token: 0x06004A02 RID: 18946 RVA: 0x001530B0 File Offset: 0x001512B0
			// (set) Token: 0x06004A03 RID: 18947 RVA: 0x0001B347 File Offset: 0x00019547
			public unsafe InputMapper inputMapper
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.EventData.NativeFieldInfoPtr_inputMapper);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputMapper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.EventData.NativeFieldInfoPtr_inputMapper), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BE8 RID: 15336
			private static readonly IntPtr NativeFieldInfoPtr_inputMapper;

			// Token: 0x04003BE9 RID: 15337
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_0;
		}

		// Token: 0x0200037F RID: 895
		public class InputMappedEventData : InputMapper.EventData
		{
			// Token: 0x06004A04 RID: 18948 RVA: 0x001530E0 File Offset: 0x001512E0
			// Note: this type is marked as 'beforefieldinit'.
			static InputMappedEventData()
			{
				Il2CppClassPointerStore<InputMapper.InputMappedEventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "InputMappedEventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMapper.InputMappedEventData>.NativeClassPtr);
				InputMapper.InputMappedEventData.NativeFieldInfoPtr_actionElementMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.InputMappedEventData>.NativeClassPtr, "actionElementMap");
				InputMapper.InputMappedEventData.NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.InputMappedEventData>.NativeClassPtr, 100671749);
			}

			// Token: 0x06004A05 RID: 18949 RVA: 0x00153134 File Offset: 0x00151334
			[CallerCount(76)]
			[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputMappedEventData(InputMapper mapper, ActionElementMap actionElementMap)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapper.InputMappedEventData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mapper);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionElementMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.InputMappedEventData.NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A06 RID: 18950 RVA: 0x0001B366 File Offset: 0x00019566
			public InputMappedEventData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001735 RID: 5941
			// (get) Token: 0x06004A07 RID: 18951 RVA: 0x00153194 File Offset: 0x00151394
			// (set) Token: 0x06004A08 RID: 18952 RVA: 0x0001B36F File Offset: 0x0001956F
			public unsafe ActionElementMap actionElementMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.InputMappedEventData.NativeFieldInfoPtr_actionElementMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.InputMappedEventData.NativeFieldInfoPtr_actionElementMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BEA RID: 15338
			private static readonly IntPtr NativeFieldInfoPtr_actionElementMap;

			// Token: 0x04003BEB RID: 15339
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_ActionElementMap_0;
		}

		// Token: 0x02000380 RID: 896
		public class CanceledEventData : InputMapper.EventData
		{
			// Token: 0x06004A09 RID: 18953 RVA: 0x001531C4 File Offset: 0x001513C4
			// Note: this type is marked as 'beforefieldinit'.
			static CanceledEventData()
			{
				Il2CppClassPointerStore<InputMapper.CanceledEventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "CanceledEventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMapper.CanceledEventData>.NativeClassPtr);
				InputMapper.CanceledEventData.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.CanceledEventData>.NativeClassPtr, "message");
				InputMapper.CanceledEventData.NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.CanceledEventData>.NativeClassPtr, 100671750);
			}

			// Token: 0x06004A0A RID: 18954 RVA: 0x00153218 File Offset: 0x00151418
			[CallerCount(76)]
			[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CanceledEventData(InputMapper mapper, string message)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapper.CanceledEventData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mapper);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.CanceledEventData.NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A0B RID: 18955 RVA: 0x0001B38E File Offset: 0x0001958E
			public CanceledEventData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001736 RID: 5942
			// (get) Token: 0x06004A0C RID: 18956 RVA: 0x00153278 File Offset: 0x00151478
			// (set) Token: 0x06004A0D RID: 18957 RVA: 0x0001B397 File Offset: 0x00019597
			public unsafe string message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.CanceledEventData.NativeFieldInfoPtr_message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.CanceledEventData.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003BEC RID: 15340
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04003BED RID: 15341
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_String_0;
		}

		// Token: 0x02000381 RID: 897
		public class ErrorEventData : InputMapper.EventData
		{
			// Token: 0x06004A0E RID: 18958 RVA: 0x001532A0 File Offset: 0x001514A0
			// Note: this type is marked as 'beforefieldinit'.
			static ErrorEventData()
			{
				Il2CppClassPointerStore<InputMapper.ErrorEventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "ErrorEventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMapper.ErrorEventData>.NativeClassPtr);
				InputMapper.ErrorEventData.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.ErrorEventData>.NativeClassPtr, "message");
				InputMapper.ErrorEventData.NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.ErrorEventData>.NativeClassPtr, 100671751);
			}

			// Token: 0x06004A0F RID: 18959 RVA: 0x001532F4 File Offset: 0x001514F4
			[CallerCount(76)]
			[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorEventData(InputMapper mapper, string message)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapper.ErrorEventData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mapper);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.ErrorEventData.NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A10 RID: 18960 RVA: 0x0001B3B6 File Offset: 0x000195B6
			public ErrorEventData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001737 RID: 5943
			// (get) Token: 0x06004A11 RID: 18961 RVA: 0x00153354 File Offset: 0x00151554
			// (set) Token: 0x06004A12 RID: 18962 RVA: 0x0001B3BF File Offset: 0x000195BF
			public unsafe string message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.ErrorEventData.NativeFieldInfoPtr_message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.ErrorEventData.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003BEE RID: 15342
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04003BEF RID: 15343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_String_0;
		}

		// Token: 0x02000382 RID: 898
		public class TimedOutEventData : InputMapper.EventData
		{
			// Token: 0x06004A13 RID: 18963 RVA: 0x0001B3DE File Offset: 0x000195DE
			// Note: this type is marked as 'beforefieldinit'.
			static TimedOutEventData()
			{
				Il2CppClassPointerStore<InputMapper.TimedOutEventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "TimedOutEventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMapper.TimedOutEventData>.NativeClassPtr);
				InputMapper.TimedOutEventData.NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.TimedOutEventData>.NativeClassPtr, 100671752);
			}

			// Token: 0x06004A14 RID: 18964 RVA: 0x0015337C File Offset: 0x0015157C
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimedOutEventData(InputMapper mapper)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapper.TimedOutEventData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mapper);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.TimedOutEventData.NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A15 RID: 18965 RVA: 0x0001B412 File Offset: 0x00019612
			public TimedOutEventData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003BF0 RID: 15344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_0;
		}

		// Token: 0x02000383 RID: 899
		public class StartedEventData : InputMapper.EventData
		{
			// Token: 0x06004A16 RID: 18966 RVA: 0x0001B41B File Offset: 0x0001961B
			// Note: this type is marked as 'beforefieldinit'.
			static StartedEventData()
			{
				Il2CppClassPointerStore<InputMapper.StartedEventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "StartedEventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMapper.StartedEventData>.NativeClassPtr);
				InputMapper.StartedEventData.NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.StartedEventData>.NativeClassPtr, 100671753);
			}

			// Token: 0x06004A17 RID: 18967 RVA: 0x001533C8 File Offset: 0x001515C8
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StartedEventData(InputMapper mapper)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapper.StartedEventData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mapper);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.StartedEventData.NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A18 RID: 18968 RVA: 0x0001B44F File Offset: 0x0001964F
			public StartedEventData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003BF1 RID: 15345
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_0;
		}

		// Token: 0x02000384 RID: 900
		public class StoppedEventData : InputMapper.EventData
		{
			// Token: 0x06004A19 RID: 18969 RVA: 0x0001B458 File Offset: 0x00019658
			// Note: this type is marked as 'beforefieldinit'.
			static StoppedEventData()
			{
				Il2CppClassPointerStore<InputMapper.StoppedEventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "StoppedEventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMapper.StoppedEventData>.NativeClassPtr);
				InputMapper.StoppedEventData.NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.StoppedEventData>.NativeClassPtr, 100671754);
			}

			// Token: 0x06004A1A RID: 18970 RVA: 0x00153414 File Offset: 0x00151614
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StoppedEventData(InputMapper mapper)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapper.StoppedEventData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mapper);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.StoppedEventData.NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A1B RID: 18971 RVA: 0x0001B48C File Offset: 0x0001968C
			public StoppedEventData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003BF2 RID: 15346
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_0;
		}

		// Token: 0x02000385 RID: 901
		public class ConflictFoundEventData : InputMapper.EventData
		{
			// Token: 0x06004A1C RID: 18972 RVA: 0x00153460 File Offset: 0x00151660
			// Note: this type is marked as 'beforefieldinit'.
			static ConflictFoundEventData()
			{
				Il2CppClassPointerStore<InputMapper.ConflictFoundEventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "ConflictFoundEventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMapper.ConflictFoundEventData>.NativeClassPtr);
				InputMapper.ConflictFoundEventData.NativeFieldInfoPtr_responseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.ConflictFoundEventData>.NativeClassPtr, "responseCallback");
				InputMapper.ConflictFoundEventData.NativeFieldInfoPtr_assignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.ConflictFoundEventData>.NativeClassPtr, "assignment");
				InputMapper.ConflictFoundEventData.NativeFieldInfoPtr_conflicts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.ConflictFoundEventData>.NativeClassPtr, "conflicts");
				InputMapper.ConflictFoundEventData.NativeFieldInfoPtr_isProtected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.ConflictFoundEventData>.NativeClassPtr, "isProtected");
				InputMapper.ConflictFoundEventData.NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_Action_1_ConflictResponse_ElementAssignmentInfo_IList_1_ElementAssignmentConflictInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.ConflictFoundEventData>.NativeClassPtr, 100671755);
			}

			// Token: 0x06004A1D RID: 18973 RVA: 0x001534F0 File Offset: 0x001516F0
			[CallerCount(0)]
			public unsafe ConflictFoundEventData(InputMapper mapper, Action<InputMapper.ConflictResponse> responseCallback, ElementAssignmentInfo assignment, IList<ElementAssignmentConflictInfo> conflicts, bool isProtected)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapper.ConflictFoundEventData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mapper);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseCallback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assignment);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conflicts);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isProtected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.ConflictFoundEventData.NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_Action_1_ConflictResponse_ElementAssignmentInfo_IList_1_ElementAssignmentConflictInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A1E RID: 18974 RVA: 0x0001B495 File Offset: 0x00019695
			public ConflictFoundEventData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001738 RID: 5944
			// (get) Token: 0x06004A1F RID: 18975 RVA: 0x00153580 File Offset: 0x00151780
			// (set) Token: 0x06004A20 RID: 18976 RVA: 0x0001B49E File Offset: 0x0001969E
			public unsafe Action<InputMapper.ConflictResponse> responseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.ConflictFoundEventData.NativeFieldInfoPtr_responseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputMapper.ConflictResponse>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.ConflictFoundEventData.NativeFieldInfoPtr_responseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001739 RID: 5945
			// (get) Token: 0x06004A21 RID: 18977 RVA: 0x001535B0 File Offset: 0x001517B0
			// (set) Token: 0x06004A22 RID: 18978 RVA: 0x0001B4BD File Offset: 0x000196BD
			public unsafe ElementAssignmentInfo assignment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.ConflictFoundEventData.NativeFieldInfoPtr_assignment);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ElementAssignmentInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.ConflictFoundEventData.NativeFieldInfoPtr_assignment), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700173A RID: 5946
			// (get) Token: 0x06004A23 RID: 18979 RVA: 0x001535E0 File Offset: 0x001517E0
			// (set) Token: 0x06004A24 RID: 18980 RVA: 0x0001B4DC File Offset: 0x000196DC
			public unsafe IList<ElementAssignmentConflictInfo> conflicts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.ConflictFoundEventData.NativeFieldInfoPtr_conflicts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ElementAssignmentConflictInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.ConflictFoundEventData.NativeFieldInfoPtr_conflicts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700173B RID: 5947
			// (get) Token: 0x06004A25 RID: 18981 RVA: 0x00153610 File Offset: 0x00151810
			// (set) Token: 0x06004A26 RID: 18982 RVA: 0x0001B4FB File Offset: 0x000196FB
			public unsafe bool isProtected
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.ConflictFoundEventData.NativeFieldInfoPtr_isProtected);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.ConflictFoundEventData.NativeFieldInfoPtr_isProtected)) = value;
				}
			}

			// Token: 0x04003BF3 RID: 15347
			private static readonly IntPtr NativeFieldInfoPtr_responseCallback;

			// Token: 0x04003BF4 RID: 15348
			private static readonly IntPtr NativeFieldInfoPtr_assignment;

			// Token: 0x04003BF5 RID: 15349
			private static readonly IntPtr NativeFieldInfoPtr_conflicts;

			// Token: 0x04003BF6 RID: 15350
			private static readonly IntPtr NativeFieldInfoPtr_isProtected;

			// Token: 0x04003BF7 RID: 15351
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InputMapper_Action_1_ConflictResponse_ElementAssignmentInfo_IList_1_ElementAssignmentConflictInfo_Boolean_0;
		}

		// Token: 0x02000386 RID: 902
		[OriginalName("Rewired_Core.dll", "", "xmzqWiCayBPBPSZAElrMgoEAVbw")]
		public enum xmzqWiCayBPBPSZAElrMgoEAVbw
		{
			// Token: 0x04003BF9 RID: 15353
			jAuwmMFaPHHmsOVpdzKkJGHpvOz,
			// Token: 0x04003BFA RID: 15354
			ichYuhKAMOKZuOYdULWGKyNWwBv,
			// Token: 0x04003BFB RID: 15355
			JNyeEvIYXIZyNhyarqciwNpHSdB,
			// Token: 0x04003BFC RID: 15356
			svjyQznZlJOtdiMyQtWTuyTiZMb,
			// Token: 0x04003BFD RID: 15357
			tqXDTjcpQDxMwWYaQEAMCtmcfMAk,
			// Token: 0x04003BFE RID: 15358
			dmARZjYACFNyCBdZIckFYCSONZu,
			// Token: 0x04003BFF RID: 15359
			wCRHgVJnqvgcyCokgoJNbgYaDGAb
		}

		// Token: 0x02000387 RID: 903
		[OriginalName("Rewired_Core.dll", "", "Status")]
		public enum Status
		{
			// Token: 0x04003C01 RID: 15361
			Idle,
			// Token: 0x04003C02 RID: 15362
			Listening,
			// Token: 0x04003C03 RID: 15363
			AwaitingResponse
		}

		// Token: 0x02000388 RID: 904
		public class SztVohOGHJfxAZjDLxgsTkhJblNG : Object
		{
			// Token: 0x06004A27 RID: 18983 RVA: 0x00153638 File Offset: 0x00151838
			// Note: this type is marked as 'beforefieldinit'.
			static SztVohOGHJfxAZjDLxgsTkhJblNG()
			{
				Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "SztVohOGHJfxAZjDLxgsTkhJblNG");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_mcZTbbPGwEArYoSxgzyGmeIyAph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, "mcZTbbPGwEArYoSxgzyGmeIyAph");
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_pvnMWcEaMfdHVEzYZcFstMNcIJG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, "pvnMWcEaMfdHVEzYZcFstMNcIJG");
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_XXscCHUbSqdTovHfIhOXcsPtLFr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, "XXscCHUbSqdTovHfIhOXcsPtLFr");
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_EolqjSEMIQCAaMZnTpWhdUKpDqz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, "EolqjSEMIQCAaMZnTpWhdUKpDqz");
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_ECMOFvQBpoMhjGrdgIWKnWiXLNu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, "ECMOFvQBpoMhjGrdgIWKnWiXLNu");
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_LgdhFLgMLSZicoxRjNYWTzwzbfj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, "LgdhFLgMLSZicoxRjNYWTzwzbfj");
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_mYPXeoLEDGJgDwFpaudrlblnFiw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, "mYPXeoLEDGJgDwFpaudrlblnFiw");
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_IazdtdlCeOAEwAIlzilallbRIbQd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, "IazdtdlCeOAEwAIlzilallbRIbQd");
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_wmkwYqTtitbgejxslljmJKBXwbC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, "wmkwYqTtitbgejxslljmJKBXwbC");
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_sfOIDrDDBcEkSLSASeMMnBKBMgxb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, "sfOIDrDDBcEkSLSASeMMnBKBMgxb");
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_NhLRctHeQDSZgIwFPrWStggAjuE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, "NhLRctHeQDSZgIwFPrWStggAjuE");
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_uXObMWEjPDjeZqdpYebKKFJYOxAS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, "uXObMWEjPDjeZqdpYebKKFJYOxAS");
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_get_status_Public_get_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671756);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_get_timeRemaining_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671757);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_get_context_Public_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671758);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_get_checkTimer_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671759);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr__ctor_Public_Void_InputMapper_Dictionary_2_xmzqWiCayBPBPSZAElrMgoEAVbw_SafeDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671760);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671761);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_Context_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671762);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_qibHnlMggWjYezyQPBTsFQbHenW_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671763);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Private_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671764);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_zfahqYjiIdfMojMAGLXbLAnHRnwb_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671765);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_xpmuwdDURcmUoRIBDfSyCTDoRXaE_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671766);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_KCYldVZEgBvfhkvNFJCAuFNdcTs_Private_DiMkgKJkwQFMXOdcXGrJiabFPThh_byref_ElementAssignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671767);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_QqUvMUZSpEwhsUKEoHaHFpBhrwF_Private_Boolean_byref_IEnumerable_1_ControllerPollingInfo_byref_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671768);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_NjdpwsiZSdIYYzuMJRHCEbdYPmT_Private_IEnumerable_1_ControllerPollingInfo_byref_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671769);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_ltTKeiwjYiChflpDLkJqhGENlch_Private_ControllerPollingInfo_Options_byref_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671770);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_ltTKeiwjYiChflpDLkJqhGENlch_Private_Static_ControllerPollingInfo_Options_byref_Boolean_byref_ModifierKeyFlags_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671771);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_ovScvQGaZcBwQcNwaXhqFQhNCNjw_Private_Static_Boolean_ControllerPollingInfo_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671772);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_dlZNiCHXmIRDBQitWUTkmOIEdCC_Private_Static_Boolean_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ControllerPollingInfo_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671773);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_PjyTZlBrcDmVhlddxmweENkwrQK_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671774);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_NvyPkGOMLGfjRquqyArWdYGUplF_Private_DiMkgKJkwQFMXOdcXGrJiabFPThh_ElementAssignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671775);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_znsDidAYIixVXDLAvLHuPZSbQqnm_Private_Static_Boolean_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ElementAssignment_List_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671776);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_XpkDENiZdHeccPVzUpKDpojLqzB_Private_Static_Boolean_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ElementAssignment_List_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671777);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_oDydEkEJVwiAVYbLVxonWywrxun_Private_Static_IList_1_ElementAssignmentConflictInfo_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ElementAssignment_List_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671778);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_RzxBkvaLhbMFrGyZhLWijPMpjHUE_Private_Static_Boolean_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ElementAssignment_byref_ElementAssignmentConflictCheck_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671779);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_tUqKHYfNDLwvZrdXyKOoakHZfjs_Private_Static_Void_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ElementAssignment_List_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671780);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_xCcCNACARHflUYpupTiRSkUKMrz_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671781);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_VgWLSYBznTpZfwcVSJkoHUZURq_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671782);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_oomjtJJdkbwxFiesscNnfgqgnCv_Private_Boolean_xmzqWiCayBPBPSZAElrMgoEAVbw_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671783);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_TOsmIyUnDbrAkvGgiejZqZWsQla_Private_Void_xmzqWiCayBPBPSZAElrMgoEAVbw_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671784);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_atMVYiecIRUdSeAYeaBVyuauztd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671785);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_wEBajoimHsuJMiqKMNrJDlGbaQKI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671786);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_zciBEWYuZhMAtgZbqTfnKgqeqPL_Private_Void_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671787);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_mYmvBuVyhaAnFgQBkLmgvJgdINv_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671788);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_XBierGaAUEyvHkBQeLhYfvfukfrL_Private_DiMkgKJkwQFMXOdcXGrJiabFPThh_ElementAssignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671789);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_pcsdTuLQXKzsYLGvQvqSbFfmZmG_Private_DiMkgKJkwQFMXOdcXGrJiabFPThh_ConflictResponse_ElementAssignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671790);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_pcsdTuLQXKzsYLGvQvqSbFfmZmG_Private_DiMkgKJkwQFMXOdcXGrJiabFPThh_ConflictResponse_ElementAssignment_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671791);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_JjOOLjSwyoCeGKNwGLEgXrbtiuJ_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671792);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_ybUUzNjRmOGZLDjeQGVBXVGctxb_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671793);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_rEHgXhtRzxzyeSOJrlVffTUCAeb_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671794);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_gRjodjoYdpmSwcndtgNTcYozIuri_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671795);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_gotVeWMLnRiUDHIevFIELFxtQdD_Private_Void_ElementAssignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671796);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_FOkqAbJXslDyyGyuQYlThLJaPoh_Private_Void_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671797);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_DqvAObIpQBloPJFyrzRvgCjCoAtx_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671798);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_sjteybTLlDhfcjwnedExgLcPVSZ_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671799);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_QOZJYeszWxrqspHizqaraZCZulH_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671800);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_OUAEYMDrESFRyHnPceDNsefSXFOk_Private_Void_ElementAssignmentInfo_IList_1_ElementAssignmentConflictInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671801);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_oMvJLoiLrdACgFJvcbTYLxycYoHg_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671802);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_znrujzFpsXHwkjXrYQnLIqPECXWh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671803);
				InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_EWNjBrFmSMAERAwZjigpJxZFcsL_Public_Void_ConflictResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, 100671804);
			}

			// Token: 0x17001748 RID: 5960
			// (get) Token: 0x06004A28 RID: 18984 RVA: 0x00153B28 File Offset: 0x00151D28
			public unsafe InputMapper.Status cvnWVGimTEwraIbmNIAQvYRCLji
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_get_status_Public_get_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001749 RID: 5961
			// (get) Token: 0x06004A29 RID: 18985 RVA: 0x00153B64 File Offset: 0x00151D64
			public unsafe float dEBPRHLmTDBCbrUIUcCyKIlazps
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 295171, RefRangeEnd = 295174, XrefRangeStart = 295167, XrefRangeEnd = 295171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_get_timeRemaining_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700174A RID: 5962
			// (get) Token: 0x06004A2A RID: 18986 RVA: 0x00153BA0 File Offset: 0x00151DA0
			public unsafe InputMapper.Context mqPFXbZviaanojLakPOEBfdEiwIj
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_get_context_Public_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputMapper.Context>(intPtr3) : null;
				}
			}

			// Token: 0x1700174B RID: 5963
			// (get) Token: 0x06004A2B RID: 18987 RVA: 0x00153BE0 File Offset: 0x00151DE0
			public unsafe bool zuPbTcEGhGYJdhNrVbxwXbqKlhrZ
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_get_checkTimer_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A2C RID: 18988 RVA: 0x00153C1C File Offset: 0x00151E1C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295205, RefRangeEnd = 295206, XrefRangeStart = 295174, XrefRangeEnd = 295205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SztVohOGHJfxAZjDLxgsTkhJblNG(InputMapper parent, Dictionary<InputMapper.xmzqWiCayBPBPSZAElrMgoEAVbw, SafeDelegate> events)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(events);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr__ctor_Public_Void_InputMapper_Dictionary_2_xmzqWiCayBPBPSZAElrMgoEAVbw_SafeDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A2D RID: 18989 RVA: 0x00153C7C File Offset: 0x00151E7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295206, XrefRangeEnd = 295208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void Finalize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A2E RID: 18990 RVA: 0x00153CB8 File Offset: 0x00151EB8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295244, RefRangeEnd = 295245, XrefRangeStart = 295208, XrefRangeEnd = 295244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void qeDEyDaZsAupdNZCUOgsfUHyXvg(InputMapper.Context A_1, InputMapper.Options A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_Context_Options_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A2F RID: 18991 RVA: 0x00153D0C File Offset: 0x00151F0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295245, XrefRangeEnd = 295246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void qibHnlMggWjYezyQPBTsFQbHenW(string A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_qibHnlMggWjYezyQPBTsFQbHenW_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A30 RID: 18992 RVA: 0x00153D50 File Offset: 0x00151F50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295246, XrefRangeEnd = 295261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void xozDTcGUrsCTUDmjINWIvPSceAOJ(UpdateLoopType A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Private_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A31 RID: 18993 RVA: 0x00153D90 File Offset: 0x00151F90
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 295270, RefRangeEnd = 295275, XrefRangeStart = 295261, XrefRangeEnd = 295270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void zfahqYjiIdfMojMAGLXbLAnHRnwb()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_zfahqYjiIdfMojMAGLXbLAnHRnwb_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A32 RID: 18994 RVA: 0x00153DC4 File Offset: 0x00151FC4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 295279, RefRangeEnd = 295281, XrefRangeStart = 295275, XrefRangeEnd = 295279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void xpmuwdDURcmUoRIBDfSyCTDoRXaE()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_xpmuwdDURcmUoRIBDfSyCTDoRXaE_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A33 RID: 18995 RVA: 0x00153DF8 File Offset: 0x00151FF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295281, XrefRangeEnd = 295300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.DiMkgKJkwQFMXOdcXGrJiabFPThh KCYldVZEgBvfhkvNFJCAuFNdcTs(out ElementAssignment A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_KCYldVZEgBvfhkvNFJCAuFNdcTs_Private_DiMkgKJkwQFMXOdcXGrJiabFPThh_byref_ElementAssignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A34 RID: 18996 RVA: 0x00153E44 File Offset: 0x00152044
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295327, RefRangeEnd = 295328, XrefRangeStart = 295300, XrefRangeEnd = 295327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool QqUvMUZSpEwhsUKEoHaHFpBhrwF(out IEnumerable<ControllerPollingInfo> A_1, out ModifierKeyFlags A_2)
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
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_QqUvMUZSpEwhsUKEoHaHFpBhrwF_Private_Boolean_byref_IEnumerable_1_ControllerPollingInfo_byref_ModifierKeyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				A_1 = ((intPtr4 == 0) ? null : new IEnumerable<ControllerPollingInfo>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06004A35 RID: 18997 RVA: 0x00153EB0 File Offset: 0x001520B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295328, XrefRangeEnd = 295334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ControllerPollingInfo> NjdpwsiZSdIYYzuMJRHCEbdYPmT(out ModifierKeyFlags A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_NjdpwsiZSdIYYzuMJRHCEbdYPmT_Private_IEnumerable_1_ControllerPollingInfo_byref_ModifierKeyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ControllerPollingInfo>>(intPtr3) : null;
				}
			}

			// Token: 0x06004A36 RID: 18998 RVA: 0x00153EFC File Offset: 0x001520FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295334, XrefRangeEnd = 295336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControllerPollingInfo ltTKeiwjYiChflpDLkJqhGENlch(InputMapper.Options A_1, out ModifierKeyFlags A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_ltTKeiwjYiChflpDLkJqhGENlch_Private_ControllerPollingInfo_Options_byref_ModifierKeyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ControllerPollingInfo(intPtr);
			}

			// Token: 0x06004A37 RID: 18999 RVA: 0x00153F54 File Offset: 0x00152154
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 295376, RefRangeEnd = 295378, XrefRangeStart = 295336, XrefRangeEnd = 295376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static ControllerPollingInfo ltTKeiwjYiChflpDLkJqhGENlch(InputMapper.Options A_0, out bool A_1, out ModifierKeyFlags A_2, out string A_3)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_1;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_ltTKeiwjYiChflpDLkJqhGENlch_Private_Static_ControllerPollingInfo_Options_byref_Boolean_byref_ModifierKeyFlags_byref_String_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				A_3 = IL2CPP.Il2CppStringToManaged(intPtr);
				return new ControllerPollingInfo(intPtr2);
			}

			// Token: 0x06004A38 RID: 19000 RVA: 0x00153FC8 File Offset: 0x001521C8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295381, RefRangeEnd = 295382, XrefRangeStart = 295378, XrefRangeEnd = 295381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool ovScvQGaZcBwQcNwaXhqFQhNCNjw(ControllerPollingInfo A_0, InputMapper.Options A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(A_0));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_ovScvQGaZcBwQcNwaXhqFQhNCNjw_Private_Static_Boolean_ControllerPollingInfo_Options_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004A39 RID: 19001 RVA: 0x00154020 File Offset: 0x00152220
			[CallerCount(0)]
			public unsafe static bool dlZNiCHXmIRDBQitWUTkmOIEdCC(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk A_0, ControllerPollingInfo A_1, InputMapper.Options A_2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_dlZNiCHXmIRDBQitWUTkmOIEdCC_Private_Static_Boolean_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ControllerPollingInfo_Options_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004A3A RID: 19002 RVA: 0x0015408C File Offset: 0x0015228C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295405, RefRangeEnd = 295406, XrefRangeStart = 295382, XrefRangeEnd = 295405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void PjyTZlBrcDmVhlddxmweENkwrQK()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_PjyTZlBrcDmVhlddxmweENkwrQK_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A3B RID: 19003 RVA: 0x001540C0 File Offset: 0x001522C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295406, XrefRangeEnd = 295412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.DiMkgKJkwQFMXOdcXGrJiabFPThh NvyPkGOMLGfjRquqyArWdYGUplF(ElementAssignment A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_NvyPkGOMLGfjRquqyArWdYGUplF_Private_DiMkgKJkwQFMXOdcXGrJiabFPThh_ElementAssignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A3C RID: 19004 RVA: 0x0015410C File Offset: 0x0015230C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295412, XrefRangeEnd = 295418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool znsDidAYIixVXDLAvLHuPZSbQqnm(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk A_0, ElementAssignment A_1, List<Player> A_2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_znsDidAYIixVXDLAvLHuPZSbQqnm_Private_Static_Boolean_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ElementAssignment_List_1_Player_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004A3D RID: 19005 RVA: 0x00154170 File Offset: 0x00152370
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 295438, RefRangeEnd = 295441, XrefRangeStart = 295418, XrefRangeEnd = 295438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool XpkDENiZdHeccPVzUpKDpojLqzB(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk A_0, ElementAssignment A_1, List<Player> A_2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_XpkDENiZdHeccPVzUpKDpojLqzB_Private_Static_Boolean_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ElementAssignment_List_1_Player_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004A3E RID: 19006 RVA: 0x001541D4 File Offset: 0x001523D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295441, XrefRangeEnd = 295468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static IList<ElementAssignmentConflictInfo> oDydEkEJVwiAVYbLVxonWywrxun(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk A_0, ElementAssignment A_1, List<Player> A_2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_oDydEkEJVwiAVYbLVxonWywrxun_Private_Static_IList_1_ElementAssignmentConflictInfo_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ElementAssignment_List_1_Player_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ElementAssignmentConflictInfo>>(intPtr3) : null;
			}

			// Token: 0x06004A3F RID: 19007 RVA: 0x00154238 File Offset: 0x00152438
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 295471, RefRangeEnd = 295476, XrefRangeStart = 295468, XrefRangeEnd = 295471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool RzxBkvaLhbMFrGyZhLWijPMpjHUE(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk A_0, ElementAssignment A_1, out ElementAssignmentConflictCheck A_2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_RzxBkvaLhbMFrGyZhLWijPMpjHUE_Private_Static_Boolean_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ElementAssignment_byref_ElementAssignmentConflictCheck_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004A40 RID: 19008 RVA: 0x00154298 File Offset: 0x00152498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295476, XrefRangeEnd = 295485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void tUqKHYfNDLwvZrdXyKOoakHZfjs(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk A_0, ElementAssignment A_1, List<Player> A_2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_tUqKHYfNDLwvZrdXyKOoakHZfjs_Private_Static_Void_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ElementAssignment_List_1_Player_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A41 RID: 19009 RVA: 0x001542F0 File Offset: 0x001524F0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 295503, RefRangeEnd = 295506, XrefRangeStart = 295485, XrefRangeEnd = 295503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void xCcCNACARHflUYpupTiRSkUKMrz()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_xCcCNACARHflUYpupTiRSkUKMrz_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A42 RID: 19010 RVA: 0x00154324 File Offset: 0x00152524
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 295518, RefRangeEnd = 295521, XrefRangeStart = 295506, XrefRangeEnd = 295518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void VgWLSYBznTpZfwcVSJkoHUZURq()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_VgWLSYBznTpZfwcVSJkoHUZURq_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A43 RID: 19011 RVA: 0x00154358 File Offset: 0x00152558
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 295524, RefRangeEnd = 295539, XrefRangeStart = 295521, XrefRangeEnd = 295524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool oomjtJJdkbwxFiesscNnfgqgnCv(InputMapper.xmzqWiCayBPBPSZAElrMgoEAVbw A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_oomjtJJdkbwxFiesscNnfgqgnCv_Private_Boolean_xmzqWiCayBPBPSZAElrMgoEAVbw_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A44 RID: 19012 RVA: 0x001543A4 File Offset: 0x001525A4
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 295544, RefRangeEnd = 295558, XrefRangeStart = 295539, XrefRangeEnd = 295544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void TOsmIyUnDbrAkvGgiejZqZWsQla<T>(InputMapper.xmzqWiCayBPBPSZAElrMgoEAVbw A_1, T A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = A_2;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref A_2;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.MethodInfoStoreGeneric_TOsmIyUnDbrAkvGgiejZqZWsQla_Private_Void_xmzqWiCayBPBPSZAElrMgoEAVbw_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A45 RID: 19013 RVA: 0x00154440 File Offset: 0x00152640
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 295562, RefRangeEnd = 295565, XrefRangeStart = 295558, XrefRangeEnd = 295562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void atMVYiecIRUdSeAYeaBVyuauztd()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_atMVYiecIRUdSeAYeaBVyuauztd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A46 RID: 19014 RVA: 0x00154474 File Offset: 0x00152674
			[CallerCount(0)]
			public unsafe void wEBajoimHsuJMiqKMNrJDlGbaQKI()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_wEBajoimHsuJMiqKMNrJDlGbaQKI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A47 RID: 19015 RVA: 0x001544A8 File Offset: 0x001526A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295565, XrefRangeEnd = 295573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void zciBEWYuZhMAtgZbqTfnKgqeqPL(ActionElementMap A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_zciBEWYuZhMAtgZbqTfnKgqeqPL_Private_Void_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A48 RID: 19016 RVA: 0x001544EC File Offset: 0x001526EC
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 295581, RefRangeEnd = 295593, XrefRangeStart = 295573, XrefRangeEnd = 295581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void mYmvBuVyhaAnFgQBkLmgvJgdINv(string A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_mYmvBuVyhaAnFgQBkLmgvJgdINv_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A49 RID: 19017 RVA: 0x00154530 File Offset: 0x00152730
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295597, RefRangeEnd = 295598, XrefRangeStart = 295593, XrefRangeEnd = 295597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.DiMkgKJkwQFMXOdcXGrJiabFPThh XBierGaAUEyvHkBQeLhYfvfukfrL(ElementAssignment A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_XBierGaAUEyvHkBQeLhYfvfukfrL_Private_DiMkgKJkwQFMXOdcXGrJiabFPThh_ElementAssignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A4A RID: 19018 RVA: 0x0015457C File Offset: 0x0015277C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295598, XrefRangeEnd = 295600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.DiMkgKJkwQFMXOdcXGrJiabFPThh pcsdTuLQXKzsYLGvQvqSbFfmZmG(InputMapper.ConflictResponse A_1, ElementAssignment A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_pcsdTuLQXKzsYLGvQvqSbFfmZmG_Private_DiMkgKJkwQFMXOdcXGrJiabFPThh_ConflictResponse_ElementAssignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004A4B RID: 19019 RVA: 0x001545D4 File Offset: 0x001527D4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 295607, RefRangeEnd = 295610, XrefRangeStart = 295600, XrefRangeEnd = 295607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.DiMkgKJkwQFMXOdcXGrJiabFPThh pcsdTuLQXKzsYLGvQvqSbFfmZmG(InputMapper.ConflictResponse A_1, ElementAssignment A_2, bool A_3)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_pcsdTuLQXKzsYLGvQvqSbFfmZmG_Private_DiMkgKJkwQFMXOdcXGrJiabFPThh_ConflictResponse_ElementAssignment_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004A4C RID: 19020 RVA: 0x0015463C File Offset: 0x0015283C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295610, XrefRangeEnd = 295618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void JjOOLjSwyoCeGKNwGLEgXrbtiuJ()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_JjOOLjSwyoCeGKNwGLEgXrbtiuJ_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A4D RID: 19021 RVA: 0x00154670 File Offset: 0x00152870
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 295626, RefRangeEnd = 295628, XrefRangeStart = 295618, XrefRangeEnd = 295626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ybUUzNjRmOGZLDjeQGVBXVGctxb(string A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_ybUUzNjRmOGZLDjeQGVBXVGctxb_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A4E RID: 19022 RVA: 0x001546B4 File Offset: 0x001528B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295628, XrefRangeEnd = 295629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void rEHgXhtRzxzyeSOJrlVffTUCAeb()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_rEHgXhtRzxzyeSOJrlVffTUCAeb_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A4F RID: 19023 RVA: 0x001546E8 File Offset: 0x001528E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295629, XrefRangeEnd = 295634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void gRjodjoYdpmSwcndtgNTcYozIuri()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_gRjodjoYdpmSwcndtgNTcYozIuri_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A50 RID: 19024 RVA: 0x0015471C File Offset: 0x0015291C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295638, RefRangeEnd = 295639, XrefRangeStart = 295634, XrefRangeEnd = 295638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void gotVeWMLnRiUDHIevFIELFxtQdD(ElementAssignment A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_gotVeWMLnRiUDHIevFIELFxtQdD_Private_Void_ElementAssignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A51 RID: 19025 RVA: 0x0015475C File Offset: 0x0015295C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295639, XrefRangeEnd = 295646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void FOkqAbJXslDyyGyuQYlThLJaPoh(ActionElementMap A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_FOkqAbJXslDyyGyuQYlThLJaPoh_Private_Void_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A52 RID: 19026 RVA: 0x001547A0 File Offset: 0x001529A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295646, XrefRangeEnd = 295653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DqvAObIpQBloPJFyrzRvgCjCoAtx()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_DqvAObIpQBloPJFyrzRvgCjCoAtx_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A53 RID: 19027 RVA: 0x001547D4 File Offset: 0x001529D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295653, XrefRangeEnd = 295660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void sjteybTLlDhfcjwnedExgLcPVSZ(string A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_sjteybTLlDhfcjwnedExgLcPVSZ_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A54 RID: 19028 RVA: 0x00154818 File Offset: 0x00152A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295660, XrefRangeEnd = 295667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void QOZJYeszWxrqspHizqaraZCZulH(string A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_QOZJYeszWxrqspHizqaraZCZulH_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A55 RID: 19029 RVA: 0x0015485C File Offset: 0x00152A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295667, XrefRangeEnd = 295680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OUAEYMDrESFRyHnPceDNsefSXFOk(ElementAssignmentInfo A_1, IList<ElementAssignmentConflictInfo> A_2, bool A_3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_OUAEYMDrESFRyHnPceDNsefSXFOk_Private_Void_ElementAssignmentInfo_IList_1_ElementAssignmentConflictInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A56 RID: 19030 RVA: 0x001548C0 File Offset: 0x00152AC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295680, XrefRangeEnd = 295687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void oMvJLoiLrdACgFJvcbTYLxycYoHg()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_oMvJLoiLrdACgFJvcbTYLxycYoHg_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A57 RID: 19031 RVA: 0x001548F4 File Offset: 0x00152AF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295687, XrefRangeEnd = 295694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void znrujzFpsXHwkjXrYQnLIqPECXWh()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_znrujzFpsXHwkjXrYQnLIqPECXWh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A58 RID: 19032 RVA: 0x00154928 File Offset: 0x00152B28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295694, XrefRangeEnd = 295707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EWNjBrFmSMAERAwZjigpJxZFcsL(InputMapper.ConflictResponse A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_EWNjBrFmSMAERAwZjigpJxZFcsL_Public_Void_ConflictResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A59 RID: 19033 RVA: 0x0001B516 File Offset: 0x00019716
			public SztVohOGHJfxAZjDLxgsTkhJblNG(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700173C RID: 5948
			// (get) Token: 0x06004A5A RID: 19034 RVA: 0x00154968 File Offset: 0x00152B68
			// (set) Token: 0x06004A5B RID: 19035 RVA: 0x0001B51F File Offset: 0x0001971F
			public unsafe InputMapper mcZTbbPGwEArYoSxgzyGmeIyAph
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_mcZTbbPGwEArYoSxgzyGmeIyAph);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputMapper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_mcZTbbPGwEArYoSxgzyGmeIyAph), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700173D RID: 5949
			// (get) Token: 0x06004A5C RID: 19036 RVA: 0x00154998 File Offset: 0x00152B98
			// (set) Token: 0x06004A5D RID: 19037 RVA: 0x0001B53E File Offset: 0x0001973E
			public unsafe InputMapper.Options pvnMWcEaMfdHVEzYZcFstMNcIJG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_pvnMWcEaMfdHVEzYZcFstMNcIJG);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputMapper.Options>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_pvnMWcEaMfdHVEzYZcFstMNcIJG), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700173E RID: 5950
			// (get) Token: 0x06004A5E RID: 19038 RVA: 0x001549C8 File Offset: 0x00152BC8
			// (set) Token: 0x06004A5F RID: 19039 RVA: 0x0001B55D File Offset: 0x0001975D
			public unsafe InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk XXscCHUbSqdTovHfIhOXcsPtLFr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_XXscCHUbSqdTovHfIhOXcsPtLFr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_XXscCHUbSqdTovHfIhOXcsPtLFr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700173F RID: 5951
			// (get) Token: 0x06004A60 RID: 19040 RVA: 0x001549F8 File Offset: 0x00152BF8
			// (set) Token: 0x06004A61 RID: 19041 RVA: 0x0001B57C File Offset: 0x0001977C
			public unsafe Dictionary<InputMapper.xmzqWiCayBPBPSZAElrMgoEAVbw, SafeDelegate> EolqjSEMIQCAaMZnTpWhdUKpDqz
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_EolqjSEMIQCAaMZnTpWhdUKpDqz);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<InputMapper.xmzqWiCayBPBPSZAElrMgoEAVbw, SafeDelegate>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_EolqjSEMIQCAaMZnTpWhdUKpDqz), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001740 RID: 5952
			// (get) Token: 0x06004A62 RID: 19042 RVA: 0x00154A28 File Offset: 0x00152C28
			// (set) Token: 0x06004A63 RID: 19043 RVA: 0x0001B59B File Offset: 0x0001979B
			public unsafe Dictionary<string, SafeDelegate> ECMOFvQBpoMhjGrdgIWKnWiXLNu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_ECMOFvQBpoMhjGrdgIWKnWiXLNu);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SafeDelegate>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_ECMOFvQBpoMhjGrdgIWKnWiXLNu), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001741 RID: 5953
			// (get) Token: 0x06004A64 RID: 19044 RVA: 0x00154A58 File Offset: 0x00152C58
			// (set) Token: 0x06004A65 RID: 19045 RVA: 0x0001B5BA File Offset: 0x000197BA
			public unsafe InputMapper.Status LgdhFLgMLSZicoxRjNYWTzwzbfj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_LgdhFLgMLSZicoxRjNYWTzwzbfj);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_LgdhFLgMLSZicoxRjNYWTzwzbfj)) = value;
				}
			}

			// Token: 0x17001742 RID: 5954
			// (get) Token: 0x06004A66 RID: 19046 RVA: 0x00154A80 File Offset: 0x00152C80
			// (set) Token: 0x06004A67 RID: 19047 RVA: 0x0001B5D5 File Offset: 0x000197D5
			public unsafe InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.uaHWCOPaCmkvsfOuZgRsWBlupKP mYPXeoLEDGJgDwFpaudrlblnFiw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_mYPXeoLEDGJgDwFpaudrlblnFiw);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_mYPXeoLEDGJgDwFpaudrlblnFiw)) = value;
				}
			}

			// Token: 0x17001743 RID: 5955
			// (get) Token: 0x06004A68 RID: 19048 RVA: 0x00154AA8 File Offset: 0x00152CA8
			// (set) Token: 0x06004A69 RID: 19049 RVA: 0x0001B5F0 File Offset: 0x000197F0
			public unsafe double IazdtdlCeOAEwAIlzilallbRIbQd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_IazdtdlCeOAEwAIlzilallbRIbQd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_IazdtdlCeOAEwAIlzilallbRIbQd)) = value;
				}
			}

			// Token: 0x17001744 RID: 5956
			// (get) Token: 0x06004A6A RID: 19050 RVA: 0x00154AD0 File Offset: 0x00152CD0
			// (set) Token: 0x06004A6B RID: 19051 RVA: 0x0001B60B File Offset: 0x0001980B
			public unsafe bool wmkwYqTtitbgejxslljmJKBXwbC
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_wmkwYqTtitbgejxslljmJKBXwbC);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_wmkwYqTtitbgejxslljmJKBXwbC)) = value;
				}
			}

			// Token: 0x17001745 RID: 5957
			// (get) Token: 0x06004A6C RID: 19052 RVA: 0x00154AF8 File Offset: 0x00152CF8
			// (set) Token: 0x06004A6D RID: 19053 RVA: 0x0001B626 File Offset: 0x00019826
			public unsafe List<Player> sfOIDrDDBcEkSLSASeMMnBKBMgxb
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_sfOIDrDDBcEkSLSASeMMnBKBMgxb);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_sfOIDrDDBcEkSLSASeMMnBKBMgxb), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001746 RID: 5958
			// (get) Token: 0x06004A6E RID: 19054 RVA: 0x00154B28 File Offset: 0x00152D28
			// (set) Token: 0x06004A6F RID: 19055 RVA: 0x0001B645 File Offset: 0x00019845
			public unsafe List<ControllerPollingInfo> NhLRctHeQDSZgIwFPrWStggAjuE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_NhLRctHeQDSZgIwFPrWStggAjuE);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ControllerPollingInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_NhLRctHeQDSZgIwFPrWStggAjuE), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001747 RID: 5959
			// (get) Token: 0x06004A70 RID: 19056 RVA: 0x00154B58 File Offset: 0x00152D58
			// (set) Token: 0x06004A71 RID: 19057 RVA: 0x0001B664 File Offset: 0x00019864
			public unsafe ElementAssignment uXObMWEjPDjeZqdpYebKKFJYOxAS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_uXObMWEjPDjeZqdpYebKKFJYOxAS);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeFieldInfoPtr_uXObMWEjPDjeZqdpYebKKFJYOxAS)) = value;
				}
			}

			// Token: 0x04003C04 RID: 15364
			private static readonly IntPtr NativeFieldInfoPtr_mcZTbbPGwEArYoSxgzyGmeIyAph;

			// Token: 0x04003C05 RID: 15365
			private static readonly IntPtr NativeFieldInfoPtr_pvnMWcEaMfdHVEzYZcFstMNcIJG;

			// Token: 0x04003C06 RID: 15366
			private static readonly IntPtr NativeFieldInfoPtr_XXscCHUbSqdTovHfIhOXcsPtLFr;

			// Token: 0x04003C07 RID: 15367
			private static readonly IntPtr NativeFieldInfoPtr_EolqjSEMIQCAaMZnTpWhdUKpDqz;

			// Token: 0x04003C08 RID: 15368
			private static readonly IntPtr NativeFieldInfoPtr_ECMOFvQBpoMhjGrdgIWKnWiXLNu;

			// Token: 0x04003C09 RID: 15369
			private static readonly IntPtr NativeFieldInfoPtr_LgdhFLgMLSZicoxRjNYWTzwzbfj;

			// Token: 0x04003C0A RID: 15370
			private static readonly IntPtr NativeFieldInfoPtr_mYPXeoLEDGJgDwFpaudrlblnFiw;

			// Token: 0x04003C0B RID: 15371
			private static readonly IntPtr NativeFieldInfoPtr_IazdtdlCeOAEwAIlzilallbRIbQd;

			// Token: 0x04003C0C RID: 15372
			private static readonly IntPtr NativeFieldInfoPtr_wmkwYqTtitbgejxslljmJKBXwbC;

			// Token: 0x04003C0D RID: 15373
			private static readonly IntPtr NativeFieldInfoPtr_sfOIDrDDBcEkSLSASeMMnBKBMgxb;

			// Token: 0x04003C0E RID: 15374
			private static readonly IntPtr NativeFieldInfoPtr_NhLRctHeQDSZgIwFPrWStggAjuE;

			// Token: 0x04003C0F RID: 15375
			private static readonly IntPtr NativeFieldInfoPtr_uXObMWEjPDjeZqdpYebKKFJYOxAS;

			// Token: 0x04003C10 RID: 15376
			private static readonly IntPtr NativeMethodInfoPtr_get_status_Public_get_Status_0;

			// Token: 0x04003C11 RID: 15377
			private static readonly IntPtr NativeMethodInfoPtr_get_timeRemaining_Public_get_Single_0;

			// Token: 0x04003C12 RID: 15378
			private static readonly IntPtr NativeMethodInfoPtr_get_context_Public_get_Context_0;

			// Token: 0x04003C13 RID: 15379
			private static readonly IntPtr NativeMethodInfoPtr_get_checkTimer_Private_get_Boolean_0;

			// Token: 0x04003C14 RID: 15380
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputMapper_Dictionary_2_xmzqWiCayBPBPSZAElrMgoEAVbw_SafeDelegate_0;

			// Token: 0x04003C15 RID: 15381
			private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

			// Token: 0x04003C16 RID: 15382
			private static readonly IntPtr NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_Context_Options_0;

			// Token: 0x04003C17 RID: 15383
			private static readonly IntPtr NativeMethodInfoPtr_qibHnlMggWjYezyQPBTsFQbHenW_Public_Void_String_0;

			// Token: 0x04003C18 RID: 15384
			private static readonly IntPtr NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Private_Void_UpdateLoopType_0;

			// Token: 0x04003C19 RID: 15385
			private static readonly IntPtr NativeMethodInfoPtr_zfahqYjiIdfMojMAGLXbLAnHRnwb_Private_Void_0;

			// Token: 0x04003C1A RID: 15386
			private static readonly IntPtr NativeMethodInfoPtr_xpmuwdDURcmUoRIBDfSyCTDoRXaE_Private_Void_0;

			// Token: 0x04003C1B RID: 15387
			private static readonly IntPtr NativeMethodInfoPtr_KCYldVZEgBvfhkvNFJCAuFNdcTs_Private_DiMkgKJkwQFMXOdcXGrJiabFPThh_byref_ElementAssignment_0;

			// Token: 0x04003C1C RID: 15388
			private static readonly IntPtr NativeMethodInfoPtr_QqUvMUZSpEwhsUKEoHaHFpBhrwF_Private_Boolean_byref_IEnumerable_1_ControllerPollingInfo_byref_ModifierKeyFlags_0;

			// Token: 0x04003C1D RID: 15389
			private static readonly IntPtr NativeMethodInfoPtr_NjdpwsiZSdIYYzuMJRHCEbdYPmT_Private_IEnumerable_1_ControllerPollingInfo_byref_ModifierKeyFlags_0;

			// Token: 0x04003C1E RID: 15390
			private static readonly IntPtr NativeMethodInfoPtr_ltTKeiwjYiChflpDLkJqhGENlch_Private_ControllerPollingInfo_Options_byref_ModifierKeyFlags_0;

			// Token: 0x04003C1F RID: 15391
			private static readonly IntPtr NativeMethodInfoPtr_ltTKeiwjYiChflpDLkJqhGENlch_Private_Static_ControllerPollingInfo_Options_byref_Boolean_byref_ModifierKeyFlags_byref_String_0;

			// Token: 0x04003C20 RID: 15392
			private static readonly IntPtr NativeMethodInfoPtr_ovScvQGaZcBwQcNwaXhqFQhNCNjw_Private_Static_Boolean_ControllerPollingInfo_Options_0;

			// Token: 0x04003C21 RID: 15393
			private static readonly IntPtr NativeMethodInfoPtr_dlZNiCHXmIRDBQitWUTkmOIEdCC_Private_Static_Boolean_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ControllerPollingInfo_Options_0;

			// Token: 0x04003C22 RID: 15394
			private static readonly IntPtr NativeMethodInfoPtr_PjyTZlBrcDmVhlddxmweENkwrQK_Private_Void_0;

			// Token: 0x04003C23 RID: 15395
			private static readonly IntPtr NativeMethodInfoPtr_NvyPkGOMLGfjRquqyArWdYGUplF_Private_DiMkgKJkwQFMXOdcXGrJiabFPThh_ElementAssignment_0;

			// Token: 0x04003C24 RID: 15396
			private static readonly IntPtr NativeMethodInfoPtr_znsDidAYIixVXDLAvLHuPZSbQqnm_Private_Static_Boolean_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ElementAssignment_List_1_Player_0;

			// Token: 0x04003C25 RID: 15397
			private static readonly IntPtr NativeMethodInfoPtr_XpkDENiZdHeccPVzUpKDpojLqzB_Private_Static_Boolean_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ElementAssignment_List_1_Player_0;

			// Token: 0x04003C26 RID: 15398
			private static readonly IntPtr NativeMethodInfoPtr_oDydEkEJVwiAVYbLVxonWywrxun_Private_Static_IList_1_ElementAssignmentConflictInfo_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ElementAssignment_List_1_Player_0;

			// Token: 0x04003C27 RID: 15399
			private static readonly IntPtr NativeMethodInfoPtr_RzxBkvaLhbMFrGyZhLWijPMpjHUE_Private_Static_Boolean_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ElementAssignment_byref_ElementAssignmentConflictCheck_0;

			// Token: 0x04003C28 RID: 15400
			private static readonly IntPtr NativeMethodInfoPtr_tUqKHYfNDLwvZrdXyKOoakHZfjs_Private_Static_Void_cdNJbuTSPXdvGUVYwnGxjYDbdAk_ElementAssignment_List_1_Player_0;

			// Token: 0x04003C29 RID: 15401
			private static readonly IntPtr NativeMethodInfoPtr_xCcCNACARHflUYpupTiRSkUKMrz_Private_Void_0;

			// Token: 0x04003C2A RID: 15402
			private static readonly IntPtr NativeMethodInfoPtr_VgWLSYBznTpZfwcVSJkoHUZURq_Private_Void_0;

			// Token: 0x04003C2B RID: 15403
			private static readonly IntPtr NativeMethodInfoPtr_oomjtJJdkbwxFiesscNnfgqgnCv_Private_Boolean_xmzqWiCayBPBPSZAElrMgoEAVbw_0;

			// Token: 0x04003C2C RID: 15404
			private static readonly IntPtr NativeMethodInfoPtr_TOsmIyUnDbrAkvGgiejZqZWsQla_Private_Void_xmzqWiCayBPBPSZAElrMgoEAVbw_T_0;

			// Token: 0x04003C2D RID: 15405
			private static readonly IntPtr NativeMethodInfoPtr_atMVYiecIRUdSeAYeaBVyuauztd_Private_Void_0;

			// Token: 0x04003C2E RID: 15406
			private static readonly IntPtr NativeMethodInfoPtr_wEBajoimHsuJMiqKMNrJDlGbaQKI_Private_Void_0;

			// Token: 0x04003C2F RID: 15407
			private static readonly IntPtr NativeMethodInfoPtr_zciBEWYuZhMAtgZbqTfnKgqeqPL_Private_Void_ActionElementMap_0;

			// Token: 0x04003C30 RID: 15408
			private static readonly IntPtr NativeMethodInfoPtr_mYmvBuVyhaAnFgQBkLmgvJgdINv_Private_Void_String_0;

			// Token: 0x04003C31 RID: 15409
			private static readonly IntPtr NativeMethodInfoPtr_XBierGaAUEyvHkBQeLhYfvfukfrL_Private_DiMkgKJkwQFMXOdcXGrJiabFPThh_ElementAssignment_0;

			// Token: 0x04003C32 RID: 15410
			private static readonly IntPtr NativeMethodInfoPtr_pcsdTuLQXKzsYLGvQvqSbFfmZmG_Private_DiMkgKJkwQFMXOdcXGrJiabFPThh_ConflictResponse_ElementAssignment_0;

			// Token: 0x04003C33 RID: 15411
			private static readonly IntPtr NativeMethodInfoPtr_pcsdTuLQXKzsYLGvQvqSbFfmZmG_Private_DiMkgKJkwQFMXOdcXGrJiabFPThh_ConflictResponse_ElementAssignment_Boolean_0;

			// Token: 0x04003C34 RID: 15412
			private static readonly IntPtr NativeMethodInfoPtr_JjOOLjSwyoCeGKNwGLEgXrbtiuJ_Private_Void_0;

			// Token: 0x04003C35 RID: 15413
			private static readonly IntPtr NativeMethodInfoPtr_ybUUzNjRmOGZLDjeQGVBXVGctxb_Private_Void_String_0;

			// Token: 0x04003C36 RID: 15414
			private static readonly IntPtr NativeMethodInfoPtr_rEHgXhtRzxzyeSOJrlVffTUCAeb_Private_Void_0;

			// Token: 0x04003C37 RID: 15415
			private static readonly IntPtr NativeMethodInfoPtr_gRjodjoYdpmSwcndtgNTcYozIuri_Private_Void_0;

			// Token: 0x04003C38 RID: 15416
			private static readonly IntPtr NativeMethodInfoPtr_gotVeWMLnRiUDHIevFIELFxtQdD_Private_Void_ElementAssignment_0;

			// Token: 0x04003C39 RID: 15417
			private static readonly IntPtr NativeMethodInfoPtr_FOkqAbJXslDyyGyuQYlThLJaPoh_Private_Void_ActionElementMap_0;

			// Token: 0x04003C3A RID: 15418
			private static readonly IntPtr NativeMethodInfoPtr_DqvAObIpQBloPJFyrzRvgCjCoAtx_Private_Void_0;

			// Token: 0x04003C3B RID: 15419
			private static readonly IntPtr NativeMethodInfoPtr_sjteybTLlDhfcjwnedExgLcPVSZ_Private_Void_String_0;

			// Token: 0x04003C3C RID: 15420
			private static readonly IntPtr NativeMethodInfoPtr_QOZJYeszWxrqspHizqaraZCZulH_Private_Void_String_0;

			// Token: 0x04003C3D RID: 15421
			private static readonly IntPtr NativeMethodInfoPtr_OUAEYMDrESFRyHnPceDNsefSXFOk_Private_Void_ElementAssignmentInfo_IList_1_ElementAssignmentConflictInfo_Boolean_0;

			// Token: 0x04003C3E RID: 15422
			private static readonly IntPtr NativeMethodInfoPtr_oMvJLoiLrdACgFJvcbTYLxycYoHg_Private_Void_0;

			// Token: 0x04003C3F RID: 15423
			private static readonly IntPtr NativeMethodInfoPtr_znrujzFpsXHwkjXrYQnLIqPECXWh_Private_Void_0;

			// Token: 0x04003C40 RID: 15424
			private static readonly IntPtr NativeMethodInfoPtr_EWNjBrFmSMAERAwZjigpJxZFcsL_Public_Void_ConflictResponse_0;

			// Token: 0x02000573 RID: 1395
			[OriginalName("Rewired_Core.dll", "", "DiMkgKJkwQFMXOdcXGrJiabFPThh")]
			public enum DiMkgKJkwQFMXOdcXGrJiabFPThh
			{
				// Token: 0x04004B91 RID: 19345
				OmCcWjNIiSxaWhFdHatGXsZcnPF,
				// Token: 0x04004B92 RID: 19346
				UQvSlRMIziQywWGCtOrTSkEpHgA
			}

			// Token: 0x02000574 RID: 1396
			[OriginalName("Rewired_Core.dll", "", "uaHWCOPaCmkvsfOuZgRsWBlupKP")]
			public enum uaHWCOPaCmkvsfOuZgRsWBlupKP
			{
				// Token: 0x04004B94 RID: 19348
				urhBwQidoSAKHIhcxeCWNbALMhkh,
				// Token: 0x04004B95 RID: 19349
				KRbmWuddQDMORjARmwUuLjkifwr
			}

			// Token: 0x02000575 RID: 1397
			public class cdNJbuTSPXdvGUVYwnGxjYDbdAk : Object
			{
				// Token: 0x06005C96 RID: 23702 RVA: 0x0019525C File Offset: 0x0019345C
				// Note: this type is marked as 'beforefieldinit'.
				static cdNJbuTSPXdvGUVYwnGxjYDbdAk()
				{
					Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr, "cdNJbuTSPXdvGUVYwnGxjYDbdAk");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr);
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_LJLpeqIMXIWQRJmTMPOerYeeqPn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, "LJLpeqIMXIWQRJmTMPOerYeeqPn");
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, "HSNQHCcXgyznRFxfZdJonabrHRG");
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_OVUMNuhgFVnKkcJEIFsqfSKjHROk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, "OVUMNuhgFVnKkcJEIFsqfSKjHROk");
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, "YgpbSyKqzywxZrpQdLClhHDXnpw");
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, "IfhnTjioRBhbGjEtsghiwZaIQGbU");
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_QpOsFxYXoouZASuhyCyewBWyCTg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, "QpOsFxYXoouZASuhyCyewBWyCTg");
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_jguJLhLQrutwBBlfOhjkXhNEEqm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, "jguJLhLQrutwBBlfOhjkXhNEEqm");
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_player_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, 100671805);
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_actionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, 100671806);
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_mappingContext_Public_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, 100671807);
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, 100671808);
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, 100671809);
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_pollingInfo_Public_get_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, 100671810);
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_modifierKeyFlags_Public_get_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, 100671811);
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, 100671812);
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_elementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, 100671813);
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, 100671814);
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Public_Void_Player_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, 100671815);
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, 100671816);
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_uwtqusBdUuePgtMazGSCicAXvohV_Public_ElementAssignment_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, 100671817);
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_uwtqusBdUuePgtMazGSCicAXvohV_Public_ElementAssignment_ControllerPollingInfo_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, 100671818);
					InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_uwtqusBdUuePgtMazGSCicAXvohV_Public_ElementAssignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr, 100671819);
				}

				// Token: 0x17001CCA RID: 7370
				// (get) Token: 0x06005C97 RID: 23703 RVA: 0x00195440 File Offset: 0x00193640
				public unsafe Player XWyIBmFjPRjRJFSaIDwlQvshsjC
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_player_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
					}
				}

				// Token: 0x17001CCB RID: 7371
				// (get) Token: 0x06005C98 RID: 23704 RVA: 0x00195480 File Offset: 0x00193680
				public unsafe int jNQTdRTTjCCEILGnXmvKFjBTfEZ
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_actionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x17001CCC RID: 7372
				// (get) Token: 0x06005C99 RID: 23705 RVA: 0x001954BC File Offset: 0x001936BC
				public unsafe InputMapper.Context ruGiIrjHizQciDZxUleaTOJLpmY
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_mappingContext_Public_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputMapper.Context>(intPtr3) : null;
					}
				}

				// Token: 0x17001CCD RID: 7373
				// (get) Token: 0x06005C9A RID: 23706 RVA: 0x001954FC File Offset: 0x001936FC
				public unsafe ControllerType vZQzaELUnAgwcqQLPWCXzRIQwTH
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x17001CCE RID: 7374
				// (get) Token: 0x06005C9B RID: 23707 RVA: 0x00195538 File Offset: 0x00193738
				public unsafe int dvCcIliHGzOfKrXnqLmKTwiJxbJP
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x17001CCF RID: 7375
				// (get) Token: 0x06005C9C RID: 23708 RVA: 0x00195574 File Offset: 0x00193774
				public unsafe ControllerPollingInfo uusrJObGAKkedkisjULBKjFeUDm
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_pollingInfo_Public_get_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new ControllerPollingInfo(intPtr);
					}
				}

				// Token: 0x17001CD0 RID: 7376
				// (get) Token: 0x06005C9D RID: 23709 RVA: 0x001955AC File Offset: 0x001937AC
				public unsafe ModifierKeyFlags iTOCOzupMahHrpfYUNjWbaIsVqg
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_modifierKeyFlags_Public_get_ModifierKeyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x17001CD1 RID: 7377
				// (get) Token: 0x06005C9E RID: 23710 RVA: 0x001955E8 File Offset: 0x001937E8
				public unsafe AxisRange fDIHCXxKWzIBcWjRyUjPuXoIgcA
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x17001CD2 RID: 7378
				// (get) Token: 0x06005C9F RID: 23711 RVA: 0x00195624 File Offset: 0x00193824
				public unsafe string ldhHQMAbvgNcrByuLltqiUyMXcm
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295142, XrefRangeEnd = 295152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_get_elementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x06005CA0 RID: 23712 RVA: 0x0019565C File Offset: 0x0019385C
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe cdNJbuTSPXdvGUVYwnGxjYDbdAk()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005CA1 RID: 23713 RVA: 0x00195698 File Offset: 0x00193898
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 295157, RefRangeEnd = 295158, XrefRangeStart = 295152, XrefRangeEnd = 295157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void dwHOFmApnpWkXreTmwZYsRXRrow(Player A_1, InputMapper.Context A_2)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Public_Void_Player_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005CA2 RID: 23714 RVA: 0x001956EC File Offset: 0x001938EC
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 295158, RefRangeEnd = 295160, XrefRangeStart = 295158, XrefRangeEnd = 295158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void GMFpQqtyJcjzYToWCrZsZQAhPYh()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005CA3 RID: 23715 RVA: 0x00195720 File Offset: 0x00193920
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295160, XrefRangeEnd = 295161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ElementAssignment uwtqusBdUuePgtMazGSCicAXvohV(ControllerPollingInfo A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_uwtqusBdUuePgtMazGSCicAXvohV_Public_ElementAssignment_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06005CA4 RID: 23716 RVA: 0x00195774 File Offset: 0x00193974
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295161, XrefRangeEnd = 295162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ElementAssignment uwtqusBdUuePgtMazGSCicAXvohV(ControllerPollingInfo A_1, ModifierKeyFlags A_2)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1));
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_uwtqusBdUuePgtMazGSCicAXvohV_Public_ElementAssignment_ControllerPollingInfo_ModifierKeyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06005CA5 RID: 23717 RVA: 0x001957D4 File Offset: 0x001939D4
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 295164, RefRangeEnd = 295167, XrefRangeStart = 295162, XrefRangeEnd = 295164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ElementAssignment uwtqusBdUuePgtMazGSCicAXvohV()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeMethodInfoPtr_uwtqusBdUuePgtMazGSCicAXvohV_Public_ElementAssignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06005CA6 RID: 23718 RVA: 0x00023008 File Offset: 0x00021208
				public cdNJbuTSPXdvGUVYwnGxjYDbdAk(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001CC3 RID: 7363
				// (get) Token: 0x06005CA7 RID: 23719 RVA: 0x00195810 File Offset: 0x00193A10
				// (set) Token: 0x06005CA8 RID: 23720 RVA: 0x00023011 File Offset: 0x00021211
				public unsafe Player LJLpeqIMXIWQRJmTMPOerYeeqPn
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_LJLpeqIMXIWQRJmTMPOerYeeqPn);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_LJLpeqIMXIWQRJmTMPOerYeeqPn), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001CC4 RID: 7364
				// (get) Token: 0x06005CA9 RID: 23721 RVA: 0x00195840 File Offset: 0x00193A40
				// (set) Token: 0x06005CAA RID: 23722 RVA: 0x00023030 File Offset: 0x00021230
				public unsafe int HSNQHCcXgyznRFxfZdJonabrHRG
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG)) = value;
					}
				}

				// Token: 0x17001CC5 RID: 7365
				// (get) Token: 0x06005CAB RID: 23723 RVA: 0x00195868 File Offset: 0x00193A68
				// (set) Token: 0x06005CAC RID: 23724 RVA: 0x0002304B File Offset: 0x0002124B
				public unsafe InputMapper.Context OVUMNuhgFVnKkcJEIFsqfSKjHROk
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_OVUMNuhgFVnKkcJEIFsqfSKjHROk);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputMapper.Context>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_OVUMNuhgFVnKkcJEIFsqfSKjHROk), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001CC6 RID: 7366
				// (get) Token: 0x06005CAD RID: 23725 RVA: 0x00195898 File Offset: 0x00193A98
				// (set) Token: 0x06005CAE RID: 23726 RVA: 0x0002306A File Offset: 0x0002126A
				public unsafe ControllerType YgpbSyKqzywxZrpQdLClhHDXnpw
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw)) = value;
					}
				}

				// Token: 0x17001CC7 RID: 7367
				// (get) Token: 0x06005CAF RID: 23727 RVA: 0x001958C0 File Offset: 0x00193AC0
				// (set) Token: 0x06005CB0 RID: 23728 RVA: 0x00023085 File Offset: 0x00021285
				public unsafe int IfhnTjioRBhbGjEtsghiwZaIQGbU
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU)) = value;
					}
				}

				// Token: 0x17001CC8 RID: 7368
				// (get) Token: 0x06005CB1 RID: 23729 RVA: 0x001958E8 File Offset: 0x00193AE8
				// (set) Token: 0x06005CB2 RID: 23730 RVA: 0x000230A0 File Offset: 0x000212A0
				public ControllerPollingInfo QpOsFxYXoouZASuhyCyewBWyCTg
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_QpOsFxYXoouZASuhyCyewBWyCTg);
						return new ControllerPollingInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_QpOsFxYXoouZASuhyCyewBWyCTg), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17001CC9 RID: 7369
				// (get) Token: 0x06005CB3 RID: 23731 RVA: 0x00195918 File Offset: 0x00193B18
				// (set) Token: 0x06005CB4 RID: 23732 RVA: 0x000230CE File Offset: 0x000212CE
				public unsafe ModifierKeyFlags jguJLhLQrutwBBlfOhjkXhNEEqm
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_jguJLhLQrutwBBlfOhjkXhNEEqm);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.cdNJbuTSPXdvGUVYwnGxjYDbdAk.NativeFieldInfoPtr_jguJLhLQrutwBBlfOhjkXhNEEqm)) = value;
					}
				}

				// Token: 0x04004B96 RID: 19350
				private static readonly IntPtr NativeFieldInfoPtr_LJLpeqIMXIWQRJmTMPOerYeeqPn;

				// Token: 0x04004B97 RID: 19351
				private static readonly IntPtr NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG;

				// Token: 0x04004B98 RID: 19352
				private static readonly IntPtr NativeFieldInfoPtr_OVUMNuhgFVnKkcJEIFsqfSKjHROk;

				// Token: 0x04004B99 RID: 19353
				private static readonly IntPtr NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw;

				// Token: 0x04004B9A RID: 19354
				private static readonly IntPtr NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU;

				// Token: 0x04004B9B RID: 19355
				private static readonly IntPtr NativeFieldInfoPtr_QpOsFxYXoouZASuhyCyewBWyCTg;

				// Token: 0x04004B9C RID: 19356
				private static readonly IntPtr NativeFieldInfoPtr_jguJLhLQrutwBBlfOhjkXhNEEqm;

				// Token: 0x04004B9D RID: 19357
				private static readonly IntPtr NativeMethodInfoPtr_get_player_Public_get_Player_0;

				// Token: 0x04004B9E RID: 19358
				private static readonly IntPtr NativeMethodInfoPtr_get_actionId_Public_get_Int32_0;

				// Token: 0x04004B9F RID: 19359
				private static readonly IntPtr NativeMethodInfoPtr_get_mappingContext_Public_get_Context_0;

				// Token: 0x04004BA0 RID: 19360
				private static readonly IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;

				// Token: 0x04004BA1 RID: 19361
				private static readonly IntPtr NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0;

				// Token: 0x04004BA2 RID: 19362
				private static readonly IntPtr NativeMethodInfoPtr_get_pollingInfo_Public_get_ControllerPollingInfo_0;

				// Token: 0x04004BA3 RID: 19363
				private static readonly IntPtr NativeMethodInfoPtr_get_modifierKeyFlags_Public_get_ModifierKeyFlags_0;

				// Token: 0x04004BA4 RID: 19364
				private static readonly IntPtr NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0;

				// Token: 0x04004BA5 RID: 19365
				private static readonly IntPtr NativeMethodInfoPtr_get_elementName_Public_get_String_0;

				// Token: 0x04004BA6 RID: 19366
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04004BA7 RID: 19367
				private static readonly IntPtr NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Public_Void_Player_Context_0;

				// Token: 0x04004BA8 RID: 19368
				private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Void_0;

				// Token: 0x04004BA9 RID: 19369
				private static readonly IntPtr NativeMethodInfoPtr_uwtqusBdUuePgtMazGSCicAXvohV_Public_ElementAssignment_ControllerPollingInfo_0;

				// Token: 0x04004BAA RID: 19370
				private static readonly IntPtr NativeMethodInfoPtr_uwtqusBdUuePgtMazGSCicAXvohV_Public_ElementAssignment_ControllerPollingInfo_ModifierKeyFlags_0;

				// Token: 0x04004BAB RID: 19371
				private static readonly IntPtr NativeMethodInfoPtr_uwtqusBdUuePgtMazGSCicAXvohV_Public_ElementAssignment_0;
			}

			// Token: 0x02000576 RID: 1398
			private sealed class MethodInfoStoreGeneric_TOsmIyUnDbrAkvGgiejZqZWsQla_Private_Void_xmzqWiCayBPBPSZAElrMgoEAVbw_T_0<T>
			{
				// Token: 0x04004BAC RID: 19372
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG.NativeMethodInfoPtr_TOsmIyUnDbrAkvGgiejZqZWsQla_Private_Void_xmzqWiCayBPBPSZAElrMgoEAVbw_T_0, Il2CppClassPointerStore<InputMapper.SztVohOGHJfxAZjDLxgsTkhJblNG>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000389 RID: 905
		public class Options : Object
		{
			// Token: 0x06004A72 RID: 19058 RVA: 0x00154B80 File Offset: 0x00152D80
			// Note: this type is marked as 'beforefieldinit'.
			static Options()
			{
				Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputMapper>.NativeClassPtr, "Options");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr);
				InputMapper.Options.NativeFieldInfoPtr_byLLhIagZtvgZmWXPEkoqwrROQI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "byLLhIagZtvgZmWXPEkoqwrROQI");
				InputMapper.Options.NativeFieldInfoPtr_WgKZFutxrzsJdjjQKjNlzhIDvKq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "WgKZFutxrzsJdjjQKjNlzhIDvKq");
				InputMapper.Options.NativeFieldInfoPtr_QuDjKhulFnKcqAmhkGpcVnhTIQH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "QuDjKhulFnKcqAmhkGpcVnhTIQH");
				InputMapper.Options.NativeFieldInfoPtr_AGSiGOboMqycYwFkfmOHFfdUtiy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "AGSiGOboMqycYwFkfmOHFfdUtiy");
				InputMapper.Options.NativeFieldInfoPtr_zvOxGBBhYQpHEpdWvwOslwQvQIx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "zvOxGBBhYQpHEpdWvwOslwQvQIx");
				InputMapper.Options.NativeFieldInfoPtr_YqbFecIYEQgLQVYwpohDcyenGnoq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "YqbFecIYEQgLQVYwpohDcyenGnoq");
				InputMapper.Options.NativeFieldInfoPtr_maPsHdgWzRcOyBDCIUQsGjqVSZL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "maPsHdgWzRcOyBDCIUQsGjqVSZL");
				InputMapper.Options.NativeFieldInfoPtr_kOZBbEeYmCNUzwihSyIhNeKJENW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "kOZBbEeYmCNUzwihSyIhNeKJENW");
				InputMapper.Options.NativeFieldInfoPtr_iPRUpogMqeiaAoyhLsmJluKtUHn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "iPRUpogMqeiaAoyhLsmJluKtUHn");
				InputMapper.Options.NativeFieldInfoPtr_mNVKdsjImAzlviHtcwIxzVPyAUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "mNVKdsjImAzlviHtcwIxzVPyAUp");
				InputMapper.Options.NativeFieldInfoPtr_SZHYOomfPmyxVpysBsWXWjqvRjd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "SZHYOomfPmyxVpysBsWXWjqvRjd");
				InputMapper.Options.NativeFieldInfoPtr_DexOldNlgABIzenDNBqHKEWKZPrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "DexOldNlgABIzenDNBqHKEWKZPrs");
				InputMapper.Options.NativeFieldInfoPtr_jgfZTRopHHISclgLLGxTcUqbFaID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "jgfZTRopHHISclgLLGxTcUqbFaID");
				InputMapper.Options.NativeFieldInfoPtr_nJHJPqVpmpdvkWvHHUpuoXBGfQn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "nJHJPqVpmpdvkWvHHUpuoXBGfQn");
				InputMapper.Options.NativeFieldInfoPtr_cohcythyjJDSxlLvgFXRyklJQTHn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "cohcythyjJDSxlLvgFXRyklJQTHn");
				InputMapper.Options.NativeFieldInfoPtr_VWMRTKDkFcCzxdYZBtjIhegMVfpo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "VWMRTKDkFcCzxdYZBtjIhegMVfpo");
				InputMapper.Options.NativeFieldInfoPtr_ECMOFvQBpoMhjGrdgIWKnWiXLNu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "ECMOFvQBpoMhjGrdgIWKnWiXLNu");
				InputMapper.Options.NativeFieldInfoPtr_zuNGMHDJVmZxOQIvOINiGBrIRUq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, "zuNGMHDJVmZxOQIvOINiGBrIRUq");
				InputMapper.Options.NativeMethodInfoPtr_get_allowAxes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671820);
				InputMapper.Options.NativeMethodInfoPtr_set_allowAxes_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671821);
				InputMapper.Options.NativeMethodInfoPtr_get_allowButtons_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671822);
				InputMapper.Options.NativeMethodInfoPtr_set_allowButtons_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671823);
				InputMapper.Options.NativeMethodInfoPtr_get_allowButtonsOnFullAxisAssignment_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671824);
				InputMapper.Options.NativeMethodInfoPtr_set_allowButtonsOnFullAxisAssignment_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671825);
				InputMapper.Options.NativeMethodInfoPtr_get_timeout_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671826);
				InputMapper.Options.NativeMethodInfoPtr_set_timeout_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671827);
				InputMapper.Options.NativeMethodInfoPtr_get_checkForConflicts_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671828);
				InputMapper.Options.NativeMethodInfoPtr_set_checkForConflicts_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671829);
				InputMapper.Options.NativeMethodInfoPtr_get_checkForConflictsWithAllPlayers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671830);
				InputMapper.Options.NativeMethodInfoPtr_set_checkForConflictsWithAllPlayers_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671831);
				InputMapper.Options.NativeMethodInfoPtr_get_checkForConflictsWithSelf_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671832);
				InputMapper.Options.NativeMethodInfoPtr_set_checkForConflictsWithSelf_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671833);
				InputMapper.Options.NativeMethodInfoPtr_get_checkForConflictsWithSystemPlayer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671834);
				InputMapper.Options.NativeMethodInfoPtr_set_checkForConflictsWithSystemPlayer_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671835);
				InputMapper.Options.NativeMethodInfoPtr_get_checkForConflictsWithPlayerIds_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671836);
				InputMapper.Options.NativeMethodInfoPtr_set_checkForConflictsWithPlayerIds_Public_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671837);
				InputMapper.Options.NativeMethodInfoPtr_get_defaultActionWhenConflictFound_Public_get_ConflictResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671838);
				InputMapper.Options.NativeMethodInfoPtr_set_defaultActionWhenConflictFound_Public_set_Void_ConflictResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671839);
				InputMapper.Options.NativeMethodInfoPtr_get_ignoreMouseXAxis_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671840);
				InputMapper.Options.NativeMethodInfoPtr_set_ignoreMouseXAxis_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671841);
				InputMapper.Options.NativeMethodInfoPtr_get_ignoreMouseYAxis_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671842);
				InputMapper.Options.NativeMethodInfoPtr_set_ignoreMouseYAxis_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671843);
				InputMapper.Options.NativeMethodInfoPtr_get_allowKeyboardKeysWithModifiers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671844);
				InputMapper.Options.NativeMethodInfoPtr_set_allowKeyboardKeysWithModifiers_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671845);
				InputMapper.Options.NativeMethodInfoPtr_get_allowKeyboardModifierKeyAsPrimary_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671846);
				InputMapper.Options.NativeMethodInfoPtr_set_allowKeyboardModifierKeyAsPrimary_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671847);
				InputMapper.Options.NativeMethodInfoPtr_get_holdDurationToMapKeyboardModifierKeyAsPrimary_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671848);
				InputMapper.Options.NativeMethodInfoPtr_set_holdDurationToMapKeyboardModifierKeyAsPrimary_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671849);
				InputMapper.Options.NativeMethodInfoPtr_get_isElementAllowedCallback_Public_get_Predicate_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671850);
				InputMapper.Options.NativeMethodInfoPtr_set_isElementAllowedCallback_Public_set_Void_Predicate_1_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671851);
				InputMapper.Options.NativeMethodInfoPtr_GiKHMSCiUGoKjASphAZMVOQMgNX_Internal_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671852);
				InputMapper.Options.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671853);
				InputMapper.Options.NativeMethodInfoPtr__ctor_Private_Void_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671854);
				InputMapper.Options.NativeMethodInfoPtr_Clone_Public_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671855);
				InputMapper.Options.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671856);
				InputMapper.Options.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671857);
				InputMapper.Options.NativeMethodInfoPtr_Copy_Public_Static_Void_Options_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671858);
				InputMapper.Options.NativeMethodInfoPtr_sqXhOImXGlbBcqwsGJcFXDBkIkD_Private_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr, 100671859);
			}

			// Token: 0x1700175E RID: 5982
			// (get) Token: 0x06004A73 RID: 19059 RVA: 0x00155034 File Offset: 0x00153234
			// (set) Token: 0x06004A74 RID: 19060 RVA: 0x00155070 File Offset: 0x00153270
			public unsafe bool allowAxes
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_get_allowAxes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_set_allowAxes_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700175F RID: 5983
			// (get) Token: 0x06004A75 RID: 19061 RVA: 0x001550B0 File Offset: 0x001532B0
			// (set) Token: 0x06004A76 RID: 19062 RVA: 0x001550EC File Offset: 0x001532EC
			public unsafe bool allowButtons
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_get_allowButtons_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_set_allowButtons_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001760 RID: 5984
			// (get) Token: 0x06004A77 RID: 19063 RVA: 0x0015512C File Offset: 0x0015332C
			// (set) Token: 0x06004A78 RID: 19064 RVA: 0x00155168 File Offset: 0x00153368
			public unsafe bool allowButtonsOnFullAxisAssignment
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_get_allowButtonsOnFullAxisAssignment_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_set_allowButtonsOnFullAxisAssignment_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001761 RID: 5985
			// (get) Token: 0x06004A79 RID: 19065 RVA: 0x001551A8 File Offset: 0x001533A8
			// (set) Token: 0x06004A7A RID: 19066 RVA: 0x001551E4 File Offset: 0x001533E4
			public unsafe float timeout
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_get_timeout_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_set_timeout_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001762 RID: 5986
			// (get) Token: 0x06004A7B RID: 19067 RVA: 0x00155224 File Offset: 0x00153424
			// (set) Token: 0x06004A7C RID: 19068 RVA: 0x00155260 File Offset: 0x00153460
			public unsafe bool checkForConflicts
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_get_checkForConflicts_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_set_checkForConflicts_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001763 RID: 5987
			// (get) Token: 0x06004A7D RID: 19069 RVA: 0x001552A0 File Offset: 0x001534A0
			// (set) Token: 0x06004A7E RID: 19070 RVA: 0x001552DC File Offset: 0x001534DC
			public unsafe bool checkForConflictsWithAllPlayers
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_get_checkForConflictsWithAllPlayers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_set_checkForConflictsWithAllPlayers_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001764 RID: 5988
			// (get) Token: 0x06004A7F RID: 19071 RVA: 0x0015531C File Offset: 0x0015351C
			// (set) Token: 0x06004A80 RID: 19072 RVA: 0x00155358 File Offset: 0x00153558
			public unsafe bool checkForConflictsWithSelf
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_get_checkForConflictsWithSelf_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_set_checkForConflictsWithSelf_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001765 RID: 5989
			// (get) Token: 0x06004A81 RID: 19073 RVA: 0x00155398 File Offset: 0x00153598
			// (set) Token: 0x06004A82 RID: 19074 RVA: 0x001553D4 File Offset: 0x001535D4
			public unsafe bool checkForConflictsWithSystemPlayer
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_get_checkForConflictsWithSystemPlayer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_set_checkForConflictsWithSystemPlayer_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001766 RID: 5990
			// (get) Token: 0x06004A83 RID: 19075 RVA: 0x00155414 File Offset: 0x00153614
			// (set) Token: 0x06004A84 RID: 19076 RVA: 0x00155454 File Offset: 0x00153654
			public unsafe Il2CppStructArray<int> checkForConflictsWithPlayerIds
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_get_checkForConflictsWithPlayerIds_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
				}
				[CallerCount(33)]
				[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_set_checkForConflictsWithPlayerIds_Public_set_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001767 RID: 5991
			// (get) Token: 0x06004A85 RID: 19077 RVA: 0x00155498 File Offset: 0x00153698
			// (set) Token: 0x06004A86 RID: 19078 RVA: 0x001554D4 File Offset: 0x001536D4
			public unsafe InputMapper.ConflictResponse defaultActionWhenConflictFound
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_get_defaultActionWhenConflictFound_Public_get_ConflictResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_set_defaultActionWhenConflictFound_Public_set_Void_ConflictResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001768 RID: 5992
			// (get) Token: 0x06004A87 RID: 19079 RVA: 0x00155514 File Offset: 0x00153714
			// (set) Token: 0x06004A88 RID: 19080 RVA: 0x00155550 File Offset: 0x00153750
			public unsafe bool ignoreMouseXAxis
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_get_ignoreMouseXAxis_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_set_ignoreMouseXAxis_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001769 RID: 5993
			// (get) Token: 0x06004A89 RID: 19081 RVA: 0x00155590 File Offset: 0x00153790
			// (set) Token: 0x06004A8A RID: 19082 RVA: 0x001555CC File Offset: 0x001537CC
			public unsafe bool ignoreMouseYAxis
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_get_ignoreMouseYAxis_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_set_ignoreMouseYAxis_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700176A RID: 5994
			// (get) Token: 0x06004A8B RID: 19083 RVA: 0x0015560C File Offset: 0x0015380C
			// (set) Token: 0x06004A8C RID: 19084 RVA: 0x00155648 File Offset: 0x00153848
			public unsafe bool allowKeyboardKeysWithModifiers
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_get_allowKeyboardKeysWithModifiers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_set_allowKeyboardKeysWithModifiers_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700176B RID: 5995
			// (get) Token: 0x06004A8D RID: 19085 RVA: 0x00155688 File Offset: 0x00153888
			// (set) Token: 0x06004A8E RID: 19086 RVA: 0x001556C4 File Offset: 0x001538C4
			public unsafe bool allowKeyboardModifierKeyAsPrimary
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_get_allowKeyboardModifierKeyAsPrimary_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_set_allowKeyboardModifierKeyAsPrimary_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700176C RID: 5996
			// (get) Token: 0x06004A8F RID: 19087 RVA: 0x00155704 File Offset: 0x00153904
			// (set) Token: 0x06004A90 RID: 19088 RVA: 0x00155740 File Offset: 0x00153940
			public unsafe float holdDurationToMapKeyboardModifierKeyAsPrimary
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_get_holdDurationToMapKeyboardModifierKeyAsPrimary_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_set_holdDurationToMapKeyboardModifierKeyAsPrimary_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700176D RID: 5997
			// (get) Token: 0x06004A91 RID: 19089 RVA: 0x00155780 File Offset: 0x00153980
			// (set) Token: 0x06004A92 RID: 19090 RVA: 0x001557C0 File Offset: 0x001539C0
			public unsafe Predicate<ControllerPollingInfo> isElementAllowedCallback
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295707, XrefRangeEnd = 295718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_get_isElementAllowedCallback_Public_get_Predicate_1_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Predicate<ControllerPollingInfo>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295718, XrefRangeEnd = 295743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_set_isElementAllowedCallback_Public_set_Void_Predicate_1_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004A93 RID: 19091 RVA: 0x00155804 File Offset: 0x00153A04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295743, XrefRangeEnd = 295750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T GiKHMSCiUGoKjASphAZMVOQMgNX<T>(string A_1) where T : SafeDelegate
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.MethodInfoStoreGeneric_GiKHMSCiUGoKjASphAZMVOQMgNX_Internal_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06004A94 RID: 19092 RVA: 0x00155850 File Offset: 0x00153A50
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 295761, RefRangeEnd = 295764, XrefRangeStart = 295750, XrefRangeEnd = 295761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Options()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A95 RID: 19093 RVA: 0x0015588C File Offset: 0x00153A8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295764, XrefRangeEnd = 295781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Options(InputMapper.Options source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr__ctor_Private_Void_Options_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A96 RID: 19094 RVA: 0x001558D8 File Offset: 0x00153AD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295781, XrefRangeEnd = 295794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputMapper.Options Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_Clone_Public_Options_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputMapper.Options>(intPtr3) : null;
			}

			// Token: 0x06004A97 RID: 19095 RVA: 0x00155918 File Offset: 0x00153B18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295794, XrefRangeEnd = 295958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputMapper.Options.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06004A98 RID: 19096 RVA: 0x0015595C File Offset: 0x00153B5C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 295977, RefRangeEnd = 295979, XrefRangeStart = 295958, XrefRangeEnd = 295977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GMFpQqtyJcjzYToWCrZsZQAhPYh()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A99 RID: 19097 RVA: 0x00155990 File Offset: 0x00153B90
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 295999, RefRangeEnd = 296002, XrefRangeStart = 295979, XrefRangeEnd = 295999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Copy(InputMapper.Options source, InputMapper.Options destination)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_Copy_Public_Static_Void_Options_Options_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A9A RID: 19098 RVA: 0x001559D8 File Offset: 0x00153BD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296002, XrefRangeEnd = 296008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void sqXhOImXGlbBcqwsGJcFXDBkIkD(Exception A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapper.Options.NativeMethodInfoPtr_sqXhOImXGlbBcqwsGJcFXDBkIkD_Private_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A9B RID: 19099 RVA: 0x0001B67F File Offset: 0x0001987F
			public Options(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700174C RID: 5964
			// (get) Token: 0x06004A9C RID: 19100 RVA: 0x00155A10 File Offset: 0x00153C10
			// (set) Token: 0x06004A9D RID: 19101 RVA: 0x0001B688 File Offset: 0x00019888
			public unsafe static string byLLhIagZtvgZmWXPEkoqwrROQI
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InputMapper.Options.NativeFieldInfoPtr_byLLhIagZtvgZmWXPEkoqwrROQI, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InputMapper.Options.NativeFieldInfoPtr_byLLhIagZtvgZmWXPEkoqwrROQI, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700174D RID: 5965
			// (get) Token: 0x06004A9E RID: 19102 RVA: 0x00155A30 File Offset: 0x00153C30
			// (set) Token: 0x06004A9F RID: 19103 RVA: 0x0001B69A File Offset: 0x0001989A
			public unsafe bool WgKZFutxrzsJdjjQKjNlzhIDvKq
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_WgKZFutxrzsJdjjQKjNlzhIDvKq);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_WgKZFutxrzsJdjjQKjNlzhIDvKq)) = value;
				}
			}

			// Token: 0x1700174E RID: 5966
			// (get) Token: 0x06004AA0 RID: 19104 RVA: 0x00155A58 File Offset: 0x00153C58
			// (set) Token: 0x06004AA1 RID: 19105 RVA: 0x0001B6B5 File Offset: 0x000198B5
			public unsafe bool QuDjKhulFnKcqAmhkGpcVnhTIQH
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_QuDjKhulFnKcqAmhkGpcVnhTIQH);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_QuDjKhulFnKcqAmhkGpcVnhTIQH)) = value;
				}
			}

			// Token: 0x1700174F RID: 5967
			// (get) Token: 0x06004AA2 RID: 19106 RVA: 0x00155A80 File Offset: 0x00153C80
			// (set) Token: 0x06004AA3 RID: 19107 RVA: 0x0001B6D0 File Offset: 0x000198D0
			public unsafe bool AGSiGOboMqycYwFkfmOHFfdUtiy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_AGSiGOboMqycYwFkfmOHFfdUtiy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_AGSiGOboMqycYwFkfmOHFfdUtiy)) = value;
				}
			}

			// Token: 0x17001750 RID: 5968
			// (get) Token: 0x06004AA4 RID: 19108 RVA: 0x00155AA8 File Offset: 0x00153CA8
			// (set) Token: 0x06004AA5 RID: 19109 RVA: 0x0001B6EB File Offset: 0x000198EB
			public unsafe float zvOxGBBhYQpHEpdWvwOslwQvQIx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_zvOxGBBhYQpHEpdWvwOslwQvQIx);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_zvOxGBBhYQpHEpdWvwOslwQvQIx)) = value;
				}
			}

			// Token: 0x17001751 RID: 5969
			// (get) Token: 0x06004AA6 RID: 19110 RVA: 0x00155AD0 File Offset: 0x00153CD0
			// (set) Token: 0x06004AA7 RID: 19111 RVA: 0x0001B706 File Offset: 0x00019906
			public unsafe bool YqbFecIYEQgLQVYwpohDcyenGnoq
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_YqbFecIYEQgLQVYwpohDcyenGnoq);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_YqbFecIYEQgLQVYwpohDcyenGnoq)) = value;
				}
			}

			// Token: 0x17001752 RID: 5970
			// (get) Token: 0x06004AA8 RID: 19112 RVA: 0x00155AF8 File Offset: 0x00153CF8
			// (set) Token: 0x06004AA9 RID: 19113 RVA: 0x0001B721 File Offset: 0x00019921
			public unsafe bool maPsHdgWzRcOyBDCIUQsGjqVSZL
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_maPsHdgWzRcOyBDCIUQsGjqVSZL);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_maPsHdgWzRcOyBDCIUQsGjqVSZL)) = value;
				}
			}

			// Token: 0x17001753 RID: 5971
			// (get) Token: 0x06004AAA RID: 19114 RVA: 0x00155B20 File Offset: 0x00153D20
			// (set) Token: 0x06004AAB RID: 19115 RVA: 0x0001B73C File Offset: 0x0001993C
			public unsafe bool kOZBbEeYmCNUzwihSyIhNeKJENW
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_kOZBbEeYmCNUzwihSyIhNeKJENW);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_kOZBbEeYmCNUzwihSyIhNeKJENW)) = value;
				}
			}

			// Token: 0x17001754 RID: 5972
			// (get) Token: 0x06004AAC RID: 19116 RVA: 0x00155B48 File Offset: 0x00153D48
			// (set) Token: 0x06004AAD RID: 19117 RVA: 0x0001B757 File Offset: 0x00019957
			public unsafe bool iPRUpogMqeiaAoyhLsmJluKtUHn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_iPRUpogMqeiaAoyhLsmJluKtUHn);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_iPRUpogMqeiaAoyhLsmJluKtUHn)) = value;
				}
			}

			// Token: 0x17001755 RID: 5973
			// (get) Token: 0x06004AAE RID: 19118 RVA: 0x00155B70 File Offset: 0x00153D70
			// (set) Token: 0x06004AAF RID: 19119 RVA: 0x0001B772 File Offset: 0x00019972
			public unsafe Il2CppStructArray<int> mNVKdsjImAzlviHtcwIxzVPyAUp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_mNVKdsjImAzlviHtcwIxzVPyAUp);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_mNVKdsjImAzlviHtcwIxzVPyAUp), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001756 RID: 5974
			// (get) Token: 0x06004AB0 RID: 19120 RVA: 0x00155BA0 File Offset: 0x00153DA0
			// (set) Token: 0x06004AB1 RID: 19121 RVA: 0x0001B791 File Offset: 0x00019991
			public unsafe InputMapper.ConflictResponse SZHYOomfPmyxVpysBsWXWjqvRjd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_SZHYOomfPmyxVpysBsWXWjqvRjd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_SZHYOomfPmyxVpysBsWXWjqvRjd)) = value;
				}
			}

			// Token: 0x17001757 RID: 5975
			// (get) Token: 0x06004AB2 RID: 19122 RVA: 0x00155BC8 File Offset: 0x00153DC8
			// (set) Token: 0x06004AB3 RID: 19123 RVA: 0x0001B7AC File Offset: 0x000199AC
			public unsafe bool DexOldNlgABIzenDNBqHKEWKZPrs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_DexOldNlgABIzenDNBqHKEWKZPrs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_DexOldNlgABIzenDNBqHKEWKZPrs)) = value;
				}
			}

			// Token: 0x17001758 RID: 5976
			// (get) Token: 0x06004AB4 RID: 19124 RVA: 0x00155BF0 File Offset: 0x00153DF0
			// (set) Token: 0x06004AB5 RID: 19125 RVA: 0x0001B7C7 File Offset: 0x000199C7
			public unsafe bool jgfZTRopHHISclgLLGxTcUqbFaID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_jgfZTRopHHISclgLLGxTcUqbFaID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_jgfZTRopHHISclgLLGxTcUqbFaID)) = value;
				}
			}

			// Token: 0x17001759 RID: 5977
			// (get) Token: 0x06004AB6 RID: 19126 RVA: 0x00155C18 File Offset: 0x00153E18
			// (set) Token: 0x06004AB7 RID: 19127 RVA: 0x0001B7E2 File Offset: 0x000199E2
			public unsafe bool nJHJPqVpmpdvkWvHHUpuoXBGfQn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_nJHJPqVpmpdvkWvHHUpuoXBGfQn);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_nJHJPqVpmpdvkWvHHUpuoXBGfQn)) = value;
				}
			}

			// Token: 0x1700175A RID: 5978
			// (get) Token: 0x06004AB8 RID: 19128 RVA: 0x00155C40 File Offset: 0x00153E40
			// (set) Token: 0x06004AB9 RID: 19129 RVA: 0x0001B7FD File Offset: 0x000199FD
			public unsafe bool cohcythyjJDSxlLvgFXRyklJQTHn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_cohcythyjJDSxlLvgFXRyklJQTHn);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_cohcythyjJDSxlLvgFXRyklJQTHn)) = value;
				}
			}

			// Token: 0x1700175B RID: 5979
			// (get) Token: 0x06004ABA RID: 19130 RVA: 0x00155C68 File Offset: 0x00153E68
			// (set) Token: 0x06004ABB RID: 19131 RVA: 0x0001B818 File Offset: 0x00019A18
			public unsafe float VWMRTKDkFcCzxdYZBtjIhegMVfpo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_VWMRTKDkFcCzxdYZBtjIhegMVfpo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_VWMRTKDkFcCzxdYZBtjIhegMVfpo)) = value;
				}
			}

			// Token: 0x1700175C RID: 5980
			// (get) Token: 0x06004ABC RID: 19132 RVA: 0x00155C90 File Offset: 0x00153E90
			// (set) Token: 0x06004ABD RID: 19133 RVA: 0x0001B833 File Offset: 0x00019A33
			public unsafe Dictionary<string, SafeDelegate> ECMOFvQBpoMhjGrdgIWKnWiXLNu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_ECMOFvQBpoMhjGrdgIWKnWiXLNu);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SafeDelegate>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapper.Options.NativeFieldInfoPtr_ECMOFvQBpoMhjGrdgIWKnWiXLNu), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700175D RID: 5981
			// (get) Token: 0x06004ABE RID: 19134 RVA: 0x00155CC0 File Offset: 0x00153EC0
			// (set) Token: 0x06004ABF RID: 19135 RVA: 0x0001B852 File Offset: 0x00019A52
			public unsafe static Action<Exception> zuNGMHDJVmZxOQIvOINiGBrIRUq
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InputMapper.Options.NativeFieldInfoPtr_zuNGMHDJVmZxOQIvOINiGBrIRUq, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Exception>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InputMapper.Options.NativeFieldInfoPtr_zuNGMHDJVmZxOQIvOINiGBrIRUq, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C41 RID: 15425
			private static readonly IntPtr NativeFieldInfoPtr_byLLhIagZtvgZmWXPEkoqwrROQI;

			// Token: 0x04003C42 RID: 15426
			private static readonly IntPtr NativeFieldInfoPtr_WgKZFutxrzsJdjjQKjNlzhIDvKq;

			// Token: 0x04003C43 RID: 15427
			private static readonly IntPtr NativeFieldInfoPtr_QuDjKhulFnKcqAmhkGpcVnhTIQH;

			// Token: 0x04003C44 RID: 15428
			private static readonly IntPtr NativeFieldInfoPtr_AGSiGOboMqycYwFkfmOHFfdUtiy;

			// Token: 0x04003C45 RID: 15429
			private static readonly IntPtr NativeFieldInfoPtr_zvOxGBBhYQpHEpdWvwOslwQvQIx;

			// Token: 0x04003C46 RID: 15430
			private static readonly IntPtr NativeFieldInfoPtr_YqbFecIYEQgLQVYwpohDcyenGnoq;

			// Token: 0x04003C47 RID: 15431
			private static readonly IntPtr NativeFieldInfoPtr_maPsHdgWzRcOyBDCIUQsGjqVSZL;

			// Token: 0x04003C48 RID: 15432
			private static readonly IntPtr NativeFieldInfoPtr_kOZBbEeYmCNUzwihSyIhNeKJENW;

			// Token: 0x04003C49 RID: 15433
			private static readonly IntPtr NativeFieldInfoPtr_iPRUpogMqeiaAoyhLsmJluKtUHn;

			// Token: 0x04003C4A RID: 15434
			private static readonly IntPtr NativeFieldInfoPtr_mNVKdsjImAzlviHtcwIxzVPyAUp;

			// Token: 0x04003C4B RID: 15435
			private static readonly IntPtr NativeFieldInfoPtr_SZHYOomfPmyxVpysBsWXWjqvRjd;

			// Token: 0x04003C4C RID: 15436
			private static readonly IntPtr NativeFieldInfoPtr_DexOldNlgABIzenDNBqHKEWKZPrs;

			// Token: 0x04003C4D RID: 15437
			private static readonly IntPtr NativeFieldInfoPtr_jgfZTRopHHISclgLLGxTcUqbFaID;

			// Token: 0x04003C4E RID: 15438
			private static readonly IntPtr NativeFieldInfoPtr_nJHJPqVpmpdvkWvHHUpuoXBGfQn;

			// Token: 0x04003C4F RID: 15439
			private static readonly IntPtr NativeFieldInfoPtr_cohcythyjJDSxlLvgFXRyklJQTHn;

			// Token: 0x04003C50 RID: 15440
			private static readonly IntPtr NativeFieldInfoPtr_VWMRTKDkFcCzxdYZBtjIhegMVfpo;

			// Token: 0x04003C51 RID: 15441
			private static readonly IntPtr NativeFieldInfoPtr_ECMOFvQBpoMhjGrdgIWKnWiXLNu;

			// Token: 0x04003C52 RID: 15442
			private static readonly IntPtr NativeFieldInfoPtr_zuNGMHDJVmZxOQIvOINiGBrIRUq;

			// Token: 0x04003C53 RID: 15443
			private static readonly IntPtr NativeMethodInfoPtr_get_allowAxes_Public_get_Boolean_0;

			// Token: 0x04003C54 RID: 15444
			private static readonly IntPtr NativeMethodInfoPtr_set_allowAxes_Public_set_Void_Boolean_0;

			// Token: 0x04003C55 RID: 15445
			private static readonly IntPtr NativeMethodInfoPtr_get_allowButtons_Public_get_Boolean_0;

			// Token: 0x04003C56 RID: 15446
			private static readonly IntPtr NativeMethodInfoPtr_set_allowButtons_Public_set_Void_Boolean_0;

			// Token: 0x04003C57 RID: 15447
			private static readonly IntPtr NativeMethodInfoPtr_get_allowButtonsOnFullAxisAssignment_Public_get_Boolean_0;

			// Token: 0x04003C58 RID: 15448
			private static readonly IntPtr NativeMethodInfoPtr_set_allowButtonsOnFullAxisAssignment_Public_set_Void_Boolean_0;

			// Token: 0x04003C59 RID: 15449
			private static readonly IntPtr NativeMethodInfoPtr_get_timeout_Public_get_Single_0;

			// Token: 0x04003C5A RID: 15450
			private static readonly IntPtr NativeMethodInfoPtr_set_timeout_Public_set_Void_Single_0;

			// Token: 0x04003C5B RID: 15451
			private static readonly IntPtr NativeMethodInfoPtr_get_checkForConflicts_Public_get_Boolean_0;

			// Token: 0x04003C5C RID: 15452
			private static readonly IntPtr NativeMethodInfoPtr_set_checkForConflicts_Public_set_Void_Boolean_0;

			// Token: 0x04003C5D RID: 15453
			private static readonly IntPtr NativeMethodInfoPtr_get_checkForConflictsWithAllPlayers_Public_get_Boolean_0;

			// Token: 0x04003C5E RID: 15454
			private static readonly IntPtr NativeMethodInfoPtr_set_checkForConflictsWithAllPlayers_Public_set_Void_Boolean_0;

			// Token: 0x04003C5F RID: 15455
			private static readonly IntPtr NativeMethodInfoPtr_get_checkForConflictsWithSelf_Public_get_Boolean_0;

			// Token: 0x04003C60 RID: 15456
			private static readonly IntPtr NativeMethodInfoPtr_set_checkForConflictsWithSelf_Public_set_Void_Boolean_0;

			// Token: 0x04003C61 RID: 15457
			private static readonly IntPtr NativeMethodInfoPtr_get_checkForConflictsWithSystemPlayer_Public_get_Boolean_0;

			// Token: 0x04003C62 RID: 15458
			private static readonly IntPtr NativeMethodInfoPtr_set_checkForConflictsWithSystemPlayer_Public_set_Void_Boolean_0;

			// Token: 0x04003C63 RID: 15459
			private static readonly IntPtr NativeMethodInfoPtr_get_checkForConflictsWithPlayerIds_Public_get_Il2CppStructArray_1_Int32_0;

			// Token: 0x04003C64 RID: 15460
			private static readonly IntPtr NativeMethodInfoPtr_set_checkForConflictsWithPlayerIds_Public_set_Void_Il2CppStructArray_1_Int32_0;

			// Token: 0x04003C65 RID: 15461
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultActionWhenConflictFound_Public_get_ConflictResponse_0;

			// Token: 0x04003C66 RID: 15462
			private static readonly IntPtr NativeMethodInfoPtr_set_defaultActionWhenConflictFound_Public_set_Void_ConflictResponse_0;

			// Token: 0x04003C67 RID: 15463
			private static readonly IntPtr NativeMethodInfoPtr_get_ignoreMouseXAxis_Public_get_Boolean_0;

			// Token: 0x04003C68 RID: 15464
			private static readonly IntPtr NativeMethodInfoPtr_set_ignoreMouseXAxis_Public_set_Void_Boolean_0;

			// Token: 0x04003C69 RID: 15465
			private static readonly IntPtr NativeMethodInfoPtr_get_ignoreMouseYAxis_Public_get_Boolean_0;

			// Token: 0x04003C6A RID: 15466
			private static readonly IntPtr NativeMethodInfoPtr_set_ignoreMouseYAxis_Public_set_Void_Boolean_0;

			// Token: 0x04003C6B RID: 15467
			private static readonly IntPtr NativeMethodInfoPtr_get_allowKeyboardKeysWithModifiers_Public_get_Boolean_0;

			// Token: 0x04003C6C RID: 15468
			private static readonly IntPtr NativeMethodInfoPtr_set_allowKeyboardKeysWithModifiers_Public_set_Void_Boolean_0;

			// Token: 0x04003C6D RID: 15469
			private static readonly IntPtr NativeMethodInfoPtr_get_allowKeyboardModifierKeyAsPrimary_Public_get_Boolean_0;

			// Token: 0x04003C6E RID: 15470
			private static readonly IntPtr NativeMethodInfoPtr_set_allowKeyboardModifierKeyAsPrimary_Public_set_Void_Boolean_0;

			// Token: 0x04003C6F RID: 15471
			private static readonly IntPtr NativeMethodInfoPtr_get_holdDurationToMapKeyboardModifierKeyAsPrimary_Public_get_Single_0;

			// Token: 0x04003C70 RID: 15472
			private static readonly IntPtr NativeMethodInfoPtr_set_holdDurationToMapKeyboardModifierKeyAsPrimary_Public_set_Void_Single_0;

			// Token: 0x04003C71 RID: 15473
			private static readonly IntPtr NativeMethodInfoPtr_get_isElementAllowedCallback_Public_get_Predicate_1_ControllerPollingInfo_0;

			// Token: 0x04003C72 RID: 15474
			private static readonly IntPtr NativeMethodInfoPtr_set_isElementAllowedCallback_Public_set_Void_Predicate_1_ControllerPollingInfo_0;

			// Token: 0x04003C73 RID: 15475
			private static readonly IntPtr NativeMethodInfoPtr_GiKHMSCiUGoKjASphAZMVOQMgNX_Internal_T_String_0;

			// Token: 0x04003C74 RID: 15476
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003C75 RID: 15477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Options_0;

			// Token: 0x04003C76 RID: 15478
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Options_0;

			// Token: 0x04003C77 RID: 15479
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04003C78 RID: 15480
			private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Void_0;

			// Token: 0x04003C79 RID: 15481
			private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Options_Options_0;

			// Token: 0x04003C7A RID: 15482
			private static readonly IntPtr NativeMethodInfoPtr_sqXhOImXGlbBcqwsGJcFXDBkIkD_Private_Static_Void_Exception_0;

			// Token: 0x02000577 RID: 1399
			private sealed class MethodInfoStoreGeneric_GiKHMSCiUGoKjASphAZMVOQMgNX_Internal_T_String_0<T>
			{
				// Token: 0x04004BAD RID: 19373
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(InputMapper.Options.NativeMethodInfoPtr_GiKHMSCiUGoKjASphAZMVOQMgNX_Internal_T_String_0, Il2CppClassPointerStore<InputMapper.Options>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}
	}
}
