using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000024 RID: 36
	[StructLayout(2)]
	public struct RegisterActivationCodeResponse_t
	{
		// Token: 0x0600048A RID: 1162 RVA: 0x000263B0 File Offset: 0x000245B0
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterActivationCodeResponse_t()
		{
			Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RegisterActivationCodeResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr);
			RegisterActivationCodeResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr, "k_iCallback");
			RegisterActivationCodeResponse_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr, "m_eResult");
			RegisterActivationCodeResponse_t.NativeFieldInfoPtr_m_unPackageRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr, "m_unPackageRegistered");
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00002AFF File Offset: 0x00000CFF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0002641C File Offset: 0x0002461C
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x00002B11 File Offset: 0x00000D11
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegisterActivationCodeResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegisterActivationCodeResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeFieldInfoPtr_m_unPackageRegistered;

		// Token: 0x040003F2 RID: 1010
		[FieldOffset(0)]
		public ERegisterActivationCodeResult m_eResult;

		// Token: 0x040003F3 RID: 1011
		[FieldOffset(4)]
		public uint m_unPackageRegistered;
	}
}
