using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000A3 RID: 163
	[StructLayout(2)]
	public struct GradientColorKey
	{
		// Token: 0x06000EED RID: 3821 RVA: 0x0003DE68 File Offset: 0x0003C068
		// Note: this type is marked as 'beforefieldinit'.
		static GradientColorKey()
		{
			Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GradientColorKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr);
			GradientColorKey.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr, "color");
			GradientColorKey.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr, "time");
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00009B6F File Offset: 0x00007D6F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr, ref this));
		}

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x04000C59 RID: 3161
		[FieldOffset(0)]
		public Color color;

		// Token: 0x04000C5A RID: 3162
		[FieldOffset(16)]
		public float time;
	}
}
