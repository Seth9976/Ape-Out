using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[StructLayout(2)]
	public struct UILineInfo
	{
		// Token: 0x06000085 RID: 133 RVA: 0x0000443C File Offset: 0x0000263C
		// Note: this type is marked as 'beforefieldinit'.
		static UILineInfo()
		{
			Il2CppClassPointerStore<UILineInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "UILineInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr);
			UILineInfo.NativeFieldInfoPtr_startCharIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, "startCharIdx");
			UILineInfo.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, "height");
			UILineInfo.NativeFieldInfoPtr_topY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, "topY");
			UILineInfo.NativeFieldInfoPtr_leading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, "leading");
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000024EC File Offset: 0x000006EC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_startCharIdx;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_topY;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_leading;

		// Token: 0x04000085 RID: 133
		[FieldOffset(0)]
		public int startCharIdx;

		// Token: 0x04000086 RID: 134
		[FieldOffset(4)]
		public int height;

		// Token: 0x04000087 RID: 135
		[FieldOffset(8)]
		public float topY;

		// Token: 0x04000088 RID: 136
		[FieldOffset(12)]
		public float leading;
	}
}
