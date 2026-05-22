using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200007B RID: 123
	[StructLayout(2)]
	public struct MusicPlayerWantsPause_t
	{
		// Token: 0x06000683 RID: 1667 RVA: 0x00004039 File Offset: 0x00002239
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsPause_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsPause_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWantsPause_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsPause_t>.NativeClassPtr);
			MusicPlayerWantsPause_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPause_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00004072 File Offset: 0x00002272
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsPause_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x00029EE4 File Offset: 0x000280E4
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00004084 File Offset: 0x00002284
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsPause_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsPause_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
