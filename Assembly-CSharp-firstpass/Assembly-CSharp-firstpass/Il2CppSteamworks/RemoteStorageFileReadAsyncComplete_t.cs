using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000A3 RID: 163
	[StructLayout(2)]
	public struct RemoteStorageFileReadAsyncComplete_t
	{
		// Token: 0x060007A6 RID: 1958 RVA: 0x0002BFFC File Offset: 0x0002A1FC
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageFileReadAsyncComplete_t()
		{
			Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageFileReadAsyncComplete_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr);
			RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_m_hFileReadAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, "m_hFileReadAsync");
			RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, "m_eResult");
			RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_m_nOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, "m_nOffset");
			RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_m_cubRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, "m_cubRead");
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00004D1D File Offset: 0x00002F1D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageFileReadAsyncComplete_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x0002C090 File Offset: 0x0002A290
		// (set) Token: 0x060007A9 RID: 1961 RVA: 0x00004D2F File Offset: 0x00002F2F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageFileReadAsyncComplete_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeFieldInfoPtr_m_hFileReadAsync;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeFieldInfoPtr_m_nOffset;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeFieldInfoPtr_m_cubRead;

		// Token: 0x040006B6 RID: 1718
		[FieldOffset(0)]
		public SteamAPICall_t m_hFileReadAsync;

		// Token: 0x040006B7 RID: 1719
		[FieldOffset(8)]
		public EResult m_eResult;

		// Token: 0x040006B8 RID: 1720
		[FieldOffset(12)]
		public uint m_nOffset;

		// Token: 0x040006B9 RID: 1721
		[FieldOffset(16)]
		public uint m_cubRead;
	}
}
