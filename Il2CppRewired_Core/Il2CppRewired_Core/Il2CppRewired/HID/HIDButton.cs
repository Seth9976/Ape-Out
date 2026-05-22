using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppRewired.Utils.Classes.Data;

namespace Il2CppRewired.HID
{
	// Token: 0x02000113 RID: 275
	public class HIDButton : HIDControllerElement
	{
		// Token: 0x06001A62 RID: 6754 RVA: 0x000937A0 File Offset: 0x000919A0
		// Note: this type is marked as 'beforefieldinit'.
		static HIDButton()
		{
			Il2CppClassPointerStore<HIDButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID", "HIDButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDButton>.NativeClassPtr);
			HIDButton.NativeFieldInfoPtr_rawValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDButton>.NativeClassPtr, "rawValue");
			HIDButton.NativeFieldInfoPtr_timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDButton>.NativeClassPtr, "timestamp");
			HIDButton.NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDButton>.NativeClassPtr, 100669496);
			HIDButton.NativeMethodInfoPtr_SetValue_Public_Void_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDButton>.NativeClassPtr, 100669497);
			HIDButton.NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDButton>.NativeClassPtr, 100669498);
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x00093834 File Offset: 0x00091A34
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 126351, RefRangeEnd = 126356, XrefRangeStart = 126351, XrefRangeEnd = 126356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HIDButton(byte reportId, HIDControllerElement.HIDInfo hidInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDButton>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reportId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hidInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDButton.NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00093890 File Offset: 0x00091A90
		[CallerCount(0)]
		public unsafe void SetValue(bool rawValue, double timestamp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rawValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timestamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDButton.NativeMethodInfoPtr_SetValue_Public_Void_Boolean_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x000938DC File Offset: 0x00091ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279072, XrefRangeEnd = 279073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDButton.NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x0000AD5E File Offset: 0x00008F5E
		public HIDButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x00093938 File Offset: 0x00091B38
		// (set) Token: 0x06001A68 RID: 6760 RVA: 0x0000AD67 File Offset: 0x00008F67
		public unsafe bool rawValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDButton.NativeFieldInfoPtr_rawValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDButton.NativeFieldInfoPtr_rawValue)) = value;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x00093960 File Offset: 0x00091B60
		// (set) Token: 0x06001A6A RID: 6762 RVA: 0x0000AD82 File Offset: 0x00008F82
		public unsafe double timestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDButton.NativeFieldInfoPtr_timestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDButton.NativeFieldInfoPtr_timestamp)) = value;
			}
		}

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeFieldInfoPtr_rawValue;

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeFieldInfoPtr_timestamp;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_0;

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Boolean_Double_0;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0;
	}
}
