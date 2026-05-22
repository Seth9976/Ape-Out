using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000299 RID: 665
	public sealed class Timer : MarshalByRefObject
	{
		// Token: 0x06002DB8 RID: 11704 RVA: 0x000E9C00 File Offset: 0x000E7E00
		// Note: this type is marked as 'beforefieldinit'.
		static Timer()
		{
			Il2CppClassPointerStore<Timer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Timer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Timer>.NativeClassPtr);
			Timer.NativeFieldInfoPtr_scheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "scheduler");
			Timer.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "callback");
			Timer.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "state");
			Timer.NativeFieldInfoPtr_due_time_ms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "due_time_ms");
			Timer.NativeFieldInfoPtr_period_ms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "period_ms");
			Timer.NativeFieldInfoPtr_next_run = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "next_run");
			Timer.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "disposed");
			Timer.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "MaxValue");
			Timer.NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670562);
			Timer.NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670563);
			Timer.NativeMethodInfoPtr_Init_Private_Void_TimerCallback_Object_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670564);
			Timer.NativeMethodInfoPtr_Change_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670565);
			Timer.NativeMethodInfoPtr_Change_Public_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670566);
			Timer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670567);
			Timer.NativeMethodInfoPtr_Change_Private_Boolean_Int64_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670568);
			Timer.NativeMethodInfoPtr_KeepRootedWhileScheduled_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670569);
			Timer.NativeMethodInfoPtr_GetTimeMonotonic_Private_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670570);
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x000E9D84 File Offset: 0x000E7F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205004, XrefRangeEnd = 205005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Timer(TimerCallback callback, Object state, int dueTime, int period)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dueTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x000E9E00 File Offset: 0x000E8000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205005, XrefRangeEnd = 205008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Timer(TimerCallback callback, Object state, TimeSpan dueTime, TimeSpan period)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dueTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_TimeSpan_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x000E9E7C File Offset: 0x000E807C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 205015, RefRangeEnd = 205020, XrefRangeStart = 205008, XrefRangeEnd = 205015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(TimerCallback callback, Object state, long dueTime, long period)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dueTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Init_Private_Void_TimerCallback_Object_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x000E9EEC File Offset: 0x000E80EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205020, XrefRangeEnd = 205021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Change(int dueTime, int period)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dueTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Change_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x000E9F44 File Offset: 0x000E8144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205021, XrefRangeEnd = 205024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Change(TimeSpan dueTime, TimeSpan period)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dueTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Change_Public_Boolean_TimeSpan_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x000E9F9C File Offset: 0x000E819C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 205029, RefRangeEnd = 205037, XrefRangeStart = 205024, XrefRangeEnd = 205029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x000E9FD0 File Offset: 0x000E81D0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 205042, RefRangeEnd = 205050, XrefRangeStart = 205037, XrefRangeEnd = 205042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Change(long dueTime, long period, bool first)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dueTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Change_Private_Boolean_Int64_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x000EA038 File Offset: 0x000E8238
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KeepRootedWhileScheduled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_KeepRootedWhileScheduled_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x000EA06C File Offset: 0x000E826C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 205051, RefRangeEnd = 205054, XrefRangeStart = 205050, XrefRangeEnd = 205051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetTimeMonotonic()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_GetTimeMonotonic_Private_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x0000FECF File Offset: 0x0000E0CF
		public Timer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x000EA09C File Offset: 0x000E829C
		// (set) Token: 0x06002DC4 RID: 11716 RVA: 0x0000FED8 File Offset: 0x0000E0D8
		public unsafe static Timer.Scheduler scheduler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Timer.NativeFieldInfoPtr_scheduler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer.Scheduler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Timer.NativeFieldInfoPtr_scheduler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x000EA0C4 File Offset: 0x000E82C4
		// (set) Token: 0x06002DC6 RID: 11718 RVA: 0x0000FEEA File Offset: 0x0000E0EA
		public unsafe TimerCallback callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002DC7 RID: 11719 RVA: 0x000EA0F4 File Offset: 0x000E82F4
		// (set) Token: 0x06002DC8 RID: 11720 RVA: 0x0000FF09 File Offset: 0x0000E109
		public unsafe Object state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06002DC9 RID: 11721 RVA: 0x000EA124 File Offset: 0x000E8324
		// (set) Token: 0x06002DCA RID: 11722 RVA: 0x0000FF28 File Offset: 0x0000E128
		public unsafe long due_time_ms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_due_time_ms);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_due_time_ms)) = value;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06002DCB RID: 11723 RVA: 0x000EA14C File Offset: 0x000E834C
		// (set) Token: 0x06002DCC RID: 11724 RVA: 0x0000FF43 File Offset: 0x0000E143
		public unsafe long period_ms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_period_ms);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_period_ms)) = value;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06002DCD RID: 11725 RVA: 0x000EA174 File Offset: 0x000E8374
		// (set) Token: 0x06002DCE RID: 11726 RVA: 0x0000FF5E File Offset: 0x0000E15E
		public unsafe long next_run
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_next_run);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_next_run)) = value;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002DCF RID: 11727 RVA: 0x000EA19C File Offset: 0x000E839C
		// (set) Token: 0x06002DD0 RID: 11728 RVA: 0x0000FF79 File Offset: 0x0000E179
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x000EA1C4 File Offset: 0x000E83C4
		// (set) Token: 0x06002DD2 RID: 11730 RVA: 0x0000FF94 File Offset: 0x0000E194
		public unsafe static long MaxValue
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Timer.NativeFieldInfoPtr_MaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Timer.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x04002799 RID: 10137
		private static readonly IntPtr NativeFieldInfoPtr_scheduler;

		// Token: 0x0400279A RID: 10138
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x0400279B RID: 10139
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x0400279C RID: 10140
		private static readonly IntPtr NativeFieldInfoPtr_due_time_ms;

		// Token: 0x0400279D RID: 10141
		private static readonly IntPtr NativeFieldInfoPtr_period_ms;

		// Token: 0x0400279E RID: 10142
		private static readonly IntPtr NativeFieldInfoPtr_next_run;

		// Token: 0x0400279F RID: 10143
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x040027A0 RID: 10144
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x040027A1 RID: 10145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_Int32_Int32_0;

		// Token: 0x040027A2 RID: 10146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_TimeSpan_TimeSpan_0;

		// Token: 0x040027A3 RID: 10147
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_TimerCallback_Object_Int64_Int64_0;

		// Token: 0x040027A4 RID: 10148
		private static readonly IntPtr NativeMethodInfoPtr_Change_Public_Boolean_Int32_Int32_0;

		// Token: 0x040027A5 RID: 10149
		private static readonly IntPtr NativeMethodInfoPtr_Change_Public_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x040027A6 RID: 10150
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040027A7 RID: 10151
		private static readonly IntPtr NativeMethodInfoPtr_Change_Private_Boolean_Int64_Int64_Boolean_0;

		// Token: 0x040027A8 RID: 10152
		private static readonly IntPtr NativeMethodInfoPtr_KeepRootedWhileScheduled_Internal_Void_0;

		// Token: 0x040027A9 RID: 10153
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeMonotonic_Private_Static_Int64_0;

		// Token: 0x020005FA RID: 1530
		public sealed class TimerComparer : Object
		{
			// Token: 0x0600546A RID: 21610 RVA: 0x0017B6FC File Offset: 0x001798FC
			// Note: this type is marked as 'beforefieldinit'.
			static TimerComparer()
			{
				Il2CppClassPointerStore<Timer.TimerComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Timer>.NativeClassPtr, "TimerComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Timer.TimerComparer>.NativeClassPtr);
				Timer.TimerComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.TimerComparer>.NativeClassPtr, 100670572);
				Timer.TimerComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.TimerComparer>.NativeClassPtr, 100670573);
			}

			// Token: 0x0600546B RID: 21611 RVA: 0x0017B750 File Offset: 0x00179950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204826, XrefRangeEnd = 204828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Compare(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.TimerComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600546C RID: 21612 RVA: 0x0017B7B0 File Offset: 0x001799B0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimerComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timer.TimerComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.TimerComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600546D RID: 21613 RVA: 0x0001FE11 File Offset: 0x0001E011
			public TimerComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004460 RID: 17504
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;

			// Token: 0x04004461 RID: 17505
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020005FB RID: 1531
		public sealed class Scheduler : Object
		{
			// Token: 0x0600546E RID: 21614 RVA: 0x0017B7EC File Offset: 0x001799EC
			// Note: this type is marked as 'beforefieldinit'.
			static Scheduler()
			{
				Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Timer>.NativeClassPtr, "Scheduler");
				Timer.Scheduler.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, "instance");
				Timer.Scheduler.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, "list");
				Timer.Scheduler.NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, "changed");
				Timer.Scheduler.NativeMethodInfoPtr_get_Instance_Public_Static_get_Scheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670575);
				Timer.Scheduler.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670576);
				Timer.Scheduler.NativeMethodInfoPtr_Remove_Public_Void_Timer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670577);
				Timer.Scheduler.NativeMethodInfoPtr_Change_Public_Void_Timer_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670578);
				Timer.Scheduler.NativeMethodInfoPtr_FindByDueTime_Private_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670579);
				Timer.Scheduler.NativeMethodInfoPtr_Add_Private_Void_Timer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670580);
				Timer.Scheduler.NativeMethodInfoPtr_InternalRemove_Private_Int32_Timer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670581);
				Timer.Scheduler.NativeMethodInfoPtr_TimerCB_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670582);
				Timer.Scheduler.NativeMethodInfoPtr_SchedulerThread_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670583);
				Timer.Scheduler.NativeMethodInfoPtr_ShrinkIfNeeded_Private_Void_List_1_Timer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670584);
			}

			// Token: 0x170015AB RID: 5547
			// (get) Token: 0x0600546F RID: 21615 RVA: 0x0017B914 File Offset: 0x00179B14
			public unsafe static Timer.Scheduler Instance
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204828, XrefRangeEnd = 204832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_get_Instance_Public_Static_get_Scheduler_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Timer.Scheduler>(intPtr3) : null;
				}
			}

			// Token: 0x06005470 RID: 21616 RVA: 0x0017B948 File Offset: 0x00179B48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204832, XrefRangeEnd = 204855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Scheduler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005471 RID: 21617 RVA: 0x0017B984 File Offset: 0x00179B84
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 204859, RefRangeEnd = 204860, XrefRangeStart = 204855, XrefRangeEnd = 204859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Remove(Timer timer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_Remove_Public_Void_Timer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005472 RID: 21618 RVA: 0x0017B9C8 File Offset: 0x00179BC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204860, XrefRangeEnd = 204866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Change(Timer timer, long new_next_run)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref new_next_run;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_Change_Public_Void_Timer_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005473 RID: 21619 RVA: 0x0017BA18 File Offset: 0x00179C18
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 204868, RefRangeEnd = 204869, XrefRangeStart = 204866, XrefRangeEnd = 204868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int FindByDueTime(long nr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref nr;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_FindByDueTime_Private_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005474 RID: 21620 RVA: 0x0017BA64 File Offset: 0x00179C64
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 204874, RefRangeEnd = 204876, XrefRangeStart = 204869, XrefRangeEnd = 204874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(Timer timer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_Add_Private_Void_Timer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005475 RID: 21621 RVA: 0x0017BAA8 File Offset: 0x00179CA8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 204876, RefRangeEnd = 204877, XrefRangeStart = 204876, XrefRangeEnd = 204876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int InternalRemove(Timer timer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_InternalRemove_Private_Int32_Timer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005476 RID: 21622 RVA: 0x0017BAF8 File Offset: 0x00179CF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204877, XrefRangeEnd = 204882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void TimerCB(Object o)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_TimerCB_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005477 RID: 21623 RVA: 0x0017BB30 File Offset: 0x00179D30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204882, XrefRangeEnd = 204998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SchedulerThread()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_SchedulerThread_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005478 RID: 21624 RVA: 0x0017BB64 File Offset: 0x00179D64
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 205003, RefRangeEnd = 205004, XrefRangeStart = 204998, XrefRangeEnd = 205003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ShrinkIfNeeded(List<Timer> list, int initial)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_ShrinkIfNeeded_Private_Void_List_1_Timer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005479 RID: 21625 RVA: 0x0001FE1A File Offset: 0x0001E01A
			public Scheduler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015A8 RID: 5544
			// (get) Token: 0x0600547A RID: 21626 RVA: 0x0017BBB4 File Offset: 0x00179DB4
			// (set) Token: 0x0600547B RID: 21627 RVA: 0x0001FE23 File Offset: 0x0001E023
			public unsafe static Timer.Scheduler instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Timer.Scheduler.NativeFieldInfoPtr_instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer.Scheduler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Timer.Scheduler.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015A9 RID: 5545
			// (get) Token: 0x0600547C RID: 21628 RVA: 0x0017BBDC File Offset: 0x00179DDC
			// (set) Token: 0x0600547D RID: 21629 RVA: 0x0001FE35 File Offset: 0x0001E035
			public unsafe SortedList list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.Scheduler.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.Scheduler.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015AA RID: 5546
			// (get) Token: 0x0600547E RID: 21630 RVA: 0x0017BC0C File Offset: 0x00179E0C
			// (set) Token: 0x0600547F RID: 21631 RVA: 0x0001FE54 File Offset: 0x0001E054
			public unsafe ManualResetEvent changed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.Scheduler.NativeFieldInfoPtr_changed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.Scheduler.NativeFieldInfoPtr_changed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004462 RID: 17506
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x04004463 RID: 17507
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x04004464 RID: 17508
			private static readonly IntPtr NativeFieldInfoPtr_changed;

			// Token: 0x04004465 RID: 17509
			private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Scheduler_0;

			// Token: 0x04004466 RID: 17510
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x04004467 RID: 17511
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Timer_0;

			// Token: 0x04004468 RID: 17512
			private static readonly IntPtr NativeMethodInfoPtr_Change_Public_Void_Timer_Int64_0;

			// Token: 0x04004469 RID: 17513
			private static readonly IntPtr NativeMethodInfoPtr_FindByDueTime_Private_Int32_Int64_0;

			// Token: 0x0400446A RID: 17514
			private static readonly IntPtr NativeMethodInfoPtr_Add_Private_Void_Timer_0;

			// Token: 0x0400446B RID: 17515
			private static readonly IntPtr NativeMethodInfoPtr_InternalRemove_Private_Int32_Timer_0;

			// Token: 0x0400446C RID: 17516
			private static readonly IntPtr NativeMethodInfoPtr_TimerCB_Private_Static_Void_Object_0;

			// Token: 0x0400446D RID: 17517
			private static readonly IntPtr NativeMethodInfoPtr_SchedulerThread_Private_Void_0;

			// Token: 0x0400446E RID: 17518
			private static readonly IntPtr NativeMethodInfoPtr_ShrinkIfNeeded_Private_Void_List_1_Timer_Int32_0;
		}
	}
}
