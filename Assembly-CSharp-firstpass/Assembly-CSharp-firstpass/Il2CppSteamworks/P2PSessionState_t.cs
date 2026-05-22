using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200012E RID: 302
	[StructLayout(2)]
	public struct P2PSessionState_t
	{
		// Token: 0x060009EB RID: 2539 RVA: 0x0002FFB8 File Offset: 0x0002E1B8
		// Note: this type is marked as 'beforefieldinit'.
		static P2PSessionState_t()
		{
			Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "P2PSessionState_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr);
			P2PSessionState_t.NativeFieldInfoPtr_m_bConnectionActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "m_bConnectionActive");
			P2PSessionState_t.NativeFieldInfoPtr_m_bConnecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "m_bConnecting");
			P2PSessionState_t.NativeFieldInfoPtr_m_eP2PSessionError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "m_eP2PSessionError");
			P2PSessionState_t.NativeFieldInfoPtr_m_bUsingRelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "m_bUsingRelay");
			P2PSessionState_t.NativeFieldInfoPtr_m_nBytesQueuedForSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "m_nBytesQueuedForSend");
			P2PSessionState_t.NativeFieldInfoPtr_m_nPacketsQueuedForSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "m_nPacketsQueuedForSend");
			P2PSessionState_t.NativeFieldInfoPtr_m_nRemoteIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "m_nRemoteIP");
			P2PSessionState_t.NativeFieldInfoPtr_m_nRemotePort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "m_nRemotePort");
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x000060EF File Offset: 0x000042EF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeFieldInfoPtr_m_bConnectionActive;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeFieldInfoPtr_m_bConnecting;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeFieldInfoPtr_m_eP2PSessionError;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeFieldInfoPtr_m_bUsingRelay;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeFieldInfoPtr_m_nBytesQueuedForSend;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeFieldInfoPtr_m_nPacketsQueuedForSend;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeFieldInfoPtr_m_nRemoteIP;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeFieldInfoPtr_m_nRemotePort;

		// Token: 0x04000CA5 RID: 3237
		[FieldOffset(0)]
		public byte m_bConnectionActive;

		// Token: 0x04000CA6 RID: 3238
		[FieldOffset(1)]
		public byte m_bConnecting;

		// Token: 0x04000CA7 RID: 3239
		[FieldOffset(2)]
		public byte m_eP2PSessionError;

		// Token: 0x04000CA8 RID: 3240
		[FieldOffset(3)]
		public byte m_bUsingRelay;

		// Token: 0x04000CA9 RID: 3241
		[FieldOffset(4)]
		public int m_nBytesQueuedForSend;

		// Token: 0x04000CAA RID: 3242
		[FieldOffset(8)]
		public int m_nPacketsQueuedForSend;

		// Token: 0x04000CAB RID: 3243
		[FieldOffset(12)]
		public uint m_nRemoteIP;

		// Token: 0x04000CAC RID: 3244
		[FieldOffset(16)]
		public ushort m_nRemotePort;
	}
}
