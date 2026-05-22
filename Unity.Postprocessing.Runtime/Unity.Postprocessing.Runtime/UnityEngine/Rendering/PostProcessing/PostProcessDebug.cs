using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200004B RID: 75
	public sealed class PostProcessDebug : MonoBehaviour
	{
		// Token: 0x06000305 RID: 773 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessDebug()
		{
			Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "PostProcessDebug");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr);
			PostProcessDebug.NativeFieldInfoPtr_postProcessLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, "postProcessLayer");
			PostProcessDebug.NativeFieldInfoPtr_m_PreviousPostProcessLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, "m_PreviousPostProcessLayer");
			PostProcessDebug.NativeFieldInfoPtr_lightMeter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, "lightMeter");
			PostProcessDebug.NativeFieldInfoPtr_histogram = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, "histogram");
			PostProcessDebug.NativeFieldInfoPtr_waveform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, "waveform");
			PostProcessDebug.NativeFieldInfoPtr_vectorscope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, "vectorscope");
			PostProcessDebug.NativeFieldInfoPtr_debugOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, "debugOverlay");
			PostProcessDebug.NativeFieldInfoPtr_m_CurrentCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, "m_CurrentCamera");
			PostProcessDebug.NativeFieldInfoPtr_m_CmdAfterEverything = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, "m_CmdAfterEverything");
			PostProcessDebug.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, 100663534);
			PostProcessDebug.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, 100663535);
			PostProcessDebug.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, 100663536);
			PostProcessDebug.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, 100663537);
			PostProcessDebug.NativeMethodInfoPtr_UpdateStates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, 100663538);
			PostProcessDebug.NativeMethodInfoPtr_OnPostRender_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, 100663539);
			PostProcessDebug.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, 100663540);
			PostProcessDebug.NativeMethodInfoPtr_DrawMonitor_Private_Void_byref_Rect_Monitor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, 100663541);
			PostProcessDebug.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr, 100663542);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000F468 File Offset: 0x0000D668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445934, XrefRangeEnd = 445943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebug.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000F49C File Offset: 0x0000D69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445943, XrefRangeEnd = 445956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebug.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000F4D0 File Offset: 0x0000D6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445956, XrefRangeEnd = 445957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebug.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000F504 File Offset: 0x0000D704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445957, XrefRangeEnd = 445960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebug.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000F538 File Offset: 0x0000D738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 446027, RefRangeEnd = 446028, XrefRangeStart = 445960, XrefRangeEnd = 446027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebug.NativeMethodInfoPtr_UpdateStates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000F56C File Offset: 0x0000D76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446028, XrefRangeEnd = 446051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPostRender()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebug.NativeMethodInfoPtr_OnPostRender_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446051, XrefRangeEnd = 446071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebug.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000F5D4 File Offset: 0x0000D7D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 446087, RefRangeEnd = 446091, XrefRangeStart = 446071, XrefRangeEnd = 446087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawMonitor(ref Rect rect, Monitor monitor, bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(monitor);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebug.NativeMethodInfoPtr_DrawMonitor_Private_Void_byref_Rect_Monitor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000F634 File Offset: 0x0000D834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessDebug()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessDebug>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessDebug.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00003BAB File Offset: 0x00001DAB
		public PostProcessDebug(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0000F670 File Offset: 0x0000D870
		// (set) Token: 0x06000311 RID: 785 RVA: 0x00003BB4 File Offset: 0x00001DB4
		public unsafe PostProcessLayer postProcessLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_postProcessLayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessLayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_postProcessLayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0000F6A0 File Offset: 0x0000D8A0
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00003BD3 File Offset: 0x00001DD3
		public unsafe PostProcessLayer m_PreviousPostProcessLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_m_PreviousPostProcessLayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessLayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_m_PreviousPostProcessLayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0000F6D0 File Offset: 0x0000D8D0
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00003BF2 File Offset: 0x00001DF2
		public unsafe bool lightMeter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_lightMeter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_lightMeter)) = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0000F6F8 File Offset: 0x0000D8F8
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00003C0D File Offset: 0x00001E0D
		public unsafe bool histogram
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_histogram);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_histogram)) = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0000F720 File Offset: 0x0000D920
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00003C28 File Offset: 0x00001E28
		public unsafe bool waveform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_waveform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_waveform)) = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0000F748 File Offset: 0x0000D948
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00003C43 File Offset: 0x00001E43
		public unsafe bool vectorscope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_vectorscope);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_vectorscope)) = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0000F770 File Offset: 0x0000D970
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00003C5E File Offset: 0x00001E5E
		public unsafe DebugOverlay debugOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_debugOverlay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_debugOverlay)) = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0000F798 File Offset: 0x0000D998
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00003C79 File Offset: 0x00001E79
		public unsafe Camera m_CurrentCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_m_CurrentCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_m_CurrentCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00003C98 File Offset: 0x00001E98
		public unsafe CommandBuffer m_CmdAfterEverything
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_m_CmdAfterEverything);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessDebug.NativeFieldInfoPtr_m_CmdAfterEverything), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeFieldInfoPtr_postProcessLayer;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousPostProcessLayer;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr_lightMeter;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeFieldInfoPtr_histogram;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr_waveform;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr_vectorscope;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_debugOverlay;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentCamera;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr_m_CmdAfterEverything;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStates_Private_Void_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_OnPostRender_Private_Void_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_DrawMonitor_Private_Void_byref_Rect_Monitor_Boolean_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
