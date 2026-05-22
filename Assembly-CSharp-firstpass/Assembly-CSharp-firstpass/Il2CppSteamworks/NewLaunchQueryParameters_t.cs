using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000025 RID: 37
	[StructLayout(2)]
	public struct NewLaunchQueryParameters_t
	{
		// Token: 0x0600048E RID: 1166 RVA: 0x00002B1F File Offset: 0x00000D1F
		// Note: this type is marked as 'beforefieldinit'.
		static NewLaunchQueryParameters_t()
		{
			Il2CppClassPointerStore<NewLaunchQueryParameters_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "NewLaunchQueryParameters_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewLaunchQueryParameters_t>.NativeClassPtr);
			NewLaunchQueryParameters_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewLaunchQueryParameters_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00002B58 File Offset: 0x00000D58
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NewLaunchQueryParameters_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00026438 File Offset: 0x00024638
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x00002B6A File Offset: 0x00000D6A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(NewLaunchQueryParameters_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NewLaunchQueryParameters_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
