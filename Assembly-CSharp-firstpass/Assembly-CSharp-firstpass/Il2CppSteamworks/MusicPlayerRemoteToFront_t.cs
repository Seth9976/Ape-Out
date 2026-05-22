using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000078 RID: 120
	[StructLayout(2)]
	public struct MusicPlayerRemoteToFront_t
	{
		// Token: 0x06000677 RID: 1655 RVA: 0x00003F2E File Offset: 0x0000212E
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerRemoteToFront_t()
		{
			Il2CppClassPointerStore<MusicPlayerRemoteToFront_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerRemoteToFront_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerRemoteToFront_t>.NativeClassPtr);
			MusicPlayerRemoteToFront_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerRemoteToFront_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00003F67 File Offset: 0x00002167
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerRemoteToFront_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00029E90 File Offset: 0x00028090
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00003F79 File Offset: 0x00002179
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerRemoteToFront_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerRemoteToFront_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
