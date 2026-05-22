using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000037 RID: 55
	[StructLayout(2)]
	public struct FriendsIsFollowing_t
	{
		// Token: 0x060004F2 RID: 1266 RVA: 0x00026FF8 File Offset: 0x000251F8
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsIsFollowing_t()
		{
			Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FriendsIsFollowing_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr);
			FriendsIsFollowing_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, "k_iCallback");
			FriendsIsFollowing_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, "m_eResult");
			FriendsIsFollowing_t.NativeFieldInfoPtr_m_steamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, "m_steamID");
			FriendsIsFollowing_t.NativeFieldInfoPtr_m_bIsFollowing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, "m_bIsFollowing");
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00002F14 File Offset: 0x00001114
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00027078 File Offset: 0x00025278
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00002F26 File Offset: 0x00001126
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FriendsIsFollowing_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendsIsFollowing_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeFieldInfoPtr_m_steamID;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeFieldInfoPtr_m_bIsFollowing;

		// Token: 0x04000454 RID: 1108
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04000455 RID: 1109
		[FieldOffset(4)]
		public CSteamID m_steamID;

		// Token: 0x04000456 RID: 1110
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool m_bIsFollowing;
	}
}
