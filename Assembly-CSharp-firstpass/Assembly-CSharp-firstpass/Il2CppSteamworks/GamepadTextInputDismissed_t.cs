using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000D4 RID: 212
	[StructLayout(2)]
	public struct GamepadTextInputDismissed_t
	{
		// Token: 0x06000894 RID: 2196 RVA: 0x0002DCE4 File Offset: 0x0002BEE4
		// Note: this type is marked as 'beforefieldinit'.
		static GamepadTextInputDismissed_t()
		{
			Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GamepadTextInputDismissed_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr);
			GamepadTextInputDismissed_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, "k_iCallback");
			GamepadTextInputDismissed_t.NativeFieldInfoPtr_m_bSubmitted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, "m_bSubmitted");
			GamepadTextInputDismissed_t.NativeFieldInfoPtr_m_unSubmittedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, "m_unSubmittedText");
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x0000569D File Offset: 0x0000389D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x0002DD50 File Offset: 0x0002BF50
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x000056AF File Offset: 0x000038AF
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTextInputDismissed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTextInputDismissed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeFieldInfoPtr_m_bSubmitted;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeFieldInfoPtr_m_unSubmittedText;

		// Token: 0x040007B9 RID: 1977
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_bSubmitted;

		// Token: 0x040007BA RID: 1978
		[FieldOffset(4)]
		public uint m_unSubmittedText;
	}
}
