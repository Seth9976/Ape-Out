using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000257 RID: 599
	[Serializable]
	public class RegionInfo : Object
	{
		// Token: 0x060029BD RID: 10685 RVA: 0x000DB954 File Offset: 0x000D9B54
		// Note: this type is marked as 'beforefieldinit'.
		static RegionInfo()
		{
			Il2CppClassPointerStore<RegionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "RegionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr);
			RegionInfo.NativeFieldInfoPtr_currentRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "currentRegion");
			RegionInfo.NativeFieldInfoPtr_regionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "regionId");
			RegionInfo.NativeFieldInfoPtr_iso2Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "iso2Name");
			RegionInfo.NativeFieldInfoPtr_iso3Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "iso3Name");
			RegionInfo.NativeFieldInfoPtr_win3Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "win3Name");
			RegionInfo.NativeFieldInfoPtr_englishName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "englishName");
			RegionInfo.NativeFieldInfoPtr_nativeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "nativeName");
			RegionInfo.NativeFieldInfoPtr_currencySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "currencySymbol");
			RegionInfo.NativeFieldInfoPtr_isoCurrencySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "isoCurrencySymbol");
			RegionInfo.NativeFieldInfoPtr_currencyEnglishName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "currencyEnglishName");
			RegionInfo.NativeFieldInfoPtr_currencyNativeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "currencyNativeName");
			RegionInfo.NativeMethodInfoPtr_get_CurrentRegion_Public_Static_get_RegionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670053);
			RegionInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670054);
			RegionInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670055);
			RegionInfo.NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670056);
			RegionInfo.NativeMethodInfoPtr_GetByTerritory_Private_Boolean_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670057);
			RegionInfo.NativeMethodInfoPtr_construct_internal_region_from_name_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670058);
			RegionInfo.NativeMethodInfoPtr_get_CurrencyEnglishName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670059);
			RegionInfo.NativeMethodInfoPtr_get_CurrencySymbol_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670060);
			RegionInfo.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670061);
			RegionInfo.NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670062);
			RegionInfo.NativeMethodInfoPtr_get_GeoId_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670063);
			RegionInfo.NativeMethodInfoPtr_get_IsMetric_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670064);
			RegionInfo.NativeMethodInfoPtr_get_ISOCurrencySymbol_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670065);
			RegionInfo.NativeMethodInfoPtr_get_NativeName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670066);
			RegionInfo.NativeMethodInfoPtr_get_CurrencyNativeName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670067);
			RegionInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670068);
			RegionInfo.NativeMethodInfoPtr_get_ThreeLetterISORegionName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670069);
			RegionInfo.NativeMethodInfoPtr_get_ThreeLetterWindowsRegionName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670070);
			RegionInfo.NativeMethodInfoPtr_get_TwoLetterISORegionName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670071);
			RegionInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670072);
			RegionInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670073);
			RegionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670074);
			RegionInfo.NativeMethodInfoPtr_ClearCachedData_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100670075);
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x060029BE RID: 10686 RVA: 0x000DBC2C File Offset: 0x000D9E2C
		public unsafe static RegionInfo CurrentRegion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200079, XrefRangeEnd = 200091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr_get_CurrentRegion_Public_Static_get_RegionInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegionInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x000DBC60 File Offset: 0x000D9E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200091, XrefRangeEnd = 200097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegionInfo(int culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x000DBCA8 File Offset: 0x000D9EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200097, XrefRangeEnd = 200105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegionInfo(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x000DBCF4 File Offset: 0x000D9EF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200114, RefRangeEnd = 200115, XrefRangeStart = 200105, XrefRangeEnd = 200114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegionInfo(CultureInfo ci)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ci);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x000DBD40 File Offset: 0x000D9F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200115, XrefRangeEnd = 200117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetByTerritory(CultureInfo ci)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ci);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr_GetByTerritory_Private_Boolean_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x000DBD90 File Offset: 0x000D9F90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 200121, RefRangeEnd = 200126, XrefRangeStart = 200117, XrefRangeEnd = 200121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool construct_internal_region_from_name(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr_construct_internal_region_from_name_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x000DBDE0 File Offset: 0x000D9FE0
		public unsafe virtual string CurrencyEnglishName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_CurrencyEnglishName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x060029C5 RID: 10693 RVA: 0x000DBE24 File Offset: 0x000DA024
		public unsafe virtual string CurrencySymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_CurrencySymbol_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x060029C6 RID: 10694 RVA: 0x000DBE68 File Offset: 0x000DA068
		public unsafe virtual string DisplayName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x060029C7 RID: 10695 RVA: 0x000DBEAC File Offset: 0x000DA0AC
		public unsafe virtual string EnglishName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x060029C8 RID: 10696 RVA: 0x000DBEF0 File Offset: 0x000DA0F0
		public unsafe virtual int GeoId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_GeoId_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x060029C9 RID: 10697 RVA: 0x000DBF38 File Offset: 0x000DA138
		public unsafe virtual bool IsMetric
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200126, XrefRangeEnd = 200130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_IsMetric_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x060029CA RID: 10698 RVA: 0x000DBF80 File Offset: 0x000DA180
		public unsafe virtual string ISOCurrencySymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_ISOCurrencySymbol_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x060029CB RID: 10699 RVA: 0x000DBFC4 File Offset: 0x000DA1C4
		public unsafe virtual string NativeName
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_NativeName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x060029CC RID: 10700 RVA: 0x000DC008 File Offset: 0x000DA208
		public unsafe virtual string CurrencyNativeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_CurrencyNativeName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x060029CD RID: 10701 RVA: 0x000DC04C File Offset: 0x000DA24C
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x060029CE RID: 10702 RVA: 0x000DC090 File Offset: 0x000DA290
		public unsafe virtual string ThreeLetterISORegionName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_ThreeLetterISORegionName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x060029CF RID: 10703 RVA: 0x000DC0D4 File Offset: 0x000DA2D4
		public unsafe virtual string ThreeLetterWindowsRegionName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_ThreeLetterWindowsRegionName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x060029D0 RID: 10704 RVA: 0x000DC118 File Offset: 0x000DA318
		public unsafe virtual string TwoLetterISORegionName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_TwoLetterISORegionName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x000DC15C File Offset: 0x000DA35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200130, XrefRangeEnd = 200132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x000DC1B4 File Offset: 0x000DA3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200132, XrefRangeEnd = 200133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x000DC1FC File Offset: 0x000DA3FC
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x000DC240 File Offset: 0x000DA440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200133, XrefRangeEnd = 200135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearCachedData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr_ClearCachedData_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x0000E5AF File Offset: 0x0000C7AF
		public RegionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x060029D6 RID: 10710 RVA: 0x000DC268 File Offset: 0x000DA468
		// (set) Token: 0x060029D7 RID: 10711 RVA: 0x0000E5B8 File Offset: 0x0000C7B8
		public unsafe static RegionInfo currentRegion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegionInfo.NativeFieldInfoPtr_currentRegion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegionInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegionInfo.NativeFieldInfoPtr_currentRegion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x060029D8 RID: 10712 RVA: 0x000DC290 File Offset: 0x000DA490
		// (set) Token: 0x060029D9 RID: 10713 RVA: 0x0000E5CA File Offset: 0x0000C7CA
		public unsafe int regionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_regionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_regionId)) = value;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x060029DA RID: 10714 RVA: 0x000DC2B8 File Offset: 0x000DA4B8
		// (set) Token: 0x060029DB RID: 10715 RVA: 0x0000E5E5 File Offset: 0x0000C7E5
		public unsafe string iso2Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_iso2Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_iso2Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x060029DC RID: 10716 RVA: 0x000DC2E0 File Offset: 0x000DA4E0
		// (set) Token: 0x060029DD RID: 10717 RVA: 0x0000E604 File Offset: 0x0000C804
		public unsafe string iso3Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_iso3Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_iso3Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x060029DE RID: 10718 RVA: 0x000DC308 File Offset: 0x000DA508
		// (set) Token: 0x060029DF RID: 10719 RVA: 0x0000E623 File Offset: 0x0000C823
		public unsafe string win3Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_win3Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_win3Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x060029E0 RID: 10720 RVA: 0x000DC330 File Offset: 0x000DA530
		// (set) Token: 0x060029E1 RID: 10721 RVA: 0x0000E642 File Offset: 0x0000C842
		public unsafe string englishName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_englishName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_englishName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x060029E2 RID: 10722 RVA: 0x000DC358 File Offset: 0x000DA558
		// (set) Token: 0x060029E3 RID: 10723 RVA: 0x0000E661 File Offset: 0x0000C861
		public unsafe string nativeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_nativeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_nativeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x060029E4 RID: 10724 RVA: 0x000DC380 File Offset: 0x000DA580
		// (set) Token: 0x060029E5 RID: 10725 RVA: 0x0000E680 File Offset: 0x0000C880
		public unsafe string currencySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x060029E6 RID: 10726 RVA: 0x000DC3A8 File Offset: 0x000DA5A8
		// (set) Token: 0x060029E7 RID: 10727 RVA: 0x0000E69F File Offset: 0x0000C89F
		public unsafe string isoCurrencySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_isoCurrencySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_isoCurrencySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x060029E8 RID: 10728 RVA: 0x000DC3D0 File Offset: 0x000DA5D0
		// (set) Token: 0x060029E9 RID: 10729 RVA: 0x0000E6BE File Offset: 0x0000C8BE
		public unsafe string currencyEnglishName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencyEnglishName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencyEnglishName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x060029EA RID: 10730 RVA: 0x000DC3F8 File Offset: 0x000DA5F8
		// (set) Token: 0x060029EB RID: 10731 RVA: 0x0000E6DD File Offset: 0x0000C8DD
		public unsafe string currencyNativeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencyNativeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencyNativeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040024DF RID: 9439
		private static readonly IntPtr NativeFieldInfoPtr_currentRegion;

		// Token: 0x040024E0 RID: 9440
		private static readonly IntPtr NativeFieldInfoPtr_regionId;

		// Token: 0x040024E1 RID: 9441
		private static readonly IntPtr NativeFieldInfoPtr_iso2Name;

		// Token: 0x040024E2 RID: 9442
		private static readonly IntPtr NativeFieldInfoPtr_iso3Name;

		// Token: 0x040024E3 RID: 9443
		private static readonly IntPtr NativeFieldInfoPtr_win3Name;

		// Token: 0x040024E4 RID: 9444
		private static readonly IntPtr NativeFieldInfoPtr_englishName;

		// Token: 0x040024E5 RID: 9445
		private static readonly IntPtr NativeFieldInfoPtr_nativeName;

		// Token: 0x040024E6 RID: 9446
		private static readonly IntPtr NativeFieldInfoPtr_currencySymbol;

		// Token: 0x040024E7 RID: 9447
		private static readonly IntPtr NativeFieldInfoPtr_isoCurrencySymbol;

		// Token: 0x040024E8 RID: 9448
		private static readonly IntPtr NativeFieldInfoPtr_currencyEnglishName;

		// Token: 0x040024E9 RID: 9449
		private static readonly IntPtr NativeFieldInfoPtr_currencyNativeName;

		// Token: 0x040024EA RID: 9450
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentRegion_Public_Static_get_RegionInfo_0;

		// Token: 0x040024EB RID: 9451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040024EC RID: 9452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040024ED RID: 9453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0;

		// Token: 0x040024EE RID: 9454
		private static readonly IntPtr NativeMethodInfoPtr_GetByTerritory_Private_Boolean_CultureInfo_0;

		// Token: 0x040024EF RID: 9455
		private static readonly IntPtr NativeMethodInfoPtr_construct_internal_region_from_name_Private_Boolean_String_0;

		// Token: 0x040024F0 RID: 9456
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyEnglishName_Public_Virtual_New_get_String_0;

		// Token: 0x040024F1 RID: 9457
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencySymbol_Public_Virtual_New_get_String_0;

		// Token: 0x040024F2 RID: 9458
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Virtual_New_get_String_0;

		// Token: 0x040024F3 RID: 9459
		private static readonly IntPtr NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0;

		// Token: 0x040024F4 RID: 9460
		private static readonly IntPtr NativeMethodInfoPtr_get_GeoId_Public_Virtual_New_get_Int32_0;

		// Token: 0x040024F5 RID: 9461
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMetric_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040024F6 RID: 9462
		private static readonly IntPtr NativeMethodInfoPtr_get_ISOCurrencySymbol_Public_Virtual_New_get_String_0;

		// Token: 0x040024F7 RID: 9463
		private static readonly IntPtr NativeMethodInfoPtr_get_NativeName_Public_Virtual_New_get_String_0;

		// Token: 0x040024F8 RID: 9464
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyNativeName_Public_Virtual_New_get_String_0;

		// Token: 0x040024F9 RID: 9465
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x040024FA RID: 9466
		private static readonly IntPtr NativeMethodInfoPtr_get_ThreeLetterISORegionName_Public_Virtual_New_get_String_0;

		// Token: 0x040024FB RID: 9467
		private static readonly IntPtr NativeMethodInfoPtr_get_ThreeLetterWindowsRegionName_Public_Virtual_New_get_String_0;

		// Token: 0x040024FC RID: 9468
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoLetterISORegionName_Public_Virtual_New_get_String_0;

		// Token: 0x040024FD RID: 9469
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040024FE RID: 9470
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040024FF RID: 9471
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002500 RID: 9472
		private static readonly IntPtr NativeMethodInfoPtr_ClearCachedData_Internal_Static_Void_0;
	}
}
