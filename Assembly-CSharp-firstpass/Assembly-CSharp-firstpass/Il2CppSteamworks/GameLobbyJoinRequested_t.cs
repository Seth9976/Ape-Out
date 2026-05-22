using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200002B RID: 43
	[StructLayout(2)]
	public struct GameLobbyJoinRequested_t
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x000268D0 File Offset: 0x00024AD0
		// Note: this type is marked as 'beforefieldinit'.
		static GameLobbyJoinRequested_t()
		{
			Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameLobbyJoinRequested_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr);
			GameLobbyJoinRequested_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr, "k_iCallback");
			GameLobbyJoinRequested_t.NativeFieldInfoPtr_m_steamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr, "m_steamIDLobby");
			GameLobbyJoinRequested_t.NativeFieldInfoPtr_m_steamIDFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr, "m_steamIDFriend");
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002D51 File Offset: 0x00000F51
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x0002693C File Offset: 0x00024B3C
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00002D63 File Offset: 0x00000F63
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameLobbyJoinRequested_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameLobbyJoinRequested_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDLobby;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDFriend;

		// Token: 0x0400040D RID: 1037
		[FieldOffset(0)]
		public CSteamID m_steamIDLobby;

		// Token: 0x0400040E RID: 1038
		[FieldOffset(8)]
		public CSteamID m_steamIDFriend;
	}
}
