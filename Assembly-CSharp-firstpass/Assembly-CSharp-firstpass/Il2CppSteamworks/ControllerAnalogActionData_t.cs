using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000128 RID: 296
	[StructLayout(2)]
	public struct ControllerAnalogActionData_t
	{
		// Token: 0x060009DF RID: 2527 RVA: 0x0002FC7C File Offset: 0x0002DE7C
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerAnalogActionData_t()
		{
			Il2CppClassPointerStore<ControllerAnalogActionData_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ControllerAnalogActionData_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerAnalogActionData_t>.NativeClassPtr);
			ControllerAnalogActionData_t.NativeFieldInfoPtr_eMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerAnalogActionData_t>.NativeClassPtr, "eMode");
			ControllerAnalogActionData_t.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerAnalogActionData_t>.NativeClassPtr, "x");
			ControllerAnalogActionData_t.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerAnalogActionData_t>.NativeClassPtr, "y");
			ControllerAnalogActionData_t.NativeFieldInfoPtr_bActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerAnalogActionData_t>.NativeClassPtr, "bActive");
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00006083 File Offset: 0x00004283
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerAnalogActionData_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeFieldInfoPtr_eMode;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeFieldInfoPtr_bActive;

		// Token: 0x04000C6B RID: 3179
		[FieldOffset(0)]
		public EControllerSourceMode eMode;

		// Token: 0x04000C6C RID: 3180
		[FieldOffset(4)]
		public float x;

		// Token: 0x04000C6D RID: 3181
		[FieldOffset(8)]
		public float y;

		// Token: 0x04000C6E RID: 3182
		[FieldOffset(12)]
		public byte bActive;
	}
}
