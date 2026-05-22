using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000D2 RID: 210
	[StructLayout(2)]
	public struct SteamShutdown_t
	{
		// Token: 0x0600088C RID: 2188 RVA: 0x00005624 File Offset: 0x00003824
		// Note: this type is marked as 'beforefieldinit'.
		static SteamShutdown_t()
		{
			Il2CppClassPointerStore<SteamShutdown_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamShutdown_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamShutdown_t>.NativeClassPtr);
			SteamShutdown_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamShutdown_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0000565D File Offset: 0x0000385D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamShutdown_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x0002DC54 File Offset: 0x0002BE54
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x0000566F File Offset: 0x0000386F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamShutdown_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamShutdown_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
