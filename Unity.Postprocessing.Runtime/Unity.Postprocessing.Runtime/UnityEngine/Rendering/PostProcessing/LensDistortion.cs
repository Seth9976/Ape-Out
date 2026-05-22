using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000026 RID: 38
	[Serializable]
	public sealed class LensDistortion : PostProcessEffectSettings
	{
		// Token: 0x0600017D RID: 381 RVA: 0x00009E24 File Offset: 0x00008024
		// Note: this type is marked as 'beforefieldinit'.
		static LensDistortion()
		{
			Il2CppClassPointerStore<LensDistortion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "LensDistortion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr);
			LensDistortion.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr, "intensity");
			LensDistortion.NativeFieldInfoPtr_intensityX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr, "intensityX");
			LensDistortion.NativeFieldInfoPtr_intensityY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr, "intensityY");
			LensDistortion.NativeFieldInfoPtr_centerX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr, "centerX");
			LensDistortion.NativeFieldInfoPtr_centerY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr, "centerY");
			LensDistortion.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr, "scale");
			LensDistortion.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr, 100663379);
			LensDistortion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr, 100663380);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00009EF4 File Offset: 0x000080F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443476, XrefRangeEnd = 443482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensDistortion.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00009F44 File Offset: 0x00008144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443482, XrefRangeEnd = 443509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LensDistortion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensDistortion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensDistortion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000304C File Offset: 0x0000124C
		public LensDistortion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00009F80 File Offset: 0x00008180
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00003055 File Offset: 0x00001255
		public unsafe FloatParameter intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_intensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00009FB0 File Offset: 0x000081B0
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00003074 File Offset: 0x00001274
		public unsafe FloatParameter intensityX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_intensityX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_intensityX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00009FE0 File Offset: 0x000081E0
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00003093 File Offset: 0x00001293
		public unsafe FloatParameter intensityY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_intensityY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_intensityY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000A010 File Offset: 0x00008210
		// (set) Token: 0x06000188 RID: 392 RVA: 0x000030B2 File Offset: 0x000012B2
		public unsafe FloatParameter centerX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_centerX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_centerX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000A040 File Offset: 0x00008240
		// (set) Token: 0x0600018A RID: 394 RVA: 0x000030D1 File Offset: 0x000012D1
		public unsafe FloatParameter centerY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_centerY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_centerY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000A070 File Offset: 0x00008270
		// (set) Token: 0x0600018C RID: 396 RVA: 0x000030F0 File Offset: 0x000012F0
		public unsafe FloatParameter scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_scale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensDistortion.NativeFieldInfoPtr_scale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_intensityX;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_intensityY;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_centerX;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr_centerY;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
