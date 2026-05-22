using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.Common
{
	// Token: 0x02000213 RID: 531
	[Serializable]
	[StructLayout(2)]
	public struct ACTkByte8
	{
		// Token: 0x06001E2F RID: 7727 RVA: 0x00087150 File Offset: 0x00085350
		// Note: this type is marked as 'beforefieldinit'.
		static ACTkByte8()
		{
			Il2CppClassPointerStore<ACTkByte8>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.Common", "ACTkByte8");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACTkByte8>.NativeClassPtr);
			ACTkByte8.NativeFieldInfoPtr_b1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACTkByte8>.NativeClassPtr, "b1");
			ACTkByte8.NativeFieldInfoPtr_b2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACTkByte8>.NativeClassPtr, "b2");
			ACTkByte8.NativeFieldInfoPtr_b3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACTkByte8>.NativeClassPtr, "b3");
			ACTkByte8.NativeFieldInfoPtr_b4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACTkByte8>.NativeClassPtr, "b4");
			ACTkByte8.NativeFieldInfoPtr_b5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACTkByte8>.NativeClassPtr, "b5");
			ACTkByte8.NativeFieldInfoPtr_b6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACTkByte8>.NativeClassPtr, "b6");
			ACTkByte8.NativeFieldInfoPtr_b7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACTkByte8>.NativeClassPtr, "b7");
			ACTkByte8.NativeFieldInfoPtr_b8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACTkByte8>.NativeClassPtr, "b8");
			ACTkByte8.NativeMethodInfoPtr_Shuffle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACTkByte8>.NativeClassPtr, 100668179);
			ACTkByte8.NativeMethodInfoPtr_UnShuffle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACTkByte8>.NativeClassPtr, 100668180);
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x00087248 File Offset: 0x00085448
		[CallerCount(0)]
		public unsafe void Shuffle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACTkByte8.NativeMethodInfoPtr_Shuffle_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00087270 File Offset: 0x00085470
		[CallerCount(0)]
		public unsafe void UnShuffle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACTkByte8.NativeMethodInfoPtr_UnShuffle_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0000AEE2 File Offset: 0x000090E2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ACTkByte8>.NativeClassPtr, ref this));
		}

		// Token: 0x04001F1C RID: 7964
		private static readonly IntPtr NativeFieldInfoPtr_b1;

		// Token: 0x04001F1D RID: 7965
		private static readonly IntPtr NativeFieldInfoPtr_b2;

		// Token: 0x04001F1E RID: 7966
		private static readonly IntPtr NativeFieldInfoPtr_b3;

		// Token: 0x04001F1F RID: 7967
		private static readonly IntPtr NativeFieldInfoPtr_b4;

		// Token: 0x04001F20 RID: 7968
		private static readonly IntPtr NativeFieldInfoPtr_b5;

		// Token: 0x04001F21 RID: 7969
		private static readonly IntPtr NativeFieldInfoPtr_b6;

		// Token: 0x04001F22 RID: 7970
		private static readonly IntPtr NativeFieldInfoPtr_b7;

		// Token: 0x04001F23 RID: 7971
		private static readonly IntPtr NativeFieldInfoPtr_b8;

		// Token: 0x04001F24 RID: 7972
		private static readonly IntPtr NativeMethodInfoPtr_Shuffle_Public_Void_0;

		// Token: 0x04001F25 RID: 7973
		private static readonly IntPtr NativeMethodInfoPtr_UnShuffle_Public_Void_0;

		// Token: 0x04001F26 RID: 7974
		[FieldOffset(0)]
		public byte b1;

		// Token: 0x04001F27 RID: 7975
		[FieldOffset(1)]
		public byte b2;

		// Token: 0x04001F28 RID: 7976
		[FieldOffset(2)]
		public byte b3;

		// Token: 0x04001F29 RID: 7977
		[FieldOffset(3)]
		public byte b4;

		// Token: 0x04001F2A RID: 7978
		[FieldOffset(4)]
		public byte b5;

		// Token: 0x04001F2B RID: 7979
		[FieldOffset(5)]
		public byte b6;

		// Token: 0x04001F2C RID: 7980
		[FieldOffset(6)]
		public byte b7;

		// Token: 0x04001F2D RID: 7981
		[FieldOffset(7)]
		public byte b8;
	}
}
