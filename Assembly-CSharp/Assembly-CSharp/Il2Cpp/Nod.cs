using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000158 RID: 344
	[StructLayout(2)]
	public struct Nod
	{
		// Token: 0x0600293F RID: 10559 RVA: 0x000A6548 File Offset: 0x000A4748
		// Note: this type is marked as 'beforefieldinit'.
		static Nod()
		{
			Il2CppClassPointerStore<Nod>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Nod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Nod>.NativeClassPtr);
			Nod.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Nod>.NativeClassPtr, "pos");
			Nod.NativeFieldInfoPtr_dad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Nod>.NativeClassPtr, "dad");
			Nod.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Nod>.NativeClassPtr, "score");
			Nod.NativeFieldInfoPtr_cleanScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Nod>.NativeClassPtr, "cleanScore");
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x0001CBE5 File Offset: 0x0001ADE5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nod>.NativeClassPtr, ref this));
		}

		// Token: 0x04001847 RID: 6215
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x04001848 RID: 6216
		private static readonly IntPtr NativeFieldInfoPtr_dad;

		// Token: 0x04001849 RID: 6217
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x0400184A RID: 6218
		private static readonly IntPtr NativeFieldInfoPtr_cleanScore;

		// Token: 0x0400184B RID: 6219
		[FieldOffset(0)]
		public Intv2 pos;

		// Token: 0x0400184C RID: 6220
		[FieldOffset(8)]
		public int dad;

		// Token: 0x0400184D RID: 6221
		[FieldOffset(12)]
		public float score;

		// Token: 0x0400184E RID: 6222
		[FieldOffset(16)]
		public float cleanScore;
	}
}
