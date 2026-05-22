using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200002E RID: 46
	[Serializable]
	public sealed class ScreenSpaceReflectionPresetParameter : ParameterOverride<ScreenSpaceReflectionPreset>
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x0000334B File Offset: 0x0000154B
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenSpaceReflectionPresetParameter()
		{
			Il2CppClassPointerStore<ScreenSpaceReflectionPresetParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "ScreenSpaceReflectionPresetParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionPresetParameter>.NativeClassPtr);
			ScreenSpaceReflectionPresetParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionPresetParameter>.NativeClassPtr, 100663420);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000B5A8 File Offset: 0x000097A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444587, XrefRangeEnd = 444590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenSpaceReflectionPresetParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceReflectionPresetParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionPresetParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00003384 File Offset: 0x00001584
		public ScreenSpaceReflectionPresetParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
