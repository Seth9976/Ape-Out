using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000068 RID: 104
	public sealed class SteamInventoryRequestPricesResult_t : ValueType
	{
		// Token: 0x06000632 RID: 1586 RVA: 0x00029600 File Offset: 0x00027800
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryRequestPricesResult_t()
		{
			Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventoryRequestPricesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr);
			SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr, "k_iCallback");
			SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_m_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr, "m_result");
			SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_m_rgchCurrency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr, "m_rgchCurrency");
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00003C40 File Offset: 0x00001E40
		public SteamInventoryRequestPricesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00003C49 File Offset: 0x00001E49
		public SteamInventoryRequestPricesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInventoryRequestPricesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x0002966C File Offset: 0x0002786C
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00003C5B File Offset: 0x00001E5B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00029688 File Offset: 0x00027888
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00003C69 File Offset: 0x00001E69
		public unsafe EResult m_result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_m_result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_m_result)) = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x000296B0 File Offset: 0x000278B0
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x00003C84 File Offset: 0x00001E84
		public unsafe string m_rgchCurrency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_m_rgchCurrency);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInventoryRequestPricesResult_t.NativeFieldInfoPtr_m_rgchCurrency), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeFieldInfoPtr_m_result;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchCurrency;
	}
}
