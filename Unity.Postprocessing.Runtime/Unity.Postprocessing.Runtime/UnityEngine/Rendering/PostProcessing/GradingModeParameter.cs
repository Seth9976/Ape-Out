using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000019 RID: 25
	[Serializable]
	public sealed class GradingModeParameter : ParameterOverride<GradingMode>
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00002777 File Offset: 0x00000977
		// Note: this type is marked as 'beforefieldinit'.
		static GradingModeParameter()
		{
			Il2CppClassPointerStore<GradingModeParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "GradingModeParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradingModeParameter>.NativeClassPtr);
			GradingModeParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradingModeParameter>.NativeClassPtr, 100663339);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00007DF0 File Offset: 0x00005FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442173, XrefRangeEnd = 442176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GradingModeParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GradingModeParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradingModeParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000027B0 File Offset: 0x000009B0
		public GradingModeParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
