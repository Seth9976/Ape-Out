using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000044 RID: 68
	[StructLayout(2)]
	public struct AssociateWithClanResult_t
	{
		// Token: 0x0600053D RID: 1341 RVA: 0x00027910 File Offset: 0x00025B10
		// Note: this type is marked as 'beforefieldinit'.
		static AssociateWithClanResult_t()
		{
			Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "AssociateWithClanResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr);
			AssociateWithClanResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr, "k_iCallback");
			AssociateWithClanResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00003222 File Offset: 0x00001422
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00027968 File Offset: 0x00025B68
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00003234 File Offset: 0x00001434
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssociateWithClanResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssociateWithClanResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x0400049F RID: 1183
		[FieldOffset(0)]
		public EResult m_eResult;
	}
}
