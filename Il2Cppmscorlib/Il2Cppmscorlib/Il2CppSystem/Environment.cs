using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem
{
	// Token: 0x02000108 RID: 264
	public static class Environment : Object
	{
		// Token: 0x0600139D RID: 5021 RVA: 0x0007EFF4 File Offset: 0x0007D1F4
		// Note: this type is marked as 'beforefieldinit'.
		static Environment()
		{
			Il2CppClassPointerStore<Environment>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Environment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Environment>.NativeClassPtr);
			Environment.NativeFieldInfoPtr_mono_corlib_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "mono_corlib_version");
			Environment.NativeFieldInfoPtr_nl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "nl");
			Environment.NativeFieldInfoPtr_os = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "os");
			Environment.NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666744);
			Environment.NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666745);
			Environment.NativeMethodInfoPtr_GetResourceStringEncodingName_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666746);
			Environment.NativeMethodInfoPtr_get_CurrentManagedThreadId_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666747);
			Environment.NativeMethodInfoPtr_get_HasShutdownStarted_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666748);
			Environment.NativeMethodInfoPtr_get_MachineName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666749);
			Environment.NativeMethodInfoPtr_GetNewLine_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666750);
			Environment.NativeMethodInfoPtr_get_NewLine_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666751);
			Environment.NativeMethodInfoPtr_get_Platform_Internal_Static_get_PlatformID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666752);
			Environment.NativeMethodInfoPtr_GetOSVersionString_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666753);
			Environment.NativeMethodInfoPtr_get_OSVersion_Public_Static_get_OperatingSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666754);
			Environment.NativeMethodInfoPtr_CreateVersionFromString_Internal_Static_Version_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666755);
			Environment.NativeMethodInfoPtr_get_StackTrace_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666756);
			Environment.NativeMethodInfoPtr_get_TickCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666757);
			Environment.NativeMethodInfoPtr_get_UserDomainName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666758);
			Environment.NativeMethodInfoPtr_get_UserName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666759);
			Environment.NativeMethodInfoPtr_Exit_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666760);
			Environment.NativeMethodInfoPtr_ExpandEnvironmentVariables_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666761);
			Environment.NativeMethodInfoPtr_GetCommandLineArgs_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666762);
			Environment.NativeMethodInfoPtr_internalGetEnvironmentVariable_native_Internal_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666763);
			Environment.NativeMethodInfoPtr_internalGetEnvironmentVariable_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666764);
			Environment.NativeMethodInfoPtr_GetEnvironmentVariable_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666765);
			Environment.NativeMethodInfoPtr_GetEnvironmentVariablesNoCase_Private_Static_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666766);
			Environment.NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666767);
			Environment.NativeMethodInfoPtr_GetWindowsFolderPath_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666768);
			Environment.NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_SpecialFolderOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666769);
			Environment.NativeMethodInfoPtr_ReadXdgUserDir_Private_Static_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666770);
			Environment.NativeMethodInfoPtr_UnixGetFolderPath_Internal_Static_String_SpecialFolder_SpecialFolderOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666771);
			Environment.NativeMethodInfoPtr_FailFast_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666772);
			Environment.NativeMethodInfoPtr_FailFast_Public_Static_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666773);
			Environment.NativeMethodInfoPtr_get_Is64BitProcess_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666774);
			Environment.NativeMethodInfoPtr_get_ProcessorCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666775);
			Environment.NativeMethodInfoPtr_get_IsRunningOnWindows_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666776);
			Environment.NativeMethodInfoPtr_GetEnvironmentVariableNames_Private_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666777);
			Environment.NativeMethodInfoPtr_GetMachineConfigPath_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666778);
			Environment.NativeMethodInfoPtr_internalGetHome_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666779);
			Environment.NativeMethodInfoPtr_GetPageSize_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666780);
			Environment.NativeMethodInfoPtr_get_IsUnix_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666781);
			Environment.NativeMethodInfoPtr_GetStackTrace_Internal_Static_String_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666782);
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x0007F36C File Offset: 0x0007D56C
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceString(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0007F3A8 File Offset: 0x0007D5A8
		[CallerCount(103)]
		[CachedScanResults(RefRangeStart = 173814, RefRangeEnd = 173917, XrefRangeStart = 173805, XrefRangeEnd = 173814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceString(string key, [Optional] Il2CppReferenceArray<Object> values)
		{
			if (values == null)
			{
				values = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0007F404 File Offset: 0x0007D604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173917, XrefRangeEnd = 173926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceStringEncodingName(int codePage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codePage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetResourceStringEncodingName_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x0007F43C File Offset: 0x0007D63C
		public unsafe static int CurrentManagedThreadId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173926, XrefRangeEnd = 173928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_CurrentManagedThreadId_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x0007F46C File Offset: 0x0007D66C
		public unsafe static bool HasShutdownStarted
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_HasShutdownStarted_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x0007F49C File Offset: 0x0007D69C
		public unsafe static string MachineName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 173931, RefRangeEnd = 173935, XrefRangeStart = 173928, XrefRangeEnd = 173931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_MachineName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0007F4C8 File Offset: 0x0007D6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173935, XrefRangeEnd = 173936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNewLine()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetNewLine_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x0007F4F4 File Offset: 0x0007D6F4
		public unsafe static string NewLine
		{
			[CallerCount(139)]
			[CachedScanResults(RefRangeStart = 173941, RefRangeEnd = 174080, XrefRangeStart = 173936, XrefRangeEnd = 173941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_NewLine_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x0007F520 File Offset: 0x0007D720
		public unsafe static PlatformID Platform
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_Platform_Internal_Static_get_PlatformID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x0007F550 File Offset: 0x0007D750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174080, XrefRangeEnd = 174085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetOSVersionString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetOSVersionString_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x0007F57C File Offset: 0x0007D77C
		public unsafe static OperatingSystem OSVersion
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 174099, RefRangeEnd = 174114, XrefRangeStart = 174085, XrefRangeEnd = 174099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_OSVersion_Public_Static_get_OperatingSystem_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OperatingSystem>(intPtr3) : null;
			}
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x0007F5B0 File Offset: 0x0007D7B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174131, RefRangeEnd = 174132, XrefRangeStart = 174114, XrefRangeEnd = 174131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Version CreateVersionFromString(string info)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_CreateVersionFromString_Internal_Static_Version_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x0007F5F4 File Offset: 0x0007D7F4
		public unsafe static string StackTrace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174132, XrefRangeEnd = 174137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_StackTrace_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x0007F620 File Offset: 0x0007D820
		public unsafe static int TickCount
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 174137, RefRangeEnd = 174142, XrefRangeStart = 174137, XrefRangeEnd = 174137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_TickCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x0007F650 File Offset: 0x0007D850
		public unsafe static string UserDomainName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174142, XrefRangeEnd = 174143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_UserDomainName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x0007F67C File Offset: 0x0007D87C
		public unsafe static string UserName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174143, XrefRangeEnd = 174146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_UserName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0007F6A8 File Offset: 0x0007D8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174146, XrefRangeEnd = 174147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Exit(int exitCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref exitCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_Exit_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0007F6DC File Offset: 0x0007D8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174147, XrefRangeEnd = 174167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExpandEnvironmentVariables(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_ExpandEnvironmentVariables_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0007F718 File Offset: 0x0007D918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174167, XrefRangeEnd = 174176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetCommandLineArgs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetCommandLineArgs_Public_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0007F74C File Offset: 0x0007D94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174176, XrefRangeEnd = 174182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string internalGetEnvironmentVariable_native(IntPtr variable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref variable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_internalGetEnvironmentVariable_native_Internal_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0007F784 File Offset: 0x0007D984
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 174193, RefRangeEnd = 174205, XrefRangeStart = 174182, XrefRangeEnd = 174193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string internalGetEnvironmentVariable(string variable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_internalGetEnvironmentVariable_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0007F7C0 File Offset: 0x0007D9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174205, XrefRangeEnd = 174206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetEnvironmentVariable(string variable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetEnvironmentVariable_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0007F7FC File Offset: 0x0007D9FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174232, RefRangeEnd = 174233, XrefRangeStart = 174206, XrefRangeEnd = 174232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Hashtable GetEnvironmentVariablesNoCase()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetEnvironmentVariablesNoCase_Private_Static_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0007F830 File Offset: 0x0007DA30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 174238, RefRangeEnd = 174241, XrefRangeStart = 174233, XrefRangeEnd = 174238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFolderPath(Environment.SpecialFolder folder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref folder;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0007F868 File Offset: 0x0007DA68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 174238, RefRangeEnd = 174241, XrefRangeStart = 174238, XrefRangeEnd = 174241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWindowsFolderPath(int folder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref folder;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetWindowsFolderPath_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x0007F8A0 File Offset: 0x0007DAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174241, XrefRangeEnd = 174246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref folder;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref option;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_SpecialFolderOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x0007F8E8 File Offset: 0x0007DAE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174256, RefRangeEnd = 174257, XrefRangeStart = 174246, XrefRangeEnd = 174256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(config_dir);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(home_dir);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_ReadXdgUserDir_Private_Static_String_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0007F95C File Offset: 0x0007DB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174257, XrefRangeEnd = 174306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnixGetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref folder;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref option;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_UnixGetFolderPath_Internal_Static_String_SpecialFolder_SpecialFolderOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0007F9A4 File Offset: 0x0007DBA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174311, RefRangeEnd = 174312, XrefRangeStart = 174306, XrefRangeEnd = 174311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FailFast(string message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_FailFast_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0007F9DC File Offset: 0x0007DBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174312, XrefRangeEnd = 174317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FailFast(string message, Exception exception)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_FailFast_Public_Static_Void_String_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x0007FA24 File Offset: 0x0007DC24
		public unsafe static bool Is64BitProcess
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_Is64BitProcess_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x0007FA54 File Offset: 0x0007DC54
		public unsafe static int ProcessorCount
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_ProcessorCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x0007FA84 File Offset: 0x0007DC84
		public unsafe static bool IsRunningOnWindows
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_IsRunningOnWindows_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x0007FAB4 File Offset: 0x0007DCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174317, XrefRangeEnd = 174321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetEnvironmentVariableNames()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetEnvironmentVariableNames_Private_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x0007FAE8 File Offset: 0x0007DCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174321, XrefRangeEnd = 174322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMachineConfigPath()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetMachineConfigPath_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0007FB14 File Offset: 0x0007DD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174322, XrefRangeEnd = 174325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string internalGetHome()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_internalGetHome_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x0007FB40 File Offset: 0x0007DD40
		[CallerCount(0)]
		public unsafe static int GetPageSize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetPageSize_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x0007FB70 File Offset: 0x0007DD70
		public unsafe static bool IsUnix
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_IsUnix_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0007FBA0 File Offset: 0x0007DDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174325, XrefRangeEnd = 174332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStackTrace(Exception e, bool needFileInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetStackTrace_Internal_Static_String_Exception_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x00006ADB File Offset: 0x00004CDB
		public static string GetResourceString(string key, params Object[] values)
		{
			return Environment.GetResourceString(key, new Il2CppReferenceArray<Object>(values));
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x00006AE9 File Offset: 0x00004CE9
		public Environment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x0007FBEC File Offset: 0x0007DDEC
		// (set) Token: 0x060013C8 RID: 5064 RVA: 0x00006AF2 File Offset: 0x00004CF2
		public unsafe static int mono_corlib_version
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Environment.NativeFieldInfoPtr_mono_corlib_version, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Environment.NativeFieldInfoPtr_mono_corlib_version, (void*)(&value));
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x0007FC08 File Offset: 0x0007DE08
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x00006B00 File Offset: 0x00004D00
		public unsafe static string nl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Environment.NativeFieldInfoPtr_nl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Environment.NativeFieldInfoPtr_nl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x0007FC28 File Offset: 0x0007DE28
		// (set) Token: 0x060013CC RID: 5068 RVA: 0x00006B12 File Offset: 0x00004D12
		public unsafe static OperatingSystem os
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Environment.NativeFieldInfoPtr_os, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OperatingSystem>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Environment.NativeFieldInfoPtr_os, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeFieldInfoPtr_mono_corlib_version;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeFieldInfoPtr_nl;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeFieldInfoPtr_os;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_0;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceStringEncodingName_Internal_Static_String_Int32_0;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentManagedThreadId_Public_Static_get_Int32_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_get_HasShutdownStarted_Public_Static_get_Boolean_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_get_MachineName_Public_Static_get_String_0;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_GetNewLine_Private_Static_String_0;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeMethodInfoPtr_get_NewLine_Public_Static_get_String_0;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr_get_Platform_Internal_Static_get_PlatformID_0;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeMethodInfoPtr_GetOSVersionString_Internal_Static_String_0;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeMethodInfoPtr_get_OSVersion_Public_Static_get_OperatingSystem_0;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeMethodInfoPtr_CreateVersionFromString_Internal_Static_Version_String_0;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeMethodInfoPtr_get_StackTrace_Public_Static_get_String_0;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeMethodInfoPtr_get_TickCount_Public_Static_get_Int32_0;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeMethodInfoPtr_get_UserDomainName_Public_Static_get_String_0;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_get_UserName_Public_Static_get_String_0;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Static_Void_Int32_0;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeMethodInfoPtr_ExpandEnvironmentVariables_Public_Static_String_String_0;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeMethodInfoPtr_GetCommandLineArgs_Public_Static_Il2CppStringArray_0;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeMethodInfoPtr_internalGetEnvironmentVariable_native_Internal_Static_String_IntPtr_0;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeMethodInfoPtr_internalGetEnvironmentVariable_Internal_Static_String_String_0;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironmentVariable_Public_Static_String_String_0;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironmentVariablesNoCase_Private_Static_Hashtable_0;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_0;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeMethodInfoPtr_GetWindowsFolderPath_Private_Static_String_Int32_0;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_SpecialFolderOption_0;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeMethodInfoPtr_ReadXdgUserDir_Private_Static_String_String_String_String_String_0;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeMethodInfoPtr_UnixGetFolderPath_Internal_Static_String_SpecialFolder_SpecialFolderOption_0;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeMethodInfoPtr_FailFast_Public_Static_Void_String_0;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr_FailFast_Public_Static_Void_String_Exception_0;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr_get_Is64BitProcess_Public_Static_get_Boolean_0;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessorCount_Public_Static_get_Int32_0;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunningOnWindows_Internal_Static_get_Boolean_0;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironmentVariableNames_Private_Static_Il2CppStringArray_0;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeMethodInfoPtr_GetMachineConfigPath_Internal_Static_String_0;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr_internalGetHome_Internal_Static_String_0;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr_GetPageSize_Internal_Static_Int32_0;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnix_Internal_Static_get_Boolean_0;

		// Token: 0x04001120 RID: 4384
		private static readonly IntPtr NativeMethodInfoPtr_GetStackTrace_Internal_Static_String_Exception_Boolean_0;

		// Token: 0x020005A8 RID: 1448
		[OriginalName("mscorlib.dll", "", "SpecialFolder")]
		public enum SpecialFolder
		{
			// Token: 0x040041F2 RID: 16882
			MyDocuments = 5,
			// Token: 0x040041F3 RID: 16883
			Desktop = 0,
			// Token: 0x040041F4 RID: 16884
			MyComputer = 17,
			// Token: 0x040041F5 RID: 16885
			Programs = 2,
			// Token: 0x040041F6 RID: 16886
			Personal = 5,
			// Token: 0x040041F7 RID: 16887
			Favorites,
			// Token: 0x040041F8 RID: 16888
			Startup,
			// Token: 0x040041F9 RID: 16889
			Recent,
			// Token: 0x040041FA RID: 16890
			SendTo,
			// Token: 0x040041FB RID: 16891
			StartMenu = 11,
			// Token: 0x040041FC RID: 16892
			MyMusic = 13,
			// Token: 0x040041FD RID: 16893
			DesktopDirectory = 16,
			// Token: 0x040041FE RID: 16894
			Templates = 21,
			// Token: 0x040041FF RID: 16895
			ApplicationData = 26,
			// Token: 0x04004200 RID: 16896
			LocalApplicationData = 28,
			// Token: 0x04004201 RID: 16897
			InternetCache = 32,
			// Token: 0x04004202 RID: 16898
			Cookies,
			// Token: 0x04004203 RID: 16899
			History,
			// Token: 0x04004204 RID: 16900
			CommonApplicationData,
			// Token: 0x04004205 RID: 16901
			System = 37,
			// Token: 0x04004206 RID: 16902
			ProgramFiles,
			// Token: 0x04004207 RID: 16903
			MyPictures,
			// Token: 0x04004208 RID: 16904
			CommonProgramFiles = 43,
			// Token: 0x04004209 RID: 16905
			MyVideos = 14,
			// Token: 0x0400420A RID: 16906
			NetworkShortcuts = 19,
			// Token: 0x0400420B RID: 16907
			Fonts,
			// Token: 0x0400420C RID: 16908
			CommonStartMenu = 22,
			// Token: 0x0400420D RID: 16909
			CommonPrograms,
			// Token: 0x0400420E RID: 16910
			CommonStartup,
			// Token: 0x0400420F RID: 16911
			CommonDesktopDirectory,
			// Token: 0x04004210 RID: 16912
			PrinterShortcuts = 27,
			// Token: 0x04004211 RID: 16913
			Windows = 36,
			// Token: 0x04004212 RID: 16914
			UserProfile = 40,
			// Token: 0x04004213 RID: 16915
			SystemX86,
			// Token: 0x04004214 RID: 16916
			ProgramFilesX86,
			// Token: 0x04004215 RID: 16917
			CommonProgramFilesX86 = 44,
			// Token: 0x04004216 RID: 16918
			CommonTemplates,
			// Token: 0x04004217 RID: 16919
			CommonDocuments,
			// Token: 0x04004218 RID: 16920
			CommonAdminTools,
			// Token: 0x04004219 RID: 16921
			AdminTools,
			// Token: 0x0400421A RID: 16922
			CommonMusic = 53,
			// Token: 0x0400421B RID: 16923
			CommonPictures,
			// Token: 0x0400421C RID: 16924
			CommonVideos,
			// Token: 0x0400421D RID: 16925
			Resources,
			// Token: 0x0400421E RID: 16926
			LocalizedResources,
			// Token: 0x0400421F RID: 16927
			CommonOemLinks,
			// Token: 0x04004220 RID: 16928
			CDBurning
		}

		// Token: 0x020005A9 RID: 1449
		[OriginalName("mscorlib.dll", "", "SpecialFolderOption")]
		public enum SpecialFolderOption
		{
			// Token: 0x04004222 RID: 16930
			None,
			// Token: 0x04004223 RID: 16931
			DoNotVerify = 16384,
			// Token: 0x04004224 RID: 16932
			Create = 32768
		}
	}
}
