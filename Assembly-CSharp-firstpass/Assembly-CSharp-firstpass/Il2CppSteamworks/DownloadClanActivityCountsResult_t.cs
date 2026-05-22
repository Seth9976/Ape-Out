using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000033 RID: 51
	[StructLayout(2)]
	public struct DownloadClanActivityCountsResult_t
	{
		// Token: 0x060004E2 RID: 1250 RVA: 0x00026DD8 File Offset: 0x00024FD8
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadClanActivityCountsResult_t()
		{
			Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "DownloadClanActivityCountsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr);
			DownloadClanActivityCountsResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr, "k_iCallback");
			DownloadClanActivityCountsResult_t.NativeFieldInfoPtr_m_bSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr, "m_bSuccess");
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00002E94 File Offset: 0x00001094
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00026E30 File Offset: 0x00025030
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x00002EA6 File Offset: 0x000010A6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DownloadClanActivityCountsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DownloadClanActivityCountsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeFieldInfoPtr_m_bSuccess;

		// Token: 0x0400043E RID: 1086
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_bSuccess;
	}
}
