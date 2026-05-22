using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200002E RID: 46
	[StructLayout(2)]
	public struct FriendRichPresenceUpdate_t
	{
		// Token: 0x060004C9 RID: 1225 RVA: 0x00026AA4 File Offset: 0x00024CA4
		// Note: this type is marked as 'beforefieldinit'.
		static FriendRichPresenceUpdate_t()
		{
			Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FriendRichPresenceUpdate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr);
			FriendRichPresenceUpdate_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr, "k_iCallback");
			FriendRichPresenceUpdate_t.NativeFieldInfoPtr_m_steamIDFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr, "m_steamIDFriend");
			FriendRichPresenceUpdate_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00002DB1 File Offset: 0x00000FB1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00026B10 File Offset: 0x00024D10
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x00002DC3 File Offset: 0x00000FC3
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FriendRichPresenceUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendRichPresenceUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDFriend;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04000422 RID: 1058
		[FieldOffset(0)]
		public CSteamID m_steamIDFriend;

		// Token: 0x04000423 RID: 1059
		[FieldOffset(8)]
		public AppId_t m_nAppID;
	}
}
