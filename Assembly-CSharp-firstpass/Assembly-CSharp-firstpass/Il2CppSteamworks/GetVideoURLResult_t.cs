using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000D7 RID: 215
	public sealed class GetVideoURLResult_t : ValueType
	{
		// Token: 0x060008A0 RID: 2208 RVA: 0x0002DDFC File Offset: 0x0002BFFC
		// Note: this type is marked as 'beforefieldinit'.
		static GetVideoURLResult_t()
		{
			Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GetVideoURLResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr);
			GetVideoURLResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, "k_iCallback");
			GetVideoURLResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, "m_eResult");
			GetVideoURLResult_t.NativeFieldInfoPtr_m_unVideoAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, "m_unVideoAppID");
			GetVideoURLResult_t.NativeFieldInfoPtr_m_rgchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, "m_rgchURL");
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00005736 File Offset: 0x00003936
		public GetVideoURLResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0000573F File Offset: 0x0000393F
		public GetVideoURLResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0002DE7C File Offset: 0x0002C07C
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x00005751 File Offset: 0x00003951
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetVideoURLResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetVideoURLResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x0002DE98 File Offset: 0x0002C098
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x0000575F File Offset: 0x0000395F
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x0002DEC0 File Offset: 0x0002C0C0
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x0000577A File Offset: 0x0000397A
		public unsafe AppId_t m_unVideoAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_m_unVideoAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_m_unVideoAppID)) = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x0002DEE8 File Offset: 0x0002C0E8
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x00005795 File Offset: 0x00003995
		public unsafe string m_rgchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_m_rgchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_m_rgchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeFieldInfoPtr_m_unVideoAppID;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchURL;
	}
}
