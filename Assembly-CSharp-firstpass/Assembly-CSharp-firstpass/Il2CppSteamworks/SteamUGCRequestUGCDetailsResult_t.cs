using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000A7 RID: 167
	public sealed class SteamUGCRequestUGCDetailsResult_t : ValueType
	{
		// Token: 0x060007B6 RID: 1974 RVA: 0x0002C214 File Offset: 0x0002A414
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUGCRequestUGCDetailsResult_t()
		{
			Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamUGCRequestUGCDetailsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr);
			SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr, "k_iCallback");
			SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_m_details = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr, "m_details");
			SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_m_bCachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr, "m_bCachedData");
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00004DD6 File Offset: 0x00002FD6
		public SteamUGCRequestUGCDetailsResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00004DDF File Offset: 0x00002FDF
		public SteamUGCRequestUGCDetailsResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x0002C280 File Offset: 0x0002A480
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x00004DF1 File Offset: 0x00002FF1
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x0002C29C File Offset: 0x0002A49C
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x00004DFF File Offset: 0x00002FFF
		public SteamUGCDetails_t m_details
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_m_details);
				return new SteamUGCDetails_t(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_m_details), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x0002C2CC File Offset: 0x0002A4CC
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x00004E2D File Offset: 0x0000302D
		public unsafe bool m_bCachedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_m_bCachedData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_m_bCachedData)) = value;
			}
		}

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr_m_details;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeFieldInfoPtr_m_bCachedData;
	}
}
