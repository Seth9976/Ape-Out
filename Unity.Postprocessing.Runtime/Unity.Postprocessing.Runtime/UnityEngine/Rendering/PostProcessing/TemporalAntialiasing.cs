using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000033 RID: 51
	[Serializable]
	public sealed class TemporalAntialiasing : Object
	{
		// Token: 0x0600020E RID: 526 RVA: 0x0000BD68 File Offset: 0x00009F68
		// Note: this type is marked as 'beforefieldinit'.
		static TemporalAntialiasing()
		{
			Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "TemporalAntialiasing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr);
			TemporalAntialiasing.NativeFieldInfoPtr_jitterSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, "jitterSpread");
			TemporalAntialiasing.NativeFieldInfoPtr_sharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, "sharpness");
			TemporalAntialiasing.NativeFieldInfoPtr_stationaryBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, "stationaryBlending");
			TemporalAntialiasing.NativeFieldInfoPtr_motionBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, "motionBlending");
			TemporalAntialiasing.NativeFieldInfoPtr_jitteredMatrixFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, "jitteredMatrixFunc");
			TemporalAntialiasing.NativeFieldInfoPtr__jitter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, "<jitter>k__BackingField");
			TemporalAntialiasing.NativeFieldInfoPtr_m_Mrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, "m_Mrt");
			TemporalAntialiasing.NativeFieldInfoPtr_m_ResetHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, "m_ResetHistory");
			TemporalAntialiasing.NativeFieldInfoPtr_k_SampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, "k_SampleCount");
			TemporalAntialiasing.NativeFieldInfoPtr__sampleIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, "<sampleIndex>k__BackingField");
			TemporalAntialiasing.NativeFieldInfoPtr_k_NumEyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, "k_NumEyes");
			TemporalAntialiasing.NativeFieldInfoPtr_k_NumHistoryTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, "k_NumHistoryTextures");
			TemporalAntialiasing.NativeFieldInfoPtr_m_HistoryTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, "m_HistoryTextures");
			TemporalAntialiasing.NativeFieldInfoPtr_m_HistoryPingPong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, "m_HistoryPingPong");
			TemporalAntialiasing.NativeMethodInfoPtr_get_jitter_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, 100663433);
			TemporalAntialiasing.NativeMethodInfoPtr_set_jitter_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, 100663434);
			TemporalAntialiasing.NativeMethodInfoPtr_get_sampleIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, 100663435);
			TemporalAntialiasing.NativeMethodInfoPtr_set_sampleIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, 100663436);
			TemporalAntialiasing.NativeMethodInfoPtr_IsSupported_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, 100663437);
			TemporalAntialiasing.NativeMethodInfoPtr_GetCameraFlags_Internal_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, 100663438);
			TemporalAntialiasing.NativeMethodInfoPtr_ResetHistory_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, 100663439);
			TemporalAntialiasing.NativeMethodInfoPtr_GenerateRandomOffset_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, 100663440);
			TemporalAntialiasing.NativeMethodInfoPtr_GetJitteredProjectionMatrix_Public_Matrix4x4_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, 100663441);
			TemporalAntialiasing.NativeMethodInfoPtr_ConfigureJitteredProjectionMatrix_Public_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, 100663442);
			TemporalAntialiasing.NativeMethodInfoPtr_ConfigureStereoJitteredProjectionMatrices_Public_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, 100663443);
			TemporalAntialiasing.NativeMethodInfoPtr_GenerateHistoryName_Private_Void_RenderTexture_Int32_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, 100663444);
			TemporalAntialiasing.NativeMethodInfoPtr_CheckHistory_Private_RenderTexture_Int32_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, 100663445);
			TemporalAntialiasing.NativeMethodInfoPtr_Render_Internal_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, 100663446);
			TemporalAntialiasing.NativeMethodInfoPtr_Release_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, 100663447);
			TemporalAntialiasing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr, 100663448);
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000BFF0 File Offset: 0x0000A1F0
		// (set) Token: 0x06000210 RID: 528 RVA: 0x0000C02C File Offset: 0x0000A22C
		public unsafe Vector2 jitter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAntialiasing.NativeMethodInfoPtr_get_jitter_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAntialiasing.NativeMethodInfoPtr_set_jitter_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000C06C File Offset: 0x0000A26C
		// (set) Token: 0x06000212 RID: 530 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		public unsafe int sampleIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAntialiasing.NativeMethodInfoPtr_get_sampleIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAntialiasing.NativeMethodInfoPtr_set_sampleIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000C0E8 File Offset: 0x0000A2E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 444982, RefRangeEnd = 444988, XrefRangeStart = 444976, XrefRangeEnd = 444982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAntialiasing.NativeMethodInfoPtr_IsSupported_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000C124 File Offset: 0x0000A324
		[CallerCount(0)]
		public unsafe DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAntialiasing.NativeMethodInfoPtr_GetCameraFlags_Internal_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000C160 File Offset: 0x0000A360
		[CallerCount(0)]
		public unsafe void ResetHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAntialiasing.NativeMethodInfoPtr_ResetHistory_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000C194 File Offset: 0x0000A394
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 444988, RefRangeEnd = 444990, XrefRangeStart = 444988, XrefRangeEnd = 444988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GenerateRandomOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAntialiasing.NativeMethodInfoPtr_GenerateRandomOffset_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000C1D0 File Offset: 0x0000A3D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 445008, RefRangeEnd = 445009, XrefRangeStart = 444990, XrefRangeEnd = 445008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetJitteredProjectionMatrix(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAntialiasing.NativeMethodInfoPtr_GetJitteredProjectionMatrix_Public_Matrix4x4_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000C220 File Offset: 0x0000A420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 445027, RefRangeEnd = 445028, XrefRangeStart = 445009, XrefRangeEnd = 445027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAntialiasing.NativeMethodInfoPtr_ConfigureJitteredProjectionMatrix_Public_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000C264 File Offset: 0x0000A464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 445050, RefRangeEnd = 445051, XrefRangeStart = 445028, XrefRangeEnd = 445050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAntialiasing.NativeMethodInfoPtr_ConfigureStereoJitteredProjectionMatrices_Public_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000C2A8 File Offset: 0x0000A4A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 445064, RefRangeEnd = 445066, XrefRangeStart = 445051, XrefRangeEnd = 445064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAntialiasing.NativeMethodInfoPtr_GenerateHistoryName_Private_Void_RenderTexture_Int32_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000C30C File Offset: 0x0000A50C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 445110, RefRangeEnd = 445112, XrefRangeStart = 445066, XrefRangeEnd = 445110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture CheckHistory(int id, PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAntialiasing.NativeMethodInfoPtr_CheckHistory_Private_RenderTexture_Int32_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000C36C File Offset: 0x0000A56C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 445144, RefRangeEnd = 445145, XrefRangeStart = 445112, XrefRangeEnd = 445144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAntialiasing.NativeMethodInfoPtr_Render_Internal_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000C3B0 File Offset: 0x0000A5B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 445150, RefRangeEnd = 445151, XrefRangeStart = 445145, XrefRangeEnd = 445150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAntialiasing.NativeMethodInfoPtr_Release_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000C3E4 File Offset: 0x0000A5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445151, XrefRangeEnd = 445160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TemporalAntialiasing()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TemporalAntialiasing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemporalAntialiasing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000355A File Offset: 0x0000175A
		public TemporalAntialiasing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0000C420 File Offset: 0x0000A620
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00003563 File Offset: 0x00001763
		public unsafe float jitterSpread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_jitterSpread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_jitterSpread)) = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000C448 File Offset: 0x0000A648
		// (set) Token: 0x06000223 RID: 547 RVA: 0x0000357E File Offset: 0x0000177E
		public unsafe float sharpness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_sharpness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_sharpness)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000C470 File Offset: 0x0000A670
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00003599 File Offset: 0x00001799
		public unsafe float stationaryBlending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_stationaryBlending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_stationaryBlending)) = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000C498 File Offset: 0x0000A698
		// (set) Token: 0x06000227 RID: 551 RVA: 0x000035B4 File Offset: 0x000017B4
		public unsafe float motionBlending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_motionBlending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_motionBlending)) = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0000C4C0 File Offset: 0x0000A6C0
		// (set) Token: 0x06000229 RID: 553 RVA: 0x000035CF File Offset: 0x000017CF
		public unsafe Func<Camera, Vector2, Matrix4x4> jitteredMatrixFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_jitteredMatrixFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Camera, Vector2, Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_jitteredMatrixFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0000C4F0 File Offset: 0x0000A6F0
		// (set) Token: 0x0600022B RID: 555 RVA: 0x000035EE File Offset: 0x000017EE
		public unsafe Vector2 _jitter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr__jitter_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr__jitter_k__BackingField)) = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0000C518 File Offset: 0x0000A718
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00003609 File Offset: 0x00001809
		public unsafe Il2CppStructArray<RenderTargetIdentifier> m_Mrt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_m_Mrt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_m_Mrt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0000C548 File Offset: 0x0000A748
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00003628 File Offset: 0x00001828
		public unsafe bool m_ResetHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_m_ResetHistory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_m_ResetHistory)) = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000C570 File Offset: 0x0000A770
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00003643 File Offset: 0x00001843
		public unsafe static int k_SampleCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TemporalAntialiasing.NativeFieldInfoPtr_k_SampleCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TemporalAntialiasing.NativeFieldInfoPtr_k_SampleCount, (void*)(&value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000C58C File Offset: 0x0000A78C
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00003651 File Offset: 0x00001851
		public unsafe int _sampleIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr__sampleIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr__sampleIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
		// (set) Token: 0x06000235 RID: 565 RVA: 0x0000366C File Offset: 0x0000186C
		public unsafe static int k_NumEyes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TemporalAntialiasing.NativeFieldInfoPtr_k_NumEyes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TemporalAntialiasing.NativeFieldInfoPtr_k_NumEyes, (void*)(&value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		// (set) Token: 0x06000237 RID: 567 RVA: 0x0000367A File Offset: 0x0000187A
		public unsafe static int k_NumHistoryTextures
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TemporalAntialiasing.NativeFieldInfoPtr_k_NumHistoryTextures, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TemporalAntialiasing.NativeFieldInfoPtr_k_NumHistoryTextures, (void*)(&value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000C5EC File Offset: 0x0000A7EC
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00003688 File Offset: 0x00001888
		public unsafe Il2CppReferenceArray<Il2CppReferenceArray<RenderTexture>> m_HistoryTextures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_m_HistoryTextures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<RenderTexture>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_m_HistoryTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0000C61C File Offset: 0x0000A81C
		// (set) Token: 0x0600023B RID: 571 RVA: 0x000036A7 File Offset: 0x000018A7
		public unsafe Il2CppStructArray<int> m_HistoryPingPong
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_m_HistoryPingPong);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemporalAntialiasing.NativeFieldInfoPtr_m_HistoryPingPong), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_jitterSpread;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr_sharpness;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeFieldInfoPtr_stationaryBlending;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeFieldInfoPtr_motionBlending;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_jitteredMatrixFunc;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr__jitter_k__BackingField;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_m_Mrt;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr_m_ResetHistory;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_k_SampleCount;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr__sampleIndex_k__BackingField;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_k_NumEyes;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_k_NumHistoryTextures;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_m_HistoryTextures;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr_m_HistoryPingPong;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_get_jitter_Public_get_Vector2_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_set_jitter_Private_set_Void_Vector2_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_get_sampleIndex_Public_get_Int32_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_set_sampleIndex_Private_set_Void_Int32_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_IsSupported_Public_Boolean_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Internal_DepthTextureMode_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_ResetHistory_Internal_Void_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandomOffset_Private_Vector2_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_GetJitteredProjectionMatrix_Public_Matrix4x4_Camera_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureJitteredProjectionMatrix_Public_Void_PostProcessRenderContext_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureStereoJitteredProjectionMatrices_Public_Void_PostProcessRenderContext_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_GenerateHistoryName_Private_Void_RenderTexture_Int32_PostProcessRenderContext_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_CheckHistory_Private_RenderTexture_Int32_PostProcessRenderContext_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Void_PostProcessRenderContext_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_Release_Internal_Void_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000075 RID: 117
		[OriginalName("Unity.Postprocessing.Runtime.dll", "", "Pass")]
		public enum Pass
		{
			// Token: 0x040004B5 RID: 1205
			SolverDilate,
			// Token: 0x040004B6 RID: 1206
			SolverNoDilate
		}
	}
}
