using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200001A RID: 26
	[Serializable]
	public sealed class TonemapperParameter : ParameterOverride<Tonemapper>
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x000027B9 File Offset: 0x000009B9
		// Note: this type is marked as 'beforefieldinit'.
		static TonemapperParameter()
		{
			Il2CppClassPointerStore<TonemapperParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "TonemapperParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TonemapperParameter>.NativeClassPtr);
			TonemapperParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TonemapperParameter>.NativeClassPtr, 100663340);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00007E2C File Offset: 0x0000602C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442176, XrefRangeEnd = 442179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TonemapperParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TonemapperParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TonemapperParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000027F2 File Offset: 0x000009F2
		public TonemapperParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
