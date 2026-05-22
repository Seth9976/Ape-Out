using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.HID
{
	// Token: 0x02000123 RID: 291
	public class HIDTouchpad : HIDControllerElement
	{
		// Token: 0x06001DC8 RID: 7624 RVA: 0x0009DB1C File Offset: 0x0009BD1C
		// Note: this type is marked as 'beforefieldinit'.
		static HIDTouchpad()
		{
			Il2CppClassPointerStore<HIDTouchpad>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID", "HIDTouchpad");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDTouchpad>.NativeClassPtr);
			HIDTouchpad.NativeFieldInfoPtr_nfdVmUBPUJnDFGllTjkjmnPgqRn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad>.NativeClassPtr, "nfdVmUBPUJnDFGllTjkjmnPgqRn");
			HIDTouchpad.NativeFieldInfoPtr_tHKCAYQlUlfruJrNMSfkMlFsimSn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad>.NativeClassPtr, "tHKCAYQlUlfruJrNMSfkMlFsimSn");
			HIDTouchpad.NativeFieldInfoPtr_WjgppoHqnpdJhVtbCJzwhwVBCrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad>.NativeClassPtr, "WjgppoHqnpdJhVtbCJzwhwVBCrt");
			HIDTouchpad.NativeFieldInfoPtr_afkGLXHGxIeTZtbNvjRtofPdBs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad>.NativeClassPtr, "afkGLXHGxIeTZtbNvjRtofPdBs");
			HIDTouchpad.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad>.NativeClassPtr, "values");
			HIDTouchpad.NativeMethodInfoPtr__ctor_Public_Void_Byte_TouchpadInfo_HIDInfo_Action_2_NativeBuffer_Il2CppStructArray_1_TouchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDTouchpad>.NativeClassPtr, 100669822);
			HIDTouchpad.NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDTouchpad>.NativeClassPtr, 100669823);
			HIDTouchpad.NativeMethodInfoPtr_ProcessQueue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDTouchpad>.NativeClassPtr, 100669824);
			HIDTouchpad.NativeMethodInfoPtr_IsTouching_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDTouchpad>.NativeClassPtr, 100669825);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x0009DC00 File Offset: 0x0009BE00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280814, RefRangeEnd = 280816, XrefRangeStart = 280801, XrefRangeEnd = 280814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HIDTouchpad(byte reportId, HIDTouchpad.TouchpadInfo info, HIDControllerElement.HIDInfo hidInfo, Action<NativeBuffer, Il2CppStructArray<HIDTouchpad.TouchData>> calcValueDelegate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDTouchpad>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reportId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hidInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(calcValueDelegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDTouchpad.NativeMethodInfoPtr__ctor_Public_Void_Byte_TouchpadInfo_HIDInfo_Action_2_NativeBuffer_Il2CppStructArray_1_TouchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x0009DC80 File Offset: 0x0009BE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280816, XrefRangeEnd = 280827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDTouchpad.NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x0009DCDC File Offset: 0x0009BEDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280841, RefRangeEnd = 280842, XrefRangeStart = 280827, XrefRangeEnd = 280841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDTouchpad.NativeMethodInfoPtr_ProcessQueue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x0009DD10 File Offset: 0x0009BF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280842, XrefRangeEnd = 280843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTouching(int touchId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDTouchpad.NativeMethodInfoPtr_IsTouching_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x0000C4B7 File Offset: 0x0000A6B7
		public HIDTouchpad(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x0009DD5C File Offset: 0x0009BF5C
		// (set) Token: 0x06001DCF RID: 7631 RVA: 0x0000C4C0 File Offset: 0x0000A6C0
		public unsafe HIDTouchpad.TouchpadInfo nfdVmUBPUJnDFGllTjkjmnPgqRn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.NativeFieldInfoPtr_nfdVmUBPUJnDFGllTjkjmnPgqRn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HIDTouchpad.TouchpadInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.NativeFieldInfoPtr_nfdVmUBPUJnDFGllTjkjmnPgqRn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x0009DD8C File Offset: 0x0009BF8C
		// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x0000C4DF File Offset: 0x0000A6DF
		public unsafe Queue<HIDTouchpad.TouchData> tHKCAYQlUlfruJrNMSfkMlFsimSn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.NativeFieldInfoPtr_tHKCAYQlUlfruJrNMSfkMlFsimSn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<HIDTouchpad.TouchData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.NativeFieldInfoPtr_tHKCAYQlUlfruJrNMSfkMlFsimSn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x0009DDBC File Offset: 0x0009BFBC
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x0000C4FE File Offset: 0x0000A6FE
		public unsafe Il2CppStructArray<HIDTouchpad.TouchData> WjgppoHqnpdJhVtbCJzwhwVBCrt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.NativeFieldInfoPtr_WjgppoHqnpdJhVtbCJzwhwVBCrt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<HIDTouchpad.TouchData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.NativeFieldInfoPtr_WjgppoHqnpdJhVtbCJzwhwVBCrt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x0009DDEC File Offset: 0x0009BFEC
		// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x0000C51D File Offset: 0x0000A71D
		public unsafe Action<NativeBuffer, Il2CppStructArray<HIDTouchpad.TouchData>> afkGLXHGxIeTZtbNvjRtofPdBs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.NativeFieldInfoPtr_afkGLXHGxIeTZtbNvjRtofPdBs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NativeBuffer, Il2CppStructArray<HIDTouchpad.TouchData>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.NativeFieldInfoPtr_afkGLXHGxIeTZtbNvjRtofPdBs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x0009DE1C File Offset: 0x0009C01C
		// (set) Token: 0x06001DD7 RID: 7639 RVA: 0x0000C53C File Offset: 0x0000A73C
		public unsafe Il2CppStructArray<HIDTouchpad.TouchData> values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<HIDTouchpad.TouchData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018DD RID: 6365
		private static readonly IntPtr NativeFieldInfoPtr_nfdVmUBPUJnDFGllTjkjmnPgqRn;

		// Token: 0x040018DE RID: 6366
		private static readonly IntPtr NativeFieldInfoPtr_tHKCAYQlUlfruJrNMSfkMlFsimSn;

		// Token: 0x040018DF RID: 6367
		private static readonly IntPtr NativeFieldInfoPtr_WjgppoHqnpdJhVtbCJzwhwVBCrt;

		// Token: 0x040018E0 RID: 6368
		private static readonly IntPtr NativeFieldInfoPtr_afkGLXHGxIeTZtbNvjRtofPdBs;

		// Token: 0x040018E1 RID: 6369
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x040018E2 RID: 6370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_TouchpadInfo_HIDInfo_Action_2_NativeBuffer_Il2CppStructArray_1_TouchData_0;

		// Token: 0x040018E3 RID: 6371
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0;

		// Token: 0x040018E4 RID: 6372
		private static readonly IntPtr NativeMethodInfoPtr_ProcessQueue_Public_Void_0;

		// Token: 0x040018E5 RID: 6373
		private static readonly IntPtr NativeMethodInfoPtr_IsTouching_Public_Boolean_Int32_0;

		// Token: 0x0200033A RID: 826
		public class TouchpadInfo : Object
		{
			// Token: 0x060045CC RID: 17868 RVA: 0x00145130 File Offset: 0x00143330
			// Note: this type is marked as 'beforefieldinit'.
			static TouchpadInfo()
			{
				Il2CppClassPointerStore<HIDTouchpad.TouchpadInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HIDTouchpad>.NativeClassPtr, "TouchpadInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDTouchpad.TouchpadInfo>.NativeClassPtr);
				HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_maxTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad.TouchpadInfo>.NativeClassPtr, "maxTouches");
				HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_minX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad.TouchpadInfo>.NativeClassPtr, "minX");
				HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_maxX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad.TouchpadInfo>.NativeClassPtr, "maxX");
				HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_minY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad.TouchpadInfo>.NativeClassPtr, "minY");
				HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_maxY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad.TouchpadInfo>.NativeClassPtr, "maxY");
				HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_invertY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad.TouchpadInfo>.NativeClassPtr, "invertY");
				HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_reverseY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad.TouchpadInfo>.NativeClassPtr, "reverseY");
				HIDTouchpad.TouchpadInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDTouchpad.TouchpadInfo>.NativeClassPtr, 100669826);
				HIDTouchpad.TouchpadInfo.NativeMethodInfoPtr_CalculateTouch_Public_Void_byref_TouchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDTouchpad.TouchpadInfo>.NativeClassPtr, 100669827);
			}

			// Token: 0x060045CD RID: 17869 RVA: 0x00145210 File Offset: 0x00143410
			[CallerCount(0)]
			public unsafe TouchpadInfo(int maxTouches, int minX, int maxX, int minY, int maxY, bool invertY, bool reverseY)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDTouchpad.TouchpadInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref maxTouches;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minX;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxX;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minY;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxY;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invertY;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverseY;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDTouchpad.TouchpadInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045CE RID: 17870 RVA: 0x001452AC File Offset: 0x001434AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280798, XrefRangeEnd = 280801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CalculateTouch(ref HIDTouchpad.TouchData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &data;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDTouchpad.TouchpadInfo.NativeMethodInfoPtr_CalculateTouch_Public_Void_byref_TouchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060045CF RID: 17871 RVA: 0x000192AD File Offset: 0x000174AD
			public TouchpadInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015C8 RID: 5576
			// (get) Token: 0x060045D0 RID: 17872 RVA: 0x001452EC File Offset: 0x001434EC
			// (set) Token: 0x060045D1 RID: 17873 RVA: 0x000192B6 File Offset: 0x000174B6
			public unsafe int maxTouches
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_maxTouches);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_maxTouches)) = value;
				}
			}

			// Token: 0x170015C9 RID: 5577
			// (get) Token: 0x060045D2 RID: 17874 RVA: 0x00145314 File Offset: 0x00143514
			// (set) Token: 0x060045D3 RID: 17875 RVA: 0x000192D1 File Offset: 0x000174D1
			public unsafe int minX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_minX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_minX)) = value;
				}
			}

			// Token: 0x170015CA RID: 5578
			// (get) Token: 0x060045D4 RID: 17876 RVA: 0x0014533C File Offset: 0x0014353C
			// (set) Token: 0x060045D5 RID: 17877 RVA: 0x000192EC File Offset: 0x000174EC
			public unsafe int maxX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_maxX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_maxX)) = value;
				}
			}

			// Token: 0x170015CB RID: 5579
			// (get) Token: 0x060045D6 RID: 17878 RVA: 0x00145364 File Offset: 0x00143564
			// (set) Token: 0x060045D7 RID: 17879 RVA: 0x00019307 File Offset: 0x00017507
			public unsafe int minY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_minY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_minY)) = value;
				}
			}

			// Token: 0x170015CC RID: 5580
			// (get) Token: 0x060045D8 RID: 17880 RVA: 0x0014538C File Offset: 0x0014358C
			// (set) Token: 0x060045D9 RID: 17881 RVA: 0x00019322 File Offset: 0x00017522
			public unsafe int maxY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_maxY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_maxY)) = value;
				}
			}

			// Token: 0x170015CD RID: 5581
			// (get) Token: 0x060045DA RID: 17882 RVA: 0x001453B4 File Offset: 0x001435B4
			// (set) Token: 0x060045DB RID: 17883 RVA: 0x0001933D File Offset: 0x0001753D
			public unsafe bool invertY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_invertY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_invertY)) = value;
				}
			}

			// Token: 0x170015CE RID: 5582
			// (get) Token: 0x060045DC RID: 17884 RVA: 0x001453DC File Offset: 0x001435DC
			// (set) Token: 0x060045DD RID: 17885 RVA: 0x00019358 File Offset: 0x00017558
			public unsafe bool reverseY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_reverseY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDTouchpad.TouchpadInfo.NativeFieldInfoPtr_reverseY)) = value;
				}
			}

			// Token: 0x04003905 RID: 14597
			private static readonly IntPtr NativeFieldInfoPtr_maxTouches;

			// Token: 0x04003906 RID: 14598
			private static readonly IntPtr NativeFieldInfoPtr_minX;

			// Token: 0x04003907 RID: 14599
			private static readonly IntPtr NativeFieldInfoPtr_maxX;

			// Token: 0x04003908 RID: 14600
			private static readonly IntPtr NativeFieldInfoPtr_minY;

			// Token: 0x04003909 RID: 14601
			private static readonly IntPtr NativeFieldInfoPtr_maxY;

			// Token: 0x0400390A RID: 14602
			private static readonly IntPtr NativeFieldInfoPtr_invertY;

			// Token: 0x0400390B RID: 14603
			private static readonly IntPtr NativeFieldInfoPtr_reverseY;

			// Token: 0x0400390C RID: 14604
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Boolean_Boolean_0;

			// Token: 0x0400390D RID: 14605
			private static readonly IntPtr NativeMethodInfoPtr_CalculateTouch_Public_Void_byref_TouchData_0;
		}

		// Token: 0x0200033B RID: 827
		[StructLayout(2)]
		public struct TouchData
		{
			// Token: 0x060045DE RID: 17886 RVA: 0x00145404 File Offset: 0x00143604
			// Note: this type is marked as 'beforefieldinit'.
			static TouchData()
			{
				Il2CppClassPointerStore<HIDTouchpad.TouchData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HIDTouchpad>.NativeClassPtr, "TouchData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDTouchpad.TouchData>.NativeClassPtr);
				HIDTouchpad.TouchData.NativeFieldInfoPtr_touchId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad.TouchData>.NativeClassPtr, "touchId");
				HIDTouchpad.TouchData.NativeFieldInfoPtr_timeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad.TouchData>.NativeClassPtr, "timeStamp");
				HIDTouchpad.TouchData.NativeFieldInfoPtr_isTouching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad.TouchData>.NativeClassPtr, "isTouching");
				HIDTouchpad.TouchData.NativeFieldInfoPtr_positionRawX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad.TouchData>.NativeClassPtr, "positionRawX");
				HIDTouchpad.TouchData.NativeFieldInfoPtr_positionRawY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad.TouchData>.NativeClassPtr, "positionRawY");
				HIDTouchpad.TouchData.NativeFieldInfoPtr_positionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad.TouchData>.NativeClassPtr, "positionX");
				HIDTouchpad.TouchData.NativeFieldInfoPtr_positionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad.TouchData>.NativeClassPtr, "positionY");
				HIDTouchpad.TouchData.NativeFieldInfoPtr_positionAbsX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad.TouchData>.NativeClassPtr, "positionAbsX");
				HIDTouchpad.TouchData.NativeFieldInfoPtr_positionAbsY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDTouchpad.TouchData>.NativeClassPtr, "positionAbsY");
				HIDTouchpad.TouchData.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDTouchpad.TouchData>.NativeClassPtr, 100669828);
			}

			// Token: 0x060045DF RID: 17887 RVA: 0x001454F8 File Offset: 0x001436F8
			[CallerCount(0)]
			public unsafe void Clear()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDTouchpad.TouchData.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045E0 RID: 17888 RVA: 0x00019373 File Offset: 0x00017573
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HIDTouchpad.TouchData>.NativeClassPtr, ref this));
			}

			// Token: 0x0400390E RID: 14606
			private static readonly IntPtr NativeFieldInfoPtr_touchId;

			// Token: 0x0400390F RID: 14607
			private static readonly IntPtr NativeFieldInfoPtr_timeStamp;

			// Token: 0x04003910 RID: 14608
			private static readonly IntPtr NativeFieldInfoPtr_isTouching;

			// Token: 0x04003911 RID: 14609
			private static readonly IntPtr NativeFieldInfoPtr_positionRawX;

			// Token: 0x04003912 RID: 14610
			private static readonly IntPtr NativeFieldInfoPtr_positionRawY;

			// Token: 0x04003913 RID: 14611
			private static readonly IntPtr NativeFieldInfoPtr_positionX;

			// Token: 0x04003914 RID: 14612
			private static readonly IntPtr NativeFieldInfoPtr_positionY;

			// Token: 0x04003915 RID: 14613
			private static readonly IntPtr NativeFieldInfoPtr_positionAbsX;

			// Token: 0x04003916 RID: 14614
			private static readonly IntPtr NativeFieldInfoPtr_positionAbsY;

			// Token: 0x04003917 RID: 14615
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

			// Token: 0x04003918 RID: 14616
			[FieldOffset(0)]
			public int touchId;

			// Token: 0x04003919 RID: 14617
			[FieldOffset(4)]
			public float timeStamp;

			// Token: 0x0400391A RID: 14618
			[FieldOffset(8)]
			[MarshalAs(4)]
			public bool isTouching;

			// Token: 0x0400391B RID: 14619
			[FieldOffset(12)]
			public int positionRawX;

			// Token: 0x0400391C RID: 14620
			[FieldOffset(16)]
			public int positionRawY;

			// Token: 0x0400391D RID: 14621
			[FieldOffset(20)]
			public float positionX;

			// Token: 0x0400391E RID: 14622
			[FieldOffset(24)]
			public float positionY;

			// Token: 0x0400391F RID: 14623
			[FieldOffset(28)]
			public int positionAbsX;

			// Token: 0x04003920 RID: 14624
			[FieldOffset(32)]
			public int positionAbsY;
		}
	}
}
