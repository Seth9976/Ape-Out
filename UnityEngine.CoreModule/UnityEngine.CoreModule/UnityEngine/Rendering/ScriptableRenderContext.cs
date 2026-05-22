using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Rendering
{
	// Token: 0x02000176 RID: 374
	[StructLayout(2)]
	public struct ScriptableRenderContext
	{
		// Token: 0x06001C34 RID: 7220 RVA: 0x0006958C File Offset: 0x0006778C
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableRenderContext()
		{
			Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ScriptableRenderContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr);
			ScriptableRenderContext.NativeFieldInfoPtr_kRenderTypeTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, "kRenderTypeTag");
			ScriptableRenderContext.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, "m_Ptr");
			ScriptableRenderContext.NativeMethodInfoPtr_GetNumberOfCameras_Internal_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100665847);
			ScriptableRenderContext.NativeMethodInfoPtr_GetCamera_Internal_Private_Camera_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100665848);
			ScriptableRenderContext.NativeMethodInfoPtr_GetNumberOfCameras_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100665850);
			ScriptableRenderContext.NativeMethodInfoPtr_GetCamera_Internal_Camera_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100665851);
			ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100665852);
			ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100665853);
			ScriptableRenderContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100665854);
			ScriptableRenderContext.NativeMethodInfoPtr_GetNumberOfCameras_Internal_Injected_Private_Static_Int32_byref_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100665856);
			ScriptableRenderContext.NativeMethodInfoPtr_GetCamera_Internal_Injected_Private_Static_Camera_byref_ScriptableRenderContext_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, 100665857);
			ScriptableRenderContext.BeginRenderPass_InternalDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.BeginRenderPass_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::BeginRenderPass_Internal");
			ScriptableRenderContext.BeginSubPass_InternalDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.BeginSubPass_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::BeginSubPass_Internal");
			ScriptableRenderContext.EndSubPass_InternalDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.EndSubPass_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::EndSubPass_Internal");
			ScriptableRenderContext.EndRenderPass_InternalDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.EndRenderPass_InternalDelegate>("UnityEngine.Rendering.ScriptableRenderContext::EndRenderPass_Internal");
			ScriptableRenderContext.InitializeSortSettingsDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.InitializeSortSettingsDelegate>("UnityEngine.Rendering.ScriptableRenderContext::InitializeSortSettings");
			ScriptableRenderContext.EmitGeometryForCameraDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.EmitGeometryForCameraDelegate>("UnityEngine.Rendering.ScriptableRenderContext::EmitGeometryForCamera");
			ScriptableRenderContext.Submit_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.Submit_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::Submit_Internal_Injected");
			ScriptableRenderContext.DrawShadows_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawShadows_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawShadows_Internal_Injected");
			ScriptableRenderContext.ExecuteCommandBuffer_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.ExecuteCommandBuffer_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::ExecuteCommandBuffer_Internal_Injected");
			ScriptableRenderContext.ExecuteCommandBufferAsync_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.ExecuteCommandBufferAsync_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::ExecuteCommandBufferAsync_Internal_Injected");
			ScriptableRenderContext.SetupCameraProperties_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.SetupCameraProperties_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::SetupCameraProperties_Internal_Injected");
			ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StereoEndRender_Internal_Injected");
			ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StartMultiEye_Internal_Injected");
			ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::StopMultiEye_Internal_Injected");
			ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawSkybox_Internal_Injected");
			ScriptableRenderContext.InvokeOnRenderObjectCallback_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.InvokeOnRenderObjectCallback_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::InvokeOnRenderObjectCallback_Internal_Injected");
			ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawGizmos_Internal_Injected");
			ScriptableRenderContext.DrawWireOverlay_Impl_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawWireOverlay_Impl_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawWireOverlay_Impl_Injected");
			ScriptableRenderContext.DrawUIOverlay_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ScriptableRenderContext.DrawUIOverlay_Internal_InjectedDelegate>("UnityEngine.Rendering.ScriptableRenderContext::DrawUIOverlay_Internal_Injected");
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x000697B8 File Offset: 0x000679B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 503177, RefRangeEnd = 503179, XrefRangeStart = 503170, XrefRangeEnd = 503177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNumberOfCameras_Internal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetNumberOfCameras_Internal_Private_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x000697E8 File Offset: 0x000679E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 503186, RefRangeEnd = 503188, XrefRangeStart = 503179, XrefRangeEnd = 503186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Camera GetCamera_Internal(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetCamera_Internal_Private_Camera_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00069828 File Offset: 0x00067A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503188, XrefRangeEnd = 503189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNumberOfCameras()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetNumberOfCameras_Internal_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00069858 File Offset: 0x00067A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503189, XrefRangeEnd = 503190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Camera GetCamera(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetCamera_Internal_Camera_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00069898 File Offset: 0x00067A98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 503195, RefRangeEnd = 503196, XrefRangeStart = 503190, XrefRangeEnd = 503195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ScriptableRenderContext other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x000698D8 File Offset: 0x00067AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503196, XrefRangeEnd = 503199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x0006991C File Offset: 0x00067B1C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x0006994C File Offset: 0x00067B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503199, XrefRangeEnd = 503203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNumberOfCameras_Internal_Injected(ref ScriptableRenderContext _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetNumberOfCameras_Internal_Injected_Private_Static_Int32_byref_ScriptableRenderContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x0006998C File Offset: 0x00067B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503203, XrefRangeEnd = 503207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Camera GetCamera_Internal_Injected(ref ScriptableRenderContext _unity_self, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRenderContext.NativeMethodInfoPtr_GetCamera_Internal_Injected_Private_Static_Camera_byref_ScriptableRenderContext_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x0000F125 File Offset: 0x0000D325
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableRenderContext>.NativeClassPtr, ref this));
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x000699DC File Offset: 0x00067BDC
		// (set) Token: 0x06001C40 RID: 7232 RVA: 0x0000F137 File Offset: 0x0000D337
		public unsafe static ShaderTagId kRenderTypeTag
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRenderContext.NativeFieldInfoPtr_kRenderTypeTag, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRenderContext.NativeFieldInfoPtr_kRenderTypeTag, (void*)(&value));
			}
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x0000F145 File Offset: 0x0000D345
		public static void BeginRenderPass_Internal(IntPtr self, int width, int height, int samples, IntPtr colors, int colorCount, int depthAttachmentIndex)
		{
			ScriptableRenderContext.BeginRenderPass_InternalDelegateField(self, width, height, samples, colors, colorCount, depthAttachmentIndex);
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x0000F15B File Offset: 0x0000D35B
		public static void BeginSubPass_Internal(IntPtr self, IntPtr colors, int colorCount, IntPtr inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			ScriptableRenderContext.BeginSubPass_InternalDelegateField(self, colors, colorCount, inputs, inputCount, isDepthReadOnly, isStencilReadOnly);
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x0000F171 File Offset: 0x0000D371
		public static void EndSubPass_Internal(IntPtr self)
		{
			ScriptableRenderContext.EndSubPass_InternalDelegateField(self);
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x0000F17E File Offset: 0x0000D37E
		public static void EndRenderPass_Internal(IntPtr self)
		{
			ScriptableRenderContext.EndRenderPass_InternalDelegateField(self);
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x0000F18B File Offset: 0x0000D38B
		public static void InitializeSortSettings(Camera camera, out SortingSettings sortingSettings)
		{
			ScriptableRenderContext.InitializeSortSettingsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(camera), out sortingSettings);
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x0000F19E File Offset: 0x0000D39E
		public void Submit_Internal()
		{
			ScriptableRenderContext.Submit_Internal_Injected(ref this);
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x0000F1A6 File Offset: 0x0000D3A6
		public void DrawShadows_Internal(IntPtr shadowDrawingSettings)
		{
			ScriptableRenderContext.DrawShadows_Internal_Injected(ref this, shadowDrawingSettings);
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x0000F1AF File Offset: 0x0000D3AF
		public static void EmitGeometryForCamera(Camera camera)
		{
			ScriptableRenderContext.EmitGeometryForCameraDelegateField(IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0000F1C1 File Offset: 0x0000D3C1
		public void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer)
		{
			ScriptableRenderContext.ExecuteCommandBuffer_Internal_Injected(ref this, commandBuffer);
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x0000F1CA File Offset: 0x0000D3CA
		public void ExecuteCommandBufferAsync_Internal(CommandBuffer commandBuffer, ComputeQueueType queueType)
		{
			ScriptableRenderContext.ExecuteCommandBufferAsync_Internal_Injected(ref this, commandBuffer, queueType);
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x0000F1D4 File Offset: 0x0000D3D4
		public void SetupCameraProperties_Internal(Camera camera, bool stereoSetup, int eye)
		{
			ScriptableRenderContext.SetupCameraProperties_Internal_Injected(ref this, camera, stereoSetup, eye);
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0000F1DF File Offset: 0x0000D3DF
		public void StereoEndRender_Internal(Camera camera, int eye, bool isFinalPass)
		{
			ScriptableRenderContext.StereoEndRender_Internal_Injected(ref this, camera, eye, isFinalPass);
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x0000F1EA File Offset: 0x0000D3EA
		public void StartMultiEye_Internal(Camera camera, int eye)
		{
			ScriptableRenderContext.StartMultiEye_Internal_Injected(ref this, camera, eye);
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0000F1F4 File Offset: 0x0000D3F4
		public void StopMultiEye_Internal(Camera camera)
		{
			ScriptableRenderContext.StopMultiEye_Internal_Injected(ref this, camera);
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x0000F1FD File Offset: 0x0000D3FD
		public void DrawSkybox_Internal(Camera camera)
		{
			ScriptableRenderContext.DrawSkybox_Internal_Injected(ref this, camera);
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0000F206 File Offset: 0x0000D406
		public void InvokeOnRenderObjectCallback_Internal()
		{
			ScriptableRenderContext.InvokeOnRenderObjectCallback_Internal_Injected(ref this);
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0000F20E File Offset: 0x0000D40E
		public void DrawGizmos_Internal(Camera camera, GizmoSubset gizmoSubset)
		{
			ScriptableRenderContext.DrawGizmos_Internal_Injected(ref this, camera, gizmoSubset);
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x0000F218 File Offset: 0x0000D418
		public void DrawWireOverlay_Impl(Camera camera)
		{
			ScriptableRenderContext.DrawWireOverlay_Impl_Injected(ref this, camera);
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x0000F221 File Offset: 0x0000D421
		public void DrawUIOverlay_Internal(Camera camera)
		{
			ScriptableRenderContext.DrawUIOverlay_Internal_Injected(ref this, camera);
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x000699F8 File Offset: 0x00067BF8
		public IntPtr Internal_GetPtr()
		{
			return this.m_Ptr;
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x0000F22A File Offset: 0x0000D42A
		public void BeginSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			ScriptableRenderContext.BeginSubPass_Internal(this.m_Ptr, (IntPtr)colors.GetUnsafeReadOnlyPtr<int>(), colors.Length, (IntPtr)inputs.GetUnsafeReadOnlyPtr<int>(), inputs.Length, isDepthReadOnly, isStencilReadOnly);
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x0000F260 File Offset: 0x0000D460
		public void BeginSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, [Optional] bool isDepthStencilReadOnly)
		{
			ScriptableRenderContext.BeginSubPass_Internal(this.m_Ptr, (IntPtr)colors.GetUnsafeReadOnlyPtr<int>(), colors.Length, (IntPtr)inputs.GetUnsafeReadOnlyPtr<int>(), inputs.Length, isDepthStencilReadOnly, isDepthStencilReadOnly);
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x0000F295 File Offset: 0x0000D495
		public void BeginSubPass(Unity.Collections.NativeArray<int> colors, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			ScriptableRenderContext.BeginSubPass_Internal(this.m_Ptr, (IntPtr)colors.GetUnsafeReadOnlyPtr<int>(), colors.Length, IntPtr.Zero, 0, isDepthReadOnly, isStencilReadOnly);
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x0000F2BE File Offset: 0x0000D4BE
		public void BeginSubPass(Unity.Collections.NativeArray<int> colors, [Optional] bool isDepthStencilReadOnly)
		{
			ScriptableRenderContext.BeginSubPass_Internal(this.m_Ptr, (IntPtr)colors.GetUnsafeReadOnlyPtr<int>(), colors.Length, IntPtr.Zero, 0, isDepthStencilReadOnly, isDepthStencilReadOnly);
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00069A10 File Offset: 0x00067C10
		public ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			this.BeginSubPass(colors, inputs, isDepthReadOnly, isStencilReadOnly);
			return new ScopedSubPass(this);
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x00069A3C File Offset: 0x00067C3C
		public ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, [Optional] bool isDepthStencilReadOnly)
		{
			this.BeginSubPass(colors, inputs, isDepthStencilReadOnly);
			return new ScopedSubPass(this);
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x00069A64 File Offset: 0x00067C64
		public ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, bool isDepthReadOnly, bool isStencilReadOnly)
		{
			this.BeginSubPass(colors, isDepthReadOnly, isStencilReadOnly);
			return new ScopedSubPass(this);
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x00069A8C File Offset: 0x00067C8C
		public ScopedSubPass BeginScopedSubPass(Unity.Collections.NativeArray<int> colors, [Optional] bool isDepthStencilReadOnly)
		{
			this.BeginSubPass(colors, isDepthStencilReadOnly);
			return new ScopedSubPass(this);
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x0000F2E7 File Offset: 0x0000D4E7
		public void EndSubPass()
		{
			ScriptableRenderContext.EndSubPass_Internal(this.m_Ptr);
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x0000F2F6 File Offset: 0x0000D4F6
		public void EndRenderPass()
		{
			ScriptableRenderContext.EndRenderPass_Internal(this.m_Ptr);
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x0000F305 File Offset: 0x0000D505
		public void Submit()
		{
			this.Submit_Internal();
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x00069AB4 File Offset: 0x00067CB4
		public void ExecuteCommandBuffer(CommandBuffer commandBuffer)
		{
			bool flag = commandBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("commandBuffer");
			}
			this.ExecuteCommandBuffer_Internal(commandBuffer);
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x00069AE0 File Offset: 0x00067CE0
		public void ExecuteCommandBufferAsync(CommandBuffer commandBuffer, ComputeQueueType queueType)
		{
			bool flag = commandBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("commandBuffer");
			}
			this.ExecuteCommandBufferAsync_Internal(commandBuffer, queueType);
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x0000F30F File Offset: 0x0000D50F
		public void SetupCameraProperties(Camera camera, [Optional] bool stereoSetup)
		{
			this.SetupCameraProperties(camera, stereoSetup, 0);
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x0000F31C File Offset: 0x0000D51C
		public void SetupCameraProperties(Camera camera, bool stereoSetup, int eye)
		{
			this.SetupCameraProperties_Internal(camera, stereoSetup, eye);
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x0000F329 File Offset: 0x0000D529
		public void StereoEndRender(Camera camera)
		{
			this.StereoEndRender(camera, 0, true);
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x0000F336 File Offset: 0x0000D536
		public void StereoEndRender(Camera camera, int eye)
		{
			this.StereoEndRender(camera, eye, true);
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x0000F343 File Offset: 0x0000D543
		public void StereoEndRender(Camera camera, int eye, bool isFinalPass)
		{
			this.StereoEndRender_Internal(camera, eye, isFinalPass);
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x0000F350 File Offset: 0x0000D550
		public void StartMultiEye(Camera camera)
		{
			this.StartMultiEye(camera, 0);
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0000F35C File Offset: 0x0000D55C
		public void StartMultiEye(Camera camera, int eye)
		{
			this.StartMultiEye_Internal(camera, eye);
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x0000F368 File Offset: 0x0000D568
		public void StopMultiEye(Camera camera)
		{
			this.StopMultiEye_Internal(camera);
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0000F373 File Offset: 0x0000D573
		public void DrawSkybox(Camera camera)
		{
			this.DrawSkybox_Internal(camera);
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0000F37E File Offset: 0x0000D57E
		public void InvokeOnRenderObjectCallback()
		{
			this.InvokeOnRenderObjectCallback_Internal();
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x0000F388 File Offset: 0x0000D588
		public void DrawGizmos(Camera camera, GizmoSubset gizmoSubset)
		{
			this.DrawGizmos_Internal(camera, gizmoSubset);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x0000F394 File Offset: 0x0000D594
		public void DrawWireOverlay(Camera camera)
		{
			this.DrawWireOverlay_Impl(camera);
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0000F39F File Offset: 0x0000D59F
		public void DrawUIOverlay(Camera camera)
		{
			this.DrawUIOverlay_Internal(camera);
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0000F3AA File Offset: 0x0000D5AA
		public void Validate()
		{
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x00069B0C File Offset: 0x00067D0C
		public static bool operator ==(ScriptableRenderContext left, ScriptableRenderContext right)
		{
			return left.Equals(right);
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x00069B28 File Offset: 0x00067D28
		public static bool operator !=(ScriptableRenderContext left, ScriptableRenderContext right)
		{
			return !left.Equals(right);
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0000F3AD File Offset: 0x0000D5AD
		public static void Submit_Internal_Injected(ref ScriptableRenderContext _unity_self)
		{
			ScriptableRenderContext.Submit_Internal_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0000F3BA File Offset: 0x0000D5BA
		public static void DrawShadows_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr shadowDrawingSettings)
		{
			ScriptableRenderContext.DrawShadows_Internal_InjectedDelegateField(ref _unity_self, shadowDrawingSettings);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0000F3C8 File Offset: 0x0000D5C8
		public static void ExecuteCommandBuffer_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer)
		{
			ScriptableRenderContext.ExecuteCommandBuffer_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(commandBuffer));
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0000F3DB File Offset: 0x0000D5DB
		public static void ExecuteCommandBufferAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer, ComputeQueueType queueType)
		{
			ScriptableRenderContext.ExecuteCommandBufferAsync_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(commandBuffer), queueType);
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0000F3EF File Offset: 0x0000D5EF
		public static void SetupCameraProperties_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, bool stereoSetup, int eye)
		{
			ScriptableRenderContext.SetupCameraProperties_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera), stereoSetup, eye);
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0000F404 File Offset: 0x0000D604
		public static void StereoEndRender_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, int eye, bool isFinalPass)
		{
			ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera), eye, isFinalPass);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x0000F419 File Offset: 0x0000D619
		public static void StartMultiEye_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, int eye)
		{
			ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera), eye);
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0000F42D File Offset: 0x0000D62D
		public static void StopMultiEye_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
		{
			ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x0000F440 File Offset: 0x0000D640
		public static void DrawSkybox_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
		{
			ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x0000F453 File Offset: 0x0000D653
		public static void InvokeOnRenderObjectCallback_Internal_Injected(ref ScriptableRenderContext _unity_self)
		{
			ScriptableRenderContext.InvokeOnRenderObjectCallback_Internal_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0000F460 File Offset: 0x0000D660
		public static void DrawGizmos_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, GizmoSubset gizmoSubset)
		{
			ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera), gizmoSubset);
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0000F474 File Offset: 0x0000D674
		public static void DrawWireOverlay_Impl_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
		{
			ScriptableRenderContext.DrawWireOverlay_Impl_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0000F487 File Offset: 0x0000D687
		public static void DrawUIOverlay_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
		{
			ScriptableRenderContext.DrawUIOverlay_Internal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeFieldInfoPtr_kRenderTypeTag;

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberOfCameras_Internal_Private_Int32_0;

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeMethodInfoPtr_GetCamera_Internal_Private_Camera_Int32_0;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberOfCameras_Internal_Int32_0;

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeMethodInfoPtr_GetCamera_Internal_Camera_Int32_0;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableRenderContext_0;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberOfCameras_Internal_Injected_Private_Static_Int32_byref_ScriptableRenderContext_0;

		// Token: 0x040015F5 RID: 5621
		private static readonly IntPtr NativeMethodInfoPtr_GetCamera_Internal_Injected_Private_Static_Camera_byref_ScriptableRenderContext_Int32_0;

		// Token: 0x040015F6 RID: 5622
		[FieldOffset(0)]
		public IntPtr m_Ptr;

		// Token: 0x040015F7 RID: 5623
		private static readonly ScriptableRenderContext.BeginRenderPass_InternalDelegate BeginRenderPass_InternalDelegateField;

		// Token: 0x040015F8 RID: 5624
		private static readonly ScriptableRenderContext.BeginSubPass_InternalDelegate BeginSubPass_InternalDelegateField;

		// Token: 0x040015F9 RID: 5625
		private static readonly ScriptableRenderContext.EndSubPass_InternalDelegate EndSubPass_InternalDelegateField;

		// Token: 0x040015FA RID: 5626
		private static readonly ScriptableRenderContext.EndRenderPass_InternalDelegate EndRenderPass_InternalDelegateField;

		// Token: 0x040015FB RID: 5627
		private static readonly ScriptableRenderContext.InitializeSortSettingsDelegate InitializeSortSettingsDelegateField;

		// Token: 0x040015FC RID: 5628
		private static readonly ScriptableRenderContext.EmitGeometryForCameraDelegate EmitGeometryForCameraDelegateField;

		// Token: 0x040015FD RID: 5629
		private static readonly ScriptableRenderContext.Submit_Internal_InjectedDelegate Submit_Internal_InjectedDelegateField;

		// Token: 0x040015FE RID: 5630
		private static readonly ScriptableRenderContext.DrawShadows_Internal_InjectedDelegate DrawShadows_Internal_InjectedDelegateField;

		// Token: 0x040015FF RID: 5631
		private static readonly ScriptableRenderContext.ExecuteCommandBuffer_Internal_InjectedDelegate ExecuteCommandBuffer_Internal_InjectedDelegateField;

		// Token: 0x04001600 RID: 5632
		private static readonly ScriptableRenderContext.ExecuteCommandBufferAsync_Internal_InjectedDelegate ExecuteCommandBufferAsync_Internal_InjectedDelegateField;

		// Token: 0x04001601 RID: 5633
		private static readonly ScriptableRenderContext.SetupCameraProperties_Internal_InjectedDelegate SetupCameraProperties_Internal_InjectedDelegateField;

		// Token: 0x04001602 RID: 5634
		private static readonly ScriptableRenderContext.StereoEndRender_Internal_InjectedDelegate StereoEndRender_Internal_InjectedDelegateField;

		// Token: 0x04001603 RID: 5635
		private static readonly ScriptableRenderContext.StartMultiEye_Internal_InjectedDelegate StartMultiEye_Internal_InjectedDelegateField;

		// Token: 0x04001604 RID: 5636
		private static readonly ScriptableRenderContext.StopMultiEye_Internal_InjectedDelegate StopMultiEye_Internal_InjectedDelegateField;

		// Token: 0x04001605 RID: 5637
		private static readonly ScriptableRenderContext.DrawSkybox_Internal_InjectedDelegate DrawSkybox_Internal_InjectedDelegateField;

		// Token: 0x04001606 RID: 5638
		private static readonly ScriptableRenderContext.InvokeOnRenderObjectCallback_Internal_InjectedDelegate InvokeOnRenderObjectCallback_Internal_InjectedDelegateField;

		// Token: 0x04001607 RID: 5639
		private static readonly ScriptableRenderContext.DrawGizmos_Internal_InjectedDelegate DrawGizmos_Internal_InjectedDelegateField;

		// Token: 0x04001608 RID: 5640
		private static readonly ScriptableRenderContext.DrawWireOverlay_Impl_InjectedDelegate DrawWireOverlay_Impl_InjectedDelegateField;

		// Token: 0x04001609 RID: 5641
		private static readonly ScriptableRenderContext.DrawUIOverlay_Internal_InjectedDelegate DrawUIOverlay_Internal_InjectedDelegateField;

		// Token: 0x020009D6 RID: 2518
		// (Invoke) Token: 0x06003248 RID: 12872
		private delegate void BeginRenderPass_InternalDelegate(IntPtr self, int width, int height, int samples, IntPtr colors, int colorCount, int depthAttachmentIndex);

		// Token: 0x020009D7 RID: 2519
		// (Invoke) Token: 0x0600324A RID: 12874
		private delegate void BeginSubPass_InternalDelegate(IntPtr self, IntPtr colors, int colorCount, IntPtr inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly);

		// Token: 0x020009D8 RID: 2520
		// (Invoke) Token: 0x0600324C RID: 12876
		private delegate void EndSubPass_InternalDelegate(IntPtr self);

		// Token: 0x020009D9 RID: 2521
		// (Invoke) Token: 0x0600324E RID: 12878
		private delegate void EndRenderPass_InternalDelegate(IntPtr self);

		// Token: 0x020009DA RID: 2522
		// (Invoke) Token: 0x06003250 RID: 12880
		private delegate void InitializeSortSettingsDelegate(IntPtr camera, [Out] IntPtr sortingSettings);

		// Token: 0x020009DB RID: 2523
		// (Invoke) Token: 0x06003252 RID: 12882
		private delegate void EmitGeometryForCameraDelegate(IntPtr camera);

		// Token: 0x020009DC RID: 2524
		// (Invoke) Token: 0x06003254 RID: 12884
		private delegate void Submit_Internal_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009DD RID: 2525
		// (Invoke) Token: 0x06003256 RID: 12886
		private delegate void DrawShadows_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr shadowDrawingSettings);

		// Token: 0x020009DE RID: 2526
		// (Invoke) Token: 0x06003258 RID: 12888
		private delegate void ExecuteCommandBuffer_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr commandBuffer);

		// Token: 0x020009DF RID: 2527
		// (Invoke) Token: 0x0600325A RID: 12890
		private delegate void ExecuteCommandBufferAsync_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr commandBuffer, ComputeQueueType queueType);

		// Token: 0x020009E0 RID: 2528
		// (Invoke) Token: 0x0600325C RID: 12892
		private delegate void SetupCameraProperties_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera, bool stereoSetup, int eye);

		// Token: 0x020009E1 RID: 2529
		// (Invoke) Token: 0x0600325E RID: 12894
		private delegate void StereoEndRender_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera, int eye, bool isFinalPass);

		// Token: 0x020009E2 RID: 2530
		// (Invoke) Token: 0x06003260 RID: 12896
		private delegate void StartMultiEye_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera, int eye);

		// Token: 0x020009E3 RID: 2531
		// (Invoke) Token: 0x06003262 RID: 12898
		private delegate void StopMultiEye_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera);

		// Token: 0x020009E4 RID: 2532
		// (Invoke) Token: 0x06003264 RID: 12900
		private delegate void DrawSkybox_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera);

		// Token: 0x020009E5 RID: 2533
		// (Invoke) Token: 0x06003266 RID: 12902
		private delegate void InvokeOnRenderObjectCallback_Internal_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009E6 RID: 2534
		// (Invoke) Token: 0x06003268 RID: 12904
		private delegate void DrawGizmos_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera, GizmoSubset gizmoSubset);

		// Token: 0x020009E7 RID: 2535
		// (Invoke) Token: 0x0600326A RID: 12906
		private delegate void DrawWireOverlay_Impl_InjectedDelegate(IntPtr _unity_self, IntPtr camera);

		// Token: 0x020009E8 RID: 2536
		// (Invoke) Token: 0x0600326C RID: 12908
		private delegate void DrawUIOverlay_Internal_InjectedDelegate(IntPtr _unity_self, IntPtr camera);
	}
}
