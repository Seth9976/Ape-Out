using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000286 RID: 646
	public sealed class ThreadPoolWorkQueue : Object
	{
		// Token: 0x06002C84 RID: 11396 RVA: 0x000E5CA0 File Offset: 0x000E3EA0
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPoolWorkQueue()
		{
			Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadPoolWorkQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr);
			ThreadPoolWorkQueue.NativeFieldInfoPtr_queueHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "queueHead");
			ThreadPoolWorkQueue.NativeFieldInfoPtr_queueTail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "queueTail");
			ThreadPoolWorkQueue.NativeFieldInfoPtr_allThreadQueues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "allThreadQueues");
			ThreadPoolWorkQueue.NativeFieldInfoPtr_numOutstandingThreadRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "numOutstandingThreadRequests");
			ThreadPoolWorkQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100670433);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_EnsureCurrentThreadHasQueue_Public_ThreadPoolWorkQueueThreadLocals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100670434);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_EnsureThreadRequested_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100670435);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_MarkThreadRequestSatisfied_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100670436);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_Enqueue_Public_Void_IThreadPoolWorkItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100670437);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_LocalFindAndPop_Internal_Boolean_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100670438);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_Dequeue_Public_Void_ThreadPoolWorkQueueThreadLocals_byref_IThreadPoolWorkItem_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100670439);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_Dispatch_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100670440);
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x000E5DC0 File Offset: 0x000E3FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204261, XrefRangeEnd = 204265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadPoolWorkQueue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x000E5DFC File Offset: 0x000E3FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204265, XrefRangeEnd = 204275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_EnsureCurrentThreadHasQueue_Public_ThreadPoolWorkQueueThreadLocals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueueThreadLocals>(intPtr3) : null;
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x000E5E3C File Offset: 0x000E403C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204282, RefRangeEnd = 204285, XrefRangeStart = 204275, XrefRangeEnd = 204282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureThreadRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_EnsureThreadRequested_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x000E5E70 File Offset: 0x000E4070
		[CallerCount(0)]
		public unsafe void MarkThreadRequestSatisfied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_MarkThreadRequestSatisfied_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x000E5EA4 File Offset: 0x000E40A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204301, RefRangeEnd = 204304, XrefRangeStart = 204285, XrefRangeEnd = 204301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceGlobal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_Enqueue_Public_Void_IThreadPoolWorkItem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x000E5EF4 File Offset: 0x000E40F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204304, XrefRangeEnd = 204308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LocalFindAndPop(IThreadPoolWorkItem callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_LocalFindAndPop_Internal_Boolean_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x000E5F44 File Offset: 0x000E4144
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204317, RefRangeEnd = 204318, XrefRangeStart = 204308, XrefRangeEnd = 204317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tl);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &missedSteal;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_Dequeue_Public_Void_ThreadPoolWorkQueueThreadLocals_byref_IThreadPoolWorkItem_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			callback = ((intPtr4 == 0) ? null : new IThreadPoolWorkItem(intPtr4));
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x000E5FB8 File Offset: 0x000E41B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204352, RefRangeEnd = 204353, XrefRangeStart = 204318, XrefRangeEnd = 204352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Dispatch()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_Dispatch_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x0000F532 File Offset: 0x0000D732
		public ThreadPoolWorkQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06002C8E RID: 11406 RVA: 0x000E5FE8 File Offset: 0x000E41E8
		// (set) Token: 0x06002C8F RID: 11407 RVA: 0x0000F53B File Offset: 0x0000D73B
		public unsafe ThreadPoolWorkQueue.QueueSegment queueHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_queueHead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue.QueueSegment>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_queueHead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06002C90 RID: 11408 RVA: 0x000E6018 File Offset: 0x000E4218
		// (set) Token: 0x06002C91 RID: 11409 RVA: 0x0000F55A File Offset: 0x0000D75A
		public unsafe ThreadPoolWorkQueue.QueueSegment queueTail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_queueTail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue.QueueSegment>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_queueTail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06002C92 RID: 11410 RVA: 0x000E6048 File Offset: 0x000E4248
		// (set) Token: 0x06002C93 RID: 11411 RVA: 0x0000F579 File Offset: 0x0000D779
		public unsafe static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolWorkQueue.NativeFieldInfoPtr_allThreadQueues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolWorkQueue.NativeFieldInfoPtr_allThreadQueues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06002C94 RID: 11412 RVA: 0x000E6070 File Offset: 0x000E4270
		// (set) Token: 0x06002C95 RID: 11413 RVA: 0x0000F58B File Offset: 0x0000D78B
		public unsafe int numOutstandingThreadRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_numOutstandingThreadRequests);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_numOutstandingThreadRequests)) = value;
			}
		}

		// Token: 0x040026C7 RID: 9927
		private static readonly IntPtr NativeFieldInfoPtr_queueHead;

		// Token: 0x040026C8 RID: 9928
		private static readonly IntPtr NativeFieldInfoPtr_queueTail;

		// Token: 0x040026C9 RID: 9929
		private static readonly IntPtr NativeFieldInfoPtr_allThreadQueues;

		// Token: 0x040026CA RID: 9930
		private static readonly IntPtr NativeFieldInfoPtr_numOutstandingThreadRequests;

		// Token: 0x040026CB RID: 9931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040026CC RID: 9932
		private static readonly IntPtr NativeMethodInfoPtr_EnsureCurrentThreadHasQueue_Public_ThreadPoolWorkQueueThreadLocals_0;

		// Token: 0x040026CD RID: 9933
		private static readonly IntPtr NativeMethodInfoPtr_EnsureThreadRequested_Internal_Void_0;

		// Token: 0x040026CE RID: 9934
		private static readonly IntPtr NativeMethodInfoPtr_MarkThreadRequestSatisfied_Internal_Void_0;

		// Token: 0x040026CF RID: 9935
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_IThreadPoolWorkItem_Boolean_0;

		// Token: 0x040026D0 RID: 9936
		private static readonly IntPtr NativeMethodInfoPtr_LocalFindAndPop_Internal_Boolean_IThreadPoolWorkItem_0;

		// Token: 0x040026D1 RID: 9937
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_Void_ThreadPoolWorkQueueThreadLocals_byref_IThreadPoolWorkItem_byref_Boolean_0;

		// Token: 0x040026D2 RID: 9938
		private static readonly IntPtr NativeMethodInfoPtr_Dispatch_Internal_Static_Boolean_0;

		// Token: 0x020005F5 RID: 1525
		public class SparseArray<T> : Object where T : class
		{
			// Token: 0x06005440 RID: 21568 RVA: 0x0017AC78 File Offset: 0x00178E78
			// Note: this type is marked as 'beforefieldinit'.
			static SparseArray()
			{
				Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "SparseArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr);
				ThreadPoolWorkQueue.SparseArray<T>.NativeFieldInfoPtr_m_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr, "m_array");
				ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr, 100670442);
				ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_get_Current_Internal_get_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr, 100670443);
				ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_Add_Internal_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr, 100670444);
				ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_Remove_Internal_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr, 100670445);
			}

			// Token: 0x06005441 RID: 21569 RVA: 0x0017AD44 File Offset: 0x00178F44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204163, XrefRangeEnd = 204165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SparseArray(int initialSize)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref initialSize;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700159F RID: 5535
			// (get) Token: 0x06005442 RID: 21570 RVA: 0x0017AD8C File Offset: 0x00178F8C
			public unsafe Il2CppArrayBase<T> Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_get_Current_Internal_get_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
				}
			}

			// Token: 0x06005443 RID: 21571 RVA: 0x0017ADC4 File Offset: 0x00178FC4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 204178, RefRangeEnd = 204179, XrefRangeStart = 204165, XrefRangeEnd = 204178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Add(T e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = e;
						if (!(t is string))
						{
							ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
						}
					}
					else
					{
						ptr4 = ref e;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_Add_Internal_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005444 RID: 21572 RVA: 0x0017AE5C File Offset: 0x0017905C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 204185, RefRangeEnd = 204186, XrefRangeStart = 204179, XrefRangeEnd = 204185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Remove(T e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = e;
						if (!(t is string))
						{
							ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
						}
					}
					else
					{
						ptr4 = ref e;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_Remove_Internal_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005445 RID: 21573 RVA: 0x0001FCF3 File Offset: 0x0001DEF3
			public SparseArray(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700159E RID: 5534
			// (get) Token: 0x06005446 RID: 21574 RVA: 0x0017AEEC File Offset: 0x001790EC
			// (set) Token: 0x06005447 RID: 21575 RVA: 0x0001FCFC File Offset: 0x0001DEFC
			public unsafe Il2CppArrayBase<T> m_array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.SparseArray<T>.NativeFieldInfoPtr_m_array);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.SparseArray<T>.NativeFieldInfoPtr_m_array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004445 RID: 17477
			private static readonly IntPtr NativeFieldInfoPtr_m_array;

			// Token: 0x04004446 RID: 17478
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x04004447 RID: 17479
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Internal_get_Il2CppArrayBase_1_T_0;

			// Token: 0x04004448 RID: 17480
			private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Int32_T_0;

			// Token: 0x04004449 RID: 17481
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Internal_Void_T_0;
		}

		// Token: 0x020005F6 RID: 1526
		public class WorkStealingQueue : Object
		{
			// Token: 0x06005448 RID: 21576 RVA: 0x0017AF14 File Offset: 0x00179114
			// Note: this type is marked as 'beforefieldinit'.
			static WorkStealingQueue()
			{
				Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "WorkStealingQueue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, "m_array");
				ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, "m_mask");
				ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_headIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, "m_headIndex");
				ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_tailIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, "m_tailIndex");
				ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_foreignLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, "m_foreignLock");
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalPush_Public_Void_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100670446);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalFindAndPop_Public_Boolean_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100670447);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalPop_Public_Boolean_byref_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100670448);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_TrySteal_Public_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100670449);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_TrySteal_Private_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100670450);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100670451);
			}

			// Token: 0x06005449 RID: 21577 RVA: 0x0017B01C File Offset: 0x0017921C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 204206, RefRangeEnd = 204207, XrefRangeStart = 204186, XrefRangeEnd = 204206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void LocalPush(IThreadPoolWorkItem obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalPush_Public_Void_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600544A RID: 21578 RVA: 0x0017B060 File Offset: 0x00179260
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 204213, RefRangeEnd = 204215, XrefRangeStart = 204207, XrefRangeEnd = 204213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool LocalFindAndPop(IThreadPoolWorkItem obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalFindAndPop_Public_Boolean_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600544B RID: 21579 RVA: 0x0017B0B0 File Offset: 0x001792B0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 204228, RefRangeEnd = 204230, XrefRangeStart = 204215, XrefRangeEnd = 204228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool LocalPop(out IThreadPoolWorkItem obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalPop_Public_Boolean_byref_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					obj = ((intPtr4 == 0) ? null : new IThreadPoolWorkItem(intPtr4));
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x0600544C RID: 21580 RVA: 0x0017B110 File Offset: 0x00179310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204230, XrefRangeEnd = 204231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = 0;
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &missedSteal;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_TrySteal_Public_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				obj = ((intPtr4 == 0) ? null : new IThreadPoolWorkItem(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600544D RID: 21581 RVA: 0x0017B17C File Offset: 0x0017937C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 204245, RefRangeEnd = 204247, XrefRangeStart = 204231, XrefRangeEnd = 204245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = 0;
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &missedSteal;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_TrySteal_Private_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				obj = ((intPtr4 == 0) ? null : new IThreadPoolWorkItem(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600544E RID: 21582 RVA: 0x0017B1F8 File Offset: 0x001793F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204247, XrefRangeEnd = 204250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WorkStealingQueue()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600544F RID: 21583 RVA: 0x0001FD1B File Offset: 0x0001DF1B
			public WorkStealingQueue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015A0 RID: 5536
			// (get) Token: 0x06005450 RID: 21584 RVA: 0x0017B234 File Offset: 0x00179434
			// (set) Token: 0x06005451 RID: 21585 RVA: 0x0001FD24 File Offset: 0x0001DF24
			public unsafe Il2CppReferenceArray<IThreadPoolWorkItem> m_array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_array);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IThreadPoolWorkItem>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015A1 RID: 5537
			// (get) Token: 0x06005452 RID: 21586 RVA: 0x0017B264 File Offset: 0x00179464
			// (set) Token: 0x06005453 RID: 21587 RVA: 0x0001FD43 File Offset: 0x0001DF43
			public unsafe int m_mask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_mask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_mask)) = value;
				}
			}

			// Token: 0x170015A2 RID: 5538
			// (get) Token: 0x06005454 RID: 21588 RVA: 0x0017B28C File Offset: 0x0017948C
			// (set) Token: 0x06005455 RID: 21589 RVA: 0x0001FD5E File Offset: 0x0001DF5E
			public unsafe int m_headIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_headIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_headIndex)) = value;
				}
			}

			// Token: 0x170015A3 RID: 5539
			// (get) Token: 0x06005456 RID: 21590 RVA: 0x0017B2B4 File Offset: 0x001794B4
			// (set) Token: 0x06005457 RID: 21591 RVA: 0x0001FD79 File Offset: 0x0001DF79
			public unsafe int m_tailIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_tailIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_tailIndex)) = value;
				}
			}

			// Token: 0x170015A4 RID: 5540
			// (get) Token: 0x06005458 RID: 21592 RVA: 0x0017B2DC File Offset: 0x001794DC
			// (set) Token: 0x06005459 RID: 21593 RVA: 0x0001FD94 File Offset: 0x0001DF94
			public unsafe SpinLock m_foreignLock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_foreignLock);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_foreignLock)) = value;
				}
			}

			// Token: 0x0400444A RID: 17482
			private static readonly IntPtr NativeFieldInfoPtr_m_array;

			// Token: 0x0400444B RID: 17483
			private static readonly IntPtr NativeFieldInfoPtr_m_mask;

			// Token: 0x0400444C RID: 17484
			private static readonly IntPtr NativeFieldInfoPtr_m_headIndex;

			// Token: 0x0400444D RID: 17485
			private static readonly IntPtr NativeFieldInfoPtr_m_tailIndex;

			// Token: 0x0400444E RID: 17486
			private static readonly IntPtr NativeFieldInfoPtr_m_foreignLock;

			// Token: 0x0400444F RID: 17487
			private static readonly IntPtr NativeMethodInfoPtr_LocalPush_Public_Void_IThreadPoolWorkItem_0;

			// Token: 0x04004450 RID: 17488
			private static readonly IntPtr NativeMethodInfoPtr_LocalFindAndPop_Public_Boolean_IThreadPoolWorkItem_0;

			// Token: 0x04004451 RID: 17489
			private static readonly IntPtr NativeMethodInfoPtr_LocalPop_Public_Boolean_byref_IThreadPoolWorkItem_0;

			// Token: 0x04004452 RID: 17490
			private static readonly IntPtr NativeMethodInfoPtr_TrySteal_Public_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_0;

			// Token: 0x04004453 RID: 17491
			private static readonly IntPtr NativeMethodInfoPtr_TrySteal_Private_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_Int32_0;

			// Token: 0x04004454 RID: 17492
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020005F7 RID: 1527
		public class QueueSegment : Object
		{
			// Token: 0x0600545A RID: 21594 RVA: 0x0017B304 File Offset: 0x00179504
			// Note: this type is marked as 'beforefieldinit'.
			static QueueSegment()
			{
				Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "QueueSegment");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr);
				ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, "nodes");
				ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_indexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, "indexes");
				ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, "Next");
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_GetIndexes_Private_Void_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100670452);
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_CompareExchangeIndexes_Private_Boolean_byref_Int32_Int32_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100670453);
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100670454);
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_IsUsedUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100670455);
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_TryEnqueue_Public_Boolean_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100670456);
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100670457);
			}

			// Token: 0x0600545B RID: 21595 RVA: 0x0017B3E4 File Offset: 0x001795E4
			[CallerCount(0)]
			public unsafe void GetIndexes(out int upper, out int lower)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &upper;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lower;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_GetIndexes_Private_Void_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600545C RID: 21596 RVA: 0x0017B430 File Offset: 0x00179630
			[CallerCount(0)]
			public unsafe bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &prevUpper;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newUpper;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &prevLower;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newLower;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_CompareExchangeIndexes_Private_Boolean_byref_Int32_Int32_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600545D RID: 21597 RVA: 0x0017B4A4 File Offset: 0x001796A4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 204253, RefRangeEnd = 204256, XrefRangeStart = 204250, XrefRangeEnd = 204253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe QueueSegment()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600545E RID: 21598 RVA: 0x0017B4E0 File Offset: 0x001796E0
			[CallerCount(0)]
			public unsafe bool IsUsedUp()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_IsUsedUp_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600545F RID: 21599 RVA: 0x0017B51C File Offset: 0x0017971C
			[CallerCount(0)]
			public unsafe bool TryEnqueue(IThreadPoolWorkItem node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_TryEnqueue_Public_Boolean_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005460 RID: 21600 RVA: 0x0017B56C File Offset: 0x0017976C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 204260, RefRangeEnd = 204261, XrefRangeStart = 204256, XrefRangeEnd = 204260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryDequeue(out IThreadPoolWorkItem node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					node = ((intPtr4 == 0) ? null : new IThreadPoolWorkItem(intPtr4));
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06005461 RID: 21601 RVA: 0x0001FDAF File Offset: 0x0001DFAF
			public QueueSegment(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015A5 RID: 5541
			// (get) Token: 0x06005462 RID: 21602 RVA: 0x0017B5CC File Offset: 0x001797CC
			// (set) Token: 0x06005463 RID: 21603 RVA: 0x0001FDB8 File Offset: 0x0001DFB8
			public unsafe Il2CppReferenceArray<IThreadPoolWorkItem> nodes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_nodes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IThreadPoolWorkItem>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015A6 RID: 5542
			// (get) Token: 0x06005464 RID: 21604 RVA: 0x0017B5FC File Offset: 0x001797FC
			// (set) Token: 0x06005465 RID: 21605 RVA: 0x0001FDD7 File Offset: 0x0001DFD7
			public unsafe int indexes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_indexes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_indexes)) = value;
				}
			}

			// Token: 0x170015A7 RID: 5543
			// (get) Token: 0x06005466 RID: 21606 RVA: 0x0017B624 File Offset: 0x00179824
			// (set) Token: 0x06005467 RID: 21607 RVA: 0x0001FDF2 File Offset: 0x0001DFF2
			public unsafe ThreadPoolWorkQueue.QueueSegment Next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_Next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue.QueueSegment>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004455 RID: 17493
			private static readonly IntPtr NativeFieldInfoPtr_nodes;

			// Token: 0x04004456 RID: 17494
			private static readonly IntPtr NativeFieldInfoPtr_indexes;

			// Token: 0x04004457 RID: 17495
			private static readonly IntPtr NativeFieldInfoPtr_Next;

			// Token: 0x04004458 RID: 17496
			private static readonly IntPtr NativeMethodInfoPtr_GetIndexes_Private_Void_byref_Int32_byref_Int32_0;

			// Token: 0x04004459 RID: 17497
			private static readonly IntPtr NativeMethodInfoPtr_CompareExchangeIndexes_Private_Boolean_byref_Int32_Int32_byref_Int32_Int32_0;

			// Token: 0x0400445A RID: 17498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400445B RID: 17499
			private static readonly IntPtr NativeMethodInfoPtr_IsUsedUp_Public_Boolean_0;

			// Token: 0x0400445C RID: 17500
			private static readonly IntPtr NativeMethodInfoPtr_TryEnqueue_Public_Boolean_IThreadPoolWorkItem_0;

			// Token: 0x0400445D RID: 17501
			private static readonly IntPtr NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_IThreadPoolWorkItem_0;
		}
	}
}
