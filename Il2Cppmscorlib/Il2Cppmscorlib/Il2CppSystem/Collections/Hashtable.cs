using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000476 RID: 1142
	[Serializable]
	public class Hashtable : Object
	{
		// Token: 0x06004561 RID: 17761 RVA: 0x0013F428 File Offset: 0x0013D628
		// Note: this type is marked as 'beforefieldinit'.
		static Hashtable()
		{
			Il2CppClassPointerStore<Hashtable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "Hashtable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable>.NativeClassPtr);
			Hashtable.NativeFieldInfoPtr_HashPrime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "HashPrime");
			Hashtable.NativeFieldInfoPtr_InitialSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "InitialSize");
			Hashtable.NativeFieldInfoPtr_LoadFactorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "LoadFactorName");
			Hashtable.NativeFieldInfoPtr_VersionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "VersionName");
			Hashtable.NativeFieldInfoPtr_ComparerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "ComparerName");
			Hashtable.NativeFieldInfoPtr_HashCodeProviderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "HashCodeProviderName");
			Hashtable.NativeFieldInfoPtr_HashSizeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "HashSizeName");
			Hashtable.NativeFieldInfoPtr_KeysName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "KeysName");
			Hashtable.NativeFieldInfoPtr_ValuesName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "ValuesName");
			Hashtable.NativeFieldInfoPtr_KeyComparerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "KeyComparerName");
			Hashtable.NativeFieldInfoPtr_buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "buckets");
			Hashtable.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "count");
			Hashtable.NativeFieldInfoPtr_occupancy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "occupancy");
			Hashtable.NativeFieldInfoPtr_loadsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "loadsize");
			Hashtable.NativeFieldInfoPtr_loadFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "loadFactor");
			Hashtable.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "version");
			Hashtable.NativeFieldInfoPtr_isWriterInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "isWriterInProgress");
			Hashtable.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "keys");
			Hashtable.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "values");
			Hashtable.NativeFieldInfoPtr__keycomparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "_keycomparer");
			Hashtable.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "_syncRoot");
			Hashtable.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673437);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673438);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673439);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673440);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IHashCodeProvider_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673441);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673442);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_IHashCodeProvider_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673443);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673444);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673445);
			Hashtable.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673446);
			Hashtable.NativeMethodInfoPtr_InitHash_Private_UInt32_Object_Int32_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673447);
			Hashtable.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673448);
			Hashtable.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673449);
			Hashtable.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673450);
			Hashtable.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673451);
			Hashtable.NativeMethodInfoPtr_ContainsKey_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673452);
			Hashtable.NativeMethodInfoPtr_CopyKeys_Private_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673453);
			Hashtable.NativeMethodInfoPtr_CopyEntries_Private_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673454);
			Hashtable.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673455);
			Hashtable.NativeMethodInfoPtr_CopyValues_Private_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673456);
			Hashtable.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673457);
			Hashtable.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673458);
			Hashtable.NativeMethodInfoPtr_expand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673459);
			Hashtable.NativeMethodInfoPtr_rehash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673460);
			Hashtable.NativeMethodInfoPtr_UpdateVersion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673461);
			Hashtable.NativeMethodInfoPtr_rehash_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673462);
			Hashtable.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673463);
			Hashtable.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673464);
			Hashtable.NativeMethodInfoPtr_GetHash_Protected_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673465);
			Hashtable.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673466);
			Hashtable.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673467);
			Hashtable.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673468);
			Hashtable.NativeMethodInfoPtr_KeyEquals_Protected_Virtual_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673469);
			Hashtable.NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673470);
			Hashtable.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673471);
			Hashtable.NativeMethodInfoPtr_Insert_Private_Void_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673472);
			Hashtable.NativeMethodInfoPtr_putEntry_Private_Void_Il2CppReferenceArray_1_bucket_Object_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673473);
			Hashtable.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673474);
			Hashtable.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673475);
			Hashtable.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673476);
			Hashtable.NativeMethodInfoPtr_Synchronized_Public_Static_Hashtable_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673477);
			Hashtable.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673478);
			Hashtable.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100673479);
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x0013F958 File Offset: 0x0013DB58
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(bool trash)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref trash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x0013F9A0 File Offset: 0x0013DBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229027, XrefRangeEnd = 229028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x0013F9DC File Offset: 0x0013DBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229028, XrefRangeEnd = 229029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x0013FA24 File Offset: 0x0013DC24
		[CallerCount(102)]
		[CachedScanResults(RefRangeStart = 229038, RefRangeEnd = 229140, XrefRangeStart = 229029, XrefRangeEnd = 229038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(int capacity, float loadFactor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x0013FA7C File Offset: 0x0013DC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229140, XrefRangeEnd = 229147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadFactor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hcp);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IHashCodeProvider_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x0013FAF8 File Offset: 0x0013DCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229147, XrefRangeEnd = 229148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadFactor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004568 RID: 17768 RVA: 0x0013FB60 File Offset: 0x0013DD60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229154, RefRangeEnd = 229155, XrefRangeStart = 229148, XrefRangeEnd = 229154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(IHashCodeProvider hcp, IComparer comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hcp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_IHashCodeProvider_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x0013FBC0 File Offset: 0x0013DDC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 229156, RefRangeEnd = 229159, XrefRangeStart = 229155, XrefRangeEnd = 229156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x0013FC0C File Offset: 0x0013DE0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 229160, RefRangeEnd = 229164, XrefRangeStart = 229159, XrefRangeEnd = 229160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(int capacity, IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x0013FC68 File Offset: 0x0013DE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229164, XrefRangeEnd = 229172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x0013FCCC File Offset: 0x0013DECC
		[CallerCount(0)]
		public unsafe uint InitHash(Object key, int hashsize, out uint seed, out uint incr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashsize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &seed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &incr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_InitHash_Private_UInt32_Object_Int32_byref_UInt32_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x0013FD44 File Offset: 0x0013DF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229172, XrefRangeEnd = 229173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x0013FDA4 File Offset: 0x0013DFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229173, XrefRangeEnd = 229178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x0013FDE0 File Offset: 0x0013DFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229178, XrefRangeEnd = 229182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x0013FE2C File Offset: 0x0013E02C
		[CallerCount(0)]
		public unsafe virtual bool Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004571 RID: 17777 RVA: 0x0013FE84 File Offset: 0x0013E084
		[CallerCount(0)]
		public unsafe virtual bool ContainsKey(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_ContainsKey_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x0013FEDC File Offset: 0x0013E0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229182, XrefRangeEnd = 229183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyKeys(Array array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_CopyKeys_Private_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x0013FF2C File Offset: 0x0013E12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229183, XrefRangeEnd = 229188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyEntries(Array array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_CopyEntries_Private_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004574 RID: 17780 RVA: 0x0013FF7C File Offset: 0x0013E17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229188, XrefRangeEnd = 229194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x0013FFD8 File Offset: 0x0013E1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229194, XrefRangeEnd = 229195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyValues(Array array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_CopyValues_Private_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170011BC RID: 4540
		public unsafe virtual Object this[Object key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229195, XrefRangeEnd = 229208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229208, XrefRangeEnd = 229209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x001400E4 File Offset: 0x0013E2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229209, XrefRangeEnd = 229215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void expand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_expand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x00140118 File Offset: 0x0013E318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229215, XrefRangeEnd = 229217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void rehash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_rehash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600457A RID: 17786 RVA: 0x0014014C File Offset: 0x0013E34C
		[CallerCount(0)]
		public unsafe void UpdateVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_UpdateVersion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600457B RID: 17787 RVA: 0x00140180 File Offset: 0x0013E380
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 229227, RefRangeEnd = 229230, XrefRangeStart = 229217, XrefRangeEnd = 229227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void rehash(int newsize, bool forceNewHashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newsize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceNewHashCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_rehash_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x001401CC File Offset: 0x0013E3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229230, XrefRangeEnd = 229233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x0014020C File Offset: 0x0013E40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229233, XrefRangeEnd = 229236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x00140258 File Offset: 0x0013E458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229236, XrefRangeEnd = 229240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHash(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_GetHash_Protected_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x0600457F RID: 17791 RVA: 0x001402B0 File Offset: 0x0013E4B0
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06004580 RID: 17792 RVA: 0x001402F8 File Offset: 0x0013E4F8
		public unsafe virtual bool IsFixedSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06004581 RID: 17793 RVA: 0x00140340 File Offset: 0x0013E540
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x00140388 File Offset: 0x0013E588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229240, XrefRangeEnd = 229243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool KeyEquals(Object item, Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_KeyEquals_Protected_Virtual_New_Boolean_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06004583 RID: 17795 RVA: 0x001403F4 File Offset: 0x0013E5F4
		public unsafe virtual ICollection Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229243, XrefRangeEnd = 229246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x06004584 RID: 17796 RVA: 0x00140440 File Offset: 0x0013E640
		public unsafe virtual ICollection Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229246, XrefRangeEnd = 229249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x0014048C File Offset: 0x0013E68C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 229264, RefRangeEnd = 229267, XrefRangeStart = 229249, XrefRangeEnd = 229264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(Object key, Object nvalue, bool add)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nvalue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref add;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_Insert_Private_Void_Object_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x001404F0 File Offset: 0x0013E6F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229268, RefRangeEnd = 229269, XrefRangeStart = 229267, XrefRangeEnd = 229268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void putEntry(Il2CppReferenceArray<Hashtable.bucket> newBuckets, Object key, Object nvalue, int hashcode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newBuckets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nvalue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashcode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_putEntry_Private_Void_Il2CppReferenceArray_1_bucket_Object_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004587 RID: 17799 RVA: 0x00140564 File Offset: 0x0013E764
		[CallerCount(0)]
		public unsafe virtual void Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x06004588 RID: 17800 RVA: 0x001405B4 File Offset: 0x0013E7B4
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229269, XrefRangeEnd = 229272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x06004589 RID: 17801 RVA: 0x00140600 File Offset: 0x0013E800
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x00140648 File Offset: 0x0013E848
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229275, RefRangeEnd = 229277, XrefRangeStart = 229272, XrefRangeEnd = 229275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Hashtable Synchronized(Hashtable table)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_Synchronized_Public_Static_Hashtable_Hashtable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x0014068C File Offset: 0x0013E88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229277, XrefRangeEnd = 229357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x001406F0 File Offset: 0x0013E8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229357, XrefRangeEnd = 229468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x0001A629 File Offset: 0x00018829
		public Hashtable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x0600458E RID: 17806 RVA: 0x00140740 File Offset: 0x0013E940
		// (set) Token: 0x0600458F RID: 17807 RVA: 0x0001A632 File Offset: 0x00018832
		public unsafe static int HashPrime
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_HashPrime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_HashPrime, (void*)(&value));
			}
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x06004590 RID: 17808 RVA: 0x0014075C File Offset: 0x0013E95C
		// (set) Token: 0x06004591 RID: 17809 RVA: 0x0001A640 File Offset: 0x00018840
		public unsafe static int InitialSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_InitialSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_InitialSize, (void*)(&value));
			}
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x06004592 RID: 17810 RVA: 0x00140778 File Offset: 0x0013E978
		// (set) Token: 0x06004593 RID: 17811 RVA: 0x0001A64E File Offset: 0x0001884E
		public unsafe static string LoadFactorName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_LoadFactorName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_LoadFactorName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06004594 RID: 17812 RVA: 0x00140798 File Offset: 0x0013E998
		// (set) Token: 0x06004595 RID: 17813 RVA: 0x0001A660 File Offset: 0x00018860
		public unsafe static string VersionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_VersionName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_VersionName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06004596 RID: 17814 RVA: 0x001407B8 File Offset: 0x0013E9B8
		// (set) Token: 0x06004597 RID: 17815 RVA: 0x0001A672 File Offset: 0x00018872
		public unsafe static string ComparerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_ComparerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_ComparerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06004598 RID: 17816 RVA: 0x001407D8 File Offset: 0x0013E9D8
		// (set) Token: 0x06004599 RID: 17817 RVA: 0x0001A684 File Offset: 0x00018884
		public unsafe static string HashCodeProviderName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_HashCodeProviderName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_HashCodeProviderName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x0600459A RID: 17818 RVA: 0x001407F8 File Offset: 0x0013E9F8
		// (set) Token: 0x0600459B RID: 17819 RVA: 0x0001A696 File Offset: 0x00018896
		public unsafe static string HashSizeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_HashSizeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_HashSizeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x0600459C RID: 17820 RVA: 0x00140818 File Offset: 0x0013EA18
		// (set) Token: 0x0600459D RID: 17821 RVA: 0x0001A6A8 File Offset: 0x000188A8
		public unsafe static string KeysName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_KeysName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_KeysName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x0600459E RID: 17822 RVA: 0x00140838 File Offset: 0x0013EA38
		// (set) Token: 0x0600459F RID: 17823 RVA: 0x0001A6BA File Offset: 0x000188BA
		public unsafe static string ValuesName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_ValuesName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_ValuesName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x060045A0 RID: 17824 RVA: 0x00140858 File Offset: 0x0013EA58
		// (set) Token: 0x060045A1 RID: 17825 RVA: 0x0001A6CC File Offset: 0x000188CC
		public unsafe static string KeyComparerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_KeyComparerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_KeyComparerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x060045A2 RID: 17826 RVA: 0x00140878 File Offset: 0x0013EA78
		// (set) Token: 0x060045A3 RID: 17827 RVA: 0x0001A6DE File Offset: 0x000188DE
		public unsafe Il2CppReferenceArray<Hashtable.bucket> buckets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_buckets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Hashtable.bucket>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x060045A4 RID: 17828 RVA: 0x001408A8 File Offset: 0x0013EAA8
		// (set) Token: 0x060045A5 RID: 17829 RVA: 0x0001A6FD File Offset: 0x000188FD
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x060045A6 RID: 17830 RVA: 0x001408D0 File Offset: 0x0013EAD0
		// (set) Token: 0x060045A7 RID: 17831 RVA: 0x0001A718 File Offset: 0x00018918
		public unsafe int occupancy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_occupancy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_occupancy)) = value;
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x060045A8 RID: 17832 RVA: 0x001408F8 File Offset: 0x0013EAF8
		// (set) Token: 0x060045A9 RID: 17833 RVA: 0x0001A733 File Offset: 0x00018933
		public unsafe int loadsize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_loadsize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_loadsize)) = value;
			}
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x060045AA RID: 17834 RVA: 0x00140920 File Offset: 0x0013EB20
		// (set) Token: 0x060045AB RID: 17835 RVA: 0x0001A74E File Offset: 0x0001894E
		public unsafe float loadFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_loadFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_loadFactor)) = value;
			}
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x060045AC RID: 17836 RVA: 0x00140948 File Offset: 0x0013EB48
		// (set) Token: 0x060045AD RID: 17837 RVA: 0x0001A769 File Offset: 0x00018969
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x060045AE RID: 17838 RVA: 0x00140970 File Offset: 0x0013EB70
		// (set) Token: 0x060045AF RID: 17839 RVA: 0x0001A784 File Offset: 0x00018984
		public unsafe bool isWriterInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_isWriterInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_isWriterInProgress)) = value;
			}
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x060045B0 RID: 17840 RVA: 0x00140998 File Offset: 0x0013EB98
		// (set) Token: 0x060045B1 RID: 17841 RVA: 0x0001A79F File Offset: 0x0001899F
		public unsafe ICollection keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x060045B2 RID: 17842 RVA: 0x001409C8 File Offset: 0x0013EBC8
		// (set) Token: 0x060045B3 RID: 17843 RVA: 0x0001A7BE File Offset: 0x000189BE
		public unsafe ICollection values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x060045B4 RID: 17844 RVA: 0x001409F8 File Offset: 0x0013EBF8
		// (set) Token: 0x060045B5 RID: 17845 RVA: 0x0001A7DD File Offset: 0x000189DD
		public unsafe IEqualityComparer _keycomparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__keycomparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__keycomparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x060045B6 RID: 17846 RVA: 0x00140A28 File Offset: 0x0013EC28
		// (set) Token: 0x060045B7 RID: 17847 RVA: 0x0001A7FC File Offset: 0x000189FC
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003878 RID: 14456
		private static readonly IntPtr NativeFieldInfoPtr_HashPrime;

		// Token: 0x04003879 RID: 14457
		private static readonly IntPtr NativeFieldInfoPtr_InitialSize;

		// Token: 0x0400387A RID: 14458
		private static readonly IntPtr NativeFieldInfoPtr_LoadFactorName;

		// Token: 0x0400387B RID: 14459
		private static readonly IntPtr NativeFieldInfoPtr_VersionName;

		// Token: 0x0400387C RID: 14460
		private static readonly IntPtr NativeFieldInfoPtr_ComparerName;

		// Token: 0x0400387D RID: 14461
		private static readonly IntPtr NativeFieldInfoPtr_HashCodeProviderName;

		// Token: 0x0400387E RID: 14462
		private static readonly IntPtr NativeFieldInfoPtr_HashSizeName;

		// Token: 0x0400387F RID: 14463
		private static readonly IntPtr NativeFieldInfoPtr_KeysName;

		// Token: 0x04003880 RID: 14464
		private static readonly IntPtr NativeFieldInfoPtr_ValuesName;

		// Token: 0x04003881 RID: 14465
		private static readonly IntPtr NativeFieldInfoPtr_KeyComparerName;

		// Token: 0x04003882 RID: 14466
		private static readonly IntPtr NativeFieldInfoPtr_buckets;

		// Token: 0x04003883 RID: 14467
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04003884 RID: 14468
		private static readonly IntPtr NativeFieldInfoPtr_occupancy;

		// Token: 0x04003885 RID: 14469
		private static readonly IntPtr NativeFieldInfoPtr_loadsize;

		// Token: 0x04003886 RID: 14470
		private static readonly IntPtr NativeFieldInfoPtr_loadFactor;

		// Token: 0x04003887 RID: 14471
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04003888 RID: 14472
		private static readonly IntPtr NativeFieldInfoPtr_isWriterInProgress;

		// Token: 0x04003889 RID: 14473
		private static readonly IntPtr NativeFieldInfoPtr_keys;

		// Token: 0x0400388A RID: 14474
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x0400388B RID: 14475
		private static readonly IntPtr NativeFieldInfoPtr__keycomparer;

		// Token: 0x0400388C RID: 14476
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x0400388D RID: 14477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x0400388E RID: 14478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400388F RID: 14479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003890 RID: 14480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0;

		// Token: 0x04003891 RID: 14481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IHashCodeProvider_IComparer_0;

		// Token: 0x04003892 RID: 14482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IEqualityComparer_0;

		// Token: 0x04003893 RID: 14483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IHashCodeProvider_IComparer_0;

		// Token: 0x04003894 RID: 14484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_0;

		// Token: 0x04003895 RID: 14485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_0;

		// Token: 0x04003896 RID: 14486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003897 RID: 14487
		private static readonly IntPtr NativeMethodInfoPtr_InitHash_Private_UInt32_Object_Int32_byref_UInt32_byref_UInt32_0;

		// Token: 0x04003898 RID: 14488
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_Object_0;

		// Token: 0x04003899 RID: 14489
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x0400389A RID: 14490
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x0400389B RID: 14491
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x0400389C RID: 14492
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x0400389D RID: 14493
		private static readonly IntPtr NativeMethodInfoPtr_CopyKeys_Private_Void_Array_Int32_0;

		// Token: 0x0400389E RID: 14494
		private static readonly IntPtr NativeMethodInfoPtr_CopyEntries_Private_Void_Array_Int32_0;

		// Token: 0x0400389F RID: 14495
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

		// Token: 0x040038A0 RID: 14496
		private static readonly IntPtr NativeMethodInfoPtr_CopyValues_Private_Void_Array_Int32_0;

		// Token: 0x040038A1 RID: 14497
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Object_0;

		// Token: 0x040038A2 RID: 14498
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_Object_0;

		// Token: 0x040038A3 RID: 14499
		private static readonly IntPtr NativeMethodInfoPtr_expand_Private_Void_0;

		// Token: 0x040038A4 RID: 14500
		private static readonly IntPtr NativeMethodInfoPtr_rehash_Private_Void_0;

		// Token: 0x040038A5 RID: 14501
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVersion_Private_Void_0;

		// Token: 0x040038A6 RID: 14502
		private static readonly IntPtr NativeMethodInfoPtr_rehash_Private_Void_Int32_Boolean_0;

		// Token: 0x040038A7 RID: 14503
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040038A8 RID: 14504
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0;

		// Token: 0x040038A9 RID: 14505
		private static readonly IntPtr NativeMethodInfoPtr_GetHash_Protected_Virtual_New_Int32_Object_0;

		// Token: 0x040038AA RID: 14506
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040038AB RID: 14507
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040038AC RID: 14508
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040038AD RID: 14509
		private static readonly IntPtr NativeMethodInfoPtr_KeyEquals_Protected_Virtual_New_Boolean_Object_Object_0;

		// Token: 0x040038AE RID: 14510
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_ICollection_0;

		// Token: 0x040038AF RID: 14511
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ICollection_0;

		// Token: 0x040038B0 RID: 14512
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Private_Void_Object_Object_Boolean_0;

		// Token: 0x040038B1 RID: 14513
		private static readonly IntPtr NativeMethodInfoPtr_putEntry_Private_Void_Il2CppReferenceArray_1_bucket_Object_Object_Int32_0;

		// Token: 0x040038B2 RID: 14514
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0;

		// Token: 0x040038B3 RID: 14515
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

		// Token: 0x040038B4 RID: 14516
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x040038B5 RID: 14517
		private static readonly IntPtr NativeMethodInfoPtr_Synchronized_Public_Static_Hashtable_Hashtable_0;

		// Token: 0x040038B6 RID: 14518
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040038B7 RID: 14519
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0;

		// Token: 0x02000653 RID: 1619
		public sealed class bucket : ValueType
		{
			// Token: 0x060056CB RID: 22219 RVA: 0x00183100 File Offset: 0x00181300
			// Note: this type is marked as 'beforefieldinit'.
			static bucket()
			{
				Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "bucket");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr);
				Hashtable.bucket.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr, "key");
				Hashtable.bucket.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr, "val");
				Hashtable.bucket.NativeFieldInfoPtr_hash_coll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr, "hash_coll");
			}

			// Token: 0x060056CC RID: 22220 RVA: 0x00021112 File Offset: 0x0001F312
			public bucket(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060056CD RID: 22221 RVA: 0x0002111B File Offset: 0x0001F31B
			public bucket()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr))
			{
			}

			// Token: 0x17001652 RID: 5714
			// (get) Token: 0x060056CE RID: 22222 RVA: 0x00183168 File Offset: 0x00181368
			// (set) Token: 0x060056CF RID: 22223 RVA: 0x0002112D File Offset: 0x0001F32D
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001653 RID: 5715
			// (get) Token: 0x060056D0 RID: 22224 RVA: 0x00183198 File Offset: 0x00181398
			// (set) Token: 0x060056D1 RID: 22225 RVA: 0x0002114C File Offset: 0x0001F34C
			public unsafe Object val
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_val);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_val), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001654 RID: 5716
			// (get) Token: 0x060056D2 RID: 22226 RVA: 0x001831C8 File Offset: 0x001813C8
			// (set) Token: 0x060056D3 RID: 22227 RVA: 0x0002116B File Offset: 0x0001F36B
			public unsafe int hash_coll
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_hash_coll);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_hash_coll)) = value;
				}
			}

			// Token: 0x040045C7 RID: 17863
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040045C8 RID: 17864
			private static readonly IntPtr NativeFieldInfoPtr_val;

			// Token: 0x040045C9 RID: 17865
			private static readonly IntPtr NativeFieldInfoPtr_hash_coll;
		}

		// Token: 0x02000654 RID: 1620
		[Serializable]
		public class KeyCollection : Object
		{
			// Token: 0x060056D4 RID: 22228 RVA: 0x001831F0 File Offset: 0x001813F0
			// Note: this type is marked as 'beforefieldinit'.
			static KeyCollection()
			{
				Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "KeyCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr);
				Hashtable.KeyCollection.NativeFieldInfoPtr__hashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, "_hashtable");
				Hashtable.KeyCollection.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, 100673480);
				Hashtable.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, 100673481);
				Hashtable.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, 100673482);
				Hashtable.KeyCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, 100673483);
				Hashtable.KeyCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, 100673484);
				Hashtable.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, 100673485);
			}

			// Token: 0x060056D5 RID: 22229 RVA: 0x001832A8 File Offset: 0x001814A8
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyCollection(Hashtable hashtable)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashtable);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.KeyCollection.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060056D6 RID: 22230 RVA: 0x001832F4 File Offset: 0x001814F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228934, XrefRangeEnd = 228936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056D7 RID: 22231 RVA: 0x00183350 File Offset: 0x00181550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228936, XrefRangeEnd = 228939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x17001656 RID: 5718
			// (get) Token: 0x060056D8 RID: 22232 RVA: 0x0018339C File Offset: 0x0018159C
			public unsafe virtual bool IsSynchronized
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228939, XrefRangeEnd = 228940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.KeyCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001657 RID: 5719
			// (get) Token: 0x060056D9 RID: 22233 RVA: 0x001833E4 File Offset: 0x001815E4
			public unsafe virtual Object SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228940, XrefRangeEnd = 228941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.KeyCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001658 RID: 5720
			// (get) Token: 0x060056DA RID: 22234 RVA: 0x00183430 File Offset: 0x00181630
			public unsafe virtual int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060056DB RID: 22235 RVA: 0x00021186 File Offset: 0x0001F386
			public KeyCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001655 RID: 5717
			// (get) Token: 0x060056DC RID: 22236 RVA: 0x00183478 File Offset: 0x00181678
			// (set) Token: 0x060056DD RID: 22237 RVA: 0x0002118F File Offset: 0x0001F38F
			public unsafe Hashtable _hashtable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.KeyCollection.NativeFieldInfoPtr__hashtable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.KeyCollection.NativeFieldInfoPtr__hashtable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045CA RID: 17866
			private static readonly IntPtr NativeFieldInfoPtr__hashtable;

			// Token: 0x040045CB RID: 17867
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0;

			// Token: 0x040045CC RID: 17868
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

			// Token: 0x040045CD RID: 17869
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

			// Token: 0x040045CE RID: 17870
			private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0;

			// Token: 0x040045CF RID: 17871
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

			// Token: 0x040045D0 RID: 17872
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;
		}

		// Token: 0x02000655 RID: 1621
		[Serializable]
		public class ValueCollection : Object
		{
			// Token: 0x060056DE RID: 22238 RVA: 0x001834A8 File Offset: 0x001816A8
			// Note: this type is marked as 'beforefieldinit'.
			static ValueCollection()
			{
				Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "ValueCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr);
				Hashtable.ValueCollection.NativeFieldInfoPtr__hashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, "_hashtable");
				Hashtable.ValueCollection.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, 100673486);
				Hashtable.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, 100673487);
				Hashtable.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, 100673488);
				Hashtable.ValueCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, 100673489);
				Hashtable.ValueCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, 100673490);
				Hashtable.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, 100673491);
			}

			// Token: 0x060056DF RID: 22239 RVA: 0x00183560 File Offset: 0x00181760
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueCollection(Hashtable hashtable)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashtable);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.ValueCollection.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060056E0 RID: 22240 RVA: 0x001835AC File Offset: 0x001817AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228941, XrefRangeEnd = 228943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056E1 RID: 22241 RVA: 0x00183608 File Offset: 0x00181808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228943, XrefRangeEnd = 228946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x1700165A RID: 5722
			// (get) Token: 0x060056E2 RID: 22242 RVA: 0x00183654 File Offset: 0x00181854
			public unsafe virtual bool IsSynchronized
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.ValueCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700165B RID: 5723
			// (get) Token: 0x060056E3 RID: 22243 RVA: 0x0018369C File Offset: 0x0018189C
			public unsafe virtual Object SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.ValueCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x1700165C RID: 5724
			// (get) Token: 0x060056E4 RID: 22244 RVA: 0x001836E8 File Offset: 0x001818E8
			public unsafe virtual int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060056E5 RID: 22245 RVA: 0x000211AE File Offset: 0x0001F3AE
			public ValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001659 RID: 5721
			// (get) Token: 0x060056E6 RID: 22246 RVA: 0x00183730 File Offset: 0x00181930
			// (set) Token: 0x060056E7 RID: 22247 RVA: 0x000211B7 File Offset: 0x0001F3B7
			public unsafe Hashtable _hashtable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.ValueCollection.NativeFieldInfoPtr__hashtable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.ValueCollection.NativeFieldInfoPtr__hashtable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045D1 RID: 17873
			private static readonly IntPtr NativeFieldInfoPtr__hashtable;

			// Token: 0x040045D2 RID: 17874
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0;

			// Token: 0x040045D3 RID: 17875
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

			// Token: 0x040045D4 RID: 17876
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

			// Token: 0x040045D5 RID: 17877
			private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0;

			// Token: 0x040045D6 RID: 17878
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

			// Token: 0x040045D7 RID: 17879
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;
		}

		// Token: 0x02000656 RID: 1622
		[Serializable]
		public class SyncHashtable : Hashtable
		{
			// Token: 0x060056E8 RID: 22248 RVA: 0x00183760 File Offset: 0x00181960
			// Note: this type is marked as 'beforefieldinit'.
			static SyncHashtable()
			{
				Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "SyncHashtable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr);
				Hashtable.SyncHashtable.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, "_table");
				Hashtable.SyncHashtable.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673492);
				Hashtable.SyncHashtable.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673493);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673494);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673495);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673496);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673497);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673498);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673499);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673500);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673501);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_Add_Public_Virtual_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673502);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673503);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673504);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673505);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673506);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673507);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673508);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673509);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Keys_Public_Virtual_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673510);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Values_Public_Virtual_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673511);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673512);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100673513);
			}

			// Token: 0x060056E9 RID: 22249 RVA: 0x00183958 File Offset: 0x00181B58
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 13543, RefRangeEnd = 13569, XrefRangeStart = 13543, XrefRangeEnd = 13569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SyncHashtable(Hashtable table)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.SyncHashtable.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060056EA RID: 22250 RVA: 0x001839A4 File Offset: 0x00181BA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228946, XrefRangeEnd = 228964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SyncHashtable(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.SyncHashtable.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056EB RID: 22251 RVA: 0x00183A08 File Offset: 0x00181C08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228964, XrefRangeEnd = 228976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700165E RID: 5726
			// (get) Token: 0x060056EC RID: 22252 RVA: 0x00183A6C File Offset: 0x00181C6C
			public unsafe override int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228976, XrefRangeEnd = 228977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700165F RID: 5727
			// (get) Token: 0x060056ED RID: 22253 RVA: 0x00183AB4 File Offset: 0x00181CB4
			public unsafe override bool IsReadOnly
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228977, XrefRangeEnd = 228978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001660 RID: 5728
			// (get) Token: 0x060056EE RID: 22254 RVA: 0x00183AFC File Offset: 0x00181CFC
			public unsafe override bool IsFixedSize
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228978, XrefRangeEnd = 228979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001661 RID: 5729
			// (get) Token: 0x060056EF RID: 22255 RVA: 0x00183B44 File Offset: 0x00181D44
			public unsafe override bool IsSynchronized
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001662 RID: 5730
			public unsafe override Object this[Object key]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228979, XrefRangeEnd = 228980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228980, XrefRangeEnd = 228983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001663 RID: 5731
			// (get) Token: 0x060056F2 RID: 22258 RVA: 0x00183C48 File Offset: 0x00181E48
			public unsafe override Object SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228983, XrefRangeEnd = 228984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060056F3 RID: 22259 RVA: 0x00183C94 File Offset: 0x00181E94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228984, XrefRangeEnd = 228987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Add(Object key, Object value)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_Add_Public_Virtual_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056F4 RID: 22260 RVA: 0x00183CF4 File Offset: 0x00181EF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228987, XrefRangeEnd = 228990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056F5 RID: 22261 RVA: 0x00183D30 File Offset: 0x00181F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228990, XrefRangeEnd = 228991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Contains(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060056F6 RID: 22262 RVA: 0x00183D88 File Offset: 0x00181F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228991, XrefRangeEnd = 229000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ContainsKey(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060056F7 RID: 22263 RVA: 0x00183DE0 File Offset: 0x00181FE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229000, XrefRangeEnd = 229003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void CopyTo(Array array, int arrayIndex)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056F8 RID: 22264 RVA: 0x00183E3C File Offset: 0x0018203C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229003, XrefRangeEnd = 229012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060056F9 RID: 22265 RVA: 0x00183E88 File Offset: 0x00182088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229012, XrefRangeEnd = 229013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.SyncHashtable.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060056FA RID: 22266 RVA: 0x00183EC8 File Offset: 0x001820C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IDictionaryEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
			}

			// Token: 0x17001664 RID: 5732
			// (get) Token: 0x060056FB RID: 22267 RVA: 0x00183F14 File Offset: 0x00182114
			public unsafe override ICollection Keys
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229013, XrefRangeEnd = 229016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Keys_Public_Virtual_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
				}
			}

			// Token: 0x17001665 RID: 5733
			// (get) Token: 0x060056FC RID: 22268 RVA: 0x00183F60 File Offset: 0x00182160
			public unsafe override ICollection Values
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229016, XrefRangeEnd = 229019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Values_Public_Virtual_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
				}
			}

			// Token: 0x060056FD RID: 22269 RVA: 0x00183FAC File Offset: 0x001821AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229019, XrefRangeEnd = 229022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Remove(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060056FE RID: 22270 RVA: 0x00183FFC File Offset: 0x001821FC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnDeserialization(Object sender)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060056FF RID: 22271 RVA: 0x000211D6 File Offset: 0x0001F3D6
			public SyncHashtable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700165D RID: 5725
			// (get) Token: 0x06005700 RID: 22272 RVA: 0x0018404C File Offset: 0x0018224C
			// (set) Token: 0x06005701 RID: 22273 RVA: 0x000211DF File Offset: 0x0001F3DF
			public unsafe Hashtable _table
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.SyncHashtable.NativeFieldInfoPtr__table);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.SyncHashtable.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045D8 RID: 17880
			private static readonly IntPtr NativeFieldInfoPtr__table;

			// Token: 0x040045D9 RID: 17881
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0;

			// Token: 0x040045DA RID: 17882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x040045DB RID: 17883
			private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x040045DC RID: 17884
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

			// Token: 0x040045DD RID: 17885
			private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

			// Token: 0x040045DE RID: 17886
			private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_get_Boolean_0;

			// Token: 0x040045DF RID: 17887
			private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0;

			// Token: 0x040045E0 RID: 17888
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Object_0;

			// Token: 0x040045E1 RID: 17889
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_Object_0;

			// Token: 0x040045E2 RID: 17890
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0;

			// Token: 0x040045E3 RID: 17891
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_Object_Object_0;

			// Token: 0x040045E4 RID: 17892
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;

			// Token: 0x040045E5 RID: 17893
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0;

			// Token: 0x040045E6 RID: 17894
			private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Boolean_Object_0;

			// Token: 0x040045E7 RID: 17895
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0;

			// Token: 0x040045E8 RID: 17896
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

			// Token: 0x040045E9 RID: 17897
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x040045EA RID: 17898
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0;

			// Token: 0x040045EB RID: 17899
			private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_get_ICollection_0;

			// Token: 0x040045EC RID: 17900
			private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_get_ICollection_0;

			// Token: 0x040045ED RID: 17901
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0;

			// Token: 0x040045EE RID: 17902
			private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0;
		}

		// Token: 0x02000657 RID: 1623
		[Serializable]
		public class HashtableEnumerator : Object
		{
			// Token: 0x06005702 RID: 22274 RVA: 0x0018407C File Offset: 0x0018227C
			// Note: this type is marked as 'beforefieldinit'.
			static HashtableEnumerator()
			{
				Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "HashtableEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr);
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr_hashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "hashtable");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr_bucket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "bucket");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "version");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "current");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr_getObjectRetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "getObjectRetType");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr_currentKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "currentKey");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr_currentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "currentValue");
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100673514);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100673515);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100673516);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100673517);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100673518);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100673519);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100673520);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100673521);
			}

			// Token: 0x06005703 RID: 22275 RVA: 0x001841D4 File Offset: 0x001823D4
			[CallerCount(0)]
			public unsafe HashtableEnumerator(Hashtable hashtable, int getObjRetType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashtable);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getObjRetType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.HashtableEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005704 RID: 22276 RVA: 0x00184230 File Offset: 0x00182430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.HashtableEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x1700166D RID: 5741
			// (get) Token: 0x06005705 RID: 22277 RVA: 0x00184270 File Offset: 0x00182470
			public unsafe virtual Object Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005706 RID: 22278 RVA: 0x001842BC File Offset: 0x001824BC
			[CallerCount(0)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700166E RID: 5742
			// (get) Token: 0x06005707 RID: 22279 RVA: 0x00184304 File Offset: 0x00182504
			public unsafe virtual DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229022, XrefRangeEnd = 229023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_New_get_DictionaryEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x1700166F RID: 5743
			// (get) Token: 0x06005708 RID: 22280 RVA: 0x00184348 File Offset: 0x00182548
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229023, XrefRangeEnd = 229027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001670 RID: 5744
			// (get) Token: 0x06005709 RID: 22281 RVA: 0x00184394 File Offset: 0x00182594
			public unsafe virtual Object Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600570A RID: 22282 RVA: 0x001843E0 File Offset: 0x001825E0
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600570B RID: 22283 RVA: 0x000211FE File Offset: 0x0001F3FE
			public HashtableEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001666 RID: 5734
			// (get) Token: 0x0600570C RID: 22284 RVA: 0x0018441C File Offset: 0x0018261C
			// (set) Token: 0x0600570D RID: 22285 RVA: 0x00021207 File Offset: 0x0001F407
			public unsafe Hashtable hashtable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_hashtable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_hashtable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001667 RID: 5735
			// (get) Token: 0x0600570E RID: 22286 RVA: 0x0018444C File Offset: 0x0018264C
			// (set) Token: 0x0600570F RID: 22287 RVA: 0x00021226 File Offset: 0x0001F426
			public unsafe int bucket
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_bucket);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_bucket)) = value;
				}
			}

			// Token: 0x17001668 RID: 5736
			// (get) Token: 0x06005710 RID: 22288 RVA: 0x00184474 File Offset: 0x00182674
			// (set) Token: 0x06005711 RID: 22289 RVA: 0x00021241 File Offset: 0x0001F441
			public unsafe int version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x17001669 RID: 5737
			// (get) Token: 0x06005712 RID: 22290 RVA: 0x0018449C File Offset: 0x0018269C
			// (set) Token: 0x06005713 RID: 22291 RVA: 0x0002125C File Offset: 0x0001F45C
			public unsafe bool current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_current)) = value;
				}
			}

			// Token: 0x1700166A RID: 5738
			// (get) Token: 0x06005714 RID: 22292 RVA: 0x001844C4 File Offset: 0x001826C4
			// (set) Token: 0x06005715 RID: 22293 RVA: 0x00021277 File Offset: 0x0001F477
			public unsafe int getObjectRetType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_getObjectRetType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_getObjectRetType)) = value;
				}
			}

			// Token: 0x1700166B RID: 5739
			// (get) Token: 0x06005716 RID: 22294 RVA: 0x001844EC File Offset: 0x001826EC
			// (set) Token: 0x06005717 RID: 22295 RVA: 0x00021292 File Offset: 0x0001F492
			public unsafe Object currentKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_currentKey);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_currentKey), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700166C RID: 5740
			// (get) Token: 0x06005718 RID: 22296 RVA: 0x0018451C File Offset: 0x0018271C
			// (set) Token: 0x06005719 RID: 22297 RVA: 0x000212B1 File Offset: 0x0001F4B1
			public unsafe Object currentValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_currentValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr_currentValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045EF RID: 17903
			private static readonly IntPtr NativeFieldInfoPtr_hashtable;

			// Token: 0x040045F0 RID: 17904
			private static readonly IntPtr NativeFieldInfoPtr_bucket;

			// Token: 0x040045F1 RID: 17905
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x040045F2 RID: 17906
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x040045F3 RID: 17907
			private static readonly IntPtr NativeFieldInfoPtr_getObjectRetType;

			// Token: 0x040045F4 RID: 17908
			private static readonly IntPtr NativeFieldInfoPtr_currentKey;

			// Token: 0x040045F5 RID: 17909
			private static readonly IntPtr NativeFieldInfoPtr_currentValue;

			// Token: 0x040045F6 RID: 17910
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_Int32_0;

			// Token: 0x040045F7 RID: 17911
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

			// Token: 0x040045F8 RID: 17912
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Object_0;

			// Token: 0x040045F9 RID: 17913
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0;

			// Token: 0x040045FA RID: 17914
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_New_get_DictionaryEntry_0;

			// Token: 0x040045FB RID: 17915
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0;

			// Token: 0x040045FC RID: 17916
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0;

			// Token: 0x040045FD RID: 17917
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;
		}

		// Token: 0x02000658 RID: 1624
		public class HashtableDebugView : Object
		{
			// Token: 0x0600571A RID: 22298 RVA: 0x000212D0 File Offset: 0x0001F4D0
			// Note: this type is marked as 'beforefieldinit'.
			static HashtableDebugView()
			{
				Il2CppClassPointerStore<Hashtable.HashtableDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "HashtableDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.HashtableDebugView>.NativeClassPtr);
			}

			// Token: 0x0600571B RID: 22299 RVA: 0x000212F0 File Offset: 0x0001F4F0
			public HashtableDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
