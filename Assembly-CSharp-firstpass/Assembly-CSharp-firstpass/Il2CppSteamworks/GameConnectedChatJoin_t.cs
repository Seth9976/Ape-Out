using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000031 RID: 49
	[StructLayout(2)]
	public struct GameConnectedChatJoin_t
	{
		// Token: 0x060004DA RID: 1242 RVA: 0x00026CA0 File Offset: 0x00024EA0
		// Note: this type is marked as 'beforefieldinit'.
		static GameConnectedChatJoin_t()
		{
			Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameConnectedChatJoin_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr);
			GameConnectedChatJoin_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr, "k_iCallback");
			GameConnectedChatJoin_t.NativeFieldInfoPtr_m_steamIDClanChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr, "m_steamIDClanChat");
			GameConnectedChatJoin_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr, "m_steamIDUser");
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00002E54 File Offset: 0x00001054
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00026D0C File Offset: 0x00024F0C
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00002E66 File Offset: 0x00001066
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameConnectedChatJoin_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameConnectedChatJoin_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDClanChat;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x04000431 RID: 1073
		[FieldOffset(0)]
		public CSteamID m_steamIDClanChat;

		// Token: 0x04000432 RID: 1074
		[FieldOffset(8)]
		public CSteamID m_steamIDUser;
	}
}
