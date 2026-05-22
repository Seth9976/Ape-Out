using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x020001F7 RID: 503
	public static class __Error : Object
	{
		// Token: 0x06002061 RID: 8289 RVA: 0x000B6C4C File Offset: 0x000B4E4C
		// Note: this type is marked as 'beforefieldinit'.
		static __Error()
		{
			Il2CppClassPointerStore<__Error>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "__Error");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__Error>.NativeClassPtr);
			__Error.NativeMethodInfoPtr_EndOfFile_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668762);
			__Error.NativeMethodInfoPtr_FileNotOpen_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668763);
			__Error.NativeMethodInfoPtr_StreamIsClosed_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668764);
			__Error.NativeMethodInfoPtr_MemoryStreamNotExpandable_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668765);
			__Error.NativeMethodInfoPtr_ReaderClosed_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668766);
			__Error.NativeMethodInfoPtr_ReadNotSupported_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668767);
			__Error.NativeMethodInfoPtr_WrongAsyncResult_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668768);
			__Error.NativeMethodInfoPtr_EndReadCalledTwice_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668769);
			__Error.NativeMethodInfoPtr_EndWriteCalledTwice_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668770);
			__Error.NativeMethodInfoPtr_GetDisplayablePath_Internal_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668771);
			__Error.NativeMethodInfoPtr_WinIOError_Internal_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668772);
			__Error.NativeMethodInfoPtr_WriteNotSupported_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668773);
			__Error.NativeMethodInfoPtr_WriterClosed_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100668774);
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x000B6D80 File Offset: 0x000B4F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189410, XrefRangeEnd = 189417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndOfFile()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_EndOfFile_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x000B6DA8 File Offset: 0x000B4FA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189424, RefRangeEnd = 189426, XrefRangeStart = 189417, XrefRangeEnd = 189424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FileNotOpen()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_FileNotOpen_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x000B6DD0 File Offset: 0x000B4FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189426, XrefRangeEnd = 189433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StreamIsClosed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_StreamIsClosed_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000B6DF8 File Offset: 0x000B4FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189433, XrefRangeEnd = 189440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemoryStreamNotExpandable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_MemoryStreamNotExpandable_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x000B6E20 File Offset: 0x000B5020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189447, RefRangeEnd = 189448, XrefRangeStart = 189440, XrefRangeEnd = 189447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReaderClosed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_ReaderClosed_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000B6E48 File Offset: 0x000B5048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189455, RefRangeEnd = 189456, XrefRangeStart = 189448, XrefRangeEnd = 189455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReadNotSupported()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_ReadNotSupported_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x000B6E70 File Offset: 0x000B5070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189456, XrefRangeEnd = 189463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WrongAsyncResult()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_WrongAsyncResult_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x000B6E98 File Offset: 0x000B5098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189463, XrefRangeEnd = 189470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndReadCalledTwice()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_EndReadCalledTwice_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x000B6EC0 File Offset: 0x000B50C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189470, XrefRangeEnd = 189477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndWriteCalledTwice()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_EndWriteCalledTwice_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x000B6EE8 File Offset: 0x000B50E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189487, RefRangeEnd = 189489, XrefRangeStart = 189477, XrefRangeEnd = 189487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDisplayablePath(string path, bool isInvalidPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInvalidPath;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_GetDisplayablePath_Internal_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x000B6F34 File Offset: 0x000B5134
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189634, RefRangeEnd = 189636, XrefRangeStart = 189489, XrefRangeEnd = 189634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WinIOError(int errorCode, string maybeFullPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(maybeFullPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_WinIOError_Internal_Static_Void_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x000B6F78 File Offset: 0x000B5178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189643, RefRangeEnd = 189644, XrefRangeStart = 189636, XrefRangeEnd = 189643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteNotSupported()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_WriteNotSupported_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x000B6FA0 File Offset: 0x000B51A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189651, RefRangeEnd = 189653, XrefRangeStart = 189644, XrefRangeEnd = 189651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriterClosed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Error.NativeMethodInfoPtr_WriterClosed_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x0000AD29 File Offset: 0x00008F29
		public __Error(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D5C RID: 7516
		private static readonly IntPtr NativeMethodInfoPtr_EndOfFile_Internal_Static_Void_0;

		// Token: 0x04001D5D RID: 7517
		private static readonly IntPtr NativeMethodInfoPtr_FileNotOpen_Internal_Static_Void_0;

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeMethodInfoPtr_StreamIsClosed_Internal_Static_Void_0;

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeMethodInfoPtr_MemoryStreamNotExpandable_Internal_Static_Void_0;

		// Token: 0x04001D60 RID: 7520
		private static readonly IntPtr NativeMethodInfoPtr_ReaderClosed_Internal_Static_Void_0;

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeMethodInfoPtr_ReadNotSupported_Internal_Static_Void_0;

		// Token: 0x04001D62 RID: 7522
		private static readonly IntPtr NativeMethodInfoPtr_WrongAsyncResult_Internal_Static_Void_0;

		// Token: 0x04001D63 RID: 7523
		private static readonly IntPtr NativeMethodInfoPtr_EndReadCalledTwice_Internal_Static_Void_0;

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeMethodInfoPtr_EndWriteCalledTwice_Internal_Static_Void_0;

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayablePath_Internal_Static_String_String_Boolean_0;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeMethodInfoPtr_WinIOError_Internal_Static_Void_Int32_String_0;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeMethodInfoPtr_WriteNotSupported_Internal_Static_Void_0;

		// Token: 0x04001D68 RID: 7528
		private static readonly IntPtr NativeMethodInfoPtr_WriterClosed_Internal_Static_Void_0;
	}
}
