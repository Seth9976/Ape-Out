using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem
{
	// Token: 0x02000065 RID: 101
	public sealed class LocalDataStoreMgr : Object
	{
		// Token: 0x06000690 RID: 1680 RVA: 0x00040254 File Offset: 0x0003E454
		// Note: this type is marked as 'beforefieldinit'.
		static LocalDataStoreMgr()
		{
			Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "LocalDataStoreMgr");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr);
			LocalDataStoreMgr.NativeFieldInfoPtr_InitialSlotTableSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "InitialSlotTableSize");
			LocalDataStoreMgr.NativeFieldInfoPtr_SlotTableDoubleThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "SlotTableDoubleThreshold");
			LocalDataStoreMgr.NativeFieldInfoPtr_LargeSlotTableSizeIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "LargeSlotTableSizeIncrease");
			LocalDataStoreMgr.NativeFieldInfoPtr_m_SlotInfoTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_SlotInfoTable");
			LocalDataStoreMgr.NativeFieldInfoPtr_m_FirstAvailableSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_FirstAvailableSlot");
			LocalDataStoreMgr.NativeFieldInfoPtr_m_ManagedLocalDataStores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_ManagedLocalDataStores");
			LocalDataStoreMgr.NativeFieldInfoPtr_m_KeyToSlotMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_KeyToSlotMap");
			LocalDataStoreMgr.NativeFieldInfoPtr_m_CookieGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_CookieGenerator");
			LocalDataStoreMgr.NativeMethodInfoPtr_CreateLocalDataStore_Public_LocalDataStoreHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664351);
			LocalDataStoreMgr.NativeMethodInfoPtr_DeleteLocalDataStore_Public_Void_LocalDataStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664352);
			LocalDataStoreMgr.NativeMethodInfoPtr_AllocateDataSlot_Public_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664353);
			LocalDataStoreMgr.NativeMethodInfoPtr_AllocateNamedDataSlot_Public_LocalDataStoreSlot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664354);
			LocalDataStoreMgr.NativeMethodInfoPtr_GetNamedDataSlot_Public_LocalDataStoreSlot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664355);
			LocalDataStoreMgr.NativeMethodInfoPtr_FreeNamedDataSlot_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664356);
			LocalDataStoreMgr.NativeMethodInfoPtr_FreeDataSlot_Internal_Void_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664357);
			LocalDataStoreMgr.NativeMethodInfoPtr_ValidateSlot_Public_Void_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664358);
			LocalDataStoreMgr.NativeMethodInfoPtr_GetSlotTableLength_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664359);
			LocalDataStoreMgr.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100664360);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000403EC File Offset: 0x0003E5EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146967, RefRangeEnd = 146968, XrefRangeStart = 146952, XrefRangeEnd = 146967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreHolder CreateLocalDataStore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_CreateLocalDataStore_Public_LocalDataStoreHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreHolder>(intPtr3) : null;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0004042C File Offset: 0x0003E62C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146973, RefRangeEnd = 146975, XrefRangeStart = 146968, XrefRangeEnd = 146973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteLocalDataStore(LocalDataStore store)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_DeleteLocalDataStore_Public_Void_LocalDataStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00040470 File Offset: 0x0003E670
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146988, RefRangeEnd = 146990, XrefRangeStart = 146975, XrefRangeEnd = 146988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreSlot AllocateDataSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_AllocateDataSlot_Public_LocalDataStoreSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x000404B0 File Offset: 0x0003E6B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146996, RefRangeEnd = 146998, XrefRangeStart = 146990, XrefRangeEnd = 146996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreSlot AllocateNamedDataSlot(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_AllocateNamedDataSlot_Public_LocalDataStoreSlot_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00040500 File Offset: 0x0003E700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147005, RefRangeEnd = 147006, XrefRangeStart = 146998, XrefRangeEnd = 147005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreSlot GetNamedDataSlot(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_GetNamedDataSlot_Public_LocalDataStoreSlot_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00040550 File Offset: 0x0003E750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147012, RefRangeEnd = 147013, XrefRangeStart = 147006, XrefRangeEnd = 147012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeNamedDataSlot(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_FreeNamedDataSlot_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00040594 File Offset: 0x0003E794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147020, RefRangeEnd = 147021, XrefRangeStart = 147013, XrefRangeEnd = 147020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeDataSlot(int slot, long cookie)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref slot;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_FreeDataSlot_Internal_Void_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000405E0 File Offset: 0x0003E7E0
		[CallerCount(0)]
		public unsafe void ValidateSlot(LocalDataStoreSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_ValidateSlot_Public_Void_LocalDataStoreSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00040624 File Offset: 0x0003E824
		[CallerCount(0)]
		public unsafe int GetSlotTableLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_GetSlotTableLength_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00040660 File Offset: 0x0003E860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147035, RefRangeEnd = 147036, XrefRangeStart = 147021, XrefRangeEnd = 147035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreMgr()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00004176 File Offset: 0x00002376
		public LocalDataStoreMgr(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x0004069C File Offset: 0x0003E89C
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x0000417F File Offset: 0x0000237F
		public unsafe static int InitialSlotTableSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LocalDataStoreMgr.NativeFieldInfoPtr_InitialSlotTableSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalDataStoreMgr.NativeFieldInfoPtr_InitialSlotTableSize, (void*)(&value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x000406B8 File Offset: 0x0003E8B8
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x0000418D File Offset: 0x0000238D
		public unsafe static int SlotTableDoubleThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LocalDataStoreMgr.NativeFieldInfoPtr_SlotTableDoubleThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalDataStoreMgr.NativeFieldInfoPtr_SlotTableDoubleThreshold, (void*)(&value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x000406D4 File Offset: 0x0003E8D4
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x0000419B File Offset: 0x0000239B
		public unsafe static int LargeSlotTableSizeIncrease
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LocalDataStoreMgr.NativeFieldInfoPtr_LargeSlotTableSizeIncrease, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalDataStoreMgr.NativeFieldInfoPtr_LargeSlotTableSizeIncrease, (void*)(&value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x000406F0 File Offset: 0x0003E8F0
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x000041A9 File Offset: 0x000023A9
		public unsafe Il2CppStructArray<bool> m_SlotInfoTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_SlotInfoTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_SlotInfoTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00040720 File Offset: 0x0003E920
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x000041C8 File Offset: 0x000023C8
		public unsafe int m_FirstAvailableSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_FirstAvailableSlot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_FirstAvailableSlot)) = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00040748 File Offset: 0x0003E948
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x000041E3 File Offset: 0x000023E3
		public unsafe List<LocalDataStore> m_ManagedLocalDataStores
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_ManagedLocalDataStores);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalDataStore>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_ManagedLocalDataStores), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00040778 File Offset: 0x0003E978
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x00004202 File Offset: 0x00002402
		public unsafe Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_KeyToSlotMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, LocalDataStoreSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_KeyToSlotMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x000407A8 File Offset: 0x0003E9A8
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x00004221 File Offset: 0x00002421
		public unsafe long m_CookieGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_CookieGenerator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_CookieGenerator)) = value;
			}
		}

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeFieldInfoPtr_InitialSlotTableSize;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeFieldInfoPtr_SlotTableDoubleThreshold;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeFieldInfoPtr_LargeSlotTableSizeIncrease;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeFieldInfoPtr_m_SlotInfoTable;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstAvailableSlot;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeFieldInfoPtr_m_ManagedLocalDataStores;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyToSlotMap;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeFieldInfoPtr_m_CookieGenerator;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocalDataStore_Public_LocalDataStoreHolder_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLocalDataStore_Public_Void_LocalDataStore_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_AllocateDataSlot_Public_LocalDataStoreSlot_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_AllocateNamedDataSlot_Public_LocalDataStoreSlot_String_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_GetNamedDataSlot_Public_LocalDataStoreSlot_String_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_FreeNamedDataSlot_Public_Void_String_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_FreeDataSlot_Internal_Void_Int32_Int64_0;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_ValidateSlot_Public_Void_LocalDataStoreSlot_0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotTableLength_Internal_Int32_0;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
