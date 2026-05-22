using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.IO
{
	// Token: 0x02000220 RID: 544
	public static class MonoIO : Object
	{
		// Token: 0x0600238F RID: 9103 RVA: 0x000C48B4 File Offset: 0x000C2AB4
		// Note: this type is marked as 'beforefieldinit'.
		static MonoIO()
		{
			Il2CppClassPointerStore<MonoIO>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "MonoIO");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoIO>.NativeClassPtr);
			MonoIO.NativeFieldInfoPtr_InvalidHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, "InvalidHandle");
			MonoIO.NativeFieldInfoPtr_dump_handles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, "dump_handles");
			MonoIO.NativeMethodInfoPtr_GetException_Public_Static_Exception_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669329);
			MonoIO.NativeMethodInfoPtr_GetException_Public_Static_Exception_String_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669330);
			MonoIO.NativeMethodInfoPtr_CreateDirectory_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669331);
			MonoIO.NativeMethodInfoPtr_CreateDirectory_Public_Static_Boolean_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669332);
			MonoIO.NativeMethodInfoPtr_RemoveDirectory_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669333);
			MonoIO.NativeMethodInfoPtr_RemoveDirectory_Public_Static_Boolean_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669334);
			MonoIO.NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669335);
			MonoIO.NativeMethodInfoPtr_MoveFile_Private_Static_Boolean_ptr_Char_ptr_Char_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669336);
			MonoIO.NativeMethodInfoPtr_MoveFile_Public_Static_Boolean_String_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669337);
			MonoIO.NativeMethodInfoPtr_DeleteFile_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669338);
			MonoIO.NativeMethodInfoPtr_DeleteFile_Public_Static_Boolean_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669339);
			MonoIO.NativeMethodInfoPtr_GetFileAttributes_Private_Static_FileAttributes_ptr_Char_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669340);
			MonoIO.NativeMethodInfoPtr_GetFileAttributes_Public_Static_FileAttributes_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669341);
			MonoIO.NativeMethodInfoPtr_GetFileType_Private_Static_MonoFileType_IntPtr_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669342);
			MonoIO.NativeMethodInfoPtr_GetFileType_Public_Static_MonoFileType_SafeHandle_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669343);
			MonoIO.NativeMethodInfoPtr_FindFirstFile_Private_Static_IntPtr_ptr_Char_byref_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669344);
			MonoIO.NativeMethodInfoPtr_FindFirstFile_Public_Static_IntPtr_String_byref_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669345);
			MonoIO.NativeMethodInfoPtr_FindNextFile_Public_Static_Boolean_IntPtr_byref_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669346);
			MonoIO.NativeMethodInfoPtr_FindCloseFile_Public_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669347);
			MonoIO.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669348);
			MonoIO.NativeMethodInfoPtr_ExistsFile_Public_Static_Boolean_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669349);
			MonoIO.NativeMethodInfoPtr_ExistsDirectory_Public_Static_Boolean_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669350);
			MonoIO.NativeMethodInfoPtr_ExistsSymlink_Public_Static_Boolean_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669351);
			MonoIO.NativeMethodInfoPtr_GetFileStat_Private_Static_Boolean_ptr_Char_byref_MonoIOStat_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669352);
			MonoIO.NativeMethodInfoPtr_GetFileStat_Public_Static_Boolean_String_byref_MonoIOStat_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669353);
			MonoIO.NativeMethodInfoPtr_Open_Private_Static_IntPtr_ptr_Char_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669354);
			MonoIO.NativeMethodInfoPtr_Open_Public_Static_IntPtr_String_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669355);
			MonoIO.NativeMethodInfoPtr_Close_Public_Static_Boolean_IntPtr_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669356);
			MonoIO.NativeMethodInfoPtr_Read_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669357);
			MonoIO.NativeMethodInfoPtr_Read_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669358);
			MonoIO.NativeMethodInfoPtr_Write_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669359);
			MonoIO.NativeMethodInfoPtr_Write_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669360);
			MonoIO.NativeMethodInfoPtr_Seek_Private_Static_Int64_IntPtr_Int64_SeekOrigin_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669361);
			MonoIO.NativeMethodInfoPtr_Seek_Public_Static_Int64_SafeHandle_Int64_SeekOrigin_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669362);
			MonoIO.NativeMethodInfoPtr_GetLength_Private_Static_Int64_IntPtr_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669363);
			MonoIO.NativeMethodInfoPtr_GetLength_Public_Static_Int64_SafeHandle_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669364);
			MonoIO.NativeMethodInfoPtr_get_ConsoleOutput_Public_Static_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669365);
			MonoIO.NativeMethodInfoPtr_get_ConsoleInput_Public_Static_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669366);
			MonoIO.NativeMethodInfoPtr_get_ConsoleError_Public_Static_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669367);
			MonoIO.NativeMethodInfoPtr_get_VolumeSeparatorChar_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669368);
			MonoIO.NativeMethodInfoPtr_get_DirectorySeparatorChar_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669369);
			MonoIO.NativeMethodInfoPtr_get_AltDirectorySeparatorChar_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669370);
			MonoIO.NativeMethodInfoPtr_get_PathSeparator_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669371);
			MonoIO.NativeMethodInfoPtr_DumpHandles_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669372);
			MonoIO.NativeMethodInfoPtr_RemapPath_Public_Static_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669373);
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x000C4C90 File Offset: 0x000C2E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192713, XrefRangeEnd = 192723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetException(MonoIOError error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetException_Public_Static_Exception_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x000C4CD0 File Offset: 0x000C2ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192723, XrefRangeEnd = 192863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetException(string path, MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetException_Public_Static_Exception_String_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x000C4D24 File Offset: 0x000C2F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192863, XrefRangeEnd = 192867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateDirectory(char* path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = path;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_CreateDirectory_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x000C4D70 File Offset: 0x000C2F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192867, XrefRangeEnd = 192874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateDirectory(string path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_CreateDirectory_Public_Static_Boolean_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x000C4DC0 File Offset: 0x000C2FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192874, XrefRangeEnd = 192878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveDirectory(char* path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = path;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_RemoveDirectory_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x000C4E0C File Offset: 0x000C300C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192878, XrefRangeEnd = 192885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveDirectory(string path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_RemoveDirectory_Public_Static_Boolean_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x000C4E5C File Offset: 0x000C305C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192885, XrefRangeEnd = 192888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCurrentDirectory(out MonoIOError error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x000C4E94 File Offset: 0x000C3094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192888, XrefRangeEnd = 192889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MoveFile(char* path, char* dest, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = path;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_MoveFile_Private_Static_Boolean_ptr_Char_ptr_Char_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x000C4EEC File Offset: 0x000C30EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192889, XrefRangeEnd = 192893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MoveFile(string path, string dest, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_MoveFile_Public_Static_Boolean_String_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x000C4F50 File Offset: 0x000C3150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192893, XrefRangeEnd = 192897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeleteFile(char* path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = path;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_DeleteFile_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x000C4F9C File Offset: 0x000C319C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192904, RefRangeEnd = 192907, XrefRangeStart = 192897, XrefRangeEnd = 192904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeleteFile(string path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_DeleteFile_Public_Static_Boolean_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x000C4FEC File Offset: 0x000C31EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192907, XrefRangeEnd = 192911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileAttributes GetFileAttributes(char* path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = path;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetFileAttributes_Private_Static_FileAttributes_ptr_Char_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x000C5038 File Offset: 0x000C3238
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 192918, RefRangeEnd = 192926, XrefRangeStart = 192911, XrefRangeEnd = 192918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileAttributes GetFileAttributes(string path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetFileAttributes_Public_Static_FileAttributes_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x000C5088 File Offset: 0x000C3288
		[CallerCount(0)]
		public unsafe static MonoFileType GetFileType(IntPtr handle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetFileType_Private_Static_MonoFileType_IntPtr_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x000C50D4 File Offset: 0x000C32D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192932, RefRangeEnd = 192934, XrefRangeStart = 192926, XrefRangeEnd = 192932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetFileType_Public_Static_MonoFileType_SafeHandle_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x000C5124 File Offset: 0x000C3324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192934, XrefRangeEnd = 192935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr FindFirstFile(char* pathWithPattern, out string fileName, out int fileAttr, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pathWithPattern;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &fileAttr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_FindFirstFile_Private_Static_IntPtr_ptr_Char_byref_String_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			fileName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x000C5198 File Offset: 0x000C3398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192935, XrefRangeEnd = 192939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr FindFirstFile(string pathWithPattern, out string fileName, out int fileAttr, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pathWithPattern);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &fileAttr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_FindFirstFile_Public_Static_IntPtr_String_byref_String_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			fileName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x000C5210 File Offset: 0x000C3410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192939, XrefRangeEnd = 192940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FindNextFile(IntPtr hnd, out string fileName, out int fileAttr, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hnd;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &fileAttr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_FindNextFile_Public_Static_Boolean_IntPtr_byref_String_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			fileName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x000C5284 File Offset: 0x000C3484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192940, XrefRangeEnd = 192942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FindCloseFile(IntPtr hnd)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hnd;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_FindCloseFile_Public_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x000C52C4 File Offset: 0x000C34C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192942, XrefRangeEnd = 192946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Exists(string path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x000C5314 File Offset: 0x000C3514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192946, XrefRangeEnd = 192950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExistsFile(string path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_ExistsFile_Public_Static_Boolean_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x000C5364 File Offset: 0x000C3564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192950, XrefRangeEnd = 192954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExistsDirectory(string path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_ExistsDirectory_Public_Static_Boolean_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x000C53B4 File Offset: 0x000C35B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192958, RefRangeEnd = 192959, XrefRangeStart = 192954, XrefRangeEnd = 192958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExistsSymlink(string path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_ExistsSymlink_Public_Static_Boolean_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x000C5404 File Offset: 0x000C3604
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192964, RefRangeEnd = 192967, XrefRangeStart = 192959, XrefRangeEnd = 192964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFileStat(char* path, out MonoIOStat stat, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = path;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetFileStat_Private_Static_Boolean_ptr_Char_byref_MonoIOStat_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x000C545C File Offset: 0x000C365C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192967, XrefRangeEnd = 192971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFileStat(string path, out MonoIOStat stat, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetFileStat_Public_Static_Boolean_String_byref_MonoIOStat_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x000C54BC File Offset: 0x000C36BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192971, XrefRangeEnd = 192975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = filename;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Open_Private_Static_IntPtr_ptr_Char_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x000C5540 File Offset: 0x000C3740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192975, XrefRangeEnd = 192982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Open_Public_Static_IntPtr_String_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x000C55C8 File Offset: 0x000C37C8
		[CallerCount(0)]
		public unsafe static bool Close(IntPtr handle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Close_Public_Static_Boolean_IntPtr_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x000C5614 File Offset: 0x000C3814
		[CallerCount(0)]
		public unsafe static int Read(IntPtr handle, Il2CppStructArray<byte> dest, int dest_offset, int count, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest_offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Read_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x000C5690 File Offset: 0x000C3890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192990, RefRangeEnd = 192991, XrefRangeStart = 192982, XrefRangeEnd = 192990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Read(SafeHandle safeHandle, Il2CppStructArray<byte> dest, int dest_offset, int count, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest_offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Read_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x000C5710 File Offset: 0x000C3910
		[CallerCount(0)]
		public unsafe static int Write(IntPtr handle, [In] Il2CppStructArray<byte> src, int src_offset, int count, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref src_offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Write_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x000C578C File Offset: 0x000C398C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192999, RefRangeEnd = 193001, XrefRangeStart = 192991, XrefRangeEnd = 192999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Write(SafeHandle safeHandle, Il2CppStructArray<byte> src, int src_offset, int count, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref src_offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Write_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x000C580C File Offset: 0x000C3A0C
		[CallerCount(0)]
		public unsafe static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Seek_Private_Static_Int64_IntPtr_Int64_SeekOrigin_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x000C5874 File Offset: 0x000C3A74
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 193007, RefRangeEnd = 193012, XrefRangeStart = 193001, XrefRangeEnd = 193007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Seek_Public_Static_Int64_SafeHandle_Int64_SeekOrigin_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x000C58E0 File Offset: 0x000C3AE0
		[CallerCount(0)]
		public unsafe static long GetLength(IntPtr handle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetLength_Private_Static_Int64_IntPtr_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x000C592C File Offset: 0x000C3B2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193019, RefRangeEnd = 193020, XrefRangeStart = 193012, XrefRangeEnd = 193019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetLength(SafeHandle safeHandle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetLength_Public_Static_Int64_SafeHandle_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x000C597C File Offset: 0x000C3B7C
		public unsafe static IntPtr ConsoleOutput
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_ConsoleOutput_Public_Static_get_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x060023B5 RID: 9141 RVA: 0x000C59AC File Offset: 0x000C3BAC
		public unsafe static IntPtr ConsoleInput
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_ConsoleInput_Public_Static_get_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x000C59DC File Offset: 0x000C3BDC
		public unsafe static IntPtr ConsoleError
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_ConsoleError_Public_Static_get_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060023B7 RID: 9143 RVA: 0x000C5A0C File Offset: 0x000C3C0C
		public unsafe static char VolumeSeparatorChar
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_VolumeSeparatorChar_Public_Static_get_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x000C5A3C File Offset: 0x000C3C3C
		public unsafe static char DirectorySeparatorChar
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_DirectorySeparatorChar_Public_Static_get_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060023B9 RID: 9145 RVA: 0x000C5A6C File Offset: 0x000C3C6C
		public unsafe static char AltDirectorySeparatorChar
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_AltDirectorySeparatorChar_Public_Static_get_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x000C5A9C File Offset: 0x000C3C9C
		public unsafe static char PathSeparator
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_PathSeparator_Public_Static_get_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x000C5ACC File Offset: 0x000C3CCC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 131113, RefRangeEnd = 131119, XrefRangeStart = 131113, XrefRangeEnd = 131119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DumpHandles()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_DumpHandles_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x000C5AF4 File Offset: 0x000C3CF4
		[CallerCount(0)]
		public unsafe static bool RemapPath(string path, out string newPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_RemapPath_Public_Static_Boolean_String_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			newPath = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x0000BEA9 File Offset: 0x0000A0A9
		public MonoIO(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x000C5B50 File Offset: 0x000C3D50
		// (set) Token: 0x060023BF RID: 9151 RVA: 0x0000BEB2 File Offset: 0x0000A0B2
		public unsafe static IntPtr InvalidHandle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoIO.NativeFieldInfoPtr_InvalidHandle, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoIO.NativeFieldInfoPtr_InvalidHandle, (void*)(&value));
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x060023C0 RID: 9152 RVA: 0x000C5B6C File Offset: 0x000C3D6C
		// (set) Token: 0x060023C1 RID: 9153 RVA: 0x0000BEC0 File Offset: 0x0000A0C0
		public unsafe static bool dump_handles
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(MonoIO.NativeFieldInfoPtr_dump_handles, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoIO.NativeFieldInfoPtr_dump_handles, (void*)(&value));
			}
		}

		// Token: 0x04001FDF RID: 8159
		private static readonly IntPtr NativeFieldInfoPtr_InvalidHandle;

		// Token: 0x04001FE0 RID: 8160
		private static readonly IntPtr NativeFieldInfoPtr_dump_handles;

		// Token: 0x04001FE1 RID: 8161
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Public_Static_Exception_MonoIOError_0;

		// Token: 0x04001FE2 RID: 8162
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Public_Static_Exception_String_MonoIOError_0;

		// Token: 0x04001FE3 RID: 8163
		private static readonly IntPtr NativeMethodInfoPtr_CreateDirectory_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0;

		// Token: 0x04001FE4 RID: 8164
		private static readonly IntPtr NativeMethodInfoPtr_CreateDirectory_Public_Static_Boolean_String_byref_MonoIOError_0;

		// Token: 0x04001FE5 RID: 8165
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDirectory_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0;

		// Token: 0x04001FE6 RID: 8166
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDirectory_Public_Static_Boolean_String_byref_MonoIOError_0;

		// Token: 0x04001FE7 RID: 8167
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_byref_MonoIOError_0;

		// Token: 0x04001FE8 RID: 8168
		private static readonly IntPtr NativeMethodInfoPtr_MoveFile_Private_Static_Boolean_ptr_Char_ptr_Char_byref_MonoIOError_0;

		// Token: 0x04001FE9 RID: 8169
		private static readonly IntPtr NativeMethodInfoPtr_MoveFile_Public_Static_Boolean_String_String_byref_MonoIOError_0;

		// Token: 0x04001FEA RID: 8170
		private static readonly IntPtr NativeMethodInfoPtr_DeleteFile_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0;

		// Token: 0x04001FEB RID: 8171
		private static readonly IntPtr NativeMethodInfoPtr_DeleteFile_Public_Static_Boolean_String_byref_MonoIOError_0;

		// Token: 0x04001FEC RID: 8172
		private static readonly IntPtr NativeMethodInfoPtr_GetFileAttributes_Private_Static_FileAttributes_ptr_Char_byref_MonoIOError_0;

		// Token: 0x04001FED RID: 8173
		private static readonly IntPtr NativeMethodInfoPtr_GetFileAttributes_Public_Static_FileAttributes_String_byref_MonoIOError_0;

		// Token: 0x04001FEE RID: 8174
		private static readonly IntPtr NativeMethodInfoPtr_GetFileType_Private_Static_MonoFileType_IntPtr_byref_MonoIOError_0;

		// Token: 0x04001FEF RID: 8175
		private static readonly IntPtr NativeMethodInfoPtr_GetFileType_Public_Static_MonoFileType_SafeHandle_byref_MonoIOError_0;

		// Token: 0x04001FF0 RID: 8176
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstFile_Private_Static_IntPtr_ptr_Char_byref_String_byref_Int32_byref_Int32_0;

		// Token: 0x04001FF1 RID: 8177
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstFile_Public_Static_IntPtr_String_byref_String_byref_Int32_byref_Int32_0;

		// Token: 0x04001FF2 RID: 8178
		private static readonly IntPtr NativeMethodInfoPtr_FindNextFile_Public_Static_Boolean_IntPtr_byref_String_byref_Int32_byref_Int32_0;

		// Token: 0x04001FF3 RID: 8179
		private static readonly IntPtr NativeMethodInfoPtr_FindCloseFile_Public_Static_Boolean_IntPtr_0;

		// Token: 0x04001FF4 RID: 8180
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_byref_MonoIOError_0;

		// Token: 0x04001FF5 RID: 8181
		private static readonly IntPtr NativeMethodInfoPtr_ExistsFile_Public_Static_Boolean_String_byref_MonoIOError_0;

		// Token: 0x04001FF6 RID: 8182
		private static readonly IntPtr NativeMethodInfoPtr_ExistsDirectory_Public_Static_Boolean_String_byref_MonoIOError_0;

		// Token: 0x04001FF7 RID: 8183
		private static readonly IntPtr NativeMethodInfoPtr_ExistsSymlink_Public_Static_Boolean_String_byref_MonoIOError_0;

		// Token: 0x04001FF8 RID: 8184
		private static readonly IntPtr NativeMethodInfoPtr_GetFileStat_Private_Static_Boolean_ptr_Char_byref_MonoIOStat_byref_MonoIOError_0;

		// Token: 0x04001FF9 RID: 8185
		private static readonly IntPtr NativeMethodInfoPtr_GetFileStat_Public_Static_Boolean_String_byref_MonoIOStat_byref_MonoIOError_0;

		// Token: 0x04001FFA RID: 8186
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_Static_IntPtr_ptr_Char_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0;

		// Token: 0x04001FFB RID: 8187
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_IntPtr_String_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0;

		// Token: 0x04001FFC RID: 8188
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Static_Boolean_IntPtr_byref_MonoIOError_0;

		// Token: 0x04001FFD RID: 8189
		private static readonly IntPtr NativeMethodInfoPtr_Read_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0;

		// Token: 0x04001FFE RID: 8190
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0;

		// Token: 0x04001FFF RID: 8191
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0;

		// Token: 0x04002000 RID: 8192
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0;

		// Token: 0x04002001 RID: 8193
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Private_Static_Int64_IntPtr_Int64_SeekOrigin_byref_MonoIOError_0;

		// Token: 0x04002002 RID: 8194
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Static_Int64_SafeHandle_Int64_SeekOrigin_byref_MonoIOError_0;

		// Token: 0x04002003 RID: 8195
		private static readonly IntPtr NativeMethodInfoPtr_GetLength_Private_Static_Int64_IntPtr_byref_MonoIOError_0;

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeMethodInfoPtr_GetLength_Public_Static_Int64_SafeHandle_byref_MonoIOError_0;

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsoleOutput_Public_Static_get_IntPtr_0;

		// Token: 0x04002006 RID: 8198
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsoleInput_Public_Static_get_IntPtr_0;

		// Token: 0x04002007 RID: 8199
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsoleError_Public_Static_get_IntPtr_0;

		// Token: 0x04002008 RID: 8200
		private static readonly IntPtr NativeMethodInfoPtr_get_VolumeSeparatorChar_Public_Static_get_Char_0;

		// Token: 0x04002009 RID: 8201
		private static readonly IntPtr NativeMethodInfoPtr_get_DirectorySeparatorChar_Public_Static_get_Char_0;

		// Token: 0x0400200A RID: 8202
		private static readonly IntPtr NativeMethodInfoPtr_get_AltDirectorySeparatorChar_Public_Static_get_Char_0;

		// Token: 0x0400200B RID: 8203
		private static readonly IntPtr NativeMethodInfoPtr_get_PathSeparator_Public_Static_get_Char_0;

		// Token: 0x0400200C RID: 8204
		private static readonly IntPtr NativeMethodInfoPtr_DumpHandles_Private_Static_Void_0;

		// Token: 0x0400200D RID: 8205
		private static readonly IntPtr NativeMethodInfoPtr_RemapPath_Public_Static_Boolean_String_byref_String_0;
	}
}
