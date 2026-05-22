using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000AE RID: 174
	[StructLayout(2)]
	public struct GetUserItemVoteResult_t
	{
		// Token: 0x060007D7 RID: 2007 RVA: 0x0002C688 File Offset: 0x0002A888
		// Note: this type is marked as 'beforefieldinit'.
		static GetUserItemVoteResult_t()
		{
			Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GetUserItemVoteResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr);
			GetUserItemVoteResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "k_iCallback");
			GetUserItemVoteResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "m_nPublishedFileId");
			GetUserItemVoteResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "m_eResult");
			GetUserItemVoteResult_t.NativeFieldInfoPtr_m_bVotedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "m_bVotedUp");
			GetUserItemVoteResult_t.NativeFieldInfoPtr_m_bVotedDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "m_bVotedDown");
			GetUserItemVoteResult_t.NativeFieldInfoPtr_m_bVoteSkipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "m_bVoteSkipped");
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00004F08 File Offset: 0x00003108
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x0002C730 File Offset: 0x0002A930
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x00004F1A File Offset: 0x0000311A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetUserItemVoteResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetUserItemVoteResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeFieldInfoPtr_m_bVotedUp;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeFieldInfoPtr_m_bVotedDown;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeFieldInfoPtr_m_bVoteSkipped;

		// Token: 0x040006FC RID: 1788
		[FieldOffset(0)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040006FD RID: 1789
		[FieldOffset(8)]
		public EResult m_eResult;

		// Token: 0x040006FE RID: 1790
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool m_bVotedUp;

		// Token: 0x040006FF RID: 1791
		[FieldOffset(13)]
		[MarshalAs(4)]
		public bool m_bVotedDown;

		// Token: 0x04000700 RID: 1792
		[FieldOffset(14)]
		[MarshalAs(4)]
		public bool m_bVoteSkipped;
	}
}
