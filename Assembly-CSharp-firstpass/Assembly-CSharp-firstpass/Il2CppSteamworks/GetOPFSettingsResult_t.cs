using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000D8 RID: 216
	[StructLayout(2)]
	public struct GetOPFSettingsResult_t
	{
		// Token: 0x060008AB RID: 2219 RVA: 0x0002DF10 File Offset: 0x0002C110
		// Note: this type is marked as 'beforefieldinit'.
		static GetOPFSettingsResult_t()
		{
			Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GetOPFSettingsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr);
			GetOPFSettingsResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr, "k_iCallback");
			GetOPFSettingsResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr, "m_eResult");
			GetOPFSettingsResult_t.NativeFieldInfoPtr_m_unVideoAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr, "m_unVideoAppID");
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x000057B4 File Offset: 0x000039B4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x0002DF7C File Offset: 0x0002C17C
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x000057C6 File Offset: 0x000039C6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetOPFSettingsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetOPFSettingsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeFieldInfoPtr_m_unVideoAppID;

		// Token: 0x040007C6 RID: 1990
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x040007C7 RID: 1991
		[FieldOffset(4)]
		public AppId_t m_unVideoAppID;
	}
}
