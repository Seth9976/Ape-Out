using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Specialized
{
	// Token: 0x020000CE RID: 206
	[Serializable]
	public class ListDictionary : Object
	{
		// Token: 0x06000B5A RID: 2906 RVA: 0x0003B008 File Offset: 0x00039208
		// Note: this type is marked as 'beforefieldinit'.
		static ListDictionary()
		{
			Il2CppClassPointerStore<ListDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Specialized", "ListDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr);
			ListDictionary.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "head");
			ListDictionary.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "version");
			ListDictionary.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "count");
			ListDictionary.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "comparer");
			ListDictionary.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "_syncRoot");
			ListDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664903);
			ListDictionary.NativeMethodInfoPtr__ctor_Public_Void_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664904);
			ListDictionary.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664905);
			ListDictionary.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664906);
			ListDictionary.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664907);
			ListDictionary.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664908);
			ListDictionary.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664909);
			ListDictionary.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664910);
			ListDictionary.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664911);
			ListDictionary.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664912);
			ListDictionary.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664913);
			ListDictionary.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664914);
			ListDictionary.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664915);
			ListDictionary.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664916);
			ListDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664917);
			ListDictionary.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664918);
			ListDictionary.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664919);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0003B1F0 File Offset: 0x000393F0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0003B22C File Offset: 0x0003942C
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListDictionary(IComparer comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr__ctor_Public_Void_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000354 RID: 852
		public unsafe virtual Object this[Object key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375408, XrefRangeEnd = 375411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 375423, RefRangeEnd = 375424, XrefRangeStart = 375411, XrefRangeEnd = 375423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x0003B31C File Offset: 0x0003951C
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0003B358 File Offset: 0x00039558
		public unsafe virtual ICollection Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375424, XrefRangeEnd = 375427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x0003B398 File Offset: 0x00039598
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0003B3D4 File Offset: 0x000395D4
		public unsafe virtual bool IsFixedSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x0003B410 File Offset: 0x00039610
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0003B44C File Offset: 0x0003964C
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375427, XrefRangeEnd = 375430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x0003B48C File Offset: 0x0003968C
		public unsafe virtual ICollection Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375430, XrefRangeEnd = 375433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0003B4CC File Offset: 0x000396CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 375445, RefRangeEnd = 375448, XrefRangeStart = 375433, XrefRangeEnd = 375445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0003B520 File Offset: 0x00039720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375448, XrefRangeEnd = 375452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0003B570 File Offset: 0x00039770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375457, RefRangeEnd = 375458, XrefRangeStart = 375452, XrefRangeEnd = 375457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0003B5C0 File Offset: 0x000397C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375458, XrefRangeEnd = 375462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0003B600 File Offset: 0x00039800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375462, XrefRangeEnd = 375466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0003B640 File Offset: 0x00039840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375466, XrefRangeEnd = 375470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00006896 File Offset: 0x00004A96
		public ListDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x0003B684 File Offset: 0x00039884
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x0000689F File Offset: 0x00004A9F
		public unsafe ListDictionary.DictionaryNode head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary.DictionaryNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0003B6B4 File Offset: 0x000398B4
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x000068BE File Offset: 0x00004ABE
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x0003B6DC File Offset: 0x000398DC
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x000068D9 File Offset: 0x00004AD9
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0003B704 File Offset: 0x00039904
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x000068F4 File Offset: 0x00004AF4
		public unsafe IComparer comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x0003B734 File Offset: 0x00039934
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x00006913 File Offset: 0x00004B13
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IComparer_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x020001C3 RID: 451
		public class NodeEnumerator : Object
		{
			// Token: 0x0600194A RID: 6474 RVA: 0x0006CD68 File Offset: 0x0006AF68
			// Note: this type is marked as 'beforefieldinit'.
			static NodeEnumerator()
			{
				Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "NodeEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr);
				ListDictionary.NodeEnumerator.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, "list");
				ListDictionary.NodeEnumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, "current");
				ListDictionary.NodeEnumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, "version");
				ListDictionary.NodeEnumerator.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, "start");
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100664920);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100664921);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100664922);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100664923);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100664924);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100664925);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100664926);
			}

			// Token: 0x0600194B RID: 6475 RVA: 0x0006CE70 File Offset: 0x0006B070
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 229510, RefRangeEnd = 229517, XrefRangeStart = 229510, XrefRangeEnd = 229517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NodeEnumerator(ListDictionary list)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000810 RID: 2064
			// (get) Token: 0x0600194C RID: 6476 RVA: 0x0006CEBC File Offset: 0x0006B0BC
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375393, XrefRangeEnd = 375397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17000811 RID: 2065
			// (get) Token: 0x0600194D RID: 6477 RVA: 0x0006CEFC File Offset: 0x0006B0FC
			public unsafe virtual DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375397, XrefRangeEnd = 375398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x17000812 RID: 2066
			// (get) Token: 0x0600194E RID: 6478 RVA: 0x0006CF34 File Offset: 0x0006B134
			public unsafe virtual Object Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17000813 RID: 2067
			// (get) Token: 0x0600194F RID: 6479 RVA: 0x0006CF74 File Offset: 0x0006B174
			public unsafe virtual Object Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001950 RID: 6480 RVA: 0x0006CFB4 File Offset: 0x0006B1B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375398, XrefRangeEnd = 375399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001951 RID: 6481 RVA: 0x0006CFF0 File Offset: 0x0006B1F0
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001952 RID: 6482 RVA: 0x0000D070 File Offset: 0x0000B270
			public NodeEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700080C RID: 2060
			// (get) Token: 0x06001953 RID: 6483 RVA: 0x0006D024 File Offset: 0x0006B224
			// (set) Token: 0x06001954 RID: 6484 RVA: 0x0000D079 File Offset: 0x0000B279
			public unsafe ListDictionary list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700080D RID: 2061
			// (get) Token: 0x06001955 RID: 6485 RVA: 0x0006D054 File Offset: 0x0006B254
			// (set) Token: 0x06001956 RID: 6486 RVA: 0x0000D098 File Offset: 0x0000B298
			public unsafe ListDictionary.DictionaryNode current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr_current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary.DictionaryNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700080E RID: 2062
			// (get) Token: 0x06001957 RID: 6487 RVA: 0x0006D084 File Offset: 0x0006B284
			// (set) Token: 0x06001958 RID: 6488 RVA: 0x0000D0B7 File Offset: 0x0000B2B7
			public unsafe int version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x1700080F RID: 2063
			// (get) Token: 0x06001959 RID: 6489 RVA: 0x0006D0AC File Offset: 0x0006B2AC
			// (set) Token: 0x0600195A RID: 6490 RVA: 0x0000D0D2 File Offset: 0x0000B2D2
			public unsafe bool start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x04001404 RID: 5124
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x04001405 RID: 5125
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x04001406 RID: 5126
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x04001407 RID: 5127
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x04001408 RID: 5128
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_0;

			// Token: 0x04001409 RID: 5129
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x0400140A RID: 5130
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x0400140B RID: 5131
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x0400140C RID: 5132
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x0400140D RID: 5133
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x0400140E RID: 5134
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x020001C4 RID: 452
		public class NodeKeyValueCollection : Object
		{
			// Token: 0x0600195B RID: 6491 RVA: 0x0006D0D4 File Offset: 0x0006B2D4
			// Note: this type is marked as 'beforefieldinit'.
			static NodeKeyValueCollection()
			{
				Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "NodeKeyValueCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr);
				ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, "list");
				ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr_isKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, "isKeys");
				ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, 100664927);
				ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, 100664928);
				ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, 100664929);
				ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, 100664930);
				ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, 100664931);
				ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, 100664932);
			}

			// Token: 0x0600195C RID: 6492 RVA: 0x0006D1A0 File Offset: 0x0006B3A0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 161220, RefRangeEnd = 161221, XrefRangeStart = 161220, XrefRangeEnd = 161221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NodeKeyValueCollection(ListDictionary list, bool isKeys)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isKeys;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600195D RID: 6493 RVA: 0x0006D1FC File Offset: 0x0006B3FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375400, XrefRangeEnd = 375402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int index)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000816 RID: 2070
			// (get) Token: 0x0600195E RID: 6494 RVA: 0x0006D24C File Offset: 0x0006B44C
			public unsafe virtual int System.Collections.ICollection.Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000817 RID: 2071
			// (get) Token: 0x0600195F RID: 6495 RVA: 0x0006D288 File Offset: 0x0006B488
			public unsafe virtual bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000818 RID: 2072
			// (get) Token: 0x06001960 RID: 6496 RVA: 0x0006D2C4 File Offset: 0x0006B4C4
			public unsafe virtual Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375402, XrefRangeEnd = 375405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001961 RID: 6497 RVA: 0x0006D304 File Offset: 0x0006B504
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375405, XrefRangeEnd = 375408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001962 RID: 6498 RVA: 0x0000D0ED File Offset: 0x0000B2ED
			public NodeKeyValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000814 RID: 2068
			// (get) Token: 0x06001963 RID: 6499 RVA: 0x0006D344 File Offset: 0x0006B544
			// (set) Token: 0x06001964 RID: 6500 RVA: 0x0000D0F6 File Offset: 0x0000B2F6
			public unsafe ListDictionary list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000815 RID: 2069
			// (get) Token: 0x06001965 RID: 6501 RVA: 0x0006D374 File Offset: 0x0006B574
			// (set) Token: 0x06001966 RID: 6502 RVA: 0x0000D115 File Offset: 0x0000B315
			public unsafe bool isKeys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr_isKeys);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr_isKeys)) = value;
				}
			}

			// Token: 0x0400140F RID: 5135
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x04001410 RID: 5136
			private static readonly IntPtr NativeFieldInfoPtr_isKeys;

			// Token: 0x04001411 RID: 5137
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0;

			// Token: 0x04001412 RID: 5138
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x04001413 RID: 5139
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04001414 RID: 5140
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04001415 RID: 5141
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001416 RID: 5142
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0200023C RID: 572
			public class NodeKeyValueEnumerator : Object
			{
				// Token: 0x06001E56 RID: 7766 RVA: 0x0007BE30 File Offset: 0x0007A030
				// Note: this type is marked as 'beforefieldinit'.
				static NodeKeyValueEnumerator()
				{
					Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, "NodeKeyValueEnumerator");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr);
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "list");
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "current");
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "version");
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_isKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "isKeys");
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "start");
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100664933);
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100664934);
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100664935);
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100664936);
				}

				// Token: 0x06001E57 RID: 7767 RVA: 0x0007BF10 File Offset: 0x0007A110
				[CallerCount(0)]
				public unsafe NodeKeyValueEnumerator(ListDictionary list, bool isKeys)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isKeys;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000988 RID: 2440
				// (get) Token: 0x06001E58 RID: 7768 RVA: 0x0007BF6C File Offset: 0x0007A16C
				public unsafe virtual Object Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06001E59 RID: 7769 RVA: 0x0007BFAC File Offset: 0x0007A1AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375399, XrefRangeEnd = 375400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe virtual bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001E5A RID: 7770 RVA: 0x0007BFE8 File Offset: 0x0007A1E8
				[CallerCount(0)]
				public unsafe virtual void Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001E5B RID: 7771 RVA: 0x0001053A File Offset: 0x0000E73A
				public NodeKeyValueEnumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000983 RID: 2435
				// (get) Token: 0x06001E5C RID: 7772 RVA: 0x0007C01C File Offset: 0x0007A21C
				// (set) Token: 0x06001E5D RID: 7773 RVA: 0x00010543 File Offset: 0x0000E743
				public unsafe ListDictionary list
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_list);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000984 RID: 2436
				// (get) Token: 0x06001E5E RID: 7774 RVA: 0x0007C04C File Offset: 0x0007A24C
				// (set) Token: 0x06001E5F RID: 7775 RVA: 0x00010562 File Offset: 0x0000E762
				public unsafe ListDictionary.DictionaryNode current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary.DictionaryNode>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000985 RID: 2437
				// (get) Token: 0x06001E60 RID: 7776 RVA: 0x0007C07C File Offset: 0x0007A27C
				// (set) Token: 0x06001E61 RID: 7777 RVA: 0x00010581 File Offset: 0x0000E781
				public unsafe int version
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_version);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_version)) = value;
					}
				}

				// Token: 0x17000986 RID: 2438
				// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0007C0A4 File Offset: 0x0007A2A4
				// (set) Token: 0x06001E63 RID: 7779 RVA: 0x0001059C File Offset: 0x0000E79C
				public unsafe bool isKeys
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_isKeys);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_isKeys)) = value;
					}
				}

				// Token: 0x17000987 RID: 2439
				// (get) Token: 0x06001E64 RID: 7780 RVA: 0x0007C0CC File Offset: 0x0007A2CC
				// (set) Token: 0x06001E65 RID: 7781 RVA: 0x000105B7 File Offset: 0x0000E7B7
				public unsafe bool start
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_start);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_start)) = value;
					}
				}

				// Token: 0x040016DE RID: 5854
				private static readonly IntPtr NativeFieldInfoPtr_list;

				// Token: 0x040016DF RID: 5855
				private static readonly IntPtr NativeFieldInfoPtr_current;

				// Token: 0x040016E0 RID: 5856
				private static readonly IntPtr NativeFieldInfoPtr_version;

				// Token: 0x040016E1 RID: 5857
				private static readonly IntPtr NativeFieldInfoPtr_isKeys;

				// Token: 0x040016E2 RID: 5858
				private static readonly IntPtr NativeFieldInfoPtr_start;

				// Token: 0x040016E3 RID: 5859
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0;

				// Token: 0x040016E4 RID: 5860
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

				// Token: 0x040016E5 RID: 5861
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x040016E6 RID: 5862
				private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
			}
		}

		// Token: 0x020001C5 RID: 453
		[Serializable]
		public class DictionaryNode : Object
		{
			// Token: 0x06001967 RID: 6503 RVA: 0x0006D39C File Offset: 0x0006B59C
			// Note: this type is marked as 'beforefieldinit'.
			static DictionaryNode()
			{
				Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "DictionaryNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr);
				ListDictionary.DictionaryNode.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr, "key");
				ListDictionary.DictionaryNode.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr, "value");
				ListDictionary.DictionaryNode.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr, "next");
				ListDictionary.DictionaryNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr, 100664937);
			}

			// Token: 0x06001968 RID: 6504 RVA: 0x0006D418 File Offset: 0x0006B618
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictionaryNode()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.DictionaryNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001969 RID: 6505 RVA: 0x0000D130 File Offset: 0x0000B330
			public DictionaryNode(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000819 RID: 2073
			// (get) Token: 0x0600196A RID: 6506 RVA: 0x0006D454 File Offset: 0x0006B654
			// (set) Token: 0x0600196B RID: 6507 RVA: 0x0000D139 File Offset: 0x0000B339
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700081A RID: 2074
			// (get) Token: 0x0600196C RID: 6508 RVA: 0x0006D484 File Offset: 0x0006B684
			// (set) Token: 0x0600196D RID: 6509 RVA: 0x0000D158 File Offset: 0x0000B358
			public unsafe Object value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700081B RID: 2075
			// (get) Token: 0x0600196E RID: 6510 RVA: 0x0006D4B4 File Offset: 0x0006B6B4
			// (set) Token: 0x0600196F RID: 6511 RVA: 0x0000D177 File Offset: 0x0000B377
			public unsafe ListDictionary.DictionaryNode next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary.DictionaryNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001417 RID: 5143
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04001418 RID: 5144
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04001419 RID: 5145
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x0400141A RID: 5146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
