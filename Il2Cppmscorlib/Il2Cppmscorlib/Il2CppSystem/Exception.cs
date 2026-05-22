using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Diagnostics;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000A4 RID: 164
	[Serializable]
	public class Exception : Object
	{
		// Token: 0x06000BAC RID: 2988 RVA: 0x000587D8 File Offset: 0x000569D8
		// Note: this type is marked as 'beforefieldinit'.
		static Exception()
		{
			Il2CppClassPointerStore<Exception>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Exception");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Exception>.NativeClassPtr);
			Exception.NativeFieldInfoPtr_s_EDILock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "s_EDILock");
			Exception.NativeFieldInfoPtr__className = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_className");
			Exception.NativeFieldInfoPtr__message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_message");
			Exception.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_data");
			Exception.NativeFieldInfoPtr__innerException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_innerException");
			Exception.NativeFieldInfoPtr__helpURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_helpURL");
			Exception.NativeFieldInfoPtr__stackTrace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_stackTrace");
			Exception.NativeFieldInfoPtr__stackTraceString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_stackTraceString");
			Exception.NativeFieldInfoPtr__remoteStackTraceString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_remoteStackTraceString");
			Exception.NativeFieldInfoPtr__remoteStackIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_remoteStackIndex");
			Exception.NativeFieldInfoPtr__dynamicMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_dynamicMethods");
			Exception.NativeFieldInfoPtr__HResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_HResult");
			Exception.NativeFieldInfoPtr__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_source");
			Exception.NativeFieldInfoPtr__safeSerializationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_safeSerializationManager");
			Exception.NativeFieldInfoPtr_captured_traces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "captured_traces");
			Exception.NativeFieldInfoPtr_native_trace_ips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "native_trace_ips");
			Exception.NativeFieldInfoPtr__COMPlusExceptionCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_COMPlusExceptionCode");
			Exception.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665287);
			Exception.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665288);
			Exception.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665289);
			Exception.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665290);
			Exception.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665291);
			Exception.NativeMethodInfoPtr_get_Message_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665292);
			Exception.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665293);
			Exception.NativeMethodInfoPtr_IsImmutableAgileException_Private_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665294);
			Exception.NativeMethodInfoPtr_GetClassName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665295);
			Exception.NativeMethodInfoPtr_get_InnerException_Public_Virtual_Final_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665296);
			Exception.NativeMethodInfoPtr_get_TargetSite_Public_Virtual_Final_New_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665297);
			Exception.NativeMethodInfoPtr_get_StackTrace_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665298);
			Exception.NativeMethodInfoPtr_GetStackTrace_Private_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665299);
			Exception.NativeMethodInfoPtr_SetErrorCode_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665300);
			Exception.NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665301);
			Exception.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665302);
			Exception.NativeMethodInfoPtr_ToString_Private_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665303);
			Exception.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665304);
			Exception.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665305);
			Exception.NativeMethodInfoPtr_StripFileInfo_Private_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665306);
			Exception.NativeMethodInfoPtr_RestoreExceptionDispatchInfo_Internal_Void_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665307);
			Exception.NativeMethodInfoPtr_get_HResult_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665308);
			Exception.NativeMethodInfoPtr_set_HResult_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665309);
			Exception.NativeMethodInfoPtr_GetIl2CppType_Public_Virtual_Final_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665310);
			Exception.NativeMethodInfoPtr_GetMessageFromNativeResources_Internal_Static_String_ExceptionMessageKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665311);
			Exception.NativeMethodInfoPtr_FixRemotingException_Internal_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665312);
			Exception.NativeMethodInfoPtr_ReportUnhandledException_Internal_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665313);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00058B78 File Offset: 0x00056D78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 154414, RefRangeEnd = 154421, XrefRangeStart = 154411, XrefRangeEnd = 154414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00058BAC File Offset: 0x00056DAC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 154422, RefRangeEnd = 154434, XrefRangeStart = 154421, XrefRangeEnd = 154422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Exception>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00058BE8 File Offset: 0x00056DE8
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 154435, RefRangeEnd = 154478, XrefRangeStart = 154434, XrefRangeEnd = 154435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Exception>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00058C34 File Offset: 0x00056E34
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 154479, RefRangeEnd = 154489, XrefRangeStart = 154478, XrefRangeEnd = 154479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Exception>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00058C94 File Offset: 0x00056E94
		[CallerCount(87)]
		[CachedScanResults(RefRangeStart = 154546, RefRangeEnd = 154633, XrefRangeStart = 154489, XrefRangeEnd = 154546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Exception>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00058CF8 File Offset: 0x00056EF8
		public unsafe virtual string Message
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 154643, RefRangeEnd = 154652, XrefRangeStart = 154633, XrefRangeEnd = 154643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_get_Message_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x00058D3C File Offset: 0x00056F3C
		public unsafe virtual IDictionary Data
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154652, XrefRangeEnd = 154660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00058D88 File Offset: 0x00056F88
		[CallerCount(0)]
		public unsafe static bool IsImmutableAgileException(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_IsImmutableAgileException_Private_Static_Boolean_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00058DCC File Offset: 0x00056FCC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 154661, RefRangeEnd = 154665, XrefRangeStart = 154660, XrefRangeEnd = 154661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetClassName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_GetClassName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x00058E04 File Offset: 0x00057004
		public unsafe virtual Exception InnerException
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_get_InnerException_Public_Virtual_Final_New_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x00058E44 File Offset: 0x00057044
		public unsafe virtual MethodBase TargetSite
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154665, XrefRangeEnd = 154669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_get_TargetSite_Public_Virtual_Final_New_get_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x00058E84 File Offset: 0x00057084
		public unsafe virtual string StackTrace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154669, XrefRangeEnd = 154670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_get_StackTrace_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00058EC8 File Offset: 0x000570C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 154675, RefRangeEnd = 154678, XrefRangeStart = 154670, XrefRangeEnd = 154675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStackTrace(bool needFileInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needFileInfo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_GetStackTrace_Private_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00058F0C File Offset: 0x0005710C
		[CallerCount(0)]
		public unsafe void SetErrorCode(int hr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_SetErrorCode_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x00058F4C File Offset: 0x0005714C
		public unsafe virtual string Source
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154678, XrefRangeEnd = 154685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00058F90 File Offset: 0x00057190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154685, XrefRangeEnd = 154686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00058FD4 File Offset: 0x000571D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 154721, RefRangeEnd = 154725, XrefRangeStart = 154686, XrefRangeEnd = 154721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(bool needFileLineInfo, bool needMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needFileLineInfo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needMessage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_ToString_Private_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00059028 File Offset: 0x00057228
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 154801, RefRangeEnd = 154824, XrefRangeStart = 154725, XrefRangeEnd = 154801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0005908C File Offset: 0x0005728C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154824, XrefRangeEnd = 154828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x000590D4 File Offset: 0x000572D4
		[CallerCount(0)]
		public unsafe string StripFileInfo(string stackTrace, bool isRemoteStackTrace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRemoteStackTrace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_StripFileInfo_Private_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0005912C File Offset: 0x0005732C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154832, RefRangeEnd = 154833, XrefRangeStart = 154828, XrefRangeEnd = 154832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionDispatchInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_RestoreExceptionDispatchInfo_Internal_Void_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x00059170 File Offset: 0x00057370
		// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x000591AC File Offset: 0x000573AC
		public unsafe int HResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_get_HResult_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_set_HResult_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x000591EC File Offset: 0x000573EC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 154834, RefRangeEnd = 154856, XrefRangeStart = 154833, XrefRangeEnd = 154834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual Type GetIl2CppType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_GetIl2CppType_Public_Virtual_Final_New_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0005922C File Offset: 0x0005742C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154856, XrefRangeEnd = 154860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessageFromNativeResources(Exception.ExceptionMessageKind kind)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref kind;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_GetMessageFromNativeResources_Internal_Static_String_ExceptionMessageKind_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00059264 File Offset: 0x00057464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154869, RefRangeEnd = 154870, XrefRangeStart = 154860, XrefRangeEnd = 154869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception FixRemotingException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_FixRemotingException_Internal_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x000592A4 File Offset: 0x000574A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154870, XrefRangeEnd = 154876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReportUnhandledException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_ReportUnhandledException_Internal_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00004EE1 File Offset: 0x000030E1
		public Exception(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x000592DC File Offset: 0x000574DC
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00004EEA File Offset: 0x000030EA
		public unsafe static Object s_EDILock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Exception.NativeFieldInfoPtr_s_EDILock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Exception.NativeFieldInfoPtr_s_EDILock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00059304 File Offset: 0x00057504
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x00004EFC File Offset: 0x000030FC
		public unsafe string _className
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__className);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__className), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x0005932C File Offset: 0x0005752C
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x00004F1B File Offset: 0x0000311B
		public unsafe string _message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x00059354 File Offset: 0x00057554
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x00004F3A File Offset: 0x0000313A
		public unsafe IDictionary _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x00059384 File Offset: 0x00057584
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x00004F59 File Offset: 0x00003159
		public unsafe Exception _innerException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__innerException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__innerException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x000593B4 File Offset: 0x000575B4
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x00004F78 File Offset: 0x00003178
		public unsafe string _helpURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__helpURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__helpURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x000593DC File Offset: 0x000575DC
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x00004F97 File Offset: 0x00003197
		public unsafe Object _stackTrace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__stackTrace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__stackTrace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x0005940C File Offset: 0x0005760C
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x00004FB6 File Offset: 0x000031B6
		public unsafe string _stackTraceString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__stackTraceString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__stackTraceString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x00059434 File Offset: 0x00057634
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x00004FD5 File Offset: 0x000031D5
		public unsafe string _remoteStackTraceString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__remoteStackTraceString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__remoteStackTraceString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x0005945C File Offset: 0x0005765C
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x00004FF4 File Offset: 0x000031F4
		public unsafe int _remoteStackIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__remoteStackIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__remoteStackIndex)) = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x00059484 File Offset: 0x00057684
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x0000500F File Offset: 0x0000320F
		public unsafe Object _dynamicMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__dynamicMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__dynamicMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x000594B4 File Offset: 0x000576B4
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x0000502E File Offset: 0x0000322E
		public unsafe int _HResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__HResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__HResult)) = value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x000594DC File Offset: 0x000576DC
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x00005049 File Offset: 0x00003249
		public unsafe string _source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__source);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__source), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x00059504 File Offset: 0x00057704
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x00005068 File Offset: 0x00003268
		public unsafe SafeSerializationManager _safeSerializationManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__safeSerializationManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeSerializationManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__safeSerializationManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x00059534 File Offset: 0x00057734
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x00005087 File Offset: 0x00003287
		public unsafe Il2CppReferenceArray<StackTrace> captured_traces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr_captured_traces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StackTrace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr_captured_traces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x00059564 File Offset: 0x00057764
		// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x000050A6 File Offset: 0x000032A6
		public unsafe Il2CppStructArray<IntPtr> native_trace_ips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr_native_trace_ips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IntPtr>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr_native_trace_ips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00059594 File Offset: 0x00057794
		// (set) Token: 0x06000BEA RID: 3050 RVA: 0x000050C5 File Offset: 0x000032C5
		public unsafe static int _COMPlusExceptionCode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Exception.NativeFieldInfoPtr__COMPlusExceptionCode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Exception.NativeFieldInfoPtr__COMPlusExceptionCode, (void*)(&value));
			}
		}

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeFieldInfoPtr_s_EDILock;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeFieldInfoPtr__className;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeFieldInfoPtr__message;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeFieldInfoPtr__innerException;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeFieldInfoPtr__helpURL;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeFieldInfoPtr__stackTrace;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeFieldInfoPtr__stackTraceString;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeFieldInfoPtr__remoteStackTraceString;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeFieldInfoPtr__remoteStackIndex;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeFieldInfoPtr__dynamicMethods;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeFieldInfoPtr__HResult;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeFieldInfoPtr__source;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeFieldInfoPtr__safeSerializationManager;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeFieldInfoPtr_captured_traces;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeFieldInfoPtr_native_trace_ips;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeFieldInfoPtr__COMPlusExceptionCode;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_New_get_String_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IDictionary_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_IsImmutableAgileException_Private_Static_Boolean_Exception_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_GetClassName_Private_String_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerException_Public_Virtual_Final_New_get_Exception_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetSite_Public_Virtual_Final_New_get_MethodBase_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_get_StackTrace_Public_Virtual_New_get_String_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_GetStackTrace_Private_String_Boolean_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_SetErrorCode_Internal_Void_Int32_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_String_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Private_String_Boolean_Boolean_0;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_StripFileInfo_Private_String_String_Boolean_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_RestoreExceptionDispatchInfo_Internal_Void_ExceptionDispatchInfo_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_get_HResult_Public_get_Int32_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_set_HResult_Protected_set_Void_Int32_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_GetIl2CppType_Public_Virtual_Final_New_Type_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_GetMessageFromNativeResources_Internal_Static_String_ExceptionMessageKind_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_FixRemotingException_Internal_Exception_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_ReportUnhandledException_Internal_Static_Void_Exception_0;

		// Token: 0x02000594 RID: 1428
		[OriginalName("mscorlib.dll", "", "ExceptionMessageKind")]
		public enum ExceptionMessageKind
		{
			// Token: 0x04004107 RID: 16647
			ThreadAbort = 1,
			// Token: 0x04004108 RID: 16648
			ThreadInterrupted,
			// Token: 0x04004109 RID: 16649
			OutOfMemory
		}
	}
}
