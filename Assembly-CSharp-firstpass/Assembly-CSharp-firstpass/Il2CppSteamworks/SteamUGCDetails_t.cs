using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000130 RID: 304
	public sealed class SteamUGCDetails_t : ValueType
	{
		// Token: 0x060009EF RID: 2543 RVA: 0x000300E0 File Offset: 0x0002E2E0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUGCDetails_t()
		{
			Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamUGCDetails_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr);
			SteamUGCDetails_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_nPublishedFileId");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_eResult");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_eFileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_eFileType");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_nCreatorAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_nCreatorAppID");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_nConsumerAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_nConsumerAppID");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_rgchTitle");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_rgchDescription");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_ulSteamIDOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_ulSteamIDOwner");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_rtimeCreated");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_rtimeUpdated");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeAddedToUserList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_rtimeAddedToUserList");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_eVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_eVisibility");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_bBanned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_bBanned");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_bAcceptedForUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_bAcceptedForUse");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_bTagsTruncated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_bTagsTruncated");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_rgchTags");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_hFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_hFile");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_hPreviewFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_hPreviewFile");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_pchFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_pchFileName");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_nFileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_nFileSize");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_nPreviewFileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_nPreviewFileSize");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_rgchURL");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_unVotesUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_unVotesUp");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_unVotesDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_unVotesDown");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_flScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_flScore");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_unNumChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_unNumChildren");
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00006113 File Offset: 0x00004313
		public SteamUGCDetails_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0000611C File Offset: 0x0000431C
		public SteamUGCDetails_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00030318 File Offset: 0x0002E518
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x0000612E File Offset: 0x0000432E
		public unsafe PublishedFileId_t m_nPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nPublishedFileId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nPublishedFileId)) = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00030340 File Offset: 0x0002E540
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x00006149 File Offset: 0x00004349
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00030368 File Offset: 0x0002E568
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x00006164 File Offset: 0x00004364
		public unsafe EWorkshopFileType m_eFileType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_eFileType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_eFileType)) = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x00030390 File Offset: 0x0002E590
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x0000617F File Offset: 0x0000437F
		public unsafe AppId_t m_nCreatorAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nCreatorAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nCreatorAppID)) = value;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x000303B8 File Offset: 0x0002E5B8
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x0000619A File Offset: 0x0000439A
		public unsafe AppId_t m_nConsumerAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nConsumerAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nConsumerAppID)) = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x000303E0 File Offset: 0x0002E5E0
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x000061B5 File Offset: 0x000043B5
		public unsafe string m_rgchTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x00030408 File Offset: 0x0002E608
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x000061D4 File Offset: 0x000043D4
		public unsafe string m_rgchDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00030430 File Offset: 0x0002E630
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x000061F3 File Offset: 0x000043F3
		public unsafe ulong m_ulSteamIDOwner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_ulSteamIDOwner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_ulSteamIDOwner)) = value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00030458 File Offset: 0x0002E658
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x0000620E File Offset: 0x0000440E
		public unsafe uint m_rtimeCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeCreated)) = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00030480 File Offset: 0x0002E680
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00006229 File Offset: 0x00004429
		public unsafe uint m_rtimeUpdated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeUpdated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeUpdated)) = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x000304A8 File Offset: 0x0002E6A8
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00006244 File Offset: 0x00004444
		public unsafe uint m_rtimeAddedToUserList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeAddedToUserList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeAddedToUserList)) = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x000304D0 File Offset: 0x0002E6D0
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x0000625F File Offset: 0x0000445F
		public unsafe ERemoteStoragePublishedFileVisibility m_eVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_eVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_eVisibility)) = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x000304F8 File Offset: 0x0002E6F8
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x0000627A File Offset: 0x0000447A
		public unsafe bool m_bBanned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_bBanned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_bBanned)) = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00030520 File Offset: 0x0002E720
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x00006295 File Offset: 0x00004495
		public unsafe bool m_bAcceptedForUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_bAcceptedForUse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_bAcceptedForUse)) = value;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00030548 File Offset: 0x0002E748
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x000062B0 File Offset: 0x000044B0
		public unsafe bool m_bTagsTruncated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_bTagsTruncated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_bTagsTruncated)) = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00030570 File Offset: 0x0002E770
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x000062CB File Offset: 0x000044CB
		public unsafe string m_rgchTags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchTags);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchTags), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00030598 File Offset: 0x0002E798
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x000062EA File Offset: 0x000044EA
		public unsafe UGCHandle_t m_hFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_hFile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_hFile)) = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x000305C0 File Offset: 0x0002E7C0
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x00006305 File Offset: 0x00004505
		public unsafe UGCHandle_t m_hPreviewFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_hPreviewFile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_hPreviewFile)) = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x000305E8 File Offset: 0x0002E7E8
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x00006320 File Offset: 0x00004520
		public unsafe string m_pchFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_pchFileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_pchFileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00030610 File Offset: 0x0002E810
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x0000633F File Offset: 0x0000453F
		public unsafe int m_nFileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nFileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nFileSize)) = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00030638 File Offset: 0x0002E838
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x0000635A File Offset: 0x0000455A
		public unsafe int m_nPreviewFileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nPreviewFileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nPreviewFileSize)) = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x00030660 File Offset: 0x0002E860
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x00006375 File Offset: 0x00004575
		public unsafe string m_rgchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00030688 File Offset: 0x0002E888
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x00006394 File Offset: 0x00004594
		public unsafe uint m_unVotesUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_unVotesUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_unVotesUp)) = value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x000306B0 File Offset: 0x0002E8B0
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x000063AF File Offset: 0x000045AF
		public unsafe uint m_unVotesDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_unVotesDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_unVotesDown)) = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x000306D8 File Offset: 0x0002E8D8
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x000063CA File Offset: 0x000045CA
		public unsafe float m_flScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_flScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_flScore)) = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00030700 File Offset: 0x0002E900
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x000063E5 File Offset: 0x000045E5
		public unsafe uint m_unNumChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_unNumChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_unNumChildren)) = value;
			}
		}

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeFieldInfoPtr_m_eFileType;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeFieldInfoPtr_m_nCreatorAppID;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeFieldInfoPtr_m_nConsumerAppID;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchTitle;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchDescription;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDOwner;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeFieldInfoPtr_m_rtimeCreated;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeFieldInfoPtr_m_rtimeUpdated;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeFieldInfoPtr_m_rtimeAddedToUserList;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeFieldInfoPtr_m_eVisibility;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeFieldInfoPtr_m_bBanned;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeFieldInfoPtr_m_bAcceptedForUse;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeFieldInfoPtr_m_bTagsTruncated;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchTags;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeFieldInfoPtr_m_hFile;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeFieldInfoPtr_m_hPreviewFile;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeFieldInfoPtr_m_pchFileName;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeFieldInfoPtr_m_nFileSize;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeFieldInfoPtr_m_nPreviewFileSize;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchURL;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeFieldInfoPtr_m_unVotesUp;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeFieldInfoPtr_m_unVotesDown;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeFieldInfoPtr_m_flScore;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeFieldInfoPtr_m_unNumChildren;
	}
}
