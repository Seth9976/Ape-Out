using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000096 RID: 150
	[Serializable]
	[StructLayout(2)]
	public struct DateTimeOffset
	{
		// Token: 0x06000A43 RID: 2627 RVA: 0x00051850 File Offset: 0x0004FA50
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeOffset()
		{
			Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeOffset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr);
			DateTimeOffset.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, "MinValue");
			DateTimeOffset.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, "MaxValue");
			DateTimeOffset.NativeFieldInfoPtr_m_dateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, "m_dateTime");
			DateTimeOffset.NativeFieldInfoPtr_m_offsetMinutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, "m_offsetMinutes");
			DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_Int64_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664997);
			DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664998);
			DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664999);
			DateTimeOffset.NativeMethodInfoPtr_get_DateTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665000);
			DateTimeOffset.NativeMethodInfoPtr_get_UtcDateTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665001);
			DateTimeOffset.NativeMethodInfoPtr_get_LocalDateTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665002);
			DateTimeOffset.NativeMethodInfoPtr_get_ClockDateTime_Private_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665003);
			DateTimeOffset.NativeMethodInfoPtr_get_Offset_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665004);
			DateTimeOffset.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665005);
			DateTimeOffset.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665006);
			DateTimeOffset.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665007);
			DateTimeOffset.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665008);
			DateTimeOffset.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665009);
			DateTimeOffset.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665010);
			DateTimeOffset.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665011);
			DateTimeOffset.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665012);
			DateTimeOffset.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665013);
			DateTimeOffset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665014);
			DateTimeOffset.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665015);
			DateTimeOffset.NativeMethodInfoPtr_ValidateOffset_Private_Static_Int16_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665016);
			DateTimeOffset.NativeMethodInfoPtr_ValidateDate_Private_Static_DateTime_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665017);
			DateTimeOffset.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100665018);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00051A88 File Offset: 0x0004FC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151909, XrefRangeEnd = 151914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset(long ticks, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_Int64_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00051AC8 File Offset: 0x0004FCC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 151922, RefRangeEnd = 151925, XrefRangeStart = 151914, XrefRangeEnd = 151922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset(DateTime dateTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00051AFC File Offset: 0x0004FCFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151939, RefRangeEnd = 151940, XrefRangeStart = 151925, XrefRangeEnd = 151939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset(DateTime dateTime, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_DateTime_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00051B3C File Offset: 0x0004FD3C
		public unsafe DateTime DateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151940, XrefRangeEnd = 151941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_DateTime_Public_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00051B6C File Offset: 0x0004FD6C
		public unsafe DateTime UtcDateTime
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 151945, RefRangeEnd = 151953, XrefRangeStart = 151941, XrefRangeEnd = 151945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_UtcDateTime_Public_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00051B9C File Offset: 0x0004FD9C
		public unsafe DateTime LocalDateTime
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 151954, RefRangeEnd = 151956, XrefRangeStart = 151953, XrefRangeEnd = 151954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_LocalDateTime_Public_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x00051BCC File Offset: 0x0004FDCC
		public unsafe DateTime ClockDateTime
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 151965, RefRangeEnd = 151972, XrefRangeStart = 151956, XrefRangeEnd = 151965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_ClockDateTime_Private_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00051BFC File Offset: 0x0004FDFC
		public unsafe TimeSpan Offset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151972, XrefRangeEnd = 151976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_Offset_Public_get_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x00051C2C File Offset: 0x0004FE2C
		public unsafe long Ticks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151976, XrefRangeEnd = 151977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00051C5C File Offset: 0x0004FE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151977, XrefRangeEnd = 151989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IComparable_CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00051CA0 File Offset: 0x0004FEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151989, XrefRangeEnd = 151996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(DateTimeOffset other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTimeOffset_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00051CE0 File Offset: 0x0004FEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151996, XrefRangeEnd = 152004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00051D24 File Offset: 0x0004FF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152004, XrefRangeEnd = 152006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(DateTimeOffset other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTimeOffset_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00051D64 File Offset: 0x0004FF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152006, XrefRangeEnd = 152020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00051D9C File Offset: 0x0004FF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152020, XrefRangeEnd = 152035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00051DEC File Offset: 0x0004FFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152035, XrefRangeEnd = 152054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00051E3C File Offset: 0x0005003C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152054, XrefRangeEnd = 152055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00051E6C File Offset: 0x0005006C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152055, XrefRangeEnd = 152068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00051E98 File Offset: 0x00050098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152068, XrefRangeEnd = 152081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00051EE8 File Offset: 0x000500E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 152081, RefRangeEnd = 152085, XrefRangeStart = 152081, XrefRangeEnd = 152081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ValidateOffset(TimeSpan offset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ValidateOffset_Private_Static_Int16_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00051F28 File Offset: 0x00050128
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 152086, RefRangeEnd = 152090, XrefRangeStart = 152085, XrefRangeEnd = 152086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ValidateDate(DateTime dateTime, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ValidateDate_Private_Static_DateTime_DateTime_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00051F74 File Offset: 0x00050174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152090, XrefRangeEnd = 152091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DateTimeOffset(DateTime dateTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00004C63 File Offset: 0x00002E63
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, ref this));
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00051FB4 File Offset: 0x000501B4
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x00004C75 File Offset: 0x00002E75
		public unsafe static DateTimeOffset MinValue
		{
			get
			{
				DateTimeOffset dateTimeOffset;
				IL2CPP.il2cpp_field_static_get_value(DateTimeOffset.NativeFieldInfoPtr_MinValue, (void*)(&dateTimeOffset));
				return dateTimeOffset;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeOffset.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x00051FD0 File Offset: 0x000501D0
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x00004C83 File Offset: 0x00002E83
		public unsafe static DateTimeOffset MaxValue
		{
			get
			{
				DateTimeOffset dateTimeOffset;
				IL2CPP.il2cpp_field_static_get_value(DateTimeOffset.NativeFieldInfoPtr_MaxValue, (void*)(&dateTimeOffset));
				return dateTimeOffset;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeOffset.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeFieldInfoPtr_m_dateTime;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeFieldInfoPtr_m_offsetMinutes;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_TimeSpan_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_TimeSpan_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTime_Public_get_DateTime_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_get_UtcDateTime_Public_get_DateTime_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalDateTime_Public_get_DateTime_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_get_ClockDateTime_Private_get_DateTime_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_get_Offset_Public_get_TimeSpan_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTimeOffset_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTimeOffset_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_ValidateOffset_Private_Static_Int16_TimeSpan_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_ValidateDate_Private_Static_DateTime_DateTime_TimeSpan_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_DateTime_0;

		// Token: 0x04000898 RID: 2200
		[FieldOffset(0)]
		public DateTime m_dateTime;

		// Token: 0x04000899 RID: 2201
		[FieldOffset(8)]
		public short m_offsetMinutes;
	}
}
