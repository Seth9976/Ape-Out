using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000067 RID: 103
	[StructLayout(2)]
	public struct SteamInventoryStartPurchaseResult_t
	{
		// Token: 0x0600062E RID: 1582 RVA: 0x00029564 File Offset: 0x00027764
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryStartPurchaseResult_t()
		{
			Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventoryStartPurchaseResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr);
			SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, "k_iCallback");
			SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr_m_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, "m_result");
			SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr_m_ulOrderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, "m_ulOrderID");
			SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr_m_ulTransID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, "m_ulTransID");
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00003C20 File Offset: 0x00001E20
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryStartPurchaseResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x000295E4 File Offset: 0x000277E4
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x00003C32 File Offset: 0x00001E32
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryStartPurchaseResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeFieldInfoPtr_m_result;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeFieldInfoPtr_m_ulOrderID;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeFieldInfoPtr_m_ulTransID;

		// Token: 0x04000574 RID: 1396
		[FieldOffset(0)]
		public EResult m_result;

		// Token: 0x04000575 RID: 1397
		[FieldOffset(8)]
		public ulong m_ulOrderID;

		// Token: 0x04000576 RID: 1398
		[FieldOffset(16)]
		public ulong m_ulTransID;
	}
}
