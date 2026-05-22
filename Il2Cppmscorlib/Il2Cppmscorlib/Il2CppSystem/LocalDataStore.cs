using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000063 RID: 99
	public sealed class LocalDataStore : Object
	{
		// Token: 0x06000677 RID: 1655 RVA: 0x0003FCB0 File Offset: 0x0003DEB0
		// Note: this type is marked as 'beforefieldinit'.
		static LocalDataStore()
		{
			Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "LocalDataStore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr);
			LocalDataStore.NativeFieldInfoPtr_m_DataTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, "m_DataTable");
			LocalDataStore.NativeFieldInfoPtr_m_Manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, "m_Manager");
			LocalDataStore.NativeMethodInfoPtr__ctor_Public_Void_LocalDataStoreMgr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100664340);
			LocalDataStore.NativeMethodInfoPtr_Dispose_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100664341);
			LocalDataStore.NativeMethodInfoPtr_GetData_Public_Object_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100664342);
			LocalDataStore.NativeMethodInfoPtr_SetData_Public_Void_LocalDataStoreSlot_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100664343);
			LocalDataStore.NativeMethodInfoPtr_FreeData_Internal_Void_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100664344);
			LocalDataStore.NativeMethodInfoPtr_PopulateElement_Private_LocalDataStoreElement_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100664345);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0003FD80 File Offset: 0x0003DF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146927, XrefRangeEnd = 146930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStore(LocalDataStoreMgr mgr, int InitialCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref InitialCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr__ctor_Public_Void_LocalDataStoreMgr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0003FDDC File Offset: 0x0003DFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146930, XrefRangeEnd = 146932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr_Dispose_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0003FE10 File Offset: 0x0003E010
		[CallerCount(0)]
		public unsafe Object GetData(LocalDataStoreSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr_GetData_Public_Object_LocalDataStoreSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0003FE60 File Offset: 0x0003E060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146933, RefRangeEnd = 146934, XrefRangeStart = 146932, XrefRangeEnd = 146933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(LocalDataStoreSlot slot, Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr_SetData_Public_Void_LocalDataStoreSlot_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0003FEB4 File Offset: 0x0003E0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146934, XrefRangeEnd = 146935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeData(int slot, long cookie)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr_FreeData_Internal_Void_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0003FF00 File Offset: 0x0003E100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146948, RefRangeEnd = 146949, XrefRangeStart = 146935, XrefRangeEnd = 146948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr_PopulateElement_Private_LocalDataStoreElement_LocalDataStoreSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreElement>(intPtr3) : null;
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x000040D1 File Offset: 0x000022D1
		public LocalDataStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0003FF50 File Offset: 0x0003E150
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x000040DA File Offset: 0x000022DA
		public unsafe Il2CppReferenceArray<LocalDataStoreElement> m_DataTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStore.NativeFieldInfoPtr_m_DataTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalDataStoreElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStore.NativeFieldInfoPtr_m_DataTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x0003FF80 File Offset: 0x0003E180
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x000040F9 File Offset: 0x000022F9
		public unsafe LocalDataStoreMgr m_Manager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStore.NativeFieldInfoPtr_m_Manager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreMgr>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStore.NativeFieldInfoPtr_m_Manager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeFieldInfoPtr_m_DataTable;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeFieldInfoPtr_m_Manager;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalDataStoreMgr_Int32_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Void_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Object_LocalDataStoreSlot_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_LocalDataStoreSlot_Object_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_FreeData_Internal_Void_Int32_Int64_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_PopulateElement_Private_LocalDataStoreElement_LocalDataStoreSlot_0;
	}
}
