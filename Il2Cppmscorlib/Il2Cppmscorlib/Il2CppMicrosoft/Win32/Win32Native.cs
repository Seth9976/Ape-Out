using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x02000049 RID: 73
	public static class Win32Native : Object
	{
		// Token: 0x060004C3 RID: 1219 RVA: 0x0003573C File Offset: 0x0003393C
		// Note: this type is marked as 'beforefieldinit'.
		static Win32Native()
		{
			Il2CppClassPointerStore<Win32Native>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "Win32Native");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32Native>.NativeClassPtr);
			Win32Native.NativeMethodInfoPtr_GetMessage_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Native>.NativeClassPtr, 100663994);
			Win32Native.NativeMethodInfoPtr_MakeHRFromErrorCode_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Native>.NativeClassPtr, 100663995);
			Win32Native.NativeMethodInfoPtr_GetCurrentProcessId_Internal_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Native>.NativeClassPtr, 100663996);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000357A8 File Offset: 0x000339A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138539, RefRangeEnd = 138541, XrefRangeStart = 138530, XrefRangeEnd = 138539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessage(int hr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Native.NativeMethodInfoPtr_GetMessage_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000357E0 File Offset: 0x000339E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 138541, RefRangeEnd = 138547, XrefRangeStart = 138541, XrefRangeEnd = 138541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int MakeHRFromErrorCode(int errorCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Native.NativeMethodInfoPtr_MakeHRFromErrorCode_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00035820 File Offset: 0x00033A20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138550, RefRangeEnd = 138552, XrefRangeStart = 138547, XrefRangeEnd = 138550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetCurrentProcessId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Native.NativeMethodInfoPtr_GetCurrentProcessId_Internal_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00003D93 File Offset: 0x00001F93
		public Win32Native(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_GetMessage_Public_Static_String_Int32_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_MakeHRFromErrorCode_Public_Static_Int32_Int32_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentProcessId_Internal_Static_UInt32_0;

		// Token: 0x0200054D RID: 1357
		public class WIN32_FIND_DATA : Object
		{
			// Token: 0x06004FD1 RID: 20433 RVA: 0x0016AE4C File Offset: 0x0016904C
			// Note: this type is marked as 'beforefieldinit'.
			static WIN32_FIND_DATA()
			{
				Il2CppClassPointerStore<Win32Native.WIN32_FIND_DATA>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Win32Native>.NativeClassPtr, "WIN32_FIND_DATA");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32Native.WIN32_FIND_DATA>.NativeClassPtr);
				Win32Native.WIN32_FIND_DATA.NativeFieldInfoPtr_dwFileAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32Native.WIN32_FIND_DATA>.NativeClassPtr, "dwFileAttributes");
				Win32Native.WIN32_FIND_DATA.NativeFieldInfoPtr_cFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32Native.WIN32_FIND_DATA>.NativeClassPtr, "cFileName");
				Win32Native.WIN32_FIND_DATA.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32Native.WIN32_FIND_DATA>.NativeClassPtr, 100663997);
			}

			// Token: 0x06004FD2 RID: 20434 RVA: 0x0016AEB4 File Offset: 0x001690B4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WIN32_FIND_DATA()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32Native.WIN32_FIND_DATA>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32Native.WIN32_FIND_DATA.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FD3 RID: 20435 RVA: 0x0001DE4B File Offset: 0x0001C04B
			public WIN32_FIND_DATA(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700146A RID: 5226
			// (get) Token: 0x06004FD4 RID: 20436 RVA: 0x0016AEF0 File Offset: 0x001690F0
			// (set) Token: 0x06004FD5 RID: 20437 RVA: 0x0001DE54 File Offset: 0x0001C054
			public unsafe int dwFileAttributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32Native.WIN32_FIND_DATA.NativeFieldInfoPtr_dwFileAttributes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32Native.WIN32_FIND_DATA.NativeFieldInfoPtr_dwFileAttributes)) = value;
				}
			}

			// Token: 0x1700146B RID: 5227
			// (get) Token: 0x06004FD6 RID: 20438 RVA: 0x0016AF18 File Offset: 0x00169118
			// (set) Token: 0x06004FD7 RID: 20439 RVA: 0x0001DE6F File Offset: 0x0001C06F
			public unsafe string cFileName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32Native.WIN32_FIND_DATA.NativeFieldInfoPtr_cFileName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32Native.WIN32_FIND_DATA.NativeFieldInfoPtr_cFileName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04004070 RID: 16496
			private static readonly IntPtr NativeFieldInfoPtr_dwFileAttributes;

			// Token: 0x04004071 RID: 16497
			private static readonly IntPtr NativeFieldInfoPtr_cFileName;

			// Token: 0x04004072 RID: 16498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
