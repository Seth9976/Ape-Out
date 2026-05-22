using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000338 RID: 824
	[Serializable]
	public class LongList : Object
	{
		// Token: 0x06003631 RID: 13873 RVA: 0x0010A5D0 File Offset: 0x001087D0
		// Note: this type is marked as 'beforefieldinit'.
		static LongList()
		{
			Il2CppClassPointerStore<LongList>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "LongList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LongList>.NativeClassPtr);
			LongList.NativeFieldInfoPtr_m_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongList>.NativeClassPtr, "m_values");
			LongList.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongList>.NativeClassPtr, "m_count");
			LongList.NativeFieldInfoPtr_m_totalItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongList>.NativeClassPtr, "m_totalItems");
			LongList.NativeFieldInfoPtr_m_currentItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongList>.NativeClassPtr, "m_currentItem");
			LongList.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671735);
			LongList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671736);
			LongList.NativeMethodInfoPtr_Add_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671737);
			LongList.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671738);
			LongList.NativeMethodInfoPtr_StartEnumeration_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671739);
			LongList.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671740);
			LongList.NativeMethodInfoPtr_get_Current_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671741);
			LongList.NativeMethodInfoPtr_RemoveElement_Internal_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671742);
			LongList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671743);
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x0010A704 File Offset: 0x00108904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214261, XrefRangeEnd = 214264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LongList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x0010A740 File Offset: 0x00108940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214264, XrefRangeEnd = 214267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LongList(int startingSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x0010A788 File Offset: 0x00108988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214267, XrefRangeEnd = 214268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_Add_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06003635 RID: 13877 RVA: 0x0010A7C8 File Offset: 0x001089C8
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x0010A804 File Offset: 0x00108A04
		[CallerCount(0)]
		public unsafe void StartEnumeration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_StartEnumeration_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x0010A838 File Offset: 0x00108A38
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06003638 RID: 13880 RVA: 0x0010A874 File Offset: 0x00108A74
		public unsafe long Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_get_Current_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x0010A8B0 File Offset: 0x00108AB0
		[CallerCount(0)]
		public unsafe bool RemoveElement(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_RemoveElement_Internal_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x0010A8FC File Offset: 0x00108AFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214274, RefRangeEnd = 214276, XrefRangeStart = 214268, XrefRangeEnd = 214274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnlargeArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x000132BE File Offset: 0x000114BE
		public LongList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x0600363C RID: 13884 RVA: 0x0010A930 File Offset: 0x00108B30
		// (set) Token: 0x0600363D RID: 13885 RVA: 0x000132C7 File Offset: 0x000114C7
		public unsafe Il2CppStructArray<long> m_values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x0600363E RID: 13886 RVA: 0x0010A960 File Offset: 0x00108B60
		// (set) Token: 0x0600363F RID: 13887 RVA: 0x000132E6 File Offset: 0x000114E6
		public unsafe int m_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_count)) = value;
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06003640 RID: 13888 RVA: 0x0010A988 File Offset: 0x00108B88
		// (set) Token: 0x06003641 RID: 13889 RVA: 0x00013301 File Offset: 0x00011501
		public unsafe int m_totalItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_totalItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_totalItems)) = value;
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06003642 RID: 13890 RVA: 0x0010A9B0 File Offset: 0x00108BB0
		// (set) Token: 0x06003643 RID: 13891 RVA: 0x0001331C File Offset: 0x0001151C
		public unsafe int m_currentItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_currentItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_currentItem)) = value;
			}
		}

		// Token: 0x04002DCB RID: 11723
		private static readonly IntPtr NativeFieldInfoPtr_m_values;

		// Token: 0x04002DCC RID: 11724
		private static readonly IntPtr NativeFieldInfoPtr_m_count;

		// Token: 0x04002DCD RID: 11725
		private static readonly IntPtr NativeFieldInfoPtr_m_totalItems;

		// Token: 0x04002DCE RID: 11726
		private static readonly IntPtr NativeFieldInfoPtr_m_currentItem;

		// Token: 0x04002DCF RID: 11727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002DD0 RID: 11728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04002DD1 RID: 11729
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_Int64_0;

		// Token: 0x04002DD2 RID: 11730
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;

		// Token: 0x04002DD3 RID: 11731
		private static readonly IntPtr NativeMethodInfoPtr_StartEnumeration_Internal_Void_0;

		// Token: 0x04002DD4 RID: 11732
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Internal_Boolean_0;

		// Token: 0x04002DD5 RID: 11733
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Internal_get_Int64_0;

		// Token: 0x04002DD6 RID: 11734
		private static readonly IntPtr NativeMethodInfoPtr_RemoveElement_Internal_Boolean_Int64_0;

		// Token: 0x04002DD7 RID: 11735
		private static readonly IntPtr NativeMethodInfoPtr_EnlargeArray_Private_Void_0;
	}
}
