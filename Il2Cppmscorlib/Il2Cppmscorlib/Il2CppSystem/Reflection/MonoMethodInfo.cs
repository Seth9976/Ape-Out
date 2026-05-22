using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001D7 RID: 471
	public sealed class MonoMethodInfo : ValueType
	{
		// Token: 0x06001E7D RID: 7805 RVA: 0x000AD0C4 File Offset: 0x000AB2C4
		// Note: this type is marked as 'beforefieldinit'.
		static MonoMethodInfo()
		{
			Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MonoMethodInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr);
			MonoMethodInfo.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "parent");
			MonoMethodInfo.NativeFieldInfoPtr_ret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "ret");
			MonoMethodInfo.NativeFieldInfoPtr_attrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "attrs");
			MonoMethodInfo.NativeFieldInfoPtr_iattrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "iattrs");
			MonoMethodInfo.NativeFieldInfoPtr_callconv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "callconv");
			MonoMethodInfo.NativeMethodInfoPtr_get_method_info_Private_Static_Void_IntPtr_byref_MonoMethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668407);
			MonoMethodInfo.NativeMethodInfoPtr_get_method_attributes_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668408);
			MonoMethodInfo.NativeMethodInfoPtr_GetMethodInfo_Internal_Static_MonoMethodInfo_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668409);
			MonoMethodInfo.NativeMethodInfoPtr_GetDeclaringType_Internal_Static_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668410);
			MonoMethodInfo.NativeMethodInfoPtr_GetReturnType_Internal_Static_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668411);
			MonoMethodInfo.NativeMethodInfoPtr_GetAttributes_Internal_Static_MethodAttributes_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668412);
			MonoMethodInfo.NativeMethodInfoPtr_GetCallingConvention_Internal_Static_CallingConventions_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668413);
			MonoMethodInfo.NativeMethodInfoPtr_GetMethodImplementationFlags_Internal_Static_MethodImplAttributes_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668414);
			MonoMethodInfo.NativeMethodInfoPtr_get_parameter_info_Private_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668415);
			MonoMethodInfo.NativeMethodInfoPtr_GetParametersInfo_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668416);
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x000AD220 File Offset: 0x000AB420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188195, XrefRangeEnd = 188197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_method_info(IntPtr handle, out MonoMethodInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_get_method_info_Private_Static_Void_IntPtr_byref_MonoMethodInfo_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			info = ((intPtr4 == 0) ? null : new MonoMethodInfo(intPtr4));
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x000AD274 File Offset: 0x000AB474
		[CallerCount(0)]
		public unsafe static int get_method_attributes(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_get_method_attributes_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x000AD2B4 File Offset: 0x000AB4B4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 188199, RefRangeEnd = 188212, XrefRangeStart = 188197, XrefRangeEnd = 188199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoMethodInfo GetMethodInfo(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetMethodInfo_Internal_Static_MonoMethodInfo_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new MonoMethodInfo(intPtr);
			}
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x000AD2EC File Offset: 0x000AB4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188212, XrefRangeEnd = 188213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetDeclaringType(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetDeclaringType_Internal_Static_Type_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x000AD32C File Offset: 0x000AB52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188213, XrefRangeEnd = 188214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetReturnType(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetReturnType_Internal_Static_Type_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x000AD36C File Offset: 0x000AB56C
		[CallerCount(0)]
		public unsafe static MethodAttributes GetAttributes(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetAttributes_Internal_Static_MethodAttributes_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x000AD3AC File Offset: 0x000AB5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188214, XrefRangeEnd = 188215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CallingConventions GetCallingConvention(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetCallingConvention_Internal_Static_CallingConventions_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x000AD3EC File Offset: 0x000AB5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188215, XrefRangeEnd = 188216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetMethodImplementationFlags_Internal_Static_MethodImplAttributes_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x000AD42C File Offset: 0x000AB62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188216, XrefRangeEnd = 188219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ParameterInfo> get_parameter_info(IntPtr handle, MemberInfo member)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_get_parameter_info_Private_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x000AD480 File Offset: 0x000AB680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ParameterInfo> GetParametersInfo(IntPtr handle, MemberInfo member)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetParametersInfo_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x0000A5D2 File Offset: 0x000087D2
		public MonoMethodInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x0000A5DB File Offset: 0x000087DB
		public MonoMethodInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr))
		{
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x000AD4D4 File Offset: 0x000AB6D4
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x0000A5ED File Offset: 0x000087ED
		public unsafe Type parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x000AD504 File Offset: 0x000AB704
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x0000A60C File Offset: 0x0000880C
		public unsafe Type ret
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_ret);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_ret), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x000AD534 File Offset: 0x000AB734
		// (set) Token: 0x06001E8F RID: 7823 RVA: 0x0000A62B File Offset: 0x0000882B
		public unsafe MethodAttributes attrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_attrs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_attrs)) = value;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x000AD55C File Offset: 0x000AB75C
		// (set) Token: 0x06001E91 RID: 7825 RVA: 0x0000A646 File Offset: 0x00008846
		public unsafe MethodImplAttributes iattrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_iattrs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_iattrs)) = value;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x000AD584 File Offset: 0x000AB784
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x0000A661 File Offset: 0x00008861
		public unsafe CallingConventions callconv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_callconv);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_callconv)) = value;
			}
		}

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeFieldInfoPtr_ret;

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeFieldInfoPtr_attrs;

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeFieldInfoPtr_iattrs;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeFieldInfoPtr_callconv;

		// Token: 0x04001BDD RID: 7133
		private static readonly IntPtr NativeMethodInfoPtr_get_method_info_Private_Static_Void_IntPtr_byref_MonoMethodInfo_0;

		// Token: 0x04001BDE RID: 7134
		private static readonly IntPtr NativeMethodInfoPtr_get_method_attributes_Private_Static_Int32_IntPtr_0;

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodInfo_Internal_Static_MonoMethodInfo_IntPtr_0;

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeMethodInfoPtr_GetDeclaringType_Internal_Static_Type_IntPtr_0;

		// Token: 0x04001BE1 RID: 7137
		private static readonly IntPtr NativeMethodInfoPtr_GetReturnType_Internal_Static_Type_IntPtr_0;

		// Token: 0x04001BE2 RID: 7138
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Internal_Static_MethodAttributes_IntPtr_0;

		// Token: 0x04001BE3 RID: 7139
		private static readonly IntPtr NativeMethodInfoPtr_GetCallingConvention_Internal_Static_CallingConventions_IntPtr_0;

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImplementationFlags_Internal_Static_MethodImplAttributes_IntPtr_0;

		// Token: 0x04001BE5 RID: 7141
		private static readonly IntPtr NativeMethodInfoPtr_get_parameter_info_Private_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0;

		// Token: 0x04001BE6 RID: 7142
		private static readonly IntPtr NativeMethodInfoPtr_GetParametersInfo_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0;
	}
}
