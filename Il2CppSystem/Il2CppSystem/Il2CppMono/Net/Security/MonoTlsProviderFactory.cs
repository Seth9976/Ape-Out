using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000026 RID: 38
	public static class MonoTlsProviderFactory : Object
	{
		// Token: 0x0600020C RID: 524 RVA: 0x00018AC0 File Offset: 0x00016CC0
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTlsProviderFactory()
		{
			Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MonoTlsProviderFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr);
			MonoTlsProviderFactory.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "locker");
			MonoTlsProviderFactory.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "initialized");
			MonoTlsProviderFactory.NativeFieldInfoPtr_defaultProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "defaultProvider");
			MonoTlsProviderFactory.NativeFieldInfoPtr_providerRegistration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "providerRegistration");
			MonoTlsProviderFactory.NativeFieldInfoPtr_providerCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "providerCache");
			MonoTlsProviderFactory.NativeFieldInfoPtr_UnityTlsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "UnityTlsId");
			MonoTlsProviderFactory.NativeFieldInfoPtr_AppleTlsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "AppleTlsId");
			MonoTlsProviderFactory.NativeFieldInfoPtr_BtlsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "BtlsId");
			MonoTlsProviderFactory.NativeFieldInfoPtr_LegacyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "LegacyId");
			MonoTlsProviderFactory.NativeMethodInfoPtr_GetProviderInternal_Internal_Static_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663728);
			MonoTlsProviderFactory.NativeMethodInfoPtr_InitializeInternal_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663729);
			MonoTlsProviderFactory.NativeMethodInfoPtr_LookupProvider_Private_Static_MonoTlsProvider_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663730);
			MonoTlsProviderFactory.NativeMethodInfoPtr_InitializeProviderRegistration_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663731);
			MonoTlsProviderFactory.NativeMethodInfoPtr_CreateDefaultProviderImpl_Private_Static_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663732);
			MonoTlsProviderFactory.NativeMethodInfoPtr_GetProvider_Internal_Static_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663733);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00018C1C File Offset: 0x00016E1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 366463, RefRangeEnd = 366467, XrefRangeStart = 366452, XrefRangeEnd = 366463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoTlsProvider GetProviderInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_GetProviderInternal_Internal_Static_MonoTlsProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr3) : null;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00018C50 File Offset: 0x00016E50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366511, RefRangeEnd = 366512, XrefRangeStart = 366467, XrefRangeEnd = 366511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_InitializeInternal_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00018C78 File Offset: 0x00016E78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366551, RefRangeEnd = 366553, XrefRangeStart = 366512, XrefRangeEnd = 366551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoTlsProvider LookupProvider(string name, bool throwOnError)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_LookupProvider_Private_Static_MonoTlsProvider_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr3) : null;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00018CCC File Offset: 0x00016ECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366624, RefRangeEnd = 366626, XrefRangeStart = 366553, XrefRangeEnd = 366624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeProviderRegistration()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_InitializeProviderRegistration_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00018CF4 File Offset: 0x00016EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366626, XrefRangeEnd = 366635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoTlsProvider CreateDefaultProviderImpl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_CreateDefaultProviderImpl_Private_Static_MonoTlsProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr3) : null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00018D28 File Offset: 0x00016F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366635, XrefRangeEnd = 366639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoTlsProvider GetProvider()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_GetProvider_Internal_Static_MonoTlsProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr3) : null;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002C14 File Offset: 0x00000E14
		public MonoTlsProviderFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00018D5C File Offset: 0x00016F5C
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00002C1D File Offset: 0x00000E1D
		public unsafe static Object locker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_locker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_locker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00018D84 File Offset: 0x00016F84
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00002C2F File Offset: 0x00000E2F
		public unsafe static bool initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_initialized, (void*)(&value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00018DA0 File Offset: 0x00016FA0
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00002C3D File Offset: 0x00000E3D
		public unsafe static MonoTlsProvider defaultProvider
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_defaultProvider, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_defaultProvider, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00018DC8 File Offset: 0x00016FC8
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00002C4F File Offset: 0x00000E4F
		public unsafe static Dictionary<string, Tuple<Guid, string>> providerRegistration
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_providerRegistration, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Tuple<Guid, string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_providerRegistration, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00018DF0 File Offset: 0x00016FF0
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00002C61 File Offset: 0x00000E61
		public unsafe static Dictionary<Guid, MonoTlsProvider> providerCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_providerCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Guid, MonoTlsProvider>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_providerCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00018E18 File Offset: 0x00017018
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00002C73 File Offset: 0x00000E73
		public unsafe static Guid UnityTlsId
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_UnityTlsId, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_UnityTlsId, (void*)(&value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00018E34 File Offset: 0x00017034
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00002C81 File Offset: 0x00000E81
		public unsafe static Guid AppleTlsId
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_AppleTlsId, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_AppleTlsId, (void*)(&value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00018E50 File Offset: 0x00017050
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00002C8F File Offset: 0x00000E8F
		public unsafe static Guid BtlsId
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_BtlsId, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_BtlsId, (void*)(&value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00018E6C File Offset: 0x0001706C
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00002C9D File Offset: 0x00000E9D
		public unsafe static Guid LegacyId
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_LegacyId, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_LegacyId, (void*)(&value));
			}
		}

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr_defaultProvider;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_providerRegistration;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_providerCache;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_UnityTlsId;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_AppleTlsId;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_BtlsId;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_LegacyId;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_GetProviderInternal_Internal_Static_MonoTlsProvider_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInternal_Internal_Static_Void_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_LookupProvider_Private_Static_MonoTlsProvider_String_Boolean_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_InitializeProviderRegistration_Private_Static_Void_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultProviderImpl_Private_Static_MonoTlsProvider_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_GetProvider_Internal_Static_MonoTlsProvider_0;
	}
}
