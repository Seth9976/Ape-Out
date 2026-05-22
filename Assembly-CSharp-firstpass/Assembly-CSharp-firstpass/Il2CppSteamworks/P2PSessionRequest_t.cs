using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000084 RID: 132
	[StructLayout(2)]
	public struct P2PSessionRequest_t
	{
		// Token: 0x060006A7 RID: 1703 RVA: 0x0002A1F0 File Offset: 0x000283F0
		// Note: this type is marked as 'beforefieldinit'.
		static P2PSessionRequest_t()
		{
			Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "P2PSessionRequest_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr);
			P2PSessionRequest_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr, "k_iCallback");
			P2PSessionRequest_t.NativeFieldInfoPtr_m_steamIDRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr, "m_steamIDRemote");
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00004204 File Offset: 0x00002404
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<P2PSessionRequest_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0002A248 File Offset: 0x00028448
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x00004216 File Offset: 0x00002416
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(P2PSessionRequest_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(P2PSessionRequest_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDRemote;

		// Token: 0x040005ED RID: 1517
		[FieldOffset(0)]
		public CSteamID m_steamIDRemote;
	}
}
