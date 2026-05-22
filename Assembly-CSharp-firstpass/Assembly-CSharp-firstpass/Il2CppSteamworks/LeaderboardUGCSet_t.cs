using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000CD RID: 205
	[StructLayout(2)]
	public struct LeaderboardUGCSet_t
	{
		// Token: 0x06000878 RID: 2168 RVA: 0x0002DA18 File Offset: 0x0002BC18
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardUGCSet_t()
		{
			Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LeaderboardUGCSet_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr);
			LeaderboardUGCSet_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr, "k_iCallback");
			LeaderboardUGCSet_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr, "m_eResult");
			LeaderboardUGCSet_t.NativeFieldInfoPtr_m_hSteamLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr, "m_hSteamLeaderboard");
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0000554B File Offset: 0x0000374B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x0002DA84 File Offset: 0x0002BC84
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x0000555D File Offset: 0x0000375D
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LeaderboardUGCSet_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeaderboardUGCSet_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeFieldInfoPtr_m_hSteamLeaderboard;

		// Token: 0x040007A0 RID: 1952
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x040007A1 RID: 1953
		[FieldOffset(8)]
		public SteamLeaderboard_t m_hSteamLeaderboard;
	}
}
