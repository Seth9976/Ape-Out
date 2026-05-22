using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000021 RID: 33
	[Serializable]
	public sealed class Dithering : Object
	{
		// Token: 0x0600014C RID: 332 RVA: 0x000095BC File Offset: 0x000077BC
		// Note: this type is marked as 'beforefieldinit'.
		static Dithering()
		{
			Il2CppClassPointerStore<Dithering>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "Dithering");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dithering>.NativeClassPtr);
			Dithering.NativeFieldInfoPtr_m_NoiseTextureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dithering>.NativeClassPtr, "m_NoiseTextureIndex");
			Dithering.NativeFieldInfoPtr_m_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dithering>.NativeClassPtr, "m_Random");
			Dithering.NativeMethodInfoPtr_Render_Internal_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dithering>.NativeClassPtr, 100663366);
			Dithering.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dithering>.NativeClassPtr, 100663367);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000963C File Offset: 0x0000783C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 443307, RefRangeEnd = 443309, XrefRangeStart = 443298, XrefRangeEnd = 443307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dithering.NativeMethodInfoPtr_Render_Internal_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00009680 File Offset: 0x00007880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443309, XrefRangeEnd = 443313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dithering()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dithering>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dithering.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002EB5 File Offset: 0x000010B5
		public Dithering(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000096BC File Offset: 0x000078BC
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00002EBE File Offset: 0x000010BE
		public unsafe int m_NoiseTextureIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dithering.NativeFieldInfoPtr_m_NoiseTextureIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dithering.NativeFieldInfoPtr_m_NoiseTextureIndex)) = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000096E4 File Offset: 0x000078E4
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00002ED9 File Offset: 0x000010D9
		public unsafe Random m_Random
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dithering.NativeFieldInfoPtr_m_Random);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dithering.NativeFieldInfoPtr_m_Random), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_m_NoiseTextureIndex;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_m_Random;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Void_PostProcessRenderContext_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
