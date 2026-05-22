using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000138 RID: 312
	public sealed class JoystickCalibrationMapSaveData : CalibrationMapSaveData
	{
		// Token: 0x06002230 RID: 8752 RVA: 0x000AF5A0 File Offset: 0x000AD7A0
		// Note: this type is marked as 'beforefieldinit'.
		static JoystickCalibrationMapSaveData()
		{
			Il2CppClassPointerStore<JoystickCalibrationMapSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "JoystickCalibrationMapSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoystickCalibrationMapSaveData>.NativeClassPtr);
			JoystickCalibrationMapSaveData.NativeFieldInfoPtr_TVmdVlqDIpecMaGZNgNZdeErpuDW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickCalibrationMapSaveData>.NativeClassPtr, "TVmdVlqDIpecMaGZNgNZdeErpuDW");
			JoystickCalibrationMapSaveData.NativeMethodInfoPtr_get_joystickHardwareTypeGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickCalibrationMapSaveData>.NativeClassPtr, 100670674);
			JoystickCalibrationMapSaveData.NativeMethodInfoPtr__ctor_Public_Void_CalibrationMap_ControllerType_String_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickCalibrationMapSaveData>.NativeClassPtr, 100670675);
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002231 RID: 8753 RVA: 0x000AF60C File Offset: 0x000AD80C
		public unsafe Guid joystickHardwareTypeGuid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoystickCalibrationMapSaveData.NativeMethodInfoPtr_get_joystickHardwareTypeGuid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x000AF648 File Offset: 0x000AD848
		[CallerCount(0)]
		public unsafe JoystickCalibrationMapSaveData(CalibrationMap calibrationMap, ControllerType controllerType, string hardwareIdentifier, Guid joystickHardwareTypeGuid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickCalibrationMapSaveData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(calibrationMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hardwareIdentifier);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref joystickHardwareTypeGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoystickCalibrationMapSaveData.NativeMethodInfoPtr__ctor_Public_Void_CalibrationMap_ControllerType_String_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x0000DCB2 File Offset: 0x0000BEB2
		public JoystickCalibrationMapSaveData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x000AF6C4 File Offset: 0x000AD8C4
		// (set) Token: 0x06002235 RID: 8757 RVA: 0x0000DCBB File Offset: 0x0000BEBB
		public unsafe Guid TVmdVlqDIpecMaGZNgNZdeErpuDW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoystickCalibrationMapSaveData.NativeFieldInfoPtr_TVmdVlqDIpecMaGZNgNZdeErpuDW);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoystickCalibrationMapSaveData.NativeFieldInfoPtr_TVmdVlqDIpecMaGZNgNZdeErpuDW)) = value;
			}
		}

		// Token: 0x04001C3B RID: 7227
		private static readonly IntPtr NativeFieldInfoPtr_TVmdVlqDIpecMaGZNgNZdeErpuDW;

		// Token: 0x04001C3C RID: 7228
		private static readonly IntPtr NativeMethodInfoPtr_get_joystickHardwareTypeGuid_Public_get_Guid_0;

		// Token: 0x04001C3D RID: 7229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CalibrationMap_ControllerType_String_Guid_0;
	}
}
