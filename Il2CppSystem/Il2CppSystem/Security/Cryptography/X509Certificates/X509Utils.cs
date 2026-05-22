using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000B0 RID: 176
	public class X509Utils : Object
	{
		// Token: 0x0600097A RID: 2426 RVA: 0x00033A1C File Offset: 0x00031C1C
		// Note: this type is marked as 'beforefieldinit'.
		static X509Utils()
		{
			Il2CppClassPointerStore<X509Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Utils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Utils>.NativeClassPtr);
			X509Utils.NativeMethodInfoPtr_FindOidInfo_Internal_Static_String_UInt32_String_OidGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Utils>.NativeClassPtr, 100664630);
			X509Utils.NativeMethodInfoPtr_FindOidInfoWithFallback_Internal_Static_String_UInt32_String_OidGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Utils>.NativeClassPtr, 100664631);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00033A74 File Offset: 0x00031C74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 373572, RefRangeEnd = 373574, XrefRangeStart = 373570, XrefRangeEnd = 373572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FindOidInfo(uint keyType, string keyValue, OidGroup oidGroup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oidGroup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Utils.NativeMethodInfoPtr_FindOidInfo_Internal_Static_String_UInt32_String_OidGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00033ACC File Offset: 0x00031CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373574, XrefRangeEnd = 373576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FindOidInfoWithFallback(uint key, string value, OidGroup group)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref group;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Utils.NativeMethodInfoPtr_FindOidInfoWithFallback_Internal_Static_String_UInt32_String_OidGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00005D70 File Offset: 0x00003F70
		public X509Utils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_FindOidInfo_Internal_Static_String_UInt32_String_OidGroup_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_FindOidInfoWithFallback_Internal_Static_String_UInt32_String_OidGroup_0;
	}
}
