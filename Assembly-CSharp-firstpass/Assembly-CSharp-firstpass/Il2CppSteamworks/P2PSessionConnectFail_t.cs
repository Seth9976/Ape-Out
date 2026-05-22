using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000085 RID: 133
	[StructLayout(2)]
	public struct P2PSessionConnectFail_t
	{
		// Token: 0x060006AB RID: 1707 RVA: 0x0002A264 File Offset: 0x00028464
		// Note: this type is marked as 'beforefieldinit'.
		static P2PSessionConnectFail_t()
		{
			Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "P2PSessionConnectFail_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr);
			P2PSessionConnectFail_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr, "k_iCallback");
			P2PSessionConnectFail_t.NativeFieldInfoPtr_m_steamIDRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr, "m_steamIDRemote");
			P2PSessionConnectFail_t.NativeFieldInfoPtr_m_eP2PSessionError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr, "m_eP2PSessionError");
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00004224 File Offset: 0x00002424
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0002A2D0 File Offset: 0x000284D0
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x00004236 File Offset: 0x00002436
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(P2PSessionConnectFail_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(P2PSessionConnectFail_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDRemote;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeFieldInfoPtr_m_eP2PSessionError;

		// Token: 0x040005F1 RID: 1521
		[FieldOffset(0)]
		public CSteamID m_steamIDRemote;

		// Token: 0x040005F2 RID: 1522
		[FieldOffset(8)]
		public byte m_eP2PSessionError;
	}
}
