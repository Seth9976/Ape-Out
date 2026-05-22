using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000021 RID: 33
	[StructLayout(2)]
	public struct SteamAppInstalled_t
	{
		// Token: 0x0600047E RID: 1150 RVA: 0x00026254 File Offset: 0x00024454
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAppInstalled_t()
		{
			Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamAppInstalled_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr);
			SteamAppInstalled_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr, "k_iCallback");
			SteamAppInstalled_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00002A9F File Offset: 0x00000C9F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamAppInstalled_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x000262AC File Offset: 0x000244AC
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00002AB1 File Offset: 0x00000CB1
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamAppInstalled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamAppInstalled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x040003E8 RID: 1000
		[FieldOffset(0)]
		public AppId_t m_nAppID;
	}
}
