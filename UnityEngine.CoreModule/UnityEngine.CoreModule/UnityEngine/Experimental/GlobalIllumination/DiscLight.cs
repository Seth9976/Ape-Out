using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200019D RID: 413
	[StructLayout(2)]
	public struct DiscLight
	{
		// Token: 0x06001EE1 RID: 7905 RVA: 0x00071B2C File Offset: 0x0006FD2C
		// Note: this type is marked as 'beforefieldinit'.
		static DiscLight()
		{
			Il2CppClassPointerStore<DiscLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "DiscLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscLight>.NativeClassPtr);
			DiscLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "instanceID");
			DiscLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "shadow");
			DiscLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "mode");
			DiscLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "position");
			DiscLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "orientation");
			DiscLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "color");
			DiscLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "indirectColor");
			DiscLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "range");
			DiscLight.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "radius");
			DiscLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "falloff");
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x00010143 File Offset: 0x0000E343
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, ref this));
		}

		// Token: 0x04001830 RID: 6192
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x04001831 RID: 6193
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x04001832 RID: 6194
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x04001833 RID: 6195
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04001834 RID: 6196
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04001836 RID: 6198
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x04001837 RID: 6199
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04001838 RID: 6200
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x04001839 RID: 6201
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x0400183A RID: 6202
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x0400183B RID: 6203
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x0400183C RID: 6204
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x0400183D RID: 6205
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x0400183E RID: 6206
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x0400183F RID: 6207
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x04001840 RID: 6208
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x04001841 RID: 6209
		[FieldOffset(68)]
		public float range;

		// Token: 0x04001842 RID: 6210
		[FieldOffset(72)]
		public float radius;

		// Token: 0x04001843 RID: 6211
		[FieldOffset(76)]
		public FalloffType falloff;
	}
}
