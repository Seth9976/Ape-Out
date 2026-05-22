using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000137 RID: 311
	public class CalibrationMapSaveData : Object
	{
		// Token: 0x06002224 RID: 8740 RVA: 0x000AF344 File Offset: 0x000AD544
		// Note: this type is marked as 'beforefieldinit'.
		static CalibrationMapSaveData()
		{
			Il2CppClassPointerStore<CalibrationMapSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "CalibrationMapSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CalibrationMapSaveData>.NativeClassPtr);
			CalibrationMapSaveData.NativeFieldInfoPtr_chZZWHWPuFraWMJXOXEIniSkFVt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationMapSaveData>.NativeClassPtr, "chZZWHWPuFraWMJXOXEIniSkFVt");
			CalibrationMapSaveData.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationMapSaveData>.NativeClassPtr, "YgpbSyKqzywxZrpQdLClhHDXnpw");
			CalibrationMapSaveData.NativeFieldInfoPtr_jdcPETmMIvMmHVnMHCJJTSjrSqP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationMapSaveData>.NativeClassPtr, "jdcPETmMIvMmHVnMHCJJTSjrSqP");
			CalibrationMapSaveData.NativeMethodInfoPtr_get_map_Public_get_CalibrationMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMapSaveData>.NativeClassPtr, 100670670);
			CalibrationMapSaveData.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMapSaveData>.NativeClassPtr, 100670671);
			CalibrationMapSaveData.NativeMethodInfoPtr_get_hardwareIdentifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMapSaveData>.NativeClassPtr, 100670672);
			CalibrationMapSaveData.NativeMethodInfoPtr__ctor_Public_Void_CalibrationMap_ControllerType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMapSaveData>.NativeClassPtr, 100670673);
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06002225 RID: 8741 RVA: 0x000AF400 File Offset: 0x000AD600
		public unsafe CalibrationMap map
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMapSaveData.NativeMethodInfoPtr_get_map_Public_get_CalibrationMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CalibrationMap>(intPtr3) : null;
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x000AF440 File Offset: 0x000AD640
		public unsafe ControllerType controllerType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMapSaveData.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06002227 RID: 8743 RVA: 0x000AF47C File Offset: 0x000AD67C
		public unsafe string hardwareIdentifier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMapSaveData.NativeMethodInfoPtr_get_hardwareIdentifier_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x000AF4B4 File Offset: 0x000AD6B4
		[CallerCount(0)]
		public unsafe CalibrationMapSaveData(CalibrationMap calibrationMap, ControllerType controllerType, string hardwareIdentifier)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalibrationMapSaveData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(calibrationMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hardwareIdentifier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMapSaveData.NativeMethodInfoPtr__ctor_Public_Void_CalibrationMap_ControllerType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x0000DC50 File Offset: 0x0000BE50
		public CalibrationMapSaveData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x0600222A RID: 8746 RVA: 0x000AF520 File Offset: 0x000AD720
		// (set) Token: 0x0600222B RID: 8747 RVA: 0x0000DC59 File Offset: 0x0000BE59
		public unsafe CalibrationMap chZZWHWPuFraWMJXOXEIniSkFVt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationMapSaveData.NativeFieldInfoPtr_chZZWHWPuFraWMJXOXEIniSkFVt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CalibrationMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationMapSaveData.NativeFieldInfoPtr_chZZWHWPuFraWMJXOXEIniSkFVt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x000AF550 File Offset: 0x000AD750
		// (set) Token: 0x0600222D RID: 8749 RVA: 0x0000DC78 File Offset: 0x0000BE78
		public unsafe ControllerType YgpbSyKqzywxZrpQdLClhHDXnpw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationMapSaveData.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationMapSaveData.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw)) = value;
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x000AF578 File Offset: 0x000AD778
		// (set) Token: 0x0600222F RID: 8751 RVA: 0x0000DC93 File Offset: 0x0000BE93
		public unsafe string jdcPETmMIvMmHVnMHCJJTSjrSqP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationMapSaveData.NativeFieldInfoPtr_jdcPETmMIvMmHVnMHCJJTSjrSqP);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationMapSaveData.NativeFieldInfoPtr_jdcPETmMIvMmHVnMHCJJTSjrSqP), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001C34 RID: 7220
		private static readonly IntPtr NativeFieldInfoPtr_chZZWHWPuFraWMJXOXEIniSkFVt;

		// Token: 0x04001C35 RID: 7221
		private static readonly IntPtr NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw;

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeFieldInfoPtr_jdcPETmMIvMmHVnMHCJJTSjrSqP;

		// Token: 0x04001C37 RID: 7223
		private static readonly IntPtr NativeMethodInfoPtr_get_map_Public_get_CalibrationMap_0;

		// Token: 0x04001C38 RID: 7224
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeMethodInfoPtr_get_hardwareIdentifier_Public_get_String_0;

		// Token: 0x04001C3A RID: 7226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CalibrationMap_ControllerType_String_0;
	}
}
