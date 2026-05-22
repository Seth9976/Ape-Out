using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000086 RID: 134
	[StructLayout(2)]
	public struct SocketStatusCallback_t
	{
		// Token: 0x060006AF RID: 1711 RVA: 0x0002A2EC File Offset: 0x000284EC
		// Note: this type is marked as 'beforefieldinit'.
		static SocketStatusCallback_t()
		{
			Il2CppClassPointerStore<SocketStatusCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SocketStatusCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketStatusCallback_t>.NativeClassPtr);
			SocketStatusCallback_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketStatusCallback_t>.NativeClassPtr, "k_iCallback");
			SocketStatusCallback_t.NativeFieldInfoPtr_m_hSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketStatusCallback_t>.NativeClassPtr, "m_hSocket");
			SocketStatusCallback_t.NativeFieldInfoPtr_m_hListenSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketStatusCallback_t>.NativeClassPtr, "m_hListenSocket");
			SocketStatusCallback_t.NativeFieldInfoPtr_m_steamIDRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketStatusCallback_t>.NativeClassPtr, "m_steamIDRemote");
			SocketStatusCallback_t.NativeFieldInfoPtr_m_eSNetSocketState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketStatusCallback_t>.NativeClassPtr, "m_eSNetSocketState");
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00004244 File Offset: 0x00002444
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SocketStatusCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0002A380 File Offset: 0x00028580
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x00004256 File Offset: 0x00002456
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SocketStatusCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SocketStatusCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeFieldInfoPtr_m_hSocket;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeFieldInfoPtr_m_hListenSocket;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDRemote;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeFieldInfoPtr_m_eSNetSocketState;

		// Token: 0x040005F8 RID: 1528
		[FieldOffset(0)]
		public SNetSocket_t m_hSocket;

		// Token: 0x040005F9 RID: 1529
		[FieldOffset(4)]
		public SNetListenSocket_t m_hListenSocket;

		// Token: 0x040005FA RID: 1530
		[FieldOffset(8)]
		public CSteamID m_steamIDRemote;

		// Token: 0x040005FB RID: 1531
		[FieldOffset(16)]
		public int m_eSNetSocketState;
	}
}
