using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000065 RID: 101
	[StructLayout(2)]
	public struct SteamInventoryDefinitionUpdate_t
	{
		// Token: 0x06000626 RID: 1574 RVA: 0x00003BA7 File Offset: 0x00001DA7
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryDefinitionUpdate_t()
		{
			Il2CppClassPointerStore<SteamInventoryDefinitionUpdate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventoryDefinitionUpdate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryDefinitionUpdate_t>.NativeClassPtr);
			SteamInventoryDefinitionUpdate_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryDefinitionUpdate_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00003BE0 File Offset: 0x00001DE0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryDefinitionUpdate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00029498 File Offset: 0x00027698
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x00003BF2 File Offset: 0x00001DF2
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryDefinitionUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryDefinitionUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
