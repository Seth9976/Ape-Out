using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000087 RID: 135
	[StructLayout(2)]
	public struct SteamParentalSettingsChanged_t
	{
		// Token: 0x060006B3 RID: 1715 RVA: 0x00004264 File Offset: 0x00002464
		// Note: this type is marked as 'beforefieldinit'.
		static SteamParentalSettingsChanged_t()
		{
			Il2CppClassPointerStore<SteamParentalSettingsChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamParentalSettingsChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamParentalSettingsChanged_t>.NativeClassPtr);
			SteamParentalSettingsChanged_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParentalSettingsChanged_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0000429D File Offset: 0x0000249D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamParentalSettingsChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0002A39C File Offset: 0x0002859C
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x000042AF File Offset: 0x000024AF
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamParentalSettingsChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamParentalSettingsChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
