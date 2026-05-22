using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000081 RID: 129
	[StructLayout(2)]
	public struct MusicPlayerSelectsQueueEntry_t
	{
		// Token: 0x0600069B RID: 1691 RVA: 0x0002A094 File Offset: 0x00028294
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerSelectsQueueEntry_t()
		{
			Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerSelectsQueueEntry_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr);
			MusicPlayerSelectsQueueEntry_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr, "k_iCallback");
			MusicPlayerSelectsQueueEntry_t.NativeFieldInfoPtr_nID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr, "nID");
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x000041A4 File Offset: 0x000023A4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x0002A0EC File Offset: 0x000282EC
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x000041B6 File Offset: 0x000023B6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerSelectsQueueEntry_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerSelectsQueueEntry_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeFieldInfoPtr_nID;

		// Token: 0x040005E4 RID: 1508
		[FieldOffset(0)]
		public int nID;
	}
}
