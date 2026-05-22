using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000040 RID: 64
	[StructLayout(2)]
	public struct GSPolicyResponse_t
	{
		// Token: 0x0600052D RID: 1325 RVA: 0x00027650 File Offset: 0x00025850
		// Note: this type is marked as 'beforefieldinit'.
		static GSPolicyResponse_t()
		{
			Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSPolicyResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr);
			GSPolicyResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr, "k_iCallback");
			GSPolicyResponse_t.NativeFieldInfoPtr_m_bSecure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr, "m_bSecure");
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x000031A2 File Offset: 0x000013A2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x000276A8 File Offset: 0x000258A8
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x000031B4 File Offset: 0x000013B4
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSPolicyResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSPolicyResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeFieldInfoPtr_m_bSecure;

		// Token: 0x0400047B RID: 1147
		[FieldOffset(0)]
		public byte m_bSecure;
	}
}
