using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200019E RID: 414
	public class XmlSchemaDatatype : Object
	{
		// Token: 0x060021F0 RID: 8688 RVA: 0x0009EDE8 File Offset: 0x0009CFE8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaDatatype()
		{
			Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaDatatype");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668131);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_TokenizedType_Public_Abstract_Virtual_New_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668132);
			XmlSchemaDatatype.NativeMethodInfoPtr_ParseValue_Public_Abstract_Virtual_New_Object_String_XmlNameTable_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668133);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_Variety_Public_Virtual_New_get_XmlSchemaDatatypeVariety_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668134);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_New_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668135);
			XmlSchemaDatatype.NativeMethodInfoPtr_IsDerivedFrom_Public_Virtual_New_Boolean_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668136);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_HasLexicalFacets_Internal_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668137);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_HasValueFacets_Internal_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668138);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_ValueConverter_Internal_Abstract_Virtual_New_get_XmlValueConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668139);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_Restriction_Internal_Abstract_Virtual_New_get_RestrictionFacets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668140);
			XmlSchemaDatatype.NativeMethodInfoPtr_Compare_Internal_Abstract_Virtual_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668141);
			XmlSchemaDatatype.NativeMethodInfoPtr_ParseValue_Internal_Abstract_Virtual_New_Object_String_XmlNameTable_IXmlNamespaceResolver_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668142);
			XmlSchemaDatatype.NativeMethodInfoPtr_TryParseValue_Internal_Abstract_Virtual_New_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668143);
			XmlSchemaDatatype.NativeMethodInfoPtr_TryParseValue_Internal_Abstract_Virtual_New_Exception_Object_XmlNameTable_IXmlNamespaceResolver_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668144);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_FacetsChecker_Internal_Abstract_Virtual_New_get_FacetsChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668145);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Abstract_Virtual_New_get_XmlSchemaWhiteSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668146);
			XmlSchemaDatatype.NativeMethodInfoPtr_DeriveByRestriction_Internal_Abstract_Virtual_New_XmlSchemaDatatype_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668147);
			XmlSchemaDatatype.NativeMethodInfoPtr_DeriveByList_Internal_Abstract_Virtual_New_XmlSchemaDatatype_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668148);
			XmlSchemaDatatype.NativeMethodInfoPtr_VerifySchemaValid_Internal_Abstract_Virtual_New_Void_XmlSchemaObjectTable_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668149);
			XmlSchemaDatatype.NativeMethodInfoPtr_IsEqual_Internal_Abstract_Virtual_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668150);
			XmlSchemaDatatype.NativeMethodInfoPtr_IsComparable_Internal_Abstract_Virtual_New_Boolean_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668151);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_TypeCodeString_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668152);
			XmlSchemaDatatype.NativeMethodInfoPtr_TypeCodeToString_Internal_String_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668153);
			XmlSchemaDatatype.NativeMethodInfoPtr_ConcatenatedToString_Internal_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668154);
			XmlSchemaDatatype.NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_XmlSchemaDatatype_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668155);
			XmlSchemaDatatype.NativeMethodInfoPtr_FromXmlTokenizedTypeXsd_Internal_Static_XmlSchemaDatatype_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668156);
			XmlSchemaDatatype.NativeMethodInfoPtr_FromXdrName_Internal_Static_XmlSchemaDatatype_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668157);
			XmlSchemaDatatype.NativeMethodInfoPtr_DeriveByUnion_Internal_Static_XmlSchemaDatatype_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668158);
			XmlSchemaDatatype.NativeMethodInfoPtr_XdrCanonizeUri_Internal_Static_String_String_XmlNameTable_SchemaNames_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668159);
			XmlSchemaDatatype.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668160);
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x060021F1 RID: 8689 RVA: 0x0009F070 File Offset: 0x0009D270
		public unsafe virtual Type ValueType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x0009F0BC File Offset: 0x0009D2BC
		public unsafe virtual XmlTokenizedType TokenizedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_TokenizedType_Public_Abstract_Virtual_New_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x0009F104 File Offset: 0x0009D304
		[CallerCount(0)]
		public unsafe virtual Object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_ParseValue_Public_Abstract_Virtual_New_Object_String_XmlNameTable_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x060021F4 RID: 8692 RVA: 0x0009F184 File Offset: 0x0009D384
		public unsafe virtual XmlSchemaDatatypeVariety Variety
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_Variety_Public_Virtual_New_get_XmlSchemaDatatypeVariety_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x060021F5 RID: 8693 RVA: 0x0009F1CC File Offset: 0x0009D3CC
		public unsafe virtual XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_New_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x0009F214 File Offset: 0x0009D414
		[CallerCount(0)]
		public unsafe virtual bool IsDerivedFrom(XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(datatype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_IsDerivedFrom_Public_Virtual_New_Boolean_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x0009F26C File Offset: 0x0009D46C
		public unsafe virtual bool HasLexicalFacets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_HasLexicalFacets_Internal_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x060021F8 RID: 8696 RVA: 0x0009F2B4 File Offset: 0x0009D4B4
		public unsafe virtual bool HasValueFacets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_HasValueFacets_Internal_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x0009F2FC File Offset: 0x0009D4FC
		public unsafe virtual XmlValueConverter ValueConverter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_ValueConverter_Internal_Abstract_Virtual_New_get_XmlValueConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x0009F348 File Offset: 0x0009D548
		public unsafe virtual RestrictionFacets Restriction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_Restriction_Internal_Abstract_Virtual_New_get_RestrictionFacets_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr3) : null;
			}
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x0009F394 File Offset: 0x0009D594
		[CallerCount(0)]
		public unsafe virtual int Compare(Object value1, Object value2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_Compare_Internal_Abstract_Virtual_New_Int32_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x0009F400 File Offset: 0x0009D600
		[CallerCount(0)]
		public unsafe virtual Object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createAtomicValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_ParseValue_Internal_Abstract_Virtual_New_Object_String_XmlNameTable_IXmlNamespaceResolver_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x0009F490 File Offset: 0x0009D690
		[CallerCount(0)]
		public unsafe virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_TryParseValue_Internal_Abstract_Virtual_New_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typedValue = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr5) : null;
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x0009F534 File Offset: 0x0009D734
		[CallerCount(0)]
		public unsafe virtual Exception TryParseValue(Object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out Object typedValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceResolver);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_TryParseValue_Internal_Abstract_Virtual_New_Exception_Object_XmlNameTable_IXmlNamespaceResolver_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typedValue = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr5) : null;
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x0009F5D8 File Offset: 0x0009D7D8
		public unsafe virtual FacetsChecker FacetsChecker
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_FacetsChecker_Internal_Abstract_Virtual_New_get_FacetsChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr3) : null;
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x0009F624 File Offset: 0x0009D824
		public unsafe virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Abstract_Virtual_New_get_XmlSchemaWhiteSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x0009F66C File Offset: 0x0009D86C
		[CallerCount(0)]
		public unsafe virtual XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(facets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_DeriveByRestriction_Internal_Abstract_Virtual_New_XmlSchemaDatatype_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x0009F6EC File Offset: 0x0009D8EC
		[CallerCount(0)]
		public unsafe virtual XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_DeriveByList_Internal_Abstract_Virtual_New_XmlSchemaDatatype_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x0009F748 File Offset: 0x0009D948
		[CallerCount(0)]
		public unsafe virtual void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caller);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_VerifySchemaValid_Internal_Abstract_Virtual_New_Void_XmlSchemaObjectTable_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x0009F7A8 File Offset: 0x0009D9A8
		[CallerCount(0)]
		public unsafe virtual bool IsEqual(Object o1, Object o2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_IsEqual_Internal_Abstract_Virtual_New_Boolean_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x0009F814 File Offset: 0x0009DA14
		[CallerCount(0)]
		public unsafe virtual bool IsComparable(XmlSchemaDatatype dtype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_IsComparable_Internal_Abstract_Virtual_New_Boolean_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06002206 RID: 8710 RVA: 0x0009F86C File Offset: 0x0009DA6C
		public unsafe string TypeCodeString
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 426938, RefRangeEnd = 426943, XrefRangeStart = 426931, XrefRangeEnd = 426938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_get_TypeCodeString_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x0009F8A4 File Offset: 0x0009DAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426943, XrefRangeEnd = 426989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TypeCodeToString(XmlTypeCode typeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_TypeCodeToString_Internal_String_XmlTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x0009F8E8 File Offset: 0x0009DAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426989, XrefRangeEnd = 427074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ConcatenatedToString(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_ConcatenatedToString_Internal_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x0009F924 File Offset: 0x0009DB24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 427082, RefRangeEnd = 427086, XrefRangeStart = 427074, XrefRangeEnd = 427082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_XmlSchemaDatatype_XmlTokenizedType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x0009F964 File Offset: 0x0009DB64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 427094, RefRangeEnd = 427095, XrefRangeStart = 427086, XrefRangeEnd = 427094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_FromXmlTokenizedTypeXsd_Internal_Static_XmlSchemaDatatype_XmlTokenizedType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x0009F9A4 File Offset: 0x0009DBA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 427108, RefRangeEnd = 427112, XrefRangeStart = 427095, XrefRangeEnd = 427108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaDatatype FromXdrName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_FromXdrName_Internal_Static_XmlSchemaDatatype_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x0009F9E8 File Offset: 0x0009DBE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 427116, RefRangeEnd = 427118, XrefRangeStart = 427112, XrefRangeEnd = 427116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaDatatype DeriveByUnion(Il2CppReferenceArray<XmlSchemaSimpleType> types, XmlSchemaType schemaType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(types);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_DeriveByUnion_Internal_Static_XmlSchemaDatatype_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x0009FA40 File Offset: 0x0009DC40
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 427134, RefRangeEnd = 427140, XrefRangeStart = 427118, XrefRangeEnd = 427134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_XdrCanonizeUri_Internal_Static_String_String_XmlNameTable_SchemaNames_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x0009FAA0 File Offset: 0x0009DCA0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaDatatype()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x0000EBC6 File Offset: 0x0000CDC6
		public XmlSchemaDatatype(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Abstract_Virtual_New_get_XmlTokenizedType_0;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Public_Abstract_Virtual_New_Object_String_XmlNameTable_IXmlNamespaceResolver_0;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeMethodInfoPtr_get_Variety_Public_Virtual_New_get_XmlSchemaDatatypeVariety_0;

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_New_get_XmlTypeCode_0;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeMethodInfoPtr_IsDerivedFrom_Public_Virtual_New_Boolean_XmlSchemaDatatype_0;

		// Token: 0x04001935 RID: 6453
		private static readonly IntPtr NativeMethodInfoPtr_get_HasLexicalFacets_Internal_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001936 RID: 6454
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValueFacets_Internal_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001937 RID: 6455
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueConverter_Internal_Abstract_Virtual_New_get_XmlValueConverter_0;

		// Token: 0x04001938 RID: 6456
		private static readonly IntPtr NativeMethodInfoPtr_get_Restriction_Internal_Abstract_Virtual_New_get_RestrictionFacets_0;

		// Token: 0x04001939 RID: 6457
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Internal_Abstract_Virtual_New_Int32_Object_Object_0;

		// Token: 0x0400193A RID: 6458
		private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Internal_Abstract_Virtual_New_Object_String_XmlNameTable_IXmlNamespaceResolver_Boolean_0;

		// Token: 0x0400193B RID: 6459
		private static readonly IntPtr NativeMethodInfoPtr_TryParseValue_Internal_Abstract_Virtual_New_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0;

		// Token: 0x0400193C RID: 6460
		private static readonly IntPtr NativeMethodInfoPtr_TryParseValue_Internal_Abstract_Virtual_New_Exception_Object_XmlNameTable_IXmlNamespaceResolver_byref_Object_0;

		// Token: 0x0400193D RID: 6461
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetsChecker_Internal_Abstract_Virtual_New_get_FacetsChecker_0;

		// Token: 0x0400193E RID: 6462
		private static readonly IntPtr NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Abstract_Virtual_New_get_XmlSchemaWhiteSpace_0;

		// Token: 0x0400193F RID: 6463
		private static readonly IntPtr NativeMethodInfoPtr_DeriveByRestriction_Internal_Abstract_Virtual_New_XmlSchemaDatatype_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType_0;

		// Token: 0x04001940 RID: 6464
		private static readonly IntPtr NativeMethodInfoPtr_DeriveByList_Internal_Abstract_Virtual_New_XmlSchemaDatatype_XmlSchemaType_0;

		// Token: 0x04001941 RID: 6465
		private static readonly IntPtr NativeMethodInfoPtr_VerifySchemaValid_Internal_Abstract_Virtual_New_Void_XmlSchemaObjectTable_XmlSchemaObject_0;

		// Token: 0x04001942 RID: 6466
		private static readonly IntPtr NativeMethodInfoPtr_IsEqual_Internal_Abstract_Virtual_New_Boolean_Object_Object_0;

		// Token: 0x04001943 RID: 6467
		private static readonly IntPtr NativeMethodInfoPtr_IsComparable_Internal_Abstract_Virtual_New_Boolean_XmlSchemaDatatype_0;

		// Token: 0x04001944 RID: 6468
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCodeString_Internal_get_String_0;

		// Token: 0x04001945 RID: 6469
		private static readonly IntPtr NativeMethodInfoPtr_TypeCodeToString_Internal_String_XmlTypeCode_0;

		// Token: 0x04001946 RID: 6470
		private static readonly IntPtr NativeMethodInfoPtr_ConcatenatedToString_Internal_Static_String_Object_0;

		// Token: 0x04001947 RID: 6471
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_XmlSchemaDatatype_XmlTokenizedType_0;

		// Token: 0x04001948 RID: 6472
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlTokenizedTypeXsd_Internal_Static_XmlSchemaDatatype_XmlTokenizedType_0;

		// Token: 0x04001949 RID: 6473
		private static readonly IntPtr NativeMethodInfoPtr_FromXdrName_Internal_Static_XmlSchemaDatatype_String_0;

		// Token: 0x0400194A RID: 6474
		private static readonly IntPtr NativeMethodInfoPtr_DeriveByUnion_Internal_Static_XmlSchemaDatatype_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaType_0;

		// Token: 0x0400194B RID: 6475
		private static readonly IntPtr NativeMethodInfoPtr_XdrCanonizeUri_Internal_Static_String_String_XmlNameTable_SchemaNames_0;

		// Token: 0x0400194C RID: 6476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
