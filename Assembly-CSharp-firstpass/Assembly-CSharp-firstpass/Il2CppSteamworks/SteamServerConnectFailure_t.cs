using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000B8 RID: 184
	[StructLayout(2)]
	public struct SteamServerConnectFailure_t
	{
		// Token: 0x0600080A RID: 2058 RVA: 0x0002CCDC File Offset: 0x0002AEDC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamServerConnectFailure_t()
		{
			Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamServerConnectFailure_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr);
			SteamServerConnectFailure_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, "k_iCallback");
			SteamServerConnectFailure_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, "m_eResult");
			SteamServerConnectFailure_t.NativeFieldInfoPtr_m_bStillRetrying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, "m_bStillRetrying");
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00005115 File Offset: 0x00003315
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x0002CD48 File Offset: 0x0002AF48
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x00005127 File Offset: 0x00003327
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamServerConnectFailure_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServerConnectFailure_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr_m_bStillRetrying;

		// Token: 0x04000732 RID: 1842
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04000733 RID: 1843
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool m_bStillRetrying;
	}
}
