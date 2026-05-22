using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200003D RID: 61
	public sealed class GSClientDeny_t : ValueType
	{
		// Token: 0x06000513 RID: 1299 RVA: 0x000273A0 File Offset: 0x000255A0
		// Note: this type is marked as 'beforefieldinit'.
		static GSClientDeny_t()
		{
			Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSClientDeny_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr);
			GSClientDeny_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, "k_iCallback");
			GSClientDeny_t.NativeFieldInfoPtr_m_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, "m_SteamID");
			GSClientDeny_t.NativeFieldInfoPtr_m_eDenyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, "m_eDenyReason");
			GSClientDeny_t.NativeFieldInfoPtr_m_rgchOptionalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, "m_rgchOptionalText");
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00003086 File Offset: 0x00001286
		public GSClientDeny_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0000308F File Offset: 0x0000128F
		public GSClientDeny_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00027420 File Offset: 0x00025620
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x000030A1 File Offset: 0x000012A1
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSClientDeny_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSClientDeny_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x0002743C File Offset: 0x0002563C
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x000030AF File Offset: 0x000012AF
		public unsafe CSteamID m_SteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_m_SteamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_m_SteamID)) = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00027464 File Offset: 0x00025664
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x000030CA File Offset: 0x000012CA
		public unsafe EDenyReason m_eDenyReason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_m_eDenyReason);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_m_eDenyReason)) = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0002748C File Offset: 0x0002568C
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x000030E5 File Offset: 0x000012E5
		public unsafe string m_rgchOptionalText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_m_rgchOptionalText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_m_rgchOptionalText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamID;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeFieldInfoPtr_m_eDenyReason;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchOptionalText;
	}
}
