using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000028 RID: 40
	[Serializable]
	public sealed class MotionBlur : PostProcessEffectSettings
	{
		// Token: 0x06000191 RID: 401 RVA: 0x0000A178 File Offset: 0x00008378
		// Note: this type is marked as 'beforefieldinit'.
		static MotionBlur()
		{
			Il2CppClassPointerStore<MotionBlur>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "MotionBlur");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlur>.NativeClassPtr);
			MotionBlur.NativeFieldInfoPtr_shutterAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlur>.NativeClassPtr, "shutterAngle");
			MotionBlur.NativeFieldInfoPtr_sampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlur>.NativeClassPtr, "sampleCount");
			MotionBlur.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlur>.NativeClassPtr, 100663383);
			MotionBlur.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlur>.NativeClassPtr, 100663384);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000A1F8 File Offset: 0x000083F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443527, XrefRangeEnd = 443537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlur.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000A248 File Offset: 0x00008448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443537, XrefRangeEnd = 443549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotionBlur()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlur>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlur.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00003118 File Offset: 0x00001318
		public MotionBlur(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000A284 File Offset: 0x00008484
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00003121 File Offset: 0x00001321
		public unsafe FloatParameter shutterAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlur.NativeFieldInfoPtr_shutterAngle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlur.NativeFieldInfoPtr_shutterAngle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000A2B4 File Offset: 0x000084B4
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00003140 File Offset: 0x00001340
		public unsafe IntParameter sampleCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlur.NativeFieldInfoPtr_sampleCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlur.NativeFieldInfoPtr_sampleCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_shutterAngle;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr_sampleCount;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
