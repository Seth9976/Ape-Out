using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000058 RID: 88
	public sealed class PostProcessResources : ScriptableObject
	{
		// Token: 0x0600048E RID: 1166 RVA: 0x00014AE8 File Offset: 0x00012CE8
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessResources()
		{
			Il2CppClassPointerStore<PostProcessResources>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "PostProcessResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessResources>.NativeClassPtr);
			PostProcessResources.NativeFieldInfoPtr_blueNoise64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources>.NativeClassPtr, "blueNoise64");
			PostProcessResources.NativeFieldInfoPtr_blueNoise256 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources>.NativeClassPtr, "blueNoise256");
			PostProcessResources.NativeFieldInfoPtr_smaaLuts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources>.NativeClassPtr, "smaaLuts");
			PostProcessResources.NativeFieldInfoPtr_shaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources>.NativeClassPtr, "shaders");
			PostProcessResources.NativeFieldInfoPtr_computeShaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources>.NativeClassPtr, "computeShaders");
			PostProcessResources.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessResources>.NativeClassPtr, 100663728);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00014B90 File Offset: 0x00012D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessResources()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessResources>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessResources.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00004778 File Offset: 0x00002978
		public PostProcessResources(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00014BCC File Offset: 0x00012DCC
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00004781 File Offset: 0x00002981
		public unsafe Il2CppReferenceArray<Texture2D> blueNoise64
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.NativeFieldInfoPtr_blueNoise64);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.NativeFieldInfoPtr_blueNoise64), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00014BFC File Offset: 0x00012DFC
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x000047A0 File Offset: 0x000029A0
		public unsafe Il2CppReferenceArray<Texture2D> blueNoise256
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.NativeFieldInfoPtr_blueNoise256);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.NativeFieldInfoPtr_blueNoise256), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00014C2C File Offset: 0x00012E2C
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x000047BF File Offset: 0x000029BF
		public unsafe PostProcessResources.SMAALuts smaaLuts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.NativeFieldInfoPtr_smaaLuts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessResources.SMAALuts>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.NativeFieldInfoPtr_smaaLuts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00014C5C File Offset: 0x00012E5C
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x000047DE File Offset: 0x000029DE
		public unsafe PostProcessResources.Shaders shaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.NativeFieldInfoPtr_shaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessResources.Shaders>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.NativeFieldInfoPtr_shaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00014C8C File Offset: 0x00012E8C
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x000047FD File Offset: 0x000029FD
		public unsafe PostProcessResources.ComputeShaders computeShaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.NativeFieldInfoPtr_computeShaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessResources.ComputeShaders>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.NativeFieldInfoPtr_computeShaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeFieldInfoPtr_blueNoise64;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeFieldInfoPtr_blueNoise256;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeFieldInfoPtr_smaaLuts;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeFieldInfoPtr_shaders;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeFieldInfoPtr_computeShaders;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200008E RID: 142
		[Serializable]
		public sealed class Shaders : Object
		{
			// Token: 0x06000732 RID: 1842 RVA: 0x0001BA6C File Offset: 0x00019C6C
			// Note: this type is marked as 'beforefieldinit'.
			static Shaders()
			{
				Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessResources>.NativeClassPtr, "Shaders");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr);
				PostProcessResources.Shaders.NativeFieldInfoPtr_bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "bloom");
				PostProcessResources.Shaders.NativeFieldInfoPtr_copy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "copy");
				PostProcessResources.Shaders.NativeFieldInfoPtr_copyStd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "copyStd");
				PostProcessResources.Shaders.NativeFieldInfoPtr_copyStdFromTexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "copyStdFromTexArray");
				PostProcessResources.Shaders.NativeFieldInfoPtr_copyStdFromDoubleWide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "copyStdFromDoubleWide");
				PostProcessResources.Shaders.NativeFieldInfoPtr_discardAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "discardAlpha");
				PostProcessResources.Shaders.NativeFieldInfoPtr_depthOfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "depthOfField");
				PostProcessResources.Shaders.NativeFieldInfoPtr_finalPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "finalPass");
				PostProcessResources.Shaders.NativeFieldInfoPtr_grainBaker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "grainBaker");
				PostProcessResources.Shaders.NativeFieldInfoPtr_motionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "motionBlur");
				PostProcessResources.Shaders.NativeFieldInfoPtr_temporalAntialiasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "temporalAntialiasing");
				PostProcessResources.Shaders.NativeFieldInfoPtr_subpixelMorphologicalAntialiasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "subpixelMorphologicalAntialiasing");
				PostProcessResources.Shaders.NativeFieldInfoPtr_texture2dLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "texture2dLerp");
				PostProcessResources.Shaders.NativeFieldInfoPtr_uber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "uber");
				PostProcessResources.Shaders.NativeFieldInfoPtr_lut2DBaker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "lut2DBaker");
				PostProcessResources.Shaders.NativeFieldInfoPtr_lightMeter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "lightMeter");
				PostProcessResources.Shaders.NativeFieldInfoPtr_gammaHistogram = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "gammaHistogram");
				PostProcessResources.Shaders.NativeFieldInfoPtr_waveform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "waveform");
				PostProcessResources.Shaders.NativeFieldInfoPtr_vectorscope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "vectorscope");
				PostProcessResources.Shaders.NativeFieldInfoPtr_debugOverlays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "debugOverlays");
				PostProcessResources.Shaders.NativeFieldInfoPtr_deferredFog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "deferredFog");
				PostProcessResources.Shaders.NativeFieldInfoPtr_scalableAO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "scalableAO");
				PostProcessResources.Shaders.NativeFieldInfoPtr_multiScaleAO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "multiScaleAO");
				PostProcessResources.Shaders.NativeFieldInfoPtr_screenSpaceReflections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, "screenSpaceReflections");
				PostProcessResources.Shaders.NativeMethodInfoPtr_Clone_Public_Shaders_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, 100663729);
				PostProcessResources.Shaders.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr, 100663730);
			}

			// Token: 0x06000733 RID: 1843 RVA: 0x0001BCA0 File Offset: 0x00019EA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448188, XrefRangeEnd = 448191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PostProcessResources.Shaders Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessResources.Shaders.NativeMethodInfoPtr_Clone_Public_Shaders_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessResources.Shaders>(intPtr3) : null;
			}

			// Token: 0x06000734 RID: 1844 RVA: 0x0001BCE0 File Offset: 0x00019EE0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Shaders()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessResources.Shaders>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessResources.Shaders.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000735 RID: 1845 RVA: 0x000058F0 File Offset: 0x00003AF0
			public Shaders(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000259 RID: 601
			// (get) Token: 0x06000736 RID: 1846 RVA: 0x0001BD1C File Offset: 0x00019F1C
			// (set) Token: 0x06000737 RID: 1847 RVA: 0x000058F9 File Offset: 0x00003AF9
			public unsafe Shader bloom
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_bloom);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_bloom), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700025A RID: 602
			// (get) Token: 0x06000738 RID: 1848 RVA: 0x0001BD4C File Offset: 0x00019F4C
			// (set) Token: 0x06000739 RID: 1849 RVA: 0x00005918 File Offset: 0x00003B18
			public unsafe Shader copy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_copy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_copy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700025B RID: 603
			// (get) Token: 0x0600073A RID: 1850 RVA: 0x0001BD7C File Offset: 0x00019F7C
			// (set) Token: 0x0600073B RID: 1851 RVA: 0x00005937 File Offset: 0x00003B37
			public unsafe Shader copyStd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_copyStd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_copyStd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700025C RID: 604
			// (get) Token: 0x0600073C RID: 1852 RVA: 0x0001BDAC File Offset: 0x00019FAC
			// (set) Token: 0x0600073D RID: 1853 RVA: 0x00005956 File Offset: 0x00003B56
			public unsafe Shader copyStdFromTexArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_copyStdFromTexArray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_copyStdFromTexArray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700025D RID: 605
			// (get) Token: 0x0600073E RID: 1854 RVA: 0x0001BDDC File Offset: 0x00019FDC
			// (set) Token: 0x0600073F RID: 1855 RVA: 0x00005975 File Offset: 0x00003B75
			public unsafe Shader copyStdFromDoubleWide
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_copyStdFromDoubleWide);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_copyStdFromDoubleWide), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700025E RID: 606
			// (get) Token: 0x06000740 RID: 1856 RVA: 0x0001BE0C File Offset: 0x0001A00C
			// (set) Token: 0x06000741 RID: 1857 RVA: 0x00005994 File Offset: 0x00003B94
			public unsafe Shader discardAlpha
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_discardAlpha);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_discardAlpha), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700025F RID: 607
			// (get) Token: 0x06000742 RID: 1858 RVA: 0x0001BE3C File Offset: 0x0001A03C
			// (set) Token: 0x06000743 RID: 1859 RVA: 0x000059B3 File Offset: 0x00003BB3
			public unsafe Shader depthOfField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_depthOfField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_depthOfField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000260 RID: 608
			// (get) Token: 0x06000744 RID: 1860 RVA: 0x0001BE6C File Offset: 0x0001A06C
			// (set) Token: 0x06000745 RID: 1861 RVA: 0x000059D2 File Offset: 0x00003BD2
			public unsafe Shader finalPass
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_finalPass);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_finalPass), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000261 RID: 609
			// (get) Token: 0x06000746 RID: 1862 RVA: 0x0001BE9C File Offset: 0x0001A09C
			// (set) Token: 0x06000747 RID: 1863 RVA: 0x000059F1 File Offset: 0x00003BF1
			public unsafe Shader grainBaker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_grainBaker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_grainBaker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000262 RID: 610
			// (get) Token: 0x06000748 RID: 1864 RVA: 0x0001BECC File Offset: 0x0001A0CC
			// (set) Token: 0x06000749 RID: 1865 RVA: 0x00005A10 File Offset: 0x00003C10
			public unsafe Shader motionBlur
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_motionBlur);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_motionBlur), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000263 RID: 611
			// (get) Token: 0x0600074A RID: 1866 RVA: 0x0001BEFC File Offset: 0x0001A0FC
			// (set) Token: 0x0600074B RID: 1867 RVA: 0x00005A2F File Offset: 0x00003C2F
			public unsafe Shader temporalAntialiasing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_temporalAntialiasing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_temporalAntialiasing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000264 RID: 612
			// (get) Token: 0x0600074C RID: 1868 RVA: 0x0001BF2C File Offset: 0x0001A12C
			// (set) Token: 0x0600074D RID: 1869 RVA: 0x00005A4E File Offset: 0x00003C4E
			public unsafe Shader subpixelMorphologicalAntialiasing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_subpixelMorphologicalAntialiasing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_subpixelMorphologicalAntialiasing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000265 RID: 613
			// (get) Token: 0x0600074E RID: 1870 RVA: 0x0001BF5C File Offset: 0x0001A15C
			// (set) Token: 0x0600074F RID: 1871 RVA: 0x00005A6D File Offset: 0x00003C6D
			public unsafe Shader texture2dLerp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_texture2dLerp);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_texture2dLerp), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000266 RID: 614
			// (get) Token: 0x06000750 RID: 1872 RVA: 0x0001BF8C File Offset: 0x0001A18C
			// (set) Token: 0x06000751 RID: 1873 RVA: 0x00005A8C File Offset: 0x00003C8C
			public unsafe Shader uber
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_uber);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_uber), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000267 RID: 615
			// (get) Token: 0x06000752 RID: 1874 RVA: 0x0001BFBC File Offset: 0x0001A1BC
			// (set) Token: 0x06000753 RID: 1875 RVA: 0x00005AAB File Offset: 0x00003CAB
			public unsafe Shader lut2DBaker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_lut2DBaker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_lut2DBaker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000268 RID: 616
			// (get) Token: 0x06000754 RID: 1876 RVA: 0x0001BFEC File Offset: 0x0001A1EC
			// (set) Token: 0x06000755 RID: 1877 RVA: 0x00005ACA File Offset: 0x00003CCA
			public unsafe Shader lightMeter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_lightMeter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_lightMeter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000269 RID: 617
			// (get) Token: 0x06000756 RID: 1878 RVA: 0x0001C01C File Offset: 0x0001A21C
			// (set) Token: 0x06000757 RID: 1879 RVA: 0x00005AE9 File Offset: 0x00003CE9
			public unsafe Shader gammaHistogram
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_gammaHistogram);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_gammaHistogram), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700026A RID: 618
			// (get) Token: 0x06000758 RID: 1880 RVA: 0x0001C04C File Offset: 0x0001A24C
			// (set) Token: 0x06000759 RID: 1881 RVA: 0x00005B08 File Offset: 0x00003D08
			public unsafe Shader waveform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_waveform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_waveform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700026B RID: 619
			// (get) Token: 0x0600075A RID: 1882 RVA: 0x0001C07C File Offset: 0x0001A27C
			// (set) Token: 0x0600075B RID: 1883 RVA: 0x00005B27 File Offset: 0x00003D27
			public unsafe Shader vectorscope
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_vectorscope);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_vectorscope), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700026C RID: 620
			// (get) Token: 0x0600075C RID: 1884 RVA: 0x0001C0AC File Offset: 0x0001A2AC
			// (set) Token: 0x0600075D RID: 1885 RVA: 0x00005B46 File Offset: 0x00003D46
			public unsafe Shader debugOverlays
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_debugOverlays);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_debugOverlays), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700026D RID: 621
			// (get) Token: 0x0600075E RID: 1886 RVA: 0x0001C0DC File Offset: 0x0001A2DC
			// (set) Token: 0x0600075F RID: 1887 RVA: 0x00005B65 File Offset: 0x00003D65
			public unsafe Shader deferredFog
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_deferredFog);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_deferredFog), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700026E RID: 622
			// (get) Token: 0x06000760 RID: 1888 RVA: 0x0001C10C File Offset: 0x0001A30C
			// (set) Token: 0x06000761 RID: 1889 RVA: 0x00005B84 File Offset: 0x00003D84
			public unsafe Shader scalableAO
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_scalableAO);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_scalableAO), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700026F RID: 623
			// (get) Token: 0x06000762 RID: 1890 RVA: 0x0001C13C File Offset: 0x0001A33C
			// (set) Token: 0x06000763 RID: 1891 RVA: 0x00005BA3 File Offset: 0x00003DA3
			public unsafe Shader multiScaleAO
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_multiScaleAO);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_multiScaleAO), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000270 RID: 624
			// (get) Token: 0x06000764 RID: 1892 RVA: 0x0001C16C File Offset: 0x0001A36C
			// (set) Token: 0x06000765 RID: 1893 RVA: 0x00005BC2 File Offset: 0x00003DC2
			public unsafe Shader screenSpaceReflections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_screenSpaceReflections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.Shaders.NativeFieldInfoPtr_screenSpaceReflections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004FA RID: 1274
			private static readonly IntPtr NativeFieldInfoPtr_bloom;

			// Token: 0x040004FB RID: 1275
			private static readonly IntPtr NativeFieldInfoPtr_copy;

			// Token: 0x040004FC RID: 1276
			private static readonly IntPtr NativeFieldInfoPtr_copyStd;

			// Token: 0x040004FD RID: 1277
			private static readonly IntPtr NativeFieldInfoPtr_copyStdFromTexArray;

			// Token: 0x040004FE RID: 1278
			private static readonly IntPtr NativeFieldInfoPtr_copyStdFromDoubleWide;

			// Token: 0x040004FF RID: 1279
			private static readonly IntPtr NativeFieldInfoPtr_discardAlpha;

			// Token: 0x04000500 RID: 1280
			private static readonly IntPtr NativeFieldInfoPtr_depthOfField;

			// Token: 0x04000501 RID: 1281
			private static readonly IntPtr NativeFieldInfoPtr_finalPass;

			// Token: 0x04000502 RID: 1282
			private static readonly IntPtr NativeFieldInfoPtr_grainBaker;

			// Token: 0x04000503 RID: 1283
			private static readonly IntPtr NativeFieldInfoPtr_motionBlur;

			// Token: 0x04000504 RID: 1284
			private static readonly IntPtr NativeFieldInfoPtr_temporalAntialiasing;

			// Token: 0x04000505 RID: 1285
			private static readonly IntPtr NativeFieldInfoPtr_subpixelMorphologicalAntialiasing;

			// Token: 0x04000506 RID: 1286
			private static readonly IntPtr NativeFieldInfoPtr_texture2dLerp;

			// Token: 0x04000507 RID: 1287
			private static readonly IntPtr NativeFieldInfoPtr_uber;

			// Token: 0x04000508 RID: 1288
			private static readonly IntPtr NativeFieldInfoPtr_lut2DBaker;

			// Token: 0x04000509 RID: 1289
			private static readonly IntPtr NativeFieldInfoPtr_lightMeter;

			// Token: 0x0400050A RID: 1290
			private static readonly IntPtr NativeFieldInfoPtr_gammaHistogram;

			// Token: 0x0400050B RID: 1291
			private static readonly IntPtr NativeFieldInfoPtr_waveform;

			// Token: 0x0400050C RID: 1292
			private static readonly IntPtr NativeFieldInfoPtr_vectorscope;

			// Token: 0x0400050D RID: 1293
			private static readonly IntPtr NativeFieldInfoPtr_debugOverlays;

			// Token: 0x0400050E RID: 1294
			private static readonly IntPtr NativeFieldInfoPtr_deferredFog;

			// Token: 0x0400050F RID: 1295
			private static readonly IntPtr NativeFieldInfoPtr_scalableAO;

			// Token: 0x04000510 RID: 1296
			private static readonly IntPtr NativeFieldInfoPtr_multiScaleAO;

			// Token: 0x04000511 RID: 1297
			private static readonly IntPtr NativeFieldInfoPtr_screenSpaceReflections;

			// Token: 0x04000512 RID: 1298
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Shaders_0;

			// Token: 0x04000513 RID: 1299
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200008F RID: 143
		[Serializable]
		public sealed class ComputeShaders : Object
		{
			// Token: 0x06000766 RID: 1894 RVA: 0x0001C19C File Offset: 0x0001A39C
			// Note: this type is marked as 'beforefieldinit'.
			static ComputeShaders()
			{
				Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessResources>.NativeClassPtr, "ComputeShaders");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr);
				PostProcessResources.ComputeShaders.NativeFieldInfoPtr_autoExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr, "autoExposure");
				PostProcessResources.ComputeShaders.NativeFieldInfoPtr_exposureHistogram = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr, "exposureHistogram");
				PostProcessResources.ComputeShaders.NativeFieldInfoPtr_lut3DBaker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr, "lut3DBaker");
				PostProcessResources.ComputeShaders.NativeFieldInfoPtr_texture3dLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr, "texture3dLerp");
				PostProcessResources.ComputeShaders.NativeFieldInfoPtr_gammaHistogram = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr, "gammaHistogram");
				PostProcessResources.ComputeShaders.NativeFieldInfoPtr_waveform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr, "waveform");
				PostProcessResources.ComputeShaders.NativeFieldInfoPtr_vectorscope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr, "vectorscope");
				PostProcessResources.ComputeShaders.NativeFieldInfoPtr_multiScaleAODownsample1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr, "multiScaleAODownsample1");
				PostProcessResources.ComputeShaders.NativeFieldInfoPtr_multiScaleAODownsample2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr, "multiScaleAODownsample2");
				PostProcessResources.ComputeShaders.NativeFieldInfoPtr_multiScaleAORender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr, "multiScaleAORender");
				PostProcessResources.ComputeShaders.NativeFieldInfoPtr_multiScaleAOUpsample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr, "multiScaleAOUpsample");
				PostProcessResources.ComputeShaders.NativeFieldInfoPtr_gaussianDownsample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr, "gaussianDownsample");
				PostProcessResources.ComputeShaders.NativeMethodInfoPtr_Clone_Public_ComputeShaders_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr, 100663731);
				PostProcessResources.ComputeShaders.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr, 100663732);
			}

			// Token: 0x06000767 RID: 1895 RVA: 0x0001C2E0 File Offset: 0x0001A4E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448191, XrefRangeEnd = 448194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PostProcessResources.ComputeShaders Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessResources.ComputeShaders.NativeMethodInfoPtr_Clone_Public_ComputeShaders_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessResources.ComputeShaders>(intPtr3) : null;
			}

			// Token: 0x06000768 RID: 1896 RVA: 0x0001C320 File Offset: 0x0001A520
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ComputeShaders()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessResources.ComputeShaders>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessResources.ComputeShaders.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000769 RID: 1897 RVA: 0x00005BE1 File Offset: 0x00003DE1
			public ComputeShaders(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000271 RID: 625
			// (get) Token: 0x0600076A RID: 1898 RVA: 0x0001C35C File Offset: 0x0001A55C
			// (set) Token: 0x0600076B RID: 1899 RVA: 0x00005BEA File Offset: 0x00003DEA
			public unsafe ComputeShader autoExposure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_autoExposure);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_autoExposure), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000272 RID: 626
			// (get) Token: 0x0600076C RID: 1900 RVA: 0x0001C38C File Offset: 0x0001A58C
			// (set) Token: 0x0600076D RID: 1901 RVA: 0x00005C09 File Offset: 0x00003E09
			public unsafe ComputeShader exposureHistogram
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_exposureHistogram);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_exposureHistogram), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000273 RID: 627
			// (get) Token: 0x0600076E RID: 1902 RVA: 0x0001C3BC File Offset: 0x0001A5BC
			// (set) Token: 0x0600076F RID: 1903 RVA: 0x00005C28 File Offset: 0x00003E28
			public unsafe ComputeShader lut3DBaker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_lut3DBaker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_lut3DBaker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000274 RID: 628
			// (get) Token: 0x06000770 RID: 1904 RVA: 0x0001C3EC File Offset: 0x0001A5EC
			// (set) Token: 0x06000771 RID: 1905 RVA: 0x00005C47 File Offset: 0x00003E47
			public unsafe ComputeShader texture3dLerp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_texture3dLerp);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_texture3dLerp), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000275 RID: 629
			// (get) Token: 0x06000772 RID: 1906 RVA: 0x0001C41C File Offset: 0x0001A61C
			// (set) Token: 0x06000773 RID: 1907 RVA: 0x00005C66 File Offset: 0x00003E66
			public unsafe ComputeShader gammaHistogram
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_gammaHistogram);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_gammaHistogram), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000276 RID: 630
			// (get) Token: 0x06000774 RID: 1908 RVA: 0x0001C44C File Offset: 0x0001A64C
			// (set) Token: 0x06000775 RID: 1909 RVA: 0x00005C85 File Offset: 0x00003E85
			public unsafe ComputeShader waveform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_waveform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_waveform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000277 RID: 631
			// (get) Token: 0x06000776 RID: 1910 RVA: 0x0001C47C File Offset: 0x0001A67C
			// (set) Token: 0x06000777 RID: 1911 RVA: 0x00005CA4 File Offset: 0x00003EA4
			public unsafe ComputeShader vectorscope
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_vectorscope);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_vectorscope), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000278 RID: 632
			// (get) Token: 0x06000778 RID: 1912 RVA: 0x0001C4AC File Offset: 0x0001A6AC
			// (set) Token: 0x06000779 RID: 1913 RVA: 0x00005CC3 File Offset: 0x00003EC3
			public unsafe ComputeShader multiScaleAODownsample1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_multiScaleAODownsample1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_multiScaleAODownsample1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000279 RID: 633
			// (get) Token: 0x0600077A RID: 1914 RVA: 0x0001C4DC File Offset: 0x0001A6DC
			// (set) Token: 0x0600077B RID: 1915 RVA: 0x00005CE2 File Offset: 0x00003EE2
			public unsafe ComputeShader multiScaleAODownsample2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_multiScaleAODownsample2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_multiScaleAODownsample2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700027A RID: 634
			// (get) Token: 0x0600077C RID: 1916 RVA: 0x0001C50C File Offset: 0x0001A70C
			// (set) Token: 0x0600077D RID: 1917 RVA: 0x00005D01 File Offset: 0x00003F01
			public unsafe ComputeShader multiScaleAORender
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_multiScaleAORender);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_multiScaleAORender), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700027B RID: 635
			// (get) Token: 0x0600077E RID: 1918 RVA: 0x0001C53C File Offset: 0x0001A73C
			// (set) Token: 0x0600077F RID: 1919 RVA: 0x00005D20 File Offset: 0x00003F20
			public unsafe ComputeShader multiScaleAOUpsample
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_multiScaleAOUpsample);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_multiScaleAOUpsample), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700027C RID: 636
			// (get) Token: 0x06000780 RID: 1920 RVA: 0x0001C56C File Offset: 0x0001A76C
			// (set) Token: 0x06000781 RID: 1921 RVA: 0x00005D3F File Offset: 0x00003F3F
			public unsafe ComputeShader gaussianDownsample
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_gaussianDownsample);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.ComputeShaders.NativeFieldInfoPtr_gaussianDownsample), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000514 RID: 1300
			private static readonly IntPtr NativeFieldInfoPtr_autoExposure;

			// Token: 0x04000515 RID: 1301
			private static readonly IntPtr NativeFieldInfoPtr_exposureHistogram;

			// Token: 0x04000516 RID: 1302
			private static readonly IntPtr NativeFieldInfoPtr_lut3DBaker;

			// Token: 0x04000517 RID: 1303
			private static readonly IntPtr NativeFieldInfoPtr_texture3dLerp;

			// Token: 0x04000518 RID: 1304
			private static readonly IntPtr NativeFieldInfoPtr_gammaHistogram;

			// Token: 0x04000519 RID: 1305
			private static readonly IntPtr NativeFieldInfoPtr_waveform;

			// Token: 0x0400051A RID: 1306
			private static readonly IntPtr NativeFieldInfoPtr_vectorscope;

			// Token: 0x0400051B RID: 1307
			private static readonly IntPtr NativeFieldInfoPtr_multiScaleAODownsample1;

			// Token: 0x0400051C RID: 1308
			private static readonly IntPtr NativeFieldInfoPtr_multiScaleAODownsample2;

			// Token: 0x0400051D RID: 1309
			private static readonly IntPtr NativeFieldInfoPtr_multiScaleAORender;

			// Token: 0x0400051E RID: 1310
			private static readonly IntPtr NativeFieldInfoPtr_multiScaleAOUpsample;

			// Token: 0x0400051F RID: 1311
			private static readonly IntPtr NativeFieldInfoPtr_gaussianDownsample;

			// Token: 0x04000520 RID: 1312
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_ComputeShaders_0;

			// Token: 0x04000521 RID: 1313
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000090 RID: 144
		[Serializable]
		public sealed class SMAALuts : Object
		{
			// Token: 0x06000782 RID: 1922 RVA: 0x0001C59C File Offset: 0x0001A79C
			// Note: this type is marked as 'beforefieldinit'.
			static SMAALuts()
			{
				Il2CppClassPointerStore<PostProcessResources.SMAALuts>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessResources>.NativeClassPtr, "SMAALuts");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessResources.SMAALuts>.NativeClassPtr);
				PostProcessResources.SMAALuts.NativeFieldInfoPtr_area = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.SMAALuts>.NativeClassPtr, "area");
				PostProcessResources.SMAALuts.NativeFieldInfoPtr_search = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessResources.SMAALuts>.NativeClassPtr, "search");
				PostProcessResources.SMAALuts.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessResources.SMAALuts>.NativeClassPtr, 100663733);
			}

			// Token: 0x06000783 RID: 1923 RVA: 0x0001C604 File Offset: 0x0001A804
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SMAALuts()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessResources.SMAALuts>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessResources.SMAALuts.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000784 RID: 1924 RVA: 0x00005D5E File Offset: 0x00003F5E
			public SMAALuts(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700027D RID: 637
			// (get) Token: 0x06000785 RID: 1925 RVA: 0x0001C640 File Offset: 0x0001A840
			// (set) Token: 0x06000786 RID: 1926 RVA: 0x00005D67 File Offset: 0x00003F67
			public unsafe Texture2D area
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.SMAALuts.NativeFieldInfoPtr_area);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.SMAALuts.NativeFieldInfoPtr_area), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700027E RID: 638
			// (get) Token: 0x06000787 RID: 1927 RVA: 0x0001C670 File Offset: 0x0001A870
			// (set) Token: 0x06000788 RID: 1928 RVA: 0x00005D86 File Offset: 0x00003F86
			public unsafe Texture2D search
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.SMAALuts.NativeFieldInfoPtr_search);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessResources.SMAALuts.NativeFieldInfoPtr_search), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000522 RID: 1314
			private static readonly IntPtr NativeFieldInfoPtr_area;

			// Token: 0x04000523 RID: 1315
			private static readonly IntPtr NativeFieldInfoPtr_search;

			// Token: 0x04000524 RID: 1316
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
