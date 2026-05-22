using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200002A RID: 42
	[Serializable]
	public sealed class MultiScaleVO : Object
	{
		// Token: 0x0600019F RID: 415 RVA: 0x0000A49C File Offset: 0x0000869C
		// Note: this type is marked as 'beforefieldinit'.
		static MultiScaleVO()
		{
			Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "MultiScaleVO");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr);
			MultiScaleVO.NativeFieldInfoPtr_m_SampleThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, "m_SampleThickness");
			MultiScaleVO.NativeFieldInfoPtr_m_InvThicknessTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, "m_InvThicknessTable");
			MultiScaleVO.NativeFieldInfoPtr_m_SampleWeightTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, "m_SampleWeightTable");
			MultiScaleVO.NativeFieldInfoPtr_m_ScaledWidths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, "m_ScaledWidths");
			MultiScaleVO.NativeFieldInfoPtr_m_ScaledHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, "m_ScaledHeights");
			MultiScaleVO.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, "m_Settings");
			MultiScaleVO.NativeFieldInfoPtr_m_PropertySheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, "m_PropertySheet");
			MultiScaleVO.NativeFieldInfoPtr_m_Resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, "m_Resources");
			MultiScaleVO.NativeFieldInfoPtr_m_AmbientOnlyAO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, "m_AmbientOnlyAO");
			MultiScaleVO.NativeFieldInfoPtr_m_MRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, "m_MRT");
			MultiScaleVO.NativeMethodInfoPtr__ctor_Public_Void_AmbientOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663389);
			MultiScaleVO.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_Final_New_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663390);
			MultiScaleVO.NativeMethodInfoPtr_SetResources_Public_Void_PostProcessResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663391);
			MultiScaleVO.NativeMethodInfoPtr_Alloc_Private_Void_CommandBuffer_Int32_MipLevel_RenderTextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663392);
			MultiScaleVO.NativeMethodInfoPtr_AllocArray_Private_Void_CommandBuffer_Int32_MipLevel_RenderTextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663393);
			MultiScaleVO.NativeMethodInfoPtr_Release_Private_Void_CommandBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663394);
			MultiScaleVO.NativeMethodInfoPtr_CalculateZBufferParams_Private_Vector4_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663395);
			MultiScaleVO.NativeMethodInfoPtr_CalculateTanHalfFovHeight_Private_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663396);
			MultiScaleVO.NativeMethodInfoPtr_GetSize_Private_Vector2_MipLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663397);
			MultiScaleVO.NativeMethodInfoPtr_GetSizeArray_Private_Vector3_MipLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663398);
			MultiScaleVO.NativeMethodInfoPtr_GenerateAOMap_Public_Void_CommandBuffer_Camera_RenderTargetIdentifier_Nullable_1_RenderTargetIdentifier_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663399);
			MultiScaleVO.NativeMethodInfoPtr_PushAllocCommands_Private_Void_CommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663400);
			MultiScaleVO.NativeMethodInfoPtr_PushDownsampleCommands_Private_Void_CommandBuffer_Camera_Nullable_1_RenderTargetIdentifier_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663401);
			MultiScaleVO.NativeMethodInfoPtr_PushRenderCommands_Private_Void_CommandBuffer_Int32_Int32_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663402);
			MultiScaleVO.NativeMethodInfoPtr_PushUpsampleCommands_Private_Void_CommandBuffer_Int32_Int32_Int32_Nullable_1_Int32_RenderTargetIdentifier_Vector3_Vector2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663403);
			MultiScaleVO.NativeMethodInfoPtr_PushReleaseCommands_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663404);
			MultiScaleVO.NativeMethodInfoPtr_PreparePropertySheet_Private_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663405);
			MultiScaleVO.NativeMethodInfoPtr_CheckAOTexture_Private_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663406);
			MultiScaleVO.NativeMethodInfoPtr_PushDebug_Private_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663407);
			MultiScaleVO.NativeMethodInfoPtr_RenderAfterOpaque_Public_Virtual_Final_New_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663408);
			MultiScaleVO.NativeMethodInfoPtr_RenderAmbientOnly_Public_Virtual_Final_New_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663409);
			MultiScaleVO.NativeMethodInfoPtr_CompositeAmbientOnly_Public_Virtual_Final_New_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663410);
			MultiScaleVO.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr, 100663411);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000A760 File Offset: 0x00008960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 443702, RefRangeEnd = 443703, XrefRangeStart = 443661, XrefRangeEnd = 443702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiScaleVO(AmbientOcclusion settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiScaleVO>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr__ctor_Public_Void_AmbientOcclusion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000A7AC File Offset: 0x000089AC
		[CallerCount(0)]
		public unsafe DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_Final_New_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000A7E8 File Offset: 0x000089E8
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 14747, RefRangeEnd = 14763, XrefRangeStart = 14747, XrefRangeEnd = 14763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResources(PostProcessResources resources)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resources);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_SetResources_Public_Void_PostProcessResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000A82C File Offset: 0x00008A2C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 443708, RefRangeEnd = 443726, XrefRangeStart = 443703, XrefRangeEnd = 443708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Alloc(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uav;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_Alloc_Private_Void_CommandBuffer_Int32_MipLevel_RenderTextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 443731, RefRangeEnd = 443739, XrefRangeStart = 443726, XrefRangeEnd = 443731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllocArray(CommandBuffer cmd, int id, MultiScaleVO.MipLevel size, RenderTextureFormat format, bool uav)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uav;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_AllocArray_Private_Void_CommandBuffer_Int32_MipLevel_RenderTextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000A924 File Offset: 0x00008B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443739, XrefRangeEnd = 443744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(CommandBuffer cmd, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_Release_Private_Void_CommandBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000A974 File Offset: 0x00008B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443744, XrefRangeEnd = 443750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 CalculateZBufferParams(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_CalculateZBufferParams_Private_Vector4_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000A9C4 File Offset: 0x00008BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443750, XrefRangeEnd = 443752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateTanHalfFovHeight(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_CalculateTanHalfFovHeight_Private_Single_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000AA14 File Offset: 0x00008C14
		[CallerCount(0)]
		public unsafe Vector2 GetSize(MultiScaleVO.MipLevel mip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mip;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_GetSize_Private_Vector2_MipLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000AA60 File Offset: 0x00008C60
		[CallerCount(0)]
		public unsafe Vector3 GetSizeArray(MultiScaleVO.MipLevel mip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mip;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_GetSizeArray_Private_Vector3_MipLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000AAAC File Offset: 0x00008CAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 443839, RefRangeEnd = 443842, XrefRangeStart = 443752, XrefRangeEnd = 443839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(depthMap));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMSAA;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_GenerateAOMap_Public_Void_CommandBuffer_Camera_RenderTargetIdentifier_Nullable_1_RenderTargetIdentifier_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000AB44 File Offset: 0x00008D44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 443897, RefRangeEnd = 443898, XrefRangeStart = 443842, XrefRangeEnd = 443897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushAllocCommands(CommandBuffer cmd, bool isMSAA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMSAA;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_PushAllocCommands_Private_Void_CommandBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000AB94 File Offset: 0x00008D94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 444045, RefRangeEnd = 444046, XrefRangeStart = 443898, XrefRangeEnd = 444045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushDownsampleCommands(CommandBuffer cmd, Camera camera, Nullable<RenderTargetIdentifier> depthMap, bool isMSAA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(depthMap));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMSAA;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_PushDownsampleCommands_Private_Void_CommandBuffer_Camera_Nullable_1_RenderTargetIdentifier_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000AC10 File Offset: 0x00008E10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 444096, RefRangeEnd = 444100, XrefRangeStart = 444046, XrefRangeEnd = 444096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tanHalfFovH;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMSAA;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_PushRenderCommands_Private_Void_CommandBuffer_Int32_Int32_Vector3_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000AC98 File Offset: 0x00008E98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 444161, RefRangeEnd = 444165, XrefRangeStart = 444100, XrefRangeEnd = 444161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, Nullable<int> highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowResDepth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interleavedAO;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highResDepth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(highResAO));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowResDepthSize;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highResDepthSize;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMSAA;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_PushUpsampleCommands_Private_Void_CommandBuffer_Int32_Int32_Int32_Nullable_1_Int32_RenderTargetIdentifier_Vector3_Vector2_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000AD64 File Offset: 0x00008F64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 444249, RefRangeEnd = 444250, XrefRangeStart = 444165, XrefRangeEnd = 444249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushReleaseCommands(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_PushReleaseCommands_Private_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000ADA8 File Offset: 0x00008FA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 444259, RefRangeEnd = 444261, XrefRangeStart = 444250, XrefRangeEnd = 444259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreparePropertySheet(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_PreparePropertySheet_Private_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000ADEC File Offset: 0x00008FEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 444300, RefRangeEnd = 444302, XrefRangeStart = 444261, XrefRangeEnd = 444300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAOTexture(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_CheckAOTexture_Private_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000AE30 File Offset: 0x00009030
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 444304, RefRangeEnd = 444306, XrefRangeStart = 444302, XrefRangeEnd = 444304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushDebug(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_PushDebug_Private_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000AE74 File Offset: 0x00009074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444306, XrefRangeEnd = 444368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderAfterOpaque(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_RenderAfterOpaque_Public_Virtual_Final_New_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000AEB8 File Offset: 0x000090B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444368, XrefRangeEnd = 444385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderAmbientOnly(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_RenderAmbientOnly_Public_Virtual_Final_New_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000AEFC File Offset: 0x000090FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444385, XrefRangeEnd = 444412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompositeAmbientOnly(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_CompositeAmbientOnly_Public_Virtual_Final_New_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000AF40 File Offset: 0x00009140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444412, XrefRangeEnd = 444416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiScaleVO.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00003168 File Offset: 0x00001368
		public MultiScaleVO(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000AF74 File Offset: 0x00009174
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00003171 File Offset: 0x00001371
		public unsafe Il2CppStructArray<float> m_SampleThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_SampleThickness);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_SampleThickness), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000AFA4 File Offset: 0x000091A4
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00003190 File Offset: 0x00001390
		public unsafe Il2CppStructArray<float> m_InvThicknessTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_InvThicknessTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_InvThicknessTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000AFD4 File Offset: 0x000091D4
		// (set) Token: 0x060001BD RID: 445 RVA: 0x000031AF File Offset: 0x000013AF
		public unsafe Il2CppStructArray<float> m_SampleWeightTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_SampleWeightTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_SampleWeightTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0000B004 File Offset: 0x00009204
		// (set) Token: 0x060001BF RID: 447 RVA: 0x000031CE File Offset: 0x000013CE
		public unsafe Il2CppStructArray<int> m_ScaledWidths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_ScaledWidths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_ScaledWidths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000B034 File Offset: 0x00009234
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x000031ED File Offset: 0x000013ED
		public unsafe Il2CppStructArray<int> m_ScaledHeights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_ScaledHeights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_ScaledHeights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000B064 File Offset: 0x00009264
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x0000320C File Offset: 0x0000140C
		public unsafe AmbientOcclusion m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmbientOcclusion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000B094 File Offset: 0x00009294
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x0000322B File Offset: 0x0000142B
		public unsafe PropertySheet m_PropertySheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_PropertySheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertySheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_PropertySheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000B0C4 File Offset: 0x000092C4
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0000324A File Offset: 0x0000144A
		public unsafe PostProcessResources m_Resources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_Resources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessResources>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_Resources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000B0F4 File Offset: 0x000092F4
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00003269 File Offset: 0x00001469
		public unsafe RenderTexture m_AmbientOnlyAO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_AmbientOnlyAO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_AmbientOnlyAO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000B124 File Offset: 0x00009324
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00003288 File Offset: 0x00001488
		public unsafe Il2CppStructArray<RenderTargetIdentifier> m_MRT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_MRT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiScaleVO.NativeFieldInfoPtr_m_MRT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_m_SampleThickness;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_m_InvThicknessTable;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_m_SampleWeightTable;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_m_ScaledWidths;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_m_ScaledHeights;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertySheet;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_m_Resources;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_m_AmbientOnlyAO;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_m_MRT;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AmbientOcclusion_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_Final_New_DepthTextureMode_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_SetResources_Public_Void_PostProcessResources_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Private_Void_CommandBuffer_Int32_MipLevel_RenderTextureFormat_Boolean_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_AllocArray_Private_Void_CommandBuffer_Int32_MipLevel_RenderTextureFormat_Boolean_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_CommandBuffer_Int32_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_CalculateZBufferParams_Private_Vector4_Camera_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_CalculateTanHalfFovHeight_Private_Single_Camera_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_GetSize_Private_Vector2_MipLevel_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_GetSizeArray_Private_Vector3_MipLevel_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_GenerateAOMap_Public_Void_CommandBuffer_Camera_RenderTargetIdentifier_Nullable_1_RenderTargetIdentifier_Boolean_Boolean_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_PushAllocCommands_Private_Void_CommandBuffer_Boolean_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_PushDownsampleCommands_Private_Void_CommandBuffer_Camera_Nullable_1_RenderTargetIdentifier_Boolean_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_PushRenderCommands_Private_Void_CommandBuffer_Int32_Int32_Vector3_Single_Boolean_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_PushUpsampleCommands_Private_Void_CommandBuffer_Int32_Int32_Int32_Nullable_1_Int32_RenderTargetIdentifier_Vector3_Vector2_Boolean_Boolean_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_PushReleaseCommands_Private_Void_CommandBuffer_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_PreparePropertySheet_Private_Void_PostProcessRenderContext_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_CheckAOTexture_Private_Void_PostProcessRenderContext_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_PushDebug_Private_Void_PostProcessRenderContext_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_RenderAfterOpaque_Public_Virtual_Final_New_Void_PostProcessRenderContext_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_RenderAmbientOnly_Public_Virtual_Final_New_Void_PostProcessRenderContext_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_CompositeAmbientOnly_Public_Virtual_Final_New_Void_PostProcessRenderContext_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_0;

		// Token: 0x0200006E RID: 110
		[OriginalName("Unity.Postprocessing.Runtime.dll", "", "MipLevel")]
		public enum MipLevel
		{
			// Token: 0x0400048E RID: 1166
			Original,
			// Token: 0x0400048F RID: 1167
			L1,
			// Token: 0x04000490 RID: 1168
			L2,
			// Token: 0x04000491 RID: 1169
			L3,
			// Token: 0x04000492 RID: 1170
			L4,
			// Token: 0x04000493 RID: 1171
			L5,
			// Token: 0x04000494 RID: 1172
			L6
		}

		// Token: 0x0200006F RID: 111
		[OriginalName("Unity.Postprocessing.Runtime.dll", "", "Pass")]
		public enum Pass
		{
			// Token: 0x04000496 RID: 1174
			DepthCopy,
			// Token: 0x04000497 RID: 1175
			CompositionDeferred,
			// Token: 0x04000498 RID: 1176
			CompositionForward,
			// Token: 0x04000499 RID: 1177
			DebugOverlay
		}
	}
}
