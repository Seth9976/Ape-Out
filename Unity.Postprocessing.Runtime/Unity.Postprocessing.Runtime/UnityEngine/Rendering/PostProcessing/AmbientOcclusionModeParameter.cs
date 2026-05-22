using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200000A RID: 10
	[Serializable]
	public sealed class AmbientOcclusionModeParameter : ParameterOverride<AmbientOcclusionMode>
	{
		// Token: 0x0600002A RID: 42 RVA: 0x000021BB File Offset: 0x000003BB
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientOcclusionModeParameter()
		{
			Il2CppClassPointerStore<AmbientOcclusionModeParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "AmbientOcclusionModeParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientOcclusionModeParameter>.NativeClassPtr);
			AmbientOcclusionModeParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionModeParameter>.NativeClassPtr, 100663304);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00006670 File Offset: 0x00004870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441575, XrefRangeEnd = 441578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientOcclusionModeParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientOcclusionModeParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionModeParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000021F4 File Offset: 0x000003F4
		public AmbientOcclusionModeParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
