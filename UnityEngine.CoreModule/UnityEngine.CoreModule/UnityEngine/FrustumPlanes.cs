using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000A5 RID: 165
	[Serializable]
	[StructLayout(2)]
	public struct FrustumPlanes
	{
		// Token: 0x06000F01 RID: 3841 RVA: 0x0003E28C File Offset: 0x0003C48C
		// Note: this type is marked as 'beforefieldinit'.
		static FrustumPlanes()
		{
			Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "FrustumPlanes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr);
			FrustumPlanes.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "left");
			FrustumPlanes.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "right");
			FrustumPlanes.NativeFieldInfoPtr_bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "bottom");
			FrustumPlanes.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "top");
			FrustumPlanes.NativeFieldInfoPtr_zNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "zNear");
			FrustumPlanes.NativeFieldInfoPtr_zFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "zFar");
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00009BF6 File Offset: 0x00007DF6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, ref this));
		}

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeFieldInfoPtr_bottom;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeFieldInfoPtr_zNear;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeFieldInfoPtr_zFar;

		// Token: 0x04000C6F RID: 3183
		[FieldOffset(0)]
		public float left;

		// Token: 0x04000C70 RID: 3184
		[FieldOffset(4)]
		public float right;

		// Token: 0x04000C71 RID: 3185
		[FieldOffset(8)]
		public float bottom;

		// Token: 0x04000C72 RID: 3186
		[FieldOffset(12)]
		public float top;

		// Token: 0x04000C73 RID: 3187
		[FieldOffset(16)]
		public float zNear;

		// Token: 0x04000C74 RID: 3188
		[FieldOffset(20)]
		public float zFar;
	}
}
