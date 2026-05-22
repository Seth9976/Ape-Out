using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000B7 RID: 183
	[StructLayout(2)]
	public struct SteamServersConnected_t
	{
		// Token: 0x06000806 RID: 2054 RVA: 0x000050BC File Offset: 0x000032BC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamServersConnected_t()
		{
			Il2CppClassPointerStore<SteamServersConnected_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamServersConnected_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServersConnected_t>.NativeClassPtr);
			SteamServersConnected_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServersConnected_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000050F5 File Offset: 0x000032F5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamServersConnected_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x0002CCC0 File Offset: 0x0002AEC0
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00005107 File Offset: 0x00003307
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamServersConnected_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServersConnected_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
