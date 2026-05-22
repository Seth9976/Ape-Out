using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x02000128 RID: 296
	public static class Dns : Object
	{
		// Token: 0x06001087 RID: 4231 RVA: 0x0004E99C File Offset: 0x0004CB9C
		// Note: this type is marked as 'beforefieldinit'.
		static Dns()
		{
			Il2CppClassPointerStore<Dns>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "Dns");
			Dns.NativeMethodInfoPtr_GetHostByName_internal_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665652);
			Dns.NativeMethodInfoPtr_GetHostByAddr_internal_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665653);
			Dns.NativeMethodInfoPtr_GetHostName_internal_Private_Static_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665654);
			Dns.NativeMethodInfoPtr_Error_11001_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665655);
			Dns.NativeMethodInfoPtr_hostent_to_IPHostEntry_Private_Static_IPHostEntry_String_String_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665656);
			Dns.NativeMethodInfoPtr_GetHostByAddressFromString_Private_Static_IPHostEntry_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665657);
			Dns.NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665658);
			Dns.NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665659);
			Dns.NativeMethodInfoPtr_GetHostAddresses_Public_Static_Il2CppReferenceArray_1_IPAddress_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665660);
			Dns.NativeMethodInfoPtr_GetHostByName_Public_Static_IPHostEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665661);
			Dns.NativeMethodInfoPtr_GetHostName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100665662);
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0004EAA0 File Offset: 0x0004CCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380664, XrefRangeEnd = 380665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHostByName_internal(string host, out string h_name, out Il2CppStringArray h_aliases, out Il2CppStringArray h_addr_list, int hint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hint;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostByName_internal_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			h_name = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr6 = intPtr2;
			h_aliases = ((intPtr6 == 0) ? null : new Il2CppStringArray(intPtr6));
			IntPtr intPtr7 = intPtr3;
			h_addr_list = ((intPtr7 == 0) ? null : new Il2CppStringArray(intPtr7));
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0004EB50 File Offset: 0x0004CD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380665, XrefRangeEnd = 380666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHostByAddr_internal(string addr, out string h_name, out Il2CppStringArray h_aliases, out Il2CppStringArray h_addr_list, int hint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(addr);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hint;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostByAddr_internal_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			h_name = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr6 = intPtr2;
			h_aliases = ((intPtr6 == 0) ? null : new Il2CppStringArray(intPtr6));
			IntPtr intPtr7 = intPtr3;
			h_addr_list = ((intPtr7 == 0) ? null : new Il2CppStringArray(intPtr7));
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0004EC00 File Offset: 0x0004CE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380666, XrefRangeEnd = 380669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHostName_internal(out string h_name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostName_internal_Private_Static_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				h_name = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0004EC4C File Offset: 0x0004CE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380669, XrefRangeEnd = 380676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Error_11001(string hostName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_Error_11001_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0004EC84 File Offset: 0x0004CE84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380706, RefRangeEnd = 380708, XrefRangeStart = 380676, XrefRangeEnd = 380706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, Il2CppStringArray h_aliases, Il2CppStringArray h_addrlist)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(originalHostName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(h_name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(h_aliases);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(h_addrlist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_hostent_to_IPHostEntry_Private_Static_IPHostEntry_String_String_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0004ED00 File Offset: 0x0004CF00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380730, RefRangeEnd = 380732, XrefRangeStart = 380708, XrefRangeEnd = 380730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry GetHostByAddressFromString(string address, bool parse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostByAddressFromString_Private_Static_IPHostEntry_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x0004ED54 File Offset: 0x0004CF54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 380741, RefRangeEnd = 380744, XrefRangeStart = 380732, XrefRangeEnd = 380741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry GetHostEntry(string hostNameOrAddress)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostNameOrAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
			}
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0004ED98 File Offset: 0x0004CF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380744, XrefRangeEnd = 380751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry GetHostEntry(IPAddress address)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_IPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0004EDDC File Offset: 0x0004CFDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380765, RefRangeEnd = 380767, XrefRangeStart = 380751, XrefRangeEnd = 380765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<IPAddress> GetHostAddresses(string hostNameOrAddress)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostNameOrAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostAddresses_Public_Static_Il2CppReferenceArray_1_IPAddress_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr3) : null;
			}
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0004EE20 File Offset: 0x0004D020
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380773, RefRangeEnd = 380775, XrefRangeStart = 380767, XrefRangeEnd = 380773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry GetHostByName(string hostName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostByName_Public_Static_IPHostEntry_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0004EE64 File Offset: 0x0004D064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380775, XrefRangeEnd = 380779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetHostName()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dns.NativeMethodInfoPtr_GetHostName_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0000886E File Offset: 0x00006A6E
		public Dns(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeMethodInfoPtr_GetHostByName_internal_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeMethodInfoPtr_GetHostByAddr_internal_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeMethodInfoPtr_GetHostName_internal_Private_Static_Boolean_byref_String_0;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeMethodInfoPtr_Error_11001_Private_Static_Void_String_0;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeMethodInfoPtr_hostent_to_IPHostEntry_Private_Static_IPHostEntry_String_String_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr_GetHostByAddressFromString_Private_Static_IPHostEntry_String_Boolean_0;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_String_0;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_IPAddress_0;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeMethodInfoPtr_GetHostAddresses_Public_Static_Il2CppReferenceArray_1_IPAddress_String_0;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeMethodInfoPtr_GetHostByName_Public_Static_IPHostEntry_String_0;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeMethodInfoPtr_GetHostName_Public_Static_String_0;
	}
}
