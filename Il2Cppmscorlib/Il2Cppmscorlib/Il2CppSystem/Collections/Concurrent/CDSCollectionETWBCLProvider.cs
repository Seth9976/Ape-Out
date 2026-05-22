using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Diagnostics.Tracing;

namespace Il2CppSystem.Collections.Concurrent
{
	// Token: 0x02000489 RID: 1161
	public sealed class CDSCollectionETWBCLProvider : EventSource
	{
		// Token: 0x060046CF RID: 18127 RVA: 0x00145C24 File Offset: 0x00143E24
		// Note: this type is marked as 'beforefieldinit'.
		static CDSCollectionETWBCLProvider()
		{
			Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Concurrent", "CDSCollectionETWBCLProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr);
			CDSCollectionETWBCLProvider.NativeFieldInfoPtr_Log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr, "Log");
			CDSCollectionETWBCLProvider.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr, 100673797);
			CDSCollectionETWBCLProvider.NativeMethodInfoPtr_ConcurrentDictionary_AcquiringAllLocks_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr, 100673798);
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x00145C90 File Offset: 0x00143E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230145, XrefRangeEnd = 230149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CDSCollectionETWBCLProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CDSCollectionETWBCLProvider.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046D1 RID: 18129 RVA: 0x00145CCC File Offset: 0x00143ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230149, XrefRangeEnd = 230150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numOfBuckets;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CDSCollectionETWBCLProvider.NativeMethodInfoPtr_ConcurrentDictionary_AcquiringAllLocks_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046D2 RID: 18130 RVA: 0x0001ACD6 File Offset: 0x00018ED6
		public CDSCollectionETWBCLProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x060046D3 RID: 18131 RVA: 0x00145D0C File Offset: 0x00143F0C
		// (set) Token: 0x060046D4 RID: 18132 RVA: 0x0001ACDF File Offset: 0x00018EDF
		public unsafe static CDSCollectionETWBCLProvider Log
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CDSCollectionETWBCLProvider.NativeFieldInfoPtr_Log, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CDSCollectionETWBCLProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CDSCollectionETWBCLProvider.NativeFieldInfoPtr_Log, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400398C RID: 14732
		private static readonly IntPtr NativeFieldInfoPtr_Log;

		// Token: 0x0400398D RID: 14733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400398E RID: 14734
		private static readonly IntPtr NativeMethodInfoPtr_ConcurrentDictionary_AcquiringAllLocks_Public_Void_Int32_0;
	}
}
