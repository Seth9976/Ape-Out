using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200019B RID: 411
	[StructLayout(2)]
	public struct SpotLight
	{
		// Token: 0x06001EDD RID: 7901 RVA: 0x000718EC File Offset: 0x0006FAEC
		// Note: this type is marked as 'beforefieldinit'.
		static SpotLight()
		{
			Il2CppClassPointerStore<SpotLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "SpotLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpotLight>.NativeClassPtr);
			SpotLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "instanceID");
			SpotLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "shadow");
			SpotLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "mode");
			SpotLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "position");
			SpotLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "orientation");
			SpotLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "color");
			SpotLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "indirectColor");
			SpotLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "range");
			SpotLight.NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "sphereRadius");
			SpotLight.NativeFieldInfoPtr_coneAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "coneAngle");
			SpotLight.NativeFieldInfoPtr_innerConeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "innerConeAngle");
			SpotLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "falloff");
			SpotLight.NativeFieldInfoPtr_angularFalloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "angularFalloff");
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x0001011F File Offset: 0x0000E31F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, ref this));
		}

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x04001801 RID: 6145
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x04001802 RID: 6146
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04001808 RID: 6152
		private static readonly IntPtr NativeFieldInfoPtr_sphereRadius;

		// Token: 0x04001809 RID: 6153
		private static readonly IntPtr NativeFieldInfoPtr_coneAngle;

		// Token: 0x0400180A RID: 6154
		private static readonly IntPtr NativeFieldInfoPtr_innerConeAngle;

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeFieldInfoPtr_angularFalloff;

		// Token: 0x0400180D RID: 6157
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x0400180E RID: 6158
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x0400180F RID: 6159
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x04001810 RID: 6160
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x04001811 RID: 6161
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x04001812 RID: 6162
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x04001813 RID: 6163
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x04001814 RID: 6164
		[FieldOffset(68)]
		public float range;

		// Token: 0x04001815 RID: 6165
		[FieldOffset(72)]
		public float sphereRadius;

		// Token: 0x04001816 RID: 6166
		[FieldOffset(76)]
		public float coneAngle;

		// Token: 0x04001817 RID: 6167
		[FieldOffset(80)]
		public float innerConeAngle;

		// Token: 0x04001818 RID: 6168
		[FieldOffset(84)]
		public FalloffType falloff;

		// Token: 0x04001819 RID: 6169
		[FieldOffset(85)]
		public AngularFalloffType angularFalloff;
	}
}
