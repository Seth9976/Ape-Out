using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000043 RID: 67
	[StructLayout(2)]
	public struct GSReputation_t
	{
		// Token: 0x06000539 RID: 1337 RVA: 0x00027824 File Offset: 0x00025A24
		// Note: this type is marked as 'beforefieldinit'.
		static GSReputation_t()
		{
			Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSReputation_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr);
			GSReputation_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "k_iCallback");
			GSReputation_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "m_eResult");
			GSReputation_t.NativeFieldInfoPtr_m_unReputationScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "m_unReputationScore");
			GSReputation_t.NativeFieldInfoPtr_m_bBanned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "m_bBanned");
			GSReputation_t.NativeFieldInfoPtr_m_unBannedIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "m_unBannedIP");
			GSReputation_t.NativeFieldInfoPtr_m_usBannedPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "m_usBannedPort");
			GSReputation_t.NativeFieldInfoPtr_m_ulBannedGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "m_ulBannedGameID");
			GSReputation_t.NativeFieldInfoPtr_m_unBanExpires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "m_unBanExpires");
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00003202 File Offset: 0x00001402
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x000278F4 File Offset: 0x00025AF4
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00003214 File Offset: 0x00001414
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSReputation_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSReputation_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeFieldInfoPtr_m_unReputationScore;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeFieldInfoPtr_m_bBanned;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeFieldInfoPtr_m_unBannedIP;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeFieldInfoPtr_m_usBannedPort;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeFieldInfoPtr_m_ulBannedGameID;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeFieldInfoPtr_m_unBanExpires;

		// Token: 0x04000496 RID: 1174
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04000497 RID: 1175
		[FieldOffset(4)]
		public uint m_unReputationScore;

		// Token: 0x04000498 RID: 1176
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool m_bBanned;

		// Token: 0x04000499 RID: 1177
		[FieldOffset(12)]
		public uint m_unBannedIP;

		// Token: 0x0400049A RID: 1178
		[FieldOffset(16)]
		public ushort m_usBannedPort;

		// Token: 0x0400049B RID: 1179
		[FieldOffset(24)]
		public ulong m_ulBannedGameID;

		// Token: 0x0400049C RID: 1180
		[FieldOffset(32)]
		public uint m_unBanExpires;
	}
}
