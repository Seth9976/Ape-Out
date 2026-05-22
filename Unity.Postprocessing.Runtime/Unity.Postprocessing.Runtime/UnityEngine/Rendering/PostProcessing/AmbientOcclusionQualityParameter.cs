using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200000B RID: 11
	[Serializable]
	public sealed class AmbientOcclusionQualityParameter : ParameterOverride<AmbientOcclusionQuality>
	{
		// Token: 0x0600002D RID: 45 RVA: 0x000021FD File Offset: 0x000003FD
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientOcclusionQualityParameter()
		{
			Il2CppClassPointerStore<AmbientOcclusionQualityParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "AmbientOcclusionQualityParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientOcclusionQualityParameter>.NativeClassPtr);
			AmbientOcclusionQualityParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionQualityParameter>.NativeClassPtr, 100663305);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000066AC File Offset: 0x000048AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441578, XrefRangeEnd = 441581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientOcclusionQualityParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientOcclusionQualityParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionQualityParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002236 File Offset: 0x00000436
		public AmbientOcclusionQualityParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
