using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Config;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.HID
{
	// Token: 0x0200011D RID: 285
	public class HIDGyroscope : HIDControllerElementWithDataSet
	{
		// Token: 0x06001D30 RID: 7472 RVA: 0x0009B834 File Offset: 0x00099A34
		// Note: this type is marked as 'beforefieldinit'.
		static HIDGyroscope()
		{
			Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID", "HIDGyroscope");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr);
			HIDGyroscope.NativeFieldInfoPtr_timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, "timestamp");
			HIDGyroscope.NativeFieldInfoPtr_lastRawValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, "lastRawValue");
			HIDGyroscope.NativeFieldInfoPtr_valueLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, "valueLength");
			HIDGyroscope.NativeFieldInfoPtr_JundODLxEaEphASnfpeoeHgDBdvQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, "JundODLxEaEphASnfpeoeHgDBdvQ");
			HIDGyroscope.NativeFieldInfoPtr_nVQBrTgrFEOGnYxIFvuzudTwQOP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, "nVQBrTgrFEOGnYxIFvuzudTwQOP");
			HIDGyroscope.NativeFieldInfoPtr_IoVcqiINSOZWWvsKrcebJLeofeXb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, "IoVcqiINSOZWWvsKrcebJLeofeXb");
			HIDGyroscope.NativeFieldInfoPtr_GwdIvCWNdssamWnbvEZeEcJFfiEE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, "GwdIvCWNdssamWnbvEZeEcJFfiEE");
			HIDGyroscope.NativeFieldInfoPtr_afkGLXHGxIeTZtbNvjRtofPdBs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, "afkGLXHGxIeTZtbNvjRtofPdBs");
			HIDGyroscope.NativeFieldInfoPtr_raYeHXsDFIavEqaNhFaBrfLxmps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, "raYeHXsDFIavEqaNhFaBrfLxmps");
			HIDGyroscope.NativeMethodInfoPtr_get_rawValue_Public_get_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, 100669722);
			HIDGyroscope.NativeMethodInfoPtr_get_events_Public_get_ExpandableArray_DataContainer_1_vwnDNljqUPuTIauvXLOcbBHPCtP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, 100669723);
			HIDGyroscope.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Byte_HIDInfo_Int32_Int32_Action_2_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_Func_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, 100669724);
			HIDGyroscope.NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, 100669725);
			HIDGyroscope.NativeMethodInfoPtr_UpdateValueManual_Public_Void_Il2CppStructArray_1_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, 100669726);
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x0009B97C File Offset: 0x00099B7C
		public unsafe Il2CppStructArray<float> rawValue
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 280455, RefRangeEnd = 280462, XrefRangeStart = 280451, XrefRangeEnd = 280455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.NativeMethodInfoPtr_get_rawValue_Public_get_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x0009B9BC File Offset: 0x00099BBC
		public unsafe ExpandableArray_DataContainer<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP> events
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 280466, RefRangeEnd = 280468, XrefRangeStart = 280462, XrefRangeEnd = 280466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.NativeMethodInfoPtr_get_events_Public_get_ExpandableArray_DataContainer_1_vwnDNljqUPuTIauvXLOcbBHPCtP_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpandableArray_DataContainer<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x0009B9FC File Offset: 0x00099BFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280487, RefRangeEnd = 280489, XrefRangeStart = 280468, XrefRangeEnd = 280487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HIDGyroscope(UpdateLoopSetting updateLoopSetting, byte reportId, HIDControllerElement.HIDInfo hidInfo, int valueLength, int startingEventCapacity, Action<Il2CppStructArray<byte>, Il2CppStructArray<float>> calcValueDelegate, Func<float> getSensorDeltaTimeDelegate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoopSetting;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reportId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hidInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startingEventCapacity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(calcValueDelegate);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getSensorDeltaTimeDelegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Byte_HIDInfo_Int32_Int32_Action_2_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_Func_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x0009BAA8 File Offset: 0x00099CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280489, XrefRangeEnd = 280501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateValue(NativeBuffer inputReport, double timestamp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputReport);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timestamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDGyroscope.NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x0009BB04 File Offset: 0x00099D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280501, XrefRangeEnd = 280508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValueManual(Il2CppStructArray<float> value, double timestamp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timestamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.NativeMethodInfoPtr_UpdateValueManual_Public_Void_Il2CppStructArray_1_Single_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x0000C088 File Offset: 0x0000A288
		public HIDGyroscope(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x0009BB54 File Offset: 0x00099D54
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x0000C091 File Offset: 0x0000A291
		public unsafe double timestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_timestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_timestamp)) = value;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x0009BB7C File Offset: 0x00099D7C
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x0000C0AC File Offset: 0x0000A2AC
		public unsafe Il2CppStructArray<float> lastRawValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_lastRawValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_lastRawValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x0009BBAC File Offset: 0x00099DAC
		// (set) Token: 0x06001D3C RID: 7484 RVA: 0x0000C0CB File Offset: 0x0000A2CB
		public unsafe int valueLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_valueLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_valueLength)) = value;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x0009BBD4 File Offset: 0x00099DD4
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x0000C0E6 File Offset: 0x0000A2E6
		public unsafe Il2CppStructArray<byte> JundODLxEaEphASnfpeoeHgDBdvQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_JundODLxEaEphASnfpeoeHgDBdvQ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_JundODLxEaEphASnfpeoeHgDBdvQ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x0009BC04 File Offset: 0x00099E04
		// (set) Token: 0x06001D40 RID: 7488 RVA: 0x0000C105 File Offset: 0x0000A305
		public unsafe Il2CppStructArray<float> nVQBrTgrFEOGnYxIFvuzudTwQOP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_nVQBrTgrFEOGnYxIFvuzudTwQOP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_nVQBrTgrFEOGnYxIFvuzudTwQOP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x0009BC34 File Offset: 0x00099E34
		// (set) Token: 0x06001D42 RID: 7490 RVA: 0x0000C124 File Offset: 0x0000A324
		public unsafe int IoVcqiINSOZWWvsKrcebJLeofeXb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_IoVcqiINSOZWWvsKrcebJLeofeXb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_IoVcqiINSOZWWvsKrcebJLeofeXb)) = value;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x0009BC5C File Offset: 0x00099E5C
		// (set) Token: 0x06001D44 RID: 7492 RVA: 0x0000C13F File Offset: 0x0000A33F
		public unsafe int GwdIvCWNdssamWnbvEZeEcJFfiEE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_GwdIvCWNdssamWnbvEZeEcJFfiEE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_GwdIvCWNdssamWnbvEZeEcJFfiEE)) = value;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x0009BC84 File Offset: 0x00099E84
		// (set) Token: 0x06001D46 RID: 7494 RVA: 0x0000C15A File Offset: 0x0000A35A
		public unsafe Action<Il2CppStructArray<byte>, Il2CppStructArray<float>> afkGLXHGxIeTZtbNvjRtofPdBs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_afkGLXHGxIeTZtbNvjRtofPdBs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppStructArray<byte>, Il2CppStructArray<float>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_afkGLXHGxIeTZtbNvjRtofPdBs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001D47 RID: 7495 RVA: 0x0009BCB4 File Offset: 0x00099EB4
		// (set) Token: 0x06001D48 RID: 7496 RVA: 0x0000C179 File Offset: 0x0000A379
		public unsafe Func<float> raYeHXsDFIavEqaNhFaBrfLxmps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_raYeHXsDFIavEqaNhFaBrfLxmps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.NativeFieldInfoPtr_raYeHXsDFIavEqaNhFaBrfLxmps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeFieldInfoPtr_timestamp;

		// Token: 0x04001879 RID: 6265
		private static readonly IntPtr NativeFieldInfoPtr_lastRawValue;

		// Token: 0x0400187A RID: 6266
		private static readonly IntPtr NativeFieldInfoPtr_valueLength;

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeFieldInfoPtr_JundODLxEaEphASnfpeoeHgDBdvQ;

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeFieldInfoPtr_nVQBrTgrFEOGnYxIFvuzudTwQOP;

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeFieldInfoPtr_IoVcqiINSOZWWvsKrcebJLeofeXb;

		// Token: 0x0400187E RID: 6270
		private static readonly IntPtr NativeFieldInfoPtr_GwdIvCWNdssamWnbvEZeEcJFfiEE;

		// Token: 0x0400187F RID: 6271
		private static readonly IntPtr NativeFieldInfoPtr_afkGLXHGxIeTZtbNvjRtofPdBs;

		// Token: 0x04001880 RID: 6272
		private static readonly IntPtr NativeFieldInfoPtr_raYeHXsDFIavEqaNhFaBrfLxmps;

		// Token: 0x04001881 RID: 6273
		private static readonly IntPtr NativeMethodInfoPtr_get_rawValue_Public_get_Il2CppStructArray_1_Single_0;

		// Token: 0x04001882 RID: 6274
		private static readonly IntPtr NativeMethodInfoPtr_get_events_Public_get_ExpandableArray_DataContainer_1_vwnDNljqUPuTIauvXLOcbBHPCtP_0;

		// Token: 0x04001883 RID: 6275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Byte_HIDInfo_Int32_Int32_Action_2_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_Func_1_Single_0;

		// Token: 0x04001884 RID: 6276
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0;

		// Token: 0x04001885 RID: 6277
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueManual_Public_Void_Il2CppStructArray_1_Single_Double_0;

		// Token: 0x02000332 RID: 818
		public class MnhkECeeMdXLdxRXUZrHbFSeKsE : HIDControllerElementWithDataSet.minEAYGbVFUHmbVTFIBMhSqoDeq
		{
			// Token: 0x0600456E RID: 17774 RVA: 0x00143C64 File Offset: 0x00141E64
			// Note: this type is marked as 'beforefieldinit'.
			static MnhkECeeMdXLdxRXUZrHbFSeKsE()
			{
				Il2CppClassPointerStore<HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, "MnhkECeeMdXLdxRXUZrHbFSeKsE");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE>.NativeClassPtr);
				HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeFieldInfoPtr_JmYyvUQdgxvhnFoWZbPakTNJFzsS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE>.NativeClassPtr, "JmYyvUQdgxvhnFoWZbPakTNJFzsS");
				HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeFieldInfoPtr_TajxlqKQUwBMsbotxeGzIFPlxhxl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE>.NativeClassPtr, "TajxlqKQUwBMsbotxeGzIFPlxhxl");
				HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeMethodInfoPtr_get_rawValue_Public_get_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE>.NativeClassPtr, 100669727);
				HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeMethodInfoPtr_get_events_Public_get_ExpandableArray_DataContainer_1_vwnDNljqUPuTIauvXLOcbBHPCtP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE>.NativeClassPtr, 100669728);
				HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE>.NativeClassPtr, 100669729);
				HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE>.NativeClassPtr, 100669730);
				HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeMethodInfoPtr_jkUaLcbChPEHRJegvDmHOiAaMZeE_Public_Void_Il2CppStructArray_1_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE>.NativeClassPtr, 100669731);
				HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeMethodInfoPtr_OwSsHQYknVfsJiONulcvlzQrCNCM_Private_SqbCLQdqFuOIjgxIadvYefGbeDa_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE>.NativeClassPtr, 100669732);
			}

			// Token: 0x170015B3 RID: 5555
			// (get) Token: 0x0600456F RID: 17775 RVA: 0x00143D30 File Offset: 0x00141F30
			public unsafe Il2CppStructArray<float> LRAQnYJfYbfJiZXUBcvaHQGOZrr
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280355, XrefRangeEnd = 280357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeMethodInfoPtr_get_rawValue_Public_get_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
				}
			}

			// Token: 0x170015B4 RID: 5556
			// (get) Token: 0x06004570 RID: 17776 RVA: 0x00143D70 File Offset: 0x00141F70
			public unsafe ExpandableArray_DataContainer<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP> tIMjiXzruseQtWLwkdgUCdhgOHIR
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280357, XrefRangeEnd = 280359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeMethodInfoPtr_get_events_Public_get_ExpandableArray_DataContainer_1_vwnDNljqUPuTIauvXLOcbBHPCtP_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpandableArray_DataContainer<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>>(intPtr3) : null;
				}
			}

			// Token: 0x06004571 RID: 17777 RVA: 0x00143DB0 File Offset: 0x00141FB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280359, XrefRangeEnd = 280366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MnhkECeeMdXLdxRXUZrHbFSeKsE(UpdateLoopSetting updateLoopSetting, int valueLength, int eventCapacity)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref updateLoopSetting;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueLength;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004572 RID: 17778 RVA: 0x00143E14 File Offset: 0x00142014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280366, XrefRangeEnd = 280374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void xozDTcGUrsCTUDmjINWIvPSceAOJ(UpdateLoopType A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Virtual_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004573 RID: 17779 RVA: 0x00143E60 File Offset: 0x00142060
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 280383, RefRangeEnd = 280385, XrefRangeStart = 280374, XrefRangeEnd = 280383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void jkUaLcbChPEHRJegvDmHOiAaMZeE(Il2CppStructArray<float> A_1, float A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeMethodInfoPtr_jkUaLcbChPEHRJegvDmHOiAaMZeE_Public_Void_Il2CppStructArray_1_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004574 RID: 17780 RVA: 0x00143EB0 File Offset: 0x001420B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280385, XrefRangeEnd = 280389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa OwSsHQYknVfsJiONulcvlzQrCNCM(UpdateLoopType A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeMethodInfoPtr_OwSsHQYknVfsJiONulcvlzQrCNCM_Private_SqbCLQdqFuOIjgxIadvYefGbeDa_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa>(intPtr3) : null;
				}
			}

			// Token: 0x06004575 RID: 17781 RVA: 0x00019013 File Offset: 0x00017213
			public MnhkECeeMdXLdxRXUZrHbFSeKsE(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015B1 RID: 5553
			// (get) Token: 0x06004576 RID: 17782 RVA: 0x00143EFC File Offset: 0x001420FC
			// (set) Token: 0x06004577 RID: 17783 RVA: 0x0001901C File Offset: 0x0001721C
			public unsafe int JmYyvUQdgxvhnFoWZbPakTNJFzsS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeFieldInfoPtr_JmYyvUQdgxvhnFoWZbPakTNJFzsS);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeFieldInfoPtr_JmYyvUQdgxvhnFoWZbPakTNJFzsS)) = value;
				}
			}

			// Token: 0x170015B2 RID: 5554
			// (get) Token: 0x06004578 RID: 17784 RVA: 0x00143F24 File Offset: 0x00142124
			// (set) Token: 0x06004579 RID: 17785 RVA: 0x00019037 File Offset: 0x00017237
			public unsafe int TajxlqKQUwBMsbotxeGzIFPlxhxl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeFieldInfoPtr_TajxlqKQUwBMsbotxeGzIFPlxhxl);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.MnhkECeeMdXLdxRXUZrHbFSeKsE.NativeFieldInfoPtr_TajxlqKQUwBMsbotxeGzIFPlxhxl)) = value;
				}
			}

			// Token: 0x040038C9 RID: 14537
			private static readonly IntPtr NativeFieldInfoPtr_JmYyvUQdgxvhnFoWZbPakTNJFzsS;

			// Token: 0x040038CA RID: 14538
			private static readonly IntPtr NativeFieldInfoPtr_TajxlqKQUwBMsbotxeGzIFPlxhxl;

			// Token: 0x040038CB RID: 14539
			private static readonly IntPtr NativeMethodInfoPtr_get_rawValue_Public_get_Il2CppStructArray_1_Single_0;

			// Token: 0x040038CC RID: 14540
			private static readonly IntPtr NativeMethodInfoPtr_get_events_Public_get_ExpandableArray_DataContainer_1_vwnDNljqUPuTIauvXLOcbBHPCtP_0;

			// Token: 0x040038CD RID: 14541
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_Int32_Int32_0;

			// Token: 0x040038CE RID: 14542
			private static readonly IntPtr NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Virtual_Void_UpdateLoopType_0;

			// Token: 0x040038CF RID: 14543
			private static readonly IntPtr NativeMethodInfoPtr_jkUaLcbChPEHRJegvDmHOiAaMZeE_Public_Void_Il2CppStructArray_1_Single_Single_0;

			// Token: 0x040038D0 RID: 14544
			private static readonly IntPtr NativeMethodInfoPtr_OwSsHQYknVfsJiONulcvlzQrCNCM_Private_SqbCLQdqFuOIjgxIadvYefGbeDa_UpdateLoopType_0;
		}

		// Token: 0x02000333 RID: 819
		public class fWEvRWEzSFCooTiEfWYUrVWngEK : HIDControllerElementWithDataSet.SqbCLQdqFuOIjgxIadvYefGbeDa
		{
			// Token: 0x0600457A RID: 17786 RVA: 0x00143F4C File Offset: 0x0014214C
			// Note: this type is marked as 'beforefieldinit'.
			static fWEvRWEzSFCooTiEfWYUrVWngEK()
			{
				Il2CppClassPointerStore<HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, "fWEvRWEzSFCooTiEfWYUrVWngEK");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK>.NativeClassPtr);
				HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeFieldInfoPtr_cbeHzhBTmSBSCwKQcEjrZHzloPR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK>.NativeClassPtr, "cbeHzhBTmSBSCwKQcEjrZHzloPR");
				HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeFieldInfoPtr_LRAQnYJfYbfJiZXUBcvaHQGOZrr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK>.NativeClassPtr, "LRAQnYJfYbfJiZXUBcvaHQGOZrr");
				HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeFieldInfoPtr_tIMjiXzruseQtWLwkdgUCdhgOHIR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK>.NativeClassPtr, "tIMjiXzruseQtWLwkdgUCdhgOHIR");
				HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeFieldInfoPtr_LyIXgKzWahGAShNtuSONjxktFqh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK>.NativeClassPtr, "LyIXgKzWahGAShNtuSONjxktFqh");
				HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK>.NativeClassPtr, 100669733);
				HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK>.NativeClassPtr, 100669734);
				HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeMethodInfoPtr_qbabBoCchObNoGQlgRnPgBFhYMaL_Public_Void_Il2CppStructArray_1_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK>.NativeClassPtr, 100669735);
				HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK>.NativeClassPtr, 100669736);
			}

			// Token: 0x0600457B RID: 17787 RVA: 0x00144018 File Offset: 0x00142218
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 280404, RefRangeEnd = 280405, XrefRangeStart = 280389, XrefRangeEnd = 280404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe fWEvRWEzSFCooTiEfWYUrVWngEK(UpdateLoopType updateLoop, int valueLength, int eventCapacity)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref updateLoop;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueLength;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopType_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600457C RID: 17788 RVA: 0x0014407C File Offset: 0x0014227C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 280433, RefRangeEnd = 280434, XrefRangeStart = 280405, XrefRangeEnd = 280433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void xozDTcGUrsCTUDmjINWIvPSceAOJ()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600457D RID: 17789 RVA: 0x001440B0 File Offset: 0x001422B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280434, XrefRangeEnd = 280440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void qbabBoCchObNoGQlgRnPgBFhYMaL(Il2CppStructArray<float> A_1, float A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeMethodInfoPtr_qbabBoCchObNoGQlgRnPgBFhYMaL_Public_Void_Il2CppStructArray_1_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600457E RID: 17790 RVA: 0x00144100 File Offset: 0x00142300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280440, XrefRangeEnd = 280447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void vsfKIEzLYgmvYXdfRKJgdqwirYk()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600457F RID: 17791 RVA: 0x00019052 File Offset: 0x00017252
			public fWEvRWEzSFCooTiEfWYUrVWngEK(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015B5 RID: 5557
			// (get) Token: 0x06004580 RID: 17792 RVA: 0x0014413C File Offset: 0x0014233C
			// (set) Token: 0x06004581 RID: 17793 RVA: 0x0001905B File Offset: 0x0001725B
			public unsafe Il2CppStructArray<float> cbeHzhBTmSBSCwKQcEjrZHzloPR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeFieldInfoPtr_cbeHzhBTmSBSCwKQcEjrZHzloPR);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeFieldInfoPtr_cbeHzhBTmSBSCwKQcEjrZHzloPR), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B6 RID: 5558
			// (get) Token: 0x06004582 RID: 17794 RVA: 0x0014416C File Offset: 0x0014236C
			// (set) Token: 0x06004583 RID: 17795 RVA: 0x0001907A File Offset: 0x0001727A
			public unsafe Il2CppStructArray<float> LRAQnYJfYbfJiZXUBcvaHQGOZrr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeFieldInfoPtr_LRAQnYJfYbfJiZXUBcvaHQGOZrr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeFieldInfoPtr_LRAQnYJfYbfJiZXUBcvaHQGOZrr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B7 RID: 5559
			// (get) Token: 0x06004584 RID: 17796 RVA: 0x0014419C File Offset: 0x0014239C
			// (set) Token: 0x06004585 RID: 17797 RVA: 0x00019099 File Offset: 0x00017299
			public unsafe ExpandableArray_DataContainer<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP> tIMjiXzruseQtWLwkdgUCdhgOHIR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeFieldInfoPtr_tIMjiXzruseQtWLwkdgUCdhgOHIR);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandableArray_DataContainer<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeFieldInfoPtr_tIMjiXzruseQtWLwkdgUCdhgOHIR), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B8 RID: 5560
			// (get) Token: 0x06004586 RID: 17798 RVA: 0x001441CC File Offset: 0x001423CC
			// (set) Token: 0x06004587 RID: 17799 RVA: 0x000190B8 File Offset: 0x000172B8
			public unsafe ExpandableArray_DataContainer<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP> LyIXgKzWahGAShNtuSONjxktFqh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeFieldInfoPtr_LyIXgKzWahGAShNtuSONjxktFqh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandableArray_DataContainer<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.fWEvRWEzSFCooTiEfWYUrVWngEK.NativeFieldInfoPtr_LyIXgKzWahGAShNtuSONjxktFqh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040038D1 RID: 14545
			private static readonly IntPtr NativeFieldInfoPtr_cbeHzhBTmSBSCwKQcEjrZHzloPR;

			// Token: 0x040038D2 RID: 14546
			private static readonly IntPtr NativeFieldInfoPtr_LRAQnYJfYbfJiZXUBcvaHQGOZrr;

			// Token: 0x040038D3 RID: 14547
			private static readonly IntPtr NativeFieldInfoPtr_tIMjiXzruseQtWLwkdgUCdhgOHIR;

			// Token: 0x040038D4 RID: 14548
			private static readonly IntPtr NativeFieldInfoPtr_LyIXgKzWahGAShNtuSONjxktFqh;

			// Token: 0x040038D5 RID: 14549
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopType_Int32_Int32_0;

			// Token: 0x040038D6 RID: 14550
			private static readonly IntPtr NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_0;

			// Token: 0x040038D7 RID: 14551
			private static readonly IntPtr NativeMethodInfoPtr_qbabBoCchObNoGQlgRnPgBFhYMaL_Public_Void_Il2CppStructArray_1_Single_Single_0;

			// Token: 0x040038D8 RID: 14552
			private static readonly IntPtr NativeMethodInfoPtr_vsfKIEzLYgmvYXdfRKJgdqwirYk_Public_Virtual_Void_0;
		}

		// Token: 0x02000334 RID: 820
		public class vwnDNljqUPuTIauvXLOcbBHPCtP : global::Il2CppSystem.Object
		{
			// Token: 0x06004588 RID: 17800 RVA: 0x001441FC File Offset: 0x001423FC
			// Note: this type is marked as 'beforefieldinit'.
			static vwnDNljqUPuTIauvXLOcbBHPCtP()
			{
				Il2CppClassPointerStore<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HIDGyroscope>.NativeClassPtr, "vwnDNljqUPuTIauvXLOcbBHPCtP");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>.NativeClassPtr);
				HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeFieldInfoPtr_LRAQnYJfYbfJiZXUBcvaHQGOZrr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>.NativeClassPtr, "LRAQnYJfYbfJiZXUBcvaHQGOZrr");
				HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeFieldInfoPtr_ysVsBUTiwWbFXiksdHmaiZeeDFGK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>.NativeClassPtr, "ysVsBUTiwWbFXiksdHmaiZeeDFGK");
				HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>.NativeClassPtr, 100669737);
				HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>.NativeClassPtr, 100669738);
				HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Public_Void_Il2CppStructArray_1_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>.NativeClassPtr, 100669739);
				HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Public_Virtual_Final_New_Void_vwnDNljqUPuTIauvXLOcbBHPCtP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>.NativeClassPtr, 100669740);
				HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeMethodInfoPtr_IrrqjlxJUgjJRmwPgXSuZpiUFbk_Public_Virtual_Final_New_Boolean_vwnDNljqUPuTIauvXLOcbBHPCtP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>.NativeClassPtr, 100669741);
				HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>.NativeClassPtr, 100669742);
				HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_vwnDNljqUPuTIauvXLOcbBHPCtP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>.NativeClassPtr, 100669743);
			}

			// Token: 0x06004589 RID: 17801 RVA: 0x001442DC File Offset: 0x001424DC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe vwnDNljqUPuTIauvXLOcbBHPCtP()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600458A RID: 17802 RVA: 0x00144318 File Offset: 0x00142518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280447, XrefRangeEnd = 280448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe vwnDNljqUPuTIauvXLOcbBHPCtP(Il2CppStructArray<float> rawValues, float deltaTime)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawValues);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600458B RID: 17803 RVA: 0x00144374 File Offset: 0x00142574
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 280448, RefRangeEnd = 280451, XrefRangeStart = 280448, XrefRangeEnd = 280448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MRZTryplKgDXZkLfSZwrsdDSOdq(Il2CppStructArray<float> A_1, float A_2)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Public_Void_Il2CppStructArray_1_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600458C RID: 17804 RVA: 0x001443C4 File Offset: 0x001425C4
			[CallerCount(0)]
			public unsafe virtual void MRZTryplKgDXZkLfSZwrsdDSOdq(HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Public_Virtual_Final_New_Void_vwnDNljqUPuTIauvXLOcbBHPCtP_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600458D RID: 17805 RVA: 0x00144408 File Offset: 0x00142608
			[CallerCount(0)]
			public unsafe virtual bool IrrqjlxJUgjJRmwPgXSuZpiUFbk(HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeMethodInfoPtr_IrrqjlxJUgjJRmwPgXSuZpiUFbk_Public_Virtual_Final_New_Boolean_vwnDNljqUPuTIauvXLOcbBHPCtP_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600458E RID: 17806 RVA: 0x00144458 File Offset: 0x00142658
			[CallerCount(0)]
			public unsafe virtual void GMFpQqtyJcjzYToWCrZsZQAhPYh()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600458F RID: 17807 RVA: 0x0014448C File Offset: 0x0014268C
			[CallerCount(0)]
			public unsafe virtual int CompareTo(HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_vwnDNljqUPuTIauvXLOcbBHPCtP_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004590 RID: 17808 RVA: 0x000190D7 File Offset: 0x000172D7
			public vwnDNljqUPuTIauvXLOcbBHPCtP(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015B9 RID: 5561
			// (get) Token: 0x06004591 RID: 17809 RVA: 0x001444DC File Offset: 0x001426DC
			// (set) Token: 0x06004592 RID: 17810 RVA: 0x000190E0 File Offset: 0x000172E0
			public unsafe Vector3 LRAQnYJfYbfJiZXUBcvaHQGOZrr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeFieldInfoPtr_LRAQnYJfYbfJiZXUBcvaHQGOZrr);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeFieldInfoPtr_LRAQnYJfYbfJiZXUBcvaHQGOZrr)) = value;
				}
			}

			// Token: 0x170015BA RID: 5562
			// (get) Token: 0x06004593 RID: 17811 RVA: 0x00144504 File Offset: 0x00142704
			// (set) Token: 0x06004594 RID: 17812 RVA: 0x000190FB File Offset: 0x000172FB
			public unsafe float ysVsBUTiwWbFXiksdHmaiZeeDFGK
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeFieldInfoPtr_ysVsBUTiwWbFXiksdHmaiZeeDFGK);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP.NativeFieldInfoPtr_ysVsBUTiwWbFXiksdHmaiZeeDFGK)) = value;
				}
			}

			// Token: 0x040038D9 RID: 14553
			private static readonly IntPtr NativeFieldInfoPtr_LRAQnYJfYbfJiZXUBcvaHQGOZrr;

			// Token: 0x040038DA RID: 14554
			private static readonly IntPtr NativeFieldInfoPtr_ysVsBUTiwWbFXiksdHmaiZeeDFGK;

			// Token: 0x040038DB RID: 14555
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040038DC RID: 14556
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Single_Single_0;

			// Token: 0x040038DD RID: 14557
			private static readonly IntPtr NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Public_Void_Il2CppStructArray_1_Single_Single_0;

			// Token: 0x040038DE RID: 14558
			private static readonly IntPtr NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Public_Virtual_Final_New_Void_vwnDNljqUPuTIauvXLOcbBHPCtP_0;

			// Token: 0x040038DF RID: 14559
			private static readonly IntPtr NativeMethodInfoPtr_IrrqjlxJUgjJRmwPgXSuZpiUFbk_Public_Virtual_Final_New_Boolean_vwnDNljqUPuTIauvXLOcbBHPCtP_0;

			// Token: 0x040038E0 RID: 14560
			private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Virtual_Final_New_Void_0;

			// Token: 0x040038E1 RID: 14561
			private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_vwnDNljqUPuTIauvXLOcbBHPCtP_0;
		}
	}
}
