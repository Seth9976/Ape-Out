using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000063 RID: 99
	[StructLayout(2)]
	public struct SteamInventoryResultReady_t
	{
		// Token: 0x0600061E RID: 1566 RVA: 0x0002939C File Offset: 0x0002759C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryResultReady_t()
		{
			Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventoryResultReady_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr);
			SteamInventoryResultReady_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr, "k_iCallback");
			SteamInventoryResultReady_t.NativeFieldInfoPtr_m_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr, "m_handle");
			SteamInventoryResultReady_t.NativeFieldInfoPtr_m_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr, "m_result");
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00003B67 File Offset: 0x00001D67
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00029408 File Offset: 0x00027608
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00003B79 File Offset: 0x00001D79
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryResultReady_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryResultReady_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeFieldInfoPtr_m_handle;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeFieldInfoPtr_m_result;

		// Token: 0x04000561 RID: 1377
		[FieldOffset(0)]
		public SteamInventoryResult_t m_handle;

		// Token: 0x04000562 RID: 1378
		[FieldOffset(4)]
		public EResult m_result;
	}
}
