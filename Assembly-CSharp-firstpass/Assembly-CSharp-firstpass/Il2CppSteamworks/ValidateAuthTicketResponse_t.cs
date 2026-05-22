using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000BD RID: 189
	[StructLayout(2)]
	public struct ValidateAuthTicketResponse_t
	{
		// Token: 0x0600081E RID: 2078 RVA: 0x0002CF2C File Offset: 0x0002B12C
		// Note: this type is marked as 'beforefieldinit'.
		static ValidateAuthTicketResponse_t()
		{
			Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ValidateAuthTicketResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr);
			ValidateAuthTicketResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, "k_iCallback");
			ValidateAuthTicketResponse_t.NativeFieldInfoPtr_m_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, "m_SteamID");
			ValidateAuthTicketResponse_t.NativeFieldInfoPtr_m_eAuthSessionResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, "m_eAuthSessionResponse");
			ValidateAuthTicketResponse_t.NativeFieldInfoPtr_m_OwnerSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, "m_OwnerSteamID");
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x000051EE File Offset: 0x000033EE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x0002CFAC File Offset: 0x0002B1AC
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x00005200 File Offset: 0x00003400
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ValidateAuthTicketResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValidateAuthTicketResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamID;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeFieldInfoPtr_m_eAuthSessionResponse;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeFieldInfoPtr_m_OwnerSteamID;

		// Token: 0x0400074A RID: 1866
		[FieldOffset(0)]
		public CSteamID m_SteamID;

		// Token: 0x0400074B RID: 1867
		[FieldOffset(8)]
		public EAuthSessionResponse m_eAuthSessionResponse;

		// Token: 0x0400074C RID: 1868
		[FieldOffset(12)]
		public CSteamID m_OwnerSteamID;
	}
}
