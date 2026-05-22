using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x020000A1 RID: 161
	[Serializable]
	public sealed class ActionCategoryMap : Object
	{
		// Token: 0x0600141B RID: 5147 RVA: 0x0007842C File Offset: 0x0007662C
		// Note: this type is marked as 'beforefieldinit'.
		static ActionCategoryMap()
		{
			Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "ActionCategoryMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr);
			ActionCategoryMap.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, "list");
			ActionCategoryMap.NativeMethodInfoPtr_ActionIdsInCategory_Public_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, 100666669);
			ActionCategoryMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, 100666670);
			ActionCategoryMap.NativeMethodInfoPtr__ctor_Public_Void_ActionCategoryMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, 100666671);
			ActionCategoryMap.NativeMethodInfoPtr_AddCategory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, 100666672);
			ActionCategoryMap.NativeMethodInfoPtr_RemoveCategory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, 100666673);
			ActionCategoryMap.NativeMethodInfoPtr_ReorderCategory_Public_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, 100666674);
			ActionCategoryMap.NativeMethodInfoPtr_ChangeCategory_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, 100666675);
			ActionCategoryMap.NativeMethodInfoPtr_IndexOfCategory_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, 100666676);
			ActionCategoryMap.NativeMethodInfoPtr_AddAction_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, 100666677);
			ActionCategoryMap.NativeMethodInfoPtr_InsertAction_Public_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, 100666678);
			ActionCategoryMap.NativeMethodInfoPtr_ReorderAction_Public_Boolean_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, 100666679);
			ActionCategoryMap.NativeMethodInfoPtr_RemoveAction_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, 100666680);
			ActionCategoryMap.NativeMethodInfoPtr_IndexOfAction_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, 100666681);
			ActionCategoryMap.NativeMethodInfoPtr_Clone_Public_ActionCategoryMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, 100666682);
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00078588 File Offset: 0x00076788
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 265137, RefRangeEnd = 265144, XrefRangeStart = 265132, XrefRangeEnd = 265137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<int> ActionIdsInCategory(int categoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref categoryId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.NativeMethodInfoPtr_ActionIdsInCategory_Public_IEnumerable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x000785D4 File Offset: 0x000767D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265144, XrefRangeEnd = 265150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionCategoryMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00078610 File Offset: 0x00076810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265166, RefRangeEnd = 265167, XrefRangeStart = 265150, XrefRangeEnd = 265166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionCategoryMap(ActionCategoryMap source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.NativeMethodInfoPtr__ctor_Public_Void_ActionCategoryMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x0007865C File Offset: 0x0007685C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 265180, RefRangeEnd = 265185, XrefRangeStart = 265167, XrefRangeEnd = 265180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCategory(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.NativeMethodInfoPtr_AddCategory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0007869C File Offset: 0x0007689C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265185, XrefRangeEnd = 265189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCategory(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.NativeMethodInfoPtr_RemoveCategory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x000786DC File Offset: 0x000768DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265189, XrefRangeEnd = 265198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReorderCategory(int id, bool offsetDown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.NativeMethodInfoPtr_ReorderCategory_Public_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00078734 File Offset: 0x00076934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265198, XrefRangeEnd = 265205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ChangeCategory(int actionId, int newCategoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newCategoryId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.NativeMethodInfoPtr_ChangeCategory_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0007878C File Offset: 0x0007698C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 265208, RefRangeEnd = 265218, XrefRangeStart = 265205, XrefRangeEnd = 265208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfCategory(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.NativeMethodInfoPtr_IndexOfCategory_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x000787D8 File Offset: 0x000769D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 265221, RefRangeEnd = 265224, XrefRangeStart = 265218, XrefRangeEnd = 265221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddAction(int categoryId, int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref categoryId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.NativeMethodInfoPtr_AddAction_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00078830 File Offset: 0x00076A30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265236, RefRangeEnd = 265238, XrefRangeStart = 265224, XrefRangeEnd = 265236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InsertAction(int categoryId, int actionId, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref categoryId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.NativeMethodInfoPtr_InsertAction_Public_Boolean_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x00078898 File Offset: 0x00076A98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265244, RefRangeEnd = 265245, XrefRangeStart = 265238, XrefRangeEnd = 265244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReorderAction(int categoryId, int actionId, bool offsetDown, bool offsetNow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref categoryId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetDown;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetNow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.NativeMethodInfoPtr_ReorderAction_Public_Boolean_Int32_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x0007890C File Offset: 0x00076B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265245, XrefRangeEnd = 265250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAction(int categoryId, int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref categoryId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.NativeMethodInfoPtr_RemoveAction_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00078958 File Offset: 0x00076B58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265253, RefRangeEnd = 265255, XrefRangeStart = 265250, XrefRangeEnd = 265253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfAction(int categoryId, int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref categoryId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.NativeMethodInfoPtr_IndexOfAction_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x000789B0 File Offset: 0x00076BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265255, XrefRangeEnd = 265259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionCategoryMap Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.NativeMethodInfoPtr_Clone_Public_ActionCategoryMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionCategoryMap>(intPtr3) : null;
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00008C6D File Offset: 0x00006E6D
		public ActionCategoryMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x000789F0 File Offset: 0x00076BF0
		// (set) Token: 0x0600142C RID: 5164 RVA: 0x00008C76 File Offset: 0x00006E76
		public unsafe List<ActionCategoryMap.Entry> list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.NativeFieldInfoPtr_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ActionCategoryMap.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeFieldInfoPtr_list;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeMethodInfoPtr_ActionIdsInCategory_Public_IEnumerable_1_Int32_Int32_0;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ActionCategoryMap_0;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeMethodInfoPtr_AddCategory_Public_Void_Int32_0;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCategory_Public_Void_Int32_0;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeMethodInfoPtr_ReorderCategory_Public_Boolean_Int32_Boolean_0;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCategory_Public_Boolean_Int32_Int32_0;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfCategory_Public_Int32_Int32_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr_AddAction_Public_Boolean_Int32_Int32_0;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr_InsertAction_Public_Boolean_Int32_Int32_Int32_0;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr_ReorderAction_Public_Boolean_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAction_Public_Void_Int32_Int32_0;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAction_Public_Int32_Int32_Int32_0;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_ActionCategoryMap_0;

		// Token: 0x020002CC RID: 716
		[Serializable]
		public class Entry : Object
		{
			// Token: 0x06003E3C RID: 15932 RVA: 0x00126CB0 File Offset: 0x00124EB0
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr);
				ActionCategoryMap.Entry.NativeFieldInfoPtr_categoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr, "categoryId");
				ActionCategoryMap.Entry.NativeFieldInfoPtr_actionIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr, "actionIds");
				ActionCategoryMap.Entry.NativeMethodInfoPtr_get_ActionIds_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr, 100666683);
				ActionCategoryMap.Entry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr, 100666684);
				ActionCategoryMap.Entry.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr, 100666685);
				ActionCategoryMap.Entry.NativeMethodInfoPtr__ctor_Public_Void_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr, 100666686);
				ActionCategoryMap.Entry.NativeMethodInfoPtr_AddAction_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr, 100666687);
				ActionCategoryMap.Entry.NativeMethodInfoPtr_InsertAction_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr, 100666688);
				ActionCategoryMap.Entry.NativeMethodInfoPtr_ReorderAction_Public_Boolean_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr, 100666689);
				ActionCategoryMap.Entry.NativeMethodInfoPtr_RemoveAction_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr, 100666690);
				ActionCategoryMap.Entry.NativeMethodInfoPtr_IndexOfAction_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr, 100666691);
				ActionCategoryMap.Entry.NativeMethodInfoPtr_ContainsAction_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr, 100666692);
				ActionCategoryMap.Entry.NativeMethodInfoPtr_Clone_Public_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr, 100666693);
			}

			// Token: 0x17001321 RID: 4897
			// (get) Token: 0x06003E3D RID: 15933 RVA: 0x00126DE0 File Offset: 0x00124FE0
			public unsafe IEnumerable<int> ActionIds
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265027, XrefRangeEnd = 265032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.NativeMethodInfoPtr_get_ActionIds_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x06003E3E RID: 15934 RVA: 0x00126E20 File Offset: 0x00125020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265032, XrefRangeEnd = 265038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E3F RID: 15935 RVA: 0x00126E5C File Offset: 0x0012505C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265038, XrefRangeEnd = 265044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry(int categoryId)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref categoryId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E40 RID: 15936 RVA: 0x00126EA4 File Offset: 0x001250A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265044, XrefRangeEnd = 265046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry(ActionCategoryMap.Entry source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.NativeMethodInfoPtr__ctor_Public_Void_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E41 RID: 15937 RVA: 0x00126EF0 File Offset: 0x001250F0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 265051, RefRangeEnd = 265054, XrefRangeStart = 265046, XrefRangeEnd = 265051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddAction(int actionId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref actionId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.NativeMethodInfoPtr_AddAction_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E42 RID: 15938 RVA: 0x00126F30 File Offset: 0x00125130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265054, XrefRangeEnd = 265060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool InsertAction(int actionId, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref actionId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.NativeMethodInfoPtr_InsertAction_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E43 RID: 15939 RVA: 0x00126F88 File Offset: 0x00125188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265060, XrefRangeEnd = 265064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ReorderAction(int actionId, bool offsetDown, bool offsetNow)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref actionId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetDown;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetNow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.NativeMethodInfoPtr_ReorderAction_Public_Boolean_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003E44 RID: 15940 RVA: 0x00126FF0 File Offset: 0x001251F0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 265067, RefRangeEnd = 265069, XrefRangeStart = 265064, XrefRangeEnd = 265067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveAction(int actionId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref actionId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.NativeMethodInfoPtr_RemoveAction_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E45 RID: 15941 RVA: 0x00127030 File Offset: 0x00125230
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 265072, RefRangeEnd = 265081, XrefRangeStart = 265069, XrefRangeEnd = 265072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int IndexOfAction(int id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.NativeMethodInfoPtr_IndexOfAction_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003E46 RID: 15942 RVA: 0x0012707C File Offset: 0x0012527C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265081, XrefRangeEnd = 265082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ContainsAction(int id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.NativeMethodInfoPtr_ContainsAction_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003E47 RID: 15943 RVA: 0x001270C8 File Offset: 0x001252C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265082, XrefRangeEnd = 265087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActionCategoryMap.Entry Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.NativeMethodInfoPtr_Clone_Public_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionCategoryMap.Entry>(intPtr3) : null;
			}

			// Token: 0x06003E48 RID: 15944 RVA: 0x000165E9 File Offset: 0x000147E9
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700131F RID: 4895
			// (get) Token: 0x06003E49 RID: 15945 RVA: 0x00127108 File Offset: 0x00125308
			// (set) Token: 0x06003E4A RID: 15946 RVA: 0x000165F2 File Offset: 0x000147F2
			public unsafe int categoryId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.Entry.NativeFieldInfoPtr_categoryId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.Entry.NativeFieldInfoPtr_categoryId)) = value;
				}
			}

			// Token: 0x17001320 RID: 4896
			// (get) Token: 0x06003E4B RID: 15947 RVA: 0x00127130 File Offset: 0x00125330
			// (set) Token: 0x06003E4C RID: 15948 RVA: 0x0001660D File Offset: 0x0001480D
			public unsafe List<int> actionIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.Entry.NativeFieldInfoPtr_actionIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.Entry.NativeFieldInfoPtr_actionIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400337A RID: 13178
			private static readonly IntPtr NativeFieldInfoPtr_categoryId;

			// Token: 0x0400337B RID: 13179
			private static readonly IntPtr NativeFieldInfoPtr_actionIds;

			// Token: 0x0400337C RID: 13180
			private static readonly IntPtr NativeMethodInfoPtr_get_ActionIds_Public_get_IEnumerable_1_Int32_0;

			// Token: 0x0400337D RID: 13181
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400337E RID: 13182
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400337F RID: 13183
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entry_0;

			// Token: 0x04003380 RID: 13184
			private static readonly IntPtr NativeMethodInfoPtr_AddAction_Public_Void_Int32_0;

			// Token: 0x04003381 RID: 13185
			private static readonly IntPtr NativeMethodInfoPtr_InsertAction_Public_Boolean_Int32_Int32_0;

			// Token: 0x04003382 RID: 13186
			private static readonly IntPtr NativeMethodInfoPtr_ReorderAction_Public_Boolean_Int32_Boolean_Boolean_0;

			// Token: 0x04003383 RID: 13187
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAction_Public_Void_Int32_0;

			// Token: 0x04003384 RID: 13188
			private static readonly IntPtr NativeMethodInfoPtr_IndexOfAction_Public_Int32_Int32_0;

			// Token: 0x04003385 RID: 13189
			private static readonly IntPtr NativeMethodInfoPtr_ContainsAction_Public_Boolean_Int32_0;

			// Token: 0x04003386 RID: 13190
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Entry_0;

			// Token: 0x020004DA RID: 1242
			public sealed class CTxLehiOhOfNxsHDPcOHHgpHGfd : Object
			{
				// Token: 0x060052EE RID: 21230 RVA: 0x001778B0 File Offset: 0x00175AB0
				// Note: this type is marked as 'beforefieldinit'.
				static CTxLehiOhOfNxsHDPcOHHgpHGfd()
				{
					Il2CppClassPointerStore<ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionCategoryMap.Entry>.NativeClassPtr, "CTxLehiOhOfNxsHDPcOHHgpHGfd");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd>.NativeClassPtr);
					ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
					ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
					ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
					ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
					ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeFieldInfoPtr_OhqAoLlnoapbTckALLtbqteoqaK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd>.NativeClassPtr, "OhqAoLlnoapbTckALLtbqteoqaK");
					ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd>.NativeClassPtr, 100666694);
					ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd>.NativeClassPtr, 100666695);
					ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd>.NativeClassPtr, 100666696);
					ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd>.NativeClassPtr, 100666697);
					ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd>.NativeClassPtr, 100666698);
					ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd>.NativeClassPtr, 100666699);
					ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd>.NativeClassPtr, 100666700);
					ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd>.NativeClassPtr, 100666701);
				}

				// Token: 0x060052EF RID: 21231 RVA: 0x001779E0 File Offset: 0x00175BE0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265011, XrefRangeEnd = 265014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator<int> System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<int>>(intPtr3) : null;
				}

				// Token: 0x060052F0 RID: 21232 RVA: 0x00177A20 File Offset: 0x00175C20
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}

				// Token: 0x060052F1 RID: 21233 RVA: 0x00177A60 File Offset: 0x00175C60
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265014, XrefRangeEnd = 265017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700196C RID: 6508
				// (get) Token: 0x060052F2 RID: 21234 RVA: 0x00177A9C File Offset: 0x00175C9C
				public unsafe int rFppGPUNmHbdxJDRqpDvUtzaAPu
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060052F3 RID: 21235 RVA: 0x00177AD8 File Offset: 0x00175CD8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265017, XrefRangeEnd = 265022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060052F4 RID: 21236 RVA: 0x00177B0C File Offset: 0x00175D0C
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700196D RID: 6509
				// (get) Token: 0x060052F5 RID: 21237 RVA: 0x00177B40 File Offset: 0x00175D40
				public unsafe Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265022, XrefRangeEnd = 265025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060052F6 RID: 21238 RVA: 0x00177B80 File Offset: 0x00175D80
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265025, XrefRangeEnd = 265027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe CTxLehiOhOfNxsHDPcOHHgpHGfd(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060052F7 RID: 21239 RVA: 0x0001DF83 File Offset: 0x0001C183
				public CTxLehiOhOfNxsHDPcOHHgpHGfd(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001967 RID: 6503
				// (get) Token: 0x060052F8 RID: 21240 RVA: 0x00177BC8 File Offset: 0x00175DC8
				// (set) Token: 0x060052F9 RID: 21241 RVA: 0x0001DF8C File Offset: 0x0001C18C
				public unsafe int NuVnrlTavvGYEgMZhwgjSLwilSSG
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG)) = value;
					}
				}

				// Token: 0x17001968 RID: 6504
				// (get) Token: 0x060052FA RID: 21242 RVA: 0x00177BF0 File Offset: 0x00175DF0
				// (set) Token: 0x060052FB RID: 21243 RVA: 0x0001DFA7 File Offset: 0x0001C1A7
				public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
					}
				}

				// Token: 0x17001969 RID: 6505
				// (get) Token: 0x060052FC RID: 21244 RVA: 0x00177C18 File Offset: 0x00175E18
				// (set) Token: 0x060052FD RID: 21245 RVA: 0x0001DFC2 File Offset: 0x0001C1C2
				public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
					}
				}

				// Token: 0x1700196A RID: 6506
				// (get) Token: 0x060052FE RID: 21246 RVA: 0x00177C40 File Offset: 0x00175E40
				// (set) Token: 0x060052FF RID: 21247 RVA: 0x0001DFDD File Offset: 0x0001C1DD
				public unsafe ActionCategoryMap.Entry HbFBVXVdulMdGSmvVCgeOcAyoyn
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionCategoryMap.Entry>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700196B RID: 6507
				// (get) Token: 0x06005300 RID: 21248 RVA: 0x00177C70 File Offset: 0x00175E70
				// (set) Token: 0x06005301 RID: 21249 RVA: 0x0001DFFC File Offset: 0x0001C1FC
				public unsafe int OhqAoLlnoapbTckALLtbqteoqaK
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeFieldInfoPtr_OhqAoLlnoapbTckALLtbqteoqaK);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.Entry.CTxLehiOhOfNxsHDPcOHHgpHGfd.NativeFieldInfoPtr_OhqAoLlnoapbTckALLtbqteoqaK)) = value;
					}
				}

				// Token: 0x04004585 RID: 17797
				private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

				// Token: 0x04004586 RID: 17798
				private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

				// Token: 0x04004587 RID: 17799
				private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

				// Token: 0x04004588 RID: 17800
				private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

				// Token: 0x04004589 RID: 17801
				private static readonly IntPtr NativeFieldInfoPtr_OhqAoLlnoapbTckALLtbqteoqaK;

				// Token: 0x0400458A RID: 17802
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0;

				// Token: 0x0400458B RID: 17803
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

				// Token: 0x0400458C RID: 17804
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400458D RID: 17805
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0;

				// Token: 0x0400458E RID: 17806
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400458F RID: 17807
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04004590 RID: 17808
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04004591 RID: 17809
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
			}
		}

		// Token: 0x020002CD RID: 717
		public sealed class omvRoeIdthADCDXJkqriWGUSOo : Object
		{
			// Token: 0x06003E4D RID: 15949 RVA: 0x00127160 File Offset: 0x00125360
			// Note: this type is marked as 'beforefieldinit'.
			static omvRoeIdthADCDXJkqriWGUSOo()
			{
				Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionCategoryMap>.NativeClassPtr, "omvRoeIdthADCDXJkqriWGUSOo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr);
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_KUKcasQBiqUSNJAcwoMVjrbRzJm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, "KUKcasQBiqUSNJAcwoMVjrbRzJm");
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_lGTASGhdOPzwNKTdfHhUjmYgcPnf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, "lGTASGhdOPzwNKTdfHhUjmYgcPnf");
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_neRpgAmWjkmPmmNJTKriHGQBYMR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, "neRpgAmWjkmPmmNJTKriHGQBYMR");
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_AZyOtohCDyspmduIkEALQPzwTQq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, "AZyOtohCDyspmduIkEALQPzwTQq");
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_hCZHtxbCjMMeLdTSELlNlJExQXHx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, "hCZHtxbCjMMeLdTSELlNlJExQXHx");
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, 100666702);
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, 100666703);
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, 100666704);
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, 100666705);
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, 100666706);
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, 100666707);
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, 100666708);
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, 100666709);
				ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr_fmTCpxhHCscZFeJLAfJlfuuJbHCL_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr, 100666710);
			}

			// Token: 0x06003E4E RID: 15950 RVA: 0x001272F4 File Offset: 0x001254F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265087, XrefRangeEnd = 265095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<int> System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<int>>(intPtr3) : null;
			}

			// Token: 0x06003E4F RID: 15951 RVA: 0x00127334 File Offset: 0x00125534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003E50 RID: 15952 RVA: 0x00127374 File Offset: 0x00125574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265095, XrefRangeEnd = 265116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700132B RID: 4907
			// (get) Token: 0x06003E51 RID: 15953 RVA: 0x001273B0 File Offset: 0x001255B0
			public unsafe int rFppGPUNmHbdxJDRqpDvUtzaAPu
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003E52 RID: 15954 RVA: 0x001273EC File Offset: 0x001255EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265116, XrefRangeEnd = 265121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E53 RID: 15955 RVA: 0x00127420 File Offset: 0x00125620
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 265124, RefRangeEnd = 265125, XrefRangeStart = 265121, XrefRangeEnd = 265124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700132C RID: 4908
			// (get) Token: 0x06003E54 RID: 15956 RVA: 0x00127454 File Offset: 0x00125654
			public unsafe Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265125, XrefRangeEnd = 265128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003E55 RID: 15957 RVA: 0x00127494 File Offset: 0x00125694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe omvRoeIdthADCDXJkqriWGUSOo(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003E56 RID: 15958 RVA: 0x001274DC File Offset: 0x001256DC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 265131, RefRangeEnd = 265132, XrefRangeStart = 265128, XrefRangeEnd = 265131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void fmTCpxhHCscZFeJLAfJlfuuJbHCL()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeMethodInfoPtr_fmTCpxhHCscZFeJLAfJlfuuJbHCL_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E57 RID: 15959 RVA: 0x0001662C File Offset: 0x0001482C
			public omvRoeIdthADCDXJkqriWGUSOo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001322 RID: 4898
			// (get) Token: 0x06003E58 RID: 15960 RVA: 0x00127510 File Offset: 0x00125710
			// (set) Token: 0x06003E59 RID: 15961 RVA: 0x00016635 File Offset: 0x00014835
			public unsafe int NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG)) = value;
				}
			}

			// Token: 0x17001323 RID: 4899
			// (get) Token: 0x06003E5A RID: 15962 RVA: 0x00127538 File Offset: 0x00125738
			// (set) Token: 0x06003E5B RID: 15963 RVA: 0x00016650 File Offset: 0x00014850
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x17001324 RID: 4900
			// (get) Token: 0x06003E5C RID: 15964 RVA: 0x00127560 File Offset: 0x00125760
			// (set) Token: 0x06003E5D RID: 15965 RVA: 0x0001666B File Offset: 0x0001486B
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x17001325 RID: 4901
			// (get) Token: 0x06003E5E RID: 15966 RVA: 0x00127588 File Offset: 0x00125788
			// (set) Token: 0x06003E5F RID: 15967 RVA: 0x00016686 File Offset: 0x00014886
			public unsafe ActionCategoryMap HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionCategoryMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001326 RID: 4902
			// (get) Token: 0x06003E60 RID: 15968 RVA: 0x001275B8 File Offset: 0x001257B8
			// (set) Token: 0x06003E61 RID: 15969 RVA: 0x000166A5 File Offset: 0x000148A5
			public unsafe int KUKcasQBiqUSNJAcwoMVjrbRzJm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_KUKcasQBiqUSNJAcwoMVjrbRzJm);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_KUKcasQBiqUSNJAcwoMVjrbRzJm)) = value;
				}
			}

			// Token: 0x17001327 RID: 4903
			// (get) Token: 0x06003E62 RID: 15970 RVA: 0x001275E0 File Offset: 0x001257E0
			// (set) Token: 0x06003E63 RID: 15971 RVA: 0x000166C0 File Offset: 0x000148C0
			public unsafe int lGTASGhdOPzwNKTdfHhUjmYgcPnf
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_lGTASGhdOPzwNKTdfHhUjmYgcPnf);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_lGTASGhdOPzwNKTdfHhUjmYgcPnf)) = value;
				}
			}

			// Token: 0x17001328 RID: 4904
			// (get) Token: 0x06003E64 RID: 15972 RVA: 0x00127608 File Offset: 0x00125808
			// (set) Token: 0x06003E65 RID: 15973 RVA: 0x000166DB File Offset: 0x000148DB
			public unsafe int neRpgAmWjkmPmmNJTKriHGQBYMR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_neRpgAmWjkmPmmNJTKriHGQBYMR);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_neRpgAmWjkmPmmNJTKriHGQBYMR)) = value;
				}
			}

			// Token: 0x17001329 RID: 4905
			// (get) Token: 0x06003E66 RID: 15974 RVA: 0x00127630 File Offset: 0x00125830
			// (set) Token: 0x06003E67 RID: 15975 RVA: 0x000166F6 File Offset: 0x000148F6
			public unsafe int AZyOtohCDyspmduIkEALQPzwTQq
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_AZyOtohCDyspmduIkEALQPzwTQq);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_AZyOtohCDyspmduIkEALQPzwTQq)) = value;
				}
			}

			// Token: 0x1700132A RID: 4906
			// (get) Token: 0x06003E68 RID: 15976 RVA: 0x00127658 File Offset: 0x00125858
			// (set) Token: 0x06003E69 RID: 15977 RVA: 0x00016711 File Offset: 0x00014911
			public unsafe IEnumerator<int> hCZHtxbCjMMeLdTSELlNlJExQXHx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_hCZHtxbCjMMeLdTSELlNlJExQXHx);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionCategoryMap.omvRoeIdthADCDXJkqriWGUSOo.NativeFieldInfoPtr_hCZHtxbCjMMeLdTSELlNlJExQXHx), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003387 RID: 13191
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04003388 RID: 13192
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04003389 RID: 13193
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x0400338A RID: 13194
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x0400338B RID: 13195
			private static readonly IntPtr NativeFieldInfoPtr_KUKcasQBiqUSNJAcwoMVjrbRzJm;

			// Token: 0x0400338C RID: 13196
			private static readonly IntPtr NativeFieldInfoPtr_lGTASGhdOPzwNKTdfHhUjmYgcPnf;

			// Token: 0x0400338D RID: 13197
			private static readonly IntPtr NativeFieldInfoPtr_neRpgAmWjkmPmmNJTKriHGQBYMR;

			// Token: 0x0400338E RID: 13198
			private static readonly IntPtr NativeFieldInfoPtr_AZyOtohCDyspmduIkEALQPzwTQq;

			// Token: 0x0400338F RID: 13199
			private static readonly IntPtr NativeFieldInfoPtr_hCZHtxbCjMMeLdTSELlNlJExQXHx;

			// Token: 0x04003390 RID: 13200
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0;

			// Token: 0x04003391 RID: 13201
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04003392 RID: 13202
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003393 RID: 13203
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04003394 RID: 13204
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003395 RID: 13205
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003396 RID: 13206
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003397 RID: 13207
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003398 RID: 13208
			private static readonly IntPtr NativeMethodInfoPtr_fmTCpxhHCscZFeJLAfJlfuuJbHCL_Private_Void_0;
		}
	}
}
