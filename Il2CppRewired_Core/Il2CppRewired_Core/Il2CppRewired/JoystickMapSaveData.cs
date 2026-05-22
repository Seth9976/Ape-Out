using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200014A RID: 330
	public sealed class JoystickMapSaveData : ControllerMapSaveData
	{
		// Token: 0x06002403 RID: 9219 RVA: 0x000B672C File Offset: 0x000B492C
		// Note: this type is marked as 'beforefieldinit'.
		static JoystickMapSaveData()
		{
			Il2CppClassPointerStore<JoystickMapSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "JoystickMapSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoystickMapSaveData>.NativeClassPtr);
			JoystickMapSaveData.NativeMethodInfoPtr_get_joystick_Public_get_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickMapSaveData>.NativeClassPtr, 100671039);
			JoystickMapSaveData.NativeMethodInfoPtr_get_joystickMap_Public_get_JoystickMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickMapSaveData>.NativeClassPtr, 100671040);
			JoystickMapSaveData.NativeMethodInfoPtr_get_joystickHardwareTypeGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickMapSaveData>.NativeClassPtr, 100671041);
			JoystickMapSaveData.NativeMethodInfoPtr__ctor_Internal_Void_Joystick_JoystickMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickMapSaveData>.NativeClassPtr, 100671042);
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002404 RID: 9220 RVA: 0x000B67AC File Offset: 0x000B49AC
		public unsafe Joystick joystick
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290072, XrefRangeEnd = 290078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoystickMapSaveData.NativeMethodInfoPtr_get_joystick_Public_get_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Joystick>(intPtr3) : null;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x000B67EC File Offset: 0x000B49EC
		public unsafe JoystickMap joystickMap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290078, XrefRangeEnd = 290084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoystickMapSaveData.NativeMethodInfoPtr_get_joystickMap_Public_get_JoystickMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JoystickMap>(intPtr3) : null;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002406 RID: 9222 RVA: 0x000B682C File Offset: 0x000B4A2C
		public unsafe Guid joystickHardwareTypeGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290084, XrefRangeEnd = 290103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoystickMapSaveData.NativeMethodInfoPtr_get_joystickHardwareTypeGuid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x000B6868 File Offset: 0x000B4A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoystickMapSaveData(Joystick joystick, JoystickMap map)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickMapSaveData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(joystick);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(map);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoystickMapSaveData.NativeMethodInfoPtr__ctor_Internal_Void_Joystick_JoystickMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x0000E760 File Offset: 0x0000C960
		public JoystickMapSaveData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D90 RID: 7568
		private static readonly IntPtr NativeMethodInfoPtr_get_joystick_Public_get_Joystick_0;

		// Token: 0x04001D91 RID: 7569
		private static readonly IntPtr NativeMethodInfoPtr_get_joystickMap_Public_get_JoystickMap_0;

		// Token: 0x04001D92 RID: 7570
		private static readonly IntPtr NativeMethodInfoPtr_get_joystickHardwareTypeGuid_Public_get_Guid_0;

		// Token: 0x04001D93 RID: 7571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Joystick_JoystickMap_0;
	}
}
