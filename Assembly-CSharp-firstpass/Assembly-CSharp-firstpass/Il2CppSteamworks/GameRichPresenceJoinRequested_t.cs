using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200002F RID: 47
	public sealed class GameRichPresenceJoinRequested_t : ValueType
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x00026B2C File Offset: 0x00024D2C
		// Note: this type is marked as 'beforefieldinit'.
		static GameRichPresenceJoinRequested_t()
		{
			Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameRichPresenceJoinRequested_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr);
			GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr, "k_iCallback");
			GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_m_steamIDFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr, "m_steamIDFriend");
			GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_m_rgchConnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr, "m_rgchConnect");
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002DD1 File Offset: 0x00000FD1
		public GameRichPresenceJoinRequested_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00002DDA File Offset: 0x00000FDA
		public GameRichPresenceJoinRequested_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00026B98 File Offset: 0x00024D98
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00002DEC File Offset: 0x00000FEC
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00026BB4 File Offset: 0x00024DB4
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00002DFA File Offset: 0x00000FFA
		public unsafe CSteamID m_steamIDFriend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_m_steamIDFriend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_m_steamIDFriend)) = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00026BDC File Offset: 0x00024DDC
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00002E15 File Offset: 0x00001015
		public unsafe string m_rgchConnect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_m_rgchConnect);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_m_rgchConnect), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDFriend;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchConnect;
	}
}
