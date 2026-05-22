using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000C0 RID: 192
	public class TypeData : Object
	{
		// Token: 0x0600112D RID: 4397 RVA: 0x0005EC94 File Offset: 0x0005CE94
		// Note: this type is marked as 'beforefieldinit'.
		static TypeData()
		{
			Il2CppClassPointerStore<TypeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "TypeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeData>.NativeClassPtr);
			TypeData.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "type");
			TypeData.NativeFieldInfoPtr_elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "elementName");
			TypeData.NativeFieldInfoPtr_sType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "sType");
			TypeData.NativeFieldInfoPtr_listItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "listItemType");
			TypeData.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "typeName");
			TypeData.NativeFieldInfoPtr_fullTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "fullTypeName");
			TypeData.NativeFieldInfoPtr_listItemTypeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "listItemTypeData");
			TypeData.NativeFieldInfoPtr_mappedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "mappedType");
			TypeData.NativeFieldInfoPtr_facet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "facet");
			TypeData.NativeFieldInfoPtr_typeConvertor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "typeConvertor");
			TypeData.NativeFieldInfoPtr_hasPublicConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "hasPublicConstructor");
			TypeData.NativeFieldInfoPtr_nullableOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "nullableOverride");
			TypeData.NativeFieldInfoPtr_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "keywords");
			TypeData.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666048);
			TypeData.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Boolean_TypeData_XmlSchemaPatternFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666049);
			TypeData.NativeMethodInfoPtr_LookupTypeConvertor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666050);
			TypeData.NativeMethodInfoPtr_get_TypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666051);
			TypeData.NativeMethodInfoPtr_get_XmlType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666052);
			TypeData.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666053);
			TypeData.NativeMethodInfoPtr_get_FullTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666054);
			TypeData.NativeMethodInfoPtr_get_SchemaType_Public_get_SchemaTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666055);
			TypeData.NativeMethodInfoPtr_get_IsListType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666056);
			TypeData.NativeMethodInfoPtr_get_IsComplexType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666057);
			TypeData.NativeMethodInfoPtr_get_IsValueType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666058);
			TypeData.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666059);
			TypeData.NativeMethodInfoPtr_set_IsNullable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666060);
			TypeData.NativeMethodInfoPtr_get_ListItemTypeData_Public_get_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666061);
			TypeData.NativeMethodInfoPtr_get_ListItemType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666062);
			TypeData.NativeMethodInfoPtr_get_IsXsdType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666063);
			TypeData.NativeMethodInfoPtr_GetIndexerProperty_Public_Static_PropertyInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666064);
			TypeData.NativeMethodInfoPtr_CreateMissingAddMethodException_Private_Static_InvalidOperationException_Type_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666065);
			TypeData.NativeMethodInfoPtr_GetGenericListItemType_Internal_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666066);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0005EF44 File Offset: 0x0005D144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403669, XrefRangeEnd = 403670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeData(Type type, string elementName, bool isPrimitive)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPrimitive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0005EFB0 File Offset: 0x0005D1B0
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 403710, RefRangeEnd = 403764, XrefRangeStart = 403670, XrefRangeEnd = 403710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeData(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPrimitive;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mappedType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(facet);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Boolean_TypeData_XmlSchemaPatternFacet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x0005F044 File Offset: 0x0005D244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403764, XrefRangeEnd = 403767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookupTypeConvertor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_LookupTypeConvertor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x0005F078 File Offset: 0x0005D278
		public unsafe string TypeName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_TypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x0005F0B0 File Offset: 0x0005D2B0
		public unsafe string XmlType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_XmlType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x0005F0E8 File Offset: 0x0005D2E8
		public unsafe Type Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x0005F128 File Offset: 0x0005D328
		public unsafe string FullTypeName
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_FullTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x0005F160 File Offset: 0x0005D360
		public unsafe SchemaTypes SchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_SchemaType_Public_get_SchemaTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x0005F19C File Offset: 0x0005D39C
		public unsafe bool IsListType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_IsListType_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x0005F1D8 File Offset: 0x0005D3D8
		public unsafe bool IsComplexType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_IsComplexType_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x0005F214 File Offset: 0x0005D414
		public unsafe bool IsValueType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 403770, RefRangeEnd = 403772, XrefRangeStart = 403767, XrefRangeEnd = 403770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_IsValueType_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x0005F250 File Offset: 0x0005D450
		// (set) Token: 0x0600113A RID: 4410 RVA: 0x0005F28C File Offset: 0x0005D48C
		public unsafe bool IsNullable
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 403775, RefRangeEnd = 403780, XrefRangeStart = 403772, XrefRangeEnd = 403775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_set_IsNullable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x0005F2CC File Offset: 0x0005D4CC
		public unsafe TypeData ListItemTypeData
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 403788, RefRangeEnd = 403791, XrefRangeStart = 403780, XrefRangeEnd = 403788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_ListItemTypeData_Public_get_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x0005F30C File Offset: 0x0005D50C
		public unsafe Type ListItemType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 403859, RefRangeEnd = 403863, XrefRangeStart = 403791, XrefRangeEnd = 403859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_ListItemType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x0005F34C File Offset: 0x0005D54C
		public unsafe bool IsXsdType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_IsXsdType_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0005F388 File Offset: 0x0005D588
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 403870, RefRangeEnd = 403872, XrefRangeStart = 403863, XrefRangeEnd = 403870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo GetIndexerProperty(Type collectionType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collectionType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_GetIndexerProperty_Public_Static_PropertyInfo_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0005F3CC File Offset: 0x0005D5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403872, XrefRangeEnd = 403887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(inheritFrom);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_CreateMissingAddMethodException_Private_Static_InvalidOperationException_Type_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InvalidOperationException>(intPtr3) : null;
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x0005F434 File Offset: 0x0005D634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 403898, RefRangeEnd = 403900, XrefRangeStart = 403887, XrefRangeEnd = 403898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetGenericListItemType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_GetGenericListItemType_Internal_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x000079A9 File Offset: 0x00005BA9
		public TypeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x0005F478 File Offset: 0x0005D678
		// (set) Token: 0x06001143 RID: 4419 RVA: 0x000079B2 File Offset: 0x00005BB2
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x0005F4A8 File Offset: 0x0005D6A8
		// (set) Token: 0x06001145 RID: 4421 RVA: 0x000079D1 File Offset: 0x00005BD1
		public unsafe string elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x0005F4D0 File Offset: 0x0005D6D0
		// (set) Token: 0x06001147 RID: 4423 RVA: 0x000079F0 File Offset: 0x00005BF0
		public unsafe SchemaTypes sType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_sType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_sType)) = value;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x0005F4F8 File Offset: 0x0005D6F8
		// (set) Token: 0x06001149 RID: 4425 RVA: 0x00007A0B File Offset: 0x00005C0B
		public unsafe Type listItemType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_listItemType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_listItemType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x0005F528 File Offset: 0x0005D728
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x00007A2A File Offset: 0x00005C2A
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x0005F550 File Offset: 0x0005D750
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x00007A49 File Offset: 0x00005C49
		public unsafe string fullTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_fullTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_fullTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x0005F578 File Offset: 0x0005D778
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x00007A68 File Offset: 0x00005C68
		public unsafe TypeData listItemTypeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_listItemTypeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_listItemTypeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x0005F5A8 File Offset: 0x0005D7A8
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x00007A87 File Offset: 0x00005C87
		public unsafe TypeData mappedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_mappedType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_mappedType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x0005F5D8 File Offset: 0x0005D7D8
		// (set) Token: 0x06001153 RID: 4435 RVA: 0x00007AA6 File Offset: 0x00005CA6
		public unsafe XmlSchemaPatternFacet facet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_facet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaPatternFacet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_facet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x0005F608 File Offset: 0x0005D808
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x00007AC5 File Offset: 0x00005CC5
		public unsafe MethodInfo typeConvertor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_typeConvertor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_typeConvertor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x0005F638 File Offset: 0x0005D838
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x00007AE4 File Offset: 0x00005CE4
		public unsafe bool hasPublicConstructor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_hasPublicConstructor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_hasPublicConstructor)) = value;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x0005F660 File Offset: 0x0005D860
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x00007AFF File Offset: 0x00005CFF
		public unsafe bool nullableOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_nullableOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_nullableOverride)) = value;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x0005F688 File Offset: 0x0005D888
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x00007B1A File Offset: 0x00005D1A
		public unsafe static Il2CppStringArray keywords
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeData.NativeFieldInfoPtr_keywords, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeData.NativeFieldInfoPtr_keywords, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeFieldInfoPtr_elementName;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeFieldInfoPtr_sType;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeFieldInfoPtr_listItemType;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeFieldInfoPtr_fullTypeName;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeFieldInfoPtr_listItemTypeData;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeFieldInfoPtr_mappedType;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeFieldInfoPtr_facet;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeFieldInfoPtr_typeConvertor;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeFieldInfoPtr_hasPublicConstructor;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeFieldInfoPtr_nullableOverride;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeFieldInfoPtr_keywords;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_Boolean_0;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_Boolean_TypeData_XmlSchemaPatternFacet_0;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeMethodInfoPtr_LookupTypeConvertor_Private_Void_0;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_get_String_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Public_get_String_0;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeMethodInfoPtr_get_FullTypeName_Public_get_String_0;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Public_get_SchemaTypes_0;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeMethodInfoPtr_get_IsListType_Public_get_Boolean_0;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeMethodInfoPtr_get_IsComplexType_Public_get_Boolean_0;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValueType_Public_get_Boolean_0;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeMethodInfoPtr_set_IsNullable_Public_set_Void_Boolean_0;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr_get_ListItemTypeData_Public_get_TypeData_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_get_ListItemType_Public_get_Type_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_get_IsXsdType_Public_get_Boolean_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexerProperty_Public_Static_PropertyInfo_Type_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_CreateMissingAddMethodException_Private_Static_InvalidOperationException_Type_String_Type_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericListItemType_Internal_Static_Type_Type_0;
	}
}
