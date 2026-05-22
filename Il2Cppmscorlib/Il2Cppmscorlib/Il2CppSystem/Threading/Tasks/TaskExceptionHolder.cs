using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Runtime.ExceptionServices;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B9 RID: 697
	public class TaskExceptionHolder : Object
	{
		// Token: 0x06002F76 RID: 12150 RVA: 0x000F1694 File Offset: 0x000EF894
		// Note: this type is marked as 'beforefieldinit'.
		static TaskExceptionHolder()
		{
			Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskExceptionHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr);
			TaskExceptionHolder.NativeFieldInfoPtr_s_failFastOnUnobservedException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "s_failFastOnUnobservedException");
			TaskExceptionHolder.NativeFieldInfoPtr_s_domainUnloadStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "s_domainUnloadStarted");
			TaskExceptionHolder.NativeFieldInfoPtr_s_adUnloadEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "s_adUnloadEventHandler");
			TaskExceptionHolder.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "m_task");
			TaskExceptionHolder.NativeFieldInfoPtr_m_faultExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "m_faultExceptions");
			TaskExceptionHolder.NativeFieldInfoPtr_m_cancellationException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "m_cancellationException");
			TaskExceptionHolder.NativeFieldInfoPtr_m_isHandled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "m_isHandled");
			TaskExceptionHolder.NativeMethodInfoPtr__ctor_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670864);
			TaskExceptionHolder.NativeMethodInfoPtr_ShouldFailFastOnUnobservedException_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670865);
			TaskExceptionHolder.NativeMethodInfoPtr_EnsureADUnloadCallbackRegistered_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670866);
			TaskExceptionHolder.NativeMethodInfoPtr_AppDomainUnloadCallback_Private_Static_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670867);
			TaskExceptionHolder.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670868);
			TaskExceptionHolder.NativeMethodInfoPtr_get_ContainsFaultList_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670869);
			TaskExceptionHolder.NativeMethodInfoPtr_Add_Internal_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670870);
			TaskExceptionHolder.NativeMethodInfoPtr_SetCancellationException_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670871);
			TaskExceptionHolder.NativeMethodInfoPtr_AddFaultException_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670872);
			TaskExceptionHolder.NativeMethodInfoPtr_MarkAsUnhandled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670873);
			TaskExceptionHolder.NativeMethodInfoPtr_MarkAsHandled_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670874);
			TaskExceptionHolder.NativeMethodInfoPtr_CreateExceptionObject_Internal_AggregateException_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670875);
			TaskExceptionHolder.NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670876);
			TaskExceptionHolder.NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670877);
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x000F1868 File Offset: 0x000EFA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207063, XrefRangeEnd = 207067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskExceptionHolder(Task task)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr__ctor_Internal_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x000F18B4 File Offset: 0x000EFAB4
		[CallerCount(0)]
		public unsafe static bool ShouldFailFastOnUnobservedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_ShouldFailFastOnUnobservedException_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x000F18E4 File Offset: 0x000EFAE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207087, RefRangeEnd = 207089, XrefRangeStart = 207067, XrefRangeEnd = 207087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureADUnloadCallbackRegistered()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_EnsureADUnloadCallbackRegistered_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x000F190C File Offset: 0x000EFB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207089, XrefRangeEnd = 207093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppDomainUnloadCallback(Object sender, EventArgs e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_AppDomainUnloadCallback_Private_Static_Void_Object_EventArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x000F1954 File Offset: 0x000EFB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207093, XrefRangeEnd = 207151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskExceptionHolder.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06002F7C RID: 12156 RVA: 0x000F1990 File Offset: 0x000EFB90
		public unsafe bool ContainsFaultList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_get_ContainsFaultList_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x000F19CC File Offset: 0x000EFBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207151, XrefRangeEnd = 207153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Object exceptionObject, bool representsCancellation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref representsCancellation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_Add_Internal_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x000F1A1C File Offset: 0x000EFC1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207185, RefRangeEnd = 207187, XrefRangeStart = 207153, XrefRangeEnd = 207185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCancellationException(Object exceptionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_SetCancellationException_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x000F1A60 File Offset: 0x000EFC60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207274, RefRangeEnd = 207276, XrefRangeStart = 207187, XrefRangeEnd = 207274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFaultException(Object exceptionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_AddFaultException_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x000F1AA4 File Offset: 0x000EFCA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207291, RefRangeEnd = 207292, XrefRangeStart = 207276, XrefRangeEnd = 207291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkAsUnhandled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_MarkAsUnhandled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x000F1AD8 File Offset: 0x000EFCD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207296, RefRangeEnd = 207299, XrefRangeStart = 207292, XrefRangeEnd = 207296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkAsHandled(bool calledFromFinalizer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calledFromFinalizer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_MarkAsHandled_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x000F1B18 File Offset: 0x000EFD18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207317, RefRangeEnd = 207319, XrefRangeStart = 207299, XrefRangeEnd = 207317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calledFromFinalizer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(includeThisException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_CreateExceptionObject_Internal_AggregateException_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AggregateException>(intPtr3) : null;
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x000F1B78 File Offset: 0x000EFD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207319, XrefRangeEnd = 207327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ExceptionDispatchInfo>>(intPtr3) : null;
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x000F1BB8 File Offset: 0x000EFDB8
		[CallerCount(0)]
		public unsafe ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x000106D2 File Offset: 0x0000E8D2
		public TaskExceptionHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06002F86 RID: 12166 RVA: 0x000F1BF8 File Offset: 0x000EFDF8
		// (set) Token: 0x06002F87 RID: 12167 RVA: 0x000106DB File Offset: 0x0000E8DB
		public unsafe static bool s_failFastOnUnobservedException
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TaskExceptionHolder.NativeFieldInfoPtr_s_failFastOnUnobservedException, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskExceptionHolder.NativeFieldInfoPtr_s_failFastOnUnobservedException, (void*)(&value));
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06002F88 RID: 12168 RVA: 0x000F1C14 File Offset: 0x000EFE14
		// (set) Token: 0x06002F89 RID: 12169 RVA: 0x000106E9 File Offset: 0x0000E8E9
		public unsafe static bool s_domainUnloadStarted
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TaskExceptionHolder.NativeFieldInfoPtr_s_domainUnloadStarted, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskExceptionHolder.NativeFieldInfoPtr_s_domainUnloadStarted, (void*)(&value));
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06002F8A RID: 12170 RVA: 0x000F1C30 File Offset: 0x000EFE30
		// (set) Token: 0x06002F8B RID: 12171 RVA: 0x000106F7 File Offset: 0x0000E8F7
		public unsafe static EventHandler s_adUnloadEventHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaskExceptionHolder.NativeFieldInfoPtr_s_adUnloadEventHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskExceptionHolder.NativeFieldInfoPtr_s_adUnloadEventHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002F8C RID: 12172 RVA: 0x000F1C58 File Offset: 0x000EFE58
		// (set) Token: 0x06002F8D RID: 12173 RVA: 0x00010709 File Offset: 0x0000E909
		public unsafe Task m_task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002F8E RID: 12174 RVA: 0x000F1C88 File Offset: 0x000EFE88
		// (set) Token: 0x06002F8F RID: 12175 RVA: 0x00010728 File Offset: 0x0000E928
		public unsafe List<ExceptionDispatchInfo> m_faultExceptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_faultExceptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ExceptionDispatchInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_faultExceptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06002F90 RID: 12176 RVA: 0x000F1CB8 File Offset: 0x000EFEB8
		// (set) Token: 0x06002F91 RID: 12177 RVA: 0x00010747 File Offset: 0x0000E947
		public unsafe ExceptionDispatchInfo m_cancellationException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_cancellationException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_cancellationException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06002F92 RID: 12178 RVA: 0x000F1CE8 File Offset: 0x000EFEE8
		// (set) Token: 0x06002F93 RID: 12179 RVA: 0x00010766 File Offset: 0x0000E966
		public unsafe bool m_isHandled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_isHandled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_isHandled)) = value;
			}
		}

		// Token: 0x04002915 RID: 10517
		private static readonly IntPtr NativeFieldInfoPtr_s_failFastOnUnobservedException;

		// Token: 0x04002916 RID: 10518
		private static readonly IntPtr NativeFieldInfoPtr_s_domainUnloadStarted;

		// Token: 0x04002917 RID: 10519
		private static readonly IntPtr NativeFieldInfoPtr_s_adUnloadEventHandler;

		// Token: 0x04002918 RID: 10520
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x04002919 RID: 10521
		private static readonly IntPtr NativeFieldInfoPtr_m_faultExceptions;

		// Token: 0x0400291A RID: 10522
		private static readonly IntPtr NativeFieldInfoPtr_m_cancellationException;

		// Token: 0x0400291B RID: 10523
		private static readonly IntPtr NativeFieldInfoPtr_m_isHandled;

		// Token: 0x0400291C RID: 10524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_0;

		// Token: 0x0400291D RID: 10525
		private static readonly IntPtr NativeMethodInfoPtr_ShouldFailFastOnUnobservedException_Private_Static_Boolean_0;

		// Token: 0x0400291E RID: 10526
		private static readonly IntPtr NativeMethodInfoPtr_EnsureADUnloadCallbackRegistered_Private_Static_Void_0;

		// Token: 0x0400291F RID: 10527
		private static readonly IntPtr NativeMethodInfoPtr_AppDomainUnloadCallback_Private_Static_Void_Object_EventArgs_0;

		// Token: 0x04002920 RID: 10528
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002921 RID: 10529
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainsFaultList_Internal_get_Boolean_0;

		// Token: 0x04002922 RID: 10530
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_Object_Boolean_0;

		// Token: 0x04002923 RID: 10531
		private static readonly IntPtr NativeMethodInfoPtr_SetCancellationException_Private_Void_Object_0;

		// Token: 0x04002924 RID: 10532
		private static readonly IntPtr NativeMethodInfoPtr_AddFaultException_Private_Void_Object_0;

		// Token: 0x04002925 RID: 10533
		private static readonly IntPtr NativeMethodInfoPtr_MarkAsUnhandled_Private_Void_0;

		// Token: 0x04002926 RID: 10534
		private static readonly IntPtr NativeMethodInfoPtr_MarkAsHandled_Internal_Void_Boolean_0;

		// Token: 0x04002927 RID: 10535
		private static readonly IntPtr NativeMethodInfoPtr_CreateExceptionObject_Internal_AggregateException_Boolean_Exception_0;

		// Token: 0x04002928 RID: 10536
		private static readonly IntPtr NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0;

		// Token: 0x04002929 RID: 10537
		private static readonly IntPtr NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0;
	}
}
