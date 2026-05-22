using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200032A RID: 810
	public static class FormatterServices : Object
	{
		// Token: 0x06003555 RID: 13653 RVA: 0x00106DC4 File Offset: 0x00104FC4
		// Note: this type is marked as 'beforefieldinit'.
		static FormatterServices()
		{
			Il2CppClassPointerStore<FormatterServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "FormatterServices");
			FormatterServices.NativeFieldInfoPtr_m_MemberInfoTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "m_MemberInfoTable");
			FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "unsafeTypeForwardersIsEnabled");
			FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabledInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "unsafeTypeForwardersIsEnabledInitialized");
			FormatterServices.NativeFieldInfoPtr_advancedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "advancedTypes");
			FormatterServices.NativeFieldInfoPtr_s_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "s_binder");
			FormatterServices.NativeMethodInfoPtr_GetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671618);
			FormatterServices.NativeMethodInfoPtr_CheckSerializable_Private_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671619);
			FormatterServices.NativeMethodInfoPtr_InternalGetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671620);
			FormatterServices.NativeMethodInfoPtr_GetParentTypes_Private_Static_Boolean_RuntimeType_byref_Il2CppReferenceArray_1_RuntimeType_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671621);
			FormatterServices.NativeMethodInfoPtr_GetSerializableMembers_Public_Static_Il2CppReferenceArray_1_MemberInfo_Type_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671622);
			FormatterServices.NativeMethodInfoPtr_GetUninitializedObject_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671623);
			FormatterServices.NativeMethodInfoPtr_nativeGetUninitializedObject_Private_Static_Object_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671624);
			FormatterServices.NativeMethodInfoPtr_GetEnableUnsafeTypeForwarders_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671625);
			FormatterServices.NativeMethodInfoPtr_UnsafeTypeForwardersIsEnabled_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671626);
			FormatterServices.NativeMethodInfoPtr_SerializationSetValue_Internal_Static_Void_MemberInfo_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671627);
			FormatterServices.NativeMethodInfoPtr_PopulateObjectMembers_Public_Static_Object_Object_Il2CppReferenceArray_1_MemberInfo_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671628);
			FormatterServices.NativeMethodInfoPtr_GetObjectData_Public_Static_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671629);
			FormatterServices.NativeMethodInfoPtr_GetTypeFromAssembly_Public_Static_Type_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671630);
			FormatterServices.NativeMethodInfoPtr_LoadAssemblyFromString_Internal_Static_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671631);
			FormatterServices.NativeMethodInfoPtr_LoadAssemblyFromStringNoThrow_Internal_Static_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671632);
			FormatterServices.NativeMethodInfoPtr_GetClrAssemblyName_Internal_Static_String_Type_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671633);
			FormatterServices.NativeMethodInfoPtr_GetClrTypeFullName_Internal_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671634);
			FormatterServices.NativeMethodInfoPtr_GetClrTypeFullNameForArray_Private_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671635);
			FormatterServices.NativeMethodInfoPtr_GetClrTypeFullNameForNonArrayTypes_Private_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671636);
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x00106FCC File Offset: 0x001051CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213342, RefRangeEnd = 213343, XrefRangeStart = 213340, XrefRangeEnd = 213342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<MemberInfo> GetSerializableMembers(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x00107010 File Offset: 0x00105210
		[CallerCount(0)]
		public unsafe static bool CheckSerializable(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_CheckSerializable_Private_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x00107054 File Offset: 0x00105254
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213418, RefRangeEnd = 213420, XrefRangeStart = 213343, XrefRangeEnd = 213418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<MemberInfo> InternalGetSerializableMembers(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_InternalGetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x00107098 File Offset: 0x00105298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213420, XrefRangeEnd = 213445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetParentTypes(RuntimeType parentType, out Il2CppReferenceArray<RuntimeType> parentTypes, out int parentTypeCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parentTypeCount;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetParentTypes_Private_Static_Boolean_RuntimeType_byref_Il2CppReferenceArray_1_RuntimeType_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parentTypes = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<RuntimeType>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x0010710C File Offset: 0x0010530C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213489, RefRangeEnd = 213491, XrefRangeStart = 213445, XrefRangeEnd = 213489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<MemberInfo> GetSerializableMembers(Type type, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetSerializableMembers_Public_Static_Il2CppReferenceArray_1_MemberInfo_Type_StreamingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x00107168 File Offset: 0x00105368
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 213498, RefRangeEnd = 213501, XrefRangeStart = 213491, XrefRangeEnd = 213498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetUninitializedObject(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetUninitializedObject_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x001071AC File Offset: 0x001053AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213502, RefRangeEnd = 213503, XrefRangeStart = 213501, XrefRangeEnd = 213502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object nativeGetUninitializedObject(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_nativeGetUninitializedObject_Private_Static_Object_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x001071F0 File Offset: 0x001053F0
		[CallerCount(0)]
		public unsafe static bool GetEnableUnsafeTypeForwarders()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetEnableUnsafeTypeForwarders_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x00107220 File Offset: 0x00105420
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 213514, RefRangeEnd = 213519, XrefRangeStart = 213503, XrefRangeEnd = 213514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UnsafeTypeForwardersIsEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_UnsafeTypeForwardersIsEnabled_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x00107250 File Offset: 0x00105450
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 213536, RefRangeEnd = 213539, XrefRangeStart = 213519, XrefRangeEnd = 213536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SerializationSetValue(MemberInfo fi, Object target, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_SerializationSetValue_Internal_Static_Void_MemberInfo_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x001072AC File Offset: 0x001054AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213551, RefRangeEnd = 213552, XrefRangeStart = 213539, XrefRangeEnd = 213551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object PopulateObjectMembers(Object obj, Il2CppReferenceArray<MemberInfo> members, Il2CppReferenceArray<Object> data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(members);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_PopulateObjectMembers_Public_Static_Object_Object_Il2CppReferenceArray_1_MemberInfo_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x00107314 File Offset: 0x00105514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213572, RefRangeEnd = 213573, XrefRangeStart = 213552, XrefRangeEnd = 213572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetObjectData(Object obj, Il2CppReferenceArray<MemberInfo> members)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(members);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetObjectData_Public_Static_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x0010736C File Offset: 0x0010556C
		[CallerCount(0)]
		public unsafe static Type GetTypeFromAssembly(Assembly assem, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetTypeFromAssembly_Public_Static_Type_Assembly_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x001073C4 File Offset: 0x001055C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213573, XrefRangeEnd = 213574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly LoadAssemblyFromString(string assemblyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_LoadAssemblyFromString_Internal_Static_Assembly_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x00107408 File Offset: 0x00105608
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213578, RefRangeEnd = 213580, XrefRangeStart = 213574, XrefRangeEnd = 213578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly LoadAssemblyFromStringNoThrow(string assemblyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_LoadAssemblyFromStringNoThrow_Internal_Static_Assembly_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x0010744C File Offset: 0x0010564C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213588, RefRangeEnd = 213590, XrefRangeStart = 213580, XrefRangeEnd = 213588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasTypeForwardedFrom;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetClrAssemblyName_Internal_Static_String_Type_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x00107498 File Offset: 0x00105698
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 213597, RefRangeEnd = 213601, XrefRangeStart = 213590, XrefRangeEnd = 213597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrTypeFullName(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetClrTypeFullName_Internal_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x001074D4 File Offset: 0x001056D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213632, RefRangeEnd = 213633, XrefRangeStart = 213601, XrefRangeEnd = 213632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrTypeFullNameForArray(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetClrTypeFullNameForArray_Private_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x00107510 File Offset: 0x00105710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213661, RefRangeEnd = 213662, XrefRangeStart = 213633, XrefRangeEnd = 213661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrTypeFullNameForNonArrayTypes(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetClrTypeFullNameForNonArrayTypes_Private_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x00012D0E File Offset: 0x00010F0E
		public FormatterServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x0600356A RID: 13674 RVA: 0x0010754C File Offset: 0x0010574C
		// (set) Token: 0x0600356B RID: 13675 RVA: 0x00012D17 File Offset: 0x00010F17
		public unsafe static ConcurrentDictionary<MemberHolder, Il2CppReferenceArray<MemberInfo>> m_MemberInfoTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormatterServices.NativeFieldInfoPtr_m_MemberInfoTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<MemberHolder, Il2CppReferenceArray<MemberInfo>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatterServices.NativeFieldInfoPtr_m_MemberInfoTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x0600356C RID: 13676 RVA: 0x00107574 File Offset: 0x00105774
		// (set) Token: 0x0600356D RID: 13677 RVA: 0x00012D29 File Offset: 0x00010F29
		public unsafe static bool unsafeTypeForwardersIsEnabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabled, (void*)(&value));
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x0600356E RID: 13678 RVA: 0x00107590 File Offset: 0x00105790
		// (set) Token: 0x0600356F RID: 13679 RVA: 0x00012D37 File Offset: 0x00010F37
		public unsafe static bool unsafeTypeForwardersIsEnabledInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabledInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabledInitialized, (void*)(&value));
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06003570 RID: 13680 RVA: 0x001075AC File Offset: 0x001057AC
		// (set) Token: 0x06003571 RID: 13681 RVA: 0x00012D45 File Offset: 0x00010F45
		public unsafe static Il2CppReferenceArray<Type> advancedTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormatterServices.NativeFieldInfoPtr_advancedTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatterServices.NativeFieldInfoPtr_advancedTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06003572 RID: 13682 RVA: 0x001075D4 File Offset: 0x001057D4
		// (set) Token: 0x06003573 RID: 13683 RVA: 0x00012D57 File Offset: 0x00010F57
		public unsafe static Binder s_binder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormatterServices.NativeFieldInfoPtr_s_binder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Binder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatterServices.NativeFieldInfoPtr_s_binder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D32 RID: 11570
		private static readonly IntPtr NativeFieldInfoPtr_m_MemberInfoTable;

		// Token: 0x04002D33 RID: 11571
		private static readonly IntPtr NativeFieldInfoPtr_unsafeTypeForwardersIsEnabled;

		// Token: 0x04002D34 RID: 11572
		private static readonly IntPtr NativeFieldInfoPtr_unsafeTypeForwardersIsEnabledInitialized;

		// Token: 0x04002D35 RID: 11573
		private static readonly IntPtr NativeFieldInfoPtr_advancedTypes;

		// Token: 0x04002D36 RID: 11574
		private static readonly IntPtr NativeFieldInfoPtr_s_binder;

		// Token: 0x04002D37 RID: 11575
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0;

		// Token: 0x04002D38 RID: 11576
		private static readonly IntPtr NativeMethodInfoPtr_CheckSerializable_Private_Static_Boolean_RuntimeType_0;

		// Token: 0x04002D39 RID: 11577
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0;

		// Token: 0x04002D3A RID: 11578
		private static readonly IntPtr NativeMethodInfoPtr_GetParentTypes_Private_Static_Boolean_RuntimeType_byref_Il2CppReferenceArray_1_RuntimeType_byref_Int32_0;

		// Token: 0x04002D3B RID: 11579
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializableMembers_Public_Static_Il2CppReferenceArray_1_MemberInfo_Type_StreamingContext_0;

		// Token: 0x04002D3C RID: 11580
		private static readonly IntPtr NativeMethodInfoPtr_GetUninitializedObject_Public_Static_Object_Type_0;

		// Token: 0x04002D3D RID: 11581
		private static readonly IntPtr NativeMethodInfoPtr_nativeGetUninitializedObject_Private_Static_Object_RuntimeType_0;

		// Token: 0x04002D3E RID: 11582
		private static readonly IntPtr NativeMethodInfoPtr_GetEnableUnsafeTypeForwarders_Private_Static_Boolean_0;

		// Token: 0x04002D3F RID: 11583
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeTypeForwardersIsEnabled_Internal_Static_Boolean_0;

		// Token: 0x04002D40 RID: 11584
		private static readonly IntPtr NativeMethodInfoPtr_SerializationSetValue_Internal_Static_Void_MemberInfo_Object_Object_0;

		// Token: 0x04002D41 RID: 11585
		private static readonly IntPtr NativeMethodInfoPtr_PopulateObjectMembers_Public_Static_Object_Object_Il2CppReferenceArray_1_MemberInfo_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002D42 RID: 11586
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Static_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_MemberInfo_0;

		// Token: 0x04002D43 RID: 11587
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeFromAssembly_Public_Static_Type_Assembly_String_0;

		// Token: 0x04002D44 RID: 11588
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssemblyFromString_Internal_Static_Assembly_String_0;

		// Token: 0x04002D45 RID: 11589
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssemblyFromStringNoThrow_Internal_Static_Assembly_String_0;

		// Token: 0x04002D46 RID: 11590
		private static readonly IntPtr NativeMethodInfoPtr_GetClrAssemblyName_Internal_Static_String_Type_byref_Boolean_0;

		// Token: 0x04002D47 RID: 11591
		private static readonly IntPtr NativeMethodInfoPtr_GetClrTypeFullName_Internal_Static_String_Type_0;

		// Token: 0x04002D48 RID: 11592
		private static readonly IntPtr NativeMethodInfoPtr_GetClrTypeFullNameForArray_Private_Static_String_Type_0;

		// Token: 0x04002D49 RID: 11593
		private static readonly IntPtr NativeMethodInfoPtr_GetClrTypeFullNameForNonArrayTypes_Private_Static_String_Type_0;

		// Token: 0x0200062A RID: 1578
		[ObfuscatedName("System.Runtime.Serialization.FormatterServices+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x060055D8 RID: 21976 RVA: 0x0017FB60 File Offset: 0x0017DD60
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr);
				FormatterServices.__c__DisplayClass9_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr, "type");
				FormatterServices.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr, 100671637);
				FormatterServices.__c__DisplayClass9_0.NativeMethodInfoPtr__GetSerializableMembers_b__0_Internal_Il2CppReferenceArray_1_MemberInfo_MemberHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr, 100671638);
			}

			// Token: 0x060055D9 RID: 21977 RVA: 0x0017FBC8 File Offset: 0x0017DDC8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055DA RID: 21978 RVA: 0x0017FC04 File Offset: 0x0017DE04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213332, XrefRangeEnd = 213340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<MemberInfo> _GetSerializableMembers_b__0(MemberHolder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.__c__DisplayClass9_0.NativeMethodInfoPtr__GetSerializableMembers_b__0_Internal_Il2CppReferenceArray_1_MemberInfo_MemberHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
				}
			}

			// Token: 0x060055DB RID: 21979 RVA: 0x00020ADC File Offset: 0x0001ECDC
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001616 RID: 5654
			// (get) Token: 0x060055DC RID: 21980 RVA: 0x0017FC54 File Offset: 0x0017DE54
			// (set) Token: 0x060055DD RID: 21981 RVA: 0x00020AE5 File Offset: 0x0001ECE5
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatterServices.__c__DisplayClass9_0.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatterServices.__c__DisplayClass9_0.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004535 RID: 17717
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04004536 RID: 17718
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004537 RID: 17719
			private static readonly IntPtr NativeMethodInfoPtr__GetSerializableMembers_b__0_Internal_Il2CppReferenceArray_1_MemberInfo_MemberHolder_0;
		}
	}
}
