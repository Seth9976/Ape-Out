using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200008E RID: 142
	[StructLayout(2)]
	public struct RemoteStorageDeletePublishedFileResult_t
	{
		// Token: 0x060006E1 RID: 1761 RVA: 0x0002A8B4 File Offset: 0x00028AB4
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageDeletePublishedFileResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageDeletePublishedFileResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr);
			RemoteStorageDeletePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageDeletePublishedFileResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageDeletePublishedFileResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr, "m_nPublishedFileId");
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0000446F File Offset: 0x0000266F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x0002A920 File Offset: 0x00028B20
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00004481 File Offset: 0x00002681
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageDeletePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageDeletePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04000624 RID: 1572
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04000625 RID: 1573
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
