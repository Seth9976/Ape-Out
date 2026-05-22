using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000D1 RID: 209
	[StructLayout(2)]
	public struct SteamAPICallCompleted_t
	{
		// Token: 0x06000888 RID: 2184 RVA: 0x0002DBB8 File Offset: 0x0002BDB8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAPICallCompleted_t()
		{
			Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamAPICallCompleted_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr);
			SteamAPICallCompleted_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, "k_iCallback");
			SteamAPICallCompleted_t.NativeFieldInfoPtr_m_hAsyncCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, "m_hAsyncCall");
			SteamAPICallCompleted_t.NativeFieldInfoPtr_m_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, "m_iCallback");
			SteamAPICallCompleted_t.NativeFieldInfoPtr_m_cubParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, "m_cubParam");
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00005604 File Offset: 0x00003804
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamAPICallCompleted_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x0002DC38 File Offset: 0x0002BE38
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00005616 File Offset: 0x00003816
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamAPICallCompleted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamAPICallCompleted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeFieldInfoPtr_m_hAsyncCall;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeFieldInfoPtr_m_iCallback;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeFieldInfoPtr_m_cubParam;

		// Token: 0x040007AF RID: 1967
		[FieldOffset(0)]
		public SteamAPICall_t m_hAsyncCall;

		// Token: 0x040007B0 RID: 1968
		[FieldOffset(8)]
		public int m_iCallback;

		// Token: 0x040007B1 RID: 1969
		[FieldOffset(12)]
		public uint m_cubParam;
	}
}
