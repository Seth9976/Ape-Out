using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Platforms;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000108 RID: 264
	public class BridgedControllerHWInfo : Object
	{
		// Token: 0x06001991 RID: 6545 RVA: 0x0009195C File Offset: 0x0008FB5C
		// Note: this type is marked as 'beforefieldinit'.
		static BridgedControllerHWInfo()
		{
			Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "BridgedControllerHWInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr);
			BridgedControllerHWInfo.NativeFieldInfoPtr_isMock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "isMock");
			BridgedControllerHWInfo.NativeFieldInfoPtr_inputManagerSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "inputManagerSource");
			BridgedControllerHWInfo.NativeFieldInfoPtr_inputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "inputSource");
			BridgedControllerHWInfo.NativeFieldInfoPtr_deviceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "deviceType");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hardwareIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hardwareIdentifier");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hardwareAxisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hardwareAxisCount");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hardwareButtonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hardwareButtonCount");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hardwareHatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hardwareHatCount");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hw_productName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hw_productName");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hw_pidVid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hw_pidVid");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hw_deviceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hw_deviceGuid");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hw_productId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hw_productId");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hw_bluetoothDeviceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hw_bluetoothDeviceName");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hw_isBluetoothDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hw_isBluetoothDevice");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hw_supportsVoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hw_supportsVoice");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hw_supportsVibration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hw_supportsVibration");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hw_xInputSubType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hw_xInputSubType");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hw_manufacturer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hw_manufacturer");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hw_serialNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hw_serialNumber");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hw_vendorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hw_vendorId");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hw_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hw_version");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hw_systemDeviceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hw_systemDeviceName");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hw_isSDL2Gamepad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hw_isSDL2Gamepad");
			BridgedControllerHWInfo.NativeFieldInfoPtr_webGL_webBrowserType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "webGL_webBrowserType");
			BridgedControllerHWInfo.NativeFieldInfoPtr_webGL_osType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "webGL_osType");
			BridgedControllerHWInfo.NativeFieldInfoPtr_webGL_mappingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "webGL_mappingType");
			BridgedControllerHWInfo.NativeFieldInfoPtr_webGL_webBrowserVersionSplit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "webGL_webBrowserVersionSplit");
			BridgedControllerHWInfo.NativeFieldInfoPtr_webGL_osVersionSplit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "webGL_osVersionSplit");
			BridgedControllerHWInfo.NativeFieldInfoPtr_hw_localVibrationMotorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "hw_localVibrationMotorCount");
			BridgedControllerHWInfo.NativeFieldInfoPtr_definitionMatchTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, "definitionMatchTag");
			BridgedControllerHWInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, 100669474);
			BridgedControllerHWInfo.NativeMethodInfoPtr__ctor_Public_Void_BridgedControllerHWInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, 100669475);
			BridgedControllerHWInfo.NativeMethodInfoPtr_KCcpZvPkVNWEewMJPJcdZegzJsP_Private_Void_BridgedControllerHWInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr, 100669476);
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00091C20 File Offset: 0x0008FE20
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BridgedControllerHWInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BridgedControllerHWInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00091C5C File Offset: 0x0008FE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279005, XrefRangeEnd = 279007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BridgedControllerHWInfo(BridgedControllerHWInfo source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BridgedControllerHWInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BridgedControllerHWInfo.NativeMethodInfoPtr__ctor_Public_Void_BridgedControllerHWInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00091CA8 File Offset: 0x0008FEA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279007, RefRangeEnd = 279009, XrefRangeStart = 279007, XrefRangeEnd = 279007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KCcpZvPkVNWEewMJPJcdZegzJsP(BridgedControllerHWInfo A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BridgedControllerHWInfo.NativeMethodInfoPtr_KCcpZvPkVNWEewMJPJcdZegzJsP_Private_Void_BridgedControllerHWInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x0000A3BE File Offset: 0x000085BE
		public BridgedControllerHWInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x00091CEC File Offset: 0x0008FEEC
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x0000A3C7 File Offset: 0x000085C7
		public unsafe bool isMock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_isMock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_isMock)) = value;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001998 RID: 6552 RVA: 0x00091D14 File Offset: 0x0008FF14
		// (set) Token: 0x06001999 RID: 6553 RVA: 0x0000A3E2 File Offset: 0x000085E2
		public unsafe InputSource inputManagerSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_inputManagerSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_inputManagerSource)) = value;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x00091D3C File Offset: 0x0008FF3C
		// (set) Token: 0x0600199B RID: 6555 RVA: 0x0000A3FD File Offset: 0x000085FD
		public unsafe InputSource inputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_inputSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_inputSource)) = value;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x00091D64 File Offset: 0x0008FF64
		// (set) Token: 0x0600199D RID: 6557 RVA: 0x0000A418 File Offset: 0x00008618
		public unsafe ControlDeviceType deviceType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_deviceType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_deviceType)) = value;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x00091D8C File Offset: 0x0008FF8C
		// (set) Token: 0x0600199F RID: 6559 RVA: 0x0000A433 File Offset: 0x00008633
		public unsafe string hardwareIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hardwareIdentifier);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hardwareIdentifier), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x00091DB4 File Offset: 0x0008FFB4
		// (set) Token: 0x060019A1 RID: 6561 RVA: 0x0000A452 File Offset: 0x00008652
		public unsafe int hardwareAxisCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hardwareAxisCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hardwareAxisCount)) = value;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x00091DDC File Offset: 0x0008FFDC
		// (set) Token: 0x060019A3 RID: 6563 RVA: 0x0000A46D File Offset: 0x0000866D
		public unsafe int hardwareButtonCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hardwareButtonCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hardwareButtonCount)) = value;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x00091E04 File Offset: 0x00090004
		// (set) Token: 0x060019A5 RID: 6565 RVA: 0x0000A488 File Offset: 0x00008688
		public unsafe int hardwareHatCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hardwareHatCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hardwareHatCount)) = value;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x00091E2C File Offset: 0x0009002C
		// (set) Token: 0x060019A7 RID: 6567 RVA: 0x0000A4A3 File Offset: 0x000086A3
		public unsafe string hw_productName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_productName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_productName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x00091E54 File Offset: 0x00090054
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x0000A4C2 File Offset: 0x000086C2
		public unsafe PidVid hw_pidVid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_pidVid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_pidVid)) = value;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x00091E7C File Offset: 0x0009007C
		// (set) Token: 0x060019AB RID: 6571 RVA: 0x0000A4DD File Offset: 0x000086DD
		public unsafe Guid hw_deviceGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_deviceGuid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_deviceGuid)) = value;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x00091EA4 File Offset: 0x000900A4
		// (set) Token: 0x060019AD RID: 6573 RVA: 0x0000A4F8 File Offset: 0x000086F8
		public unsafe int hw_productId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_productId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_productId)) = value;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x00091ECC File Offset: 0x000900CC
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x0000A513 File Offset: 0x00008713
		public unsafe string hw_bluetoothDeviceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_bluetoothDeviceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_bluetoothDeviceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x00091EF4 File Offset: 0x000900F4
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x0000A532 File Offset: 0x00008732
		public unsafe bool hw_isBluetoothDevice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_isBluetoothDevice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_isBluetoothDevice)) = value;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x00091F1C File Offset: 0x0009011C
		// (set) Token: 0x060019B3 RID: 6579 RVA: 0x0000A54D File Offset: 0x0000874D
		public unsafe bool hw_supportsVoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_supportsVoice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_supportsVoice)) = value;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x00091F44 File Offset: 0x00090144
		// (set) Token: 0x060019B5 RID: 6581 RVA: 0x0000A568 File Offset: 0x00008768
		public unsafe bool hw_supportsVibration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_supportsVibration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_supportsVibration)) = value;
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x00091F6C File Offset: 0x0009016C
		// (set) Token: 0x060019B7 RID: 6583 RVA: 0x0000A583 File Offset: 0x00008783
		public unsafe XInputDeviceSubType hw_xInputSubType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_xInputSubType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_xInputSubType)) = value;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x00091F94 File Offset: 0x00090194
		// (set) Token: 0x060019B9 RID: 6585 RVA: 0x0000A59E File Offset: 0x0000879E
		public unsafe string hw_manufacturer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_manufacturer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_manufacturer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x00091FBC File Offset: 0x000901BC
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x0000A5BD File Offset: 0x000087BD
		public unsafe string hw_serialNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_serialNumber);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_serialNumber), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x00091FE4 File Offset: 0x000901E4
		// (set) Token: 0x060019BD RID: 6589 RVA: 0x0000A5DC File Offset: 0x000087DC
		public unsafe int hw_vendorId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_vendorId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_vendorId)) = value;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x0009200C File Offset: 0x0009020C
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x0000A5F7 File Offset: 0x000087F7
		public unsafe int hw_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_version)) = value;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x00092034 File Offset: 0x00090234
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x0000A612 File Offset: 0x00008812
		public unsafe string hw_systemDeviceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_systemDeviceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_systemDeviceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x0009205C File Offset: 0x0009025C
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x0000A631 File Offset: 0x00008831
		public unsafe bool hw_isSDL2Gamepad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_isSDL2Gamepad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_isSDL2Gamepad)) = value;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x00092084 File Offset: 0x00090284
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x0000A64C File Offset: 0x0000884C
		public unsafe WebGLWebBrowserType webGL_webBrowserType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_webGL_webBrowserType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_webGL_webBrowserType)) = value;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x000920AC File Offset: 0x000902AC
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x0000A667 File Offset: 0x00008867
		public unsafe WebGLOSType webGL_osType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_webGL_osType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_webGL_osType)) = value;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x000920D4 File Offset: 0x000902D4
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x0000A682 File Offset: 0x00008882
		public unsafe WebGLGamepadMappingType webGL_mappingType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_webGL_mappingType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_webGL_mappingType)) = value;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x000920FC File Offset: 0x000902FC
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x0000A69D File Offset: 0x0000889D
		public unsafe Il2CppStringArray webGL_webBrowserVersionSplit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_webGL_webBrowserVersionSplit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_webGL_webBrowserVersionSplit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x0009212C File Offset: 0x0009032C
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x0000A6BC File Offset: 0x000088BC
		public unsafe Il2CppStringArray webGL_osVersionSplit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_webGL_osVersionSplit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_webGL_osVersionSplit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x0009215C File Offset: 0x0009035C
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x0000A6DB File Offset: 0x000088DB
		public unsafe int hw_localVibrationMotorCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_localVibrationMotorCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_hw_localVibrationMotorCount)) = value;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x00092184 File Offset: 0x00090384
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x0000A6F6 File Offset: 0x000088F6
		public unsafe string definitionMatchTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_definitionMatchTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BridgedControllerHWInfo.NativeFieldInfoPtr_definitionMatchTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001638 RID: 5688
		private static readonly IntPtr NativeFieldInfoPtr_isMock;

		// Token: 0x04001639 RID: 5689
		private static readonly IntPtr NativeFieldInfoPtr_inputManagerSource;

		// Token: 0x0400163A RID: 5690
		private static readonly IntPtr NativeFieldInfoPtr_inputSource;

		// Token: 0x0400163B RID: 5691
		private static readonly IntPtr NativeFieldInfoPtr_deviceType;

		// Token: 0x0400163C RID: 5692
		private static readonly IntPtr NativeFieldInfoPtr_hardwareIdentifier;

		// Token: 0x0400163D RID: 5693
		private static readonly IntPtr NativeFieldInfoPtr_hardwareAxisCount;

		// Token: 0x0400163E RID: 5694
		private static readonly IntPtr NativeFieldInfoPtr_hardwareButtonCount;

		// Token: 0x0400163F RID: 5695
		private static readonly IntPtr NativeFieldInfoPtr_hardwareHatCount;

		// Token: 0x04001640 RID: 5696
		private static readonly IntPtr NativeFieldInfoPtr_hw_productName;

		// Token: 0x04001641 RID: 5697
		private static readonly IntPtr NativeFieldInfoPtr_hw_pidVid;

		// Token: 0x04001642 RID: 5698
		private static readonly IntPtr NativeFieldInfoPtr_hw_deviceGuid;

		// Token: 0x04001643 RID: 5699
		private static readonly IntPtr NativeFieldInfoPtr_hw_productId;

		// Token: 0x04001644 RID: 5700
		private static readonly IntPtr NativeFieldInfoPtr_hw_bluetoothDeviceName;

		// Token: 0x04001645 RID: 5701
		private static readonly IntPtr NativeFieldInfoPtr_hw_isBluetoothDevice;

		// Token: 0x04001646 RID: 5702
		private static readonly IntPtr NativeFieldInfoPtr_hw_supportsVoice;

		// Token: 0x04001647 RID: 5703
		private static readonly IntPtr NativeFieldInfoPtr_hw_supportsVibration;

		// Token: 0x04001648 RID: 5704
		private static readonly IntPtr NativeFieldInfoPtr_hw_xInputSubType;

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeFieldInfoPtr_hw_manufacturer;

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeFieldInfoPtr_hw_serialNumber;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeFieldInfoPtr_hw_vendorId;

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeFieldInfoPtr_hw_version;

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeFieldInfoPtr_hw_systemDeviceName;

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeFieldInfoPtr_hw_isSDL2Gamepad;

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeFieldInfoPtr_webGL_webBrowserType;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeFieldInfoPtr_webGL_osType;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeFieldInfoPtr_webGL_mappingType;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeFieldInfoPtr_webGL_webBrowserVersionSplit;

		// Token: 0x04001653 RID: 5715
		private static readonly IntPtr NativeFieldInfoPtr_webGL_osVersionSplit;

		// Token: 0x04001654 RID: 5716
		private static readonly IntPtr NativeFieldInfoPtr_hw_localVibrationMotorCount;

		// Token: 0x04001655 RID: 5717
		private static readonly IntPtr NativeFieldInfoPtr_definitionMatchTag;

		// Token: 0x04001656 RID: 5718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BridgedControllerHWInfo_0;

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeMethodInfoPtr_KCcpZvPkVNWEewMJPJcdZegzJsP_Private_Void_BridgedControllerHWInfo_0;
	}
}
