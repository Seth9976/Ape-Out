using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x02000109 RID: 265
	public static class TimerThread : Object
	{
		// Token: 0x06000E7E RID: 3710 RVA: 0x0004733C File Offset: 0x0004553C
		// Note: this type is marked as 'beforefieldinit'.
		static TimerThread()
		{
			Il2CppClassPointerStore<TimerThread>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "TimerThread");
			TimerThread.NativeFieldInfoPtr_s_Queues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_Queues");
			TimerThread.NativeFieldInfoPtr_s_NewQueues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_NewQueues");
			TimerThread.NativeFieldInfoPtr_s_ThreadState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_ThreadState");
			TimerThread.NativeFieldInfoPtr_s_ThreadReadyEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_ThreadReadyEvent");
			TimerThread.NativeFieldInfoPtr_s_ThreadShutdownEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_ThreadShutdownEvent");
			TimerThread.NativeFieldInfoPtr_s_ThreadEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_ThreadEvents");
			TimerThread.NativeFieldInfoPtr_s_QueuesCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_QueuesCache");
			TimerThread.NativeMethodInfoPtr_CreateQueue_Internal_Static_Queue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, 100665383);
			TimerThread.NativeMethodInfoPtr_StopTimerThread_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, 100665384);
			TimerThread.NativeMethodInfoPtr_OnDomainUnload_Private_Static_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, 100665385);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x0004742C File Offset: 0x0004562C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378225, RefRangeEnd = 378226, XrefRangeStart = 378201, XrefRangeEnd = 378225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimerThread.Queue CreateQueue(int durationMilliseconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref durationMilliseconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.NativeMethodInfoPtr_CreateQueue_Internal_Static_Queue_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerThread.Queue>(intPtr3) : null;
			}
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0004746C File Offset: 0x0004566C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378226, XrefRangeEnd = 378232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopTimerThread()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.NativeMethodInfoPtr_StopTimerThread_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00047494 File Offset: 0x00045694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378232, XrefRangeEnd = 378243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnDomainUnload(Object sender, EventArgs e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.NativeMethodInfoPtr_OnDomainUnload_Private_Static_Void_Object_EventArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00007A95 File Offset: 0x00005C95
		public TimerThread(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x000474DC File Offset: 0x000456DC
		// (set) Token: 0x06000E84 RID: 3716 RVA: 0x00007A9E File Offset: 0x00005C9E
		public unsafe static LinkedList<WeakReference> s_Queues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_Queues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<WeakReference>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_Queues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x00047504 File Offset: 0x00045704
		// (set) Token: 0x06000E86 RID: 3718 RVA: 0x00007AB0 File Offset: 0x00005CB0
		public unsafe static LinkedList<WeakReference> s_NewQueues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_NewQueues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<WeakReference>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_NewQueues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x0004752C File Offset: 0x0004572C
		// (set) Token: 0x06000E88 RID: 3720 RVA: 0x00007AC2 File Offset: 0x00005CC2
		public unsafe static int s_ThreadState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_ThreadState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_ThreadState, (void*)(&value));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x00047548 File Offset: 0x00045748
		// (set) Token: 0x06000E8A RID: 3722 RVA: 0x00007AD0 File Offset: 0x00005CD0
		public unsafe static AutoResetEvent s_ThreadReadyEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_ThreadReadyEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoResetEvent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_ThreadReadyEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x00047570 File Offset: 0x00045770
		// (set) Token: 0x06000E8C RID: 3724 RVA: 0x00007AE2 File Offset: 0x00005CE2
		public unsafe static ManualResetEvent s_ThreadShutdownEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_ThreadShutdownEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_ThreadShutdownEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x00047598 File Offset: 0x00045798
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x00007AF4 File Offset: 0x00005CF4
		public unsafe static Il2CppReferenceArray<WaitHandle> s_ThreadEvents
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_ThreadEvents, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WaitHandle>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_ThreadEvents, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x000475C0 File Offset: 0x000457C0
		// (set) Token: 0x06000E90 RID: 3728 RVA: 0x00007B06 File Offset: 0x00005D06
		public unsafe static Hashtable s_QueuesCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_QueuesCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_QueuesCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeFieldInfoPtr_s_Queues;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeFieldInfoPtr_s_NewQueues;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeFieldInfoPtr_s_ThreadState;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeFieldInfoPtr_s_ThreadReadyEvent;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeFieldInfoPtr_s_ThreadShutdownEvent;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeFieldInfoPtr_s_ThreadEvents;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeFieldInfoPtr_s_QueuesCache;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_CreateQueue_Internal_Static_Queue_Int32_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_StopTimerThread_Private_Static_Void_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_OnDomainUnload_Private_Static_Void_Object_EventArgs_0;

		// Token: 0x020001D4 RID: 468
		public class Queue : Object
		{
			// Token: 0x060019F2 RID: 6642 RVA: 0x0006F14C File Offset: 0x0006D34C
			// Note: this type is marked as 'beforefieldinit'.
			static Queue()
			{
				Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "Queue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr);
				TimerThread.Queue.NativeFieldInfoPtr_m_DurationMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr, "m_DurationMilliseconds");
				TimerThread.Queue.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr, 100665386);
			}

			// Token: 0x060019F3 RID: 6643 RVA: 0x0006F1A0 File Offset: 0x0006D3A0
			[CallerCount(0)]
			public unsafe Queue(int durationMilliseconds)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref durationMilliseconds;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Queue.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019F4 RID: 6644 RVA: 0x0000D509 File Offset: 0x0000B709
			public Queue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000846 RID: 2118
			// (get) Token: 0x060019F5 RID: 6645 RVA: 0x0006F1E8 File Offset: 0x0006D3E8
			// (set) Token: 0x060019F6 RID: 6646 RVA: 0x0000D512 File Offset: 0x0000B712
			public unsafe int m_DurationMilliseconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Queue.NativeFieldInfoPtr_m_DurationMilliseconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Queue.NativeFieldInfoPtr_m_DurationMilliseconds)) = value;
				}
			}

			// Token: 0x04001471 RID: 5233
			private static readonly IntPtr NativeFieldInfoPtr_m_DurationMilliseconds;

			// Token: 0x04001472 RID: 5234
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;
		}

		// Token: 0x020001D5 RID: 469
		public class Timer : Object
		{
			// Token: 0x060019F7 RID: 6647 RVA: 0x0006F210 File Offset: 0x0006D410
			// Note: this type is marked as 'beforefieldinit'.
			static Timer()
			{
				Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "Timer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr);
				TimerThread.Timer.NativeFieldInfoPtr_m_StartTimeMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, "m_StartTimeMilliseconds");
				TimerThread.Timer.NativeFieldInfoPtr_m_DurationMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, "m_DurationMilliseconds");
				TimerThread.Timer.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, 100665387);
				TimerThread.Timer.NativeMethodInfoPtr_Cancel_Internal_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, 100665388);
				TimerThread.Timer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, 100665389);
			}

			// Token: 0x060019F8 RID: 6648 RVA: 0x0006F2A0 File Offset: 0x0006D4A0
			[CallerCount(0)]
			public unsafe Timer(int durationMilliseconds)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref durationMilliseconds;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Timer.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019F9 RID: 6649 RVA: 0x0006F2E8 File Offset: 0x0006D4E8
			[CallerCount(0)]
			public unsafe virtual bool Cancel()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimerThread.Timer.NativeMethodInfoPtr_Cancel_Internal_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060019FA RID: 6650 RVA: 0x0006F330 File Offset: 0x0006D530
			[CallerCount(0)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Timer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019FB RID: 6651 RVA: 0x0000D52D File Offset: 0x0000B72D
			public Timer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000847 RID: 2119
			// (get) Token: 0x060019FC RID: 6652 RVA: 0x0006F364 File Offset: 0x0006D564
			// (set) Token: 0x060019FD RID: 6653 RVA: 0x0000D536 File Offset: 0x0000B736
			public unsafe int m_StartTimeMilliseconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Timer.NativeFieldInfoPtr_m_StartTimeMilliseconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Timer.NativeFieldInfoPtr_m_StartTimeMilliseconds)) = value;
				}
			}

			// Token: 0x17000848 RID: 2120
			// (get) Token: 0x060019FE RID: 6654 RVA: 0x0006F38C File Offset: 0x0006D58C
			// (set) Token: 0x060019FF RID: 6655 RVA: 0x0000D551 File Offset: 0x0000B751
			public unsafe int m_DurationMilliseconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Timer.NativeFieldInfoPtr_m_DurationMilliseconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Timer.NativeFieldInfoPtr_m_DurationMilliseconds)) = value;
				}
			}

			// Token: 0x04001473 RID: 5235
			private static readonly IntPtr NativeFieldInfoPtr_m_StartTimeMilliseconds;

			// Token: 0x04001474 RID: 5236
			private static readonly IntPtr NativeFieldInfoPtr_m_DurationMilliseconds;

			// Token: 0x04001475 RID: 5237
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x04001476 RID: 5238
			private static readonly IntPtr NativeMethodInfoPtr_Cancel_Internal_Abstract_Virtual_New_Boolean_0;

			// Token: 0x04001477 RID: 5239
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x020001D6 RID: 470
		public sealed class Callback : MulticastDelegate
		{
			// Token: 0x06001A00 RID: 6656 RVA: 0x0006F3B4 File Offset: 0x0006D5B4
			// Note: this type is marked as 'beforefieldinit'.
			static Callback()
			{
				Il2CppClassPointerStore<TimerThread.Callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "Callback");
				TimerThread.Callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Callback>.NativeClassPtr, 100665390);
				TimerThread.Callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Timer_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Callback>.NativeClassPtr, 100665391);
				TimerThread.Callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Timer_Int32_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Callback>.NativeClassPtr, 100665392);
				TimerThread.Callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Callback>.NativeClassPtr, 100665393);
			}

			// Token: 0x06001A01 RID: 6657 RVA: 0x0006F428 File Offset: 0x0006D628
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.Callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A02 RID: 6658 RVA: 0x0006F484 File Offset: 0x0006D684
			[CallerCount(0)]
			public unsafe void Invoke(TimerThread.Timer timer, int timeNoticed, Object context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeNoticed;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Timer_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A03 RID: 6659 RVA: 0x0006F4E8 File Offset: 0x0006D6E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378186, XrefRangeEnd = 378190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(TimerThread.Timer timer, int timeNoticed, Object context, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeNoticed;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Callback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Timer_Int32_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001A04 RID: 6660 RVA: 0x0006F580 File Offset: 0x0006D780
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Callback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A05 RID: 6661 RVA: 0x0000D56C File Offset: 0x0000B76C
			public Callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001A06 RID: 6662 RVA: 0x0000D575 File Offset: 0x0000B775
			public static implicit operator TimerThread.Callback(Action<TimerThread.Timer, int, Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<TimerThread.Callback>(A_0);
			}

			// Token: 0x06001A07 RID: 6663 RVA: 0x0000D57D File Offset: 0x0000B77D
			public static TimerThread.Callback operator +(TimerThread.Callback A_0, TimerThread.Callback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TimerThread.Callback>();
			}

			// Token: 0x06001A08 RID: 6664 RVA: 0x0000D58B File Offset: 0x0000B78B
			public static TimerThread.Callback operator -(TimerThread.Callback A_0, TimerThread.Callback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<TimerThread.Callback>();
				}
				return delegate2;
			}

			// Token: 0x04001478 RID: 5240
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001479 RID: 5241
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Timer_Int32_Object_0;

			// Token: 0x0400147A RID: 5242
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Timer_Int32_Object_AsyncCallback_Object_0;

			// Token: 0x0400147B RID: 5243
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001D7 RID: 471
		public class TimerQueue : TimerThread.Queue
		{
			// Token: 0x06001A09 RID: 6665 RVA: 0x0006F5C4 File Offset: 0x0006D7C4
			// Note: this type is marked as 'beforefieldinit'.
			static TimerQueue()
			{
				Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "TimerQueue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr);
				TimerThread.TimerQueue.NativeFieldInfoPtr_m_Timers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr, "m_Timers");
				TimerThread.TimerQueue.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr, 100665394);
			}

			// Token: 0x06001A0A RID: 6666 RVA: 0x0006F618 File Offset: 0x0006D818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378190, XrefRangeEnd = 378193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimerQueue(int durationMilliseconds)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref durationMilliseconds;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerQueue.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A0B RID: 6667 RVA: 0x0000D59C File Offset: 0x0000B79C
			public TimerQueue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000849 RID: 2121
			// (get) Token: 0x06001A0C RID: 6668 RVA: 0x0006F660 File Offset: 0x0006D860
			// (set) Token: 0x06001A0D RID: 6669 RVA: 0x0000D5A5 File Offset: 0x0000B7A5
			public unsafe TimerThread.TimerNode m_Timers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerQueue.NativeFieldInfoPtr_m_Timers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.TimerNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerQueue.NativeFieldInfoPtr_m_Timers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400147C RID: 5244
			private static readonly IntPtr NativeFieldInfoPtr_m_Timers;

			// Token: 0x0400147D RID: 5245
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;
		}

		// Token: 0x020001D8 RID: 472
		public class InfiniteTimerQueue : TimerThread.Queue
		{
			// Token: 0x06001A0E RID: 6670 RVA: 0x0000D5C4 File Offset: 0x0000B7C4
			// Note: this type is marked as 'beforefieldinit'.
			static InfiniteTimerQueue()
			{
				Il2CppClassPointerStore<TimerThread.InfiniteTimerQueue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "InfiniteTimerQueue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerThread.InfiniteTimerQueue>.NativeClassPtr);
				TimerThread.InfiniteTimerQueue.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.InfiniteTimerQueue>.NativeClassPtr, 100665395);
			}

			// Token: 0x06001A0F RID: 6671 RVA: 0x0006F690 File Offset: 0x0006D890
			[CallerCount(0)]
			public unsafe InfiniteTimerQueue()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.InfiniteTimerQueue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.InfiniteTimerQueue.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A10 RID: 6672 RVA: 0x0000D5F8 File Offset: 0x0000B7F8
			public InfiniteTimerQueue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400147E RID: 5246
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
		}

		// Token: 0x020001D9 RID: 473
		public class TimerNode : TimerThread.Timer
		{
			// Token: 0x06001A11 RID: 6673 RVA: 0x0006F6CC File Offset: 0x0006D8CC
			// Note: this type is marked as 'beforefieldinit'.
			static TimerNode()
			{
				Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "TimerNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr);
				TimerThread.TimerNode.NativeFieldInfoPtr_m_TimerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "m_TimerState");
				TimerThread.TimerNode.NativeFieldInfoPtr_m_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "m_Callback");
				TimerThread.TimerNode.NativeFieldInfoPtr_m_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "m_Context");
				TimerThread.TimerNode.NativeFieldInfoPtr_m_QueueLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "m_QueueLock");
				TimerThread.TimerNode.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "next");
				TimerThread.TimerNode.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "prev");
				TimerThread.TimerNode.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100665396);
				TimerThread.TimerNode.NativeMethodInfoPtr_get_Next_Internal_get_TimerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100665397);
				TimerThread.TimerNode.NativeMethodInfoPtr_set_Next_Internal_set_Void_TimerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100665398);
				TimerThread.TimerNode.NativeMethodInfoPtr_get_Prev_Internal_get_TimerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100665399);
				TimerThread.TimerNode.NativeMethodInfoPtr_set_Prev_Internal_set_Void_TimerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100665400);
				TimerThread.TimerNode.NativeMethodInfoPtr_Cancel_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100665401);
			}

			// Token: 0x06001A12 RID: 6674 RVA: 0x0006F7E8 File Offset: 0x0006D9E8
			[CallerCount(0)]
			public unsafe TimerNode()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000850 RID: 2128
			// (get) Token: 0x06001A13 RID: 6675 RVA: 0x0006F824 File Offset: 0x0006DA24
			// (set) Token: 0x06001A14 RID: 6676 RVA: 0x0006F864 File Offset: 0x0006DA64
			public unsafe TimerThread.TimerNode Next
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr_get_Next_Internal_get_TimerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerThread.TimerNode>(intPtr3) : null;
				}
				[CallerCount(23)]
				[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr_set_Next_Internal_set_Void_TimerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000851 RID: 2129
			// (get) Token: 0x06001A15 RID: 6677 RVA: 0x0006F8A8 File Offset: 0x0006DAA8
			// (set) Token: 0x06001A16 RID: 6678 RVA: 0x0006F8E8 File Offset: 0x0006DAE8
			public unsafe TimerThread.TimerNode Prev
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr_get_Prev_Internal_get_TimerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerThread.TimerNode>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr_set_Prev_Internal_set_Void_TimerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06001A17 RID: 6679 RVA: 0x0006F92C File Offset: 0x0006DB2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378193, XrefRangeEnd = 378201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Cancel()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimerThread.TimerNode.NativeMethodInfoPtr_Cancel_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001A18 RID: 6680 RVA: 0x0000D601 File Offset: 0x0000B801
			public TimerNode(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700084A RID: 2122
			// (get) Token: 0x06001A19 RID: 6681 RVA: 0x0006F974 File Offset: 0x0006DB74
			// (set) Token: 0x06001A1A RID: 6682 RVA: 0x0000D60A File Offset: 0x0000B80A
			public unsafe TimerThread.TimerNode.TimerState m_TimerState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_TimerState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_TimerState)) = value;
				}
			}

			// Token: 0x1700084B RID: 2123
			// (get) Token: 0x06001A1B RID: 6683 RVA: 0x0006F99C File Offset: 0x0006DB9C
			// (set) Token: 0x06001A1C RID: 6684 RVA: 0x0000D625 File Offset: 0x0000B825
			public unsafe TimerThread.Callback m_Callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_Callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.Callback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700084C RID: 2124
			// (get) Token: 0x06001A1D RID: 6685 RVA: 0x0006F9CC File Offset: 0x0006DBCC
			// (set) Token: 0x06001A1E RID: 6686 RVA: 0x0000D644 File Offset: 0x0000B844
			public unsafe Object m_Context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_Context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_Context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700084D RID: 2125
			// (get) Token: 0x06001A1F RID: 6687 RVA: 0x0006F9FC File Offset: 0x0006DBFC
			// (set) Token: 0x06001A20 RID: 6688 RVA: 0x0000D663 File Offset: 0x0000B863
			public unsafe Object m_QueueLock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_QueueLock);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_QueueLock), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700084E RID: 2126
			// (get) Token: 0x06001A21 RID: 6689 RVA: 0x0006FA2C File Offset: 0x0006DC2C
			// (set) Token: 0x06001A22 RID: 6690 RVA: 0x0000D682 File Offset: 0x0000B882
			public unsafe TimerThread.TimerNode next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.TimerNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700084F RID: 2127
			// (get) Token: 0x06001A23 RID: 6691 RVA: 0x0006FA5C File Offset: 0x0006DC5C
			// (set) Token: 0x06001A24 RID: 6692 RVA: 0x0000D6A1 File Offset: 0x0000B8A1
			public unsafe TimerThread.TimerNode prev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_prev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.TimerNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_prev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400147F RID: 5247
			private static readonly IntPtr NativeFieldInfoPtr_m_TimerState;

			// Token: 0x04001480 RID: 5248
			private static readonly IntPtr NativeFieldInfoPtr_m_Callback;

			// Token: 0x04001481 RID: 5249
			private static readonly IntPtr NativeFieldInfoPtr_m_Context;

			// Token: 0x04001482 RID: 5250
			private static readonly IntPtr NativeFieldInfoPtr_m_QueueLock;

			// Token: 0x04001483 RID: 5251
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x04001484 RID: 5252
			private static readonly IntPtr NativeFieldInfoPtr_prev;

			// Token: 0x04001485 RID: 5253
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04001486 RID: 5254
			private static readonly IntPtr NativeMethodInfoPtr_get_Next_Internal_get_TimerNode_0;

			// Token: 0x04001487 RID: 5255
			private static readonly IntPtr NativeMethodInfoPtr_set_Next_Internal_set_Void_TimerNode_0;

			// Token: 0x04001488 RID: 5256
			private static readonly IntPtr NativeMethodInfoPtr_get_Prev_Internal_get_TimerNode_0;

			// Token: 0x04001489 RID: 5257
			private static readonly IntPtr NativeMethodInfoPtr_set_Prev_Internal_set_Void_TimerNode_0;

			// Token: 0x0400148A RID: 5258
			private static readonly IntPtr NativeMethodInfoPtr_Cancel_Internal_Virtual_Boolean_0;

			// Token: 0x0200023D RID: 573
			[OriginalName("System.dll", "", "TimerState")]
			public enum TimerState
			{
				// Token: 0x040016E8 RID: 5864
				Ready,
				// Token: 0x040016E9 RID: 5865
				Fired,
				// Token: 0x040016EA RID: 5866
				Cancelled,
				// Token: 0x040016EB RID: 5867
				Sentinel
			}
		}
	}
}
