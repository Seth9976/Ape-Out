using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200008B RID: 139
	[StructLayout(2)]
	public struct RemoteStorageAppSyncStatusCheck_t
	{
		// Token: 0x060006CE RID: 1742 RVA: 0x0002A67C File Offset: 0x0002887C
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageAppSyncStatusCheck_t()
		{
			Il2CppClassPointerStore<RemoteStorageAppSyncStatusCheck_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageAppSyncStatusCheck_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageAppSyncStatusCheck_t>.NativeClassPtr);
			RemoteStorageAppSyncStatusCheck_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncStatusCheck_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageAppSyncStatusCheck_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncStatusCheck_t>.NativeClassPtr, "m_nAppID");
			RemoteStorageAppSyncStatusCheck_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncStatusCheck_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x000043B1 File Offset: 0x000025B1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageAppSyncStatusCheck_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0002A6E8 File Offset: 0x000288E8
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x000043C3 File Offset: 0x000025C3
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageAppSyncStatusCheck_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageAppSyncStatusCheck_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000614 RID: 1556
		[FieldOffset(0)]
		public AppId_t m_nAppID;

		// Token: 0x04000615 RID: 1557
		[FieldOffset(4)]
		public EResult m_eResult;
	}
}
