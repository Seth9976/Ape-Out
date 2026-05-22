using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Specialized
{
	// Token: 0x020000CF RID: 207
	[Serializable]
	public class NameObjectCollectionBase : Object
	{
		// Token: 0x06000B77 RID: 2935 RVA: 0x0003B764 File Offset: 0x00039964
		// Note: this type is marked as 'beforefieldinit'.
		static NameObjectCollectionBase()
		{
			Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Specialized", "NameObjectCollectionBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr);
			NameObjectCollectionBase.NativeFieldInfoPtr__readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_readOnly");
			NameObjectCollectionBase.NativeFieldInfoPtr__entriesArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_entriesArray");
			NameObjectCollectionBase.NativeFieldInfoPtr__keyComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_keyComparer");
			NameObjectCollectionBase.NativeFieldInfoPtr__entriesTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_entriesTable");
			NameObjectCollectionBase.NativeFieldInfoPtr__nullKeyEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_nullKeyEntry");
			NameObjectCollectionBase.NativeFieldInfoPtr__serializationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_serializationInfo");
			NameObjectCollectionBase.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_version");
			NameObjectCollectionBase.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_syncRoot");
			NameObjectCollectionBase.NativeFieldInfoPtr_defaultComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "defaultComparer");
			NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664938);
			NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664939);
			NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664940);
			NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Internal_Void_DBNull_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664941);
			NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664942);
			NameObjectCollectionBase.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664943);
			NameObjectCollectionBase.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664944);
			NameObjectCollectionBase.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664945);
			NameObjectCollectionBase.NativeMethodInfoPtr_Reset_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664946);
			NameObjectCollectionBase.NativeMethodInfoPtr_FindEntry_Private_NameObjectEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664947);
			NameObjectCollectionBase.NativeMethodInfoPtr_get_IsReadOnly_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664948);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseAdd_Protected_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664949);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseRemove_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664950);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseGet_Protected_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664951);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseSet_Protected_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664952);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseGet_Protected_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664953);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseGetKey_Protected_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664954);
			NameObjectCollectionBase.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664955);
			NameObjectCollectionBase.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664956);
			NameObjectCollectionBase.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664957);
			NameObjectCollectionBase.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664958);
			NameObjectCollectionBase.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100664959);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0003BA00 File Offset: 0x00039C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375485, XrefRangeEnd = 375490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0003BA3C File Offset: 0x00039C3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 375502, RefRangeEnd = 375506, XrefRangeStart = 375490, XrefRangeEnd = 375502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase(IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0003BA88 File Offset: 0x00039C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375506, XrefRangeEnd = 375508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase(int capacity, IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_Int32_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0003BAE4 File Offset: 0x00039CE4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase(DBNull dummy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dummy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Internal_Void_DBNull_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0003BB30 File Offset: 0x00039D30
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0003BB94 File Offset: 0x00039D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375508, XrefRangeEnd = 375733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameObjectCollectionBase.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0003BBF8 File Offset: 0x00039DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375733, XrefRangeEnd = 375832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameObjectCollectionBase.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0003BC48 File Offset: 0x00039E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375832, XrefRangeEnd = 375840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0003BC7C File Offset: 0x00039E7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 375848, RefRangeEnd = 375851, XrefRangeStart = 375840, XrefRangeEnd = 375848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_Reset_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0003BCBC File Offset: 0x00039EBC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 375852, RefRangeEnd = 375858, XrefRangeStart = 375851, XrefRangeEnd = 375852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase.NameObjectEntry FindEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_FindEntry_Private_NameObjectEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameObjectCollectionBase.NameObjectEntry>(intPtr3) : null;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0003BD0C File Offset: 0x00039F0C
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_get_IsReadOnly_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0003BD48 File Offset: 0x00039F48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 375863, RefRangeEnd = 375866, XrefRangeStart = 375858, XrefRangeEnd = 375863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseAdd(string name, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseAdd_Protected_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0003BD9C File Offset: 0x00039F9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375873, RefRangeEnd = 375874, XrefRangeStart = 375866, XrefRangeEnd = 375873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseRemove(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseRemove_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0003BDE0 File Offset: 0x00039FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375874, XrefRangeEnd = 375875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object BaseGet(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseGet_Protected_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0003BE30 File Offset: 0x0003A030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375875, XrefRangeEnd = 375878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseSet(string name, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseSet_Protected_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0003BE84 File Offset: 0x0003A084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375878, XrefRangeEnd = 375880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object BaseGet(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseGet_Protected_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0003BED0 File Offset: 0x0003A0D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 375882, RefRangeEnd = 375886, XrefRangeStart = 375880, XrefRangeEnd = 375882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string BaseGetKey(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseGetKey_Protected_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0003BF14 File Offset: 0x0003A114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375886, XrefRangeEnd = 375890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameObjectCollectionBase.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0003BF60 File Offset: 0x0003A160
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375890, XrefRangeEnd = 375891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameObjectCollectionBase.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0003BFA8 File Offset: 0x0003A1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375891, XrefRangeEnd = 375900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0003BFF8 File Offset: 0x0003A1F8
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375900, XrefRangeEnd = 375903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x0003C038 File Offset: 0x0003A238
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00006932 File Offset: 0x00004B32
		public NameObjectCollectionBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0003C074 File Offset: 0x0003A274
		// (set) Token: 0x06000B90 RID: 2960 RVA: 0x0000693B File Offset: 0x00004B3B
		public unsafe bool _readOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__readOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__readOnly)) = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x0003C09C File Offset: 0x0003A29C
		// (set) Token: 0x06000B92 RID: 2962 RVA: 0x00006956 File Offset: 0x00004B56
		public unsafe ArrayList _entriesArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__entriesArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__entriesArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0003C0CC File Offset: 0x0003A2CC
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x00006975 File Offset: 0x00004B75
		public unsafe IEqualityComparer _keyComparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__keyComparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__keyComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0003C0FC File Offset: 0x0003A2FC
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x00006994 File Offset: 0x00004B94
		public unsafe Hashtable _entriesTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__entriesTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__entriesTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0003C12C File Offset: 0x0003A32C
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x000069B3 File Offset: 0x00004BB3
		public unsafe NameObjectCollectionBase.NameObjectEntry _nullKeyEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__nullKeyEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameObjectCollectionBase.NameObjectEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__nullKeyEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0003C15C File Offset: 0x0003A35C
		// (set) Token: 0x06000B9A RID: 2970 RVA: 0x000069D2 File Offset: 0x00004BD2
		public unsafe SerializationInfo _serializationInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__serializationInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__serializationInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x0003C18C File Offset: 0x0003A38C
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x000069F1 File Offset: 0x00004BF1
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x0003C1B4 File Offset: 0x0003A3B4
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x00006A0C File Offset: 0x00004C0C
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x0003C1E4 File Offset: 0x0003A3E4
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x00006A2B File Offset: 0x00004C2B
		public unsafe static StringComparer defaultComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NameObjectCollectionBase.NativeFieldInfoPtr_defaultComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NameObjectCollectionBase.NativeFieldInfoPtr_defaultComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeFieldInfoPtr__readOnly;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeFieldInfoPtr__entriesArray;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeFieldInfoPtr__keyComparer;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeFieldInfoPtr__entriesTable;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeFieldInfoPtr__nullKeyEntry;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeFieldInfoPtr__serializationInfo;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeFieldInfoPtr_defaultComparer;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IEqualityComparer_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_IEqualityComparer_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DBNull_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_Int32_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_FindEntry_Private_NameObjectEntry_String_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Protected_get_Boolean_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_BaseAdd_Protected_Void_String_Object_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_BaseRemove_Protected_Void_String_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_BaseGet_Protected_Object_String_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_BaseSet_Protected_Void_String_Object_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_BaseGet_Protected_Object_Int32_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_BaseGetKey_Protected_String_Int32_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x020001C6 RID: 454
		public class NameObjectEntry : Object
		{
			// Token: 0x06001970 RID: 6512 RVA: 0x0006D4E4 File Offset: 0x0006B6E4
			// Note: this type is marked as 'beforefieldinit'.
			static NameObjectEntry()
			{
				Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "NameObjectEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr);
				NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr, "Key");
				NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr, "Value");
				NameObjectCollectionBase.NameObjectEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr, 100664961);
			}

			// Token: 0x06001971 RID: 6513 RVA: 0x0006D54C File Offset: 0x0006B74C
			[CallerCount(76)]
			[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NameObjectEntry(string name, Object value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NameObjectEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001972 RID: 6514 RVA: 0x0000D196 File Offset: 0x0000B396
			public NameObjectEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700081C RID: 2076
			// (get) Token: 0x06001973 RID: 6515 RVA: 0x0006D5AC File Offset: 0x0006B7AC
			// (set) Token: 0x06001974 RID: 6516 RVA: 0x0000D19F File Offset: 0x0000B39F
			public unsafe string Key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700081D RID: 2077
			// (get) Token: 0x06001975 RID: 6517 RVA: 0x0006D5D4 File Offset: 0x0006B7D4
			// (set) Token: 0x06001976 RID: 6518 RVA: 0x0000D1BE File Offset: 0x0000B3BE
			public unsafe Object Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400141B RID: 5147
			private static readonly IntPtr NativeFieldInfoPtr_Key;

			// Token: 0x0400141C RID: 5148
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x0400141D RID: 5149
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Object_0;
		}

		// Token: 0x020001C7 RID: 455
		[Serializable]
		public class NameObjectKeysEnumerator : Object
		{
			// Token: 0x06001977 RID: 6519 RVA: 0x0006D604 File Offset: 0x0006B804
			// Note: this type is marked as 'beforefieldinit'.
			static NameObjectKeysEnumerator()
			{
				Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "NameObjectKeysEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr);
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, "_pos");
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__coll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, "_coll");
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, "_version");
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_NameObjectCollectionBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, 100664962);
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, 100664963);
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, 100664964);
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, 100664965);
			}

			// Token: 0x06001978 RID: 6520 RVA: 0x0006D6BC File Offset: 0x0006B8BC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 375470, RefRangeEnd = 375472, XrefRangeStart = 375470, XrefRangeEnd = 375470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NameObjectKeysEnumerator(NameObjectCollectionBase coll)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_NameObjectCollectionBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001979 RID: 6521 RVA: 0x0006D708 File Offset: 0x0006B908
			[CallerCount(0)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600197A RID: 6522 RVA: 0x0006D744 File Offset: 0x0006B944
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000821 RID: 2081
			// (get) Token: 0x0600197B RID: 6523 RVA: 0x0006D778 File Offset: 0x0006B978
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375472, XrefRangeEnd = 375485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600197C RID: 6524 RVA: 0x0000D1DD File Offset: 0x0000B3DD
			public NameObjectKeysEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700081E RID: 2078
			// (get) Token: 0x0600197D RID: 6525 RVA: 0x0006D7B8 File Offset: 0x0006B9B8
			// (set) Token: 0x0600197E RID: 6526 RVA: 0x0000D1E6 File Offset: 0x0000B3E6
			public unsafe int _pos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__pos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__pos)) = value;
				}
			}

			// Token: 0x1700081F RID: 2079
			// (get) Token: 0x0600197F RID: 6527 RVA: 0x0006D7E0 File Offset: 0x0006B9E0
			// (set) Token: 0x06001980 RID: 6528 RVA: 0x0000D201 File Offset: 0x0000B401
			public unsafe NameObjectCollectionBase _coll
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__coll);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameObjectCollectionBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__coll), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000820 RID: 2080
			// (get) Token: 0x06001981 RID: 6529 RVA: 0x0006D810 File Offset: 0x0006BA10
			// (set) Token: 0x06001982 RID: 6530 RVA: 0x0000D220 File Offset: 0x0000B420
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x0400141E RID: 5150
			private static readonly IntPtr NativeFieldInfoPtr__pos;

			// Token: 0x0400141F RID: 5151
			private static readonly IntPtr NativeFieldInfoPtr__coll;

			// Token: 0x04001420 RID: 5152
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04001421 RID: 5153
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_NameObjectCollectionBase_0;

			// Token: 0x04001422 RID: 5154
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04001423 RID: 5155
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x04001424 RID: 5156
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;
		}
	}
}
