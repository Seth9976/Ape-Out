using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000075 RID: 117
	[StructLayout(2)]
	public struct VolumeHasChanged_t
	{
		// Token: 0x0600066B RID: 1643 RVA: 0x00029DE4 File Offset: 0x00027FE4
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeHasChanged_t()
		{
			Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "VolumeHasChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr);
			VolumeHasChanged_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr, "k_iCallback");
			VolumeHasChanged_t.NativeFieldInfoPtr_m_flNewVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr, "m_flNewVolume");
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00003E5C File Offset: 0x0000205C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x00029E3C File Offset: 0x0002803C
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x00003E6E File Offset: 0x0000206E
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(VolumeHasChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumeHasChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeFieldInfoPtr_m_flNewVolume;

		// Token: 0x040005D0 RID: 1488
		[FieldOffset(0)]
		public float m_flNewVolume;
	}
}
