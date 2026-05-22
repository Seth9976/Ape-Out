using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200007A RID: 122
	[StructLayout(2)]
	public struct MusicPlayerWantsPlay_t
	{
		// Token: 0x0600067F RID: 1663 RVA: 0x00003FE0 File Offset: 0x000021E0
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsPlay_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsPlay_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWantsPlay_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsPlay_t>.NativeClassPtr);
			MusicPlayerWantsPlay_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPlay_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00004019 File Offset: 0x00002219
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsPlay_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x00029EC8 File Offset: 0x000280C8
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x0000402B File Offset: 0x0000222B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsPlay_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsPlay_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
