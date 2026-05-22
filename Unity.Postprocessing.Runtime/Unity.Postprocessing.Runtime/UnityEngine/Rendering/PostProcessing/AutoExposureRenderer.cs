using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000012 RID: 18
	public sealed class AutoExposureRenderer : PostProcessEffectRenderer<AutoExposure>
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00007310 File Offset: 0x00005510
		// Note: this type is marked as 'beforefieldinit'.
		static AutoExposureRenderer()
		{
			Il2CppClassPointerStore<AutoExposureRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "AutoExposureRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoExposureRenderer>.NativeClassPtr);
			AutoExposureRenderer.NativeFieldInfoPtr_k_NumEyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExposureRenderer>.NativeClassPtr, "k_NumEyes");
			AutoExposureRenderer.NativeFieldInfoPtr_k_NumAutoExposureTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExposureRenderer>.NativeClassPtr, "k_NumAutoExposureTextures");
			AutoExposureRenderer.NativeFieldInfoPtr_m_AutoExposurePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExposureRenderer>.NativeClassPtr, "m_AutoExposurePool");
			AutoExposureRenderer.NativeFieldInfoPtr_m_AutoExposurePingPong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExposureRenderer>.NativeClassPtr, "m_AutoExposurePingPong");
			AutoExposureRenderer.NativeFieldInfoPtr_m_CurrentAutoExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExposureRenderer>.NativeClassPtr, "m_CurrentAutoExposure");
			AutoExposureRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExposureRenderer>.NativeClassPtr, 100663325);
			AutoExposureRenderer.NativeMethodInfoPtr_CheckTexture_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExposureRenderer>.NativeClassPtr, 100663326);
			AutoExposureRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExposureRenderer>.NativeClassPtr, 100663327);
			AutoExposureRenderer.NativeMethodInfoPtr_Release_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExposureRenderer>.NativeClassPtr, 100663328);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000073F4 File Offset: 0x000055F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441770, XrefRangeEnd = 441782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoExposureRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoExposureRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExposureRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00007430 File Offset: 0x00005630
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441807, RefRangeEnd = 441809, XrefRangeStart = 441782, XrefRangeEnd = 441807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTexture(int eye, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExposureRenderer.NativeMethodInfoPtr_CheckTexture_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000747C File Offset: 0x0000567C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441809, XrefRangeEnd = 441878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExposureRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000074C0 File Offset: 0x000056C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441878, XrefRangeEnd = 441884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExposureRenderer.NativeMethodInfoPtr_Release_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000024F2 File Offset: 0x000006F2
		public AutoExposureRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000074F4 File Offset: 0x000056F4
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000024FB File Offset: 0x000006FB
		public unsafe static int k_NumEyes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AutoExposureRenderer.NativeFieldInfoPtr_k_NumEyes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AutoExposureRenderer.NativeFieldInfoPtr_k_NumEyes, (void*)(&value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00007510 File Offset: 0x00005710
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002509 File Offset: 0x00000709
		public unsafe static int k_NumAutoExposureTextures
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AutoExposureRenderer.NativeFieldInfoPtr_k_NumAutoExposureTextures, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AutoExposureRenderer.NativeFieldInfoPtr_k_NumAutoExposureTextures, (void*)(&value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000752C File Offset: 0x0000572C
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002517 File Offset: 0x00000717
		public unsafe Il2CppReferenceArray<Il2CppReferenceArray<RenderTexture>> m_AutoExposurePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposureRenderer.NativeFieldInfoPtr_m_AutoExposurePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<RenderTexture>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposureRenderer.NativeFieldInfoPtr_m_AutoExposurePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000755C File Offset: 0x0000575C
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002536 File Offset: 0x00000736
		public unsafe Il2CppStructArray<int> m_AutoExposurePingPong
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposureRenderer.NativeFieldInfoPtr_m_AutoExposurePingPong);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposureRenderer.NativeFieldInfoPtr_m_AutoExposurePingPong), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000758C File Offset: 0x0000578C
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00002555 File Offset: 0x00000755
		public unsafe RenderTexture m_CurrentAutoExposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposureRenderer.NativeFieldInfoPtr_m_CurrentAutoExposure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposureRenderer.NativeFieldInfoPtr_m_CurrentAutoExposure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_k_NumEyes;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_k_NumAutoExposureTextures;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoExposurePool;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoExposurePingPong;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentAutoExposure;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_CheckTexture_Private_Void_Int32_Int32_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_0;
	}
}
