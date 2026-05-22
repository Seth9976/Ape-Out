using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000088 RID: 136
	[StructLayout(2)]
	public struct RemoteStorageAppSyncedClient_t
	{
		// Token: 0x060006B7 RID: 1719 RVA: 0x0002A3B8 File Offset: 0x000285B8
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageAppSyncedClient_t()
		{
			Il2CppClassPointerStore<RemoteStorageAppSyncedClient_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageAppSyncedClient_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageAppSyncedClient_t>.NativeClassPtr);
			RemoteStorageAppSyncedClient_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncedClient_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageAppSyncedClient_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncedClient_t>.NativeClassPtr, "m_nAppID");
			RemoteStorageAppSyncedClient_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncedClient_t>.NativeClassPtr, "m_eResult");
			RemoteStorageAppSyncedClient_t.NativeFieldInfoPtr_m_unNumDownloads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncedClient_t>.NativeClassPtr, "m_unNumDownloads");
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x000042BD File Offset: 0x000024BD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageAppSyncedClient_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0002A438 File Offset: 0x00028638
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x000042CF File Offset: 0x000024CF
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageAppSyncedClient_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageAppSyncedClient_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeFieldInfoPtr_m_unNumDownloads;

		// Token: 0x04000601 RID: 1537
		[FieldOffset(0)]
		public AppId_t m_nAppID;

		// Token: 0x04000602 RID: 1538
		[FieldOffset(4)]
		public EResult m_eResult;

		// Token: 0x04000603 RID: 1539
		[FieldOffset(8)]
		public int m_unNumDownloads;
	}
}
