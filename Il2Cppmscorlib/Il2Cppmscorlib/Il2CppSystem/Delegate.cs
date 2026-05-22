using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000113 RID: 275
	[Serializable]
	public class Delegate : Object
	{
		// Token: 0x0600145C RID: 5212 RVA: 0x000816BC File Offset: 0x0007F8BC
		// Note: this type is marked as 'beforefieldinit'.
		static Delegate()
		{
			Il2CppClassPointerStore<Delegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Delegate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Delegate>.NativeClassPtr);
			Delegate.NativeFieldInfoPtr_method_ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "method_ptr");
			Delegate.NativeFieldInfoPtr_invoke_impl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "invoke_impl");
			Delegate.NativeFieldInfoPtr_m_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "m_target");
			Delegate.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "method");
			Delegate.NativeFieldInfoPtr_delegate_trampoline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "delegate_trampoline");
			Delegate.NativeFieldInfoPtr_extra_arg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "extra_arg");
			Delegate.NativeFieldInfoPtr_method_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "method_code");
			Delegate.NativeFieldInfoPtr_method_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "method_info");
			Delegate.NativeFieldInfoPtr_original_method_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "original_method_info");
			Delegate.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "data");
			Delegate.NativeFieldInfoPtr_method_is_virtual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "method_is_virtual");
			Delegate.NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666841);
			Delegate.NativeMethodInfoPtr_GetVirtualMethod_internal_Private_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666842);
			Delegate.NativeMethodInfoPtr_get_Target_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666843);
			Delegate.NativeMethodInfoPtr_CreateDelegate_internal_Internal_Static_Delegate_Type_Object_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666844);
			Delegate.NativeMethodInfoPtr_arg_type_match_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666845);
			Delegate.NativeMethodInfoPtr_arg_type_match_this_Private_Static_Boolean_Type_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666846);
			Delegate.NativeMethodInfoPtr_return_type_match_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666847);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666848);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Private_Static_Delegate_Type_Object_MethodInfo_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666849);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666850);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666851);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666852);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666853);
			Delegate.NativeMethodInfoPtr_GetCandidateMethod_Private_Static_MethodInfo_Type_Type_String_BindingFlags_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666854);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666855);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666856);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666857);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666858);
			Delegate.NativeMethodInfoPtr_DynamicInvoke_Public_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666859);
			Delegate.NativeMethodInfoPtr_InitializeDelegateData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666860);
			Delegate.NativeMethodInfoPtr_DynamicInvokeImpl_Protected_Virtual_New_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666861);
			Delegate.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666862);
			Delegate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666863);
			Delegate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666864);
			Delegate.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_New_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666865);
			Delegate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666866);
			Delegate.NativeMethodInfoPtr_GetInvocationList_Public_Virtual_New_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666867);
			Delegate.NativeMethodInfoPtr_Combine_Public_Static_Delegate_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666868);
			Delegate.NativeMethodInfoPtr_Combine_Public_Static_Delegate_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666869);
			Delegate.NativeMethodInfoPtr_CombineImpl_Protected_Virtual_New_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666870);
			Delegate.NativeMethodInfoPtr_Remove_Public_Static_Delegate_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666871);
			Delegate.NativeMethodInfoPtr_RemoveImpl_Protected_Virtual_New_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666872);
			Delegate.NativeMethodInfoPtr_RemoveAll_Public_Static_Delegate_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666873);
			Delegate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666874);
			Delegate.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666875);
			Delegate.NativeMethodInfoPtr_CreateDelegateNoSecurityCheck_Internal_Static_Delegate_RuntimeType_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666876);
			Delegate.NativeMethodInfoPtr_AllocDelegateLike_internal_Internal_Static_MulticastDelegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100666877);
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x00081AAC File Offset: 0x0007FCAC
		public unsafe MethodInfo Method
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00081AEC File Offset: 0x0007FCEC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 131113, RefRangeEnd = 131119, XrefRangeStart = 131113, XrefRangeEnd = 131119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodInfo GetVirtualMethod_internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_GetVirtualMethod_internal_Private_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x00081B2C File Offset: 0x0007FD2C
		public unsafe Object Target
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_get_Target_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00081B6C File Offset: 0x0007FD6C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 174763, RefRangeEnd = 174771, XrefRangeStart = 174761, XrefRangeEnd = 174763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate_internal(Type type, Object target, MethodInfo info, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_internal_Internal_Static_Delegate_Type_Object_MethodInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00081BE4 File Offset: 0x0007FDE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 174789, RefRangeEnd = 174795, XrefRangeStart = 174771, XrefRangeEnd = 174789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool arg_type_match(Type delArgType, Type argType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delArgType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_arg_type_match_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00081C38 File Offset: 0x0007FE38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174799, RefRangeEnd = 174800, XrefRangeStart = 174795, XrefRangeEnd = 174799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delArgType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boxedThis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_arg_type_match_this_Private_Static_Boolean_Type_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00081C9C File Offset: 0x0007FE9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 174804, RefRangeEnd = 174806, XrefRangeStart = 174800, XrefRangeEnd = 174804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool return_type_match(Type delReturnType, Type returnType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delReturnType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_return_type_match_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00081CF0 File Offset: 0x0007FEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174806, XrefRangeEnd = 174807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object firstArgument, MethodInfo method, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstArgument);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_MethodInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00081D68 File Offset: 0x0007FF68
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 174843, RefRangeEnd = 174864, XrefRangeStart = 174807, XrefRangeEnd = 174843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstArgument);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowClosed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Private_Static_Delegate_Type_Object_MethodInfo_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00081DEC File Offset: 0x0007FFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174864, XrefRangeEnd = 174865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object firstArgument, MethodInfo method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstArgument);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00081E54 File Offset: 0x00080054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174865, XrefRangeEnd = 174866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00081EB8 File Offset: 0x000800B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174866, XrefRangeEnd = 174867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, MethodInfo method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00081F10 File Offset: 0x00080110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174867, XrefRangeEnd = 174871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object target, string method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x00081F78 File Offset: 0x00080178
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 174897, RefRangeEnd = 174903, XrefRangeStart = 174871, XrefRangeEnd = 174897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bflags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_GetCandidateMethod_Private_Static_MethodInfo_Type_Type_String_BindingFlags_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0008200C File Offset: 0x0008020C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174903, XrefRangeEnd = 174910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00082090 File Offset: 0x00080290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174910, XrefRangeEnd = 174917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Type target, string method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x000820F8 File Offset: 0x000802F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174917, XrefRangeEnd = 174921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0008217C File Offset: 0x0008037C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174921, XrefRangeEnd = 174925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object target, string method, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x000821F4 File Offset: 0x000803F4
		[CallerCount(0)]
		public unsafe Object DynamicInvoke([Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_DynamicInvoke_Public_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00082254 File Offset: 0x00080454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174931, RefRangeEnd = 174932, XrefRangeStart = 174925, XrefRangeEnd = 174931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDelegateData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_InitializeDelegateData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00082288 File Offset: 0x00080488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174932, XrefRangeEnd = 174959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object DynamicInvokeImpl(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_DynamicInvokeImpl_Protected_Virtual_New_Object_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x000822E4 File Offset: 0x000804E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00082330 File Offset: 0x00080530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174965, RefRangeEnd = 174966, XrefRangeStart = 174959, XrefRangeEnd = 174965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00082388 File Offset: 0x00080588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174966, XrefRangeEnd = 174969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x000823D0 File Offset: 0x000805D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174969, XrefRangeEnd = 174977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodInfo GetMethodImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_New_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0008241C File Offset: 0x0008061C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174977, XrefRangeEnd = 174978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00082480 File Offset: 0x00080680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174978, XrefRangeEnd = 174983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Delegate> GetInvocationList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_GetInvocationList_Public_Virtual_New_Il2CppReferenceArray_1_Delegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Delegate>>(intPtr3) : null;
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x000824CC File Offset: 0x000806CC
		[CallerCount(238)]
		[CachedScanResults(RefRangeStart = 174988, RefRangeEnd = 175226, XrefRangeStart = 174983, XrefRangeEnd = 174988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate Combine(Delegate a, Delegate b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_Combine_Public_Static_Delegate_Delegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00082524 File Offset: 0x00080724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175233, RefRangeEnd = 175234, XrefRangeStart = 175226, XrefRangeEnd = 175233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate Combine([Optional] Il2CppReferenceArray<Delegate> delegates)
		{
			if (delegates == null)
			{
				delegates = new Il2CppReferenceArray<Delegate>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegates);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_Combine_Public_Static_Delegate_Il2CppReferenceArray_1_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x00082578 File Offset: 0x00080778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175234, XrefRangeEnd = 175242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Delegate CombineImpl(Delegate d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_CombineImpl_Protected_Virtual_New_Delegate_Delegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x000825D4 File Offset: 0x000807D4
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 175247, RefRangeEnd = 175454, XrefRangeStart = 175242, XrefRangeEnd = 175247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate Remove(Delegate source, Delegate value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_Remove_Public_Static_Delegate_Delegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0008262C File Offset: 0x0008082C
		[CallerCount(0)]
		public unsafe virtual Delegate RemoveImpl(Delegate d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_RemoveImpl_Protected_Virtual_New_Delegate_Delegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00082688 File Offset: 0x00080888
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175455, RefRangeEnd = 175457, XrefRangeStart = 175454, XrefRangeEnd = 175455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate RemoveAll(Delegate source, Delegate value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_RemoveAll_Public_Static_Delegate_Delegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x000826E0 File Offset: 0x000808E0
		[CallerCount(0)]
		public unsafe static bool operator ==(Delegate d1, Delegate d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Delegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x00082734 File Offset: 0x00080934
		[CallerCount(0)]
		public unsafe static bool operator !=(Delegate d1, Delegate d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Delegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x00082788 File Offset: 0x00080988
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 174763, RefRangeEnd = 174771, XrefRangeStart = 174763, XrefRangeEnd = 174771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegateNoSecurityCheck(RuntimeType type, Object firstArgument, MethodInfo method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstArgument);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegateNoSecurityCheck_Internal_Static_Delegate_RuntimeType_Object_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x000827F0 File Offset: 0x000809F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175459, RefRangeEnd = 175461, XrefRangeStart = 175457, XrefRangeEnd = 175459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MulticastDelegate AllocDelegateLike_internal(Delegate d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_AllocDelegateLike_internal_Internal_Static_MulticastDelegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MulticastDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00006FFA File Offset: 0x000051FA
		public Object DynamicInvoke(params Object[] args)
		{
			return this.DynamicInvoke(new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x00007008 File Offset: 0x00005208
		public static Delegate Combine(params Delegate[] delegates)
		{
			return Delegate.Combine(new Il2CppReferenceArray<Delegate>(delegates));
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x00007015 File Offset: 0x00005215
		public Delegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x00082834 File Offset: 0x00080A34
		// (set) Token: 0x06001486 RID: 5254 RVA: 0x0000701E File Offset: 0x0000521E
		public unsafe IntPtr method_ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_ptr)) = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x0008285C File Offset: 0x00080A5C
		// (set) Token: 0x06001488 RID: 5256 RVA: 0x00007039 File Offset: 0x00005239
		public unsafe IntPtr invoke_impl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_invoke_impl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_invoke_impl)) = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x00082884 File Offset: 0x00080A84
		// (set) Token: 0x0600148A RID: 5258 RVA: 0x00007054 File Offset: 0x00005254
		public unsafe Object m_target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_m_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_m_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x000828B4 File Offset: 0x00080AB4
		// (set) Token: 0x0600148C RID: 5260 RVA: 0x00007073 File Offset: 0x00005273
		public unsafe IntPtr method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method)) = value;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x000828DC File Offset: 0x00080ADC
		// (set) Token: 0x0600148E RID: 5262 RVA: 0x0000708E File Offset: 0x0000528E
		public unsafe IntPtr delegate_trampoline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_delegate_trampoline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_delegate_trampoline)) = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x00082904 File Offset: 0x00080B04
		// (set) Token: 0x06001490 RID: 5264 RVA: 0x000070A9 File Offset: 0x000052A9
		public unsafe IntPtr extra_arg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_extra_arg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_extra_arg)) = value;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x0008292C File Offset: 0x00080B2C
		// (set) Token: 0x06001492 RID: 5266 RVA: 0x000070C4 File Offset: 0x000052C4
		public unsafe IntPtr method_code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_code);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_code)) = value;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x00082954 File Offset: 0x00080B54
		// (set) Token: 0x06001494 RID: 5268 RVA: 0x000070DF File Offset: 0x000052DF
		public unsafe MethodInfo method_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x00082984 File Offset: 0x00080B84
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x000070FE File Offset: 0x000052FE
		public unsafe MethodInfo original_method_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_original_method_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_original_method_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x000829B4 File Offset: 0x00080BB4
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x0000711D File Offset: 0x0000531D
		public unsafe DelegateData data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x000829E4 File Offset: 0x00080BE4
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x0000713C File Offset: 0x0000533C
		public unsafe bool method_is_virtual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_is_virtual);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_is_virtual)) = value;
			}
		}

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeFieldInfoPtr_method_ptr;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeFieldInfoPtr_invoke_impl;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeFieldInfoPtr_m_target;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeFieldInfoPtr_delegate_trampoline;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeFieldInfoPtr_extra_arg;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeFieldInfoPtr_method_code;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeFieldInfoPtr_method_info;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeFieldInfoPtr_original_method_info;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeFieldInfoPtr_method_is_virtual;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeMethodInfoPtr_GetVirtualMethod_internal_Private_MethodInfo_0;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Object_0;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_internal_Internal_Static_Delegate_Type_Object_MethodInfo_Boolean_0;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr_arg_type_match_Private_Static_Boolean_Type_Type_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr_arg_type_match_this_Private_Static_Boolean_Type_Type_Boolean_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_return_type_match_Private_Static_Boolean_Type_Type_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_MethodInfo_Boolean_0;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Private_Static_Delegate_Type_Object_MethodInfo_Boolean_Boolean_0;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_MethodInfo_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_Boolean_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_0;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_GetCandidateMethod_Private_Static_MethodInfo_Type_Type_String_BindingFlags_Boolean_Boolean_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_Boolean_Boolean_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_Boolean_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_DynamicInvoke_Public_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDelegateData_Private_Void_0;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeMethodInfoPtr_DynamicInvokeImpl_Protected_Virtual_New_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_New_MethodInfo_0;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeMethodInfoPtr_GetInvocationList_Public_Virtual_New_Il2CppReferenceArray_1_Delegate_0;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Delegate_Delegate_Delegate_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Delegate_Il2CppReferenceArray_1_Delegate_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_CombineImpl_Protected_Virtual_New_Delegate_Delegate_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Static_Delegate_Delegate_Delegate_0;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeMethodInfoPtr_RemoveImpl_Protected_Virtual_New_Delegate_Delegate_0;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAll_Public_Static_Delegate_Delegate_Delegate_0;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Delegate_Delegate_0;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Delegate_Delegate_0;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegateNoSecurityCheck_Internal_Static_Delegate_RuntimeType_Object_MethodInfo_0;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeMethodInfoPtr_AllocDelegateLike_internal_Internal_Static_MulticastDelegate_Delegate_0;
	}
}
