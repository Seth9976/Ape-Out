using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000035 RID: 53
	[StructLayout(2)]
	public struct GameConnectedFriendChatMsg_t
	{
		// Token: 0x060004EA RID: 1258 RVA: 0x00026ED4 File Offset: 0x000250D4
		// Note: this type is marked as 'beforefieldinit'.
		static GameConnectedFriendChatMsg_t()
		{
			Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameConnectedFriendChatMsg_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr);
			GameConnectedFriendChatMsg_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr, "k_iCallback");
			GameConnectedFriendChatMsg_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr, "m_steamIDUser");
			GameConnectedFriendChatMsg_t.NativeFieldInfoPtr_m_iMessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr, "m_iMessageID");
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00002ED4 File Offset: 0x000010D4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00026F40 File Offset: 0x00025140
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00002EE6 File Offset: 0x000010E6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameConnectedFriendChatMsg_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameConnectedFriendChatMsg_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeFieldInfoPtr_m_iMessageID;

		// Token: 0x04000447 RID: 1095
		[FieldOffset(0)]
		public CSteamID m_steamIDUser;

		// Token: 0x04000448 RID: 1096
		[FieldOffset(8)]
		public int m_iMessageID;
	}
}
