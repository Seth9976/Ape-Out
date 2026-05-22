using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x020000B4 RID: 180
	public sealed class ParsingInfo : ValueType
	{
		// Token: 0x06000CDA RID: 3290 RVA: 0x0005DFB4 File Offset: 0x0005C1B4
		// Note: this type is marked as 'beforefieldinit'.
		static ParsingInfo()
		{
			Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParsingInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr);
			ParsingInfo.NativeFieldInfoPtr_calendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "calendar");
			ParsingInfo.NativeFieldInfoPtr_dayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "dayOfWeek");
			ParsingInfo.NativeFieldInfoPtr_timeMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "timeMark");
			ParsingInfo.NativeFieldInfoPtr_fUseHour12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fUseHour12");
			ParsingInfo.NativeFieldInfoPtr_fUseTwoDigitYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fUseTwoDigitYear");
			ParsingInfo.NativeFieldInfoPtr_fAllowInnerWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fAllowInnerWhite");
			ParsingInfo.NativeFieldInfoPtr_fAllowTrailingWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fAllowTrailingWhite");
			ParsingInfo.NativeFieldInfoPtr_fCustomNumberParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fCustomNumberParser");
			ParsingInfo.NativeFieldInfoPtr_parseNumberDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "parseNumberDelegate");
			ParsingInfo.NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, 100665467);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x0005E0AC File Offset: 0x0005C2AC
		[CallerCount(0)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingInfo.NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0000552F File Offset: 0x0000372F
		public ParsingInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00005538 File Offset: 0x00003738
		public ParsingInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0005E0E4 File Offset: 0x0005C2E4
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x0000554A File Offset: 0x0000374A
		public unsafe Calendar calendar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_calendar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_calendar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x0005E114 File Offset: 0x0005C314
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x00005569 File Offset: 0x00003769
		public unsafe int dayOfWeek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_dayOfWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_dayOfWeek)) = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0005E13C File Offset: 0x0005C33C
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x00005584 File Offset: 0x00003784
		public unsafe DateTimeParse.TM timeMark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_timeMark);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_timeMark)) = value;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x0005E164 File Offset: 0x0005C364
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x0000559F File Offset: 0x0000379F
		public unsafe bool fUseHour12
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fUseHour12);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fUseHour12)) = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x0005E18C File Offset: 0x0005C38C
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x000055BA File Offset: 0x000037BA
		public unsafe bool fUseTwoDigitYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fUseTwoDigitYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fUseTwoDigitYear)) = value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0005E1B4 File Offset: 0x0005C3B4
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x000055D5 File Offset: 0x000037D5
		public unsafe bool fAllowInnerWhite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fAllowInnerWhite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fAllowInnerWhite)) = value;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0005E1DC File Offset: 0x0005C3DC
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x000055F0 File Offset: 0x000037F0
		public unsafe bool fAllowTrailingWhite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fAllowTrailingWhite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fAllowTrailingWhite)) = value;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x0005E204 File Offset: 0x0005C404
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x0000560B File Offset: 0x0000380B
		public unsafe bool fCustomNumberParser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fCustomNumberParser);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fCustomNumberParser)) = value;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0005E22C File Offset: 0x0005C42C
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x00005626 File Offset: 0x00003826
		public unsafe DateTimeParse.MatchNumberDelegate parseNumberDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_parseNumberDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeParse.MatchNumberDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_parseNumberDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeFieldInfoPtr_calendar;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeFieldInfoPtr_dayOfWeek;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeFieldInfoPtr_timeMark;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeFieldInfoPtr_fUseHour12;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeFieldInfoPtr_fUseTwoDigitYear;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeFieldInfoPtr_fAllowInnerWhite;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeFieldInfoPtr_fAllowTrailingWhite;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeFieldInfoPtr_fCustomNumberParser;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeFieldInfoPtr_parseNumberDelegate;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;
	}
}
