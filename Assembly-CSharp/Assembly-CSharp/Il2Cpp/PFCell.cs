using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000155 RID: 341
	[Serializable]
	[StructLayout(2)]
	public struct PFCell
	{
		// Token: 0x0600292B RID: 10539 RVA: 0x000A6254 File Offset: 0x000A4454
		// Note: this type is marked as 'beforefieldinit'.
		static PFCell()
		{
			Il2CppClassPointerStore<PFCell>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PFCell");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PFCell>.NativeClassPtr);
			PFCell.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PFCell>.NativeClassPtr, "value");
			PFCell.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PFCell>.NativeClassPtr, "pos");
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x0001CB12 File Offset: 0x0001AD12
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PFCell>.NativeClassPtr, ref this));
		}

		// Token: 0x04001837 RID: 6199
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04001838 RID: 6200
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x04001839 RID: 6201
		[FieldOffset(0)]
		public int value;

		// Token: 0x0400183A RID: 6202
		[FieldOffset(4)]
		public Intv2 pos;
	}
}
