using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200002C RID: 44
	[StructLayout(2)]
	public struct AvatarImageLoaded_t
	{
		// Token: 0x060004C1 RID: 1217 RVA: 0x00026958 File Offset: 0x00024B58
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarImageLoaded_t()
		{
			Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "AvatarImageLoaded_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr);
			AvatarImageLoaded_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, "k_iCallback");
			AvatarImageLoaded_t.NativeFieldInfoPtr_m_steamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, "m_steamID");
			AvatarImageLoaded_t.NativeFieldInfoPtr_m_iImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, "m_iImage");
			AvatarImageLoaded_t.NativeFieldInfoPtr_m_iWide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, "m_iWide");
			AvatarImageLoaded_t.NativeFieldInfoPtr_m_iTall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, "m_iTall");
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00002D71 File Offset: 0x00000F71
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x000269EC File Offset: 0x00024BEC
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00002D83 File Offset: 0x00000F83
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AvatarImageLoaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarImageLoaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeFieldInfoPtr_m_steamID;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeFieldInfoPtr_m_iImage;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeFieldInfoPtr_m_iWide;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeFieldInfoPtr_m_iTall;

		// Token: 0x04000414 RID: 1044
		[FieldOffset(0)]
		public CSteamID m_steamID;

		// Token: 0x04000415 RID: 1045
		[FieldOffset(8)]
		public int m_iImage;

		// Token: 0x04000416 RID: 1046
		[FieldOffset(12)]
		public int m_iWide;

		// Token: 0x04000417 RID: 1047
		[FieldOffset(16)]
		public int m_iTall;
	}
}
