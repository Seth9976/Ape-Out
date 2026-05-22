using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSanford.Collections.Generic
{
	// Token: 0x020001E8 RID: 488
	public class UndoableList<T> : Object
	{
		// Token: 0x060018DC RID: 6364 RVA: 0x0006F6C0 File Offset: 0x0006D8C0
		// Note: this type is marked as 'beforefieldinit'.
		static UndoableList()
		{
			Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections.Generic", "UndoableList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr);
			UndoableList<T>.NativeFieldInfoPtr_theList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, "theList");
			UndoableList<T>.NativeFieldInfoPtr_undoManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, "undoManager");
			UndoableList<T>.NativeMethodInfoPtr_Test_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666947);
			UndoableList<T>.NativeMethodInfoPtr_TestAdd_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666948);
			UndoableList<T>.NativeMethodInfoPtr_TestClear_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666949);
			UndoableList<T>.NativeMethodInfoPtr_TestInsert_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666950);
			UndoableList<T>.NativeMethodInfoPtr_TestInsertRange_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666951);
			UndoableList<T>.NativeMethodInfoPtr_TestRemove_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666952);
			UndoableList<T>.NativeMethodInfoPtr_TestRemoveAt_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666953);
			UndoableList<T>.NativeMethodInfoPtr_TestRemoveRange_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666954);
			UndoableList<T>.NativeMethodInfoPtr_TestReverse_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666955);
			UndoableList<T>.NativeMethodInfoPtr_PopulateLists_Private_Static_Void_IList_1_Int32_IList_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666956);
			UndoableList<T>.NativeMethodInfoPtr_TestEquals_Private_Static_Void_ICollection_1_Int32_ICollection_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666957);
			UndoableList<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666958);
			UndoableList<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666959);
			UndoableList<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666960);
			UndoableList<T>.NativeMethodInfoPtr_Undo_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666961);
			UndoableList<T>.NativeMethodInfoPtr_Redo_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666962);
			UndoableList<T>.NativeMethodInfoPtr_ClearHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666963);
			UndoableList<T>.NativeMethodInfoPtr_BinarySearch_Public_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666964);
			UndoableList<T>.NativeMethodInfoPtr_BinarySearch_Public_Int32_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666965);
			UndoableList<T>.NativeMethodInfoPtr_BinarySearch_Public_Int32_Int32_Int32_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666966);
			UndoableList<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666967);
			UndoableList<T>.NativeMethodInfoPtr_ConvertAll_Public_List_1_TOutput_Converter_2_T_TOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666968);
			UndoableList<T>.NativeMethodInfoPtr_Exists_Public_Boolean_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666969);
			UndoableList<T>.NativeMethodInfoPtr_Find_Public_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666970);
			UndoableList<T>.NativeMethodInfoPtr_FindAll_Public_List_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666971);
			UndoableList<T>.NativeMethodInfoPtr_FindIndex_Public_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666972);
			UndoableList<T>.NativeMethodInfoPtr_FindIndex_Public_Int32_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666973);
			UndoableList<T>.NativeMethodInfoPtr_FindIndex_Public_Int32_Int32_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666974);
			UndoableList<T>.NativeMethodInfoPtr_FindLastIndex_Public_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666975);
			UndoableList<T>.NativeMethodInfoPtr_FindLastIndex_Public_Int32_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666976);
			UndoableList<T>.NativeMethodInfoPtr_FindLastIndex_Public_Int32_Int32_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666977);
			UndoableList<T>.NativeMethodInfoPtr_FindLast_Public_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666978);
			UndoableList<T>.NativeMethodInfoPtr_LastIndexOf_Public_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666979);
			UndoableList<T>.NativeMethodInfoPtr_LastIndexOf_Public_Int32_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666980);
			UndoableList<T>.NativeMethodInfoPtr_LastIndexOf_Public_Int32_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666981);
			UndoableList<T>.NativeMethodInfoPtr_TrueForAll_Public_Boolean_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666982);
			UndoableList<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666983);
			UndoableList<T>.NativeMethodInfoPtr_TrimExcess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666984);
			UndoableList<T>.NativeMethodInfoPtr_AddRange_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666985);
			UndoableList<T>.NativeMethodInfoPtr_InsertRange_Public_Void_Int32_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666986);
			UndoableList<T>.NativeMethodInfoPtr_RemoveRange_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666987);
			UndoableList<T>.NativeMethodInfoPtr_Reverse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666988);
			UndoableList<T>.NativeMethodInfoPtr_Reverse_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666989);
			UndoableList<T>.NativeMethodInfoPtr_get_UndoCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666990);
			UndoableList<T>.NativeMethodInfoPtr_get_RedoCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666991);
			UndoableList<T>.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666992);
			UndoableList<T>.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666993);
			UndoableList<T>.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666994);
			UndoableList<T>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666995);
			UndoableList<T>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666996);
			UndoableList<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666997);
			UndoableList<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666998);
			UndoableList<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100666999);
			UndoableList<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100667000);
			UndoableList<T>.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100667001);
			UndoableList<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100667002);
			UndoableList<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100667003);
			UndoableList<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, 100667004);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0006FBDC File Offset: 0x0006DDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20397, XrefRangeEnd = 20411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Test()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_Test_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0006FC04 File Offset: 0x0006DE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20411, XrefRangeEnd = 20427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestAdd(List<int> comparisonList, UndoableList<int> undoList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparisonList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_TestAdd_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0006FC4C File Offset: 0x0006DE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20427, XrefRangeEnd = 20430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestClear(List<int> comparisonList, UndoableList<int> undoList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparisonList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_TestClear_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0006FC94 File Offset: 0x0006DE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20430, XrefRangeEnd = 20439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestInsert(List<int> comparisonList, UndoableList<int> undoList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparisonList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_TestInsert_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0006FCDC File Offset: 0x0006DEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20439, XrefRangeEnd = 20456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestInsertRange(List<int> comparisonList, UndoableList<int> undoList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparisonList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_TestInsertRange_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x0006FD24 File Offset: 0x0006DF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20456, XrefRangeEnd = 20466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestRemove(List<int> comparisonList, UndoableList<int> undoList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparisonList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_TestRemove_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0006FD6C File Offset: 0x0006DF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20466, XrefRangeEnd = 20476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestRemoveAt(List<int> comparisonList, UndoableList<int> undoList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparisonList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_TestRemoveAt_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x0006FDB4 File Offset: 0x0006DFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20476, XrefRangeEnd = 20487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestRemoveRange(List<int> comparisonList, UndoableList<int> undoList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparisonList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_TestRemoveRange_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0006FDFC File Offset: 0x0006DFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20487, XrefRangeEnd = 20500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestReverse(List<int> comparisonList, UndoableList<int> undoList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparisonList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_TestReverse_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0006FE44 File Offset: 0x0006E044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20500, XrefRangeEnd = 20509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PopulateLists(IList<int> a, IList<int> b, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_PopulateLists_Private_Static_Void_IList_1_Int32_IList_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0006FE9C File Offset: 0x0006E09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20509, XrefRangeEnd = 20521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestEquals(ICollection<int> a, ICollection<int> b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_TestEquals_Private_Static_Void_ICollection_1_Int32_ICollection_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0006FEE4 File Offset: 0x0006E0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20521, XrefRangeEnd = 20527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndoableList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x0006FF20 File Offset: 0x0006E120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20527, XrefRangeEnd = 20533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndoableList(IEnumerable<T> collection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x0006FF6C File Offset: 0x0006E16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20533, XrefRangeEnd = 20539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndoableList(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x0006FFB4 File Offset: 0x0006E1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20539, XrefRangeEnd = 20541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_Undo_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x0006FFF0 File Offset: 0x0006E1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20541, XrefRangeEnd = 20543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Redo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_Redo_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0007002C File Offset: 0x0006E22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20543, XrefRangeEnd = 20545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_ClearHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x00070060 File Offset: 0x0006E260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20545, XrefRangeEnd = 20546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BinarySearch(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref item;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_BinarySearch_Public_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x000700F8 File Offset: 0x0006E2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20546, XrefRangeEnd = 20547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BinarySearch(T item, IComparer<T> comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref item;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_BinarySearch_Public_Int32_T_IComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x000701A4 File Offset: 0x0006E3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20547, XrefRangeEnd = 20548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BinarySearch(int index, int count, T item, IComparer<T> comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				if (!(t is string))
				{
					ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr3) != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref item;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_BinarySearch_Public_Int32_Int32_Int32_T_IComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0007026C File Offset: 0x0006E46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20548, XrefRangeEnd = 20549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref item;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00070304 File Offset: 0x0006E504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20549, XrefRangeEnd = 20550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(converter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<TOutput>.MethodInfoStoreGeneric_ConvertAll_Public_List_1_TOutput_Converter_2_T_TOutput_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TOutput>>(intPtr3) : null;
			}
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00070354 File Offset: 0x0006E554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20550, XrefRangeEnd = 20551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Exists(Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_Exists_Public_Boolean_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x000703A4 File Offset: 0x0006E5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20551, XrefRangeEnd = 20552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Find(Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_Find_Public_T_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x000703F0 File Offset: 0x0006E5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20552, XrefRangeEnd = 20553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<T> FindAll(Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_FindAll_Public_List_1_T_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00070440 File Offset: 0x0006E640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20553, XrefRangeEnd = 20554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindIndex(Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_FindIndex_Public_Int32_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x00070490 File Offset: 0x0006E690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20554, XrefRangeEnd = 20555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindIndex(int startIndex, Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_FindIndex_Public_Int32_Int32_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x000704EC File Offset: 0x0006E6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20555, XrefRangeEnd = 20556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindIndex(int startIndex, int count, Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_FindIndex_Public_Int32_Int32_Int32_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00070558 File Offset: 0x0006E758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20556, XrefRangeEnd = 20557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindLastIndex(Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_FindLastIndex_Public_Int32_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x000705A8 File Offset: 0x0006E7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20557, XrefRangeEnd = 20558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindLastIndex(int startIndex, Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_FindLastIndex_Public_Int32_Int32_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00070604 File Offset: 0x0006E804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20558, XrefRangeEnd = 20559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindLastIndex(int startIndex, int count, Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_FindLastIndex_Public_Int32_Int32_Int32_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00070670 File Offset: 0x0006E870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20559, XrefRangeEnd = 20560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T FindLast(Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_FindLast_Public_T_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x000706BC File Offset: 0x0006E8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20560, XrefRangeEnd = 20561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref item;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_LastIndexOf_Public_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00070754 File Offset: 0x0006E954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20561, XrefRangeEnd = 20562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(T item, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref item;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_LastIndexOf_Public_Int32_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x000707FC File Offset: 0x0006E9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20562, XrefRangeEnd = 20563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(T item, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref item;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_LastIndexOf_Public_Int32_T_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x000708B0 File Offset: 0x0006EAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20563, XrefRangeEnd = 20564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrueForAll(Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_TrueForAll_Public_Boolean_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00070900 File Offset: 0x0006EB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20564, XrefRangeEnd = 20565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00070938 File Offset: 0x0006EB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20565, XrefRangeEnd = 20566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrimExcess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_TrimExcess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x0007096C File Offset: 0x0006EB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20566, XrefRangeEnd = 20570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRange(IEnumerable<T> collection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_AddRange_Public_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x000709B0 File Offset: 0x0006EBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20570, XrefRangeEnd = 20574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertRange(int index, IEnumerable<T> collection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_InsertRange_Public_Void_Int32_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00070A00 File Offset: 0x0006EC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20574, XrefRangeEnd = 20578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRange(int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_RemoveRange_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x00070A4C File Offset: 0x0006EC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20578, XrefRangeEnd = 20582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reverse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_Reverse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00070A80 File Offset: 0x0006EC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20582, XrefRangeEnd = 20586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reverse(int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_Reverse_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x00070ACC File Offset: 0x0006ECCC
		public unsafe int UndoCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20586, XrefRangeEnd = 20587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_get_UndoCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001909 RID: 6409 RVA: 0x00070B08 File Offset: 0x0006ED08
		public unsafe int RedoCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20587, XrefRangeEnd = 20588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_get_RedoCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00070B44 File Offset: 0x0006ED44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20588, XrefRangeEnd = 20589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int IndexOf(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref item;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00070BDC File Offset: 0x0006EDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20589, XrefRangeEnd = 20593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Insert(int index, T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				if (!(t is string))
				{
					ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr3) != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref item;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00070C78 File Offset: 0x0006EE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20593, XrefRangeEnd = 20597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000546 RID: 1350
		public unsafe virtual T this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20597, XrefRangeEnd = 20598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20598, XrefRangeEnd = 20602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00070D9C File Offset: 0x0006EF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20602, XrefRangeEnd = 20606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref item;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00070E2C File Offset: 0x0006F02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20606, XrefRangeEnd = 20609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00070E60 File Offset: 0x0006F060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20609, XrefRangeEnd = 20610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppArrayBase<T> array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x00070EB0 File Offset: 0x0006F0B0
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20610, XrefRangeEnd = 20611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x00070EEC File Offset: 0x0006F0EC
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00070F28 File Offset: 0x0006F128
		[CallerCount(0)]
		public unsafe virtual bool Remove(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref item;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00070FC0 File Offset: 0x0006F1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20611, XrefRangeEnd = 20613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00071000 File Offset: 0x0006F200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00009E0A File Offset: 0x0000800A
		public UndoableList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x00071040 File Offset: 0x0006F240
		// (set) Token: 0x06001919 RID: 6425 RVA: 0x00009E13 File Offset: 0x00008013
		public unsafe List<T> theList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.NativeFieldInfoPtr_theList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.NativeFieldInfoPtr_theList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x00071070 File Offset: 0x0006F270
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x00009E32 File Offset: 0x00008032
		public unsafe UndoManager undoManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.NativeFieldInfoPtr_undoManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.NativeFieldInfoPtr_undoManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeFieldInfoPtr_theList;

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeFieldInfoPtr_undoManager;

		// Token: 0x040019E3 RID: 6627
		private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Static_Void_0;

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeMethodInfoPtr_TestAdd_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0;

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeMethodInfoPtr_TestClear_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0;

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeMethodInfoPtr_TestInsert_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeMethodInfoPtr_TestInsertRange_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeMethodInfoPtr_TestRemove_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0;

		// Token: 0x040019E9 RID: 6633
		private static readonly IntPtr NativeMethodInfoPtr_TestRemoveAt_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0;

		// Token: 0x040019EA RID: 6634
		private static readonly IntPtr NativeMethodInfoPtr_TestRemoveRange_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0;

		// Token: 0x040019EB RID: 6635
		private static readonly IntPtr NativeMethodInfoPtr_TestReverse_Private_Static_Void_List_1_Int32_UndoableList_1_Int32_0;

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeMethodInfoPtr_PopulateLists_Private_Static_Void_IList_1_Int32_IList_1_Int32_Int32_0;

		// Token: 0x040019ED RID: 6637
		private static readonly IntPtr NativeMethodInfoPtr_TestEquals_Private_Static_Void_ICollection_1_Int32_ICollection_1_Int32_0;

		// Token: 0x040019EE RID: 6638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0;

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040019F1 RID: 6641
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Boolean_0;

		// Token: 0x040019F2 RID: 6642
		private static readonly IntPtr NativeMethodInfoPtr_Redo_Public_Boolean_0;

		// Token: 0x040019F3 RID: 6643
		private static readonly IntPtr NativeMethodInfoPtr_ClearHistory_Public_Void_0;

		// Token: 0x040019F4 RID: 6644
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Int32_T_0;

		// Token: 0x040019F5 RID: 6645
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Int32_T_IComparer_1_T_0;

		// Token: 0x040019F6 RID: 6646
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Int32_Int32_Int32_T_IComparer_1_T_0;

		// Token: 0x040019F7 RID: 6647
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x040019F8 RID: 6648
		private static readonly IntPtr NativeMethodInfoPtr_ConvertAll_Public_List_1_TOutput_Converter_2_T_TOutput_0;

		// Token: 0x040019F9 RID: 6649
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Boolean_Predicate_1_T_0;

		// Token: 0x040019FA RID: 6650
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_T_Predicate_1_T_0;

		// Token: 0x040019FB RID: 6651
		private static readonly IntPtr NativeMethodInfoPtr_FindAll_Public_List_1_T_Predicate_1_T_0;

		// Token: 0x040019FC RID: 6652
		private static readonly IntPtr NativeMethodInfoPtr_FindIndex_Public_Int32_Predicate_1_T_0;

		// Token: 0x040019FD RID: 6653
		private static readonly IntPtr NativeMethodInfoPtr_FindIndex_Public_Int32_Int32_Predicate_1_T_0;

		// Token: 0x040019FE RID: 6654
		private static readonly IntPtr NativeMethodInfoPtr_FindIndex_Public_Int32_Int32_Int32_Predicate_1_T_0;

		// Token: 0x040019FF RID: 6655
		private static readonly IntPtr NativeMethodInfoPtr_FindLastIndex_Public_Int32_Predicate_1_T_0;

		// Token: 0x04001A00 RID: 6656
		private static readonly IntPtr NativeMethodInfoPtr_FindLastIndex_Public_Int32_Int32_Predicate_1_T_0;

		// Token: 0x04001A01 RID: 6657
		private static readonly IntPtr NativeMethodInfoPtr_FindLastIndex_Public_Int32_Int32_Int32_Predicate_1_T_0;

		// Token: 0x04001A02 RID: 6658
		private static readonly IntPtr NativeMethodInfoPtr_FindLast_Public_T_Predicate_1_T_0;

		// Token: 0x04001A03 RID: 6659
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_T_0;

		// Token: 0x04001A04 RID: 6660
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_T_Int32_0;

		// Token: 0x04001A05 RID: 6661
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_T_Int32_Int32_0;

		// Token: 0x04001A06 RID: 6662
		private static readonly IntPtr NativeMethodInfoPtr_TrueForAll_Public_Boolean_Predicate_1_T_0;

		// Token: 0x04001A07 RID: 6663
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04001A08 RID: 6664
		private static readonly IntPtr NativeMethodInfoPtr_TrimExcess_Public_Void_0;

		// Token: 0x04001A09 RID: 6665
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Void_IEnumerable_1_T_0;

		// Token: 0x04001A0A RID: 6666
		private static readonly IntPtr NativeMethodInfoPtr_InsertRange_Public_Void_Int32_IEnumerable_1_T_0;

		// Token: 0x04001A0B RID: 6667
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRange_Public_Void_Int32_Int32_0;

		// Token: 0x04001A0C RID: 6668
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_Void_0;

		// Token: 0x04001A0D RID: 6669
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_Void_Int32_Int32_0;

		// Token: 0x04001A0E RID: 6670
		private static readonly IntPtr NativeMethodInfoPtr_get_UndoCount_Public_get_Int32_0;

		// Token: 0x04001A0F RID: 6671
		private static readonly IntPtr NativeMethodInfoPtr_get_RedoCount_Public_get_Int32_0;

		// Token: 0x04001A10 RID: 6672
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0;

		// Token: 0x04001A11 RID: 6673
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_T_0;

		// Token: 0x04001A12 RID: 6674
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04001A13 RID: 6675
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0;

		// Token: 0x04001A14 RID: 6676
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_T_0;

		// Token: 0x04001A15 RID: 6677
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_T_0;

		// Token: 0x04001A16 RID: 6678
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001A17 RID: 6679
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04001A18 RID: 6680
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A19 RID: 6681
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001A1A RID: 6682
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x04001A1B RID: 6683
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x04001A1C RID: 6684
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x02000269 RID: 617
		public class SetCommand : Object
		{
			// Token: 0x060021B8 RID: 8632 RVA: 0x00092B94 File Offset: 0x00090D94
			// Note: this type is marked as 'beforefieldinit'.
			static SetCommand()
			{
				Il2CppClassPointerStore<UndoableList<T>.SetCommand>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, "SetCommand"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndoableList<T>.SetCommand>.NativeClassPtr);
				UndoableList<T>.SetCommand.NativeFieldInfoPtr_theList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.SetCommand>.NativeClassPtr, "theList");
				UndoableList<T>.SetCommand.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.SetCommand>.NativeClassPtr, "index");
				UndoableList<T>.SetCommand.NativeFieldInfoPtr_oldItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.SetCommand>.NativeClassPtr, "oldItem");
				UndoableList<T>.SetCommand.NativeFieldInfoPtr_newItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.SetCommand>.NativeClassPtr, "newItem");
				UndoableList<T>.SetCommand.NativeFieldInfoPtr_undone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.SetCommand>.NativeClassPtr, "undone");
				UndoableList<T>.SetCommand.NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.SetCommand>.NativeClassPtr, 100667005);
				UndoableList<T>.SetCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.SetCommand>.NativeClassPtr, 100667006);
				UndoableList<T>.SetCommand.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.SetCommand>.NativeClassPtr, 100667007);
			}

			// Token: 0x060021B9 RID: 8633 RVA: 0x00092C9C File Offset: 0x00090E9C
			[CallerCount(0)]
			public unsafe SetCommand(IList<T> theList, int index, T item)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoableList<T>.SetCommand>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(theList);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref item;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.SetCommand.NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021BA RID: 8634 RVA: 0x00092D54 File Offset: 0x00090F54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20349, XrefRangeEnd = 20353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.SetCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021BB RID: 8635 RVA: 0x00092D88 File Offset: 0x00090F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20353, XrefRangeEnd = 20355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Undo()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.SetCommand.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021BC RID: 8636 RVA: 0x0000C819 File Offset: 0x0000AA19
			public SetCommand(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D0 RID: 1744
			// (get) Token: 0x060021BD RID: 8637 RVA: 0x00092DBC File Offset: 0x00090FBC
			// (set) Token: 0x060021BE RID: 8638 RVA: 0x0000C822 File Offset: 0x0000AA22
			public unsafe IList<T> theList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.SetCommand.NativeFieldInfoPtr_theList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.SetCommand.NativeFieldInfoPtr_theList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D1 RID: 1745
			// (get) Token: 0x060021BF RID: 8639 RVA: 0x00092DEC File Offset: 0x00090FEC
			// (set) Token: 0x060021C0 RID: 8640 RVA: 0x0000C841 File Offset: 0x0000AA41
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.SetCommand.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.SetCommand.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170006D2 RID: 1746
			// (get) Token: 0x060021C1 RID: 8641 RVA: 0x00092E14 File Offset: 0x00091014
			// (set) Token: 0x060021C2 RID: 8642 RVA: 0x00092E3C File Offset: 0x0009103C
			public unsafe T oldItem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.SetCommand.NativeFieldInfoPtr_oldItem);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.SetCommand.NativeFieldInfoPtr_oldItem);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170006D3 RID: 1747
			// (get) Token: 0x060021C3 RID: 8643 RVA: 0x00092EE4 File Offset: 0x000910E4
			// (set) Token: 0x060021C4 RID: 8644 RVA: 0x00092F0C File Offset: 0x0009110C
			public unsafe T newItem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.SetCommand.NativeFieldInfoPtr_newItem);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.SetCommand.NativeFieldInfoPtr_newItem);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170006D4 RID: 1748
			// (get) Token: 0x060021C5 RID: 8645 RVA: 0x00092FB4 File Offset: 0x000911B4
			// (set) Token: 0x060021C6 RID: 8646 RVA: 0x0000C85C File Offset: 0x0000AA5C
			public unsafe bool undone
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.SetCommand.NativeFieldInfoPtr_undone);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.SetCommand.NativeFieldInfoPtr_undone)) = value;
				}
			}

			// Token: 0x04002123 RID: 8483
			private static readonly IntPtr NativeFieldInfoPtr_theList;

			// Token: 0x04002124 RID: 8484
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04002125 RID: 8485
			private static readonly IntPtr NativeFieldInfoPtr_oldItem;

			// Token: 0x04002126 RID: 8486
			private static readonly IntPtr NativeFieldInfoPtr_newItem;

			// Token: 0x04002127 RID: 8487
			private static readonly IntPtr NativeFieldInfoPtr_undone;

			// Token: 0x04002128 RID: 8488
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_Int32_T_0;

			// Token: 0x04002129 RID: 8489
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400212A RID: 8490
			private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200026A RID: 618
		public class InsertCommand : Object
		{
			// Token: 0x060021C7 RID: 8647 RVA: 0x00092FDC File Offset: 0x000911DC
			// Note: this type is marked as 'beforefieldinit'.
			static InsertCommand()
			{
				Il2CppClassPointerStore<UndoableList<T>.InsertCommand>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, "InsertCommand"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndoableList<T>.InsertCommand>.NativeClassPtr);
				UndoableList<T>.InsertCommand.NativeFieldInfoPtr_theList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.InsertCommand>.NativeClassPtr, "theList");
				UndoableList<T>.InsertCommand.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.InsertCommand>.NativeClassPtr, "index");
				UndoableList<T>.InsertCommand.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.InsertCommand>.NativeClassPtr, "item");
				UndoableList<T>.InsertCommand.NativeFieldInfoPtr_undone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.InsertCommand>.NativeClassPtr, "undone");
				UndoableList<T>.InsertCommand.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.InsertCommand>.NativeClassPtr, "count");
				UndoableList<T>.InsertCommand.NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.InsertCommand>.NativeClassPtr, 100667008);
				UndoableList<T>.InsertCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.InsertCommand>.NativeClassPtr, 100667009);
				UndoableList<T>.InsertCommand.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.InsertCommand>.NativeClassPtr, 100667010);
			}

			// Token: 0x060021C8 RID: 8648 RVA: 0x000930E4 File Offset: 0x000912E4
			[CallerCount(0)]
			public unsafe InsertCommand(IList<T> theList, int index, T item)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoableList<T>.InsertCommand>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(theList);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref item;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.InsertCommand.NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021C9 RID: 8649 RVA: 0x0009319C File Offset: 0x0009139C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20355, XrefRangeEnd = 20359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.InsertCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021CA RID: 8650 RVA: 0x000931D0 File Offset: 0x000913D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20359, XrefRangeEnd = 20361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Undo()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.InsertCommand.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021CB RID: 8651 RVA: 0x0000C877 File Offset: 0x0000AA77
			public InsertCommand(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D5 RID: 1749
			// (get) Token: 0x060021CC RID: 8652 RVA: 0x00093204 File Offset: 0x00091404
			// (set) Token: 0x060021CD RID: 8653 RVA: 0x0000C880 File Offset: 0x0000AA80
			public unsafe IList<T> theList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertCommand.NativeFieldInfoPtr_theList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertCommand.NativeFieldInfoPtr_theList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D6 RID: 1750
			// (get) Token: 0x060021CE RID: 8654 RVA: 0x00093234 File Offset: 0x00091434
			// (set) Token: 0x060021CF RID: 8655 RVA: 0x0000C89F File Offset: 0x0000AA9F
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertCommand.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertCommand.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170006D7 RID: 1751
			// (get) Token: 0x060021D0 RID: 8656 RVA: 0x0009325C File Offset: 0x0009145C
			// (set) Token: 0x060021D1 RID: 8657 RVA: 0x00093284 File Offset: 0x00091484
			public unsafe T item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertCommand.NativeFieldInfoPtr_item);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertCommand.NativeFieldInfoPtr_item);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170006D8 RID: 1752
			// (get) Token: 0x060021D2 RID: 8658 RVA: 0x0009332C File Offset: 0x0009152C
			// (set) Token: 0x060021D3 RID: 8659 RVA: 0x0000C8BA File Offset: 0x0000AABA
			public unsafe bool undone
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertCommand.NativeFieldInfoPtr_undone);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertCommand.NativeFieldInfoPtr_undone)) = value;
				}
			}

			// Token: 0x170006D9 RID: 1753
			// (get) Token: 0x060021D4 RID: 8660 RVA: 0x00093354 File Offset: 0x00091554
			// (set) Token: 0x060021D5 RID: 8661 RVA: 0x0000C8D5 File Offset: 0x0000AAD5
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertCommand.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertCommand.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x0400212B RID: 8491
			private static readonly IntPtr NativeFieldInfoPtr_theList;

			// Token: 0x0400212C RID: 8492
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400212D RID: 8493
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x0400212E RID: 8494
			private static readonly IntPtr NativeFieldInfoPtr_undone;

			// Token: 0x0400212F RID: 8495
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04002130 RID: 8496
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_Int32_T_0;

			// Token: 0x04002131 RID: 8497
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002132 RID: 8498
			private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200026B RID: 619
		public class InsertRangeCommand : Object
		{
			// Token: 0x060021D6 RID: 8662 RVA: 0x0009337C File Offset: 0x0009157C
			// Note: this type is marked as 'beforefieldinit'.
			static InsertRangeCommand()
			{
				Il2CppClassPointerStore<UndoableList<T>.InsertRangeCommand>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, "InsertRangeCommand"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndoableList<T>.InsertRangeCommand>.NativeClassPtr);
				UndoableList<T>.InsertRangeCommand.NativeFieldInfoPtr_theList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.InsertRangeCommand>.NativeClassPtr, "theList");
				UndoableList<T>.InsertRangeCommand.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.InsertRangeCommand>.NativeClassPtr, "index");
				UndoableList<T>.InsertRangeCommand.NativeFieldInfoPtr_insertList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.InsertRangeCommand>.NativeClassPtr, "insertList");
				UndoableList<T>.InsertRangeCommand.NativeFieldInfoPtr_undone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.InsertRangeCommand>.NativeClassPtr, "undone");
				UndoableList<T>.InsertRangeCommand.NativeMethodInfoPtr__ctor_Public_Void_List_1_T_Int32_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.InsertRangeCommand>.NativeClassPtr, 100667011);
				UndoableList<T>.InsertRangeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.InsertRangeCommand>.NativeClassPtr, 100667012);
				UndoableList<T>.InsertRangeCommand.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.InsertRangeCommand>.NativeClassPtr, 100667013);
			}

			// Token: 0x060021D7 RID: 8663 RVA: 0x00093470 File Offset: 0x00091670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20361, XrefRangeEnd = 20363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InsertRangeCommand(List<T> theList, int index, IEnumerable<T> collection)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoableList<T>.InsertRangeCommand>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(theList);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.InsertRangeCommand.NativeMethodInfoPtr__ctor_Public_Void_List_1_T_Int32_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021D8 RID: 8664 RVA: 0x000934DC File Offset: 0x000916DC
			[CallerCount(0)]
			public unsafe virtual void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.InsertRangeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021D9 RID: 8665 RVA: 0x00093510 File Offset: 0x00091710
			[CallerCount(0)]
			public unsafe virtual void Undo()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.InsertRangeCommand.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021DA RID: 8666 RVA: 0x0000C8F0 File Offset: 0x0000AAF0
			public InsertRangeCommand(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006DA RID: 1754
			// (get) Token: 0x060021DB RID: 8667 RVA: 0x00093544 File Offset: 0x00091744
			// (set) Token: 0x060021DC RID: 8668 RVA: 0x0000C8F9 File Offset: 0x0000AAF9
			public unsafe List<T> theList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertRangeCommand.NativeFieldInfoPtr_theList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertRangeCommand.NativeFieldInfoPtr_theList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DB RID: 1755
			// (get) Token: 0x060021DD RID: 8669 RVA: 0x00093574 File Offset: 0x00091774
			// (set) Token: 0x060021DE RID: 8670 RVA: 0x0000C918 File Offset: 0x0000AB18
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertRangeCommand.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertRangeCommand.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170006DC RID: 1756
			// (get) Token: 0x060021DF RID: 8671 RVA: 0x0009359C File Offset: 0x0009179C
			// (set) Token: 0x060021E0 RID: 8672 RVA: 0x0000C933 File Offset: 0x0000AB33
			public unsafe List<T> insertList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertRangeCommand.NativeFieldInfoPtr_insertList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertRangeCommand.NativeFieldInfoPtr_insertList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DD RID: 1757
			// (get) Token: 0x060021E1 RID: 8673 RVA: 0x000935CC File Offset: 0x000917CC
			// (set) Token: 0x060021E2 RID: 8674 RVA: 0x0000C952 File Offset: 0x0000AB52
			public unsafe bool undone
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertRangeCommand.NativeFieldInfoPtr_undone);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.InsertRangeCommand.NativeFieldInfoPtr_undone)) = value;
				}
			}

			// Token: 0x04002133 RID: 8499
			private static readonly IntPtr NativeFieldInfoPtr_theList;

			// Token: 0x04002134 RID: 8500
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04002135 RID: 8501
			private static readonly IntPtr NativeFieldInfoPtr_insertList;

			// Token: 0x04002136 RID: 8502
			private static readonly IntPtr NativeFieldInfoPtr_undone;

			// Token: 0x04002137 RID: 8503
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_T_Int32_IEnumerable_1_T_0;

			// Token: 0x04002138 RID: 8504
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002139 RID: 8505
			private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200026C RID: 620
		public class RemoveAtCommand : Object
		{
			// Token: 0x060021E3 RID: 8675 RVA: 0x000935F4 File Offset: 0x000917F4
			// Note: this type is marked as 'beforefieldinit'.
			static RemoveAtCommand()
			{
				Il2CppClassPointerStore<UndoableList<T>.RemoveAtCommand>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, "RemoveAtCommand"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndoableList<T>.RemoveAtCommand>.NativeClassPtr);
				UndoableList<T>.RemoveAtCommand.NativeFieldInfoPtr_theList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.RemoveAtCommand>.NativeClassPtr, "theList");
				UndoableList<T>.RemoveAtCommand.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.RemoveAtCommand>.NativeClassPtr, "index");
				UndoableList<T>.RemoveAtCommand.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.RemoveAtCommand>.NativeClassPtr, "item");
				UndoableList<T>.RemoveAtCommand.NativeFieldInfoPtr_undone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.RemoveAtCommand>.NativeClassPtr, "undone");
				UndoableList<T>.RemoveAtCommand.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.RemoveAtCommand>.NativeClassPtr, "count");
				UndoableList<T>.RemoveAtCommand.NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.RemoveAtCommand>.NativeClassPtr, 100667014);
				UndoableList<T>.RemoveAtCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.RemoveAtCommand>.NativeClassPtr, 100667015);
				UndoableList<T>.RemoveAtCommand.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.RemoveAtCommand>.NativeClassPtr, 100667016);
			}

			// Token: 0x060021E4 RID: 8676 RVA: 0x000936FC File Offset: 0x000918FC
			[CallerCount(0)]
			public unsafe RemoveAtCommand(IList<T> theList, int index)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoableList<T>.RemoveAtCommand>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(theList);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.RemoveAtCommand.NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021E5 RID: 8677 RVA: 0x00093758 File Offset: 0x00091958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20363, XrefRangeEnd = 20369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.RemoveAtCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021E6 RID: 8678 RVA: 0x0009378C File Offset: 0x0009198C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20369, XrefRangeEnd = 20371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Undo()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.RemoveAtCommand.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021E7 RID: 8679 RVA: 0x0000C96D File Offset: 0x0000AB6D
			public RemoveAtCommand(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006DE RID: 1758
			// (get) Token: 0x060021E8 RID: 8680 RVA: 0x000937C0 File Offset: 0x000919C0
			// (set) Token: 0x060021E9 RID: 8681 RVA: 0x0000C976 File Offset: 0x0000AB76
			public unsafe IList<T> theList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveAtCommand.NativeFieldInfoPtr_theList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveAtCommand.NativeFieldInfoPtr_theList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DF RID: 1759
			// (get) Token: 0x060021EA RID: 8682 RVA: 0x000937F0 File Offset: 0x000919F0
			// (set) Token: 0x060021EB RID: 8683 RVA: 0x0000C995 File Offset: 0x0000AB95
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveAtCommand.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveAtCommand.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170006E0 RID: 1760
			// (get) Token: 0x060021EC RID: 8684 RVA: 0x00093818 File Offset: 0x00091A18
			// (set) Token: 0x060021ED RID: 8685 RVA: 0x00093840 File Offset: 0x00091A40
			public unsafe T item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveAtCommand.NativeFieldInfoPtr_item);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveAtCommand.NativeFieldInfoPtr_item);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170006E1 RID: 1761
			// (get) Token: 0x060021EE RID: 8686 RVA: 0x000938E8 File Offset: 0x00091AE8
			// (set) Token: 0x060021EF RID: 8687 RVA: 0x0000C9B0 File Offset: 0x0000ABB0
			public unsafe bool undone
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveAtCommand.NativeFieldInfoPtr_undone);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveAtCommand.NativeFieldInfoPtr_undone)) = value;
				}
			}

			// Token: 0x170006E2 RID: 1762
			// (get) Token: 0x060021F0 RID: 8688 RVA: 0x00093910 File Offset: 0x00091B10
			// (set) Token: 0x060021F1 RID: 8689 RVA: 0x0000C9CB File Offset: 0x0000ABCB
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveAtCommand.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveAtCommand.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x0400213A RID: 8506
			private static readonly IntPtr NativeFieldInfoPtr_theList;

			// Token: 0x0400213B RID: 8507
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400213C RID: 8508
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x0400213D RID: 8509
			private static readonly IntPtr NativeFieldInfoPtr_undone;

			// Token: 0x0400213E RID: 8510
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x0400213F RID: 8511
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_Int32_0;

			// Token: 0x04002140 RID: 8512
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002141 RID: 8513
			private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200026D RID: 621
		public class RemoveRangeCommand : Object
		{
			// Token: 0x060021F2 RID: 8690 RVA: 0x00093938 File Offset: 0x00091B38
			// Note: this type is marked as 'beforefieldinit'.
			static RemoveRangeCommand()
			{
				Il2CppClassPointerStore<UndoableList<T>.RemoveRangeCommand>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, "RemoveRangeCommand"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndoableList<T>.RemoveRangeCommand>.NativeClassPtr);
				UndoableList<T>.RemoveRangeCommand.NativeFieldInfoPtr_theList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.RemoveRangeCommand>.NativeClassPtr, "theList");
				UndoableList<T>.RemoveRangeCommand.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.RemoveRangeCommand>.NativeClassPtr, "index");
				UndoableList<T>.RemoveRangeCommand.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.RemoveRangeCommand>.NativeClassPtr, "count");
				UndoableList<T>.RemoveRangeCommand.NativeFieldInfoPtr_rangeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.RemoveRangeCommand>.NativeClassPtr, "rangeList");
				UndoableList<T>.RemoveRangeCommand.NativeFieldInfoPtr_undone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.RemoveRangeCommand>.NativeClassPtr, "undone");
				UndoableList<T>.RemoveRangeCommand.NativeMethodInfoPtr__ctor_Public_Void_List_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.RemoveRangeCommand>.NativeClassPtr, 100667017);
				UndoableList<T>.RemoveRangeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.RemoveRangeCommand>.NativeClassPtr, 100667018);
				UndoableList<T>.RemoveRangeCommand.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.RemoveRangeCommand>.NativeClassPtr, 100667019);
			}

			// Token: 0x060021F3 RID: 8691 RVA: 0x00093A40 File Offset: 0x00091C40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20371, XrefRangeEnd = 20373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RemoveRangeCommand(List<T> theList, int index, int count)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoableList<T>.RemoveRangeCommand>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(theList);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.RemoveRangeCommand.NativeMethodInfoPtr__ctor_Public_Void_List_1_T_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021F4 RID: 8692 RVA: 0x00093AA8 File Offset: 0x00091CA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20373, XrefRangeEnd = 20375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.RemoveRangeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021F5 RID: 8693 RVA: 0x00093ADC File Offset: 0x00091CDC
			[CallerCount(0)]
			public unsafe virtual void Undo()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.RemoveRangeCommand.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021F6 RID: 8694 RVA: 0x0000C9E6 File Offset: 0x0000ABE6
			public RemoveRangeCommand(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E3 RID: 1763
			// (get) Token: 0x060021F7 RID: 8695 RVA: 0x00093B10 File Offset: 0x00091D10
			// (set) Token: 0x060021F8 RID: 8696 RVA: 0x0000C9EF File Offset: 0x0000ABEF
			public unsafe List<T> theList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveRangeCommand.NativeFieldInfoPtr_theList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveRangeCommand.NativeFieldInfoPtr_theList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E4 RID: 1764
			// (get) Token: 0x060021F9 RID: 8697 RVA: 0x00093B40 File Offset: 0x00091D40
			// (set) Token: 0x060021FA RID: 8698 RVA: 0x0000CA0E File Offset: 0x0000AC0E
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveRangeCommand.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveRangeCommand.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170006E5 RID: 1765
			// (get) Token: 0x060021FB RID: 8699 RVA: 0x00093B68 File Offset: 0x00091D68
			// (set) Token: 0x060021FC RID: 8700 RVA: 0x0000CA29 File Offset: 0x0000AC29
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveRangeCommand.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveRangeCommand.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x170006E6 RID: 1766
			// (get) Token: 0x060021FD RID: 8701 RVA: 0x00093B90 File Offset: 0x00091D90
			// (set) Token: 0x060021FE RID: 8702 RVA: 0x0000CA44 File Offset: 0x0000AC44
			public unsafe List<T> rangeList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveRangeCommand.NativeFieldInfoPtr_rangeList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveRangeCommand.NativeFieldInfoPtr_rangeList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E7 RID: 1767
			// (get) Token: 0x060021FF RID: 8703 RVA: 0x00093BC0 File Offset: 0x00091DC0
			// (set) Token: 0x06002200 RID: 8704 RVA: 0x0000CA63 File Offset: 0x0000AC63
			public unsafe bool undone
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveRangeCommand.NativeFieldInfoPtr_undone);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.RemoveRangeCommand.NativeFieldInfoPtr_undone)) = value;
				}
			}

			// Token: 0x04002142 RID: 8514
			private static readonly IntPtr NativeFieldInfoPtr_theList;

			// Token: 0x04002143 RID: 8515
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04002144 RID: 8516
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04002145 RID: 8517
			private static readonly IntPtr NativeFieldInfoPtr_rangeList;

			// Token: 0x04002146 RID: 8518
			private static readonly IntPtr NativeFieldInfoPtr_undone;

			// Token: 0x04002147 RID: 8519
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_T_Int32_Int32_0;

			// Token: 0x04002148 RID: 8520
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002149 RID: 8521
			private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200026E RID: 622
		public class ClearCommand : Object
		{
			// Token: 0x06002201 RID: 8705 RVA: 0x00093BE8 File Offset: 0x00091DE8
			// Note: this type is marked as 'beforefieldinit'.
			static ClearCommand()
			{
				Il2CppClassPointerStore<UndoableList<T>.ClearCommand>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, "ClearCommand"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndoableList<T>.ClearCommand>.NativeClassPtr);
				UndoableList<T>.ClearCommand.NativeFieldInfoPtr_theList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.ClearCommand>.NativeClassPtr, "theList");
				UndoableList<T>.ClearCommand.NativeFieldInfoPtr_undoList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.ClearCommand>.NativeClassPtr, "undoList");
				UndoableList<T>.ClearCommand.NativeFieldInfoPtr_undone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.ClearCommand>.NativeClassPtr, "undone");
				UndoableList<T>.ClearCommand.NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.ClearCommand>.NativeClassPtr, 100667020);
				UndoableList<T>.ClearCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.ClearCommand>.NativeClassPtr, 100667021);
				UndoableList<T>.ClearCommand.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.ClearCommand>.NativeClassPtr, 100667022);
			}

			// Token: 0x06002202 RID: 8706 RVA: 0x00093CC8 File Offset: 0x00091EC8
			[CallerCount(0)]
			public unsafe ClearCommand(IList<T> theList)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoableList<T>.ClearCommand>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(theList);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.ClearCommand.NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002203 RID: 8707 RVA: 0x00093D14 File Offset: 0x00091F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20375, XrefRangeEnd = 20379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.ClearCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002204 RID: 8708 RVA: 0x00093D48 File Offset: 0x00091F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20379, XrefRangeEnd = 20397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Undo()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.ClearCommand.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002205 RID: 8709 RVA: 0x0000CA7E File Offset: 0x0000AC7E
			public ClearCommand(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E8 RID: 1768
			// (get) Token: 0x06002206 RID: 8710 RVA: 0x00093D7C File Offset: 0x00091F7C
			// (set) Token: 0x06002207 RID: 8711 RVA: 0x0000CA87 File Offset: 0x0000AC87
			public unsafe IList<T> theList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.ClearCommand.NativeFieldInfoPtr_theList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.ClearCommand.NativeFieldInfoPtr_theList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E9 RID: 1769
			// (get) Token: 0x06002208 RID: 8712 RVA: 0x00093DAC File Offset: 0x00091FAC
			// (set) Token: 0x06002209 RID: 8713 RVA: 0x0000CAA6 File Offset: 0x0000ACA6
			public unsafe IList<T> undoList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.ClearCommand.NativeFieldInfoPtr_undoList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.ClearCommand.NativeFieldInfoPtr_undoList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006EA RID: 1770
			// (get) Token: 0x0600220A RID: 8714 RVA: 0x00093DDC File Offset: 0x00091FDC
			// (set) Token: 0x0600220B RID: 8715 RVA: 0x0000CAC5 File Offset: 0x0000ACC5
			public unsafe bool undone
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.ClearCommand.NativeFieldInfoPtr_undone);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.ClearCommand.NativeFieldInfoPtr_undone)) = value;
				}
			}

			// Token: 0x0400214A RID: 8522
			private static readonly IntPtr NativeFieldInfoPtr_theList;

			// Token: 0x0400214B RID: 8523
			private static readonly IntPtr NativeFieldInfoPtr_undoList;

			// Token: 0x0400214C RID: 8524
			private static readonly IntPtr NativeFieldInfoPtr_undone;

			// Token: 0x0400214D RID: 8525
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_T_0;

			// Token: 0x0400214E RID: 8526
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400214F RID: 8527
			private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200026F RID: 623
		public class ReverseCommand : Object
		{
			// Token: 0x0600220C RID: 8716 RVA: 0x00093E04 File Offset: 0x00092004
			// Note: this type is marked as 'beforefieldinit'.
			static ReverseCommand()
			{
				Il2CppClassPointerStore<UndoableList<T>.ReverseCommand>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UndoableList<T>>.NativeClassPtr, "ReverseCommand"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndoableList<T>.ReverseCommand>.NativeClassPtr);
				UndoableList<T>.ReverseCommand.NativeFieldInfoPtr_theList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.ReverseCommand>.NativeClassPtr, "theList");
				UndoableList<T>.ReverseCommand.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.ReverseCommand>.NativeClassPtr, "index");
				UndoableList<T>.ReverseCommand.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.ReverseCommand>.NativeClassPtr, "count");
				UndoableList<T>.ReverseCommand.NativeFieldInfoPtr_reverseRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.ReverseCommand>.NativeClassPtr, "reverseRange");
				UndoableList<T>.ReverseCommand.NativeFieldInfoPtr_undone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoableList<T>.ReverseCommand>.NativeClassPtr, "undone");
				UndoableList<T>.ReverseCommand.NativeMethodInfoPtr__ctor_Public_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.ReverseCommand>.NativeClassPtr, 100667023);
				UndoableList<T>.ReverseCommand.NativeMethodInfoPtr__ctor_Public_Void_List_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.ReverseCommand>.NativeClassPtr, 100667024);
				UndoableList<T>.ReverseCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.ReverseCommand>.NativeClassPtr, 100667025);
				UndoableList<T>.ReverseCommand.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoableList<T>.ReverseCommand>.NativeClassPtr, 100667026);
			}

			// Token: 0x0600220D RID: 8717 RVA: 0x00093F20 File Offset: 0x00092120
			[CallerCount(0)]
			public unsafe ReverseCommand(List<T> theList)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoableList<T>.ReverseCommand>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(theList);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.ReverseCommand.NativeMethodInfoPtr__ctor_Public_Void_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600220E RID: 8718 RVA: 0x00093F6C File Offset: 0x0009216C
			[CallerCount(0)]
			public unsafe ReverseCommand(List<T> theList, int index, int count)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoableList<T>.ReverseCommand>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(theList);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.ReverseCommand.NativeMethodInfoPtr__ctor_Public_Void_List_1_T_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600220F RID: 8719 RVA: 0x00093FD4 File Offset: 0x000921D4
			[CallerCount(0)]
			public unsafe virtual void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.ReverseCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002210 RID: 8720 RVA: 0x00094008 File Offset: 0x00092208
			[CallerCount(0)]
			public unsafe virtual void Undo()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoableList<T>.ReverseCommand.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002211 RID: 8721 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
			public ReverseCommand(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006EB RID: 1771
			// (get) Token: 0x06002212 RID: 8722 RVA: 0x0009403C File Offset: 0x0009223C
			// (set) Token: 0x06002213 RID: 8723 RVA: 0x0000CAE9 File Offset: 0x0000ACE9
			public unsafe List<T> theList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.ReverseCommand.NativeFieldInfoPtr_theList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.ReverseCommand.NativeFieldInfoPtr_theList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006EC RID: 1772
			// (get) Token: 0x06002214 RID: 8724 RVA: 0x0009406C File Offset: 0x0009226C
			// (set) Token: 0x06002215 RID: 8725 RVA: 0x0000CB08 File Offset: 0x0000AD08
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.ReverseCommand.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.ReverseCommand.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170006ED RID: 1773
			// (get) Token: 0x06002216 RID: 8726 RVA: 0x00094094 File Offset: 0x00092294
			// (set) Token: 0x06002217 RID: 8727 RVA: 0x0000CB23 File Offset: 0x0000AD23
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.ReverseCommand.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.ReverseCommand.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x170006EE RID: 1774
			// (get) Token: 0x06002218 RID: 8728 RVA: 0x000940BC File Offset: 0x000922BC
			// (set) Token: 0x06002219 RID: 8729 RVA: 0x0000CB3E File Offset: 0x0000AD3E
			public unsafe bool reverseRange
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.ReverseCommand.NativeFieldInfoPtr_reverseRange);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.ReverseCommand.NativeFieldInfoPtr_reverseRange)) = value;
				}
			}

			// Token: 0x170006EF RID: 1775
			// (get) Token: 0x0600221A RID: 8730 RVA: 0x000940E4 File Offset: 0x000922E4
			// (set) Token: 0x0600221B RID: 8731 RVA: 0x0000CB59 File Offset: 0x0000AD59
			public unsafe bool undone
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.ReverseCommand.NativeFieldInfoPtr_undone);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoableList<T>.ReverseCommand.NativeFieldInfoPtr_undone)) = value;
				}
			}

			// Token: 0x04002150 RID: 8528
			private static readonly IntPtr NativeFieldInfoPtr_theList;

			// Token: 0x04002151 RID: 8529
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04002152 RID: 8530
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04002153 RID: 8531
			private static readonly IntPtr NativeFieldInfoPtr_reverseRange;

			// Token: 0x04002154 RID: 8532
			private static readonly IntPtr NativeFieldInfoPtr_undone;

			// Token: 0x04002155 RID: 8533
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_T_0;

			// Token: 0x04002156 RID: 8534
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_T_Int32_Int32_0;

			// Token: 0x04002157 RID: 8535
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002158 RID: 8536
			private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000270 RID: 624
		private sealed class MethodInfoStoreGeneric_ConvertAll_Public_List_1_TOutput_Converter_2_T_TOutput_0
		{
			// Token: 0x04002159 RID: 8537
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UndoableList<TOutput>.NativeMethodInfoPtr_ConvertAll_Public_List_1_TOutput_Converter_2_T_TOutput_0, Il2CppClassPointerStore<UndoableList<TOutput>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOutput>.NativeClassPtr)) }))));
		}
	}
}
