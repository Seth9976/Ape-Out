using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000B9 RID: 185
	[StructLayout(2)]
	public struct SteamServersDisconnected_t
	{
		// Token: 0x0600080E RID: 2062 RVA: 0x0002CD64 File Offset: 0x0002AF64
		// Note: this type is marked as 'beforefieldinit'.
		static SteamServersDisconnected_t()
		{
			Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamServersDisconnected_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr);
			SteamServersDisconnected_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr, "k_iCallback");
			SteamServersDisconnected_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00005135 File Offset: 0x00003335
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x0002CDBC File Offset: 0x0002AFBC
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x00005147 File Offset: 0x00003347
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamServersDisconnected_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServersDisconnected_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000736 RID: 1846
		[FieldOffset(0)]
		public EResult m_eResult;
	}
}
