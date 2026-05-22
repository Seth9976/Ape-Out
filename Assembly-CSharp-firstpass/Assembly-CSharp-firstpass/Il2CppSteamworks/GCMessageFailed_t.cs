using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200003B RID: 59
	[StructLayout(2)]
	public struct GCMessageFailed_t
	{
		// Token: 0x0600050B RID: 1291 RVA: 0x0000300D File Offset: 0x0000120D
		// Note: this type is marked as 'beforefieldinit'.
		static GCMessageFailed_t()
		{
			Il2CppClassPointerStore<GCMessageFailed_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GCMessageFailed_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GCMessageFailed_t>.NativeClassPtr);
			GCMessageFailed_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GCMessageFailed_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00003046 File Offset: 0x00001246
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GCMessageFailed_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x000272FC File Offset: 0x000254FC
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00003058 File Offset: 0x00001258
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GCMessageFailed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GCMessageFailed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
