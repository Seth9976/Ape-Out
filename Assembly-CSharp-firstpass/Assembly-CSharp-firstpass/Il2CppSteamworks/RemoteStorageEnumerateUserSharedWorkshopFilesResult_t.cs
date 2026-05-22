using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200009D RID: 157
	public sealed class RemoteStorageEnumerateUserSharedWorkshopFilesResult_t : ValueType
	{
		// Token: 0x06000778 RID: 1912 RVA: 0x0002BA98 File Offset: 0x00029C98
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageEnumerateUserSharedWorkshopFilesResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageEnumerateUserSharedWorkshopFilesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr);
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, "m_nResultsReturned");
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, "m_nTotalResultCount");
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, "m_rgPublishedFileId");
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00004B31 File Offset: 0x00002D31
		public RemoteStorageEnumerateUserSharedWorkshopFilesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00004B3A File Offset: 0x00002D3A
		public RemoteStorageEnumerateUserSharedWorkshopFilesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x0002BB2C File Offset: 0x00029D2C
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x00004B4C File Offset: 0x00002D4C
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x0002BB48 File Offset: 0x00029D48
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x00004B5A File Offset: 0x00002D5A
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x0002BB70 File Offset: 0x00029D70
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x00004B75 File Offset: 0x00002D75
		public unsafe int m_nResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned)) = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x0002BB98 File Offset: 0x00029D98
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x00004B90 File Offset: 0x00002D90
		public unsafe int m_nTotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount)) = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x0002BBC0 File Offset: 0x00029DC0
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x00004BAB File Offset: 0x00002DAB
		public unsafe Il2CppStructArray<PublishedFileId_t> m_rgPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeFieldInfoPtr_m_nResultsReturned;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeFieldInfoPtr_m_nTotalResultCount;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeFieldInfoPtr_m_rgPublishedFileId;
	}
}
