using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000F0 RID: 240
	public static class NclUtilities : Object
	{
		// Token: 0x06000D29 RID: 3369 RVA: 0x00042080 File Offset: 0x00040280
		// Note: this type is marked as 'beforefieldinit'.
		static NclUtilities()
		{
			Il2CppClassPointerStore<NclUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "NclUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr);
			NclUtilities.NativeFieldInfoPtr__LocalAddresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, "_LocalAddresses");
			NclUtilities.NativeFieldInfoPtr__LocalAddressesLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, "_LocalAddressesLock");
			NclUtilities.NativeFieldInfoPtr__LocalDomainName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, "_LocalDomainName");
			NclUtilities.NativeMethodInfoPtr_IsAddressLocal_Internal_Static_Boolean_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100665198);
			NclUtilities.NativeMethodInfoPtr_GetLocalHost_Private_Static_IPHostEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100665199);
			NclUtilities.NativeMethodInfoPtr_get_LocalAddresses_Internal_Static_get_Il2CppReferenceArray_1_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100665200);
			NclUtilities.NativeMethodInfoPtr_get_LocalAddressesLock_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100665201);
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x0004213C File Offset: 0x0004033C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376721, XrefRangeEnd = 376724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAddressLocal(IPAddress ipAddress)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ipAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NclUtilities.NativeMethodInfoPtr_IsAddressLocal_Internal_Static_Boolean_IPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00042180 File Offset: 0x00040380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376724, XrefRangeEnd = 376729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry GetLocalHost()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NclUtilities.NativeMethodInfoPtr_GetLocalHost_Private_Static_IPHostEntry_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x000421B4 File Offset: 0x000403B4
		public unsafe static Il2CppReferenceArray<IPAddress> LocalAddresses
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 376777, RefRangeEnd = 376778, XrefRangeStart = 376729, XrefRangeEnd = 376777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NclUtilities.NativeMethodInfoPtr_get_LocalAddresses_Internal_Static_get_Il2CppReferenceArray_1_IPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr3) : null;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x000421E8 File Offset: 0x000403E8
		public unsafe static Object LocalAddressesLock
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376778, XrefRangeEnd = 376785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NclUtilities.NativeMethodInfoPtr_get_LocalAddressesLock_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00007362 File Offset: 0x00005562
		public NclUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x0004221C File Offset: 0x0004041C
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x0000736B File Offset: 0x0000556B
		public unsafe static Il2CppReferenceArray<IPAddress> _LocalAddresses
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NclUtilities.NativeFieldInfoPtr__LocalAddresses, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NclUtilities.NativeFieldInfoPtr__LocalAddresses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x00042244 File Offset: 0x00040444
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x0000737D File Offset: 0x0000557D
		public unsafe static Object _LocalAddressesLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NclUtilities.NativeFieldInfoPtr__LocalAddressesLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NclUtilities.NativeFieldInfoPtr__LocalAddressesLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x0004226C File Offset: 0x0004046C
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x0000738F File Offset: 0x0000558F
		public unsafe static string _LocalDomainName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NclUtilities.NativeFieldInfoPtr__LocalDomainName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NclUtilities.NativeFieldInfoPtr__LocalDomainName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeFieldInfoPtr__LocalAddresses;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeFieldInfoPtr__LocalAddressesLock;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeFieldInfoPtr__LocalDomainName;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_IsAddressLocal_Internal_Static_Boolean_IPAddress_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalHost_Private_Static_IPHostEntry_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalAddresses_Internal_Static_get_Il2CppReferenceArray_1_IPAddress_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalAddressesLock_Private_Static_get_Object_0;
	}
}
