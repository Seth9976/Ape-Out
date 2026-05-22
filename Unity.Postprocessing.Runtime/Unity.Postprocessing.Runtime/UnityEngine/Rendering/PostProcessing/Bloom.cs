using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000013 RID: 19
	[Serializable]
	public sealed class Bloom : PostProcessEffectSettings
	{
		// Token: 0x06000083 RID: 131 RVA: 0x000075BC File Offset: 0x000057BC
		// Note: this type is marked as 'beforefieldinit'.
		static Bloom()
		{
			Il2CppClassPointerStore<Bloom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "Bloom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bloom>.NativeClassPtr);
			Bloom.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "intensity");
			Bloom.NativeFieldInfoPtr_threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "threshold");
			Bloom.NativeFieldInfoPtr_softKnee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "softKnee");
			Bloom.NativeFieldInfoPtr_clamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "clamp");
			Bloom.NativeFieldInfoPtr_diffusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "diffusion");
			Bloom.NativeFieldInfoPtr_anamorphicRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "anamorphicRatio");
			Bloom.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "color");
			Bloom.NativeFieldInfoPtr_fastMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "fastMode");
			Bloom.NativeFieldInfoPtr_dirtTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "dirtTexture");
			Bloom.NativeFieldInfoPtr_dirtIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "dirtIntensity");
			Bloom.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bloom>.NativeClassPtr, 100663329);
			Bloom.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bloom>.NativeClassPtr, 100663330);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000076DC File Offset: 0x000058DC
		[CallerCount(0)]
		public unsafe override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bloom.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000772C File Offset: 0x0000592C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441884, XrefRangeEnd = 441930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bloom()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bloom>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bloom.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002574 File Offset: 0x00000774
		public Bloom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00007768 File Offset: 0x00005968
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0000257D File Offset: 0x0000077D
		public unsafe FloatParameter intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_intensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00007798 File Offset: 0x00005998
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000259C File Offset: 0x0000079C
		public unsafe FloatParameter threshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_threshold);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_threshold), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000077C8 File Offset: 0x000059C8
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000025BB File Offset: 0x000007BB
		public unsafe FloatParameter softKnee
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_softKnee);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_softKnee), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000077F8 File Offset: 0x000059F8
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000025DA File Offset: 0x000007DA
		public unsafe FloatParameter clamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_clamp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_clamp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00007828 File Offset: 0x00005A28
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000025F9 File Offset: 0x000007F9
		public unsafe FloatParameter diffusion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_diffusion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_diffusion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00007858 File Offset: 0x00005A58
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002618 File Offset: 0x00000818
		public unsafe FloatParameter anamorphicRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_anamorphicRatio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_anamorphicRatio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00007888 File Offset: 0x00005A88
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002637 File Offset: 0x00000837
		public unsafe ColorParameter color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000078B8 File Offset: 0x00005AB8
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002656 File Offset: 0x00000856
		public unsafe BoolParameter fastMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_fastMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_fastMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000078E8 File Offset: 0x00005AE8
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002675 File Offset: 0x00000875
		public unsafe TextureParameter dirtTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_dirtTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_dirtTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00007918 File Offset: 0x00005B18
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002694 File Offset: 0x00000894
		public unsafe FloatParameter dirtIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_dirtIntensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_dirtIntensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_threshold;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_softKnee;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_clamp;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_diffusion;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_anamorphicRatio;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_fastMode;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_dirtTexture;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_dirtIntensity;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
