using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppSanford.Collections
{
	// Token: 0x020001D8 RID: 472
	public class SkipList : Object
	{
		// Token: 0x0600179F RID: 6047 RVA: 0x0006A4B0 File Offset: 0x000686B0
		// Note: this type is marked as 'beforefieldinit'.
		static SkipList()
		{
			Il2CppClassPointerStore<SkipList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections", "SkipList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkipList>.NativeClassPtr);
			SkipList.NativeFieldInfoPtr_MaxLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipList>.NativeClassPtr, "MaxLevel");
			SkipList.NativeFieldInfoPtr_Probability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipList>.NativeClassPtr, "Probability");
			SkipList.NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipList>.NativeClassPtr, "header");
			SkipList.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipList>.NativeClassPtr, "comparer");
			SkipList.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipList>.NativeClassPtr, "random");
			SkipList.NativeFieldInfoPtr_listLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipList>.NativeClassPtr, "listLevel");
			SkipList.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipList>.NativeClassPtr, "count");
			SkipList.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipList>.NativeClassPtr, "version");
			SkipList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666708);
			SkipList.NativeMethodInfoPtr__ctor_Public_Void_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666709);
			SkipList.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666710);
			SkipList.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666711);
			SkipList.NativeMethodInfoPtr_GetNewLevel_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666712);
			SkipList.NativeMethodInfoPtr_Search_Private_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666713);
			SkipList.NativeMethodInfoPtr_Search_Private_Boolean_Object_byref_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666714);
			SkipList.NativeMethodInfoPtr_Search_Private_Boolean_Object_Il2CppReferenceArray_1_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666715);
			SkipList.NativeMethodInfoPtr_Search_Private_Boolean_Object_byref_Node_Il2CppReferenceArray_1_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666716);
			SkipList.NativeMethodInfoPtr_SearchWithComparer_Private_Boolean_Object_byref_Node_Il2CppReferenceArray_1_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666717);
			SkipList.NativeMethodInfoPtr_SearchWithComparable_Private_Boolean_Object_byref_Node_Il2CppReferenceArray_1_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666718);
			SkipList.NativeMethodInfoPtr_Insert_Private_Void_Object_Object_Il2CppReferenceArray_1_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666719);
			SkipList.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666720);
			SkipList.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666721);
			SkipList.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666722);
			SkipList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666723);
			SkipList.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666724);
			SkipList.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666725);
			SkipList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666726);
			SkipList.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666727);
			SkipList.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666728);
			SkipList.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666729);
			SkipList.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666730);
			SkipList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666731);
			SkipList.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666732);
			SkipList.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666733);
			SkipList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666734);
			SkipList.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList>.NativeClassPtr, 100666735);
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0006A7B0 File Offset: 0x000689B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18993, XrefRangeEnd = 19002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkipList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkipList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x0006A7EC File Offset: 0x000689EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19002, XrefRangeEnd = 19011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkipList(IComparer comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkipList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr__ctor_Public_Void_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x0006A838 File Offset: 0x00068A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19011, XrefRangeEnd = 19015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkipList.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x0006A874 File Offset: 0x00068A74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19017, RefRangeEnd = 19021, XrefRangeStart = 19015, XrefRangeEnd = 19017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x0006A8A8 File Offset: 0x00068AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19021, XrefRangeEnd = 19022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNewLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_GetNewLevel_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x0006A8E4 File Offset: 0x00068AE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19039, RefRangeEnd = 19040, XrefRangeStart = 19022, XrefRangeEnd = 19039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Search(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_Search_Private_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x0006A934 File Offset: 0x00068B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19040, XrefRangeEnd = 19044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Search(Object key, out SkipList.Node curr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_Search_Private_Boolean_Object_byref_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			curr = ((intPtr4 == 0) ? null : new SkipList.Node(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x0006A9A4 File Offset: 0x00068BA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19058, RefRangeEnd = 19059, XrefRangeStart = 19044, XrefRangeEnd = 19058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Search(Object key, Il2CppReferenceArray<SkipList.Node> update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(update);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_Search_Private_Boolean_Object_Il2CppReferenceArray_1_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x0006AA04 File Offset: 0x00068C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19059, XrefRangeEnd = 19060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Search(Object key, out SkipList.Node curr, Il2CppReferenceArray<SkipList.Node> update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(update);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_Search_Private_Boolean_Object_byref_Node_Il2CppReferenceArray_1_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			curr = ((intPtr4 == 0) ? null : new SkipList.Node(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x0006AA88 File Offset: 0x00068C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19060, XrefRangeEnd = 19070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SearchWithComparer(Object key, out SkipList.Node curr, Il2CppReferenceArray<SkipList.Node> update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(update);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_SearchWithComparer_Private_Boolean_Object_byref_Node_Il2CppReferenceArray_1_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			curr = ((intPtr4 == 0) ? null : new SkipList.Node(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x0006AB0C File Offset: 0x00068D0C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 19090, RefRangeEnd = 19097, XrefRangeStart = 19070, XrefRangeEnd = 19090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SearchWithComparable(Object key, out SkipList.Node curr, Il2CppReferenceArray<SkipList.Node> update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(update);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_SearchWithComparable_Private_Boolean_Object_byref_Node_Il2CppReferenceArray_1_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			curr = ((intPtr4 == 0) ? null : new SkipList.Node(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x0006AB90 File Offset: 0x00068D90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19113, RefRangeEnd = 19115, XrefRangeStart = 19097, XrefRangeEnd = 19113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(Object key, Object val, Il2CppReferenceArray<SkipList.Node> update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(update);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_Insert_Private_Void_Object_Object_Il2CppReferenceArray_1_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x0006ABF8 File Offset: 0x00068DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19115, XrefRangeEnd = 19120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(Object key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x0006AC4C File Offset: 0x00068E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19120, XrefRangeEnd = 19122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x0006AC80 File Offset: 0x00068E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19122, XrefRangeEnd = 19123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x0006ACD0 File Offset: 0x00068ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19123, XrefRangeEnd = 19127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0006AD10 File Offset: 0x00068F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19127, XrefRangeEnd = 19147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x0006AD54 File Offset: 0x00068F54
		public unsafe virtual bool IsFixedSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x0006AD90 File Offset: 0x00068F90
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E4 RID: 1252
		public unsafe virtual Object this[Object key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19147, XrefRangeEnd = 19165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19165, XrefRangeEnd = 19184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x0006AE70 File Offset: 0x00069070
		public unsafe virtual ICollection Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19184, XrefRangeEnd = 19188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x0006AEB0 File Offset: 0x000690B0
		public unsafe virtual ICollection Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19188, XrefRangeEnd = 19192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x0006AEF0 File Offset: 0x000690F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19192, XrefRangeEnd = 19195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x0006AF40 File Offset: 0x00069140
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060017B9 RID: 6073 RVA: 0x0006AF7C File Offset: 0x0006917C
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x0006AFB8 File Offset: 0x000691B8
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(397)]
			[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x0006AFF8 File Offset: 0x000691F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19195, XrefRangeEnd = 19199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00009777 File Offset: 0x00007977
		public SkipList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x0006B038 File Offset: 0x00069238
		// (set) Token: 0x060017BE RID: 6078 RVA: 0x00009780 File Offset: 0x00007980
		public unsafe static int MaxLevel
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SkipList.NativeFieldInfoPtr_MaxLevel, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkipList.NativeFieldInfoPtr_MaxLevel, (void*)(&value));
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060017BF RID: 6079 RVA: 0x0006B054 File Offset: 0x00069254
		// (set) Token: 0x060017C0 RID: 6080 RVA: 0x0000978E File Offset: 0x0000798E
		public unsafe static double Probability
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(SkipList.NativeFieldInfoPtr_Probability, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkipList.NativeFieldInfoPtr_Probability, (void*)(&value));
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060017C1 RID: 6081 RVA: 0x0006B070 File Offset: 0x00069270
		// (set) Token: 0x060017C2 RID: 6082 RVA: 0x0000979C File Offset: 0x0000799C
		public unsafe SkipList.Node header
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.NativeFieldInfoPtr_header);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkipList.Node>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.NativeFieldInfoPtr_header), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060017C3 RID: 6083 RVA: 0x0006B0A0 File Offset: 0x000692A0
		// (set) Token: 0x060017C4 RID: 6084 RVA: 0x000097BB File Offset: 0x000079BB
		public unsafe IComparer comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060017C5 RID: 6085 RVA: 0x0006B0D0 File Offset: 0x000692D0
		// (set) Token: 0x060017C6 RID: 6086 RVA: 0x000097DA File Offset: 0x000079DA
		public unsafe Random random
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.NativeFieldInfoPtr_random);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.NativeFieldInfoPtr_random), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x0006B100 File Offset: 0x00069300
		// (set) Token: 0x060017C8 RID: 6088 RVA: 0x000097F9 File Offset: 0x000079F9
		public unsafe int listLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.NativeFieldInfoPtr_listLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.NativeFieldInfoPtr_listLevel)) = value;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x0006B128 File Offset: 0x00069328
		// (set) Token: 0x060017CA RID: 6090 RVA: 0x00009814 File Offset: 0x00007A14
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x0006B150 File Offset: 0x00069350
		// (set) Token: 0x060017CC RID: 6092 RVA: 0x0000982F File Offset: 0x00007A2F
		public unsafe long version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x040018FC RID: 6396
		private static readonly IntPtr NativeFieldInfoPtr_MaxLevel;

		// Token: 0x040018FD RID: 6397
		private static readonly IntPtr NativeFieldInfoPtr_Probability;

		// Token: 0x040018FE RID: 6398
		private static readonly IntPtr NativeFieldInfoPtr_header;

		// Token: 0x040018FF RID: 6399
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x04001900 RID: 6400
		private static readonly IntPtr NativeFieldInfoPtr_random;

		// Token: 0x04001901 RID: 6401
		private static readonly IntPtr NativeFieldInfoPtr_listLevel;

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IComparer_0;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeMethodInfoPtr_GetNewLevel_Private_Int32_0;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeMethodInfoPtr_Search_Private_Boolean_Object_0;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeMethodInfoPtr_Search_Private_Boolean_Object_byref_Node_0;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeMethodInfoPtr_Search_Private_Boolean_Object_Il2CppReferenceArray_1_Node_0;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeMethodInfoPtr_Search_Private_Boolean_Object_byref_Node_Il2CppReferenceArray_1_Node_0;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeMethodInfoPtr_SearchWithComparer_Private_Boolean_Object_byref_Node_Il2CppReferenceArray_1_Node_0;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeMethodInfoPtr_SearchWithComparable_Private_Boolean_Object_byref_Node_Il2CppReferenceArray_1_Node_0;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Private_Void_Object_Object_Il2CppReferenceArray_1_Node_0;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001916 RID: 6422
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001917 RID: 6423
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0;

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x0400191C RID: 6428
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x02000260 RID: 608
		public class Node : Object
		{
			// Token: 0x06002134 RID: 8500 RVA: 0x00090B28 File Offset: 0x0008ED28
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<SkipList.Node>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkipList>.NativeClassPtr, "Node");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkipList.Node>.NativeClassPtr);
				SkipList.Node.NativeFieldInfoPtr_forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipList.Node>.NativeClassPtr, "forward");
				SkipList.Node.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipList.Node>.NativeClassPtr, "key");
				SkipList.Node.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipList.Node>.NativeClassPtr, "val");
				SkipList.Node.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList.Node>.NativeClassPtr, 100666736);
				SkipList.Node.NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList.Node>.NativeClassPtr, 100666737);
				SkipList.Node.NativeMethodInfoPtr_get_Key_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList.Node>.NativeClassPtr, 100666738);
				SkipList.Node.NativeMethodInfoPtr_set_Key_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList.Node>.NativeClassPtr, 100666739);
				SkipList.Node.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList.Node>.NativeClassPtr, 100666740);
				SkipList.Node.NativeMethodInfoPtr_set_Value_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList.Node>.NativeClassPtr, 100666741);
				SkipList.Node.NativeMethodInfoPtr_get_Entry_Public_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList.Node>.NativeClassPtr, 100666742);
				SkipList.Node.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList.Node>.NativeClassPtr, 100666743);
			}

			// Token: 0x06002135 RID: 8501 RVA: 0x00090C30 File Offset: 0x0008EE30
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 18971, RefRangeEnd = 18973, XrefRangeStart = 18968, XrefRangeEnd = 18971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Node(int level)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkipList.Node>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref level;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.Node.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002136 RID: 8502 RVA: 0x00090C78 File Offset: 0x0008EE78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18973, XrefRangeEnd = 18976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Node(int level, Object key, Object val)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkipList.Node>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref level;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.Node.NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006A5 RID: 1701
			// (get) Token: 0x06002137 RID: 8503 RVA: 0x00090CE4 File Offset: 0x0008EEE4
			// (set) Token: 0x06002138 RID: 8504 RVA: 0x00090D24 File Offset: 0x0008EF24
			public unsafe Object Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.Node.NativeMethodInfoPtr_get_Key_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.Node.NativeMethodInfoPtr_set_Key_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170006A6 RID: 1702
			// (get) Token: 0x06002139 RID: 8505 RVA: 0x00090D68 File Offset: 0x0008EF68
			// (set) Token: 0x0600213A RID: 8506 RVA: 0x00090DA8 File Offset: 0x0008EFA8
			public unsafe Object Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.Node.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
				[CallerCount(33)]
				[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.Node.NativeMethodInfoPtr_set_Value_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170006A7 RID: 1703
			// (get) Token: 0x0600213B RID: 8507 RVA: 0x00090DEC File Offset: 0x0008EFEC
			public unsafe DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18976, XrefRangeEnd = 18977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.Node.NativeMethodInfoPtr_get_Entry_Public_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x0600213C RID: 8508 RVA: 0x00090E24 File Offset: 0x0008F024
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 18978, RefRangeEnd = 18981, XrefRangeStart = 18977, XrefRangeEnd = 18978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.Node.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600213D RID: 8509 RVA: 0x0000C4F0 File Offset: 0x0000A6F0
			public Node(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A2 RID: 1698
			// (get) Token: 0x0600213E RID: 8510 RVA: 0x00090E58 File Offset: 0x0008F058
			// (set) Token: 0x0600213F RID: 8511 RVA: 0x0000C4F9 File Offset: 0x0000A6F9
			public unsafe Il2CppReferenceArray<SkipList.Node> forward
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.Node.NativeFieldInfoPtr_forward);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkipList.Node>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.Node.NativeFieldInfoPtr_forward), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006A3 RID: 1699
			// (get) Token: 0x06002140 RID: 8512 RVA: 0x00090E88 File Offset: 0x0008F088
			// (set) Token: 0x06002141 RID: 8513 RVA: 0x0000C518 File Offset: 0x0000A718
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.Node.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.Node.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006A4 RID: 1700
			// (get) Token: 0x06002142 RID: 8514 RVA: 0x00090EB8 File Offset: 0x0008F0B8
			// (set) Token: 0x06002143 RID: 8515 RVA: 0x0000C537 File Offset: 0x0000A737
			public unsafe Object val
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.Node.NativeFieldInfoPtr_val);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.Node.NativeFieldInfoPtr_val), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020CD RID: 8397
			private static readonly IntPtr NativeFieldInfoPtr_forward;

			// Token: 0x040020CE RID: 8398
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040020CF RID: 8399
			private static readonly IntPtr NativeFieldInfoPtr_val;

			// Token: 0x040020D0 RID: 8400
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040020D1 RID: 8401
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_Object_0;

			// Token: 0x040020D2 RID: 8402
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_Object_0;

			// Token: 0x040020D3 RID: 8403
			private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_Object_0;

			// Token: 0x040020D4 RID: 8404
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

			// Token: 0x040020D5 RID: 8405
			private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Object_0;

			// Token: 0x040020D6 RID: 8406
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_get_DictionaryEntry_0;

			// Token: 0x040020D7 RID: 8407
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000261 RID: 609
		public class SkipListEnumerator : Object
		{
			// Token: 0x06002144 RID: 8516 RVA: 0x00090EE8 File Offset: 0x0008F0E8
			// Note: this type is marked as 'beforefieldinit'.
			static SkipListEnumerator()
			{
				Il2CppClassPointerStore<SkipList.SkipListEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkipList>.NativeClassPtr, "SkipListEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkipList.SkipListEnumerator>.NativeClassPtr);
				SkipList.SkipListEnumerator.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipList.SkipListEnumerator>.NativeClassPtr, "list");
				SkipList.SkipListEnumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipList.SkipListEnumerator>.NativeClassPtr, "current");
				SkipList.SkipListEnumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipList.SkipListEnumerator>.NativeClassPtr, "version");
				SkipList.SkipListEnumerator.NativeFieldInfoPtr_moveResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipList.SkipListEnumerator>.NativeClassPtr, "moveResult");
				SkipList.SkipListEnumerator.NativeMethodInfoPtr__ctor_Public_Void_SkipList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList.SkipListEnumerator>.NativeClassPtr, 100666744);
				SkipList.SkipListEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList.SkipListEnumerator>.NativeClassPtr, 100666745);
				SkipList.SkipListEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList.SkipListEnumerator>.NativeClassPtr, 100666746);
				SkipList.SkipListEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList.SkipListEnumerator>.NativeClassPtr, 100666747);
				SkipList.SkipListEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList.SkipListEnumerator>.NativeClassPtr, 100666748);
				SkipList.SkipListEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList.SkipListEnumerator>.NativeClassPtr, 100666749);
				SkipList.SkipListEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipList.SkipListEnumerator>.NativeClassPtr, 100666750);
			}

			// Token: 0x06002145 RID: 8517 RVA: 0x00090FF0 File Offset: 0x0008F1F0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 18981, RefRangeEnd = 18983, XrefRangeStart = 18981, XrefRangeEnd = 18981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SkipListEnumerator(SkipList list)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkipList.SkipListEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.SkipListEnumerator.NativeMethodInfoPtr__ctor_Public_Void_SkipList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170006AC RID: 1708
			// (get) Token: 0x06002146 RID: 8518 RVA: 0x0009103C File Offset: 0x0008F23C
			public unsafe virtual DictionaryEntry Entry
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 18983, RefRangeEnd = 18986, XrefRangeStart = 18983, XrefRangeEnd = 18983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.SkipListEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x170006AD RID: 1709
			// (get) Token: 0x06002147 RID: 8519 RVA: 0x00091074 File Offset: 0x0008F274
			public unsafe virtual Object Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18986, XrefRangeEnd = 18987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.SkipListEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170006AE RID: 1710
			// (get) Token: 0x06002148 RID: 8520 RVA: 0x000910B4 File Offset: 0x0008F2B4
			public unsafe virtual Object Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18987, XrefRangeEnd = 18988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.SkipListEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002149 RID: 8521 RVA: 0x000910F4 File Offset: 0x0008F2F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18988, XrefRangeEnd = 18989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.SkipListEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600214A RID: 8522 RVA: 0x00091130 File Offset: 0x0008F330
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.SkipListEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006AF RID: 1711
			// (get) Token: 0x0600214B RID: 8523 RVA: 0x00091164 File Offset: 0x0008F364
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18989, XrefRangeEnd = 18993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipList.SkipListEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600214C RID: 8524 RVA: 0x0000C556 File Offset: 0x0000A756
			public SkipListEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A8 RID: 1704
			// (get) Token: 0x0600214D RID: 8525 RVA: 0x000911A4 File Offset: 0x0008F3A4
			// (set) Token: 0x0600214E RID: 8526 RVA: 0x0000C55F File Offset: 0x0000A75F
			public unsafe SkipList list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.SkipListEnumerator.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkipList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.SkipListEnumerator.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006A9 RID: 1705
			// (get) Token: 0x0600214F RID: 8527 RVA: 0x000911D4 File Offset: 0x0008F3D4
			// (set) Token: 0x06002150 RID: 8528 RVA: 0x0000C57E File Offset: 0x0000A77E
			public unsafe SkipList.Node current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.SkipListEnumerator.NativeFieldInfoPtr_current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkipList.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.SkipListEnumerator.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006AA RID: 1706
			// (get) Token: 0x06002151 RID: 8529 RVA: 0x00091204 File Offset: 0x0008F404
			// (set) Token: 0x06002152 RID: 8530 RVA: 0x0000C59D File Offset: 0x0000A79D
			public unsafe long version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.SkipListEnumerator.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.SkipListEnumerator.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x170006AB RID: 1707
			// (get) Token: 0x06002153 RID: 8531 RVA: 0x0009122C File Offset: 0x0008F42C
			// (set) Token: 0x06002154 RID: 8532 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
			public unsafe bool moveResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.SkipListEnumerator.NativeFieldInfoPtr_moveResult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipList.SkipListEnumerator.NativeFieldInfoPtr_moveResult)) = value;
				}
			}

			// Token: 0x040020D8 RID: 8408
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x040020D9 RID: 8409
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x040020DA RID: 8410
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x040020DB RID: 8411
			private static readonly IntPtr NativeFieldInfoPtr_moveResult;

			// Token: 0x040020DC RID: 8412
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SkipList_0;

			// Token: 0x040020DD RID: 8413
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x040020DE RID: 8414
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x040020DF RID: 8415
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x040020E0 RID: 8416
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x040020E1 RID: 8417
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x040020E2 RID: 8418
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;
		}
	}
}
