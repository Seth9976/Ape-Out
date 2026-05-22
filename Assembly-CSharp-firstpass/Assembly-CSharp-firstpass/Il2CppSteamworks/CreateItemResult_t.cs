using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000A8 RID: 168
	[StructLayout(2)]
	public struct CreateItemResult_t
	{
		// Token: 0x060007BF RID: 1983 RVA: 0x0002C2F4 File Offset: 0x0002A4F4
		// Note: this type is marked as 'beforefieldinit'.
		static CreateItemResult_t()
		{
			Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CreateItemResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr);
			CreateItemResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, "k_iCallback");
			CreateItemResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, "m_eResult");
			CreateItemResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, "m_nPublishedFileId");
			CreateItemResult_t.NativeFieldInfoPtr_m_bUserNeedsToAcceptWorkshopLegalAgreement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, "m_bUserNeedsToAcceptWorkshopLegalAgreement");
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00004E48 File Offset: 0x00003048
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x0002C374 File Offset: 0x0002A574
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x00004E5A File Offset: 0x0000305A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CreateItemResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CreateItemResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeFieldInfoPtr_m_bUserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x040006D2 RID: 1746
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x040006D3 RID: 1747
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040006D4 RID: 1748
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}
