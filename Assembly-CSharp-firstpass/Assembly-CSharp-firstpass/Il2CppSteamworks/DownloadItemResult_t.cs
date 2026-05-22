using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000AB RID: 171
	[StructLayout(2)]
	public struct DownloadItemResult_t
	{
		// Token: 0x060007CB RID: 1995 RVA: 0x0002C4B4 File Offset: 0x0002A6B4
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadItemResult_t()
		{
			Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "DownloadItemResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr);
			DownloadItemResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, "k_iCallback");
			DownloadItemResult_t.NativeFieldInfoPtr_m_unAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, "m_unAppID");
			DownloadItemResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, "m_nPublishedFileId");
			DownloadItemResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00004EA8 File Offset: 0x000030A8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x0002C534 File Offset: 0x0002A734
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x00004EBA File Offset: 0x000030BA
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DownloadItemResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DownloadItemResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeFieldInfoPtr_m_unAppID;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040006E5 RID: 1765
		[FieldOffset(0)]
		public AppId_t m_unAppID;

		// Token: 0x040006E6 RID: 1766
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040006E7 RID: 1767
		[FieldOffset(16)]
		public EResult m_eResult;
	}
}
