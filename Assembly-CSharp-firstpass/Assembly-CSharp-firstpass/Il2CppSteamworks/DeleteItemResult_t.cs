using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000B6 RID: 182
	[StructLayout(2)]
	public struct DeleteItemResult_t
	{
		// Token: 0x06000802 RID: 2050 RVA: 0x0002CC38 File Offset: 0x0002AE38
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteItemResult_t()
		{
			Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "DeleteItemResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr);
			DeleteItemResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr, "k_iCallback");
			DeleteItemResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr, "m_eResult");
			DeleteItemResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr, "m_nPublishedFileId");
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0000509C File Offset: 0x0000329C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x0002CCA4 File Offset: 0x0002AEA4
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x000050AE File Offset: 0x000032AE
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeleteItemResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeleteItemResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x0400072C RID: 1836
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x0400072D RID: 1837
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
