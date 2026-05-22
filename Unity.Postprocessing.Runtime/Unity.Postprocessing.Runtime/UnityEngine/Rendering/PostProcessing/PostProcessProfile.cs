using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000056 RID: 86
	public sealed class PostProcessProfile : ScriptableObject
	{
		// Token: 0x0600040F RID: 1039 RVA: 0x00012DA4 File Offset: 0x00010FA4
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessProfile()
		{
			Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "PostProcessProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr);
			PostProcessProfile.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr, "settings");
			PostProcessProfile.NativeFieldInfoPtr_isDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr, "isDirty");
			PostProcessProfile.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr, 100663664);
			PostProcessProfile.NativeMethodInfoPtr_AddSettings_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr, 100663665);
			PostProcessProfile.NativeMethodInfoPtr_AddSettings_Public_PostProcessEffectSettings_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr, 100663666);
			PostProcessProfile.NativeMethodInfoPtr_AddSettings_Public_PostProcessEffectSettings_PostProcessEffectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr, 100663667);
			PostProcessProfile.NativeMethodInfoPtr_RemoveSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr, 100663668);
			PostProcessProfile.NativeMethodInfoPtr_RemoveSettings_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr, 100663669);
			PostProcessProfile.NativeMethodInfoPtr_HasSettings_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr, 100663670);
			PostProcessProfile.NativeMethodInfoPtr_HasSettings_Public_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr, 100663671);
			PostProcessProfile.NativeMethodInfoPtr_GetSetting_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr, 100663672);
			PostProcessProfile.NativeMethodInfoPtr_TryGetSettings_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr, 100663673);
			PostProcessProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr, 100663674);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00012ED8 File Offset: 0x000110D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 447979, XrefRangeEnd = 447998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessProfile.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00012F0C File Offset: 0x0001110C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 447998, XrefRangeEnd = 448004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T AddSettings<T>() where T : PostProcessEffectSettings
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessProfile.MethodInfoStoreGeneric_AddSettings_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00012F48 File Offset: 0x00011148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 448015, RefRangeEnd = 448016, XrefRangeStart = 448004, XrefRangeEnd = 448015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessEffectSettings AddSettings(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessProfile.NativeMethodInfoPtr_AddSettings_Public_PostProcessEffectSettings_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessEffectSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00012F98 File Offset: 0x00011198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448016, XrefRangeEnd = 448021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(effect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessProfile.NativeMethodInfoPtr_AddSettings_Public_PostProcessEffectSettings_PostProcessEffectSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessEffectSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00012FE8 File Offset: 0x000111E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448021, XrefRangeEnd = 448035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSettings<T>() where T : PostProcessEffectSettings
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessProfile.MethodInfoStoreGeneric_RemoveSettings_Public_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0001301C File Offset: 0x0001121C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448035, XrefRangeEnd = 448045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSettings(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessProfile.NativeMethodInfoPtr_RemoveSettings_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00013060 File Offset: 0x00011260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448045, XrefRangeEnd = 448051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSettings<T>() where T : PostProcessEffectSettings
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessProfile.MethodInfoStoreGeneric_HasSettings_Public_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0001309C File Offset: 0x0001129C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 448063, RefRangeEnd = 448067, XrefRangeStart = 448051, XrefRangeEnd = 448063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSettings(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessProfile.NativeMethodInfoPtr_HasSettings_Public_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000130EC File Offset: 0x000112EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448067, XrefRangeEnd = 448088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetSetting<T>() where T : PostProcessEffectSettings
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessProfile.MethodInfoStoreGeneric_GetSetting_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00013128 File Offset: 0x00011328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448088, XrefRangeEnd = 448115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetSettings<T>(out T outSetting) where T : PostProcessEffectSettings
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref outSetting;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PostProcessProfile.MethodInfoStoreGeneric_TryGetSettings_Public_Boolean_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					outSetting = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000131B4 File Offset: 0x000113B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448115, XrefRangeEnd = 448122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000043ED File Offset: 0x000025ED
		public PostProcessProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x000131F0 File Offset: 0x000113F0
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x000043F6 File Offset: 0x000025F6
		public unsafe List<PostProcessEffectSettings> settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessProfile.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PostProcessEffectSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessProfile.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00013220 File Offset: 0x00011420
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00004415 File Offset: 0x00002615
		public unsafe bool isDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessProfile.NativeFieldInfoPtr_isDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessProfile.NativeFieldInfoPtr_isDirty)) = value;
			}
		}

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeFieldInfoPtr_isDirty;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_AddSettings_Public_T_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_AddSettings_Public_PostProcessEffectSettings_Type_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_AddSettings_Public_PostProcessEffectSettings_PostProcessEffectSettings_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSettings_Public_Void_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSettings_Public_Void_Type_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_HasSettings_Public_Boolean_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_HasSettings_Public_Boolean_Type_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_GetSetting_Public_T_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_TryGetSettings_Public_Boolean_byref_T_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000087 RID: 135
		[ObfuscatedName("UnityEngine.Rendering.PostProcessing.PostProcessProfile+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000725 RID: 1829 RVA: 0x0001B770 File Offset: 0x00019970
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PostProcessProfile.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessProfile.__c>.NativeClassPtr);
				PostProcessProfile.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessProfile.__c>.NativeClassPtr, "<>9");
				PostProcessProfile.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessProfile.__c>.NativeClassPtr, "<>9__2_0");
				PostProcessProfile.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessProfile.__c>.NativeClassPtr, 100663676);
				PostProcessProfile.__c.NativeMethodInfoPtr__OnEnable_b__2_0_Internal_Boolean_PostProcessEffectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessProfile.__c>.NativeClassPtr, 100663677);
			}

			// Token: 0x06000726 RID: 1830 RVA: 0x0001B7EC File Offset: 0x000199EC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessProfile.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessProfile.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000727 RID: 1831 RVA: 0x0001B828 File Offset: 0x00019A28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 447967, XrefRangeEnd = 447979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnEnable_b__2_0(PostProcessEffectSettings x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessProfile.__c.NativeMethodInfoPtr__OnEnable_b__2_0_Internal_Boolean_PostProcessEffectSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000728 RID: 1832 RVA: 0x000058C3 File Offset: 0x00003AC3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000257 RID: 599
			// (get) Token: 0x06000729 RID: 1833 RVA: 0x0001B878 File Offset: 0x00019A78
			// (set) Token: 0x0600072A RID: 1834 RVA: 0x000058CC File Offset: 0x00003ACC
			public unsafe static PostProcessProfile.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PostProcessProfile.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessProfile.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessProfile.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000258 RID: 600
			// (get) Token: 0x0600072B RID: 1835 RVA: 0x0001B8A0 File Offset: 0x00019AA0
			// (set) Token: 0x0600072C RID: 1836 RVA: 0x000058DE File Offset: 0x00003ADE
			public unsafe static Predicate<PostProcessEffectSettings> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PostProcessProfile.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<PostProcessEffectSettings>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessProfile.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004EC RID: 1260
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040004ED RID: 1261
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040004EE RID: 1262
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004EF RID: 1263
			private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__2_0_Internal_Boolean_PostProcessEffectSettings_0;
		}

		// Token: 0x02000088 RID: 136
		private sealed class MethodInfoStoreGeneric_AddSettings_Public_T_0<T>
		{
			// Token: 0x040004F0 RID: 1264
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PostProcessProfile.NativeMethodInfoPtr_AddSettings_Public_T_0, Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000089 RID: 137
		private sealed class MethodInfoStoreGeneric_RemoveSettings_Public_Void_0<T>
		{
			// Token: 0x040004F1 RID: 1265
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PostProcessProfile.NativeMethodInfoPtr_RemoveSettings_Public_Void_0, Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200008A RID: 138
		private sealed class MethodInfoStoreGeneric_HasSettings_Public_Boolean_0<T>
		{
			// Token: 0x040004F2 RID: 1266
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PostProcessProfile.NativeMethodInfoPtr_HasSettings_Public_Boolean_0, Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200008B RID: 139
		private sealed class MethodInfoStoreGeneric_GetSetting_Public_T_0<T>
		{
			// Token: 0x040004F3 RID: 1267
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PostProcessProfile.NativeMethodInfoPtr_GetSetting_Public_T_0, Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200008C RID: 140
		private sealed class MethodInfoStoreGeneric_TryGetSettings_Public_Boolean_byref_T_0<T>
		{
			// Token: 0x040004F4 RID: 1268
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PostProcessProfile.NativeMethodInfoPtr_TryGetSettings_Public_Boolean_byref_T_0, Il2CppClassPointerStore<PostProcessProfile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
