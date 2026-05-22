using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000C7 RID: 199
	[StructLayout(2)]
	public struct LeaderboardScoresDownloaded_t
	{
		// Token: 0x06000857 RID: 2135 RVA: 0x0002D5D0 File Offset: 0x0002B7D0
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardScoresDownloaded_t()
		{
			Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LeaderboardScoresDownloaded_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr);
			LeaderboardScoresDownloaded_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, "k_iCallback");
			LeaderboardScoresDownloaded_t.NativeFieldInfoPtr_m_hSteamLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, "m_hSteamLeaderboard");
			LeaderboardScoresDownloaded_t.NativeFieldInfoPtr_m_hSteamLeaderboardEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, "m_hSteamLeaderboardEntries");
			LeaderboardScoresDownloaded_t.NativeFieldInfoPtr_m_cEntryCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, "m_cEntryCount");
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00005412 File Offset: 0x00003612
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x0002D650 File Offset: 0x0002B850
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x00005424 File Offset: 0x00003624
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LeaderboardScoresDownloaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeaderboardScoresDownloaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeFieldInfoPtr_m_hSteamLeaderboard;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeFieldInfoPtr_m_hSteamLeaderboardEntries;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeFieldInfoPtr_m_cEntryCount;

		// Token: 0x0400077B RID: 1915
		[FieldOffset(0)]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		// Token: 0x0400077C RID: 1916
		[FieldOffset(8)]
		public SteamLeaderboardEntries_t m_hSteamLeaderboardEntries;

		// Token: 0x0400077D RID: 1917
		[FieldOffset(16)]
		public int m_cEntryCount;
	}
}
