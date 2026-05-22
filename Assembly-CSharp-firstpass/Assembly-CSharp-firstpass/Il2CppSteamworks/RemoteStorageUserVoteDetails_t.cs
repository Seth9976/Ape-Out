using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200009C RID: 156
	[StructLayout(2)]
	public struct RemoteStorageUserVoteDetails_t
	{
		// Token: 0x06000774 RID: 1908 RVA: 0x0002B9FC File Offset: 0x00029BFC
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageUserVoteDetails_t()
		{
			Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageUserVoteDetails_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr);
			RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, "m_eResult");
			RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr_m_eVote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, "m_eVote");
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00004B11 File Offset: 0x00002D11
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x0002BA7C File Offset: 0x00029C7C
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x00004B23 File Offset: 0x00002D23
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeFieldInfoPtr_m_eVote;

		// Token: 0x0400068C RID: 1676
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x0400068D RID: 1677
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400068E RID: 1678
		[FieldOffset(16)]
		public EWorkshopVote m_eVote;
	}
}
