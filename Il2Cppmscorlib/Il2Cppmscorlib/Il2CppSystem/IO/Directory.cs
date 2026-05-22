using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x020001FA RID: 506
	public static class Directory : Object
	{
		// Token: 0x060020CC RID: 8396 RVA: 0x000B8860 File Offset: 0x000B6A60
		// Note: this type is marked as 'beforefieldinit'.
		static Directory()
		{
			Il2CppClassPointerStore<Directory>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "Directory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Directory>.NativeClassPtr);
			Directory.NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668828);
			Directory.NativeMethodInfoPtr_InternalGetFiles_Private_Static_Il2CppStringArray_String_String_SearchOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668829);
			Directory.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668830);
			Directory.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668831);
			Directory.NativeMethodInfoPtr_InternalGetDirectories_Private_Static_Il2CppStringArray_String_String_SearchOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668832);
			Directory.NativeMethodInfoPtr_InternalGetFileDirectoryNames_Internal_Static_Il2CppStringArray_String_String_String_Boolean_Boolean_SearchOption_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668833);
			Directory.NativeMethodInfoPtr_CreateDirectory_Public_Static_DirectoryInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668834);
			Directory.NativeMethodInfoPtr_CreateDirectoriesInternal_Private_Static_DirectoryInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668835);
			Directory.NativeMethodInfoPtr_Delete_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668836);
			Directory.NativeMethodInfoPtr_RecursiveDelete_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668837);
			Directory.NativeMethodInfoPtr_Delete_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668838);
			Directory.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668839);
			Directory.NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668840);
			Directory.NativeMethodInfoPtr_InsecureGetCurrentDirectory_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668841);
			Directory.NativeMethodInfoPtr_GetDemandDir_Internal_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668842);
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x000B89BC File Offset: 0x000B6BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189842, XrefRangeEnd = 189845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetFiles(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x000B8A00 File Offset: 0x000B6C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189845, XrefRangeEnd = 189846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray InternalGetFiles(string path, string searchPattern, SearchOption searchOption)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_InternalGetFiles_Private_Static_Il2CppStringArray_String_String_SearchOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x000B8A64 File Offset: 0x000B6C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189846, XrefRangeEnd = 189849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetDirectories(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x000B8AA8 File Offset: 0x000B6CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189849, XrefRangeEnd = 189850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetDirectories(string path, string searchPattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x000B8B00 File Offset: 0x000B6D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189850, XrefRangeEnd = 189851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray InternalGetDirectories(string path, string searchPattern, SearchOption searchOption)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_InternalGetDirectories_Private_Static_Il2CppStringArray_String_String_SearchOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x000B8B64 File Offset: 0x000B6D64
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 189871, RefRangeEnd = 189879, XrefRangeStart = 189851, XrefRangeEnd = 189871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray InternalGetFileDirectoryNames(string path, string userPathOriginal, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption, bool checkHost)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userPathOriginal);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFiles;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDirs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkHost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_InternalGetFileDirectoryNames_Internal_Static_Il2CppStringArray_String_String_String_Boolean_Boolean_SearchOption_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x000B8C04 File Offset: 0x000B6E04
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 189928, RefRangeEnd = 189934, XrefRangeStart = 189879, XrefRangeEnd = 189928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DirectoryInfo CreateDirectory(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_CreateDirectory_Public_Static_DirectoryInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DirectoryInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x000B8C48 File Offset: 0x000B6E48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189953, RefRangeEnd = 189954, XrefRangeStart = 189934, XrefRangeEnd = 189953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DirectoryInfo CreateDirectoriesInternal(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_CreateDirectoriesInternal_Private_Static_DirectoryInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DirectoryInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x000B8C8C File Offset: 0x000B6E8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189984, RefRangeEnd = 189986, XrefRangeStart = 189954, XrefRangeEnd = 189984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Delete(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_Delete_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x000B8CC4 File Offset: 0x000B6EC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190016, RefRangeEnd = 190019, XrefRangeStart = 189986, XrefRangeEnd = 190016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecursiveDelete(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_RecursiveDelete_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x000B8CFC File Offset: 0x000B6EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190019, XrefRangeEnd = 190025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Delete(string path, bool recursive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recursive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_Delete_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x000B8D40 File Offset: 0x000B6F40
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 190041, RefRangeEnd = 190062, XrefRangeStart = 190025, XrefRangeEnd = 190041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Exists(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x000B8D84 File Offset: 0x000B6F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190062, XrefRangeEnd = 190063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCurrentDirectory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x000B8DB0 File Offset: 0x000B6FB0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 190069, RefRangeEnd = 190075, XrefRangeStart = 190063, XrefRangeEnd = 190069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InsecureGetCurrentDirectory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_InsecureGetCurrentDirectory_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x000B8DDC File Offset: 0x000B6FDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 190101, RefRangeEnd = 190103, XrefRangeStart = 190075, XrefRangeEnd = 190101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDemandDir(string fullPath, bool thisDirOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref thisDirOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetDemandDir_Internal_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x0000AF4D File Offset: 0x0000914D
		public Directory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001DAF RID: 7599
		private static readonly IntPtr NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_0;

		// Token: 0x04001DB0 RID: 7600
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetFiles_Private_Static_Il2CppStringArray_String_String_SearchOption_0;

		// Token: 0x04001DB1 RID: 7601
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0;

		// Token: 0x04001DB2 RID: 7602
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_String_0;

		// Token: 0x04001DB3 RID: 7603
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetDirectories_Private_Static_Il2CppStringArray_String_String_SearchOption_0;

		// Token: 0x04001DB4 RID: 7604
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetFileDirectoryNames_Internal_Static_Il2CppStringArray_String_String_String_Boolean_Boolean_SearchOption_Boolean_0;

		// Token: 0x04001DB5 RID: 7605
		private static readonly IntPtr NativeMethodInfoPtr_CreateDirectory_Public_Static_DirectoryInfo_String_0;

		// Token: 0x04001DB6 RID: 7606
		private static readonly IntPtr NativeMethodInfoPtr_CreateDirectoriesInternal_Private_Static_DirectoryInfo_String_0;

		// Token: 0x04001DB7 RID: 7607
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_String_0;

		// Token: 0x04001DB8 RID: 7608
		private static readonly IntPtr NativeMethodInfoPtr_RecursiveDelete_Private_Static_Void_String_0;

		// Token: 0x04001DB9 RID: 7609
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_String_Boolean_0;

		// Token: 0x04001DBA RID: 7610
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0;

		// Token: 0x04001DBB RID: 7611
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_0;

		// Token: 0x04001DBC RID: 7612
		private static readonly IntPtr NativeMethodInfoPtr_InsecureGetCurrentDirectory_Internal_Static_String_0;

		// Token: 0x04001DBD RID: 7613
		private static readonly IntPtr NativeMethodInfoPtr_GetDemandDir_Internal_Static_String_String_Boolean_0;

		// Token: 0x020005D0 RID: 1488
		public sealed class SearchData : Object
		{
			// Token: 0x060052D9 RID: 21209 RVA: 0x00175EE4 File Offset: 0x001740E4
			// Note: this type is marked as 'beforefieldinit'.
			static SearchData()
			{
				Il2CppClassPointerStore<Directory.SearchData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Directory>.NativeClassPtr, "SearchData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Directory.SearchData>.NativeClassPtr);
				Directory.SearchData.NativeFieldInfoPtr_fullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Directory.SearchData>.NativeClassPtr, "fullPath");
				Directory.SearchData.NativeFieldInfoPtr_userPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Directory.SearchData>.NativeClassPtr, "userPath");
				Directory.SearchData.NativeFieldInfoPtr_searchOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Directory.SearchData>.NativeClassPtr, "searchOption");
				Directory.SearchData.NativeMethodInfoPtr__ctor_Public_Void_String_String_SearchOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory.SearchData>.NativeClassPtr, 100668843);
			}

			// Token: 0x060052DA RID: 21210 RVA: 0x00175F60 File Offset: 0x00174160
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 186110, RefRangeEnd = 186112, XrefRangeStart = 186110, XrefRangeEnd = 186112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SearchData(string fullPath, string userPath, SearchOption searchOption)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Directory.SearchData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userPath);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.SearchData.NativeMethodInfoPtr__ctor_Public_Void_String_String_SearchOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052DB RID: 21211 RVA: 0x0001F2AA File Offset: 0x0001D4AA
			public SearchData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700153F RID: 5439
			// (get) Token: 0x060052DC RID: 21212 RVA: 0x00175FCC File Offset: 0x001741CC
			// (set) Token: 0x060052DD RID: 21213 RVA: 0x0001F2B3 File Offset: 0x0001D4B3
			public unsafe string fullPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Directory.SearchData.NativeFieldInfoPtr_fullPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Directory.SearchData.NativeFieldInfoPtr_fullPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001540 RID: 5440
			// (get) Token: 0x060052DE RID: 21214 RVA: 0x00175FF4 File Offset: 0x001741F4
			// (set) Token: 0x060052DF RID: 21215 RVA: 0x0001F2D2 File Offset: 0x0001D4D2
			public unsafe string userPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Directory.SearchData.NativeFieldInfoPtr_userPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Directory.SearchData.NativeFieldInfoPtr_userPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001541 RID: 5441
			// (get) Token: 0x060052E0 RID: 21216 RVA: 0x0017601C File Offset: 0x0017421C
			// (set) Token: 0x060052E1 RID: 21217 RVA: 0x0001F2F1 File Offset: 0x0001D4F1
			public unsafe SearchOption searchOption
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Directory.SearchData.NativeFieldInfoPtr_searchOption);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Directory.SearchData.NativeFieldInfoPtr_searchOption)) = value;
				}
			}

			// Token: 0x04004329 RID: 17193
			private static readonly IntPtr NativeFieldInfoPtr_fullPath;

			// Token: 0x0400432A RID: 17194
			private static readonly IntPtr NativeFieldInfoPtr_userPath;

			// Token: 0x0400432B RID: 17195
			private static readonly IntPtr NativeFieldInfoPtr_searchOption;

			// Token: 0x0400432C RID: 17196
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_SearchOption_0;
		}
	}
}
