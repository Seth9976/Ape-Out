using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Platforms.PS4.Internal
{
	// Token: 0x02000180 RID: 384
	[StructLayout(2)]
	public struct PadControllerInformation
	{
		// Token: 0x060028AD RID: 10413 RVA: 0x000CD95C File Offset: 0x000CBB5C
		// Note: this type is marked as 'beforefieldinit'.
		static PadControllerInformation()
		{
			Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.PS4.Internal", "PadControllerInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr);
			PadControllerInformation.NativeFieldInfoPtr_touchPadInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr, "touchPadInfo");
			PadControllerInformation.NativeFieldInfoPtr_stickInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr, "stickInfo");
			PadControllerInformation.NativeFieldInfoPtr_connectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr, "connectionType");
			PadControllerInformation.NativeFieldInfoPtr_connectedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr, "connectedCount");
			PadControllerInformation.NativeFieldInfoPtr_connected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr, "connected");
			PadControllerInformation.NativeFieldInfoPtr_deviceClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr, "deviceClass");
			PadControllerInformation.NativeFieldInfoPtr_reserve0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr, "reserve0");
			PadControllerInformation.NativeFieldInfoPtr_reserve1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr, "reserve1");
			PadControllerInformation.NativeFieldInfoPtr_reserve2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr, "reserve2");
			PadControllerInformation.NativeFieldInfoPtr_reserve3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr, "reserve3");
			PadControllerInformation.NativeFieldInfoPtr_reserve4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr, "reserve4");
			PadControllerInformation.NativeFieldInfoPtr_reserve5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr, "reserve5");
			PadControllerInformation.NativeFieldInfoPtr_reserve6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr, "reserve6");
			PadControllerInformation.NativeFieldInfoPtr_reserve7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr, "reserve7");
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x0000FA73 File Offset: 0x0000DC73
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PadControllerInformation>.NativeClassPtr, ref this));
		}

		// Token: 0x0400225D RID: 8797
		private static readonly IntPtr NativeFieldInfoPtr_touchPadInfo;

		// Token: 0x0400225E RID: 8798
		private static readonly IntPtr NativeFieldInfoPtr_stickInfo;

		// Token: 0x0400225F RID: 8799
		private static readonly IntPtr NativeFieldInfoPtr_connectionType;

		// Token: 0x04002260 RID: 8800
		private static readonly IntPtr NativeFieldInfoPtr_connectedCount;

		// Token: 0x04002261 RID: 8801
		private static readonly IntPtr NativeFieldInfoPtr_connected;

		// Token: 0x04002262 RID: 8802
		private static readonly IntPtr NativeFieldInfoPtr_deviceClass;

		// Token: 0x04002263 RID: 8803
		private static readonly IntPtr NativeFieldInfoPtr_reserve0;

		// Token: 0x04002264 RID: 8804
		private static readonly IntPtr NativeFieldInfoPtr_reserve1;

		// Token: 0x04002265 RID: 8805
		private static readonly IntPtr NativeFieldInfoPtr_reserve2;

		// Token: 0x04002266 RID: 8806
		private static readonly IntPtr NativeFieldInfoPtr_reserve3;

		// Token: 0x04002267 RID: 8807
		private static readonly IntPtr NativeFieldInfoPtr_reserve4;

		// Token: 0x04002268 RID: 8808
		private static readonly IntPtr NativeFieldInfoPtr_reserve5;

		// Token: 0x04002269 RID: 8809
		private static readonly IntPtr NativeFieldInfoPtr_reserve6;

		// Token: 0x0400226A RID: 8810
		private static readonly IntPtr NativeFieldInfoPtr_reserve7;

		// Token: 0x0400226B RID: 8811
		[FieldOffset(0)]
		public PadTouchPadInformation touchPadInfo;

		// Token: 0x0400226C RID: 8812
		[FieldOffset(8)]
		public PadStickInformation stickInfo;

		// Token: 0x0400226D RID: 8813
		[FieldOffset(10)]
		public byte connectionType;

		// Token: 0x0400226E RID: 8814
		[FieldOffset(11)]
		public byte connectedCount;

		// Token: 0x0400226F RID: 8815
		[FieldOffset(12)]
		public int connected;

		// Token: 0x04002270 RID: 8816
		[FieldOffset(16)]
		public int deviceClass;

		// Token: 0x04002271 RID: 8817
		[FieldOffset(20)]
		public byte reserve0;

		// Token: 0x04002272 RID: 8818
		[FieldOffset(21)]
		public byte reserve1;

		// Token: 0x04002273 RID: 8819
		[FieldOffset(22)]
		public byte reserve2;

		// Token: 0x04002274 RID: 8820
		[FieldOffset(23)]
		public byte reserve3;

		// Token: 0x04002275 RID: 8821
		[FieldOffset(24)]
		public byte reserve4;

		// Token: 0x04002276 RID: 8822
		[FieldOffset(25)]
		public byte reserve5;

		// Token: 0x04002277 RID: 8823
		[FieldOffset(26)]
		public byte reserve6;

		// Token: 0x04002278 RID: 8824
		[FieldOffset(27)]
		public byte reserve7;
	}
}
