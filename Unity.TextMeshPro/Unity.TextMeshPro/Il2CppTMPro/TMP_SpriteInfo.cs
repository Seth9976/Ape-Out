using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x02000069 RID: 105
	[StructLayout(2)]
	public struct TMP_SpriteInfo
	{
		// Token: 0x06000C72 RID: 3186 RVA: 0x000345F0 File Offset: 0x000327F0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SpriteInfo()
		{
			Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SpriteInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr);
			TMP_SpriteInfo.NativeFieldInfoPtr_spriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr, "spriteIndex");
			TMP_SpriteInfo.NativeFieldInfoPtr_characterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr, "characterIndex");
			TMP_SpriteInfo.NativeFieldInfoPtr_vertexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr, "vertexIndex");
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00007C5C File Offset: 0x00005E5C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeFieldInfoPtr_spriteIndex;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeFieldInfoPtr_characterIndex;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeFieldInfoPtr_vertexIndex;

		// Token: 0x040009F9 RID: 2553
		[FieldOffset(0)]
		public int spriteIndex;

		// Token: 0x040009FA RID: 2554
		[FieldOffset(4)]
		public int characterIndex;

		// Token: 0x040009FB RID: 2555
		[FieldOffset(8)]
		public int vertexIndex;
	}
}
