using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000BE RID: 190
	[StructLayout(2)]
	public struct MicroTxnAuthorizationResponse_t
	{
		// Token: 0x06000822 RID: 2082 RVA: 0x0002CFC8 File Offset: 0x0002B1C8
		// Note: this type is marked as 'beforefieldinit'.
		static MicroTxnAuthorizationResponse_t()
		{
			Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MicroTxnAuthorizationResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr);
			MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, "k_iCallback");
			MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr_m_unAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, "m_unAppID");
			MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr_m_ulOrderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, "m_ulOrderID");
			MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr_m_bAuthorized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, "m_bAuthorized");
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0000520E File Offset: 0x0000340E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x0002D048 File Offset: 0x0002B248
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x00005220 File Offset: 0x00003420
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeFieldInfoPtr_m_unAppID;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeFieldInfoPtr_m_ulOrderID;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeFieldInfoPtr_m_bAuthorized;

		// Token: 0x04000751 RID: 1873
		[FieldOffset(0)]
		public uint m_unAppID;

		// Token: 0x04000752 RID: 1874
		[FieldOffset(8)]
		public ulong m_ulOrderID;

		// Token: 0x04000753 RID: 1875
		[FieldOffset(16)]
		public byte m_bAuthorized;
	}
}
