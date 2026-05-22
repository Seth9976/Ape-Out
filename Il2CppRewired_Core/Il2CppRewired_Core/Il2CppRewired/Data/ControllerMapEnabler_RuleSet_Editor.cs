using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Data
{
	// Token: 0x02000141 RID: 321
	[Serializable]
	public sealed class ControllerMapEnabler_RuleSet_Editor : Object
	{
		// Token: 0x0600233C RID: 9020 RVA: 0x000B37E4 File Offset: 0x000B19E4
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerMapEnabler_RuleSet_Editor()
		{
			Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data", "ControllerMapEnabler_RuleSet_Editor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr);
			ControllerMapEnabler_RuleSet_Editor.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr, "_id");
			ControllerMapEnabler_RuleSet_Editor.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr, "_name");
			ControllerMapEnabler_RuleSet_Editor.NativeFieldInfoPtr__tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr, "_tag");
			ControllerMapEnabler_RuleSet_Editor.NativeFieldInfoPtr__rules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr, "_rules");
			ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr, 100670876);
			ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr, 100670877);
			ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr, 100670878);
			ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr, 100670879);
			ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr, 100670880);
			ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr, 100670881);
			ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_get_rules_Public_get_List_1_ControllerMapEnabler_Rule_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr, 100670882);
			ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_set_rules_Public_set_Void_List_1_ControllerMapEnabler_Rule_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr, 100670883);
			ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr, 100670884);
			ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr__ctor_Public_Void_ControllerMapEnabler_RuleSet_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr, 100670885);
			ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_Clone_Internal_ControllerMapEnabler_RuleSet_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr, 100670886);
			ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_ToRuntime_Internal_RuleSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr, 100670887);
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x0600233D RID: 9021 RVA: 0x000B3954 File Offset: 0x000B1B54
		// (set) Token: 0x0600233E RID: 9022 RVA: 0x000B3990 File Offset: 0x000B1B90
		public unsafe int id
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x000B39D0 File Offset: 0x000B1BD0
		// (set) Token: 0x06002340 RID: 9024 RVA: 0x000B3A08 File Offset: 0x000B1C08
		public unsafe string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x000B3A4C File Offset: 0x000B1C4C
		// (set) Token: 0x06002342 RID: 9026 RVA: 0x000B3A84 File Offset: 0x000B1C84
		public unsafe string tag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x000B3AC8 File Offset: 0x000B1CC8
		// (set) Token: 0x06002344 RID: 9028 RVA: 0x000B3B08 File Offset: 0x000B1D08
		public unsafe List<ControllerMapEnabler_Rule_Editor> rules
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_get_rules_Public_get_List_1_ControllerMapEnabler_Rule_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ControllerMapEnabler_Rule_Editor>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_set_rules_Public_set_Void_List_1_ControllerMapEnabler_Rule_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x000B3B4C File Offset: 0x000B1D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288974, XrefRangeEnd = 288980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapEnabler_RuleSet_Editor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x000B3B88 File Offset: 0x000B1D88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288986, RefRangeEnd = 288988, XrefRangeStart = 288980, XrefRangeEnd = 288986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapEnabler_RuleSet_Editor(ControllerMapEnabler_RuleSet_Editor source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapEnabler_RuleSet_Editor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr__ctor_Public_Void_ControllerMapEnabler_RuleSet_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x000B3BD4 File Offset: 0x000B1DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288988, XrefRangeEnd = 288992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapEnabler_RuleSet_Editor Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_Clone_Internal_ControllerMapEnabler_RuleSet_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMapEnabler_RuleSet_Editor>(intPtr3) : null;
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x000B3C14 File Offset: 0x000B1E14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289015, RefRangeEnd = 289016, XrefRangeStart = 288992, XrefRangeEnd = 289015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapEnabler.RuleSet ToRuntime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_RuleSet_Editor.NativeMethodInfoPtr_ToRuntime_Internal_RuleSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMapEnabler.RuleSet>(intPtr3) : null;
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x0000E302 File Offset: 0x0000C502
		public ControllerMapEnabler_RuleSet_Editor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x000B3C54 File Offset: 0x000B1E54
		// (set) Token: 0x0600234B RID: 9035 RVA: 0x0000E30B File Offset: 0x0000C50B
		public unsafe int _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_RuleSet_Editor.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_RuleSet_Editor.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x0600234C RID: 9036 RVA: 0x000B3C7C File Offset: 0x000B1E7C
		// (set) Token: 0x0600234D RID: 9037 RVA: 0x0000E326 File Offset: 0x0000C526
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_RuleSet_Editor.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_RuleSet_Editor.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x0600234E RID: 9038 RVA: 0x000B3CA4 File Offset: 0x000B1EA4
		// (set) Token: 0x0600234F RID: 9039 RVA: 0x0000E345 File Offset: 0x0000C545
		public unsafe string _tag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_RuleSet_Editor.NativeFieldInfoPtr__tag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_RuleSet_Editor.NativeFieldInfoPtr__tag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x000B3CCC File Offset: 0x000B1ECC
		// (set) Token: 0x06002351 RID: 9041 RVA: 0x0000E364 File Offset: 0x0000C564
		public unsafe List<ControllerMapEnabler_Rule_Editor> _rules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_RuleSet_Editor.NativeFieldInfoPtr__rules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ControllerMapEnabler_Rule_Editor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_RuleSet_Editor.NativeFieldInfoPtr__rules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CFE RID: 7422
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x04001CFF RID: 7423
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04001D00 RID: 7424
		private static readonly IntPtr NativeFieldInfoPtr__tag;

		// Token: 0x04001D01 RID: 7425
		private static readonly IntPtr NativeFieldInfoPtr__rules;

		// Token: 0x04001D02 RID: 7426
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04001D03 RID: 7427
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0;

		// Token: 0x04001D04 RID: 7428
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04001D05 RID: 7429
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x04001D06 RID: 7430
		private static readonly IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;

		// Token: 0x04001D07 RID: 7431
		private static readonly IntPtr NativeMethodInfoPtr_set_tag_Public_set_Void_String_0;

		// Token: 0x04001D08 RID: 7432
		private static readonly IntPtr NativeMethodInfoPtr_get_rules_Public_get_List_1_ControllerMapEnabler_Rule_Editor_0;

		// Token: 0x04001D09 RID: 7433
		private static readonly IntPtr NativeMethodInfoPtr_set_rules_Public_set_Void_List_1_ControllerMapEnabler_Rule_Editor_0;

		// Token: 0x04001D0A RID: 7434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D0B RID: 7435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ControllerMapEnabler_RuleSet_Editor_0;

		// Token: 0x04001D0C RID: 7436
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_ControllerMapEnabler_RuleSet_Editor_0;

		// Token: 0x04001D0D RID: 7437
		private static readonly IntPtr NativeMethodInfoPtr_ToRuntime_Internal_RuleSet_0;
	}
}
