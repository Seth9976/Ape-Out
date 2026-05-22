using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000B2 RID: 178
	[StructLayout(2)]
	public struct RemoveUGCDependencyResult_t
	{
		// Token: 0x060007E7 RID: 2023 RVA: 0x0002C8D0 File Offset: 0x0002AAD0
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveUGCDependencyResult_t()
		{
			Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoveUGCDependencyResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr);
			RemoveUGCDependencyResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, "k_iCallback");
			RemoveUGCDependencyResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, "m_eResult");
			RemoveUGCDependencyResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoveUGCDependencyResult_t.NativeFieldInfoPtr_m_nChildPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, "m_nChildPublishedFileId");
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00004F88 File Offset: 0x00003188
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x0002C950 File Offset: 0x0002AB50
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x00004F9A File Offset: 0x0000319A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoveUGCDependencyResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoveUGCDependencyResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeFieldInfoPtr_m_nChildPublishedFileId;

		// Token: 0x04000712 RID: 1810
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04000713 RID: 1811
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000714 RID: 1812
		[FieldOffset(16)]
		public PublishedFileId_t m_nChildPublishedFileId;
	}
}
