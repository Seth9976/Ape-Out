using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000069 RID: 105
	[StructLayout(2)]
	public struct FavoritesListChanged_t
	{
		// Token: 0x0600063B RID: 1595 RVA: 0x000296D8 File Offset: 0x000278D8
		// Note: this type is marked as 'beforefieldinit'.
		static FavoritesListChanged_t()
		{
			Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FavoritesListChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr);
			FavoritesListChanged_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "k_iCallback");
			FavoritesListChanged_t.NativeFieldInfoPtr_m_nIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "m_nIP");
			FavoritesListChanged_t.NativeFieldInfoPtr_m_nQueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "m_nQueryPort");
			FavoritesListChanged_t.NativeFieldInfoPtr_m_nConnPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "m_nConnPort");
			FavoritesListChanged_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "m_nAppID");
			FavoritesListChanged_t.NativeFieldInfoPtr_m_nFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "m_nFlags");
			FavoritesListChanged_t.NativeFieldInfoPtr_m_bAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "m_bAdd");
			FavoritesListChanged_t.NativeFieldInfoPtr_m_unAccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, "m_unAccountId");
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00003CA3 File Offset: 0x00001EA3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FavoritesListChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x000297A8 File Offset: 0x000279A8
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x00003CB5 File Offset: 0x00001EB5
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FavoritesListChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FavoritesListChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeFieldInfoPtr_m_nIP;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeFieldInfoPtr_m_nQueryPort;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeFieldInfoPtr_m_nConnPort;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeFieldInfoPtr_m_nFlags;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeFieldInfoPtr_m_bAdd;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeFieldInfoPtr_m_unAccountId;

		// Token: 0x04000582 RID: 1410
		[FieldOffset(0)]
		public uint m_nIP;

		// Token: 0x04000583 RID: 1411
		[FieldOffset(4)]
		public uint m_nQueryPort;

		// Token: 0x04000584 RID: 1412
		[FieldOffset(8)]
		public uint m_nConnPort;

		// Token: 0x04000585 RID: 1413
		[FieldOffset(12)]
		public uint m_nAppID;

		// Token: 0x04000586 RID: 1414
		[FieldOffset(16)]
		public uint m_nFlags;

		// Token: 0x04000587 RID: 1415
		[FieldOffset(20)]
		[MarshalAs(4)]
		public bool m_bAdd;

		// Token: 0x04000588 RID: 1416
		[FieldOffset(24)]
		public AccountID_t m_unAccountId;
	}
}
