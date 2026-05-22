using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000369 RID: 873
	public sealed class Converter : Object
	{
		// Token: 0x060038AA RID: 14506 RVA: 0x00112A84 File Offset: 0x00110C84
		// Note: this type is marked as 'beforefieldinit'.
		static Converter()
		{
			Il2CppClassPointerStore<Converter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "Converter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Converter>.NativeClassPtr);
			Converter.NativeFieldInfoPtr_primitiveTypeEnumLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "primitiveTypeEnumLength");
			Converter.NativeFieldInfoPtr_typeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeA");
			Converter.NativeFieldInfoPtr_arrayTypeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "arrayTypeA");
			Converter.NativeFieldInfoPtr_valueA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "valueA");
			Converter.NativeFieldInfoPtr_typeCodeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeCodeA");
			Converter.NativeFieldInfoPtr_codeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "codeA");
			Converter.NativeFieldInfoPtr_typeofISerializable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofISerializable");
			Converter.NativeFieldInfoPtr_typeofString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofString");
			Converter.NativeFieldInfoPtr_typeofConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofConverter");
			Converter.NativeFieldInfoPtr_typeofBoolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofBoolean");
			Converter.NativeFieldInfoPtr_typeofByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofByte");
			Converter.NativeFieldInfoPtr_typeofChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofChar");
			Converter.NativeFieldInfoPtr_typeofDecimal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDecimal");
			Converter.NativeFieldInfoPtr_typeofDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDouble");
			Converter.NativeFieldInfoPtr_typeofInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt16");
			Converter.NativeFieldInfoPtr_typeofInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt32");
			Converter.NativeFieldInfoPtr_typeofInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt64");
			Converter.NativeFieldInfoPtr_typeofSByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSByte");
			Converter.NativeFieldInfoPtr_typeofSingle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSingle");
			Converter.NativeFieldInfoPtr_typeofTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofTimeSpan");
			Converter.NativeFieldInfoPtr_typeofDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDateTime");
			Converter.NativeFieldInfoPtr_typeofUInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt16");
			Converter.NativeFieldInfoPtr_typeofUInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt32");
			Converter.NativeFieldInfoPtr_typeofUInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt64");
			Converter.NativeFieldInfoPtr_typeofObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofObject");
			Converter.NativeFieldInfoPtr_typeofSystemVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSystemVoid");
			Converter.NativeFieldInfoPtr_urtAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "urtAssembly");
			Converter.NativeFieldInfoPtr_urtAssemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "urtAssemblyString");
			Converter.NativeFieldInfoPtr_typeofTypeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofTypeArray");
			Converter.NativeFieldInfoPtr_typeofObjectArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofObjectArray");
			Converter.NativeFieldInfoPtr_typeofStringArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofStringArray");
			Converter.NativeFieldInfoPtr_typeofBooleanArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofBooleanArray");
			Converter.NativeFieldInfoPtr_typeofByteArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofByteArray");
			Converter.NativeFieldInfoPtr_typeofCharArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofCharArray");
			Converter.NativeFieldInfoPtr_typeofDecimalArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDecimalArray");
			Converter.NativeFieldInfoPtr_typeofDoubleArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDoubleArray");
			Converter.NativeFieldInfoPtr_typeofInt16Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt16Array");
			Converter.NativeFieldInfoPtr_typeofInt32Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt32Array");
			Converter.NativeFieldInfoPtr_typeofInt64Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt64Array");
			Converter.NativeFieldInfoPtr_typeofSByteArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSByteArray");
			Converter.NativeFieldInfoPtr_typeofSingleArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSingleArray");
			Converter.NativeFieldInfoPtr_typeofTimeSpanArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofTimeSpanArray");
			Converter.NativeFieldInfoPtr_typeofDateTimeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDateTimeArray");
			Converter.NativeFieldInfoPtr_typeofUInt16Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt16Array");
			Converter.NativeFieldInfoPtr_typeofUInt32Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt32Array");
			Converter.NativeFieldInfoPtr_typeofUInt64Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt64Array");
			Converter.NativeFieldInfoPtr_typeofMarshalByRefObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofMarshalByRefObject");
			Converter.NativeMethodInfoPtr_ToCode_Internal_Static_InternalPrimitiveTypeE_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671968);
			Converter.NativeMethodInfoPtr_IsWriteAsByteArray_Internal_Static_Boolean_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671969);
			Converter.NativeMethodInfoPtr_TypeLength_Internal_Static_Int32_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671970);
			Converter.NativeMethodInfoPtr_ToArrayType_Internal_Static_Type_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671971);
			Converter.NativeMethodInfoPtr_InitTypeA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671972);
			Converter.NativeMethodInfoPtr_InitArrayTypeA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671973);
			Converter.NativeMethodInfoPtr_ToType_Internal_Static_Type_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671974);
			Converter.NativeMethodInfoPtr_CreatePrimitiveArray_Internal_Static_Array_InternalPrimitiveTypeE_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671975);
			Converter.NativeMethodInfoPtr_IsPrimitiveArray_Internal_Static_Boolean_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671976);
			Converter.NativeMethodInfoPtr_InitValueA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671977);
			Converter.NativeMethodInfoPtr_ToComType_Internal_Static_String_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671978);
			Converter.NativeMethodInfoPtr_InitTypeCodeA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671979);
			Converter.NativeMethodInfoPtr_ToTypeCode_Internal_Static_TypeCode_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671980);
			Converter.NativeMethodInfoPtr_InitCodeA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671981);
			Converter.NativeMethodInfoPtr_ToPrimitiveTypeEnum_Internal_Static_InternalPrimitiveTypeE_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671982);
			Converter.NativeMethodInfoPtr_FromString_Internal_Static_Object_String_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671983);
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x00112FA0 File Offset: 0x001111A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 215970, RefRangeEnd = 215976, XrefRangeStart = 215961, XrefRangeEnd = 215970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InternalPrimitiveTypeE ToCode(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToCode_Internal_Static_InternalPrimitiveTypeE_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x00112FE4 File Offset: 0x001111E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215976, RefRangeEnd = 215979, XrefRangeStart = 215976, XrefRangeEnd = 215976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWriteAsByteArray(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_IsWriteAsByteArray_Internal_Static_Boolean_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x00113024 File Offset: 0x00111224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215979, RefRangeEnd = 215981, XrefRangeStart = 215979, XrefRangeEnd = 215979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TypeLength(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_TypeLength_Internal_Static_Int32_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x00113064 File Offset: 0x00111264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215981, XrefRangeEnd = 215991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type ToArrayType(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToArrayType_Internal_Static_Type_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x001130A4 File Offset: 0x001112A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216045, RefRangeEnd = 216046, XrefRangeStart = 215991, XrefRangeEnd = 216045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitTypeA()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_InitTypeA_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x001130CC File Offset: 0x001112CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216100, RefRangeEnd = 216101, XrefRangeStart = 216046, XrefRangeEnd = 216100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitArrayTypeA()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_InitArrayTypeA_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x001130F4 File Offset: 0x001112F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216111, RefRangeEnd = 216114, XrefRangeStart = 216101, XrefRangeEnd = 216111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type ToType(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToType_Internal_Static_Type_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x00113134 File Offset: 0x00111334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216159, RefRangeEnd = 216160, XrefRangeStart = 216114, XrefRangeEnd = 216159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_CreatePrimitiveArray_Internal_Static_Array_InternalPrimitiveTypeE_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x00113184 File Offset: 0x00111384
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216187, RefRangeEnd = 216189, XrefRangeStart = 216160, XrefRangeEnd = 216187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrimitiveArray(Type type, out Object typeInformation)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_IsPrimitiveArray_Internal_Static_Boolean_Type_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typeInformation = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x001131E8 File Offset: 0x001113E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216273, RefRangeEnd = 216274, XrefRangeStart = 216189, XrefRangeEnd = 216273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitValueA()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_InitValueA_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x00113210 File Offset: 0x00111410
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216284, RefRangeEnd = 216286, XrefRangeStart = 216274, XrefRangeEnd = 216284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToComType(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToComType_Internal_Static_String_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x00113248 File Offset: 0x00111448
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216294, RefRangeEnd = 216296, XrefRangeStart = 216286, XrefRangeEnd = 216294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitTypeCodeA()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_InitTypeCodeA_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x00113270 File Offset: 0x00111470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216296, XrefRangeEnd = 216306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeCode ToTypeCode(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToTypeCode_Internal_Static_TypeCode_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x001132B0 File Offset: 0x001114B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216313, RefRangeEnd = 216314, XrefRangeStart = 216306, XrefRangeEnd = 216313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitCodeA()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_InitCodeA_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x001132D8 File Offset: 0x001114D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216314, XrefRangeEnd = 216324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToPrimitiveTypeEnum_Internal_Static_InternalPrimitiveTypeE_TypeCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x00113318 File Offset: 0x00111518
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216346, RefRangeEnd = 216349, XrefRangeStart = 216324, XrefRangeEnd = 216346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FromString(string value, InternalPrimitiveTypeE code)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_FromString_Internal_Static_Object_String_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x000146FC File Offset: 0x000128FC
		public Converter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x060038BC RID: 14524 RVA: 0x0011336C File Offset: 0x0011156C
		// (set) Token: 0x060038BD RID: 14525 RVA: 0x00014705 File Offset: 0x00012905
		public unsafe static int primitiveTypeEnumLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_primitiveTypeEnumLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_primitiveTypeEnumLength, (void*)(&value));
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x060038BE RID: 14526 RVA: 0x00113388 File Offset: 0x00111588
		// (set) Token: 0x060038BF RID: 14527 RVA: 0x00014713 File Offset: 0x00012913
		public unsafe static Il2CppReferenceArray<Type> typeA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x060038C0 RID: 14528 RVA: 0x001133B0 File Offset: 0x001115B0
		// (set) Token: 0x060038C1 RID: 14529 RVA: 0x00014725 File Offset: 0x00012925
		public unsafe static Il2CppReferenceArray<Type> arrayTypeA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_arrayTypeA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_arrayTypeA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x060038C2 RID: 14530 RVA: 0x001133D8 File Offset: 0x001115D8
		// (set) Token: 0x060038C3 RID: 14531 RVA: 0x00014737 File Offset: 0x00012937
		public unsafe static Il2CppStringArray valueA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_valueA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_valueA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x060038C4 RID: 14532 RVA: 0x00113400 File Offset: 0x00111600
		// (set) Token: 0x060038C5 RID: 14533 RVA: 0x00014749 File Offset: 0x00012949
		public unsafe static Il2CppStructArray<TypeCode> typeCodeA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeCodeA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TypeCode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeCodeA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x060038C6 RID: 14534 RVA: 0x00113428 File Offset: 0x00111628
		// (set) Token: 0x060038C7 RID: 14535 RVA: 0x0001475B File Offset: 0x0001295B
		public unsafe static Il2CppStructArray<InternalPrimitiveTypeE> codeA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_codeA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<InternalPrimitiveTypeE>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_codeA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x060038C8 RID: 14536 RVA: 0x00113450 File Offset: 0x00111650
		// (set) Token: 0x060038C9 RID: 14537 RVA: 0x0001476D File Offset: 0x0001296D
		public unsafe static Type typeofISerializable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofISerializable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofISerializable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x060038CA RID: 14538 RVA: 0x00113478 File Offset: 0x00111678
		// (set) Token: 0x060038CB RID: 14539 RVA: 0x0001477F File Offset: 0x0001297F
		public unsafe static Type typeofString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofString, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofString, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x060038CC RID: 14540 RVA: 0x001134A0 File Offset: 0x001116A0
		// (set) Token: 0x060038CD RID: 14541 RVA: 0x00014791 File Offset: 0x00012991
		public unsafe static Type typeofConverter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofConverter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofConverter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x060038CE RID: 14542 RVA: 0x001134C8 File Offset: 0x001116C8
		// (set) Token: 0x060038CF RID: 14543 RVA: 0x000147A3 File Offset: 0x000129A3
		public unsafe static Type typeofBoolean
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofBoolean, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofBoolean, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x060038D0 RID: 14544 RVA: 0x001134F0 File Offset: 0x001116F0
		// (set) Token: 0x060038D1 RID: 14545 RVA: 0x000147B5 File Offset: 0x000129B5
		public unsafe static Type typeofByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x060038D2 RID: 14546 RVA: 0x00113518 File Offset: 0x00111718
		// (set) Token: 0x060038D3 RID: 14547 RVA: 0x000147C7 File Offset: 0x000129C7
		public unsafe static Type typeofChar
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofChar, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofChar, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x060038D4 RID: 14548 RVA: 0x00113540 File Offset: 0x00111740
		// (set) Token: 0x060038D5 RID: 14549 RVA: 0x000147D9 File Offset: 0x000129D9
		public unsafe static Type typeofDecimal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDecimal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDecimal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x060038D6 RID: 14550 RVA: 0x00113568 File Offset: 0x00111768
		// (set) Token: 0x060038D7 RID: 14551 RVA: 0x000147EB File Offset: 0x000129EB
		public unsafe static Type typeofDouble
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDouble, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDouble, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x060038D8 RID: 14552 RVA: 0x00113590 File Offset: 0x00111790
		// (set) Token: 0x060038D9 RID: 14553 RVA: 0x000147FD File Offset: 0x000129FD
		public unsafe static Type typeofInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x060038DA RID: 14554 RVA: 0x001135B8 File Offset: 0x001117B8
		// (set) Token: 0x060038DB RID: 14555 RVA: 0x0001480F File Offset: 0x00012A0F
		public unsafe static Type typeofInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x060038DC RID: 14556 RVA: 0x001135E0 File Offset: 0x001117E0
		// (set) Token: 0x060038DD RID: 14557 RVA: 0x00014821 File Offset: 0x00012A21
		public unsafe static Type typeofInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x060038DE RID: 14558 RVA: 0x00113608 File Offset: 0x00111808
		// (set) Token: 0x060038DF RID: 14559 RVA: 0x00014833 File Offset: 0x00012A33
		public unsafe static Type typeofSByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofSByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofSByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x060038E0 RID: 14560 RVA: 0x00113630 File Offset: 0x00111830
		// (set) Token: 0x060038E1 RID: 14561 RVA: 0x00014845 File Offset: 0x00012A45
		public unsafe static Type typeofSingle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofSingle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofSingle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x060038E2 RID: 14562 RVA: 0x00113658 File Offset: 0x00111858
		// (set) Token: 0x060038E3 RID: 14563 RVA: 0x00014857 File Offset: 0x00012A57
		public unsafe static Type typeofTimeSpan
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofTimeSpan, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofTimeSpan, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x060038E4 RID: 14564 RVA: 0x00113680 File Offset: 0x00111880
		// (set) Token: 0x060038E5 RID: 14565 RVA: 0x00014869 File Offset: 0x00012A69
		public unsafe static Type typeofDateTime
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDateTime, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDateTime, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x060038E6 RID: 14566 RVA: 0x001136A8 File Offset: 0x001118A8
		// (set) Token: 0x060038E7 RID: 14567 RVA: 0x0001487B File Offset: 0x00012A7B
		public unsafe static Type typeofUInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x060038E8 RID: 14568 RVA: 0x001136D0 File Offset: 0x001118D0
		// (set) Token: 0x060038E9 RID: 14569 RVA: 0x0001488D File Offset: 0x00012A8D
		public unsafe static Type typeofUInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x060038EA RID: 14570 RVA: 0x001136F8 File Offset: 0x001118F8
		// (set) Token: 0x060038EB RID: 14571 RVA: 0x0001489F File Offset: 0x00012A9F
		public unsafe static Type typeofUInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x060038EC RID: 14572 RVA: 0x00113720 File Offset: 0x00111920
		// (set) Token: 0x060038ED RID: 14573 RVA: 0x000148B1 File Offset: 0x00012AB1
		public unsafe static Type typeofObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x060038EE RID: 14574 RVA: 0x00113748 File Offset: 0x00111948
		// (set) Token: 0x060038EF RID: 14575 RVA: 0x000148C3 File Offset: 0x00012AC3
		public unsafe static Type typeofSystemVoid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofSystemVoid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofSystemVoid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x060038F0 RID: 14576 RVA: 0x00113770 File Offset: 0x00111970
		// (set) Token: 0x060038F1 RID: 14577 RVA: 0x000148D5 File Offset: 0x00012AD5
		public unsafe static Assembly urtAssembly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_urtAssembly, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_urtAssembly, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x060038F2 RID: 14578 RVA: 0x00113798 File Offset: 0x00111998
		// (set) Token: 0x060038F3 RID: 14579 RVA: 0x000148E7 File Offset: 0x00012AE7
		public unsafe static string urtAssemblyString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_urtAssemblyString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_urtAssemblyString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x060038F4 RID: 14580 RVA: 0x001137B8 File Offset: 0x001119B8
		// (set) Token: 0x060038F5 RID: 14581 RVA: 0x000148F9 File Offset: 0x00012AF9
		public unsafe static Type typeofTypeArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofTypeArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofTypeArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x060038F6 RID: 14582 RVA: 0x001137E0 File Offset: 0x001119E0
		// (set) Token: 0x060038F7 RID: 14583 RVA: 0x0001490B File Offset: 0x00012B0B
		public unsafe static Type typeofObjectArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofObjectArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofObjectArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x060038F8 RID: 14584 RVA: 0x00113808 File Offset: 0x00111A08
		// (set) Token: 0x060038F9 RID: 14585 RVA: 0x0001491D File Offset: 0x00012B1D
		public unsafe static Type typeofStringArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofStringArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofStringArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x060038FA RID: 14586 RVA: 0x00113830 File Offset: 0x00111A30
		// (set) Token: 0x060038FB RID: 14587 RVA: 0x0001492F File Offset: 0x00012B2F
		public unsafe static Type typeofBooleanArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofBooleanArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofBooleanArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x060038FC RID: 14588 RVA: 0x00113858 File Offset: 0x00111A58
		// (set) Token: 0x060038FD RID: 14589 RVA: 0x00014941 File Offset: 0x00012B41
		public unsafe static Type typeofByteArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofByteArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofByteArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x060038FE RID: 14590 RVA: 0x00113880 File Offset: 0x00111A80
		// (set) Token: 0x060038FF RID: 14591 RVA: 0x00014953 File Offset: 0x00012B53
		public unsafe static Type typeofCharArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofCharArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofCharArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06003900 RID: 14592 RVA: 0x001138A8 File Offset: 0x00111AA8
		// (set) Token: 0x06003901 RID: 14593 RVA: 0x00014965 File Offset: 0x00012B65
		public unsafe static Type typeofDecimalArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDecimalArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDecimalArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06003902 RID: 14594 RVA: 0x001138D0 File Offset: 0x00111AD0
		// (set) Token: 0x06003903 RID: 14595 RVA: 0x00014977 File Offset: 0x00012B77
		public unsafe static Type typeofDoubleArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDoubleArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDoubleArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06003904 RID: 14596 RVA: 0x001138F8 File Offset: 0x00111AF8
		// (set) Token: 0x06003905 RID: 14597 RVA: 0x00014989 File Offset: 0x00012B89
		public unsafe static Type typeofInt16Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt16Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt16Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06003906 RID: 14598 RVA: 0x00113920 File Offset: 0x00111B20
		// (set) Token: 0x06003907 RID: 14599 RVA: 0x0001499B File Offset: 0x00012B9B
		public unsafe static Type typeofInt32Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt32Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt32Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06003908 RID: 14600 RVA: 0x00113948 File Offset: 0x00111B48
		// (set) Token: 0x06003909 RID: 14601 RVA: 0x000149AD File Offset: 0x00012BAD
		public unsafe static Type typeofInt64Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt64Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt64Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x0600390A RID: 14602 RVA: 0x00113970 File Offset: 0x00111B70
		// (set) Token: 0x0600390B RID: 14603 RVA: 0x000149BF File Offset: 0x00012BBF
		public unsafe static Type typeofSByteArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofSByteArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofSByteArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x0600390C RID: 14604 RVA: 0x00113998 File Offset: 0x00111B98
		// (set) Token: 0x0600390D RID: 14605 RVA: 0x000149D1 File Offset: 0x00012BD1
		public unsafe static Type typeofSingleArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofSingleArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofSingleArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x0600390E RID: 14606 RVA: 0x001139C0 File Offset: 0x00111BC0
		// (set) Token: 0x0600390F RID: 14607 RVA: 0x000149E3 File Offset: 0x00012BE3
		public unsafe static Type typeofTimeSpanArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofTimeSpanArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofTimeSpanArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06003910 RID: 14608 RVA: 0x001139E8 File Offset: 0x00111BE8
		// (set) Token: 0x06003911 RID: 14609 RVA: 0x000149F5 File Offset: 0x00012BF5
		public unsafe static Type typeofDateTimeArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDateTimeArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDateTimeArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06003912 RID: 14610 RVA: 0x00113A10 File Offset: 0x00111C10
		// (set) Token: 0x06003913 RID: 14611 RVA: 0x00014A07 File Offset: 0x00012C07
		public unsafe static Type typeofUInt16Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt16Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt16Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06003914 RID: 14612 RVA: 0x00113A38 File Offset: 0x00111C38
		// (set) Token: 0x06003915 RID: 14613 RVA: 0x00014A19 File Offset: 0x00012C19
		public unsafe static Type typeofUInt32Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt32Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt32Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06003916 RID: 14614 RVA: 0x00113A60 File Offset: 0x00111C60
		// (set) Token: 0x06003917 RID: 14615 RVA: 0x00014A2B File Offset: 0x00012C2B
		public unsafe static Type typeofUInt64Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt64Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt64Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06003918 RID: 14616 RVA: 0x00113A88 File Offset: 0x00111C88
		// (set) Token: 0x06003919 RID: 14617 RVA: 0x00014A3D File Offset: 0x00012C3D
		public unsafe static Type typeofMarshalByRefObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofMarshalByRefObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofMarshalByRefObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F60 RID: 12128
		private static readonly IntPtr NativeFieldInfoPtr_primitiveTypeEnumLength;

		// Token: 0x04002F61 RID: 12129
		private static readonly IntPtr NativeFieldInfoPtr_typeA;

		// Token: 0x04002F62 RID: 12130
		private static readonly IntPtr NativeFieldInfoPtr_arrayTypeA;

		// Token: 0x04002F63 RID: 12131
		private static readonly IntPtr NativeFieldInfoPtr_valueA;

		// Token: 0x04002F64 RID: 12132
		private static readonly IntPtr NativeFieldInfoPtr_typeCodeA;

		// Token: 0x04002F65 RID: 12133
		private static readonly IntPtr NativeFieldInfoPtr_codeA;

		// Token: 0x04002F66 RID: 12134
		private static readonly IntPtr NativeFieldInfoPtr_typeofISerializable;

		// Token: 0x04002F67 RID: 12135
		private static readonly IntPtr NativeFieldInfoPtr_typeofString;

		// Token: 0x04002F68 RID: 12136
		private static readonly IntPtr NativeFieldInfoPtr_typeofConverter;

		// Token: 0x04002F69 RID: 12137
		private static readonly IntPtr NativeFieldInfoPtr_typeofBoolean;

		// Token: 0x04002F6A RID: 12138
		private static readonly IntPtr NativeFieldInfoPtr_typeofByte;

		// Token: 0x04002F6B RID: 12139
		private static readonly IntPtr NativeFieldInfoPtr_typeofChar;

		// Token: 0x04002F6C RID: 12140
		private static readonly IntPtr NativeFieldInfoPtr_typeofDecimal;

		// Token: 0x04002F6D RID: 12141
		private static readonly IntPtr NativeFieldInfoPtr_typeofDouble;

		// Token: 0x04002F6E RID: 12142
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt16;

		// Token: 0x04002F6F RID: 12143
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt32;

		// Token: 0x04002F70 RID: 12144
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt64;

		// Token: 0x04002F71 RID: 12145
		private static readonly IntPtr NativeFieldInfoPtr_typeofSByte;

		// Token: 0x04002F72 RID: 12146
		private static readonly IntPtr NativeFieldInfoPtr_typeofSingle;

		// Token: 0x04002F73 RID: 12147
		private static readonly IntPtr NativeFieldInfoPtr_typeofTimeSpan;

		// Token: 0x04002F74 RID: 12148
		private static readonly IntPtr NativeFieldInfoPtr_typeofDateTime;

		// Token: 0x04002F75 RID: 12149
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt16;

		// Token: 0x04002F76 RID: 12150
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt32;

		// Token: 0x04002F77 RID: 12151
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt64;

		// Token: 0x04002F78 RID: 12152
		private static readonly IntPtr NativeFieldInfoPtr_typeofObject;

		// Token: 0x04002F79 RID: 12153
		private static readonly IntPtr NativeFieldInfoPtr_typeofSystemVoid;

		// Token: 0x04002F7A RID: 12154
		private static readonly IntPtr NativeFieldInfoPtr_urtAssembly;

		// Token: 0x04002F7B RID: 12155
		private static readonly IntPtr NativeFieldInfoPtr_urtAssemblyString;

		// Token: 0x04002F7C RID: 12156
		private static readonly IntPtr NativeFieldInfoPtr_typeofTypeArray;

		// Token: 0x04002F7D RID: 12157
		private static readonly IntPtr NativeFieldInfoPtr_typeofObjectArray;

		// Token: 0x04002F7E RID: 12158
		private static readonly IntPtr NativeFieldInfoPtr_typeofStringArray;

		// Token: 0x04002F7F RID: 12159
		private static readonly IntPtr NativeFieldInfoPtr_typeofBooleanArray;

		// Token: 0x04002F80 RID: 12160
		private static readonly IntPtr NativeFieldInfoPtr_typeofByteArray;

		// Token: 0x04002F81 RID: 12161
		private static readonly IntPtr NativeFieldInfoPtr_typeofCharArray;

		// Token: 0x04002F82 RID: 12162
		private static readonly IntPtr NativeFieldInfoPtr_typeofDecimalArray;

		// Token: 0x04002F83 RID: 12163
		private static readonly IntPtr NativeFieldInfoPtr_typeofDoubleArray;

		// Token: 0x04002F84 RID: 12164
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt16Array;

		// Token: 0x04002F85 RID: 12165
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt32Array;

		// Token: 0x04002F86 RID: 12166
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt64Array;

		// Token: 0x04002F87 RID: 12167
		private static readonly IntPtr NativeFieldInfoPtr_typeofSByteArray;

		// Token: 0x04002F88 RID: 12168
		private static readonly IntPtr NativeFieldInfoPtr_typeofSingleArray;

		// Token: 0x04002F89 RID: 12169
		private static readonly IntPtr NativeFieldInfoPtr_typeofTimeSpanArray;

		// Token: 0x04002F8A RID: 12170
		private static readonly IntPtr NativeFieldInfoPtr_typeofDateTimeArray;

		// Token: 0x04002F8B RID: 12171
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt16Array;

		// Token: 0x04002F8C RID: 12172
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt32Array;

		// Token: 0x04002F8D RID: 12173
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt64Array;

		// Token: 0x04002F8E RID: 12174
		private static readonly IntPtr NativeFieldInfoPtr_typeofMarshalByRefObject;

		// Token: 0x04002F8F RID: 12175
		private static readonly IntPtr NativeMethodInfoPtr_ToCode_Internal_Static_InternalPrimitiveTypeE_Type_0;

		// Token: 0x04002F90 RID: 12176
		private static readonly IntPtr NativeMethodInfoPtr_IsWriteAsByteArray_Internal_Static_Boolean_InternalPrimitiveTypeE_0;

		// Token: 0x04002F91 RID: 12177
		private static readonly IntPtr NativeMethodInfoPtr_TypeLength_Internal_Static_Int32_InternalPrimitiveTypeE_0;

		// Token: 0x04002F92 RID: 12178
		private static readonly IntPtr NativeMethodInfoPtr_ToArrayType_Internal_Static_Type_InternalPrimitiveTypeE_0;

		// Token: 0x04002F93 RID: 12179
		private static readonly IntPtr NativeMethodInfoPtr_InitTypeA_Private_Static_Void_0;

		// Token: 0x04002F94 RID: 12180
		private static readonly IntPtr NativeMethodInfoPtr_InitArrayTypeA_Private_Static_Void_0;

		// Token: 0x04002F95 RID: 12181
		private static readonly IntPtr NativeMethodInfoPtr_ToType_Internal_Static_Type_InternalPrimitiveTypeE_0;

		// Token: 0x04002F96 RID: 12182
		private static readonly IntPtr NativeMethodInfoPtr_CreatePrimitiveArray_Internal_Static_Array_InternalPrimitiveTypeE_Int32_0;

		// Token: 0x04002F97 RID: 12183
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitiveArray_Internal_Static_Boolean_Type_byref_Object_0;

		// Token: 0x04002F98 RID: 12184
		private static readonly IntPtr NativeMethodInfoPtr_InitValueA_Private_Static_Void_0;

		// Token: 0x04002F99 RID: 12185
		private static readonly IntPtr NativeMethodInfoPtr_ToComType_Internal_Static_String_InternalPrimitiveTypeE_0;

		// Token: 0x04002F9A RID: 12186
		private static readonly IntPtr NativeMethodInfoPtr_InitTypeCodeA_Private_Static_Void_0;

		// Token: 0x04002F9B RID: 12187
		private static readonly IntPtr NativeMethodInfoPtr_ToTypeCode_Internal_Static_TypeCode_InternalPrimitiveTypeE_0;

		// Token: 0x04002F9C RID: 12188
		private static readonly IntPtr NativeMethodInfoPtr_InitCodeA_Private_Static_Void_0;

		// Token: 0x04002F9D RID: 12189
		private static readonly IntPtr NativeMethodInfoPtr_ToPrimitiveTypeEnum_Internal_Static_InternalPrimitiveTypeE_TypeCode_0;

		// Token: 0x04002F9E RID: 12190
		private static readonly IntPtr NativeMethodInfoPtr_FromString_Internal_Static_Object_String_InternalPrimitiveTypeE_0;
	}
}
