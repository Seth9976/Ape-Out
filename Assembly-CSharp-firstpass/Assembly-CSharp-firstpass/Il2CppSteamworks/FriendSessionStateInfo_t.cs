using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200012C RID: 300
	[StructLayout(2)]
	public struct FriendSessionStateInfo_t
	{
		// Token: 0x060009E7 RID: 2535 RVA: 0x0002FEE0 File Offset: 0x0002E0E0
		// Note: this type is marked as 'beforefieldinit'.
		static FriendSessionStateInfo_t()
		{
			Il2CppClassPointerStore<FriendSessionStateInfo_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FriendSessionStateInfo_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendSessionStateInfo_t>.NativeClassPtr);
			FriendSessionStateInfo_t.NativeFieldInfoPtr_m_uiOnlineSessionInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendSessionStateInfo_t>.NativeClassPtr, "m_uiOnlineSessionInstances");
			FriendSessionStateInfo_t.NativeFieldInfoPtr_m_uiPublishedToFriendsSessionInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendSessionStateInfo_t>.NativeClassPtr, "m_uiPublishedToFriendsSessionInstance");
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x000060CB File Offset: 0x000042CB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendSessionStateInfo_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeFieldInfoPtr_m_uiOnlineSessionInstances;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeFieldInfoPtr_m_uiPublishedToFriendsSessionInstance;

		// Token: 0x04000C93 RID: 3219
		[FieldOffset(0)]
		public uint m_uiOnlineSessionInstances;

		// Token: 0x04000C94 RID: 3220
		[FieldOffset(4)]
		public byte m_uiPublishedToFriendsSessionInstance;
	}
}
