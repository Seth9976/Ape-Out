using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000C9 RID: 201
	[StructLayout(2)]
	public struct NumberOfCurrentPlayers_t
	{
		// Token: 0x0600085F RID: 2143 RVA: 0x0002D744 File Offset: 0x0002B944
		// Note: this type is marked as 'beforefieldinit'.
		static NumberOfCurrentPlayers_t()
		{
			Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "NumberOfCurrentPlayers_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr);
			NumberOfCurrentPlayers_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr, "k_iCallback");
			NumberOfCurrentPlayers_t.NativeFieldInfoPtr_m_bSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr, "m_bSuccess");
			NumberOfCurrentPlayers_t.NativeFieldInfoPtr_m_cPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr, "m_cPlayers");
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00005452 File Offset: 0x00003652
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x0002D7B0 File Offset: 0x0002B9B0
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00005464 File Offset: 0x00003664
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(NumberOfCurrentPlayers_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberOfCurrentPlayers_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeFieldInfoPtr_m_bSuccess;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeFieldInfoPtr_m_cPlayers;

		// Token: 0x0400078E RID: 1934
		[FieldOffset(0)]
		public byte m_bSuccess;

		// Token: 0x0400078F RID: 1935
		[FieldOffset(4)]
		public int m_cPlayers;
	}
}
