using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppRewired
{
	// Token: 0x0200015A RID: 346
	[Serializable]
	public sealed class InputMapCategory : InputCategory
	{
		// Token: 0x06002703 RID: 9987 RVA: 0x000C5B54 File Offset: 0x000C3D54
		// Note: this type is marked as 'beforefieldinit'.
		static InputMapCategory()
		{
			Il2CppClassPointerStore<InputMapCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "InputMapCategory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMapCategory>.NativeClassPtr);
			InputMapCategory.NativeFieldInfoPtr__checkConflictsWithAllCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapCategory>.NativeClassPtr, "_checkConflictsWithAllCategories");
			InputMapCategory.NativeFieldInfoPtr__checkConflictsCategoryIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapCategory>.NativeClassPtr, "_checkConflictsCategoryIds");
			InputMapCategory.NativeFieldInfoPtr__checkConflictsCategoryIds_readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapCategory>.NativeClassPtr, "_checkConflictsCategoryIds_readOnly");
			InputMapCategory.NativeMethodInfoPtr_get_checkConflictsWithAllCategories_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapCategory>.NativeClassPtr, 100671676);
			InputMapCategory.NativeMethodInfoPtr_set_checkConflictsWithAllCategories_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapCategory>.NativeClassPtr, 100671677);
			InputMapCategory.NativeMethodInfoPtr_get_checkConflictsCategoryIds_Public_get_IList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapCategory>.NativeClassPtr, 100671678);
			InputMapCategory.NativeMethodInfoPtr_get_checkConflictsCategoryIds_orig_Internal_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapCategory>.NativeClassPtr, 100671679);
			InputMapCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapCategory>.NativeClassPtr, 100671680);
			InputMapCategory.NativeMethodInfoPtr__ctor_Public_Void_InputMapCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapCategory>.NativeClassPtr, 100671681);
			InputMapCategory.NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapCategory>.NativeClassPtr, 100671682);
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06002704 RID: 9988 RVA: 0x000C5C4C File Offset: 0x000C3E4C
		// (set) Token: 0x06002705 RID: 9989 RVA: 0x000C5C88 File Offset: 0x000C3E88
		public unsafe bool checkConflictsWithAllCategories
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapCategory.NativeMethodInfoPtr_get_checkConflictsWithAllCategories_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapCategory.NativeMethodInfoPtr_set_checkConflictsWithAllCategories_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06002706 RID: 9990 RVA: 0x000C5CC8 File Offset: 0x000C3EC8
		public unsafe IList<int> checkConflictsCategoryIds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapCategory.NativeMethodInfoPtr_get_checkConflictsCategoryIds_Public_get_IList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06002707 RID: 9991 RVA: 0x000C5D08 File Offset: 0x000C3F08
		public unsafe List<int> checkConflictsCategoryIds_orig
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapCategory.NativeMethodInfoPtr_get_checkConflictsCategoryIds_orig_Internal_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x000C5D48 File Offset: 0x000C3F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295081, XrefRangeEnd = 295087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputMapCategory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapCategory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x000C5D84 File Offset: 0x000C3F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295087, XrefRangeEnd = 295090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputMapCategory(InputMapCategory source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapCategory>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapCategory.NativeMethodInfoPtr__ctor_Public_Void_InputMapCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x000C5DD0 File Offset: 0x000C3FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295090, XrefRangeEnd = 295094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dwHOFmApnpWkXreTmwZYsRXRrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputMapCategory.NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x0000F464 File Offset: 0x0000D664
		public InputMapCategory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x0600270C RID: 9996 RVA: 0x000C5E04 File Offset: 0x000C4004
		// (set) Token: 0x0600270D RID: 9997 RVA: 0x0000F46D File Offset: 0x0000D66D
		public unsafe bool _checkConflictsWithAllCategories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapCategory.NativeFieldInfoPtr__checkConflictsWithAllCategories);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapCategory.NativeFieldInfoPtr__checkConflictsWithAllCategories)) = value;
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x0600270E RID: 9998 RVA: 0x000C5E2C File Offset: 0x000C402C
		// (set) Token: 0x0600270F RID: 9999 RVA: 0x0000F488 File Offset: 0x0000D688
		public unsafe List<int> _checkConflictsCategoryIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapCategory.NativeFieldInfoPtr__checkConflictsCategoryIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapCategory.NativeFieldInfoPtr__checkConflictsCategoryIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x000C5E5C File Offset: 0x000C405C
		// (set) Token: 0x06002711 RID: 10001 RVA: 0x0000F4A7 File Offset: 0x0000D6A7
		public unsafe ReadOnlyCollection<int> _checkConflictsCategoryIds_readOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapCategory.NativeFieldInfoPtr__checkConflictsCategoryIds_readOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputMapCategory.NativeFieldInfoPtr__checkConflictsCategoryIds_readOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002001 RID: 8193
		private static readonly IntPtr NativeFieldInfoPtr__checkConflictsWithAllCategories;

		// Token: 0x04002002 RID: 8194
		private static readonly IntPtr NativeFieldInfoPtr__checkConflictsCategoryIds;

		// Token: 0x04002003 RID: 8195
		private static readonly IntPtr NativeFieldInfoPtr__checkConflictsCategoryIds_readOnly;

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeMethodInfoPtr_get_checkConflictsWithAllCategories_Public_get_Boolean_0;

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeMethodInfoPtr_set_checkConflictsWithAllCategories_Internal_set_Void_Boolean_0;

		// Token: 0x04002006 RID: 8198
		private static readonly IntPtr NativeMethodInfoPtr_get_checkConflictsCategoryIds_Public_get_IList_1_Int32_0;

		// Token: 0x04002007 RID: 8199
		private static readonly IntPtr NativeMethodInfoPtr_get_checkConflictsCategoryIds_orig_Internal_get_List_1_Int32_0;

		// Token: 0x04002008 RID: 8200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002009 RID: 8201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputMapCategory_0;

		// Token: 0x0400200A RID: 8202
		private static readonly IntPtr NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Internal_Void_0;
	}
}
