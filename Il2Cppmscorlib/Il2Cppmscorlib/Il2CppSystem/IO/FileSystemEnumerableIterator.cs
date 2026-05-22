using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.IO
{
	// Token: 0x02000203 RID: 515
	public class FileSystemEnumerableIterator<TSource> : Iterator<TSource>
	{
		// Token: 0x0600212C RID: 8492 RVA: 0x000BA358 File Offset: 0x000B8558
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemEnumerableIterator()
		{
			Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileSystemEnumerableIterator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr);
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__resultHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "_resultHandler");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "searchStack");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "searchData");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchCriteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "searchCriteria");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__hnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "_hnd");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_needsParentPathDiscoveryDemand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "needsParentPathDiscoveryDemand");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "empty");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_userPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "userPath");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "searchOption");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_fullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "fullPath");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_normalizedSearchPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "normalizedSearchPath");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__checkHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "_checkHost");
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_SearchOption_SearchResultHandler_1_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668891);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_CommonInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668892);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr__ctor_Private_Void_String_String_String_String_SearchOption_SearchResultHandler_1_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668893);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_Clone_Protected_Virtual_Iterator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668894);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668895);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668896);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_CreateSearchResult_Private_SearchResult_SearchData_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668897);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_HandleError_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668898);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_AddSearchableDirsToStack_Private_Void_SearchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668899);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_DoDemand_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668900);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_NormalizeSearchPattern_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668901);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_GetNormalizedSearchCriteria_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668902);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_GetFullSearchString_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668903);
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x000BA5B8 File Offset: 0x000B87B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 190365, RefRangeEnd = 190367, XrefRangeStart = 190333, XrefRangeEnd = 190365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemEnumerableIterator(string path, string originalUserPath, string searchPattern, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalUserPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultHandler);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkHost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_SearchOption_SearchResultHandler_1_TSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x000BA658 File Offset: 0x000B8858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190367, XrefRangeEnd = 190391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommonInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_CommonInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x000BA68C File Offset: 0x000B888C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190391, XrefRangeEnd = 190399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemEnumerableIterator(string fullPath, string normalizedSearchPath, string searchCriteria, string userPath, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(normalizedSearchPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchCriteria);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userPath);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultHandler);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkHost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr__ctor_Private_Void_String_String_String_String_SearchOption_SearchResultHandler_1_TSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x000BA740 File Offset: 0x000B8940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190399, XrefRangeEnd = 190401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Iterator<TSource> Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_Clone_Protected_Virtual_Iterator_1_TSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Iterator<TSource>>(intPtr3) : null;
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x000BA78C File Offset: 0x000B898C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190401, XrefRangeEnd = 190402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x000BA7D8 File Offset: 0x000B89D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190402, XrefRangeEnd = 190434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x000BA820 File Offset: 0x000B8A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190434, XrefRangeEnd = 190442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SearchResult CreateSearchResult(Directory.SearchData localSearchData, Win32Native.WIN32_FIND_DATA findData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localSearchData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(findData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_CreateSearchResult_Private_SearchResult_SearchData_WIN32_FIND_DATA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SearchResult>(intPtr3) : null;
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x000BA884 File Offset: 0x000B8A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190442, XrefRangeEnd = 190444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleError(int hr, string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_HandleError_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x000BA8D4 File Offset: 0x000B8AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190444, XrefRangeEnd = 190484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSearchableDirsToStack(Directory.SearchData localSearchData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localSearchData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_AddSearchableDirsToStack_Private_Void_SearchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x000BA918 File Offset: 0x000B8B18
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoDemand(string fullPathToDemand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPathToDemand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_DoDemand_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x000BA95C File Offset: 0x000B8B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190484, XrefRangeEnd = 190500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NormalizeSearchPattern(string searchPattern)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_NormalizeSearchPattern_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x000BA998 File Offset: 0x000B8B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190500, XrefRangeEnd = 190512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNormalizedSearchCriteria(string fullSearchString, string fullPathMod)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullSearchString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fullPathMod);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_GetNormalizedSearchCriteria_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x000BA9E8 File Offset: 0x000B8BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190512, XrefRangeEnd = 190523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFullSearchString(string fullPath, string searchPattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_GetFullSearchString_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x0000B0A8 File Offset: 0x000092A8
		public FileSystemEnumerableIterator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x000BAA38 File Offset: 0x000B8C38
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x0000B0B1 File Offset: 0x000092B1
		public unsafe SearchResultHandler<TSource> _resultHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__resultHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchResultHandler<TSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__resultHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x000BAA68 File Offset: 0x000B8C68
		// (set) Token: 0x0600213E RID: 8510 RVA: 0x0000B0D0 File Offset: 0x000092D0
		public unsafe List<Directory.SearchData> searchStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Directory.SearchData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x000BAA98 File Offset: 0x000B8C98
		// (set) Token: 0x06002140 RID: 8512 RVA: 0x0000B0EF File Offset: 0x000092EF
		public unsafe Directory.SearchData searchData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Directory.SearchData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x000BAAC8 File Offset: 0x000B8CC8
		// (set) Token: 0x06002142 RID: 8514 RVA: 0x0000B10E File Offset: 0x0000930E
		public unsafe string searchCriteria
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchCriteria);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchCriteria), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x000BAAF0 File Offset: 0x000B8CF0
		// (set) Token: 0x06002144 RID: 8516 RVA: 0x0000B12D File Offset: 0x0000932D
		public unsafe SafeFindHandle _hnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__hnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeFindHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__hnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x000BAB20 File Offset: 0x000B8D20
		// (set) Token: 0x06002146 RID: 8518 RVA: 0x0000B14C File Offset: 0x0000934C
		public unsafe bool needsParentPathDiscoveryDemand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_needsParentPathDiscoveryDemand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_needsParentPathDiscoveryDemand)) = value;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x000BAB48 File Offset: 0x000B8D48
		// (set) Token: 0x06002148 RID: 8520 RVA: 0x0000B167 File Offset: 0x00009367
		public unsafe bool empty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_empty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_empty)) = value;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x000BAB70 File Offset: 0x000B8D70
		// (set) Token: 0x0600214A RID: 8522 RVA: 0x0000B182 File Offset: 0x00009382
		public unsafe string userPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_userPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_userPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x000BAB98 File Offset: 0x000B8D98
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x0000B1A1 File Offset: 0x000093A1
		public unsafe SearchOption searchOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchOption);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchOption)) = value;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x000BABC0 File Offset: 0x000B8DC0
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x0000B1BC File Offset: 0x000093BC
		public unsafe string fullPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_fullPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_fullPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x000BABE8 File Offset: 0x000B8DE8
		// (set) Token: 0x06002150 RID: 8528 RVA: 0x0000B1DB File Offset: 0x000093DB
		public unsafe string normalizedSearchPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_normalizedSearchPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_normalizedSearchPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x000BAC10 File Offset: 0x000B8E10
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x0000B1FA File Offset: 0x000093FA
		public unsafe bool _checkHost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__checkHost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__checkHost)) = value;
			}
		}

		// Token: 0x04001DF5 RID: 7669
		private static readonly IntPtr NativeFieldInfoPtr__resultHandler;

		// Token: 0x04001DF6 RID: 7670
		private static readonly IntPtr NativeFieldInfoPtr_searchStack;

		// Token: 0x04001DF7 RID: 7671
		private static readonly IntPtr NativeFieldInfoPtr_searchData;

		// Token: 0x04001DF8 RID: 7672
		private static readonly IntPtr NativeFieldInfoPtr_searchCriteria;

		// Token: 0x04001DF9 RID: 7673
		private static readonly IntPtr NativeFieldInfoPtr__hnd;

		// Token: 0x04001DFA RID: 7674
		private static readonly IntPtr NativeFieldInfoPtr_needsParentPathDiscoveryDemand;

		// Token: 0x04001DFB RID: 7675
		private static readonly IntPtr NativeFieldInfoPtr_empty;

		// Token: 0x04001DFC RID: 7676
		private static readonly IntPtr NativeFieldInfoPtr_userPath;

		// Token: 0x04001DFD RID: 7677
		private static readonly IntPtr NativeFieldInfoPtr_searchOption;

		// Token: 0x04001DFE RID: 7678
		private static readonly IntPtr NativeFieldInfoPtr_fullPath;

		// Token: 0x04001DFF RID: 7679
		private static readonly IntPtr NativeFieldInfoPtr_normalizedSearchPath;

		// Token: 0x04001E00 RID: 7680
		private static readonly IntPtr NativeFieldInfoPtr__checkHost;

		// Token: 0x04001E01 RID: 7681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_SearchOption_SearchResultHandler_1_TSource_Boolean_0;

		// Token: 0x04001E02 RID: 7682
		private static readonly IntPtr NativeMethodInfoPtr_CommonInit_Private_Void_0;

		// Token: 0x04001E03 RID: 7683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_String_String_String_SearchOption_SearchResultHandler_1_TSource_Boolean_0;

		// Token: 0x04001E04 RID: 7684
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Protected_Virtual_Iterator_1_TSource_0;

		// Token: 0x04001E05 RID: 7685
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04001E06 RID: 7686
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

		// Token: 0x04001E07 RID: 7687
		private static readonly IntPtr NativeMethodInfoPtr_CreateSearchResult_Private_SearchResult_SearchData_WIN32_FIND_DATA_0;

		// Token: 0x04001E08 RID: 7688
		private static readonly IntPtr NativeMethodInfoPtr_HandleError_Private_Void_Int32_String_0;

		// Token: 0x04001E09 RID: 7689
		private static readonly IntPtr NativeMethodInfoPtr_AddSearchableDirsToStack_Private_Void_SearchData_0;

		// Token: 0x04001E0A RID: 7690
		private static readonly IntPtr NativeMethodInfoPtr_DoDemand_Internal_Void_String_0;

		// Token: 0x04001E0B RID: 7691
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeSearchPattern_Private_Static_String_String_0;

		// Token: 0x04001E0C RID: 7692
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalizedSearchCriteria_Private_Static_String_String_String_0;

		// Token: 0x04001E0D RID: 7693
		private static readonly IntPtr NativeMethodInfoPtr_GetFullSearchString_Private_Static_String_String_String_0;
	}
}
