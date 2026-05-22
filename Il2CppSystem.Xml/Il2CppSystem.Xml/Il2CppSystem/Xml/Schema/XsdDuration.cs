using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001EC RID: 492
	[StructLayout(2)]
	public struct XsdDuration
	{
		// Token: 0x06002954 RID: 10580 RVA: 0x000BD2F4 File Offset: 0x000BB4F4
		// Note: this type is marked as 'beforefieldinit'.
		static XsdDuration()
		{
			Il2CppClassPointerStore<XsdDuration>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdDuration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr);
			XsdDuration.NativeFieldInfoPtr_years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "years");
			XsdDuration.NativeFieldInfoPtr_months = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "months");
			XsdDuration.NativeFieldInfoPtr_days = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "days");
			XsdDuration.NativeFieldInfoPtr_hours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "hours");
			XsdDuration.NativeFieldInfoPtr_minutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "minutes");
			XsdDuration.NativeFieldInfoPtr_seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "seconds");
			XsdDuration.NativeFieldInfoPtr_nanoseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "nanoseconds");
			XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669199);
			XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_DurationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669200);
			XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_String_DurationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669201);
			XsdDuration.NativeMethodInfoPtr_get_IsNegative_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669202);
			XsdDuration.NativeMethodInfoPtr_get_Years_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669203);
			XsdDuration.NativeMethodInfoPtr_get_Months_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669204);
			XsdDuration.NativeMethodInfoPtr_get_Days_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669205);
			XsdDuration.NativeMethodInfoPtr_get_Hours_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669206);
			XsdDuration.NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669207);
			XsdDuration.NativeMethodInfoPtr_get_Seconds_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669208);
			XsdDuration.NativeMethodInfoPtr_get_Nanoseconds_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669209);
			XsdDuration.NativeMethodInfoPtr_ToTimeSpan_Public_TimeSpan_DurationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669210);
			XsdDuration.NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669211);
			XsdDuration.NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_DurationType_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669212);
			XsdDuration.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669213);
			XsdDuration.NativeMethodInfoPtr_ToString_Internal_String_DurationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669214);
			XsdDuration.NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_byref_XsdDuration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669215);
			XsdDuration.NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_DurationType_byref_XsdDuration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669216);
			XsdDuration.NativeMethodInfoPtr_TryParseDigits_Private_Static_String_String_byref_Int32_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100669217);
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x000BD52C File Offset: 0x000BB72C
		[CallerCount(0)]
		public unsafe XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isNegative;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref years;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref months;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref days;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hours;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutes;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nanoseconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x000BD5C0 File Offset: 0x000BB7C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 438515, RefRangeEnd = 438520, XrefRangeStart = 438515, XrefRangeEnd = 438515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDuration(TimeSpan timeSpan, XsdDuration.DurationType durationType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeSpan;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_DurationType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x000BD600 File Offset: 0x000BB800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438520, XrefRangeEnd = 438521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDuration(string s, XsdDuration.DurationType durationType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_String_DurationType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x000BD644 File Offset: 0x000BB844
		public unsafe bool IsNegative
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_IsNegative_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06002959 RID: 10585 RVA: 0x000BD674 File Offset: 0x000BB874
		public unsafe int Years
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Years_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x0600295A RID: 10586 RVA: 0x000BD6A4 File Offset: 0x000BB8A4
		public unsafe int Months
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Months_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x0600295B RID: 10587 RVA: 0x000BD6D4 File Offset: 0x000BB8D4
		public unsafe int Days
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Days_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x0600295C RID: 10588 RVA: 0x000BD704 File Offset: 0x000BB904
		public unsafe int Hours
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Hours_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x000BD734 File Offset: 0x000BB934
		public unsafe int Minutes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x000BD764 File Offset: 0x000BB964
		public unsafe int Seconds
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Seconds_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x0600295F RID: 10591 RVA: 0x000BD794 File Offset: 0x000BB994
		public unsafe int Nanoseconds
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Nanoseconds_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x000BD7C4 File Offset: 0x000BB9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438521, XrefRangeEnd = 438522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan ToTimeSpan(XsdDuration.DurationType durationType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref durationType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_ToTimeSpan_Public_TimeSpan_DurationType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x000BD804 File Offset: 0x000BBA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438522, XrefRangeEnd = 438523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception TryToTimeSpan(out TimeSpan result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_byref_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x000BD844 File Offset: 0x000BBA44
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 438528, RefRangeEnd = 438537, XrefRangeStart = 438523, XrefRangeEnd = 438528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref durationType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_DurationType_byref_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x000BD894 File Offset: 0x000BBA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438537, XrefRangeEnd = 438538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x000BD8C0 File Offset: 0x000BBAC0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 438604, RefRangeEnd = 438610, XrefRangeStart = 438538, XrefRangeEnd = 438604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(XsdDuration.DurationType durationType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref durationType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_ToString_Internal_String_DurationType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x000BD8F8 File Offset: 0x000BBAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438610, XrefRangeEnd = 438611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryParse(string s, out XsdDuration result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_byref_XsdDuration_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x000BD94C File Offset: 0x000BBB4C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 438658, RefRangeEnd = 438667, XrefRangeStart = 438611, XrefRangeEnd = 438658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_DurationType_byref_XsdDuration_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x000BD9AC File Offset: 0x000BBBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438667, XrefRangeEnd = 438668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eatDigits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &numDigits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_TryParseDigits_Private_Static_String_String_byref_Int32_Boolean_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x00011710 File Offset: 0x0000F910
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, ref this));
		}

		// Token: 0x04001F1B RID: 7963
		private static readonly IntPtr NativeFieldInfoPtr_years;

		// Token: 0x04001F1C RID: 7964
		private static readonly IntPtr NativeFieldInfoPtr_months;

		// Token: 0x04001F1D RID: 7965
		private static readonly IntPtr NativeFieldInfoPtr_days;

		// Token: 0x04001F1E RID: 7966
		private static readonly IntPtr NativeFieldInfoPtr_hours;

		// Token: 0x04001F1F RID: 7967
		private static readonly IntPtr NativeFieldInfoPtr_minutes;

		// Token: 0x04001F20 RID: 7968
		private static readonly IntPtr NativeFieldInfoPtr_seconds;

		// Token: 0x04001F21 RID: 7969
		private static readonly IntPtr NativeFieldInfoPtr_nanoseconds;

		// Token: 0x04001F22 RID: 7970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001F23 RID: 7971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_DurationType_0;

		// Token: 0x04001F24 RID: 7972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_DurationType_0;

		// Token: 0x04001F25 RID: 7973
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNegative_Public_get_Boolean_0;

		// Token: 0x04001F26 RID: 7974
		private static readonly IntPtr NativeMethodInfoPtr_get_Years_Public_get_Int32_0;

		// Token: 0x04001F27 RID: 7975
		private static readonly IntPtr NativeMethodInfoPtr_get_Months_Public_get_Int32_0;

		// Token: 0x04001F28 RID: 7976
		private static readonly IntPtr NativeMethodInfoPtr_get_Days_Public_get_Int32_0;

		// Token: 0x04001F29 RID: 7977
		private static readonly IntPtr NativeMethodInfoPtr_get_Hours_Public_get_Int32_0;

		// Token: 0x04001F2A RID: 7978
		private static readonly IntPtr NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0;

		// Token: 0x04001F2B RID: 7979
		private static readonly IntPtr NativeMethodInfoPtr_get_Seconds_Public_get_Int32_0;

		// Token: 0x04001F2C RID: 7980
		private static readonly IntPtr NativeMethodInfoPtr_get_Nanoseconds_Public_get_Int32_0;

		// Token: 0x04001F2D RID: 7981
		private static readonly IntPtr NativeMethodInfoPtr_ToTimeSpan_Public_TimeSpan_DurationType_0;

		// Token: 0x04001F2E RID: 7982
		private static readonly IntPtr NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_byref_TimeSpan_0;

		// Token: 0x04001F2F RID: 7983
		private static readonly IntPtr NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_DurationType_byref_TimeSpan_0;

		// Token: 0x04001F30 RID: 7984
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001F31 RID: 7985
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_String_DurationType_0;

		// Token: 0x04001F32 RID: 7986
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_byref_XsdDuration_0;

		// Token: 0x04001F33 RID: 7987
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_DurationType_byref_XsdDuration_0;

		// Token: 0x04001F34 RID: 7988
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDigits_Private_Static_String_String_byref_Int32_Boolean_byref_Int32_byref_Int32_0;

		// Token: 0x04001F35 RID: 7989
		[FieldOffset(0)]
		public int years;

		// Token: 0x04001F36 RID: 7990
		[FieldOffset(4)]
		public int months;

		// Token: 0x04001F37 RID: 7991
		[FieldOffset(8)]
		public int days;

		// Token: 0x04001F38 RID: 7992
		[FieldOffset(12)]
		public int hours;

		// Token: 0x04001F39 RID: 7993
		[FieldOffset(16)]
		public int minutes;

		// Token: 0x04001F3A RID: 7994
		[FieldOffset(20)]
		public int seconds;

		// Token: 0x04001F3B RID: 7995
		[FieldOffset(24)]
		public uint nanoseconds;

		// Token: 0x02000256 RID: 598
		[OriginalName("System.Xml.dll", "", "Parts")]
		public enum Parts
		{
			// Token: 0x0400243B RID: 9275
			HasNone,
			// Token: 0x0400243C RID: 9276
			HasYears,
			// Token: 0x0400243D RID: 9277
			HasMonths,
			// Token: 0x0400243E RID: 9278
			HasDays = 4,
			// Token: 0x0400243F RID: 9279
			HasHours = 8,
			// Token: 0x04002440 RID: 9280
			HasMinutes = 16,
			// Token: 0x04002441 RID: 9281
			HasSeconds = 32
		}

		// Token: 0x02000257 RID: 599
		[OriginalName("System.Xml.dll", "", "DurationType")]
		public enum DurationType
		{
			// Token: 0x04002443 RID: 9283
			Duration,
			// Token: 0x04002444 RID: 9284
			YearMonthDuration,
			// Token: 0x04002445 RID: 9285
			DayTimeDuration
		}
	}
}
