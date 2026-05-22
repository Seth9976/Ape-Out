using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Data
{
	// Token: 0x02000144 RID: 324
	[Serializable]
	public sealed class ControllerMapLayoutManager_RuleSet_Editor : Object
	{
		// Token: 0x0600238E RID: 9102 RVA: 0x000B4B20 File Offset: 0x000B2D20
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerMapLayoutManager_RuleSet_Editor()
		{
			Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data", "ControllerMapLayoutManager_RuleSet_Editor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr);
			ControllerMapLayoutManager_RuleSet_Editor.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr, "_id");
			ControllerMapLayoutManager_RuleSet_Editor.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr, "_name");
			ControllerMapLayoutManager_RuleSet_Editor.NativeFieldInfoPtr__tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr, "_tag");
			ControllerMapLayoutManager_RuleSet_Editor.NativeFieldInfoPtr__rules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr, "_rules");
			ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr, 100670972);
			ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr, 100670973);
			ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr, 100670974);
			ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr, 100670975);
			ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr, 100670976);
			ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr, 100670977);
			ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_get_rules_Public_get_List_1_ControllerMapLayoutManager_Rule_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr, 100670978);
			ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_set_rules_Public_set_Void_List_1_ControllerMapLayoutManager_Rule_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr, 100670979);
			ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr, 100670980);
			ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr__ctor_Public_Void_ControllerMapLayoutManager_RuleSet_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr, 100670981);
			ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_Clone_Internal_ControllerMapLayoutManager_RuleSet_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr, 100670982);
			ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_ToRuntime_Internal_RuleSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr, 100670983);
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x000B4C90 File Offset: 0x000B2E90
		// (set) Token: 0x06002390 RID: 9104 RVA: 0x000B4CCC File Offset: 0x000B2ECC
		public unsafe int id
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x000B4D0C File Offset: 0x000B2F0C
		// (set) Token: 0x06002392 RID: 9106 RVA: 0x000B4D44 File Offset: 0x000B2F44
		public unsafe string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x000B4D88 File Offset: 0x000B2F88
		// (set) Token: 0x06002394 RID: 9108 RVA: 0x000B4DC0 File Offset: 0x000B2FC0
		public unsafe string tag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06002395 RID: 9109 RVA: 0x000B4E04 File Offset: 0x000B3004
		// (set) Token: 0x06002396 RID: 9110 RVA: 0x000B4E44 File Offset: 0x000B3044
		public unsafe List<ControllerMapLayoutManager_Rule_Editor> rules
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_get_rules_Public_get_List_1_ControllerMapLayoutManager_Rule_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ControllerMapLayoutManager_Rule_Editor>>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_set_rules_Public_set_Void_List_1_ControllerMapLayoutManager_Rule_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x000B4E88 File Offset: 0x000B3088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289810, XrefRangeEnd = 289816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapLayoutManager_RuleSet_Editor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x000B4EC4 File Offset: 0x000B30C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289822, RefRangeEnd = 289824, XrefRangeStart = 289816, XrefRangeEnd = 289822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapLayoutManager_RuleSet_Editor(ControllerMapLayoutManager_RuleSet_Editor source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapLayoutManager_RuleSet_Editor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr__ctor_Public_Void_ControllerMapLayoutManager_RuleSet_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x000B4F10 File Offset: 0x000B3110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289824, XrefRangeEnd = 289828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapLayoutManager_RuleSet_Editor Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_Clone_Internal_ControllerMapLayoutManager_RuleSet_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMapLayoutManager_RuleSet_Editor>(intPtr3) : null;
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x000B4F50 File Offset: 0x000B3150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289851, RefRangeEnd = 289852, XrefRangeStart = 289828, XrefRangeEnd = 289851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapLayoutManager.RuleSet ToRuntime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_RuleSet_Editor.NativeMethodInfoPtr_ToRuntime_Internal_RuleSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMapLayoutManager.RuleSet>(intPtr3) : null;
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x0000E4F9 File Offset: 0x0000C6F9
		public ControllerMapLayoutManager_RuleSet_Editor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x0600239C RID: 9116 RVA: 0x000B4F90 File Offset: 0x000B3190
		// (set) Token: 0x0600239D RID: 9117 RVA: 0x0000E502 File Offset: 0x0000C702
		public unsafe int _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager_RuleSet_Editor.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager_RuleSet_Editor.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x0600239E RID: 9118 RVA: 0x000B4FB8 File Offset: 0x000B31B8
		// (set) Token: 0x0600239F RID: 9119 RVA: 0x0000E51D File Offset: 0x0000C71D
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager_RuleSet_Editor.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager_RuleSet_Editor.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x000B4FE0 File Offset: 0x000B31E0
		// (set) Token: 0x060023A1 RID: 9121 RVA: 0x0000E53C File Offset: 0x0000C73C
		public unsafe string _tag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager_RuleSet_Editor.NativeFieldInfoPtr__tag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager_RuleSet_Editor.NativeFieldInfoPtr__tag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x000B5008 File Offset: 0x000B3208
		// (set) Token: 0x060023A3 RID: 9123 RVA: 0x0000E55B File Offset: 0x0000C75B
		public unsafe List<ControllerMapLayoutManager_Rule_Editor> _rules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager_RuleSet_Editor.NativeFieldInfoPtr__rules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ControllerMapLayoutManager_Rule_Editor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager_RuleSet_Editor.NativeFieldInfoPtr__rules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D3A RID: 7482
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x04001D3B RID: 7483
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04001D3C RID: 7484
		private static readonly IntPtr NativeFieldInfoPtr__tag;

		// Token: 0x04001D3D RID: 7485
		private static readonly IntPtr NativeFieldInfoPtr__rules;

		// Token: 0x04001D3E RID: 7486
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04001D3F RID: 7487
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0;

		// Token: 0x04001D40 RID: 7488
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04001D41 RID: 7489
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x04001D42 RID: 7490
		private static readonly IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;

		// Token: 0x04001D43 RID: 7491
		private static readonly IntPtr NativeMethodInfoPtr_set_tag_Public_set_Void_String_0;

		// Token: 0x04001D44 RID: 7492
		private static readonly IntPtr NativeMethodInfoPtr_get_rules_Public_get_List_1_ControllerMapLayoutManager_Rule_Editor_0;

		// Token: 0x04001D45 RID: 7493
		private static readonly IntPtr NativeMethodInfoPtr_set_rules_Public_set_Void_List_1_ControllerMapLayoutManager_Rule_Editor_0;

		// Token: 0x04001D46 RID: 7494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D47 RID: 7495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ControllerMapLayoutManager_RuleSet_Editor_0;

		// Token: 0x04001D48 RID: 7496
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_ControllerMapLayoutManager_RuleSet_Editor_0;

		// Token: 0x04001D49 RID: 7497
		private static readonly IntPtr NativeMethodInfoPtr_ToRuntime_Internal_RuleSet_0;
	}
}
