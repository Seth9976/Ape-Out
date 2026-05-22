using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000505 RID: 1285
	public static class Statics : Object
	{
		// Token: 0x06004AED RID: 19181 RVA: 0x0015A6B0 File Offset: 0x001588B0
		// Note: this type is marked as 'beforefieldinit'.
		static Statics()
		{
			Il2CppClassPointerStore<Statics>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "Statics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Statics>.NativeClassPtr);
			Statics.NativeFieldInfoPtr_IntPtrType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Statics>.NativeClassPtr, "IntPtrType");
			Statics.NativeFieldInfoPtr_UIntPtrType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Statics>.NativeClassPtr, "UIntPtrType");
			Statics.NativeFieldInfoPtr_HexIntPtrType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Statics>.NativeClassPtr, "HexIntPtrType");
			Statics.NativeMethodInfoPtr_MetadataForString_Public_Static_Il2CppStructArray_1_Byte_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674486);
			Statics.NativeMethodInfoPtr_EncodeTags_Public_Static_Void_Int32_byref_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674487);
			Statics.NativeMethodInfoPtr_Combine_Public_Static_Byte_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674488);
			Statics.NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674489);
			Statics.NativeMethodInfoPtr_CheckName_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674490);
			Statics.NativeMethodInfoPtr_ShouldOverrideFieldName_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674491);
			Statics.NativeMethodInfoPtr_MakeDataType_Public_Static_TraceLoggingDataType_TraceLoggingDataType_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674492);
			Statics.NativeMethodInfoPtr_Format8_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674493);
			Statics.NativeMethodInfoPtr_Format16_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674494);
			Statics.NativeMethodInfoPtr_Format32_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674495);
			Statics.NativeMethodInfoPtr_Format64_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674496);
			Statics.NativeMethodInfoPtr_FormatPtr_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674497);
			Statics.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674498);
			Statics.NativeMethodInfoPtr_IsValueType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674499);
			Statics.NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674500);
			Statics.NativeMethodInfoPtr_GetProperties_Public_Static_IEnumerable_1_PropertyInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674501);
			Statics.NativeMethodInfoPtr_GetGetMethod_Public_Static_MethodInfo_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674502);
			Statics.NativeMethodInfoPtr_GetDeclaredStaticMethod_Public_Static_MethodInfo_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674503);
			Statics.NativeMethodInfoPtr_HasCustomAttribute_Public_Static_Boolean_PropertyInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674504);
			Statics.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_AttributeType_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674505);
			Statics.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_AttributeType_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674506);
			Statics.NativeMethodInfoPtr_GetGenericArguments_Public_Static_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674507);
			Statics.NativeMethodInfoPtr_FindEnumerableElementType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674508);
			Statics.NativeMethodInfoPtr_IsGenericMatch_Public_Static_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674509);
			Statics.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674510);
			Statics.NativeMethodInfoPtr_GetTypeInfoInstance_Public_Static_TraceLoggingTypeInfo_Type_List_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674511);
			Statics.NativeMethodInfoPtr_CreateDefaultTypeInfo_Public_Static_TraceLoggingTypeInfo_1_DataType_List_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674512);
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x0015A938 File Offset: 0x00158B38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 236397, RefRangeEnd = 236400, XrefRangeStart = 236386, XrefRangeEnd = 236397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> MetadataForString(string name, int prefixSize, int suffixSize, int additionalSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prefixSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suffixSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_MetadataForString_Public_Static_Il2CppStructArray_1_Byte_String_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x0015A9A8 File Offset: 0x00158BA8
		[CallerCount(0)]
		public unsafe static void EncodeTags(int tags, ref int pos, Il2CppStructArray<byte> metadata)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_EncodeTags_Public_Static_Void_Int32_byref_Int32_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x0015A9FC File Offset: 0x00158BFC
		[CallerCount(0)]
		public unsafe static byte Combine(int settingValue, byte defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref settingValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_Combine_Public_Static_Byte_Int32_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x0015AA48 File Offset: 0x00158C48
		[CallerCount(0)]
		public unsafe static int Combine(int settingValue1, int settingValue2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref settingValue1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref settingValue2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x0015AA94 File Offset: 0x00158C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236400, XrefRangeEnd = 236401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_CheckName_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x0015AACC File Offset: 0x00158CCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236401, RefRangeEnd = 236403, XrefRangeStart = 236401, XrefRangeEnd = 236401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldOverrideFieldName(string fieldName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_ShouldOverrideFieldName_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x0015AB10 File Offset: 0x00158D10
		[CallerCount(0)]
		public unsafe static TraceLoggingDataType MakeDataType(TraceLoggingDataType baseType, EventFieldFormat format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref baseType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_MakeDataType_Public_Static_TraceLoggingDataType_TraceLoggingDataType_EventFieldFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AF5 RID: 19189 RVA: 0x0015AB5C File Offset: 0x00158D5C
		[CallerCount(217)]
		[CachedScanResults(RefRangeStart = 236404, RefRangeEnd = 236621, XrefRangeStart = 236403, XrefRangeEnd = 236404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingDataType Format8(EventFieldFormat format, TraceLoggingDataType native)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref native;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_Format8_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x0015ABA8 File Offset: 0x00158DA8
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 236622, RefRangeEnd = 236672, XrefRangeStart = 236621, XrefRangeEnd = 236622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingDataType Format16(EventFieldFormat format, TraceLoggingDataType native)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref native;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_Format16_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x0015ABF4 File Offset: 0x00158DF4
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 236673, RefRangeEnd = 236723, XrefRangeStart = 236672, XrefRangeEnd = 236673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingDataType Format32(EventFieldFormat format, TraceLoggingDataType native)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref native;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_Format32_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x0015AC40 File Offset: 0x00158E40
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 236724, RefRangeEnd = 236774, XrefRangeStart = 236723, XrefRangeEnd = 236724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingDataType Format64(EventFieldFormat format, TraceLoggingDataType native)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref native;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_Format64_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x0015AC8C File Offset: 0x00158E8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 236778, RefRangeEnd = 236782, XrefRangeStart = 236774, XrefRangeEnd = 236778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingDataType FormatPtr(EventFieldFormat format, TraceLoggingDataType native)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref native;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_FormatPtr_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x0015ACD8 File Offset: 0x00158ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type type, [Optional] Il2CppReferenceArray<Object> parameters)
		{
			if (parameters == null)
			{
				parameters = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004AFB RID: 19195 RVA: 0x0015AD3C File Offset: 0x00158F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236782, XrefRangeEnd = 236783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValueType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_IsValueType_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004AFC RID: 19196 RVA: 0x0015AD80 File Offset: 0x00158F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEnum(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x0015ADC4 File Offset: 0x00158FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236783, XrefRangeEnd = 236784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<PropertyInfo> GetProperties(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_GetProperties_Public_Static_IEnumerable_1_PropertyInfo_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PropertyInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x0015AE08 File Offset: 0x00159008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236784, XrefRangeEnd = 236785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetGetMethod(PropertyInfo propInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_GetGetMethod_Public_Static_MethodInfo_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06004AFF RID: 19199 RVA: 0x0015AE4C File Offset: 0x0015904C
		[CallerCount(0)]
		public unsafe static MethodInfo GetDeclaredStaticMethod(Type declaringType, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(declaringType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_GetDeclaredStaticMethod_Public_Static_MethodInfo_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x0015AEA4 File Offset: 0x001590A4
		[CallerCount(0)]
		public unsafe static bool HasCustomAttribute(PropertyInfo propInfo, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_HasCustomAttribute_Public_Static_Boolean_PropertyInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B01 RID: 19201 RVA: 0x0015AEF8 File Offset: 0x001590F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236785, XrefRangeEnd = 236791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeType GetCustomAttribute<AttributeType>(PropertyInfo propInfo) where AttributeType : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_AttributeType_PropertyInfo_0<AttributeType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<AttributeType>(intPtr, false, true);
			}
		}

		// Token: 0x06004B02 RID: 19202 RVA: 0x0015AF38 File Offset: 0x00159138
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236797, RefRangeEnd = 236799, XrefRangeStart = 236791, XrefRangeEnd = 236797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeType GetCustomAttribute<AttributeType>(Type type) where AttributeType : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_AttributeType_Type_0<AttributeType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<AttributeType>(intPtr, false, true);
			}
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x0015AF78 File Offset: 0x00159178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236799, XrefRangeEnd = 236800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Type> GetGenericArguments(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_GetGenericArguments_Public_Static_Il2CppReferenceArray_1_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x0015AFBC File Offset: 0x001591BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236827, RefRangeEnd = 236828, XrefRangeStart = 236800, XrefRangeEnd = 236827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type FindEnumerableElementType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_FindEnumerableElementType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x0015B000 File Offset: 0x00159200
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 236829, RefRangeEnd = 236832, XrefRangeStart = 236828, XrefRangeEnd = 236829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGenericMatch(Type type, Object openType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(openType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_IsGenericMatch_Public_Static_Boolean_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x0015B054 File Offset: 0x00159254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type delegateType, MethodInfo methodInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(methodInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x0015B0AC File Offset: 0x001592AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 236883, RefRangeEnd = 236888, XrefRangeStart = 236832, XrefRangeEnd = 236883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingTypeInfo GetTypeInfoInstance(Type dataType, List<Type> recursionCheck)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recursionCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_GetTypeInfoInstance_Public_Static_TraceLoggingTypeInfo_Type_List_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo>(intPtr3) : null;
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x0015B104 File Offset: 0x00159304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236888, XrefRangeEnd = 237435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingTypeInfo<DataType> CreateDefaultTypeInfo<DataType>(List<Type> recursionCheck)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recursionCheck);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.MethodInfoStoreGeneric_CreateDefaultTypeInfo_Public_Static_TraceLoggingTypeInfo_1_DataType_List_1_Type_0<DataType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<DataType>>(intPtr3) : null;
			}
		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x0001BDCF File Offset: 0x00019FCF
		public static Object CreateInstance(Type type, params Object[] parameters)
		{
			return Statics.CreateInstance(type, new Il2CppReferenceArray<Object>(parameters));
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x0001BDDD File Offset: 0x00019FDD
		public Statics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06004B0B RID: 19211 RVA: 0x0015B148 File Offset: 0x00159348
		// (set) Token: 0x06004B0C RID: 19212 RVA: 0x0001BDE6 File Offset: 0x00019FE6
		public unsafe static TraceLoggingDataType IntPtrType
		{
			get
			{
				TraceLoggingDataType traceLoggingDataType;
				IL2CPP.il2cpp_field_static_get_value(Statics.NativeFieldInfoPtr_IntPtrType, (void*)(&traceLoggingDataType));
				return traceLoggingDataType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Statics.NativeFieldInfoPtr_IntPtrType, (void*)(&value));
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06004B0D RID: 19213 RVA: 0x0015B164 File Offset: 0x00159364
		// (set) Token: 0x06004B0E RID: 19214 RVA: 0x0001BDF4 File Offset: 0x00019FF4
		public unsafe static TraceLoggingDataType UIntPtrType
		{
			get
			{
				TraceLoggingDataType traceLoggingDataType;
				IL2CPP.il2cpp_field_static_get_value(Statics.NativeFieldInfoPtr_UIntPtrType, (void*)(&traceLoggingDataType));
				return traceLoggingDataType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Statics.NativeFieldInfoPtr_UIntPtrType, (void*)(&value));
			}
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x06004B0F RID: 19215 RVA: 0x0015B180 File Offset: 0x00159380
		// (set) Token: 0x06004B10 RID: 19216 RVA: 0x0001BE02 File Offset: 0x0001A002
		public unsafe static TraceLoggingDataType HexIntPtrType
		{
			get
			{
				TraceLoggingDataType traceLoggingDataType;
				IL2CPP.il2cpp_field_static_get_value(Statics.NativeFieldInfoPtr_HexIntPtrType, (void*)(&traceLoggingDataType));
				return traceLoggingDataType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Statics.NativeFieldInfoPtr_HexIntPtrType, (void*)(&value));
			}
		}

		// Token: 0x04003C69 RID: 15465
		private static readonly IntPtr NativeFieldInfoPtr_IntPtrType;

		// Token: 0x04003C6A RID: 15466
		private static readonly IntPtr NativeFieldInfoPtr_UIntPtrType;

		// Token: 0x04003C6B RID: 15467
		private static readonly IntPtr NativeFieldInfoPtr_HexIntPtrType;

		// Token: 0x04003C6C RID: 15468
		private static readonly IntPtr NativeMethodInfoPtr_MetadataForString_Public_Static_Il2CppStructArray_1_Byte_String_Int32_Int32_Int32_0;

		// Token: 0x04003C6D RID: 15469
		private static readonly IntPtr NativeMethodInfoPtr_EncodeTags_Public_Static_Void_Int32_byref_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003C6E RID: 15470
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Byte_Int32_Byte_0;

		// Token: 0x04003C6F RID: 15471
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04003C70 RID: 15472
		private static readonly IntPtr NativeMethodInfoPtr_CheckName_Public_Static_Void_String_0;

		// Token: 0x04003C71 RID: 15473
		private static readonly IntPtr NativeMethodInfoPtr_ShouldOverrideFieldName_Public_Static_Boolean_String_0;

		// Token: 0x04003C72 RID: 15474
		private static readonly IntPtr NativeMethodInfoPtr_MakeDataType_Public_Static_TraceLoggingDataType_TraceLoggingDataType_EventFieldFormat_0;

		// Token: 0x04003C73 RID: 15475
		private static readonly IntPtr NativeMethodInfoPtr_Format8_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0;

		// Token: 0x04003C74 RID: 15476
		private static readonly IntPtr NativeMethodInfoPtr_Format16_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0;

		// Token: 0x04003C75 RID: 15477
		private static readonly IntPtr NativeMethodInfoPtr_Format32_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0;

		// Token: 0x04003C76 RID: 15478
		private static readonly IntPtr NativeMethodInfoPtr_Format64_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0;

		// Token: 0x04003C77 RID: 15479
		private static readonly IntPtr NativeMethodInfoPtr_FormatPtr_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0;

		// Token: 0x04003C78 RID: 15480
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003C79 RID: 15481
		private static readonly IntPtr NativeMethodInfoPtr_IsValueType_Public_Static_Boolean_Type_0;

		// Token: 0x04003C7A RID: 15482
		private static readonly IntPtr NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0;

		// Token: 0x04003C7B RID: 15483
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Static_IEnumerable_1_PropertyInfo_Type_0;

		// Token: 0x04003C7C RID: 15484
		private static readonly IntPtr NativeMethodInfoPtr_GetGetMethod_Public_Static_MethodInfo_PropertyInfo_0;

		// Token: 0x04003C7D RID: 15485
		private static readonly IntPtr NativeMethodInfoPtr_GetDeclaredStaticMethod_Public_Static_MethodInfo_Type_String_0;

		// Token: 0x04003C7E RID: 15486
		private static readonly IntPtr NativeMethodInfoPtr_HasCustomAttribute_Public_Static_Boolean_PropertyInfo_Type_0;

		// Token: 0x04003C7F RID: 15487
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_AttributeType_PropertyInfo_0;

		// Token: 0x04003C80 RID: 15488
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_AttributeType_Type_0;

		// Token: 0x04003C81 RID: 15489
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Static_Il2CppReferenceArray_1_Type_Type_0;

		// Token: 0x04003C82 RID: 15490
		private static readonly IntPtr NativeMethodInfoPtr_FindEnumerableElementType_Public_Static_Type_Type_0;

		// Token: 0x04003C83 RID: 15491
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericMatch_Public_Static_Boolean_Type_Object_0;

		// Token: 0x04003C84 RID: 15492
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_0;

		// Token: 0x04003C85 RID: 15493
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeInfoInstance_Public_Static_TraceLoggingTypeInfo_Type_List_1_Type_0;

		// Token: 0x04003C86 RID: 15494
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultTypeInfo_Public_Static_TraceLoggingTypeInfo_1_DataType_List_1_Type_0;

		// Token: 0x02000679 RID: 1657
		private sealed class MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_AttributeType_PropertyInfo_0<AttributeType>
		{
			// Token: 0x040046EE RID: 18158
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Statics.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_AttributeType_PropertyInfo_0, Il2CppClassPointerStore<Statics>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AttributeType>.NativeClassPtr)) }))));
		}

		// Token: 0x0200067A RID: 1658
		private sealed class MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_AttributeType_Type_0<AttributeType>
		{
			// Token: 0x040046EF RID: 18159
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Statics.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_AttributeType_Type_0, Il2CppClassPointerStore<Statics>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AttributeType>.NativeClassPtr)) }))));
		}

		// Token: 0x0200067B RID: 1659
		private sealed class MethodInfoStoreGeneric_CreateDefaultTypeInfo_Public_Static_TraceLoggingTypeInfo_1_DataType_List_1_Type_0<DataType>
		{
			// Token: 0x040046F0 RID: 18160
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Statics.NativeMethodInfoPtr_CreateDefaultTypeInfo_Public_Static_TraceLoggingTypeInfo_1_DataType_List_1_Type_0, Il2CppClassPointerStore<Statics>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DataType>.NativeClassPtr)) }))));
		}
	}
}
