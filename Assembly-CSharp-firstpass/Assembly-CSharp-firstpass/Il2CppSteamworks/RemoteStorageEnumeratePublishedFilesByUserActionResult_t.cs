using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200009F RID: 159
	public sealed class RemoteStorageEnumeratePublishedFilesByUserActionResult_t : ValueType
	{
		// Token: 0x06000789 RID: 1929 RVA: 0x0002BC8C File Offset: 0x00029E8C
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageEnumeratePublishedFilesByUserActionResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageEnumeratePublishedFilesByUserActionResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr);
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_eAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "m_eAction");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_nResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "m_nResultsReturned");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_nTotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "m_nTotalResultCount");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_rgPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "m_rgPublishedFileId");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_rgRTimeUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "m_rgRTimeUpdated");
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00004BEA File Offset: 0x00002DEA
		public RemoteStorageEnumeratePublishedFilesByUserActionResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00004BF3 File Offset: 0x00002DF3
		public RemoteStorageEnumeratePublishedFilesByUserActionResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x0002BD48 File Offset: 0x00029F48
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x00004C05 File Offset: 0x00002E05
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x0002BD64 File Offset: 0x00029F64
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00004C13 File Offset: 0x00002E13
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x0002BD8C File Offset: 0x00029F8C
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x00004C2E File Offset: 0x00002E2E
		public unsafe EWorkshopFileAction m_eAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_eAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_eAction)) = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x0002BDB4 File Offset: 0x00029FB4
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x00004C49 File Offset: 0x00002E49
		public unsafe int m_nResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_nResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_nResultsReturned)) = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x0002BDDC File Offset: 0x00029FDC
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x00004C64 File Offset: 0x00002E64
		public unsafe int m_nTotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_nTotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_nTotalResultCount)) = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x0002BE04 File Offset: 0x0002A004
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x00004C7F File Offset: 0x00002E7F
		public unsafe Il2CppStructArray<PublishedFileId_t> m_rgPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_rgPublishedFileId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_rgPublishedFileId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x0002BE34 File Offset: 0x0002A034
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x00004C9E File Offset: 0x00002E9E
		public unsafe Il2CppStructArray<uint> m_rgRTimeUpdated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_rgRTimeUpdated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_rgRTimeUpdated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr_m_eAction;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeFieldInfoPtr_m_nResultsReturned;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeFieldInfoPtr_m_nTotalResultCount;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeFieldInfoPtr_m_rgPublishedFileId;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeFieldInfoPtr_m_rgRTimeUpdated;
	}
}
