using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000096 RID: 150
	public sealed class RemoteStorageEnumerateWorkshopFilesResult_t : ValueType
	{
		// Token: 0x0600074D RID: 1869 RVA: 0x0002B4F0 File Offset: 0x000296F0
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageEnumerateWorkshopFilesResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageEnumerateWorkshopFilesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr);
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "m_nResultsReturned");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "m_nTotalResultCount");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "m_rgPublishedFileId");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "m_rgScore");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nAppId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "m_nAppId");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_unStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "m_unStartIndex");
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00004983 File Offset: 0x00002B83
		public RemoteStorageEnumerateWorkshopFilesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0000498C File Offset: 0x00002B8C
		public RemoteStorageEnumerateWorkshopFilesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x0002B5C0 File Offset: 0x000297C0
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x0000499E File Offset: 0x00002B9E
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x0002B5DC File Offset: 0x000297DC
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x000049AC File Offset: 0x00002BAC
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x0002B604 File Offset: 0x00029804
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x000049C7 File Offset: 0x00002BC7
		public unsafe int m_nResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned)) = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x0002B62C File Offset: 0x0002982C
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x000049E2 File Offset: 0x00002BE2
		public unsafe int m_nTotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount)) = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x0002B654 File Offset: 0x00029854
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x000049FD File Offset: 0x00002BFD
		public unsafe Il2CppStructArray<PublishedFileId_t> m_rgPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x0002B684 File Offset: 0x00029884
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x00004A1C File Offset: 0x00002C1C
		public unsafe Il2CppStructArray<float> m_rgScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x0002B6B4 File Offset: 0x000298B4
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x00004A3B File Offset: 0x00002C3B
		public unsafe AppId_t m_nAppId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nAppId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nAppId)) = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x0002B6DC File Offset: 0x000298DC
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x00004A56 File Offset: 0x00002C56
		public unsafe uint m_unStartIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_unStartIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_unStartIndex)) = value;
			}
		}

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeFieldInfoPtr_m_nResultsReturned;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeFieldInfoPtr_m_nTotalResultCount;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeFieldInfoPtr_m_rgPublishedFileId;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeFieldInfoPtr_m_rgScore;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppId;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeFieldInfoPtr_m_unStartIndex;
	}
}
