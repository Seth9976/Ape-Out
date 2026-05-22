using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.ConstrainedExecution;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Security.Principal;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200027E RID: 638
	public sealed class Thread : CriticalFinalizerObject
	{
		// Token: 0x06002C02 RID: 11266 RVA: 0x000E3FE8 File Offset: 0x000E21E8
		// Note: this type is marked as 'beforefieldinit'.
		static Thread()
		{
			Il2CppClassPointerStore<Thread>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Thread");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Thread>.NativeClassPtr);
			Thread.NativeFieldInfoPtr_s_LocalDataStoreMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "s_LocalDataStoreMgr");
			Thread.NativeFieldInfoPtr_s_LocalDataStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "s_LocalDataStore");
			Thread.NativeFieldInfoPtr_m_CurrentCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_CurrentCulture");
			Thread.NativeFieldInfoPtr_m_CurrentUICulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_CurrentUICulture");
			Thread.NativeFieldInfoPtr_s_asyncLocalCurrentCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "s_asyncLocalCurrentCulture");
			Thread.NativeFieldInfoPtr_s_asyncLocalCurrentUICulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "s_asyncLocalCurrentUICulture");
			Thread.NativeFieldInfoPtr_internal_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "internal_thread");
			Thread.NativeFieldInfoPtr_m_ThreadStartArg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_ThreadStartArg");
			Thread.NativeFieldInfoPtr_pending_exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "pending_exception");
			Thread.NativeFieldInfoPtr_principal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "principal");
			Thread.NativeFieldInfoPtr_principal_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "principal_version");
			Thread.NativeFieldInfoPtr_current_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "current_thread");
			Thread.NativeFieldInfoPtr_m_Delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_Delegate");
			Thread.NativeFieldInfoPtr_m_ExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_ExecutionContext");
			Thread.NativeFieldInfoPtr_m_ExecutionContextBelongsToOuterScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thread>.NativeClassPtr, "m_ExecutionContextBelongsToOuterScope");
			Thread.NativeMethodInfoPtr_AsyncLocalSetCurrentCulture_Private_Static_Void_AsyncLocalValueChangedArgs_1_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670364);
			Thread.NativeMethodInfoPtr__ctor_Public_Void_ThreadStart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670365);
			Thread.NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670366);
			Thread.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670367);
			Thread.NativeMethodInfoPtr_Start_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670368);
			Thread.NativeMethodInfoPtr_Start_Private_Void_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670369);
			Thread.NativeMethodInfoPtr_GetExecutionContextReader_Internal_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670370);
			Thread.NativeMethodInfoPtr_get_ExecutionContextBelongsToCurrentScope_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670371);
			Thread.NativeMethodInfoPtr_set_ExecutionContextBelongsToCurrentScope_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670372);
			Thread.NativeMethodInfoPtr_GetMutableExecutionContext_Internal_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670373);
			Thread.NativeMethodInfoPtr_SetExecutionContext_Internal_Void_ExecutionContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670374);
			Thread.NativeMethodInfoPtr_SetExecutionContext_Internal_Void_Reader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670375);
			Thread.NativeMethodInfoPtr_SleepInternal_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670376);
			Thread.NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670377);
			Thread.NativeMethodInfoPtr_YieldInternal_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670378);
			Thread.NativeMethodInfoPtr_Yield_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670379);
			Thread.NativeMethodInfoPtr_SetStartHelper_Private_Void_Delegate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670380);
			Thread.NativeMethodInfoPtr_get_CurrentUICulture_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670381);
			Thread.NativeMethodInfoPtr_GetCurrentUICultureNoAppX_Internal_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670382);
			Thread.NativeMethodInfoPtr_get_CurrentCulture_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670383);
			Thread.NativeMethodInfoPtr_set_CurrentCulture_Public_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670384);
			Thread.NativeMethodInfoPtr_GetCurrentCultureNoAppX_Private_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670385);
			Thread.NativeMethodInfoPtr_nativeInitCultureAccessors_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670386);
			Thread.NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670387);
			Thread.NativeMethodInfoPtr_ConstructInternalThread_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670388);
			Thread.NativeMethodInfoPtr_get_Internal_Private_get_InternalThread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670389);
			Thread.NativeMethodInfoPtr_get_CurrentContext_Public_Static_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670390);
			Thread.NativeMethodInfoPtr_GetCurrentThread_Private_Static_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670391);
			Thread.NativeMethodInfoPtr_get_CurrentThread_Public_Static_get_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670392);
			Thread.NativeMethodInfoPtr_get_CurrentThreadId_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670393);
			Thread.NativeMethodInfoPtr_GetDomainID_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670394);
			Thread.NativeMethodInfoPtr_Thread_internal_Private_IntPtr_MulticastDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670395);
			Thread.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670396);
			Thread.NativeMethodInfoPtr_get_IsThreadPoolThread_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670397);
			Thread.NativeMethodInfoPtr_get_IsThreadPoolThreadInternal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670398);
			Thread.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670399);
			Thread.NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670400);
			Thread.NativeMethodInfoPtr_SetName_internal_Private_Static_Void_InternalThread_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670401);
			Thread.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670402);
			Thread.NativeMethodInfoPtr_get_ThreadState_Public_get_ThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670403);
			Thread.NativeMethodInfoPtr_SpinWait_nop_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670404);
			Thread.NativeMethodInfoPtr_SpinWait_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670405);
			Thread.NativeMethodInfoPtr_StartInternal_Private_Void_IPrincipal_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670406);
			Thread.NativeMethodInfoPtr_SetState_Private_Static_Void_InternalThread_ThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670407);
			Thread.NativeMethodInfoPtr_ClrState_Private_Static_Void_InternalThread_ThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670408);
			Thread.NativeMethodInfoPtr_GetState_Private_Static_ThreadState_InternalThread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670409);
			Thread.NativeMethodInfoPtr_SystemMaxStackStize_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670410);
			Thread.NativeMethodInfoPtr_GetProcessDefaultStackSize_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670411);
			Thread.NativeMethodInfoPtr_SetStart_Private_Void_MulticastDelegate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670412);
			Thread.NativeMethodInfoPtr_get_ManagedThreadId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670413);
			Thread.NativeMethodInfoPtr_BeginCriticalRegion_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670414);
			Thread.NativeMethodInfoPtr_EndCriticalRegion_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670415);
			Thread.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670416);
			Thread.NativeMethodInfoPtr_ValidateThreadState_Private_ThreadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thread>.NativeClassPtr, 100670417);
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x000E457C File Offset: 0x000E277C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201672, XrefRangeEnd = 201676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<CultureInfo> args)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_AsyncLocalSetCurrentCulture_Private_Static_Void_AsyncLocalValueChangedArgs_1_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x000E45B8 File Offset: 0x000E27B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201676, XrefRangeEnd = 201683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Thread(ThreadStart start)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Thread>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr__ctor_Public_Void_ThreadStart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x000E4604 File Offset: 0x000E2804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201683, XrefRangeEnd = 201690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Thread(ParameterizedThreadStart start)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Thread>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x000E4650 File Offset: 0x000E2850
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 201691, RefRangeEnd = 201698, XrefRangeStart = 201690, XrefRangeEnd = 201691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x000E4684 File Offset: 0x000E2884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201701, RefRangeEnd = 201702, XrefRangeStart = 201698, XrefRangeEnd = 201701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start(Object parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Start_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x000E46C8 File Offset: 0x000E28C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201710, RefRangeEnd = 201712, XrefRangeStart = 201702, XrefRangeEnd = 201710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start(ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &stackMark;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Start_Private_Void_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x000E4708 File Offset: 0x000E2908
		[CallerCount(0)]
		public unsafe ExecutionContext.Reader GetExecutionContextReader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetExecutionContextReader_Internal_Reader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ExecutionContext.Reader(intPtr);
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002C0A RID: 11274 RVA: 0x000E4740 File Offset: 0x000E2940
		// (set) Token: 0x06002C0B RID: 11275 RVA: 0x000E477C File Offset: 0x000E297C
		public unsafe bool ExecutionContextBelongsToCurrentScope
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_ExecutionContextBelongsToCurrentScope_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_set_ExecutionContextBelongsToCurrentScope_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x000E47BC File Offset: 0x000E29BC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 201715, RefRangeEnd = 201721, XrefRangeStart = 201712, XrefRangeEnd = 201715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext GetMutableExecutionContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetMutableExecutionContext_Internal_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x000E47FC File Offset: 0x000E29FC
		[CallerCount(0)]
		public unsafe void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref belongsToCurrentScope;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetExecutionContext_Internal_Void_ExecutionContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x000E484C File Offset: 0x000E2A4C
		[CallerCount(0)]
		public unsafe void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref belongsToCurrentScope;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetExecutionContext_Internal_Void_Reader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x000E48A4 File Offset: 0x000E2AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201721, XrefRangeEnd = 201725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SleepInternal(int millisecondsTimeout)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SleepInternal_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x000E48D8 File Offset: 0x000E2AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201725, XrefRangeEnd = 201737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sleep(int millisecondsTimeout)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x000E490C File Offset: 0x000E2B0C
		[CallerCount(0)]
		public unsafe static bool YieldInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_YieldInternal_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x000E493C File Offset: 0x000E2B3C
		[CallerCount(0)]
		public unsafe static bool Yield()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Yield_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x000E496C File Offset: 0x000E2B6C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 201757, RefRangeEnd = 201767, XrefRangeStart = 201737, XrefRangeEnd = 201757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStartHelper(Delegate start, int maxStackSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxStackSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetStartHelper_Private_Void_Delegate_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002C14 RID: 11284 RVA: 0x000E49BC File Offset: 0x000E2BBC
		public unsafe CultureInfo CurrentUICulture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201767, XrefRangeEnd = 201768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_CurrentUICulture_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x000E49FC File Offset: 0x000E2BFC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 201774, RefRangeEnd = 201781, XrefRangeStart = 201768, XrefRangeEnd = 201774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo GetCurrentUICultureNoAppX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetCurrentUICultureNoAppX_Internal_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002C16 RID: 11286 RVA: 0x000E4A3C File Offset: 0x000E2C3C
		// (set) Token: 0x06002C17 RID: 11287 RVA: 0x000E4A7C File Offset: 0x000E2C7C
		public unsafe CultureInfo CurrentCulture
		{
			[CallerCount(75)]
			[CachedScanResults(RefRangeStart = 201787, RefRangeEnd = 201862, XrefRangeStart = 201781, XrefRangeEnd = 201787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_CurrentCulture_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 201898, RefRangeEnd = 201899, XrefRangeStart = 201862, XrefRangeEnd = 201898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_set_CurrentCulture_Public_set_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x000E4AC0 File Offset: 0x000E2CC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201905, RefRangeEnd = 201907, XrefRangeStart = 201899, XrefRangeEnd = 201905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo GetCurrentCultureNoAppX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetCurrentCultureNoAppX_Private_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x000E4B00 File Offset: 0x000E2D00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201920, RefRangeEnd = 201921, XrefRangeStart = 201907, XrefRangeEnd = 201920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void nativeInitCultureAccessors()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_nativeInitCultureAccessors_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C1A RID: 11290 RVA: 0x000E4B28 File Offset: 0x000E2D28
		[CallerCount(0)]
		public unsafe static void MemoryBarrier()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x000E4B50 File Offset: 0x000E2D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201921, XrefRangeEnd = 201927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConstructInternalThread()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_ConstructInternalThread_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06002C1C RID: 11292 RVA: 0x000E4B84 File Offset: 0x000E2D84
		public unsafe InternalThread Internal
		{
			[CallerCount(1022)]
			[CachedScanResults(RefRangeStart = 201933, RefRangeEnd = 202955, XrefRangeStart = 201927, XrefRangeEnd = 201933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_Internal_Private_get_InternalThread_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InternalThread>(intPtr3) : null;
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x000E4BC4 File Offset: 0x000E2DC4
		public unsafe static Context CurrentContext
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 173638, RefRangeEnd = 173641, XrefRangeStart = 173638, XrefRangeEnd = 173641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_CurrentContext_Public_Static_get_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x000E4BF8 File Offset: 0x000E2DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202955, XrefRangeEnd = 202956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Thread GetCurrentThread()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetCurrentThread_Private_Static_Thread_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr3) : null;
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x000E4C2C File Offset: 0x000E2E2C
		public unsafe static Thread CurrentThread
		{
			[CallerCount(1123)]
			[CachedScanResults(RefRangeStart = 202960, RefRangeEnd = 204083, XrefRangeStart = 202956, XrefRangeEnd = 202960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_CurrentThread_Public_Static_get_Thread_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr3) : null;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06002C20 RID: 11296 RVA: 0x000E4C60 File Offset: 0x000E2E60
		public unsafe static int CurrentThreadId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_CurrentThreadId_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x000E4C90 File Offset: 0x000E2E90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173653, RefRangeEnd = 173654, XrefRangeStart = 173653, XrefRangeEnd = 173654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDomainID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetDomainID_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x000E4CC0 File Offset: 0x000E2EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204083, XrefRangeEnd = 204084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr Thread_internal(MulticastDelegate start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Thread_internal_Private_IntPtr_MulticastDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x000E4D10 File Offset: 0x000E2F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204084, XrefRangeEnd = 204085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06002C24 RID: 11300 RVA: 0x000E4D44 File Offset: 0x000E2F44
		public unsafe bool IsThreadPoolThread
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204085, XrefRangeEnd = 204086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_IsThreadPoolThread_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06002C25 RID: 11301 RVA: 0x000E4D80 File Offset: 0x000E2F80
		public unsafe bool IsThreadPoolThreadInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_IsThreadPoolThreadInternal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06002C26 RID: 11302 RVA: 0x000E4DBC File Offset: 0x000E2FBC
		public unsafe bool IsAlive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204086, XrefRangeEnd = 204090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (set) Token: 0x06002C27 RID: 11303 RVA: 0x000E4DF8 File Offset: 0x000E2FF8
		public unsafe bool IsBackground
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 204098, RefRangeEnd = 204102, XrefRangeStart = 204090, XrefRangeEnd = 204098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x000E4E38 File Offset: 0x000E3038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204102, XrefRangeEnd = 204103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetName_internal(InternalThread thread, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thread);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetName_internal_Private_Static_Void_InternalThread_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A6F RID: 2671
		// (set) Token: 0x06002C29 RID: 11305 RVA: 0x000E4E80 File Offset: 0x000E3080
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 204105, RefRangeEnd = 204106, XrefRangeStart = 204103, XrefRangeEnd = 204105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06002C2A RID: 11306 RVA: 0x000E4EC4 File Offset: 0x000E30C4
		public unsafe ThreadState ThreadState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204106, XrefRangeEnd = 204110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_ThreadState_Public_get_ThreadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000E4F00 File Offset: 0x000E3100
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SpinWait_nop()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SpinWait_nop_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x000E4F28 File Offset: 0x000E3128
		[CallerCount(0)]
		public unsafe static void SpinWait(int iterations)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iterations;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SpinWait_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x000E4F5C File Offset: 0x000E315C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204110, XrefRangeEnd = 204112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartInternal(IPrincipal principal, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(principal);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_StartInternal_Private_Void_IPrincipal_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x000E4FAC File Offset: 0x000E31AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204112, XrefRangeEnd = 204115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetState(InternalThread thread, ThreadState set)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thread);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref set;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetState_Private_Static_Void_InternalThread_ThreadState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x000E4FF0 File Offset: 0x000E31F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204115, XrefRangeEnd = 204118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClrState(InternalThread thread, ThreadState clr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thread);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_ClrState_Private_Static_Void_InternalThread_ThreadState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x000E5034 File Offset: 0x000E3234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204118, XrefRangeEnd = 204121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ThreadState GetState(InternalThread thread)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thread);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetState_Private_Static_ThreadState_InternalThread_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x000E5078 File Offset: 0x000E3278
		[CallerCount(0)]
		public unsafe static int SystemMaxStackStize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SystemMaxStackStize_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x000E50A8 File Offset: 0x000E32A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204121, XrefRangeEnd = 204124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetProcessDefaultStackSize(int maxStackSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxStackSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetProcessDefaultStackSize_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x000E50E8 File Offset: 0x000E32E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204125, RefRangeEnd = 204126, XrefRangeStart = 204124, XrefRangeEnd = 204125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStart(MulticastDelegate start, int maxStackSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxStackSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_SetStart_Private_Void_MulticastDelegate_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06002C34 RID: 11316 RVA: 0x000E5138 File Offset: 0x000E3338
		public unsafe int ManagedThreadId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204126, XrefRangeEnd = 204127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_get_ManagedThreadId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x000E5174 File Offset: 0x000E3374
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 204129, RefRangeEnd = 204133, XrefRangeStart = 204127, XrefRangeEnd = 204129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginCriticalRegion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_BeginCriticalRegion_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x000E519C File Offset: 0x000E339C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204135, RefRangeEnd = 204138, XrefRangeStart = 204133, XrefRangeEnd = 204135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndCriticalRegion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_EndCriticalRegion_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x000E51C4 File Offset: 0x000E33C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x000E5200 File Offset: 0x000E3400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204138, XrefRangeEnd = 204142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadState ValidateThreadState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thread.NativeMethodInfoPtr_ValidateThreadState_Private_ThreadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x0000F2DF File Offset: 0x0000D4DF
		public Thread(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06002C3A RID: 11322 RVA: 0x000E523C File Offset: 0x000E343C
		// (set) Token: 0x06002C3B RID: 11323 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		public unsafe static LocalDataStoreMgr s_LocalDataStoreMgr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_s_LocalDataStoreMgr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreMgr>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_s_LocalDataStoreMgr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06002C3C RID: 11324 RVA: 0x000E5264 File Offset: 0x000E3464
		// (set) Token: 0x06002C3D RID: 11325 RVA: 0x0000F2FA File Offset: 0x0000D4FA
		public unsafe static LocalDataStoreHolder s_LocalDataStore
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_s_LocalDataStore, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreHolder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_s_LocalDataStore, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06002C3E RID: 11326 RVA: 0x000E528C File Offset: 0x000E348C
		// (set) Token: 0x06002C3F RID: 11327 RVA: 0x0000F30C File Offset: 0x0000D50C
		public unsafe static CultureInfo m_CurrentCulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_m_CurrentCulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_m_CurrentCulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06002C40 RID: 11328 RVA: 0x000E52B4 File Offset: 0x000E34B4
		// (set) Token: 0x06002C41 RID: 11329 RVA: 0x0000F31E File Offset: 0x0000D51E
		public unsafe static CultureInfo m_CurrentUICulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_m_CurrentUICulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_m_CurrentUICulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06002C42 RID: 11330 RVA: 0x000E52DC File Offset: 0x000E34DC
		// (set) Token: 0x06002C43 RID: 11331 RVA: 0x0000F330 File Offset: 0x0000D530
		public unsafe static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_s_asyncLocalCurrentCulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncLocal<CultureInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_s_asyncLocalCurrentCulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06002C44 RID: 11332 RVA: 0x000E5304 File Offset: 0x000E3504
		// (set) Token: 0x06002C45 RID: 11333 RVA: 0x0000F342 File Offset: 0x0000D542
		public unsafe static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_s_asyncLocalCurrentUICulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncLocal<CultureInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_s_asyncLocalCurrentUICulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06002C46 RID: 11334 RVA: 0x000E532C File Offset: 0x000E352C
		// (set) Token: 0x06002C47 RID: 11335 RVA: 0x0000F354 File Offset: 0x0000D554
		public unsafe InternalThread internal_thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_internal_thread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InternalThread>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_internal_thread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06002C48 RID: 11336 RVA: 0x000E535C File Offset: 0x000E355C
		// (set) Token: 0x06002C49 RID: 11337 RVA: 0x0000F373 File Offset: 0x0000D573
		public unsafe Object m_ThreadStartArg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ThreadStartArg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ThreadStartArg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x000E538C File Offset: 0x000E358C
		// (set) Token: 0x06002C4B RID: 11339 RVA: 0x0000F392 File Offset: 0x0000D592
		public unsafe Object pending_exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_pending_exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_pending_exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06002C4C RID: 11340 RVA: 0x000E53BC File Offset: 0x000E35BC
		// (set) Token: 0x06002C4D RID: 11341 RVA: 0x0000F3B1 File Offset: 0x0000D5B1
		public unsafe IPrincipal principal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_principal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPrincipal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_principal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06002C4E RID: 11342 RVA: 0x000E53EC File Offset: 0x000E35EC
		// (set) Token: 0x06002C4F RID: 11343 RVA: 0x0000F3D0 File Offset: 0x0000D5D0
		public unsafe int principal_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_principal_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_principal_version)) = value;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06002C50 RID: 11344 RVA: 0x000E5414 File Offset: 0x000E3614
		// (set) Token: 0x06002C51 RID: 11345 RVA: 0x0000F3EB File Offset: 0x0000D5EB
		public unsafe static Thread current_thread
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Thread.NativeFieldInfoPtr_current_thread, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thread.NativeFieldInfoPtr_current_thread, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06002C52 RID: 11346 RVA: 0x000E543C File Offset: 0x000E363C
		// (set) Token: 0x06002C53 RID: 11347 RVA: 0x0000F3FD File Offset: 0x0000D5FD
		public unsafe MulticastDelegate m_Delegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_Delegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MulticastDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_Delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x000E546C File Offset: 0x000E366C
		// (set) Token: 0x06002C55 RID: 11349 RVA: 0x0000F41C File Offset: 0x0000D61C
		public unsafe ExecutionContext m_ExecutionContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ExecutionContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x000E549C File Offset: 0x000E369C
		// (set) Token: 0x06002C57 RID: 11351 RVA: 0x0000F43B File Offset: 0x0000D63B
		public unsafe bool m_ExecutionContextBelongsToOuterScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ExecutionContextBelongsToOuterScope);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thread.NativeFieldInfoPtr_m_ExecutionContextBelongsToOuterScope)) = value;
			}
		}

		// Token: 0x04002669 RID: 9833
		private static readonly IntPtr NativeFieldInfoPtr_s_LocalDataStoreMgr;

		// Token: 0x0400266A RID: 9834
		private static readonly IntPtr NativeFieldInfoPtr_s_LocalDataStore;

		// Token: 0x0400266B RID: 9835
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentCulture;

		// Token: 0x0400266C RID: 9836
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentUICulture;

		// Token: 0x0400266D RID: 9837
		private static readonly IntPtr NativeFieldInfoPtr_s_asyncLocalCurrentCulture;

		// Token: 0x0400266E RID: 9838
		private static readonly IntPtr NativeFieldInfoPtr_s_asyncLocalCurrentUICulture;

		// Token: 0x0400266F RID: 9839
		private static readonly IntPtr NativeFieldInfoPtr_internal_thread;

		// Token: 0x04002670 RID: 9840
		private static readonly IntPtr NativeFieldInfoPtr_m_ThreadStartArg;

		// Token: 0x04002671 RID: 9841
		private static readonly IntPtr NativeFieldInfoPtr_pending_exception;

		// Token: 0x04002672 RID: 9842
		private static readonly IntPtr NativeFieldInfoPtr_principal;

		// Token: 0x04002673 RID: 9843
		private static readonly IntPtr NativeFieldInfoPtr_principal_version;

		// Token: 0x04002674 RID: 9844
		private static readonly IntPtr NativeFieldInfoPtr_current_thread;

		// Token: 0x04002675 RID: 9845
		private static readonly IntPtr NativeFieldInfoPtr_m_Delegate;

		// Token: 0x04002676 RID: 9846
		private static readonly IntPtr NativeFieldInfoPtr_m_ExecutionContext;

		// Token: 0x04002677 RID: 9847
		private static readonly IntPtr NativeFieldInfoPtr_m_ExecutionContextBelongsToOuterScope;

		// Token: 0x04002678 RID: 9848
		private static readonly IntPtr NativeMethodInfoPtr_AsyncLocalSetCurrentCulture_Private_Static_Void_AsyncLocalValueChangedArgs_1_CultureInfo_0;

		// Token: 0x04002679 RID: 9849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ThreadStart_0;

		// Token: 0x0400267A RID: 9850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ParameterizedThreadStart_0;

		// Token: 0x0400267B RID: 9851
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400267C RID: 9852
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_Object_0;

		// Token: 0x0400267D RID: 9853
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_byref_StackCrawlMark_0;

		// Token: 0x0400267E RID: 9854
		private static readonly IntPtr NativeMethodInfoPtr_GetExecutionContextReader_Internal_Reader_0;

		// Token: 0x0400267F RID: 9855
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutionContextBelongsToCurrentScope_Internal_get_Boolean_0;

		// Token: 0x04002680 RID: 9856
		private static readonly IntPtr NativeMethodInfoPtr_set_ExecutionContextBelongsToCurrentScope_Internal_set_Void_Boolean_0;

		// Token: 0x04002681 RID: 9857
		private static readonly IntPtr NativeMethodInfoPtr_GetMutableExecutionContext_Internal_ExecutionContext_0;

		// Token: 0x04002682 RID: 9858
		private static readonly IntPtr NativeMethodInfoPtr_SetExecutionContext_Internal_Void_ExecutionContext_Boolean_0;

		// Token: 0x04002683 RID: 9859
		private static readonly IntPtr NativeMethodInfoPtr_SetExecutionContext_Internal_Void_Reader_Boolean_0;

		// Token: 0x04002684 RID: 9860
		private static readonly IntPtr NativeMethodInfoPtr_SleepInternal_Private_Static_Void_Int32_0;

		// Token: 0x04002685 RID: 9861
		private static readonly IntPtr NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0;

		// Token: 0x04002686 RID: 9862
		private static readonly IntPtr NativeMethodInfoPtr_YieldInternal_Private_Static_Boolean_0;

		// Token: 0x04002687 RID: 9863
		private static readonly IntPtr NativeMethodInfoPtr_Yield_Public_Static_Boolean_0;

		// Token: 0x04002688 RID: 9864
		private static readonly IntPtr NativeMethodInfoPtr_SetStartHelper_Private_Void_Delegate_Int32_0;

		// Token: 0x04002689 RID: 9865
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentUICulture_Public_get_CultureInfo_0;

		// Token: 0x0400268A RID: 9866
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentUICultureNoAppX_Internal_CultureInfo_0;

		// Token: 0x0400268B RID: 9867
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCulture_Public_get_CultureInfo_0;

		// Token: 0x0400268C RID: 9868
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentCulture_Public_set_Void_CultureInfo_0;

		// Token: 0x0400268D RID: 9869
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentCultureNoAppX_Private_CultureInfo_0;

		// Token: 0x0400268E RID: 9870
		private static readonly IntPtr NativeMethodInfoPtr_nativeInitCultureAccessors_Private_Static_Void_0;

		// Token: 0x0400268F RID: 9871
		private static readonly IntPtr NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0;

		// Token: 0x04002690 RID: 9872
		private static readonly IntPtr NativeMethodInfoPtr_ConstructInternalThread_Private_Void_0;

		// Token: 0x04002691 RID: 9873
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Private_get_InternalThread_0;

		// Token: 0x04002692 RID: 9874
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentContext_Public_Static_get_Context_0;

		// Token: 0x04002693 RID: 9875
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentThread_Private_Static_Thread_0;

		// Token: 0x04002694 RID: 9876
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentThread_Public_Static_get_Thread_0;

		// Token: 0x04002695 RID: 9877
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentThreadId_Internal_Static_get_Int32_0;

		// Token: 0x04002696 RID: 9878
		private static readonly IntPtr NativeMethodInfoPtr_GetDomainID_Public_Static_Int32_0;

		// Token: 0x04002697 RID: 9879
		private static readonly IntPtr NativeMethodInfoPtr_Thread_internal_Private_IntPtr_MulticastDelegate_0;

		// Token: 0x04002698 RID: 9880
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002699 RID: 9881
		private static readonly IntPtr NativeMethodInfoPtr_get_IsThreadPoolThread_Public_get_Boolean_0;

		// Token: 0x0400269A RID: 9882
		private static readonly IntPtr NativeMethodInfoPtr_get_IsThreadPoolThreadInternal_Internal_get_Boolean_0;

		// Token: 0x0400269B RID: 9883
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0;

		// Token: 0x0400269C RID: 9884
		private static readonly IntPtr NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0;

		// Token: 0x0400269D RID: 9885
		private static readonly IntPtr NativeMethodInfoPtr_SetName_internal_Private_Static_Void_InternalThread_String_0;

		// Token: 0x0400269E RID: 9886
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x0400269F RID: 9887
		private static readonly IntPtr NativeMethodInfoPtr_get_ThreadState_Public_get_ThreadState_0;

		// Token: 0x040026A0 RID: 9888
		private static readonly IntPtr NativeMethodInfoPtr_SpinWait_nop_Private_Static_Void_0;

		// Token: 0x040026A1 RID: 9889
		private static readonly IntPtr NativeMethodInfoPtr_SpinWait_Public_Static_Void_Int32_0;

		// Token: 0x040026A2 RID: 9890
		private static readonly IntPtr NativeMethodInfoPtr_StartInternal_Private_Void_IPrincipal_byref_StackCrawlMark_0;

		// Token: 0x040026A3 RID: 9891
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Private_Static_Void_InternalThread_ThreadState_0;

		// Token: 0x040026A4 RID: 9892
		private static readonly IntPtr NativeMethodInfoPtr_ClrState_Private_Static_Void_InternalThread_ThreadState_0;

		// Token: 0x040026A5 RID: 9893
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Private_Static_ThreadState_InternalThread_0;

		// Token: 0x040026A6 RID: 9894
		private static readonly IntPtr NativeMethodInfoPtr_SystemMaxStackStize_Private_Static_Int32_0;

		// Token: 0x040026A7 RID: 9895
		private static readonly IntPtr NativeMethodInfoPtr_GetProcessDefaultStackSize_Private_Static_Int32_Int32_0;

		// Token: 0x040026A8 RID: 9896
		private static readonly IntPtr NativeMethodInfoPtr_SetStart_Private_Void_MulticastDelegate_Int32_0;

		// Token: 0x040026A9 RID: 9897
		private static readonly IntPtr NativeMethodInfoPtr_get_ManagedThreadId_Public_get_Int32_0;

		// Token: 0x040026AA RID: 9898
		private static readonly IntPtr NativeMethodInfoPtr_BeginCriticalRegion_Public_Static_Void_0;

		// Token: 0x040026AB RID: 9899
		private static readonly IntPtr NativeMethodInfoPtr_EndCriticalRegion_Public_Static_Void_0;

		// Token: 0x040026AC RID: 9900
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040026AD RID: 9901
		private static readonly IntPtr NativeMethodInfoPtr_ValidateThreadState_Private_ThreadState_0;
	}
}
