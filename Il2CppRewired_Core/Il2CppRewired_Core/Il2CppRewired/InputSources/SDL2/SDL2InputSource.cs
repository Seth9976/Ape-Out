using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Config;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppRewired.InputSources.SDL2
{
	// Token: 0x020001AA RID: 426
	public class SDL2InputSource : Object
	{
		// Token: 0x06002BBE RID: 11198 RVA: 0x000D98A0 File Offset: 0x000D7AA0
		// Note: this type is marked as 'beforefieldinit'.
		static SDL2InputSource()
		{
			Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.InputSources.SDL2", "SDL2InputSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr);
			SDL2InputSource.NativeFieldInfoPtr_CYHSmvVCpXjzThqDQUWMonBKDfYl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, "CYHSmvVCpXjzThqDQUWMonBKDfYl");
			SDL2InputSource.NativeFieldInfoPtr_QRhIyOMbbMFaviRtQmklePdGWlGz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, "QRhIyOMbbMFaviRtQmklePdGWlGz");
			SDL2InputSource.NativeFieldInfoPtr_RWldjYOQKWvHFADHbFNnuREdvaD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, "RWldjYOQKWvHFADHbFNnuREdvaD");
			SDL2InputSource.NativeFieldInfoPtr_ggrfrcaPhHHrQaXRiZHRPmQAGsJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, "ggrfrcaPhHHrQaXRiZHRPmQAGsJ");
			SDL2InputSource.NativeFieldInfoPtr_BXArBotmYcIIVbnpXVwfDahshnch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, "BXArBotmYcIIVbnpXVwfDahshnch");
			SDL2InputSource.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, "cyyBkkdxKBBsyXCzMlRPgcvSIBjT");
			SDL2InputSource.NativeFieldInfoPtr_fHwvAEhSaXstIllfGXDtviCPUrg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, "fHwvAEhSaXstIllfGXDtviCPUrg");
			SDL2InputSource.NativeFieldInfoPtr_DvSRXSxiKkaailUlYQGYMwHLOkf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, "DvSRXSxiKkaailUlYQGYMwHLOkf");
			SDL2InputSource.NativeFieldInfoPtr_wTXEvzDishJeydrbNslIvVMBXAy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, "wTXEvzDishJeydrbNslIvVMBXAy");
			SDL2InputSource.NativeFieldInfoPtr_PILJADqUYXlZLNkhppmaluzzoMq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, "PILJADqUYXlZLNkhppmaluzzoMq");
			SDL2InputSource.NativeFieldInfoPtr_BdkcSSpIMpNctcqRGtWgHezNhVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, "BdkcSSpIMpNctcqRGtWgHezNhVs");
			SDL2InputSource.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
			SDL2InputSource.NativeMethodInfoPtr_get_initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674621);
			SDL2InputSource.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674622);
			SDL2InputSource.NativeMethodInfoPtr_add__DeviceChangedEvent_Private_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674623);
			SDL2InputSource.NativeMethodInfoPtr_remove__DeviceChangedEvent_Private_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674624);
			SDL2InputSource.NativeMethodInfoPtr_add_DeviceChangedEvent_Public_Virtual_Final_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674625);
			SDL2InputSource.NativeMethodInfoPtr_remove_DeviceChangedEvent_Public_Virtual_Final_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674626);
			SDL2InputSource.NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674627);
			SDL2InputSource.NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674628);
			SDL2InputSource.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674629);
			SDL2InputSource.NativeMethodInfoPtr_UpdateDevices_Public_Virtual_Final_New_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674630);
			SDL2InputSource.NativeMethodInfoPtr_UpdateFinished_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674631);
			SDL2InputSource.NativeMethodInfoPtr_GetJoysticks_Public_Virtual_Final_New_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674632);
			SDL2InputSource.NativeMethodInfoPtr_RntVfvanzkYpGPWnuexfFARqyqE_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674633);
			SDL2InputSource.NativeMethodInfoPtr_JUKPSPLtOuPczUittYVIDPhYwYP_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674634);
			SDL2InputSource.NativeMethodInfoPtr_gUbeaqEWdhGXDRqpZjzchsKZOrOD_Private_VcgaqAPARubixeQXnHQhlksdPyqf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674635);
			SDL2InputSource.NativeMethodInfoPtr_EMUkyAOTnqOyAPanUxmYQPLHAEN_Private_hreiwttkoBQlMwGESjPdQGifGUW_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674636);
			SDL2InputSource.NativeMethodInfoPtr_rtzKdXSkgxexpjJFzBbnhmDJkmfE_Private_ilRJkluDUSPPcKRydmoYznciuvi_Int32_MAhEpNnfHVJXeDzbLwATgncxHhBK_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674637);
			SDL2InputSource.NativeMethodInfoPtr_dtIGWpMNPXMASSrJCjEsjOiffWVi_Private_ilRJkluDUSPPcKRydmoYznciuvi_Int32_JuWdVmrYhDjDMoIxmEvznniBSmG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674638);
			SDL2InputSource.NativeMethodInfoPtr_xuPDyzFmYFlFlDsYyPPMkkMdimH_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674639);
			SDL2InputSource.NativeMethodInfoPtr_PmCcIQTdelidXfDwWtZLTrwwwvk_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674640);
			SDL2InputSource.NativeMethodInfoPtr_efxtIhaaqCboFagRjGZREAdxtESW_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674641);
			SDL2InputSource.NativeMethodInfoPtr_UkAtyzMCaredYaLMOpeGuRNkMlQd_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674642);
			SDL2InputSource.NativeMethodInfoPtr_eBraZtngYizdLKmCBgNMFYNHlvJ_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674643);
			SDL2InputSource.NativeMethodInfoPtr_IGNDRTsRvPMcNkGMaNIgxkyUaMQ_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674644);
			SDL2InputSource.NativeMethodInfoPtr_bKSGGviKkgdmjPgWnmbUKPCprnq_Private_VcgaqAPARubixeQXnHQhlksdPyqf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674645);
			SDL2InputSource.NativeMethodInfoPtr_znxpQKrMAGTjExwOyqXlbUhGQer_Private_hreiwttkoBQlMwGESjPdQGifGUW_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674646);
			SDL2InputSource.NativeMethodInfoPtr_ahgRVqctcOKSEWjIoLFyirpSkbN_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674647);
			SDL2InputSource.NativeMethodInfoPtr_OGOZwRDEFYAkhdchIbcathBnsbK_Private_Void_byref_fPSDMDJKbTnloqtoAtkXaczUnMb_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674648);
			SDL2InputSource.NativeMethodInfoPtr_AvjBZKKprgZkOnGWLuNBUGoVBQd_Private_Void_byref_LUwcibGVNgDPRnvhdZttMDxOVNfO_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674649);
			SDL2InputSource.NativeMethodInfoPtr_hQdOBJciAcPHIWjtPjusmsnnftB_Private_Void_byref_LkagNZbGMBLBNjRdDKmhjgSgcHQI_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674650);
			SDL2InputSource.NativeMethodInfoPtr_vdyiPvArQlcBKuyXPKcXbsAgmKen_Private_Void_byref_hIQNeSHEcmxtPPcyxQydZuqEvZD_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674651);
			SDL2InputSource.NativeMethodInfoPtr_zwuHpBhFIHZNREvaVqPNSLMgNWj_Private_Void_byref_AFZToTqUcAQhXSHrqAbwiEOITklR_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674652);
			SDL2InputSource.NativeMethodInfoPtr_tkcXutdvKvCPwPWSQGPfbWYxIKx_Private_Void_byref_AFZToTqUcAQhXSHrqAbwiEOITklR_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674653);
			SDL2InputSource.NativeMethodInfoPtr_EVLJxnsBDyrGMADEzcOvjitffJAE_Private_Void_byref_ciKFGtlmBiQXDFaciTbiQWFpJya_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674654);
			SDL2InputSource.NativeMethodInfoPtr_pwiEzmvRcCANEfQyWKZOjhSPZHh_Private_Void_byref_wLDLDLwKXQgGHcoIxosVGAwiIOvJ_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674655);
			SDL2InputSource.NativeMethodInfoPtr_QbDrfuAbSvkeAbXbEuQxLUkjGeK_Private_Void_byref_TfMaQOInSDmtSPonkjOwyMSzmHC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674656);
			SDL2InputSource.NativeMethodInfoPtr_amqdgrDRTBDaUFnRFXCOMxIxpMWD_Private_Void_byref_TfMaQOInSDmtSPonkjOwyMSzmHC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674657);
			SDL2InputSource.NativeMethodInfoPtr_PzHTNIypSIkkzUuyiVWXhclpiSx_Private_Void_byref_TfMaQOInSDmtSPonkjOwyMSzmHC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674658);
			SDL2InputSource.NativeMethodInfoPtr_WxawRJlIZedjDFMYkWoPlqKKRQo_Private_Void_Int32_SDkFJbJoObYlXcDXpYlEIQQSkvlx_Byte_Int16_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674659);
			SDL2InputSource.NativeMethodInfoPtr_HDMkZMkFGNTUfHVIPupKFFbAezP_Private_Void_Int32_SDkFJbJoObYlXcDXpYlEIQQSkvlx_Byte_Int16_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674660);
			SDL2InputSource.NativeMethodInfoPtr_pkvsjznylcJuLIZhpaIUwdoguW_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674661);
			SDL2InputSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674662);
			SDL2InputSource.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674663);
			SDL2InputSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, 100674664);
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06002BBF RID: 11199 RVA: 0x000D9D30 File Offset: 0x000D7F30
		public unsafe bool initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_get_initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x000D9D6C File Offset: 0x000D7F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323820, RefRangeEnd = 323821, XrefRangeStart = 323782, XrefRangeEnd = 323820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SDL2InputSource(UpdateLoopSetting updateLoop, bool handleJoysticks, bool handleGamepads, bool handleUnifiedMouse, bool handleUnifiedKeyboard)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleJoysticks;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleGamepads;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleUnifiedMouse;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleUnifiedKeyboard;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x000D9DEC File Offset: 0x000D7FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323821, XrefRangeEnd = 323824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__DeviceChangedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_add__DeviceChangedEvent_Private_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x000D9E30 File Offset: 0x000D8030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323824, XrefRangeEnd = 323827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__DeviceChangedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_remove__DeviceChangedEvent_Private_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x000D9E74 File Offset: 0x000D8074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_DeviceChangedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_add_DeviceChangedEvent_Public_Virtual_Final_New_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x000D9EB8 File Offset: 0x000D80B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_DeviceChangedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_remove_DeviceChangedEvent_Public_Virtual_Final_New_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x000D9EFC File Offset: 0x000D80FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323827, XrefRangeEnd = 323832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SystemDeviceConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x000D9F30 File Offset: 0x000D8130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323832, XrefRangeEnd = 323837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SystemDeviceDisconnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x000D9F64 File Offset: 0x000D8164
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x000D9F98 File Offset: 0x000D8198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323837, XrefRangeEnd = 323838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateDevices(UpdateLoopType updateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_UpdateDevices_Public_Virtual_Final_New_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x000D9FD8 File Offset: 0x000D81D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateFinished()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_UpdateFinished_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x000DA00C File Offset: 0x000D820C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323838, XrefRangeEnd = 323882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList<T> GetJoysticks<T>() where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.MethodInfoStoreGeneric_GetJoysticks_Public_Virtual_Final_New_IList_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<T>>(intPtr3) : null;
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x000DA04C File Offset: 0x000D824C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 323892, RefRangeEnd = 323896, XrefRangeStart = 323882, XrefRangeEnd = 323892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RntVfvanzkYpGPWnuexfFARqyqE()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_RntVfvanzkYpGPWnuexfFARqyqE_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x000DA088 File Offset: 0x000D8288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323896, XrefRangeEnd = 323898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int JUKPSPLtOuPczUittYVIDPhYwYP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_JUKPSPLtOuPczUittYVIDPhYwYP_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x000DA0C4 File Offset: 0x000D82C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323914, RefRangeEnd = 323915, XrefRangeStart = 323898, XrefRangeEnd = 323914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VcgaqAPARubixeQXnHQhlksdPyqf gUbeaqEWdhGXDRqpZjzchsKZOrOD(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_gUbeaqEWdhGXDRqpZjzchsKZOrOD_Private_VcgaqAPARubixeQXnHQhlksdPyqf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VcgaqAPARubixeQXnHQhlksdPyqf>(intPtr3) : null;
			}
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x000DA110 File Offset: 0x000D8310
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323943, RefRangeEnd = 323944, XrefRangeStart = 323915, XrefRangeEnd = 323943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe hreiwttkoBQlMwGESjPdQGifGUW EMUkyAOTnqOyAPanUxmYQPLHAEN(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_EMUkyAOTnqOyAPanUxmYQPLHAEN_Private_hreiwttkoBQlMwGESjPdQGifGUW_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<hreiwttkoBQlMwGESjPdQGifGUW>(intPtr3) : null;
			}
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x000DA15C File Offset: 0x000D835C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 324006, RefRangeEnd = 324009, XrefRangeStart = 323944, XrefRangeEnd = 324006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ilRJkluDUSPPcKRydmoYznciuvi rtzKdXSkgxexpjJFzBbnhmDJkmfE(int A_1, MAhEpNnfHVJXeDzbLwATgncxHhBK A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_rtzKdXSkgxexpjJFzBbnhmDJkmfE_Private_ilRJkluDUSPPcKRydmoYznciuvi_Int32_MAhEpNnfHVJXeDzbLwATgncxHhBK_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ilRJkluDUSPPcKRydmoYznciuvi>(intPtr3) : null;
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x000DA1BC File Offset: 0x000D83BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324009, XrefRangeEnd = 324018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ilRJkluDUSPPcKRydmoYznciuvi dtIGWpMNPXMASSrJCjEsjOiffWVi(int A_1, JuWdVmrYhDjDMoIxmEvznniBSmG A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_dtIGWpMNPXMASSrJCjEsjOiffWVi_Private_ilRJkluDUSPPcKRydmoYznciuvi_Int32_JuWdVmrYhDjDMoIxmEvznniBSmG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ilRJkluDUSPPcKRydmoYznciuvi>(intPtr3) : null;
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x000DA21C File Offset: 0x000D841C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324018, XrefRangeEnd = 324022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void xuPDyzFmYFlFlDsYyPPMkkMdimH()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_xuPDyzFmYFlFlDsYyPPMkkMdimH_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x000DA250 File Offset: 0x000D8450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324055, RefRangeEnd = 324056, XrefRangeStart = 324022, XrefRangeEnd = 324055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PmCcIQTdelidXfDwWtZLTrwwwvk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_PmCcIQTdelidXfDwWtZLTrwwwvk_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x000DA284 File Offset: 0x000D8484
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 324068, RefRangeEnd = 324072, XrefRangeStart = 324056, XrefRangeEnd = 324068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool efxtIhaaqCboFagRjGZREAdxtESW(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_efxtIhaaqCboFagRjGZREAdxtESW_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x000DA2D0 File Offset: 0x000D84D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324072, XrefRangeEnd = 324080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UkAtyzMCaredYaLMOpeGuRNkMlQd(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_UkAtyzMCaredYaLMOpeGuRNkMlQd_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x000DA310 File Offset: 0x000D8510
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 324092, RefRangeEnd = 324095, XrefRangeStart = 324080, XrefRangeEnd = 324092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool eBraZtngYizdLKmCBgNMFYNHlvJ(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_eBraZtngYizdLKmCBgNMFYNHlvJ_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x000DA35C File Offset: 0x000D855C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324095, XrefRangeEnd = 324103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IGNDRTsRvPMcNkGMaNIgxkyUaMQ(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_IGNDRTsRvPMcNkGMaNIgxkyUaMQ_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x000DA39C File Offset: 0x000D859C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324103, XrefRangeEnd = 324105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VcgaqAPARubixeQXnHQhlksdPyqf bKSGGviKkgdmjPgWnmbUKPCprnq(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_bKSGGviKkgdmjPgWnmbUKPCprnq_Private_VcgaqAPARubixeQXnHQhlksdPyqf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VcgaqAPARubixeQXnHQhlksdPyqf>(intPtr3) : null;
			}
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x000DA3E8 File Offset: 0x000D85E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324105, XrefRangeEnd = 324107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe hreiwttkoBQlMwGESjPdQGifGUW znxpQKrMAGTjExwOyqXlbUhGQer(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_znxpQKrMAGTjExwOyqXlbUhGQer_Private_hreiwttkoBQlMwGESjPdQGifGUW_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<hreiwttkoBQlMwGESjPdQGifGUW>(intPtr3) : null;
			}
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x000DA434 File Offset: 0x000D8634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324142, RefRangeEnd = 324143, XrefRangeStart = 324107, XrefRangeEnd = 324142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ahgRVqctcOKSEWjIoLFyirpSkbN()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_ahgRVqctcOKSEWjIoLFyirpSkbN_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x000DA468 File Offset: 0x000D8668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324143, XrefRangeEnd = 324144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OGOZwRDEFYAkhdchIbcathBnsbK(ref sFaEDZPORevmmEbtxDOukwTDPQd.fPSDMDJKbTnloqtoAtkXaczUnMb A_1, double A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_OGOZwRDEFYAkhdchIbcathBnsbK_Private_Void_byref_fPSDMDJKbTnloqtoAtkXaczUnMb_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x000DA4B4 File Offset: 0x000D86B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324144, XrefRangeEnd = 324145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AvjBZKKprgZkOnGWLuNBUGoVBQd(ref sFaEDZPORevmmEbtxDOukwTDPQd.LUwcibGVNgDPRnvhdZttMDxOVNfO A_1, double A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_AvjBZKKprgZkOnGWLuNBUGoVBQd_Private_Void_byref_LUwcibGVNgDPRnvhdZttMDxOVNfO_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x000DA500 File Offset: 0x000D8700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324145, XrefRangeEnd = 324146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void hQdOBJciAcPHIWjtPjusmsnnftB(ref sFaEDZPORevmmEbtxDOukwTDPQd.LkagNZbGMBLBNjRdDKmhjgSgcHQI A_1, double A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_hQdOBJciAcPHIWjtPjusmsnnftB_Private_Void_byref_LkagNZbGMBLBNjRdDKmhjgSgcHQI_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x000DA54C File Offset: 0x000D874C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void vdyiPvArQlcBKuyXPKcXbsAgmKen(ref sFaEDZPORevmmEbtxDOukwTDPQd.hIQNeSHEcmxtPPcyxQydZuqEvZD A_1, double A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_vdyiPvArQlcBKuyXPKcXbsAgmKen_Private_Void_byref_hIQNeSHEcmxtPPcyxQydZuqEvZD_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x000DA598 File Offset: 0x000D8798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324146, XrefRangeEnd = 324148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void zwuHpBhFIHZNREvaVqPNSLMgNWj(ref sFaEDZPORevmmEbtxDOukwTDPQd.AFZToTqUcAQhXSHrqAbwiEOITklR A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_zwuHpBhFIHZNREvaVqPNSLMgNWj_Private_Void_byref_AFZToTqUcAQhXSHrqAbwiEOITklR_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x000DA5D8 File Offset: 0x000D87D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324157, RefRangeEnd = 324158, XrefRangeStart = 324148, XrefRangeEnd = 324157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void tkcXutdvKvCPwPWSQGPfbWYxIKx(ref sFaEDZPORevmmEbtxDOukwTDPQd.AFZToTqUcAQhXSHrqAbwiEOITklR A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_tkcXutdvKvCPwPWSQGPfbWYxIKx_Private_Void_byref_AFZToTqUcAQhXSHrqAbwiEOITklR_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x000DA618 File Offset: 0x000D8818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324158, XrefRangeEnd = 324159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EVLJxnsBDyrGMADEzcOvjitffJAE(ref sFaEDZPORevmmEbtxDOukwTDPQd.ciKFGtlmBiQXDFaciTbiQWFpJya A_1, double A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_EVLJxnsBDyrGMADEzcOvjitffJAE_Private_Void_byref_ciKFGtlmBiQXDFaciTbiQWFpJya_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x000DA664 File Offset: 0x000D8864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324159, XrefRangeEnd = 324160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void pwiEzmvRcCANEfQyWKZOjhSPZHh(ref sFaEDZPORevmmEbtxDOukwTDPQd.wLDLDLwKXQgGHcoIxosVGAwiIOvJ A_1, double A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_pwiEzmvRcCANEfQyWKZOjhSPZHh_Private_Void_byref_wLDLDLwKXQgGHcoIxosVGAwiIOvJ_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x000DA6B0 File Offset: 0x000D88B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324162, RefRangeEnd = 324163, XrefRangeStart = 324160, XrefRangeEnd = 324162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QbDrfuAbSvkeAbXbEuQxLUkjGeK(ref sFaEDZPORevmmEbtxDOukwTDPQd.TfMaQOInSDmtSPonkjOwyMSzmHC A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_QbDrfuAbSvkeAbXbEuQxLUkjGeK_Private_Void_byref_TfMaQOInSDmtSPonkjOwyMSzmHC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x000DA6F0 File Offset: 0x000D88F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324172, RefRangeEnd = 324173, XrefRangeStart = 324163, XrefRangeEnd = 324172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void amqdgrDRTBDaUFnRFXCOMxIxpMWD(ref sFaEDZPORevmmEbtxDOukwTDPQd.TfMaQOInSDmtSPonkjOwyMSzmHC A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_amqdgrDRTBDaUFnRFXCOMxIxpMWD_Private_Void_byref_TfMaQOInSDmtSPonkjOwyMSzmHC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x000DA730 File Offset: 0x000D8930
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PzHTNIypSIkkzUuyiVWXhclpiSx(ref sFaEDZPORevmmEbtxDOukwTDPQd.TfMaQOInSDmtSPonkjOwyMSzmHC A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_PzHTNIypSIkkzUuyiVWXhclpiSx_Private_Void_byref_TfMaQOInSDmtSPonkjOwyMSzmHC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x000DA770 File Offset: 0x000D8970
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 324176, RefRangeEnd = 324182, XrefRangeStart = 324173, XrefRangeEnd = 324176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WxawRJlIZedjDFMYkWoPlqKKRQo(int A_1, SDkFJbJoObYlXcDXpYlEIQQSkvlx A_2, byte A_3, short A_4, double A_5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_5;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_WxawRJlIZedjDFMYkWoPlqKKRQo_Private_Void_Int32_SDkFJbJoObYlXcDXpYlEIQQSkvlx_Byte_Int16_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x000DA7E8 File Offset: 0x000D89E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 324185, RefRangeEnd = 324189, XrefRangeStart = 324182, XrefRangeEnd = 324185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HDMkZMkFGNTUfHVIPupKFFbAezP(int A_1, SDkFJbJoObYlXcDXpYlEIQQSkvlx A_2, byte A_3, short A_4, double A_5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_5;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_HDMkZMkFGNTUfHVIPupKFFbAezP_Private_Void_Int32_SDkFJbJoObYlXcDXpYlEIQQSkvlx_Byte_Int16_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000DA860 File Offset: 0x000D8A60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324219, RefRangeEnd = 324220, XrefRangeStart = 324189, XrefRangeEnd = 324219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void pkvsjznylcJuLIZhpaIUwdoguW()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_pkvsjznylcJuLIZhpaIUwdoguW_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x000DA894 File Offset: 0x000D8A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324220, XrefRangeEnd = 324224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x000DA8C8 File Offset: 0x000D8AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SDL2InputSource.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x000DA904 File Offset: 0x000D8B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324224, XrefRangeEnd = 324230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SDL2InputSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x00010647 File Offset: 0x0000E847
		public SDL2InputSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06002BEC RID: 11244 RVA: 0x000DA950 File Offset: 0x000D8B50
		// (set) Token: 0x06002BED RID: 11245 RVA: 0x00010650 File Offset: 0x0000E850
		public unsafe static int CYHSmvVCpXjzThqDQUWMonBKDfYl
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SDL2InputSource.NativeFieldInfoPtr_CYHSmvVCpXjzThqDQUWMonBKDfYl, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SDL2InputSource.NativeFieldInfoPtr_CYHSmvVCpXjzThqDQUWMonBKDfYl, (void*)(&value));
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06002BEE RID: 11246 RVA: 0x000DA96C File Offset: 0x000D8B6C
		// (set) Token: 0x06002BEF RID: 11247 RVA: 0x0001065E File Offset: 0x0000E85E
		public unsafe bool QRhIyOMbbMFaviRtQmklePdGWlGz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_QRhIyOMbbMFaviRtQmklePdGWlGz);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_QRhIyOMbbMFaviRtQmklePdGWlGz)) = value;
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x000DA994 File Offset: 0x000D8B94
		// (set) Token: 0x06002BF1 RID: 11249 RVA: 0x00010679 File Offset: 0x0000E879
		public unsafe bool RWldjYOQKWvHFADHbFNnuREdvaD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_RWldjYOQKWvHFADHbFNnuREdvaD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_RWldjYOQKWvHFADHbFNnuREdvaD)) = value;
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06002BF2 RID: 11250 RVA: 0x000DA9BC File Offset: 0x000D8BBC
		// (set) Token: 0x06002BF3 RID: 11251 RVA: 0x00010694 File Offset: 0x0000E894
		public unsafe bool ggrfrcaPhHHrQaXRiZHRPmQAGsJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_ggrfrcaPhHHrQaXRiZHRPmQAGsJ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_ggrfrcaPhHHrQaXRiZHRPmQAGsJ)) = value;
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06002BF4 RID: 11252 RVA: 0x000DA9E4 File Offset: 0x000D8BE4
		// (set) Token: 0x06002BF5 RID: 11253 RVA: 0x000106AF File Offset: 0x0000E8AF
		public unsafe bool BXArBotmYcIIVbnpXVwfDahshnch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_BXArBotmYcIIVbnpXVwfDahshnch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_BXArBotmYcIIVbnpXVwfDahshnch)) = value;
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x000DAA0C File Offset: 0x000D8C0C
		// (set) Token: 0x06002BF7 RID: 11255 RVA: 0x000106CA File Offset: 0x0000E8CA
		public unsafe bool cyyBkkdxKBBsyXCzMlRPgcvSIBjT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT)) = value;
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06002BF8 RID: 11256 RVA: 0x000DAA34 File Offset: 0x000D8C34
		// (set) Token: 0x06002BF9 RID: 11257 RVA: 0x000106E5 File Offset: 0x0000E8E5
		public unsafe ADictionary<int, VcgaqAPARubixeQXnHQhlksdPyqf> fHwvAEhSaXstIllfGXDtviCPUrg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_fHwvAEhSaXstIllfGXDtviCPUrg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ADictionary<int, VcgaqAPARubixeQXnHQhlksdPyqf>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_fHwvAEhSaXstIllfGXDtviCPUrg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06002BFA RID: 11258 RVA: 0x000DAA64 File Offset: 0x000D8C64
		// (set) Token: 0x06002BFB RID: 11259 RVA: 0x00010704 File Offset: 0x0000E904
		public unsafe ADictionary<int, hreiwttkoBQlMwGESjPdQGifGUW> DvSRXSxiKkaailUlYQGYMwHLOkf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_DvSRXSxiKkaailUlYQGYMwHLOkf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ADictionary<int, hreiwttkoBQlMwGESjPdQGifGUW>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_DvSRXSxiKkaailUlYQGYMwHLOkf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06002BFC RID: 11260 RVA: 0x000DAA94 File Offset: 0x000D8C94
		// (set) Token: 0x06002BFD RID: 11261 RVA: 0x00010723 File Offset: 0x0000E923
		public unsafe sFaEDZPORevmmEbtxDOukwTDPQd.KIlCzOCyLwrSmBqdCDjvscPqlKp wTXEvzDishJeydrbNslIvVMBXAy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_wTXEvzDishJeydrbNslIvVMBXAy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_wTXEvzDishJeydrbNslIvVMBXAy)) = value;
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06002BFE RID: 11262 RVA: 0x000DAABC File Offset: 0x000D8CBC
		// (set) Token: 0x06002BFF RID: 11263 RVA: 0x0001073E File Offset: 0x0000E93E
		public unsafe NativeBuffer PILJADqUYXlZLNkhppmaluzzoMq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_PILJADqUYXlZLNkhppmaluzzoMq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_PILJADqUYXlZLNkhppmaluzzoMq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06002C00 RID: 11264 RVA: 0x000DAAEC File Offset: 0x000D8CEC
		// (set) Token: 0x06002C01 RID: 11265 RVA: 0x0001075D File Offset: 0x0000E95D
		public unsafe Action BdkcSSpIMpNctcqRGtWgHezNhVs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_BdkcSSpIMpNctcqRGtWgHezNhVs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_BdkcSSpIMpNctcqRGtWgHezNhVs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06002C02 RID: 11266 RVA: 0x000DAB1C File Offset: 0x000D8D1C
		// (set) Token: 0x06002C03 RID: 11267 RVA: 0x0001077C File Offset: 0x0000E97C
		public unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SDL2InputSource.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
			}
		}

		// Token: 0x0400252D RID: 9517
		private static readonly IntPtr NativeFieldInfoPtr_CYHSmvVCpXjzThqDQUWMonBKDfYl;

		// Token: 0x0400252E RID: 9518
		private static readonly IntPtr NativeFieldInfoPtr_QRhIyOMbbMFaviRtQmklePdGWlGz;

		// Token: 0x0400252F RID: 9519
		private static readonly IntPtr NativeFieldInfoPtr_RWldjYOQKWvHFADHbFNnuREdvaD;

		// Token: 0x04002530 RID: 9520
		private static readonly IntPtr NativeFieldInfoPtr_ggrfrcaPhHHrQaXRiZHRPmQAGsJ;

		// Token: 0x04002531 RID: 9521
		private static readonly IntPtr NativeFieldInfoPtr_BXArBotmYcIIVbnpXVwfDahshnch;

		// Token: 0x04002532 RID: 9522
		private static readonly IntPtr NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT;

		// Token: 0x04002533 RID: 9523
		private static readonly IntPtr NativeFieldInfoPtr_fHwvAEhSaXstIllfGXDtviCPUrg;

		// Token: 0x04002534 RID: 9524
		private static readonly IntPtr NativeFieldInfoPtr_DvSRXSxiKkaailUlYQGYMwHLOkf;

		// Token: 0x04002535 RID: 9525
		private static readonly IntPtr NativeFieldInfoPtr_wTXEvzDishJeydrbNslIvVMBXAy;

		// Token: 0x04002536 RID: 9526
		private static readonly IntPtr NativeFieldInfoPtr_PILJADqUYXlZLNkhppmaluzzoMq;

		// Token: 0x04002537 RID: 9527
		private static readonly IntPtr NativeFieldInfoPtr_BdkcSSpIMpNctcqRGtWgHezNhVs;

		// Token: 0x04002538 RID: 9528
		private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

		// Token: 0x04002539 RID: 9529
		private static readonly IntPtr NativeMethodInfoPtr_get_initialized_Public_get_Boolean_0;

		// Token: 0x0400253A RID: 9530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x0400253B RID: 9531
		private static readonly IntPtr NativeMethodInfoPtr_add__DeviceChangedEvent_Private_add_Void_Action_0;

		// Token: 0x0400253C RID: 9532
		private static readonly IntPtr NativeMethodInfoPtr_remove__DeviceChangedEvent_Private_rem_Void_Action_0;

		// Token: 0x0400253D RID: 9533
		private static readonly IntPtr NativeMethodInfoPtr_add_DeviceChangedEvent_Public_Virtual_Final_New_add_Void_Action_0;

		// Token: 0x0400253E RID: 9534
		private static readonly IntPtr NativeMethodInfoPtr_remove_DeviceChangedEvent_Public_Virtual_Final_New_rem_Void_Action_0;

		// Token: 0x0400253F RID: 9535
		private static readonly IntPtr NativeMethodInfoPtr_SystemDeviceConnected_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002540 RID: 9536
		private static readonly IntPtr NativeMethodInfoPtr_SystemDeviceDisconnected_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002541 RID: 9537
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002542 RID: 9538
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDevices_Public_Virtual_Final_New_Void_UpdateLoopType_0;

		// Token: 0x04002543 RID: 9539
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFinished_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002544 RID: 9540
		private static readonly IntPtr NativeMethodInfoPtr_GetJoysticks_Public_Virtual_Final_New_IList_1_T_0;

		// Token: 0x04002545 RID: 9541
		private static readonly IntPtr NativeMethodInfoPtr_RntVfvanzkYpGPWnuexfFARqyqE_Private_Int32_0;

		// Token: 0x04002546 RID: 9542
		private static readonly IntPtr NativeMethodInfoPtr_JUKPSPLtOuPczUittYVIDPhYwYP_Private_Int32_0;

		// Token: 0x04002547 RID: 9543
		private static readonly IntPtr NativeMethodInfoPtr_gUbeaqEWdhGXDRqpZjzchsKZOrOD_Private_VcgaqAPARubixeQXnHQhlksdPyqf_Int32_0;

		// Token: 0x04002548 RID: 9544
		private static readonly IntPtr NativeMethodInfoPtr_EMUkyAOTnqOyAPanUxmYQPLHAEN_Private_hreiwttkoBQlMwGESjPdQGifGUW_Int32_0;

		// Token: 0x04002549 RID: 9545
		private static readonly IntPtr NativeMethodInfoPtr_rtzKdXSkgxexpjJFzBbnhmDJkmfE_Private_ilRJkluDUSPPcKRydmoYznciuvi_Int32_MAhEpNnfHVJXeDzbLwATgncxHhBK_0;

		// Token: 0x0400254A RID: 9546
		private static readonly IntPtr NativeMethodInfoPtr_dtIGWpMNPXMASSrJCjEsjOiffWVi_Private_ilRJkluDUSPPcKRydmoYznciuvi_Int32_JuWdVmrYhDjDMoIxmEvznniBSmG_0;

		// Token: 0x0400254B RID: 9547
		private static readonly IntPtr NativeMethodInfoPtr_xuPDyzFmYFlFlDsYyPPMkkMdimH_Private_Void_0;

		// Token: 0x0400254C RID: 9548
		private static readonly IntPtr NativeMethodInfoPtr_PmCcIQTdelidXfDwWtZLTrwwwvk_Private_Void_0;

		// Token: 0x0400254D RID: 9549
		private static readonly IntPtr NativeMethodInfoPtr_efxtIhaaqCboFagRjGZREAdxtESW_Private_Boolean_Int32_0;

		// Token: 0x0400254E RID: 9550
		private static readonly IntPtr NativeMethodInfoPtr_UkAtyzMCaredYaLMOpeGuRNkMlQd_Private_Void_Int32_0;

		// Token: 0x0400254F RID: 9551
		private static readonly IntPtr NativeMethodInfoPtr_eBraZtngYizdLKmCBgNMFYNHlvJ_Private_Boolean_Int32_0;

		// Token: 0x04002550 RID: 9552
		private static readonly IntPtr NativeMethodInfoPtr_IGNDRTsRvPMcNkGMaNIgxkyUaMQ_Private_Void_Int32_0;

		// Token: 0x04002551 RID: 9553
		private static readonly IntPtr NativeMethodInfoPtr_bKSGGviKkgdmjPgWnmbUKPCprnq_Private_VcgaqAPARubixeQXnHQhlksdPyqf_Int32_0;

		// Token: 0x04002552 RID: 9554
		private static readonly IntPtr NativeMethodInfoPtr_znxpQKrMAGTjExwOyqXlbUhGQer_Private_hreiwttkoBQlMwGESjPdQGifGUW_Int32_0;

		// Token: 0x04002553 RID: 9555
		private static readonly IntPtr NativeMethodInfoPtr_ahgRVqctcOKSEWjIoLFyirpSkbN_Private_Void_0;

		// Token: 0x04002554 RID: 9556
		private static readonly IntPtr NativeMethodInfoPtr_OGOZwRDEFYAkhdchIbcathBnsbK_Private_Void_byref_fPSDMDJKbTnloqtoAtkXaczUnMb_Double_0;

		// Token: 0x04002555 RID: 9557
		private static readonly IntPtr NativeMethodInfoPtr_AvjBZKKprgZkOnGWLuNBUGoVBQd_Private_Void_byref_LUwcibGVNgDPRnvhdZttMDxOVNfO_Double_0;

		// Token: 0x04002556 RID: 9558
		private static readonly IntPtr NativeMethodInfoPtr_hQdOBJciAcPHIWjtPjusmsnnftB_Private_Void_byref_LkagNZbGMBLBNjRdDKmhjgSgcHQI_Double_0;

		// Token: 0x04002557 RID: 9559
		private static readonly IntPtr NativeMethodInfoPtr_vdyiPvArQlcBKuyXPKcXbsAgmKen_Private_Void_byref_hIQNeSHEcmxtPPcyxQydZuqEvZD_Double_0;

		// Token: 0x04002558 RID: 9560
		private static readonly IntPtr NativeMethodInfoPtr_zwuHpBhFIHZNREvaVqPNSLMgNWj_Private_Void_byref_AFZToTqUcAQhXSHrqAbwiEOITklR_0;

		// Token: 0x04002559 RID: 9561
		private static readonly IntPtr NativeMethodInfoPtr_tkcXutdvKvCPwPWSQGPfbWYxIKx_Private_Void_byref_AFZToTqUcAQhXSHrqAbwiEOITklR_0;

		// Token: 0x0400255A RID: 9562
		private static readonly IntPtr NativeMethodInfoPtr_EVLJxnsBDyrGMADEzcOvjitffJAE_Private_Void_byref_ciKFGtlmBiQXDFaciTbiQWFpJya_Double_0;

		// Token: 0x0400255B RID: 9563
		private static readonly IntPtr NativeMethodInfoPtr_pwiEzmvRcCANEfQyWKZOjhSPZHh_Private_Void_byref_wLDLDLwKXQgGHcoIxosVGAwiIOvJ_Double_0;

		// Token: 0x0400255C RID: 9564
		private static readonly IntPtr NativeMethodInfoPtr_QbDrfuAbSvkeAbXbEuQxLUkjGeK_Private_Void_byref_TfMaQOInSDmtSPonkjOwyMSzmHC_0;

		// Token: 0x0400255D RID: 9565
		private static readonly IntPtr NativeMethodInfoPtr_amqdgrDRTBDaUFnRFXCOMxIxpMWD_Private_Void_byref_TfMaQOInSDmtSPonkjOwyMSzmHC_0;

		// Token: 0x0400255E RID: 9566
		private static readonly IntPtr NativeMethodInfoPtr_PzHTNIypSIkkzUuyiVWXhclpiSx_Private_Void_byref_TfMaQOInSDmtSPonkjOwyMSzmHC_0;

		// Token: 0x0400255F RID: 9567
		private static readonly IntPtr NativeMethodInfoPtr_WxawRJlIZedjDFMYkWoPlqKKRQo_Private_Void_Int32_SDkFJbJoObYlXcDXpYlEIQQSkvlx_Byte_Int16_Double_0;

		// Token: 0x04002560 RID: 9568
		private static readonly IntPtr NativeMethodInfoPtr_HDMkZMkFGNTUfHVIPupKFFbAezP_Private_Void_Int32_SDkFJbJoObYlXcDXpYlEIQQSkvlx_Byte_Int16_Double_0;

		// Token: 0x04002561 RID: 9569
		private static readonly IntPtr NativeMethodInfoPtr_pkvsjznylcJuLIZhpaIUwdoguW_Private_Void_0;

		// Token: 0x04002562 RID: 9570
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002563 RID: 9571
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002564 RID: 9572
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x020003BF RID: 959
		public sealed class JKCqpxgpClTqKEiwrWTJPlRNIPU : MulticastDelegate
		{
			// Token: 0x06004F22 RID: 20258 RVA: 0x001684D0 File Offset: 0x001666D0
			// Note: this type is marked as 'beforefieldinit'.
			static JKCqpxgpClTqKEiwrWTJPlRNIPU()
			{
				Il2CppClassPointerStore<SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, "JKCqpxgpClTqKEiwrWTJPlRNIPU");
				SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU>.NativeClassPtr, 100674665);
				SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_Byte_Byte_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU>.NativeClassPtr, 100674666);
				SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Byte_Byte_Int16_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU>.NativeClassPtr, 100674667);
				SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU>.NativeClassPtr, 100674668);
			}

			// Token: 0x06004F23 RID: 20259 RVA: 0x00168544 File Offset: 0x00166744
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe JKCqpxgpClTqKEiwrWTJPlRNIPU(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F24 RID: 20260 RVA: 0x001685A0 File Offset: 0x001667A0
			[CallerCount(0)]
			public unsafe void Invoke(int joystickId, byte rewiredElementType, byte elementIndex, short value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref joystickId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rewiredElementType;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIndex;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_Byte_Byte_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F25 RID: 20261 RVA: 0x00168608 File Offset: 0x00166808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323750, XrefRangeEnd = 323762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(int joystickId, byte rewiredElementType, byte elementIndex, short value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref joystickId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rewiredElementType;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIndex;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Byte_Byte_Int16_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004F26 RID: 20262 RVA: 0x001686A4 File Offset: 0x001668A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F27 RID: 20263 RVA: 0x0001CD72 File Offset: 0x0001AF72
			public JKCqpxgpClTqKEiwrWTJPlRNIPU(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004F28 RID: 20264 RVA: 0x0001CD7B File Offset: 0x0001AF7B
			public static implicit operator SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU(Action<int, byte, byte, short> A_0)
			{
				return DelegateSupport.ConvertDelegate<SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU>(A_0);
			}

			// Token: 0x06004F29 RID: 20265 RVA: 0x0001CD83 File Offset: 0x0001AF83
			public static SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU operator +(SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU A_0, SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU>();
			}

			// Token: 0x06004F2A RID: 20266 RVA: 0x0001CD91 File Offset: 0x0001AF91
			public static SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU operator -(SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU A_0, SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<SDL2InputSource.JKCqpxgpClTqKEiwrWTJPlRNIPU>();
				}
				return delegate2;
			}

			// Token: 0x04004216 RID: 16918
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004217 RID: 16919
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_Byte_Byte_Int16_0;

			// Token: 0x04004218 RID: 16920
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Byte_Byte_Int16_AsyncCallback_Object_0;

			// Token: 0x04004219 RID: 16921
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003C0 RID: 960
		public sealed class mexSRAcuTdoUbgoKTWiPgnqnzEt : MulticastDelegate
		{
			// Token: 0x06004F2B RID: 20267 RVA: 0x001686E8 File Offset: 0x001668E8
			// Note: this type is marked as 'beforefieldinit'.
			static mexSRAcuTdoUbgoKTWiPgnqnzEt()
			{
				Il2CppClassPointerStore<SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, "mexSRAcuTdoUbgoKTWiPgnqnzEt");
				SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt>.NativeClassPtr, 100674669);
				SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt>.NativeClassPtr, 100674670);
				SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt>.NativeClassPtr, 100674671);
				SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt>.NativeClassPtr, 100674672);
			}

			// Token: 0x06004F2C RID: 20268 RVA: 0x0016875C File Offset: 0x0016695C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe mexSRAcuTdoUbgoKTWiPgnqnzEt(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F2D RID: 20269 RVA: 0x001687B8 File Offset: 0x001669B8
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 12882, RefRangeEnd = 12902, XrefRangeStart = 12882, XrefRangeEnd = 12902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(int joystickIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref joystickIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F2E RID: 20270 RVA: 0x001687F8 File Offset: 0x001669F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323762, XrefRangeEnd = 323766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(int joystickIndex, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref joystickIndex;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004F2F RID: 20271 RVA: 0x00168868 File Offset: 0x00166A68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F30 RID: 20272 RVA: 0x0001CDA2 File Offset: 0x0001AFA2
			public mexSRAcuTdoUbgoKTWiPgnqnzEt(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004F31 RID: 20273 RVA: 0x0001CDAB File Offset: 0x0001AFAB
			public static implicit operator SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt(Action<int> A_0)
			{
				return DelegateSupport.ConvertDelegate<SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt>(A_0);
			}

			// Token: 0x06004F32 RID: 20274 RVA: 0x0001CDB3 File Offset: 0x0001AFB3
			public static SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt operator +(SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt A_0, SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt>();
			}

			// Token: 0x06004F33 RID: 20275 RVA: 0x0001CDC1 File Offset: 0x0001AFC1
			public static SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt operator -(SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt A_0, SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<SDL2InputSource.mexSRAcuTdoUbgoKTWiPgnqnzEt>();
				}
				return delegate2;
			}

			// Token: 0x0400421A RID: 16922
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400421B RID: 16923
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0;

			// Token: 0x0400421C RID: 16924
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0;

			// Token: 0x0400421D RID: 16925
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003C1 RID: 961
		public sealed class oRcgovuSVtILntHoFimrekntGXSC : MulticastDelegate
		{
			// Token: 0x06004F34 RID: 20276 RVA: 0x001688AC File Offset: 0x00166AAC
			// Note: this type is marked as 'beforefieldinit'.
			static oRcgovuSVtILntHoFimrekntGXSC()
			{
				Il2CppClassPointerStore<SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, "oRcgovuSVtILntHoFimrekntGXSC");
				SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC>.NativeClassPtr, 100674673);
				SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC>.NativeClassPtr, 100674674);
				SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC>.NativeClassPtr, 100674675);
				SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC>.NativeClassPtr, 100674676);
			}

			// Token: 0x06004F35 RID: 20277 RVA: 0x00168920 File Offset: 0x00166B20
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe oRcgovuSVtILntHoFimrekntGXSC(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F36 RID: 20278 RVA: 0x0016897C File Offset: 0x00166B7C
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 12882, RefRangeEnd = 12902, XrefRangeStart = 12882, XrefRangeEnd = 12902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(int joystickId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref joystickId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F37 RID: 20279 RVA: 0x001689BC File Offset: 0x00166BBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323766, XrefRangeEnd = 323770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(int joystickId, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref joystickId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004F38 RID: 20280 RVA: 0x00168A2C File Offset: 0x00166C2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F39 RID: 20281 RVA: 0x0001CDD2 File Offset: 0x0001AFD2
			public oRcgovuSVtILntHoFimrekntGXSC(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004F3A RID: 20282 RVA: 0x0001CDDB File Offset: 0x0001AFDB
			public static implicit operator SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC(Action<int> A_0)
			{
				return DelegateSupport.ConvertDelegate<SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC>(A_0);
			}

			// Token: 0x06004F3B RID: 20283 RVA: 0x0001CDE3 File Offset: 0x0001AFE3
			public static SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC operator +(SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC A_0, SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC>();
			}

			// Token: 0x06004F3C RID: 20284 RVA: 0x0001CDF1 File Offset: 0x0001AFF1
			public static SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC operator -(SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC A_0, SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<SDL2InputSource.oRcgovuSVtILntHoFimrekntGXSC>();
				}
				return delegate2;
			}

			// Token: 0x0400421E RID: 16926
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400421F RID: 16927
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0;

			// Token: 0x04004220 RID: 16928
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0;

			// Token: 0x04004221 RID: 16929
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003C2 RID: 962
		public sealed class SbXZobenjWCIYMAzSqIoiAVKcPMk : MulticastDelegate
		{
			// Token: 0x06004F3D RID: 20285 RVA: 0x00168A70 File Offset: 0x00166C70
			// Note: this type is marked as 'beforefieldinit'.
			static SbXZobenjWCIYMAzSqIoiAVKcPMk()
			{
				Il2CppClassPointerStore<SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr, "SbXZobenjWCIYMAzSqIoiAVKcPMk");
				SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk>.NativeClassPtr, 100674677);
				SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_Byte_Byte_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk>.NativeClassPtr, 100674678);
				SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Byte_Byte_Int16_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk>.NativeClassPtr, 100674679);
				SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk>.NativeClassPtr, 100674680);
			}

			// Token: 0x06004F3E RID: 20286 RVA: 0x00168AE4 File Offset: 0x00166CE4
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SbXZobenjWCIYMAzSqIoiAVKcPMk(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F3F RID: 20287 RVA: 0x00168B40 File Offset: 0x00166D40
			[CallerCount(0)]
			public unsafe void Invoke(int gameControllerId, byte rewiredElementType, byte sdlElementType, short value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref gameControllerId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rewiredElementType;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sdlElementType;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_Byte_Byte_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F40 RID: 20288 RVA: 0x00168BA8 File Offset: 0x00166DA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323770, XrefRangeEnd = 323782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(int gameControllerId, byte rewiredElementType, byte sdlElementType, short value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref gameControllerId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rewiredElementType;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sdlElementType;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Byte_Byte_Int16_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004F41 RID: 20289 RVA: 0x00168C44 File Offset: 0x00166E44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F42 RID: 20290 RVA: 0x0001CE02 File Offset: 0x0001B002
			public SbXZobenjWCIYMAzSqIoiAVKcPMk(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004F43 RID: 20291 RVA: 0x0001CE0B File Offset: 0x0001B00B
			public static implicit operator SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk(Action<int, byte, byte, short> A_0)
			{
				return DelegateSupport.ConvertDelegate<SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk>(A_0);
			}

			// Token: 0x06004F44 RID: 20292 RVA: 0x0001CE13 File Offset: 0x0001B013
			public static SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk operator +(SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk A_0, SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk>();
			}

			// Token: 0x06004F45 RID: 20293 RVA: 0x0001CE21 File Offset: 0x0001B021
			public static SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk operator -(SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk A_0, SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<SDL2InputSource.SbXZobenjWCIYMAzSqIoiAVKcPMk>();
				}
				return delegate2;
			}

			// Token: 0x04004222 RID: 16930
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004223 RID: 16931
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_Byte_Byte_Int16_0;

			// Token: 0x04004224 RID: 16932
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Byte_Byte_Int16_AsyncCallback_Object_0;

			// Token: 0x04004225 RID: 16933
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020003C3 RID: 963
		private sealed class MethodInfoStoreGeneric_GetJoysticks_Public_Virtual_Final_New_IList_1_T_0<T>
		{
			// Token: 0x04004226 RID: 16934
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SDL2InputSource.NativeMethodInfoPtr_GetJoysticks_Public_Virtual_Final_New_IList_1_T_0, Il2CppClassPointerStore<SDL2InputSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
