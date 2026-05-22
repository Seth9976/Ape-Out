using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000150 RID: 336
	[StructLayout(2)]
	public struct SmallRect
	{
		// Token: 0x06001769 RID: 5993 RVA: 0x0008DA64 File Offset: 0x0008BC64
		// Note: this type is marked as 'beforefieldinit'.
		static SmallRect()
		{
			Il2CppClassPointerStore<SmallRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "SmallRect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmallRect>.NativeClassPtr);
			SmallRect.NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, "Left");
			SmallRect.NativeFieldInfoPtr_Top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, "Top");
			SmallRect.NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, "Right");
			SmallRect.NativeFieldInfoPtr_Bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, "Bottom");
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x0000820D File Offset: 0x0000640D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, ref this));
		}

		// Token: 0x040015B4 RID: 5556
		private static readonly IntPtr NativeFieldInfoPtr_Left;

		// Token: 0x040015B5 RID: 5557
		private static readonly IntPtr NativeFieldInfoPtr_Top;

		// Token: 0x040015B6 RID: 5558
		private static readonly IntPtr NativeFieldInfoPtr_Right;

		// Token: 0x040015B7 RID: 5559
		private static readonly IntPtr NativeFieldInfoPtr_Bottom;

		// Token: 0x040015B8 RID: 5560
		[FieldOffset(0)]
		public short Left;

		// Token: 0x040015B9 RID: 5561
		[FieldOffset(2)]
		public short Top;

		// Token: 0x040015BA RID: 5562
		[FieldOffset(4)]
		public short Right;

		// Token: 0x040015BB RID: 5563
		[FieldOffset(6)]
		public short Bottom;
	}
}
