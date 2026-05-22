using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000058 RID: 88
	[Serializable]
	public class GroupCollection : Object
	{
		// Token: 0x0600058C RID: 1420 RVA: 0x00025FA4 File Offset: 0x000241A4
		// Note: this type is marked as 'beforefieldinit'.
		static GroupCollection()
		{
			Il2CppClassPointerStore<GroupCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "GroupCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr);
			GroupCollection.NativeFieldInfoPtr__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, "_match");
			GroupCollection.NativeFieldInfoPtr__captureMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, "_captureMap");
			GroupCollection.NativeFieldInfoPtr__groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, "_groups");
			GroupCollection.NativeMethodInfoPtr__ctor_Internal_Void_Match_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664157);
			GroupCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664158);
			GroupCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664159);
			GroupCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664160);
			GroupCollection.NativeMethodInfoPtr_get_Item_Public_get_Group_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664161);
			GroupCollection.NativeMethodInfoPtr_GetGroup_Internal_Group_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664162);
			GroupCollection.NativeMethodInfoPtr_GetGroupImpl_Internal_Group_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664163);
			GroupCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664164);
			GroupCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664165);
			GroupCollection.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664166);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x000260D8 File Offset: 0x000242D8
		[CallerCount(76)]
		[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GroupCollection(Match match, Hashtable caps)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr__ctor_Internal_Void_Match_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00026138 File Offset: 0x00024338
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00026178 File Offset: 0x00024378
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x000261B4 File Offset: 0x000243B4
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B8 RID: 440
		public unsafe Group this[int groupnum]
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 370578, RefRangeEnd = 370588, XrefRangeStart = 370568, XrefRangeEnd = 370578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref groupnum;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_get_Item_Public_get_Group_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Group>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0002623C File Offset: 0x0002443C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370588, XrefRangeEnd = 370598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Group GetGroup(int groupnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref groupnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_GetGroup_Internal_Group_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Group>(intPtr3) : null;
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00026288 File Offset: 0x00024488
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 370627, RefRangeEnd = 370631, XrefRangeStart = 370598, XrefRangeEnd = 370627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Group GetGroupImpl(int groupnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref groupnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_GetGroupImpl_Internal_Group_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Group>(intPtr3) : null;
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000262D4 File Offset: 0x000244D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370631, XrefRangeEnd = 370634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00026324 File Offset: 0x00024524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370634, XrefRangeEnd = 370637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00026364 File Offset: 0x00024564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370637, XrefRangeEnd = 370640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GroupCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0000417E File Offset: 0x0000237E
		public GroupCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x000263A0 File Offset: 0x000245A0
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x00004187 File Offset: 0x00002387
		public unsafe Match _match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x000263D0 File Offset: 0x000245D0
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x000041A6 File Offset: 0x000023A6
		public unsafe Hashtable _captureMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__captureMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__captureMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00026400 File Offset: 0x00024600
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x000041C5 File Offset: 0x000023C5
		public unsafe Il2CppReferenceArray<Group> _groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Group>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeFieldInfoPtr__match;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeFieldInfoPtr__captureMap;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr__groups;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Match_Hashtable_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Group_Int32_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_GetGroup_Internal_Group_Int32_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_GetGroupImpl_Internal_Group_Int32_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
