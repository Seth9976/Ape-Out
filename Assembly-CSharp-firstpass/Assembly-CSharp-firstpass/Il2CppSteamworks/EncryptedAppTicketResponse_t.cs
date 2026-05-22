using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000BF RID: 191
	[StructLayout(2)]
	public struct EncryptedAppTicketResponse_t
	{
		// Token: 0x06000826 RID: 2086 RVA: 0x0002D064 File Offset: 0x0002B264
		// Note: this type is marked as 'beforefieldinit'.
		static EncryptedAppTicketResponse_t()
		{
			Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "EncryptedAppTicketResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr);
			EncryptedAppTicketResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr, "k_iCallback");
			EncryptedAppTicketResponse_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0000522E File Offset: 0x0000342E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x0002D0BC File Offset: 0x0002B2BC
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x00005240 File Offset: 0x00003440
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(EncryptedAppTicketResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncryptedAppTicketResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000756 RID: 1878
		[FieldOffset(0)]
		public EResult m_eResult;
	}
}
