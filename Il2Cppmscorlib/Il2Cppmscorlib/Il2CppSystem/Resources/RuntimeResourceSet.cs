using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;

namespace Il2CppSystem.Resources
{
	// Token: 0x0200018A RID: 394
	public sealed class RuntimeResourceSet : ResourceSet
	{
		// Token: 0x06001B8A RID: 7050 RVA: 0x000A0F08 File Offset: 0x0009F108
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeResourceSet()
		{
			Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "RuntimeResourceSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr);
			RuntimeResourceSet.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, "Version");
			RuntimeResourceSet.NativeFieldInfoPtr__resCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, "_resCache");
			RuntimeResourceSet.NativeFieldInfoPtr__defaultReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, "_defaultReader");
			RuntimeResourceSet.NativeFieldInfoPtr__caseInsensitiveTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, "_caseInsensitiveTable");
			RuntimeResourceSet.NativeFieldInfoPtr__haveReadFromReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, "_haveReadFromReader");
			RuntimeResourceSet.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100667998);
			RuntimeResourceSet.NativeMethodInfoPtr__ctor_Internal_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100667999);
			RuntimeResourceSet.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100668000);
			RuntimeResourceSet.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100668001);
			RuntimeResourceSet.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100668002);
			RuntimeResourceSet.NativeMethodInfoPtr_GetEnumeratorHelper_Private_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100668003);
			RuntimeResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100668004);
			RuntimeResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100668005);
			RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100668006);
			RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100668007);
			RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Private_Object_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100668008);
			RuntimeResourceSet.NativeMethodInfoPtr_ResolveResourceLocator_Private_Object_ResourceLocator_String_Dictionary_2_String_ResourceLocator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr, 100668009);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x000A108C File Offset: 0x0009F28C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185952, RefRangeEnd = 185953, XrefRangeStart = 185935, XrefRangeEnd = 185952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeResourceSet(string fileName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x000A10D8 File Offset: 0x0009F2D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185966, RefRangeEnd = 185967, XrefRangeStart = 185953, XrefRangeEnd = 185966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeResourceSet(Stream stream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeResourceSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr__ctor_Internal_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x000A1124 File Offset: 0x0009F324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185967, XrefRangeEnd = 185976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x000A1164 File Offset: 0x0009F364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185976, XrefRangeEnd = 185977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x000A11A4 File Offset: 0x0009F3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x000A11E4 File Offset: 0x0009F3E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185987, RefRangeEnd = 185989, XrefRangeStart = 185977, XrefRangeEnd = 185987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IDictionaryEnumerator GetEnumeratorHelper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetEnumeratorHelper_Private_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x000A1224 File Offset: 0x0009F424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185989, XrefRangeEnd = 185992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetString(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x000A126C File Offset: 0x0009F46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185992, XrefRangeEnd = 185995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetString(string key, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetString_Public_Virtual_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x000A12C4 File Offset: 0x0009F4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185995, XrefRangeEnd = 185996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetObject(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x000A1314 File Offset: 0x0009F514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185996, XrefRangeEnd = 185997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetObject(string key, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x000A1374 File Offset: 0x0009F574
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 186052, RefRangeEnd = 186056, XrefRangeStart = 185997, XrefRangeEnd = 186052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetObject(string key, bool ignoreCase, bool isString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isString;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_GetObject_Private_Object_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x000A13E0 File Offset: 0x0009F5E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 186067, RefRangeEnd = 186069, XrefRangeStart = 186056, XrefRangeEnd = 186067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resLocation));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(copyOfCache);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyInWrongCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResourceSet.NativeMethodInfoPtr_ResolveResourceLocator_Private_Object_ResourceLocator_String_Dictionary_2_String_ResourceLocator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x00009590 File Offset: 0x00007790
		public RuntimeResourceSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001B98 RID: 7064 RVA: 0x000A1468 File Offset: 0x0009F668
		// (set) Token: 0x06001B99 RID: 7065 RVA: 0x00009599 File Offset: 0x00007799
		public unsafe static int Version
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RuntimeResourceSet.NativeFieldInfoPtr_Version, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeResourceSet.NativeFieldInfoPtr_Version, (void*)(&value));
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x000A1484 File Offset: 0x0009F684
		// (set) Token: 0x06001B9B RID: 7067 RVA: 0x000095A7 File Offset: 0x000077A7
		public unsafe Dictionary<string, ResourceLocator> _resCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__resCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ResourceLocator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__resCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x000A14B4 File Offset: 0x0009F6B4
		// (set) Token: 0x06001B9D RID: 7069 RVA: 0x000095C6 File Offset: 0x000077C6
		public unsafe ResourceReader _defaultReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__defaultReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__defaultReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001B9E RID: 7070 RVA: 0x000A14E4 File Offset: 0x0009F6E4
		// (set) Token: 0x06001B9F RID: 7071 RVA: 0x000095E5 File Offset: 0x000077E5
		public new unsafe Dictionary<string, ResourceLocator> _caseInsensitiveTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__caseInsensitiveTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ResourceLocator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__caseInsensitiveTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x000A1514 File Offset: 0x0009F714
		// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x00009604 File Offset: 0x00007804
		public unsafe bool _haveReadFromReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__haveReadFromReader);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResourceSet.NativeFieldInfoPtr__haveReadFromReader)) = value;
			}
		}

		// Token: 0x040018FE RID: 6398
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x040018FF RID: 6399
		private static readonly IntPtr NativeFieldInfoPtr__resCache;

		// Token: 0x04001900 RID: 6400
		private static readonly IntPtr NativeFieldInfoPtr__defaultReader;

		// Token: 0x04001901 RID: 6401
		private static readonly IntPtr NativeFieldInfoPtr__caseInsensitiveTable;

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeFieldInfoPtr__haveReadFromReader;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_0;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumeratorHelper_Private_IDictionaryEnumerator_0;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_String_String_0;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_String_String_Boolean_0;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_0;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Public_Virtual_Object_String_Boolean_0;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Private_Object_String_Boolean_Boolean_0;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeMethodInfoPtr_ResolveResourceLocator_Private_Object_ResourceLocator_String_Dictionary_2_String_ResourceLocator_Boolean_0;
	}
}
