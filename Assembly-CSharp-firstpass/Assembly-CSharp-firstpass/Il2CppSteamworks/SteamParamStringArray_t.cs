using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200012F RID: 303
	[StructLayout(2)]
	public struct SteamParamStringArray_t
	{
		// Token: 0x060009ED RID: 2541 RVA: 0x00030088 File Offset: 0x0002E288
		// Note: this type is marked as 'beforefieldinit'.
		static SteamParamStringArray_t()
		{
			Il2CppClassPointerStore<SteamParamStringArray_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamParamStringArray_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamParamStringArray_t>.NativeClassPtr);
			SteamParamStringArray_t.NativeFieldInfoPtr_m_ppStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParamStringArray_t>.NativeClassPtr, "m_ppStrings");
			SteamParamStringArray_t.NativeFieldInfoPtr_m_nNumStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParamStringArray_t>.NativeClassPtr, "m_nNumStrings");
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00006101 File Offset: 0x00004301
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamParamStringArray_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeFieldInfoPtr_m_ppStrings;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeFieldInfoPtr_m_nNumStrings;

		// Token: 0x04000CAF RID: 3247
		[FieldOffset(0)]
		public IntPtr m_ppStrings;

		// Token: 0x04000CB0 RID: 3248
		[FieldOffset(8)]
		public int m_nNumStrings;
	}
}
