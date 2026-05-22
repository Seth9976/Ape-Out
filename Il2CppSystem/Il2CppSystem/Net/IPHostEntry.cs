using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000ED RID: 237
	public class IPHostEntry : Object
	{
		// Token: 0x06000D13 RID: 3347 RVA: 0x00041CC0 File Offset: 0x0003FEC0
		// Note: this type is marked as 'beforefieldinit'.
		static IPHostEntry()
		{
			Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IPHostEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr);
			IPHostEntry.NativeFieldInfoPtr_hostName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, "hostName");
			IPHostEntry.NativeFieldInfoPtr_aliases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, "aliases");
			IPHostEntry.NativeFieldInfoPtr_addressList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, "addressList");
			IPHostEntry.NativeFieldInfoPtr_isTrustedHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, "isTrustedHost");
			IPHostEntry.NativeMethodInfoPtr_get_HostName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100665190);
			IPHostEntry.NativeMethodInfoPtr_set_HostName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100665191);
			IPHostEntry.NativeMethodInfoPtr_set_Aliases_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100665192);
			IPHostEntry.NativeMethodInfoPtr_get_AddressList_Public_get_Il2CppReferenceArray_1_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100665193);
			IPHostEntry.NativeMethodInfoPtr_set_AddressList_Public_set_Void_Il2CppReferenceArray_1_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100665194);
			IPHostEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100665195);
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x00041DB8 File Offset: 0x0003FFB8
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x00041DF0 File Offset: 0x0003FFF0
		public unsafe string HostName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr_get_HostName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr_set_HostName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E2 RID: 994
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x00041E34 File Offset: 0x00040034
		public unsafe Il2CppStringArray Aliases
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr_set_Aliases_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x00041E78 File Offset: 0x00040078
		// (set) Token: 0x06000D18 RID: 3352 RVA: 0x00041EB8 File Offset: 0x000400B8
		public unsafe Il2CppReferenceArray<IPAddress> AddressList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr_get_AddressList_Public_get_Il2CppReferenceArray_1_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr3) : null;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr_set_AddressList_Public_set_Void_Il2CppReferenceArray_1_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00041EFC File Offset: 0x000400FC
		[CallerCount(0)]
		public unsafe IPHostEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00007267 File Offset: 0x00005467
		public IPHostEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00041F38 File Offset: 0x00040138
		// (set) Token: 0x06000D1C RID: 3356 RVA: 0x00007270 File Offset: 0x00005470
		public unsafe string hostName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_hostName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_hostName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x00041F60 File Offset: 0x00040160
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x0000728F File Offset: 0x0000548F
		public unsafe Il2CppStringArray aliases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_aliases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_aliases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x00041F90 File Offset: 0x00040190
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x000072AE File Offset: 0x000054AE
		public unsafe Il2CppReferenceArray<IPAddress> addressList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_addressList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_addressList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x00041FC0 File Offset: 0x000401C0
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x000072CD File Offset: 0x000054CD
		public unsafe bool isTrustedHost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_isTrustedHost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_isTrustedHost)) = value;
			}
		}

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeFieldInfoPtr_hostName;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeFieldInfoPtr_aliases;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeFieldInfoPtr_addressList;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeFieldInfoPtr_isTrustedHost;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_get_HostName_Public_get_String_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_set_HostName_Public_set_Void_String_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_set_Aliases_Public_set_Void_Il2CppStringArray_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressList_Public_get_Il2CppReferenceArray_1_IPAddress_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_set_AddressList_Public_set_Void_Il2CppReferenceArray_1_IPAddress_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
