using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200002D RID: 45
	[StructLayout(2)]
	public struct ClanOfficerListResponse_t
	{
		// Token: 0x060004C5 RID: 1221 RVA: 0x00026A08 File Offset: 0x00024C08
		// Note: this type is marked as 'beforefieldinit'.
		static ClanOfficerListResponse_t()
		{
			Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ClanOfficerListResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr);
			ClanOfficerListResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, "k_iCallback");
			ClanOfficerListResponse_t.NativeFieldInfoPtr_m_steamIDClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, "m_steamIDClan");
			ClanOfficerListResponse_t.NativeFieldInfoPtr_m_cOfficers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, "m_cOfficers");
			ClanOfficerListResponse_t.NativeFieldInfoPtr_m_bSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, "m_bSuccess");
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002D91 File Offset: 0x00000F91
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00026A88 File Offset: 0x00024C88
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00002DA3 File Offset: 0x00000FA3
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ClanOfficerListResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClanOfficerListResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDClan;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeFieldInfoPtr_m_cOfficers;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeFieldInfoPtr_m_bSuccess;

		// Token: 0x0400041C RID: 1052
		[FieldOffset(0)]
		public CSteamID m_steamIDClan;

		// Token: 0x0400041D RID: 1053
		[FieldOffset(8)]
		public int m_cOfficers;

		// Token: 0x0400041E RID: 1054
		[FieldOffset(12)]
		public byte m_bSuccess;
	}
}
