using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000041 RID: 65
	[StructLayout(2)]
	public struct GSGameplayStats_t
	{
		// Token: 0x06000531 RID: 1329 RVA: 0x000276C4 File Offset: 0x000258C4
		// Note: this type is marked as 'beforefieldinit'.
		static GSGameplayStats_t()
		{
			Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSGameplayStats_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr);
			GSGameplayStats_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, "k_iCallback");
			GSGameplayStats_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, "m_eResult");
			GSGameplayStats_t.NativeFieldInfoPtr_m_nRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, "m_nRank");
			GSGameplayStats_t.NativeFieldInfoPtr_m_unTotalConnects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, "m_unTotalConnects");
			GSGameplayStats_t.NativeFieldInfoPtr_m_unTotalMinutesPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, "m_unTotalMinutesPlayed");
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000031C2 File Offset: 0x000013C2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00027758 File Offset: 0x00025958
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x000031D4 File Offset: 0x000013D4
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSGameplayStats_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSGameplayStats_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeFieldInfoPtr_m_nRank;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeFieldInfoPtr_m_unTotalConnects;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeFieldInfoPtr_m_unTotalMinutesPlayed;

		// Token: 0x04000481 RID: 1153
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04000482 RID: 1154
		[FieldOffset(4)]
		public int m_nRank;

		// Token: 0x04000483 RID: 1155
		[FieldOffset(8)]
		public uint m_unTotalConnects;

		// Token: 0x04000484 RID: 1156
		[FieldOffset(12)]
		public uint m_unTotalMinutesPlayed;
	}
}
