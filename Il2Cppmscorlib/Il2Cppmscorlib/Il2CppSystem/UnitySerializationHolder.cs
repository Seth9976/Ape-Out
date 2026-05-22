using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000102 RID: 258
	[Serializable]
	public class UnitySerializationHolder : Object
	{
		// Token: 0x060012F3 RID: 4851 RVA: 0x0007C72C File Offset: 0x0007A92C
		// Note: this type is marked as 'beforefieldinit'.
		static UnitySerializationHolder()
		{
			Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "UnitySerializationHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr);
			UnitySerializationHolder.NativeFieldInfoPtr_m_instantiation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_instantiation");
			UnitySerializationHolder.NativeFieldInfoPtr_m_elementTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_elementTypes");
			UnitySerializationHolder.NativeFieldInfoPtr_m_genericParameterPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_genericParameterPosition");
			UnitySerializationHolder.NativeFieldInfoPtr_m_declaringType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_declaringType");
			UnitySerializationHolder.NativeFieldInfoPtr_m_declaringMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_declaringMethod");
			UnitySerializationHolder.NativeFieldInfoPtr_m_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_data");
			UnitySerializationHolder.NativeFieldInfoPtr_m_assemblyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_assemblyName");
			UnitySerializationHolder.NativeFieldInfoPtr_m_unityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_unityType");
			UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Missing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666659);
			UnitySerializationHolder.NativeMethodInfoPtr_AddElementTypes_Internal_Static_RuntimeType_SerializationInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666660);
			UnitySerializationHolder.NativeMethodInfoPtr_MakeElementTypes_Internal_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666661);
			UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666662);
			UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Int32_String_RuntimeAssembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666663);
			UnitySerializationHolder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666664);
			UnitySerializationHolder.NativeMethodInfoPtr_ThrowInsufficientInformation_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666665);
			UnitySerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666666);
			UnitySerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666667);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0007C8B0 File Offset: 0x0007AAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173160, XrefRangeEnd = 173171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetUnitySerializationInfo(SerializationInfo info, Missing missing)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(missing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Missing_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0007C8F8 File Offset: 0x0007AAF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173206, RefRangeEnd = 173207, XrefRangeStart = 173171, XrefRangeEnd = 173206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_AddElementTypes_Internal_Static_RuntimeType_SerializationInfo_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0007C950 File Offset: 0x0007AB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173207, XrefRangeEnd = 173210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type MakeElementTypes(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_MakeElementTypes_Internal_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0007C9A0 File Offset: 0x0007ABA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173233, RefRangeEnd = 173234, XrefRangeStart = 173210, XrefRangeEnd = 173233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0007C9E8 File Offset: 0x0007ABE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 173259, RefRangeEnd = 173264, XrefRangeStart = 173234, XrefRangeEnd = 173259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Int32_String_RuntimeAssembly_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0007CA50 File Offset: 0x0007AC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173264, XrefRangeEnd = 173301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitySerializationHolder(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0007CAB4 File Offset: 0x0007ACB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173301, XrefRangeEnd = 173313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowInsufficientInformation(string field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(field);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_ThrowInsufficientInformation_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x0007CAF8 File Offset: 0x0007ACF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173313, XrefRangeEnd = 173320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitySerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0007CB5C File Offset: 0x0007AD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173320, XrefRangeEnd = 173333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitySerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00006658 File Offset: 0x00004858
		public UnitySerializationHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x0007CBBC File Offset: 0x0007ADBC
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x00006661 File Offset: 0x00004861
		public unsafe Il2CppReferenceArray<Type> m_instantiation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_instantiation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_instantiation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x0007CBEC File Offset: 0x0007ADEC
		// (set) Token: 0x06001301 RID: 4865 RVA: 0x00006680 File Offset: 0x00004880
		public unsafe Il2CppStructArray<int> m_elementTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_elementTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_elementTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x0007CC1C File Offset: 0x0007AE1C
		// (set) Token: 0x06001303 RID: 4867 RVA: 0x0000669F File Offset: 0x0000489F
		public unsafe int m_genericParameterPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_genericParameterPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_genericParameterPosition)) = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x0007CC44 File Offset: 0x0007AE44
		// (set) Token: 0x06001305 RID: 4869 RVA: 0x000066BA File Offset: 0x000048BA
		public unsafe Type m_declaringType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_declaringType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_declaringType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x0007CC74 File Offset: 0x0007AE74
		// (set) Token: 0x06001307 RID: 4871 RVA: 0x000066D9 File Offset: 0x000048D9
		public unsafe MethodBase m_declaringMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_declaringMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_declaringMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x0007CCA4 File Offset: 0x0007AEA4
		// (set) Token: 0x06001309 RID: 4873 RVA: 0x000066F8 File Offset: 0x000048F8
		public unsafe string m_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_data);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_data), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x0007CCCC File Offset: 0x0007AECC
		// (set) Token: 0x0600130B RID: 4875 RVA: 0x00006717 File Offset: 0x00004917
		public unsafe string m_assemblyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_assemblyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_assemblyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x0007CCF4 File Offset: 0x0007AEF4
		// (set) Token: 0x0600130D RID: 4877 RVA: 0x00006736 File Offset: 0x00004936
		public unsafe int m_unityType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_unityType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_unityType)) = value;
			}
		}

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeFieldInfoPtr_m_instantiation;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeFieldInfoPtr_m_elementTypes;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeFieldInfoPtr_m_genericParameterPosition;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeFieldInfoPtr_m_declaringType;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeFieldInfoPtr_m_declaringMethod;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeFieldInfoPtr_m_data;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeFieldInfoPtr_m_assemblyName;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeFieldInfoPtr_m_unityType;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Missing_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr_AddElementTypes_Internal_Static_RuntimeType_SerializationInfo_RuntimeType_0;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeMethodInfoPtr_MakeElementTypes_Internal_Type_Type_0;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_RuntimeType_0;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Int32_String_RuntimeAssembly_0;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInsufficientInformation_Private_Void_String_0;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0;
	}
}
