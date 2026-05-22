using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000D3 RID: 211
	[StructLayout(2)]
	public struct CheckFileSignature_t
	{
		// Token: 0x06000890 RID: 2192 RVA: 0x0002DC70 File Offset: 0x0002BE70
		// Note: this type is marked as 'beforefieldinit'.
		static CheckFileSignature_t()
		{
			Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CheckFileSignature_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr);
			CheckFileSignature_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr, "k_iCallback");
			CheckFileSignature_t.NativeFieldInfoPtr_m_eCheckFileSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr, "m_eCheckFileSignature");
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0000567D File Offset: 0x0000387D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x0002DCC8 File Offset: 0x0002BEC8
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x0000568F File Offset: 0x0000388F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CheckFileSignature_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CheckFileSignature_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeFieldInfoPtr_m_eCheckFileSignature;

		// Token: 0x040007B5 RID: 1973
		[FieldOffset(0)]
		public ECheckFileSignature m_eCheckFileSignature;
	}
}
