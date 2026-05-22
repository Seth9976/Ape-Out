using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	public sealed class EyeAdaptationParameter : ParameterOverride<EyeAdaptation>
	{
		// Token: 0x0600005E RID: 94 RVA: 0x000023CE File Offset: 0x000005CE
		// Note: this type is marked as 'beforefieldinit'.
		static EyeAdaptationParameter()
		{
			Il2CppClassPointerStore<EyeAdaptationParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "EyeAdaptationParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeAdaptationParameter>.NativeClassPtr);
			EyeAdaptationParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationParameter>.NativeClassPtr, 100663322);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00007014 File Offset: 0x00005214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441717, XrefRangeEnd = 441720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyeAdaptationParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeAdaptationParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002407 File Offset: 0x00000607
		public EyeAdaptationParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
