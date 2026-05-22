using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200019C RID: 412
	[StructLayout(2)]
	public struct RectangleLight
	{
		// Token: 0x06001EDF RID: 7903 RVA: 0x00071A20 File Offset: 0x0006FC20
		// Note: this type is marked as 'beforefieldinit'.
		static RectangleLight()
		{
			Il2CppClassPointerStore<RectangleLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "RectangleLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr);
			RectangleLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "instanceID");
			RectangleLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "shadow");
			RectangleLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "mode");
			RectangleLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "position");
			RectangleLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "orientation");
			RectangleLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "color");
			RectangleLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "indirectColor");
			RectangleLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "range");
			RectangleLight.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "width");
			RectangleLight.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "height");
			RectangleLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "falloff");
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x00010131 File Offset: 0x0000E331
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, ref this));
		}

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x0400181B RID: 6171
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x0400181C RID: 6172
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x0400181D RID: 6173
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x0400181E RID: 6174
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04001820 RID: 6176
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x04001821 RID: 6177
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04001822 RID: 6178
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x04001823 RID: 6179
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04001824 RID: 6180
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x04001825 RID: 6181
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x04001826 RID: 6182
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x04001827 RID: 6183
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x04001828 RID: 6184
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x04001829 RID: 6185
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x0400182A RID: 6186
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x0400182B RID: 6187
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x0400182C RID: 6188
		[FieldOffset(68)]
		public float range;

		// Token: 0x0400182D RID: 6189
		[FieldOffset(72)]
		public float width;

		// Token: 0x0400182E RID: 6190
		[FieldOffset(76)]
		public float height;

		// Token: 0x0400182F RID: 6191
		[FieldOffset(80)]
		public FalloffType falloff;
	}
}
