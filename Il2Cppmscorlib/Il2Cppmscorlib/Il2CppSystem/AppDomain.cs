using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Security.Policy;

namespace Il2CppSystem
{
	// Token: 0x02000105 RID: 261
	public sealed class AppDomain : MarshalByRefObject
	{
		// Token: 0x06001338 RID: 4920 RVA: 0x0007D8D0 File Offset: 0x0007BAD0
		// Note: this type is marked as 'beforefieldinit'.
		static AppDomain()
		{
			Il2CppClassPointerStore<AppDomain>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AppDomain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppDomain>.NativeClassPtr);
			AppDomain.NativeFieldInfoPtr__mono_app_domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_mono_app_domain");
			AppDomain.NativeFieldInfoPtr__process_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_process_guid");
			AppDomain.NativeFieldInfoPtr_type_resolve_in_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "type_resolve_in_progress");
			AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "assembly_resolve_in_progress");
			AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress_refonly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "assembly_resolve_in_progress_refonly");
			AppDomain.NativeFieldInfoPtr__evidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_evidence");
			AppDomain.NativeFieldInfoPtr__granted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_granted");
			AppDomain.NativeFieldInfoPtr__principalPolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_principalPolicy");
			AppDomain.NativeFieldInfoPtr__principal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_principal");
			AppDomain.NativeFieldInfoPtr_default_domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "default_domain");
			AppDomain.NativeFieldInfoPtr_AssemblyLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "AssemblyLoad");
			AppDomain.NativeFieldInfoPtr_AssemblyResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "AssemblyResolve");
			AppDomain.NativeFieldInfoPtr_DomainUnload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "DomainUnload");
			AppDomain.NativeFieldInfoPtr_ProcessExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "ProcessExit");
			AppDomain.NativeFieldInfoPtr_ResourceResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "ResourceResolve");
			AppDomain.NativeFieldInfoPtr_TypeResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "TypeResolve");
			AppDomain.NativeFieldInfoPtr_UnhandledException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "UnhandledException");
			AppDomain.NativeFieldInfoPtr_FirstChanceException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "FirstChanceException");
			AppDomain.NativeFieldInfoPtr__domain_manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_domain_manager");
			AppDomain.NativeFieldInfoPtr_ReflectionOnlyAssemblyResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "ReflectionOnlyAssemblyResolve");
			AppDomain.NativeFieldInfoPtr__activation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_activation");
			AppDomain.NativeFieldInfoPtr__applicationIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "_applicationIdentity");
			AppDomain.NativeFieldInfoPtr_compatibility_switch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, "compatibility_switch");
			AppDomain.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666699);
			AppDomain.NativeMethodInfoPtr_getFriendlyName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666700);
			AppDomain.NativeMethodInfoPtr_getCurDomain_Private_Static_AppDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666701);
			AppDomain.NativeMethodInfoPtr_get_CurrentDomain_Public_Static_get_AppDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666702);
			AppDomain.NativeMethodInfoPtr_GetAssemblies_Private_Il2CppReferenceArray_1_Assembly_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666703);
			AppDomain.NativeMethodInfoPtr_GetAssemblies_Public_Virtual_Final_New_Il2CppReferenceArray_1_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666704);
			AppDomain.NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666705);
			AppDomain.NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666706);
			AppDomain.NativeMethodInfoPtr_LoadAssembly_Internal_Assembly_String_Evidence_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666707);
			AppDomain.NativeMethodInfoPtr_LoadSatellite_Internal_Assembly_AssemblyName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666708);
			AppDomain.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666709);
			AppDomain.NativeMethodInfoPtr_Load_Internal_Assembly_String_Evidence_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666710);
			AppDomain.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666711);
			AppDomain.NativeMethodInfoPtr_LoadAssemblyRaw_Internal_Assembly_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Evidence_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666712);
			AppDomain.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Evidence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666713);
			AppDomain.NativeMethodInfoPtr_Load_Internal_Assembly_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Evidence_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666714);
			AppDomain.NativeMethodInfoPtr_InternalSetDomainByID_Private_Static_AppDomain_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666715);
			AppDomain.NativeMethodInfoPtr_InternalSetDomain_Private_Static_AppDomain_AppDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666716);
			AppDomain.NativeMethodInfoPtr_InternalPushDomainRefByID_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666717);
			AppDomain.NativeMethodInfoPtr_InternalPopDomainRef_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666718);
			AppDomain.NativeMethodInfoPtr_InternalSetContext_Internal_Static_Context_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666719);
			AppDomain.NativeMethodInfoPtr_InternalGetContext_Internal_Static_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666720);
			AppDomain.NativeMethodInfoPtr_InternalGetDefaultContext_Internal_Static_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666721);
			AppDomain.NativeMethodInfoPtr_InternalGetProcessGuid_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666722);
			AppDomain.NativeMethodInfoPtr_InvokeInDomainByID_Internal_Static_Object_Int32_MethodInfo_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666723);
			AppDomain.NativeMethodInfoPtr_GetProcessGuid_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666724);
			AppDomain.NativeMethodInfoPtr_InternalIsFinalizingForUnload_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666725);
			AppDomain.NativeMethodInfoPtr_IsFinalizingForUnload_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666726);
			AppDomain.NativeMethodInfoPtr_getDomainID_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666727);
			AppDomain.NativeMethodInfoPtr_GetCurrentThreadId_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666728);
			AppDomain.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666729);
			AppDomain.NativeMethodInfoPtr_DoAssemblyLoad_Private_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666730);
			AppDomain.NativeMethodInfoPtr_DoAssemblyResolve_Private_Assembly_String_Assembly_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666731);
			AppDomain.NativeMethodInfoPtr_DoTypeResolve_Internal_Assembly_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666732);
			AppDomain.NativeMethodInfoPtr_DoResourceResolve_Internal_Assembly_String_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666733);
			AppDomain.NativeMethodInfoPtr_DoDomainUnload_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666734);
			AppDomain.NativeMethodInfoPtr_GetMarshalledDomainObjRef_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666735);
			AppDomain.NativeMethodInfoPtr_ProcessMessageInDomain_Internal_Void_Il2CppStructArray_1_Byte_CADMethodCallMessage_byref_Il2CppStructArray_1_Byte_byref_CADMethodReturnMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666736);
			AppDomain.NativeMethodInfoPtr_add_DomainUnload_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666737);
			AppDomain.NativeMethodInfoPtr_remove_DomainUnload_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666738);
			AppDomain.NativeMethodInfoPtr_add_ProcessExit_Public_Virtual_Final_New_add_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666739);
			AppDomain.NativeMethodInfoPtr_remove_ProcessExit_Public_Virtual_Final_New_rem_Void_EventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666740);
			AppDomain.NativeMethodInfoPtr_add_UnhandledException_Public_Virtual_Final_New_add_Void_UnhandledExceptionEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666741);
			AppDomain.NativeMethodInfoPtr_remove_UnhandledException_Public_Virtual_Final_New_rem_Void_UnhandledExceptionEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomain>.NativeClassPtr, 100666742);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0007DE3C File Offset: 0x0007C03C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppDomain()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppDomain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x0007DE78 File Offset: 0x0007C078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173552, XrefRangeEnd = 173553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getFriendlyName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_getFriendlyName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0007DEB0 File Offset: 0x0007C0B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 173557, RefRangeEnd = 173561, XrefRangeStart = 173553, XrefRangeEnd = 173557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AppDomain getCurDomain()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_getCurDomain_Private_Static_AppDomain_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppDomain>(intPtr3) : null;
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x0007DEE4 File Offset: 0x0007C0E4
		public unsafe static AppDomain CurrentDomain
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 173557, RefRangeEnd = 173561, XrefRangeStart = 173557, XrefRangeEnd = 173561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_get_CurrentDomain_Public_Static_get_AppDomain_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppDomain>(intPtr3) : null;
			}
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x0007DF18 File Offset: 0x0007C118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173561, XrefRangeEnd = 173579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Assembly> GetAssemblies(bool refOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref refOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetAssemblies_Private_Il2CppReferenceArray_1_Assembly_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Assembly>>(intPtr3) : null;
			}
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0007DF64 File Offset: 0x0007C164
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 173597, RefRangeEnd = 173603, XrefRangeStart = 173579, XrefRangeEnd = 173597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Assembly> GetAssemblies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetAssemblies_Public_Virtual_Final_New_Il2CppReferenceArray_1_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Assembly>>(intPtr3) : null;
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0007DFA4 File Offset: 0x0007C1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173603, XrefRangeEnd = 173610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetData(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0007DFF4 File Offset: 0x0007C1F4
		[CallerCount(0)]
		public unsafe override Object InitializeLifetimeService()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0007E034 File Offset: 0x0007C234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173610, XrefRangeEnd = 173611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(securityEvidence);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_LoadAssembly_Internal_Assembly_String_Evidence_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0007E0A4 File Offset: 0x0007C2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173611, XrefRangeEnd = 173613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assemblyRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_LoadSatellite_Internal_Assembly_AssemblyName_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0007E104 File Offset: 0x0007C304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173613, XrefRangeEnd = 173614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly Load(string assemblyString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0007E154 File Offset: 0x0007C354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173614, XrefRangeEnd = 173615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblySecurity);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refonly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_Load_Internal_Assembly_String_Evidence_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0007E1C4 File Offset: 0x0007C3C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173616, RefRangeEnd = 173617, XrefRangeStart = 173615, XrefRangeEnd = 173616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly Load(Il2CppStructArray<byte> rawAssembly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawAssembly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0007E214 File Offset: 0x0007C414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173618, RefRangeEnd = 173619, XrefRangeStart = 173617, XrefRangeEnd = 173618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly LoadAssemblyRaw(Il2CppStructArray<byte> rawAssembly, Il2CppStructArray<byte> rawSymbolStore, Evidence securityEvidence, bool refonly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawAssembly);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rawSymbolStore);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(securityEvidence);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refonly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_LoadAssemblyRaw_Internal_Assembly_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Evidence_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x0007E298 File Offset: 0x0007C498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173620, RefRangeEnd = 173621, XrefRangeStart = 173619, XrefRangeEnd = 173620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly Load(Il2CppStructArray<byte> rawAssembly, Il2CppStructArray<byte> rawSymbolStore, Evidence securityEvidence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawAssembly);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rawSymbolStore);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(securityEvidence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Evidence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0007E30C File Offset: 0x0007C50C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173628, RefRangeEnd = 173629, XrefRangeStart = 173621, XrefRangeEnd = 173628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly Load(Il2CppStructArray<byte> rawAssembly, Il2CppStructArray<byte> rawSymbolStore, Evidence securityEvidence, bool refonly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawAssembly);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rawSymbolStore);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(securityEvidence);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refonly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_Load_Internal_Assembly_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Evidence_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0007E390 File Offset: 0x0007C590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173629, XrefRangeEnd = 173630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AppDomain InternalSetDomainByID(int domain_id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domain_id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalSetDomainByID_Private_Static_AppDomain_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppDomain>(intPtr3) : null;
			}
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x0007E3D0 File Offset: 0x0007C5D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173631, RefRangeEnd = 173632, XrefRangeStart = 173630, XrefRangeEnd = 173631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AppDomain InternalSetDomain(AppDomain context)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalSetDomain_Private_Static_AppDomain_AppDomain_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppDomain>(intPtr3) : null;
			}
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0007E414 File Offset: 0x0007C614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173633, RefRangeEnd = 173634, XrefRangeStart = 173632, XrefRangeEnd = 173633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalPushDomainRefByID(int domain_id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domain_id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalPushDomainRefByID_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x0007E448 File Offset: 0x0007C648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173634, XrefRangeEnd = 173635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalPopDomainRef()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalPopDomainRef_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x0007E470 File Offset: 0x0007C670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173636, RefRangeEnd = 173637, XrefRangeStart = 173635, XrefRangeEnd = 173636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context InternalSetContext(Context context)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalSetContext_Internal_Static_Context_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x0007E4B4 File Offset: 0x0007C6B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173638, RefRangeEnd = 173641, XrefRangeStart = 173637, XrefRangeEnd = 173638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context InternalGetContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalGetContext_Internal_Static_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x0007E4E8 File Offset: 0x0007C6E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173638, RefRangeEnd = 173641, XrefRangeStart = 173638, XrefRangeEnd = 173641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context InternalGetDefaultContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalGetDefaultContext_Internal_Static_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0007E51C File Offset: 0x0007C71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173641, XrefRangeEnd = 173642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalGetProcessGuid(string newguid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newguid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalGetProcessGuid_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x0007E558 File Offset: 0x0007C758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173646, RefRangeEnd = 173647, XrefRangeStart = 173642, XrefRangeEnd = 173646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object InvokeInDomainByID(int domain_id, MethodInfo method, Object obj, Il2CppReferenceArray<Object> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domain_id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InvokeInDomainByID_Internal_Static_Object_Int32_MethodInfo_Object_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x0007E5D0 File Offset: 0x0007C7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173647, XrefRangeEnd = 173650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetProcessGuid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetProcessGuid_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x0007E5FC File Offset: 0x0007C7FC
		[CallerCount(0)]
		public unsafe static bool InternalIsFinalizingForUnload(int domain_id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domain_id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_InternalIsFinalizingForUnload_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0007E63C File Offset: 0x0007C83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173650, XrefRangeEnd = 173651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFinalizingForUnload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_IsFinalizingForUnload_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0007E678 File Offset: 0x0007C878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173653, RefRangeEnd = 173654, XrefRangeStart = 173651, XrefRangeEnd = 173653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int getDomainID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_getDomainID_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0007E6B4 File Offset: 0x0007C8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173654, XrefRangeEnd = 173655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCurrentThreadId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetCurrentThreadId_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0007E6E4 File Offset: 0x0007C8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0007E71C File Offset: 0x0007C91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173655, XrefRangeEnd = 173662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoAssemblyLoad(Assembly assembly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_DoAssemblyLoad_Private_Void_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0007E760 File Offset: 0x0007C960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173662, XrefRangeEnd = 173696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestingAssembly);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refonly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_DoAssemblyResolve_Private_Assembly_String_Assembly_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0007E7D0 File Offset: 0x0007C9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173696, XrefRangeEnd = 173735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly DoTypeResolve(Object name_or_tb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name_or_tb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_DoTypeResolve_Internal_Assembly_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x0007E820 File Offset: 0x0007CA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173735, XrefRangeEnd = 173743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly DoResourceResolve(string name, Assembly requesting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requesting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_DoResourceResolve_Internal_Assembly_String_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0007E884 File Offset: 0x0007CA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173743, XrefRangeEnd = 173744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoDomainUnload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_DoDomainUnload_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0007E8B8 File Offset: 0x0007CAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173744, XrefRangeEnd = 173755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetMarshalledDomainObjRef()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_GetMarshalledDomainObjRef_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0007E8F8 File Offset: 0x0007CAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173755, XrefRangeEnd = 173784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMessageInDomain(Il2CppStructArray<byte> arrRequest, CADMethodCallMessage cadMsg, out Il2CppStructArray<byte> arrResponse, out CADMethodReturnMessage cadMrm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arrRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cadMsg);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_ProcessMessageInDomain_Internal_Void_Il2CppStructArray_1_Byte_CADMethodCallMessage_byref_Il2CppStructArray_1_Byte_byref_CADMethodReturnMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			arrResponse = ((intPtr5 == 0) ? null : new Il2CppStructArray<byte>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			cadMrm = ((intPtr6 == 0) ? null : new CADMethodReturnMessage(intPtr6));
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x0007E994 File Offset: 0x0007CB94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173787, RefRangeEnd = 173789, XrefRangeStart = 173784, XrefRangeEnd = 173787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_DomainUnload(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_add_DomainUnload_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x0007E9D8 File Offset: 0x0007CBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173789, XrefRangeEnd = 173792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_DomainUnload(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_remove_DomainUnload_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x0007EA1C File Offset: 0x0007CC1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173795, RefRangeEnd = 173796, XrefRangeStart = 173792, XrefRangeEnd = 173795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ProcessExit(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_add_ProcessExit_Public_Virtual_Final_New_add_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x0007EA60 File Offset: 0x0007CC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173796, XrefRangeEnd = 173799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ProcessExit(EventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_remove_ProcessExit_Public_Virtual_Final_New_rem_Void_EventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x0007EAA4 File Offset: 0x0007CCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173799, XrefRangeEnd = 173802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_UnhandledException(UnhandledExceptionEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_add_UnhandledException_Public_Virtual_Final_New_add_Void_UnhandledExceptionEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x0007EAE8 File Offset: 0x0007CCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173802, XrefRangeEnd = 173805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_UnhandledException(UnhandledExceptionEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomain.NativeMethodInfoPtr_remove_UnhandledException_Public_Virtual_Final_New_rem_Void_UnhandledExceptionEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x000067F8 File Offset: 0x000049F8
		public AppDomain(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x0007EB2C File Offset: 0x0007CD2C
		// (set) Token: 0x06001367 RID: 4967 RVA: 0x00006801 File Offset: 0x00004A01
		public unsafe IntPtr _mono_app_domain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__mono_app_domain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__mono_app_domain)) = value;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x0007EB54 File Offset: 0x0007CD54
		// (set) Token: 0x06001369 RID: 4969 RVA: 0x0000681C File Offset: 0x00004A1C
		public unsafe static string _process_guid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppDomain.NativeFieldInfoPtr__process_guid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppDomain.NativeFieldInfoPtr__process_guid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x0007EB74 File Offset: 0x0007CD74
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x0000682E File Offset: 0x00004A2E
		public unsafe static Dictionary<string, Object> type_resolve_in_progress
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppDomain.NativeFieldInfoPtr_type_resolve_in_progress, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppDomain.NativeFieldInfoPtr_type_resolve_in_progress, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x0007EB9C File Offset: 0x0007CD9C
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x00006840 File Offset: 0x00004A40
		public unsafe static Dictionary<string, Object> assembly_resolve_in_progress
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x0007EBC4 File Offset: 0x0007CDC4
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x00006852 File Offset: 0x00004A52
		public unsafe static Dictionary<string, Object> assembly_resolve_in_progress_refonly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress_refonly, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppDomain.NativeFieldInfoPtr_assembly_resolve_in_progress_refonly, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x0007EBEC File Offset: 0x0007CDEC
		// (set) Token: 0x06001371 RID: 4977 RVA: 0x00006864 File Offset: 0x00004A64
		public unsafe Object _evidence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__evidence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__evidence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x0007EC1C File Offset: 0x0007CE1C
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x00006883 File Offset: 0x00004A83
		public unsafe Object _granted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__granted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__granted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x0007EC4C File Offset: 0x0007CE4C
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x000068A2 File Offset: 0x00004AA2
		public unsafe int _principalPolicy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__principalPolicy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__principalPolicy)) = value;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x0007EC74 File Offset: 0x0007CE74
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x000068BD File Offset: 0x00004ABD
		public unsafe static Object _principal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppDomain.NativeFieldInfoPtr__principal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppDomain.NativeFieldInfoPtr__principal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x0007EC9C File Offset: 0x0007CE9C
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x000068CF File Offset: 0x00004ACF
		public unsafe static AppDomain default_domain
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppDomain.NativeFieldInfoPtr_default_domain, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppDomain>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppDomain.NativeFieldInfoPtr_default_domain, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x0007ECC4 File Offset: 0x0007CEC4
		// (set) Token: 0x0600137B RID: 4987 RVA: 0x000068E1 File Offset: 0x00004AE1
		public unsafe AssemblyLoadEventHandler AssemblyLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_AssemblyLoad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssemblyLoadEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_AssemblyLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x0007ECF4 File Offset: 0x0007CEF4
		// (set) Token: 0x0600137D RID: 4989 RVA: 0x00006900 File Offset: 0x00004B00
		public unsafe ResolveEventHandler AssemblyResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_AssemblyResolve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_AssemblyResolve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x0007ED24 File Offset: 0x0007CF24
		// (set) Token: 0x0600137F RID: 4991 RVA: 0x0000691F File Offset: 0x00004B1F
		public unsafe EventHandler DomainUnload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_DomainUnload);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_DomainUnload), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x0007ED54 File Offset: 0x0007CF54
		// (set) Token: 0x06001381 RID: 4993 RVA: 0x0000693E File Offset: 0x00004B3E
		public unsafe EventHandler ProcessExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ProcessExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ProcessExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x0007ED84 File Offset: 0x0007CF84
		// (set) Token: 0x06001383 RID: 4995 RVA: 0x0000695D File Offset: 0x00004B5D
		public unsafe ResolveEventHandler ResourceResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ResourceResolve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ResourceResolve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x0007EDB4 File Offset: 0x0007CFB4
		// (set) Token: 0x06001385 RID: 4997 RVA: 0x0000697C File Offset: 0x00004B7C
		public unsafe ResolveEventHandler TypeResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_TypeResolve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_TypeResolve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x0007EDE4 File Offset: 0x0007CFE4
		// (set) Token: 0x06001387 RID: 4999 RVA: 0x0000699B File Offset: 0x00004B9B
		public unsafe UnhandledExceptionEventHandler UnhandledException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_UnhandledException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnhandledExceptionEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_UnhandledException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x0007EE14 File Offset: 0x0007D014
		// (set) Token: 0x06001389 RID: 5001 RVA: 0x000069BA File Offset: 0x00004BBA
		public unsafe EventHandler<FirstChanceExceptionEventArgs> FirstChanceException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_FirstChanceException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<FirstChanceExceptionEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_FirstChanceException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x0007EE44 File Offset: 0x0007D044
		// (set) Token: 0x0600138B RID: 5003 RVA: 0x000069D9 File Offset: 0x00004BD9
		public unsafe Object _domain_manager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__domain_manager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__domain_manager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x0007EE74 File Offset: 0x0007D074
		// (set) Token: 0x0600138D RID: 5005 RVA: 0x000069F8 File Offset: 0x00004BF8
		public unsafe ResolveEventHandler ReflectionOnlyAssemblyResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ReflectionOnlyAssemblyResolve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_ReflectionOnlyAssemblyResolve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x0007EEA4 File Offset: 0x0007D0A4
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x00006A17 File Offset: 0x00004C17
		public unsafe Object _activation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__activation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__activation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x0007EED4 File Offset: 0x0007D0D4
		// (set) Token: 0x06001391 RID: 5009 RVA: 0x00006A36 File Offset: 0x00004C36
		public unsafe Object _applicationIdentity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__applicationIdentity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr__applicationIdentity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x0007EF04 File Offset: 0x0007D104
		// (set) Token: 0x06001393 RID: 5011 RVA: 0x00006A55 File Offset: 0x00004C55
		public unsafe List<string> compatibility_switch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_compatibility_switch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomain.NativeFieldInfoPtr_compatibility_switch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeFieldInfoPtr__mono_app_domain;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeFieldInfoPtr__process_guid;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeFieldInfoPtr_type_resolve_in_progress;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeFieldInfoPtr_assembly_resolve_in_progress;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeFieldInfoPtr_assembly_resolve_in_progress_refonly;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeFieldInfoPtr__evidence;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeFieldInfoPtr__granted;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeFieldInfoPtr__principalPolicy;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeFieldInfoPtr__principal;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeFieldInfoPtr_default_domain;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeFieldInfoPtr_AssemblyLoad;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeFieldInfoPtr_AssemblyResolve;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeFieldInfoPtr_DomainUnload;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeFieldInfoPtr_ProcessExit;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeFieldInfoPtr_ResourceResolve;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeFieldInfoPtr_TypeResolve;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeFieldInfoPtr_UnhandledException;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeFieldInfoPtr_FirstChanceException;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeFieldInfoPtr__domain_manager;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeFieldInfoPtr_ReflectionOnlyAssemblyResolve;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeFieldInfoPtr__activation;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeFieldInfoPtr__applicationIdentity;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeFieldInfoPtr_compatibility_switch;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeMethodInfoPtr_getFriendlyName_Private_String_0;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeMethodInfoPtr_getCurDomain_Private_Static_AppDomain_0;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDomain_Public_Static_get_AppDomain_0;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblies_Private_Il2CppReferenceArray_1_Assembly_Boolean_0;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblies_Public_Virtual_Final_New_Il2CppReferenceArray_1_Assembly_0;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_Object_String_0;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_Object_0;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssembly_Internal_Assembly_String_Evidence_Boolean_0;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr_LoadSatellite_Internal_Assembly_AssemblyName_Boolean_0;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_String_0;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeMethodInfoPtr_Load_Internal_Assembly_String_Evidence_Boolean_0;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_Il2CppStructArray_1_Byte_0;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssemblyRaw_Internal_Assembly_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Evidence_Boolean_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Assembly_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Evidence_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_Load_Internal_Assembly_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Evidence_Boolean_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetDomainByID_Private_Static_AppDomain_Int32_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetDomain_Private_Static_AppDomain_AppDomain_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_InternalPushDomainRefByID_Internal_Static_Void_Int32_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_InternalPopDomainRef_Internal_Static_Void_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetContext_Internal_Static_Context_Context_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetContext_Internal_Static_Context_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetDefaultContext_Internal_Static_Context_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetProcessGuid_Internal_Static_String_String_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_InvokeInDomainByID_Internal_Static_Object_Int32_MethodInfo_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_GetProcessGuid_Internal_Static_String_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsFinalizingForUnload_Private_Static_Boolean_Int32_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr_IsFinalizingForUnload_Public_Boolean_0;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr_getDomainID_Private_Int32_0;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentThreadId_Public_Static_Int32_0;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeMethodInfoPtr_DoAssemblyLoad_Private_Void_Assembly_0;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeMethodInfoPtr_DoAssemblyResolve_Private_Assembly_String_Assembly_Boolean_0;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_DoTypeResolve_Internal_Assembly_Object_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr_DoResourceResolve_Internal_Assembly_String_Assembly_0;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeMethodInfoPtr_DoDomainUnload_Private_Void_0;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeMethodInfoPtr_GetMarshalledDomainObjRef_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessageInDomain_Internal_Void_Il2CppStructArray_1_Byte_CADMethodCallMessage_byref_Il2CppStructArray_1_Byte_byref_CADMethodReturnMessage_0;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr_add_DomainUnload_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_remove_DomainUnload_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr_add_ProcessExit_Public_Virtual_Final_New_add_Void_EventHandler_0;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr_remove_ProcessExit_Public_Virtual_Final_New_rem_Void_EventHandler_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_add_UnhandledException_Public_Virtual_Final_New_add_Void_UnhandledExceptionEventHandler_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_remove_UnhandledException_Public_Virtual_Final_New_rem_Void_UnhandledExceptionEventHandler_0;
	}
}
