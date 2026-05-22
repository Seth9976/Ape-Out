using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x0200006D RID: 109
	[StructLayout(2)]
	public struct TagAttribute
	{
		// Token: 0x06000D05 RID: 3333 RVA: 0x00035898 File Offset: 0x00033A98
		// Note: this type is marked as 'beforefieldinit'.
		static TagAttribute()
		{
			Il2CppClassPointerStore<TagAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TagAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr);
			TagAttribute.NativeFieldInfoPtr_startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr, "startIndex");
			TagAttribute.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr, "length");
			TagAttribute.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr, "hashCode");
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x000084D1 File Offset: 0x000066D1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr, ref this));
		}

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeFieldInfoPtr_startIndex;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeFieldInfoPtr_hashCode;

		// Token: 0x04000A4E RID: 2638
		[FieldOffset(0)]
		public int startIndex;

		// Token: 0x04000A4F RID: 2639
		[FieldOffset(4)]
		public int length;

		// Token: 0x04000A50 RID: 2640
		[FieldOffset(8)]
		public int hashCode;
	}
}
