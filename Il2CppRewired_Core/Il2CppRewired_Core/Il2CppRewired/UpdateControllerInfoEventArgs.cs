using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Interfaces;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200010E RID: 270
	public class UpdateControllerInfoEventArgs : EventArgs
	{
		// Token: 0x06001A29 RID: 6697 RVA: 0x00092E18 File Offset: 0x00091018
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateControllerInfoEventArgs()
		{
			Il2CppClassPointerStore<UpdateControllerInfoEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "UpdateControllerInfoEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateControllerInfoEventArgs>.NativeClassPtr);
			UpdateControllerInfoEventArgs.NativeFieldInfoPtr_sourceJoystick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateControllerInfoEventArgs>.NativeClassPtr, "sourceJoystick");
			UpdateControllerInfoEventArgs.NativeMethodInfoPtr__ctor_Public_Void_IInputManagerJoystickPublic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateControllerInfoEventArgs>.NativeClassPtr, 100669486);
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x00092E70 File Offset: 0x00091070
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 279042, RefRangeEnd = 279049, XrefRangeStart = 279039, XrefRangeEnd = 279042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateControllerInfoEventArgs(IInputManagerJoystickPublic sourceJoystick)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateControllerInfoEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceJoystick);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateControllerInfoEventArgs.NativeMethodInfoPtr__ctor_Public_Void_IInputManagerJoystickPublic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0000AB1C File Offset: 0x00008D1C
		public UpdateControllerInfoEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x00092EBC File Offset: 0x000910BC
		// (set) Token: 0x06001A2D RID: 6701 RVA: 0x0000AB25 File Offset: 0x00008D25
		public unsafe IInputManagerJoystickPublic sourceJoystick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateControllerInfoEventArgs.NativeFieldInfoPtr_sourceJoystick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IInputManagerJoystickPublic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateControllerInfoEventArgs.NativeFieldInfoPtr_sourceJoystick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001684 RID: 5764
		private static readonly IntPtr NativeFieldInfoPtr_sourceJoystick;

		// Token: 0x04001685 RID: 5765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IInputManagerJoystickPublic_0;
	}
}
