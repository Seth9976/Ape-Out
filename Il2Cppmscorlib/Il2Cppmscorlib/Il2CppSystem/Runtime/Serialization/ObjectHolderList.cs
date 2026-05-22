using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000339 RID: 825
	public class ObjectHolderList : Object
	{
		// Token: 0x06003644 RID: 13892 RVA: 0x0010A9D8 File Offset: 0x00108BD8
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectHolderList()
		{
			Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ObjectHolderList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr);
			ObjectHolderList.NativeFieldInfoPtr_m_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, "m_values");
			ObjectHolderList.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, "m_count");
			ObjectHolderList.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671744);
			ObjectHolderList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671745);
			ObjectHolderList.NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671746);
			ObjectHolderList.NativeMethodInfoPtr_GetFixupEnumerator_Internal_ObjectHolderListEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671747);
			ObjectHolderList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671748);
			ObjectHolderList.NativeMethodInfoPtr_get_Version_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671749);
			ObjectHolderList.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr, 100671750);
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x0010AABC File Offset: 0x00108CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214276, XrefRangeEnd = 214279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolderList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x0010AAF8 File Offset: 0x00108CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214279, XrefRangeEnd = 214282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolderList(int startingSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolderList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x0010AB40 File Offset: 0x00108D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214282, XrefRangeEnd = 214288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(ObjectHolder value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectHolderList.NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_ObjectHolder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x0010AB90 File Offset: 0x00108D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214288, XrefRangeEnd = 214291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolderListEnumerator GetFixupEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr_GetFixupEnumerator_Internal_ObjectHolderListEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectHolderListEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x0010ABD0 File Offset: 0x00108DD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214297, RefRangeEnd = 214298, XrefRangeStart = 214291, XrefRangeEnd = 214297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnlargeArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x0600364A RID: 13898 RVA: 0x0010AC04 File Offset: 0x00108E04
		public unsafe int Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr_get_Version_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x0600364B RID: 13899 RVA: 0x0010AC40 File Offset: 0x00108E40
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderList.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x00013337 File Offset: 0x00011537
		public ObjectHolderList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x0600364D RID: 13901 RVA: 0x0010AC7C File Offset: 0x00108E7C
		// (set) Token: 0x0600364E RID: 13902 RVA: 0x00013340 File Offset: 0x00011540
		public unsafe Il2CppReferenceArray<ObjectHolder> m_values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderList.NativeFieldInfoPtr_m_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ObjectHolder>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderList.NativeFieldInfoPtr_m_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x0600364F RID: 13903 RVA: 0x0010ACAC File Offset: 0x00108EAC
		// (set) Token: 0x06003650 RID: 13904 RVA: 0x0001335F File Offset: 0x0001155F
		public unsafe int m_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderList.NativeFieldInfoPtr_m_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderList.NativeFieldInfoPtr_m_count)) = value;
			}
		}

		// Token: 0x04002DD8 RID: 11736
		private static readonly IntPtr NativeFieldInfoPtr_m_values;

		// Token: 0x04002DD9 RID: 11737
		private static readonly IntPtr NativeFieldInfoPtr_m_count;

		// Token: 0x04002DDA RID: 11738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002DDB RID: 11739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04002DDC RID: 11740
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Virtual_New_Void_ObjectHolder_0;

		// Token: 0x04002DDD RID: 11741
		private static readonly IntPtr NativeMethodInfoPtr_GetFixupEnumerator_Internal_ObjectHolderListEnumerator_0;

		// Token: 0x04002DDE RID: 11742
		private static readonly IntPtr NativeMethodInfoPtr_EnlargeArray_Private_Void_0;

		// Token: 0x04002DDF RID: 11743
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Internal_get_Int32_0;

		// Token: 0x04002DE0 RID: 11744
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;
	}
}
