using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000B1 RID: 177
	[StructLayout(2)]
	public struct AddUGCDependencyResult_t
	{
		// Token: 0x060007E3 RID: 2019 RVA: 0x0002C834 File Offset: 0x0002AA34
		// Note: this type is marked as 'beforefieldinit'.
		static AddUGCDependencyResult_t()
		{
			Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "AddUGCDependencyResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr);
			AddUGCDependencyResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, "k_iCallback");
			AddUGCDependencyResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, "m_eResult");
			AddUGCDependencyResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, "m_nPublishedFileId");
			AddUGCDependencyResult_t.NativeFieldInfoPtr_m_nChildPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, "m_nChildPublishedFileId");
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00004F68 File Offset: 0x00003168
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x0002C8B4 File Offset: 0x0002AAB4
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00004F7A File Offset: 0x0000317A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AddUGCDependencyResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddUGCDependencyResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeFieldInfoPtr_m_nChildPublishedFileId;

		// Token: 0x0400070B RID: 1803
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x0400070C RID: 1804
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400070D RID: 1805
		[FieldOffset(16)]
		public PublishedFileId_t m_nChildPublishedFileId;
	}
}
