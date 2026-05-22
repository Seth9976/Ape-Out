using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;
using UnityEngine.Rendering;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000009 RID: 9
	public class Utility : Object
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00004240 File Offset: 0x00002440
		// Note: this type is marked as 'beforefieldinit'.
		static Utility()
		{
			Il2CppClassPointerStore<Utility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsNativeModule.dll", "UnityEngine.UIElements.UIR", "Utility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utility>.NativeClassPtr);
			Utility.NativeFieldInfoPtr_GraphicsResourcesRecreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "GraphicsResourcesRecreate");
			Utility.NativeFieldInfoPtr_EngineUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "EngineUpdate");
			Utility.NativeFieldInfoPtr_FlushPendingResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "FlushPendingResources");
			Utility.NativeFieldInfoPtr_RegisterIntermediateRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "RegisterIntermediateRenderers");
			Utility.NativeFieldInfoPtr_RenderNodeAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "RenderNodeAdd");
			Utility.NativeFieldInfoPtr_RenderNodeExecute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "RenderNodeExecute");
			Utility.NativeFieldInfoPtr_RenderNodeCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "RenderNodeCleanup");
			Utility.NativeFieldInfoPtr_s_MarkerRaiseEngineUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "s_MarkerRaiseEngineUpdate");
			Utility.NativeMethodInfoPtr_RaiseGraphicsResourcesRecreate_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100663311);
			Utility.NativeMethodInfoPtr_RaiseEngineUpdate_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100663312);
			Utility.NativeMethodInfoPtr_RaiseFlushPendingResources_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100663313);
			Utility.NativeMethodInfoPtr_RaiseRegisterIntermediateRenderers_Internal_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100663314);
			Utility.NativeMethodInfoPtr_RaiseRenderNodeAdd_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100663315);
			Utility.NativeMethodInfoPtr_RaiseRenderNodeExecute_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100663316);
			Utility.NativeMethodInfoPtr_RaiseRenderNodeCleanup_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100663317);
			Utility.AllocateBufferDelegateField = IL2CPP.ResolveICall<Utility.AllocateBufferDelegate>("UnityEngine.UIElements.UIR.Utility::AllocateBuffer");
			Utility.FreeBufferDelegateField = IL2CPP.ResolveICall<Utility.FreeBufferDelegate>("UnityEngine.UIElements.UIR.Utility::FreeBuffer");
			Utility.UpdateBufferRangesDelegateField = IL2CPP.ResolveICall<Utility.UpdateBufferRangesDelegate>("UnityEngine.UIElements.UIR.Utility::UpdateBufferRanges");
			Utility.SetVectorArrayDelegateField = IL2CPP.ResolveICall<Utility.SetVectorArrayDelegate>("UnityEngine.UIElements.UIR.Utility::SetVectorArray");
			Utility.GetVertexDeclarationDelegateField = IL2CPP.ResolveICall<Utility.GetVertexDeclarationDelegate>("UnityEngine.UIElements.UIR.Utility::GetVertexDeclaration");
			Utility.DrawRangesDelegateField = IL2CPP.ResolveICall<Utility.DrawRangesDelegate>("UnityEngine.UIElements.UIR.Utility::DrawRanges");
			Utility.SetPropertyBlockDelegateField = IL2CPP.ResolveICall<Utility.SetPropertyBlockDelegate>("UnityEngine.UIElements.UIR.Utility::SetPropertyBlock");
			Utility.DisableScissorDelegateField = IL2CPP.ResolveICall<Utility.DisableScissorDelegate>("UnityEngine.UIElements.UIR.Utility::DisableScissor");
			Utility.IsScissorEnabledDelegateField = IL2CPP.ResolveICall<Utility.IsScissorEnabledDelegate>("UnityEngine.UIElements.UIR.Utility::IsScissorEnabled");
			Utility.InsertCPUFenceDelegateField = IL2CPP.ResolveICall<Utility.InsertCPUFenceDelegate>("UnityEngine.UIElements.UIR.Utility::InsertCPUFence");
			Utility.CPUFencePassedDelegateField = IL2CPP.ResolveICall<Utility.CPUFencePassedDelegate>("UnityEngine.UIElements.UIR.Utility::CPUFencePassed");
			Utility.WaitForCPUFencePassedDelegateField = IL2CPP.ResolveICall<Utility.WaitForCPUFencePassedDelegate>("UnityEngine.UIElements.UIR.Utility::WaitForCPUFencePassed");
			Utility.SyncRenderThreadDelegateField = IL2CPP.ResolveICall<Utility.SyncRenderThreadDelegate>("UnityEngine.UIElements.UIR.Utility::SyncRenderThread");
			Utility.ProfileDrawChainBeginDelegateField = IL2CPP.ResolveICall<Utility.ProfileDrawChainBeginDelegate>("UnityEngine.UIElements.UIR.Utility::ProfileDrawChainBegin");
			Utility.ProfileDrawChainEndDelegateField = IL2CPP.ResolveICall<Utility.ProfileDrawChainEndDelegate>("UnityEngine.UIElements.UIR.Utility::ProfileDrawChainEnd");
			Utility.ProfileImmediateRendererBeginDelegateField = IL2CPP.ResolveICall<Utility.ProfileImmediateRendererBeginDelegate>("UnityEngine.UIElements.UIR.Utility::ProfileImmediateRendererBegin");
			Utility.ProfileImmediateRendererEndDelegateField = IL2CPP.ResolveICall<Utility.ProfileImmediateRendererEndDelegate>("UnityEngine.UIElements.UIR.Utility::ProfileImmediateRendererEnd");
			Utility.NotifyOfUIREventsDelegateField = IL2CPP.ResolveICall<Utility.NotifyOfUIREventsDelegate>("UnityEngine.UIElements.UIR.Utility::NotifyOfUIREvents");
			Utility.DebugIsMainThreadDelegateField = IL2CPP.ResolveICall<Utility.DebugIsMainThreadDelegate>("UnityEngine.UIElements.UIR.Utility::DebugIsMainThread");
			Utility.RegisterIntermediateRenderer_InjectedDelegateField = IL2CPP.ResolveICall<Utility.RegisterIntermediateRenderer_InjectedDelegate>("UnityEngine.UIElements.UIR.Utility::RegisterIntermediateRenderer_Injected");
			Utility.SetScissorRect_InjectedDelegateField = IL2CPP.ResolveICall<Utility.SetScissorRect_InjectedDelegate>("UnityEngine.UIElements.UIR.Utility::SetScissorRect_Injected");
			Utility.GetActiveViewport_InjectedDelegateField = IL2CPP.ResolveICall<Utility.GetActiveViewport_InjectedDelegate>("UnityEngine.UIElements.UIR.Utility::GetActiveViewport_Injected");
			Utility.GetUnityProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Utility.GetUnityProjectionMatrix_InjectedDelegate>("UnityEngine.UIElements.UIR.Utility::GetUnityProjectionMatrix_Injected");
			Utility.GetDeviceProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Utility.GetDeviceProjectionMatrix_InjectedDelegate>("UnityEngine.UIElements.UIR.Utility::GetDeviceProjectionMatrix_Injected");
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004504 File Offset: 0x00002704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533451, XrefRangeEnd = 533458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseGraphicsResourcesRecreate(bool recreate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recreate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseGraphicsResourcesRecreate_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00004538 File Offset: 0x00002738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533458, XrefRangeEnd = 533465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseEngineUpdate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseEngineUpdate_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004560 File Offset: 0x00002760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533465, XrefRangeEnd = 533470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseFlushPendingResources()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseFlushPendingResources_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004588 File Offset: 0x00002788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533470, XrefRangeEnd = 533477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseRegisterIntermediateRenderers(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseRegisterIntermediateRenderers_Internal_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000045C0 File Offset: 0x000027C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533477, XrefRangeEnd = 533484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseRenderNodeAdd(IntPtr userData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseRenderNodeAdd_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000045F4 File Offset: 0x000027F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533484, XrefRangeEnd = 533491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseRenderNodeExecute(IntPtr userData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseRenderNodeExecute_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00004628 File Offset: 0x00002828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533491, XrefRangeEnd = 533498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RaiseRenderNodeCleanup(IntPtr userData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_RaiseRenderNodeCleanup_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000028F4 File Offset: 0x00000AF4
		public Utility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000465C File Offset: 0x0000285C
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x000028FD File Offset: 0x00000AFD
		public unsafe static Action<bool> GraphicsResourcesRecreate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_GraphicsResourcesRecreate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_GraphicsResourcesRecreate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00004684 File Offset: 0x00002884
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000290F File Offset: 0x00000B0F
		public unsafe static Action EngineUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_EngineUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_EngineUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000046AC File Offset: 0x000028AC
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002921 File Offset: 0x00000B21
		public unsafe static Action FlushPendingResources
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_FlushPendingResources, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_FlushPendingResources, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000046D4 File Offset: 0x000028D4
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00002933 File Offset: 0x00000B33
		public unsafe static Action<Camera> RegisterIntermediateRenderers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_RegisterIntermediateRenderers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Camera>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_RegisterIntermediateRenderers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000046FC File Offset: 0x000028FC
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002945 File Offset: 0x00000B45
		public unsafe static Action<IntPtr> RenderNodeAdd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_RenderNodeAdd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IntPtr>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_RenderNodeAdd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00004724 File Offset: 0x00002924
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002957 File Offset: 0x00000B57
		public unsafe static Action<IntPtr> RenderNodeExecute
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_RenderNodeExecute, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IntPtr>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_RenderNodeExecute, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000474C File Offset: 0x0000294C
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002969 File Offset: 0x00000B69
		public unsafe static Action<IntPtr> RenderNodeCleanup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_RenderNodeCleanup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IntPtr>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_RenderNodeCleanup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00004774 File Offset: 0x00002974
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0000297B File Offset: 0x00000B7B
		public unsafe static ProfilerMarker s_MarkerRaiseEngineUpdate
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_s_MarkerRaiseEngineUpdate, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_s_MarkerRaiseEngineUpdate, (void*)(&value));
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004790 File Offset: 0x00002990
		public static void SetVectorArray<T>(MaterialPropertyBlock props, int name, NativeSlice<T> vector4s) where T : struct
		{
			int num = vector4s.Length * vector4s.Stride / 16;
			Utility.SetVectorArray(props, name, new IntPtr(NativeSliceUnsafeUtility.GetUnsafePtr<T>(vector4s)), num);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002989 File Offset: 0x00000B89
		public static void add_GraphicsResourcesRecreate(Action<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002996 File Offset: 0x00000B96
		public static void remove_GraphicsResourcesRecreate(Action<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000029A3 File Offset: 0x00000BA3
		public static void add_RegisterIntermediateRenderers(Action<Camera> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000029B0 File Offset: 0x00000BB0
		public static void remove_RegisterIntermediateRenderers(Action<Camera> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000029BD File Offset: 0x00000BBD
		public static void add_RenderNodeAdd(Action<IntPtr> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000029CA File Offset: 0x00000BCA
		public static void remove_RenderNodeAdd(Action<IntPtr> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000029D7 File Offset: 0x00000BD7
		public static void add_RenderNodeExecute(Action<IntPtr> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000029E4 File Offset: 0x00000BE4
		public static void remove_RenderNodeExecute(Action<IntPtr> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000029F1 File Offset: 0x00000BF1
		public static void add_RenderNodeCleanup(Action<IntPtr> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000029FE File Offset: 0x00000BFE
		public static void remove_RenderNodeCleanup(Action<IntPtr> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002A0B File Offset: 0x00000C0B
		public static IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer)
		{
			return Utility.AllocateBufferDelegateField(elementCount, elementStride, vertexBuffer);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002A1A File Offset: 0x00000C1A
		public static void FreeBuffer(IntPtr buffer)
		{
			Utility.FreeBufferDelegateField(buffer);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002A27 File Offset: 0x00000C27
		public static void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd)
		{
			Utility.UpdateBufferRangesDelegateField(buffer, ranges, rangeCount, writeRangeStart, writeRangeEnd);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002A39 File Offset: 0x00000C39
		public static void SetVectorArray(MaterialPropertyBlock props, int name, IntPtr vector4s, int count)
		{
			Utility.SetVectorArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(props), name, vector4s, count);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002A4E File Offset: 0x00000C4E
		public static IntPtr GetVertexDeclaration(Il2CppStructArray<VertexAttributeDescriptor> vertexAttributes)
		{
			return Utility.GetVertexDeclarationDelegateField(IL2CPP.Il2CppObjectBaseToPtr(vertexAttributes));
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000047C8 File Offset: 0x000029C8
		public static void RegisterIntermediateRenderer(Camera camera, Material material, Matrix4x4 transform, Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize)
		{
			Utility.RegisterIntermediateRenderer_Injected(camera, material, ref transform, ref aabb, renderLayer, shadowCasting, receiveShadows, sameDistanceSortPriority, sceneCullingMask, rendererCallbackFlags, userData, userDataSize);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002A60 File Offset: 0x00000C60
		public unsafe static void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl)
		{
			Utility.DrawRangesDelegateField(ib, vertexStreams, streamCount, ranges, rangeCount, vertexDecl);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002A74 File Offset: 0x00000C74
		public static void SetPropertyBlock(MaterialPropertyBlock props)
		{
			Utility.SetPropertyBlockDelegateField(IL2CPP.Il2CppObjectBaseToPtr(props));
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002A86 File Offset: 0x00000C86
		public static void SetScissorRect(RectInt scissorRect)
		{
			Utility.SetScissorRect_Injected(ref scissorRect);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002A8F File Offset: 0x00000C8F
		public static void DisableScissor()
		{
			Utility.DisableScissorDelegateField();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002A9B File Offset: 0x00000C9B
		public static bool IsScissorEnabled()
		{
			return Utility.IsScissorEnabledDelegateField();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002AA7 File Offset: 0x00000CA7
		public static uint InsertCPUFence()
		{
			return Utility.InsertCPUFenceDelegateField();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002AB3 File Offset: 0x00000CB3
		public static bool CPUFencePassed(uint fence)
		{
			return Utility.CPUFencePassedDelegateField(fence);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002AC0 File Offset: 0x00000CC0
		public static void WaitForCPUFencePassed(uint fence)
		{
			Utility.WaitForCPUFencePassedDelegateField(fence);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002ACD File Offset: 0x00000CCD
		public static void SyncRenderThread()
		{
			Utility.SyncRenderThreadDelegateField();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000047F0 File Offset: 0x000029F0
		public static RectInt GetActiveViewport()
		{
			RectInt rectInt;
			Utility.GetActiveViewport_Injected(out rectInt);
			return rectInt;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002AD9 File Offset: 0x00000CD9
		public static void ProfileDrawChainBegin()
		{
			Utility.ProfileDrawChainBeginDelegateField();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002AE5 File Offset: 0x00000CE5
		public static void ProfileDrawChainEnd()
		{
			Utility.ProfileDrawChainEndDelegateField();
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002AF1 File Offset: 0x00000CF1
		public static void ProfileImmediateRendererBegin()
		{
			Utility.ProfileImmediateRendererBeginDelegateField();
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002AFD File Offset: 0x00000CFD
		public static void ProfileImmediateRendererEnd()
		{
			Utility.ProfileImmediateRendererEndDelegateField();
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002B09 File Offset: 0x00000D09
		public static void NotifyOfUIREvents(bool subscribe)
		{
			Utility.NotifyOfUIREventsDelegateField(subscribe);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00004808 File Offset: 0x00002A08
		public static Matrix4x4 GetUnityProjectionMatrix()
		{
			Matrix4x4 matrix4x;
			Utility.GetUnityProjectionMatrix_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00004820 File Offset: 0x00002A20
		public static Matrix4x4 GetDeviceProjectionMatrix()
		{
			Matrix4x4 matrix4x;
			Utility.GetDeviceProjectionMatrix_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002B16 File Offset: 0x00000D16
		public static bool DebugIsMainThread()
		{
			return Utility.DebugIsMainThreadDelegateField();
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00004838 File Offset: 0x00002A38
		public static void RegisterIntermediateRenderer_Injected(Camera camera, Material material, ref Matrix4x4 transform, ref Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize)
		{
			Utility.RegisterIntermediateRenderer_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(material), ref transform, ref aabb, renderLayer, shadowCasting, receiveShadows, sameDistanceSortPriority, sceneCullingMask, rendererCallbackFlags, userData, userDataSize);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002B22 File Offset: 0x00000D22
		public static void SetScissorRect_Injected(ref RectInt scissorRect)
		{
			Utility.SetScissorRect_InjectedDelegateField(ref scissorRect);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002B2F File Offset: 0x00000D2F
		public static void GetActiveViewport_Injected(out RectInt ret)
		{
			Utility.GetActiveViewport_InjectedDelegateField(out ret);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002B3C File Offset: 0x00000D3C
		public static void GetUnityProjectionMatrix_Injected(out Matrix4x4 ret)
		{
			Utility.GetUnityProjectionMatrix_InjectedDelegateField(out ret);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002B49 File Offset: 0x00000D49
		public static void GetDeviceProjectionMatrix_Injected(out Matrix4x4 ret)
		{
			Utility.GetDeviceProjectionMatrix_InjectedDelegateField(out ret);
		}

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_GraphicsResourcesRecreate;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_EngineUpdate;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_FlushPendingResources;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_RegisterIntermediateRenderers;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_RenderNodeAdd;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_RenderNodeExecute;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_RenderNodeCleanup;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerRaiseEngineUpdate;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_RaiseGraphicsResourcesRecreate_Internal_Static_Void_Boolean_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_RaiseEngineUpdate_Internal_Static_Void_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_RaiseFlushPendingResources_Internal_Static_Void_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_RaiseRegisterIntermediateRenderers_Internal_Static_Void_Camera_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_RaiseRenderNodeAdd_Internal_Static_Void_IntPtr_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_RaiseRenderNodeExecute_Internal_Static_Void_IntPtr_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_RaiseRenderNodeCleanup_Internal_Static_Void_IntPtr_0;

		// Token: 0x0400008A RID: 138
		private static readonly Utility.AllocateBufferDelegate AllocateBufferDelegateField;

		// Token: 0x0400008B RID: 139
		private static readonly Utility.FreeBufferDelegate FreeBufferDelegateField;

		// Token: 0x0400008C RID: 140
		private static readonly Utility.UpdateBufferRangesDelegate UpdateBufferRangesDelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly Utility.SetVectorArrayDelegate SetVectorArrayDelegateField;

		// Token: 0x0400008E RID: 142
		private static readonly Utility.GetVertexDeclarationDelegate GetVertexDeclarationDelegateField;

		// Token: 0x0400008F RID: 143
		private static readonly Utility.DrawRangesDelegate DrawRangesDelegateField;

		// Token: 0x04000090 RID: 144
		private static readonly Utility.SetPropertyBlockDelegate SetPropertyBlockDelegateField;

		// Token: 0x04000091 RID: 145
		private static readonly Utility.DisableScissorDelegate DisableScissorDelegateField;

		// Token: 0x04000092 RID: 146
		private static readonly Utility.IsScissorEnabledDelegate IsScissorEnabledDelegateField;

		// Token: 0x04000093 RID: 147
		private static readonly Utility.InsertCPUFenceDelegate InsertCPUFenceDelegateField;

		// Token: 0x04000094 RID: 148
		private static readonly Utility.CPUFencePassedDelegate CPUFencePassedDelegateField;

		// Token: 0x04000095 RID: 149
		private static readonly Utility.WaitForCPUFencePassedDelegate WaitForCPUFencePassedDelegateField;

		// Token: 0x04000096 RID: 150
		private static readonly Utility.SyncRenderThreadDelegate SyncRenderThreadDelegateField;

		// Token: 0x04000097 RID: 151
		private static readonly Utility.ProfileDrawChainBeginDelegate ProfileDrawChainBeginDelegateField;

		// Token: 0x04000098 RID: 152
		private static readonly Utility.ProfileDrawChainEndDelegate ProfileDrawChainEndDelegateField;

		// Token: 0x04000099 RID: 153
		private static readonly Utility.ProfileImmediateRendererBeginDelegate ProfileImmediateRendererBeginDelegateField;

		// Token: 0x0400009A RID: 154
		private static readonly Utility.ProfileImmediateRendererEndDelegate ProfileImmediateRendererEndDelegateField;

		// Token: 0x0400009B RID: 155
		private static readonly Utility.NotifyOfUIREventsDelegate NotifyOfUIREventsDelegateField;

		// Token: 0x0400009C RID: 156
		private static readonly Utility.DebugIsMainThreadDelegate DebugIsMainThreadDelegateField;

		// Token: 0x0400009D RID: 157
		private static readonly Utility.RegisterIntermediateRenderer_InjectedDelegate RegisterIntermediateRenderer_InjectedDelegateField;

		// Token: 0x0400009E RID: 158
		private static readonly Utility.SetScissorRect_InjectedDelegate SetScissorRect_InjectedDelegateField;

		// Token: 0x0400009F RID: 159
		private static readonly Utility.GetActiveViewport_InjectedDelegate GetActiveViewport_InjectedDelegateField;

		// Token: 0x040000A0 RID: 160
		private static readonly Utility.GetUnityProjectionMatrix_InjectedDelegate GetUnityProjectionMatrix_InjectedDelegateField;

		// Token: 0x040000A1 RID: 161
		private static readonly Utility.GetDeviceProjectionMatrix_InjectedDelegate GetDeviceProjectionMatrix_InjectedDelegateField;

		// Token: 0x02000080 RID: 128
		public class GPUBuffer<T> : Object where T : new()
		{
			// Token: 0x060001FA RID: 506 RVA: 0x000049E0 File Offset: 0x00002BE0
			// Note: this type is marked as 'beforefieldinit'.
			static GPUBuffer()
			{
				Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Utility>.NativeClassPtr, "GPUBuffer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr);
				Utility.GPUBuffer<T>.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility.GPUBuffer<T>>.NativeClassPtr, "buffer");
			}

			// Token: 0x060001FB RID: 507 RVA: 0x00002C0C File Offset: 0x00000E0C
			public GPUBuffer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060001FC RID: 508 RVA: 0x00004A5C File Offset: 0x00002C5C
			// (set) Token: 0x060001FD RID: 509 RVA: 0x00002C15 File Offset: 0x00000E15
			public unsafe IntPtr buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Utility.GPUBuffer<T>.NativeFieldInfoPtr_buffer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Utility.GPUBuffer<T>.NativeFieldInfoPtr_buffer)) = value;
				}
			}

			// Token: 0x040000F1 RID: 241
			private static readonly IntPtr NativeFieldInfoPtr_buffer;
		}

		// Token: 0x02000081 RID: 129
		public enum RendererCallbacks
		{
			// Token: 0x040000F3 RID: 243
			RendererCallback_Init = 1,
			// Token: 0x040000F4 RID: 244
			RendererCallback_Exec,
			// Token: 0x040000F5 RID: 245
			RendererCallback_Cleanup = 4
		}

		// Token: 0x02000082 RID: 130
		public enum GPUBufferType
		{
			// Token: 0x040000F7 RID: 247
			Vertex,
			// Token: 0x040000F8 RID: 248
			Index
		}

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060001FF RID: 511
		private delegate IntPtr AllocateBufferDelegate(int elementCount, int elementStride, bool vertexBuffer);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x06000201 RID: 513
		private delegate void FreeBufferDelegate(IntPtr buffer);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x06000203 RID: 515
		private delegate void UpdateBufferRangesDelegate(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x06000205 RID: 517
		private delegate void SetVectorArrayDelegate(IntPtr props, int name, IntPtr vector4s, int count);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x06000207 RID: 519
		private delegate IntPtr GetVertexDeclarationDelegate(IntPtr vertexAttributes);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x06000209 RID: 521
		private delegate void DrawRangesDelegate(IntPtr ib, IntPtr vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x0600020B RID: 523
		private delegate void SetPropertyBlockDelegate(IntPtr props);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x0600020D RID: 525
		private delegate void DisableScissorDelegate();

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x0600020F RID: 527
		private delegate bool IsScissorEnabledDelegate();

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x06000211 RID: 529
		private delegate uint InsertCPUFenceDelegate();

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x06000213 RID: 531
		private delegate bool CPUFencePassedDelegate(uint fence);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x06000215 RID: 533
		private delegate void WaitForCPUFencePassedDelegate(uint fence);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x06000217 RID: 535
		private delegate void SyncRenderThreadDelegate();

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x06000219 RID: 537
		private delegate void ProfileDrawChainBeginDelegate();

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x0600021B RID: 539
		private delegate void ProfileDrawChainEndDelegate();

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x0600021D RID: 541
		private delegate void ProfileImmediateRendererBeginDelegate();

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x0600021F RID: 543
		private delegate void ProfileImmediateRendererEndDelegate();

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x06000221 RID: 545
		private delegate void NotifyOfUIREventsDelegate(bool subscribe);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x06000223 RID: 547
		private delegate bool DebugIsMainThreadDelegate();

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06000225 RID: 549
		private delegate void RegisterIntermediateRenderer_InjectedDelegate(IntPtr camera, IntPtr material, IntPtr transform, IntPtr aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x06000227 RID: 551
		private delegate void SetScissorRect_InjectedDelegate(IntPtr scissorRect);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x06000229 RID: 553
		private delegate void GetActiveViewport_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x0600022B RID: 555
		private delegate void GetUnityProjectionMatrix_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x0600022D RID: 557
		private delegate void GetDeviceProjectionMatrix_InjectedDelegate([Out] IntPtr ret);
	}
}
