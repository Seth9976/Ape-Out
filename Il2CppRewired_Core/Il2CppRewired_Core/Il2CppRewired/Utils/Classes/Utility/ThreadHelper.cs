using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x02000200 RID: 512
	public class ThreadHelper : Object
	{
		// Token: 0x06003505 RID: 13573 RVA: 0x001087C4 File Offset: 0x001069C4
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadHelper()
		{
			Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "ThreadHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr);
			ThreadHelper.NativeFieldInfoPtr_IORxYtMPcMqPSloiOuvaJAIVAyO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "IORxYtMPcMqPSloiOuvaJAIVAyO");
			ThreadHelper.NativeFieldInfoPtr_awIRcauAfKIIrMTeMOPobpDBtok = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "awIRcauAfKIIrMTeMOPobpDBtok");
			ThreadHelper.NativeFieldInfoPtr_EbNjedtgmmFwfTnOvvmSghwMnPZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "EbNjedtgmmFwfTnOvvmSghwMnPZ");
			ThreadHelper.NativeFieldInfoPtr_gOELfapeuFdrIAOpZSySQNGNPXoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "gOELfapeuFdrIAOpZSySQNGNPXoc");
			ThreadHelper.NativeFieldInfoPtr_heedExUpBZxjABhFYpOtxtgFOqN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "heedExUpBZxjABhFYpOtxtgFOqN");
			ThreadHelper.NativeFieldInfoPtr_mqdKLtopMtRqpppAKeTyDuyeVQLx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "mqdKLtopMtRqpppAKeTyDuyeVQLx");
			ThreadHelper.NativeFieldInfoPtr_SXIeRPGefZrMGhmBwKSjPwfBLvFC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "SXIeRPGefZrMGhmBwKSjPwfBLvFC");
			ThreadHelper.NativeFieldInfoPtr_JyBkzjloFznhMwXryFkNCyxJENW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "JyBkzjloFznhMwXryFkNCyxJENW");
			ThreadHelper.NativeFieldInfoPtr_rqDFsUeMkAkljWlbCxLIrYOXxhJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "rqDFsUeMkAkljWlbCxLIrYOXxhJ");
			ThreadHelper.NativeFieldInfoPtr_PigbqppOBezNXaXcAxgVCbHfKen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "PigbqppOBezNXaXcAxgVCbHfKen");
			ThreadHelper.NativeFieldInfoPtr_OQdPRIDeEhhyLbZlMxuViYZeaVQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "OQdPRIDeEhhyLbZlMxuViYZeaVQ");
			ThreadHelper.NativeFieldInfoPtr_xAVoxbMBekfdYwiyjKuYtYPXxAz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "xAVoxbMBekfdYwiyjKuYtYPXxAz");
			ThreadHelper.NativeFieldInfoPtr_TKwWBSVpVhkJcHdTVSDIiDWGyAd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "TKwWBSVpVhkJcHdTVSDIiDWGyAd");
			ThreadHelper.NativeFieldInfoPtr_USBvupWGQFGGubjpypEiEgCysyw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "USBvupWGQFGGubjpypEiEgCysyw");
			ThreadHelper.NativeFieldInfoPtr_XFjdFBadVwvTQIMvYBXiSZBOBOJG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "XFjdFBadVwvTQIMvYBXiSZBOBOJG");
			ThreadHelper.NativeFieldInfoPtr_pcogQJTVUeXLMWUMclBLRplfNHZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "pcogQJTVUeXLMWUMclBLRplfNHZ");
			ThreadHelper.NativeFieldInfoPtr_qdfXuJxpBsGXsWzvgfydVCzwmGh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "qdfXuJxpBsGXsWzvgfydVCzwmGh");
			ThreadHelper.NativeFieldInfoPtr_yUzGQXthnWHJxiLvgiHSYHaFENMh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "yUzGQXthnWHJxiLvgiHSYHaFENMh");
			ThreadHelper.NativeFieldInfoPtr_JPdBJybjYJkuOwDAXGJmiCexUYu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "JPdBJybjYJkuOwDAXGJmiCexUYu");
			ThreadHelper.NativeFieldInfoPtr_ppZURMrhwUwtmAspxNoPMnEeXBj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "ppZURMrhwUwtmAspxNoPMnEeXBj");
			ThreadHelper.NativeFieldInfoPtr_UuflFGnqEOdvGClJSCmdInRlvSXG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "UuflFGnqEOdvGClJSCmdInRlvSXG");
			ThreadHelper.NativeFieldInfoPtr_tdNfoCtyJAsjthCtenNYyALZAFH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "tdNfoCtyJAsjthCtenNYyALZAFH");
			ThreadHelper.NativeFieldInfoPtr_jheefOAIPKKBUBKgTPCgsBlihJPb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "jheefOAIPKKBUBKgTPCgsBlihJPb");
			ThreadHelper.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
			ThreadHelper.NativeMethodInfoPtr_Create_Public_Static_ThreadHelper_Boolean_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676567);
			ThreadHelper.NativeMethodInfoPtr_CreateFixedTimeStep_Public_Static_ThreadHelper_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676568);
			ThreadHelper.NativeMethodInfoPtr_CreateFixedTimeStep_Public_Static_ThreadHelper_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676569);
			ThreadHelper.NativeMethodInfoPtr_get_isRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676570);
			ThreadHelper.NativeMethodInfoPtr_get_isStopped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676571);
			ThreadHelper.NativeMethodInfoPtr_get_useHighPrecitionTimer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676572);
			ThreadHelper.NativeMethodInfoPtr_set_useHighPrecitionTimer_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676573);
			ThreadHelper.NativeMethodInfoPtr_get_useFixedTimeStep_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676574);
			ThreadHelper.NativeMethodInfoPtr_get_fixedTimeStepFPS_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676575);
			ThreadHelper.NativeMethodInfoPtr_set_fixedTimeStepFPS_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676576);
			ThreadHelper.NativeMethodInfoPtr_get_timeoutMS_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676577);
			ThreadHelper.NativeMethodInfoPtr_set_timeoutMS_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676578);
			ThreadHelper.NativeMethodInfoPtr_get_tick_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676579);
			ThreadHelper.NativeMethodInfoPtr_add_ThreadUpdateEvent_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676580);
			ThreadHelper.NativeMethodInfoPtr_remove_ThreadUpdateEvent_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676581);
			ThreadHelper.NativeMethodInfoPtr_add__ThreadStartedEvent_Private_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676582);
			ThreadHelper.NativeMethodInfoPtr_remove__ThreadStartedEvent_Private_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676583);
			ThreadHelper.NativeMethodInfoPtr_add_ThreadStartedEvent_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676584);
			ThreadHelper.NativeMethodInfoPtr_remove_ThreadStartedEvent_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676585);
			ThreadHelper.NativeMethodInfoPtr_add__ThreadPreStopEvent_Private_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676586);
			ThreadHelper.NativeMethodInfoPtr_remove__ThreadPreStopEvent_Private_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676587);
			ThreadHelper.NativeMethodInfoPtr_add_ThreadPreStopEvent_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676588);
			ThreadHelper.NativeMethodInfoPtr_remove_ThreadPreStopEvent_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676589);
			ThreadHelper.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676590);
			ThreadHelper.NativeMethodInfoPtr__ctor_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676591);
			ThreadHelper.NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676592);
			ThreadHelper.NativeMethodInfoPtr_Start_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676593);
			ThreadHelper.NativeMethodInfoPtr_Stop_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676594);
			ThreadHelper.NativeMethodInfoPtr_EnqueueAction_Public_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676595);
			ThreadHelper.NativeMethodInfoPtr_InvokeActionSync_Public_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676596);
			ThreadHelper.NativeMethodInfoPtr_WaitForActionQueueToFinish_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676597);
			ThreadHelper.NativeMethodInfoPtr_ResetTimeout_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676598);
			ThreadHelper.NativeMethodInfoPtr_BSiDqmroNVUFAccgKuLKJqwTQwc_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676599);
			ThreadHelper.NativeMethodInfoPtr_bgbFetAQFScMDhVKJMILYAhujbNu_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676600);
			ThreadHelper.NativeMethodInfoPtr_MVJWFnhwAvZznMFjRPeeOXzXBm_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676601);
			ThreadHelper.NativeMethodInfoPtr_TKiWmFaLEMnOYDsHlExcIQMuvRv_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676602);
			ThreadHelper.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676603);
			ThreadHelper.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676604);
			ThreadHelper.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676605);
			ThreadHelper.NativeMethodInfoPtr_WMEvddBTxcSiKyOpIzmOriHWFuVc_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100676606);
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x00108CF4 File Offset: 0x00106EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345935, XrefRangeEnd = 345939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ThreadHelper Create(bool fixedTimeStep = false, int fixedTimeStepFPS = 100, bool useHighPrecisionTimer = false, int timeoutMS = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fixedTimeStep;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fixedTimeStepFPS;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useHighPrecisionTimer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeoutMS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_Create_Public_Static_ThreadHelper_Boolean_Int32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThreadHelper>(intPtr3) : null;
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x00108D60 File Offset: 0x00106F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345939, XrefRangeEnd = 345940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ThreadHelper CreateFixedTimeStep(int timeStepFPS, int timeoutMS = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeStepFPS;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeoutMS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_CreateFixedTimeStep_Public_Static_ThreadHelper_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThreadHelper>(intPtr3) : null;
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x00108DB0 File Offset: 0x00106FB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 345944, RefRangeEnd = 345948, XrefRangeStart = 345940, XrefRangeEnd = 345944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ThreadHelper CreateFixedTimeStep(int timeStepFPS, bool useHighPrecisionTimer = false, int timeoutMS = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeStepFPS;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useHighPrecisionTimer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeoutMS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_CreateFixedTimeStep_Public_Static_ThreadHelper_Int32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThreadHelper>(intPtr3) : null;
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06003509 RID: 13577 RVA: 0x00108E0C File Offset: 0x0010700C
		public unsafe bool isRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_get_isRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x0600350A RID: 13578 RVA: 0x00108E48 File Offset: 0x00107048
		public unsafe bool isStopped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_get_isStopped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x0600350B RID: 13579 RVA: 0x00108E84 File Offset: 0x00107084
		// (set) Token: 0x0600350C RID: 13580 RVA: 0x00108EC0 File Offset: 0x001070C0
		public unsafe bool useHighPrecitionTimer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_get_useHighPrecitionTimer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345948, XrefRangeEnd = 345949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_set_useHighPrecitionTimer_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x0600350D RID: 13581 RVA: 0x00108F00 File Offset: 0x00107100
		public unsafe bool useFixedTimeStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_get_useFixedTimeStep_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x00108F3C File Offset: 0x0010713C
		// (set) Token: 0x0600350F RID: 13583 RVA: 0x00108F78 File Offset: 0x00107178
		public unsafe int fixedTimeStepFPS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_get_fixedTimeStepFPS_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345949, XrefRangeEnd = 345951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_set_fixedTimeStepFPS_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x00108FB8 File Offset: 0x001071B8
		// (set) Token: 0x06003511 RID: 13585 RVA: 0x00108FF4 File Offset: 0x001071F4
		public unsafe int timeoutMS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_get_timeoutMS_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345951, XrefRangeEnd = 345953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_set_timeoutMS_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06003512 RID: 13586 RVA: 0x00109034 File Offset: 0x00107234
		public unsafe uint tick
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_get_tick_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003513 RID: 13587 RVA: 0x00109070 File Offset: 0x00107270
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 345956, RefRangeEnd = 345962, XrefRangeStart = 345953, XrefRangeEnd = 345956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ThreadUpdateEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_add_ThreadUpdateEvent_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x001090B4 File Offset: 0x001072B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 345965, RefRangeEnd = 345968, XrefRangeStart = 345962, XrefRangeEnd = 345965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ThreadUpdateEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_remove_ThreadUpdateEvent_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003515 RID: 13589 RVA: 0x001090F8 File Offset: 0x001072F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345968, XrefRangeEnd = 345971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__ThreadStartedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_add__ThreadStartedEvent_Private_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003516 RID: 13590 RVA: 0x0010913C File Offset: 0x0010733C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345971, XrefRangeEnd = 345974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__ThreadStartedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_remove__ThreadStartedEvent_Private_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x00109180 File Offset: 0x00107380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ThreadStartedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_add_ThreadStartedEvent_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x001091C4 File Offset: 0x001073C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ThreadStartedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_remove_ThreadStartedEvent_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x00109208 File Offset: 0x00107408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345974, XrefRangeEnd = 345977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__ThreadPreStopEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_add__ThreadPreStopEvent_Private_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x0010924C File Offset: 0x0010744C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345977, XrefRangeEnd = 345980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__ThreadPreStopEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_remove__ThreadPreStopEvent_Private_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x00109290 File Offset: 0x00107490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ThreadPreStopEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_add_ThreadPreStopEvent_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x001092D4 File Offset: 0x001074D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ThreadPreStopEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_remove_ThreadPreStopEvent_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x00109318 File Offset: 0x00107518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345980, XrefRangeEnd = 345981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x00109354 File Offset: 0x00107554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345981, XrefRangeEnd = 345982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadHelper(int timeoutMS)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeoutMS;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr__ctor_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x0010939C File Offset: 0x0010759C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 346009, RefRangeEnd = 346015, XrefRangeStart = 345982, XrefRangeEnd = 346009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadHelper(int fixedTimeStepFPS, bool useHighPrecisionTimer, int timeoutMS)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fixedTimeStepFPS;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useHighPrecisionTimer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeoutMS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x00109400 File Offset: 0x00107600
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 346028, RefRangeEnd = 346036, XrefRangeStart = 346015, XrefRangeEnd = 346028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Start(bool wait)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref wait;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_Start_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x0010944C File Offset: 0x0010764C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 346045, RefRangeEnd = 346049, XrefRangeStart = 346036, XrefRangeEnd = 346045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop(bool wait)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref wait;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_Stop_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x0010948C File Offset: 0x0010768C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346058, RefRangeEnd = 346059, XrefRangeStart = 346049, XrefRangeEnd = 346058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EnqueueAction(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_EnqueueAction_Public_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x001094DC File Offset: 0x001076DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346059, XrefRangeEnd = 346061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InvokeActionSync(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_InvokeActionSync_Public_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x0010952C File Offset: 0x0010772C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 346070, RefRangeEnd = 346073, XrefRangeStart = 346061, XrefRangeEnd = 346070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WaitForActionQueueToFinish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_WaitForActionQueueToFinish_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x00109560 File Offset: 0x00107760
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 346073, RefRangeEnd = 346077, XrefRangeStart = 346073, XrefRangeEnd = 346073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_ResetTimeout_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x00109594 File Offset: 0x00107794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346077, XrefRangeEnd = 346128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BSiDqmroNVUFAccgKuLKJqwTQwc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_BSiDqmroNVUFAccgKuLKJqwTQwc_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x001095C8 File Offset: 0x001077C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346149, RefRangeEnd = 346150, XrefRangeStart = 346128, XrefRangeEnd = 346149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void bgbFetAQFScMDhVKJMILYAhujbNu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_bgbFetAQFScMDhVKJMILYAhujbNu_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x001095FC File Offset: 0x001077FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 346159, RefRangeEnd = 346164, XrefRangeStart = 346150, XrefRangeEnd = 346159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MVJWFnhwAvZznMFjRPeeOXzXBm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_MVJWFnhwAvZznMFjRPeeOXzXBm_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x00109630 File Offset: 0x00107830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346164, XrefRangeEnd = 346171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TKiWmFaLEMnOYDsHlExcIQMuvRv()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_TKiWmFaLEMnOYDsHlExcIQMuvRv_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x00109664 File Offset: 0x00107864
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 346176, RefRangeEnd = 346183, XrefRangeStart = 346171, XrefRangeEnd = 346176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x00109698 File Offset: 0x00107898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346183, XrefRangeEnd = 346184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThreadHelper.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x001096D4 File Offset: 0x001078D4
		[CallerCount(0)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x00109714 File Offset: 0x00107914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346184, XrefRangeEnd = 346185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WMEvddBTxcSiKyOpIzmOriHWFuVc(Object A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_WMEvddBTxcSiKyOpIzmOriHWFuVc_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x00012224 File Offset: 0x00010424
		public ThreadHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x0600352F RID: 13615 RVA: 0x0010974C File Offset: 0x0010794C
		// (set) Token: 0x06003530 RID: 13616 RVA: 0x0001222D File Offset: 0x0001042D
		public unsafe static uint IORxYtMPcMqPSloiOuvaJAIVAyO
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ThreadHelper.NativeFieldInfoPtr_IORxYtMPcMqPSloiOuvaJAIVAyO, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadHelper.NativeFieldInfoPtr_IORxYtMPcMqPSloiOuvaJAIVAyO, (void*)(&value));
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06003531 RID: 13617 RVA: 0x00109768 File Offset: 0x00107968
		// (set) Token: 0x06003532 RID: 13618 RVA: 0x0001223B File Offset: 0x0001043B
		public unsafe Stopwatch awIRcauAfKIIrMTeMOPobpDBtok
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_awIRcauAfKIIrMTeMOPobpDBtok);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_awIRcauAfKIIrMTeMOPobpDBtok), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06003533 RID: 13619 RVA: 0x00109798 File Offset: 0x00107998
		// (set) Token: 0x06003534 RID: 13620 RVA: 0x0001225A File Offset: 0x0001045A
		public unsafe Thread EbNjedtgmmFwfTnOvvmSghwMnPZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_EbNjedtgmmFwfTnOvvmSghwMnPZ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_EbNjedtgmmFwfTnOvvmSghwMnPZ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06003535 RID: 13621 RVA: 0x001097C8 File Offset: 0x001079C8
		// (set) Token: 0x06003536 RID: 13622 RVA: 0x00012279 File Offset: 0x00010479
		public unsafe ManualResetEvent gOELfapeuFdrIAOpZSySQNGNPXoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_gOELfapeuFdrIAOpZSySQNGNPXoc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_gOELfapeuFdrIAOpZSySQNGNPXoc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06003537 RID: 13623 RVA: 0x001097F8 File Offset: 0x001079F8
		// (set) Token: 0x06003538 RID: 13624 RVA: 0x00012298 File Offset: 0x00010498
		public unsafe ManualResetEvent heedExUpBZxjABhFYpOtxtgFOqN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_heedExUpBZxjABhFYpOtxtgFOqN);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_heedExUpBZxjABhFYpOtxtgFOqN), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06003539 RID: 13625 RVA: 0x00109828 File Offset: 0x00107A28
		// (set) Token: 0x0600353A RID: 13626 RVA: 0x000122B7 File Offset: 0x000104B7
		public unsafe AutoResetEvent mqdKLtopMtRqpppAKeTyDuyeVQLx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_mqdKLtopMtRqpppAKeTyDuyeVQLx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_mqdKLtopMtRqpppAKeTyDuyeVQLx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x0600353B RID: 13627 RVA: 0x00109858 File Offset: 0x00107A58
		// (set) Token: 0x0600353C RID: 13628 RVA: 0x000122D6 File Offset: 0x000104D6
		public unsafe bool SXIeRPGefZrMGhmBwKSjPwfBLvFC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_SXIeRPGefZrMGhmBwKSjPwfBLvFC);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_SXIeRPGefZrMGhmBwKSjPwfBLvFC)) = value;
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x0600353D RID: 13629 RVA: 0x00109880 File Offset: 0x00107A80
		// (set) Token: 0x0600353E RID: 13630 RVA: 0x000122F1 File Offset: 0x000104F1
		public unsafe bool JyBkzjloFznhMwXryFkNCyxJENW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_JyBkzjloFznhMwXryFkNCyxJENW);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_JyBkzjloFznhMwXryFkNCyxJENW)) = value;
			}
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x0600353F RID: 13631 RVA: 0x001098A8 File Offset: 0x00107AA8
		// (set) Token: 0x06003540 RID: 13632 RVA: 0x0001230C File Offset: 0x0001050C
		public unsafe int rqDFsUeMkAkljWlbCxLIrYOXxhJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_rqDFsUeMkAkljWlbCxLIrYOXxhJ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_rqDFsUeMkAkljWlbCxLIrYOXxhJ)) = value;
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x06003541 RID: 13633 RVA: 0x001098D0 File Offset: 0x00107AD0
		// (set) Token: 0x06003542 RID: 13634 RVA: 0x00012327 File Offset: 0x00010527
		public unsafe bool PigbqppOBezNXaXcAxgVCbHfKen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_PigbqppOBezNXaXcAxgVCbHfKen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_PigbqppOBezNXaXcAxgVCbHfKen)) = value;
			}
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06003543 RID: 13635 RVA: 0x001098F8 File Offset: 0x00107AF8
		// (set) Token: 0x06003544 RID: 13636 RVA: 0x00012342 File Offset: 0x00010542
		public unsafe int OQdPRIDeEhhyLbZlMxuViYZeaVQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_OQdPRIDeEhhyLbZlMxuViYZeaVQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_OQdPRIDeEhhyLbZlMxuViYZeaVQ)) = value;
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06003545 RID: 13637 RVA: 0x00109920 File Offset: 0x00107B20
		// (set) Token: 0x06003546 RID: 13638 RVA: 0x0001235D File Offset: 0x0001055D
		public unsafe long xAVoxbMBekfdYwiyjKuYtYPXxAz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_xAVoxbMBekfdYwiyjKuYtYPXxAz);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_xAVoxbMBekfdYwiyjKuYtYPXxAz)) = value;
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06003547 RID: 13639 RVA: 0x00109948 File Offset: 0x00107B48
		// (set) Token: 0x06003548 RID: 13640 RVA: 0x00012378 File Offset: 0x00010578
		public unsafe bool TKwWBSVpVhkJcHdTVSDIiDWGyAd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_TKwWBSVpVhkJcHdTVSDIiDWGyAd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_TKwWBSVpVhkJcHdTVSDIiDWGyAd)) = value;
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x06003549 RID: 13641 RVA: 0x00109970 File Offset: 0x00107B70
		// (set) Token: 0x0600354A RID: 13642 RVA: 0x00012393 File Offset: 0x00010593
		public unsafe int USBvupWGQFGGubjpypEiEgCysyw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_USBvupWGQFGGubjpypEiEgCysyw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_USBvupWGQFGGubjpypEiEgCysyw)) = value;
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x0600354B RID: 13643 RVA: 0x00109998 File Offset: 0x00107B98
		// (set) Token: 0x0600354C RID: 13644 RVA: 0x000123AE File Offset: 0x000105AE
		public unsafe long XFjdFBadVwvTQIMvYBXiSZBOBOJG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_XFjdFBadVwvTQIMvYBXiSZBOBOJG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_XFjdFBadVwvTQIMvYBXiSZBOBOJG)) = value;
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x0600354D RID: 13645 RVA: 0x001099C0 File Offset: 0x00107BC0
		// (set) Token: 0x0600354E RID: 13646 RVA: 0x000123C9 File Offset: 0x000105C9
		public unsafe uint pcogQJTVUeXLMWUMclBLRplfNHZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_pcogQJTVUeXLMWUMclBLRplfNHZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_pcogQJTVUeXLMWUMclBLRplfNHZ)) = value;
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x0600354F RID: 13647 RVA: 0x001099E8 File Offset: 0x00107BE8
		// (set) Token: 0x06003550 RID: 13648 RVA: 0x000123E4 File Offset: 0x000105E4
		public unsafe Object qdfXuJxpBsGXsWzvgfydVCzwmGh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_qdfXuJxpBsGXsWzvgfydVCzwmGh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_qdfXuJxpBsGXsWzvgfydVCzwmGh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06003551 RID: 13649 RVA: 0x00109A18 File Offset: 0x00107C18
		// (set) Token: 0x06003552 RID: 13650 RVA: 0x00012403 File Offset: 0x00010603
		public unsafe Queue<Action> yUzGQXthnWHJxiLvgiHSYHaFENMh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_yUzGQXthnWHJxiLvgiHSYHaFENMh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_yUzGQXthnWHJxiLvgiHSYHaFENMh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06003553 RID: 13651 RVA: 0x00109A48 File Offset: 0x00107C48
		// (set) Token: 0x06003554 RID: 13652 RVA: 0x00012422 File Offset: 0x00010622
		public unsafe Queue<Action> JPdBJybjYJkuOwDAXGJmiCexUYu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_JPdBJybjYJkuOwDAXGJmiCexUYu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_JPdBJybjYJkuOwDAXGJmiCexUYu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06003555 RID: 13653 RVA: 0x00109A78 File Offset: 0x00107C78
		// (set) Token: 0x06003556 RID: 13654 RVA: 0x00012441 File Offset: 0x00010641
		public unsafe bool ppZURMrhwUwtmAspxNoPMnEeXBj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_ppZURMrhwUwtmAspxNoPMnEeXBj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_ppZURMrhwUwtmAspxNoPMnEeXBj)) = value;
			}
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06003557 RID: 13655 RVA: 0x00109AA0 File Offset: 0x00107CA0
		// (set) Token: 0x06003558 RID: 13656 RVA: 0x0001245C File Offset: 0x0001065C
		public unsafe Action UuflFGnqEOdvGClJSCmdInRlvSXG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_UuflFGnqEOdvGClJSCmdInRlvSXG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_UuflFGnqEOdvGClJSCmdInRlvSXG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06003559 RID: 13657 RVA: 0x00109AD0 File Offset: 0x00107CD0
		// (set) Token: 0x0600355A RID: 13658 RVA: 0x0001247B File Offset: 0x0001067B
		public unsafe Action tdNfoCtyJAsjthCtenNYyALZAFH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_tdNfoCtyJAsjthCtenNYyALZAFH);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_tdNfoCtyJAsjthCtenNYyALZAFH), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x0600355B RID: 13659 RVA: 0x00109B00 File Offset: 0x00107D00
		// (set) Token: 0x0600355C RID: 13660 RVA: 0x0001249A File Offset: 0x0001069A
		public unsafe Action jheefOAIPKKBUBKgTPCgsBlihJPb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_jheefOAIPKKBUBKgTPCgsBlihJPb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_jheefOAIPKKBUBKgTPCgsBlihJPb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x0600355D RID: 13661 RVA: 0x00109B30 File Offset: 0x00107D30
		// (set) Token: 0x0600355E RID: 13662 RVA: 0x000124B9 File Offset: 0x000106B9
		public unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
			}
		}

		// Token: 0x04002D32 RID: 11570
		private static readonly IntPtr NativeFieldInfoPtr_IORxYtMPcMqPSloiOuvaJAIVAyO;

		// Token: 0x04002D33 RID: 11571
		private static readonly IntPtr NativeFieldInfoPtr_awIRcauAfKIIrMTeMOPobpDBtok;

		// Token: 0x04002D34 RID: 11572
		private static readonly IntPtr NativeFieldInfoPtr_EbNjedtgmmFwfTnOvvmSghwMnPZ;

		// Token: 0x04002D35 RID: 11573
		private static readonly IntPtr NativeFieldInfoPtr_gOELfapeuFdrIAOpZSySQNGNPXoc;

		// Token: 0x04002D36 RID: 11574
		private static readonly IntPtr NativeFieldInfoPtr_heedExUpBZxjABhFYpOtxtgFOqN;

		// Token: 0x04002D37 RID: 11575
		private static readonly IntPtr NativeFieldInfoPtr_mqdKLtopMtRqpppAKeTyDuyeVQLx;

		// Token: 0x04002D38 RID: 11576
		private static readonly IntPtr NativeFieldInfoPtr_SXIeRPGefZrMGhmBwKSjPwfBLvFC;

		// Token: 0x04002D39 RID: 11577
		private static readonly IntPtr NativeFieldInfoPtr_JyBkzjloFznhMwXryFkNCyxJENW;

		// Token: 0x04002D3A RID: 11578
		private static readonly IntPtr NativeFieldInfoPtr_rqDFsUeMkAkljWlbCxLIrYOXxhJ;

		// Token: 0x04002D3B RID: 11579
		private static readonly IntPtr NativeFieldInfoPtr_PigbqppOBezNXaXcAxgVCbHfKen;

		// Token: 0x04002D3C RID: 11580
		private static readonly IntPtr NativeFieldInfoPtr_OQdPRIDeEhhyLbZlMxuViYZeaVQ;

		// Token: 0x04002D3D RID: 11581
		private static readonly IntPtr NativeFieldInfoPtr_xAVoxbMBekfdYwiyjKuYtYPXxAz;

		// Token: 0x04002D3E RID: 11582
		private static readonly IntPtr NativeFieldInfoPtr_TKwWBSVpVhkJcHdTVSDIiDWGyAd;

		// Token: 0x04002D3F RID: 11583
		private static readonly IntPtr NativeFieldInfoPtr_USBvupWGQFGGubjpypEiEgCysyw;

		// Token: 0x04002D40 RID: 11584
		private static readonly IntPtr NativeFieldInfoPtr_XFjdFBadVwvTQIMvYBXiSZBOBOJG;

		// Token: 0x04002D41 RID: 11585
		private static readonly IntPtr NativeFieldInfoPtr_pcogQJTVUeXLMWUMclBLRplfNHZ;

		// Token: 0x04002D42 RID: 11586
		private static readonly IntPtr NativeFieldInfoPtr_qdfXuJxpBsGXsWzvgfydVCzwmGh;

		// Token: 0x04002D43 RID: 11587
		private static readonly IntPtr NativeFieldInfoPtr_yUzGQXthnWHJxiLvgiHSYHaFENMh;

		// Token: 0x04002D44 RID: 11588
		private static readonly IntPtr NativeFieldInfoPtr_JPdBJybjYJkuOwDAXGJmiCexUYu;

		// Token: 0x04002D45 RID: 11589
		private static readonly IntPtr NativeFieldInfoPtr_ppZURMrhwUwtmAspxNoPMnEeXBj;

		// Token: 0x04002D46 RID: 11590
		private static readonly IntPtr NativeFieldInfoPtr_UuflFGnqEOdvGClJSCmdInRlvSXG;

		// Token: 0x04002D47 RID: 11591
		private static readonly IntPtr NativeFieldInfoPtr_tdNfoCtyJAsjthCtenNYyALZAFH;

		// Token: 0x04002D48 RID: 11592
		private static readonly IntPtr NativeFieldInfoPtr_jheefOAIPKKBUBKgTPCgsBlihJPb;

		// Token: 0x04002D49 RID: 11593
		private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

		// Token: 0x04002D4A RID: 11594
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ThreadHelper_Boolean_Int32_Boolean_Int32_0;

		// Token: 0x04002D4B RID: 11595
		private static readonly IntPtr NativeMethodInfoPtr_CreateFixedTimeStep_Public_Static_ThreadHelper_Int32_Int32_0;

		// Token: 0x04002D4C RID: 11596
		private static readonly IntPtr NativeMethodInfoPtr_CreateFixedTimeStep_Public_Static_ThreadHelper_Int32_Boolean_Int32_0;

		// Token: 0x04002D4D RID: 11597
		private static readonly IntPtr NativeMethodInfoPtr_get_isRunning_Public_get_Boolean_0;

		// Token: 0x04002D4E RID: 11598
		private static readonly IntPtr NativeMethodInfoPtr_get_isStopped_Public_get_Boolean_0;

		// Token: 0x04002D4F RID: 11599
		private static readonly IntPtr NativeMethodInfoPtr_get_useHighPrecitionTimer_Public_get_Boolean_0;

		// Token: 0x04002D50 RID: 11600
		private static readonly IntPtr NativeMethodInfoPtr_set_useHighPrecitionTimer_Public_set_Void_Boolean_0;

		// Token: 0x04002D51 RID: 11601
		private static readonly IntPtr NativeMethodInfoPtr_get_useFixedTimeStep_Public_get_Boolean_0;

		// Token: 0x04002D52 RID: 11602
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedTimeStepFPS_Public_get_Int32_0;

		// Token: 0x04002D53 RID: 11603
		private static readonly IntPtr NativeMethodInfoPtr_set_fixedTimeStepFPS_Public_set_Void_Int32_0;

		// Token: 0x04002D54 RID: 11604
		private static readonly IntPtr NativeMethodInfoPtr_get_timeoutMS_Public_get_Int32_0;

		// Token: 0x04002D55 RID: 11605
		private static readonly IntPtr NativeMethodInfoPtr_set_timeoutMS_Public_set_Void_Int32_0;

		// Token: 0x04002D56 RID: 11606
		private static readonly IntPtr NativeMethodInfoPtr_get_tick_Public_get_UInt32_0;

		// Token: 0x04002D57 RID: 11607
		private static readonly IntPtr NativeMethodInfoPtr_add_ThreadUpdateEvent_Public_add_Void_Action_0;

		// Token: 0x04002D58 RID: 11608
		private static readonly IntPtr NativeMethodInfoPtr_remove_ThreadUpdateEvent_Public_rem_Void_Action_0;

		// Token: 0x04002D59 RID: 11609
		private static readonly IntPtr NativeMethodInfoPtr_add__ThreadStartedEvent_Private_add_Void_Action_0;

		// Token: 0x04002D5A RID: 11610
		private static readonly IntPtr NativeMethodInfoPtr_remove__ThreadStartedEvent_Private_rem_Void_Action_0;

		// Token: 0x04002D5B RID: 11611
		private static readonly IntPtr NativeMethodInfoPtr_add_ThreadStartedEvent_Public_add_Void_Action_0;

		// Token: 0x04002D5C RID: 11612
		private static readonly IntPtr NativeMethodInfoPtr_remove_ThreadStartedEvent_Public_rem_Void_Action_0;

		// Token: 0x04002D5D RID: 11613
		private static readonly IntPtr NativeMethodInfoPtr_add__ThreadPreStopEvent_Private_add_Void_Action_0;

		// Token: 0x04002D5E RID: 11614
		private static readonly IntPtr NativeMethodInfoPtr_remove__ThreadPreStopEvent_Private_rem_Void_Action_0;

		// Token: 0x04002D5F RID: 11615
		private static readonly IntPtr NativeMethodInfoPtr_add_ThreadPreStopEvent_Public_add_Void_Action_0;

		// Token: 0x04002D60 RID: 11616
		private static readonly IntPtr NativeMethodInfoPtr_remove_ThreadPreStopEvent_Public_rem_Void_Action_0;

		// Token: 0x04002D61 RID: 11617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002D62 RID: 11618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_0;

		// Token: 0x04002D63 RID: 11619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Int32_0;

		// Token: 0x04002D64 RID: 11620
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Boolean_Boolean_0;

		// Token: 0x04002D65 RID: 11621
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_Boolean_0;

		// Token: 0x04002D66 RID: 11622
		private static readonly IntPtr NativeMethodInfoPtr_EnqueueAction_Public_Boolean_Action_0;

		// Token: 0x04002D67 RID: 11623
		private static readonly IntPtr NativeMethodInfoPtr_InvokeActionSync_Public_Boolean_Action_0;

		// Token: 0x04002D68 RID: 11624
		private static readonly IntPtr NativeMethodInfoPtr_WaitForActionQueueToFinish_Public_Void_0;

		// Token: 0x04002D69 RID: 11625
		private static readonly IntPtr NativeMethodInfoPtr_ResetTimeout_Public_Void_0;

		// Token: 0x04002D6A RID: 11626
		private static readonly IntPtr NativeMethodInfoPtr_BSiDqmroNVUFAccgKuLKJqwTQwc_Private_Void_0;

		// Token: 0x04002D6B RID: 11627
		private static readonly IntPtr NativeMethodInfoPtr_bgbFetAQFScMDhVKJMILYAhujbNu_Private_Void_0;

		// Token: 0x04002D6C RID: 11628
		private static readonly IntPtr NativeMethodInfoPtr_MVJWFnhwAvZznMFjRPeeOXzXBm_Private_Void_0;

		// Token: 0x04002D6D RID: 11629
		private static readonly IntPtr NativeMethodInfoPtr_TKiWmFaLEMnOYDsHlExcIQMuvRv_Private_Void_0;

		// Token: 0x04002D6E RID: 11630
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002D6F RID: 11631
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002D70 RID: 11632
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0;

		// Token: 0x04002D71 RID: 11633
		private static readonly IntPtr NativeMethodInfoPtr_WMEvddBTxcSiKyOpIzmOriHWFuVc_Private_Static_Void_Object_0;
	}
}
