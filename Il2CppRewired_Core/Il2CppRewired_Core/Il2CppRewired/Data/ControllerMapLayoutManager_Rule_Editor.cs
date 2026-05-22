using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Data
{
	// Token: 0x02000145 RID: 325
	[Serializable]
	public sealed class ControllerMapLayoutManager_Rule_Editor : Object
	{
		// Token: 0x060023A4 RID: 9124 RVA: 0x000B5038 File Offset: 0x000B3238
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerMapLayoutManager_Rule_Editor()
		{
			Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data", "ControllerMapLayoutManager_Rule_Editor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr);
			ControllerMapLayoutManager_Rule_Editor.NativeFieldInfoPtr__tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr, "_tag");
			ControllerMapLayoutManager_Rule_Editor.NativeFieldInfoPtr__categoryIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr, "_categoryIds");
			ControllerMapLayoutManager_Rule_Editor.NativeFieldInfoPtr__layoutId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr, "_layoutId");
			ControllerMapLayoutManager_Rule_Editor.NativeFieldInfoPtr__controllerSetSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr, "_controllerSetSelector");
			ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr, 100670984);
			ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr, 100670985);
			ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_get_categoryIds_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr, 100670986);
			ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_set_categoryIds_Public_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr, 100670987);
			ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr, 100670988);
			ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_set_layoutId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr, 100670989);
			ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_get_controllerSetSelector_Public_get_ControllerSetSelector_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr, 100670990);
			ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_set_controllerSetSelector_Public_set_Void_ControllerSetSelector_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr, 100670991);
			ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr, 100670992);
			ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr__ctor_Public_Void_ControllerMapLayoutManager_Rule_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr, 100670993);
			ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_ToRuntime_Internal_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr, 100670994);
			ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr, 100670995);
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060023A5 RID: 9125 RVA: 0x000B51A8 File Offset: 0x000B33A8
		// (set) Token: 0x060023A6 RID: 9126 RVA: 0x000B51E0 File Offset: 0x000B33E0
		public unsafe string tag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060023A7 RID: 9127 RVA: 0x000B5224 File Offset: 0x000B3424
		// (set) Token: 0x060023A8 RID: 9128 RVA: 0x000B5264 File Offset: 0x000B3464
		public unsafe List<int> categoryIds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_get_categoryIds_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_set_categoryIds_Public_set_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x060023A9 RID: 9129 RVA: 0x000B52A8 File Offset: 0x000B34A8
		// (set) Token: 0x060023AA RID: 9130 RVA: 0x000B52E4 File Offset: 0x000B34E4
		public unsafe int layoutId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_set_layoutId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x060023AB RID: 9131 RVA: 0x000B5324 File Offset: 0x000B3524
		// (set) Token: 0x060023AC RID: 9132 RVA: 0x000B5364 File Offset: 0x000B3564
		public unsafe ControllerSetSelector_Editor controllerSetSelector
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_get_controllerSetSelector_Public_get_ControllerSetSelector_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector_Editor>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_set_controllerSetSelector_Public_set_Void_ControllerSetSelector_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x000B53A8 File Offset: 0x000B35A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289852, XrefRangeEnd = 289862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapLayoutManager_Rule_Editor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x000B53E4 File Offset: 0x000B35E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289870, RefRangeEnd = 289871, XrefRangeStart = 289862, XrefRangeEnd = 289870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapLayoutManager_Rule_Editor(ControllerMapLayoutManager_Rule_Editor source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapLayoutManager_Rule_Editor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr__ctor_Public_Void_ControllerMapLayoutManager_Rule_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x000B5430 File Offset: 0x000B3630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289881, RefRangeEnd = 289882, XrefRangeStart = 289871, XrefRangeEnd = 289881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapLayoutManager.Rule ToRuntime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_ToRuntime_Internal_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMapLayoutManager.Rule>(intPtr3) : null;
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x000B5470 File Offset: 0x000B3670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289882, XrefRangeEnd = 289886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Rewired_Utils_Interfaces_IDeepCloneable_DeepClone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager_Rule_Editor.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x0000E57A File Offset: 0x0000C77A
		public ControllerMapLayoutManager_Rule_Editor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x000B54B0 File Offset: 0x000B36B0
		// (set) Token: 0x060023B3 RID: 9139 RVA: 0x0000E583 File Offset: 0x0000C783
		public unsafe string _tag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager_Rule_Editor.NativeFieldInfoPtr__tag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager_Rule_Editor.NativeFieldInfoPtr__tag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x000B54D8 File Offset: 0x000B36D8
		// (set) Token: 0x060023B5 RID: 9141 RVA: 0x0000E5A2 File Offset: 0x0000C7A2
		public unsafe List<int> _categoryIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager_Rule_Editor.NativeFieldInfoPtr__categoryIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager_Rule_Editor.NativeFieldInfoPtr__categoryIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x000B5508 File Offset: 0x000B3708
		// (set) Token: 0x060023B7 RID: 9143 RVA: 0x0000E5C1 File Offset: 0x0000C7C1
		public unsafe int _layoutId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager_Rule_Editor.NativeFieldInfoPtr__layoutId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager_Rule_Editor.NativeFieldInfoPtr__layoutId)) = value;
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x000B5530 File Offset: 0x000B3730
		// (set) Token: 0x060023B9 RID: 9145 RVA: 0x0000E5DC File Offset: 0x0000C7DC
		public unsafe ControllerSetSelector_Editor _controllerSetSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager_Rule_Editor.NativeFieldInfoPtr__controllerSetSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector_Editor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager_Rule_Editor.NativeFieldInfoPtr__controllerSetSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D4A RID: 7498
		private static readonly IntPtr NativeFieldInfoPtr__tag;

		// Token: 0x04001D4B RID: 7499
		private static readonly IntPtr NativeFieldInfoPtr__categoryIds;

		// Token: 0x04001D4C RID: 7500
		private static readonly IntPtr NativeFieldInfoPtr__layoutId;

		// Token: 0x04001D4D RID: 7501
		private static readonly IntPtr NativeFieldInfoPtr__controllerSetSelector;

		// Token: 0x04001D4E RID: 7502
		private static readonly IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;

		// Token: 0x04001D4F RID: 7503
		private static readonly IntPtr NativeMethodInfoPtr_set_tag_Public_set_Void_String_0;

		// Token: 0x04001D50 RID: 7504
		private static readonly IntPtr NativeMethodInfoPtr_get_categoryIds_Public_get_List_1_Int32_0;

		// Token: 0x04001D51 RID: 7505
		private static readonly IntPtr NativeMethodInfoPtr_set_categoryIds_Public_set_Void_List_1_Int32_0;

		// Token: 0x04001D52 RID: 7506
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0;

		// Token: 0x04001D53 RID: 7507
		private static readonly IntPtr NativeMethodInfoPtr_set_layoutId_Public_set_Void_Int32_0;

		// Token: 0x04001D54 RID: 7508
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerSetSelector_Public_get_ControllerSetSelector_Editor_0;

		// Token: 0x04001D55 RID: 7509
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerSetSelector_Public_set_Void_ControllerSetSelector_Editor_0;

		// Token: 0x04001D56 RID: 7510
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D57 RID: 7511
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ControllerMapLayoutManager_Rule_Editor_0;

		// Token: 0x04001D58 RID: 7512
		private static readonly IntPtr NativeMethodInfoPtr_ToRuntime_Internal_Rule_0;

		// Token: 0x04001D59 RID: 7513
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0;
	}
}
