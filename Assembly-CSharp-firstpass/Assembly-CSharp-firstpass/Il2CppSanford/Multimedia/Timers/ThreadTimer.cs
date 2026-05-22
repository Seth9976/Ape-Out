using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.ComponentModel;

namespace Il2CppSanford.Multimedia.Timers
{
	// Token: 0x02000186 RID: 390
	public sealed class ThreadTimer : Object
	{
		// Token: 0x06001183 RID: 4483 RVA: 0x000545EC File Offset: 0x000527EC
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadTimer()
		{
			Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Timers", "ThreadTimer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr);
			ThreadTimer.NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, "queue");
			ThreadTimer.NativeFieldInfoPtr_isRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, "isRunning");
			ThreadTimer.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, "mode");
			ThreadTimer.NativeFieldInfoPtr_period = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, "period");
			ThreadTimer.NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, "resolution");
			ThreadTimer.NativeFieldInfoPtr_emptyArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, "emptyArgs");
			ThreadTimer.NativeFieldInfoPtr_tickRaiser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, "tickRaiser");
			ThreadTimer.NativeFieldInfoPtr_synchronizingObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, "synchronizingObject");
			ThreadTimer.NativeFieldInfoPtr_site = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, "site");
			ThreadTimer.NativeFieldInfoPtr_Disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, "Disposed");
			ThreadTimer.NativeFieldInfoPtr_Started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, "Started");
			ThreadTimer.NativeFieldInfoPtr_Stopped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, "Stopped");
			ThreadTimer.NativeFieldInfoPtr_Tick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, "Tick");
			ThreadTimer.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, "disposed");
			ThreadTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665825);
			ThreadTimer.NativeMethodInfoPtr__ctor_Private_Void_ThreadTimerQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665826);
			ThreadTimer.NativeMethodInfoPtr_DoTick_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665827);
			ThreadTimer.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665828);
			ThreadTimer.NativeMethodInfoPtr_get_Mode_Public_Virtual_Final_New_get_TimerMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665829);
			ThreadTimer.NativeMethodInfoPtr_set_Mode_Public_Virtual_Final_New_set_Void_TimerMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665830);
			ThreadTimer.NativeMethodInfoPtr_get_Period_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665831);
			ThreadTimer.NativeMethodInfoPtr_set_Period_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665832);
			ThreadTimer.NativeMethodInfoPtr_get_PeriodTimeSpan_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665833);
			ThreadTimer.NativeMethodInfoPtr_get_Resolution_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665834);
			ThreadTimer.NativeMethodInfoPtr_set_Resolution_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665835);
			ThreadTimer.NativeMethodInfoPtr_get_Site_Public_Virtual_Final_New_get_ISite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665836);
			ThreadTimer.NativeMethodInfoPtr_set_Site_Public_Virtual_Final_New_set_Void_ISite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665837);
			ThreadTimer.NativeMethodInfoPtr_get_SynchronizingObject_Public_Virtual_Final_New_get_ISynchronizeInvoke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665838);
			ThreadTimer.NativeMethodInfoPtr_set_SynchronizingObject_Public_Virtual_Final_New_set_Void_ISynchronizeInvoke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665839);
			ThreadTimer.NativeMethodInfoPtr_add_Disposed_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665840);
			ThreadTimer.NativeMethodInfoPtr_remove_Disposed_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665841);
			ThreadTimer.NativeMethodInfoPtr_add_Started_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665842);
			ThreadTimer.NativeMethodInfoPtr_remove_Started_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665843);
			ThreadTimer.NativeMethodInfoPtr_add_Stopped_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665844);
			ThreadTimer.NativeMethodInfoPtr_remove_Stopped_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665845);
			ThreadTimer.NativeMethodInfoPtr_add_Tick_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665846);
			ThreadTimer.NativeMethodInfoPtr_remove_Tick_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665847);
			ThreadTimer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665848);
			ThreadTimer.NativeMethodInfoPtr_OnDisposed_Private_Void_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665849);
			ThreadTimer.NativeMethodInfoPtr_OnStarted_Private_Void_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665850);
			ThreadTimer.NativeMethodInfoPtr_OnStopped_Private_Void_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665851);
			ThreadTimer.NativeMethodInfoPtr_OnTick_Private_Void_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665852);
			ThreadTimer.NativeMethodInfoPtr_Start_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665853);
			ThreadTimer.NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, 100665854);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0005498C File Offset: 0x00052B8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14236, RefRangeEnd = 14237, XrefRangeStart = 14213, XrefRangeEnd = 14236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadTimer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x000549C8 File Offset: 0x00052BC8
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadTimer(ThreadTimerQueue queue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(queue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr__ctor_Private_Void_ThreadTimerQueue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00054A14 File Offset: 0x00052C14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14326, RefRangeEnd = 14327, XrefRangeStart = 14316, XrefRangeEnd = 14326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_DoTick_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x00054A48 File Offset: 0x00052C48
		public unsafe bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x00054A84 File Offset: 0x00052C84
		// (set) Token: 0x06001189 RID: 4489 RVA: 0x00054AC0 File Offset: 0x00052CC0
		public unsafe TimerMode Mode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14327, RefRangeEnd = 14328, XrefRangeStart = 14327, XrefRangeEnd = 14327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_get_Mode_Public_Virtual_Final_New_get_TimerMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14328, XrefRangeEnd = 14330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_set_Mode_Public_Virtual_Final_New_set_Void_TimerMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x00054B00 File Offset: 0x00052D00
		// (set) Token: 0x0600118B RID: 4491 RVA: 0x00054B3C File Offset: 0x00052D3C
		public unsafe int Period
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_get_Period_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14330, XrefRangeEnd = 14340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_set_Period_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x00054B7C File Offset: 0x00052D7C
		public unsafe TimeSpan PeriodTimeSpan
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_get_PeriodTimeSpan_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x00054BB8 File Offset: 0x00052DB8
		// (set) Token: 0x0600118E RID: 4494 RVA: 0x00054BF4 File Offset: 0x00052DF4
		public unsafe int Resolution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_get_Resolution_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14340, XrefRangeEnd = 14348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_set_Resolution_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x00054C34 File Offset: 0x00052E34
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x00054C74 File Offset: 0x00052E74
		public unsafe ISite Site
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_get_Site_Public_Virtual_Final_New_get_ISite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_set_Site_Public_Virtual_Final_New_set_Void_ISite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x00054CB8 File Offset: 0x00052EB8
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x00054CF8 File Offset: 0x00052EF8
		public unsafe ISynchronizeInvoke SynchronizingObject
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 14348, RefRangeEnd = 14355, XrefRangeStart = 14348, XrefRangeEnd = 14348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_get_SynchronizingObject_Public_Virtual_Final_New_get_ISynchronizeInvoke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISynchronizeInvoke>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_set_SynchronizingObject_Public_Virtual_Final_New_set_Void_ISynchronizeInvoke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00054D3C File Offset: 0x00052F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14355, XrefRangeEnd = 14358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Disposed(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_add_Disposed_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00054D80 File Offset: 0x00052F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14358, XrefRangeEnd = 14361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Disposed(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_remove_Disposed_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00054DC4 File Offset: 0x00052FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14361, XrefRangeEnd = 14364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Started(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_add_Started_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00054E08 File Offset: 0x00053008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14364, XrefRangeEnd = 14367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Started(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_remove_Started_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00054E4C File Offset: 0x0005304C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14367, XrefRangeEnd = 14370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Stopped(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_add_Stopped_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00054E90 File Offset: 0x00053090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14370, XrefRangeEnd = 14373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Stopped(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_remove_Stopped_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00054ED4 File Offset: 0x000530D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14373, XrefRangeEnd = 14376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Tick(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_add_Tick_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00054F18 File Offset: 0x00053118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14376, XrefRangeEnd = 14379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Tick(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_remove_Tick_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00054F5C File Offset: 0x0005315C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14379, XrefRangeEnd = 14385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00054F90 File Offset: 0x00053190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14385, XrefRangeEnd = 14386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisposed(EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_OnDisposed_Private_Void_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00054FD4 File Offset: 0x000531D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14386, XrefRangeEnd = 14387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnStarted(EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_OnStarted_Private_Void_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00055018 File Offset: 0x00053218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14387, XrefRangeEnd = 14388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnStopped(EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_OnStopped_Private_Void_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0005505C File Offset: 0x0005325C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14388, XrefRangeEnd = 14389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTick(EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_OnTick_Private_Void_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x000550A0 File Offset: 0x000532A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 14411, RefRangeEnd = 14413, XrefRangeStart = 14389, XrefRangeEnd = 14411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_Start_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x000550D4 File Offset: 0x000532D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14435, RefRangeEnd = 14438, XrefRangeStart = 14413, XrefRangeEnd = 14435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x000072CF File Offset: 0x000054CF
		public ThreadTimer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x00055108 File Offset: 0x00053308
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x000072D8 File Offset: 0x000054D8
		public unsafe ThreadTimerQueue queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadTimerQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00055138 File Offset: 0x00053338
		// (set) Token: 0x060011A6 RID: 4518 RVA: 0x000072F7 File Offset: 0x000054F7
		public unsafe bool isRunning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_isRunning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_isRunning)) = value;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x00055160 File Offset: 0x00053360
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x00007312 File Offset: 0x00005512
		public unsafe TimerMode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x00055188 File Offset: 0x00053388
		// (set) Token: 0x060011AA RID: 4522 RVA: 0x0000732D File Offset: 0x0000552D
		public unsafe TimeSpan period
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_period);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_period)) = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x000551B0 File Offset: 0x000533B0
		// (set) Token: 0x060011AC RID: 4524 RVA: 0x00007348 File Offset: 0x00005548
		public unsafe TimeSpan resolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_resolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_resolution)) = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x000551D8 File Offset: 0x000533D8
		// (set) Token: 0x060011AE RID: 4526 RVA: 0x00007363 File Offset: 0x00005563
		public unsafe static Il2CppReferenceArray<Object> emptyArgs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadTimer.NativeFieldInfoPtr_emptyArgs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadTimer.NativeFieldInfoPtr_emptyArgs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x00055200 File Offset: 0x00053400
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x00007375 File Offset: 0x00005575
		public unsafe ThreadTimer.EventRaiser tickRaiser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_tickRaiser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadTimer.EventRaiser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_tickRaiser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x00055230 File Offset: 0x00053430
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x00007394 File Offset: 0x00005594
		public unsafe ISynchronizeInvoke synchronizingObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_synchronizingObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISynchronizeInvoke>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_synchronizingObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x00055260 File Offset: 0x00053460
		// (set) Token: 0x060011B4 RID: 4532 RVA: 0x000073B3 File Offset: 0x000055B3
		public unsafe ISite site
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_site);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_site), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x00055290 File Offset: 0x00053490
		// (set) Token: 0x060011B6 RID: 4534 RVA: 0x000073D2 File Offset: 0x000055D2
		public unsafe EventHandler Disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_Disposed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_Disposed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x000552C0 File Offset: 0x000534C0
		// (set) Token: 0x060011B8 RID: 4536 RVA: 0x000073F1 File Offset: 0x000055F1
		public unsafe EventHandler Started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_Started);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_Started), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x000552F0 File Offset: 0x000534F0
		// (set) Token: 0x060011BA RID: 4538 RVA: 0x00007410 File Offset: 0x00005610
		public unsafe EventHandler Stopped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_Stopped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_Stopped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x00055320 File Offset: 0x00053520
		// (set) Token: 0x060011BC RID: 4540 RVA: 0x0000742F File Offset: 0x0000562F
		public unsafe EventHandler Tick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_Tick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_Tick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x00055350 File Offset: 0x00053550
		// (set) Token: 0x060011BE RID: 4542 RVA: 0x0000744E File Offset: 0x0000564E
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimer.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeFieldInfoPtr_queue;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeFieldInfoPtr_isRunning;

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeFieldInfoPtr_period;

		// Token: 0x04001399 RID: 5017
		private static readonly IntPtr NativeFieldInfoPtr_resolution;

		// Token: 0x0400139A RID: 5018
		private static readonly IntPtr NativeFieldInfoPtr_emptyArgs;

		// Token: 0x0400139B RID: 5019
		private static readonly IntPtr NativeFieldInfoPtr_tickRaiser;

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeFieldInfoPtr_synchronizingObject;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeFieldInfoPtr_site;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeFieldInfoPtr_Disposed;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeFieldInfoPtr_Started;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeFieldInfoPtr_Stopped;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeFieldInfoPtr_Tick;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_ThreadTimerQueue_0;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeMethodInfoPtr_DoTick_Internal_Void_0;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_Virtual_Final_New_get_TimerMode_0;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeMethodInfoPtr_set_Mode_Public_Virtual_Final_New_set_Void_TimerMode_0;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeMethodInfoPtr_get_Period_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeMethodInfoPtr_set_Period_Public_Virtual_Final_New_set_Void_Int32_0;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeMethodInfoPtr_get_PeriodTimeSpan_Public_get_TimeSpan_0;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeMethodInfoPtr_get_Resolution_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeMethodInfoPtr_set_Resolution_Public_Virtual_Final_New_set_Void_Int32_0;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeMethodInfoPtr_get_Site_Public_Virtual_Final_New_get_ISite_0;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeMethodInfoPtr_set_Site_Public_Virtual_Final_New_set_Void_ISite_0;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizingObject_Public_Virtual_Final_New_get_ISynchronizeInvoke_0;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeMethodInfoPtr_set_SynchronizingObject_Public_Virtual_Final_New_set_Void_ISynchronizeInvoke_0;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeMethodInfoPtr_add_Disposed_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeMethodInfoPtr_remove_Disposed_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr_add_Started_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeMethodInfoPtr_remove_Started_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeMethodInfoPtr_add_Stopped_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeMethodInfoPtr_remove_Stopped_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeMethodInfoPtr_add_Tick_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeMethodInfoPtr_remove_Tick_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeMethodInfoPtr_OnDisposed_Private_Void_EventArgs_0;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeMethodInfoPtr_OnStarted_Private_Void_EventArgs_0;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeMethodInfoPtr_OnStopped_Private_Void_EventArgs_0;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Private_Void_EventArgs_0;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Final_New_Void_0;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_0;

		// Token: 0x02000242 RID: 578
		public sealed class EventRaiser : MulticastDelegate
		{
			// Token: 0x06001FD6 RID: 8150 RVA: 0x0008C41C File Offset: 0x0008A61C
			// Note: this type is marked as 'beforefieldinit'.
			static EventRaiser()
			{
				Il2CppClassPointerStore<ThreadTimer.EventRaiser>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadTimer>.NativeClassPtr, "EventRaiser");
				ThreadTimer.EventRaiser.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer.EventRaiser>.NativeClassPtr, 100665856);
				ThreadTimer.EventRaiser.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer.EventRaiser>.NativeClassPtr, 100665857);
				ThreadTimer.EventRaiser.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_EventArgs_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer.EventRaiser>.NativeClassPtr, 100665858);
				ThreadTimer.EventRaiser.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimer.EventRaiser>.NativeClassPtr, 100665859);
			}

			// Token: 0x06001FD7 RID: 8151 RVA: 0x0008C490 File Offset: 0x0008A690
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventRaiser(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadTimer.EventRaiser>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.EventRaiser.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FD8 RID: 8152 RVA: 0x0008C4EC File Offset: 0x0008A6EC
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 14114, RefRangeEnd = 14213, XrefRangeStart = 14114, XrefRangeEnd = 14114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(EventArgs e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.EventRaiser.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FD9 RID: 8153 RVA: 0x0008C530 File Offset: 0x0008A730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(EventArgs e, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.EventRaiser.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_EventArgs_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001FDA RID: 8154 RVA: 0x0008C5A4 File Offset: 0x0008A7A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimer.EventRaiser.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FDB RID: 8155 RVA: 0x0000BA27 File Offset: 0x00009C27
			public EventRaiser(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FDC RID: 8156 RVA: 0x0000BA30 File Offset: 0x00009C30
			public static implicit operator ThreadTimer.EventRaiser(Action<EventArgs> A_0)
			{
				return DelegateSupport.ConvertDelegate<ThreadTimer.EventRaiser>(A_0);
			}

			// Token: 0x06001FDD RID: 8157 RVA: 0x0000BA38 File Offset: 0x00009C38
			public static ThreadTimer.EventRaiser operator +(ThreadTimer.EventRaiser A_0, ThreadTimer.EventRaiser A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ThreadTimer.EventRaiser>();
			}

			// Token: 0x06001FDE RID: 8158 RVA: 0x0000BA46 File Offset: 0x00009C46
			public static ThreadTimer.EventRaiser operator -(ThreadTimer.EventRaiser A_0, ThreadTimer.EventRaiser A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ThreadTimer.EventRaiser>();
				}
				return delegate2;
			}

			// Token: 0x04002006 RID: 8198
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002007 RID: 8199
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_EventArgs_0;

			// Token: 0x04002008 RID: 8200
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_EventArgs_AsyncCallback_Object_0;

			// Token: 0x04002009 RID: 8201
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
