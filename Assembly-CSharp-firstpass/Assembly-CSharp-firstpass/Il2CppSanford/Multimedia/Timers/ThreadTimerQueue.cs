using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;
using Il2CppSystem.Threading;

namespace Il2CppSanford.Multimedia.Timers
{
	// Token: 0x02000187 RID: 391
	public class ThreadTimerQueue : Object
	{
		// Token: 0x060011BF RID: 4543 RVA: 0x00055378 File Offset: 0x00053578
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadTimerQueue()
		{
			Il2CppClassPointerStore<ThreadTimerQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Timers", "ThreadTimerQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadTimerQueue>.NativeClassPtr);
			ThreadTimerQueue.NativeFieldInfoPtr_watch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimerQueue>.NativeClassPtr, "watch");
			ThreadTimerQueue.NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimerQueue>.NativeClassPtr, "loop");
			ThreadTimerQueue.NativeFieldInfoPtr_tickQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimerQueue>.NativeClassPtr, "tickQueue");
			ThreadTimerQueue.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimerQueue>.NativeClassPtr, "instance");
			ThreadTimerQueue.NativeMethodInfoPtr_get_Instance_Public_Static_get_ThreadTimerQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimerQueue>.NativeClassPtr, 100665860);
			ThreadTimerQueue.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimerQueue>.NativeClassPtr, 100665861);
			ThreadTimerQueue.NativeMethodInfoPtr_Add_Public_Void_ThreadTimer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimerQueue>.NativeClassPtr, 100665862);
			ThreadTimerQueue.NativeMethodInfoPtr_Remove_Public_Void_ThreadTimer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimerQueue>.NativeClassPtr, 100665863);
			ThreadTimerQueue.NativeMethodInfoPtr_Min_Private_Static_TimeSpan_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimerQueue>.NativeClassPtr, 100665864);
			ThreadTimerQueue.NativeMethodInfoPtr_TimerLoop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimerQueue>.NativeClassPtr, 100665865);
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x00055470 File Offset: 0x00053670
		public unsafe static ThreadTimerQueue Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14440, XrefRangeEnd = 14446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimerQueue.NativeMethodInfoPtr_get_Instance_Public_Static_get_ThreadTimerQueue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThreadTimerQueue>(intPtr3) : null;
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x000554A4 File Offset: 0x000536A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 14463, RefRangeEnd = 14465, XrefRangeStart = 14446, XrefRangeEnd = 14463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadTimerQueue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadTimerQueue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimerQueue.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x000554E0 File Offset: 0x000536E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14488, RefRangeEnd = 14489, XrefRangeStart = 14465, XrefRangeEnd = 14488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(ThreadTimer timer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimerQueue.NativeMethodInfoPtr_Add_Public_Void_ThreadTimer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00055524 File Offset: 0x00053724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14499, RefRangeEnd = 14500, XrefRangeStart = 14489, XrefRangeEnd = 14499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(ThreadTimer timer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimerQueue.NativeMethodInfoPtr_Remove_Public_Void_ThreadTimer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00055568 File Offset: 0x00053768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14503, RefRangeEnd = 14504, XrefRangeStart = 14500, XrefRangeEnd = 14503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan Min(TimeSpan x0, TimeSpan x1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimerQueue.NativeMethodInfoPtr_Min_Private_Static_TimeSpan_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x000555B4 File Offset: 0x000537B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14504, XrefRangeEnd = 14540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TimerLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimerQueue.NativeMethodInfoPtr_TimerLoop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00007469 File Offset: 0x00005669
		public ThreadTimerQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x060011C7 RID: 4551 RVA: 0x000555E8 File Offset: 0x000537E8
		// (set) Token: 0x060011C8 RID: 4552 RVA: 0x00007472 File Offset: 0x00005672
		public unsafe Stopwatch watch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimerQueue.NativeFieldInfoPtr_watch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimerQueue.NativeFieldInfoPtr_watch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x00055618 File Offset: 0x00053818
		// (set) Token: 0x060011CA RID: 4554 RVA: 0x00007491 File Offset: 0x00005691
		public unsafe Thread loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimerQueue.NativeFieldInfoPtr_loop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimerQueue.NativeFieldInfoPtr_loop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x00055648 File Offset: 0x00053848
		// (set) Token: 0x060011CC RID: 4556 RVA: 0x000074B0 File Offset: 0x000056B0
		public unsafe List<ThreadTimerQueue.Tick> tickQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimerQueue.NativeFieldInfoPtr_tickQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ThreadTimerQueue.Tick>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimerQueue.NativeFieldInfoPtr_tickQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x00055678 File Offset: 0x00053878
		// (set) Token: 0x060011CE RID: 4558 RVA: 0x000074CF File Offset: 0x000056CF
		public unsafe static ThreadTimerQueue instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadTimerQueue.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadTimerQueue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadTimerQueue.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeFieldInfoPtr_watch;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeFieldInfoPtr_loop;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeFieldInfoPtr_tickQueue;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_ThreadTimerQueue_0;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_ThreadTimer_0;

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_ThreadTimer_0;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeMethodInfoPtr_Min_Private_Static_TimeSpan_TimeSpan_TimeSpan_0;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeMethodInfoPtr_TimerLoop_Private_Void_0;

		// Token: 0x02000243 RID: 579
		public class Tick : Object
		{
			// Token: 0x06001FDF RID: 8159 RVA: 0x0008C5E8 File Offset: 0x0008A7E8
			// Note: this type is marked as 'beforefieldinit'.
			static Tick()
			{
				Il2CppClassPointerStore<ThreadTimerQueue.Tick>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadTimerQueue>.NativeClassPtr, "Tick");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadTimerQueue.Tick>.NativeClassPtr);
				ThreadTimerQueue.Tick.NativeFieldInfoPtr_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimerQueue.Tick>.NativeClassPtr, "Timer");
				ThreadTimerQueue.Tick.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadTimerQueue.Tick>.NativeClassPtr, "Time");
				ThreadTimerQueue.Tick.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimerQueue.Tick>.NativeClassPtr, 100665866);
				ThreadTimerQueue.Tick.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadTimerQueue.Tick>.NativeClassPtr, 100665867);
			}

			// Token: 0x06001FE0 RID: 8160 RVA: 0x0008C664 File Offset: 0x0008A864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14438, XrefRangeEnd = 14440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int CompareTo(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimerQueue.Tick.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001FE1 RID: 8161 RVA: 0x0008C6B4 File Offset: 0x0008A8B4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Tick()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadTimerQueue.Tick>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadTimerQueue.Tick.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FE2 RID: 8162 RVA: 0x0000BA57 File Offset: 0x00009C57
			public Tick(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000647 RID: 1607
			// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x0008C6F0 File Offset: 0x0008A8F0
			// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x0000BA60 File Offset: 0x00009C60
			public unsafe ThreadTimer Timer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimerQueue.Tick.NativeFieldInfoPtr_Timer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadTimer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimerQueue.Tick.NativeFieldInfoPtr_Timer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000648 RID: 1608
			// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x0008C720 File Offset: 0x0008A920
			// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x0000BA7F File Offset: 0x00009C7F
			public unsafe TimeSpan Time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimerQueue.Tick.NativeFieldInfoPtr_Time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadTimerQueue.Tick.NativeFieldInfoPtr_Time)) = value;
				}
			}

			// Token: 0x0400200A RID: 8202
			private static readonly IntPtr NativeFieldInfoPtr_Timer;

			// Token: 0x0400200B RID: 8203
			private static readonly IntPtr NativeFieldInfoPtr_Time;

			// Token: 0x0400200C RID: 8204
			private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

			// Token: 0x0400200D RID: 8205
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
