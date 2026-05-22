using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200001D RID: 29
	public static class SteamEncryptedAppTicket : Object
	{
		// Token: 0x06000135 RID: 309 RVA: 0x00011B84 File Offset: 0x0000FD84
		// Note: this type is marked as 'beforefieldinit'.
		static SteamEncryptedAppTicket()
		{
			Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamEncryptedAppTicket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_BDecryptTicket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_Il2CppStructArray_1_Byte_byref_UInt32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100663535);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_BIsTicketForApp_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100663536);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_GetTicketIssueTime_Public_Static_UInt32_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100663537);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_GetTicketSteamID_Public_Static_Void_Il2CppStructArray_1_Byte_UInt32_byref_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100663538);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_GetTicketAppID_Public_Static_UInt32_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100663539);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_BUserOwnsAppInTicket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100663540);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_BUserIsVacBanned_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100663541);
			SteamEncryptedAppTicket.NativeMethodInfoPtr_GetUserVariableData_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamEncryptedAppTicket>.NativeClassPtr, 100663542);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00011C54 File Offset: 0x0000FE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2999, XrefRangeEnd = 3001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BDecryptTicket(Il2CppStructArray<byte> rgubTicketEncrypted, uint cubTicketEncrypted, Il2CppStructArray<byte> rgubTicketDecrypted, ref uint pcubTicketDecrypted, Il2CppStructArray<byte> rgubKey, int cubKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketEncrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketEncrypted;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcubTicketDecrypted;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgubKey);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_BDecryptTicket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_Il2CppStructArray_1_Byte_byref_UInt32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00011CE4 File Offset: 0x0000FEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3001, XrefRangeEnd = 3003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsTicketForApp(Il2CppStructArray<byte> rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketDecrypted;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAppID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_BIsTicketForApp_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_AppId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00011D44 File Offset: 0x0000FF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3003, XrefRangeEnd = 3005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetTicketIssueTime(Il2CppStructArray<byte> rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketDecrypted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_GetTicketIssueTime_Public_Static_UInt32_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00011D94 File Offset: 0x0000FF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3005, XrefRangeEnd = 3007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetTicketSteamID(Il2CppStructArray<byte> rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketDecrypted;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &psteamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_GetTicketSteamID_Public_Static_Void_Il2CppStructArray_1_Byte_UInt32_byref_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00011DE8 File Offset: 0x0000FFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3007, XrefRangeEnd = 3009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetTicketAppID(Il2CppStructArray<byte> rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketDecrypted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_GetTicketAppID_Public_Static_UInt32_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00011E38 File Offset: 0x00010038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3009, XrefRangeEnd = 3011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BUserOwnsAppInTicket(Il2CppStructArray<byte> rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketDecrypted;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAppID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_BUserOwnsAppInTicket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_AppId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00011E98 File Offset: 0x00010098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3011, XrefRangeEnd = 3013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BUserIsVacBanned(Il2CppStructArray<byte> rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketDecrypted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_BUserIsVacBanned_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00011EE8 File Offset: 0x000100E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3013, XrefRangeEnd = 3022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetUserVariableData(Il2CppStructArray<byte> rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgubTicketDecrypted);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubTicketDecrypted;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcubUserData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamEncryptedAppTicket.NativeMethodInfoPtr_GetUserVariableData_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000028B3 File Offset: 0x00000AB3
		public SteamEncryptedAppTicket(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_BDecryptTicket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_Il2CppStructArray_1_Byte_byref_UInt32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_BIsTicketForApp_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_AppId_t_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_GetTicketIssueTime_Public_Static_UInt32_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_GetTicketSteamID_Public_Static_Void_Il2CppStructArray_1_Byte_UInt32_byref_CSteamID_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_GetTicketAppID_Public_Static_UInt32_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_BUserOwnsAppInTicket_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_AppId_t_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_BUserIsVacBanned_Public_Static_Boolean_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_GetUserVariableData_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_0;
	}
}
