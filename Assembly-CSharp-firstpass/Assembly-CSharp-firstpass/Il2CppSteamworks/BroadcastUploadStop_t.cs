using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000D6 RID: 214
	[StructLayout(2)]
	public struct BroadcastUploadStop_t
	{
		// Token: 0x0600089C RID: 2204 RVA: 0x0002DD88 File Offset: 0x0002BF88
		// Note: this type is marked as 'beforefieldinit'.
		static BroadcastUploadStop_t()
		{
			Il2CppClassPointerStore<BroadcastUploadStop_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "BroadcastUploadStop_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BroadcastUploadStop_t>.NativeClassPtr);
			BroadcastUploadStop_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastUploadStop_t>.NativeClassPtr, "k_iCallback");
			BroadcastUploadStop_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastUploadStop_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00005716 File Offset: 0x00003916
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BroadcastUploadStop_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0002DDE0 File Offset: 0x0002BFE0
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x00005728 File Offset: 0x00003928
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BroadcastUploadStop_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BroadcastUploadStop_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040007BE RID: 1982
		[FieldOffset(0)]
		public EBroadcastUploadResult m_eResult;
	}
}
