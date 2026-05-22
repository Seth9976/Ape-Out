using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000077 RID: 119
	[StructLayout(2)]
	public struct MusicPlayerRemoteWillDeactivate_t
	{
		// Token: 0x06000673 RID: 1651 RVA: 0x00003ED5 File Offset: 0x000020D5
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerRemoteWillDeactivate_t()
		{
			Il2CppClassPointerStore<MusicPlayerRemoteWillDeactivate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerRemoteWillDeactivate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerRemoteWillDeactivate_t>.NativeClassPtr);
			MusicPlayerRemoteWillDeactivate_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerRemoteWillDeactivate_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00003F0E File Offset: 0x0000210E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerRemoteWillDeactivate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x00029E74 File Offset: 0x00028074
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x00003F20 File Offset: 0x00002120
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerRemoteWillDeactivate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerRemoteWillDeactivate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
