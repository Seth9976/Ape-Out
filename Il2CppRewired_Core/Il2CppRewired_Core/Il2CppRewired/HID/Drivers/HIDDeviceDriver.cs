using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Config;
using Il2CppSystem;

namespace Il2CppRewired.HID.Drivers
{
	// Token: 0x02000117 RID: 279
	public class HIDDeviceDriver : Object
	{
		// Token: 0x06001A80 RID: 6784 RVA: 0x00093E54 File Offset: 0x00092054
		// Note: this type is marked as 'beforefieldinit'.
		static HIDDeviceDriver()
		{
			Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID.Drivers", "HIDDeviceDriver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr);
			HIDDeviceDriver.NativeFieldInfoPtr_axes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, "axes");
			HIDDeviceDriver.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, "buttons");
			HIDDeviceDriver.NativeFieldInfoPtr_hats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, "hats");
			HIDDeviceDriver.NativeFieldInfoPtr_accelerometers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, "accelerometers");
			HIDDeviceDriver.NativeFieldInfoPtr_gyroscopes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, "gyroscopes");
			HIDDeviceDriver.NativeFieldInfoPtr_touchpads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, "touchpads");
			HIDDeviceDriver.NativeFieldInfoPtr_vibrationMotors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, "vibrationMotors");
			HIDDeviceDriver.NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, "lights");
			HIDDeviceDriver.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
			HIDDeviceDriver.NativeMethodInfoPtr_get_AxisCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669518);
			HIDDeviceDriver.NativeMethodInfoPtr_get_ButtonCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669519);
			HIDDeviceDriver.NativeMethodInfoPtr_get_HatCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669520);
			HIDDeviceDriver.NativeMethodInfoPtr_get_AccelerometerCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669521);
			HIDDeviceDriver.NativeMethodInfoPtr_get_GyroscopeCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669522);
			HIDDeviceDriver.NativeMethodInfoPtr_get_TouchpadCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669523);
			HIDDeviceDriver.NativeMethodInfoPtr_get_LightCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669524);
			HIDDeviceDriver.NativeMethodInfoPtr_get_VibrationMotorCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669525);
			HIDDeviceDriver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669526);
			HIDDeviceDriver.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669527);
			HIDDeviceDriver.NativeMethodInfoPtr_ParseInputReport_Public_Abstract_Virtual_New_Boolean_IntPtr_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669528);
			HIDDeviceDriver.NativeMethodInfoPtr_CreateControllerExtension_Public_Abstract_Virtual_New_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669529);
			HIDDeviceDriver.NativeMethodInfoPtr_GetDriver_Public_Static_HIDDeviceDriver_DriverType_InitArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669530);
			HIDDeviceDriver.NativeMethodInfoPtr_FindDriverId_Public_Static_DriverType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669531);
			HIDDeviceDriver.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669532);
			HIDDeviceDriver.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669533);
			HIDDeviceDriver.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669534);
			HIDDeviceDriver.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, 100669535);
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001A81 RID: 6785 RVA: 0x000940A0 File Offset: 0x000922A0
		public unsafe virtual int AxisCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.NativeMethodInfoPtr_get_AxisCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x000940DC File Offset: 0x000922DC
		public unsafe virtual int ButtonCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.NativeMethodInfoPtr_get_ButtonCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001A83 RID: 6787 RVA: 0x00094118 File Offset: 0x00092318
		public unsafe virtual int HatCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.NativeMethodInfoPtr_get_HatCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x00094154 File Offset: 0x00092354
		public unsafe virtual int AccelerometerCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.NativeMethodInfoPtr_get_AccelerometerCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x00094190 File Offset: 0x00092390
		public unsafe virtual int GyroscopeCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.NativeMethodInfoPtr_get_GyroscopeCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x000941CC File Offset: 0x000923CC
		public unsafe virtual int TouchpadCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.NativeMethodInfoPtr_get_TouchpadCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001A87 RID: 6791 RVA: 0x00094208 File Offset: 0x00092408
		public unsafe virtual int LightCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.NativeMethodInfoPtr_get_LightCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x00094244 File Offset: 0x00092444
		public unsafe virtual int VibrationMotorCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.NativeMethodInfoPtr_get_VibrationMotorCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x00094280 File Offset: 0x00092480
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HIDDeviceDriver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x000942BC File Offset: 0x000924BC
		[CallerCount(0)]
		public unsafe virtual void Update(UpdateLoopType updateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDDeviceDriver.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x00094308 File Offset: 0x00092508
		[CallerCount(0)]
		public unsafe virtual bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputReportPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputReportLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timestamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDDeviceDriver.NativeMethodInfoPtr_ParseInputReport_Public_Abstract_Virtual_New_Boolean_IntPtr_Int32_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00094378 File Offset: 0x00092578
		[CallerCount(0)]
		public unsafe virtual Controller.Extension CreateControllerExtension()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDDeviceDriver.NativeMethodInfoPtr_CreateControllerExtension_Public_Abstract_Virtual_New_Extension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x000943C4 File Offset: 0x000925C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279207, XrefRangeEnd = 279214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HIDDeviceDriver GetDriver(HIDDeviceDriver.DriverType driverId, HIDDeviceDriver.InitArgs hidDriverInitArgs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref driverId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hidDriverInitArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.NativeMethodInfoPtr_GetDriver_Public_Static_HIDDeviceDriver_DriverType_InitArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HIDDeviceDriver>(intPtr3) : null;
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00094418 File Offset: 0x00092618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279214, XrefRangeEnd = 279234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HIDDeviceDriver.DriverType FindDriverId(int vendorId, int productId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vendorId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.NativeMethodInfoPtr_FindDriverId_Public_Static_DriverType_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001A8F RID: 6799 RVA: 0x00094464 File Offset: 0x00092664
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x000944A0 File Offset: 0x000926A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279234, XrefRangeEnd = 279238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x000944D4 File Offset: 0x000926D4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 213019, RefRangeEnd = 213025, XrefRangeStart = 213019, XrefRangeEnd = 213025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDDeviceDriver.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00094510 File Offset: 0x00092710
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDDeviceDriver.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x0000AE1E File Offset: 0x0000901E
		public HIDDeviceDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x0009455C File Offset: 0x0009275C
		// (set) Token: 0x06001A95 RID: 6805 RVA: 0x0000AE27 File Offset: 0x00009027
		public unsafe Il2CppReferenceArray<HIDAxis> axes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_axes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HIDAxis>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_axes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x0009458C File Offset: 0x0009278C
		// (set) Token: 0x06001A97 RID: 6807 RVA: 0x0000AE46 File Offset: 0x00009046
		public unsafe Il2CppReferenceArray<HIDButton> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HIDButton>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x000945BC File Offset: 0x000927BC
		// (set) Token: 0x06001A99 RID: 6809 RVA: 0x0000AE65 File Offset: 0x00009065
		public unsafe Il2CppReferenceArray<HIDHat> hats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_hats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HIDHat>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_hats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x000945EC File Offset: 0x000927EC
		// (set) Token: 0x06001A9B RID: 6811 RVA: 0x0000AE84 File Offset: 0x00009084
		public unsafe Il2CppReferenceArray<HIDAccelerometer> accelerometers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_accelerometers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HIDAccelerometer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_accelerometers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001A9C RID: 6812 RVA: 0x0009461C File Offset: 0x0009281C
		// (set) Token: 0x06001A9D RID: 6813 RVA: 0x0000AEA3 File Offset: 0x000090A3
		public unsafe Il2CppReferenceArray<HIDGyroscope> gyroscopes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_gyroscopes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HIDGyroscope>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_gyroscopes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x0009464C File Offset: 0x0009284C
		// (set) Token: 0x06001A9F RID: 6815 RVA: 0x0000AEC2 File Offset: 0x000090C2
		public unsafe Il2CppReferenceArray<HIDTouchpad> touchpads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_touchpads);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HIDTouchpad>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_touchpads), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x0009467C File Offset: 0x0009287C
		// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x0000AEE1 File Offset: 0x000090E1
		public unsafe Il2CppReferenceArray<HIDVibrationMotor> vibrationMotors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_vibrationMotors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HIDVibrationMotor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_vibrationMotors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x000946AC File Offset: 0x000928AC
		// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x0000AF00 File Offset: 0x00009100
		public unsafe Il2CppReferenceArray<HIDLight> lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HIDLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x000946DC File Offset: 0x000928DC
		// (set) Token: 0x06001AA5 RID: 6821 RVA: 0x0000AF1F File Offset: 0x0000911F
		public unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
			}
		}

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeFieldInfoPtr_axes;

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x040016BB RID: 5819
		private static readonly IntPtr NativeFieldInfoPtr_hats;

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeFieldInfoPtr_accelerometers;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeFieldInfoPtr_gyroscopes;

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeFieldInfoPtr_touchpads;

		// Token: 0x040016BF RID: 5823
		private static readonly IntPtr NativeFieldInfoPtr_vibrationMotors;

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeFieldInfoPtr_lights;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeMethodInfoPtr_get_ButtonCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeMethodInfoPtr_get_HatCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeMethodInfoPtr_get_AccelerometerCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeMethodInfoPtr_get_GyroscopeCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeMethodInfoPtr_get_TouchpadCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeMethodInfoPtr_get_LightCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr_get_VibrationMotorCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_UpdateLoopType_0;

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeMethodInfoPtr_ParseInputReport_Public_Abstract_Virtual_New_Boolean_IntPtr_Int32_Double_0;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr_CreateControllerExtension_Public_Abstract_Virtual_New_Extension_0;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeMethodInfoPtr_GetDriver_Public_Static_HIDDeviceDriver_DriverType_InitArgs_0;

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeMethodInfoPtr_FindDriverId_Public_Static_DriverType_Int32_Int32_0;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x02000329 RID: 809
		[OriginalName("Rewired_Core.dll", "", "DriverType")]
		public enum DriverType
		{
			// Token: 0x0400389E RID: 14494
			urhBwQidoSAKHIhcxeCWNbALMhkh,
			// Token: 0x0400389F RID: 14495
			nnjLDBNeeGfhkDBKJdccvGkpHfA,
			// Token: 0x040038A0 RID: 14496
			djfaapIZMHIkERBlyKYgExqkthRm,
			// Token: 0x040038A1 RID: 14497
			gzjakqrCQCbcCEZSrXqvPnLcbRx
		}

		// Token: 0x0200032A RID: 810
		public sealed class GetHidFeatureData : MulticastDelegate
		{
			// Token: 0x0600454C RID: 17740 RVA: 0x001436B4 File Offset: 0x001418B4
			// Note: this type is marked as 'beforefieldinit'.
			static GetHidFeatureData()
			{
				Il2CppClassPointerStore<HIDDeviceDriver.GetHidFeatureData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, "GetHidFeatureData");
				HIDDeviceDriver.GetHidFeatureData.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver.GetHidFeatureData>.NativeClassPtr, 100669536);
				HIDDeviceDriver.GetHidFeatureData.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver.GetHidFeatureData>.NativeClassPtr, 100669537);
				HIDDeviceDriver.GetHidFeatureData.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Byte_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver.GetHidFeatureData>.NativeClassPtr, 100669538);
				HIDDeviceDriver.GetHidFeatureData.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_Byte_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver.GetHidFeatureData>.NativeClassPtr, 100669539);
			}

			// Token: 0x0600454D RID: 17741 RVA: 0x00143728 File Offset: 0x00141928
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetHidFeatureData(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDDeviceDriver.GetHidFeatureData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.GetHidFeatureData.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600454E RID: 17742 RVA: 0x00143784 File Offset: 0x00141984
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 279202, RefRangeEnd = 279203, XrefRangeStart = 279202, XrefRangeEnd = 279202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> Invoke(byte reportId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref reportId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.GetHidFeatureData.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x0600454F RID: 17743 RVA: 0x001437D0 File Offset: 0x001419D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279203, XrefRangeEnd = 279207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(byte reportId, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref reportId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.GetHidFeatureData.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Byte_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004550 RID: 17744 RVA: 0x00143840 File Offset: 0x00141A40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.GetHidFeatureData.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_Byte_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06004551 RID: 17745 RVA: 0x00018EA5 File Offset: 0x000170A5
			public GetHidFeatureData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004552 RID: 17746 RVA: 0x00018EAE File Offset: 0x000170AE
			public static implicit operator HIDDeviceDriver.GetHidFeatureData(Func<byte, Il2CppStructArray<byte>> A_0)
			{
				return DelegateSupport.ConvertDelegate<HIDDeviceDriver.GetHidFeatureData>(A_0);
			}

			// Token: 0x06004553 RID: 17747 RVA: 0x00018EB6 File Offset: 0x000170B6
			public static HIDDeviceDriver.GetHidFeatureData operator +(HIDDeviceDriver.GetHidFeatureData A_0, HIDDeviceDriver.GetHidFeatureData A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<HIDDeviceDriver.GetHidFeatureData>();
			}

			// Token: 0x06004554 RID: 17748 RVA: 0x00018EC4 File Offset: 0x000170C4
			public static HIDDeviceDriver.GetHidFeatureData operator -(HIDDeviceDriver.GetHidFeatureData A_0, HIDDeviceDriver.GetHidFeatureData A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<HIDDeviceDriver.GetHidFeatureData>();
				}
				return delegate2;
			}

			// Token: 0x040038A2 RID: 14498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040038A3 RID: 14499
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_Byte_Byte_0;

			// Token: 0x040038A4 RID: 14500
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Byte_AsyncCallback_Object_0;

			// Token: 0x040038A5 RID: 14501
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_Byte_IAsyncResult_0;
		}

		// Token: 0x0200032B RID: 811
		public class InitArgs : Object
		{
			// Token: 0x06004555 RID: 17749 RVA: 0x00143890 File Offset: 0x00141A90
			// Note: this type is marked as 'beforefieldinit'.
			static InitArgs()
			{
				Il2CppClassPointerStore<HIDDeviceDriver.InitArgs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HIDDeviceDriver>.NativeClassPtr, "InitArgs");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDDeviceDriver.InitArgs>.NativeClassPtr);
				HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_updateLoopSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver.InitArgs>.NativeClassPtr, "updateLoopSetting");
				HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_connectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver.InitArgs>.NativeClassPtr, "connectionType");
				HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_minAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver.InitArgs>.NativeClassPtr, "minAxisValue");
				HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_maxAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver.InitArgs>.NativeClassPtr, "maxAxisValue");
				HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_hatZeroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver.InitArgs>.NativeClassPtr, "hatZeroValue");
				HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_hatSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver.InitArgs>.NativeClassPtr, "hatSpan");
				HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_inputReportLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver.InitArgs>.NativeClassPtr, "inputReportLength");
				HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_outputReportLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver.InitArgs>.NativeClassPtr, "outputReportLength");
				HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_synchronousWriteOutputReportDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver.InitArgs>.NativeClassPtr, "synchronousWriteOutputReportDelegate");
				HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_asynchronousWriteOutputReportDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver.InitArgs>.NativeClassPtr, "asynchronousWriteOutputReportDelegate");
				HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_getFeatureReportDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDDeviceDriver.InitArgs>.NativeClassPtr, "getFeatureReportDelegate");
				HIDDeviceDriver.InitArgs.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_DeviceConnectionType_Int32_Int32_Int32_Int32_Int32_Int32_Func_2_OutputReport_Boolean_Action_1_OutputReport_GetHidFeatureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDDeviceDriver.InitArgs>.NativeClassPtr, 100669540);
			}

			// Token: 0x06004556 RID: 17750 RVA: 0x001439AC File Offset: 0x00141BAC
			[CallerCount(0)]
			public unsafe InitArgs(UpdateLoopSetting updateLoopSetting, DeviceConnectionType connectionType, int minAxisValue, int maxAxisValue, int hatZeroValue, int hatSpan, int inputReportLength, int outputReportLength, Func<OutputReport, bool> synchronousWriteOutputReportDelegate, Action<OutputReport> asynchronousWriteOutputReportDelegate, HIDDeviceDriver.GetHidFeatureData getFeatureReportDelegate)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDDeviceDriver.InitArgs>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref updateLoopSetting;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionType;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minAxisValue;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxAxisValue;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hatZeroValue;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hatSpan;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputReportLength;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outputReportLength;
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(synchronousWriteOutputReportDelegate);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asynchronousWriteOutputReportDelegate);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getFeatureReportDelegate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDDeviceDriver.InitArgs.NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_DeviceConnectionType_Int32_Int32_Int32_Int32_Int32_Int32_Func_2_OutputReport_Boolean_Action_1_OutputReport_GetHidFeatureData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004557 RID: 17751 RVA: 0x00018ED5 File Offset: 0x000170D5
			public InitArgs(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015A6 RID: 5542
			// (get) Token: 0x06004558 RID: 17752 RVA: 0x00143A94 File Offset: 0x00141C94
			// (set) Token: 0x06004559 RID: 17753 RVA: 0x00018EDE File Offset: 0x000170DE
			public unsafe UpdateLoopSetting updateLoopSetting
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_updateLoopSetting);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_updateLoopSetting)) = value;
				}
			}

			// Token: 0x170015A7 RID: 5543
			// (get) Token: 0x0600455A RID: 17754 RVA: 0x00143ABC File Offset: 0x00141CBC
			// (set) Token: 0x0600455B RID: 17755 RVA: 0x00018EF9 File Offset: 0x000170F9
			public unsafe DeviceConnectionType connectionType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_connectionType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_connectionType)) = value;
				}
			}

			// Token: 0x170015A8 RID: 5544
			// (get) Token: 0x0600455C RID: 17756 RVA: 0x00143AE4 File Offset: 0x00141CE4
			// (set) Token: 0x0600455D RID: 17757 RVA: 0x00018F14 File Offset: 0x00017114
			public unsafe int minAxisValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_minAxisValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_minAxisValue)) = value;
				}
			}

			// Token: 0x170015A9 RID: 5545
			// (get) Token: 0x0600455E RID: 17758 RVA: 0x00143B0C File Offset: 0x00141D0C
			// (set) Token: 0x0600455F RID: 17759 RVA: 0x00018F2F File Offset: 0x0001712F
			public unsafe int maxAxisValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_maxAxisValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_maxAxisValue)) = value;
				}
			}

			// Token: 0x170015AA RID: 5546
			// (get) Token: 0x06004560 RID: 17760 RVA: 0x00143B34 File Offset: 0x00141D34
			// (set) Token: 0x06004561 RID: 17761 RVA: 0x00018F4A File Offset: 0x0001714A
			public unsafe int hatZeroValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_hatZeroValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_hatZeroValue)) = value;
				}
			}

			// Token: 0x170015AB RID: 5547
			// (get) Token: 0x06004562 RID: 17762 RVA: 0x00143B5C File Offset: 0x00141D5C
			// (set) Token: 0x06004563 RID: 17763 RVA: 0x00018F65 File Offset: 0x00017165
			public unsafe int hatSpan
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_hatSpan);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_hatSpan)) = value;
				}
			}

			// Token: 0x170015AC RID: 5548
			// (get) Token: 0x06004564 RID: 17764 RVA: 0x00143B84 File Offset: 0x00141D84
			// (set) Token: 0x06004565 RID: 17765 RVA: 0x00018F80 File Offset: 0x00017180
			public unsafe int inputReportLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_inputReportLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_inputReportLength)) = value;
				}
			}

			// Token: 0x170015AD RID: 5549
			// (get) Token: 0x06004566 RID: 17766 RVA: 0x00143BAC File Offset: 0x00141DAC
			// (set) Token: 0x06004567 RID: 17767 RVA: 0x00018F9B File Offset: 0x0001719B
			public unsafe int outputReportLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_outputReportLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_outputReportLength)) = value;
				}
			}

			// Token: 0x170015AE RID: 5550
			// (get) Token: 0x06004568 RID: 17768 RVA: 0x00143BD4 File Offset: 0x00141DD4
			// (set) Token: 0x06004569 RID: 17769 RVA: 0x00018FB6 File Offset: 0x000171B6
			public unsafe Func<OutputReport, bool> synchronousWriteOutputReportDelegate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_synchronousWriteOutputReportDelegate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<OutputReport, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_synchronousWriteOutputReportDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015AF RID: 5551
			// (get) Token: 0x0600456A RID: 17770 RVA: 0x00143C04 File Offset: 0x00141E04
			// (set) Token: 0x0600456B RID: 17771 RVA: 0x00018FD5 File Offset: 0x000171D5
			public unsafe Action<OutputReport> asynchronousWriteOutputReportDelegate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_asynchronousWriteOutputReportDelegate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<OutputReport>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_asynchronousWriteOutputReportDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015B0 RID: 5552
			// (get) Token: 0x0600456C RID: 17772 RVA: 0x00143C34 File Offset: 0x00141E34
			// (set) Token: 0x0600456D RID: 17773 RVA: 0x00018FF4 File Offset: 0x000171F4
			public unsafe HIDDeviceDriver.GetHidFeatureData getFeatureReportDelegate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_getFeatureReportDelegate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HIDDeviceDriver.GetHidFeatureData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDDeviceDriver.InitArgs.NativeFieldInfoPtr_getFeatureReportDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040038A6 RID: 14502
			private static readonly IntPtr NativeFieldInfoPtr_updateLoopSetting;

			// Token: 0x040038A7 RID: 14503
			private static readonly IntPtr NativeFieldInfoPtr_connectionType;

			// Token: 0x040038A8 RID: 14504
			private static readonly IntPtr NativeFieldInfoPtr_minAxisValue;

			// Token: 0x040038A9 RID: 14505
			private static readonly IntPtr NativeFieldInfoPtr_maxAxisValue;

			// Token: 0x040038AA RID: 14506
			private static readonly IntPtr NativeFieldInfoPtr_hatZeroValue;

			// Token: 0x040038AB RID: 14507
			private static readonly IntPtr NativeFieldInfoPtr_hatSpan;

			// Token: 0x040038AC RID: 14508
			private static readonly IntPtr NativeFieldInfoPtr_inputReportLength;

			// Token: 0x040038AD RID: 14509
			private static readonly IntPtr NativeFieldInfoPtr_outputReportLength;

			// Token: 0x040038AE RID: 14510
			private static readonly IntPtr NativeFieldInfoPtr_synchronousWriteOutputReportDelegate;

			// Token: 0x040038AF RID: 14511
			private static readonly IntPtr NativeFieldInfoPtr_asynchronousWriteOutputReportDelegate;

			// Token: 0x040038B0 RID: 14512
			private static readonly IntPtr NativeFieldInfoPtr_getFeatureReportDelegate;

			// Token: 0x040038B1 RID: 14513
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UpdateLoopSetting_DeviceConnectionType_Int32_Int32_Int32_Int32_Int32_Int32_Func_2_OutputReport_Boolean_Action_1_OutputReport_GetHidFeatureData_0;
		}
	}
}
