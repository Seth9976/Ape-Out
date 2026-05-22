using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Platforms.PS4.Internal
{
	// Token: 0x02000182 RID: 386
	[StructLayout(2)]
	public struct PadStickInformation
	{
		// Token: 0x060028B1 RID: 10417 RVA: 0x000CDB38 File Offset: 0x000CBD38
		// Note: this type is marked as 'beforefieldinit'.
		static PadStickInformation()
		{
			Il2CppClassPointerStore<PadStickInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.PS4.Internal", "PadStickInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PadStickInformation>.NativeClassPtr);
			PadStickInformation.NativeFieldInfoPtr_deadZoneLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadStickInformation>.NativeClassPtr, "deadZoneLeft");
			PadStickInformation.NativeFieldInfoPtr_deadZoneRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PadStickInformation>.NativeClassPtr, "deadZoneRight");
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x0000FA97 File Offset: 0x0000DC97
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PadStickInformation>.NativeClassPtr, ref this));
		}

		// Token: 0x04002283 RID: 8835
		private static readonly IntPtr NativeFieldInfoPtr_deadZoneLeft;

		// Token: 0x04002284 RID: 8836
		private static readonly IntPtr NativeFieldInfoPtr_deadZoneRight;

		// Token: 0x04002285 RID: 8837
		[FieldOffset(0)]
		public byte deadZoneLeft;

		// Token: 0x04002286 RID: 8838
		[FieldOffset(1)]
		public byte deadZoneRight;
	}
}
