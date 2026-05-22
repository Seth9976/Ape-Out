using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000175 RID: 373
	public static class RenderPipelineManager : Object
	{
		// Token: 0x06001C20 RID: 7200 RVA: 0x000692A8 File Offset: 0x000674A8
		// Note: this type is marked as 'beforefieldinit'.
		static RenderPipelineManager()
		{
			Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderPipelineManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr);
			RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_CurrentPipelineAsset");
			RenderPipelineManager.NativeFieldInfoPtr_s_Cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_Cameras");
			RenderPipelineManager.NativeFieldInfoPtr_s_CameraCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_CameraCapacity");
			RenderPipelineManager.NativeFieldInfoPtr__currentPipeline_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "<currentPipeline>k__BackingField");
			RenderPipelineManager.NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100665840);
			RenderPipelineManager.NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100665841);
			RenderPipelineManager.NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100665842);
			RenderPipelineManager.NativeMethodInfoPtr_GetCameras_Private_Static_Void_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100665843);
			RenderPipelineManager.NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_List_1_RenderRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100665844);
			RenderPipelineManager.NativeMethodInfoPtr_PrepareRenderPipeline_Internal_Static_Void_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100665845);
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x000693A0 File Offset: 0x000675A0
		// (set) Token: 0x06001C22 RID: 7202 RVA: 0x000693D4 File Offset: 0x000675D4
		public unsafe static RenderPipeline currentPipeline
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503050, XrefRangeEnd = 503054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503054, XrefRangeEnd = 503058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0006940C File Offset: 0x0006760C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 503085, RefRangeEnd = 503088, XrefRangeStart = 503058, XrefRangeEnd = 503085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupRenderPipeline()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x00069434 File Offset: 0x00067634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 503106, RefRangeEnd = 503107, XrefRangeStart = 503088, XrefRangeEnd = 503106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetCameras(ScriptableRenderContext context)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_GetCameras_Private_Static_Void_ScriptableRenderContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x00069468 File Offset: 0x00067668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503107, XrefRangeEnd = 503130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, List<Camera.RenderRequest> renderRequests)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pipe);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loopPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderRequests);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_List_1_RenderRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x000694C0 File Offset: 0x000676C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 503168, RefRangeEnd = 503170, XrefRangeStart = 503130, XrefRangeEnd = 503168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pipelineAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_PrepareRenderPipeline_Internal_Static_Void_RenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
		public RenderPipelineManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x000694F8 File Offset: 0x000676F8
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x0000F0AD File Offset: 0x0000D2AD
		public unsafe static RenderPipelineAsset s_CurrentPipelineAsset
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineAsset, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderPipelineAsset>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineAsset, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00069520 File Offset: 0x00067720
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x0000F0BF File Offset: 0x0000D2BF
		public unsafe static Il2CppReferenceArray<Camera> s_Cameras
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_Cameras, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Camera>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_Cameras, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00069548 File Offset: 0x00067748
		// (set) Token: 0x06001C2D RID: 7213 RVA: 0x0000F0D1 File Offset: 0x0000D2D1
		public unsafe static int s_CameraCapacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_CameraCapacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_CameraCapacity, (void*)(&value));
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x00069564 File Offset: 0x00067764
		// (set) Token: 0x06001C2F RID: 7215 RVA: 0x0000F0DF File Offset: 0x0000D2DF
		public unsafe static RenderPipeline _currentPipeline_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr__currentPipeline_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr__currentPipeline_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x0000F0F1 File Offset: 0x0000D2F1
		public static void BeginFrameRendering(ScriptableRenderContext context, Il2CppReferenceArray<Camera> cameras)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x0000F0FE File Offset: 0x0000D2FE
		public static void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x0000F10B File Offset: 0x0000D30B
		public static void EndFrameRendering(ScriptableRenderContext context, Il2CppReferenceArray<Camera> cameras)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x0000F118 File Offset: 0x0000D318
		public static void EndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeFieldInfoPtr_s_CurrentPipelineAsset;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeFieldInfoPtr_s_Cameras;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeFieldInfoPtr_s_CameraCapacity;

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeFieldInfoPtr__currentPipeline_k__BackingField;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0;

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeMethodInfoPtr_GetCameras_Private_Static_Void_ScriptableRenderContext_0;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_List_1_RenderRequest_0;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeMethodInfoPtr_PrepareRenderPipeline_Internal_Static_Void_RenderPipelineAsset_0;
	}
}
