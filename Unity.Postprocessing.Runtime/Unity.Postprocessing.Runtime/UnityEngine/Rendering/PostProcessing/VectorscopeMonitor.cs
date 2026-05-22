using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200003C RID: 60
	[Serializable]
	public sealed class VectorscopeMonitor : Monitor
	{
		// Token: 0x06000289 RID: 649 RVA: 0x0000D430 File Offset: 0x0000B630
		// Note: this type is marked as 'beforefieldinit'.
		static VectorscopeMonitor()
		{
			Il2CppClassPointerStore<VectorscopeMonitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "VectorscopeMonitor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VectorscopeMonitor>.NativeClassPtr);
			VectorscopeMonitor.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorscopeMonitor>.NativeClassPtr, "size");
			VectorscopeMonitor.NativeFieldInfoPtr_exposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorscopeMonitor>.NativeClassPtr, "exposure");
			VectorscopeMonitor.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorscopeMonitor>.NativeClassPtr, "m_Data");
			VectorscopeMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorscopeMonitor>.NativeClassPtr, "k_ThreadGroupSizeX");
			VectorscopeMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorscopeMonitor>.NativeClassPtr, "k_ThreadGroupSizeY");
			VectorscopeMonitor.NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorscopeMonitor>.NativeClassPtr, 100663472);
			VectorscopeMonitor.NativeMethodInfoPtr_NeedsHalfRes_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorscopeMonitor>.NativeClassPtr, 100663473);
			VectorscopeMonitor.NativeMethodInfoPtr_ShaderResourcesAvailable_Internal_Virtual_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorscopeMonitor>.NativeClassPtr, 100663474);
			VectorscopeMonitor.NativeMethodInfoPtr_Render_Internal_Virtual_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorscopeMonitor>.NativeClassPtr, 100663475);
			VectorscopeMonitor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorscopeMonitor>.NativeClassPtr, 100663476);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000D528 File Offset: 0x0000B728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445476, XrefRangeEnd = 445481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorscopeMonitor.NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000D55C File Offset: 0x0000B75C
		[CallerCount(0)]
		public unsafe override bool NeedsHalfRes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorscopeMonitor.NativeMethodInfoPtr_NeedsHalfRes_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000D598 File Offset: 0x0000B798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445481, XrefRangeEnd = 445486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShaderResourcesAvailable(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorscopeMonitor.NativeMethodInfoPtr_ShaderResourcesAvailable_Internal_Virtual_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000D5E8 File Offset: 0x0000B7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445486, XrefRangeEnd = 445594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorscopeMonitor.NativeMethodInfoPtr_Render_Internal_Virtual_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000D62C File Offset: 0x0000B82C
		[CallerCount(0)]
		public unsafe VectorscopeMonitor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VectorscopeMonitor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorscopeMonitor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00003971 File Offset: 0x00001B71
		public VectorscopeMonitor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0000D668 File Offset: 0x0000B868
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0000397A File Offset: 0x00001B7A
		public unsafe int size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorscopeMonitor.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorscopeMonitor.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000D690 File Offset: 0x0000B890
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00003995 File Offset: 0x00001B95
		public unsafe float exposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorscopeMonitor.NativeFieldInfoPtr_exposure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorscopeMonitor.NativeFieldInfoPtr_exposure)) = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000D6B8 File Offset: 0x0000B8B8
		// (set) Token: 0x06000295 RID: 661 RVA: 0x000039B0 File Offset: 0x00001BB0
		public unsafe ComputeBuffer m_Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorscopeMonitor.NativeFieldInfoPtr_m_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorscopeMonitor.NativeFieldInfoPtr_m_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000D6E8 File Offset: 0x0000B8E8
		// (set) Token: 0x06000297 RID: 663 RVA: 0x000039CF File Offset: 0x00001BCF
		public unsafe static int k_ThreadGroupSizeX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(VectorscopeMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VectorscopeMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeX, (void*)(&value));
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000D704 File Offset: 0x0000B904
		// (set) Token: 0x06000299 RID: 665 RVA: 0x000039DD File Offset: 0x00001BDD
		public unsafe static int k_ThreadGroupSizeY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(VectorscopeMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VectorscopeMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeY, (void*)(&value));
			}
		}

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeFieldInfoPtr_exposure;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeFieldInfoPtr_k_ThreadGroupSizeX;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeFieldInfoPtr_k_ThreadGroupSizeY;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_NeedsHalfRes_Internal_Virtual_Boolean_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_ShaderResourcesAvailable_Internal_Virtual_Boolean_PostProcessRenderContext_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Virtual_Void_PostProcessRenderContext_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
