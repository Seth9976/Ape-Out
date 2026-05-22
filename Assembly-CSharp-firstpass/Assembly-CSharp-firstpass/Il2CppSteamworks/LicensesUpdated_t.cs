using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000BC RID: 188
	[StructLayout(2)]
	public struct LicensesUpdated_t
	{
		// Token: 0x0600081A RID: 2074 RVA: 0x00005195 File Offset: 0x00003395
		// Note: this type is marked as 'beforefieldinit'.
		static LicensesUpdated_t()
		{
			Il2CppClassPointerStore<LicensesUpdated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LicensesUpdated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LicensesUpdated_t>.NativeClassPtr);
			LicensesUpdated_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensesUpdated_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x000051CE File Offset: 0x000033CE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LicensesUpdated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x0002CF10 File Offset: 0x0002B110
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x000051E0 File Offset: 0x000033E0
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LicensesUpdated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LicensesUpdated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
