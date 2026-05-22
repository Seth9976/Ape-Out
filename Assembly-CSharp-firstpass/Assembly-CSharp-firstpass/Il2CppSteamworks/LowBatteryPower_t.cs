using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000D0 RID: 208
	[StructLayout(2)]
	public struct LowBatteryPower_t
	{
		// Token: 0x06000884 RID: 2180 RVA: 0x0002DB44 File Offset: 0x0002BD44
		// Note: this type is marked as 'beforefieldinit'.
		static LowBatteryPower_t()
		{
			Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LowBatteryPower_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr);
			LowBatteryPower_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr, "k_iCallback");
			LowBatteryPower_t.NativeFieldInfoPtr_m_nMinutesBatteryLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr, "m_nMinutesBatteryLeft");
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000055E4 File Offset: 0x000037E4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x0002DB9C File Offset: 0x0002BD9C
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x000055F6 File Offset: 0x000037F6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LowBatteryPower_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LowBatteryPower_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeFieldInfoPtr_m_nMinutesBatteryLeft;

		// Token: 0x040007AA RID: 1962
		[FieldOffset(0)]
		public byte m_nMinutesBatteryLeft;
	}
}
