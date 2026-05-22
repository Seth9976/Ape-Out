using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000BA RID: 186
	[StructLayout(2)]
	public struct ClientGameServerDeny_t
	{
		// Token: 0x06000812 RID: 2066 RVA: 0x0002CDD8 File Offset: 0x0002AFD8
		// Note: this type is marked as 'beforefieldinit'.
		static ClientGameServerDeny_t()
		{
			Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ClientGameServerDeny_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr);
			ClientGameServerDeny_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "k_iCallback");
			ClientGameServerDeny_t.NativeFieldInfoPtr_m_uAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "m_uAppID");
			ClientGameServerDeny_t.NativeFieldInfoPtr_m_unGameServerIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "m_unGameServerIP");
			ClientGameServerDeny_t.NativeFieldInfoPtr_m_usGameServerPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "m_usGameServerPort");
			ClientGameServerDeny_t.NativeFieldInfoPtr_m_bSecure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "m_bSecure");
			ClientGameServerDeny_t.NativeFieldInfoPtr_m_uReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "m_uReason");
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00005155 File Offset: 0x00003355
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x0002CE80 File Offset: 0x0002B080
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x00005167 File Offset: 0x00003367
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ClientGameServerDeny_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientGameServerDeny_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeFieldInfoPtr_m_uAppID;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeFieldInfoPtr_m_unGameServerIP;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeFieldInfoPtr_m_usGameServerPort;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeFieldInfoPtr_m_bSecure;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeFieldInfoPtr_m_uReason;

		// Token: 0x0400073D RID: 1853
		[FieldOffset(0)]
		public uint m_uAppID;

		// Token: 0x0400073E RID: 1854
		[FieldOffset(4)]
		public uint m_unGameServerIP;

		// Token: 0x0400073F RID: 1855
		[FieldOffset(8)]
		public ushort m_usGameServerPort;

		// Token: 0x04000740 RID: 1856
		[FieldOffset(10)]
		public ushort m_bSecure;

		// Token: 0x04000741 RID: 1857
		[FieldOffset(12)]
		public uint m_uReason;
	}
}
