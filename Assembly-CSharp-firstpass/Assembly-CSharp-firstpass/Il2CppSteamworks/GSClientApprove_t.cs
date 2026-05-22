using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200003C RID: 60
	[StructLayout(2)]
	public struct GSClientApprove_t
	{
		// Token: 0x0600050F RID: 1295 RVA: 0x00027318 File Offset: 0x00025518
		// Note: this type is marked as 'beforefieldinit'.
		static GSClientApprove_t()
		{
			Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSClientApprove_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr);
			GSClientApprove_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr, "k_iCallback");
			GSClientApprove_t.NativeFieldInfoPtr_m_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr, "m_SteamID");
			GSClientApprove_t.NativeFieldInfoPtr_m_OwnerSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr, "m_OwnerSteamID");
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00003066 File Offset: 0x00001266
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00027384 File Offset: 0x00025584
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x00003078 File Offset: 0x00001278
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSClientApprove_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSClientApprove_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamID;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeFieldInfoPtr_m_OwnerSteamID;

		// Token: 0x0400046A RID: 1130
		[FieldOffset(0)]
		public CSteamID m_SteamID;

		// Token: 0x0400046B RID: 1131
		[FieldOffset(8)]
		public CSteamID m_OwnerSteamID;
	}
}
