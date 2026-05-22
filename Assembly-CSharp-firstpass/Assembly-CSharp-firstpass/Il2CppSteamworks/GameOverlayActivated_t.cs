using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000029 RID: 41
	[StructLayout(2)]
	public struct GameOverlayActivated_t
	{
		// Token: 0x060004B0 RID: 1200 RVA: 0x00026784 File Offset: 0x00024984
		// Note: this type is marked as 'beforefieldinit'.
		static GameOverlayActivated_t()
		{
			Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameOverlayActivated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr);
			GameOverlayActivated_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr, "k_iCallback");
			GameOverlayActivated_t.NativeFieldInfoPtr_m_bActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr, "m_bActive");
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00002CCA File Offset: 0x00000ECA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameOverlayActivated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x000267DC File Offset: 0x000249DC
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00002CDC File Offset: 0x00000EDC
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameOverlayActivated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameOverlayActivated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_m_bActive;

		// Token: 0x04000406 RID: 1030
		[FieldOffset(0)]
		public byte m_bActive;
	}
}
