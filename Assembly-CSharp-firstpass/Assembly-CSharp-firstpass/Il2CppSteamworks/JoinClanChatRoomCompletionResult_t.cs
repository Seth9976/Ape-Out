using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000034 RID: 52
	[StructLayout(2)]
	public struct JoinClanChatRoomCompletionResult_t
	{
		// Token: 0x060004E6 RID: 1254 RVA: 0x00026E4C File Offset: 0x0002504C
		// Note: this type is marked as 'beforefieldinit'.
		static JoinClanChatRoomCompletionResult_t()
		{
			Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "JoinClanChatRoomCompletionResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr);
			JoinClanChatRoomCompletionResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr, "k_iCallback");
			JoinClanChatRoomCompletionResult_t.NativeFieldInfoPtr_m_steamIDClanChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr, "m_steamIDClanChat");
			JoinClanChatRoomCompletionResult_t.NativeFieldInfoPtr_m_eChatRoomEnterResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr, "m_eChatRoomEnterResponse");
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00002EB4 File Offset: 0x000010B4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00026EB8 File Offset: 0x000250B8
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00002EC6 File Offset: 0x000010C6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(JoinClanChatRoomCompletionResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JoinClanChatRoomCompletionResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDClanChat;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeFieldInfoPtr_m_eChatRoomEnterResponse;

		// Token: 0x04000442 RID: 1090
		[FieldOffset(0)]
		public CSteamID m_steamIDClanChat;

		// Token: 0x04000443 RID: 1091
		[FieldOffset(8)]
		public EChatRoomEnterResponse m_eChatRoomEnterResponse;
	}
}
