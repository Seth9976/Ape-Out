using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200014F RID: 335
	[StructLayout(2)]
	public struct Coord
	{
		// Token: 0x06001767 RID: 5991 RVA: 0x0008DA0C File Offset: 0x0008BC0C
		// Note: this type is marked as 'beforefieldinit'.
		static Coord()
		{
			Il2CppClassPointerStore<Coord>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Coord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Coord>.NativeClassPtr);
			Coord.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coord>.NativeClassPtr, "X");
			Coord.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coord>.NativeClassPtr, "Y");
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x000081FB File Offset: 0x000063FB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Coord>.NativeClassPtr, ref this));
		}

		// Token: 0x040015B0 RID: 5552
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x040015B1 RID: 5553
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x040015B2 RID: 5554
		[FieldOffset(0)]
		public short X;

		// Token: 0x040015B3 RID: 5555
		[FieldOffset(2)]
		public short Y;
	}
}
