using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000C5 RID: 197
	public sealed class UserAchievementStored_t : ValueType
	{
		// Token: 0x06000844 RID: 2116 RVA: 0x0002D3BC File Offset: 0x0002B5BC
		// Note: this type is marked as 'beforefieldinit'.
		static UserAchievementStored_t()
		{
			Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UserAchievementStored_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr);
			UserAchievementStored_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "k_iCallback");
			UserAchievementStored_t.NativeFieldInfoPtr_m_nGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "m_nGameID");
			UserAchievementStored_t.NativeFieldInfoPtr_m_bGroupAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "m_bGroupAchievement");
			UserAchievementStored_t.NativeFieldInfoPtr_m_rgchAchievementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "m_rgchAchievementName");
			UserAchievementStored_t.NativeFieldInfoPtr_m_nCurProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "m_nCurProgress");
			UserAchievementStored_t.NativeFieldInfoPtr_m_nMaxProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr, "m_nMaxProgress");
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0000533E File Offset: 0x0000353E
		public UserAchievementStored_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00005347 File Offset: 0x00003547
		public UserAchievementStored_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserAchievementStored_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x0002D464 File Offset: 0x0002B664
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x00005359 File Offset: 0x00003559
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserAchievementStored_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserAchievementStored_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x0002D480 File Offset: 0x0002B680
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x00005367 File Offset: 0x00003567
		public unsafe ulong m_nGameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_nGameID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_nGameID)) = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x0002D4A8 File Offset: 0x0002B6A8
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x00005382 File Offset: 0x00003582
		public unsafe bool m_bGroupAchievement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_bGroupAchievement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_bGroupAchievement)) = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0002D4D0 File Offset: 0x0002B6D0
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x0000539D File Offset: 0x0000359D
		public unsafe string m_rgchAchievementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_rgchAchievementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_rgchAchievementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x0002D4F8 File Offset: 0x0002B6F8
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x000053BC File Offset: 0x000035BC
		public unsafe uint m_nCurProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_nCurProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_nCurProgress)) = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0002D520 File Offset: 0x0002B720
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x000053D7 File Offset: 0x000035D7
		public unsafe uint m_nMaxProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_nMaxProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementStored_t.NativeFieldInfoPtr_m_nMaxProgress)) = value;
			}
		}

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeFieldInfoPtr_m_nGameID;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeFieldInfoPtr_m_bGroupAchievement;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchAchievementName;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeFieldInfoPtr_m_nCurProgress;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeFieldInfoPtr_m_nMaxProgress;
	}
}
