using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Resources
{
	// Token: 0x02000185 RID: 389
	[Serializable]
	public class ResourceManager : Object
	{
		// Token: 0x06001AE9 RID: 6889 RVA: 0x0009EB80 File Offset: 0x0009CD80
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceManager()
		{
			Il2CppClassPointerStore<ResourceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ResourceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr);
			ResourceManager.NativeFieldInfoPtr_BaseNameField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "BaseNameField");
			ResourceManager.NativeFieldInfoPtr_ResourceSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "ResourceSets");
			ResourceManager.NativeFieldInfoPtr__resourceSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_resourceSets");
			ResourceManager.NativeFieldInfoPtr_moduleDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "moduleDir");
			ResourceManager.NativeFieldInfoPtr_MainAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "MainAssembly");
			ResourceManager.NativeFieldInfoPtr__locationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_locationInfo");
			ResourceManager.NativeFieldInfoPtr__userResourceSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_userResourceSet");
			ResourceManager.NativeFieldInfoPtr__neutralResourcesCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_neutralResourcesCulture");
			ResourceManager.NativeFieldInfoPtr__lastUsedResourceCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_lastUsedResourceCache");
			ResourceManager.NativeFieldInfoPtr__ignoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_ignoreCase");
			ResourceManager.NativeFieldInfoPtr_UseManifest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "UseManifest");
			ResourceManager.NativeFieldInfoPtr_UseSatelliteAssem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "UseSatelliteAssem");
			ResourceManager.NativeFieldInfoPtr__fallbackLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_fallbackLoc");
			ResourceManager.NativeFieldInfoPtr__satelliteContractVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_satelliteContractVersion");
			ResourceManager.NativeFieldInfoPtr__lookedForSatelliteContractVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_lookedForSatelliteContractVersion");
			ResourceManager.NativeFieldInfoPtr__callingAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_callingAssembly");
			ResourceManager.NativeFieldInfoPtr_m_callingAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_callingAssembly");
			ResourceManager.NativeFieldInfoPtr_resourceGroveler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "resourceGroveler");
			ResourceManager.NativeFieldInfoPtr_MagicNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "MagicNumber");
			ResourceManager.NativeFieldInfoPtr_HeaderVersionNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "HeaderVersionNumber");
			ResourceManager.NativeFieldInfoPtr__minResourceSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_minResourceSet");
			ResourceManager.NativeFieldInfoPtr_ResReaderTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "ResReaderTypeName");
			ResourceManager.NativeFieldInfoPtr_ResSetTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "ResSetTypeName");
			ResourceManager.NativeFieldInfoPtr_MscorlibName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "MscorlibName");
			ResourceManager.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "DEBUG");
			ResourceManager.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667908);
			ResourceManager.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667909);
			ResourceManager.NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667910);
			ResourceManager.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667911);
			ResourceManager.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667912);
			ResourceManager.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667913);
			ResourceManager.NativeMethodInfoPtr_CommonAssemblyInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667914);
			ResourceManager.NativeMethodInfoPtr_get_BaseName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667915);
			ResourceManager.NativeMethodInfoPtr_get_FallbackLocation_Protected_get_UltimateResourceFallbackLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667916);
			ResourceManager.NativeMethodInfoPtr_GetResourceFileName_Protected_Virtual_New_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667917);
			ResourceManager.NativeMethodInfoPtr_GetFirstResourceSet_Internal_ResourceSet_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667918);
			ResourceManager.NativeMethodInfoPtr_GetResourceSet_Public_Virtual_New_ResourceSet_CultureInfo_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667919);
			ResourceManager.NativeMethodInfoPtr_InternalGetResourceSet_Protected_Virtual_New_ResourceSet_CultureInfo_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667920);
			ResourceManager.NativeMethodInfoPtr_InternalGetResourceSet_Private_ResourceSet_CultureInfo_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667921);
			ResourceManager.NativeMethodInfoPtr_AddResourceSet_Private_Static_Void_Dictionary_2_String_ResourceSet_String_byref_ResourceSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667922);
			ResourceManager.NativeMethodInfoPtr_GetSatelliteContractVersion_Protected_Static_Version_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667923);
			ResourceManager.NativeMethodInfoPtr_CompareNames_Internal_Static_Boolean_String_String_AssemblyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667924);
			ResourceManager.NativeMethodInfoPtr_SetAppXConfiguration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667925);
			ResourceManager.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667926);
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x0009EF20 File Offset: 0x0009D120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185248, RefRangeEnd = 185249, XrefRangeStart = 185245, XrefRangeEnd = 185248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x0009EF54 File Offset: 0x0009D154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185249, XrefRangeEnd = 185259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x0009EF90 File Offset: 0x0009D190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185259, XrefRangeEnd = 185273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceManager(string baseName, Assembly assembly)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x0009EFF0 File Offset: 0x0009D1F0
		[CallerCount(0)]
		public unsafe void OnDeserializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0009F038 File Offset: 0x0009D238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185273, XrefRangeEnd = 185295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0009F080 File Offset: 0x0009D280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185295, XrefRangeEnd = 185299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0009F0C8 File Offset: 0x0009D2C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185318, RefRangeEnd = 185319, XrefRangeStart = 185299, XrefRangeEnd = 185318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommonAssemblyInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_CommonAssemblyInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x0009F0FC File Offset: 0x0009D2FC
		public unsafe virtual string BaseName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.NativeMethodInfoPtr_get_BaseName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x0009F140 File Offset: 0x0009D340
		public unsafe UltimateResourceFallbackLocation FallbackLocation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_get_FallbackLocation_Protected_get_UltimateResourceFallbackLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x0009F17C File Offset: 0x0009D37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185319, XrefRangeEnd = 185338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetResourceFileName(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.NativeMethodInfoPtr_GetResourceFileName_Protected_Virtual_New_String_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x0009F1D0 File Offset: 0x0009D3D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185347, RefRangeEnd = 185348, XrefRangeStart = 185338, XrefRangeEnd = 185347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceSet GetFirstResourceSet(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_GetFirstResourceSet_Internal_ResourceSet_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
			}
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x0009F220 File Offset: 0x0009D420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185348, XrefRangeEnd = 185357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createIfNotExists;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryParents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.NativeMethodInfoPtr_GetResourceSet_Public_Virtual_New_ResourceSet_CultureInfo_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x0009F298 File Offset: 0x0009D498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185357, XrefRangeEnd = 185358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createIfNotExists;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryParents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.NativeMethodInfoPtr_InternalGetResourceSet_Protected_Virtual_New_ResourceSet_CultureInfo_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0009F310 File Offset: 0x0009D510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185370, RefRangeEnd = 185371, XrefRangeStart = 185358, XrefRangeEnd = 185370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceSet InternalGetResourceSet(CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedCulture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createIfNotExists;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryParents;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_InternalGetResourceSet_Private_ResourceSet_CultureInfo_Boolean_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x0009F38C File Offset: 0x0009D58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185371, XrefRangeEnd = 185384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddResourceSet(Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localResourceSets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(rs);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_AddResourceSet_Private_Static_Void_Dictionary_2_String_ResourceSet_String_byref_ResourceSet_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			rs = ((intPtr4 == 0) ? null : new ResourceSet(intPtr4));
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0009F3FC File Offset: 0x0009D5FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185423, RefRangeEnd = 185425, XrefRangeStart = 185384, XrefRangeEnd = 185423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Version GetSatelliteContractVersion(Assembly a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_GetSatelliteContractVersion_Protected_Static_Version_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x0009F440 File Offset: 0x0009D640
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 185450, RefRangeEnd = 185455, XrefRangeStart = 185425, XrefRangeEnd = 185450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asmTypeName1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asmName2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_CompareNames_Internal_Static_Boolean_String_String_AssemblyName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0009F4A8 File Offset: 0x0009D6A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAppXConfiguration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_SetAppXConfiguration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0009F4DC File Offset: 0x0009D6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185455, XrefRangeEnd = 185480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetString(string name, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0000909D File Offset: 0x0000729D
		public ResourceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001AFE RID: 6910 RVA: 0x0009F544 File Offset: 0x0009D744
		// (set) Token: 0x06001AFF RID: 6911 RVA: 0x000090A6 File Offset: 0x000072A6
		public unsafe string BaseNameField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_BaseNameField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_BaseNameField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x0009F56C File Offset: 0x0009D76C
		// (set) Token: 0x06001B01 RID: 6913 RVA: 0x000090C5 File Offset: 0x000072C5
		public unsafe Hashtable ResourceSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_ResourceSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_ResourceSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x0009F59C File Offset: 0x0009D79C
		// (set) Token: 0x06001B03 RID: 6915 RVA: 0x000090E4 File Offset: 0x000072E4
		public unsafe Dictionary<string, ResourceSet> _resourceSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__resourceSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ResourceSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__resourceSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x0009F5CC File Offset: 0x0009D7CC
		// (set) Token: 0x06001B05 RID: 6917 RVA: 0x00009103 File Offset: 0x00007303
		public unsafe string moduleDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_moduleDir);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_moduleDir), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0009F5F4 File Offset: 0x0009D7F4
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x00009122 File Offset: 0x00007322
		public unsafe Assembly MainAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_MainAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_MainAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x0009F624 File Offset: 0x0009D824
		// (set) Token: 0x06001B09 RID: 6921 RVA: 0x00009141 File Offset: 0x00007341
		public unsafe Type _locationInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__locationInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__locationInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x0009F654 File Offset: 0x0009D854
		// (set) Token: 0x06001B0B RID: 6923 RVA: 0x00009160 File Offset: 0x00007360
		public unsafe Type _userResourceSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__userResourceSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__userResourceSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x0009F684 File Offset: 0x0009D884
		// (set) Token: 0x06001B0D RID: 6925 RVA: 0x0000917F File Offset: 0x0000737F
		public unsafe CultureInfo _neutralResourcesCulture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__neutralResourcesCulture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__neutralResourcesCulture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x0009F6B4 File Offset: 0x0009D8B4
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x0000919E File Offset: 0x0000739E
		public unsafe ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__lastUsedResourceCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager.CultureNameResourceSetPair>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__lastUsedResourceCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x0009F6E4 File Offset: 0x0009D8E4
		// (set) Token: 0x06001B11 RID: 6929 RVA: 0x000091BD File Offset: 0x000073BD
		public unsafe bool _ignoreCase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__ignoreCase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__ignoreCase)) = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x0009F70C File Offset: 0x0009D90C
		// (set) Token: 0x06001B13 RID: 6931 RVA: 0x000091D8 File Offset: 0x000073D8
		public unsafe bool UseManifest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_UseManifest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_UseManifest)) = value;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x0009F734 File Offset: 0x0009D934
		// (set) Token: 0x06001B15 RID: 6933 RVA: 0x000091F3 File Offset: 0x000073F3
		public unsafe bool UseSatelliteAssem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_UseSatelliteAssem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_UseSatelliteAssem)) = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x0009F75C File Offset: 0x0009D95C
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x0000920E File Offset: 0x0000740E
		public unsafe UltimateResourceFallbackLocation _fallbackLoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__fallbackLoc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__fallbackLoc)) = value;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x0009F784 File Offset: 0x0009D984
		// (set) Token: 0x06001B19 RID: 6937 RVA: 0x00009229 File Offset: 0x00007429
		public unsafe Version _satelliteContractVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__satelliteContractVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__satelliteContractVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001B1A RID: 6938 RVA: 0x0009F7B4 File Offset: 0x0009D9B4
		// (set) Token: 0x06001B1B RID: 6939 RVA: 0x00009248 File Offset: 0x00007448
		public unsafe bool _lookedForSatelliteContractVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__lookedForSatelliteContractVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__lookedForSatelliteContractVersion)) = value;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001B1C RID: 6940 RVA: 0x0009F7DC File Offset: 0x0009D9DC
		// (set) Token: 0x06001B1D RID: 6941 RVA: 0x00009263 File Offset: 0x00007463
		public unsafe Assembly _callingAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__callingAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__callingAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001B1E RID: 6942 RVA: 0x0009F80C File Offset: 0x0009DA0C
		// (set) Token: 0x06001B1F RID: 6943 RVA: 0x00009282 File Offset: 0x00007482
		public unsafe RuntimeAssembly m_callingAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_callingAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_callingAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x0009F83C File Offset: 0x0009DA3C
		// (set) Token: 0x06001B21 RID: 6945 RVA: 0x000092A1 File Offset: 0x000074A1
		public unsafe IResourceGroveler resourceGroveler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_resourceGroveler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceGroveler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_resourceGroveler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001B22 RID: 6946 RVA: 0x0009F86C File Offset: 0x0009DA6C
		// (set) Token: 0x06001B23 RID: 6947 RVA: 0x000092C0 File Offset: 0x000074C0
		public unsafe static int MagicNumber
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_MagicNumber, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_MagicNumber, (void*)(&value));
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x0009F888 File Offset: 0x0009DA88
		// (set) Token: 0x06001B25 RID: 6949 RVA: 0x000092CE File Offset: 0x000074CE
		public unsafe static int HeaderVersionNumber
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_HeaderVersionNumber, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_HeaderVersionNumber, (void*)(&value));
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x0009F8A4 File Offset: 0x0009DAA4
		// (set) Token: 0x06001B27 RID: 6951 RVA: 0x000092DC File Offset: 0x000074DC
		public unsafe static Type _minResourceSet
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr__minResourceSet, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr__minResourceSet, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001B28 RID: 6952 RVA: 0x0009F8CC File Offset: 0x0009DACC
		// (set) Token: 0x06001B29 RID: 6953 RVA: 0x000092EE File Offset: 0x000074EE
		public unsafe static string ResReaderTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_ResReaderTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_ResReaderTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001B2A RID: 6954 RVA: 0x0009F8EC File Offset: 0x0009DAEC
		// (set) Token: 0x06001B2B RID: 6955 RVA: 0x00009300 File Offset: 0x00007500
		public unsafe static string ResSetTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_ResSetTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_ResSetTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x0009F90C File Offset: 0x0009DB0C
		// (set) Token: 0x06001B2D RID: 6957 RVA: 0x00009312 File Offset: 0x00007512
		public unsafe static string MscorlibName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_MscorlibName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_MscorlibName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x0009F92C File Offset: 0x0009DB2C
		// (set) Token: 0x06001B2F RID: 6959 RVA: 0x00009324 File Offset: 0x00007524
		public unsafe static int DEBUG
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_DEBUG, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_DEBUG, (void*)(&value));
			}
		}

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeFieldInfoPtr_BaseNameField;

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeFieldInfoPtr_ResourceSets;

		// Token: 0x0400187E RID: 6270
		private static readonly IntPtr NativeFieldInfoPtr__resourceSets;

		// Token: 0x0400187F RID: 6271
		private static readonly IntPtr NativeFieldInfoPtr_moduleDir;

		// Token: 0x04001880 RID: 6272
		private static readonly IntPtr NativeFieldInfoPtr_MainAssembly;

		// Token: 0x04001881 RID: 6273
		private static readonly IntPtr NativeFieldInfoPtr__locationInfo;

		// Token: 0x04001882 RID: 6274
		private static readonly IntPtr NativeFieldInfoPtr__userResourceSet;

		// Token: 0x04001883 RID: 6275
		private static readonly IntPtr NativeFieldInfoPtr__neutralResourcesCulture;

		// Token: 0x04001884 RID: 6276
		private static readonly IntPtr NativeFieldInfoPtr__lastUsedResourceCache;

		// Token: 0x04001885 RID: 6277
		private static readonly IntPtr NativeFieldInfoPtr__ignoreCase;

		// Token: 0x04001886 RID: 6278
		private static readonly IntPtr NativeFieldInfoPtr_UseManifest;

		// Token: 0x04001887 RID: 6279
		private static readonly IntPtr NativeFieldInfoPtr_UseSatelliteAssem;

		// Token: 0x04001888 RID: 6280
		private static readonly IntPtr NativeFieldInfoPtr__fallbackLoc;

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeFieldInfoPtr__satelliteContractVersion;

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeFieldInfoPtr__lookedForSatelliteContractVersion;

		// Token: 0x0400188B RID: 6283
		private static readonly IntPtr NativeFieldInfoPtr__callingAssembly;

		// Token: 0x0400188C RID: 6284
		private static readonly IntPtr NativeFieldInfoPtr_m_callingAssembly;

		// Token: 0x0400188D RID: 6285
		private static readonly IntPtr NativeFieldInfoPtr_resourceGroveler;

		// Token: 0x0400188E RID: 6286
		private static readonly IntPtr NativeFieldInfoPtr_MagicNumber;

		// Token: 0x0400188F RID: 6287
		private static readonly IntPtr NativeFieldInfoPtr_HeaderVersionNumber;

		// Token: 0x04001890 RID: 6288
		private static readonly IntPtr NativeFieldInfoPtr__minResourceSet;

		// Token: 0x04001891 RID: 6289
		private static readonly IntPtr NativeFieldInfoPtr_ResReaderTypeName;

		// Token: 0x04001892 RID: 6290
		private static readonly IntPtr NativeFieldInfoPtr_ResSetTypeName;

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeFieldInfoPtr_MscorlibName;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04001896 RID: 6294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001897 RID: 6295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0;

		// Token: 0x04001898 RID: 6296
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0;

		// Token: 0x04001899 RID: 6297
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x0400189A RID: 6298
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x0400189B RID: 6299
		private static readonly IntPtr NativeMethodInfoPtr_CommonAssemblyInit_Private_Void_0;

		// Token: 0x0400189C RID: 6300
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseName_Public_Virtual_New_get_String_0;

		// Token: 0x0400189D RID: 6301
		private static readonly IntPtr NativeMethodInfoPtr_get_FallbackLocation_Protected_get_UltimateResourceFallbackLocation_0;

		// Token: 0x0400189E RID: 6302
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceFileName_Protected_Virtual_New_String_CultureInfo_0;

		// Token: 0x0400189F RID: 6303
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstResourceSet_Internal_ResourceSet_CultureInfo_0;

		// Token: 0x040018A0 RID: 6304
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceSet_Public_Virtual_New_ResourceSet_CultureInfo_Boolean_Boolean_0;

		// Token: 0x040018A1 RID: 6305
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetResourceSet_Protected_Virtual_New_ResourceSet_CultureInfo_Boolean_Boolean_0;

		// Token: 0x040018A2 RID: 6306
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetResourceSet_Private_ResourceSet_CultureInfo_Boolean_Boolean_byref_StackCrawlMark_0;

		// Token: 0x040018A3 RID: 6307
		private static readonly IntPtr NativeMethodInfoPtr_AddResourceSet_Private_Static_Void_Dictionary_2_String_ResourceSet_String_byref_ResourceSet_0;

		// Token: 0x040018A4 RID: 6308
		private static readonly IntPtr NativeMethodInfoPtr_GetSatelliteContractVersion_Protected_Static_Version_Assembly_0;

		// Token: 0x040018A5 RID: 6309
		private static readonly IntPtr NativeMethodInfoPtr_CompareNames_Internal_Static_Boolean_String_String_AssemblyName_0;

		// Token: 0x040018A6 RID: 6310
		private static readonly IntPtr NativeMethodInfoPtr_SetAppXConfiguration_Private_Void_0;

		// Token: 0x040018A7 RID: 6311
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_CultureInfo_0;

		// Token: 0x020005C1 RID: 1473
		public class CultureNameResourceSetPair : Object
		{
			// Token: 0x06005271 RID: 21105 RVA: 0x00174780 File Offset: 0x00172980
			// Note: this type is marked as 'beforefieldinit'.
			static CultureNameResourceSetPair()
			{
				Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "CultureNameResourceSetPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr);
				ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastCultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr, "lastCultureName");
				ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastResourceSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr, "lastResourceSet");
				ResourceManager.CultureNameResourceSetPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr, 100667928);
			}

			// Token: 0x06005272 RID: 21106 RVA: 0x001747E8 File Offset: 0x001729E8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CultureNameResourceSetPair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.CultureNameResourceSetPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005273 RID: 21107 RVA: 0x0001F03F File Offset: 0x0001D23F
			public CultureNameResourceSetPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001524 RID: 5412
			// (get) Token: 0x06005274 RID: 21108 RVA: 0x00174824 File Offset: 0x00172A24
			// (set) Token: 0x06005275 RID: 21109 RVA: 0x0001F048 File Offset: 0x0001D248
			public unsafe string lastCultureName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastCultureName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastCultureName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001525 RID: 5413
			// (get) Token: 0x06005276 RID: 21110 RVA: 0x0017484C File Offset: 0x00172A4C
			// (set) Token: 0x06005277 RID: 21111 RVA: 0x0001F067 File Offset: 0x0001D267
			public unsafe ResourceSet lastResourceSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastResourceSet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastResourceSet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040042EC RID: 17132
			private static readonly IntPtr NativeFieldInfoPtr_lastCultureName;

			// Token: 0x040042ED RID: 17133
			private static readonly IntPtr NativeFieldInfoPtr_lastResourceSet;

			// Token: 0x040042EE RID: 17134
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020005C2 RID: 1474
		public class ResourceManagerMediator : Object
		{
			// Token: 0x06005278 RID: 21112 RVA: 0x0017487C File Offset: 0x00172A7C
			// Note: this type is marked as 'beforefieldinit'.
			static ResourceManagerMediator()
			{
				Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "ResourceManagerMediator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr);
				ResourceManager.ResourceManagerMediator.NativeFieldInfoPtr__rm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, "_rm");
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr__ctor_Internal_Void_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667929);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_ModuleDir_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667930);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_LocationInfo_Internal_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667931);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_UserResourceSet_Internal_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667932);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_BaseNameField_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667933);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_NeutralResourcesCulture_Internal_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667934);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_GetResourceFileName_Internal_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667935);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_LookedForSatelliteContractVersion_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667936);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_set_LookedForSatelliteContractVersion_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667937);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_SatelliteContractVersion_Internal_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667938);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_set_SatelliteContractVersion_Internal_set_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667939);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_ObtainSatelliteContractVersion_Internal_Version_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667940);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_FallbackLoc_Internal_get_UltimateResourceFallbackLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667941);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_CallingAssembly_Internal_get_RuntimeAssembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667942);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_MainAssembly_Internal_get_RuntimeAssembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667943);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_BaseName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667944);
			}

			// Token: 0x06005279 RID: 21113 RVA: 0x001749FC File Offset: 0x00172BFC
			[CallerCount(0)]
			public unsafe ResourceManagerMediator(ResourceManager rm)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr__ctor_Internal_Void_ResourceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001527 RID: 5415
			// (get) Token: 0x0600527A RID: 21114 RVA: 0x00174A48 File Offset: 0x00172C48
			public unsafe string ModuleDir
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_ModuleDir_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001528 RID: 5416
			// (get) Token: 0x0600527B RID: 21115 RVA: 0x00174A80 File Offset: 0x00172C80
			public unsafe Type LocationInfo
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 185215, RefRangeEnd = 185218, XrefRangeStart = 185215, XrefRangeEnd = 185215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_LocationInfo_Internal_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x17001529 RID: 5417
			// (get) Token: 0x0600527C RID: 21116 RVA: 0x00174AC0 File Offset: 0x00172CC0
			public unsafe Type UserResourceSet
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_UserResourceSet_Internal_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x1700152A RID: 5418
			// (get) Token: 0x0600527D RID: 21117 RVA: 0x00174B00 File Offset: 0x00172D00
			public unsafe string BaseNameField
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_BaseNameField_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700152B RID: 5419
			// (get) Token: 0x0600527E RID: 21118 RVA: 0x00174B38 File Offset: 0x00172D38
			public unsafe CultureInfo NeutralResourcesCulture
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 185218, RefRangeEnd = 185220, XrefRangeStart = 185218, XrefRangeEnd = 185218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_NeutralResourcesCulture_Internal_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
				}
			}

			// Token: 0x0600527F RID: 21119 RVA: 0x00174B78 File Offset: 0x00172D78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185220, XrefRangeEnd = 185221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetResourceFileName(CultureInfo culture)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_GetResourceFileName_Internal_String_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700152C RID: 5420
			// (get) Token: 0x06005280 RID: 21120 RVA: 0x00174BC0 File Offset: 0x00172DC0
			// (set) Token: 0x06005281 RID: 21121 RVA: 0x00174BFC File Offset: 0x00172DFC
			public unsafe bool LookedForSatelliteContractVersion
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_LookedForSatelliteContractVersion_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_set_LookedForSatelliteContractVersion_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700152D RID: 5421
			// (get) Token: 0x06005282 RID: 21122 RVA: 0x00174C3C File Offset: 0x00172E3C
			// (set) Token: 0x06005283 RID: 21123 RVA: 0x00174C7C File Offset: 0x00172E7C
			public unsafe Version SatelliteContractVersion
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 185221, RefRangeEnd = 185223, XrefRangeStart = 185221, XrefRangeEnd = 185221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_SatelliteContractVersion_Internal_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_set_SatelliteContractVersion_Internal_set_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06005284 RID: 21124 RVA: 0x00174CC0 File Offset: 0x00172EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185223, XrefRangeEnd = 185227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Version ObtainSatelliteContractVersion(Assembly a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_ObtainSatelliteContractVersion_Internal_Version_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
				}
			}

			// Token: 0x1700152E RID: 5422
			// (get) Token: 0x06005285 RID: 21125 RVA: 0x00174D10 File Offset: 0x00172F10
			public unsafe UltimateResourceFallbackLocation FallbackLoc
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_FallbackLoc_Internal_get_UltimateResourceFallbackLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700152F RID: 5423
			// (get) Token: 0x06005286 RID: 21126 RVA: 0x00174D4C File Offset: 0x00172F4C
			public unsafe RuntimeAssembly CallingAssembly
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_CallingAssembly_Internal_get_RuntimeAssembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
				}
			}

			// Token: 0x17001530 RID: 5424
			// (get) Token: 0x06005287 RID: 21127 RVA: 0x00174D8C File Offset: 0x00172F8C
			public unsafe RuntimeAssembly MainAssembly
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 185229, RefRangeEnd = 185244, XrefRangeStart = 185227, XrefRangeEnd = 185229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_MainAssembly_Internal_get_RuntimeAssembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
				}
			}

			// Token: 0x17001531 RID: 5425
			// (get) Token: 0x06005288 RID: 21128 RVA: 0x00174DCC File Offset: 0x00172FCC
			public unsafe string BaseName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185244, XrefRangeEnd = 185245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_BaseName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06005289 RID: 21129 RVA: 0x0001F086 File Offset: 0x0001D286
			public ResourceManagerMediator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001526 RID: 5414
			// (get) Token: 0x0600528A RID: 21130 RVA: 0x00174E04 File Offset: 0x00173004
			// (set) Token: 0x0600528B RID: 21131 RVA: 0x0001F08F File Offset: 0x0001D28F
			public unsafe ResourceManager _rm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.ResourceManagerMediator.NativeFieldInfoPtr__rm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.ResourceManagerMediator.NativeFieldInfoPtr__rm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040042EF RID: 17135
			private static readonly IntPtr NativeFieldInfoPtr__rm;

			// Token: 0x040042F0 RID: 17136
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ResourceManager_0;

			// Token: 0x040042F1 RID: 17137
			private static readonly IntPtr NativeMethodInfoPtr_get_ModuleDir_Internal_get_String_0;

			// Token: 0x040042F2 RID: 17138
			private static readonly IntPtr NativeMethodInfoPtr_get_LocationInfo_Internal_get_Type_0;

			// Token: 0x040042F3 RID: 17139
			private static readonly IntPtr NativeMethodInfoPtr_get_UserResourceSet_Internal_get_Type_0;

			// Token: 0x040042F4 RID: 17140
			private static readonly IntPtr NativeMethodInfoPtr_get_BaseNameField_Internal_get_String_0;

			// Token: 0x040042F5 RID: 17141
			private static readonly IntPtr NativeMethodInfoPtr_get_NeutralResourcesCulture_Internal_get_CultureInfo_0;

			// Token: 0x040042F6 RID: 17142
			private static readonly IntPtr NativeMethodInfoPtr_GetResourceFileName_Internal_String_CultureInfo_0;

			// Token: 0x040042F7 RID: 17143
			private static readonly IntPtr NativeMethodInfoPtr_get_LookedForSatelliteContractVersion_Internal_get_Boolean_0;

			// Token: 0x040042F8 RID: 17144
			private static readonly IntPtr NativeMethodInfoPtr_set_LookedForSatelliteContractVersion_Internal_set_Void_Boolean_0;

			// Token: 0x040042F9 RID: 17145
			private static readonly IntPtr NativeMethodInfoPtr_get_SatelliteContractVersion_Internal_get_Version_0;

			// Token: 0x040042FA RID: 17146
			private static readonly IntPtr NativeMethodInfoPtr_set_SatelliteContractVersion_Internal_set_Void_Version_0;

			// Token: 0x040042FB RID: 17147
			private static readonly IntPtr NativeMethodInfoPtr_ObtainSatelliteContractVersion_Internal_Version_Assembly_0;

			// Token: 0x040042FC RID: 17148
			private static readonly IntPtr NativeMethodInfoPtr_get_FallbackLoc_Internal_get_UltimateResourceFallbackLocation_0;

			// Token: 0x040042FD RID: 17149
			private static readonly IntPtr NativeMethodInfoPtr_get_CallingAssembly_Internal_get_RuntimeAssembly_0;

			// Token: 0x040042FE RID: 17150
			private static readonly IntPtr NativeMethodInfoPtr_get_MainAssembly_Internal_get_RuntimeAssembly_0;

			// Token: 0x040042FF RID: 17151
			private static readonly IntPtr NativeMethodInfoPtr_get_BaseName_Internal_get_String_0;
		}
	}
}
