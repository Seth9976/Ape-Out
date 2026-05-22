using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200007D RID: 125
	[StructLayout(2)]
	public struct MusicPlayerWantsPlayNext_t
	{
		// Token: 0x0600068B RID: 1675 RVA: 0x000040EB File Offset: 0x000022EB
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsPlayNext_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsPlayNext_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWantsPlayNext_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsPlayNext_t>.NativeClassPtr);
			MusicPlayerWantsPlayNext_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPlayNext_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00004124 File Offset: 0x00002324
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsPlayNext_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00029F1C File Offset: 0x0002811C
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00004136 File Offset: 0x00002336
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsPlayNext_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsPlayNext_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
