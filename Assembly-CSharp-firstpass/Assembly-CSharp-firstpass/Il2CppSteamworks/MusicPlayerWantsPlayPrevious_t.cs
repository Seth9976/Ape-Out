using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200007C RID: 124
	[StructLayout(2)]
	public struct MusicPlayerWantsPlayPrevious_t
	{
		// Token: 0x06000687 RID: 1671 RVA: 0x00004092 File Offset: 0x00002292
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsPlayPrevious_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsPlayPrevious_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWantsPlayPrevious_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsPlayPrevious_t>.NativeClassPtr);
			MusicPlayerWantsPlayPrevious_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPlayPrevious_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000040CB File Offset: 0x000022CB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsPlayPrevious_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00029F00 File Offset: 0x00028100
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x000040DD File Offset: 0x000022DD
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsPlayPrevious_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsPlayPrevious_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
