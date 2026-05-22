using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000031 RID: 49
	public sealed class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer<ScreenSpaceReflections>
	{
		// Token: 0x060001F8 RID: 504 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenSpaceReflectionsRenderer()
		{
			Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "ScreenSpaceReflectionsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer>.NativeClassPtr);
			ScreenSpaceReflectionsRenderer.NativeFieldInfoPtr_m_Resolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer>.NativeClassPtr, "m_Resolve");
			ScreenSpaceReflectionsRenderer.NativeFieldInfoPtr_m_History = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer>.NativeClassPtr, "m_History");
			ScreenSpaceReflectionsRenderer.NativeFieldInfoPtr_m_MipIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer>.NativeClassPtr, "m_MipIDs");
			ScreenSpaceReflectionsRenderer.NativeFieldInfoPtr_m_Presets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer>.NativeClassPtr, "m_Presets");
			ScreenSpaceReflectionsRenderer.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer>.NativeClassPtr, 100663424);
			ScreenSpaceReflectionsRenderer.NativeMethodInfoPtr_CheckRT_Internal_Void_byref_RenderTexture_Int32_Int32_FilterMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer>.NativeClassPtr, 100663425);
			ScreenSpaceReflectionsRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer>.NativeClassPtr, 100663426);
			ScreenSpaceReflectionsRenderer.NativeMethodInfoPtr_Release_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer>.NativeClassPtr, 100663427);
			ScreenSpaceReflectionsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer>.NativeClassPtr, 100663428);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000B9C4 File Offset: 0x00009BC4
		[CallerCount(0)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionsRenderer.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000BA00 File Offset: 0x00009C00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 444692, RefRangeEnd = 444694, XrefRangeStart = 444642, XrefRangeEnd = 444692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, bool useMipMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(rt);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMipMap;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionsRenderer.NativeMethodInfoPtr_CheckRT_Internal_Void_byref_RenderTexture_Int32_Int32_FilterMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			rt = ((intPtr4 == 0) ? null : new RenderTexture(intPtr4));
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000BA90 File Offset: 0x00009C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444694, XrefRangeEnd = 444853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionsRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444853, XrefRangeEnd = 444858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionsRenderer.NativeMethodInfoPtr_Release_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000BB08 File Offset: 0x00009D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444858, XrefRangeEnd = 444891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenSpaceReflectionsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000034B1 File Offset: 0x000016B1
		public ScreenSpaceReflectionsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000BB44 File Offset: 0x00009D44
		// (set) Token: 0x06000200 RID: 512 RVA: 0x000034BA File Offset: 0x000016BA
		public unsafe RenderTexture m_Resolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionsRenderer.NativeFieldInfoPtr_m_Resolve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionsRenderer.NativeFieldInfoPtr_m_Resolve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000BB74 File Offset: 0x00009D74
		// (set) Token: 0x06000202 RID: 514 RVA: 0x000034D9 File Offset: 0x000016D9
		public unsafe RenderTexture m_History
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionsRenderer.NativeFieldInfoPtr_m_History);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionsRenderer.NativeFieldInfoPtr_m_History), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000BBA4 File Offset: 0x00009DA4
		// (set) Token: 0x06000204 RID: 516 RVA: 0x000034F8 File Offset: 0x000016F8
		public unsafe Il2CppStructArray<int> m_MipIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionsRenderer.NativeFieldInfoPtr_m_MipIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionsRenderer.NativeFieldInfoPtr_m_MipIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000BBD4 File Offset: 0x00009DD4
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00003517 File Offset: 0x00001717
		public unsafe Il2CppReferenceArray<ScreenSpaceReflectionsRenderer.QualityPreset> m_Presets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionsRenderer.NativeFieldInfoPtr_m_Presets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScreenSpaceReflectionsRenderer.QualityPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionsRenderer.NativeFieldInfoPtr_m_Presets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_m_Resolve;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr_m_History;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr_m_MipIDs;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr_m_Presets;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_CheckRT_Internal_Void_byref_RenderTexture_Int32_Int32_FilterMode_Boolean_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000071 RID: 113
		public class QualityPreset : Object
		{
			// Token: 0x060006CC RID: 1740 RVA: 0x0001A7D8 File Offset: 0x000189D8
			// Note: this type is marked as 'beforefieldinit'.
			static QualityPreset()
			{
				Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer.QualityPreset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer>.NativeClassPtr, "QualityPreset");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer.QualityPreset>.NativeClassPtr);
				ScreenSpaceReflectionsRenderer.QualityPreset.NativeFieldInfoPtr_maximumIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer.QualityPreset>.NativeClassPtr, "maximumIterationCount");
				ScreenSpaceReflectionsRenderer.QualityPreset.NativeFieldInfoPtr_thickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer.QualityPreset>.NativeClassPtr, "thickness");
				ScreenSpaceReflectionsRenderer.QualityPreset.NativeFieldInfoPtr_downsampling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer.QualityPreset>.NativeClassPtr, "downsampling");
				ScreenSpaceReflectionsRenderer.QualityPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer.QualityPreset>.NativeClassPtr, 100663429);
			}

			// Token: 0x060006CD RID: 1741 RVA: 0x0001A854 File Offset: 0x00018A54
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe QualityPreset()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceReflectionsRenderer.QualityPreset>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionsRenderer.QualityPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006CE RID: 1742 RVA: 0x0000563E File Offset: 0x0000383E
			public QualityPreset(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000241 RID: 577
			// (get) Token: 0x060006CF RID: 1743 RVA: 0x0001A890 File Offset: 0x00018A90
			// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00005647 File Offset: 0x00003847
			public unsafe int maximumIterationCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionsRenderer.QualityPreset.NativeFieldInfoPtr_maximumIterationCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionsRenderer.QualityPreset.NativeFieldInfoPtr_maximumIterationCount)) = value;
				}
			}

			// Token: 0x17000242 RID: 578
			// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0001A8B8 File Offset: 0x00018AB8
			// (set) Token: 0x060006D2 RID: 1746 RVA: 0x00005662 File Offset: 0x00003862
			public unsafe float thickness
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionsRenderer.QualityPreset.NativeFieldInfoPtr_thickness);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionsRenderer.QualityPreset.NativeFieldInfoPtr_thickness)) = value;
				}
			}

			// Token: 0x17000243 RID: 579
			// (get) Token: 0x060006D3 RID: 1747 RVA: 0x0001A8E0 File Offset: 0x00018AE0
			// (set) Token: 0x060006D4 RID: 1748 RVA: 0x0000567D File Offset: 0x0000387D
			public unsafe ScreenSpaceReflectionResolution downsampling
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionsRenderer.QualityPreset.NativeFieldInfoPtr_downsampling);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionsRenderer.QualityPreset.NativeFieldInfoPtr_downsampling)) = value;
				}
			}

			// Token: 0x040004A3 RID: 1187
			private static readonly IntPtr NativeFieldInfoPtr_maximumIterationCount;

			// Token: 0x040004A4 RID: 1188
			private static readonly IntPtr NativeFieldInfoPtr_thickness;

			// Token: 0x040004A5 RID: 1189
			private static readonly IntPtr NativeFieldInfoPtr_downsampling;

			// Token: 0x040004A6 RID: 1190
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000072 RID: 114
		[OriginalName("Unity.Postprocessing.Runtime.dll", "", "Pass")]
		public enum Pass
		{
			// Token: 0x040004A8 RID: 1192
			Test,
			// Token: 0x040004A9 RID: 1193
			Resolve,
			// Token: 0x040004AA RID: 1194
			Reproject,
			// Token: 0x040004AB RID: 1195
			Composite
		}
	}
}
