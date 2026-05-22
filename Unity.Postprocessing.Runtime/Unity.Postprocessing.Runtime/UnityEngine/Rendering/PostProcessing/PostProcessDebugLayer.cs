using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200004E RID: 78
	[Serializable]
	public sealed class PostProcessDebugLayer : Object
	{
		// Token: 0x06000322 RID: 802 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessDebugLayer()
		{
			Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "PostProcessDebugLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr);
			PostProcessDebugLayer.NativeFieldInfoPtr_lightMeter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, "lightMeter");
			PostProcessDebugLayer.NativeFieldInfoPtr_histogram = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, "histogram");
			PostProcessDebugLayer.NativeFieldInfoPtr_waveform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, "waveform");
			PostProcessDebugLayer.NativeFieldInfoPtr_vectorscope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, "vectorscope");
			PostProcessDebugLayer.NativeFieldInfoPtr_m_Monitors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, "m_Monitors");
			PostProcessDebugLayer.NativeFieldInfoPtr_frameWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, "frameWidth");
			PostProcessDebugLayer.NativeFieldInfoPtr_frameHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, "frameHeight");
			PostProcessDebugLayer.NativeFieldInfoPtr__debugOverlayTarget_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, "<debugOverlayTarget>k__BackingField");
			PostProcessDebugLayer.NativeFieldInfoPtr__debugOverlayActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, "<debugOverlayActive>k__BackingField");
			PostProcessDebugLayer.NativeFieldInfoPtr__debugOverlay_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, "<debugOverlay>k__BackingField");
			PostProcessDebugLayer.NativeFieldInfoPtr_overlaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, "overlaySettings");
			PostProcessDebugLayer.NativeMethodInfoPtr_get_debugOverlayTarget_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663543);
			PostProcessDebugLayer.NativeMethodInfoPtr_set_debugOverlayTarget_Private_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663544);
			PostProcessDebugLayer.NativeMethodInfoPtr_get_debugOverlayActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663545);
			PostProcessDebugLayer.NativeMethodInfoPtr_set_debugOverlayActive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663546);
			PostProcessDebugLayer.NativeMethodInfoPtr_get_debugOverlay_Public_get_DebugOverlay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663547);
			PostProcessDebugLayer.NativeMethodInfoPtr_set_debugOverlay_Private_set_Void_DebugOverlay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663548);
			PostProcessDebugLayer.NativeMethodInfoPtr_OnEnable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663549);
			PostProcessDebugLayer.NativeMethodInfoPtr_OnDisable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663550);
			PostProcessDebugLayer.NativeMethodInfoPtr_DestroyDebugOverlayTarget_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663551);
			PostProcessDebugLayer.NativeMethodInfoPtr_RequestMonitorPass_Public_Void_MonitorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663552);
			PostProcessDebugLayer.NativeMethodInfoPtr_RequestDebugOverlay_Public_Void_DebugOverlay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663553);
			PostProcessDebugLayer.NativeMethodInfoPtr_SetFrameSize_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663554);
			PostProcessDebugLayer.NativeMethodInfoPtr_PushDebugOverlay_Public_Void_CommandBuffer_RenderTargetIdentifier_PropertySheet_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663555);
			PostProcessDebugLayer.NativeMethodInfoPtr_GetCameraFlags_Internal_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663556);
			PostProcessDebugLayer.NativeMethodInfoPtr_RenderMonitors_Internal_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663557);
			PostProcessDebugLayer.NativeMethodInfoPtr_RenderSpecialOverlays_Internal_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663558);
			PostProcessDebugLayer.NativeMethodInfoPtr_EndFrame_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663559);
			PostProcessDebugLayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, 100663560);
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0000FA6C File Offset: 0x0000DC6C
		// (set) Token: 0x06000324 RID: 804 RVA: 0x0000FAAC File Offset: 0x0000DCAC
		public unsafe RenderTexture debugOverlayTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_get_debugOverlayTarget_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_set_debugOverlayTarget_Private_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000FAF0 File Offset: 0x0000DCF0
		// (set) Token: 0x06000326 RID: 806 RVA: 0x0000FB2C File Offset: 0x0000DD2C
		public unsafe bool debugOverlayActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_get_debugOverlayActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_set_debugOverlayActive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000FB6C File Offset: 0x0000DD6C
		// (set) Token: 0x06000328 RID: 808 RVA: 0x0000FBA8 File Offset: 0x0000DDA8
		public unsafe DebugOverlay debugOverlay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_get_debugOverlay_Public_get_DebugOverlay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_set_debugOverlay_Private_set_Void_DebugOverlay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 446128, RefRangeEnd = 446129, XrefRangeStart = 446091, XrefRangeEnd = 446128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_OnEnable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000FC1C File Offset: 0x0000DE1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 446139, RefRangeEnd = 446140, XrefRangeStart = 446129, XrefRangeEnd = 446139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_OnDisable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000FC50 File Offset: 0x0000DE50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 446144, RefRangeEnd = 446146, XrefRangeStart = 446140, XrefRangeEnd = 446144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyDebugOverlayTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_DestroyDebugOverlayTarget_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000FC84 File Offset: 0x0000DE84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 446149, RefRangeEnd = 446153, XrefRangeStart = 446146, XrefRangeEnd = 446149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestMonitorPass(MonitorType monitor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref monitor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_RequestMonitorPass_Public_Void_MonitorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000FCC4 File Offset: 0x0000DEC4
		[CallerCount(0)]
		public unsafe void RequestDebugOverlay(DebugOverlay mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_RequestDebugOverlay_Public_Void_DebugOverlay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000FD04 File Offset: 0x0000DF04
		[CallerCount(0)]
		public unsafe void SetFrameSize(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_SetFrameSize_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000FD50 File Offset: 0x0000DF50
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 446197, RefRangeEnd = 446203, XrefRangeStart = 446153, XrefRangeEnd = 446197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sheet);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_PushDebugOverlay_Public_Void_CommandBuffer_RenderTargetIdentifier_PropertySheet_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000FDC0 File Offset: 0x0000DFC0
		[CallerCount(0)]
		public unsafe DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_GetCameraFlags_Internal_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000FDFC File Offset: 0x0000DFFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 446239, RefRangeEnd = 446240, XrefRangeStart = 446203, XrefRangeEnd = 446239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderMonitors(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_RenderMonitors_Internal_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000FE40 File Offset: 0x0000E040
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 446266, RefRangeEnd = 446267, XrefRangeStart = 446240, XrefRangeEnd = 446266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderSpecialOverlays(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_RenderSpecialOverlays_Internal_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000FE84 File Offset: 0x0000E084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 446277, RefRangeEnd = 446278, XrefRangeStart = 446267, XrefRangeEnd = 446277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr_EndFrame_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessDebugLayer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00003CB7 File Offset: 0x00001EB7
		public PostProcessDebugLayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000FEF4 File Offset: 0x0000E0F4
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00003CC0 File Offset: 0x00001EC0
		public unsafe LightMeterMonitor lightMeter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr_lightMeter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightMeterMonitor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr_lightMeter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000FF24 File Offset: 0x0000E124
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00003CDF File Offset: 0x00001EDF
		public unsafe HistogramMonitor histogram
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr_histogram);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HistogramMonitor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr_histogram), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000FF54 File Offset: 0x0000E154
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00003CFE File Offset: 0x00001EFE
		public unsafe WaveformMonitor waveform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr_waveform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaveformMonitor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr_waveform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0000FF84 File Offset: 0x0000E184
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00003D1D File Offset: 0x00001F1D
		public unsafe VectorscopeMonitor vectorscope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr_vectorscope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VectorscopeMonitor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr_vectorscope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000FFB4 File Offset: 0x0000E1B4
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00003D3C File Offset: 0x00001F3C
		public unsafe Dictionary<MonitorType, Monitor> m_Monitors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr_m_Monitors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<MonitorType, Monitor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr_m_Monitors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000FFE4 File Offset: 0x0000E1E4
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00003D5B File Offset: 0x00001F5B
		public unsafe int frameWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr_frameWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr_frameWidth)) = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0001000C File Offset: 0x0000E20C
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00003D76 File Offset: 0x00001F76
		public unsafe int frameHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr_frameHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr_frameHeight)) = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00010034 File Offset: 0x0000E234
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00003D91 File Offset: 0x00001F91
		public unsafe RenderTexture _debugOverlayTarget_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr__debugOverlayTarget_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr__debugOverlayTarget_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00010064 File Offset: 0x0000E264
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00003DB0 File Offset: 0x00001FB0
		public unsafe bool _debugOverlayActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr__debugOverlayActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr__debugOverlayActive_k__BackingField)) = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0001008C File Offset: 0x0000E28C
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00003DCB File Offset: 0x00001FCB
		public unsafe DebugOverlay _debugOverlay_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr__debugOverlay_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr__debugOverlay_k__BackingField)) = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600034A RID: 842 RVA: 0x000100B4 File Offset: 0x0000E2B4
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00003DE6 File Offset: 0x00001FE6
		public unsafe PostProcessDebugLayer.OverlaySettings overlaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr_overlaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessDebugLayer.OverlaySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.NativeFieldInfoPtr_overlaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr_lightMeter;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeFieldInfoPtr_histogram;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr_waveform;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr_vectorscope;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr_m_Monitors;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeFieldInfoPtr_frameWidth;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeFieldInfoPtr_frameHeight;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeFieldInfoPtr__debugOverlayTarget_k__BackingField;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeFieldInfoPtr__debugOverlayActive_k__BackingField;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeFieldInfoPtr__debugOverlay_k__BackingField;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeFieldInfoPtr_overlaySettings;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_get_debugOverlayTarget_Public_get_RenderTexture_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_set_debugOverlayTarget_Private_set_Void_RenderTexture_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_get_debugOverlayActive_Public_get_Boolean_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_set_debugOverlayActive_Private_set_Void_Boolean_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_get_debugOverlay_Public_get_DebugOverlay_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_set_debugOverlay_Private_set_Void_DebugOverlay_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Internal_Void_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Internal_Void_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDebugOverlayTarget_Private_Void_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_RequestMonitorPass_Public_Void_MonitorType_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_RequestDebugOverlay_Public_Void_DebugOverlay_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_SetFrameSize_Internal_Void_Int32_Int32_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_PushDebugOverlay_Public_Void_CommandBuffer_RenderTargetIdentifier_PropertySheet_Int32_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Internal_DepthTextureMode_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_RenderMonitors_Internal_Void_PostProcessRenderContext_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_RenderSpecialOverlays_Internal_Void_PostProcessRenderContext_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_EndFrame_Internal_Void_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200007A RID: 122
		[Serializable]
		public class OverlaySettings : Object
		{
			// Token: 0x060006D8 RID: 1752 RVA: 0x0001AA04 File Offset: 0x00018C04
			// Note: this type is marked as 'beforefieldinit'.
			static OverlaySettings()
			{
				Il2CppClassPointerStore<PostProcessDebugLayer.OverlaySettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessDebugLayer>.NativeClassPtr, "OverlaySettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessDebugLayer.OverlaySettings>.NativeClassPtr);
				PostProcessDebugLayer.OverlaySettings.NativeFieldInfoPtr_linearDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebugLayer.OverlaySettings>.NativeClassPtr, "linearDepth");
				PostProcessDebugLayer.OverlaySettings.NativeFieldInfoPtr_motionColorIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebugLayer.OverlaySettings>.NativeClassPtr, "motionColorIntensity");
				PostProcessDebugLayer.OverlaySettings.NativeFieldInfoPtr_motionGridSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebugLayer.OverlaySettings>.NativeClassPtr, "motionGridSize");
				PostProcessDebugLayer.OverlaySettings.NativeFieldInfoPtr_colorBlindnessType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebugLayer.OverlaySettings>.NativeClassPtr, "colorBlindnessType");
				PostProcessDebugLayer.OverlaySettings.NativeFieldInfoPtr_colorBlindnessStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebugLayer.OverlaySettings>.NativeClassPtr, "colorBlindnessStrength");
				PostProcessDebugLayer.OverlaySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebugLayer.OverlaySettings>.NativeClassPtr, 100663561);
			}

			// Token: 0x060006D9 RID: 1753 RVA: 0x0001AAA8 File Offset: 0x00018CA8
			[CallerCount(0)]
			public unsafe OverlaySettings()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessDebugLayer.OverlaySettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebugLayer.OverlaySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006DA RID: 1754 RVA: 0x00005698 File Offset: 0x00003898
			public OverlaySettings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000244 RID: 580
			// (get) Token: 0x060006DB RID: 1755 RVA: 0x0001AAE4 File Offset: 0x00018CE4
			// (set) Token: 0x060006DC RID: 1756 RVA: 0x000056A1 File Offset: 0x000038A1
			public unsafe bool linearDepth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.OverlaySettings.NativeFieldInfoPtr_linearDepth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.OverlaySettings.NativeFieldInfoPtr_linearDepth)) = value;
				}
			}

			// Token: 0x17000245 RID: 581
			// (get) Token: 0x060006DD RID: 1757 RVA: 0x0001AB0C File Offset: 0x00018D0C
			// (set) Token: 0x060006DE RID: 1758 RVA: 0x000056BC File Offset: 0x000038BC
			public unsafe float motionColorIntensity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.OverlaySettings.NativeFieldInfoPtr_motionColorIntensity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.OverlaySettings.NativeFieldInfoPtr_motionColorIntensity)) = value;
				}
			}

			// Token: 0x17000246 RID: 582
			// (get) Token: 0x060006DF RID: 1759 RVA: 0x0001AB34 File Offset: 0x00018D34
			// (set) Token: 0x060006E0 RID: 1760 RVA: 0x000056D7 File Offset: 0x000038D7
			public unsafe int motionGridSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.OverlaySettings.NativeFieldInfoPtr_motionGridSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.OverlaySettings.NativeFieldInfoPtr_motionGridSize)) = value;
				}
			}

			// Token: 0x17000247 RID: 583
			// (get) Token: 0x060006E1 RID: 1761 RVA: 0x0001AB5C File Offset: 0x00018D5C
			// (set) Token: 0x060006E2 RID: 1762 RVA: 0x000056F2 File Offset: 0x000038F2
			public unsafe ColorBlindnessType colorBlindnessType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.OverlaySettings.NativeFieldInfoPtr_colorBlindnessType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.OverlaySettings.NativeFieldInfoPtr_colorBlindnessType)) = value;
				}
			}

			// Token: 0x17000248 RID: 584
			// (get) Token: 0x060006E3 RID: 1763 RVA: 0x0001AB84 File Offset: 0x00018D84
			// (set) Token: 0x060006E4 RID: 1764 RVA: 0x0000570D File Offset: 0x0000390D
			public unsafe float colorBlindnessStrength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.OverlaySettings.NativeFieldInfoPtr_colorBlindnessStrength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebugLayer.OverlaySettings.NativeFieldInfoPtr_colorBlindnessStrength)) = value;
				}
			}

			// Token: 0x040004BF RID: 1215
			private static readonly IntPtr NativeFieldInfoPtr_linearDepth;

			// Token: 0x040004C0 RID: 1216
			private static readonly IntPtr NativeFieldInfoPtr_motionColorIntensity;

			// Token: 0x040004C1 RID: 1217
			private static readonly IntPtr NativeFieldInfoPtr_motionGridSize;

			// Token: 0x040004C2 RID: 1218
			private static readonly IntPtr NativeFieldInfoPtr_colorBlindnessType;

			// Token: 0x040004C3 RID: 1219
			private static readonly IntPtr NativeFieldInfoPtr_colorBlindnessStrength;

			// Token: 0x040004C4 RID: 1220
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
