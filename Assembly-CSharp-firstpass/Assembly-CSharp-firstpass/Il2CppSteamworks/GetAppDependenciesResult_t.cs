using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000B5 RID: 181
	public sealed class GetAppDependenciesResult_t : ValueType
	{
		// Token: 0x060007F3 RID: 2035 RVA: 0x0002CAA4 File Offset: 0x0002ACA4
		// Note: this type is marked as 'beforefieldinit'.
		static GetAppDependenciesResult_t()
		{
			Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GetAppDependenciesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr);
			GetAppDependenciesResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "k_iCallback");
			GetAppDependenciesResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "m_eResult");
			GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "m_nPublishedFileId");
			GetAppDependenciesResult_t.NativeFieldInfoPtr_m_rgAppIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "m_rgAppIDs");
			GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nNumAppDependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "m_nNumAppDependencies");
			GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nTotalNumAppDependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "m_nTotalNumAppDependencies");
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00004FE8 File Offset: 0x000031E8
		public GetAppDependenciesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00004FF1 File Offset: 0x000031F1
		public GetAppDependenciesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0002CB4C File Offset: 0x0002AD4C
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00005003 File Offset: 0x00003203
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetAppDependenciesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetAppDependenciesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0002CB68 File Offset: 0x0002AD68
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00005011 File Offset: 0x00003211
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x0002CB90 File Offset: 0x0002AD90
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x0000502C File Offset: 0x0000322C
		public unsafe PublishedFileId_t m_nPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nPublishedFileId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nPublishedFileId)) = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0002CBB8 File Offset: 0x0002ADB8
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x00005047 File Offset: 0x00003247
		public unsafe Il2CppStructArray<AppId_t> m_rgAppIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_rgAppIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AppId_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_rgAppIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x0002CBE8 File Offset: 0x0002ADE8
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x00005066 File Offset: 0x00003266
		public unsafe uint m_nNumAppDependencies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nNumAppDependencies);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nNumAppDependencies)) = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x0002CC10 File Offset: 0x0002AE10
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00005081 File Offset: 0x00003281
		public unsafe uint m_nTotalNumAppDependencies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nTotalNumAppDependencies);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nTotalNumAppDependencies)) = value;
			}
		}

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_m_rgAppIDs;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr_m_nNumAppDependencies;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr_m_nTotalNumAppDependencies;
	}
}
