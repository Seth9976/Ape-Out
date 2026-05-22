using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security;

namespace Il2CppSystem.Net
{
	// Token: 0x0200011D RID: 285
	public static class UnsafeNclNativeMethods : Object
	{
		// Token: 0x0600101D RID: 4125 RVA: 0x000085AB File Offset: 0x000067AB
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeNclNativeMethods()
		{
			Il2CppClassPointerStore<UnsafeNclNativeMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "UnsafeNclNativeMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNclNativeMethods>.NativeClassPtr);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x000085D0 File Offset: 0x000067D0
		public UnsafeNclNativeMethods(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x020001DE RID: 478
		public static class HttpApi : Object
		{
			// Token: 0x06001A43 RID: 6723 RVA: 0x0000D7A9 File Offset: 0x0000B9A9
			// Note: this type is marked as 'beforefieldinit'.
			static HttpApi()
			{
				Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNclNativeMethods>.NativeClassPtr, "HttpApi");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi>.NativeClassPtr);
				UnsafeNclNativeMethods.HttpApi.NativeFieldInfoPtr_m_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi>.NativeClassPtr, "m_Strings");
			}

			// Token: 0x06001A44 RID: 6724 RVA: 0x0000D7DD File Offset: 0x0000B9DD
			public HttpApi(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700085B RID: 2139
			// (get) Token: 0x06001A45 RID: 6725 RVA: 0x00070000 File Offset: 0x0006E200
			// (set) Token: 0x06001A46 RID: 6726 RVA: 0x0000D7E6 File Offset: 0x0000B9E6
			public unsafe static Il2CppStringArray m_Strings
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnsafeNclNativeMethods.HttpApi.NativeFieldInfoPtr_m_Strings, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnsafeNclNativeMethods.HttpApi.NativeFieldInfoPtr_m_Strings, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014A0 RID: 5280
			private static readonly IntPtr NativeFieldInfoPtr_m_Strings;

			// Token: 0x0200023E RID: 574
			public static class HTTP_REQUEST_HEADER_ID : Object
			{
				// Token: 0x06001E66 RID: 7782 RVA: 0x0007C0F4 File Offset: 0x0007A2F4
				// Note: this type is marked as 'beforefieldinit'.
				static HTTP_REQUEST_HEADER_ID()
				{
					Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi>.NativeClassPtr, "HTTP_REQUEST_HEADER_ID");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID>.NativeClassPtr);
					UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.NativeFieldInfoPtr_m_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID>.NativeClassPtr, "m_Strings");
					UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID>.NativeClassPtr, 100665596);
				}

				// Token: 0x06001E67 RID: 7783 RVA: 0x0007C148 File Offset: 0x0007A348
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380007, XrefRangeEnd = 380011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string ToString(int position)
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref position;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x06001E68 RID: 7784 RVA: 0x000105D2 File Offset: 0x0000E7D2
				public HTTP_REQUEST_HEADER_ID(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000989 RID: 2441
				// (get) Token: 0x06001E69 RID: 7785 RVA: 0x0007C180 File Offset: 0x0007A380
				// (set) Token: 0x06001E6A RID: 7786 RVA: 0x000105DB File Offset: 0x0000E7DB
				public unsafe static Il2CppStringArray m_Strings
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.NativeFieldInfoPtr_m_Strings, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.NativeFieldInfoPtr_m_Strings, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040016EC RID: 5868
				private static readonly IntPtr NativeFieldInfoPtr_m_Strings;

				// Token: 0x040016ED RID: 5869
				private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0;
			}
		}

		// Token: 0x020001DF RID: 479
		public static class SecureStringHelper : Object
		{
			// Token: 0x06001A47 RID: 6727 RVA: 0x00070028 File Offset: 0x0006E228
			// Note: this type is marked as 'beforefieldinit'.
			static SecureStringHelper()
			{
				Il2CppClassPointerStore<UnsafeNclNativeMethods.SecureStringHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNclNativeMethods>.NativeClassPtr, "SecureStringHelper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNclNativeMethods.SecureStringHelper>.NativeClassPtr);
				UnsafeNclNativeMethods.SecureStringHelper.NativeMethodInfoPtr_CreateString_Internal_Static_String_SecureString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNclNativeMethods.SecureStringHelper>.NativeClassPtr, 100665598);
				UnsafeNclNativeMethods.SecureStringHelper.NativeMethodInfoPtr_CreateSecureString_Internal_Static_SecureString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNclNativeMethods.SecureStringHelper>.NativeClassPtr, 100665599);
			}

			// Token: 0x06001A48 RID: 6728 RVA: 0x0007007C File Offset: 0x0006E27C
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 380044, RefRangeEnd = 380054, XrefRangeStart = 380011, XrefRangeEnd = 380044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string CreateString(SecureString secureString)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(secureString);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNclNativeMethods.SecureStringHelper.NativeMethodInfoPtr_CreateString_Internal_Static_String_SecureString_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001A49 RID: 6729 RVA: 0x000700B8 File Offset: 0x0006E2B8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 380058, RefRangeEnd = 380060, XrefRangeStart = 380054, XrefRangeEnd = 380058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static SecureString CreateSecureString(string plainString)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(plainString);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNclNativeMethods.SecureStringHelper.NativeMethodInfoPtr_CreateSecureString_Internal_Static_SecureString_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecureString>(intPtr3) : null;
				}
			}

			// Token: 0x06001A4A RID: 6730 RVA: 0x0000D7F8 File Offset: 0x0000B9F8
			public SecureStringHelper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040014A1 RID: 5281
			private static readonly IntPtr NativeMethodInfoPtr_CreateString_Internal_Static_String_SecureString_0;

			// Token: 0x040014A2 RID: 5282
			private static readonly IntPtr NativeMethodInfoPtr_CreateSecureString_Internal_Static_SecureString_String_0;
		}
	}
}
