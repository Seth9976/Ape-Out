using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000AD RID: 173
	[StructLayout(2)]
	public struct SetUserItemVoteResult_t
	{
		// Token: 0x060007D3 RID: 2003 RVA: 0x0002C5EC File Offset: 0x0002A7EC
		// Note: this type is marked as 'beforefieldinit'.
		static SetUserItemVoteResult_t()
		{
			Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SetUserItemVoteResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr);
			SetUserItemVoteResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, "k_iCallback");
			SetUserItemVoteResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, "m_nPublishedFileId");
			SetUserItemVoteResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, "m_eResult");
			SetUserItemVoteResult_t.NativeFieldInfoPtr_m_bVoteUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, "m_bVoteUp");
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00004EE8 File Offset: 0x000030E8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x0002C66C File Offset: 0x0002A86C
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x00004EFA File Offset: 0x000030FA
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SetUserItemVoteResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SetUserItemVoteResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeFieldInfoPtr_m_bVoteUp;

		// Token: 0x040006F3 RID: 1779
		[FieldOffset(0)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040006F4 RID: 1780
		[FieldOffset(8)]
		public EResult m_eResult;

		// Token: 0x040006F5 RID: 1781
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool m_bVoteUp;
	}
}
