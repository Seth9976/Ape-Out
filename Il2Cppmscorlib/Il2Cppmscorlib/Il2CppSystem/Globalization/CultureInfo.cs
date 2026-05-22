using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000253 RID: 595
	[Serializable]
	public class CultureInfo : Object
	{
		// Token: 0x06002904 RID: 10500 RVA: 0x000D9050 File Offset: 0x000D7250
		// Note: this type is marked as 'beforefieldinit'.
		static CultureInfo()
		{
			Il2CppClassPointerStore<CultureInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CultureInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr);
			CultureInfo.NativeFieldInfoPtr_invariant_culture_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "invariant_culture_info");
			CultureInfo.NativeFieldInfoPtr_shared_table_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "shared_table_lock");
			CultureInfo.NativeFieldInfoPtr_default_current_culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "default_current_culture");
			CultureInfo.NativeFieldInfoPtr_m_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_isReadOnly");
			CultureInfo.NativeFieldInfoPtr_cultureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "cultureID");
			CultureInfo.NativeFieldInfoPtr_parent_lcid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "parent_lcid");
			CultureInfo.NativeFieldInfoPtr_datetime_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "datetime_index");
			CultureInfo.NativeFieldInfoPtr_number_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "number_index");
			CultureInfo.NativeFieldInfoPtr_default_calendar_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "default_calendar_type");
			CultureInfo.NativeFieldInfoPtr_m_useUserOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_useUserOverride");
			CultureInfo.NativeFieldInfoPtr_numInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "numInfo");
			CultureInfo.NativeFieldInfoPtr_dateTimeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "dateTimeInfo");
			CultureInfo.NativeFieldInfoPtr_textInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "textInfo");
			CultureInfo.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_name");
			CultureInfo.NativeFieldInfoPtr_englishname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "englishname");
			CultureInfo.NativeFieldInfoPtr_nativename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "nativename");
			CultureInfo.NativeFieldInfoPtr_iso3lang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "iso3lang");
			CultureInfo.NativeFieldInfoPtr_iso2lang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "iso2lang");
			CultureInfo.NativeFieldInfoPtr_win3lang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "win3lang");
			CultureInfo.NativeFieldInfoPtr_territory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "territory");
			CultureInfo.NativeFieldInfoPtr_native_calendar_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "native_calendar_names");
			CultureInfo.NativeFieldInfoPtr_compareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "compareInfo");
			CultureInfo.NativeFieldInfoPtr_textinfo_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "textinfo_data");
			CultureInfo.NativeFieldInfoPtr_m_dataItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_dataItem");
			CultureInfo.NativeFieldInfoPtr_calendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "calendar");
			CultureInfo.NativeFieldInfoPtr_parent_culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "parent_culture");
			CultureInfo.NativeFieldInfoPtr_constructed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "constructed");
			CultureInfo.NativeFieldInfoPtr_cached_serialized_form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "cached_serialized_form");
			CultureInfo.NativeFieldInfoPtr_m_cultureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_cultureData");
			CultureInfo.NativeFieldInfoPtr_m_isInherited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "m_isInherited");
			CultureInfo.NativeFieldInfoPtr_InvariantCultureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "InvariantCultureId");
			CultureInfo.NativeFieldInfoPtr_CalendarTypeBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "CalendarTypeBits");
			CultureInfo.NativeFieldInfoPtr_MSG_READONLY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "MSG_READONLY");
			CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentUICulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "s_DefaultThreadCurrentUICulture");
			CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "s_DefaultThreadCurrentCulture");
			CultureInfo.NativeFieldInfoPtr_shared_by_number = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "shared_by_number");
			CultureInfo.NativeFieldInfoPtr_shared_by_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "shared_by_name");
			CultureInfo.NativeFieldInfoPtr_IsTaiwanSku = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "IsTaiwanSku");
			CultureInfo.NativeMethodInfoPtr_get_InvariantCulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669973);
			CultureInfo.NativeMethodInfoPtr_get_CurrentCulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669974);
			CultureInfo.NativeMethodInfoPtr_get_CurrentUICulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669975);
			CultureInfo.NativeMethodInfoPtr_ConstructCurrentCulture_Internal_Static_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669976);
			CultureInfo.NativeMethodInfoPtr_ConstructCurrentUICulture_Internal_Static_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669977);
			CultureInfo.NativeMethodInfoPtr_get_Territory_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669978);
			CultureInfo.NativeMethodInfoPtr_get_LCID_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669979);
			CultureInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669980);
			CultureInfo.NativeMethodInfoPtr_get_Calendar_Public_Virtual_New_get_Calendar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669981);
			CultureInfo.NativeMethodInfoPtr_get_Parent_Public_Virtual_New_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669982);
			CultureInfo.NativeMethodInfoPtr_get_TextInfo_Public_Virtual_New_get_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669983);
			CultureInfo.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669984);
			CultureInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669985);
			CultureInfo.NativeMethodInfoPtr_GetCultures_Public_Static_Il2CppReferenceArray_1_CultureInfo_CultureTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669986);
			CultureInfo.NativeMethodInfoPtr_GetTextInfoData_Private_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669987);
			CultureInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669988);
			CultureInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669989);
			CultureInfo.NativeMethodInfoPtr_get_CompareInfo_Public_Virtual_New_get_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669990);
			CultureInfo.NativeMethodInfoPtr_get_IsNeutralCulture_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669991);
			CultureInfo.NativeMethodInfoPtr_CheckNeutral_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669992);
			CultureInfo.NativeMethodInfoPtr_get_NumberFormat_Public_Virtual_New_get_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669993);
			CultureInfo.NativeMethodInfoPtr_set_NumberFormat_Public_Virtual_New_set_Void_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669994);
			CultureInfo.NativeMethodInfoPtr_get_DateTimeFormat_Public_Virtual_New_get_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669995);
			CultureInfo.NativeMethodInfoPtr_set_DateTimeFormat_Public_Virtual_New_set_Void_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669996);
			CultureInfo.NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669997);
			CultureInfo.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669998);
			CultureInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100669999);
			CultureInfo.NativeMethodInfoPtr_Construct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670000);
			CultureInfo.NativeMethodInfoPtr_construct_internal_locale_from_lcid_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670001);
			CultureInfo.NativeMethodInfoPtr_construct_internal_locale_from_name_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670002);
			CultureInfo.NativeMethodInfoPtr_get_current_locale_name_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670003);
			CultureInfo.NativeMethodInfoPtr_internal_get_cultures_Private_Static_Il2CppReferenceArray_1_CultureInfo_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670004);
			CultureInfo.NativeMethodInfoPtr_ConstructInvariant_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670005);
			CultureInfo.NativeMethodInfoPtr_CreateTextInfo_Private_TextInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670006);
			CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670007);
			CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670008);
			CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670009);
			CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670010);
			CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670011);
			CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670012);
			CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670013);
			CultureInfo.NativeMethodInfoPtr_insert_into_shared_tables_Private_Static_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670014);
			CultureInfo.NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670015);
			CultureInfo.NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670016);
			CultureInfo.NativeMethodInfoPtr_CreateCulture_Internal_Static_CultureInfo_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670017);
			CultureInfo.NativeMethodInfoPtr_CreateSpecificCulture_Public_Static_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670018);
			CultureInfo.NativeMethodInfoPtr_CreateSpecificCultureFromNeutral_Private_Static_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670019);
			CultureInfo.NativeMethodInfoPtr_get_CalendarType_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670020);
			CultureInfo.NativeMethodInfoPtr_CreateCalendar_Private_Static_Calendar_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670021);
			CultureInfo.NativeMethodInfoPtr_CreateNotFoundException_Private_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670022);
			CultureInfo.NativeMethodInfoPtr_get_DefaultThreadCurrentCulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670023);
			CultureInfo.NativeMethodInfoPtr_get_DefaultThreadCurrentUICulture_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670024);
			CultureInfo.NativeMethodInfoPtr_get_SortName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670025);
			CultureInfo.NativeMethodInfoPtr_get_UserDefaultUICulture_Internal_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670026);
			CultureInfo.NativeMethodInfoPtr_get_UserDefaultCulture_Internal_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670027);
			CultureInfo.NativeMethodInfoPtr_CheckDomainSafetyObject_Internal_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670028);
			CultureInfo.NativeMethodInfoPtr_get_HasInvariantCultureName_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670029);
			CultureInfo.NativeMethodInfoPtr_VerifyCultureName_Internal_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, 100670030);
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x000D9800 File Offset: 0x000D7A00
		public unsafe static CultureInfo InvariantCulture
		{
			[CallerCount(195)]
			[CachedScanResults(RefRangeStart = 198665, RefRangeEnd = 198860, XrefRangeStart = 198661, XrefRangeEnd = 198665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_InvariantCulture_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06002906 RID: 10502 RVA: 0x000D9834 File Offset: 0x000D7A34
		public unsafe static CultureInfo CurrentCulture
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 198863, RefRangeEnd = 198869, XrefRangeStart = 198860, XrefRangeEnd = 198863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_CurrentCulture_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x000D9868 File Offset: 0x000D7A68
		public unsafe static CultureInfo CurrentUICulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198869, XrefRangeEnd = 198872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_CurrentUICulture_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x000D989C File Offset: 0x000D7A9C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 198891, RefRangeEnd = 198896, XrefRangeStart = 198872, XrefRangeEnd = 198891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo ConstructCurrentCulture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_ConstructCurrentCulture_Internal_Static_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x000D98D0 File Offset: 0x000D7AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198896, XrefRangeEnd = 198900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo ConstructCurrentUICulture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_ConstructCurrentUICulture_Internal_Static_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x0600290A RID: 10506 RVA: 0x000D9904 File Offset: 0x000D7B04
		public unsafe string Territory
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_Territory_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x000D993C File Offset: 0x000D7B3C
		public unsafe virtual int LCID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_LCID_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x0600290C RID: 10508 RVA: 0x000D9984 File Offset: 0x000D7B84
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x0600290D RID: 10509 RVA: 0x000D99C8 File Offset: 0x000D7BC8
		public unsafe virtual Calendar Calendar
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198900, XrefRangeEnd = 198905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_Calendar_Public_Virtual_New_get_Calendar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr3) : null;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x0600290E RID: 10510 RVA: 0x000D9A14 File Offset: 0x000D7C14
		public unsafe virtual CultureInfo Parent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198905, XrefRangeEnd = 198914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_Parent_Public_Virtual_New_get_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x0600290F RID: 10511 RVA: 0x000D9A60 File Offset: 0x000D7C60
		public unsafe virtual TextInfo TextInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198914, XrefRangeEnd = 198923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_TextInfo_Public_Virtual_New_get_TextInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x000D9AAC File Offset: 0x000D7CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198923, XrefRangeEnd = 198934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x000D9AF8 File Offset: 0x000D7CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198934, XrefRangeEnd = 198936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x000D9B50 File Offset: 0x000D7D50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198966, RefRangeEnd = 198967, XrefRangeStart = 198936, XrefRangeEnd = 198966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CultureInfo> GetCultures(CultureTypes types)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref types;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_GetCultures_Public_Static_Il2CppReferenceArray_1_CultureInfo_CultureTypes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CultureInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000D9B90 File Offset: 0x000D7D90
		[CallerCount(0)]
		public unsafe CultureInfo.Data GetTextInfoData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_GetTextInfoData_Private_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x000D9BCC File Offset: 0x000D7DCC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x000D9C14 File Offset: 0x000D7E14
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06002916 RID: 10518 RVA: 0x000D9C58 File Offset: 0x000D7E58
		public unsafe virtual CompareInfo CompareInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198967, XrefRangeEnd = 198974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_CompareInfo_Public_Virtual_New_get_CompareInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x000D9CA4 File Offset: 0x000D7EA4
		public unsafe virtual bool IsNeutralCulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198974, XrefRangeEnd = 198976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_IsNeutralCulture_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x000D9CEC File Offset: 0x000D7EEC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNeutral()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CheckNeutral_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06002919 RID: 10521 RVA: 0x000D9D20 File Offset: 0x000D7F20
		// (set) Token: 0x0600291A RID: 10522 RVA: 0x000D9D6C File Offset: 0x000D7F6C
		public unsafe virtual NumberFormatInfo NumberFormat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198976, XrefRangeEnd = 198980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_NumberFormat_Public_Virtual_New_get_NumberFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198980, XrefRangeEnd = 198995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_set_NumberFormat_Public_Virtual_New_set_Void_NumberFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x000D9DBC File Offset: 0x000D7FBC
		// (set) Token: 0x0600291C RID: 10524 RVA: 0x000D9E08 File Offset: 0x000D8008
		public unsafe virtual DateTimeFormatInfo DateTimeFormat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198995, XrefRangeEnd = 199000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_DateTimeFormat_Public_Virtual_New_get_DateTimeFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199000, XrefRangeEnd = 199015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_set_DateTimeFormat_Public_Virtual_New_set_Void_DateTimeFormatInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x0600291D RID: 10525 RVA: 0x000D9E58 File Offset: 0x000D8058
		public unsafe virtual string EnglishName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199015, XrefRangeEnd = 199017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x0600291E RID: 10526 RVA: 0x000D9E9C File Offset: 0x000D809C
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x000D9ED8 File Offset: 0x000D80D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199017, XrefRangeEnd = 199028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetFormat(Type formatType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x000D9F34 File Offset: 0x000D8134
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 199030, RefRangeEnd = 199035, XrefRangeStart = 199028, XrefRangeEnd = 199030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Construct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_Construct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x000D9F68 File Offset: 0x000D8168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199036, RefRangeEnd = 199037, XrefRangeStart = 199035, XrefRangeEnd = 199036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool construct_internal_locale_from_lcid(int lcid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lcid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_construct_internal_locale_from_lcid_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x000D9FB4 File Offset: 0x000D81B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199041, RefRangeEnd = 199044, XrefRangeStart = 199037, XrefRangeEnd = 199041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool construct_internal_locale_from_name(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_construct_internal_locale_from_name_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x000DA004 File Offset: 0x000D8204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199044, XrefRangeEnd = 199047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string get_current_locale_name()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_current_locale_name_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x000DA030 File Offset: 0x000D8230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199047, XrefRangeEnd = 199048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CultureInfo> internal_get_cultures(bool neutral, bool specific, bool installed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref neutral;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref specific;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref installed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_internal_get_cultures_Private_Static_Il2CppReferenceArray_1_CultureInfo_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CultureInfo>>(intPtr3) : null;
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x000DA08C File Offset: 0x000D828C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199062, RefRangeEnd = 199063, XrefRangeStart = 199048, XrefRangeEnd = 199062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConstructInvariant(bool read_only)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref read_only;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_ConstructInvariant_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x000DA0CC File Offset: 0x000D82CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199063, XrefRangeEnd = 199067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextInfo CreateTextInfo(bool readOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateTextInfo_Private_TextInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x000DA118 File Offset: 0x000D8318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199067, XrefRangeEnd = 199068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(int culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x000DA160 File Offset: 0x000D8360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199068, XrefRangeEnd = 199069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(int culture, bool useUserOverride)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x000DA1B8 File Offset: 0x000D83B8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 199105, RefRangeEnd = 199111, XrefRangeStart = 199069, XrefRangeEnd = 199105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(int culture, bool useUserOverride, bool read_only)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref read_only;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x000DA21C File Offset: 0x000D841C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199111, XrefRangeEnd = 199112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x000DA268 File Offset: 0x000D8468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199112, XrefRangeEnd = 199113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(string name, bool useUserOverride)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x000DA2C4 File Offset: 0x000D84C4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 199129, RefRangeEnd = 199139, XrefRangeStart = 199113, XrefRangeEnd = 199129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo(string name, bool useUserOverride, bool read_only)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUserOverride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref read_only;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x000DA32C File Offset: 0x000D852C
		[CallerCount(0)]
		public unsafe CultureInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x000DA368 File Offset: 0x000D8568
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199165, RefRangeEnd = 199167, XrefRangeStart = 199139, XrefRangeEnd = 199165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void insert_into_shared_tables(CultureInfo c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_insert_into_shared_tables_Private_Static_Void_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x000DA3A0 File Offset: 0x000D85A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199188, RefRangeEnd = 199191, XrefRangeStart = 199167, XrefRangeEnd = 199188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo GetCultureInfo(int culture)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x000DA3E0 File Offset: 0x000D85E0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 199212, RefRangeEnd = 199223, XrefRangeStart = 199191, XrefRangeEnd = 199212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo GetCultureInfo(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x000DA424 File Offset: 0x000D8624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199223, XrefRangeEnd = 199227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo CreateCulture(string name, bool reference)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateCulture_Internal_Static_CultureInfo_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x000DA478 File Offset: 0x000D8678
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199245, RefRangeEnd = 199247, XrefRangeStart = 199227, XrefRangeEnd = 199245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo CreateSpecificCulture(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateSpecificCulture_Public_Static_CultureInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x000DA4BC File Offset: 0x000D86BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199810, RefRangeEnd = 199811, XrefRangeStart = 199247, XrefRangeEnd = 199810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo CreateSpecificCultureFromNeutral(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateSpecificCultureFromNeutral_Private_Static_CultureInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06002934 RID: 10548 RVA: 0x000DA500 File Offset: 0x000D8700
		public unsafe int CalendarType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 199811, RefRangeEnd = 199815, XrefRangeStart = 199811, XrefRangeEnd = 199811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_CalendarType_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x000DA53C File Offset: 0x000D873C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199834, RefRangeEnd = 199835, XrefRangeStart = 199815, XrefRangeEnd = 199834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Calendar CreateCalendar(int calendarType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calendarType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateCalendar_Private_Static_Calendar_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr3) : null;
			}
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x000DA57C File Offset: 0x000D877C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199835, XrefRangeEnd = 199846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateNotFoundException(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CreateNotFoundException_Private_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06002937 RID: 10551 RVA: 0x000DA5C0 File Offset: 0x000D87C0
		public unsafe static CultureInfo DefaultThreadCurrentCulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199846, XrefRangeEnd = 199850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_DefaultThreadCurrentCulture_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06002938 RID: 10552 RVA: 0x000DA5F4 File Offset: 0x000D87F4
		public unsafe static CultureInfo DefaultThreadCurrentUICulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199850, XrefRangeEnd = 199854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_DefaultThreadCurrentUICulture_Public_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06002939 RID: 10553 RVA: 0x000DA628 File Offset: 0x000D8828
		public unsafe string SortName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_SortName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x0600293A RID: 10554 RVA: 0x000DA660 File Offset: 0x000D8860
		public unsafe static CultureInfo UserDefaultUICulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199854, XrefRangeEnd = 199862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_UserDefaultUICulture_Internal_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x0600293B RID: 10555 RVA: 0x000DA694 File Offset: 0x000D8894
		public unsafe static CultureInfo UserDefaultCulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199862, XrefRangeEnd = 199866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_UserDefaultCulture_Internal_Static_get_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x000DA6C8 File Offset: 0x000D88C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199873, RefRangeEnd = 199875, XrefRangeStart = 199866, XrefRangeEnd = 199873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckDomainSafetyObject(Object obj, Object container)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_CheckDomainSafetyObject_Internal_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x0600293D RID: 10557 RVA: 0x000DA710 File Offset: 0x000D8910
		public unsafe bool HasInvariantCultureName
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 199883, RefRangeEnd = 199888, XrefRangeStart = 199875, XrefRangeEnd = 199883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_get_HasInvariantCultureName_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x000DA74C File Offset: 0x000D894C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199893, RefRangeEnd = 199894, XrefRangeStart = 199888, XrefRangeEnd = 199893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool VerifyCultureName(string cultureName, bool throwException)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwException;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureInfo.NativeMethodInfoPtr_VerifyCultureName_Internal_Static_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x0000E052 File Offset: 0x0000C252
		public CultureInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x000DA79C File Offset: 0x000D899C
		// (set) Token: 0x06002941 RID: 10561 RVA: 0x0000E05B File Offset: 0x0000C25B
		public unsafe static CultureInfo invariant_culture_info
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_invariant_culture_info, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_invariant_culture_info, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06002942 RID: 10562 RVA: 0x000DA7C4 File Offset: 0x000D89C4
		// (set) Token: 0x06002943 RID: 10563 RVA: 0x0000E06D File Offset: 0x0000C26D
		public unsafe static Object shared_table_lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_shared_table_lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_shared_table_lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06002944 RID: 10564 RVA: 0x000DA7EC File Offset: 0x000D89EC
		// (set) Token: 0x06002945 RID: 10565 RVA: 0x0000E07F File Offset: 0x0000C27F
		public unsafe static CultureInfo default_current_culture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_default_current_culture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_default_current_culture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06002946 RID: 10566 RVA: 0x000DA814 File Offset: 0x000D8A14
		// (set) Token: 0x06002947 RID: 10567 RVA: 0x0000E091 File Offset: 0x0000C291
		public unsafe bool m_isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_isReadOnly)) = value;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06002948 RID: 10568 RVA: 0x000DA83C File Offset: 0x000D8A3C
		// (set) Token: 0x06002949 RID: 10569 RVA: 0x0000E0AC File Offset: 0x0000C2AC
		public unsafe int cultureID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_cultureID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_cultureID)) = value;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x0600294A RID: 10570 RVA: 0x000DA864 File Offset: 0x000D8A64
		// (set) Token: 0x0600294B RID: 10571 RVA: 0x0000E0C7 File Offset: 0x0000C2C7
		public unsafe int parent_lcid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_parent_lcid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_parent_lcid)) = value;
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x0600294C RID: 10572 RVA: 0x000DA88C File Offset: 0x000D8A8C
		// (set) Token: 0x0600294D RID: 10573 RVA: 0x0000E0E2 File Offset: 0x0000C2E2
		public unsafe int datetime_index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_datetime_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_datetime_index)) = value;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x000DA8B4 File Offset: 0x000D8AB4
		// (set) Token: 0x0600294F RID: 10575 RVA: 0x0000E0FD File Offset: 0x0000C2FD
		public unsafe int number_index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_number_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_number_index)) = value;
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x000DA8DC File Offset: 0x000D8ADC
		// (set) Token: 0x06002951 RID: 10577 RVA: 0x0000E118 File Offset: 0x0000C318
		public unsafe int default_calendar_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_default_calendar_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_default_calendar_type)) = value;
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06002952 RID: 10578 RVA: 0x000DA904 File Offset: 0x000D8B04
		// (set) Token: 0x06002953 RID: 10579 RVA: 0x0000E133 File Offset: 0x0000C333
		public unsafe bool m_useUserOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_useUserOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_useUserOverride)) = value;
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x000DA92C File Offset: 0x000D8B2C
		// (set) Token: 0x06002955 RID: 10581 RVA: 0x0000E14E File Offset: 0x0000C34E
		public unsafe NumberFormatInfo numInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_numInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_numInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x000DA95C File Offset: 0x000D8B5C
		// (set) Token: 0x06002957 RID: 10583 RVA: 0x0000E16D File Offset: 0x0000C36D
		public unsafe DateTimeFormatInfo dateTimeInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_dateTimeInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeFormatInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_dateTimeInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x000DA98C File Offset: 0x000D8B8C
		// (set) Token: 0x06002959 RID: 10585 RVA: 0x0000E18C File Offset: 0x0000C38C
		public unsafe TextInfo textInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_textInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_textInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x0600295A RID: 10586 RVA: 0x000DA9BC File Offset: 0x000D8BBC
		// (set) Token: 0x0600295B RID: 10587 RVA: 0x0000E1AB File Offset: 0x0000C3AB
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x0600295C RID: 10588 RVA: 0x000DA9E4 File Offset: 0x000D8BE4
		// (set) Token: 0x0600295D RID: 10589 RVA: 0x0000E1CA File Offset: 0x0000C3CA
		public unsafe string englishname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_englishname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_englishname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x000DAA0C File Offset: 0x000D8C0C
		// (set) Token: 0x0600295F RID: 10591 RVA: 0x0000E1E9 File Offset: 0x0000C3E9
		public unsafe string nativename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_nativename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_nativename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06002960 RID: 10592 RVA: 0x000DAA34 File Offset: 0x000D8C34
		// (set) Token: 0x06002961 RID: 10593 RVA: 0x0000E208 File Offset: 0x0000C408
		public unsafe string iso3lang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_iso3lang);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_iso3lang), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06002962 RID: 10594 RVA: 0x000DAA5C File Offset: 0x000D8C5C
		// (set) Token: 0x06002963 RID: 10595 RVA: 0x0000E227 File Offset: 0x0000C427
		public unsafe string iso2lang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_iso2lang);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_iso2lang), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06002964 RID: 10596 RVA: 0x000DAA84 File Offset: 0x000D8C84
		// (set) Token: 0x06002965 RID: 10597 RVA: 0x0000E246 File Offset: 0x0000C446
		public unsafe string win3lang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_win3lang);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_win3lang), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x000DAAAC File Offset: 0x000D8CAC
		// (set) Token: 0x06002967 RID: 10599 RVA: 0x0000E265 File Offset: 0x0000C465
		public unsafe string territory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_territory);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_territory), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x000DAAD4 File Offset: 0x000D8CD4
		// (set) Token: 0x06002969 RID: 10601 RVA: 0x0000E284 File Offset: 0x0000C484
		public unsafe Il2CppStringArray native_calendar_names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_native_calendar_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_native_calendar_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x000DAB04 File Offset: 0x000D8D04
		// (set) Token: 0x0600296B RID: 10603 RVA: 0x0000E2A3 File Offset: 0x0000C4A3
		public unsafe CompareInfo compareInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_compareInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_compareInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x0600296C RID: 10604 RVA: 0x000DAB34 File Offset: 0x000D8D34
		// (set) Token: 0x0600296D RID: 10605 RVA: 0x0000E2C2 File Offset: 0x0000C4C2
		public unsafe void* textinfo_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_textinfo_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_textinfo_data)) = value;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x0600296E RID: 10606 RVA: 0x000DAB58 File Offset: 0x000D8D58
		// (set) Token: 0x0600296F RID: 10607 RVA: 0x0000E2DD File Offset: 0x0000C4DD
		public unsafe int m_dataItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_dataItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_dataItem)) = value;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06002970 RID: 10608 RVA: 0x000DAB80 File Offset: 0x000D8D80
		// (set) Token: 0x06002971 RID: 10609 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		public unsafe Calendar calendar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_calendar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_calendar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x000DABB0 File Offset: 0x000D8DB0
		// (set) Token: 0x06002973 RID: 10611 RVA: 0x0000E317 File Offset: 0x0000C517
		public unsafe CultureInfo parent_culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_parent_culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_parent_culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06002974 RID: 10612 RVA: 0x000DABE0 File Offset: 0x000D8DE0
		// (set) Token: 0x06002975 RID: 10613 RVA: 0x0000E336 File Offset: 0x0000C536
		public unsafe bool constructed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_constructed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_constructed)) = value;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06002976 RID: 10614 RVA: 0x000DAC08 File Offset: 0x000D8E08
		// (set) Token: 0x06002977 RID: 10615 RVA: 0x0000E351 File Offset: 0x0000C551
		public unsafe Il2CppStructArray<byte> cached_serialized_form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_cached_serialized_form);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_cached_serialized_form), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06002978 RID: 10616 RVA: 0x000DAC38 File Offset: 0x000D8E38
		// (set) Token: 0x06002979 RID: 10617 RVA: 0x0000E370 File Offset: 0x0000C570
		public unsafe CultureData m_cultureData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_cultureData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_cultureData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x0600297A RID: 10618 RVA: 0x000DAC68 File Offset: 0x000D8E68
		// (set) Token: 0x0600297B RID: 10619 RVA: 0x0000E38F File Offset: 0x0000C58F
		public unsafe bool m_isInherited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_isInherited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureInfo.NativeFieldInfoPtr_m_isInherited)) = value;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x0600297C RID: 10620 RVA: 0x000DAC90 File Offset: 0x000D8E90
		// (set) Token: 0x0600297D RID: 10621 RVA: 0x0000E3AA File Offset: 0x0000C5AA
		public unsafe static int InvariantCultureId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_InvariantCultureId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_InvariantCultureId, (void*)(&value));
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x0600297E RID: 10622 RVA: 0x000DACAC File Offset: 0x000D8EAC
		// (set) Token: 0x0600297F RID: 10623 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
		public unsafe static int CalendarTypeBits
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_CalendarTypeBits, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_CalendarTypeBits, (void*)(&value));
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06002980 RID: 10624 RVA: 0x000DACC8 File Offset: 0x000D8EC8
		// (set) Token: 0x06002981 RID: 10625 RVA: 0x0000E3C6 File Offset: 0x0000C5C6
		public unsafe static string MSG_READONLY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_MSG_READONLY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_MSG_READONLY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06002982 RID: 10626 RVA: 0x000DACE8 File Offset: 0x000D8EE8
		// (set) Token: 0x06002983 RID: 10627 RVA: 0x0000E3D8 File Offset: 0x0000C5D8
		public unsafe static CultureInfo s_DefaultThreadCurrentUICulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentUICulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentUICulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06002984 RID: 10628 RVA: 0x000DAD10 File Offset: 0x000D8F10
		// (set) Token: 0x06002985 RID: 10629 RVA: 0x0000E3EA File Offset: 0x0000C5EA
		public unsafe static CultureInfo s_DefaultThreadCurrentCulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentCulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_s_DefaultThreadCurrentCulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06002986 RID: 10630 RVA: 0x000DAD38 File Offset: 0x000D8F38
		// (set) Token: 0x06002987 RID: 10631 RVA: 0x0000E3FC File Offset: 0x0000C5FC
		public unsafe static Dictionary<int, CultureInfo> shared_by_number
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_shared_by_number, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, CultureInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_shared_by_number, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06002988 RID: 10632 RVA: 0x000DAD60 File Offset: 0x000D8F60
		// (set) Token: 0x06002989 RID: 10633 RVA: 0x0000E40E File Offset: 0x0000C60E
		public unsafe static Dictionary<string, CultureInfo> shared_by_name
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_shared_by_name, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, CultureInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_shared_by_name, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x0600298A RID: 10634 RVA: 0x000DAD88 File Offset: 0x000D8F88
		// (set) Token: 0x0600298B RID: 10635 RVA: 0x0000E420 File Offset: 0x0000C620
		public unsafe static bool IsTaiwanSku
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CultureInfo.NativeFieldInfoPtr_IsTaiwanSku, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CultureInfo.NativeFieldInfoPtr_IsTaiwanSku, (void*)(&value));
			}
		}

		// Token: 0x0400245F RID: 9311
		private static readonly IntPtr NativeFieldInfoPtr_invariant_culture_info;

		// Token: 0x04002460 RID: 9312
		private static readonly IntPtr NativeFieldInfoPtr_shared_table_lock;

		// Token: 0x04002461 RID: 9313
		private static readonly IntPtr NativeFieldInfoPtr_default_current_culture;

		// Token: 0x04002462 RID: 9314
		private static readonly IntPtr NativeFieldInfoPtr_m_isReadOnly;

		// Token: 0x04002463 RID: 9315
		private static readonly IntPtr NativeFieldInfoPtr_cultureID;

		// Token: 0x04002464 RID: 9316
		private static readonly IntPtr NativeFieldInfoPtr_parent_lcid;

		// Token: 0x04002465 RID: 9317
		private static readonly IntPtr NativeFieldInfoPtr_datetime_index;

		// Token: 0x04002466 RID: 9318
		private static readonly IntPtr NativeFieldInfoPtr_number_index;

		// Token: 0x04002467 RID: 9319
		private static readonly IntPtr NativeFieldInfoPtr_default_calendar_type;

		// Token: 0x04002468 RID: 9320
		private static readonly IntPtr NativeFieldInfoPtr_m_useUserOverride;

		// Token: 0x04002469 RID: 9321
		private static readonly IntPtr NativeFieldInfoPtr_numInfo;

		// Token: 0x0400246A RID: 9322
		private static readonly IntPtr NativeFieldInfoPtr_dateTimeInfo;

		// Token: 0x0400246B RID: 9323
		private static readonly IntPtr NativeFieldInfoPtr_textInfo;

		// Token: 0x0400246C RID: 9324
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x0400246D RID: 9325
		private static readonly IntPtr NativeFieldInfoPtr_englishname;

		// Token: 0x0400246E RID: 9326
		private static readonly IntPtr NativeFieldInfoPtr_nativename;

		// Token: 0x0400246F RID: 9327
		private static readonly IntPtr NativeFieldInfoPtr_iso3lang;

		// Token: 0x04002470 RID: 9328
		private static readonly IntPtr NativeFieldInfoPtr_iso2lang;

		// Token: 0x04002471 RID: 9329
		private static readonly IntPtr NativeFieldInfoPtr_win3lang;

		// Token: 0x04002472 RID: 9330
		private static readonly IntPtr NativeFieldInfoPtr_territory;

		// Token: 0x04002473 RID: 9331
		private static readonly IntPtr NativeFieldInfoPtr_native_calendar_names;

		// Token: 0x04002474 RID: 9332
		private static readonly IntPtr NativeFieldInfoPtr_compareInfo;

		// Token: 0x04002475 RID: 9333
		private static readonly IntPtr NativeFieldInfoPtr_textinfo_data;

		// Token: 0x04002476 RID: 9334
		private static readonly IntPtr NativeFieldInfoPtr_m_dataItem;

		// Token: 0x04002477 RID: 9335
		private static readonly IntPtr NativeFieldInfoPtr_calendar;

		// Token: 0x04002478 RID: 9336
		private static readonly IntPtr NativeFieldInfoPtr_parent_culture;

		// Token: 0x04002479 RID: 9337
		private static readonly IntPtr NativeFieldInfoPtr_constructed;

		// Token: 0x0400247A RID: 9338
		private static readonly IntPtr NativeFieldInfoPtr_cached_serialized_form;

		// Token: 0x0400247B RID: 9339
		private static readonly IntPtr NativeFieldInfoPtr_m_cultureData;

		// Token: 0x0400247C RID: 9340
		private static readonly IntPtr NativeFieldInfoPtr_m_isInherited;

		// Token: 0x0400247D RID: 9341
		private static readonly IntPtr NativeFieldInfoPtr_InvariantCultureId;

		// Token: 0x0400247E RID: 9342
		private static readonly IntPtr NativeFieldInfoPtr_CalendarTypeBits;

		// Token: 0x0400247F RID: 9343
		private static readonly IntPtr NativeFieldInfoPtr_MSG_READONLY;

		// Token: 0x04002480 RID: 9344
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultThreadCurrentUICulture;

		// Token: 0x04002481 RID: 9345
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultThreadCurrentCulture;

		// Token: 0x04002482 RID: 9346
		private static readonly IntPtr NativeFieldInfoPtr_shared_by_number;

		// Token: 0x04002483 RID: 9347
		private static readonly IntPtr NativeFieldInfoPtr_shared_by_name;

		// Token: 0x04002484 RID: 9348
		private static readonly IntPtr NativeFieldInfoPtr_IsTaiwanSku;

		// Token: 0x04002485 RID: 9349
		private static readonly IntPtr NativeMethodInfoPtr_get_InvariantCulture_Public_Static_get_CultureInfo_0;

		// Token: 0x04002486 RID: 9350
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCulture_Public_Static_get_CultureInfo_0;

		// Token: 0x04002487 RID: 9351
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentUICulture_Public_Static_get_CultureInfo_0;

		// Token: 0x04002488 RID: 9352
		private static readonly IntPtr NativeMethodInfoPtr_ConstructCurrentCulture_Internal_Static_CultureInfo_0;

		// Token: 0x04002489 RID: 9353
		private static readonly IntPtr NativeMethodInfoPtr_ConstructCurrentUICulture_Internal_Static_CultureInfo_0;

		// Token: 0x0400248A RID: 9354
		private static readonly IntPtr NativeMethodInfoPtr_get_Territory_Internal_get_String_0;

		// Token: 0x0400248B RID: 9355
		private static readonly IntPtr NativeMethodInfoPtr_get_LCID_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400248C RID: 9356
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x0400248D RID: 9357
		private static readonly IntPtr NativeMethodInfoPtr_get_Calendar_Public_Virtual_New_get_Calendar_0;

		// Token: 0x0400248E RID: 9358
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_Virtual_New_get_CultureInfo_0;

		// Token: 0x0400248F RID: 9359
		private static readonly IntPtr NativeMethodInfoPtr_get_TextInfo_Public_Virtual_New_get_TextInfo_0;

		// Token: 0x04002490 RID: 9360
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x04002491 RID: 9361
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002492 RID: 9362
		private static readonly IntPtr NativeMethodInfoPtr_GetCultures_Public_Static_Il2CppReferenceArray_1_CultureInfo_CultureTypes_0;

		// Token: 0x04002493 RID: 9363
		private static readonly IntPtr NativeMethodInfoPtr_GetTextInfoData_Private_Data_0;

		// Token: 0x04002494 RID: 9364
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002495 RID: 9365
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002496 RID: 9366
		private static readonly IntPtr NativeMethodInfoPtr_get_CompareInfo_Public_Virtual_New_get_CompareInfo_0;

		// Token: 0x04002497 RID: 9367
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNeutralCulture_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04002498 RID: 9368
		private static readonly IntPtr NativeMethodInfoPtr_CheckNeutral_Private_Void_0;

		// Token: 0x04002499 RID: 9369
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberFormat_Public_Virtual_New_get_NumberFormatInfo_0;

		// Token: 0x0400249A RID: 9370
		private static readonly IntPtr NativeMethodInfoPtr_set_NumberFormat_Public_Virtual_New_set_Void_NumberFormatInfo_0;

		// Token: 0x0400249B RID: 9371
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeFormat_Public_Virtual_New_get_DateTimeFormatInfo_0;

		// Token: 0x0400249C RID: 9372
		private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeFormat_Public_Virtual_New_set_Void_DateTimeFormatInfo_0;

		// Token: 0x0400249D RID: 9373
		private static readonly IntPtr NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0;

		// Token: 0x0400249E RID: 9374
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;

		// Token: 0x0400249F RID: 9375
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Virtual_New_Object_Type_0;

		// Token: 0x040024A0 RID: 9376
		private static readonly IntPtr NativeMethodInfoPtr_Construct_Private_Void_0;

		// Token: 0x040024A1 RID: 9377
		private static readonly IntPtr NativeMethodInfoPtr_construct_internal_locale_from_lcid_Private_Boolean_Int32_0;

		// Token: 0x040024A2 RID: 9378
		private static readonly IntPtr NativeMethodInfoPtr_construct_internal_locale_from_name_Private_Boolean_String_0;

		// Token: 0x040024A3 RID: 9379
		private static readonly IntPtr NativeMethodInfoPtr_get_current_locale_name_Private_Static_String_0;

		// Token: 0x040024A4 RID: 9380
		private static readonly IntPtr NativeMethodInfoPtr_internal_get_cultures_Private_Static_Il2CppReferenceArray_1_CultureInfo_Boolean_Boolean_Boolean_0;

		// Token: 0x040024A5 RID: 9381
		private static readonly IntPtr NativeMethodInfoPtr_ConstructInvariant_Private_Void_Boolean_0;

		// Token: 0x040024A6 RID: 9382
		private static readonly IntPtr NativeMethodInfoPtr_CreateTextInfo_Private_TextInfo_Boolean_0;

		// Token: 0x040024A7 RID: 9383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040024A8 RID: 9384
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

		// Token: 0x040024A9 RID: 9385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Boolean_Boolean_0;

		// Token: 0x040024AA RID: 9386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040024AB RID: 9387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x040024AC RID: 9388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_Boolean_Boolean_0;

		// Token: 0x040024AD RID: 9389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040024AE RID: 9390
		private static readonly IntPtr NativeMethodInfoPtr_insert_into_shared_tables_Private_Static_Void_CultureInfo_0;

		// Token: 0x040024AF RID: 9391
		private static readonly IntPtr NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_Int32_0;

		// Token: 0x040024B0 RID: 9392
		private static readonly IntPtr NativeMethodInfoPtr_GetCultureInfo_Public_Static_CultureInfo_String_0;

		// Token: 0x040024B1 RID: 9393
		private static readonly IntPtr NativeMethodInfoPtr_CreateCulture_Internal_Static_CultureInfo_String_Boolean_0;

		// Token: 0x040024B2 RID: 9394
		private static readonly IntPtr NativeMethodInfoPtr_CreateSpecificCulture_Public_Static_CultureInfo_String_0;

		// Token: 0x040024B3 RID: 9395
		private static readonly IntPtr NativeMethodInfoPtr_CreateSpecificCultureFromNeutral_Private_Static_CultureInfo_String_0;

		// Token: 0x040024B4 RID: 9396
		private static readonly IntPtr NativeMethodInfoPtr_get_CalendarType_Internal_get_Int32_0;

		// Token: 0x040024B5 RID: 9397
		private static readonly IntPtr NativeMethodInfoPtr_CreateCalendar_Private_Static_Calendar_Int32_0;

		// Token: 0x040024B6 RID: 9398
		private static readonly IntPtr NativeMethodInfoPtr_CreateNotFoundException_Private_Static_Exception_String_0;

		// Token: 0x040024B7 RID: 9399
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultThreadCurrentCulture_Public_Static_get_CultureInfo_0;

		// Token: 0x040024B8 RID: 9400
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultThreadCurrentUICulture_Public_Static_get_CultureInfo_0;

		// Token: 0x040024B9 RID: 9401
		private static readonly IntPtr NativeMethodInfoPtr_get_SortName_Internal_get_String_0;

		// Token: 0x040024BA RID: 9402
		private static readonly IntPtr NativeMethodInfoPtr_get_UserDefaultUICulture_Internal_Static_get_CultureInfo_0;

		// Token: 0x040024BB RID: 9403
		private static readonly IntPtr NativeMethodInfoPtr_get_UserDefaultCulture_Internal_Static_get_CultureInfo_0;

		// Token: 0x040024BC RID: 9404
		private static readonly IntPtr NativeMethodInfoPtr_CheckDomainSafetyObject_Internal_Static_Void_Object_Object_0;

		// Token: 0x040024BD RID: 9405
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInvariantCultureName_Internal_get_Boolean_0;

		// Token: 0x040024BE RID: 9406
		private static readonly IntPtr NativeMethodInfoPtr_VerifyCultureName_Internal_Static_Boolean_String_Boolean_0;

		// Token: 0x020005E8 RID: 1512
		[StructLayout(2)]
		public struct Data
		{
			// Token: 0x060053ED RID: 21485 RVA: 0x00179D30 File Offset: 0x00177F30
			// Note: this type is marked as 'beforefieldinit'.
			static Data()
			{
				Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CultureInfo>.NativeClassPtr, "Data");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr);
				CultureInfo.Data.NativeFieldInfoPtr_ansi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "ansi");
				CultureInfo.Data.NativeFieldInfoPtr_ebcdic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "ebcdic");
				CultureInfo.Data.NativeFieldInfoPtr_mac = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "mac");
				CultureInfo.Data.NativeFieldInfoPtr_oem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "oem");
				CultureInfo.Data.NativeFieldInfoPtr_right_to_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "right_to_left");
				CultureInfo.Data.NativeFieldInfoPtr_list_sep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, "list_sep");
			}

			// Token: 0x060053EE RID: 21486 RVA: 0x0001F9D1 File Offset: 0x0001DBD1
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CultureInfo.Data>.NativeClassPtr, ref this));
			}

			// Token: 0x04004405 RID: 17413
			private static readonly IntPtr NativeFieldInfoPtr_ansi;

			// Token: 0x04004406 RID: 17414
			private static readonly IntPtr NativeFieldInfoPtr_ebcdic;

			// Token: 0x04004407 RID: 17415
			private static readonly IntPtr NativeFieldInfoPtr_mac;

			// Token: 0x04004408 RID: 17416
			private static readonly IntPtr NativeFieldInfoPtr_oem;

			// Token: 0x04004409 RID: 17417
			private static readonly IntPtr NativeFieldInfoPtr_right_to_left;

			// Token: 0x0400440A RID: 17418
			private static readonly IntPtr NativeFieldInfoPtr_list_sep;

			// Token: 0x0400440B RID: 17419
			[FieldOffset(0)]
			public int ansi;

			// Token: 0x0400440C RID: 17420
			[FieldOffset(4)]
			public int ebcdic;

			// Token: 0x0400440D RID: 17421
			[FieldOffset(8)]
			public int mac;

			// Token: 0x0400440E RID: 17422
			[FieldOffset(12)]
			public int oem;

			// Token: 0x0400440F RID: 17423
			[FieldOffset(16)]
			[MarshalAs(4)]
			public bool right_to_left;

			// Token: 0x04004410 RID: 17424
			[FieldOffset(17)]
			public byte list_sep;
		}
	}
}
