using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000060 RID: 96
	[StructLayout(2)]
	public struct HTTPRequestCompleted_t
	{
		// Token: 0x06000612 RID: 1554 RVA: 0x000291A0 File Offset: 0x000273A0
		// Note: this type is marked as 'beforefieldinit'.
		static HTTPRequestCompleted_t()
		{
			Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTTPRequestCompleted_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr);
			HTTPRequestCompleted_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "k_iCallback");
			HTTPRequestCompleted_t.NativeFieldInfoPtr_m_hRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "m_hRequest");
			HTTPRequestCompleted_t.NativeFieldInfoPtr_m_ulContextValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "m_ulContextValue");
			HTTPRequestCompleted_t.NativeFieldInfoPtr_m_bRequestSuccessful = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "m_bRequestSuccessful");
			HTTPRequestCompleted_t.NativeFieldInfoPtr_m_eStatusCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "m_eStatusCode");
			HTTPRequestCompleted_t.NativeFieldInfoPtr_m_unBodySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "m_unBodySize");
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00003B07 File Offset: 0x00001D07
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00029248 File Offset: 0x00027448
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x00003B19 File Offset: 0x00001D19
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTTPRequestCompleted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTTPRequestCompleted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeFieldInfoPtr_m_hRequest;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeFieldInfoPtr_m_ulContextValue;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeFieldInfoPtr_m_bRequestSuccessful;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_m_eStatusCode;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr_m_unBodySize;

		// Token: 0x0400054B RID: 1355
		[FieldOffset(0)]
		public HTTPRequestHandle m_hRequest;

		// Token: 0x0400054C RID: 1356
		[FieldOffset(8)]
		public ulong m_ulContextValue;

		// Token: 0x0400054D RID: 1357
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool m_bRequestSuccessful;

		// Token: 0x0400054E RID: 1358
		[FieldOffset(20)]
		public EHTTPStatusCode m_eStatusCode;

		// Token: 0x0400054F RID: 1359
		[FieldOffset(24)]
		public uint m_unBodySize;
	}
}
