using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000D5 RID: 213
	[StructLayout(2)]
	public struct BroadcastUploadStart_t
	{
		// Token: 0x06000898 RID: 2200 RVA: 0x000056BD File Offset: 0x000038BD
		// Note: this type is marked as 'beforefieldinit'.
		static BroadcastUploadStart_t()
		{
			Il2CppClassPointerStore<BroadcastUploadStart_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "BroadcastUploadStart_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BroadcastUploadStart_t>.NativeClassPtr);
			BroadcastUploadStart_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastUploadStart_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x000056F6 File Offset: 0x000038F6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BroadcastUploadStart_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x0002DD6C File Offset: 0x0002BF6C
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00005708 File Offset: 0x00003908
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BroadcastUploadStart_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BroadcastUploadStart_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
