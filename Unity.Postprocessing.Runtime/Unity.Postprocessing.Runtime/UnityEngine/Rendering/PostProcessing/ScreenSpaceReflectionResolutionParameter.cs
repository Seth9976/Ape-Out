using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200002F RID: 47
	[Serializable]
	public sealed class ScreenSpaceReflectionResolutionParameter : ParameterOverride<ScreenSpaceReflectionResolution>
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x0000338D File Offset: 0x0000158D
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenSpaceReflectionResolutionParameter()
		{
			Il2CppClassPointerStore<ScreenSpaceReflectionResolutionParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "ScreenSpaceReflectionResolutionParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionResolutionParameter>.NativeClassPtr);
			ScreenSpaceReflectionResolutionParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionResolutionParameter>.NativeClassPtr, 100663421);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000B5E4 File Offset: 0x000097E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444590, XrefRangeEnd = 444593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenSpaceReflectionResolutionParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceReflectionResolutionParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionResolutionParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000033C6 File Offset: 0x000015C6
		public ScreenSpaceReflectionResolutionParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
