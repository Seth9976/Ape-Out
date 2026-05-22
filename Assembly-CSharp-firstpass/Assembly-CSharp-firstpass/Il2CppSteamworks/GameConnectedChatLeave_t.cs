using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000032 RID: 50
	[StructLayout(2)]
	public struct GameConnectedChatLeave_t
	{
		// Token: 0x060004DE RID: 1246 RVA: 0x00026D28 File Offset: 0x00024F28
		// Note: this type is marked as 'beforefieldinit'.
		static GameConnectedChatLeave_t()
		{
			Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameConnectedChatLeave_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr);
			GameConnectedChatLeave_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, "k_iCallback");
			GameConnectedChatLeave_t.NativeFieldInfoPtr_m_steamIDClanChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, "m_steamIDClanChat");
			GameConnectedChatLeave_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, "m_steamIDUser");
			GameConnectedChatLeave_t.NativeFieldInfoPtr_m_bKicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, "m_bKicked");
			GameConnectedChatLeave_t.NativeFieldInfoPtr_m_bDropped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, "m_bDropped");
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00002E74 File Offset: 0x00001074
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00026DBC File Offset: 0x00024FBC
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00002E86 File Offset: 0x00001086
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameConnectedChatLeave_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameConnectedChatLeave_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDClanChat;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeFieldInfoPtr_m_bKicked;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeFieldInfoPtr_m_bDropped;

		// Token: 0x04000438 RID: 1080
		[FieldOffset(0)]
		public CSteamID m_steamIDClanChat;

		// Token: 0x04000439 RID: 1081
		[FieldOffset(8)]
		public CSteamID m_steamIDUser;

		// Token: 0x0400043A RID: 1082
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool m_bKicked;

		// Token: 0x0400043B RID: 1083
		[FieldOffset(17)]
		[MarshalAs(4)]
		public bool m_bDropped;
	}
}
