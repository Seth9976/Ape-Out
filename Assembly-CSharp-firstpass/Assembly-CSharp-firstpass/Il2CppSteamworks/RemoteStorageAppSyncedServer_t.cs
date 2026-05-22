using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000089 RID: 137
	[StructLayout(2)]
	public struct RemoteStorageAppSyncedServer_t
	{
		// Token: 0x060006BB RID: 1723 RVA: 0x0002A454 File Offset: 0x00028654
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageAppSyncedServer_t()
		{
			Il2CppClassPointerStore<RemoteStorageAppSyncedServer_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageAppSyncedServer_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageAppSyncedServer_t>.NativeClassPtr);
			RemoteStorageAppSyncedServer_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncedServer_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageAppSyncedServer_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncedServer_t>.NativeClassPtr, "m_nAppID");
			RemoteStorageAppSyncedServer_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncedServer_t>.NativeClassPtr, "m_eResult");
			RemoteStorageAppSyncedServer_t.NativeFieldInfoPtr_m_unNumUploads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncedServer_t>.NativeClassPtr, "m_unNumUploads");
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x000042DD File Offset: 0x000024DD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageAppSyncedServer_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x0002A4D4 File Offset: 0x000286D4
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x000042EF File Offset: 0x000024EF
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageAppSyncedServer_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageAppSyncedServer_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeFieldInfoPtr_m_unNumUploads;

		// Token: 0x04000608 RID: 1544
		[FieldOffset(0)]
		public AppId_t m_nAppID;

		// Token: 0x04000609 RID: 1545
		[FieldOffset(4)]
		public EResult m_eResult;

		// Token: 0x0400060A RID: 1546
		[FieldOffset(8)]
		public int m_unNumUploads;
	}
}
