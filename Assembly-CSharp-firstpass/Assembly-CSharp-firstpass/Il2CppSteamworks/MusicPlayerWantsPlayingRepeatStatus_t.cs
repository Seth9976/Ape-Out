using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000083 RID: 131
	[StructLayout(2)]
	public struct MusicPlayerWantsPlayingRepeatStatus_t
	{
		// Token: 0x060006A3 RID: 1699 RVA: 0x0002A17C File Offset: 0x0002837C
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsPlayingRepeatStatus_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWantsPlayingRepeatStatus_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr);
			MusicPlayerWantsPlayingRepeatStatus_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr, "k_iCallback");
			MusicPlayerWantsPlayingRepeatStatus_t.NativeFieldInfoPtr_m_nPlayingRepeatStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr, "m_nPlayingRepeatStatus");
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x000041E4 File Offset: 0x000023E4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x0002A1D4 File Offset: 0x000283D4
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x000041F6 File Offset: 0x000023F6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsPlayingRepeatStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsPlayingRepeatStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeFieldInfoPtr_m_nPlayingRepeatStatus;

		// Token: 0x040005EA RID: 1514
		[FieldOffset(0)]
		public int m_nPlayingRepeatStatus;
	}
}
