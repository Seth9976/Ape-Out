using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000038 RID: 56
	public sealed class FriendsEnumerateFollowingList_t : ValueType
	{
		// Token: 0x060004F6 RID: 1270 RVA: 0x00027094 File Offset: 0x00025294
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsEnumerateFollowingList_t()
		{
			Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FriendsEnumerateFollowingList_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr);
			FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, "k_iCallback");
			FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, "m_eResult");
			FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_rgSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, "m_rgSteamID");
			FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_nResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, "m_nResultsReturned");
			FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_nTotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, "m_nTotalResultCount");
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00002F34 File Offset: 0x00001134
		public FriendsEnumerateFollowingList_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00002F3D File Offset: 0x0000113D
		public FriendsEnumerateFollowingList_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00027128 File Offset: 0x00025328
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00002F4F File Offset: 0x0000114F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00027144 File Offset: 0x00025344
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00002F5D File Offset: 0x0000115D
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0002716C File Offset: 0x0002536C
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00002F78 File Offset: 0x00001178
		public unsafe Il2CppStructArray<CSteamID> m_rgSteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_rgSteamID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<CSteamID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_rgSteamID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x0002719C File Offset: 0x0002539C
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00002F97 File Offset: 0x00001197
		public unsafe int m_nResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_nResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_nResultsReturned)) = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x000271C4 File Offset: 0x000253C4
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x00002FB2 File Offset: 0x000011B2
		public unsafe int m_nTotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_nTotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_m_nTotalResultCount)) = value;
			}
		}

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeFieldInfoPtr_m_rgSteamID;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeFieldInfoPtr_m_nResultsReturned;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeFieldInfoPtr_m_nTotalResultCount;
	}
}
