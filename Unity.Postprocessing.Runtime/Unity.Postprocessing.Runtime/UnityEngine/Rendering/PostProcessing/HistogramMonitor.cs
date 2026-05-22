using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000038 RID: 56
	[Serializable]
	public sealed class HistogramMonitor : Monitor
	{
		// Token: 0x06000259 RID: 601 RVA: 0x0000CAA8 File Offset: 0x0000ACA8
		// Note: this type is marked as 'beforefieldinit'.
		static HistogramMonitor()
		{
			Il2CppClassPointerStore<HistogramMonitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "HistogramMonitor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HistogramMonitor>.NativeClassPtr);
			HistogramMonitor.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramMonitor>.NativeClassPtr, "width");
			HistogramMonitor.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramMonitor>.NativeClassPtr, "height");
			HistogramMonitor.NativeFieldInfoPtr_channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramMonitor>.NativeClassPtr, "channel");
			HistogramMonitor.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramMonitor>.NativeClassPtr, "m_Data");
			HistogramMonitor.NativeFieldInfoPtr_k_NumBins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramMonitor>.NativeClassPtr, "k_NumBins");
			HistogramMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramMonitor>.NativeClassPtr, "k_ThreadGroupSizeX");
			HistogramMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramMonitor>.NativeClassPtr, "k_ThreadGroupSizeY");
			HistogramMonitor.NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramMonitor>.NativeClassPtr, 100663454);
			HistogramMonitor.NativeMethodInfoPtr_NeedsHalfRes_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramMonitor>.NativeClassPtr, 100663455);
			HistogramMonitor.NativeMethodInfoPtr_ShaderResourcesAvailable_Internal_Virtual_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramMonitor>.NativeClassPtr, 100663456);
			HistogramMonitor.NativeMethodInfoPtr_Render_Internal_Virtual_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramMonitor>.NativeClassPtr, 100663457);
			HistogramMonitor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramMonitor>.NativeClassPtr, 100663458);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000CBC8 File Offset: 0x0000ADC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445230, XrefRangeEnd = 445235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HistogramMonitor.NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000CBFC File Offset: 0x0000ADFC
		[CallerCount(0)]
		public unsafe override bool NeedsHalfRes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HistogramMonitor.NativeMethodInfoPtr_NeedsHalfRes_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000CC38 File Offset: 0x0000AE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445235, XrefRangeEnd = 445240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShaderResourcesAvailable(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HistogramMonitor.NativeMethodInfoPtr_ShaderResourcesAvailable_Internal_Virtual_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000CC88 File Offset: 0x0000AE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445240, XrefRangeEnd = 445336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HistogramMonitor.NativeMethodInfoPtr_Render_Internal_Virtual_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000CCCC File Offset: 0x0000AECC
		[CallerCount(0)]
		public unsafe HistogramMonitor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HistogramMonitor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HistogramMonitor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00003831 File Offset: 0x00001A31
		public HistogramMonitor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000CD08 File Offset: 0x0000AF08
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0000383A File Offset: 0x00001A3A
		public unsafe int width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramMonitor.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramMonitor.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0000CD30 File Offset: 0x0000AF30
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00003855 File Offset: 0x00001A55
		public unsafe int height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramMonitor.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramMonitor.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0000CD58 File Offset: 0x0000AF58
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00003870 File Offset: 0x00001A70
		public unsafe HistogramMonitor.Channel channel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramMonitor.NativeFieldInfoPtr_channel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramMonitor.NativeFieldInfoPtr_channel)) = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000CD80 File Offset: 0x0000AF80
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0000388B File Offset: 0x00001A8B
		public unsafe ComputeBuffer m_Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramMonitor.NativeFieldInfoPtr_m_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramMonitor.NativeFieldInfoPtr_m_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		// (set) Token: 0x06000269 RID: 617 RVA: 0x000038AA File Offset: 0x00001AAA
		public unsafe static int k_NumBins
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HistogramMonitor.NativeFieldInfoPtr_k_NumBins, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HistogramMonitor.NativeFieldInfoPtr_k_NumBins, (void*)(&value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000CDCC File Offset: 0x0000AFCC
		// (set) Token: 0x0600026B RID: 619 RVA: 0x000038B8 File Offset: 0x00001AB8
		public unsafe static int k_ThreadGroupSizeX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HistogramMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HistogramMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeX, (void*)(&value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000CDE8 File Offset: 0x0000AFE8
		// (set) Token: 0x0600026D RID: 621 RVA: 0x000038C6 File Offset: 0x00001AC6
		public unsafe static int k_ThreadGroupSizeY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HistogramMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HistogramMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeY, (void*)(&value));
			}
		}

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr_channel;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_k_NumBins;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_k_ThreadGroupSizeX;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_k_ThreadGroupSizeY;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_NeedsHalfRes_Internal_Virtual_Boolean_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_ShaderResourcesAvailable_Internal_Virtual_Boolean_PostProcessRenderContext_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Virtual_Void_PostProcessRenderContext_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000076 RID: 118
		[OriginalName("Unity.Postprocessing.Runtime.dll", "", "Channel")]
		public enum Channel
		{
			// Token: 0x040004B8 RID: 1208
			Red,
			// Token: 0x040004B9 RID: 1209
			Green,
			// Token: 0x040004BA RID: 1210
			Blue,
			// Token: 0x040004BB RID: 1211
			Master
		}
	}
}
