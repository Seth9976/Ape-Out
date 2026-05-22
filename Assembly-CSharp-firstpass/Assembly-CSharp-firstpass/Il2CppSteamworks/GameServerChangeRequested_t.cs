using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200002A RID: 42
	public sealed class GameServerChangeRequested_t : ValueType
	{
		// Token: 0x060004B4 RID: 1204 RVA: 0x000267F8 File Offset: 0x000249F8
		// Note: this type is marked as 'beforefieldinit'.
		static GameServerChangeRequested_t()
		{
			Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameServerChangeRequested_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr);
			GameServerChangeRequested_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, "k_iCallback");
			GameServerChangeRequested_t.NativeFieldInfoPtr_m_rgchServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, "m_rgchServer");
			GameServerChangeRequested_t.NativeFieldInfoPtr_m_rgchPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, "m_rgchPassword");
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002CEA File Offset: 0x00000EEA
		public GameServerChangeRequested_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002CF3 File Offset: 0x00000EF3
		public GameServerChangeRequested_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00026864 File Offset: 0x00024A64
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00002D05 File Offset: 0x00000F05
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameServerChangeRequested_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameServerChangeRequested_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00026880 File Offset: 0x00024A80
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00002D13 File Offset: 0x00000F13
		public unsafe string m_rgchServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameServerChangeRequested_t.NativeFieldInfoPtr_m_rgchServer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameServerChangeRequested_t.NativeFieldInfoPtr_m_rgchServer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x000268A8 File Offset: 0x00024AA8
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00002D32 File Offset: 0x00000F32
		public unsafe string m_rgchPassword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameServerChangeRequested_t.NativeFieldInfoPtr_m_rgchPassword);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameServerChangeRequested_t.NativeFieldInfoPtr_m_rgchPassword), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchServer;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchPassword;
	}
}
