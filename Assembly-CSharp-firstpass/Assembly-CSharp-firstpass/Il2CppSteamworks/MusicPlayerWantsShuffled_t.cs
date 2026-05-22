using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200007E RID: 126
	[StructLayout(2)]
	public struct MusicPlayerWantsShuffled_t
	{
		// Token: 0x0600068F RID: 1679 RVA: 0x00029F38 File Offset: 0x00028138
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsShuffled_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWantsShuffled_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr);
			MusicPlayerWantsShuffled_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr, "k_iCallback");
			MusicPlayerWantsShuffled_t.NativeFieldInfoPtr_m_bShuffled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr, "m_bShuffled");
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00004144 File Offset: 0x00002344
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00029F90 File Offset: 0x00028190
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00004156 File Offset: 0x00002356
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsShuffled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsShuffled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeFieldInfoPtr_m_bShuffled;

		// Token: 0x040005DB RID: 1499
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_bShuffled;
	}
}
