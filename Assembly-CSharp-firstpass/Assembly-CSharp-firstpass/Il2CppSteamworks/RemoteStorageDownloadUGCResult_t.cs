using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000094 RID: 148
	public sealed class RemoteStorageDownloadUGCResult_t : ValueType
	{
		// Token: 0x0600070D RID: 1805 RVA: 0x0002ADDC File Offset: 0x00028FDC
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageDownloadUGCResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageDownloadUGCResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr);
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_hFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "m_hFile");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "m_nAppID");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_nSizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "m_nSizeInBytes");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_pchFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "m_pchFileName");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_ulSteamIDOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "m_ulSteamIDOwner");
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00004640 File Offset: 0x00002840
		public RemoteStorageDownloadUGCResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00004649 File Offset: 0x00002849
		public RemoteStorageDownloadUGCResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0002AE98 File Offset: 0x00029098
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x0000465B File Offset: 0x0000285B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0002AEB4 File Offset: 0x000290B4
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x00004669 File Offset: 0x00002869
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0002AEDC File Offset: 0x000290DC
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00004684 File Offset: 0x00002884
		public unsafe UGCHandle_t m_hFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_hFile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_hFile)) = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0002AF04 File Offset: 0x00029104
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x0000469F File Offset: 0x0000289F
		public unsafe AppId_t m_nAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_nAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_nAppID)) = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0002AF2C File Offset: 0x0002912C
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x000046BA File Offset: 0x000028BA
		public unsafe int m_nSizeInBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_nSizeInBytes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_nSizeInBytes)) = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0002AF54 File Offset: 0x00029154
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x000046D5 File Offset: 0x000028D5
		public unsafe string m_pchFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_pchFileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_pchFileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x0002AF7C File Offset: 0x0002917C
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x000046F4 File Offset: 0x000028F4
		public unsafe ulong m_ulSteamIDOwner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_ulSteamIDOwner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_ulSteamIDOwner)) = value;
			}
		}

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeFieldInfoPtr_m_hFile;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeFieldInfoPtr_m_nSizeInBytes;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeFieldInfoPtr_m_pchFileName;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDOwner;
	}
}
