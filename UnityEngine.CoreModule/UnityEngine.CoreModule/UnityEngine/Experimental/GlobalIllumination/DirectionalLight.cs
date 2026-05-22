using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000199 RID: 409
	[StructLayout(2)]
	public struct DirectionalLight
	{
		// Token: 0x06001ED9 RID: 7897 RVA: 0x00071710 File Offset: 0x0006F910
		// Note: this type is marked as 'beforefieldinit'.
		static DirectionalLight()
		{
			Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "DirectionalLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr);
			DirectionalLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "instanceID");
			DirectionalLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "shadow");
			DirectionalLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "mode");
			DirectionalLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "position");
			DirectionalLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "orientation");
			DirectionalLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "color");
			DirectionalLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "indirectColor");
			DirectionalLight.NativeFieldInfoPtr_penumbraWidthRadian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "penumbraWidthRadian");
			DirectionalLight.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "direction");
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x000100FB File Offset: 0x0000E2FB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, ref this));
		}

		// Token: 0x040017DA RID: 6106
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x040017DB RID: 6107
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x040017DC RID: 6108
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040017DD RID: 6109
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040017DE RID: 6110
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x040017DF RID: 6111
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040017E0 RID: 6112
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x040017E1 RID: 6113
		private static readonly IntPtr NativeFieldInfoPtr_penumbraWidthRadian;

		// Token: 0x040017E2 RID: 6114
		private static readonly IntPtr NativeFieldInfoPtr_direction;

		// Token: 0x040017E3 RID: 6115
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x040017E4 RID: 6116
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x040017E5 RID: 6117
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x040017E6 RID: 6118
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x040017E7 RID: 6119
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x040017E8 RID: 6120
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x040017E9 RID: 6121
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x040017EA RID: 6122
		[FieldOffset(68)]
		public float penumbraWidthRadian;

		// Token: 0x040017EB RID: 6123
		[FieldOffset(72)]
		public Vector3 direction;
	}
}
