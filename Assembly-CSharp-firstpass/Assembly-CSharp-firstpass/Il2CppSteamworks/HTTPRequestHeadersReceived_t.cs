using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000061 RID: 97
	[StructLayout(2)]
	public struct HTTPRequestHeadersReceived_t
	{
		// Token: 0x06000616 RID: 1558 RVA: 0x00029264 File Offset: 0x00027464
		// Note: this type is marked as 'beforefieldinit'.
		static HTTPRequestHeadersReceived_t()
		{
			Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTTPRequestHeadersReceived_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr);
			HTTPRequestHeadersReceived_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr, "k_iCallback");
			HTTPRequestHeadersReceived_t.NativeFieldInfoPtr_m_hRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr, "m_hRequest");
			HTTPRequestHeadersReceived_t.NativeFieldInfoPtr_m_ulContextValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr, "m_ulContextValue");
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00003B27 File Offset: 0x00001D27
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x000292D0 File Offset: 0x000274D0
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x00003B39 File Offset: 0x00001D39
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTTPRequestHeadersReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTTPRequestHeadersReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeFieldInfoPtr_m_hRequest;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeFieldInfoPtr_m_ulContextValue;

		// Token: 0x04000553 RID: 1363
		[FieldOffset(0)]
		public HTTPRequestHandle m_hRequest;

		// Token: 0x04000554 RID: 1364
		[FieldOffset(8)]
		public ulong m_ulContextValue;
	}
}
