using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x02000007 RID: 7
	[StructLayout(2)]
	public struct YogaSize
	{
		// Token: 0x060000DC RID: 220 RVA: 0x000040A8 File Offset: 0x000022A8
		// Note: this type is marked as 'beforefieldinit'.
		static YogaSize()
		{
			Il2CppClassPointerStore<YogaSize>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsNativeModule.dll", "UnityEngine.Yoga", "YogaSize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YogaSize>.NativeClassPtr);
			YogaSize.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaSize>.NativeClassPtr, "width");
			YogaSize.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaSize>.NativeClassPtr, "height");
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000289D File Offset: 0x00000A9D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<YogaSize>.NativeClassPtr, ref this));
		}

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04000073 RID: 115
		[FieldOffset(0)]
		public float width;

		// Token: 0x04000074 RID: 116
		[FieldOffset(4)]
		public float height;
	}
}
