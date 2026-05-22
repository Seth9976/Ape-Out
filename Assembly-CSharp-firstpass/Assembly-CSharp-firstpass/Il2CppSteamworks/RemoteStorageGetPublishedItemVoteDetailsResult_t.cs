using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000097 RID: 151
	[StructLayout(2)]
	public struct RemoteStorageGetPublishedItemVoteDetailsResult_t
	{
		// Token: 0x06000760 RID: 1888 RVA: 0x0002B704 File Offset: 0x00029904
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageGetPublishedItemVoteDetailsResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageGetPublishedItemVoteDetailsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr);
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_m_unPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "m_unPublishedFileId");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_m_nVotesFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "m_nVotesFor");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_m_nVotesAgainst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "m_nVotesAgainst");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_m_nReports = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "m_nReports");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_m_fScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "m_fScore");
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00004A71 File Offset: 0x00002C71
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x0002B7C0 File Offset: 0x000299C0
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x00004A83 File Offset: 0x00002C83
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeFieldInfoPtr_m_unPublishedFileId;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeFieldInfoPtr_m_nVotesFor;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeFieldInfoPtr_m_nVotesAgainst;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeFieldInfoPtr_m_nReports;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeFieldInfoPtr_m_fScore;

		// Token: 0x0400066E RID: 1646
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x0400066F RID: 1647
		[FieldOffset(8)]
		public PublishedFileId_t m_unPublishedFileId;

		// Token: 0x04000670 RID: 1648
		[FieldOffset(16)]
		public int m_nVotesFor;

		// Token: 0x04000671 RID: 1649
		[FieldOffset(20)]
		public int m_nVotesAgainst;

		// Token: 0x04000672 RID: 1650
		[FieldOffset(24)]
		public int m_nReports;

		// Token: 0x04000673 RID: 1651
		[FieldOffset(28)]
		public float m_fScore;
	}
}
