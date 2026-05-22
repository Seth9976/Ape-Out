using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200001E RID: 30
	[Serializable]
	public sealed class KernelSizeParameter : ParameterOverride<KernelSize>
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00002D7D File Offset: 0x00000F7D
		// Note: this type is marked as 'beforefieldinit'.
		static KernelSizeParameter()
		{
			Il2CppClassPointerStore<KernelSizeParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "KernelSizeParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KernelSizeParameter>.NativeClassPtr);
			KernelSizeParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KernelSizeParameter>.NativeClassPtr, 100663356);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00008FA8 File Offset: 0x000071A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443077, XrefRangeEnd = 443080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KernelSizeParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KernelSizeParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KernelSizeParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002DB6 File Offset: 0x00000FB6
		public KernelSizeParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
