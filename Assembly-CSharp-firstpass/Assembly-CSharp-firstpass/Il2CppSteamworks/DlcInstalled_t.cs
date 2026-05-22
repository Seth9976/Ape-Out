using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000023 RID: 35
	[StructLayout(2)]
	public struct DlcInstalled_t
	{
		// Token: 0x06000486 RID: 1158 RVA: 0x0002633C File Offset: 0x0002453C
		// Note: this type is marked as 'beforefieldinit'.
		static DlcInstalled_t()
		{
			Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "DlcInstalled_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr);
			DlcInstalled_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr, "k_iCallback");
			DlcInstalled_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002ADF File Offset: 0x00000CDF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00026394 File Offset: 0x00024594
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00002AF1 File Offset: 0x00000CF1
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DlcInstalled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DlcInstalled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x040003EE RID: 1006
		[FieldOffset(0)]
		public AppId_t m_nAppID;
	}
}
