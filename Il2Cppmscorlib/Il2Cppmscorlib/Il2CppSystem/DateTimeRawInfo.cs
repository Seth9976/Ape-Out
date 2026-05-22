using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000B0 RID: 176
	[StructLayout(2)]
	public struct DateTimeRawInfo
	{
		// Token: 0x06000CAE RID: 3246 RVA: 0x0005D80C File Offset: 0x0005BA0C
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeRawInfo()
		{
			Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeRawInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr);
			DateTimeRawInfo.NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "num");
			DateTimeRawInfo.NativeFieldInfoPtr_numCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "numCount");
			DateTimeRawInfo.NativeFieldInfoPtr_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "month");
			DateTimeRawInfo.NativeFieldInfoPtr_year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "year");
			DateTimeRawInfo.NativeFieldInfoPtr_dayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "dayOfWeek");
			DateTimeRawInfo.NativeFieldInfoPtr_era = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "era");
			DateTimeRawInfo.NativeFieldInfoPtr_timeMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "timeMark");
			DateTimeRawInfo.NativeFieldInfoPtr_fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "fraction");
			DateTimeRawInfo.NativeFieldInfoPtr_hasSameDateAndTimeSeparators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "hasSameDateAndTimeSeparators");
			DateTimeRawInfo.NativeFieldInfoPtr_timeZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "timeZone");
			DateTimeRawInfo.NativeMethodInfoPtr_Init_Internal_Void_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, 100665460);
			DateTimeRawInfo.NativeMethodInfoPtr_AddNumber_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, 100665461);
			DateTimeRawInfo.NativeMethodInfoPtr_GetNumber_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, 100665462);
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0005D940 File Offset: 0x0005BB40
		[CallerCount(0)]
		public unsafe void Init(int* numberBuffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = numberBuffer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeRawInfo.NativeMethodInfoPtr_Init_Internal_Void_ptr_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0005D974 File Offset: 0x0005BB74
		[CallerCount(0)]
		public unsafe void AddNumber(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeRawInfo.NativeMethodInfoPtr_AddNumber_Internal_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0005D9A8 File Offset: 0x0005BBA8
		[CallerCount(0)]
		public unsafe int GetNumber(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeRawInfo.NativeMethodInfoPtr_GetNumber_Internal_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00005342 File Offset: 0x00003542
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeFieldInfoPtr_num;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeFieldInfoPtr_numCount;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeFieldInfoPtr_month;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeFieldInfoPtr_year;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeFieldInfoPtr_dayOfWeek;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeFieldInfoPtr_era;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeFieldInfoPtr_timeMark;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeFieldInfoPtr_fraction;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeFieldInfoPtr_hasSameDateAndTimeSeparators;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeFieldInfoPtr_timeZone;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_ptr_Int32_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_AddNumber_Internal_Void_Int32_0;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_GetNumber_Internal_Int32_Int32_0;

		// Token: 0x04000AA1 RID: 2721
		[FieldOffset(0)]
		public IntPtr num;

		// Token: 0x04000AA2 RID: 2722
		[FieldOffset(8)]
		public int numCount;

		// Token: 0x04000AA3 RID: 2723
		[FieldOffset(12)]
		public int month;

		// Token: 0x04000AA4 RID: 2724
		[FieldOffset(16)]
		public int year;

		// Token: 0x04000AA5 RID: 2725
		[FieldOffset(20)]
		public int dayOfWeek;

		// Token: 0x04000AA6 RID: 2726
		[FieldOffset(24)]
		public int era;

		// Token: 0x04000AA7 RID: 2727
		[FieldOffset(28)]
		public DateTimeParse.TM timeMark;

		// Token: 0x04000AA8 RID: 2728
		[FieldOffset(32)]
		public double fraction;

		// Token: 0x04000AA9 RID: 2729
		[FieldOffset(40)]
		[MarshalAs(4)]
		public bool hasSameDateAndTimeSeparators;

		// Token: 0x04000AAA RID: 2730
		[FieldOffset(41)]
		[MarshalAs(4)]
		public bool timeZone;
	}
}
