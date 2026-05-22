using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000AA RID: 170
	[StructLayout(2)]
	public struct ItemInstalled_t
	{
		// Token: 0x060007C7 RID: 1991 RVA: 0x0002C42C File Offset: 0x0002A62C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemInstalled_t()
		{
			Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ItemInstalled_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr);
			ItemInstalled_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr, "k_iCallback");
			ItemInstalled_t.NativeFieldInfoPtr_m_unAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr, "m_unAppID");
			ItemInstalled_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr, "m_nPublishedFileId");
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00004E88 File Offset: 0x00003088
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemInstalled_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x0002C498 File Offset: 0x0002A698
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x00004E9A File Offset: 0x0000309A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ItemInstalled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemInstalled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr_m_unAppID;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x040006DF RID: 1759
		[FieldOffset(0)]
		public AppId_t m_unAppID;

		// Token: 0x040006E0 RID: 1760
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
