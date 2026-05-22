using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200003A RID: 58
	[StructLayout(2)]
	public struct GCMessageAvailable_t
	{
		// Token: 0x06000507 RID: 1287 RVA: 0x00027288 File Offset: 0x00025488
		// Note: this type is marked as 'beforefieldinit'.
		static GCMessageAvailable_t()
		{
			Il2CppClassPointerStore<GCMessageAvailable_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GCMessageAvailable_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GCMessageAvailable_t>.NativeClassPtr);
			GCMessageAvailable_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GCMessageAvailable_t>.NativeClassPtr, "k_iCallback");
			GCMessageAvailable_t.NativeFieldInfoPtr_m_nMessageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GCMessageAvailable_t>.NativeClassPtr, "m_nMessageSize");
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00002FED File Offset: 0x000011ED
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GCMessageAvailable_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x000272E0 File Offset: 0x000254E0
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x00002FFF File Offset: 0x000011FF
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GCMessageAvailable_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GCMessageAvailable_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeFieldInfoPtr_m_nMessageSize;

		// Token: 0x04000465 RID: 1125
		[FieldOffset(0)]
		public uint m_nMessageSize;
	}
}
