using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200001F RID: 31
	[Serializable]
	public sealed class DepthOfField : PostProcessEffectSettings
	{
		// Token: 0x0600012D RID: 301 RVA: 0x00008FE4 File Offset: 0x000071E4
		// Note: this type is marked as 'beforefieldinit'.
		static DepthOfField()
		{
			Il2CppClassPointerStore<DepthOfField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "DepthOfField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr);
			DepthOfField.NativeFieldInfoPtr_focusDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, "focusDistance");
			DepthOfField.NativeFieldInfoPtr_aperture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, "aperture");
			DepthOfField.NativeFieldInfoPtr_focalLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, "focalLength");
			DepthOfField.NativeFieldInfoPtr_kernelSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, "kernelSize");
			DepthOfField.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, 100663357);
			DepthOfField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr, 100663358);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000908C File Offset: 0x0000728C
		[CallerCount(0)]
		public unsafe override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfField.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000090DC File Offset: 0x000072DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443080, XrefRangeEnd = 443100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DepthOfField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthOfField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002DBF File Offset: 0x00000FBF
		public DepthOfField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00009118 File Offset: 0x00007318
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00002DC8 File Offset: 0x00000FC8
		public unsafe FloatParameter focusDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_focusDistance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_focusDistance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00009148 File Offset: 0x00007348
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00002DE7 File Offset: 0x00000FE7
		public unsafe FloatParameter aperture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_aperture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_aperture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00009178 File Offset: 0x00007378
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00002E06 File Offset: 0x00001006
		public unsafe FloatParameter focalLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_focalLength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_focalLength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000091A8 File Offset: 0x000073A8
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00002E25 File Offset: 0x00001025
		public unsafe KernelSizeParameter kernelSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_kernelSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KernelSizeParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfField.NativeFieldInfoPtr_kernelSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_focusDistance;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_aperture;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_focalLength;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr_kernelSize;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
