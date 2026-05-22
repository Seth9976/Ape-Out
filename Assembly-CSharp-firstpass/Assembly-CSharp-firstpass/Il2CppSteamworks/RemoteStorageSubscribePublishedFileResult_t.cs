using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000090 RID: 144
	[StructLayout(2)]
	public struct RemoteStorageSubscribePublishedFileResult_t
	{
		// Token: 0x060006F2 RID: 1778 RVA: 0x0002AA94 File Offset: 0x00028C94
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageSubscribePublishedFileResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageSubscribePublishedFileResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr);
			RemoteStorageSubscribePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageSubscribePublishedFileResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageSubscribePublishedFileResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr, "m_nPublishedFileId");
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00004528 File Offset: 0x00002728
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x0002AB00 File Offset: 0x00028D00
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x0000453A File Offset: 0x0000273A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageSubscribePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageSubscribePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x0400062E RID: 1582
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x0400062F RID: 1583
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
