using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000B4 RID: 180
	[StructLayout(2)]
	public struct RemoveAppDependencyResult_t
	{
		// Token: 0x060007EF RID: 2031 RVA: 0x0002CA08 File Offset: 0x0002AC08
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveAppDependencyResult_t()
		{
			Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoveAppDependencyResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr);
			RemoveAppDependencyResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, "k_iCallback");
			RemoveAppDependencyResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, "m_eResult");
			RemoveAppDependencyResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoveAppDependencyResult_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00004FC8 File Offset: 0x000031C8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x0002CA88 File Offset: 0x0002AC88
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x00004FDA File Offset: 0x000031DA
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoveAppDependencyResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoveAppDependencyResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04000720 RID: 1824
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04000721 RID: 1825
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000722 RID: 1826
		[FieldOffset(16)]
		public AppId_t m_nAppID;
	}
}
