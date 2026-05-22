using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000036 RID: 54
	[StructLayout(2)]
	public struct FriendsGetFollowerCount_t
	{
		// Token: 0x060004EE RID: 1262 RVA: 0x00026F5C File Offset: 0x0002515C
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsGetFollowerCount_t()
		{
			Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FriendsGetFollowerCount_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr);
			FriendsGetFollowerCount_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, "k_iCallback");
			FriendsGetFollowerCount_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, "m_eResult");
			FriendsGetFollowerCount_t.NativeFieldInfoPtr_m_steamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, "m_steamID");
			FriendsGetFollowerCount_t.NativeFieldInfoPtr_m_nCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, "m_nCount");
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00002EF4 File Offset: 0x000010F4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00026FDC File Offset: 0x000251DC
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00002F06 File Offset: 0x00001106
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FriendsGetFollowerCount_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendsGetFollowerCount_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeFieldInfoPtr_m_steamID;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeFieldInfoPtr_m_nCount;

		// Token: 0x0400044D RID: 1101
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x0400044E RID: 1102
		[FieldOffset(4)]
		public CSteamID m_steamID;

		// Token: 0x0400044F RID: 1103
		[FieldOffset(12)]
		public int m_nCount;
	}
}
