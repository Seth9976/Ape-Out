using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000070 RID: 112
	[StructLayout(2)]
	public struct LobbyMatchList_t
	{
		// Token: 0x06000657 RID: 1623 RVA: 0x00029BBC File Offset: 0x00027DBC
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyMatchList_t()
		{
			Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyMatchList_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr);
			LobbyMatchList_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr, "k_iCallback");
			LobbyMatchList_t.NativeFieldInfoPtr_m_nLobbiesMatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr, "m_nLobbiesMatching");
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00003D83 File Offset: 0x00001F83
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x00029C14 File Offset: 0x00027E14
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x00003D95 File Offset: 0x00001F95
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyMatchList_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyMatchList_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeFieldInfoPtr_m_nLobbiesMatching;

		// Token: 0x040005BD RID: 1469
		[FieldOffset(0)]
		public uint m_nLobbiesMatching;
	}
}
