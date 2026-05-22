using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200003F RID: 63
	public sealed class GSClientAchievementStatus_t : ValueType
	{
		// Token: 0x06000522 RID: 1314 RVA: 0x0002753C File Offset: 0x0002573C
		// Note: this type is marked as 'beforefieldinit'.
		static GSClientAchievementStatus_t()
		{
			Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSClientAchievementStatus_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr);
			GSClientAchievementStatus_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, "k_iCallback");
			GSClientAchievementStatus_t.NativeFieldInfoPtr_m_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, "m_SteamID");
			GSClientAchievementStatus_t.NativeFieldInfoPtr_m_pchAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, "m_pchAchievement");
			GSClientAchievementStatus_t.NativeFieldInfoPtr_m_bUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr, "m_bUnlocked");
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00003124 File Offset: 0x00001324
		public GSClientAchievementStatus_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000312D File Offset: 0x0000132D
		public GSClientAchievementStatus_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GSClientAchievementStatus_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x000275BC File Offset: 0x000257BC
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x0000313F File Offset: 0x0000133F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSClientAchievementStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSClientAchievementStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x000275D8 File Offset: 0x000257D8
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x0000314D File Offset: 0x0000134D
		public unsafe ulong m_SteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_m_SteamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_m_SteamID)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00027600 File Offset: 0x00025800
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00003168 File Offset: 0x00001368
		public unsafe string m_pchAchievement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_m_pchAchievement);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_m_pchAchievement), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00027628 File Offset: 0x00025828
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00003187 File Offset: 0x00001387
		public unsafe bool m_bUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_m_bUnlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientAchievementStatus_t.NativeFieldInfoPtr_m_bUnlocked)) = value;
			}
		}

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamID;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeFieldInfoPtr_m_pchAchievement;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeFieldInfoPtr_m_bUnlocked;
	}
}
