using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;

namespace Il2CppRewired.HID
{
	// Token: 0x02000111 RID: 273
	public class HIDAccelerometer : HIDControllerElement
	{
		// Token: 0x06001A3B RID: 6715 RVA: 0x00093144 File Offset: 0x00091344
		// Note: this type is marked as 'beforefieldinit'.
		static HIDAccelerometer()
		{
			Il2CppClassPointerStore<HIDAccelerometer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID", "HIDAccelerometer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDAccelerometer>.NativeClassPtr);
			HIDAccelerometer.NativeFieldInfoPtr_rawValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDAccelerometer>.NativeClassPtr, "rawValue");
			HIDAccelerometer.NativeFieldInfoPtr_timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDAccelerometer>.NativeClassPtr, "timestamp");
			HIDAccelerometer.NativeFieldInfoPtr_valueLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDAccelerometer>.NativeClassPtr, "valueLength");
			HIDAccelerometer.NativeFieldInfoPtr_JundODLxEaEphASnfpeoeHgDBdvQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDAccelerometer>.NativeClassPtr, "JundODLxEaEphASnfpeoeHgDBdvQ");
			HIDAccelerometer.NativeFieldInfoPtr_IoVcqiINSOZWWvsKrcebJLeofeXb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDAccelerometer>.NativeClassPtr, "IoVcqiINSOZWWvsKrcebJLeofeXb");
			HIDAccelerometer.NativeFieldInfoPtr_GwdIvCWNdssamWnbvEZeEcJFfiEE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDAccelerometer>.NativeClassPtr, "GwdIvCWNdssamWnbvEZeEcJFfiEE");
			HIDAccelerometer.NativeFieldInfoPtr_afkGLXHGxIeTZtbNvjRtofPdBs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDAccelerometer>.NativeClassPtr, "afkGLXHGxIeTZtbNvjRtofPdBs");
			HIDAccelerometer.NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_Int32_Action_2_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDAccelerometer>.NativeClassPtr, 100669491);
			HIDAccelerometer.NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDAccelerometer>.NativeClassPtr, 100669492);
			HIDAccelerometer.NativeMethodInfoPtr_UpdateValueManual_Public_Void_Il2CppStructArray_1_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDAccelerometer>.NativeClassPtr, 100669493);
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0009323C File Offset: 0x0009143C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279059, RefRangeEnd = 279061, XrefRangeStart = 279052, XrefRangeEnd = 279059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HIDAccelerometer(byte reportId, HIDControllerElement.HIDInfo hidInfo, int valueLength, Action<Il2CppStructArray<byte>, Il2CppStructArray<float>> calcValueDelegate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDAccelerometer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reportId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hidInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(calcValueDelegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDAccelerometer.NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_Int32_Action_2_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x000932B8 File Offset: 0x000914B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279061, XrefRangeEnd = 279066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDAccelerometer.NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00093314 File Offset: 0x00091514
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDAccelerometer.NativeMethodInfoPtr_UpdateValueManual_Public_Void_Il2CppStructArray_1_Single_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0000ABAB File Offset: 0x00008DAB
		public HIDAccelerometer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001A40 RID: 6720 RVA: 0x00093364 File Offset: 0x00091564
		// (set) Token: 0x06001A41 RID: 6721 RVA: 0x0000ABB4 File Offset: 0x00008DB4
		public unsafe Il2CppStructArray<float> rawValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAccelerometer.NativeFieldInfoPtr_rawValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAccelerometer.NativeFieldInfoPtr_rawValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001A42 RID: 6722 RVA: 0x00093394 File Offset: 0x00091594
		// (set) Token: 0x06001A43 RID: 6723 RVA: 0x0000ABD3 File Offset: 0x00008DD3
		public unsafe double timestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAccelerometer.NativeFieldInfoPtr_timestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAccelerometer.NativeFieldInfoPtr_timestamp)) = value;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001A44 RID: 6724 RVA: 0x000933BC File Offset: 0x000915BC
		// (set) Token: 0x06001A45 RID: 6725 RVA: 0x0000ABEE File Offset: 0x00008DEE
		public unsafe int valueLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAccelerometer.NativeFieldInfoPtr_valueLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAccelerometer.NativeFieldInfoPtr_valueLength)) = value;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001A46 RID: 6726 RVA: 0x000933E4 File Offset: 0x000915E4
		// (set) Token: 0x06001A47 RID: 6727 RVA: 0x0000AC09 File Offset: 0x00008E09
		public unsafe Il2CppStructArray<byte> JundODLxEaEphASnfpeoeHgDBdvQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAccelerometer.NativeFieldInfoPtr_JundODLxEaEphASnfpeoeHgDBdvQ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAccelerometer.NativeFieldInfoPtr_JundODLxEaEphASnfpeoeHgDBdvQ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001A48 RID: 6728 RVA: 0x00093414 File Offset: 0x00091614
		// (set) Token: 0x06001A49 RID: 6729 RVA: 0x0000AC28 File Offset: 0x00008E28
		public unsafe int IoVcqiINSOZWWvsKrcebJLeofeXb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAccelerometer.NativeFieldInfoPtr_IoVcqiINSOZWWvsKrcebJLeofeXb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAccelerometer.NativeFieldInfoPtr_IoVcqiINSOZWWvsKrcebJLeofeXb)) = value;
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001A4A RID: 6730 RVA: 0x0009343C File Offset: 0x0009163C
		// (set) Token: 0x06001A4B RID: 6731 RVA: 0x0000AC43 File Offset: 0x00008E43
		public unsafe int GwdIvCWNdssamWnbvEZeEcJFfiEE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAccelerometer.NativeFieldInfoPtr_GwdIvCWNdssamWnbvEZeEcJFfiEE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAccelerometer.NativeFieldInfoPtr_GwdIvCWNdssamWnbvEZeEcJFfiEE)) = value;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x00093464 File Offset: 0x00091664
		// (set) Token: 0x06001A4D RID: 6733 RVA: 0x0000AC5E File Offset: 0x00008E5E
		public unsafe Action<Il2CppStructArray<byte>, Il2CppStructArray<float>> afkGLXHGxIeTZtbNvjRtofPdBs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAccelerometer.NativeFieldInfoPtr_afkGLXHGxIeTZtbNvjRtofPdBs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppStructArray<byte>, Il2CppStructArray<float>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAccelerometer.NativeFieldInfoPtr_afkGLXHGxIeTZtbNvjRtofPdBs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400168C RID: 5772
		private static readonly IntPtr NativeFieldInfoPtr_rawValue;

		// Token: 0x0400168D RID: 5773
		private static readonly IntPtr NativeFieldInfoPtr_timestamp;

		// Token: 0x0400168E RID: 5774
		private static readonly IntPtr NativeFieldInfoPtr_valueLength;

		// Token: 0x0400168F RID: 5775
		private static readonly IntPtr NativeFieldInfoPtr_JundODLxEaEphASnfpeoeHgDBdvQ;

		// Token: 0x04001690 RID: 5776
		private static readonly IntPtr NativeFieldInfoPtr_IoVcqiINSOZWWvsKrcebJLeofeXb;

		// Token: 0x04001691 RID: 5777
		private static readonly IntPtr NativeFieldInfoPtr_GwdIvCWNdssamWnbvEZeEcJFfiEE;

		// Token: 0x04001692 RID: 5778
		private static readonly IntPtr NativeFieldInfoPtr_afkGLXHGxIeTZtbNvjRtofPdBs;

		// Token: 0x04001693 RID: 5779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_Int32_Action_2_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_0;

		// Token: 0x04001694 RID: 5780
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0;

		// Token: 0x04001695 RID: 5781
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueManual_Public_Void_Il2CppStructArray_1_Single_Double_0;
	}
}
