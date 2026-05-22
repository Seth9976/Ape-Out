using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Platforms.PS4.Internal
{
	// Token: 0x02000183 RID: 387
	[StructLayout(2)]
	public struct PadTouchPadInformation
	{
		// Token: 0x060028B3 RID: 10419 RVA: 0x000CDB90 File Offset: 0x000CBD90
		// Note: this type is marked as 'beforefieldinit'.
		static PadTouchPadInformation()
		{
			Il2CppClassPointerStore<PadTouchPadInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.PS4.Internal", "PadTouchPadInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PadTouchPadInformation>.NativeClassPtr);
			PadTouchPadInformation.NativeFieldInfoPtr_pixelDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadTouchPadInformation>.NativeClassPtr, "pixelDensity");
			PadTouchPadInformation.NativeFieldInfoPtr_resolutionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadTouchPadInformation>.NativeClassPtr, "resolutionX");
			PadTouchPadInformation.NativeFieldInfoPtr_resolutionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadTouchPadInformation>.NativeClassPtr, "resolutionY");
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x0000FAA9 File Offset: 0x0000DCA9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PadTouchPadInformation>.NativeClassPtr, ref this));
		}

		// Token: 0x04002287 RID: 8839
		private static readonly IntPtr NativeFieldInfoPtr_pixelDensity;

		// Token: 0x04002288 RID: 8840
		private static readonly IntPtr NativeFieldInfoPtr_resolutionX;

		// Token: 0x04002289 RID: 8841
		private static readonly IntPtr NativeFieldInfoPtr_resolutionY;

		// Token: 0x0400228A RID: 8842
		[FieldOffset(0)]
		public float pixelDensity;

		// Token: 0x0400228B RID: 8843
		[FieldOffset(4)]
		public ushort resolutionX;

		// Token: 0x0400228C RID: 8844
		[FieldOffset(6)]
		public ushort resolutionY;
	}
}
