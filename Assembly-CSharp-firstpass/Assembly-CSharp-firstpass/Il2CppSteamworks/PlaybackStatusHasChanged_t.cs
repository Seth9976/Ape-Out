using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000074 RID: 116
	[StructLayout(2)]
	public struct PlaybackStatusHasChanged_t
	{
		// Token: 0x06000667 RID: 1639 RVA: 0x00003E03 File Offset: 0x00002003
		// Note: this type is marked as 'beforefieldinit'.
		static PlaybackStatusHasChanged_t()
		{
			Il2CppClassPointerStore<PlaybackStatusHasChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "PlaybackStatusHasChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaybackStatusHasChanged_t>.NativeClassPtr);
			PlaybackStatusHasChanged_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaybackStatusHasChanged_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00003E3C File Offset: 0x0000203C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlaybackStatusHasChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x00029DC8 File Offset: 0x00027FC8
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x00003E4E File Offset: 0x0000204E
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PlaybackStatusHasChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlaybackStatusHasChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
