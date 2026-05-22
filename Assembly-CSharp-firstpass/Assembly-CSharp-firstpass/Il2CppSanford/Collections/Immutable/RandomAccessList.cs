using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppSanford.Collections.Immutable
{
	// Token: 0x020001E2 RID: 482
	public class RandomAccessList : Object
	{
		// Token: 0x0600186F RID: 6255 RVA: 0x0006D9EC File Offset: 0x0006BBEC
		// Note: this type is marked as 'beforefieldinit'.
		static RandomAccessList()
		{
			Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections.Immutable", "RandomAccessList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr);
			RandomAccessList.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr, "Empty");
			RandomAccessList.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr, "count");
			RandomAccessList.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr, "first");
			RandomAccessList.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr, "head");
			RandomAccessList.NativeFieldInfoPtr_tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr, "tail");
			RandomAccessList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr, 100666837);
			RandomAccessList.NativeMethodInfoPtr__ctor_Private_Void_RalTopNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr, 100666838);
			RandomAccessList.NativeMethodInfoPtr_Cons_Public_RandomAccessList_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr, 100666839);
			RandomAccessList.NativeMethodInfoPtr_GetValue_Public_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr, 100666840);
			RandomAccessList.NativeMethodInfoPtr_SetValue_Public_RandomAccessList_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr, 100666841);
			RandomAccessList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr, 100666842);
			RandomAccessList.NativeMethodInfoPtr_get_Head_Public_get_RandomAccessList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr, 100666843);
			RandomAccessList.NativeMethodInfoPtr_get_Tail_Public_get_RandomAccessList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr, 100666844);
			RandomAccessList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr, 100666845);
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x0006DB34 File Offset: 0x0006BD34
		[CallerCount(0)]
		public unsafe RandomAccessList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomAccessList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x0006DB70 File Offset: 0x0006BD70
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 19461, RefRangeEnd = 19470, XrefRangeStart = 19461, XrefRangeEnd = 19470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomAccessList(RalTopNode first, int count)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomAccessList>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomAccessList.NativeMethodInfoPtr__ctor_Private_Void_RalTopNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0006DBCC File Offset: 0x0006BDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19918, XrefRangeEnd = 19939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomAccessList Cons(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomAccessList.NativeMethodInfoPtr_Cons_Public_RandomAccessList_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RandomAccessList>(intPtr3) : null;
			}
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x0006DC1C File Offset: 0x0006BE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19939, XrefRangeEnd = 19950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomAccessList.NativeMethodInfoPtr_GetValue_Public_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x0006DC68 File Offset: 0x0006BE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19950, XrefRangeEnd = 19955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomAccessList SetValue(Object value, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomAccessList.NativeMethodInfoPtr_SetValue_Public_RandomAccessList_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RandomAccessList>(intPtr3) : null;
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x0006DCC8 File Offset: 0x0006BEC8
		public unsafe int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomAccessList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x0006DD04 File Offset: 0x0006BF04
		public unsafe RandomAccessList Head
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19955, XrefRangeEnd = 19966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomAccessList.NativeMethodInfoPtr_get_Head_Public_get_RandomAccessList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RandomAccessList>(intPtr3) : null;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x0006DD44 File Offset: 0x0006BF44
		public unsafe RandomAccessList Tail
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19966, XrefRangeEnd = 19987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomAccessList.NativeMethodInfoPtr_get_Tail_Public_get_RandomAccessList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RandomAccessList>(intPtr3) : null;
			}
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x0006DD84 File Offset: 0x0006BF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19987, XrefRangeEnd = 19991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomAccessList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00009BDD File Offset: 0x00007DDD
		public RandomAccessList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x0006DDC4 File Offset: 0x0006BFC4
		// (set) Token: 0x0600187B RID: 6267 RVA: 0x00009BE6 File Offset: 0x00007DE6
		public unsafe static RandomAccessList Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RandomAccessList.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomAccessList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RandomAccessList.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x0006DDEC File Offset: 0x0006BFEC
		// (set) Token: 0x0600187D RID: 6269 RVA: 0x00009BF8 File Offset: 0x00007DF8
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomAccessList.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomAccessList.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x0006DE14 File Offset: 0x0006C014
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x00009C13 File Offset: 0x00007E13
		public unsafe RalTopNode first
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomAccessList.NativeFieldInfoPtr_first);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RalTopNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomAccessList.NativeFieldInfoPtr_first), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x0006DE44 File Offset: 0x0006C044
		// (set) Token: 0x06001881 RID: 6273 RVA: 0x00009C32 File Offset: 0x00007E32
		public unsafe RandomAccessList head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomAccessList.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomAccessList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomAccessList.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x0006DE74 File Offset: 0x0006C074
		// (set) Token: 0x06001883 RID: 6275 RVA: 0x00009C51 File Offset: 0x00007E51
		public unsafe RandomAccessList tail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomAccessList.NativeFieldInfoPtr_tail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomAccessList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomAccessList.NativeFieldInfoPtr_tail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001992 RID: 6546
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04001993 RID: 6547
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04001994 RID: 6548
		private static readonly IntPtr NativeFieldInfoPtr_first;

		// Token: 0x04001995 RID: 6549
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x04001996 RID: 6550
		private static readonly IntPtr NativeFieldInfoPtr_tail;

		// Token: 0x04001997 RID: 6551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001998 RID: 6552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_RalTopNode_Int32_0;

		// Token: 0x04001999 RID: 6553
		private static readonly IntPtr NativeMethodInfoPtr_Cons_Public_RandomAccessList_Object_0;

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int32_0;

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_RandomAccessList_Object_Int32_0;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeMethodInfoPtr_get_Head_Public_get_RandomAccessList_0;

		// Token: 0x0400199E RID: 6558
		private static readonly IntPtr NativeMethodInfoPtr_get_Tail_Public_get_RandomAccessList_0;

		// Token: 0x0400199F RID: 6559
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;
	}
}
