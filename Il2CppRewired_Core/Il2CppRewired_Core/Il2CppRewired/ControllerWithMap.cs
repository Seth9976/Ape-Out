using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200005E RID: 94
	public class ControllerWithMap : Controller
	{
		// Token: 0x06000DD7 RID: 3543 RVA: 0x00006CBF File Offset: 0x00004EBF
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerWithMap()
		{
			Il2CppClassPointerStore<ControllerWithMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerWithMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerWithMap>.NativeClassPtr);
			ControllerWithMap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_InputSource_String_String_String_ControllerType_Guid_Int32_Il2CppStructArray_1_Boolean_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerWithMap>.NativeClassPtr, 100665390);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0005E3F0 File Offset: 0x0005C5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254302, XrefRangeEnd = 254303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerWithMap(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, ControllerType type, Guid hardwareTypeGuid, int buttonCount, Il2CppStructArray<bool> isButtonPressureSensitive, HardwareControllerMap_Game hardwareMap, Controller.Extension extension, ControllerDataUpdater dataUpdater)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerWithMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputSource;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hardwareName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hardwareIdentifier);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hardwareTypeGuid;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonCount;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(isButtonPressureSensitive);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hardwareMap);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extension);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataUpdater);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerWithMap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_InputSource_String_String_String_ControllerType_Guid_Int32_Il2CppStructArray_1_Boolean_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00006CF8 File Offset: 0x00004EF8
		public ControllerWithMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_InputSource_String_String_String_ControllerType_Guid_Int32_Il2CppStructArray_1_Boolean_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0;
	}
}
