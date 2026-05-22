using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x02000217 RID: 535
	public static class File : Object
	{
		// Token: 0x06002315 RID: 8981 RVA: 0x000C25A8 File Offset: 0x000C07A8
		// Note: this type is marked as 'beforefieldinit'.
		static File()
		{
			Il2CppClassPointerStore<File>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "File");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<File>.NativeClassPtr);
			File.NativeMethodInfoPtr_Create_Public_Static_FileStream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669256);
			File.NativeMethodInfoPtr_Create_Public_Static_FileStream_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669257);
			File.NativeMethodInfoPtr_CreateText_Public_Static_StreamWriter_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669258);
			File.NativeMethodInfoPtr_Delete_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669259);
			File.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669260);
			File.NativeMethodInfoPtr_Move_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669261);
			File.NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669262);
			File.NativeMethodInfoPtr_OpenRead_Public_Static_FileStream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669263);
			File.NativeMethodInfoPtr_OpenText_Public_Static_StreamReader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669264);
			File.NativeMethodInfoPtr_OpenWrite_Public_Static_FileStream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669265);
			File.NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669266);
			File.NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669267);
			File.NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669268);
			File.NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669269);
			File.NativeMethodInfoPtr_FillAttributeInfo_Internal_Static_Int32_String_byref_MonoIOStat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100669270);
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x000C2704 File Offset: 0x000C0904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192143, XrefRangeEnd = 192147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileStream Create(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Create_Public_Static_FileStream_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr3) : null;
			}
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x000C2748 File Offset: 0x000C0948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192147, XrefRangeEnd = 192151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileStream Create(string path, int bufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Create_Public_Static_FileStream_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr3) : null;
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x000C279C File Offset: 0x000C099C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192151, XrefRangeEnd = 192159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StreamWriter CreateText(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_CreateText_Public_Static_StreamWriter_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StreamWriter>(intPtr3) : null;
			}
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x000C27E0 File Offset: 0x000C09E0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 192174, RefRangeEnd = 192184, XrefRangeStart = 192159, XrefRangeEnd = 192174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Delete(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Delete_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x000C2818 File Offset: 0x000C0A18
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 192198, RefRangeEnd = 192223, XrefRangeStart = 192184, XrefRangeEnd = 192198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Exists(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x000C285C File Offset: 0x000C0A5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192257, RefRangeEnd = 192260, XrefRangeStart = 192223, XrefRangeEnd = 192257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Move(string sourceFileName, string destFileName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceFileName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destFileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Move_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x000C28A4 File Offset: 0x000C0AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192260, XrefRangeEnd = 192264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileStream Open(string path, FileMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr3) : null;
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x000C28F8 File Offset: 0x000C0AF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 192268, RefRangeEnd = 192272, XrefRangeStart = 192264, XrefRangeEnd = 192268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileStream OpenRead(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_OpenRead_Public_Static_FileStream_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr3) : null;
			}
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x000C293C File Offset: 0x000C0B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192272, XrefRangeEnd = 192276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StreamReader OpenText(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_OpenText_Public_Static_StreamReader_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr3) : null;
			}
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x000C2980 File Offset: 0x000C0B80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192280, RefRangeEnd = 192282, XrefRangeStart = 192276, XrefRangeEnd = 192280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileStream OpenWrite(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_OpenWrite_Public_Static_FileStream_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr3) : null;
			}
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x000C29C4 File Offset: 0x000C0BC4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 192290, RefRangeEnd = 192295, XrefRangeStart = 192282, XrefRangeEnd = 192290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadAllText(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x000C2A00 File Offset: 0x000C0C00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192303, RefRangeEnd = 192304, XrefRangeStart = 192295, XrefRangeEnd = 192303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadAllText(string path, Encoding encoding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x000C2A50 File Offset: 0x000C0C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192309, RefRangeEnd = 192310, XrefRangeStart = 192304, XrefRangeEnd = 192309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteAllText(string path, string contents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x000C2A98 File Offset: 0x000C0C98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192318, RefRangeEnd = 192321, XrefRangeStart = 192310, XrefRangeEnd = 192318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteAllText(string path, string contents, Encoding encoding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(contents);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x000C2AF4 File Offset: 0x000C0CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192321, XrefRangeEnd = 192329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FillAttributeInfo(string path, ref MonoIOStat data, bool tryagain, bool returnErrorOnNotFound)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryagain;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnErrorOnNotFound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(File.NativeMethodInfoPtr_FillAttributeInfo_Internal_Static_Int32_String_byref_MonoIOStat_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x0000BBC6 File Offset: 0x00009DC6
		public File(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F54 RID: 8020
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_FileStream_String_0;

		// Token: 0x04001F55 RID: 8021
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_FileStream_String_Int32_0;

		// Token: 0x04001F56 RID: 8022
		private static readonly IntPtr NativeMethodInfoPtr_CreateText_Public_Static_StreamWriter_String_0;

		// Token: 0x04001F57 RID: 8023
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_String_0;

		// Token: 0x04001F58 RID: 8024
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0;

		// Token: 0x04001F59 RID: 8025
		private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Static_Void_String_String_0;

		// Token: 0x04001F5A RID: 8026
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_0;

		// Token: 0x04001F5B RID: 8027
		private static readonly IntPtr NativeMethodInfoPtr_OpenRead_Public_Static_FileStream_String_0;

		// Token: 0x04001F5C RID: 8028
		private static readonly IntPtr NativeMethodInfoPtr_OpenText_Public_Static_StreamReader_String_0;

		// Token: 0x04001F5D RID: 8029
		private static readonly IntPtr NativeMethodInfoPtr_OpenWrite_Public_Static_FileStream_String_0;

		// Token: 0x04001F5E RID: 8030
		private static readonly IntPtr NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0;

		// Token: 0x04001F5F RID: 8031
		private static readonly IntPtr NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_Encoding_0;

		// Token: 0x04001F60 RID: 8032
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_0;

		// Token: 0x04001F61 RID: 8033
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllText_Public_Static_Void_String_String_Encoding_0;

		// Token: 0x04001F62 RID: 8034
		private static readonly IntPtr NativeMethodInfoPtr_FillAttributeInfo_Internal_Static_Int32_String_byref_MonoIOStat_Boolean_Boolean_0;
	}
}
