using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000080 RID: 128
	[StructLayout(2)]
	public struct MusicPlayerWantsVolume_t
	{
		// Token: 0x06000697 RID: 1687 RVA: 0x0002A020 File Offset: 0x00028220
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsVolume_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWantsVolume_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr);
			MusicPlayerWantsVolume_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr, "k_iCallback");
			MusicPlayerWantsVolume_t.NativeFieldInfoPtr_m_flNewVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr, "m_flNewVolume");
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00004184 File Offset: 0x00002384
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsVolume_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x0002A078 File Offset: 0x00028278
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00004196 File Offset: 0x00002396
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsVolume_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsVolume_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeFieldInfoPtr_m_flNewVolume;

		// Token: 0x040005E1 RID: 1505
		[FieldOffset(0)]
		public float m_flNewVolume;
	}
}
