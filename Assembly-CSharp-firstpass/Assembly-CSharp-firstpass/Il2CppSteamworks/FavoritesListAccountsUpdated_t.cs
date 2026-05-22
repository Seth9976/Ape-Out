using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000073 RID: 115
	[StructLayout(2)]
	public struct FavoritesListAccountsUpdated_t
	{
		// Token: 0x06000663 RID: 1635 RVA: 0x00029D54 File Offset: 0x00027F54
		// Note: this type is marked as 'beforefieldinit'.
		static FavoritesListAccountsUpdated_t()
		{
			Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FavoritesListAccountsUpdated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr);
			FavoritesListAccountsUpdated_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr, "k_iCallback");
			FavoritesListAccountsUpdated_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00003DE3 File Offset: 0x00001FE3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FavoritesListAccountsUpdated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00029DAC File Offset: 0x00027FAC
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x00003DF5 File Offset: 0x00001FF5
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FavoritesListAccountsUpdated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FavoritesListAccountsUpdated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040005CC RID: 1484
		[FieldOffset(0)]
		public EResult m_eResult;
	}
}
