using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000A0 RID: 160
	[StructLayout(2)]
	public struct RemoteStoragePublishFileProgress_t
	{
		// Token: 0x0600079A RID: 1946 RVA: 0x0002BE64 File Offset: 0x0002A064
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishFileProgress_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStoragePublishFileProgress_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr);
			RemoteStoragePublishFileProgress_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr, "k_iCallback");
			RemoteStoragePublishFileProgress_t.NativeFieldInfoPtr_m_dPercentFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr, "m_dPercentFile");
			RemoteStoragePublishFileProgress_t.NativeFieldInfoPtr_m_bPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr, "m_bPreview");
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00004CBD File Offset: 0x00002EBD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x0002BED0 File Offset: 0x0002A0D0
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x00004CCF File Offset: 0x00002ECF
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishFileProgress_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishFileProgress_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeFieldInfoPtr_m_dPercentFile;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeFieldInfoPtr_m_bPreview;

		// Token: 0x040006A5 RID: 1701
		[FieldOffset(0)]
		public double m_dPercentFile;

		// Token: 0x040006A6 RID: 1702
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool m_bPreview;
	}
}
