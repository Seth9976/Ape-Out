using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200014A RID: 330
	[StructLayout(2)]
	public struct BRECORD
	{
		// Token: 0x06001744 RID: 5956 RVA: 0x0008CFDC File Offset: 0x0008B1DC
		// Note: this type is marked as 'beforefieldinit'.
		static BRECORD()
		{
			Il2CppClassPointerStore<BRECORD>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "BRECORD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BRECORD>.NativeClassPtr);
			BRECORD.NativeFieldInfoPtr_pvRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BRECORD>.NativeClassPtr, "pvRecord");
			BRECORD.NativeFieldInfoPtr_pRecInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BRECORD>.NativeClassPtr, "pRecInfo");
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00008122 File Offset: 0x00006322
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BRECORD>.NativeClassPtr, ref this));
		}

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeFieldInfoPtr_pvRecord;

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeFieldInfoPtr_pRecInfo;

		// Token: 0x04001587 RID: 5511
		[FieldOffset(0)]
		public IntPtr pvRecord;

		// Token: 0x04001588 RID: 5512
		[FieldOffset(8)]
		public IntPtr pRecInfo;
	}
}
