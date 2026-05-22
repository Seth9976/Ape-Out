using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000353 RID: 851
	public static class BinaryConverter : Object
	{
		// Token: 0x0600375C RID: 14172 RVA: 0x0010E938 File Offset: 0x0010CB38
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryConverter()
		{
			Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr);
			BinaryConverter.NativeMethodInfoPtr_GetBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_WriteObjectInfo_String_ObjectWriter_byref_Object_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100671868);
			BinaryConverter.NativeMethodInfoPtr_GetParserBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100671869);
			BinaryConverter.NativeMethodInfoPtr_WriteTypeInfo_Internal_Static_Void_BinaryTypeEnum_Object_Int32___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100671870);
			BinaryConverter.NativeMethodInfoPtr_ReadTypeInfo_Internal_Static_Object_BinaryTypeEnum___BinaryParser_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100671871);
			BinaryConverter.NativeMethodInfoPtr_TypeFromInfo_Internal_Static_Void_BinaryTypeEnum_Object_ObjectReader_BinaryAssemblyInfo_byref_InternalPrimitiveTypeE_byref_String_byref_Type_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100671872);
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x0010E9CC File Offset: 0x0010CBCC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 215708, RefRangeEnd = 215712, XrefRangeStart = 215678, XrefRangeEnd = 215708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BinaryTypeEnum GetBinaryTypeInfo(Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out Object typeInformation, out int assemId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectWriter);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &assemId;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_GetBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_WriteObjectInfo_String_ObjectWriter_byref_Object_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typeInformation = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x0010EA78 File Offset: 0x0010CC78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215746, RefRangeEnd = 215747, XrefRangeStart = 215712, XrefRangeEnd = 215746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BinaryTypeEnum GetParserBinaryTypeInfo(Type type, out Object typeInformation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_GetParserBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typeInformation = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x0010EADC File Offset: 0x0010CCDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215748, RefRangeEnd = 215750, XrefRangeStart = 215747, XrefRangeEnd = 215748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, Object typeInformation, int assemId, __BinaryWriter sout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryTypeEnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInformation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sout);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_WriteTypeInfo_Internal_Static_Void_BinaryTypeEnum_Object_Int32___BinaryWriter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x0010EB40 File Offset: 0x0010CD40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215751, RefRangeEnd = 215754, XrefRangeStart = 215750, XrefRangeEnd = 215751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryTypeEnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &assemId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_ReadTypeInfo_Internal_Static_Object_BinaryTypeEnum___BinaryParser_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x0010EBA0 File Offset: 0x0010CDA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215767, RefRangeEnd = 215769, XrefRangeStart = 215754, XrefRangeEnd = 215767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TypeFromInfo(BinaryTypeEnum binaryTypeEnum, Object typeInformation, ObjectReader objectReader, BinaryAssemblyInfo assemblyInfo, out InternalPrimitiveTypeE primitiveTypeEnum, out string typeString, out Type type, out bool isVariant)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryTypeEnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInformation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectReader);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &primitiveTypeEnum;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isVariant;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_TypeFromInfo_Internal_Static_Void_BinaryTypeEnum_Object_ObjectReader_BinaryAssemblyInfo_byref_InternalPrimitiveTypeE_byref_String_byref_Type_byref_Boolean_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			typeString = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			type = ((intPtr5 == 0) ? null : new Type(intPtr5));
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x00013B7C File Offset: 0x00011D7C
		public BinaryConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E9E RID: 11934
		private static readonly IntPtr NativeMethodInfoPtr_GetBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_WriteObjectInfo_String_ObjectWriter_byref_Object_byref_Int32_0;

		// Token: 0x04002E9F RID: 11935
		private static readonly IntPtr NativeMethodInfoPtr_GetParserBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_byref_Object_0;

		// Token: 0x04002EA0 RID: 11936
		private static readonly IntPtr NativeMethodInfoPtr_WriteTypeInfo_Internal_Static_Void_BinaryTypeEnum_Object_Int32___BinaryWriter_0;

		// Token: 0x04002EA1 RID: 11937
		private static readonly IntPtr NativeMethodInfoPtr_ReadTypeInfo_Internal_Static_Object_BinaryTypeEnum___BinaryParser_byref_Int32_0;

		// Token: 0x04002EA2 RID: 11938
		private static readonly IntPtr NativeMethodInfoPtr_TypeFromInfo_Internal_Static_Void_BinaryTypeEnum_Object_ObjectReader_BinaryAssemblyInfo_byref_InternalPrimitiveTypeE_byref_String_byref_Type_byref_Boolean_0;
	}
}
