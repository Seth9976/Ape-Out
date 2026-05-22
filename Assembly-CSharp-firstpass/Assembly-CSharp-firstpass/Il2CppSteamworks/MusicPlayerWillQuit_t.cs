using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000079 RID: 121
	[StructLayout(2)]
	public struct MusicPlayerWillQuit_t
	{
		// Token: 0x0600067B RID: 1659 RVA: 0x00003F87 File Offset: 0x00002187
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWillQuit_t()
		{
			Il2CppClassPointerStore<MusicPlayerWillQuit_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWillQuit_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWillQuit_t>.NativeClassPtr);
			MusicPlayerWillQuit_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWillQuit_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00003FC0 File Offset: 0x000021C0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWillQuit_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x00029EAC File Offset: 0x000280AC
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x00003FD2 File Offset: 0x000021D2
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWillQuit_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWillQuit_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
