using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000098 RID: 152
	[StructLayout(2)]
	public struct RemoteStoragePublishedFileSubscribed_t
	{
		// Token: 0x06000764 RID: 1892 RVA: 0x0002B7DC File Offset: 0x000299DC
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishedFileSubscribed_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStoragePublishedFileSubscribed_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr);
			RemoteStoragePublishedFileSubscribed_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr, "k_iCallback");
			RemoteStoragePublishedFileSubscribed_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStoragePublishedFileSubscribed_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00004A91 File Offset: 0x00002C91
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x0002B848 File Offset: 0x00029A48
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x00004AA3 File Offset: 0x00002CA3
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishedFileSubscribed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishedFileSubscribed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04000677 RID: 1655
		[FieldOffset(0)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000678 RID: 1656
		[FieldOffset(8)]
		public AppId_t m_nAppID;
	}
}
