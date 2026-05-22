using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200008D RID: 141
	[StructLayout(2)]
	public struct RemoteStoragePublishFileResult_t
	{
		// Token: 0x060006DD RID: 1757 RVA: 0x0002A818 File Offset: 0x00028A18
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishFileResult_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStoragePublishFileResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr);
			RemoteStoragePublishFileResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStoragePublishFileResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, "m_eResult");
			RemoteStoragePublishFileResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStoragePublishFileResult_t.NativeFieldInfoPtr_m_bUserNeedsToAcceptWorkshopLegalAgreement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, "m_bUserNeedsToAcceptWorkshopLegalAgreement");
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0000444F File Offset: 0x0000264F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x0002A898 File Offset: 0x00028A98
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x00004461 File Offset: 0x00002661
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeFieldInfoPtr_m_bUserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x0400061E RID: 1566
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x0400061F RID: 1567
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000620 RID: 1568
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}
