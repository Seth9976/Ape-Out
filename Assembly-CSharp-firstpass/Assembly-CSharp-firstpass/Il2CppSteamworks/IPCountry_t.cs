using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000CF RID: 207
	[StructLayout(2)]
	public struct IPCountry_t
	{
		// Token: 0x06000880 RID: 2176 RVA: 0x0000558B File Offset: 0x0000378B
		// Note: this type is marked as 'beforefieldinit'.
		static IPCountry_t()
		{
			Il2CppClassPointerStore<IPCountry_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "IPCountry_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPCountry_t>.NativeClassPtr);
			IPCountry_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPCountry_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x000055C4 File Offset: 0x000037C4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IPCountry_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x0002DB28 File Offset: 0x0002BD28
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x000055D6 File Offset: 0x000037D6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IPCountry_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPCountry_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
