using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000064 RID: 100
	[StructLayout(2)]
	public struct SteamInventoryFullUpdate_t
	{
		// Token: 0x06000622 RID: 1570 RVA: 0x00029424 File Offset: 0x00027624
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryFullUpdate_t()
		{
			Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventoryFullUpdate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr);
			SteamInventoryFullUpdate_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr, "k_iCallback");
			SteamInventoryFullUpdate_t.NativeFieldInfoPtr_m_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr, "m_handle");
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00003B87 File Offset: 0x00001D87
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x0002947C File Offset: 0x0002767C
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x00003B99 File Offset: 0x00001D99
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryFullUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryFullUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeFieldInfoPtr_m_handle;

		// Token: 0x04000565 RID: 1381
		[FieldOffset(0)]
		public SteamInventoryResult_t m_handle;
	}
}
