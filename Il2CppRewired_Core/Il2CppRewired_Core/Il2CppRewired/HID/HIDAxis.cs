using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppRewired.Utils.Classes.Data;

namespace Il2CppRewired.HID
{
	// Token: 0x02000112 RID: 274
	public class HIDAxis : HIDControllerElement
	{
		// Token: 0x06001A4E RID: 6734 RVA: 0x00093494 File Offset: 0x00091694
		// Note: this type is marked as 'beforefieldinit'.
		static HIDAxis()
		{
			Il2CppClassPointerStore<HIDAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID", "HIDAxis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDAxis>.NativeClassPtr);
			HIDAxis.NativeFieldInfoPtr_rawValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDAxis>.NativeClassPtr, "rawValue");
			HIDAxis.NativeFieldInfoPtr_timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDAxis>.NativeClassPtr, "timestamp");
			HIDAxis.NativeFieldInfoPtr_byteLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDAxis>.NativeClassPtr, "byteLength");
			HIDAxis.NativeFieldInfoPtr_startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDAxis>.NativeClassPtr, "startIndex");
			HIDAxis.NativeFieldInfoPtr_isSigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDAxis>.NativeClassPtr, "isSigned");
			HIDAxis.NativeFieldInfoPtr_minValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDAxis>.NativeClassPtr, "minValue");
			HIDAxis.NativeFieldInfoPtr_maxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDAxis>.NativeClassPtr, "maxValue");
			HIDAxis.NativeFieldInfoPtr_zeroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDAxis>.NativeClassPtr, "zeroValue");
			HIDAxis.NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDAxis>.NativeClassPtr, 100669494);
			HIDAxis.NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDAxis>.NativeClassPtr, 100669495);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0009358C File Offset: 0x0009178C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279067, RefRangeEnd = 279068, XrefRangeStart = 279066, XrefRangeEnd = 279067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HIDAxis(byte reportId, HIDControllerElement.HIDInfo hidInfo, bool isSigned, int zeroValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDAxis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reportId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hidInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSigned;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zeroValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDAxis.NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00093604 File Offset: 0x00091804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279068, XrefRangeEnd = 279072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDAxis.NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0000AC7D File Offset: 0x00008E7D
		public HIDAxis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x00093660 File Offset: 0x00091860
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x0000AC86 File Offset: 0x00008E86
		public unsafe int rawValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAxis.NativeFieldInfoPtr_rawValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAxis.NativeFieldInfoPtr_rawValue)) = value;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x00093688 File Offset: 0x00091888
		// (set) Token: 0x06001A55 RID: 6741 RVA: 0x0000ACA1 File Offset: 0x00008EA1
		public unsafe double timestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAxis.NativeFieldInfoPtr_timestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAxis.NativeFieldInfoPtr_timestamp)) = value;
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x000936B0 File Offset: 0x000918B0
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x0000ACBC File Offset: 0x00008EBC
		public unsafe int byteLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAxis.NativeFieldInfoPtr_byteLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAxis.NativeFieldInfoPtr_byteLength)) = value;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x000936D8 File Offset: 0x000918D8
		// (set) Token: 0x06001A59 RID: 6745 RVA: 0x0000ACD7 File Offset: 0x00008ED7
		public unsafe int startIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAxis.NativeFieldInfoPtr_startIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAxis.NativeFieldInfoPtr_startIndex)) = value;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x00093700 File Offset: 0x00091900
		// (set) Token: 0x06001A5B RID: 6747 RVA: 0x0000ACF2 File Offset: 0x00008EF2
		public unsafe bool isSigned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAxis.NativeFieldInfoPtr_isSigned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAxis.NativeFieldInfoPtr_isSigned)) = value;
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x00093728 File Offset: 0x00091928
		// (set) Token: 0x06001A5D RID: 6749 RVA: 0x0000AD0D File Offset: 0x00008F0D
		public unsafe int minValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAxis.NativeFieldInfoPtr_minValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAxis.NativeFieldInfoPtr_minValue)) = value;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x00093750 File Offset: 0x00091950
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x0000AD28 File Offset: 0x00008F28
		public unsafe int maxValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAxis.NativeFieldInfoPtr_maxValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAxis.NativeFieldInfoPtr_maxValue)) = value;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x00093778 File Offset: 0x00091978
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x0000AD43 File Offset: 0x00008F43
		public unsafe int zeroValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAxis.NativeFieldInfoPtr_zeroValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDAxis.NativeFieldInfoPtr_zeroValue)) = value;
			}
		}

		// Token: 0x04001696 RID: 5782
		private static readonly IntPtr NativeFieldInfoPtr_rawValue;

		// Token: 0x04001697 RID: 5783
		private static readonly IntPtr NativeFieldInfoPtr_timestamp;

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeFieldInfoPtr_byteLength;

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeFieldInfoPtr_startIndex;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeFieldInfoPtr_isSigned;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeFieldInfoPtr_minValue;

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeFieldInfoPtr_maxValue;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeFieldInfoPtr_zeroValue;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_Boolean_Int32_0;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0;
	}
}
