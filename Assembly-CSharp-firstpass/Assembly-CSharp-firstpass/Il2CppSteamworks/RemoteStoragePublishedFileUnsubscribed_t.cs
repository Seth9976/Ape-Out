using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000099 RID: 153
	[StructLayout(2)]
	public struct RemoteStoragePublishedFileUnsubscribed_t
	{
		// Token: 0x06000768 RID: 1896 RVA: 0x0002B864 File Offset: 0x00029A64
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishedFileUnsubscribed_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStoragePublishedFileUnsubscribed_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr);
			RemoteStoragePublishedFileUnsubscribed_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr, "k_iCallback");
			RemoteStoragePublishedFileUnsubscribed_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStoragePublishedFileUnsubscribed_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00004AB1 File Offset: 0x00002CB1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x0002B8D0 File Offset: 0x00029AD0
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00004AC3 File Offset: 0x00002CC3
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishedFileUnsubscribed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishedFileUnsubscribed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x0400067C RID: 1660
		[FieldOffset(0)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400067D RID: 1661
		[FieldOffset(8)]
		public AppId_t m_nAppID;
	}
}
