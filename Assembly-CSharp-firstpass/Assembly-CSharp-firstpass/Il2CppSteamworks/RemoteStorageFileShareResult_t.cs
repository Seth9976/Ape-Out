using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200008C RID: 140
	public sealed class RemoteStorageFileShareResult_t : ValueType
	{
		// Token: 0x060006D2 RID: 1746 RVA: 0x0002A704 File Offset: 0x00028904
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageFileShareResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageFileShareResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr);
			RemoteStorageFileShareResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_hFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, "m_hFile");
			RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_rgchFilename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, "m_rgchFilename");
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000043D1 File Offset: 0x000025D1
		public RemoteStorageFileShareResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000043DA File Offset: 0x000025DA
		public RemoteStorageFileShareResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x0002A784 File Offset: 0x00028984
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x000043EC File Offset: 0x000025EC
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0002A7A0 File Offset: 0x000289A0
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x000043FA File Offset: 0x000025FA
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x0002A7C8 File Offset: 0x000289C8
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x00004415 File Offset: 0x00002615
		public unsafe UGCHandle_t m_hFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_hFile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_hFile)) = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x0002A7F0 File Offset: 0x000289F0
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x00004430 File Offset: 0x00002630
		public unsafe string m_rgchFilename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_rgchFilename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_rgchFilename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeFieldInfoPtr_m_hFile;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchFilename;
	}
}
