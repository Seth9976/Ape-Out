using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200009E RID: 158
	[StructLayout(2)]
	public struct RemoteStorageSetUserPublishedFileActionResult_t
	{
		// Token: 0x06000785 RID: 1925 RVA: 0x0002BBF0 File Offset: 0x00029DF0
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageSetUserPublishedFileActionResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageSetUserPublishedFileActionResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr);
			RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr_m_eAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, "m_eAction");
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00004BCA File Offset: 0x00002DCA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x0002BC70 File Offset: 0x00029E70
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x00004BDC File Offset: 0x00002DDC
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeFieldInfoPtr_m_eAction;

		// Token: 0x04000698 RID: 1688
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04000699 RID: 1689
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400069A RID: 1690
		[FieldOffset(16)]
		public EWorkshopFileAction m_eAction;
	}
}
