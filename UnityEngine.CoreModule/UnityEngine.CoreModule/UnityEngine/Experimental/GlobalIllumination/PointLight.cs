using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200019A RID: 410
	[StructLayout(2)]
	public struct PointLight
	{
		// Token: 0x06001EDB RID: 7899 RVA: 0x000717F4 File Offset: 0x0006F9F4
		// Note: this type is marked as 'beforefieldinit'.
		static PointLight()
		{
			Il2CppClassPointerStore<PointLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "PointLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointLight>.NativeClassPtr);
			PointLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "instanceID");
			PointLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "shadow");
			PointLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "mode");
			PointLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "position");
			PointLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "orientation");
			PointLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "color");
			PointLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "indirectColor");
			PointLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "range");
			PointLight.NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "sphereRadius");
			PointLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "falloff");
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x0001010D File Offset: 0x0000E30D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PointLight>.NativeClassPtr, ref this));
		}

		// Token: 0x040017EC RID: 6124
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x040017ED RID: 6125
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x040017EE RID: 6126
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x040017F3 RID: 6131
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeFieldInfoPtr_sphereRadius;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x040017F6 RID: 6134
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x040017F7 RID: 6135
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x040017F8 RID: 6136
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x040017F9 RID: 6137
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x040017FA RID: 6138
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x040017FB RID: 6139
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x040017FC RID: 6140
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x040017FD RID: 6141
		[FieldOffset(68)]
		public float range;

		// Token: 0x040017FE RID: 6142
		[FieldOffset(72)]
		public float sphereRadius;

		// Token: 0x040017FF RID: 6143
		[FieldOffset(76)]
		public FalloffType falloff;
	}
}
