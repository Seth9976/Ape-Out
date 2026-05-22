using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000C8 RID: 200
	[StructLayout(2)]
	public struct LeaderboardScoreUploaded_t
	{
		// Token: 0x0600085B RID: 2139 RVA: 0x0002D66C File Offset: 0x0002B86C
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardScoreUploaded_t()
		{
			Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LeaderboardScoreUploaded_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr);
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "k_iCallback");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_m_bSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "m_bSuccess");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_m_hSteamLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "m_hSteamLeaderboard");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_m_nScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "m_nScore");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_m_bScoreChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "m_bScoreChanged");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_m_nGlobalRankNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "m_nGlobalRankNew");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_m_nGlobalRankPrevious = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "m_nGlobalRankPrevious");
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00005432 File Offset: 0x00003632
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x0002D728 File Offset: 0x0002B928
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x00005444 File Offset: 0x00003644
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LeaderboardScoreUploaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeaderboardScoreUploaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeFieldInfoPtr_m_bSuccess;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeFieldInfoPtr_m_hSteamLeaderboard;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeFieldInfoPtr_m_nScore;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeFieldInfoPtr_m_bScoreChanged;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeFieldInfoPtr_m_nGlobalRankNew;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeFieldInfoPtr_m_nGlobalRankPrevious;

		// Token: 0x04000785 RID: 1925
		[FieldOffset(0)]
		public byte m_bSuccess;

		// Token: 0x04000786 RID: 1926
		[FieldOffset(8)]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		// Token: 0x04000787 RID: 1927
		[FieldOffset(16)]
		public int m_nScore;

		// Token: 0x04000788 RID: 1928
		[FieldOffset(20)]
		public byte m_bScoreChanged;

		// Token: 0x04000789 RID: 1929
		[FieldOffset(24)]
		public int m_nGlobalRankNew;

		// Token: 0x0400078A RID: 1930
		[FieldOffset(28)]
		public int m_nGlobalRankPrevious;
	}
}
