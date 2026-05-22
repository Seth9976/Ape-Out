using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200007F RID: 127
	[StructLayout(2)]
	public struct MusicPlayerWantsLooped_t
	{
		// Token: 0x06000693 RID: 1683 RVA: 0x00029FAC File Offset: 0x000281AC
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsLooped_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWantsLooped_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr);
			MusicPlayerWantsLooped_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr, "k_iCallback");
			MusicPlayerWantsLooped_t.NativeFieldInfoPtr_m_bLooped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr, "m_bLooped");
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00004164 File Offset: 0x00002364
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsLooped_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x0002A004 File Offset: 0x00028204
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00004176 File Offset: 0x00002376
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsLooped_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsLooped_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeFieldInfoPtr_m_bLooped;

		// Token: 0x040005DE RID: 1502
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_bLooped;
	}
}
