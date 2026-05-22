using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000159 RID: 345
	[Serializable]
	[StructLayout(2)]
	public struct CSteamID
	{
		// Token: 0x06000E9A RID: 3738 RVA: 0x00048DE8 File Offset: 0x00046FE8
		// Note: this type is marked as 'beforefieldinit'.
		static CSteamID()
		{
			Il2CppClassPointerStore<CSteamID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CSteamID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CSteamID>.NativeClassPtr);
			CSteamID.NativeFieldInfoPtr_Nil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "Nil");
			CSteamID.NativeFieldInfoPtr_OutofDateGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "OutofDateGS");
			CSteamID.NativeFieldInfoPtr_LanModeGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "LanModeGS");
			CSteamID.NativeFieldInfoPtr_NotInitYetGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "NotInitYetGS");
			CSteamID.NativeFieldInfoPtr_NonSteamGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "NonSteamGS");
			CSteamID.NativeFieldInfoPtr_m_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, "m_SteamID");
			CSteamID.NativeMethodInfoPtr__ctor_Public_Void_AccountID_t_EUniverse_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665317);
			CSteamID.NativeMethodInfoPtr__ctor_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665318);
			CSteamID.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665319);
			CSteamID.NativeMethodInfoPtr_Set_Public_Void_AccountID_t_EUniverse_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665320);
			CSteamID.NativeMethodInfoPtr_InstancedSet_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665321);
			CSteamID.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665322);
			CSteamID.NativeMethodInfoPtr_CreateBlankAnonLogon_Public_Void_EUniverse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665323);
			CSteamID.NativeMethodInfoPtr_CreateBlankAnonUserLogon_Public_Void_EUniverse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665324);
			CSteamID.NativeMethodInfoPtr_BBlankAnonAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665325);
			CSteamID.NativeMethodInfoPtr_BGameServerAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665326);
			CSteamID.NativeMethodInfoPtr_BPersistentGameServerAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665327);
			CSteamID.NativeMethodInfoPtr_BAnonGameServerAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665328);
			CSteamID.NativeMethodInfoPtr_BContentServerAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665329);
			CSteamID.NativeMethodInfoPtr_BClanAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665330);
			CSteamID.NativeMethodInfoPtr_BChatAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665331);
			CSteamID.NativeMethodInfoPtr_IsLobby_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665332);
			CSteamID.NativeMethodInfoPtr_BIndividualAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665333);
			CSteamID.NativeMethodInfoPtr_BAnonAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665334);
			CSteamID.NativeMethodInfoPtr_BAnonUserAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665335);
			CSteamID.NativeMethodInfoPtr_BConsoleUserAccount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665336);
			CSteamID.NativeMethodInfoPtr_SetAccountID_Public_Void_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665337);
			CSteamID.NativeMethodInfoPtr_SetAccountInstance_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665338);
			CSteamID.NativeMethodInfoPtr_SetEAccountType_Public_Void_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665339);
			CSteamID.NativeMethodInfoPtr_SetEUniverse_Public_Void_EUniverse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665340);
			CSteamID.NativeMethodInfoPtr_ClearIndividualInstance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665341);
			CSteamID.NativeMethodInfoPtr_HasNoIndividualInstance_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665342);
			CSteamID.NativeMethodInfoPtr_GetAccountID_Public_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665343);
			CSteamID.NativeMethodInfoPtr_GetUnAccountInstance_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665344);
			CSteamID.NativeMethodInfoPtr_GetEAccountType_Public_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665345);
			CSteamID.NativeMethodInfoPtr_GetEUniverse_Public_EUniverse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665346);
			CSteamID.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665347);
			CSteamID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665348);
			CSteamID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665349);
			CSteamID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665350);
			CSteamID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CSteamID_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665351);
			CSteamID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CSteamID_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665352);
			CSteamID.NativeMethodInfoPtr_op_Explicit_Public_Static_CSteamID_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665353);
			CSteamID.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665354);
			CSteamID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665355);
			CSteamID.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, 100665356);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x000491B0 File Offset: 0x000473B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13319, XrefRangeEnd = 13320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CSteamID(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unAccountID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eUniverse;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAccountType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr__ctor_Public_Void_AccountID_t_EUniverse_EAccountType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00049200 File Offset: 0x00047400
		[CallerCount(0)]
		public unsafe CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unAccountID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unAccountInstance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eUniverse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAccountType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr__ctor_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0004925C File Offset: 0x0004745C
		[CallerCount(0)]
		public unsafe CSteamID(ulong ulSteamID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulSteamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00049290 File Offset: 0x00047490
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13320, RefRangeEnd = 13321, XrefRangeStart = 13320, XrefRangeEnd = 13320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unAccountID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eUniverse;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAccountType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_Set_Public_Void_AccountID_t_EUniverse_EAccountType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x000492E0 File Offset: 0x000474E0
		[CallerCount(0)]
		public unsafe void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unAccountID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unInstance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eUniverse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAccountType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_InstancedSet_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0004933C File Offset: 0x0004753C
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00049364 File Offset: 0x00047564
		[CallerCount(0)]
		public unsafe void CreateBlankAnonLogon(EUniverse eUniverse)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eUniverse;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_CreateBlankAnonLogon_Public_Void_EUniverse_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00049398 File Offset: 0x00047598
		[CallerCount(0)]
		public unsafe void CreateBlankAnonUserLogon(EUniverse eUniverse)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eUniverse;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_CreateBlankAnonUserLogon_Public_Void_EUniverse_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x000493CC File Offset: 0x000475CC
		[CallerCount(0)]
		public unsafe bool BBlankAnonAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BBlankAnonAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x000493FC File Offset: 0x000475FC
		[CallerCount(0)]
		public unsafe bool BGameServerAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BGameServerAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0004942C File Offset: 0x0004762C
		[CallerCount(0)]
		public unsafe bool BPersistentGameServerAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BPersistentGameServerAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0004945C File Offset: 0x0004765C
		[CallerCount(0)]
		public unsafe bool BAnonGameServerAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BAnonGameServerAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x0004948C File Offset: 0x0004768C
		[CallerCount(0)]
		public unsafe bool BContentServerAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BContentServerAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x000494BC File Offset: 0x000476BC
		[CallerCount(0)]
		public unsafe bool BClanAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BClanAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x000494EC File Offset: 0x000476EC
		[CallerCount(0)]
		public unsafe bool BChatAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BChatAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0004951C File Offset: 0x0004771C
		[CallerCount(0)]
		public unsafe bool IsLobby()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_IsLobby_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0004954C File Offset: 0x0004774C
		[CallerCount(0)]
		public unsafe bool BIndividualAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BIndividualAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0004957C File Offset: 0x0004777C
		[CallerCount(0)]
		public unsafe bool BAnonAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BAnonAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x000495AC File Offset: 0x000477AC
		[CallerCount(0)]
		public unsafe bool BAnonUserAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BAnonUserAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x000495DC File Offset: 0x000477DC
		[CallerCount(0)]
		public unsafe bool BConsoleUserAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_BConsoleUserAccount_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0004960C File Offset: 0x0004780C
		[CallerCount(0)]
		public unsafe void SetAccountID(AccountID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_SetAccountID_Public_Void_AccountID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00049640 File Offset: 0x00047840
		[CallerCount(0)]
		public unsafe void SetAccountInstance(uint other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_SetAccountInstance_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00049674 File Offset: 0x00047874
		[CallerCount(0)]
		public unsafe void SetEAccountType(EAccountType other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_SetEAccountType_Public_Void_EAccountType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x000496A8 File Offset: 0x000478A8
		[CallerCount(0)]
		public unsafe void SetEUniverse(EUniverse other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_SetEUniverse_Public_Void_EUniverse_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x000496DC File Offset: 0x000478DC
		[CallerCount(0)]
		public unsafe void ClearIndividualInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_ClearIndividualInstance_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00049704 File Offset: 0x00047904
		[CallerCount(0)]
		public unsafe bool HasNoIndividualInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_HasNoIndividualInstance_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00049734 File Offset: 0x00047934
		[CallerCount(0)]
		public unsafe AccountID_t GetAccountID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_GetAccountID_Public_AccountID_t_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00049764 File Offset: 0x00047964
		[CallerCount(0)]
		public unsafe uint GetUnAccountInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_GetUnAccountInstance_Public_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00049794 File Offset: 0x00047994
		[CallerCount(0)]
		public unsafe EAccountType GetEAccountType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_GetEAccountType_Public_EAccountType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x000497C4 File Offset: 0x000479C4
		[CallerCount(0)]
		public unsafe EUniverse GetEUniverse()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_GetEUniverse_Public_EUniverse_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x000497F4 File Offset: 0x000479F4
		[CallerCount(0)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_IsValid_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00049824 File Offset: 0x00047A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00049850 File Offset: 0x00047A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13321, XrefRangeEnd = 13325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00049894 File Offset: 0x00047A94
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x000498C4 File Offset: 0x00047AC4
		[CallerCount(0)]
		public unsafe static bool operator ==(CSteamID x, CSteamID y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CSteamID_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00049910 File Offset: 0x00047B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13325, XrefRangeEnd = 13328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(CSteamID x, CSteamID y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CSteamID_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x0004995C File Offset: 0x00047B5C
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator CSteamID(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_op_Explicit_Public_Static_CSteamID_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x0004999C File Offset: 0x00047B9C
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(CSteamID that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x000499DC File Offset: 0x00047BDC
		[CallerCount(0)]
		public unsafe bool Equals(CSteamID other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CSteamID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00049A1C File Offset: 0x00047C1C
		[CallerCount(0)]
		public unsafe int CompareTo(CSteamID other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamID.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CSteamID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00006836 File Offset: 0x00004A36
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CSteamID>.NativeClassPtr, ref this));
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x00049A5C File Offset: 0x00047C5C
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x00006848 File Offset: 0x00004A48
		public unsafe static CSteamID Nil
		{
			get
			{
				CSteamID csteamID;
				IL2CPP.il2cpp_field_static_get_value(CSteamID.NativeFieldInfoPtr_Nil, (void*)(&csteamID));
				return csteamID;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamID.NativeFieldInfoPtr_Nil, (void*)(&value));
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x00049A78 File Offset: 0x00047C78
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x00006856 File Offset: 0x00004A56
		public unsafe static CSteamID OutofDateGS
		{
			get
			{
				CSteamID csteamID;
				IL2CPP.il2cpp_field_static_get_value(CSteamID.NativeFieldInfoPtr_OutofDateGS, (void*)(&csteamID));
				return csteamID;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamID.NativeFieldInfoPtr_OutofDateGS, (void*)(&value));
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x00049A94 File Offset: 0x00047C94
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x00006864 File Offset: 0x00004A64
		public unsafe static CSteamID LanModeGS
		{
			get
			{
				CSteamID csteamID;
				IL2CPP.il2cpp_field_static_get_value(CSteamID.NativeFieldInfoPtr_LanModeGS, (void*)(&csteamID));
				return csteamID;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamID.NativeFieldInfoPtr_LanModeGS, (void*)(&value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x00049AB0 File Offset: 0x00047CB0
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x00006872 File Offset: 0x00004A72
		public unsafe static CSteamID NotInitYetGS
		{
			get
			{
				CSteamID csteamID;
				IL2CPP.il2cpp_field_static_get_value(CSteamID.NativeFieldInfoPtr_NotInitYetGS, (void*)(&csteamID));
				return csteamID;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamID.NativeFieldInfoPtr_NotInitYetGS, (void*)(&value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x00049ACC File Offset: 0x00047CCC
		// (set) Token: 0x06000ECD RID: 3789 RVA: 0x00006880 File Offset: 0x00004A80
		public unsafe static CSteamID NonSteamGS
		{
			get
			{
				CSteamID csteamID;
				IL2CPP.il2cpp_field_static_get_value(CSteamID.NativeFieldInfoPtr_NonSteamGS, (void*)(&csteamID));
				return csteamID;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamID.NativeFieldInfoPtr_NonSteamGS, (void*)(&value));
			}
		}

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeFieldInfoPtr_Nil;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeFieldInfoPtr_OutofDateGS;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeFieldInfoPtr_LanModeGS;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeFieldInfoPtr_NotInitYetGS;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeFieldInfoPtr_NonSteamGS;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamID;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_t_EUniverse_EAccountType_0;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_AccountID_t_EUniverse_EAccountType_0;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeMethodInfoPtr_InstancedSet_Public_Void_AccountID_t_UInt32_EUniverse_EAccountType_0;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_CreateBlankAnonLogon_Public_Void_EUniverse_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_CreateBlankAnonUserLogon_Public_Void_EUniverse_0;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_BBlankAnonAccount_Public_Boolean_0;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeMethodInfoPtr_BGameServerAccount_Public_Boolean_0;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr_BPersistentGameServerAccount_Public_Boolean_0;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeMethodInfoPtr_BAnonGameServerAccount_Public_Boolean_0;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeMethodInfoPtr_BContentServerAccount_Public_Boolean_0;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeMethodInfoPtr_BClanAccount_Public_Boolean_0;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeMethodInfoPtr_BChatAccount_Public_Boolean_0;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeMethodInfoPtr_IsLobby_Public_Boolean_0;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeMethodInfoPtr_BIndividualAccount_Public_Boolean_0;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_BAnonAccount_Public_Boolean_0;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr_BAnonUserAccount_Public_Boolean_0;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeMethodInfoPtr_BConsoleUserAccount_Public_Boolean_0;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeMethodInfoPtr_SetAccountID_Public_Void_AccountID_t_0;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeMethodInfoPtr_SetAccountInstance_Public_Void_UInt32_0;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeMethodInfoPtr_SetEAccountType_Public_Void_EAccountType_0;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeMethodInfoPtr_SetEUniverse_Public_Void_EUniverse_0;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeMethodInfoPtr_ClearIndividualInstance_Public_Void_0;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeMethodInfoPtr_HasNoIndividualInstance_Public_Boolean_0;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeMethodInfoPtr_GetAccountID_Public_AccountID_t_0;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeMethodInfoPtr_GetUnAccountInstance_Public_UInt32_0;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeMethodInfoPtr_GetEAccountType_Public_EAccountType_0;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeMethodInfoPtr_GetEUniverse_Public_EUniverse_0;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CSteamID_CSteamID_0;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CSteamID_CSteamID_0;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_CSteamID_UInt64_0;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_CSteamID_0;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CSteamID_0;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_CSteamID_0;

		// Token: 0x04001120 RID: 4384
		[FieldOffset(0)]
		public ulong m_SteamID;
	}
}
