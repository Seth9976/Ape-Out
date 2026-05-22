using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Internal
{
	// Token: 0x02000129 RID: 297
	[Serializable]
	public sealed class StandaloneAxis : Object
	{
		// Token: 0x06001E79 RID: 7801 RVA: 0x0009FDBC File Offset: 0x0009DFBC
		// Note: this type is marked as 'beforefieldinit'.
		static StandaloneAxis()
		{
			Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Internal", "StandaloneAxis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr);
			StandaloneAxis.NativeFieldInfoPtr__buttonActivationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, "_buttonActivationThreshold");
			StandaloneAxis.NativeFieldInfoPtr__calibration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, "_calibration");
			StandaloneAxis.NativeFieldInfoPtr__valueRaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, "_valueRaw");
			StandaloneAxis.NativeFieldInfoPtr__valueRawPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, "_valueRawPrev");
			StandaloneAxis.NativeFieldInfoPtr_QPwyUMnDblgZagiNvxJIlyjVaauW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, "QPwyUMnDblgZagiNvxJIlyjVaauW");
			StandaloneAxis.NativeFieldInfoPtr_yxyBCoIhWGFtBdIDHEdQJGsaXAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, "yxyBCoIhWGFtBdIDHEdQJGsaXAP");
			StandaloneAxis.NativeFieldInfoPtr_laCCotadRZLcEBphiMtLblfYPvic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, "laCCotadRZLcEBphiMtLblfYPvic");
			StandaloneAxis.NativeFieldInfoPtr_NGvdqyhYrFZLKdndPZtdddhySDCc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, "NGvdqyhYrFZLKdndPZtdddhySDCc");
			StandaloneAxis.NativeFieldInfoPtr_BUSCuDWGrtFDGNbjGpKMxPJpXYR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, "BUSCuDWGrtFDGNbjGpKMxPJpXYR");
			StandaloneAxis.NativeFieldInfoPtr_TVOObVCfrHbpfklCvityGQAodXr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, "TVOObVCfrHbpfklCvityGQAodXr");
			StandaloneAxis.NativeFieldInfoPtr_MiXrQPkNOgLkxlZLPmhBfojaVMx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, "MiXrQPkNOgLkxlZLPmhBfojaVMx");
			StandaloneAxis.NativeFieldInfoPtr_MHmGzzwXrIZfHHJVImtYVkpEADp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, "MHmGzzwXrIZfHHJVImtYVkpEADp");
			StandaloneAxis.NativeMethodInfoPtr_get_buttonActivationThreshold_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669906);
			StandaloneAxis.NativeMethodInfoPtr_set_buttonActivationThreshold_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669907);
			StandaloneAxis.NativeMethodInfoPtr_get_calibration_Public_get_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669908);
			StandaloneAxis.NativeMethodInfoPtr_set_calibration_Private_set_Void_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669909);
			StandaloneAxis.NativeMethodInfoPtr_get_valueRaw_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669910);
			StandaloneAxis.NativeMethodInfoPtr_set_valueRaw_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669911);
			StandaloneAxis.NativeMethodInfoPtr_get_valueRawPrev_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669912);
			StandaloneAxis.NativeMethodInfoPtr_set_valueRawPrev_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669913);
			StandaloneAxis.NativeMethodInfoPtr_get_valueRawDelta_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669914);
			StandaloneAxis.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669915);
			StandaloneAxis.NativeMethodInfoPtr_get_valuePrev_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669916);
			StandaloneAxis.NativeMethodInfoPtr_get_valueDelta_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669917);
			StandaloneAxis.NativeMethodInfoPtr_get_rawButtonValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669918);
			StandaloneAxis.NativeMethodInfoPtr_get_rawButtonValuePrev_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669919);
			StandaloneAxis.NativeMethodInfoPtr_get_buttonValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669920);
			StandaloneAxis.NativeMethodInfoPtr_get_buttonValuePrev_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669921);
			StandaloneAxis.NativeMethodInfoPtr_get_rawMin_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669922);
			StandaloneAxis.NativeMethodInfoPtr_get_rawMax_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669923);
			StandaloneAxis.NativeMethodInfoPtr_get_rawZero_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669924);
			StandaloneAxis.NativeMethodInfoPtr_add__AxisValueChangedEvent_Private_add_Void_AxisValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669925);
			StandaloneAxis.NativeMethodInfoPtr_remove__AxisValueChangedEvent_Private_rem_Void_AxisValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669926);
			StandaloneAxis.NativeMethodInfoPtr_add_AxisValueChangedEvent_Public_add_Void_AxisValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669927);
			StandaloneAxis.NativeMethodInfoPtr_remove_AxisValueChangedEvent_Public_rem_Void_AxisValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669928);
			StandaloneAxis.NativeMethodInfoPtr_add__RawAxisValueChangedEvent_Private_add_Void_AxisValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669929);
			StandaloneAxis.NativeMethodInfoPtr_remove__RawAxisValueChangedEvent_Private_rem_Void_AxisValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669930);
			StandaloneAxis.NativeMethodInfoPtr_add_RawAxisValueChangedEvent_Public_add_Void_AxisValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669931);
			StandaloneAxis.NativeMethodInfoPtr_remove_RawAxisValueChangedEvent_Public_rem_Void_AxisValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669932);
			StandaloneAxis.NativeMethodInfoPtr_add__ButtonDownEvent_Private_add_Void_ButtonDownEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669933);
			StandaloneAxis.NativeMethodInfoPtr_remove__ButtonDownEvent_Private_rem_Void_ButtonDownEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669934);
			StandaloneAxis.NativeMethodInfoPtr_add_ButtonDownEvent_Public_add_Void_ButtonDownEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669935);
			StandaloneAxis.NativeMethodInfoPtr_remove_ButtonDownEvent_Public_rem_Void_ButtonDownEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669936);
			StandaloneAxis.NativeMethodInfoPtr_add__ButtonUpEvent_Private_add_Void_ButtonUpEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669937);
			StandaloneAxis.NativeMethodInfoPtr_remove__ButtonUpEvent_Private_rem_Void_ButtonUpEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669938);
			StandaloneAxis.NativeMethodInfoPtr_add_ButtonUpEvent_Public_add_Void_ButtonUpEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669939);
			StandaloneAxis.NativeMethodInfoPtr_remove_ButtonUpEvent_Public_rem_Void_ButtonUpEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669940);
			StandaloneAxis.NativeMethodInfoPtr_add__ButtonValueChangedEvent_Private_add_Void_ButtonValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669941);
			StandaloneAxis.NativeMethodInfoPtr_remove__ButtonValueChangedEvent_Private_rem_Void_ButtonValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669942);
			StandaloneAxis.NativeMethodInfoPtr_add_ButtonValueChangedEvent_Public_add_Void_ButtonValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669943);
			StandaloneAxis.NativeMethodInfoPtr_remove_ButtonValueChangedEvent_Public_rem_Void_ButtonValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669944);
			StandaloneAxis.NativeMethodInfoPtr_add__RawButtonDownEvent_Private_add_Void_ButtonDownEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669945);
			StandaloneAxis.NativeMethodInfoPtr_remove__RawButtonDownEvent_Private_rem_Void_ButtonDownEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669946);
			StandaloneAxis.NativeMethodInfoPtr_add_RawButtonDownEvent_Public_add_Void_ButtonDownEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669947);
			StandaloneAxis.NativeMethodInfoPtr_remove_RawButtonDownEvent_Public_rem_Void_ButtonDownEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669948);
			StandaloneAxis.NativeMethodInfoPtr_add__RawButtonUpEvent_Private_add_Void_ButtonUpEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669949);
			StandaloneAxis.NativeMethodInfoPtr_remove__RawButtonUpEvent_Private_rem_Void_ButtonUpEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669950);
			StandaloneAxis.NativeMethodInfoPtr_add_RawButtonUpEvent_Public_add_Void_ButtonUpEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669951);
			StandaloneAxis.NativeMethodInfoPtr_remove_RawButtonUpEvent_Public_rem_Void_ButtonUpEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669952);
			StandaloneAxis.NativeMethodInfoPtr_add__RawButtonValueChangedEvent_Private_add_Void_ButtonValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669953);
			StandaloneAxis.NativeMethodInfoPtr_remove__RawButtonValueChangedEvent_Private_rem_Void_ButtonValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669954);
			StandaloneAxis.NativeMethodInfoPtr_add_RawButtonValueChangedEvent_Public_add_Void_ButtonValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669955);
			StandaloneAxis.NativeMethodInfoPtr_remove_RawButtonValueChangedEvent_Public_rem_Void_ButtonValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669956);
			StandaloneAxis.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669957);
			StandaloneAxis.NativeMethodInfoPtr_SetRawValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669958);
			StandaloneAxis.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669959);
			StandaloneAxis.NativeMethodInfoPtr_CreateRelative_Internal_Static_StandaloneAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, 100669960);
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x000A0328 File Offset: 0x0009E528
		// (set) Token: 0x06001E7B RID: 7803 RVA: 0x000A0364 File Offset: 0x0009E564
		public unsafe float buttonActivationThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_get_buttonActivationThreshold_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281545, XrefRangeEnd = 281546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_set_buttonActivationThreshold_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x000A03A4 File Offset: 0x0009E5A4
		// (set) Token: 0x06001E7D RID: 7805 RVA: 0x000A03E4 File Offset: 0x0009E5E4
		public unsafe AxisCalibration calibration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_get_calibration_Public_get_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisCalibration>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_set_calibration_Private_set_Void_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x000A0428 File Offset: 0x0009E628
		// (set) Token: 0x06001E7F RID: 7807 RVA: 0x000A0464 File Offset: 0x0009E664
		public unsafe float valueRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_get_valueRaw_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_set_valueRaw_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x000A04A4 File Offset: 0x0009E6A4
		// (set) Token: 0x06001E81 RID: 7809 RVA: 0x000A04E0 File Offset: 0x0009E6E0
		public unsafe float valueRawPrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_get_valueRawPrev_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_set_valueRawPrev_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001E82 RID: 7810 RVA: 0x000A0520 File Offset: 0x0009E720
		public unsafe float valueRawDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_get_valueRawDelta_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x000A055C File Offset: 0x0009E75C
		public unsafe float value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281546, XrefRangeEnd = 281547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_get_value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x000A0598 File Offset: 0x0009E798
		public unsafe float valuePrev
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281547, XrefRangeEnd = 281548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_get_valuePrev_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x000A05D4 File Offset: 0x0009E7D4
		public unsafe float valueDelta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281548, XrefRangeEnd = 281550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_get_valueDelta_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x000A0610 File Offset: 0x0009E810
		public unsafe bool rawButtonValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_get_rawButtonValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06001E87 RID: 7815 RVA: 0x000A064C File Offset: 0x0009E84C
		public unsafe bool rawButtonValuePrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_get_rawButtonValuePrev_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x000A0688 File Offset: 0x0009E888
		public unsafe bool buttonValue
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 281553, RefRangeEnd = 281557, XrefRangeStart = 281550, XrefRangeEnd = 281553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_get_buttonValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06001E89 RID: 7817 RVA: 0x000A06C4 File Offset: 0x0009E8C4
		public unsafe bool buttonValuePrev
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 281560, RefRangeEnd = 281563, XrefRangeStart = 281557, XrefRangeEnd = 281560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_get_buttonValuePrev_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x000A0700 File Offset: 0x0009E900
		public unsafe float rawMin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_get_rawMin_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06001E8B RID: 7819 RVA: 0x000A073C File Offset: 0x0009E93C
		public unsafe float rawMax
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_get_rawMax_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x000A0778 File Offset: 0x0009E978
		public unsafe float rawZero
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_get_rawZero_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x000A07B4 File Offset: 0x0009E9B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281566, RefRangeEnd = 281569, XrefRangeStart = 281563, XrefRangeEnd = 281566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__AxisValueChangedEvent(StandaloneAxis.AxisValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_add__AxisValueChangedEvent_Private_add_Void_AxisValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x000A07F8 File Offset: 0x0009E9F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281572, RefRangeEnd = 281575, XrefRangeStart = 281569, XrefRangeEnd = 281572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__AxisValueChangedEvent(StandaloneAxis.AxisValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_remove__AxisValueChangedEvent_Private_rem_Void_AxisValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x000A083C File Offset: 0x0009EA3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281566, RefRangeEnd = 281569, XrefRangeStart = 281566, XrefRangeEnd = 281569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_AxisValueChangedEvent(StandaloneAxis.AxisValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_add_AxisValueChangedEvent_Public_add_Void_AxisValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x000A0880 File Offset: 0x0009EA80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281572, RefRangeEnd = 281575, XrefRangeStart = 281572, XrefRangeEnd = 281575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_AxisValueChangedEvent(StandaloneAxis.AxisValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_remove_AxisValueChangedEvent_Public_rem_Void_AxisValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x000A08C4 File Offset: 0x0009EAC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281578, RefRangeEnd = 281580, XrefRangeStart = 281575, XrefRangeEnd = 281578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__RawAxisValueChangedEvent(StandaloneAxis.AxisValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_add__RawAxisValueChangedEvent_Private_add_Void_AxisValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x000A0908 File Offset: 0x0009EB08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281583, RefRangeEnd = 281585, XrefRangeStart = 281580, XrefRangeEnd = 281583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__RawAxisValueChangedEvent(StandaloneAxis.AxisValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_remove__RawAxisValueChangedEvent_Private_rem_Void_AxisValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x000A094C File Offset: 0x0009EB4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281578, RefRangeEnd = 281580, XrefRangeStart = 281578, XrefRangeEnd = 281580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_RawAxisValueChangedEvent(StandaloneAxis.AxisValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_add_RawAxisValueChangedEvent_Public_add_Void_AxisValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x000A0990 File Offset: 0x0009EB90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281583, RefRangeEnd = 281585, XrefRangeStart = 281583, XrefRangeEnd = 281585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_RawAxisValueChangedEvent(StandaloneAxis.AxisValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_remove_RawAxisValueChangedEvent_Public_rem_Void_AxisValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x000A09D4 File Offset: 0x0009EBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281585, XrefRangeEnd = 281588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__ButtonDownEvent(StandaloneAxis.ButtonDownEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_add__ButtonDownEvent_Private_add_Void_ButtonDownEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x000A0A18 File Offset: 0x0009EC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281588, XrefRangeEnd = 281591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__ButtonDownEvent(StandaloneAxis.ButtonDownEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_remove__ButtonDownEvent_Private_rem_Void_ButtonDownEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x000A0A5C File Offset: 0x0009EC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ButtonDownEvent(StandaloneAxis.ButtonDownEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_add_ButtonDownEvent_Public_add_Void_ButtonDownEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x000A0AA0 File Offset: 0x0009ECA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ButtonDownEvent(StandaloneAxis.ButtonDownEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_remove_ButtonDownEvent_Public_rem_Void_ButtonDownEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x000A0AE4 File Offset: 0x0009ECE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281591, XrefRangeEnd = 281594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__ButtonUpEvent(StandaloneAxis.ButtonUpEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_add__ButtonUpEvent_Private_add_Void_ButtonUpEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x000A0B28 File Offset: 0x0009ED28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281594, XrefRangeEnd = 281597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__ButtonUpEvent(StandaloneAxis.ButtonUpEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_remove__ButtonUpEvent_Private_rem_Void_ButtonUpEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x000A0B6C File Offset: 0x0009ED6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ButtonUpEvent(StandaloneAxis.ButtonUpEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_add_ButtonUpEvent_Public_add_Void_ButtonUpEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x000A0BB0 File Offset: 0x0009EDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ButtonUpEvent(StandaloneAxis.ButtonUpEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_remove_ButtonUpEvent_Public_rem_Void_ButtonUpEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x000A0BF4 File Offset: 0x0009EDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281597, XrefRangeEnd = 281600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__ButtonValueChangedEvent(StandaloneAxis.ButtonValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_add__ButtonValueChangedEvent_Private_add_Void_ButtonValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x000A0C38 File Offset: 0x0009EE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281600, XrefRangeEnd = 281603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__ButtonValueChangedEvent(StandaloneAxis.ButtonValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_remove__ButtonValueChangedEvent_Private_rem_Void_ButtonValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x000A0C7C File Offset: 0x0009EE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ButtonValueChangedEvent(StandaloneAxis.ButtonValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_add_ButtonValueChangedEvent_Public_add_Void_ButtonValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x000A0CC0 File Offset: 0x0009EEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ButtonValueChangedEvent(StandaloneAxis.ButtonValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_remove_ButtonValueChangedEvent_Public_rem_Void_ButtonValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x000A0D04 File Offset: 0x0009EF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281603, XrefRangeEnd = 281606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__RawButtonDownEvent(StandaloneAxis.ButtonDownEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_add__RawButtonDownEvent_Private_add_Void_ButtonDownEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x000A0D48 File Offset: 0x0009EF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281606, XrefRangeEnd = 281609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__RawButtonDownEvent(StandaloneAxis.ButtonDownEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_remove__RawButtonDownEvent_Private_rem_Void_ButtonDownEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x000A0D8C File Offset: 0x0009EF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_RawButtonDownEvent(StandaloneAxis.ButtonDownEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_add_RawButtonDownEvent_Public_add_Void_ButtonDownEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x000A0DD0 File Offset: 0x0009EFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_RawButtonDownEvent(StandaloneAxis.ButtonDownEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_remove_RawButtonDownEvent_Public_rem_Void_ButtonDownEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x000A0E14 File Offset: 0x0009F014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281609, XrefRangeEnd = 281612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__RawButtonUpEvent(StandaloneAxis.ButtonUpEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_add__RawButtonUpEvent_Private_add_Void_ButtonUpEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x000A0E58 File Offset: 0x0009F058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281612, XrefRangeEnd = 281615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__RawButtonUpEvent(StandaloneAxis.ButtonUpEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_remove__RawButtonUpEvent_Private_rem_Void_ButtonUpEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x000A0E9C File Offset: 0x0009F09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_RawButtonUpEvent(StandaloneAxis.ButtonUpEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_add_RawButtonUpEvent_Public_add_Void_ButtonUpEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x000A0EE0 File Offset: 0x0009F0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_RawButtonUpEvent(StandaloneAxis.ButtonUpEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_remove_RawButtonUpEvent_Public_rem_Void_ButtonUpEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x000A0F24 File Offset: 0x0009F124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281615, XrefRangeEnd = 281618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__RawButtonValueChangedEvent(StandaloneAxis.ButtonValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_add__RawButtonValueChangedEvent_Private_add_Void_ButtonValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x000A0F68 File Offset: 0x0009F168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281618, XrefRangeEnd = 281621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__RawButtonValueChangedEvent(StandaloneAxis.ButtonValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_remove__RawButtonValueChangedEvent_Private_rem_Void_ButtonValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x000A0FAC File Offset: 0x0009F1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_RawButtonValueChangedEvent(StandaloneAxis.ButtonValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_add_RawButtonValueChangedEvent_Public_add_Void_ButtonValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x000A0FF0 File Offset: 0x0009F1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_RawButtonValueChangedEvent(StandaloneAxis.ButtonValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_remove_RawButtonValueChangedEvent_Public_rem_Void_ButtonValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x000A1034 File Offset: 0x0009F234
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 281636, RefRangeEnd = 281642, XrefRangeStart = 281621, XrefRangeEnd = 281636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandaloneAxis()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x000A1070 File Offset: 0x0009F270
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 281659, RefRangeEnd = 281684, XrefRangeStart = 281642, XrefRangeEnd = 281659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRawValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_SetRawValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x000A10B0 File Offset: 0x0009F2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281684, XrefRangeEnd = 281686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x000A10E4 File Offset: 0x0009F2E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 281691, RefRangeEnd = 281695, XrefRangeStart = 281686, XrefRangeEnd = 281691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StandaloneAxis CreateRelative()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.NativeMethodInfoPtr_CreateRelative_Internal_Static_StandaloneAxis_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StandaloneAxis>(intPtr3) : null;
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x0000C936 File Offset: 0x0000AB36
		public StandaloneAxis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x000A1118 File Offset: 0x0009F318
		// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x0000C93F File Offset: 0x0000AB3F
		public unsafe float _buttonActivationThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr__buttonActivationThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr__buttonActivationThreshold)) = value;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x000A1140 File Offset: 0x0009F340
		// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x0000C95A File Offset: 0x0000AB5A
		public unsafe AxisCalibration _calibration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr__calibration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxisCalibration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr__calibration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x000A1170 File Offset: 0x0009F370
		// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x0000C979 File Offset: 0x0000AB79
		public unsafe float _valueRaw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr__valueRaw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr__valueRaw)) = value;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x000A1198 File Offset: 0x0009F398
		// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x0000C994 File Offset: 0x0000AB94
		public unsafe float _valueRawPrev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr__valueRawPrev);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr__valueRawPrev)) = value;
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x000A11C0 File Offset: 0x0009F3C0
		// (set) Token: 0x06001EBB RID: 7867 RVA: 0x0000C9AF File Offset: 0x0000ABAF
		public unsafe StandaloneAxis.AxisValueChangedEventHandler QPwyUMnDblgZagiNvxJIlyjVaauW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr_QPwyUMnDblgZagiNvxJIlyjVaauW);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandaloneAxis.AxisValueChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr_QPwyUMnDblgZagiNvxJIlyjVaauW), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x000A11F0 File Offset: 0x0009F3F0
		// (set) Token: 0x06001EBD RID: 7869 RVA: 0x0000C9CE File Offset: 0x0000ABCE
		public unsafe StandaloneAxis.AxisValueChangedEventHandler yxyBCoIhWGFtBdIDHEdQJGsaXAP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr_yxyBCoIhWGFtBdIDHEdQJGsaXAP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandaloneAxis.AxisValueChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr_yxyBCoIhWGFtBdIDHEdQJGsaXAP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x000A1220 File Offset: 0x0009F420
		// (set) Token: 0x06001EBF RID: 7871 RVA: 0x0000C9ED File Offset: 0x0000ABED
		public unsafe StandaloneAxis.ButtonDownEventHandler laCCotadRZLcEBphiMtLblfYPvic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr_laCCotadRZLcEBphiMtLblfYPvic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandaloneAxis.ButtonDownEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr_laCCotadRZLcEBphiMtLblfYPvic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x000A1250 File Offset: 0x0009F450
		// (set) Token: 0x06001EC1 RID: 7873 RVA: 0x0000CA0C File Offset: 0x0000AC0C
		public unsafe StandaloneAxis.ButtonUpEventHandler NGvdqyhYrFZLKdndPZtdddhySDCc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr_NGvdqyhYrFZLKdndPZtdddhySDCc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandaloneAxis.ButtonUpEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr_NGvdqyhYrFZLKdndPZtdddhySDCc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x000A1280 File Offset: 0x0009F480
		// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x0000CA2B File Offset: 0x0000AC2B
		public unsafe StandaloneAxis.ButtonValueChangedEventHandler BUSCuDWGrtFDGNbjGpKMxPJpXYR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr_BUSCuDWGrtFDGNbjGpKMxPJpXYR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandaloneAxis.ButtonValueChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr_BUSCuDWGrtFDGNbjGpKMxPJpXYR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x000A12B0 File Offset: 0x0009F4B0
		// (set) Token: 0x06001EC5 RID: 7877 RVA: 0x0000CA4A File Offset: 0x0000AC4A
		public unsafe StandaloneAxis.ButtonDownEventHandler TVOObVCfrHbpfklCvityGQAodXr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr_TVOObVCfrHbpfklCvityGQAodXr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandaloneAxis.ButtonDownEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr_TVOObVCfrHbpfklCvityGQAodXr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x000A12E0 File Offset: 0x0009F4E0
		// (set) Token: 0x06001EC7 RID: 7879 RVA: 0x0000CA69 File Offset: 0x0000AC69
		public unsafe StandaloneAxis.ButtonUpEventHandler MiXrQPkNOgLkxlZLPmhBfojaVMx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr_MiXrQPkNOgLkxlZLPmhBfojaVMx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandaloneAxis.ButtonUpEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr_MiXrQPkNOgLkxlZLPmhBfojaVMx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x000A1310 File Offset: 0x0009F510
		// (set) Token: 0x06001EC9 RID: 7881 RVA: 0x0000CA88 File Offset: 0x0000AC88
		public unsafe StandaloneAxis.ButtonValueChangedEventHandler MHmGzzwXrIZfHHJVImtYVkpEADp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr_MHmGzzwXrIZfHHJVImtYVkpEADp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandaloneAxis.ButtonValueChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis.NativeFieldInfoPtr_MHmGzzwXrIZfHHJVImtYVkpEADp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeFieldInfoPtr__buttonActivationThreshold;

		// Token: 0x04001953 RID: 6483
		private static readonly IntPtr NativeFieldInfoPtr__calibration;

		// Token: 0x04001954 RID: 6484
		private static readonly IntPtr NativeFieldInfoPtr__valueRaw;

		// Token: 0x04001955 RID: 6485
		private static readonly IntPtr NativeFieldInfoPtr__valueRawPrev;

		// Token: 0x04001956 RID: 6486
		private static readonly IntPtr NativeFieldInfoPtr_QPwyUMnDblgZagiNvxJIlyjVaauW;

		// Token: 0x04001957 RID: 6487
		private static readonly IntPtr NativeFieldInfoPtr_yxyBCoIhWGFtBdIDHEdQJGsaXAP;

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeFieldInfoPtr_laCCotadRZLcEBphiMtLblfYPvic;

		// Token: 0x04001959 RID: 6489
		private static readonly IntPtr NativeFieldInfoPtr_NGvdqyhYrFZLKdndPZtdddhySDCc;

		// Token: 0x0400195A RID: 6490
		private static readonly IntPtr NativeFieldInfoPtr_BUSCuDWGrtFDGNbjGpKMxPJpXYR;

		// Token: 0x0400195B RID: 6491
		private static readonly IntPtr NativeFieldInfoPtr_TVOObVCfrHbpfklCvityGQAodXr;

		// Token: 0x0400195C RID: 6492
		private static readonly IntPtr NativeFieldInfoPtr_MiXrQPkNOgLkxlZLPmhBfojaVMx;

		// Token: 0x0400195D RID: 6493
		private static readonly IntPtr NativeFieldInfoPtr_MHmGzzwXrIZfHHJVImtYVkpEADp;

		// Token: 0x0400195E RID: 6494
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonActivationThreshold_Public_get_Single_0;

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeMethodInfoPtr_set_buttonActivationThreshold_Public_set_Void_Single_0;

		// Token: 0x04001960 RID: 6496
		private static readonly IntPtr NativeMethodInfoPtr_get_calibration_Public_get_AxisCalibration_0;

		// Token: 0x04001961 RID: 6497
		private static readonly IntPtr NativeMethodInfoPtr_set_calibration_Private_set_Void_AxisCalibration_0;

		// Token: 0x04001962 RID: 6498
		private static readonly IntPtr NativeMethodInfoPtr_get_valueRaw_Public_get_Single_0;

		// Token: 0x04001963 RID: 6499
		private static readonly IntPtr NativeMethodInfoPtr_set_valueRaw_Private_set_Void_Single_0;

		// Token: 0x04001964 RID: 6500
		private static readonly IntPtr NativeMethodInfoPtr_get_valueRawPrev_Public_get_Single_0;

		// Token: 0x04001965 RID: 6501
		private static readonly IntPtr NativeMethodInfoPtr_set_valueRawPrev_Private_set_Void_Single_0;

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeMethodInfoPtr_get_valueRawDelta_Public_get_Single_0;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_get_Single_0;

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeMethodInfoPtr_get_valueDelta_Public_get_Single_0;

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeMethodInfoPtr_get_rawButtonValue_Public_get_Boolean_0;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeMethodInfoPtr_get_rawButtonValuePrev_Public_get_Boolean_0;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonValue_Public_get_Boolean_0;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonValuePrev_Public_get_Boolean_0;

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeMethodInfoPtr_get_rawMin_Internal_get_Single_0;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeMethodInfoPtr_get_rawMax_Internal_get_Single_0;

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeMethodInfoPtr_get_rawZero_Internal_get_Single_0;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeMethodInfoPtr_add__AxisValueChangedEvent_Private_add_Void_AxisValueChangedEventHandler_0;

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeMethodInfoPtr_remove__AxisValueChangedEvent_Private_rem_Void_AxisValueChangedEventHandler_0;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeMethodInfoPtr_add_AxisValueChangedEvent_Public_add_Void_AxisValueChangedEventHandler_0;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeMethodInfoPtr_remove_AxisValueChangedEvent_Public_rem_Void_AxisValueChangedEventHandler_0;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeMethodInfoPtr_add__RawAxisValueChangedEvent_Private_add_Void_AxisValueChangedEventHandler_0;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeMethodInfoPtr_remove__RawAxisValueChangedEvent_Private_rem_Void_AxisValueChangedEventHandler_0;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeMethodInfoPtr_add_RawAxisValueChangedEvent_Public_add_Void_AxisValueChangedEventHandler_0;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeMethodInfoPtr_remove_RawAxisValueChangedEvent_Public_rem_Void_AxisValueChangedEventHandler_0;

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeMethodInfoPtr_add__ButtonDownEvent_Private_add_Void_ButtonDownEventHandler_0;

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeMethodInfoPtr_remove__ButtonDownEvent_Private_rem_Void_ButtonDownEventHandler_0;

		// Token: 0x0400197B RID: 6523
		private static readonly IntPtr NativeMethodInfoPtr_add_ButtonDownEvent_Public_add_Void_ButtonDownEventHandler_0;

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeMethodInfoPtr_remove_ButtonDownEvent_Public_rem_Void_ButtonDownEventHandler_0;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeMethodInfoPtr_add__ButtonUpEvent_Private_add_Void_ButtonUpEventHandler_0;

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeMethodInfoPtr_remove__ButtonUpEvent_Private_rem_Void_ButtonUpEventHandler_0;

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeMethodInfoPtr_add_ButtonUpEvent_Public_add_Void_ButtonUpEventHandler_0;

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeMethodInfoPtr_remove_ButtonUpEvent_Public_rem_Void_ButtonUpEventHandler_0;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeMethodInfoPtr_add__ButtonValueChangedEvent_Private_add_Void_ButtonValueChangedEventHandler_0;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeMethodInfoPtr_remove__ButtonValueChangedEvent_Private_rem_Void_ButtonValueChangedEventHandler_0;

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeMethodInfoPtr_add_ButtonValueChangedEvent_Public_add_Void_ButtonValueChangedEventHandler_0;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeMethodInfoPtr_remove_ButtonValueChangedEvent_Public_rem_Void_ButtonValueChangedEventHandler_0;

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeMethodInfoPtr_add__RawButtonDownEvent_Private_add_Void_ButtonDownEventHandler_0;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeMethodInfoPtr_remove__RawButtonDownEvent_Private_rem_Void_ButtonDownEventHandler_0;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeMethodInfoPtr_add_RawButtonDownEvent_Public_add_Void_ButtonDownEventHandler_0;

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeMethodInfoPtr_remove_RawButtonDownEvent_Public_rem_Void_ButtonDownEventHandler_0;

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeMethodInfoPtr_add__RawButtonUpEvent_Private_add_Void_ButtonUpEventHandler_0;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeMethodInfoPtr_remove__RawButtonUpEvent_Private_rem_Void_ButtonUpEventHandler_0;

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeMethodInfoPtr_add_RawButtonUpEvent_Public_add_Void_ButtonUpEventHandler_0;

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeMethodInfoPtr_remove_RawButtonUpEvent_Public_rem_Void_ButtonUpEventHandler_0;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeMethodInfoPtr_add__RawButtonValueChangedEvent_Private_add_Void_ButtonValueChangedEventHandler_0;

		// Token: 0x0400198E RID: 6542
		private static readonly IntPtr NativeMethodInfoPtr_remove__RawButtonValueChangedEvent_Private_rem_Void_ButtonValueChangedEventHandler_0;

		// Token: 0x0400198F RID: 6543
		private static readonly IntPtr NativeMethodInfoPtr_add_RawButtonValueChangedEvent_Public_add_Void_ButtonValueChangedEventHandler_0;

		// Token: 0x04001990 RID: 6544
		private static readonly IntPtr NativeMethodInfoPtr_remove_RawButtonValueChangedEvent_Public_rem_Void_ButtonValueChangedEventHandler_0;

		// Token: 0x04001991 RID: 6545
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001992 RID: 6546
		private static readonly IntPtr NativeMethodInfoPtr_SetRawValue_Public_Void_Single_0;

		// Token: 0x04001993 RID: 6547
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04001994 RID: 6548
		private static readonly IntPtr NativeMethodInfoPtr_CreateRelative_Internal_Static_StandaloneAxis_0;

		// Token: 0x0200033E RID: 830
		public sealed class AxisValueChangedEventHandler : MulticastDelegate
		{
			// Token: 0x060045F1 RID: 17905 RVA: 0x001458A4 File Offset: 0x00143AA4
			// Note: this type is marked as 'beforefieldinit'.
			static AxisValueChangedEventHandler()
			{
				Il2CppClassPointerStore<StandaloneAxis.AxisValueChangedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, "AxisValueChangedEventHandler");
				StandaloneAxis.AxisValueChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis.AxisValueChangedEventHandler>.NativeClassPtr, 100669961);
				StandaloneAxis.AxisValueChangedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis.AxisValueChangedEventHandler>.NativeClassPtr, 100669962);
				StandaloneAxis.AxisValueChangedEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis.AxisValueChangedEventHandler>.NativeClassPtr, 100669963);
				StandaloneAxis.AxisValueChangedEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis.AxisValueChangedEventHandler>.NativeClassPtr, 100669964);
			}

			// Token: 0x060045F2 RID: 17906 RVA: 0x00145918 File Offset: 0x00143B18
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AxisValueChangedEventHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandaloneAxis.AxisValueChangedEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.AxisValueChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045F3 RID: 17907 RVA: 0x00145974 File Offset: 0x00143B74
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 281527, RefRangeEnd = 281537, XrefRangeStart = 281527, XrefRangeEnd = 281527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.AxisValueChangedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060045F4 RID: 17908 RVA: 0x001459B4 File Offset: 0x00143BB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281537, XrefRangeEnd = 281541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(float value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.AxisValueChangedEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060045F5 RID: 17909 RVA: 0x00145A24 File Offset: 0x00143C24
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.AxisValueChangedEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060045F6 RID: 17910 RVA: 0x00019406 File Offset: 0x00017606
			public AxisValueChangedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060045F7 RID: 17911 RVA: 0x0001940F File Offset: 0x0001760F
			public static implicit operator StandaloneAxis.AxisValueChangedEventHandler(Action<float> A_0)
			{
				return DelegateSupport.ConvertDelegate<StandaloneAxis.AxisValueChangedEventHandler>(A_0);
			}

			// Token: 0x060045F8 RID: 17912 RVA: 0x00019417 File Offset: 0x00017617
			public static StandaloneAxis.AxisValueChangedEventHandler operator +(StandaloneAxis.AxisValueChangedEventHandler A_0, StandaloneAxis.AxisValueChangedEventHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StandaloneAxis.AxisValueChangedEventHandler>();
			}

			// Token: 0x060045F9 RID: 17913 RVA: 0x00019425 File Offset: 0x00017625
			public static StandaloneAxis.AxisValueChangedEventHandler operator -(StandaloneAxis.AxisValueChangedEventHandler A_0, StandaloneAxis.AxisValueChangedEventHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StandaloneAxis.AxisValueChangedEventHandler>();
				}
				return delegate2;
			}

			// Token: 0x0400392F RID: 14639
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003930 RID: 14640
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Single_0;

			// Token: 0x04003931 RID: 14641
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_AsyncCallback_Object_0;

			// Token: 0x04003932 RID: 14642
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200033F RID: 831
		public sealed class ButtonValueChangedEventHandler : MulticastDelegate
		{
			// Token: 0x060045FA RID: 17914 RVA: 0x00145A68 File Offset: 0x00143C68
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonValueChangedEventHandler()
			{
				Il2CppClassPointerStore<StandaloneAxis.ButtonValueChangedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, "ButtonValueChangedEventHandler");
				StandaloneAxis.ButtonValueChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis.ButtonValueChangedEventHandler>.NativeClassPtr, 100669965);
				StandaloneAxis.ButtonValueChangedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis.ButtonValueChangedEventHandler>.NativeClassPtr, 100669966);
				StandaloneAxis.ButtonValueChangedEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis.ButtonValueChangedEventHandler>.NativeClassPtr, 100669967);
				StandaloneAxis.ButtonValueChangedEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis.ButtonValueChangedEventHandler>.NativeClassPtr, 100669968);
			}

			// Token: 0x060045FB RID: 17915 RVA: 0x00145ADC File Offset: 0x00143CDC
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonValueChangedEventHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandaloneAxis.ButtonValueChangedEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.ButtonValueChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045FC RID: 17916 RVA: 0x00145B38 File Offset: 0x00143D38
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 42994, RefRangeEnd = 43010, XrefRangeStart = 42994, XrefRangeEnd = 43010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(bool value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.ButtonValueChangedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060045FD RID: 17917 RVA: 0x00145B78 File Offset: 0x00143D78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281541, XrefRangeEnd = 281545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(bool value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.ButtonValueChangedEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060045FE RID: 17918 RVA: 0x00145BE8 File Offset: 0x00143DE8
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.ButtonValueChangedEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060045FF RID: 17919 RVA: 0x00019436 File Offset: 0x00017636
			public ButtonValueChangedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004600 RID: 17920 RVA: 0x0001943F File Offset: 0x0001763F
			public static implicit operator StandaloneAxis.ButtonValueChangedEventHandler(Action<bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<StandaloneAxis.ButtonValueChangedEventHandler>(A_0);
			}

			// Token: 0x06004601 RID: 17921 RVA: 0x00019447 File Offset: 0x00017647
			public static StandaloneAxis.ButtonValueChangedEventHandler operator +(StandaloneAxis.ButtonValueChangedEventHandler A_0, StandaloneAxis.ButtonValueChangedEventHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StandaloneAxis.ButtonValueChangedEventHandler>();
			}

			// Token: 0x06004602 RID: 17922 RVA: 0x00019455 File Offset: 0x00017655
			public static StandaloneAxis.ButtonValueChangedEventHandler operator -(StandaloneAxis.ButtonValueChangedEventHandler A_0, StandaloneAxis.ButtonValueChangedEventHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StandaloneAxis.ButtonValueChangedEventHandler>();
				}
				return delegate2;
			}

			// Token: 0x04003933 RID: 14643
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003934 RID: 14644
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;

			// Token: 0x04003935 RID: 14645
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;

			// Token: 0x04003936 RID: 14646
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000340 RID: 832
		public sealed class ButtonDownEventHandler : MulticastDelegate
		{
			// Token: 0x06004603 RID: 17923 RVA: 0x00145C2C File Offset: 0x00143E2C
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonDownEventHandler()
			{
				Il2CppClassPointerStore<StandaloneAxis.ButtonDownEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, "ButtonDownEventHandler");
				StandaloneAxis.ButtonDownEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis.ButtonDownEventHandler>.NativeClassPtr, 100669969);
				StandaloneAxis.ButtonDownEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis.ButtonDownEventHandler>.NativeClassPtr, 100669970);
				StandaloneAxis.ButtonDownEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis.ButtonDownEventHandler>.NativeClassPtr, 100669971);
				StandaloneAxis.ButtonDownEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis.ButtonDownEventHandler>.NativeClassPtr, 100669972);
			}

			// Token: 0x06004604 RID: 17924 RVA: 0x00145CA0 File Offset: 0x00143EA0
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonDownEventHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandaloneAxis.ButtonDownEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.ButtonDownEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004605 RID: 17925 RVA: 0x00145CFC File Offset: 0x00143EFC
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.ButtonDownEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004606 RID: 17926 RVA: 0x00145D30 File Offset: 0x00143F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.ButtonDownEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004607 RID: 17927 RVA: 0x00145D94 File Offset: 0x00143F94
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.ButtonDownEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004608 RID: 17928 RVA: 0x00019466 File Offset: 0x00017666
			public ButtonDownEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004609 RID: 17929 RVA: 0x0001946F File Offset: 0x0001766F
			public static implicit operator StandaloneAxis.ButtonDownEventHandler(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<StandaloneAxis.ButtonDownEventHandler>(A_0);
			}

			// Token: 0x0600460A RID: 17930 RVA: 0x00019477 File Offset: 0x00017677
			public static StandaloneAxis.ButtonDownEventHandler operator +(StandaloneAxis.ButtonDownEventHandler A_0, StandaloneAxis.ButtonDownEventHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StandaloneAxis.ButtonDownEventHandler>();
			}

			// Token: 0x0600460B RID: 17931 RVA: 0x00019485 File Offset: 0x00017685
			public static StandaloneAxis.ButtonDownEventHandler operator -(StandaloneAxis.ButtonDownEventHandler A_0, StandaloneAxis.ButtonDownEventHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StandaloneAxis.ButtonDownEventHandler>();
				}
				return delegate2;
			}

			// Token: 0x04003937 RID: 14647
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003938 RID: 14648
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04003939 RID: 14649
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x0400393A RID: 14650
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000341 RID: 833
		public sealed class ButtonUpEventHandler : MulticastDelegate
		{
			// Token: 0x0600460C RID: 17932 RVA: 0x00145DD8 File Offset: 0x00143FD8
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonUpEventHandler()
			{
				Il2CppClassPointerStore<StandaloneAxis.ButtonUpEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StandaloneAxis>.NativeClassPtr, "ButtonUpEventHandler");
				StandaloneAxis.ButtonUpEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis.ButtonUpEventHandler>.NativeClassPtr, 100669973);
				StandaloneAxis.ButtonUpEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis.ButtonUpEventHandler>.NativeClassPtr, 100669974);
				StandaloneAxis.ButtonUpEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis.ButtonUpEventHandler>.NativeClassPtr, 100669975);
				StandaloneAxis.ButtonUpEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis.ButtonUpEventHandler>.NativeClassPtr, 100669976);
			}

			// Token: 0x0600460D RID: 17933 RVA: 0x00145E4C File Offset: 0x0014404C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonUpEventHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandaloneAxis.ButtonUpEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.ButtonUpEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600460E RID: 17934 RVA: 0x00145EA8 File Offset: 0x001440A8
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.ButtonUpEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600460F RID: 17935 RVA: 0x00145EDC File Offset: 0x001440DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.ButtonUpEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004610 RID: 17936 RVA: 0x00145F40 File Offset: 0x00144140
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis.ButtonUpEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004611 RID: 17937 RVA: 0x00019496 File Offset: 0x00017696
			public ButtonUpEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004612 RID: 17938 RVA: 0x0001949F File Offset: 0x0001769F
			public static implicit operator StandaloneAxis.ButtonUpEventHandler(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<StandaloneAxis.ButtonUpEventHandler>(A_0);
			}

			// Token: 0x06004613 RID: 17939 RVA: 0x000194A7 File Offset: 0x000176A7
			public static StandaloneAxis.ButtonUpEventHandler operator +(StandaloneAxis.ButtonUpEventHandler A_0, StandaloneAxis.ButtonUpEventHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StandaloneAxis.ButtonUpEventHandler>();
			}

			// Token: 0x06004614 RID: 17940 RVA: 0x000194B5 File Offset: 0x000176B5
			public static StandaloneAxis.ButtonUpEventHandler operator -(StandaloneAxis.ButtonUpEventHandler A_0, StandaloneAxis.ButtonUpEventHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StandaloneAxis.ButtonUpEventHandler>();
				}
				return delegate2;
			}

			// Token: 0x0400393B RID: 14651
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400393C RID: 14652
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x0400393D RID: 14653
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x0400393E RID: 14654
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
