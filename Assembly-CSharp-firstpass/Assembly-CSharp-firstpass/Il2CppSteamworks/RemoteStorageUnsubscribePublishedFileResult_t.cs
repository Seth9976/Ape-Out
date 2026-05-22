using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000092 RID: 146
	[StructLayout(2)]
	public struct RemoteStorageUnsubscribePublishedFileResult_t
	{
		// Token: 0x06000705 RID: 1797 RVA: 0x0002ACB8 File Offset: 0x00028EB8
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageUnsubscribePublishedFileResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageUnsubscribePublishedFileResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr);
			RemoteStorageUnsubscribePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageUnsubscribePublishedFileResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageUnsubscribePublishedFileResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr, "m_nPublishedFileId");
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00004600 File Offset: 0x00002800
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x0002AD24 File Offset: 0x00028F24
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x00004612 File Offset: 0x00002812
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageUnsubscribePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageUnsubscribePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04000639 RID: 1593
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x0400063A RID: 1594
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
