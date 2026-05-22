using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000C2 RID: 194
	public class TypeTranslator : Object
	{
		// Token: 0x06001167 RID: 4455 RVA: 0x0005F93C File Offset: 0x0005DB3C
		// Note: this type is marked as 'beforefieldinit'.
		static TypeTranslator()
		{
			Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "TypeTranslator");
			TypeTranslator.NativeFieldInfoPtr_nameCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, "nameCache");
			TypeTranslator.NativeFieldInfoPtr_primitiveTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, "primitiveTypes");
			TypeTranslator.NativeFieldInfoPtr_primitiveArrayTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, "primitiveArrayTypes");
			TypeTranslator.NativeFieldInfoPtr_nullableTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, "nullableTypes");
			TypeTranslator.NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100666074);
			TypeTranslator.NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100666075);
			TypeTranslator.NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100666076);
			TypeTranslator.NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100666077);
			TypeTranslator.NativeMethodInfoPtr_GetArrayName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100666078);
			TypeTranslator.NativeMethodInfoPtr_ParseArrayType_Public_Static_Void_String_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeTranslator>.NativeClassPtr, 100666079);
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0005FA2C File Offset: 0x0005DC2C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 404598, RefRangeEnd = 404611, XrefRangeStart = 404594, XrefRangeEnd = 404598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeData GetTypeData(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTranslator.NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
			}
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x0005FA70 File Offset: 0x0005DC70
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 404650, RefRangeEnd = 404661, XrefRangeStart = 404611, XrefRangeEnd = 404650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(runtimeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlDataType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref underlyingEnumType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTranslator.NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0005FAD4 File Offset: 0x0005DCD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404661, XrefRangeEnd = 404665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeData GetPrimitiveTypeData(string typeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTranslator.NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
			}
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x0005FB18 File Offset: 0x0005DD18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 404671, RefRangeEnd = 404673, XrefRangeStart = 404665, XrefRangeEnd = 404671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeData GetPrimitiveTypeData(string typeName, bool nullable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTranslator.NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x0005FB6C File Offset: 0x0005DD6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 404704, RefRangeEnd = 404708, XrefRangeStart = 404673, XrefRangeEnd = 404704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetArrayName(string elemName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elemName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeTranslator.NativeMethodInfoPtr_GetArrayName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0005FBA8 File Offset: 0x0005DDA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 404720, RefRangeEnd = 404721, XrefRangeStart = 404708, XrefRangeEnd = 404720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(arrayType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(TypeTranslator.NativeMethodInfoPtr_ParseArrayType_Public_Static_Void_String_byref_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			type = IL2CPP.Il2CppStringToManaged(intPtr);
			ns = IL2CPP.Il2CppStringToManaged(intPtr2);
			dimensions = IL2CPP.Il2CppStringToManaged(intPtr3);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00007B73 File Offset: 0x00005D73
		public TypeTranslator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x0005FC30 File Offset: 0x0005DE30
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x00007B7C File Offset: 0x00005D7C
		public unsafe static Hashtable nameCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeTranslator.NativeFieldInfoPtr_nameCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTranslator.NativeFieldInfoPtr_nameCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x0005FC58 File Offset: 0x0005DE58
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x00007B8E File Offset: 0x00005D8E
		public unsafe static Hashtable primitiveTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeTranslator.NativeFieldInfoPtr_primitiveTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTranslator.NativeFieldInfoPtr_primitiveTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x0005FC80 File Offset: 0x0005DE80
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x00007BA0 File Offset: 0x00005DA0
		public unsafe static Hashtable primitiveArrayTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeTranslator.NativeFieldInfoPtr_primitiveArrayTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTranslator.NativeFieldInfoPtr_primitiveArrayTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x0005FCA8 File Offset: 0x0005DEA8
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x00007BB2 File Offset: 0x00005DB2
		public unsafe static Hashtable nullableTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeTranslator.NativeFieldInfoPtr_nullableTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeTranslator.NativeFieldInfoPtr_nullableTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeFieldInfoPtr_nameCache;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeFieldInfoPtr_primitiveTypes;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeFieldInfoPtr_primitiveArrayTypes;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeFieldInfoPtr_nullableTypes;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_0;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeData_Public_Static_TypeData_Type_String_Boolean_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimitiveTypeData_Public_Static_TypeData_String_Boolean_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayName_Public_Static_String_String_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_ParseArrayType_Public_Static_Void_String_byref_String_byref_String_byref_String_0;
	}
}
