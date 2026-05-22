using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.HID
{
	// Token: 0x02000125 RID: 293
	public class HIDVibrationMotor : Object
	{
		// Token: 0x06001E01 RID: 7681 RVA: 0x0009E25C File Offset: 0x0009C45C
		// Note: this type is marked as 'beforefieldinit'.
		static HIDVibrationMotor()
		{
			Il2CppClassPointerStore<HIDVibrationMotor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID", "HIDVibrationMotor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDVibrationMotor>.NativeClassPtr);
			HIDVibrationMotor.NativeFieldInfoPtr_JVSbsVGvAXKoNeOOighmkdPkhZpt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDVibrationMotor>.NativeClassPtr, "JVSbsVGvAXKoNeOOighmkdPkhZpt");
			HIDVibrationMotor.NativeFieldInfoPtr_CgdDzMTFIOdtCeNiPgCbUzJMfZL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDVibrationMotor>.NativeClassPtr, "CgdDzMTFIOdtCeNiPgCbUzJMfZL");
			HIDVibrationMotor.NativeFieldInfoPtr_ARrKvmSwqWsdVwJzTDhnieeqyXwA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDVibrationMotor>.NativeClassPtr, "ARrKvmSwqWsdVwJzTDhnieeqyXwA");
			HIDVibrationMotor.NativeFieldInfoPtr_aXfPutNdDZalxEUghgtFUonzmkcd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDVibrationMotor>.NativeClassPtr, "aXfPutNdDZalxEUghgtFUonzmkcd");
			HIDVibrationMotor.NativeMethodInfoPtr_add_ValueChangedEvent_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDVibrationMotor>.NativeClassPtr, 100669830);
			HIDVibrationMotor.NativeMethodInfoPtr_remove_ValueChangedEvent_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDVibrationMotor>.NativeClassPtr, 100669831);
			HIDVibrationMotor.NativeMethodInfoPtr_get_Speed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDVibrationMotor>.NativeClassPtr, 100669832);
			HIDVibrationMotor.NativeMethodInfoPtr_set_Speed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDVibrationMotor>.NativeClassPtr, 100669833);
			HIDVibrationMotor.NativeMethodInfoPtr_get_SpeedRaw_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDVibrationMotor>.NativeClassPtr, 100669834);
			HIDVibrationMotor.NativeMethodInfoPtr_set_SpeedRaw_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDVibrationMotor>.NativeClassPtr, 100669835);
			HIDVibrationMotor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDVibrationMotor>.NativeClassPtr, 100669836);
			HIDVibrationMotor.NativeMethodInfoPtr_rkxvFAKFNgahOavUJaNmGRuJGvO_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDVibrationMotor>.NativeClassPtr, 100669837);
			HIDVibrationMotor.NativeMethodInfoPtr_CWPYZrAdsxoBUMIhaDxAAhQSpByI_Private_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDVibrationMotor>.NativeClassPtr, 100669838);
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x0009E390 File Offset: 0x0009C590
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 280846, RefRangeEnd = 280850, XrefRangeStart = 280843, XrefRangeEnd = 280846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ValueChangedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDVibrationMotor.NativeMethodInfoPtr_add_ValueChangedEvent_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0009E3D4 File Offset: 0x0009C5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280850, XrefRangeEnd = 280853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ValueChangedEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDVibrationMotor.NativeMethodInfoPtr_remove_ValueChangedEvent_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x0009E418 File Offset: 0x0009C618
		// (set) Token: 0x06001E05 RID: 7685 RVA: 0x0009E454 File Offset: 0x0009C654
		public unsafe float Speed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDVibrationMotor.NativeMethodInfoPtr_get_Speed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280853, XrefRangeEnd = 280854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDVibrationMotor.NativeMethodInfoPtr_set_Speed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x0009E494 File Offset: 0x0009C694
		// (set) Token: 0x06001E07 RID: 7687 RVA: 0x0009E4D0 File Offset: 0x0009C6D0
		public unsafe int SpeedRaw
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDVibrationMotor.NativeMethodInfoPtr_get_SpeedRaw_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280854, XrefRangeEnd = 280855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDVibrationMotor.NativeMethodInfoPtr_set_SpeedRaw_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x0009E510 File Offset: 0x0009C710
		[CallerCount(0)]
		public unsafe HIDVibrationMotor(int minSpeedRaw, int maxSpeedRaw)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDVibrationMotor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minSpeedRaw;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeedRaw;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDVibrationMotor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x0009E568 File Offset: 0x0009C768
		[CallerCount(0)]
		public unsafe float rkxvFAKFNgahOavUJaNmGRuJGvO(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDVibrationMotor.NativeMethodInfoPtr_rkxvFAKFNgahOavUJaNmGRuJGvO_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x0009E5B4 File Offset: 0x0009C7B4
		[CallerCount(0)]
		public unsafe int CWPYZrAdsxoBUMIhaDxAAhQSpByI(float A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDVibrationMotor.NativeMethodInfoPtr_CWPYZrAdsxoBUMIhaDxAAhQSpByI_Private_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x0000C66E File Offset: 0x0000A86E
		public HIDVibrationMotor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x0009E600 File Offset: 0x0009C800
		// (set) Token: 0x06001E0D RID: 7693 RVA: 0x0000C677 File Offset: 0x0000A877
		public unsafe int JVSbsVGvAXKoNeOOighmkdPkhZpt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDVibrationMotor.NativeFieldInfoPtr_JVSbsVGvAXKoNeOOighmkdPkhZpt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDVibrationMotor.NativeFieldInfoPtr_JVSbsVGvAXKoNeOOighmkdPkhZpt)) = value;
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x0009E628 File Offset: 0x0009C828
		// (set) Token: 0x06001E0F RID: 7695 RVA: 0x0000C692 File Offset: 0x0000A892
		public unsafe int CgdDzMTFIOdtCeNiPgCbUzJMfZL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDVibrationMotor.NativeFieldInfoPtr_CgdDzMTFIOdtCeNiPgCbUzJMfZL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDVibrationMotor.NativeFieldInfoPtr_CgdDzMTFIOdtCeNiPgCbUzJMfZL)) = value;
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x0009E650 File Offset: 0x0009C850
		// (set) Token: 0x06001E11 RID: 7697 RVA: 0x0000C6AD File Offset: 0x0000A8AD
		public unsafe int ARrKvmSwqWsdVwJzTDhnieeqyXwA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDVibrationMotor.NativeFieldInfoPtr_ARrKvmSwqWsdVwJzTDhnieeqyXwA);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDVibrationMotor.NativeFieldInfoPtr_ARrKvmSwqWsdVwJzTDhnieeqyXwA)) = value;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x0009E678 File Offset: 0x0009C878
		// (set) Token: 0x06001E13 RID: 7699 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
		public unsafe Action aXfPutNdDZalxEUghgtFUonzmkcd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDVibrationMotor.NativeFieldInfoPtr_aXfPutNdDZalxEUghgtFUonzmkcd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDVibrationMotor.NativeFieldInfoPtr_aXfPutNdDZalxEUghgtFUonzmkcd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018FA RID: 6394
		private static readonly IntPtr NativeFieldInfoPtr_JVSbsVGvAXKoNeOOighmkdPkhZpt;

		// Token: 0x040018FB RID: 6395
		private static readonly IntPtr NativeFieldInfoPtr_CgdDzMTFIOdtCeNiPgCbUzJMfZL;

		// Token: 0x040018FC RID: 6396
		private static readonly IntPtr NativeFieldInfoPtr_ARrKvmSwqWsdVwJzTDhnieeqyXwA;

		// Token: 0x040018FD RID: 6397
		private static readonly IntPtr NativeFieldInfoPtr_aXfPutNdDZalxEUghgtFUonzmkcd;

		// Token: 0x040018FE RID: 6398
		private static readonly IntPtr NativeMethodInfoPtr_add_ValueChangedEvent_Public_add_Void_Action_0;

		// Token: 0x040018FF RID: 6399
		private static readonly IntPtr NativeMethodInfoPtr_remove_ValueChangedEvent_Public_rem_Void_Action_0;

		// Token: 0x04001900 RID: 6400
		private static readonly IntPtr NativeMethodInfoPtr_get_Speed_Public_get_Single_0;

		// Token: 0x04001901 RID: 6401
		private static readonly IntPtr NativeMethodInfoPtr_set_Speed_Public_set_Void_Single_0;

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeMethodInfoPtr_get_SpeedRaw_Public_get_Int32_0;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeMethodInfoPtr_set_SpeedRaw_Public_set_Void_Int32_0;

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeMethodInfoPtr_rkxvFAKFNgahOavUJaNmGRuJGvO_Private_Single_Int32_0;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeMethodInfoPtr_CWPYZrAdsxoBUMIhaDxAAhQSpByI_Private_Int32_Single_0;
	}
}
