using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000401 RID: 1025
	[Serializable]
	public class MonoMethodMessage : Object
	{
		// Token: 0x060041C7 RID: 16839 RVA: 0x00132870 File Offset: 0x00130A70
		// Note: this type is marked as 'beforefieldinit'.
		static MonoMethodMessage()
		{
			Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MonoMethodMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr);
			MonoMethodMessage.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "method");
			MonoMethodMessage.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "args");
			MonoMethodMessage.NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "names");
			MonoMethodMessage.NativeFieldInfoPtr_arg_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "arg_types");
			MonoMethodMessage.NativeFieldInfoPtr_ctx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "ctx");
			MonoMethodMessage.NativeFieldInfoPtr_rval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "rval");
			MonoMethodMessage.NativeFieldInfoPtr_exc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "exc");
			MonoMethodMessage.NativeFieldInfoPtr_asyncResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "asyncResult");
			MonoMethodMessage.NativeFieldInfoPtr_call_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "call_type");
			MonoMethodMessage.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "uri");
			MonoMethodMessage.NativeFieldInfoPtr_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "properties");
			MonoMethodMessage.NativeFieldInfoPtr_methodSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "methodSignature");
			MonoMethodMessage.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "identity");
			MonoMethodMessage.NativeFieldInfoPtr_CallContextKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "CallContextKey");
			MonoMethodMessage.NativeFieldInfoPtr_UriKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "UriKey");
			MonoMethodMessage.NativeMethodInfoPtr_InitMessage_Internal_Void_MonoMethod_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672949);
			MonoMethodMessage.NativeMethodInfoPtr__ctor_Public_Void_MethodBase_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672950);
			MonoMethodMessage.NativeMethodInfoPtr__ctor_Internal_Void_MethodInfo_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672951);
			MonoMethodMessage.NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672952);
			MonoMethodMessage.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672953);
			MonoMethodMessage.NativeMethodInfoPtr_get_Properties_Public_Virtual_Final_New_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672954);
			MonoMethodMessage.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672955);
			MonoMethodMessage.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672956);
			MonoMethodMessage.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672957);
			MonoMethodMessage.NativeMethodInfoPtr_set_LogicalCallContext_Public_set_Void_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672958);
			MonoMethodMessage.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672959);
			MonoMethodMessage.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672960);
			MonoMethodMessage.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672961);
			MonoMethodMessage.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672962);
			MonoMethodMessage.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672963);
			MonoMethodMessage.NativeMethodInfoPtr_set_Uri_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672964);
			MonoMethodMessage.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672965);
			MonoMethodMessage.NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672966);
			MonoMethodMessage.NativeMethodInfoPtr_get_OutArgCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672967);
			MonoMethodMessage.NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672968);
			MonoMethodMessage.NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672969);
			MonoMethodMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672970);
			MonoMethodMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672971);
			MonoMethodMessage.NativeMethodInfoPtr_get_AsyncResult_Public_get_AsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672972);
			MonoMethodMessage.NativeMethodInfoPtr_get_CallType_Internal_get_CallType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672973);
			MonoMethodMessage.NativeMethodInfoPtr_NeedsOutProcessing_Public_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672974);
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x00132BD4 File Offset: 0x00130DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225449, RefRangeEnd = 225450, XrefRangeStart = 225435, XrefRangeEnd = 225449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMessage(MonoMethod method, Il2CppReferenceArray<Object> out_args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(out_args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_InitMessage_Internal_Void_MonoMethod_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x00132C28 File Offset: 0x00130E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225450, XrefRangeEnd = 225453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoMethodMessage(MethodBase method, Il2CppReferenceArray<Object> out_args)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(out_args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr__ctor_Public_Void_MethodBase_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041CA RID: 16842 RVA: 0x00132C88 File Offset: 0x00130E88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 225458, RefRangeEnd = 225461, XrefRangeStart = 225453, XrefRangeEnd = 225458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoMethodMessage(MethodInfo minfo, Il2CppReferenceArray<Object> in_args, Il2CppReferenceArray<Object> out_args)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(minfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(in_args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(out_args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr__ctor_Internal_Void_MethodInfo_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041CB RID: 16843 RVA: 0x00132CF8 File Offset: 0x00130EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225461, XrefRangeEnd = 225462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetMethodInfo(Type type, string methodName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x060041CC RID: 16844 RVA: 0x00132D50 File Offset: 0x00130F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225462, XrefRangeEnd = 225482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoMethodMessage(Type type, string methodName, Il2CppReferenceArray<Object> in_args)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(in_args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x060041CD RID: 16845 RVA: 0x00132DC0 File Offset: 0x00130FC0
		public unsafe virtual IDictionary Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225482, XrefRangeEnd = 225486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_Properties_Public_Virtual_Final_New_get_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x060041CE RID: 16846 RVA: 0x00132E00 File Offset: 0x00131000
		public unsafe virtual int ArgCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225486, XrefRangeEnd = 225487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x060041CF RID: 16847 RVA: 0x00132E3C File Offset: 0x0013103C
		public unsafe virtual Il2CppReferenceArray<Object> Args
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x060041D0 RID: 16848 RVA: 0x00132E7C File Offset: 0x0013107C
		// (set) Token: 0x060041D1 RID: 16849 RVA: 0x00132EBC File Offset: 0x001310BC
		public unsafe virtual LogicalCallContext LogicalCallContext
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_set_LogicalCallContext_Public_set_Void_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x060041D2 RID: 16850 RVA: 0x00132F00 File Offset: 0x00131100
		public unsafe virtual MethodBase MethodBase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x060041D3 RID: 16851 RVA: 0x00132F40 File Offset: 0x00131140
		public unsafe virtual string MethodName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225487, XrefRangeEnd = 225490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x060041D4 RID: 16852 RVA: 0x00132F78 File Offset: 0x00131178
		public unsafe virtual Object MethodSignature
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225490, XrefRangeEnd = 225496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x060041D5 RID: 16853 RVA: 0x00132FB8 File Offset: 0x001311B8
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225496, XrefRangeEnd = 225499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x060041D6 RID: 16854 RVA: 0x00132FF0 File Offset: 0x001311F0
		// (set) Token: 0x060041D7 RID: 16855 RVA: 0x00133028 File Offset: 0x00131228
		public unsafe virtual string Uri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 17925, RefRangeEnd = 17937, XrefRangeStart = 17925, XrefRangeEnd = 17937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_set_Uri_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060041D8 RID: 16856 RVA: 0x0013306C File Offset: 0x0013126C
		[CallerCount(0)]
		public unsafe virtual Object GetArg(int arg_num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref arg_num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x060041D9 RID: 16857 RVA: 0x001330B8 File Offset: 0x001312B8
		public unsafe virtual Exception Exception
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x060041DA RID: 16858 RVA: 0x001330F8 File Offset: 0x001312F8
		public unsafe virtual int OutArgCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225499, XrefRangeEnd = 225500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_OutArgCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x060041DB RID: 16859 RVA: 0x00133134 File Offset: 0x00131334
		public unsafe virtual Il2CppReferenceArray<Object> OutArgs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225500, XrefRangeEnd = 225507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x060041DC RID: 16860 RVA: 0x00133174 File Offset: 0x00131374
		public unsafe virtual Object ReturnValue
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x060041DD RID: 16861 RVA: 0x001331B4 File Offset: 0x001313B4
		// (set) Token: 0x060041DE RID: 16862 RVA: 0x001331F4 File Offset: 0x001313F4
		public unsafe virtual Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 89481, RefRangeEnd = 89490, XrefRangeStart = 89481, XrefRangeEnd = 89490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x060041DF RID: 16863 RVA: 0x00133238 File Offset: 0x00131438
		public unsafe AsyncResult AsyncResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_AsyncResult_Public_get_AsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncResult>(intPtr3) : null;
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x060041E0 RID: 16864 RVA: 0x00133278 File Offset: 0x00131478
		public unsafe CallType CallType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 225516, RefRangeEnd = 225521, XrefRangeStart = 225507, XrefRangeEnd = 225516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_CallType_Internal_get_CallType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x001332B4 File Offset: 0x001314B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225521, XrefRangeEnd = 225523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NeedsOutProcessing(out int outCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &outCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_NeedsOutProcessing_Public_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x00018C14 File Offset: 0x00016E14
		public MonoMethodMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x060041E3 RID: 16867 RVA: 0x00133300 File Offset: 0x00131500
		// (set) Token: 0x060041E4 RID: 16868 RVA: 0x00018C1D File Offset: 0x00016E1D
		public unsafe MonoMethod method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoMethod>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x060041E5 RID: 16869 RVA: 0x00133330 File Offset: 0x00131530
		// (set) Token: 0x060041E6 RID: 16870 RVA: 0x00018C3C File Offset: 0x00016E3C
		public unsafe Il2CppReferenceArray<Object> args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x060041E7 RID: 16871 RVA: 0x00133360 File Offset: 0x00131560
		// (set) Token: 0x060041E8 RID: 16872 RVA: 0x00018C5B File Offset: 0x00016E5B
		public unsafe Il2CppStringArray names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x060041E9 RID: 16873 RVA: 0x00133390 File Offset: 0x00131590
		// (set) Token: 0x060041EA RID: 16874 RVA: 0x00018C7A File Offset: 0x00016E7A
		public unsafe Il2CppStructArray<byte> arg_types
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_arg_types);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_arg_types), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x060041EB RID: 16875 RVA: 0x001333C0 File Offset: 0x001315C0
		// (set) Token: 0x060041EC RID: 16876 RVA: 0x00018C99 File Offset: 0x00016E99
		public unsafe LogicalCallContext ctx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_ctx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_ctx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x060041ED RID: 16877 RVA: 0x001333F0 File Offset: 0x001315F0
		// (set) Token: 0x060041EE RID: 16878 RVA: 0x00018CB8 File Offset: 0x00016EB8
		public unsafe Object rval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_rval);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_rval), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x060041EF RID: 16879 RVA: 0x00133420 File Offset: 0x00131620
		// (set) Token: 0x060041F0 RID: 16880 RVA: 0x00018CD7 File Offset: 0x00016ED7
		public unsafe Exception exc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_exc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_exc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x060041F1 RID: 16881 RVA: 0x00133450 File Offset: 0x00131650
		// (set) Token: 0x060041F2 RID: 16882 RVA: 0x00018CF6 File Offset: 0x00016EF6
		public unsafe AsyncResult asyncResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_asyncResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_asyncResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x060041F3 RID: 16883 RVA: 0x00133480 File Offset: 0x00131680
		// (set) Token: 0x060041F4 RID: 16884 RVA: 0x00018D15 File Offset: 0x00016F15
		public unsafe CallType call_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_call_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_call_type)) = value;
			}
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x060041F5 RID: 16885 RVA: 0x001334A8 File Offset: 0x001316A8
		// (set) Token: 0x060041F6 RID: 16886 RVA: 0x00018D30 File Offset: 0x00016F30
		public unsafe string uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x060041F7 RID: 16887 RVA: 0x001334D0 File Offset: 0x001316D0
		// (set) Token: 0x060041F8 RID: 16888 RVA: 0x00018D4F File Offset: 0x00016F4F
		public unsafe MCMDictionary properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MCMDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x060041F9 RID: 16889 RVA: 0x00133500 File Offset: 0x00131700
		// (set) Token: 0x060041FA RID: 16890 RVA: 0x00018D6E File Offset: 0x00016F6E
		public unsafe Il2CppReferenceArray<Type> methodSignature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_methodSignature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_methodSignature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x060041FB RID: 16891 RVA: 0x00133530 File Offset: 0x00131730
		// (set) Token: 0x060041FC RID: 16892 RVA: 0x00018D8D File Offset: 0x00016F8D
		public unsafe Identity identity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_identity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_identity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x060041FD RID: 16893 RVA: 0x00133560 File Offset: 0x00131760
		// (set) Token: 0x060041FE RID: 16894 RVA: 0x00018DAC File Offset: 0x00016FAC
		public unsafe static string CallContextKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoMethodMessage.NativeFieldInfoPtr_CallContextKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoMethodMessage.NativeFieldInfoPtr_CallContextKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x060041FF RID: 16895 RVA: 0x00133580 File Offset: 0x00131780
		// (set) Token: 0x06004200 RID: 16896 RVA: 0x00018DBE File Offset: 0x00016FBE
		public unsafe static string UriKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoMethodMessage.NativeFieldInfoPtr_UriKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoMethodMessage.NativeFieldInfoPtr_UriKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040035BE RID: 13758
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x040035BF RID: 13759
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x040035C0 RID: 13760
		private static readonly IntPtr NativeFieldInfoPtr_names;

		// Token: 0x040035C1 RID: 13761
		private static readonly IntPtr NativeFieldInfoPtr_arg_types;

		// Token: 0x040035C2 RID: 13762
		private static readonly IntPtr NativeFieldInfoPtr_ctx;

		// Token: 0x040035C3 RID: 13763
		private static readonly IntPtr NativeFieldInfoPtr_rval;

		// Token: 0x040035C4 RID: 13764
		private static readonly IntPtr NativeFieldInfoPtr_exc;

		// Token: 0x040035C5 RID: 13765
		private static readonly IntPtr NativeFieldInfoPtr_asyncResult;

		// Token: 0x040035C6 RID: 13766
		private static readonly IntPtr NativeFieldInfoPtr_call_type;

		// Token: 0x040035C7 RID: 13767
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x040035C8 RID: 13768
		private static readonly IntPtr NativeFieldInfoPtr_properties;

		// Token: 0x040035C9 RID: 13769
		private static readonly IntPtr NativeFieldInfoPtr_methodSignature;

		// Token: 0x040035CA RID: 13770
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x040035CB RID: 13771
		private static readonly IntPtr NativeFieldInfoPtr_CallContextKey;

		// Token: 0x040035CC RID: 13772
		private static readonly IntPtr NativeFieldInfoPtr_UriKey;

		// Token: 0x040035CD RID: 13773
		private static readonly IntPtr NativeMethodInfoPtr_InitMessage_Internal_Void_MonoMethod_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040035CE RID: 13774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodBase_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040035CF RID: 13775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_MethodInfo_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040035D0 RID: 13776
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Type_String_0;

		// Token: 0x040035D1 RID: 13777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040035D2 RID: 13778
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_Final_New_get_IDictionary_0;

		// Token: 0x040035D3 RID: 13779
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040035D4 RID: 13780
		private static readonly IntPtr NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040035D5 RID: 13781
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0;

		// Token: 0x040035D6 RID: 13782
		private static readonly IntPtr NativeMethodInfoPtr_set_LogicalCallContext_Public_set_Void_LogicalCallContext_0;

		// Token: 0x040035D7 RID: 13783
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0;

		// Token: 0x040035D8 RID: 13784
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040035D9 RID: 13785
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040035DA RID: 13786
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040035DB RID: 13787
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040035DC RID: 13788
		private static readonly IntPtr NativeMethodInfoPtr_set_Uri_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x040035DD RID: 13789
		private static readonly IntPtr NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0;

		// Token: 0x040035DE RID: 13790
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0;

		// Token: 0x040035DF RID: 13791
		private static readonly IntPtr NativeMethodInfoPtr_get_OutArgCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040035E0 RID: 13792
		private static readonly IntPtr NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040035E1 RID: 13793
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040035E2 RID: 13794
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0;

		// Token: 0x040035E3 RID: 13795
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0;

		// Token: 0x040035E4 RID: 13796
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncResult_Public_get_AsyncResult_0;

		// Token: 0x040035E5 RID: 13797
		private static readonly IntPtr NativeMethodInfoPtr_get_CallType_Internal_get_CallType_0;

		// Token: 0x040035E6 RID: 13798
		private static readonly IntPtr NativeMethodInfoPtr_NeedsOutProcessing_Public_Boolean_byref_Int32_0;
	}
}
