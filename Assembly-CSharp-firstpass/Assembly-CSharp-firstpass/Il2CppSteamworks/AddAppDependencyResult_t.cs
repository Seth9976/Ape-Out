using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000B3 RID: 179
	[StructLayout(2)]
	public struct AddAppDependencyResult_t
	{
		// Token: 0x060007EB RID: 2027 RVA: 0x0002C96C File Offset: 0x0002AB6C
		// Note: this type is marked as 'beforefieldinit'.
		static AddAppDependencyResult_t()
		{
			Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "AddAppDependencyResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr);
			AddAppDependencyResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, "k_iCallback");
			AddAppDependencyResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, "m_eResult");
			AddAppDependencyResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, "m_nPublishedFileId");
			AddAppDependencyResult_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00004FA8 File Offset: 0x000031A8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x0002C9EC File Offset: 0x0002ABEC
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x00004FBA File Offset: 0x000031BA
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AddAppDependencyResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddAppDependencyResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04000719 RID: 1817
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x0400071A RID: 1818
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400071B RID: 1819
		[FieldOffset(16)]
		public AppId_t m_nAppID;
	}
}
