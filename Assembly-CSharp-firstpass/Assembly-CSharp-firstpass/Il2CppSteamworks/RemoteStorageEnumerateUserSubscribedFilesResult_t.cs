using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000091 RID: 145
	public sealed class RemoteStorageEnumerateUserSubscribedFilesResult_t : ValueType
	{
		// Token: 0x060006F6 RID: 1782 RVA: 0x0002AB1C File Offset: 0x00028D1C
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageEnumerateUserSubscribedFilesResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageEnumerateUserSubscribedFilesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr);
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "m_nResultsReturned");
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "m_nTotalResultCount");
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "m_rgPublishedFileId");
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_rgRTimeSubscribed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "m_rgRTimeSubscribed");
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00004548 File Offset: 0x00002748
		public RemoteStorageEnumerateUserSubscribedFilesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00004551 File Offset: 0x00002751
		public RemoteStorageEnumerateUserSubscribedFilesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x0002ABC4 File Offset: 0x00028DC4
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x00004563 File Offset: 0x00002763
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x0002ABE0 File Offset: 0x00028DE0
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x00004571 File Offset: 0x00002771
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x0002AC08 File Offset: 0x00028E08
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x0000458C File Offset: 0x0000278C
		public unsafe int m_nResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned)) = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x0002AC30 File Offset: 0x00028E30
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x000045A7 File Offset: 0x000027A7
		public unsafe int m_nTotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount)) = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x0002AC58 File Offset: 0x00028E58
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x000045C2 File Offset: 0x000027C2
		public unsafe Il2CppStructArray<PublishedFileId_t> m_rgPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x0002AC88 File Offset: 0x00028E88
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x000045E1 File Offset: 0x000027E1
		public unsafe Il2CppStructArray<uint> m_rgRTimeSubscribed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_rgRTimeSubscribed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_rgRTimeSubscribed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeFieldInfoPtr_m_nResultsReturned;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeFieldInfoPtr_m_nTotalResultCount;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeFieldInfoPtr_m_rgPublishedFileId;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeFieldInfoPtr_m_rgRTimeSubscribed;
	}
}
