using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000AC RID: 172
	[StructLayout(2)]
	public struct UserFavoriteItemsListChanged_t
	{
		// Token: 0x060007CF RID: 1999 RVA: 0x0002C550 File Offset: 0x0002A750
		// Note: this type is marked as 'beforefieldinit'.
		static UserFavoriteItemsListChanged_t()
		{
			Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UserFavoriteItemsListChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr);
			UserFavoriteItemsListChanged_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, "k_iCallback");
			UserFavoriteItemsListChanged_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, "m_nPublishedFileId");
			UserFavoriteItemsListChanged_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, "m_eResult");
			UserFavoriteItemsListChanged_t.NativeFieldInfoPtr_m_bWasAddRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, "m_bWasAddRequest");
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00004EC8 File Offset: 0x000030C8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x0002C5D0 File Offset: 0x0002A7D0
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x00004EDA File Offset: 0x000030DA
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserFavoriteItemsListChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserFavoriteItemsListChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeFieldInfoPtr_m_bWasAddRequest;

		// Token: 0x040006EC RID: 1772
		[FieldOffset(0)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040006ED RID: 1773
		[FieldOffset(8)]
		public EResult m_eResult;

		// Token: 0x040006EE RID: 1774
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool m_bWasAddRequest;
	}
}
