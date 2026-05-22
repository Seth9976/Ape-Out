using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000132 RID: 306
	[StructLayout(2)]
	public struct LeaderboardEntry_t
	{
		// Token: 0x06000A28 RID: 2600 RVA: 0x000307A8 File Offset: 0x0002E9A8
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardEntry_t()
		{
			Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LeaderboardEntry_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr);
			LeaderboardEntry_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, "m_steamIDUser");
			LeaderboardEntry_t.NativeFieldInfoPtr_m_nGlobalRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, "m_nGlobalRank");
			LeaderboardEntry_t.NativeFieldInfoPtr_m_nScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, "m_nScore");
			LeaderboardEntry_t.NativeFieldInfoPtr_m_cDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, "m_cDetails");
			LeaderboardEntry_t.NativeFieldInfoPtr_m_hUGC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, "m_hUGC");
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00006412 File Offset: 0x00004612
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeFieldInfoPtr_m_nGlobalRank;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeFieldInfoPtr_m_nScore;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeFieldInfoPtr_m_cDetails;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeFieldInfoPtr_m_hUGC;

		// Token: 0x04000CD8 RID: 3288
		[FieldOffset(0)]
		public CSteamID m_steamIDUser;

		// Token: 0x04000CD9 RID: 3289
		[FieldOffset(8)]
		public int m_nGlobalRank;

		// Token: 0x04000CDA RID: 3290
		[FieldOffset(12)]
		public int m_nScore;

		// Token: 0x04000CDB RID: 3291
		[FieldOffset(16)]
		public int m_cDetails;

		// Token: 0x04000CDC RID: 3292
		[FieldOffset(24)]
		public UGCHandle_t m_hUGC;
	}
}
