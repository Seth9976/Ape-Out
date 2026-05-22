using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000022 RID: 34
	[StructLayout(2)]
	public struct SteamAppUninstalled_t
	{
		// Token: 0x06000482 RID: 1154 RVA: 0x000262C8 File Offset: 0x000244C8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAppUninstalled_t()
		{
			Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamAppUninstalled_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr);
			SteamAppUninstalled_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr, "k_iCallback");
			SteamAppUninstalled_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002ABF File Offset: 0x00000CBF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamAppUninstalled_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00026320 File Offset: 0x00024520
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00002AD1 File Offset: 0x00000CD1
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamAppUninstalled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamAppUninstalled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x040003EB RID: 1003
		[FieldOffset(0)]
		public AppId_t m_nAppID;
	}
}
