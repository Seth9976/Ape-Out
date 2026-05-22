using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000CC RID: 204
	[StructLayout(2)]
	public struct GlobalAchievementPercentagesReady_t
	{
		// Token: 0x06000874 RID: 2164 RVA: 0x0002D990 File Offset: 0x0002BB90
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalAchievementPercentagesReady_t()
		{
			Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GlobalAchievementPercentagesReady_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr);
			GlobalAchievementPercentagesReady_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr, "k_iCallback");
			GlobalAchievementPercentagesReady_t.NativeFieldInfoPtr_m_nGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr, "m_nGameID");
			GlobalAchievementPercentagesReady_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0000552B File Offset: 0x0000372B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x0002D9FC File Offset: 0x0002BBFC
		// (set) Token: 0x06000877 RID: 2167 RVA: 0x0000553D File Offset: 0x0000373D
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GlobalAchievementPercentagesReady_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalAchievementPercentagesReady_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeFieldInfoPtr_m_nGameID;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x0400079B RID: 1947
		[FieldOffset(0)]
		public ulong m_nGameID;

		// Token: 0x0400079C RID: 1948
		[FieldOffset(8)]
		public EResult m_eResult;
	}
}
