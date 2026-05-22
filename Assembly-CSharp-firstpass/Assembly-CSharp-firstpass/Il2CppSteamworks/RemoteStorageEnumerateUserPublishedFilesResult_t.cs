using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200008F RID: 143
	public sealed class RemoteStorageEnumerateUserPublishedFilesResult_t : ValueType
	{
		// Token: 0x060006E5 RID: 1765 RVA: 0x0002A93C File Offset: 0x00028B3C
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageEnumerateUserPublishedFilesResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageEnumerateUserPublishedFilesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr);
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, "m_nResultsReturned");
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, "m_nTotalResultCount");
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, "m_rgPublishedFileId");
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0000448F File Offset: 0x0000268F
		public RemoteStorageEnumerateUserPublishedFilesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00004498 File Offset: 0x00002698
		public RemoteStorageEnumerateUserPublishedFilesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0002A9D0 File Offset: 0x00028BD0
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x000044AA File Offset: 0x000026AA
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x0002A9EC File Offset: 0x00028BEC
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x000044B8 File Offset: 0x000026B8
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x0002AA14 File Offset: 0x00028C14
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x000044D3 File Offset: 0x000026D3
		public unsafe int m_nResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned)) = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x0002AA3C File Offset: 0x00028C3C
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x000044EE File Offset: 0x000026EE
		public unsafe int m_nTotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount)) = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0002AA64 File Offset: 0x00028C64
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00004509 File Offset: 0x00002709
		public unsafe Il2CppStructArray<PublishedFileId_t> m_rgPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeFieldInfoPtr_m_nResultsReturned;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeFieldInfoPtr_m_nTotalResultCount;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeFieldInfoPtr_m_rgPublishedFileId;
	}
}
