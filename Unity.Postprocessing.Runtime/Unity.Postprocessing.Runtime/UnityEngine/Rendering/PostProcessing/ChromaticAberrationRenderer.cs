using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000016 RID: 22
	public sealed class ChromaticAberrationRenderer : PostProcessEffectRenderer<ChromaticAberration>
	{
		// Token: 0x060000AE RID: 174 RVA: 0x00007C8C File Offset: 0x00005E8C
		// Note: this type is marked as 'beforefieldinit'.
		static ChromaticAberrationRenderer()
		{
			Il2CppClassPointerStore<ChromaticAberrationRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "ChromaticAberrationRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChromaticAberrationRenderer>.NativeClassPtr);
			ChromaticAberrationRenderer.NativeFieldInfoPtr_m_InternalSpectralLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberrationRenderer>.NativeClassPtr, "m_InternalSpectralLut");
			ChromaticAberrationRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationRenderer>.NativeClassPtr, 100663336);
			ChromaticAberrationRenderer.NativeMethodInfoPtr_Release_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationRenderer>.NativeClassPtr, 100663337);
			ChromaticAberrationRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationRenderer>.NativeClassPtr, 100663338);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00007D0C File Offset: 0x00005F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442094, XrefRangeEnd = 442168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00007D50 File Offset: 0x00005F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442168, XrefRangeEnd = 442172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationRenderer.NativeMethodInfoPtr_Release_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00007D84 File Offset: 0x00005F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442172, XrefRangeEnd = 442173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChromaticAberrationRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChromaticAberrationRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000274F File Offset: 0x0000094F
		public ChromaticAberrationRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00007DC0 File Offset: 0x00005FC0
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002758 File Offset: 0x00000958
		public unsafe Texture2D m_InternalSpectralLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationRenderer.NativeFieldInfoPtr_m_InternalSpectralLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationRenderer.NativeFieldInfoPtr_m_InternalSpectralLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalSpectralLut;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
