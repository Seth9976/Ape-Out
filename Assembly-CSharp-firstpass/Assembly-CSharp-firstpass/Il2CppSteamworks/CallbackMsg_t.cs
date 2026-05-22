using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000131 RID: 305
	[StructLayout(2)]
	public struct CallbackMsg_t
	{
		// Token: 0x06000A26 RID: 2598 RVA: 0x00030728 File Offset: 0x0002E928
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackMsg_t()
		{
			Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CallbackMsg_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr);
			CallbackMsg_t.NativeFieldInfoPtr_m_hSteamUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr, "m_hSteamUser");
			CallbackMsg_t.NativeFieldInfoPtr_m_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr, "m_iCallback");
			CallbackMsg_t.NativeFieldInfoPtr_m_pubParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr, "m_pubParam");
			CallbackMsg_t.NativeFieldInfoPtr_m_cubParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr, "m_cubParam");
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00006400 File Offset: 0x00004600
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeFieldInfoPtr_m_hSteamUser;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeFieldInfoPtr_m_iCallback;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeFieldInfoPtr_m_pubParam;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeFieldInfoPtr_m_cubParam;

		// Token: 0x04000CCF RID: 3279
		[FieldOffset(0)]
		public int m_hSteamUser;

		// Token: 0x04000CD0 RID: 3280
		[FieldOffset(4)]
		public int m_iCallback;

		// Token: 0x04000CD1 RID: 3281
		[FieldOffset(8)]
		public IntPtr m_pubParam;

		// Token: 0x04000CD2 RID: 3282
		[FieldOffset(16)]
		public int m_cubParam;
	}
}
