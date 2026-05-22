using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000026 RID: 38
	public sealed class AppProofOfPurchaseKeyResponse_t : ValueType
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x00026454 File Offset: 0x00024654
		// Note: this type is marked as 'beforefieldinit'.
		static AppProofOfPurchaseKeyResponse_t()
		{
			Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "AppProofOfPurchaseKeyResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr);
			AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, "k_iCallback");
			AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, "m_eResult");
			AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, "m_nAppID");
			AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_cchKeyLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, "m_cchKeyLength");
			AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_rgchKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr, "m_rgchKey");
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002B78 File Offset: 0x00000D78
		public AppProofOfPurchaseKeyResponse_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00002B81 File Offset: 0x00000D81
		public AppProofOfPurchaseKeyResponse_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppProofOfPurchaseKeyResponse_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x000264E8 File Offset: 0x000246E8
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00002B93 File Offset: 0x00000D93
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00026504 File Offset: 0x00024704
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00002BA1 File Offset: 0x00000DA1
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0002652C File Offset: 0x0002472C
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00002BBC File Offset: 0x00000DBC
		public unsafe uint m_nAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_nAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_nAppID)) = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00026554 File Offset: 0x00024754
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00002BD7 File Offset: 0x00000DD7
		public unsafe uint m_cchKeyLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_cchKeyLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_cchKeyLength)) = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0002657C File Offset: 0x0002477C
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00002BF2 File Offset: 0x00000DF2
		public unsafe string m_rgchKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_rgchKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppProofOfPurchaseKeyResponse_t.NativeFieldInfoPtr_m_rgchKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeFieldInfoPtr_m_cchKeyLength;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchKey;
	}
}
