using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200009A RID: 154
	[StructLayout(2)]
	public struct RemoteStoragePublishedFileDeleted_t
	{
		// Token: 0x0600076C RID: 1900 RVA: 0x0002B8EC File Offset: 0x00029AEC
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishedFileDeleted_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStoragePublishedFileDeleted_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr);
			RemoteStoragePublishedFileDeleted_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr, "k_iCallback");
			RemoteStoragePublishedFileDeleted_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStoragePublishedFileDeleted_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00004AD1 File Offset: 0x00002CD1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x0002B958 File Offset: 0x00029B58
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x00004AE3 File Offset: 0x00002CE3
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishedFileDeleted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishedFileDeleted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04000681 RID: 1665
		[FieldOffset(0)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000682 RID: 1666
		[FieldOffset(8)]
		public AppId_t m_nAppID;
	}
}
