using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x02000223 RID: 547
	public static class Path : Object
	{
		// Token: 0x060023C4 RID: 9156 RVA: 0x000C5C1C File Offset: 0x000C3E1C
		// Note: this type is marked as 'beforefieldinit'.
		static Path()
		{
			Il2CppClassPointerStore<Path>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "Path");
			Path.NativeFieldInfoPtr_InvalidPathChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "InvalidPathChars");
			Path.NativeFieldInfoPtr_AltDirectorySeparatorChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "AltDirectorySeparatorChar");
			Path.NativeFieldInfoPtr_DirectorySeparatorChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "DirectorySeparatorChar");
			Path.NativeFieldInfoPtr_PathSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "PathSeparator");
			Path.NativeFieldInfoPtr_DirectorySeparatorStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "DirectorySeparatorStr");
			Path.NativeFieldInfoPtr_VolumeSeparatorChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "VolumeSeparatorChar");
			Path.NativeFieldInfoPtr_PathSeparatorChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "PathSeparatorChars");
			Path.NativeFieldInfoPtr_dirEqualsVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "dirEqualsVolume");
			Path.NativeFieldInfoPtr_trimEndCharsWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "trimEndCharsWindows");
			Path.NativeFieldInfoPtr_trimEndCharsUnix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "trimEndCharsUnix");
			Path.NativeMethodInfoPtr_Combine_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669375);
			Path.NativeMethodInfoPtr_CleanPath_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669376);
			Path.NativeMethodInfoPtr_GetDirectoryName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669377);
			Path.NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669378);
			Path.NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669379);
			Path.NativeMethodInfoPtr_GetFullPath_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669380);
			Path.NativeMethodInfoPtr_GetFullPathInternal_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669381);
			Path.NativeMethodInfoPtr_GetFullPathName_Private_Static_Int32_String_Int32_StringBuilder_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669382);
			Path.NativeMethodInfoPtr_GetFullPathName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669383);
			Path.NativeMethodInfoPtr_WindowsDriveAdjustment_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669384);
			Path.NativeMethodInfoPtr_InsecureGetFullPath_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669385);
			Path.NativeMethodInfoPtr_IsDirectorySeparator_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669386);
			Path.NativeMethodInfoPtr_GetPathRoot_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669387);
			Path.NativeMethodInfoPtr_IsPathRooted_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669388);
			Path.NativeMethodInfoPtr_GetInvalidFileNameChars_Public_Static_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669389);
			Path.NativeMethodInfoPtr_GetInvalidPathChars_Public_Static_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669390);
			Path.NativeMethodInfoPtr_findExtension_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669391);
			Path.NativeMethodInfoPtr_GetServerAndShare_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669393);
			Path.NativeMethodInfoPtr_SameRoot_Private_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669394);
			Path.NativeMethodInfoPtr_CanonicalizePath_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669395);
			Path.NativeMethodInfoPtr_Combine_Public_Static_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669396);
			Path.NativeMethodInfoPtr_Combine_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669397);
			Path.NativeMethodInfoPtr_Validate_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669398);
			Path.NativeMethodInfoPtr_Validate_Internal_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669399);
			Path.NativeMethodInfoPtr_get_DirectorySeparatorCharAsString_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669400);
			Path.NativeMethodInfoPtr_get_TrimEndChars_Internal_Static_get_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669401);
			Path.NativeMethodInfoPtr_CheckSearchPattern_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669402);
			Path.NativeMethodInfoPtr_CheckInvalidPathChars_Internal_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669403);
			Path.NativeMethodInfoPtr_InternalCombine_Internal_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669404);
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x000C5F50 File Offset: 0x000C4150
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 193044, RefRangeEnd = 193078, XrefRangeStart = 193020, XrefRangeEnd = 193044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Combine(string path1, string path2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Combine_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x000C5FA0 File Offset: 0x000C41A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193078, XrefRangeEnd = 193111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CleanPath(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_CleanPath_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x000C5FDC File Offset: 0x000C41DC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 193138, RefRangeEnd = 193149, XrefRangeStart = 193111, XrefRangeEnd = 193138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDirectoryName(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetDirectoryName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x000C6018 File Offset: 0x000C4218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193165, RefRangeEnd = 193166, XrefRangeStart = 193149, XrefRangeEnd = 193165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetExtension(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x000C6054 File Offset: 0x000C4254
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 193176, RefRangeEnd = 193185, XrefRangeStart = 193166, XrefRangeEnd = 193176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFileName(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x000C6090 File Offset: 0x000C4290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193189, RefRangeEnd = 193190, XrefRangeStart = 193185, XrefRangeEnd = 193189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFullPath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFullPath_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x000C60CC File Offset: 0x000C42CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193190, XrefRangeEnd = 193194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFullPathInternal(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFullPathInternal_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x000C6108 File Offset: 0x000C4308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193198, RefRangeEnd = 193199, XrefRangeStart = 193194, XrefRangeEnd = 193198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref IntPtr lpFilePartOrNull)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBufferChars;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpFilePartOrNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFullPathName_Private_Static_Int32_String_Int32_StringBuilder_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x000C6178 File Offset: 0x000C4378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193223, RefRangeEnd = 193224, XrefRangeStart = 193199, XrefRangeEnd = 193223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFullPathName(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFullPathName_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x000C61B4 File Offset: 0x000C43B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193237, RefRangeEnd = 193238, XrefRangeStart = 193224, XrefRangeEnd = 193237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string WindowsDriveAdjustment(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_WindowsDriveAdjustment_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x000C61F0 File Offset: 0x000C43F0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 193315, RefRangeEnd = 193326, XrefRangeStart = 193238, XrefRangeEnd = 193315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InsecureGetFullPath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_InsecureGetFullPath_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x000C622C File Offset: 0x000C442C
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 193330, RefRangeEnd = 193356, XrefRangeStart = 193326, XrefRangeEnd = 193330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDirectorySeparator(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_IsDirectorySeparator_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x000C626C File Offset: 0x000C446C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193397, RefRangeEnd = 193400, XrefRangeStart = 193356, XrefRangeEnd = 193397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPathRoot(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetPathRoot_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x000C62A8 File Offset: 0x000C44A8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 193414, RefRangeEnd = 193420, XrefRangeStart = 193400, XrefRangeEnd = 193414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPathRooted(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_IsPathRooted_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x000C62EC File Offset: 0x000C44EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193420, XrefRangeEnd = 193426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> GetInvalidFileNameChars()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetInvalidFileNameChars_Public_Static_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x000C6320 File Offset: 0x000C4520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193426, XrefRangeEnd = 193432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> GetInvalidPathChars()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetInvalidPathChars_Public_Static_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x000C6354 File Offset: 0x000C4554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193432, XrefRangeEnd = 193438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int findExtension(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_findExtension_Private_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x000C6398 File Offset: 0x000C4598
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193463, RefRangeEnd = 193465, XrefRangeStart = 193438, XrefRangeEnd = 193463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetServerAndShare(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetServerAndShare_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x000C63D4 File Offset: 0x000C45D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193486, RefRangeEnd = 193488, XrefRangeStart = 193465, XrefRangeEnd = 193486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SameRoot(string root, string path)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_SameRoot_Private_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x000C6428 File Offset: 0x000C4628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193571, RefRangeEnd = 193572, XrefRangeStart = 193488, XrefRangeEnd = 193571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CanonicalizePath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_CanonicalizePath_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x000C6464 File Offset: 0x000C4664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193626, RefRangeEnd = 193627, XrefRangeStart = 193572, XrefRangeEnd = 193626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Combine([Optional] Il2CppStringArray paths)
		{
			if (paths == null)
			{
				paths = new Il2CppStringArray(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paths);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Combine_Public_Static_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x000C64B0 File Offset: 0x000C46B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193665, RefRangeEnd = 193666, XrefRangeStart = 193627, XrefRangeEnd = 193665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Combine(string path1, string path2, string path3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Combine_Public_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x000C6510 File Offset: 0x000C4710
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 193672, RefRangeEnd = 193676, XrefRangeStart = 193666, XrefRangeEnd = 193672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Validate(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Validate_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x000C6548 File Offset: 0x000C4748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193683, RefRangeEnd = 193684, XrefRangeStart = 193676, XrefRangeEnd = 193683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Validate(string path, string parameterName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Validate_Internal_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060023DD RID: 9181 RVA: 0x000C6590 File Offset: 0x000C4790
		public unsafe static string DirectorySeparatorCharAsString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193684, XrefRangeEnd = 193688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_get_DirectorySeparatorCharAsString_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060023DE RID: 9182 RVA: 0x000C65BC File Offset: 0x000C47BC
		public unsafe static Il2CppStructArray<char> TrimEndChars
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193688, XrefRangeEnd = 193692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_get_TrimEndChars_Internal_Static_get_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x000C65F0 File Offset: 0x000C47F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193710, RefRangeEnd = 193711, XrefRangeStart = 193692, XrefRangeEnd = 193710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckSearchPattern(string searchPattern)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_CheckSearchPattern_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x000C6628 File Offset: 0x000C4828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193716, RefRangeEnd = 193718, XrefRangeStart = 193711, XrefRangeEnd = 193716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckInvalidPathChars(string path, bool checkAdditional = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkAdditional;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_CheckInvalidPathChars_Internal_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x000C666C File Offset: 0x000C486C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 193738, RefRangeEnd = 193746, XrefRangeStart = 193718, XrefRangeEnd = 193738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalCombine(string path1, string path2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_InternalCombine_Internal_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		public static string Combine(params string[] paths)
		{
			return Path.Combine(new Il2CppStringArray(paths));
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x0000BEED File Offset: 0x0000A0ED
		public Path(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x000C66BC File Offset: 0x000C48BC
		// (set) Token: 0x060023E5 RID: 9189 RVA: 0x0000BEF6 File Offset: 0x0000A0F6
		public unsafe static Il2CppStructArray<char> InvalidPathChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_InvalidPathChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_InvalidPathChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x000C66E4 File Offset: 0x000C48E4
		// (set) Token: 0x060023E7 RID: 9191 RVA: 0x0000BF08 File Offset: 0x0000A108
		public unsafe static char AltDirectorySeparatorChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_AltDirectorySeparatorChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_AltDirectorySeparatorChar, (void*)(&value));
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060023E8 RID: 9192 RVA: 0x000C6700 File Offset: 0x000C4900
		// (set) Token: 0x060023E9 RID: 9193 RVA: 0x0000BF16 File Offset: 0x0000A116
		public unsafe static char DirectorySeparatorChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_DirectorySeparatorChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_DirectorySeparatorChar, (void*)(&value));
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x000C671C File Offset: 0x000C491C
		// (set) Token: 0x060023EB RID: 9195 RVA: 0x0000BF24 File Offset: 0x0000A124
		public unsafe static char PathSeparator
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_PathSeparator, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_PathSeparator, (void*)(&value));
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x000C6738 File Offset: 0x000C4938
		// (set) Token: 0x060023ED RID: 9197 RVA: 0x0000BF32 File Offset: 0x0000A132
		public unsafe static string DirectorySeparatorStr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_DirectorySeparatorStr, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_DirectorySeparatorStr, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x000C6758 File Offset: 0x000C4958
		// (set) Token: 0x060023EF RID: 9199 RVA: 0x0000BF44 File Offset: 0x0000A144
		public unsafe static char VolumeSeparatorChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_VolumeSeparatorChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_VolumeSeparatorChar, (void*)(&value));
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060023F0 RID: 9200 RVA: 0x000C6774 File Offset: 0x000C4974
		// (set) Token: 0x060023F1 RID: 9201 RVA: 0x0000BF52 File Offset: 0x0000A152
		public unsafe static Il2CppStructArray<char> PathSeparatorChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_PathSeparatorChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_PathSeparatorChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x000C679C File Offset: 0x000C499C
		// (set) Token: 0x060023F3 RID: 9203 RVA: 0x0000BF64 File Offset: 0x0000A164
		public unsafe static bool dirEqualsVolume
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_dirEqualsVolume, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_dirEqualsVolume, (void*)(&value));
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x000C67B8 File Offset: 0x000C49B8
		// (set) Token: 0x060023F5 RID: 9205 RVA: 0x0000BF72 File Offset: 0x0000A172
		public unsafe static Il2CppStructArray<char> trimEndCharsWindows
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_trimEndCharsWindows, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_trimEndCharsWindows, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060023F6 RID: 9206 RVA: 0x000C67E0 File Offset: 0x000C49E0
		// (set) Token: 0x060023F7 RID: 9207 RVA: 0x0000BF84 File Offset: 0x0000A184
		public unsafe static Il2CppStructArray<char> trimEndCharsUnix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_trimEndCharsUnix, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_trimEndCharsUnix, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002033 RID: 8243
		private static readonly IntPtr NativeFieldInfoPtr_InvalidPathChars;

		// Token: 0x04002034 RID: 8244
		private static readonly IntPtr NativeFieldInfoPtr_AltDirectorySeparatorChar;

		// Token: 0x04002035 RID: 8245
		private static readonly IntPtr NativeFieldInfoPtr_DirectorySeparatorChar;

		// Token: 0x04002036 RID: 8246
		private static readonly IntPtr NativeFieldInfoPtr_PathSeparator;

		// Token: 0x04002037 RID: 8247
		private static readonly IntPtr NativeFieldInfoPtr_DirectorySeparatorStr;

		// Token: 0x04002038 RID: 8248
		private static readonly IntPtr NativeFieldInfoPtr_VolumeSeparatorChar;

		// Token: 0x04002039 RID: 8249
		private static readonly IntPtr NativeFieldInfoPtr_PathSeparatorChars;

		// Token: 0x0400203A RID: 8250
		private static readonly IntPtr NativeFieldInfoPtr_dirEqualsVolume;

		// Token: 0x0400203B RID: 8251
		private static readonly IntPtr NativeFieldInfoPtr_trimEndCharsWindows;

		// Token: 0x0400203C RID: 8252
		private static readonly IntPtr NativeFieldInfoPtr_trimEndCharsUnix;

		// Token: 0x0400203D RID: 8253
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_String_String_String_0;

		// Token: 0x0400203E RID: 8254
		private static readonly IntPtr NativeMethodInfoPtr_CleanPath_Internal_Static_String_String_0;

		// Token: 0x0400203F RID: 8255
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectoryName_Public_Static_String_String_0;

		// Token: 0x04002040 RID: 8256
		private static readonly IntPtr NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0;

		// Token: 0x04002041 RID: 8257
		private static readonly IntPtr NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0;

		// Token: 0x04002042 RID: 8258
		private static readonly IntPtr NativeMethodInfoPtr_GetFullPath_Public_Static_String_String_0;

		// Token: 0x04002043 RID: 8259
		private static readonly IntPtr NativeMethodInfoPtr_GetFullPathInternal_Internal_Static_String_String_0;

		// Token: 0x04002044 RID: 8260
		private static readonly IntPtr NativeMethodInfoPtr_GetFullPathName_Private_Static_Int32_String_Int32_StringBuilder_byref_IntPtr_0;

		// Token: 0x04002045 RID: 8261
		private static readonly IntPtr NativeMethodInfoPtr_GetFullPathName_Internal_Static_String_String_0;

		// Token: 0x04002046 RID: 8262
		private static readonly IntPtr NativeMethodInfoPtr_WindowsDriveAdjustment_Internal_Static_String_String_0;

		// Token: 0x04002047 RID: 8263
		private static readonly IntPtr NativeMethodInfoPtr_InsecureGetFullPath_Internal_Static_String_String_0;

		// Token: 0x04002048 RID: 8264
		private static readonly IntPtr NativeMethodInfoPtr_IsDirectorySeparator_Internal_Static_Boolean_Char_0;

		// Token: 0x04002049 RID: 8265
		private static readonly IntPtr NativeMethodInfoPtr_GetPathRoot_Public_Static_String_String_0;

		// Token: 0x0400204A RID: 8266
		private static readonly IntPtr NativeMethodInfoPtr_IsPathRooted_Public_Static_Boolean_String_0;

		// Token: 0x0400204B RID: 8267
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalidFileNameChars_Public_Static_Il2CppStructArray_1_Char_0;

		// Token: 0x0400204C RID: 8268
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalidPathChars_Public_Static_Il2CppStructArray_1_Char_0;

		// Token: 0x0400204D RID: 8269
		private static readonly IntPtr NativeMethodInfoPtr_findExtension_Private_Static_Int32_String_0;

		// Token: 0x0400204E RID: 8270
		private static readonly IntPtr NativeMethodInfoPtr_GetServerAndShare_Private_Static_String_String_0;

		// Token: 0x0400204F RID: 8271
		private static readonly IntPtr NativeMethodInfoPtr_SameRoot_Private_Static_Boolean_String_String_0;

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeMethodInfoPtr_CanonicalizePath_Private_Static_String_String_0;

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_String_Il2CppStringArray_0;

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_String_String_String_String_0;

		// Token: 0x04002053 RID: 8275
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Static_Void_String_0;

		// Token: 0x04002054 RID: 8276
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Static_Void_String_String_0;

		// Token: 0x04002055 RID: 8277
		private static readonly IntPtr NativeMethodInfoPtr_get_DirectorySeparatorCharAsString_Internal_Static_get_String_0;

		// Token: 0x04002056 RID: 8278
		private static readonly IntPtr NativeMethodInfoPtr_get_TrimEndChars_Internal_Static_get_Il2CppStructArray_1_Char_0;

		// Token: 0x04002057 RID: 8279
		private static readonly IntPtr NativeMethodInfoPtr_CheckSearchPattern_Internal_Static_Void_String_0;

		// Token: 0x04002058 RID: 8280
		private static readonly IntPtr NativeMethodInfoPtr_CheckInvalidPathChars_Internal_Static_Void_String_Boolean_0;

		// Token: 0x04002059 RID: 8281
		private static readonly IntPtr NativeMethodInfoPtr_InternalCombine_Internal_Static_String_String_String_0;
	}
}
