using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000A1 RID: 161
	[StructLayout(2)]
	public struct RemoteStoragePublishedFileUpdated_t
	{
		// Token: 0x0600079E RID: 1950 RVA: 0x0002BEEC File Offset: 0x0002A0EC
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishedFileUpdated_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStoragePublishedFileUpdated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr);
			RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, "k_iCallback");
			RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, "m_nAppID");
			RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr_m_ulUnused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, "m_ulUnused");
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00004CDD File Offset: 0x00002EDD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0002BF6C File Offset: 0x0002A16C
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x00004CEF File Offset: 0x00002EEF
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeFieldInfoPtr_m_ulUnused;

		// Token: 0x040006AB RID: 1707
		[FieldOffset(0)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040006AC RID: 1708
		[FieldOffset(8)]
		public AppId_t m_nAppID;

		// Token: 0x040006AD RID: 1709
		[FieldOffset(16)]
		public ulong m_ulUnused;
	}
}
