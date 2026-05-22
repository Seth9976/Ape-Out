using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000030 RID: 48
	[StructLayout(2)]
	public struct GameConnectedClanChatMsg_t
	{
		// Token: 0x060004D6 RID: 1238 RVA: 0x00026C04 File Offset: 0x00024E04
		// Note: this type is marked as 'beforefieldinit'.
		static GameConnectedClanChatMsg_t()
		{
			Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameConnectedClanChatMsg_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr);
			GameConnectedClanChatMsg_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, "k_iCallback");
			GameConnectedClanChatMsg_t.NativeFieldInfoPtr_m_steamIDClanChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, "m_steamIDClanChat");
			GameConnectedClanChatMsg_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, "m_steamIDUser");
			GameConnectedClanChatMsg_t.NativeFieldInfoPtr_m_iMessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, "m_iMessageID");
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00002E34 File Offset: 0x00001034
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00026C84 File Offset: 0x00024E84
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00002E46 File Offset: 0x00001046
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameConnectedClanChatMsg_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameConnectedClanChatMsg_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDClanChat;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeFieldInfoPtr_m_iMessageID;

		// Token: 0x0400042B RID: 1067
		[FieldOffset(0)]
		public CSteamID m_steamIDClanChat;

		// Token: 0x0400042C RID: 1068
		[FieldOffset(8)]
		public CSteamID m_steamIDUser;

		// Token: 0x0400042D RID: 1069
		[FieldOffset(16)]
		public int m_iMessageID;
	}
}
