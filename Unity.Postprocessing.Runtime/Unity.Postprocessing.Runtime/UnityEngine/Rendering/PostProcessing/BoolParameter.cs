using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000042 RID: 66
	[Serializable]
	public sealed class BoolParameter : ParameterOverride<bool>
	{
		// Token: 0x060002CD RID: 717 RVA: 0x00003AB2 File Offset: 0x00001CB2
		// Note: this type is marked as 'beforefieldinit'.
		static BoolParameter()
		{
			Il2CppClassPointerStore<BoolParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "BoolParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolParameter>.NativeClassPtr);
			BoolParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolParameter>.NativeClassPtr, 100663502);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000E568 File Offset: 0x0000C768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445731, XrefRangeEnd = 445734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00003AEB File Offset: 0x00001CEB
		public BoolParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
