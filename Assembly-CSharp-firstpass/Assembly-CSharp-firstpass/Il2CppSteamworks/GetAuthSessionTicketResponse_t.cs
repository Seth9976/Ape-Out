using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000C0 RID: 192
	[StructLayout(2)]
	public struct GetAuthSessionTicketResponse_t
	{
		// Token: 0x0600082A RID: 2090 RVA: 0x0002D0D8 File Offset: 0x0002B2D8
		// Note: this type is marked as 'beforefieldinit'.
		static GetAuthSessionTicketResponse_t()
		{
			Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GetAuthSessionTicketResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr);
			GetAuthSessionTicketResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, "k_iCallback");
			GetAuthSessionTicketResponse_t.NativeFieldInfoPtr_m_hAuthTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, "m_hAuthTicket");
			GetAuthSessionTicketResponse_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0000524E File Offset: 0x0000344E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x0002D144 File Offset: 0x0002B344
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x00005260 File Offset: 0x00003460
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetAuthSessionTicketResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetAuthSessionTicketResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeFieldInfoPtr_m_hAuthTicket;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x0400075A RID: 1882
		[FieldOffset(0)]
		public HAuthTicket m_hAuthTicket;

		// Token: 0x0400075B RID: 1883
		[FieldOffset(4)]
		public EResult m_eResult;
	}
}
