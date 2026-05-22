using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000A6 RID: 166
	[StructLayout(2)]
	public struct SteamUGCQueryCompleted_t
	{
		// Token: 0x060007B2 RID: 1970 RVA: 0x0002C150 File Offset: 0x0002A350
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUGCQueryCompleted_t()
		{
			Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamUGCQueryCompleted_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr);
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "k_iCallback");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "m_handle");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "m_eResult");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_unNumResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "m_unNumResultsReturned");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_unTotalMatchingResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "m_unTotalMatchingResults");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_bCachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "m_bCachedData");
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00004DB6 File Offset: 0x00002FB6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0002C1F8 File Offset: 0x0002A3F8
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x00004DC8 File Offset: 0x00002FC8
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeFieldInfoPtr_m_handle;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeFieldInfoPtr_m_unNumResultsReturned;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeFieldInfoPtr_m_unTotalMatchingResults;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeFieldInfoPtr_m_bCachedData;

		// Token: 0x040006C6 RID: 1734
		[FieldOffset(0)]
		public UGCQueryHandle_t m_handle;

		// Token: 0x040006C7 RID: 1735
		[FieldOffset(8)]
		public EResult m_eResult;

		// Token: 0x040006C8 RID: 1736
		[FieldOffset(12)]
		public uint m_unNumResultsReturned;

		// Token: 0x040006C9 RID: 1737
		[FieldOffset(16)]
		public uint m_unTotalMatchingResults;

		// Token: 0x040006CA RID: 1738
		[FieldOffset(20)]
		[MarshalAs(4)]
		public bool m_bCachedData;
	}
}
