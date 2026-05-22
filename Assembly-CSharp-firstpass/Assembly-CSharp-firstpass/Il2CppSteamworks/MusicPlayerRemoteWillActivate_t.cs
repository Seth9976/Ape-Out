using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000076 RID: 118
	[StructLayout(2)]
	public struct MusicPlayerRemoteWillActivate_t
	{
		// Token: 0x0600066F RID: 1647 RVA: 0x00003E7C File Offset: 0x0000207C
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerRemoteWillActivate_t()
		{
			Il2CppClassPointerStore<MusicPlayerRemoteWillActivate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerRemoteWillActivate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerRemoteWillActivate_t>.NativeClassPtr);
			MusicPlayerRemoteWillActivate_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerRemoteWillActivate_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00003EB5 File Offset: 0x000020B5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerRemoteWillActivate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x00029E58 File Offset: 0x00028058
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x00003EC7 File Offset: 0x000020C7
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerRemoteWillActivate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerRemoteWillActivate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
