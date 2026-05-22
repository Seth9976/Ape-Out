using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200012A RID: 298
	[StructLayout(2)]
	public struct ControllerMotionData_t
	{
		// Token: 0x060009E3 RID: 2531 RVA: 0x0002FD54 File Offset: 0x0002DF54
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerMotionData_t()
		{
			Il2CppClassPointerStore<ControllerMotionData_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ControllerMotionData_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMotionData_t>.NativeClassPtr);
			ControllerMotionData_t.NativeFieldInfoPtr_rotQuatX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMotionData_t>.NativeClassPtr, "rotQuatX");
			ControllerMotionData_t.NativeFieldInfoPtr_rotQuatY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMotionData_t>.NativeClassPtr, "rotQuatY");
			ControllerMotionData_t.NativeFieldInfoPtr_rotQuatZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMotionData_t>.NativeClassPtr, "rotQuatZ");
			ControllerMotionData_t.NativeFieldInfoPtr_rotQuatW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMotionData_t>.NativeClassPtr, "rotQuatW");
			ControllerMotionData_t.NativeFieldInfoPtr_posAccelX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMotionData_t>.NativeClassPtr, "posAccelX");
			ControllerMotionData_t.NativeFieldInfoPtr_posAccelY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMotionData_t>.NativeClassPtr, "posAccelY");
			ControllerMotionData_t.NativeFieldInfoPtr_posAccelZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMotionData_t>.NativeClassPtr, "posAccelZ");
			ControllerMotionData_t.NativeFieldInfoPtr_rotVelX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMotionData_t>.NativeClassPtr, "rotVelX");
			ControllerMotionData_t.NativeFieldInfoPtr_rotVelY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMotionData_t>.NativeClassPtr, "rotVelY");
			ControllerMotionData_t.NativeFieldInfoPtr_rotVelZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMotionData_t>.NativeClassPtr, "rotVelZ");
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000060A7 File Offset: 0x000042A7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerMotionData_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeFieldInfoPtr_rotQuatX;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeFieldInfoPtr_rotQuatY;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeFieldInfoPtr_rotQuatZ;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeFieldInfoPtr_rotQuatW;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeFieldInfoPtr_posAccelX;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeFieldInfoPtr_posAccelY;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeFieldInfoPtr_posAccelZ;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeFieldInfoPtr_rotVelX;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeFieldInfoPtr_rotVelY;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeFieldInfoPtr_rotVelZ;

		// Token: 0x04000C7D RID: 3197
		[FieldOffset(0)]
		public float rotQuatX;

		// Token: 0x04000C7E RID: 3198
		[FieldOffset(4)]
		public float rotQuatY;

		// Token: 0x04000C7F RID: 3199
		[FieldOffset(8)]
		public float rotQuatZ;

		// Token: 0x04000C80 RID: 3200
		[FieldOffset(12)]
		public float rotQuatW;

		// Token: 0x04000C81 RID: 3201
		[FieldOffset(16)]
		public float posAccelX;

		// Token: 0x04000C82 RID: 3202
		[FieldOffset(20)]
		public float posAccelY;

		// Token: 0x04000C83 RID: 3203
		[FieldOffset(24)]
		public float posAccelZ;

		// Token: 0x04000C84 RID: 3204
		[FieldOffset(28)]
		public float rotVelX;

		// Token: 0x04000C85 RID: 3205
		[FieldOffset(32)]
		public float rotVelY;

		// Token: 0x04000C86 RID: 3206
		[FieldOffset(36)]
		public float rotVelZ;
	}
}
