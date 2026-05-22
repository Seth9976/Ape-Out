using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000152 RID: 338
	[Serializable]
	public class gameserveritem_t : Object
	{
		// Token: 0x06000E10 RID: 3600 RVA: 0x00046D8C File Offset: 0x00044F8C
		// Note: this type is marked as 'beforefieldinit'.
		static gameserveritem_t()
		{
			Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "gameserveritem_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr);
			gameserveritem_t.NativeFieldInfoPtr_m_NetAdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_NetAdr");
			gameserveritem_t.NativeFieldInfoPtr_m_nPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_nPing");
			gameserveritem_t.NativeFieldInfoPtr_m_bHadSuccessfulResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_bHadSuccessfulResponse");
			gameserveritem_t.NativeFieldInfoPtr_m_bDoNotRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_bDoNotRefresh");
			gameserveritem_t.NativeFieldInfoPtr_m_szGameDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_szGameDir");
			gameserveritem_t.NativeFieldInfoPtr_m_szMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_szMap");
			gameserveritem_t.NativeFieldInfoPtr_m_szGameDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_szGameDescription");
			gameserveritem_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_nAppID");
			gameserveritem_t.NativeFieldInfoPtr_m_nPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_nPlayers");
			gameserveritem_t.NativeFieldInfoPtr_m_nMaxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_nMaxPlayers");
			gameserveritem_t.NativeFieldInfoPtr_m_nBotPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_nBotPlayers");
			gameserveritem_t.NativeFieldInfoPtr_m_bPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_bPassword");
			gameserveritem_t.NativeFieldInfoPtr_m_bSecure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_bSecure");
			gameserveritem_t.NativeFieldInfoPtr_m_ulTimeLastPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_ulTimeLastPlayed");
			gameserveritem_t.NativeFieldInfoPtr_m_nServerVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_nServerVersion");
			gameserveritem_t.NativeFieldInfoPtr_m_szServerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_szServerName");
			gameserveritem_t.NativeFieldInfoPtr_m_szGameTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_szGameTags");
			gameserveritem_t.NativeFieldInfoPtr_m_steamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, "m_steamID");
			gameserveritem_t.NativeMethodInfoPtr_GetGameDir_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100665235);
			gameserveritem_t.NativeMethodInfoPtr_SetGameDir_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100665236);
			gameserveritem_t.NativeMethodInfoPtr_GetMap_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100665237);
			gameserveritem_t.NativeMethodInfoPtr_SetMap_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100665238);
			gameserveritem_t.NativeMethodInfoPtr_GetGameDescription_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100665239);
			gameserveritem_t.NativeMethodInfoPtr_SetGameDescription_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100665240);
			gameserveritem_t.NativeMethodInfoPtr_GetServerName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100665241);
			gameserveritem_t.NativeMethodInfoPtr_SetServerName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100665242);
			gameserveritem_t.NativeMethodInfoPtr_GetGameTags_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100665243);
			gameserveritem_t.NativeMethodInfoPtr_SetGameTags_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100665244);
			gameserveritem_t.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr, 100665245);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00047000 File Offset: 0x00045200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12782, XrefRangeEnd = 12785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetGameDir()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_GetGameDir_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00047038 File Offset: 0x00045238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12785, XrefRangeEnd = 12789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameDir(string dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_SetGameDir_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0004707C File Offset: 0x0004527C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12789, XrefRangeEnd = 12792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_GetMap_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x000470B4 File Offset: 0x000452B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12792, XrefRangeEnd = 12796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMap(string map)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(map);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_SetMap_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x000470F8 File Offset: 0x000452F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12796, XrefRangeEnd = 12799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetGameDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_GetGameDescription_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00047130 File Offset: 0x00045330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12799, XrefRangeEnd = 12803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameDescription(string desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_SetGameDescription_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00047174 File Offset: 0x00045374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12803, XrefRangeEnd = 12806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetServerName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_GetServerName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x000471AC File Offset: 0x000453AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12806, XrefRangeEnd = 12810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetServerName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_SetServerName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x000471F0 File Offset: 0x000453F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12810, XrefRangeEnd = 12813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetGameTags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_GetGameTags_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00047228 File Offset: 0x00045428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12813, XrefRangeEnd = 12817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameTags(string tags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tags);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr_SetGameTags_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0004726C File Offset: 0x0004546C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe gameserveritem_t()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<gameserveritem_t>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(gameserveritem_t.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x0000658B File Offset: 0x0000478B
		public gameserveritem_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x000472A8 File Offset: 0x000454A8
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x00006594 File Offset: 0x00004794
		public unsafe servernetadr_t m_NetAdr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_NetAdr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_NetAdr)) = value;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x000472D0 File Offset: 0x000454D0
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x000065AF File Offset: 0x000047AF
		public unsafe int m_nPing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nPing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nPing)) = value;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x000472F8 File Offset: 0x000454F8
		// (set) Token: 0x06000E22 RID: 3618 RVA: 0x000065CA File Offset: 0x000047CA
		public unsafe bool m_bHadSuccessfulResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_bHadSuccessfulResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_bHadSuccessfulResponse)) = value;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x00047320 File Offset: 0x00045520
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x000065E5 File Offset: 0x000047E5
		public unsafe bool m_bDoNotRefresh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_bDoNotRefresh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_bDoNotRefresh)) = value;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x00047348 File Offset: 0x00045548
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x00006600 File Offset: 0x00004800
		public unsafe Il2CppStructArray<byte> m_szGameDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szGameDir);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szGameDir), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x00047378 File Offset: 0x00045578
		// (set) Token: 0x06000E28 RID: 3624 RVA: 0x0000661F File Offset: 0x0000481F
		public unsafe Il2CppStructArray<byte> m_szMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x000473A8 File Offset: 0x000455A8
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x0000663E File Offset: 0x0000483E
		public unsafe Il2CppStructArray<byte> m_szGameDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szGameDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szGameDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x000473D8 File Offset: 0x000455D8
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x0000665D File Offset: 0x0000485D
		public unsafe uint m_nAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nAppID)) = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00047400 File Offset: 0x00045600
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x00006678 File Offset: 0x00004878
		public unsafe int m_nPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nPlayers)) = value;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x00047428 File Offset: 0x00045628
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x00006693 File Offset: 0x00004893
		public unsafe int m_nMaxPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nMaxPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nMaxPlayers)) = value;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x00047450 File Offset: 0x00045650
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x000066AE File Offset: 0x000048AE
		public unsafe int m_nBotPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nBotPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nBotPlayers)) = value;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x00047478 File Offset: 0x00045678
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x000066C9 File Offset: 0x000048C9
		public unsafe bool m_bPassword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_bPassword);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_bPassword)) = value;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x000474A0 File Offset: 0x000456A0
		// (set) Token: 0x06000E36 RID: 3638 RVA: 0x000066E4 File Offset: 0x000048E4
		public unsafe bool m_bSecure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_bSecure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_bSecure)) = value;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x000474C8 File Offset: 0x000456C8
		// (set) Token: 0x06000E38 RID: 3640 RVA: 0x000066FF File Offset: 0x000048FF
		public unsafe uint m_ulTimeLastPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_ulTimeLastPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_ulTimeLastPlayed)) = value;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x000474F0 File Offset: 0x000456F0
		// (set) Token: 0x06000E3A RID: 3642 RVA: 0x0000671A File Offset: 0x0000491A
		public unsafe int m_nServerVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nServerVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_nServerVersion)) = value;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x00047518 File Offset: 0x00045718
		// (set) Token: 0x06000E3C RID: 3644 RVA: 0x00006735 File Offset: 0x00004935
		public unsafe Il2CppStructArray<byte> m_szServerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szServerName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szServerName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x00047548 File Offset: 0x00045748
		// (set) Token: 0x06000E3E RID: 3646 RVA: 0x00006754 File Offset: 0x00004954
		public unsafe Il2CppStructArray<byte> m_szGameTags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szGameTags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_szGameTags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00047578 File Offset: 0x00045778
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x00006773 File Offset: 0x00004973
		public unsafe CSteamID m_steamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_steamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(gameserveritem_t.NativeFieldInfoPtr_m_steamID)) = value;
			}
		}

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeFieldInfoPtr_m_NetAdr;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeFieldInfoPtr_m_nPing;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeFieldInfoPtr_m_bHadSuccessfulResponse;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeFieldInfoPtr_m_bDoNotRefresh;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeFieldInfoPtr_m_szGameDir;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeFieldInfoPtr_m_szMap;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeFieldInfoPtr_m_szGameDescription;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeFieldInfoPtr_m_nPlayers;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeFieldInfoPtr_m_nMaxPlayers;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeFieldInfoPtr_m_nBotPlayers;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeFieldInfoPtr_m_bPassword;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeFieldInfoPtr_m_bSecure;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeFieldInfoPtr_m_ulTimeLastPlayed;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeFieldInfoPtr_m_nServerVersion;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeFieldInfoPtr_m_szServerName;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeFieldInfoPtr_m_szGameTags;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeFieldInfoPtr_m_steamID;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr_GetGameDir_Public_String_0;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeMethodInfoPtr_SetGameDir_Public_Void_String_0;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeMethodInfoPtr_GetMap_Public_String_0;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeMethodInfoPtr_SetMap_Public_Void_String_0;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr_GetGameDescription_Public_String_0;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr_SetGameDescription_Public_Void_String_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr_GetServerName_Public_String_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr_SetServerName_Public_Void_String_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_GetGameTags_Public_String_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_SetGameTags_Public_Void_String_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
