using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000066 RID: 102
	[StructLayout(2)]
	public struct SteamInventoryEligiblePromoItemDefIDs_t
	{
		// Token: 0x0600062A RID: 1578 RVA: 0x000294B4 File Offset: 0x000276B4
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryEligiblePromoItemDefIDs_t()
		{
			Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventoryEligiblePromoItemDefIDs_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr);
			SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, "k_iCallback");
			SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_m_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, "m_result");
			SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_m_steamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, "m_steamID");
			SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_m_numEligiblePromoItemDefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, "m_numEligiblePromoItemDefs");
			SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_m_bCachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, "m_bCachedData");
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00003C00 File Offset: 0x00001E00
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00029548 File Offset: 0x00027748
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00003C12 File Offset: 0x00001E12
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeFieldInfoPtr_m_result;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeFieldInfoPtr_m_steamID;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeFieldInfoPtr_m_numEligiblePromoItemDefs;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeFieldInfoPtr_m_bCachedData;

		// Token: 0x0400056C RID: 1388
		[FieldOffset(0)]
		public EResult m_result;

		// Token: 0x0400056D RID: 1389
		[FieldOffset(4)]
		public CSteamID m_steamID;

		// Token: 0x0400056E RID: 1390
		[FieldOffset(12)]
		public int m_numEligiblePromoItemDefs;

		// Token: 0x0400056F RID: 1391
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool m_bCachedData;
	}
}
