using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000BB RID: 187
	[StructLayout(2)]
	public struct IPCFailure_t
	{
		// Token: 0x06000816 RID: 2070 RVA: 0x0002CE9C File Offset: 0x0002B09C
		// Note: this type is marked as 'beforefieldinit'.
		static IPCFailure_t()
		{
			Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "IPCFailure_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr);
			IPCFailure_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr, "k_iCallback");
			IPCFailure_t.NativeFieldInfoPtr_m_eFailureType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr, "m_eFailureType");
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00005175 File Offset: 0x00003375
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x0002CEF4 File Offset: 0x0002B0F4
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00005187 File Offset: 0x00003387
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IPCFailure_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPCFailure_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeFieldInfoPtr_m_eFailureType;

		// Token: 0x04000744 RID: 1860
		[FieldOffset(0)]
		public byte m_eFailureType;
	}
}
