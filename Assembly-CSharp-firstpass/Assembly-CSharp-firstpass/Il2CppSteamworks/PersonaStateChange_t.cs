using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000028 RID: 40
	[StructLayout(2)]
	public struct PersonaStateChange_t
	{
		// Token: 0x060004AC RID: 1196 RVA: 0x000266FC File Offset: 0x000248FC
		// Note: this type is marked as 'beforefieldinit'.
		static PersonaStateChange_t()
		{
			Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "PersonaStateChange_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr);
			PersonaStateChange_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr, "k_iCallback");
			PersonaStateChange_t.NativeFieldInfoPtr_m_ulSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr, "m_ulSteamID");
			PersonaStateChange_t.NativeFieldInfoPtr_m_nChangeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr, "m_nChangeFlags");
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002CAA File Offset: 0x00000EAA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersonaStateChange_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00026768 File Offset: 0x00024968
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00002CBC File Offset: 0x00000EBC
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PersonaStateChange_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PersonaStateChange_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamID;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr_m_nChangeFlags;

		// Token: 0x04000402 RID: 1026
		[FieldOffset(0)]
		public ulong m_ulSteamID;

		// Token: 0x04000403 RID: 1027
		[FieldOffset(8)]
		public EPersonaChange m_nChangeFlags;
	}
}
