using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000C6 RID: 198
	[StructLayout(2)]
	public struct LeaderboardFindResult_t
	{
		// Token: 0x06000853 RID: 2131 RVA: 0x0002D548 File Offset: 0x0002B748
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardFindResult_t()
		{
			Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LeaderboardFindResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr);
			LeaderboardFindResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr, "k_iCallback");
			LeaderboardFindResult_t.NativeFieldInfoPtr_m_hSteamLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr, "m_hSteamLeaderboard");
			LeaderboardFindResult_t.NativeFieldInfoPtr_m_bLeaderboardFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr, "m_bLeaderboardFound");
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000053F2 File Offset: 0x000035F2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x0002D5B4 File Offset: 0x0002B7B4
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x00005404 File Offset: 0x00003604
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LeaderboardFindResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeaderboardFindResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeFieldInfoPtr_m_hSteamLeaderboard;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeFieldInfoPtr_m_bLeaderboardFound;

		// Token: 0x04000775 RID: 1909
		[FieldOffset(0)]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		// Token: 0x04000776 RID: 1910
		[FieldOffset(8)]
		public byte m_bLeaderboardFound;
	}
}
