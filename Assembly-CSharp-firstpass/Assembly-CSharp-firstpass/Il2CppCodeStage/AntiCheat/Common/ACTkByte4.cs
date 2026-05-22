using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.Common
{
	// Token: 0x02000212 RID: 530
	[Serializable]
	[StructLayout(2)]
	public struct ACTkByte4
	{
		// Token: 0x06001E2B RID: 7723 RVA: 0x00087058 File Offset: 0x00085258
		// Note: this type is marked as 'beforefieldinit'.
		static ACTkByte4()
		{
			Il2CppClassPointerStore<ACTkByte4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.Common", "ACTkByte4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACTkByte4>.NativeClassPtr);
			ACTkByte4.NativeFieldInfoPtr_b1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACTkByte4>.NativeClassPtr, "b1");
			ACTkByte4.NativeFieldInfoPtr_b2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACTkByte4>.NativeClassPtr, "b2");
			ACTkByte4.NativeFieldInfoPtr_b3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACTkByte4>.NativeClassPtr, "b3");
			ACTkByte4.NativeFieldInfoPtr_b4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACTkByte4>.NativeClassPtr, "b4");
			ACTkByte4.NativeMethodInfoPtr_Shuffle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACTkByte4>.NativeClassPtr, 100668177);
			ACTkByte4.NativeMethodInfoPtr_UnShuffle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACTkByte4>.NativeClassPtr, 100668178);
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x00087100 File Offset: 0x00085300
		[CallerCount(0)]
		public unsafe void Shuffle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACTkByte4.NativeMethodInfoPtr_Shuffle_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x00087128 File Offset: 0x00085328
		[CallerCount(0)]
		public unsafe void UnShuffle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACTkByte4.NativeMethodInfoPtr_UnShuffle_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x0000AED0 File Offset: 0x000090D0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ACTkByte4>.NativeClassPtr, ref this));
		}

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeFieldInfoPtr_b1;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeFieldInfoPtr_b2;

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeFieldInfoPtr_b3;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeFieldInfoPtr_b4;

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeMethodInfoPtr_Shuffle_Public_Void_0;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeMethodInfoPtr_UnShuffle_Public_Void_0;

		// Token: 0x04001F18 RID: 7960
		[FieldOffset(0)]
		public byte b1;

		// Token: 0x04001F19 RID: 7961
		[FieldOffset(1)]
		public byte b2;

		// Token: 0x04001F1A RID: 7962
		[FieldOffset(2)]
		public byte b3;

		// Token: 0x04001F1B RID: 7963
		[FieldOffset(3)]
		public byte b4;
	}
}
