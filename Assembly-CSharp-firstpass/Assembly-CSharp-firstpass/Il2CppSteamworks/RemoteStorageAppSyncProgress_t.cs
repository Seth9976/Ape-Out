using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200008A RID: 138
	public sealed class RemoteStorageAppSyncProgress_t : ValueType
	{
		// Token: 0x060006BF RID: 1727 RVA: 0x0002A4F0 File Offset: 0x000286F0
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageAppSyncProgress_t()
		{
			Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageAppSyncProgress_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr);
			RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_rgchCurrentFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr, "m_rgchCurrentFile");
			RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr, "m_nAppID");
			RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_uBytesTransferredThisChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr, "m_uBytesTransferredThisChunk");
			RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_dAppPercentComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr, "m_dAppPercentComplete");
			RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_bUploading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr, "m_bUploading");
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x000042FD File Offset: 0x000024FD
		public RemoteStorageAppSyncProgress_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00004306 File Offset: 0x00002506
		public RemoteStorageAppSyncProgress_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x0002A598 File Offset: 0x00028798
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x00004318 File Offset: 0x00002518
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0002A5B4 File Offset: 0x000287B4
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x00004326 File Offset: 0x00002526
		public unsafe string m_rgchCurrentFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_rgchCurrentFile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_rgchCurrentFile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x0002A5DC File Offset: 0x000287DC
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x00004345 File Offset: 0x00002545
		public unsafe AppId_t m_nAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_nAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_nAppID)) = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x0002A604 File Offset: 0x00028804
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x00004360 File Offset: 0x00002560
		public unsafe uint m_uBytesTransferredThisChunk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_uBytesTransferredThisChunk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_uBytesTransferredThisChunk)) = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x0002A62C File Offset: 0x0002882C
		// (set) Token: 0x060006CB RID: 1739 RVA: 0x0000437B File Offset: 0x0000257B
		public unsafe double m_dAppPercentComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_dAppPercentComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_dAppPercentComplete)) = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x0002A654 File Offset: 0x00028854
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x00004396 File Offset: 0x00002596
		public unsafe bool m_bUploading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_bUploading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_bUploading)) = value;
			}
		}

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchCurrentFile;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeFieldInfoPtr_m_uBytesTransferredThisChunk;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeFieldInfoPtr_m_dAppPercentComplete;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeFieldInfoPtr_m_bUploading;
	}
}
