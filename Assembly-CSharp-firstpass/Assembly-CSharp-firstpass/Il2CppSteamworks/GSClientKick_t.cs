using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200003E RID: 62
	[StructLayout(2)]
	public struct GSClientKick_t
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x000274B4 File Offset: 0x000256B4
		// Note: this type is marked as 'beforefieldinit'.
		static GSClientKick_t()
		{
			Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSClientKick_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr);
			GSClientKick_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr, "k_iCallback");
			GSClientKick_t.NativeFieldInfoPtr_m_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr, "m_SteamID");
			GSClientKick_t.NativeFieldInfoPtr_m_eDenyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr, "m_eDenyReason");
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00003104 File Offset: 0x00001304
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00027520 File Offset: 0x00025720
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00003116 File Offset: 0x00001316
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSClientKick_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSClientKick_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamID;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeFieldInfoPtr_m_eDenyReason;

		// Token: 0x04000473 RID: 1139
		[FieldOffset(0)]
		public CSteamID m_SteamID;

		// Token: 0x04000474 RID: 1140
		[FieldOffset(8)]
		public EDenyReason m_eDenyReason;
	}
}
