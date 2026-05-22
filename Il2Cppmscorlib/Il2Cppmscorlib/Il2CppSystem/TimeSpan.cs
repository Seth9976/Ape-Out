using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000F4 RID: 244
	[Serializable]
	[StructLayout(2)]
	public struct TimeSpan
	{
		// Token: 0x06001101 RID: 4353 RVA: 0x000729A8 File Offset: 0x00070BA8
		// Note: this type is marked as 'beforefieldinit'.
		static TimeSpan()
		{
			Il2CppClassPointerStore<TimeSpan>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TimeSpan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr);
			TimeSpan.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "Zero");
			TimeSpan.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MaxValue");
			TimeSpan.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MinValue");
			TimeSpan.NativeFieldInfoPtr__ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "_ticks");
			TimeSpan.NativeFieldInfoPtr__legacyConfigChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "_legacyConfigChecked");
			TimeSpan.NativeFieldInfoPtr__legacyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "_legacyMode");
			TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666241);
			TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666242);
			TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666243);
			TimeSpan.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666244);
			TimeSpan.NativeMethodInfoPtr_get_Hours_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666245);
			TimeSpan.NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666246);
			TimeSpan.NativeMethodInfoPtr_get_TotalDays_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666247);
			TimeSpan.NativeMethodInfoPtr_get_TotalHours_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666248);
			TimeSpan.NativeMethodInfoPtr_get_TotalMilliseconds_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666249);
			TimeSpan.NativeMethodInfoPtr_get_TotalMinutes_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666250);
			TimeSpan.NativeMethodInfoPtr_get_TotalSeconds_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666251);
			TimeSpan.NativeMethodInfoPtr_Add_Public_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666252);
			TimeSpan.NativeMethodInfoPtr_Compare_Public_Static_Int32_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666253);
			TimeSpan.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666254);
			TimeSpan.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666255);
			TimeSpan.NativeMethodInfoPtr_FromDays_Public_Static_TimeSpan_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666256);
			TimeSpan.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666257);
			TimeSpan.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666258);
			TimeSpan.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666259);
			TimeSpan.NativeMethodInfoPtr_FromHours_Public_Static_TimeSpan_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666260);
			TimeSpan.NativeMethodInfoPtr_Interval_Private_Static_TimeSpan_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666261);
			TimeSpan.NativeMethodInfoPtr_FromMilliseconds_Public_Static_TimeSpan_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666262);
			TimeSpan.NativeMethodInfoPtr_FromMinutes_Public_Static_TimeSpan_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666263);
			TimeSpan.NativeMethodInfoPtr_Negate_Public_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666264);
			TimeSpan.NativeMethodInfoPtr_FromSeconds_Public_Static_TimeSpan_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666265);
			TimeSpan.NativeMethodInfoPtr_Subtract_Public_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666266);
			TimeSpan.NativeMethodInfoPtr_FromTicks_Public_Static_TimeSpan_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666267);
			TimeSpan.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666268);
			TimeSpan.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666269);
			TimeSpan.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666270);
			TimeSpan.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666271);
			TimeSpan.NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666272);
			TimeSpan.NativeMethodInfoPtr_op_Addition_Public_Static_TimeSpan_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666273);
			TimeSpan.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666274);
			TimeSpan.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666275);
			TimeSpan.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666276);
			TimeSpan.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666277);
			TimeSpan.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666278);
			TimeSpan.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666279);
			TimeSpan.NativeMethodInfoPtr_GetLegacyFormatMode_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666280);
			TimeSpan.NativeMethodInfoPtr_get_LegacyMode_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666281);
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00072D84 File Offset: 0x00070F84
		[CallerCount(0)]
		public unsafe TimeSpan(long ticks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00072DB8 File Offset: 0x00070FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168080, XrefRangeEnd = 168084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan(int hours, int minutes, int seconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hours;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00072E08 File Offset: 0x00071008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168084, RefRangeEnd = 168085, XrefRangeStart = 168084, XrefRangeEnd = 168084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref days;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hours;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref milliseconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x00072E74 File Offset: 0x00071074
		public unsafe long Ticks
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x00072EA4 File Offset: 0x000710A4
		public unsafe int Hours
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_Hours_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x00072ED4 File Offset: 0x000710D4
		public unsafe int Minutes
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x00072F04 File Offset: 0x00071104
		public unsafe double TotalDays
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_TotalDays_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x00072F34 File Offset: 0x00071134
		public unsafe double TotalHours
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_TotalHours_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x00072F64 File Offset: 0x00071164
		public unsafe double TotalMilliseconds
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_TotalMilliseconds_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x00072F94 File Offset: 0x00071194
		public unsafe double TotalMinutes
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_TotalMinutes_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x00072FC4 File Offset: 0x000711C4
		public unsafe double TotalSeconds
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_TotalSeconds_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00072FF4 File Offset: 0x000711F4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 168085, RefRangeEnd = 168094, XrefRangeStart = 168085, XrefRangeEnd = 168085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan Add(TimeSpan ts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Add_Public_TimeSpan_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x00073034 File Offset: 0x00071234
		[CallerCount(0)]
		public unsafe static int Compare(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Compare_Public_Static_Int32_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x00073080 File Offset: 0x00071280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168096, RefRangeEnd = 168097, XrefRangeStart = 168094, XrefRangeEnd = 168096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x000730C4 File Offset: 0x000712C4
		[CallerCount(0)]
		public unsafe int CompareTo(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00073104 File Offset: 0x00071304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168101, RefRangeEnd = 168102, XrefRangeStart = 168097, XrefRangeEnd = 168101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromDays(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromDays_Public_Static_TimeSpan_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00073144 File Offset: 0x00071344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168102, XrefRangeEnd = 168104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00073188 File Offset: 0x00071388
		[CallerCount(0)]
		public unsafe bool Equals(TimeSpan obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x000731C8 File Offset: 0x000713C8
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x000731F8 File Offset: 0x000713F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168104, XrefRangeEnd = 168108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromHours(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromHours_Public_Static_TimeSpan_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00073238 File Offset: 0x00071438
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 168112, RefRangeEnd = 168123, XrefRangeStart = 168108, XrefRangeEnd = 168112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan Interval(double value, int scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Interval_Private_Static_TimeSpan_Double_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00073284 File Offset: 0x00071484
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168127, RefRangeEnd = 168128, XrefRangeStart = 168123, XrefRangeEnd = 168127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromMilliseconds(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromMilliseconds_Public_Static_TimeSpan_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x000732C4 File Offset: 0x000714C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168132, RefRangeEnd = 168133, XrefRangeStart = 168128, XrefRangeEnd = 168132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromMinutes(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromMinutes_Public_Static_TimeSpan_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00073304 File Offset: 0x00071504
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 168137, RefRangeEnd = 168140, XrefRangeStart = 168133, XrefRangeEnd = 168137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan Negate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Negate_Public_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00073334 File Offset: 0x00071534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168140, XrefRangeEnd = 168144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromSeconds(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromSeconds_Public_Static_TimeSpan_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00073374 File Offset: 0x00071574
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 168144, RefRangeEnd = 168147, XrefRangeStart = 168144, XrefRangeEnd = 168144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan Subtract(TimeSpan ts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Subtract_Public_TimeSpan_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x000733B4 File Offset: 0x000715B4
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromTicks(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromTicks_Public_Static_TimeSpan_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x000733F4 File Offset: 0x000715F4
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 168147, RefRangeEnd = 168182, XrefRangeStart = 168147, XrefRangeEnd = 168147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00073450 File Offset: 0x00071650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168182, XrefRangeEnd = 168186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0007347C File Offset: 0x0007167C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168186, XrefRangeEnd = 168190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x000734B8 File Offset: 0x000716B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168190, XrefRangeEnd = 168213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00073508 File Offset: 0x00071708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168213, XrefRangeEnd = 168214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan operator -(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00073554 File Offset: 0x00071754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168214, XrefRangeEnd = 168215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan operator +(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_Addition_Public_Static_TimeSpan_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x000735A0 File Offset: 0x000717A0
		[CallerCount(0)]
		public unsafe static bool operator ==(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x000735EC File Offset: 0x000717EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12921, RefRangeEnd = 12922, XrefRangeStart = 12921, XrefRangeEnd = 12922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00073638 File Offset: 0x00071838
		[CallerCount(0)]
		public unsafe static bool operator <(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00073684 File Offset: 0x00071884
		[CallerCount(0)]
		public unsafe static bool operator <=(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x000736D0 File Offset: 0x000718D0
		[CallerCount(0)]
		public unsafe static bool operator >(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0007371C File Offset: 0x0007191C
		[CallerCount(0)]
		public unsafe static bool operator >=(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00073768 File Offset: 0x00071968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168215, XrefRangeEnd = 168217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetLegacyFormatMode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_GetLegacyFormatMode_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x00073798 File Offset: 0x00071998
		public unsafe static bool LegacyMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168217, XrefRangeEnd = 168230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_LegacyMode_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x000061FB File Offset: 0x000043FB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, ref this));
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x000737C8 File Offset: 0x000719C8
		// (set) Token: 0x0600112D RID: 4397 RVA: 0x0000620D File Offset: 0x0000440D
		public unsafe static TimeSpan Zero
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_Zero, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x000737E4 File Offset: 0x000719E4
		// (set) Token: 0x0600112F RID: 4399 RVA: 0x0000621B File Offset: 0x0000441B
		public unsafe static TimeSpan MaxValue
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MaxValue, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x00073800 File Offset: 0x00071A00
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x00006229 File Offset: 0x00004429
		public unsafe static TimeSpan MinValue
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MinValue, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x0007381C File Offset: 0x00071A1C
		// (set) Token: 0x06001133 RID: 4403 RVA: 0x00006237 File Offset: 0x00004437
		public unsafe static bool _legacyConfigChecked
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr__legacyConfigChecked, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr__legacyConfigChecked, (void*)(&value));
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x00073838 File Offset: 0x00071A38
		// (set) Token: 0x06001135 RID: 4405 RVA: 0x00006245 File Offset: 0x00004445
		public unsafe static bool _legacyMode
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr__legacyMode, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr__legacyMode, (void*)(&value));
			}
		}

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeFieldInfoPtr__ticks;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeFieldInfoPtr__legacyConfigChecked;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeFieldInfoPtr__legacyMode;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_get_Hours_Public_get_Int32_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDays_Public_get_Double_0;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalHours_Public_get_Double_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalMilliseconds_Public_get_Double_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalMinutes_Public_get_Double_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalSeconds_Public_get_Double_0;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_TimeSpan_TimeSpan_0;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_TimeSpan_TimeSpan_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TimeSpan_0;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr_FromDays_Public_Static_TimeSpan_Double_0;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeSpan_0;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr_FromHours_Public_Static_TimeSpan_Double_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr_Interval_Private_Static_TimeSpan_Double_Int32_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_FromMilliseconds_Public_Static_TimeSpan_Double_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_FromMinutes_Public_Static_TimeSpan_Double_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_Negate_Public_TimeSpan_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_FromSeconds_Public_Static_TimeSpan_Double_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_TimeSpan_TimeSpan_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_FromTicks_Public_Static_TimeSpan_Int64_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_TimeSpan_TimeSpan_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_TimeSpan_TimeSpan_TimeSpan_0;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeMethodInfoPtr_GetLegacyFormatMode_Private_Static_Boolean_0;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeMethodInfoPtr_get_LegacyMode_Private_Static_get_Boolean_0;

		// Token: 0x04000EEF RID: 3823
		[FieldOffset(0)]
		public long _ticks;
	}
}
