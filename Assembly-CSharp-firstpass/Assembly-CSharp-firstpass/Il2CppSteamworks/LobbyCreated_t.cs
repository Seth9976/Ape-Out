using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000072 RID: 114
	[StructLayout(2)]
	public struct LobbyCreated_t
	{
		// Token: 0x0600065F RID: 1631 RVA: 0x00029CCC File Offset: 0x00027ECC
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyCreated_t()
		{
			Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyCreated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr);
			LobbyCreated_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr, "k_iCallback");
			LobbyCreated_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr, "m_eResult");
			LobbyCreated_t.NativeFieldInfoPtr_m_ulSteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr, "m_ulSteamIDLobby");
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00003DC3 File Offset: 0x00001FC3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x00029D38 File Offset: 0x00027F38
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x00003DD5 File Offset: 0x00001FD5
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyCreated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyCreated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDLobby;

		// Token: 0x040005C8 RID: 1480
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x040005C9 RID: 1481
		[FieldOffset(8)]
		public ulong m_ulSteamIDLobby;
	}
}
