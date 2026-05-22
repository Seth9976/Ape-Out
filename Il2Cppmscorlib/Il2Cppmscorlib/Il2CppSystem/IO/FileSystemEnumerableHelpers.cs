using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMicrosoft.Win32;

namespace Il2CppSystem.IO
{
	// Token: 0x02000207 RID: 519
	public static class FileSystemEnumerableHelpers : Object
	{
		// Token: 0x0600216C RID: 8556 RVA: 0x000BB1C4 File Offset: 0x000B93C4
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemEnumerableHelpers()
		{
			Il2CppClassPointerStore<FileSystemEnumerableHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileSystemEnumerableHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEnumerableHelpers>.NativeClassPtr);
			FileSystemEnumerableHelpers.NativeMethodInfoPtr_IsDir_Internal_Static_Boolean_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableHelpers>.NativeClassPtr, 100668913);
			FileSystemEnumerableHelpers.NativeMethodInfoPtr_IsFile_Internal_Static_Boolean_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableHelpers>.NativeClassPtr, 100668914);
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x000BB21C File Offset: 0x000B941C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190529, RefRangeEnd = 190530, XrefRangeStart = 190525, XrefRangeEnd = 190529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDir(Win32Native.WIN32_FIND_DATA data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableHelpers.NativeMethodInfoPtr_IsDir_Internal_Static_Boolean_WIN32_FIND_DATA_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x000BB260 File Offset: 0x000B9460
		[CallerCount(0)]
		public unsafe static bool IsFile(Win32Native.WIN32_FIND_DATA data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableHelpers.NativeMethodInfoPtr_IsFile_Internal_Static_Boolean_WIN32_FIND_DATA_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x0000B2C3 File Offset: 0x000094C3
		public FileSystemEnumerableHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001E1C RID: 7708
		private static readonly IntPtr NativeMethodInfoPtr_IsDir_Internal_Static_Boolean_WIN32_FIND_DATA_0;

		// Token: 0x04001E1D RID: 7709
		private static readonly IntPtr NativeMethodInfoPtr_IsFile_Internal_Static_Boolean_WIN32_FIND_DATA_0;
	}
}
