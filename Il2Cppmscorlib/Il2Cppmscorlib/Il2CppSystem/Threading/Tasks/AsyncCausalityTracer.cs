using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A0 RID: 672
	public static class AsyncCausalityTracer : Object
	{
		// Token: 0x06002DE1 RID: 11745 RVA: 0x000EA560 File Offset: 0x000E8760
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncCausalityTracer()
		{
			Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "AsyncCausalityTracer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr);
			AsyncCausalityTracer.NativeMethodInfoPtr_get_LoggingOn_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100670592);
			AsyncCausalityTracer.NativeMethodInfoPtr_TraceOperationCreation_Internal_Static_Void_CausalityTraceLevel_Int32_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100670593);
			AsyncCausalityTracer.NativeMethodInfoPtr_TraceOperationCompletion_Internal_Static_Void_CausalityTraceLevel_Int32_AsyncCausalityStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100670594);
			AsyncCausalityTracer.NativeMethodInfoPtr_TraceOperationRelation_Internal_Static_Void_CausalityTraceLevel_Int32_CausalityRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100670595);
			AsyncCausalityTracer.NativeMethodInfoPtr_TraceSynchronousWorkStart_Internal_Static_Void_CausalityTraceLevel_Int32_CausalitySynchronousWork_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100670596);
			AsyncCausalityTracer.NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Internal_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100670597);
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002DE2 RID: 11746 RVA: 0x000EA608 File Offset: 0x000E8808
		public unsafe static bool LoggingOn
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_get_LoggingOn_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x000EA638 File Offset: 0x000E8838
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taskId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(operationName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relatedContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_TraceOperationCreation_Internal_Static_Void_CausalityTraceLevel_Int32_String_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x000EA698 File Offset: 0x000E8898
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taskId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_TraceOperationCompletion_Internal_Static_Void_CausalityTraceLevel_Int32_AsyncCausalityStatus_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x000EA6E8 File Offset: 0x000E88E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceOperationRelation(CausalityTraceLevel traceLevel, int taskId, CausalityRelation relation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taskId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_TraceOperationRelation_Internal_Static_Void_CausalityTraceLevel_Int32_CausalityRelation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x000EA738 File Offset: 0x000E8938
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taskId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref work;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_TraceSynchronousWorkStart_Internal_Static_Void_CausalityTraceLevel_Int32_CausalitySynchronousWork_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x000EA788 File Offset: 0x000E8988
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref work;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncCausalityTracer.NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Internal_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x0000FFDB File Offset: 0x0000E1DB
		public AsyncCausalityTracer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040027C4 RID: 10180
		private static readonly IntPtr NativeMethodInfoPtr_get_LoggingOn_Internal_Static_get_Boolean_0;

		// Token: 0x040027C5 RID: 10181
		private static readonly IntPtr NativeMethodInfoPtr_TraceOperationCreation_Internal_Static_Void_CausalityTraceLevel_Int32_String_UInt64_0;

		// Token: 0x040027C6 RID: 10182
		private static readonly IntPtr NativeMethodInfoPtr_TraceOperationCompletion_Internal_Static_Void_CausalityTraceLevel_Int32_AsyncCausalityStatus_0;

		// Token: 0x040027C7 RID: 10183
		private static readonly IntPtr NativeMethodInfoPtr_TraceOperationRelation_Internal_Static_Void_CausalityTraceLevel_Int32_CausalityRelation_0;

		// Token: 0x040027C8 RID: 10184
		private static readonly IntPtr NativeMethodInfoPtr_TraceSynchronousWorkStart_Internal_Static_Void_CausalityTraceLevel_Int32_CausalitySynchronousWork_0;

		// Token: 0x040027C9 RID: 10185
		private static readonly IntPtr NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Internal_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0;
	}
}
