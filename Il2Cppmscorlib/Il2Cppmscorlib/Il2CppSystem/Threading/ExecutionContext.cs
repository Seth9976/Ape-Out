using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000272 RID: 626
	[Serializable]
	public sealed class ExecutionContext : Object
	{
		// Token: 0x06002B5D RID: 11101 RVA: 0x000E16A8 File Offset: 0x000DF8A8
		// Note: this type is marked as 'beforefieldinit'.
		static ExecutionContext()
		{
			Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ExecutionContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr);
			ExecutionContext.NativeFieldInfoPtr__syncContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_syncContext");
			ExecutionContext.NativeFieldInfoPtr__syncContextNoFlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_syncContextNoFlow");
			ExecutionContext.NativeFieldInfoPtr__logicalCallContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_logicalCallContext");
			ExecutionContext.NativeFieldInfoPtr__illogicalCallContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_illogicalCallContext");
			ExecutionContext.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_flags");
			ExecutionContext.NativeFieldInfoPtr__localValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_localValues");
			ExecutionContext.NativeFieldInfoPtr__localChangeNotifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "_localChangeNotifications");
			ExecutionContext.NativeFieldInfoPtr_s_dummyDefaultEC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "s_dummyDefaultEC");
			ExecutionContext.NativeMethodInfoPtr_get_isNewCapture_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670244);
			ExecutionContext.NativeMethodInfoPtr_set_isNewCapture_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670245);
			ExecutionContext.NativeMethodInfoPtr_get_isFlowSuppressed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670246);
			ExecutionContext.NativeMethodInfoPtr_set_isFlowSuppressed_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670247);
			ExecutionContext.NativeMethodInfoPtr_get_PreAllocatedDefault_Internal_Static_get_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670248);
			ExecutionContext.NativeMethodInfoPtr_get_IsPreAllocatedDefault_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670249);
			ExecutionContext.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670250);
			ExecutionContext.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670251);
			ExecutionContext.NativeMethodInfoPtr_GetLocalValue_Internal_Static_Object_IAsyncLocal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670252);
			ExecutionContext.NativeMethodInfoPtr_SetLocalValue_Internal_Static_Void_IAsyncLocal_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670253);
			ExecutionContext.NativeMethodInfoPtr_OnAsyncLocalContextChanged_Internal_Static_Void_ExecutionContext_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670254);
			ExecutionContext.NativeMethodInfoPtr_get_LogicalCallContext_Internal_get_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670255);
			ExecutionContext.NativeMethodInfoPtr_set_LogicalCallContext_Internal_set_Void_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670256);
			ExecutionContext.NativeMethodInfoPtr_get_IllogicalCallContext_Internal_get_IllogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670257);
			ExecutionContext.NativeMethodInfoPtr_set_IllogicalCallContext_Internal_set_Void_IllogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670258);
			ExecutionContext.NativeMethodInfoPtr_get_SynchronizationContext_Internal_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670259);
			ExecutionContext.NativeMethodInfoPtr_set_SynchronizationContext_Internal_set_Void_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670260);
			ExecutionContext.NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Internal_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670261);
			ExecutionContext.NativeMethodInfoPtr_set_SynchronizationContextNoFlow_Internal_set_Void_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670262);
			ExecutionContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670263);
			ExecutionContext.NativeMethodInfoPtr_Run_Public_Static_Void_ExecutionContext_ContextCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670264);
			ExecutionContext.NativeMethodInfoPtr_Run_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670265);
			ExecutionContext.NativeMethodInfoPtr_RunInternal_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670266);
			ExecutionContext.NativeMethodInfoPtr_EstablishCopyOnWriteScope_Internal_Static_Void_byref_ExecutionContextSwitcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670267);
			ExecutionContext.NativeMethodInfoPtr_EstablishCopyOnWriteScope_Private_Static_Void_Thread_Boolean_byref_ExecutionContextSwitcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670268);
			ExecutionContext.NativeMethodInfoPtr_SetExecutionContext_Internal_Static_ExecutionContextSwitcher_ExecutionContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670269);
			ExecutionContext.NativeMethodInfoPtr_CreateCopy_Public_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670270);
			ExecutionContext.NativeMethodInfoPtr_CreateMutableCopy_Internal_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670271);
			ExecutionContext.NativeMethodInfoPtr_IsFlowSuppressed_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670272);
			ExecutionContext.NativeMethodInfoPtr_Capture_Public_Static_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670273);
			ExecutionContext.NativeMethodInfoPtr_FastCapture_Internal_Static_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670274);
			ExecutionContext.NativeMethodInfoPtr_Capture_Internal_Static_ExecutionContext_byref_StackCrawlMark_CaptureOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670275);
			ExecutionContext.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670276);
			ExecutionContext.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670277);
			ExecutionContext.NativeMethodInfoPtr_IsDefaultFTContext_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, 100670278);
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06002B5E RID: 11102 RVA: 0x000E1A34 File Offset: 0x000DFC34
		// (set) Token: 0x06002B5F RID: 11103 RVA: 0x000E1A70 File Offset: 0x000DFC70
		public unsafe bool isNewCapture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_isNewCapture_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_isNewCapture_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06002B60 RID: 11104 RVA: 0x000E1AB0 File Offset: 0x000DFCB0
		// (set) Token: 0x06002B61 RID: 11105 RVA: 0x000E1AEC File Offset: 0x000DFCEC
		public unsafe bool isFlowSuppressed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_isFlowSuppressed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_isFlowSuppressed_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06002B62 RID: 11106 RVA: 0x000E1B2C File Offset: 0x000DFD2C
		public unsafe static ExecutionContext PreAllocatedDefault
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201113, XrefRangeEnd = 201117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_PreAllocatedDefault_Internal_Static_get_ExecutionContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06002B63 RID: 11107 RVA: 0x000E1B60 File Offset: 0x000DFD60
		public unsafe bool IsPreAllocatedDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_IsPreAllocatedDefault_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x000E1B9C File Offset: 0x000DFD9C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x000E1BD8 File Offset: 0x000DFDD8
		[CallerCount(0)]
		public unsafe ExecutionContext(bool isPreAllocatedDefault)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isPreAllocatedDefault;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x000E1C20 File Offset: 0x000DFE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201117, XrefRangeEnd = 201119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetLocalValue(IAsyncLocal local)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(local);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_GetLocalValue_Internal_Static_Object_IAsyncLocal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x000E1C64 File Offset: 0x000DFE64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201150, RefRangeEnd = 201151, XrefRangeStart = 201119, XrefRangeEnd = 201150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLocalValue(IAsyncLocal local, Object newValue, bool needChangeNotifications)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(local);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needChangeNotifications;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_SetLocalValue_Internal_Static_Void_IAsyncLocal_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x000E1CBC File Offset: 0x000DFEBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201176, RefRangeEnd = 201178, XrefRangeStart = 201151, XrefRangeEnd = 201176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previous);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(current);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_OnAsyncLocalContextChanged_Internal_Static_Void_ExecutionContext_ExecutionContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x000E1D04 File Offset: 0x000DFF04
		// (set) Token: 0x06002B6A RID: 11114 RVA: 0x000E1D44 File Offset: 0x000DFF44
		public unsafe LogicalCallContext LogicalCallContext
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 201181, RefRangeEnd = 201187, XrefRangeStart = 201178, XrefRangeEnd = 201181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_LogicalCallContext_Internal_get_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_LogicalCallContext_Internal_set_Void_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06002B6B RID: 11115 RVA: 0x000E1D88 File Offset: 0x000DFF88
		// (set) Token: 0x06002B6C RID: 11116 RVA: 0x000E1DC8 File Offset: 0x000DFFC8
		public unsafe IllogicalCallContext IllogicalCallContext
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201187, XrefRangeEnd = 201190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_IllogicalCallContext_Internal_get_IllogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IllogicalCallContext>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_IllogicalCallContext_Internal_set_Void_IllogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06002B6D RID: 11117 RVA: 0x000E1E0C File Offset: 0x000E000C
		// (set) Token: 0x06002B6E RID: 11118 RVA: 0x000E1E4C File Offset: 0x000E004C
		public unsafe SynchronizationContext SynchronizationContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_SynchronizationContext_Internal_get_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_SynchronizationContext_Internal_set_Void_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06002B6F RID: 11119 RVA: 0x000E1E90 File Offset: 0x000E0090
		// (set) Token: 0x06002B70 RID: 11120 RVA: 0x000E1ED0 File Offset: 0x000E00D0
		public unsafe SynchronizationContext SynchronizationContextNoFlow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Internal_get_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_set_SynchronizationContextNoFlow_Internal_set_Void_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x000E1F14 File Offset: 0x000E0114
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 33858, RefRangeEnd = 33864, XrefRangeStart = 33858, XrefRangeEnd = 33864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x000E1F48 File Offset: 0x000E0148
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 201194, RefRangeEnd = 201198, XrefRangeStart = 201190, XrefRangeEnd = 201194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Run(ExecutionContext executionContext, ContextCallback callback, Object state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_Run_Public_Static_Void_ExecutionContext_ContextCallback_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x000E1FA4 File Offset: 0x000E01A4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 201202, RefRangeEnd = 201210, XrefRangeStart = 201198, XrefRangeEnd = 201202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Run(ExecutionContext executionContext, ContextCallback callback, Object state, bool preserveSyncCtx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveSyncCtx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_Run_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x000E200C File Offset: 0x000E020C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201228, RefRangeEnd = 201229, XrefRangeStart = 201210, XrefRangeEnd = 201228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, bool preserveSyncCtx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveSyncCtx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_RunInternal_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x000E2074 File Offset: 0x000E0274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201229, XrefRangeEnd = 201234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ecsw));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_EstablishCopyOnWriteScope_Internal_Static_Void_byref_ExecutionContextSwitcher_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x000E20B0 File Offset: 0x000E02B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 201234, RefRangeEnd = 201239, XrefRangeStart = 201234, XrefRangeEnd = 201234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentThread);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref knownNullWindowsIdentity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ecsw));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_EstablishCopyOnWriteScope_Private_Static_Void_Thread_Boolean_byref_ExecutionContextSwitcher_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x000E210C File Offset: 0x000E030C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201244, RefRangeEnd = 201245, XrefRangeStart = 201239, XrefRangeEnd = 201244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveSyncCtx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_SetExecutionContext_Internal_Static_ExecutionContextSwitcher_ExecutionContext_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ExecutionContextSwitcher(intPtr);
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x000E2158 File Offset: 0x000E0358
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 201256, RefRangeEnd = 201260, XrefRangeStart = 201245, XrefRangeEnd = 201256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext CreateCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_CreateCopy_Public_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000E2198 File Offset: 0x000E0398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201273, RefRangeEnd = 201274, XrefRangeStart = 201260, XrefRangeEnd = 201273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext CreateMutableCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_CreateMutableCopy_Internal_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x000E21D8 File Offset: 0x000E03D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 201275, RefRangeEnd = 201278, XrefRangeStart = 201274, XrefRangeEnd = 201275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFlowSuppressed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_IsFlowSuppressed_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x000E2208 File Offset: 0x000E0408
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201282, RefRangeEnd = 201284, XrefRangeStart = 201278, XrefRangeEnd = 201282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExecutionContext Capture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_Capture_Public_Static_ExecutionContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x000E223C File Offset: 0x000E043C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201288, RefRangeEnd = 201290, XrefRangeStart = 201284, XrefRangeEnd = 201288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExecutionContext FastCapture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_FastCapture_Internal_Static_ExecutionContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x000E2270 File Offset: 0x000E0470
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 201292, RefRangeEnd = 201302, XrefRangeStart = 201290, XrefRangeEnd = 201292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &stackMark;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_Capture_Internal_Static_ExecutionContext_byref_StackCrawlMark_CaptureOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x000E22C0 File Offset: 0x000E04C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201302, XrefRangeEnd = 201311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x000E231C File Offset: 0x000E051C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201311, XrefRangeEnd = 201320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionContext(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x000E2380 File Offset: 0x000E0580
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 201320, RefRangeEnd = 201323, XrefRangeStart = 201320, XrefRangeEnd = 201320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDefaultFTContext(bool ignoreSyncCtx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ignoreSyncCtx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.NativeMethodInfoPtr_IsDefaultFTContext_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x0000EFF9 File Offset: 0x0000D1F9
		public ExecutionContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06002B82 RID: 11138 RVA: 0x000E23CC File Offset: 0x000E05CC
		// (set) Token: 0x06002B83 RID: 11139 RVA: 0x0000F002 File Offset: 0x0000D202
		public unsafe SynchronizationContext _syncContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__syncContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__syncContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x000E23FC File Offset: 0x000E05FC
		// (set) Token: 0x06002B85 RID: 11141 RVA: 0x0000F021 File Offset: 0x0000D221
		public unsafe SynchronizationContext _syncContextNoFlow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__syncContextNoFlow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__syncContextNoFlow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x000E242C File Offset: 0x000E062C
		// (set) Token: 0x06002B87 RID: 11143 RVA: 0x0000F040 File Offset: 0x0000D240
		public unsafe LogicalCallContext _logicalCallContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__logicalCallContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__logicalCallContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x000E245C File Offset: 0x000E065C
		// (set) Token: 0x06002B89 RID: 11145 RVA: 0x0000F05F File Offset: 0x0000D25F
		public unsafe IllogicalCallContext _illogicalCallContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__illogicalCallContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IllogicalCallContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__illogicalCallContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x000E248C File Offset: 0x000E068C
		// (set) Token: 0x06002B8B RID: 11147 RVA: 0x0000F07E File Offset: 0x0000D27E
		public unsafe ExecutionContext.Flags _flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__flags)) = value;
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06002B8C RID: 11148 RVA: 0x000E24B4 File Offset: 0x000E06B4
		// (set) Token: 0x06002B8D RID: 11149 RVA: 0x0000F099 File Offset: 0x0000D299
		public unsafe Dictionary<IAsyncLocal, Object> _localValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__localValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IAsyncLocal, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__localValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06002B8E RID: 11150 RVA: 0x000E24E4 File Offset: 0x000E06E4
		// (set) Token: 0x06002B8F RID: 11151 RVA: 0x0000F0B8 File Offset: 0x0000D2B8
		public unsafe List<IAsyncLocal> _localChangeNotifications
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__localChangeNotifications);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IAsyncLocal>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.NativeFieldInfoPtr__localChangeNotifications), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06002B90 RID: 11152 RVA: 0x000E2514 File Offset: 0x000E0714
		// (set) Token: 0x06002B91 RID: 11153 RVA: 0x0000F0D7 File Offset: 0x0000D2D7
		public unsafe static ExecutionContext s_dummyDefaultEC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecutionContext.NativeFieldInfoPtr_s_dummyDefaultEC, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecutionContext.NativeFieldInfoPtr_s_dummyDefaultEC, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040025F1 RID: 9713
		private static readonly IntPtr NativeFieldInfoPtr__syncContext;

		// Token: 0x040025F2 RID: 9714
		private static readonly IntPtr NativeFieldInfoPtr__syncContextNoFlow;

		// Token: 0x040025F3 RID: 9715
		private static readonly IntPtr NativeFieldInfoPtr__logicalCallContext;

		// Token: 0x040025F4 RID: 9716
		private static readonly IntPtr NativeFieldInfoPtr__illogicalCallContext;

		// Token: 0x040025F5 RID: 9717
		private static readonly IntPtr NativeFieldInfoPtr__flags;

		// Token: 0x040025F6 RID: 9718
		private static readonly IntPtr NativeFieldInfoPtr__localValues;

		// Token: 0x040025F7 RID: 9719
		private static readonly IntPtr NativeFieldInfoPtr__localChangeNotifications;

		// Token: 0x040025F8 RID: 9720
		private static readonly IntPtr NativeFieldInfoPtr_s_dummyDefaultEC;

		// Token: 0x040025F9 RID: 9721
		private static readonly IntPtr NativeMethodInfoPtr_get_isNewCapture_Internal_get_Boolean_0;

		// Token: 0x040025FA RID: 9722
		private static readonly IntPtr NativeMethodInfoPtr_set_isNewCapture_Internal_set_Void_Boolean_0;

		// Token: 0x040025FB RID: 9723
		private static readonly IntPtr NativeMethodInfoPtr_get_isFlowSuppressed_Internal_get_Boolean_0;

		// Token: 0x040025FC RID: 9724
		private static readonly IntPtr NativeMethodInfoPtr_set_isFlowSuppressed_Internal_set_Void_Boolean_0;

		// Token: 0x040025FD RID: 9725
		private static readonly IntPtr NativeMethodInfoPtr_get_PreAllocatedDefault_Internal_Static_get_ExecutionContext_0;

		// Token: 0x040025FE RID: 9726
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPreAllocatedDefault_Internal_get_Boolean_0;

		// Token: 0x040025FF RID: 9727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002600 RID: 9728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04002601 RID: 9729
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalValue_Internal_Static_Object_IAsyncLocal_0;

		// Token: 0x04002602 RID: 9730
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalValue_Internal_Static_Void_IAsyncLocal_Object_Boolean_0;

		// Token: 0x04002603 RID: 9731
		private static readonly IntPtr NativeMethodInfoPtr_OnAsyncLocalContextChanged_Internal_Static_Void_ExecutionContext_ExecutionContext_0;

		// Token: 0x04002604 RID: 9732
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Internal_get_LogicalCallContext_0;

		// Token: 0x04002605 RID: 9733
		private static readonly IntPtr NativeMethodInfoPtr_set_LogicalCallContext_Internal_set_Void_LogicalCallContext_0;

		// Token: 0x04002606 RID: 9734
		private static readonly IntPtr NativeMethodInfoPtr_get_IllogicalCallContext_Internal_get_IllogicalCallContext_0;

		// Token: 0x04002607 RID: 9735
		private static readonly IntPtr NativeMethodInfoPtr_set_IllogicalCallContext_Internal_set_Void_IllogicalCallContext_0;

		// Token: 0x04002608 RID: 9736
		private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizationContext_Internal_get_SynchronizationContext_0;

		// Token: 0x04002609 RID: 9737
		private static readonly IntPtr NativeMethodInfoPtr_set_SynchronizationContext_Internal_set_Void_SynchronizationContext_0;

		// Token: 0x0400260A RID: 9738
		private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Internal_get_SynchronizationContext_0;

		// Token: 0x0400260B RID: 9739
		private static readonly IntPtr NativeMethodInfoPtr_set_SynchronizationContextNoFlow_Internal_set_Void_SynchronizationContext_0;

		// Token: 0x0400260C RID: 9740
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400260D RID: 9741
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Void_ExecutionContext_ContextCallback_Object_0;

		// Token: 0x0400260E RID: 9742
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0;

		// Token: 0x0400260F RID: 9743
		private static readonly IntPtr NativeMethodInfoPtr_RunInternal_Internal_Static_Void_ExecutionContext_ContextCallback_Object_Boolean_0;

		// Token: 0x04002610 RID: 9744
		private static readonly IntPtr NativeMethodInfoPtr_EstablishCopyOnWriteScope_Internal_Static_Void_byref_ExecutionContextSwitcher_0;

		// Token: 0x04002611 RID: 9745
		private static readonly IntPtr NativeMethodInfoPtr_EstablishCopyOnWriteScope_Private_Static_Void_Thread_Boolean_byref_ExecutionContextSwitcher_0;

		// Token: 0x04002612 RID: 9746
		private static readonly IntPtr NativeMethodInfoPtr_SetExecutionContext_Internal_Static_ExecutionContextSwitcher_ExecutionContext_Boolean_0;

		// Token: 0x04002613 RID: 9747
		private static readonly IntPtr NativeMethodInfoPtr_CreateCopy_Public_ExecutionContext_0;

		// Token: 0x04002614 RID: 9748
		private static readonly IntPtr NativeMethodInfoPtr_CreateMutableCopy_Internal_ExecutionContext_0;

		// Token: 0x04002615 RID: 9749
		private static readonly IntPtr NativeMethodInfoPtr_IsFlowSuppressed_Public_Static_Boolean_0;

		// Token: 0x04002616 RID: 9750
		private static readonly IntPtr NativeMethodInfoPtr_Capture_Public_Static_ExecutionContext_0;

		// Token: 0x04002617 RID: 9751
		private static readonly IntPtr NativeMethodInfoPtr_FastCapture_Internal_Static_ExecutionContext_0;

		// Token: 0x04002618 RID: 9752
		private static readonly IntPtr NativeMethodInfoPtr_Capture_Internal_Static_ExecutionContext_byref_StackCrawlMark_CaptureOptions_0;

		// Token: 0x04002619 RID: 9753
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400261A RID: 9754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400261B RID: 9755
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultFTContext_Internal_Boolean_Boolean_0;

		// Token: 0x020005EE RID: 1518
		[OriginalName("mscorlib.dll", "", "Flags")]
		public enum Flags
		{
			// Token: 0x04004425 RID: 17445
			None,
			// Token: 0x04004426 RID: 17446
			IsNewCapture,
			// Token: 0x04004427 RID: 17447
			IsFlowSuppressed,
			// Token: 0x04004428 RID: 17448
			IsPreAllocatedDefault = 4
		}

		// Token: 0x020005EF RID: 1519
		public sealed class Reader : ValueType
		{
			// Token: 0x06005415 RID: 21525 RVA: 0x0017A38C File Offset: 0x0017858C
			// Note: this type is marked as 'beforefieldinit'.
			static Reader()
			{
				Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExecutionContext>.NativeClassPtr, "Reader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr);
				ExecutionContext.Reader.NativeFieldInfoPtr_m_ec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, "m_ec");
				ExecutionContext.Reader.NativeMethodInfoPtr__ctor_Public_Void_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670280);
				ExecutionContext.Reader.NativeMethodInfoPtr_DangerousGetRawExecutionContext_Public_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670281);
				ExecutionContext.Reader.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670282);
				ExecutionContext.Reader.NativeMethodInfoPtr_IsDefaultFTContext_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670283);
				ExecutionContext.Reader.NativeMethodInfoPtr_get_IsFlowSuppressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670284);
				ExecutionContext.Reader.NativeMethodInfoPtr_get_SynchronizationContext_Public_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670285);
				ExecutionContext.Reader.NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Public_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670286);
				ExecutionContext.Reader.NativeMethodInfoPtr_get_LogicalCallContext_Public_get_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670287);
				ExecutionContext.Reader.NativeMethodInfoPtr_GetLocalValue_Public_Object_IAsyncLocal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670288);
				ExecutionContext.Reader.NativeMethodInfoPtr_HasSameLocalValues_Public_Boolean_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, 100670289);
			}

			// Token: 0x06005416 RID: 21526 RVA: 0x0017A494 File Offset: 0x00178694
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 99329, RefRangeEnd = 99331, XrefRangeStart = 99329, XrefRangeEnd = 99331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Reader(ExecutionContext ec)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr__ctor_Public_Void_ExecutionContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005417 RID: 21527 RVA: 0x0017A4E4 File Offset: 0x001786E4
			[CallerCount(0)]
			public unsafe ExecutionContext DangerousGetRawExecutionContext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_DangerousGetRawExecutionContext_Public_ExecutionContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
			}

			// Token: 0x17001595 RID: 5525
			// (get) Token: 0x06005418 RID: 21528 RVA: 0x0017A528 File Offset: 0x00178728
			public unsafe bool IsNull
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005419 RID: 21529 RVA: 0x0017A56C File Offset: 0x0017876C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201103, XrefRangeEnd = 201105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsDefaultFTContext(bool ignoreSyncCtx)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ignoreSyncCtx;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_IsDefaultFTContext_Public_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001596 RID: 5526
			// (get) Token: 0x0600541A RID: 21530 RVA: 0x0017A5BC File Offset: 0x001787BC
			public unsafe bool IsFlowSuppressed
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_get_IsFlowSuppressed_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001597 RID: 5527
			// (get) Token: 0x0600541B RID: 21531 RVA: 0x0017A600 File Offset: 0x00178800
			public unsafe SynchronizationContext SynchronizationContext
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_get_SynchronizationContext_Public_get_SynchronizationContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
				}
			}

			// Token: 0x17001598 RID: 5528
			// (get) Token: 0x0600541C RID: 21532 RVA: 0x0017A644 File Offset: 0x00178844
			public unsafe SynchronizationContext SynchronizationContextNoFlow
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Public_get_SynchronizationContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
				}
			}

			// Token: 0x17001599 RID: 5529
			// (get) Token: 0x0600541D RID: 21533 RVA: 0x0017A688 File Offset: 0x00178888
			public unsafe LogicalCallContext.Reader LogicalCallContext
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201105, XrefRangeEnd = 201107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_get_LogicalCallContext_Public_get_Reader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new LogicalCallContext.Reader(intPtr);
				}
			}

			// Token: 0x0600541E RID: 21534 RVA: 0x0017A6C4 File Offset: 0x001788C4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 201109, RefRangeEnd = 201112, XrefRangeStart = 201107, XrefRangeEnd = 201109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object GetLocalValue(IAsyncLocal local)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(local);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_GetLocalValue_Public_Object_IAsyncLocal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600541F RID: 21535 RVA: 0x0017A71C File Offset: 0x0017891C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201112, XrefRangeEnd = 201113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool HasSameLocalValues(ExecutionContext other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionContext.Reader.NativeMethodInfoPtr_HasSameLocalValues_Public_Boolean_ExecutionContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005420 RID: 21536 RVA: 0x0001FBD8 File Offset: 0x0001DDD8
			public Reader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005421 RID: 21537 RVA: 0x0001FBE1 File Offset: 0x0001DDE1
			public Reader()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr))
			{
			}

			// Token: 0x17001594 RID: 5524
			// (get) Token: 0x06005422 RID: 21538 RVA: 0x0017A770 File Offset: 0x00178970
			// (set) Token: 0x06005423 RID: 21539 RVA: 0x0001FBF3 File Offset: 0x0001DDF3
			public unsafe ExecutionContext m_ec
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.Reader.NativeFieldInfoPtr_m_ec);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionContext.Reader.NativeFieldInfoPtr_m_ec), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004429 RID: 17449
			private static readonly IntPtr NativeFieldInfoPtr_m_ec;

			// Token: 0x0400442A RID: 17450
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ExecutionContext_0;

			// Token: 0x0400442B RID: 17451
			private static readonly IntPtr NativeMethodInfoPtr_DangerousGetRawExecutionContext_Public_ExecutionContext_0;

			// Token: 0x0400442C RID: 17452
			private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0;

			// Token: 0x0400442D RID: 17453
			private static readonly IntPtr NativeMethodInfoPtr_IsDefaultFTContext_Public_Boolean_Boolean_0;

			// Token: 0x0400442E RID: 17454
			private static readonly IntPtr NativeMethodInfoPtr_get_IsFlowSuppressed_Public_get_Boolean_0;

			// Token: 0x0400442F RID: 17455
			private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizationContext_Public_get_SynchronizationContext_0;

			// Token: 0x04004430 RID: 17456
			private static readonly IntPtr NativeMethodInfoPtr_get_SynchronizationContextNoFlow_Public_get_SynchronizationContext_0;

			// Token: 0x04004431 RID: 17457
			private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Public_get_Reader_0;

			// Token: 0x04004432 RID: 17458
			private static readonly IntPtr NativeMethodInfoPtr_GetLocalValue_Public_Object_IAsyncLocal_0;

			// Token: 0x04004433 RID: 17459
			private static readonly IntPtr NativeMethodInfoPtr_HasSameLocalValues_Public_Boolean_ExecutionContext_0;
		}

		// Token: 0x020005F0 RID: 1520
		[OriginalName("mscorlib.dll", "", "CaptureOptions")]
		[Flags]
		public enum CaptureOptions
		{
			// Token: 0x04004435 RID: 17461
			None = 0,
			// Token: 0x04004436 RID: 17462
			IgnoreSyncCtx = 1,
			// Token: 0x04004437 RID: 17463
			OptimizeDefaultCase = 2
		}
	}
}
