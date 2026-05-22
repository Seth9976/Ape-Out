using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200004A RID: 74
	public sealed class PostProcessBundle : Object
	{
		// Token: 0x060002F3 RID: 755 RVA: 0x0000EE98 File Offset: 0x0000D098
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessBundle()
		{
			Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "PostProcessBundle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr);
			PostProcessBundle.NativeFieldInfoPtr__attribute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr, "<attribute>k__BackingField");
			PostProcessBundle.NativeFieldInfoPtr__settings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr, "<settings>k__BackingField");
			PostProcessBundle.NativeFieldInfoPtr_m_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr, "m_Renderer");
			PostProcessBundle.NativeMethodInfoPtr_get_attribute_Public_get_PostProcessAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr, 100663524);
			PostProcessBundle.NativeMethodInfoPtr_set_attribute_Private_set_Void_PostProcessAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr, 100663525);
			PostProcessBundle.NativeMethodInfoPtr_get_settings_Public_get_PostProcessEffectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr, 100663526);
			PostProcessBundle.NativeMethodInfoPtr_set_settings_Private_set_Void_PostProcessEffectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr, 100663527);
			PostProcessBundle.NativeMethodInfoPtr_get_renderer_Internal_get_PostProcessEffectRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr, 100663528);
			PostProcessBundle.NativeMethodInfoPtr__ctor_Internal_Void_PostProcessEffectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr, 100663529);
			PostProcessBundle.NativeMethodInfoPtr_Release_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr, 100663530);
			PostProcessBundle.NativeMethodInfoPtr_ResetHistory_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr, 100663531);
			PostProcessBundle.NativeMethodInfoPtr_CastSettings_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr, 100663532);
			PostProcessBundle.NativeMethodInfoPtr_CastRenderer_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr, 100663533);
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000EFCC File Offset: 0x0000D1CC
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x0000F00C File Offset: 0x0000D20C
		public unsafe PostProcessAttribute attribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessBundle.NativeMethodInfoPtr_get_attribute_Public_get_PostProcessAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessAttribute>(intPtr3) : null;
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessBundle.NativeMethodInfoPtr_set_attribute_Private_set_Void_PostProcessAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000F050 File Offset: 0x0000D250
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x0000F090 File Offset: 0x0000D290
		public unsafe PostProcessEffectSettings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessBundle.NativeMethodInfoPtr_get_settings_Public_get_PostProcessEffectSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessEffectSettings>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessBundle.NativeMethodInfoPtr_set_settings_Private_set_Void_PostProcessEffectSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x0000F0D4 File Offset: 0x0000D2D4
		public unsafe PostProcessEffectRenderer renderer
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 445914, RefRangeEnd = 445921, XrefRangeStart = 445910, XrefRangeEnd = 445914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessBundle.NativeMethodInfoPtr_get_renderer_Internal_get_PostProcessEffectRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessEffectRenderer>(intPtr3) : null;
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000F114 File Offset: 0x0000D314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445921, XrefRangeEnd = 445927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessBundle(PostProcessEffectSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessBundle.NativeMethodInfoPtr__ctor_Internal_Void_PostProcessEffectSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000F160 File Offset: 0x0000D360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445927, XrefRangeEnd = 445931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessBundle.NativeMethodInfoPtr_Release_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000F194 File Offset: 0x0000D394
		[CallerCount(0)]
		public unsafe void ResetHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessBundle.NativeMethodInfoPtr_ResetHistory_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000F1C8 File Offset: 0x0000D3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445931, XrefRangeEnd = 445932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T CastSettings<T>() where T : PostProcessEffectSettings
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessBundle.MethodInfoStoreGeneric_CastSettings_Internal_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000F204 File Offset: 0x0000D404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445932, XrefRangeEnd = 445934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T CastRenderer<T>() where T : PostProcessEffectRenderer
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessBundle.MethodInfoStoreGeneric_CastRenderer_Internal_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00003B45 File Offset: 0x00001D45
		public PostProcessBundle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002FF RID: 767 RVA: 0x0000F240 File Offset: 0x0000D440
		// (set) Token: 0x06000300 RID: 768 RVA: 0x00003B4E File Offset: 0x00001D4E
		public unsafe PostProcessAttribute _attribute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessBundle.NativeFieldInfoPtr__attribute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessBundle.NativeFieldInfoPtr__attribute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0000F270 File Offset: 0x0000D470
		// (set) Token: 0x06000302 RID: 770 RVA: 0x00003B6D File Offset: 0x00001D6D
		public unsafe PostProcessEffectSettings _settings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessBundle.NativeFieldInfoPtr__settings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessEffectSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessBundle.NativeFieldInfoPtr__settings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		// (set) Token: 0x06000304 RID: 772 RVA: 0x00003B8C File Offset: 0x00001D8C
		public unsafe PostProcessEffectRenderer m_Renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessBundle.NativeFieldInfoPtr_m_Renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessEffectRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessBundle.NativeFieldInfoPtr_m_Renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeFieldInfoPtr__attribute_k__BackingField;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeFieldInfoPtr__settings_k__BackingField;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeFieldInfoPtr_m_Renderer;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_get_attribute_Public_get_PostProcessAttribute_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_set_attribute_Private_set_Void_PostProcessAttribute_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_PostProcessEffectSettings_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Private_set_Void_PostProcessEffectSettings_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_get_renderer_Internal_get_PostProcessEffectRenderer_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PostProcessEffectSettings_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_Release_Internal_Void_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_ResetHistory_Internal_Void_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_CastSettings_Internal_T_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_CastRenderer_Internal_T_0;

		// Token: 0x02000078 RID: 120
		private sealed class MethodInfoStoreGeneric_CastSettings_Internal_T_0<T>
		{
			// Token: 0x040004BD RID: 1213
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PostProcessBundle.NativeMethodInfoPtr_CastSettings_Internal_T_0, Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000079 RID: 121
		private sealed class MethodInfoStoreGeneric_CastRenderer_Internal_T_0<T>
		{
			// Token: 0x040004BE RID: 1214
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PostProcessBundle.NativeMethodInfoPtr_CastRenderer_Internal_T_0, Il2CppClassPointerStore<PostProcessBundle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
