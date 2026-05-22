using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000A9 RID: 169
	[StructLayout(2)]
	public struct SubmitItemUpdateResult_t
	{
		// Token: 0x060007C3 RID: 1987 RVA: 0x0002C390 File Offset: 0x0002A590
		// Note: this type is marked as 'beforefieldinit'.
		static SubmitItemUpdateResult_t()
		{
			Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SubmitItemUpdateResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr);
			SubmitItemUpdateResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, "k_iCallback");
			SubmitItemUpdateResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, "m_eResult");
			SubmitItemUpdateResult_t.NativeFieldInfoPtr_m_bUserNeedsToAcceptWorkshopLegalAgreement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, "m_bUserNeedsToAcceptWorkshopLegalAgreement");
			SubmitItemUpdateResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, "m_nPublishedFileId");
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00004E68 File Offset: 0x00003068
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x0002C410 File Offset: 0x0002A610
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x00004E7A File Offset: 0x0000307A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SubmitItemUpdateResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubmitItemUpdateResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr_m_bUserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x040006D9 RID: 1753
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x040006DA RID: 1754
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x040006DB RID: 1755
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
