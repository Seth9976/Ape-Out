using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200010B RID: 267
	public class ControllerDataUpdater : Object
	{
		// Token: 0x06001A05 RID: 6661 RVA: 0x0009285C File Offset: 0x00090A5C
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerDataUpdater()
		{
			Il2CppClassPointerStore<ControllerDataUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerDataUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerDataUpdater>.NativeClassPtr);
			ControllerDataUpdater.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDataUpdater>.NativeClassPtr, "source");
			ControllerDataUpdater.NativeFieldInfoPtr_axisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDataUpdater>.NativeClassPtr, "axisCount");
			ControllerDataUpdater.NativeFieldInfoPtr_buttonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDataUpdater>.NativeClassPtr, "buttonCount");
			ControllerDataUpdater.NativeFieldInfoPtr_axisValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDataUpdater>.NativeClassPtr, "axisValues");
			ControllerDataUpdater.NativeFieldInfoPtr_buttonValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDataUpdater>.NativeClassPtr, "buttonValues");
			ControllerDataUpdater.NativeFieldInfoPtr_buttonPressureValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDataUpdater>.NativeClassPtr, "buttonPressureValues");
			ControllerDataUpdater.NativeFieldInfoPtr_axisHasBeenPressedOSXLinux = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDataUpdater>.NativeClassPtr, "axisHasBeenPressedOSXLinux");
			ControllerDataUpdater.NativeFieldInfoPtr_ltfzkGnkekMKPfuxoeGQgCGlDMHC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDataUpdater>.NativeClassPtr, "ltfzkGnkekMKPfuxoeGQgCGlDMHC");
			ControllerDataUpdater.NativeFieldInfoPtr_hasReceivedInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDataUpdater>.NativeClassPtr, "hasReceivedInput");
			ControllerDataUpdater.NativeMethodInfoPtr__ctor_Public_Void_InputSource_Int32_Int32_Il2CppReferenceArray_1_UnknownControllerHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataUpdater>.NativeClassPtr, 100669480);
			ControllerDataUpdater.NativeMethodInfoPtr_IsUnknownHatCardinal_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataUpdater>.NativeClassPtr, 100669481);
			ControllerDataUpdater.NativeMethodInfoPtr_GetUnknownHatButtons_Public_HatButtons_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataUpdater>.NativeClassPtr, 100669482);
			ControllerDataUpdater.NativeMethodInfoPtr_ClearData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataUpdater>.NativeClassPtr, 100669483);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00092990 File Offset: 0x00090B90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 279024, RefRangeEnd = 279029, XrefRangeStart = 279014, XrefRangeEnd = 279024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerDataUpdater(InputSource source, int axisCount, int buttonCount, Il2CppReferenceArray<UnknownControllerHat> unknownControllerHats)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerDataUpdater>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unknownControllerHats);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataUpdater.NativeMethodInfoPtr__ctor_Public_Void_InputSource_Int32_Int32_Il2CppReferenceArray_1_UnknownControllerHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00092A08 File Offset: 0x00090C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279029, XrefRangeEnd = 279031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUnknownHatCardinal(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataUpdater.NativeMethodInfoPtr_IsUnknownHatCardinal_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00092A54 File Offset: 0x00090C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279031, XrefRangeEnd = 279033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnknownControllerHat.HatButtons GetUnknownHatButtons(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataUpdater.NativeMethodInfoPtr_GetUnknownHatButtons_Public_HatButtons_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnknownControllerHat.HatButtons>(intPtr3) : null;
			}
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00092AA0 File Offset: 0x00090CA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279037, RefRangeEnd = 279039, XrefRangeStart = 279033, XrefRangeEnd = 279037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataUpdater.NativeMethodInfoPtr_ClearData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0000A9A9 File Offset: 0x00008BA9
		public ControllerDataUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x00092AD4 File Offset: 0x00090CD4
		// (set) Token: 0x06001A0C RID: 6668 RVA: 0x0000A9B2 File Offset: 0x00008BB2
		public unsafe InputSource source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_source);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_source)) = value;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001A0D RID: 6669 RVA: 0x00092AFC File Offset: 0x00090CFC
		// (set) Token: 0x06001A0E RID: 6670 RVA: 0x0000A9CD File Offset: 0x00008BCD
		public unsafe int axisCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_axisCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_axisCount)) = value;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x00092B24 File Offset: 0x00090D24
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x0000A9E8 File Offset: 0x00008BE8
		public unsafe int buttonCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_buttonCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_buttonCount)) = value;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x00092B4C File Offset: 0x00090D4C
		// (set) Token: 0x06001A12 RID: 6674 RVA: 0x0000AA03 File Offset: 0x00008C03
		public unsafe Il2CppStructArray<float> axisValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_axisValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_axisValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x00092B7C File Offset: 0x00090D7C
		// (set) Token: 0x06001A14 RID: 6676 RVA: 0x0000AA22 File Offset: 0x00008C22
		public unsafe Il2CppStructArray<bool> buttonValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_buttonValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_buttonValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x00092BAC File Offset: 0x00090DAC
		// (set) Token: 0x06001A16 RID: 6678 RVA: 0x0000AA41 File Offset: 0x00008C41
		public unsafe Il2CppStructArray<float> buttonPressureValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_buttonPressureValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_buttonPressureValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x00092BDC File Offset: 0x00090DDC
		// (set) Token: 0x06001A18 RID: 6680 RVA: 0x0000AA60 File Offset: 0x00008C60
		public unsafe Il2CppStructArray<bool> axisHasBeenPressedOSXLinux
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_axisHasBeenPressedOSXLinux);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_axisHasBeenPressedOSXLinux), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x00092C0C File Offset: 0x00090E0C
		// (set) Token: 0x06001A1A RID: 6682 RVA: 0x0000AA7F File Offset: 0x00008C7F
		public unsafe Il2CppReferenceArray<UnknownControllerHat> ltfzkGnkekMKPfuxoeGQgCGlDMHC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_ltfzkGnkekMKPfuxoeGQgCGlDMHC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnknownControllerHat>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_ltfzkGnkekMKPfuxoeGQgCGlDMHC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x00092C3C File Offset: 0x00090E3C
		// (set) Token: 0x06001A1C RID: 6684 RVA: 0x0000AA9E File Offset: 0x00008C9E
		public unsafe bool hasReceivedInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_hasReceivedInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataUpdater.NativeFieldInfoPtr_hasReceivedInput)) = value;
			}
		}

		// Token: 0x04001672 RID: 5746
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04001673 RID: 5747
		private static readonly IntPtr NativeFieldInfoPtr_axisCount;

		// Token: 0x04001674 RID: 5748
		private static readonly IntPtr NativeFieldInfoPtr_buttonCount;

		// Token: 0x04001675 RID: 5749
		private static readonly IntPtr NativeFieldInfoPtr_axisValues;

		// Token: 0x04001676 RID: 5750
		private static readonly IntPtr NativeFieldInfoPtr_buttonValues;

		// Token: 0x04001677 RID: 5751
		private static readonly IntPtr NativeFieldInfoPtr_buttonPressureValues;

		// Token: 0x04001678 RID: 5752
		private static readonly IntPtr NativeFieldInfoPtr_axisHasBeenPressedOSXLinux;

		// Token: 0x04001679 RID: 5753
		private static readonly IntPtr NativeFieldInfoPtr_ltfzkGnkekMKPfuxoeGQgCGlDMHC;

		// Token: 0x0400167A RID: 5754
		private static readonly IntPtr NativeFieldInfoPtr_hasReceivedInput;

		// Token: 0x0400167B RID: 5755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputSource_Int32_Int32_Il2CppReferenceArray_1_UnknownControllerHat_0;

		// Token: 0x0400167C RID: 5756
		private static readonly IntPtr NativeMethodInfoPtr_IsUnknownHatCardinal_Public_Boolean_Int32_0;

		// Token: 0x0400167D RID: 5757
		private static readonly IntPtr NativeMethodInfoPtr_GetUnknownHatButtons_Public_HatButtons_Int32_0;

		// Token: 0x0400167E RID: 5758
		private static readonly IntPtr NativeMethodInfoPtr_ClearData_Public_Void_0;
	}
}
