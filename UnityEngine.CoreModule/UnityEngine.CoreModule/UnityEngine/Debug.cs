using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200004F RID: 79
	public class Debug : Object
	{
		// Token: 0x0600040F RID: 1039 RVA: 0x0001F0C8 File Offset: 0x0001D2C8
		// Note: this type is marked as 'beforefieldinit'.
		static Debug()
		{
			Il2CppClassPointerStore<Debug>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Debug");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debug>.NativeClassPtr);
			Debug.NativeFieldInfoPtr_s_DefaultLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "s_DefaultLogger");
			Debug.NativeFieldInfoPtr_s_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "s_Logger");
			Debug.NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663599);
			Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663600);
			Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663601);
			Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663602);
			Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663603);
			Debug.NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663604);
			Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663605);
			Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663606);
			Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663607);
			Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663608);
			Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663609);
			Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663610);
			Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663611);
			Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663612);
			Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663613);
			Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663614);
			Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663615);
			Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663616);
			Debug.NativeMethodInfoPtr_get_isDebugBuild_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663617);
			Debug.NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663618);
			Debug.NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663619);
			Debug.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663621);
			Debug.BreakDelegateField = IL2CPP.ResolveICall<Debug.BreakDelegate>("UnityEngine.Debug::Break");
			Debug.DebugBreakDelegateField = IL2CPP.ResolveICall<Debug.DebugBreakDelegate>("UnityEngine.Debug::DebugBreak");
			Debug.ClearDeveloperConsoleDelegateField = IL2CPP.ResolveICall<Debug.ClearDeveloperConsoleDelegate>("UnityEngine.Debug::ClearDeveloperConsole");
			Debug.get_developerConsoleVisibleDelegateField = IL2CPP.ResolveICall<Debug.get_developerConsoleVisibleDelegate>("UnityEngine.Debug::get_developerConsoleVisible");
			Debug.set_developerConsoleVisibleDelegateField = IL2CPP.ResolveICall<Debug.set_developerConsoleVisibleDelegate>("UnityEngine.Debug::set_developerConsoleVisible");
			Debug.OpenConsoleFileDelegateField = IL2CPP.ResolveICall<Debug.OpenConsoleFileDelegate>("UnityEngine.Debug::OpenConsoleFile");
			Debug.GetDiagnosticSwitchDelegateField = IL2CPP.ResolveICall<Debug.GetDiagnosticSwitchDelegate>("UnityEngine.Debug::GetDiagnosticSwitch");
			Debug.SetDiagnosticSwitchDelegateField = IL2CPP.ResolveICall<Debug.SetDiagnosticSwitchDelegate>("UnityEngine.Debug::SetDiagnosticSwitch");
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0001F350 File Offset: 0x0001D550
		public unsafe static ILogger unityLogger
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486763, XrefRangeEnd = 486767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0001F384 File Offset: 0x0001D584
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 486776, RefRangeEnd = 486779, XrefRangeStart = 486767, XrefRangeEnd = 486776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0001F3E0 File Offset: 0x0001D5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486779, XrefRangeEnd = 486788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Vector3 start, Vector3 end, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0001F430 File Offset: 0x0001D630
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 486797, RefRangeEnd = 486801, XrefRangeStart = 486788, XrefRangeEnd = 486797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Vector3 start, Vector3 end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0001F470 File Offset: 0x0001D670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486801, XrefRangeEnd = 486806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0001F4DC File Offset: 0x0001D6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486806, XrefRangeEnd = 486810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferMax;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(projectFolder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0001F538 File Offset: 0x0001D738
		[CallerCount(87)]
		[CachedScanResults(RefRangeStart = 486817, RefRangeEnd = 486904, XrefRangeStart = 486810, XrefRangeEnd = 486817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0001F570 File Offset: 0x0001D770
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 486910, RefRangeEnd = 486913, XrefRangeStart = 486904, XrefRangeEnd = 486910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(Object message, Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0001F5B8 File Offset: 0x0001D7B8
		[CallerCount(90)]
		[CachedScanResults(RefRangeStart = 486920, RefRangeEnd = 487010, XrefRangeStart = 486913, XrefRangeEnd = 486920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0001F5F0 File Offset: 0x0001D7F0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 487016, RefRangeEnd = 487025, XrefRangeStart = 487010, XrefRangeEnd = 487016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(Object message, Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0001F638 File Offset: 0x0001D838
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 487031, RefRangeEnd = 487033, XrefRangeStart = 487025, XrefRangeEnd = 487031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogErrorFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0001F690 File Offset: 0x0001D890
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 487039, RefRangeEnd = 487041, XrefRangeStart = 487033, XrefRangeEnd = 487039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogErrorFormat(Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0001F6F8 File Offset: 0x0001D8F8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 487047, RefRangeEnd = 487055, XrefRangeStart = 487041, XrefRangeEnd = 487047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0001F730 File Offset: 0x0001D930
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 487061, RefRangeEnd = 487063, XrefRangeStart = 487055, XrefRangeEnd = 487061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogException(Exception exception, Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0001F778 File Offset: 0x0001D978
		[CallerCount(59)]
		[CachedScanResults(RefRangeStart = 487070, RefRangeEnd = 487129, XrefRangeStart = 487063, XrefRangeEnd = 487070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0001F7B0 File Offset: 0x0001D9B0
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 487135, RefRangeEnd = 487169, XrefRangeStart = 487129, XrefRangeEnd = 487135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(Object message, Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0001F7F8 File Offset: 0x0001D9F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 487175, RefRangeEnd = 487177, XrefRangeStart = 487169, XrefRangeEnd = 487175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarningFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0001F850 File Offset: 0x0001DA50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 487183, RefRangeEnd = 487185, XrefRangeStart = 487177, XrefRangeEnd = 487183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarningFormat(Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0001F8B8 File Offset: 0x0001DAB8
		public unsafe static bool isDebugBuild
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487185, XrefRangeEnd = 487189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_get_isDebugBuild_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0001F8E8 File Offset: 0x0001DAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487189, XrefRangeEnd = 487203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CallOverridenDebugHandler(Exception exception, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0001F93C File Offset: 0x0001DB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487203, XrefRangeEnd = 487221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLoggingEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0001F96C File Offset: 0x0001DB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487221, XrefRangeEnd = 487225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Color_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000044BA File Offset: 0x000026BA
		public static void LogErrorFormat(string format, params Object[] args)
		{
			Debug.LogErrorFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000044C8 File Offset: 0x000026C8
		public static void LogErrorFormat(Object context, string format, params Object[] args)
		{
			Debug.LogErrorFormat(context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000044D7 File Offset: 0x000026D7
		public static void LogWarningFormat(string format, params Object[] args)
		{
			Debug.LogWarningFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000044E5 File Offset: 0x000026E5
		public static void LogWarningFormat(Object context, string format, params Object[] args)
		{
			Debug.LogWarningFormat(context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000044F4 File Offset: 0x000026F4
		public Debug(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0001F9D8 File Offset: 0x0001DBD8
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x000044FD File Offset: 0x000026FD
		public unsafe static ILogger s_DefaultLogger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr_s_DefaultLogger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr_s_DefaultLogger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0001FA00 File Offset: 0x0001DC00
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x0000450F File Offset: 0x0000270F
		public unsafe static ILogger s_Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr_s_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr_s_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0001FA28 File Offset: 0x0001DC28
		public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
		{
			bool flag = true;
			Debug.DrawRay(start, dir, color, duration, flag);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0001FA44 File Offset: 0x0001DC44
		public static void DrawRay(Vector3 start, Vector3 dir, Color color)
		{
			bool flag = true;
			float num = 0f;
			Debug.DrawRay(start, dir, color, num, flag);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0001FA68 File Offset: 0x0001DC68
		public static void DrawRay(Vector3 start, Vector3 dir)
		{
			bool flag = true;
			float num = 0f;
			Color white = Color.white;
			Debug.DrawRay(start, dir, white, num, flag);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00004521 File Offset: 0x00002721
		public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest)
		{
			Debug.DrawLine(start, start + dir, color, duration, depthTest);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00004536 File Offset: 0x00002736
		public static void Break()
		{
			Debug.BreakDelegateField();
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00004542 File Offset: 0x00002742
		public static void DebugBreak()
		{
			Debug.DebugBreakDelegateField();
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000454E File Offset: 0x0000274E
		public static void LogFormat(string format, Il2CppReferenceArray<Object> args)
		{
			Debug.unityLogger.LogFormat(LogType.Log, format, args);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000455F File Offset: 0x0000275F
		public static void LogFormat(string format, params Object[] args)
		{
			Debug.LogFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000456D File Offset: 0x0000276D
		public static void LogFormat(Object context, string format, Il2CppReferenceArray<Object> args)
		{
			Debug.unityLogger.LogFormat(LogType.Log, context, format, args);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000457F File Offset: 0x0000277F
		public static void LogFormat(Object context, string format, params Object[] args)
		{
			Debug.LogFormat(context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0001FA90 File Offset: 0x0001DC90
		public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, Il2CppReferenceArray<Object> args)
		{
			DebugLogHandler debugLogHandler = Debug.unityLogger.logHandler.TryCast<DebugLogHandler>();
			bool flag = debugLogHandler == null;
			if (flag)
			{
				Debug.unityLogger.LogFormat(logType, context, format, args);
			}
			else
			{
				bool flag2 = Debug.unityLogger.IsLogTypeAllowed(logType);
				if (flag2)
				{
					debugLogHandler.LogFormat(logType, logOptions, context, format, args);
				}
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000458E File Offset: 0x0000278E
		public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params Object[] args)
		{
			Debug.LogFormat(logType, logOptions, context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000045A0 File Offset: 0x000027A0
		public static void ClearDeveloperConsole()
		{
			Debug.ClearDeveloperConsoleDelegateField();
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x000045AC File Offset: 0x000027AC
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x000045B8 File Offset: 0x000027B8
		public static bool developerConsoleVisible
		{
			get
			{
				return Debug.get_developerConsoleVisibleDelegateField();
			}
			set
			{
				Debug.set_developerConsoleVisibleDelegateField(value);
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0001FAE4 File Offset: 0x0001DCE4
		public static void Assert(bool condition)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, "Assertion failed");
			}
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0001FB0C File Offset: 0x0001DD0C
		public static void Assert(bool condition, Object context)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, "Assertion failed", context);
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0001FB34 File Offset: 0x0001DD34
		public static void Assert(bool condition, Object message)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message);
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0001FB58 File Offset: 0x0001DD58
		public static void Assert(bool condition, string message)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message);
			}
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0001FB7C File Offset: 0x0001DD7C
		public static void Assert(bool condition, Object message, Object context)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message, context);
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0001FBA0 File Offset: 0x0001DDA0
		public static void Assert(bool condition, string message, Object context)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message, context);
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0001FBC4 File Offset: 0x0001DDC4
		public static void AssertFormat(bool condition, string format, Il2CppReferenceArray<Object> args)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.LogFormat(LogType.Assert, format, args);
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000045C5 File Offset: 0x000027C5
		public static void AssertFormat(bool condition, string format, params Object[] args)
		{
			Debug.AssertFormat(condition, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0001FBE8 File Offset: 0x0001DDE8
		public static void AssertFormat(bool condition, Object context, string format, Il2CppReferenceArray<Object> args)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.LogFormat(LogType.Assert, context, format, args);
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000045D4 File Offset: 0x000027D4
		public static void AssertFormat(bool condition, Object context, string format, params Object[] args)
		{
			Debug.AssertFormat(condition, context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000045E4 File Offset: 0x000027E4
		public static void LogAssertion(Object message)
		{
			Debug.unityLogger.Log(LogType.Assert, message);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000045F4 File Offset: 0x000027F4
		public static void LogAssertion(Object message, Object context)
		{
			Debug.unityLogger.Log(LogType.Assert, message, context);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00004605 File Offset: 0x00002805
		public static void LogAssertionFormat(string format, Il2CppReferenceArray<Object> args)
		{
			Debug.unityLogger.LogFormat(LogType.Assert, format, args);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00004616 File Offset: 0x00002816
		public static void LogAssertionFormat(string format, params Object[] args)
		{
			Debug.LogAssertionFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00004624 File Offset: 0x00002824
		public static void LogAssertionFormat(Object context, string format, Il2CppReferenceArray<Object> args)
		{
			Debug.unityLogger.LogFormat(LogType.Assert, context, format, args);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00004636 File Offset: 0x00002836
		public static void LogAssertionFormat(Object context, string format, params Object[] args)
		{
			Debug.LogAssertionFormat(context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00004645 File Offset: 0x00002845
		public static void OpenConsoleFile()
		{
			Debug.OpenConsoleFileDelegateField();
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0001FC10 File Offset: 0x0001DE10
		public static Object GetDiagnosticSwitch(string name)
		{
			IntPtr intPtr = Debug.GetDiagnosticSwitchDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00004651 File Offset: 0x00002851
		public static void SetDiagnosticSwitch(string name, Object value, bool setPersistent)
		{
			Debug.SetDiagnosticSwitchDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(value), setPersistent);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0001FC3C File Offset: 0x0001DE3C
		public static void Assert(bool condition, string format, Il2CppReferenceArray<Object> args)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.LogFormat(LogType.Assert, format, args);
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000466A File Offset: 0x0000286A
		public static void Assert(bool condition, string format, params Object[] args)
		{
			Debug.Assert(condition, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0001FC60 File Offset: 0x0001DE60
		public static ILogger logger
		{
			get
			{
				return Debug.s_Logger;
			}
		}

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultLogger;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeFieldInfoPtr_s_Logger;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_get_isDebugBuild_Public_Static_get_Boolean_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Color_Single_Boolean_0;

		// Token: 0x0400034C RID: 844
		private static readonly Debug.BreakDelegate BreakDelegateField;

		// Token: 0x0400034D RID: 845
		private static readonly Debug.DebugBreakDelegate DebugBreakDelegateField;

		// Token: 0x0400034E RID: 846
		private static readonly Debug.ClearDeveloperConsoleDelegate ClearDeveloperConsoleDelegateField;

		// Token: 0x0400034F RID: 847
		private static readonly Debug.get_developerConsoleVisibleDelegate get_developerConsoleVisibleDelegateField;

		// Token: 0x04000350 RID: 848
		private static readonly Debug.set_developerConsoleVisibleDelegate set_developerConsoleVisibleDelegateField;

		// Token: 0x04000351 RID: 849
		private static readonly Debug.OpenConsoleFileDelegate OpenConsoleFileDelegateField;

		// Token: 0x04000352 RID: 850
		private static readonly Debug.GetDiagnosticSwitchDelegate GetDiagnosticSwitchDelegateField;

		// Token: 0x04000353 RID: 851
		private static readonly Debug.SetDiagnosticSwitchDelegate SetDiagnosticSwitchDelegateField;

		// Token: 0x02000416 RID: 1046
		// (Invoke) Token: 0x06002658 RID: 9816
		private delegate void BreakDelegate();

		// Token: 0x02000417 RID: 1047
		// (Invoke) Token: 0x0600265A RID: 9818
		private delegate void DebugBreakDelegate();

		// Token: 0x02000418 RID: 1048
		// (Invoke) Token: 0x0600265C RID: 9820
		private delegate void ClearDeveloperConsoleDelegate();

		// Token: 0x02000419 RID: 1049
		// (Invoke) Token: 0x0600265E RID: 9822
		private delegate bool get_developerConsoleVisibleDelegate();

		// Token: 0x0200041A RID: 1050
		// (Invoke) Token: 0x06002660 RID: 9824
		private delegate void set_developerConsoleVisibleDelegate(bool value);

		// Token: 0x0200041B RID: 1051
		// (Invoke) Token: 0x06002662 RID: 9826
		private delegate void OpenConsoleFileDelegate();

		// Token: 0x0200041C RID: 1052
		// (Invoke) Token: 0x06002664 RID: 9828
		private delegate IntPtr GetDiagnosticSwitchDelegate(IntPtr name);

		// Token: 0x0200041D RID: 1053
		// (Invoke) Token: 0x06002666 RID: 9830
		private delegate void SetDiagnosticSwitchDelegate(IntPtr name, IntPtr value, bool setPersistent);
	}
}
