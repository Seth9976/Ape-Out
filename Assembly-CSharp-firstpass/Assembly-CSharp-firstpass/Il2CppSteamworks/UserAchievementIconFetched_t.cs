using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000CB RID: 203
	public sealed class UserAchievementIconFetched_t : ValueType
	{
		// Token: 0x06000867 RID: 2151 RVA: 0x0002D840 File Offset: 0x0002BA40
		// Note: this type is marked as 'beforefieldinit'.
		static UserAchievementIconFetched_t()
		{
			Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UserAchievementIconFetched_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr);
			UserAchievementIconFetched_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, "k_iCallback");
			UserAchievementIconFetched_t.NativeFieldInfoPtr_m_nGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, "m_nGameID");
			UserAchievementIconFetched_t.NativeFieldInfoPtr_m_rgchAchievementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, "m_rgchAchievementName");
			UserAchievementIconFetched_t.NativeFieldInfoPtr_m_bAchieved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, "m_bAchieved");
			UserAchievementIconFetched_t.NativeFieldInfoPtr_m_nIconHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, "m_nIconHandle");
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00005492 File Offset: 0x00003692
		public UserAchievementIconFetched_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0000549B File Offset: 0x0000369B
		public UserAchievementIconFetched_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr))
		{
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x0002D8D4 File Offset: 0x0002BAD4
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x000054AD File Offset: 0x000036AD
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserAchievementIconFetched_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserAchievementIconFetched_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0002D8F0 File Offset: 0x0002BAF0
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x000054BB File Offset: 0x000036BB
		public unsafe CGameID m_nGameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_m_nGameID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_m_nGameID)) = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x0002D918 File Offset: 0x0002BB18
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x000054D6 File Offset: 0x000036D6
		public unsafe string m_rgchAchievementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_m_rgchAchievementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_m_rgchAchievementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x0002D940 File Offset: 0x0002BB40
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x000054F5 File Offset: 0x000036F5
		public unsafe bool m_bAchieved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_m_bAchieved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_m_bAchieved)) = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x0002D968 File Offset: 0x0002BB68
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x00005510 File Offset: 0x00003710
		public unsafe int m_nIconHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_m_nIconHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_m_nIconHandle)) = value;
			}
		}

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeFieldInfoPtr_m_nGameID;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchAchievementName;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeFieldInfoPtr_m_bAchieved;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeFieldInfoPtr_m_nIconHandle;
	}
}
