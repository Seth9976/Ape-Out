using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200009B RID: 155
	[StructLayout(2)]
	public struct RemoteStorageUpdateUserPublishedItemVoteResult_t
	{
		// Token: 0x06000770 RID: 1904 RVA: 0x0002B974 File Offset: 0x00029B74
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageUpdateUserPublishedItemVoteResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageUpdateUserPublishedItemVoteResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr);
			RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr, "m_nPublishedFileId");
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00004AF1 File Offset: 0x00002CF1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x0002B9E0 File Offset: 0x00029BE0
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x00004B03 File Offset: 0x00002D03
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04000686 RID: 1670
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04000687 RID: 1671
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
