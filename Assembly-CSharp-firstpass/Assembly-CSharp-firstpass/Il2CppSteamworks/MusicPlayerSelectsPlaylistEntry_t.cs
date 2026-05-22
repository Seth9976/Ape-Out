using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000082 RID: 130
	[StructLayout(2)]
	public struct MusicPlayerSelectsPlaylistEntry_t
	{
		// Token: 0x0600069F RID: 1695 RVA: 0x0002A108 File Offset: 0x00028308
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerSelectsPlaylistEntry_t()
		{
			Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerSelectsPlaylistEntry_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr);
			MusicPlayerSelectsPlaylistEntry_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr, "k_iCallback");
			MusicPlayerSelectsPlaylistEntry_t.NativeFieldInfoPtr_nID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr, "nID");
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000041C4 File Offset: 0x000023C4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerSelectsPlaylistEntry_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x0002A160 File Offset: 0x00028360
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x000041D6 File Offset: 0x000023D6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerSelectsPlaylistEntry_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerSelectsPlaylistEntry_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeFieldInfoPtr_nID;

		// Token: 0x040005E7 RID: 1511
		[FieldOffset(0)]
		public int nID;
	}
}
