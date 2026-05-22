using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Data.Mapping;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000156 RID: 342
	public class HardwareJoystickMap_InputManager : Object
	{
		// Token: 0x0600263A RID: 9786 RVA: 0x000C2F9C File Offset: 0x000C119C
		// Note: this type is marked as 'beforefieldinit'.
		static HardwareJoystickMap_InputManager()
		{
			Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "HardwareJoystickMap_InputManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr);
			HardwareJoystickMap_InputManager.NativeFieldInfoPtr_controllerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr, "controllerName");
			HardwareJoystickMap_InputManager.NativeFieldInfoPtr_hardwareMapIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr, "hardwareMapIdentifier");
			HardwareJoystickMap_InputManager.NativeFieldInfoPtr_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr, "map");
			HardwareJoystickMap_InputManager.NativeFieldInfoPtr_buttonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr, "buttonCount");
			HardwareJoystickMap_InputManager.NativeFieldInfoPtr_axisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr, "axisCount");
			HardwareJoystickMap_InputManager.NativeFieldInfoPtr_elementIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr, "elementIdentifiers");
			HardwareJoystickMap_InputManager.NativeFieldInfoPtr_compoundElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr, "compoundElements");
			HardwareJoystickMap_InputManager.NativeFieldInfoPtr_useSystemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr, "useSystemName");
			HardwareJoystickMap_InputManager.NativeFieldInfoPtr_isUnknownController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr, "isUnknownController");
			HardwareJoystickMap_InputManager.NativeFieldInfoPtr_joystickTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr, "joystickTypes");
			HardwareJoystickMap_InputManager.NativeMethodInfoPtr_GetAxisNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr, 100671581);
			HardwareJoystickMap_InputManager.NativeMethodInfoPtr_GetEffectiveButtonNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr, 100671582);
			HardwareJoystickMap_InputManager.NativeMethodInfoPtr__ctor_Public_Void_HardwareControllerMapIdentifier_Il2CppStructArray_1_JoystickType_Platform_String_Int32_Int32_Int32_Il2CppReferenceArray_1_CompoundElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr, 100671583);
			HardwareJoystickMap_InputManager.NativeMethodInfoPtr_ToGameHardwareControllerMap_Public_HardwareControllerMap_Game_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr, 100671584);
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x000C30E4 File Offset: 0x000C12E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294707, XrefRangeEnd = 294708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetAxisNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickMap_InputManager.NativeMethodInfoPtr_GetAxisNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x000C3124 File Offset: 0x000C1324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294708, XrefRangeEnd = 294709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetEffectiveButtonNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickMap_InputManager.NativeMethodInfoPtr_GetEffectiveButtonNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x000C3164 File Offset: 0x000C1364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294717, RefRangeEnd = 294718, XrefRangeStart = 294709, XrefRangeEnd = 294717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareJoystickMap_InputManager(HardwareControllerMapIdentifier hardwareMapIdentifier, Il2CppStructArray<JoystickType> joystickTypes, HardwareJoystickMap.Platform hardwarePlatformMap, string controllerName, int buttonCount, int axisCount, int elementIdentifierCount, Il2CppReferenceArray<HardwareJoystickMap.CompoundElement> compoundElements)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwareJoystickMap_InputManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hardwareMapIdentifier;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(joystickTypes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hardwarePlatformMap);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(controllerName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisCount;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compoundElements);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickMap_InputManager.NativeMethodInfoPtr__ctor_Public_Void_HardwareControllerMapIdentifier_Il2CppStructArray_1_JoystickType_Platform_String_Int32_Int32_Int32_Il2CppReferenceArray_1_CompoundElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x000C3220 File Offset: 0x000C1420
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 294733, RefRangeEnd = 294741, XrefRangeStart = 294718, XrefRangeEnd = 294733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareControllerMap_Game ToGameHardwareControllerMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwareJoystickMap_InputManager.NativeMethodInfoPtr_ToGameHardwareControllerMap_Public_HardwareControllerMap_Game_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareControllerMap_Game>(intPtr3) : null;
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x0000EED9 File Offset: 0x0000D0D9
		public HardwareJoystickMap_InputManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06002640 RID: 9792 RVA: 0x000C3260 File Offset: 0x000C1460
		// (set) Token: 0x06002641 RID: 9793 RVA: 0x0000EEE2 File Offset: 0x0000D0E2
		public unsafe string controllerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_controllerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_controllerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06002642 RID: 9794 RVA: 0x000C3288 File Offset: 0x000C1488
		// (set) Token: 0x06002643 RID: 9795 RVA: 0x0000EF01 File Offset: 0x0000D101
		public unsafe HardwareControllerMapIdentifier hardwareMapIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_hardwareMapIdentifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_hardwareMapIdentifier)) = value;
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06002644 RID: 9796 RVA: 0x000C32B0 File Offset: 0x000C14B0
		// (set) Token: 0x06002645 RID: 9797 RVA: 0x0000EF1C File Offset: 0x0000D11C
		public unsafe HardwareJoystickMap.Platform map
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_map);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HardwareJoystickMap.Platform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_map), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06002646 RID: 9798 RVA: 0x000C32E0 File Offset: 0x000C14E0
		// (set) Token: 0x06002647 RID: 9799 RVA: 0x0000EF3B File Offset: 0x0000D13B
		public unsafe int buttonCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_buttonCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_buttonCount)) = value;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06002648 RID: 9800 RVA: 0x000C3308 File Offset: 0x000C1508
		// (set) Token: 0x06002649 RID: 9801 RVA: 0x0000EF56 File Offset: 0x0000D156
		public unsafe int axisCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_axisCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_axisCount)) = value;
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x000C3330 File Offset: 0x000C1530
		// (set) Token: 0x0600264B RID: 9803 RVA: 0x0000EF71 File Offset: 0x0000D171
		public unsafe Il2CppReferenceArray<ControllerElementIdentifier> elementIdentifiers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_elementIdentifiers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControllerElementIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_elementIdentifiers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x000C3360 File Offset: 0x000C1560
		// (set) Token: 0x0600264D RID: 9805 RVA: 0x0000EF90 File Offset: 0x0000D190
		public unsafe Il2CppReferenceArray<HardwareJoystickMap.CompoundElement> compoundElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_compoundElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HardwareJoystickMap.CompoundElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_compoundElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x000C3390 File Offset: 0x000C1590
		// (set) Token: 0x0600264F RID: 9807 RVA: 0x0000EFAF File Offset: 0x0000D1AF
		public unsafe bool useSystemName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_useSystemName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_useSystemName)) = value;
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x000C33B8 File Offset: 0x000C15B8
		// (set) Token: 0x06002651 RID: 9809 RVA: 0x0000EFCA File Offset: 0x0000D1CA
		public unsafe bool isUnknownController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_isUnknownController);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_isUnknownController)) = value;
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06002652 RID: 9810 RVA: 0x000C33E0 File Offset: 0x000C15E0
		// (set) Token: 0x06002653 RID: 9811 RVA: 0x0000EFE5 File Offset: 0x0000D1E5
		public unsafe Il2CppStructArray<JoystickType> joystickTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_joystickTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<JoystickType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardwareJoystickMap_InputManager.NativeFieldInfoPtr_joystickTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F71 RID: 8049
		private static readonly IntPtr NativeFieldInfoPtr_controllerName;

		// Token: 0x04001F72 RID: 8050
		private static readonly IntPtr NativeFieldInfoPtr_hardwareMapIdentifier;

		// Token: 0x04001F73 RID: 8051
		private static readonly IntPtr NativeFieldInfoPtr_map;

		// Token: 0x04001F74 RID: 8052
		private static readonly IntPtr NativeFieldInfoPtr_buttonCount;

		// Token: 0x04001F75 RID: 8053
		private static readonly IntPtr NativeFieldInfoPtr_axisCount;

		// Token: 0x04001F76 RID: 8054
		private static readonly IntPtr NativeFieldInfoPtr_elementIdentifiers;

		// Token: 0x04001F77 RID: 8055
		private static readonly IntPtr NativeFieldInfoPtr_compoundElements;

		// Token: 0x04001F78 RID: 8056
		private static readonly IntPtr NativeFieldInfoPtr_useSystemName;

		// Token: 0x04001F79 RID: 8057
		private static readonly IntPtr NativeFieldInfoPtr_isUnknownController;

		// Token: 0x04001F7A RID: 8058
		private static readonly IntPtr NativeFieldInfoPtr_joystickTypes;

		// Token: 0x04001F7B RID: 8059
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisNames_Public_Il2CppStringArray_0;

		// Token: 0x04001F7C RID: 8060
		private static readonly IntPtr NativeMethodInfoPtr_GetEffectiveButtonNames_Public_Il2CppStringArray_0;

		// Token: 0x04001F7D RID: 8061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HardwareControllerMapIdentifier_Il2CppStructArray_1_JoystickType_Platform_String_Int32_Int32_Int32_Il2CppReferenceArray_1_CompoundElement_0;

		// Token: 0x04001F7E RID: 8062
		private static readonly IntPtr NativeMethodInfoPtr_ToGameHardwareControllerMap_Public_HardwareControllerMap_Game_0;
	}
}
