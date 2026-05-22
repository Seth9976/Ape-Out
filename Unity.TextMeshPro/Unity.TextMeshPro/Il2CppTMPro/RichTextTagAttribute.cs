using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x0200006E RID: 110
	[StructLayout(2)]
	public struct RichTextTagAttribute
	{
		// Token: 0x06000D07 RID: 3335 RVA: 0x00035904 File Offset: 0x00033B04
		// Note: this type is marked as 'beforefieldinit'.
		static RichTextTagAttribute()
		{
			Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "RichTextTagAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr);
			RichTextTagAttribute.NativeFieldInfoPtr_nameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "nameHashCode");
			RichTextTagAttribute.NativeFieldInfoPtr_valueHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "valueHashCode");
			RichTextTagAttribute.NativeFieldInfoPtr_valueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "valueType");
			RichTextTagAttribute.NativeFieldInfoPtr_valueStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "valueStartIndex");
			RichTextTagAttribute.NativeFieldInfoPtr_valueLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "valueLength");
			RichTextTagAttribute.NativeFieldInfoPtr_unitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "unitType");
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x000084E3 File Offset: 0x000066E3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, ref this));
		}

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeFieldInfoPtr_nameHashCode;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeFieldInfoPtr_valueHashCode;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeFieldInfoPtr_valueType;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeFieldInfoPtr_valueStartIndex;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeFieldInfoPtr_valueLength;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeFieldInfoPtr_unitType;

		// Token: 0x04000A57 RID: 2647
		[FieldOffset(0)]
		public int nameHashCode;

		// Token: 0x04000A58 RID: 2648
		[FieldOffset(4)]
		public int valueHashCode;

		// Token: 0x04000A59 RID: 2649
		[FieldOffset(8)]
		public TagValueType valueType;

		// Token: 0x04000A5A RID: 2650
		[FieldOffset(12)]
		public int valueStartIndex;

		// Token: 0x04000A5B RID: 2651
		[FieldOffset(16)]
		public int valueLength;

		// Token: 0x04000A5C RID: 2652
		[FieldOffset(20)]
		public TagUnitType unitType;
	}
}
