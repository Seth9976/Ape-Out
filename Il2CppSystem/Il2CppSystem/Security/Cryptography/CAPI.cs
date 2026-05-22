using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020000A6 RID: 166
	public static class CAPI : Object
	{
		// Token: 0x06000962 RID: 2402 RVA: 0x0003337C File Offset: 0x0003157C
		// Note: this type is marked as 'beforefieldinit'.
		static CAPI()
		{
			Il2CppClassPointerStore<CAPI>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography", "CAPI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CAPI>.NativeClassPtr);
			CAPI.NativeMethodInfoPtr_CryptFindOIDInfoNameFromKey_Public_Static_String_String_OidGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CAPI>.NativeClassPtr, 100664614);
			CAPI.NativeMethodInfoPtr_CryptFindOIDInfoKeyFromName_Public_Static_String_String_OidGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CAPI>.NativeClassPtr, 100664615);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x000333D4 File Offset: 0x000315D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 373254, RefRangeEnd = 373257, XrefRangeStart = 373183, XrefRangeEnd = 373254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CryptFindOIDInfoNameFromKey(string key, OidGroup oidGroup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oidGroup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CAPI.NativeMethodInfoPtr_CryptFindOIDInfoNameFromKey_Public_Static_String_String_OidGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00033420 File Offset: 0x00031620
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 373325, RefRangeEnd = 373327, XrefRangeStart = 373257, XrefRangeEnd = 373325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CryptFindOIDInfoKeyFromName(string name, OidGroup oidGroup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oidGroup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CAPI.NativeMethodInfoPtr_CryptFindOIDInfoKeyFromName_Public_Static_String_String_OidGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00005D20 File Offset: 0x00003F20
		public CAPI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_CryptFindOIDInfoNameFromKey_Public_Static_String_String_OidGroup_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_CryptFindOIDInfoKeyFromName_Public_Static_String_String_OidGroup_0;
	}
}
