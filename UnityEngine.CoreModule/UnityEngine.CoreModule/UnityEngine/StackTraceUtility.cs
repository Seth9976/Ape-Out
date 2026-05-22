using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Diagnostics;

namespace UnityEngine
{
	// Token: 0x020000E4 RID: 228
	public static class StackTraceUtility : Object
	{
		// Token: 0x06001370 RID: 4976 RVA: 0x0004EE68 File Offset: 0x0004D068
		// Note: this type is marked as 'beforefieldinit'.
		static StackTraceUtility()
		{
			Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "StackTraceUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr);
			StackTraceUtility.NativeFieldInfoPtr_projectFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, "projectFolder");
			StackTraceUtility.NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100664981);
			StackTraceUtility.NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100664982);
			StackTraceUtility.NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100664983);
			StackTraceUtility.NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100664984);
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x0004EEFC File Offset: 0x0004D0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496629, XrefRangeEnd = 496645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetProjectFolder(string folder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(folder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x0004EF34 File Offset: 0x0004D134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496645, XrefRangeEnd = 496663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExtractStackTrace()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0004EF60 File Offset: 0x0004D160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496663, XrefRangeEnd = 496704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExtractStringFromExceptionInternal(Object exceptiono, out string message, out string stackTrace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptiono);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			stackTrace = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x0004EFCC File Offset: 0x0004D1CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 496801, RefRangeEnd = 496803, XrefRangeStart = 496704, XrefRangeEnd = 496801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExtractFormattedStackTrace(StackTrace stackTrace)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stackTrace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0000AEB5 File Offset: 0x000090B5
		public StackTraceUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x0004F008 File Offset: 0x0004D208
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x0000AEBE File Offset: 0x000090BE
		public unsafe static string projectFolder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StackTraceUtility.NativeFieldInfoPtr_projectFolder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackTraceUtility.NativeFieldInfoPtr_projectFolder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x0004F028 File Offset: 0x0004D228
		public static string ExtractStringFromException(Object exception)
		{
			string text;
			string text2;
			StackTraceUtility.ExtractStringFromExceptionInternal(exception, out text, out text2);
			return String.Concat(text, "\n", text2);
		}

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeFieldInfoPtr_projectFolder;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0;
	}
}
