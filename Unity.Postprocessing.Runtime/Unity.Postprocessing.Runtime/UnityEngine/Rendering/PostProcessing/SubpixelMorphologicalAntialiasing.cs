using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000032 RID: 50
	[Serializable]
	public sealed class SubpixelMorphologicalAntialiasing : Object
	{
		// Token: 0x06000207 RID: 519 RVA: 0x0000BC04 File Offset: 0x00009E04
		// Note: this type is marked as 'beforefieldinit'.
		static SubpixelMorphologicalAntialiasing()
		{
			Il2CppClassPointerStore<SubpixelMorphologicalAntialiasing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "SubpixelMorphologicalAntialiasing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubpixelMorphologicalAntialiasing>.NativeClassPtr);
			SubpixelMorphologicalAntialiasing.NativeFieldInfoPtr_quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubpixelMorphologicalAntialiasing>.NativeClassPtr, "quality");
			SubpixelMorphologicalAntialiasing.NativeMethodInfoPtr_IsSupported_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubpixelMorphologicalAntialiasing>.NativeClassPtr, 100663430);
			SubpixelMorphologicalAntialiasing.NativeMethodInfoPtr_Render_Internal_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubpixelMorphologicalAntialiasing>.NativeClassPtr, 100663431);
			SubpixelMorphologicalAntialiasing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubpixelMorphologicalAntialiasing>.NativeClassPtr, 100663432);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000BC84 File Offset: 0x00009E84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 444895, RefRangeEnd = 444897, XrefRangeStart = 444891, XrefRangeEnd = 444895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubpixelMorphologicalAntialiasing.NativeMethodInfoPtr_IsSupported_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000BCC0 File Offset: 0x00009EC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 444975, RefRangeEnd = 444976, XrefRangeStart = 444897, XrefRangeEnd = 444975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubpixelMorphologicalAntialiasing.NativeMethodInfoPtr_Render_Internal_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000BD04 File Offset: 0x00009F04
		[CallerCount(0)]
		public unsafe SubpixelMorphologicalAntialiasing()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubpixelMorphologicalAntialiasing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubpixelMorphologicalAntialiasing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00003536 File Offset: 0x00001736
		public SubpixelMorphologicalAntialiasing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0000BD40 File Offset: 0x00009F40
		// (set) Token: 0x0600020D RID: 525 RVA: 0x0000353F File Offset: 0x0000173F
		public unsafe SubpixelMorphologicalAntialiasing.Quality quality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubpixelMorphologicalAntialiasing.NativeFieldInfoPtr_quality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubpixelMorphologicalAntialiasing.NativeFieldInfoPtr_quality)) = value;
			}
		}

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_quality;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_IsSupported_Public_Boolean_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Void_PostProcessRenderContext_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000073 RID: 115
		[OriginalName("Unity.Postprocessing.Runtime.dll", "", "Pass")]
		public enum Pass
		{
			// Token: 0x040004AD RID: 1197
			EdgeDetection,
			// Token: 0x040004AE RID: 1198
			BlendWeights = 3,
			// Token: 0x040004AF RID: 1199
			NeighborhoodBlending = 6
		}

		// Token: 0x02000074 RID: 116
		[OriginalName("Unity.Postprocessing.Runtime.dll", "", "Quality")]
		public enum Quality
		{
			// Token: 0x040004B1 RID: 1201
			Low,
			// Token: 0x040004B2 RID: 1202
			Medium,
			// Token: 0x040004B3 RID: 1203
			High
		}
	}
}
