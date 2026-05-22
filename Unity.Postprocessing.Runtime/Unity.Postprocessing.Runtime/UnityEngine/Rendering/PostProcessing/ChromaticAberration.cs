using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000015 RID: 21
	[Serializable]
	public sealed class ChromaticAberration : PostProcessEffectSettings
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00007ADC File Offset: 0x00005CDC
		// Note: this type is marked as 'beforefieldinit'.
		static ChromaticAberration()
		{
			Il2CppClassPointerStore<ChromaticAberration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "ChromaticAberration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChromaticAberration>.NativeClassPtr);
			ChromaticAberration.NativeFieldInfoPtr_spectralLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberration>.NativeClassPtr, "spectralLut");
			ChromaticAberration.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberration>.NativeClassPtr, "intensity");
			ChromaticAberration.NativeFieldInfoPtr_fastMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberration>.NativeClassPtr, "fastMode");
			ChromaticAberration.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberration>.NativeClassPtr, 100663334);
			ChromaticAberration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberration>.NativeClassPtr, 100663335);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00007B70 File Offset: 0x00005D70
		[CallerCount(0)]
		public unsafe override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberration.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00007BC0 File Offset: 0x00005DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442077, XrefRangeEnd = 442094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChromaticAberration()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChromaticAberration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000026E9 File Offset: 0x000008E9
		public ChromaticAberration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00007BFC File Offset: 0x00005DFC
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000026F2 File Offset: 0x000008F2
		public unsafe TextureParameter spectralLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberration.NativeFieldInfoPtr_spectralLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberration.NativeFieldInfoPtr_spectralLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00007C2C File Offset: 0x00005E2C
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00002711 File Offset: 0x00000911
		public unsafe FloatParameter intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberration.NativeFieldInfoPtr_intensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberration.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00007C5C File Offset: 0x00005E5C
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002730 File Offset: 0x00000930
		public unsafe BoolParameter fastMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberration.NativeFieldInfoPtr_fastMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberration.NativeFieldInfoPtr_fastMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_spectralLut;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_fastMode;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
