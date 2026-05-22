using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000A2 RID: 162
	[StructLayout(2)]
	public struct RemoteStorageFileWriteAsyncComplete_t
	{
		// Token: 0x060007A2 RID: 1954 RVA: 0x0002BF88 File Offset: 0x0002A188
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageFileWriteAsyncComplete_t()
		{
			Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageFileWriteAsyncComplete_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr);
			RemoteStorageFileWriteAsyncComplete_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageFileWriteAsyncComplete_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00004CFD File Offset: 0x00002EFD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x0002BFE0 File Offset: 0x0002A1E0
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x00004D0F File Offset: 0x00002F0F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageFileWriteAsyncComplete_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageFileWriteAsyncComplete_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040006B0 RID: 1712
		[FieldOffset(0)]
		public EResult m_eResult;
	}
}
