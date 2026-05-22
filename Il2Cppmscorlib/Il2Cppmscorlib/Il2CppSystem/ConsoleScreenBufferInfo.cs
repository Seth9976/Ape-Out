using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000151 RID: 337
	[StructLayout(2)]
	public struct ConsoleScreenBufferInfo
	{
		// Token: 0x0600176B RID: 5995 RVA: 0x0008DAE4 File Offset: 0x0008BCE4
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleScreenBufferInfo()
		{
			Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleScreenBufferInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr);
			ConsoleScreenBufferInfo.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "Size");
			ConsoleScreenBufferInfo.NativeFieldInfoPtr_CursorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "CursorPosition");
			ConsoleScreenBufferInfo.NativeFieldInfoPtr_Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "Attribute");
			ConsoleScreenBufferInfo.NativeFieldInfoPtr_Window = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "Window");
			ConsoleScreenBufferInfo.NativeFieldInfoPtr_MaxWindowSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, "MaxWindowSize");
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x0000821F File Offset: 0x0000641F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConsoleScreenBufferInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x040015BC RID: 5564
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x040015BD RID: 5565
		private static readonly IntPtr NativeFieldInfoPtr_CursorPosition;

		// Token: 0x040015BE RID: 5566
		private static readonly IntPtr NativeFieldInfoPtr_Attribute;

		// Token: 0x040015BF RID: 5567
		private static readonly IntPtr NativeFieldInfoPtr_Window;

		// Token: 0x040015C0 RID: 5568
		private static readonly IntPtr NativeFieldInfoPtr_MaxWindowSize;

		// Token: 0x040015C1 RID: 5569
		[FieldOffset(0)]
		public Coord Size;

		// Token: 0x040015C2 RID: 5570
		[FieldOffset(4)]
		public Coord CursorPosition;

		// Token: 0x040015C3 RID: 5571
		[FieldOffset(8)]
		public short Attribute;

		// Token: 0x040015C4 RID: 5572
		[FieldOffset(10)]
		public SmallRect Window;

		// Token: 0x040015C5 RID: 5573
		[FieldOffset(18)]
		public Coord MaxWindowSize;
	}
}
