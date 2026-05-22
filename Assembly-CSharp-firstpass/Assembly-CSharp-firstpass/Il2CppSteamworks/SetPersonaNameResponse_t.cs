using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000039 RID: 57
	[StructLayout(2)]
	public struct SetPersonaNameResponse_t
	{
		// Token: 0x06000503 RID: 1283 RVA: 0x000271EC File Offset: 0x000253EC
		// Note: this type is marked as 'beforefieldinit'.
		static SetPersonaNameResponse_t()
		{
			Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SetPersonaNameResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr);
			SetPersonaNameResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, "k_iCallback");
			SetPersonaNameResponse_t.NativeFieldInfoPtr_m_bSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, "m_bSuccess");
			SetPersonaNameResponse_t.NativeFieldInfoPtr_m_bLocalSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, "m_bLocalSuccess");
			SetPersonaNameResponse_t.NativeFieldInfoPtr_m_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, "m_result");
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00002FCD File Offset: 0x000011CD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetPersonaNameResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x0002726C File Offset: 0x0002546C
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x00002FDF File Offset: 0x000011DF
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SetPersonaNameResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SetPersonaNameResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeFieldInfoPtr_m_bSuccess;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeFieldInfoPtr_m_bLocalSuccess;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeFieldInfoPtr_m_result;

		// Token: 0x04000460 RID: 1120
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_bSuccess;

		// Token: 0x04000461 RID: 1121
		[FieldOffset(1)]
		[MarshalAs(4)]
		public bool m_bLocalSuccess;

		// Token: 0x04000462 RID: 1122
		[FieldOffset(4)]
		public EResult m_result;
	}
}
