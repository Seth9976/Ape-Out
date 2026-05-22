using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001C5 RID: 453
	[Serializable]
	public class CustomAttributeData : Object
	{
		// Token: 0x06001D58 RID: 7512 RVA: 0x000A8694 File Offset: 0x000A6894
		// Note: this type is marked as 'beforefieldinit'.
		static CustomAttributeData()
		{
			Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "CustomAttributeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr);
			CustomAttributeData.NativeFieldInfoPtr_ctorInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, "ctorInfo");
			CustomAttributeData.NativeFieldInfoPtr_ctorArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, "ctorArgs");
			CustomAttributeData.NativeFieldInfoPtr_namedArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, "namedArgs");
			CustomAttributeData.NativeFieldInfoPtr_lazyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, "lazyData");
			CustomAttributeData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668247);
			CustomAttributeData.NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_Assembly_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668248);
			CustomAttributeData.NativeMethodInfoPtr_ResolveArgumentsInternal_Private_Static_Void_ConstructorInfo_Assembly_IntPtr_UInt32_byref_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668249);
			CustomAttributeData.NativeMethodInfoPtr_ResolveArguments_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668250);
			CustomAttributeData.NativeMethodInfoPtr_get_Constructor_Public_Virtual_New_get_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668251);
			CustomAttributeData.NativeMethodInfoPtr_get_ConstructorArguments_Public_Virtual_New_get_IList_1_CustomAttributeTypedArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668252);
			CustomAttributeData.NativeMethodInfoPtr_get_NamedArguments_Public_Virtual_New_get_IList_1_CustomAttributeNamedArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668253);
			CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668254);
			CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668255);
			CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_IList_1_CustomAttributeData_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668256);
			CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668257);
			CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668258);
			CustomAttributeData.NativeMethodInfoPtr_get_AttributeType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668259);
			CustomAttributeData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668260);
			CustomAttributeData.NativeMethodInfoPtr_UnboxValues_Private_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668261);
			CustomAttributeData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668262);
			CustomAttributeData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668263);
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x000A8868 File Offset: 0x000A6A68
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x000A88A4 File Offset: 0x000A6AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187504, XrefRangeEnd = 187507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeData(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data_length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_Assembly_IntPtr_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x000A8920 File Offset: 0x000A6B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187507, XrefRangeEnd = 187508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out Il2CppReferenceArray<Object> ctorArgs, out Il2CppReferenceArray<Object> namedArgs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data_length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_ResolveArgumentsInternal_Private_Static_Void_ConstructorInfo_Assembly_IntPtr_UInt32_byref_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			ctorArgs = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			namedArgs = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr6));
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x000A89CC File Offset: 0x000A6BCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 187514, RefRangeEnd = 187517, XrefRangeStart = 187508, XrefRangeEnd = 187514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResolveArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_ResolveArguments_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x000A8A00 File Offset: 0x000A6C00
		public unsafe virtual ConstructorInfo Constructor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_get_Constructor_Public_Virtual_New_get_ConstructorInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x000A8A4C File Offset: 0x000A6C4C
		public unsafe virtual IList<CustomAttributeTypedArgument> ConstructorArguments
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187517, XrefRangeEnd = 187518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_get_ConstructorArguments_Public_Virtual_New_get_IList_1_CustomAttributeTypedArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeTypedArgument>>(intPtr3) : null;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001D5F RID: 7519 RVA: 0x000A8A98 File Offset: 0x000A6C98
		public unsafe virtual IList<CustomAttributeNamedArgument> NamedArguments
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187518, XrefRangeEnd = 187519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_get_NamedArguments_Public_Virtual_New_get_IList_1_CustomAttributeNamedArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeNamedArgument>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x000A8AE4 File Offset: 0x000A6CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187519, XrefRangeEnd = 187523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributes(Assembly target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x000A8B28 File Offset: 0x000A6D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187523, XrefRangeEnd = 187527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x000A8B6C File Offset: 0x000A6D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_IList_1_CustomAttributeData_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x000A8BB0 File Offset: 0x000A6DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187527, XrefRangeEnd = 187531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributes(Module target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Module_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x000A8BF4 File Offset: 0x000A6DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187531, XrefRangeEnd = 187535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_ParameterInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x000A8C38 File Offset: 0x000A6E38
		public unsafe Type AttributeType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187535, XrefRangeEnd = 187536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_get_AttributeType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x000A8C78 File Offset: 0x000A6E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187536, XrefRangeEnd = 187604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x000A8CBC File Offset: 0x000A6EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187604, XrefRangeEnd = 187608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> UnboxValues<T>(Il2CppReferenceArray<Object> values)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.MethodInfoStoreGeneric_UnboxValues_Private_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x000A8CF8 File Offset: 0x000A6EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187608, XrefRangeEnd = 187653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x000A8D50 File Offset: 0x000A6F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187653, XrefRangeEnd = 187677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00009F58 File Offset: 0x00008158
		public CustomAttributeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x000A8D98 File Offset: 0x000A6F98
		// (set) Token: 0x06001D6C RID: 7532 RVA: 0x00009F61 File Offset: 0x00008161
		public unsafe ConstructorInfo ctorInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_ctorInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_ctorInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x000A8DC8 File Offset: 0x000A6FC8
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x00009F80 File Offset: 0x00008180
		public unsafe IList<CustomAttributeTypedArgument> ctorArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_ctorArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeTypedArgument>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_ctorArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x000A8DF8 File Offset: 0x000A6FF8
		// (set) Token: 0x06001D70 RID: 7536 RVA: 0x00009F9F File Offset: 0x0000819F
		public unsafe IList<CustomAttributeNamedArgument> namedArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_namedArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeNamedArgument>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_namedArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x000A8E28 File Offset: 0x000A7028
		// (set) Token: 0x06001D72 RID: 7538 RVA: 0x00009FBE File Offset: 0x000081BE
		public unsafe CustomAttributeData.LazyCAttrData lazyData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_lazyData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomAttributeData.LazyCAttrData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_lazyData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B0C RID: 6924
		private static readonly IntPtr NativeFieldInfoPtr_ctorInfo;

		// Token: 0x04001B0D RID: 6925
		private static readonly IntPtr NativeFieldInfoPtr_ctorArgs;

		// Token: 0x04001B0E RID: 6926
		private static readonly IntPtr NativeFieldInfoPtr_namedArgs;

		// Token: 0x04001B0F RID: 6927
		private static readonly IntPtr NativeFieldInfoPtr_lazyData;

		// Token: 0x04001B10 RID: 6928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001B11 RID: 6929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_Assembly_IntPtr_UInt32_0;

		// Token: 0x04001B12 RID: 6930
		private static readonly IntPtr NativeMethodInfoPtr_ResolveArgumentsInternal_Private_Static_Void_ConstructorInfo_Assembly_IntPtr_UInt32_byref_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001B13 RID: 6931
		private static readonly IntPtr NativeMethodInfoPtr_ResolveArguments_Private_Void_0;

		// Token: 0x04001B14 RID: 6932
		private static readonly IntPtr NativeMethodInfoPtr_get_Constructor_Public_Virtual_New_get_ConstructorInfo_0;

		// Token: 0x04001B15 RID: 6933
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructorArguments_Public_Virtual_New_get_IList_1_CustomAttributeTypedArgument_0;

		// Token: 0x04001B16 RID: 6934
		private static readonly IntPtr NativeMethodInfoPtr_get_NamedArguments_Public_Virtual_New_get_IList_1_CustomAttributeNamedArgument_0;

		// Token: 0x04001B17 RID: 6935
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Assembly_0;

		// Token: 0x04001B18 RID: 6936
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_MemberInfo_0;

		// Token: 0x04001B19 RID: 6937
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_IList_1_CustomAttributeData_RuntimeType_0;

		// Token: 0x04001B1A RID: 6938
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Module_0;

		// Token: 0x04001B1B RID: 6939
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_ParameterInfo_0;

		// Token: 0x04001B1C RID: 6940
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeType_Public_get_Type_0;

		// Token: 0x04001B1D RID: 6941
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001B1E RID: 6942
		private static readonly IntPtr NativeMethodInfoPtr_UnboxValues_Private_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001B1F RID: 6943
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001B20 RID: 6944
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x020005C8 RID: 1480
		public class LazyCAttrData : Object
		{
			// Token: 0x060052A9 RID: 21161 RVA: 0x00175418 File Offset: 0x00173618
			// Note: this type is marked as 'beforefieldinit'.
			static LazyCAttrData()
			{
				Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, "LazyCAttrData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr);
				CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr, "assembly");
				CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr, "data");
				CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr, "data_length");
				CustomAttributeData.LazyCAttrData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr, 100668264);
			}

			// Token: 0x060052AA RID: 21162 RVA: 0x00175494 File Offset: 0x00173694
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LazyCAttrData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.LazyCAttrData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052AB RID: 21163 RVA: 0x0001F18C File Offset: 0x0001D38C
			public LazyCAttrData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700153C RID: 5436
			// (get) Token: 0x060052AC RID: 21164 RVA: 0x001754D0 File Offset: 0x001736D0
			// (set) Token: 0x060052AD RID: 21165 RVA: 0x0001F195 File Offset: 0x0001D395
			public unsafe Assembly assembly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_assembly);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_assembly), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700153D RID: 5437
			// (get) Token: 0x060052AE RID: 21166 RVA: 0x00175500 File Offset: 0x00173700
			// (set) Token: 0x060052AF RID: 21167 RVA: 0x0001F1B4 File Offset: 0x0001D3B4
			public unsafe IntPtr data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data)) = value;
				}
			}

			// Token: 0x1700153E RID: 5438
			// (get) Token: 0x060052B0 RID: 21168 RVA: 0x00175528 File Offset: 0x00173728
			// (set) Token: 0x060052B1 RID: 21169 RVA: 0x0001F1CF File Offset: 0x0001D3CF
			public unsafe uint data_length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data_length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data_length)) = value;
				}
			}

			// Token: 0x04004312 RID: 17170
			private static readonly IntPtr NativeFieldInfoPtr_assembly;

			// Token: 0x04004313 RID: 17171
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04004314 RID: 17172
			private static readonly IntPtr NativeFieldInfoPtr_data_length;

			// Token: 0x04004315 RID: 17173
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020005C9 RID: 1481
		private sealed class MethodInfoStoreGeneric_UnboxValues_Private_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0<T>
		{
			// Token: 0x04004316 RID: 17174
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomAttributeData.NativeMethodInfoPtr_UnboxValues_Private_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
