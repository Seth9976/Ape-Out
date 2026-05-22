using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200003D RID: 61
	[Serializable]
	public sealed class WaveformMonitor : Monitor
	{
		// Token: 0x0600029A RID: 666 RVA: 0x0000D720 File Offset: 0x0000B920
		// Note: this type is marked as 'beforefieldinit'.
		static WaveformMonitor()
		{
			Il2CppClassPointerStore<WaveformMonitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "WaveformMonitor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaveformMonitor>.NativeClassPtr);
			WaveformMonitor.NativeFieldInfoPtr_exposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveformMonitor>.NativeClassPtr, "exposure");
			WaveformMonitor.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveformMonitor>.NativeClassPtr, "height");
			WaveformMonitor.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveformMonitor>.NativeClassPtr, "m_Data");
			WaveformMonitor.NativeFieldInfoPtr_k_ThreadGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveformMonitor>.NativeClassPtr, "k_ThreadGroupSize");
			WaveformMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveformMonitor>.NativeClassPtr, "k_ThreadGroupSizeX");
			WaveformMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaveformMonitor>.NativeClassPtr, "k_ThreadGroupSizeY");
			WaveformMonitor.NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveformMonitor>.NativeClassPtr, 100663477);
			WaveformMonitor.NativeMethodInfoPtr_NeedsHalfRes_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveformMonitor>.NativeClassPtr, 100663478);
			WaveformMonitor.NativeMethodInfoPtr_ShaderResourcesAvailable_Internal_Virtual_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveformMonitor>.NativeClassPtr, 100663479);
			WaveformMonitor.NativeMethodInfoPtr_Render_Internal_Virtual_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveformMonitor>.NativeClassPtr, 100663480);
			WaveformMonitor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaveformMonitor>.NativeClassPtr, 100663481);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000D82C File Offset: 0x0000BA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaveformMonitor.NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000D860 File Offset: 0x0000BA60
		[CallerCount(0)]
		public unsafe override bool NeedsHalfRes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaveformMonitor.NativeMethodInfoPtr_NeedsHalfRes_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000D89C File Offset: 0x0000BA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445594, XrefRangeEnd = 445599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShaderResourcesAvailable(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaveformMonitor.NativeMethodInfoPtr_ShaderResourcesAvailable_Internal_Virtual_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000D8EC File Offset: 0x0000BAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445599, XrefRangeEnd = 445719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaveformMonitor.NativeMethodInfoPtr_Render_Internal_Virtual_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000D930 File Offset: 0x0000BB30
		[CallerCount(0)]
		public unsafe WaveformMonitor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaveformMonitor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaveformMonitor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000039EB File Offset: 0x00001BEB
		public WaveformMonitor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000D96C File Offset: 0x0000BB6C
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x000039F4 File Offset: 0x00001BF4
		public unsafe float exposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaveformMonitor.NativeFieldInfoPtr_exposure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaveformMonitor.NativeFieldInfoPtr_exposure)) = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000D994 File Offset: 0x0000BB94
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00003A0F File Offset: 0x00001C0F
		public unsafe int height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaveformMonitor.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaveformMonitor.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000D9BC File Offset: 0x0000BBBC
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00003A2A File Offset: 0x00001C2A
		public unsafe ComputeBuffer m_Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaveformMonitor.NativeFieldInfoPtr_m_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaveformMonitor.NativeFieldInfoPtr_m_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000D9EC File Offset: 0x0000BBEC
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00003A49 File Offset: 0x00001C49
		public unsafe static int k_ThreadGroupSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaveformMonitor.NativeFieldInfoPtr_k_ThreadGroupSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaveformMonitor.NativeFieldInfoPtr_k_ThreadGroupSize, (void*)(&value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000DA08 File Offset: 0x0000BC08
		// (set) Token: 0x060002AA RID: 682 RVA: 0x00003A57 File Offset: 0x00001C57
		public unsafe static int k_ThreadGroupSizeX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaveformMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaveformMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeX, (void*)(&value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000DA24 File Offset: 0x0000BC24
		// (set) Token: 0x060002AC RID: 684 RVA: 0x00003A65 File Offset: 0x00001C65
		public unsafe static int k_ThreadGroupSizeY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaveformMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaveformMonitor.NativeFieldInfoPtr_k_ThreadGroupSizeY, (void*)(&value));
			}
		}

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeFieldInfoPtr_exposure;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeFieldInfoPtr_k_ThreadGroupSize;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeFieldInfoPtr_k_ThreadGroupSizeX;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeFieldInfoPtr_k_ThreadGroupSizeY;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Internal_Virtual_Void_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_NeedsHalfRes_Internal_Virtual_Boolean_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_ShaderResourcesAvailable_Internal_Virtual_Boolean_PostProcessRenderContext_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Virtual_Void_PostProcessRenderContext_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
