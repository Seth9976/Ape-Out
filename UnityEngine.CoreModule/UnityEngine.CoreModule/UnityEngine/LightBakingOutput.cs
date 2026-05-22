using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000073 RID: 115
	[StructLayout(2)]
	public struct LightBakingOutput
	{
		// Token: 0x06000A79 RID: 2681 RVA: 0x0002E648 File Offset: 0x0002C848
		// Note: this type is marked as 'beforefieldinit'.
		static LightBakingOutput()
		{
			Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightBakingOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr);
			LightBakingOutput.NativeFieldInfoPtr_probeOcclusionLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "probeOcclusionLightIndex");
			LightBakingOutput.NativeFieldInfoPtr_occlusionMaskChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "occlusionMaskChannel");
			LightBakingOutput.NativeFieldInfoPtr_lightmapBakeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "lightmapBakeType");
			LightBakingOutput.NativeFieldInfoPtr_mixedLightingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "mixedLightingMode");
			LightBakingOutput.NativeFieldInfoPtr_isBaked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "isBaked");
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00007B09 File Offset: 0x00005D09
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeFieldInfoPtr_probeOcclusionLightIndex;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeFieldInfoPtr_occlusionMaskChannel;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeFieldInfoPtr_lightmapBakeType;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeFieldInfoPtr_mixedLightingMode;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeFieldInfoPtr_isBaked;

		// Token: 0x04000704 RID: 1796
		[FieldOffset(0)]
		public int probeOcclusionLightIndex;

		// Token: 0x04000705 RID: 1797
		[FieldOffset(4)]
		public int occlusionMaskChannel;

		// Token: 0x04000706 RID: 1798
		[FieldOffset(8)]
		public LightmapBakeType lightmapBakeType;

		// Token: 0x04000707 RID: 1799
		[FieldOffset(12)]
		public MixedLightingMode mixedLightingMode;

		// Token: 0x04000708 RID: 1800
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool isBaked;
	}
}
