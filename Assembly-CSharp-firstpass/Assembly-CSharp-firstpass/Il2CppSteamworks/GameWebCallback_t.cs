using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000C1 RID: 193
	public sealed class GameWebCallback_t : ValueType
	{
		// Token: 0x0600082E RID: 2094 RVA: 0x0002D160 File Offset: 0x0002B360
		// Note: this type is marked as 'beforefieldinit'.
		static GameWebCallback_t()
		{
			Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameWebCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr);
			GameWebCallback_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr, "k_iCallback");
			GameWebCallback_t.NativeFieldInfoPtr_m_szURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr, "m_szURL");
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0000526E File Offset: 0x0000346E
		public GameWebCallback_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00005277 File Offset: 0x00003477
		public GameWebCallback_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x0002D1B8 File Offset: 0x0002B3B8
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x00005289 File Offset: 0x00003489
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameWebCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameWebCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x0002D1D4 File Offset: 0x0002B3D4
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x00005297 File Offset: 0x00003497
		public unsafe string m_szURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameWebCallback_t.NativeFieldInfoPtr_m_szURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameWebCallback_t.NativeFieldInfoPtr_m_szURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeFieldInfoPtr_m_szURL;
	}
}
