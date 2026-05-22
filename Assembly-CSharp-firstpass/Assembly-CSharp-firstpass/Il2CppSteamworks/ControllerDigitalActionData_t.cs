using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000129 RID: 297
	[StructLayout(2)]
	public struct ControllerDigitalActionData_t
	{
		// Token: 0x060009E1 RID: 2529 RVA: 0x0002FCFC File Offset: 0x0002DEFC
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerDigitalActionData_t()
		{
			Il2CppClassPointerStore<ControllerDigitalActionData_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ControllerDigitalActionData_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerDigitalActionData_t>.NativeClassPtr);
			ControllerDigitalActionData_t.NativeFieldInfoPtr_bState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDigitalActionData_t>.NativeClassPtr, "bState");
			ControllerDigitalActionData_t.NativeFieldInfoPtr_bActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDigitalActionData_t>.NativeClassPtr, "bActive");
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00006095 File Offset: 0x00004295
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerDigitalActionData_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeFieldInfoPtr_bState;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeFieldInfoPtr_bActive;

		// Token: 0x04000C71 RID: 3185
		[FieldOffset(0)]
		public byte bState;

		// Token: 0x04000C72 RID: 3186
		[FieldOffset(1)]
		public byte bActive;
	}
}
