using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000062 RID: 98
	[StructLayout(2)]
	public struct HTTPRequestDataReceived_t
	{
		// Token: 0x0600061A RID: 1562 RVA: 0x000292EC File Offset: 0x000274EC
		// Note: this type is marked as 'beforefieldinit'.
		static HTTPRequestDataReceived_t()
		{
			Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTTPRequestDataReceived_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr);
			HTTPRequestDataReceived_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, "k_iCallback");
			HTTPRequestDataReceived_t.NativeFieldInfoPtr_m_hRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, "m_hRequest");
			HTTPRequestDataReceived_t.NativeFieldInfoPtr_m_ulContextValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, "m_ulContextValue");
			HTTPRequestDataReceived_t.NativeFieldInfoPtr_m_cOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, "m_cOffset");
			HTTPRequestDataReceived_t.NativeFieldInfoPtr_m_cBytesReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, "m_cBytesReceived");
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00003B47 File Offset: 0x00001D47
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00029380 File Offset: 0x00027580
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x00003B59 File Offset: 0x00001D59
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTTPRequestDataReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTTPRequestDataReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeFieldInfoPtr_m_hRequest;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr_m_ulContextValue;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeFieldInfoPtr_m_cOffset;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr_m_cBytesReceived;

		// Token: 0x0400055A RID: 1370
		[FieldOffset(0)]
		public HTTPRequestHandle m_hRequest;

		// Token: 0x0400055B RID: 1371
		[FieldOffset(8)]
		public ulong m_ulContextValue;

		// Token: 0x0400055C RID: 1372
		[FieldOffset(16)]
		public uint m_cOffset;

		// Token: 0x0400055D RID: 1373
		[FieldOffset(20)]
		public uint m_cBytesReceived;
	}
}
