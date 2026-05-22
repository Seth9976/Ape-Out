using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000051 RID: 81
	[Serializable]
	public class PostProcessEffectSettings : ScriptableObject
	{
		// Token: 0x0600035F RID: 863 RVA: 0x000106AC File Offset: 0x0000E8AC
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessEffectSettings()
		{
			Il2CppClassPointerStore<PostProcessEffectSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "PostProcessEffectSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessEffectSettings>.NativeClassPtr);
			PostProcessEffectSettings.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessEffectSettings>.NativeClassPtr, "active");
			PostProcessEffectSettings.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessEffectSettings>.NativeClassPtr, "enabled");
			PostProcessEffectSettings.NativeFieldInfoPtr_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessEffectSettings>.NativeClassPtr, "parameters");
			PostProcessEffectSettings.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectSettings>.NativeClassPtr, 100663573);
			PostProcessEffectSettings.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectSettings>.NativeClassPtr, 100663574);
			PostProcessEffectSettings.NativeMethodInfoPtr_SetAllOverridesTo_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectSettings>.NativeClassPtr, 100663575);
			PostProcessEffectSettings.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_New_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectSettings>.NativeClassPtr, 100663576);
			PostProcessEffectSettings.NativeMethodInfoPtr_GetHash_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectSettings>.NativeClassPtr, 100663577);
			PostProcessEffectSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectSettings>.NativeClassPtr, 100663578);
			PostProcessEffectSettings.NativeMethodInfoPtr__OnEnable_b__3_2_Private_ParameterOverride_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectSettings>.NativeClassPtr, 100663579);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000107A4 File Offset: 0x0000E9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446295, XrefRangeEnd = 446360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessEffectSettings.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000107D8 File Offset: 0x0000E9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446360, XrefRangeEnd = 446374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessEffectSettings.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0001080C File Offset: 0x0000EA0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 446388, RefRangeEnd = 446389, XrefRangeStart = 446374, XrefRangeEnd = 446388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAllOverridesTo(bool state, bool excludeEnabled = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref excludeEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessEffectSettings.NativeMethodInfoPtr_SetAllOverridesTo_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00010858 File Offset: 0x0000EA58
		[CallerCount(0)]
		public unsafe virtual bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessEffectSettings.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_New_Boolean_PostProcessRenderContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000108B0 File Offset: 0x0000EAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446389, XrefRangeEnd = 446403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessEffectSettings.NativeMethodInfoPtr_GetHash_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000108EC File Offset: 0x0000EAEC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 446410, RefRangeEnd = 446421, XrefRangeStart = 446403, XrefRangeEnd = 446410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessEffectSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessEffectSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessEffectSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00010928 File Offset: 0x0000EB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446421, XrefRangeEnd = 446423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterOverride _OnEnable_b__3_2(FieldInfo t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessEffectSettings.NativeMethodInfoPtr__OnEnable_b__3_2_Private_ParameterOverride_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterOverride>(intPtr3) : null;
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00003E32 File Offset: 0x00002032
		public PostProcessEffectSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00010978 File Offset: 0x0000EB78
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00003E3B File Offset: 0x0000203B
		public unsafe bool active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessEffectSettings.NativeFieldInfoPtr_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessEffectSettings.NativeFieldInfoPtr_active)) = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000109A0 File Offset: 0x0000EBA0
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00003E56 File Offset: 0x00002056
		public unsafe BoolParameter enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessEffectSettings.NativeFieldInfoPtr_enabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessEffectSettings.NativeFieldInfoPtr_enabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000109D0 File Offset: 0x0000EBD0
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00003E75 File Offset: 0x00002075
		public unsafe ReadOnlyCollection<ParameterOverride> parameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessEffectSettings.NativeFieldInfoPtr_parameters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ParameterOverride>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessEffectSettings.NativeFieldInfoPtr_parameters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr_active;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr_enabled;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeFieldInfoPtr_parameters;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_SetAllOverridesTo_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_New_Boolean_PostProcessRenderContext_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_GetHash_Public_Int32_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__3_2_Private_ParameterOverride_FieldInfo_0;

		// Token: 0x0200007B RID: 123
		[ObfuscatedName("UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060006E5 RID: 1765 RVA: 0x0001ABAC File Offset: 0x00018DAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PostProcessEffectSettings.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessEffectSettings>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessEffectSettings.__c>.NativeClassPtr);
				PostProcessEffectSettings.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessEffectSettings.__c>.NativeClassPtr, "<>9");
				PostProcessEffectSettings.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessEffectSettings.__c>.NativeClassPtr, "<>9__3_0");
				PostProcessEffectSettings.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessEffectSettings.__c>.NativeClassPtr, "<>9__3_1");
				PostProcessEffectSettings.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectSettings.__c>.NativeClassPtr, 100663581);
				PostProcessEffectSettings.__c.NativeMethodInfoPtr__OnEnable_b__3_0_Internal_Boolean_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectSettings.__c>.NativeClassPtr, 100663582);
				PostProcessEffectSettings.__c.NativeMethodInfoPtr__OnEnable_b__3_1_Internal_Int32_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectSettings.__c>.NativeClassPtr, 100663583);
			}

			// Token: 0x060006E6 RID: 1766 RVA: 0x0001AC50 File Offset: 0x00018E50
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessEffectSettings.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessEffectSettings.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006E7 RID: 1767 RVA: 0x0001AC8C File Offset: 0x00018E8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446283, XrefRangeEnd = 446290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnEnable_b__3_0(FieldInfo t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessEffectSettings.__c.NativeMethodInfoPtr__OnEnable_b__3_0_Internal_Boolean_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060006E8 RID: 1768 RVA: 0x0001ACDC File Offset: 0x00018EDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 446290, XrefRangeEnd = 446295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnEnable_b__3_1(FieldInfo t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessEffectSettings.__c.NativeMethodInfoPtr__OnEnable_b__3_1_Internal_Int32_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060006E9 RID: 1769 RVA: 0x00005728 File Offset: 0x00003928
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000249 RID: 585
			// (get) Token: 0x060006EA RID: 1770 RVA: 0x0001AD2C File Offset: 0x00018F2C
			// (set) Token: 0x060006EB RID: 1771 RVA: 0x00005731 File Offset: 0x00003931
			public unsafe static PostProcessEffectSettings.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PostProcessEffectSettings.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessEffectSettings.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessEffectSettings.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700024A RID: 586
			// (get) Token: 0x060006EC RID: 1772 RVA: 0x0001AD54 File Offset: 0x00018F54
			// (set) Token: 0x060006ED RID: 1773 RVA: 0x00005743 File Offset: 0x00003943
			public unsafe static Func<FieldInfo, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PostProcessEffectSettings.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessEffectSettings.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700024B RID: 587
			// (get) Token: 0x060006EE RID: 1774 RVA: 0x0001AD7C File Offset: 0x00018F7C
			// (set) Token: 0x060006EF RID: 1775 RVA: 0x00005755 File Offset: 0x00003955
			public unsafe static Func<FieldInfo, int> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PostProcessEffectSettings.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessEffectSettings.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004C5 RID: 1221
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040004C6 RID: 1222
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040004C7 RID: 1223
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x040004C8 RID: 1224
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004C9 RID: 1225
			private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__3_0_Internal_Boolean_FieldInfo_0;

			// Token: 0x040004CA RID: 1226
			private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__3_1_Internal_Int32_FieldInfo_0;
		}
	}
}
