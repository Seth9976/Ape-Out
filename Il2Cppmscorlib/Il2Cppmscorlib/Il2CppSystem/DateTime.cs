using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000094 RID: 148
	[Serializable]
	[StructLayout(2)]
	public struct DateTime
	{
		// Token: 0x0600098F RID: 2447 RVA: 0x0004F07C File Offset: 0x0004D27C
		// Note: this type is marked as 'beforefieldinit'.
		static DateTime()
		{
			Il2CppClassPointerStore<DateTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTime>.NativeClassPtr);
			DateTime.NativeFieldInfoPtr_TicksPerMillisecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksPerMillisecond");
			DateTime.NativeFieldInfoPtr_TicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksPerSecond");
			DateTime.NativeFieldInfoPtr_TicksPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksPerMinute");
			DateTime.NativeFieldInfoPtr_TicksPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksPerHour");
			DateTime.NativeFieldInfoPtr_TicksPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksPerDay");
			DateTime.NativeFieldInfoPtr_MillisPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MillisPerSecond");
			DateTime.NativeFieldInfoPtr_MillisPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MillisPerMinute");
			DateTime.NativeFieldInfoPtr_MillisPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MillisPerHour");
			DateTime.NativeFieldInfoPtr_MillisPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MillisPerDay");
			DateTime.NativeFieldInfoPtr_DaysPerYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysPerYear");
			DateTime.NativeFieldInfoPtr_DaysPer4Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysPer4Years");
			DateTime.NativeFieldInfoPtr_DaysPer100Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysPer100Years");
			DateTime.NativeFieldInfoPtr_DaysPer400Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysPer400Years");
			DateTime.NativeFieldInfoPtr_DaysTo1601 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysTo1601");
			DateTime.NativeFieldInfoPtr_DaysTo1899 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysTo1899");
			DateTime.NativeFieldInfoPtr_DaysTo1970 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysTo1970");
			DateTime.NativeFieldInfoPtr_DaysTo10000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysTo10000");
			DateTime.NativeFieldInfoPtr_MinTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MinTicks");
			DateTime.NativeFieldInfoPtr_MaxTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MaxTicks");
			DateTime.NativeFieldInfoPtr_MaxMillis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MaxMillis");
			DateTime.NativeFieldInfoPtr_FileTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "FileTimeOffset");
			DateTime.NativeFieldInfoPtr_DoubleDateOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DoubleDateOffset");
			DateTime.NativeFieldInfoPtr_OADateMinAsTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "OADateMinAsTicks");
			DateTime.NativeFieldInfoPtr_OADateMinAsDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "OADateMinAsDouble");
			DateTime.NativeFieldInfoPtr_OADateMaxAsDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "OADateMaxAsDouble");
			DateTime.NativeFieldInfoPtr_DatePartYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DatePartYear");
			DateTime.NativeFieldInfoPtr_DatePartDayOfYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DatePartDayOfYear");
			DateTime.NativeFieldInfoPtr_DatePartMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DatePartMonth");
			DateTime.NativeFieldInfoPtr_DatePartDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DatePartDay");
			DateTime.NativeFieldInfoPtr_DaysToMonth365 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysToMonth365");
			DateTime.NativeFieldInfoPtr_DaysToMonth366 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysToMonth366");
			DateTime.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MinValue");
			DateTime.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MaxValue");
			DateTime.NativeFieldInfoPtr_TicksMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksMask");
			DateTime.NativeFieldInfoPtr_FlagsMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "FlagsMask");
			DateTime.NativeFieldInfoPtr_LocalMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "LocalMask");
			DateTime.NativeFieldInfoPtr_TicksCeiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksCeiling");
			DateTime.NativeFieldInfoPtr_KindUnspecified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "KindUnspecified");
			DateTime.NativeFieldInfoPtr_KindUtc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "KindUtc");
			DateTime.NativeFieldInfoPtr_KindLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "KindLocal");
			DateTime.NativeFieldInfoPtr_KindLocalAmbiguousDst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "KindLocalAmbiguousDst");
			DateTime.NativeFieldInfoPtr_KindShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "KindShift");
			DateTime.NativeFieldInfoPtr_TicksField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksField");
			DateTime.NativeFieldInfoPtr_DateDataField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DateDataField");
			DateTime.NativeFieldInfoPtr_dateData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "dateData");
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664906);
			DateTime.NativeMethodInfoPtr__ctor_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664907);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int64_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664908);
			DateTime.NativeMethodInfoPtr__ctor_Internal_Void_Int64_DateTimeKind_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664909);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664910);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664911);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664912);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664913);
			DateTime.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664914);
			DateTime.NativeMethodInfoPtr_get_InternalTicks_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664915);
			DateTime.NativeMethodInfoPtr_get_InternalKind_Private_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664916);
			DateTime.NativeMethodInfoPtr_Add_Public_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664917);
			DateTime.NativeMethodInfoPtr_Add_Private_DateTime_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664918);
			DateTime.NativeMethodInfoPtr_AddDays_Public_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664919);
			DateTime.NativeMethodInfoPtr_AddMilliseconds_Public_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664920);
			DateTime.NativeMethodInfoPtr_AddMonths_Public_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664921);
			DateTime.NativeMethodInfoPtr_AddSeconds_Public_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664922);
			DateTime.NativeMethodInfoPtr_AddTicks_Public_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664923);
			DateTime.NativeMethodInfoPtr_AddYears_Public_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664924);
			DateTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664925);
			DateTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664926);
			DateTime.NativeMethodInfoPtr_DateToTicks_Private_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664927);
			DateTime.NativeMethodInfoPtr_TimeToTicks_Private_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664928);
			DateTime.NativeMethodInfoPtr_DaysInMonth_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664929);
			DateTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664930);
			DateTime.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664931);
			DateTime.NativeMethodInfoPtr_FromBinary_Public_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664932);
			DateTime.NativeMethodInfoPtr_FromBinaryRaw_Internal_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664933);
			DateTime.NativeMethodInfoPtr_FromFileTime_Public_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664934);
			DateTime.NativeMethodInfoPtr_FromFileTimeUtc_Public_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664935);
			DateTime.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664936);
			DateTime.NativeMethodInfoPtr_SpecifyKind_Public_Static_DateTime_DateTime_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664937);
			DateTime.NativeMethodInfoPtr_ToBinaryRaw_Internal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664938);
			DateTime.NativeMethodInfoPtr_get_Date_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664939);
			DateTime.NativeMethodInfoPtr_GetDatePart_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664940);
			DateTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664941);
			DateTime.NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664942);
			DateTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664943);
			DateTime.NativeMethodInfoPtr_get_Hour_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664944);
			DateTime.NativeMethodInfoPtr_IsAmbiguousDaylightSavingTime_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664945);
			DateTime.NativeMethodInfoPtr_get_Kind_Public_get_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664946);
			DateTime.NativeMethodInfoPtr_get_Minute_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664947);
			DateTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664948);
			DateTime.NativeMethodInfoPtr_get_Now_Public_Static_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664949);
			DateTime.NativeMethodInfoPtr_get_UtcNow_Public_Static_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664950);
			DateTime.NativeMethodInfoPtr_GetSystemTimeAsFileTime_Internal_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664951);
			DateTime.NativeMethodInfoPtr_get_Second_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664952);
			DateTime.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664953);
			DateTime.NativeMethodInfoPtr_get_TimeOfDay_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664954);
			DateTime.NativeMethodInfoPtr_get_Year_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664955);
			DateTime.NativeMethodInfoPtr_IsLeapYear_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664956);
			DateTime.NativeMethodInfoPtr_Parse_Public_Static_DateTime_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664957);
			DateTime.NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664958);
			DateTime.NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_String_IFormatProvider_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664959);
			DateTime.NativeMethodInfoPtr_Subtract_Public_TimeSpan_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664960);
			DateTime.NativeMethodInfoPtr_ToFileTimeUtc_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664961);
			DateTime.NativeMethodInfoPtr_ToLocalTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664962);
			DateTime.NativeMethodInfoPtr_ToLocalTime_Internal_DateTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664963);
			DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664964);
			DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664965);
			DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664966);
			DateTime.NativeMethodInfoPtr_ToUniversalTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664967);
			DateTime.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664968);
			DateTime.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_IFormatProvider_DateTimeStyles_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664969);
			DateTime.NativeMethodInfoPtr_op_Addition_Public_Static_DateTime_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664970);
			DateTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_DateTime_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664971);
			DateTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664972);
			DateTime.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664973);
			DateTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664974);
			DateTime.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664975);
			DateTime.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664976);
			DateTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664977);
			DateTime.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664978);
			DateTime.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664979);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664980);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664981);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664982);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664983);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664984);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664985);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664986);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664987);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664988);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664989);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664990);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664991);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664992);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664993);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664994);
			DateTime.NativeMethodInfoPtr_TryCreate_Internal_Static_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664995);
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0004FB38 File Offset: 0x0004DD38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151124, RefRangeEnd = 151126, XrefRangeStart = 151124, XrefRangeEnd = 151124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(long ticks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0004FB6C File Offset: 0x0004DD6C
		[CallerCount(0)]
		public unsafe DateTime(ulong dateData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Private_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0004FBA0 File Offset: 0x0004DDA0
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 151126, RefRangeEnd = 151150, XrefRangeStart = 151126, XrefRangeEnd = 151126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(long ticks, DateTimeKind kind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int64_DateTimeKind_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0004FBE0 File Offset: 0x0004DDE0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 151150, RefRangeEnd = 151162, XrefRangeStart = 151150, XrefRangeEnd = 151150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(long ticks, DateTimeKind kind, bool isAmbiguousDst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAmbiguousDst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Internal_Void_Int64_DateTimeKind_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0004FC30 File Offset: 0x0004DE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151162, XrefRangeEnd = 151166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(int year, int month, int day)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0004FC80 File Offset: 0x0004DE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151166, XrefRangeEnd = 151171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(int year, int month, int day, int hour, int minute, int second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0004FCF8 File Offset: 0x0004DEF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151176, RefRangeEnd = 151178, XrefRangeStart = 151171, XrefRangeEnd = 151176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_DateTimeKind_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0004FD80 File Offset: 0x0004DF80
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 151183, RefRangeEnd = 151194, XrefRangeStart = 151178, XrefRangeEnd = 151183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecond;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0004FE08 File Offset: 0x0004E008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151194, XrefRangeEnd = 151219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x0004FE58 File Offset: 0x0004E058
		public unsafe long InternalTicks
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_InternalTicks_Internal_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0004FE88 File Offset: 0x0004E088
		public unsafe ulong InternalKind
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_InternalKind_Private_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0004FEB8 File Offset: 0x0004E0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151219, XrefRangeEnd = 151220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime Add(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Add_Public_DateTime_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 151242, RefRangeEnd = 151254, XrefRangeStart = 151220, XrefRangeEnd = 151242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime Add(double value, int scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Add_Private_DateTime_Double_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0004FF44 File Offset: 0x0004E144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151254, XrefRangeEnd = 151255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddDays(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddDays_Public_DateTime_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0004FF84 File Offset: 0x0004E184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151255, XrefRangeEnd = 151256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddMilliseconds(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddMilliseconds_Public_DateTime_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0004FFC4 File Offset: 0x0004E1C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151267, RefRangeEnd = 151268, XrefRangeStart = 151256, XrefRangeEnd = 151267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddMonths(int months)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref months;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddMonths_Public_DateTime_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00050004 File Offset: 0x0004E204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151268, XrefRangeEnd = 151269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddSeconds(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddSeconds_Public_DateTime_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00050044 File Offset: 0x0004E244
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 151269, RefRangeEnd = 151276, XrefRangeStart = 151269, XrefRangeEnd = 151269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddTicks(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddTicks_Public_DateTime_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00050084 File Offset: 0x0004E284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151285, RefRangeEnd = 151286, XrefRangeStart = 151276, XrefRangeEnd = 151285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddYears(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddYears_Public_DateTime_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x000500C4 File Offset: 0x0004E2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151286, XrefRangeEnd = 151288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00050108 File Offset: 0x0004E308
		[CallerCount(0)]
		public unsafe int CompareTo(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00050148 File Offset: 0x0004E348
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 151298, RefRangeEnd = 151333, XrefRangeStart = 151288, XrefRangeEnd = 151298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long DateToTicks(int year, int month, int day)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_DateToTicks_Private_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x000501A4 File Offset: 0x0004E3A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 151344, RefRangeEnd = 151350, XrefRangeStart = 151333, XrefRangeEnd = 151344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long TimeToTicks(int hour, int minute, int second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hour;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_TimeToTicks_Private_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00050200 File Offset: 0x0004E400
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 151360, RefRangeEnd = 151364, XrefRangeStart = 151350, XrefRangeEnd = 151360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DaysInMonth(int year, int month)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_DaysInMonth_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0005024C File Offset: 0x0004E44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151364, XrefRangeEnd = 151366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00050290 File Offset: 0x0004E490
		[CallerCount(0)]
		public unsafe bool Equals(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x000502D0 File Offset: 0x0004E4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151366, XrefRangeEnd = 151370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime FromBinary(long dateData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_FromBinary_Public_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00050310 File Offset: 0x0004E510
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 151370, RefRangeEnd = 151373, XrefRangeStart = 151370, XrefRangeEnd = 151370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime FromBinaryRaw(long dateData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_FromBinaryRaw_Internal_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00050350 File Offset: 0x0004E550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151373, XrefRangeEnd = 151377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime FromFileTime(long fileTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_FromFileTime_Public_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00050390 File Offset: 0x0004E590
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151378, RefRangeEnd = 151380, XrefRangeStart = 151377, XrefRangeEnd = 151378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime FromFileTimeUtc(long fileTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_FromFileTimeUtc_Public_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x000503D0 File Offset: 0x0004E5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151380, XrefRangeEnd = 151392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00050420 File Offset: 0x0004E620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151392, XrefRangeEnd = 151393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime SpecifyKind(DateTime value, DateTimeKind kind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_SpecifyKind_Public_Static_DateTime_DateTime_DateTimeKind_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0005046C File Offset: 0x0004E66C
		[CallerCount(0)]
		public unsafe long ToBinaryRaw()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToBinaryRaw_Internal_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0005049C File Offset: 0x0004E69C
		public unsafe DateTime Date
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Date_Public_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x000504CC File Offset: 0x0004E6CC
		[CallerCount(68)]
		[CachedScanResults(RefRangeStart = 151402, RefRangeEnd = 151470, XrefRangeStart = 151393, XrefRangeEnd = 151402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDatePart(int part)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref part;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_GetDatePart_Private_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0005050C File Offset: 0x0004E70C
		public unsafe int Day
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151470, XrefRangeEnd = 151471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x0005053C File Offset: 0x0004E73C
		public unsafe DayOfWeek DayOfWeek
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0005056C File Offset: 0x0004E76C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x0005059C File Offset: 0x0004E79C
		public unsafe int Hour
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Hour_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x000505CC File Offset: 0x0004E7CC
		[CallerCount(0)]
		public unsafe bool IsAmbiguousDaylightSavingTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_IsAmbiguousDaylightSavingTime_Internal_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x000505FC File Offset: 0x0004E7FC
		public unsafe DateTimeKind Kind
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Kind_Public_get_DateTimeKind_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x0005062C File Offset: 0x0004E82C
		public unsafe int Minute
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Minute_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x0005065C File Offset: 0x0004E85C
		public unsafe int Month
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151471, XrefRangeEnd = 151472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x0005068C File Offset: 0x0004E88C
		public unsafe static DateTime Now
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 151478, RefRangeEnd = 151501, XrefRangeStart = 151472, XrefRangeEnd = 151478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Now_Public_Static_get_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x000506BC File Offset: 0x0004E8BC
		public unsafe static DateTime UtcNow
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 151504, RefRangeEnd = 151526, XrefRangeStart = 151501, XrefRangeEnd = 151504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_UtcNow_Public_Static_get_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000506EC File Offset: 0x0004E8EC
		[CallerCount(0)]
		public unsafe static long GetSystemTimeAsFileTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_GetSystemTimeAsFileTime_Internal_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x0005071C File Offset: 0x0004E91C
		public unsafe int Second
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Second_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x0005074C File Offset: 0x0004E94C
		public unsafe long Ticks
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0005077C File Offset: 0x0004E97C
		public unsafe TimeSpan TimeOfDay
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_TimeOfDay_Public_get_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x000507AC File Offset: 0x0004E9AC
		public unsafe int Year
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151526, XrefRangeEnd = 151527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Year_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000507DC File Offset: 0x0004E9DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 151527, RefRangeEnd = 151530, XrefRangeStart = 151527, XrefRangeEnd = 151527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLeapYear(int year)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_IsLeapYear_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0005081C File Offset: 0x0004EA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151530, XrefRangeEnd = 151542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime Parse(string s, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Parse_Public_Static_DateTime_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00050870 File Offset: 0x0004EA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151542, XrefRangeEnd = 151550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ParseExact(string s, string format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x000508D8 File Offset: 0x0004EAD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151561, RefRangeEnd = 151563, XrefRangeStart = 151550, XrefRangeEnd = 151561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_String_IFormatProvider_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0005094C File Offset: 0x0004EB4C
		[CallerCount(0)]
		public unsafe TimeSpan Subtract(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Subtract_Public_TimeSpan_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0005098C File Offset: 0x0004EB8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151565, RefRangeEnd = 151566, XrefRangeStart = 151563, XrefRangeEnd = 151565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long ToFileTimeUtc()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToFileTimeUtc_Public_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x000509BC File Offset: 0x0004EBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151566, XrefRangeEnd = 151567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ToLocalTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToLocalTime_Public_DateTime_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x000509EC File Offset: 0x0004EBEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151567, RefRangeEnd = 151569, XrefRangeStart = 151567, XrefRangeEnd = 151567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ToLocalTime(bool throwOnOverflow)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwOnOverflow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToLocalTime_Internal_DateTime_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00050A2C File Offset: 0x0004EC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151569, XrefRangeEnd = 151577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00050A58 File Offset: 0x0004EC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151577, XrefRangeEnd = 151585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00050A94 File Offset: 0x0004EC94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151593, RefRangeEnd = 151594, XrefRangeStart = 151585, XrefRangeEnd = 151593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00050AE4 File Offset: 0x0004ECE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151594, XrefRangeEnd = 151596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ToUniversalTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToUniversalTime_Public_DateTime_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00050B14 File Offset: 0x0004ED14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151596, XrefRangeEnd = 151604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, out DateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00050B64 File Offset: 0x0004ED64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151604, XrefRangeEnd = 151615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_IFormatProvider_DateTimeStyles_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00050BD4 File Offset: 0x0004EDD4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 151615, RefRangeEnd = 151629, XrefRangeStart = 151615, XrefRangeEnd = 151615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime operator +(DateTime d, TimeSpan t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_Addition_Public_Static_DateTime_DateTime_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00050C20 File Offset: 0x0004EE20
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 151629, RefRangeEnd = 151637, XrefRangeStart = 151629, XrefRangeEnd = 151629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime operator -(DateTime d, TimeSpan t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_DateTime_DateTime_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00050C6C File Offset: 0x0004EE6C
		[CallerCount(0)]
		public unsafe static TimeSpan operator -(DateTime d1, DateTime d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00050CB8 File Offset: 0x0004EEB8
		[CallerCount(0)]
		public unsafe static bool operator ==(DateTime d1, DateTime d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00050D04 File Offset: 0x0004EF04
		[CallerCount(0)]
		public unsafe static bool operator !=(DateTime d1, DateTime d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00050D50 File Offset: 0x0004EF50
		[CallerCount(0)]
		public unsafe static bool operator <(DateTime t1, DateTime t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00050D9C File Offset: 0x0004EF9C
		[CallerCount(0)]
		public unsafe static bool operator <=(DateTime t1, DateTime t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00050DE8 File Offset: 0x0004EFE8
		[CallerCount(0)]
		public unsafe static bool operator >(DateTime t1, DateTime t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00050E34 File Offset: 0x0004F034
		[CallerCount(0)]
		public unsafe static bool operator >=(DateTime t1, DateTime t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00050E80 File Offset: 0x0004F080
		[CallerCount(0)]
		public unsafe TypeCode GetTypeCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00050EB0 File Offset: 0x0004F0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151637, XrefRangeEnd = 151656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_IConvertible_ToBoolean(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00050EF4 File Offset: 0x0004F0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151656, XrefRangeEnd = 151675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char System_IConvertible_ToChar(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00050F38 File Offset: 0x0004F138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151675, XrefRangeEnd = 151694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte System_IConvertible_ToSByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00050F7C File Offset: 0x0004F17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151694, XrefRangeEnd = 151713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte System_IConvertible_ToByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00050FC0 File Offset: 0x0004F1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151713, XrefRangeEnd = 151732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short System_IConvertible_ToInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00051004 File Offset: 0x0004F204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151732, XrefRangeEnd = 151751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort System_IConvertible_ToUInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00051048 File Offset: 0x0004F248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151751, XrefRangeEnd = 151770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IConvertible_ToInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0005108C File Offset: 0x0004F28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151770, XrefRangeEnd = 151789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint System_IConvertible_ToUInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000510D0 File Offset: 0x0004F2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151789, XrefRangeEnd = 151808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long System_IConvertible_ToInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00051114 File Offset: 0x0004F314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151808, XrefRangeEnd = 151827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong System_IConvertible_ToUInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00051158 File Offset: 0x0004F358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151827, XrefRangeEnd = 151846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float System_IConvertible_ToSingle(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0005119C File Offset: 0x0004F39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151846, XrefRangeEnd = 151865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double System_IConvertible_ToDouble(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x000511E0 File Offset: 0x0004F3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151865, XrefRangeEnd = 151884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00051224 File Offset: 0x0004F424
		[CallerCount(0)]
		public unsafe DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00051268 File Offset: 0x0004F468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151884, XrefRangeEnd = 151891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object System_IConvertible_ToType(Type type, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x000512C0 File Offset: 0x0004F4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151891, XrefRangeEnd = 151909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecond;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_TryCreate_Internal_Static_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000049D9 File Offset: 0x00002BD9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DateTime>.NativeClassPtr, ref this));
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00051360 File Offset: 0x0004F560
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x000049EB File Offset: 0x00002BEB
		public unsafe static long TicksPerMillisecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksPerMillisecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksPerMillisecond, (void*)(&value));
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0005137C File Offset: 0x0004F57C
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x000049F9 File Offset: 0x00002BF9
		public unsafe static long TicksPerSecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksPerSecond, (void*)(&value));
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00051398 File Offset: 0x0004F598
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x00004A07 File Offset: 0x00002C07
		public unsafe static long TicksPerMinute
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksPerMinute, (void*)(&value));
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x000513B4 File Offset: 0x0004F5B4
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x00004A15 File Offset: 0x00002C15
		public unsafe static long TicksPerHour
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksPerHour, (void*)(&value));
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x000513D0 File Offset: 0x0004F5D0
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x00004A23 File Offset: 0x00002C23
		public unsafe static long TicksPerDay
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksPerDay, (void*)(&value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x000513EC File Offset: 0x0004F5EC
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x00004A31 File Offset: 0x00002C31
		public unsafe static int MillisPerSecond
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MillisPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MillisPerSecond, (void*)(&value));
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00051408 File Offset: 0x0004F608
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00004A3F File Offset: 0x00002C3F
		public unsafe static int MillisPerMinute
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MillisPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MillisPerMinute, (void*)(&value));
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00051424 File Offset: 0x0004F624
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00004A4D File Offset: 0x00002C4D
		public unsafe static int MillisPerHour
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MillisPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MillisPerHour, (void*)(&value));
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00051440 File Offset: 0x0004F640
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x00004A5B File Offset: 0x00002C5B
		public unsafe static int MillisPerDay
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MillisPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MillisPerDay, (void*)(&value));
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x0005145C File Offset: 0x0004F65C
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x00004A69 File Offset: 0x00002C69
		public unsafe static int DaysPerYear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysPerYear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysPerYear, (void*)(&value));
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00051478 File Offset: 0x0004F678
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x00004A77 File Offset: 0x00002C77
		public unsafe static int DaysPer4Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysPer4Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysPer4Years, (void*)(&value));
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00051494 File Offset: 0x0004F694
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x00004A85 File Offset: 0x00002C85
		public unsafe static int DaysPer100Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysPer100Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysPer100Years, (void*)(&value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x000514B0 File Offset: 0x0004F6B0
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x00004A93 File Offset: 0x00002C93
		public unsafe static int DaysPer400Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysPer400Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysPer400Years, (void*)(&value));
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x000514CC File Offset: 0x0004F6CC
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x00004AA1 File Offset: 0x00002CA1
		public unsafe static int DaysTo1601
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysTo1601, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysTo1601, (void*)(&value));
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x000514E8 File Offset: 0x0004F6E8
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x00004AAF File Offset: 0x00002CAF
		public unsafe static int DaysTo1899
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysTo1899, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysTo1899, (void*)(&value));
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x00051504 File Offset: 0x0004F704
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x00004ABD File Offset: 0x00002CBD
		public unsafe static int DaysTo1970
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysTo1970, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysTo1970, (void*)(&value));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x00051520 File Offset: 0x0004F720
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x00004ACB File Offset: 0x00002CCB
		public unsafe static int DaysTo10000
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysTo10000, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysTo10000, (void*)(&value));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0005153C File Offset: 0x0004F73C
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00004AD9 File Offset: 0x00002CD9
		public unsafe static long MinTicks
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MinTicks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MinTicks, (void*)(&value));
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00051558 File Offset: 0x0004F758
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00004AE7 File Offset: 0x00002CE7
		public unsafe static long MaxTicks
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MaxTicks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MaxTicks, (void*)(&value));
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00051574 File Offset: 0x0004F774
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x00004AF5 File Offset: 0x00002CF5
		public unsafe static long MaxMillis
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MaxMillis, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MaxMillis, (void*)(&value));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00051590 File Offset: 0x0004F790
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x00004B03 File Offset: 0x00002D03
		public unsafe static long FileTimeOffset
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_FileTimeOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_FileTimeOffset, (void*)(&value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x000515AC File Offset: 0x0004F7AC
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x00004B11 File Offset: 0x00002D11
		public unsafe static long DoubleDateOffset
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DoubleDateOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DoubleDateOffset, (void*)(&value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x000515C8 File Offset: 0x0004F7C8
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00004B1F File Offset: 0x00002D1F
		public unsafe static long OADateMinAsTicks
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_OADateMinAsTicks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_OADateMinAsTicks, (void*)(&value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x000515E4 File Offset: 0x0004F7E4
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00004B2D File Offset: 0x00002D2D
		public unsafe static double OADateMinAsDouble
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_OADateMinAsDouble, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_OADateMinAsDouble, (void*)(&value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00051600 File Offset: 0x0004F800
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00004B3B File Offset: 0x00002D3B
		public unsafe static double OADateMaxAsDouble
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_OADateMaxAsDouble, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_OADateMaxAsDouble, (void*)(&value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x0005161C File Offset: 0x0004F81C
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x00004B49 File Offset: 0x00002D49
		public unsafe static int DatePartYear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DatePartYear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DatePartYear, (void*)(&value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00051638 File Offset: 0x0004F838
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x00004B57 File Offset: 0x00002D57
		public unsafe static int DatePartDayOfYear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DatePartDayOfYear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DatePartDayOfYear, (void*)(&value));
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00051654 File Offset: 0x0004F854
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x00004B65 File Offset: 0x00002D65
		public unsafe static int DatePartMonth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DatePartMonth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DatePartMonth, (void*)(&value));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00051670 File Offset: 0x0004F870
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x00004B73 File Offset: 0x00002D73
		public unsafe static int DatePartDay
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DatePartDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DatePartDay, (void*)(&value));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0005168C File Offset: 0x0004F88C
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x00004B81 File Offset: 0x00002D81
		public unsafe static Il2CppStructArray<int> DaysToMonth365
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysToMonth365, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysToMonth365, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x000516B4 File Offset: 0x0004F8B4
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x00004B93 File Offset: 0x00002D93
		public unsafe static Il2CppStructArray<int> DaysToMonth366
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysToMonth366, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysToMonth366, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x000516DC File Offset: 0x0004F8DC
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x00004BA5 File Offset: 0x00002DA5
		public unsafe static DateTime MinValue
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MinValue, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x000516F8 File Offset: 0x0004F8F8
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x00004BB3 File Offset: 0x00002DB3
		public unsafe static DateTime MaxValue
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MaxValue, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00051714 File Offset: 0x0004F914
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x00004BC1 File Offset: 0x00002DC1
		public unsafe static ulong TicksMask
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksMask, (void*)(&value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00051730 File Offset: 0x0004F930
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x00004BCF File Offset: 0x00002DCF
		public unsafe static ulong FlagsMask
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_FlagsMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_FlagsMask, (void*)(&value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0005174C File Offset: 0x0004F94C
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x00004BDD File Offset: 0x00002DDD
		public unsafe static ulong LocalMask
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_LocalMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_LocalMask, (void*)(&value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00051768 File Offset: 0x0004F968
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x00004BEB File Offset: 0x00002DEB
		public unsafe static long TicksCeiling
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksCeiling, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksCeiling, (void*)(&value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00051784 File Offset: 0x0004F984
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public unsafe static ulong KindUnspecified
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_KindUnspecified, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_KindUnspecified, (void*)(&value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x000517A0 File Offset: 0x0004F9A0
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00004C07 File Offset: 0x00002E07
		public unsafe static ulong KindUtc
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_KindUtc, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_KindUtc, (void*)(&value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x000517BC File Offset: 0x0004F9BC
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00004C15 File Offset: 0x00002E15
		public unsafe static ulong KindLocal
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_KindLocal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_KindLocal, (void*)(&value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x000517D8 File Offset: 0x0004F9D8
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x00004C23 File Offset: 0x00002E23
		public unsafe static ulong KindLocalAmbiguousDst
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_KindLocalAmbiguousDst, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_KindLocalAmbiguousDst, (void*)(&value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x000517F4 File Offset: 0x0004F9F4
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x00004C31 File Offset: 0x00002E31
		public unsafe static int KindShift
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_KindShift, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_KindShift, (void*)(&value));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00051810 File Offset: 0x0004FA10
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x00004C3F File Offset: 0x00002E3F
		public unsafe static string TicksField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00051830 File Offset: 0x0004FA30
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00004C51 File Offset: 0x00002E51
		public unsafe static string DateDataField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DateDataField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DateDataField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerMillisecond;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerSecond;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerMinute;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerHour;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerDay;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerSecond;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerMinute;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerHour;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerDay;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeFieldInfoPtr_DaysPerYear;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer4Years;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer100Years;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer400Years;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeFieldInfoPtr_DaysTo1601;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeFieldInfoPtr_DaysTo1899;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeFieldInfoPtr_DaysTo1970;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeFieldInfoPtr_DaysTo10000;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeFieldInfoPtr_MinTicks;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeFieldInfoPtr_MaxTicks;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeFieldInfoPtr_MaxMillis;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeFieldInfoPtr_FileTimeOffset;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeFieldInfoPtr_DoubleDateOffset;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeFieldInfoPtr_OADateMinAsTicks;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeFieldInfoPtr_OADateMinAsDouble;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeFieldInfoPtr_OADateMaxAsDouble;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeFieldInfoPtr_DatePartYear;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeFieldInfoPtr_DatePartDayOfYear;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeFieldInfoPtr_DatePartMonth;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeFieldInfoPtr_DatePartDay;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeFieldInfoPtr_DaysToMonth365;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeFieldInfoPtr_DaysToMonth366;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeFieldInfoPtr_TicksMask;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeFieldInfoPtr_FlagsMask;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeFieldInfoPtr_LocalMask;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeFieldInfoPtr_TicksCeiling;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeFieldInfoPtr_KindUnspecified;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeFieldInfoPtr_KindUtc;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeFieldInfoPtr_KindLocal;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeFieldInfoPtr_KindLocalAmbiguousDst;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeFieldInfoPtr_KindShift;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeFieldInfoPtr_TicksField;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeFieldInfoPtr_DateDataField;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeFieldInfoPtr_dateData;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_UInt64_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_DateTimeKind_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int64_DateTimeKind_Boolean_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_DateTimeKind_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalTicks_Internal_get_Int64_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalKind_Private_get_UInt64_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_DateTime_TimeSpan_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_Add_Private_DateTime_Double_Int32_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_AddDays_Public_DateTime_Double_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_AddMilliseconds_Public_DateTime_Double_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_AddMonths_Public_DateTime_Int32_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_AddSeconds_Public_DateTime_Double_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_AddTicks_Public_DateTime_Int64_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_AddYears_Public_DateTime_Int32_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTime_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_DateToTicks_Private_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_TimeToTicks_Private_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_DaysInMonth_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTime_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_FromBinary_Public_Static_DateTime_Int64_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_FromBinaryRaw_Internal_Static_DateTime_Int64_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_FromFileTime_Public_Static_DateTime_Int64_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_FromFileTimeUtc_Public_Static_DateTime_Int64_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_SpecifyKind_Public_Static_DateTime_DateTime_DateTimeKind_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_ToBinaryRaw_Internal_Int64_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_get_Date_Public_get_DateTime_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_GetDatePart_Private_Int32_Int32_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_get_Day_Public_get_Int32_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_get_Hour_Public_get_Int32_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_IsAmbiguousDaylightSavingTime_Internal_Boolean_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_get_Kind_Public_get_DateTimeKind_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_get_Minute_Public_get_Int32_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_get_Month_Public_get_Int32_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_get_Now_Public_Static_get_DateTime_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_get_UtcNow_Public_Static_get_DateTime_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemTimeAsFileTime_Internal_Static_Int64_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_get_Second_Public_get_Int32_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeOfDay_Public_get_TimeSpan_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_get_Year_Public_get_Int32_0;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Static_Boolean_Int32_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_DateTime_String_IFormatProvider_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_String_IFormatProvider_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_String_IFormatProvider_DateTimeStyles_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_TimeSpan_DateTime_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_ToFileTimeUtc_Public_Int64_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_ToLocalTime_Public_DateTime_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_ToLocalTime_Internal_DateTime_Boolean_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_ToUniversalTime_Public_DateTime_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_DateTime_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_IFormatProvider_DateTimeStyles_byref_DateTime_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_DateTime_DateTime_TimeSpan_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_DateTime_DateTime_TimeSpan_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_DateTime_DateTime_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_TryCreate_Internal_Static_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0;

		// Token: 0x04000879 RID: 2169
		[FieldOffset(0)]
		public ulong dateData;
	}
}
