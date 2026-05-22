using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000042 RID: 66
	[StructLayout(2)]
	public struct GSClientGroupStatus_t
	{
		// Token: 0x06000535 RID: 1333 RVA: 0x00027774 File Offset: 0x00025974
		// Note: this type is marked as 'beforefieldinit'.
		static GSClientGroupStatus_t()
		{
			Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSClientGroupStatus_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr);
			GSClientGroupStatus_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, "k_iCallback");
			GSClientGroupStatus_t.NativeFieldInfoPtr_m_SteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, "m_SteamIDUser");
			GSClientGroupStatus_t.NativeFieldInfoPtr_m_SteamIDGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, "m_SteamIDGroup");
			GSClientGroupStatus_t.NativeFieldInfoPtr_m_bMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, "m_bMember");
			GSClientGroupStatus_t.NativeFieldInfoPtr_m_bOfficer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, "m_bOfficer");
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000031E2 File Offset: 0x000013E2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSClientGroupStatus_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00027808 File Offset: 0x00025A08
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x000031F4 File Offset: 0x000013F4
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSClientGroupStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSClientGroupStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamIDUser;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamIDGroup;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeFieldInfoPtr_m_bMember;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeFieldInfoPtr_m_bOfficer;

		// Token: 0x0400048A RID: 1162
		[FieldOffset(0)]
		public CSteamID m_SteamIDUser;

		// Token: 0x0400048B RID: 1163
		[FieldOffset(8)]
		public CSteamID m_SteamIDGroup;

		// Token: 0x0400048C RID: 1164
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool m_bMember;

		// Token: 0x0400048D RID: 1165
		[FieldOffset(17)]
		[MarshalAs(4)]
		public bool m_bOfficer;
	}
}
