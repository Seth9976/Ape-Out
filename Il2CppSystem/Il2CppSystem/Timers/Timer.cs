using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Timers
{
	// Token: 0x02000048 RID: 72
	public class Timer : Component
	{
		// Token: 0x06000402 RID: 1026 RVA: 0x00020844 File Offset: 0x0001EA44
		// Note: this type is marked as 'beforefieldinit'.
		static Timer()
		{
			Il2CppClassPointerStore<Timer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Timers", "Timer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Timer>.NativeClassPtr);
			Timer.NativeFieldInfoPtr_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "interval");
			Timer.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "enabled");
			Timer.NativeFieldInfoPtr_initializing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "initializing");
			Timer.NativeFieldInfoPtr_delayedEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "delayedEnable");
			Timer.NativeFieldInfoPtr_onIntervalElapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "onIntervalElapsed");
			Timer.NativeFieldInfoPtr_autoReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "autoReset");
			Timer.NativeFieldInfoPtr_synchronizingObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "synchronizingObject");
			Timer.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "disposed");
			Timer.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "timer");
			Timer.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "callback");
			Timer.NativeFieldInfoPtr_cookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "cookie");
			Timer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100663994);
			Timer.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100663995);
			Timer.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100663996);
			Timer.NativeMethodInfoPtr_CalculateRoundedInterval_Private_Static_Int32_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100663997);
			Timer.NativeMethodInfoPtr_UpdateTimer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100663998);
			Timer.NativeMethodInfoPtr_get_Interval_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100663999);
			Timer.NativeMethodInfoPtr_set_Interval_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100664000);
			Timer.NativeMethodInfoPtr_add_Elapsed_Public_add_Void_ElapsedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100664001);
			Timer.NativeMethodInfoPtr_remove_Elapsed_Public_rem_Void_ElapsedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100664002);
			Timer.NativeMethodInfoPtr_get_SynchronizingObject_Public_get_ISynchronizeInvoke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100664003);
			Timer.NativeMethodInfoPtr_set_SynchronizingObject_Public_set_Void_ISynchronizeInvoke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100664004);
			Timer.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100664005);
			Timer.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100664006);
			Timer.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100664007);
			Timer.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100664008);
			Timer.NativeMethodInfoPtr_MyTimerCallback_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100664009);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00020A90 File Offset: 0x0001EC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369288, XrefRangeEnd = 369296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Timer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00020ACC File Offset: 0x0001ECCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369305, RefRangeEnd = 369307, XrefRangeStart = 369296, XrefRangeEnd = 369305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Timer(double interval)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref interval;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr__ctor_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000146 RID: 326
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00020B14 File Offset: 0x0001ED14
		public unsafe bool Enabled
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 369312, RefRangeEnd = 369316, XrefRangeStart = 369307, XrefRangeEnd = 369312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00020B54 File Offset: 0x0001ED54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 369320, RefRangeEnd = 369324, XrefRangeStart = 369316, XrefRangeEnd = 369320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CalculateRoundedInterval(double interval, bool argumentCheck = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref interval;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argumentCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_CalculateRoundedInterval_Private_Static_Int32_Double_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00020BA0 File Offset: 0x0001EDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369324, XrefRangeEnd = 369326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_UpdateTimer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00020BD4 File Offset: 0x0001EDD4
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00020C10 File Offset: 0x0001EE10
		public unsafe double Interval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_get_Interval_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369326, XrefRangeEnd = 369328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_set_Interval_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00020C50 File Offset: 0x0001EE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369328, XrefRangeEnd = 369331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Elapsed(ElapsedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_add_Elapsed_Public_add_Void_ElapsedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00020C94 File Offset: 0x0001EE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369331, XrefRangeEnd = 369334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Elapsed(ElapsedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_remove_Elapsed_Public_rem_Void_ElapsedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00020CD8 File Offset: 0x0001EED8
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00020D18 File Offset: 0x0001EF18
		public unsafe ISynchronizeInvoke SynchronizingObject
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 369354, RefRangeEnd = 369358, XrefRangeStart = 369334, XrefRangeEnd = 369354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_get_SynchronizingObject_Public_get_ISynchronizeInvoke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISynchronizeInvoke>(intPtr3) : null;
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14747, RefRangeEnd = 14763, XrefRangeStart = 14747, XrefRangeEnd = 14763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_set_SynchronizingObject_Public_set_Void_ISynchronizeInvoke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00020D5C File Offset: 0x0001EF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369358, XrefRangeEnd = 369359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00020D90 File Offset: 0x0001EF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369359, XrefRangeEnd = 369361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Timer.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00020DDC File Offset: 0x0001EFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369361, XrefRangeEnd = 369362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00020E10 File Offset: 0x0001F010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369362, XrefRangeEnd = 369363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00020E44 File Offset: 0x0001F044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369363, XrefRangeEnd = 369390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyTimerCallback(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_MyTimerCallback_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000362F File Offset: 0x0000182F
		public Timer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00020E88 File Offset: 0x0001F088
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00003638 File Offset: 0x00001838
		public unsafe double interval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_interval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_interval)) = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00020EB0 File Offset: 0x0001F0B0
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00003653 File Offset: 0x00001853
		public unsafe bool enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_enabled)) = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00020ED8 File Offset: 0x0001F0D8
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x0000366E File Offset: 0x0000186E
		public unsafe bool initializing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_initializing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_initializing)) = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00020F00 File Offset: 0x0001F100
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00003689 File Offset: 0x00001889
		public unsafe bool delayedEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_delayedEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_delayedEnable)) = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00020F28 File Offset: 0x0001F128
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x000036A4 File Offset: 0x000018A4
		public unsafe ElapsedEventHandler onIntervalElapsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_onIntervalElapsed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ElapsedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_onIntervalElapsed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00020F58 File Offset: 0x0001F158
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x000036C3 File Offset: 0x000018C3
		public unsafe bool autoReset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_autoReset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_autoReset)) = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00020F80 File Offset: 0x0001F180
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x000036DE File Offset: 0x000018DE
		public unsafe ISynchronizeInvoke synchronizingObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_synchronizingObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISynchronizeInvoke>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_synchronizingObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00020FB0 File Offset: 0x0001F1B0
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x000036FD File Offset: 0x000018FD
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

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00020FD8 File Offset: 0x0001F1D8
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00003718 File Offset: 0x00001918
		public unsafe Timer timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_timer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_timer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00021008 File Offset: 0x0001F208
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00003737 File Offset: 0x00001937
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

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00021038 File Offset: 0x0001F238
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00003756 File Offset: 0x00001956
		public unsafe Object cookie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_cookie);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_cookie), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeFieldInfoPtr_interval;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeFieldInfoPtr_enabled;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeFieldInfoPtr_initializing;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeFieldInfoPtr_delayedEnable;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeFieldInfoPtr_onIntervalElapsed;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeFieldInfoPtr_autoReset;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeFieldInfoPtr_synchronizingObject;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeFieldInfoPtr_cookie;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_CalculateRoundedInterval_Private_Static_Int32_Double_Boolean_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimer_Private_Void_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_get_Interval_Public_get_Double_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_set_Interval_Public_set_Void_Double_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_add_Elapsed_Public_add_Void_ElapsedEventHandler_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_remove_Elapsed_Public_rem_Void_ElapsedEventHandler_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizingObject_Public_get_ISynchronizeInvoke_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_set_SynchronizingObject_Public_set_Void_ISynchronizeInvoke_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_MyTimerCallback_Private_Void_Object_0;
	}
}
