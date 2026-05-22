using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net
{
	// Token: 0x02000113 RID: 275
	[Serializable]
	public class CookieContainer : Object
	{
		// Token: 0x06000F4B RID: 3915 RVA: 0x00049D04 File Offset: 0x00047F04
		// Note: this type is marked as 'beforefieldinit'.
		static CookieContainer()
		{
			Il2CppClassPointerStore<CookieContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CookieContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr);
			CookieContainer.NativeFieldInfoPtr_HeaderInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "HeaderInfo");
			CookieContainer.NativeFieldInfoPtr_m_domainTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_domainTable");
			CookieContainer.NativeFieldInfoPtr_m_maxCookieSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_maxCookieSize");
			CookieContainer.NativeFieldInfoPtr_m_maxCookies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_maxCookies");
			CookieContainer.NativeFieldInfoPtr_m_maxCookiesPerDomain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_maxCookiesPerDomain");
			CookieContainer.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_count");
			CookieContainer.NativeFieldInfoPtr_m_fqdnMyDomain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_fqdnMyDomain");
			CookieContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665490);
			CookieContainer.NativeMethodInfoPtr_AddRemoveDomain_Private_Void_String_PathList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665491);
			CookieContainer.NativeMethodInfoPtr_Add_Internal_Void_Cookie_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665492);
			CookieContainer.NativeMethodInfoPtr_AgeCookies_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665493);
			CookieContainer.NativeMethodInfoPtr_ExpireCollection_Private_Int32_CookieCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665494);
			CookieContainer.NativeMethodInfoPtr_IsLocalDomain_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665495);
			CookieContainer.NativeMethodInfoPtr_CookieCutter_Internal_CookieCollection_Uri_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665496);
			CookieContainer.NativeMethodInfoPtr_InternalGetCookies_Internal_CookieCollection_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665497);
			CookieContainer.NativeMethodInfoPtr_BuildCookieCollectionFromDomainMatches_Private_Void_Uri_Boolean_Int32_CookieCollection_List_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665498);
			CookieContainer.NativeMethodInfoPtr_MergeUpdateCollections_Private_Void_CookieCollection_CookieCollection_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665499);
			CookieContainer.NativeMethodInfoPtr_GetCookieHeader_Public_String_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665500);
			CookieContainer.NativeMethodInfoPtr_GetCookieHeader_Internal_String_Uri_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665501);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00049EB0 File Offset: 0x000480B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378822, XrefRangeEnd = 378833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieContainer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00049EEC File Offset: 0x000480EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 378837, RefRangeEnd = 378839, XrefRangeStart = 378833, XrefRangeEnd = 378837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRemoveDomain(string key, PathList value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_AddRemoveDomain_Private_Void_String_PathList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00049F40 File Offset: 0x00048140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378882, RefRangeEnd = 378883, XrefRangeStart = 378839, XrefRangeEnd = 378882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Cookie cookie, bool throwOnError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookie);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_Add_Internal_Void_Cookie_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00049F90 File Offset: 0x00048190
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 378995, RefRangeEnd = 378997, XrefRangeStart = 378883, XrefRangeEnd = 378995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AgeCookies(string domain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(domain);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_AgeCookies_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00049FE0 File Offset: 0x000481E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379003, RefRangeEnd = 379004, XrefRangeStart = 378997, XrefRangeEnd = 379003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExpireCollection(CookieCollection cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_ExpireCollection_Private_Int32_CookieCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0004A030 File Offset: 0x00048230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379018, RefRangeEnd = 379019, XrefRangeStart = 379004, XrefRangeEnd = 379018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLocalDomain(string host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_IsLocalDomain_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0004A080 File Offset: 0x00048280
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 379079, RefRangeEnd = 379081, XrefRangeStart = 379019, XrefRangeEnd = 379079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(headerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(setCookieHeader);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isThrow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_CookieCutter_Internal_CookieCollection_Uri_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookieCollection>(intPtr3) : null;
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0004A104 File Offset: 0x00048304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379124, RefRangeEnd = 379125, XrefRangeStart = 379081, XrefRangeEnd = 379124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieCollection InternalGetCookies(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_InternalGetCookies_Internal_CookieCollection_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookieCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0004A154 File Offset: 0x00048354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 379182, RefRangeEnd = 379184, XrefRangeStart = 379125, XrefRangeEnd = 379182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSecure;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookies);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(domainAttribute);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchOnlyPlainCookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_BuildCookieCollectionFromDomainMatches_Private_Void_Uri_Boolean_Int32_CookieCollection_List_1_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0004A1E8 File Offset: 0x000483E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 379193, RefRangeEnd = 379195, XrefRangeStart = 379184, XrefRangeEnd = 379193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSecure;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPlainOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_MergeUpdateCollections_Private_Void_CookieCollection_CookieCollection_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0004A268 File Offset: 0x00048468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379195, XrefRangeEnd = 379199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCookieHeader(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_GetCookieHeader_Public_String_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0004A2B0 File Offset: 0x000484B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 379232, RefRangeEnd = 379234, XrefRangeStart = 379199, XrefRangeEnd = 379232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCookieHeader(Uri uri, out string optCookie2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_GetCookieHeader_Internal_String_Uri_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			optCookie2 = IL2CPP.Il2CppStringToManaged(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0000804D File Offset: 0x0000624D
		public CookieContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x0004A314 File Offset: 0x00048514
		// (set) Token: 0x06000F5A RID: 3930 RVA: 0x00008056 File Offset: 0x00006256
		public unsafe static Il2CppReferenceArray<HeaderVariantInfo> HeaderInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CookieContainer.NativeFieldInfoPtr_HeaderInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HeaderVariantInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CookieContainer.NativeFieldInfoPtr_HeaderInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x0004A33C File Offset: 0x0004853C
		// (set) Token: 0x06000F5C RID: 3932 RVA: 0x00008068 File Offset: 0x00006268
		public unsafe Hashtable m_domainTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_domainTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_domainTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x0004A36C File Offset: 0x0004856C
		// (set) Token: 0x06000F5E RID: 3934 RVA: 0x00008087 File Offset: 0x00006287
		public unsafe int m_maxCookieSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookieSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookieSize)) = value;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x0004A394 File Offset: 0x00048594
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x000080A2 File Offset: 0x000062A2
		public unsafe int m_maxCookies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookies);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookies)) = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x0004A3BC File Offset: 0x000485BC
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x000080BD File Offset: 0x000062BD
		public unsafe int m_maxCookiesPerDomain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookiesPerDomain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookiesPerDomain)) = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x0004A3E4 File Offset: 0x000485E4
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x000080D8 File Offset: 0x000062D8
		public unsafe int m_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_count)) = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x0004A40C File Offset: 0x0004860C
		// (set) Token: 0x06000F66 RID: 3942 RVA: 0x000080F3 File Offset: 0x000062F3
		public unsafe string m_fqdnMyDomain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_fqdnMyDomain);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_fqdnMyDomain), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeFieldInfoPtr_HeaderInfo;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeFieldInfoPtr_m_domainTable;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCookieSize;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCookies;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCookiesPerDomain;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeFieldInfoPtr_m_count;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeFieldInfoPtr_m_fqdnMyDomain;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeMethodInfoPtr_AddRemoveDomain_Private_Void_String_PathList_0;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_Cookie_Boolean_0;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr_AgeCookies_Private_Boolean_String_0;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeMethodInfoPtr_ExpireCollection_Private_Int32_CookieCollection_0;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalDomain_Internal_Boolean_String_0;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr_CookieCutter_Internal_CookieCollection_Uri_String_String_Boolean_0;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetCookies_Internal_CookieCollection_Uri_0;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr_BuildCookieCollectionFromDomainMatches_Private_Void_Uri_Boolean_Int32_CookieCollection_List_1_String_Boolean_0;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeMethodInfoPtr_MergeUpdateCollections_Private_Void_CookieCollection_CookieCollection_Int32_Boolean_Boolean_0;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr_GetCookieHeader_Public_String_Uri_0;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr_GetCookieHeader_Internal_String_Uri_byref_String_0;
	}
}
