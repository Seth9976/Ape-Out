using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000093 RID: 147
	[StructLayout(2)]
	public struct RemoteStorageUpdatePublishedFileResult_t
	{
		// Token: 0x06000709 RID: 1801 RVA: 0x0002AD40 File Offset: 0x00028F40
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageUpdatePublishedFileResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageUpdatePublishedFileResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr);
			RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr_m_bUserNeedsToAcceptWorkshopLegalAgreement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, "m_bUserNeedsToAcceptWorkshopLegalAgreement");
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00004620 File Offset: 0x00002820
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x0002ADC0 File Offset: 0x00028FC0
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x00004632 File Offset: 0x00002832
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeFieldInfoPtr_m_bUserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x0400063F RID: 1599
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04000640 RID: 1600
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000641 RID: 1601
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}
