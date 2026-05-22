using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	public sealed class AutoExposure : PostProcessEffectSettings
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00007050 File Offset: 0x00005250
		// Note: this type is marked as 'beforefieldinit'.
		static AutoExposure()
		{
			Il2CppClassPointerStore<AutoExposure>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "AutoExposure");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoExposure>.NativeClassPtr);
			AutoExposure.NativeFieldInfoPtr_filtering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExposure>.NativeClassPtr, "filtering");
			AutoExposure.NativeFieldInfoPtr_minLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExposure>.NativeClassPtr, "minLuminance");
			AutoExposure.NativeFieldInfoPtr_maxLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExposure>.NativeClassPtr, "maxLuminance");
			AutoExposure.NativeFieldInfoPtr_keyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExposure>.NativeClassPtr, "keyValue");
			AutoExposure.NativeFieldInfoPtr_eyeAdaptation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExposure>.NativeClassPtr, "eyeAdaptation");
			AutoExposure.NativeFieldInfoPtr_speedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExposure>.NativeClassPtr, "speedUp");
			AutoExposure.NativeFieldInfoPtr_speedDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExposure>.NativeClassPtr, "speedDown");
			AutoExposure.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExposure>.NativeClassPtr, 100663323);
			AutoExposure.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExposure>.NativeClassPtr, 100663324);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00007134 File Offset: 0x00005334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441720, XrefRangeEnd = 441737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExposure.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007184 File Offset: 0x00005384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441737, XrefRangeEnd = 441770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoExposure()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoExposure>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExposure.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002410 File Offset: 0x00000610
		public AutoExposure(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000071C0 File Offset: 0x000053C0
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002419 File Offset: 0x00000619
		public unsafe Vector2Parameter filtering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposure.NativeFieldInfoPtr_filtering);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2Parameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposure.NativeFieldInfoPtr_filtering), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000071F0 File Offset: 0x000053F0
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002438 File Offset: 0x00000638
		public unsafe FloatParameter minLuminance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposure.NativeFieldInfoPtr_minLuminance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposure.NativeFieldInfoPtr_minLuminance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00007220 File Offset: 0x00005420
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002457 File Offset: 0x00000657
		public unsafe FloatParameter maxLuminance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposure.NativeFieldInfoPtr_maxLuminance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposure.NativeFieldInfoPtr_maxLuminance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00007250 File Offset: 0x00005450
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002476 File Offset: 0x00000676
		public unsafe FloatParameter keyValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposure.NativeFieldInfoPtr_keyValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposure.NativeFieldInfoPtr_keyValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00007280 File Offset: 0x00005480
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00002495 File Offset: 0x00000695
		public unsafe EyeAdaptationParameter eyeAdaptation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposure.NativeFieldInfoPtr_eyeAdaptation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeAdaptationParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposure.NativeFieldInfoPtr_eyeAdaptation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000072B0 File Offset: 0x000054B0
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000024B4 File Offset: 0x000006B4
		public unsafe FloatParameter speedUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposure.NativeFieldInfoPtr_speedUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposure.NativeFieldInfoPtr_speedUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000072E0 File Offset: 0x000054E0
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000024D3 File Offset: 0x000006D3
		public unsafe FloatParameter speedDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposure.NativeFieldInfoPtr_speedDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExposure.NativeFieldInfoPtr_speedDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_filtering;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_minLuminance;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_maxLuminance;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_keyValue;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_eyeAdaptation;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_speedUp;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_speedDown;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
