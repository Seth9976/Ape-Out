using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Platforms.PS4.Internal
{
	// Token: 0x02000181 RID: 385
	[StructLayout(2)]
	public struct PadDeviceClassExtendedInformation
	{
		// Token: 0x060028AF RID: 10415 RVA: 0x000CDAA4 File Offset: 0x000CBCA4
		// Note: this type is marked as 'beforefieldinit'.
		static PadDeviceClassExtendedInformation()
		{
			Il2CppClassPointerStore<PadDeviceClassExtendedInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.PS4.Internal", "PadDeviceClassExtendedInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PadDeviceClassExtendedInformation>.NativeClassPtr);
			PadDeviceClassExtendedInformation.NativeFieldInfoPtr_deviceClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadDeviceClassExtendedInformation>.NativeClassPtr, "deviceClass");
			PadDeviceClassExtendedInformation.NativeFieldInfoPtr_reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadDeviceClassExtendedInformation>.NativeClassPtr, "reserved");
			PadDeviceClassExtendedInformation.NativeFieldInfoPtr_capability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadDeviceClassExtendedInformation>.NativeClassPtr, "capability");
			PadDeviceClassExtendedInformation.NativeFieldInfoPtr_quantityOfSelectorSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadDeviceClassExtendedInformation>.NativeClassPtr, "quantityOfSelectorSwitch");
			PadDeviceClassExtendedInformation.NativeFieldInfoPtr_maxPhysicalWheelAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadDeviceClassExtendedInformation>.NativeClassPtr, "maxPhysicalWheelAngle");
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x0000FA85 File Offset: 0x0000DC85
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PadDeviceClassExtendedInformation>.NativeClassPtr, ref this));
		}

		// Token: 0x04002279 RID: 8825
		private static readonly IntPtr NativeFieldInfoPtr_deviceClass;

		// Token: 0x0400227A RID: 8826
		private static readonly IntPtr NativeFieldInfoPtr_reserved;

		// Token: 0x0400227B RID: 8827
		private static readonly IntPtr NativeFieldInfoPtr_capability;

		// Token: 0x0400227C RID: 8828
		private static readonly IntPtr NativeFieldInfoPtr_quantityOfSelectorSwitch;

		// Token: 0x0400227D RID: 8829
		private static readonly IntPtr NativeFieldInfoPtr_maxPhysicalWheelAngle;

		// Token: 0x0400227E RID: 8830
		[FieldOffset(0)]
		public int deviceClass;

		// Token: 0x0400227F RID: 8831
		[FieldOffset(4)]
		public int reserved;

		// Token: 0x04002280 RID: 8832
		[FieldOffset(8)]
		public byte capability;

		// Token: 0x04002281 RID: 8833
		[FieldOffset(9)]
		public byte quantityOfSelectorSwitch;

		// Token: 0x04002282 RID: 8834
		[FieldOffset(10)]
		public ushort maxPhysicalWheelAngle;
	}
}
