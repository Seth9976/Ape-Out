using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000104 RID: 260
	public class TypedObject : Object
	{
		// Token: 0x0600159E RID: 5534 RVA: 0x0006F560 File Offset: 0x0006D760
		// Note: this type is marked as 'beforefieldinit'.
		static TypedObject()
		{
			Il2CppClassPointerStore<TypedObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "TypedObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedObject>.NativeClassPtr);
			TypedObject.NativeFieldInfoPtr_dstruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, "dstruct");
			TypedObject.NativeFieldInfoPtr_ovalue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, "ovalue");
			TypedObject.NativeFieldInfoPtr_svalue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, "svalue");
			TypedObject.NativeFieldInfoPtr_xsdtype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, "xsdtype");
			TypedObject.NativeFieldInfoPtr_dim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, "dim");
			TypedObject.NativeFieldInfoPtr_isList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, "isList");
			TypedObject.NativeMethodInfoPtr_get_Dim_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100666568);
			TypedObject.NativeMethodInfoPtr_get_IsList_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100666569);
			TypedObject.NativeMethodInfoPtr_get_IsDecimal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100666570);
			TypedObject.NativeMethodInfoPtr_get_Dvalue_Public_get_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100666571);
			TypedObject.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100666572);
			TypedObject.NativeMethodInfoPtr_get_Type_Public_get_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100666573);
			TypedObject.NativeMethodInfoPtr__ctor_Public_Void_Object_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100666574);
			TypedObject.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100666575);
			TypedObject.NativeMethodInfoPtr_SetDecimal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100666576);
			TypedObject.NativeMethodInfoPtr_ListDValueEquals_Private_Boolean_TypedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100666577);
			TypedObject.NativeMethodInfoPtr_Equals_Public_Boolean_TypedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100666578);
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x0006F6E4 File Offset: 0x0006D8E4
		public unsafe int Dim
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_get_Dim_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x0006F720 File Offset: 0x0006D920
		public unsafe bool IsList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_get_IsList_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x0006F75C File Offset: 0x0006D95C
		public unsafe bool IsDecimal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_get_IsDecimal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x0006F798 File Offset: 0x0006D998
		public unsafe Il2CppStructArray<Decimal> Dvalue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_get_Dvalue_Public_get_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Decimal>>(intPtr3) : null;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060015A3 RID: 5539 RVA: 0x0006F7D8 File Offset: 0x0006D9D8
		public unsafe Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x0006F818 File Offset: 0x0006DA18
		public unsafe XmlSchemaDatatype Type
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_get_Type_Public_get_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0006F858 File Offset: 0x0006DA58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 409110, RefRangeEnd = 409115, XrefRangeStart = 409103, XrefRangeEnd = 409110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypedObject(Object obj, string svalue, XmlSchemaDatatype xsdtype)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedObject>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(svalue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xsdtype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr__ctor_Public_Void_Object_String_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x0006F8C8 File Offset: 0x0006DAC8
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypedObject.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x0006F90C File Offset: 0x0006DB0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 409122, RefRangeEnd = 409125, XrefRangeStart = 409115, XrefRangeEnd = 409122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDecimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_SetDecimal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x0006F940 File Offset: 0x0006DB40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 409134, RefRangeEnd = 409135, XrefRangeStart = 409125, XrefRangeEnd = 409134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ListDValueEquals(TypedObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_ListDValueEquals_Private_Boolean_TypedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x0006F990 File Offset: 0x0006DB90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 409140, RefRangeEnd = 409141, XrefRangeStart = 409135, XrefRangeEnd = 409140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(TypedObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_Equals_Public_Boolean_TypedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00009AA9 File Offset: 0x00007CA9
		public TypedObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x0006F9E0 File Offset: 0x0006DBE0
		// (set) Token: 0x060015AC RID: 5548 RVA: 0x00009AB2 File Offset: 0x00007CB2
		public unsafe TypedObject.DecimalStruct dstruct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_dstruct);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypedObject.DecimalStruct>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_dstruct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x0006FA10 File Offset: 0x0006DC10
		// (set) Token: 0x060015AE RID: 5550 RVA: 0x00009AD1 File Offset: 0x00007CD1
		public unsafe Object ovalue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_ovalue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_ovalue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x0006FA40 File Offset: 0x0006DC40
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x00009AF0 File Offset: 0x00007CF0
		public unsafe string svalue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_svalue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_svalue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x0006FA68 File Offset: 0x0006DC68
		// (set) Token: 0x060015B2 RID: 5554 RVA: 0x00009B0F File Offset: 0x00007D0F
		public unsafe XmlSchemaDatatype xsdtype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_xsdtype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_xsdtype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x0006FA98 File Offset: 0x0006DC98
		// (set) Token: 0x060015B4 RID: 5556 RVA: 0x00009B2E File Offset: 0x00007D2E
		public unsafe int dim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_dim);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_dim)) = value;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x0006FAC0 File Offset: 0x0006DCC0
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x00009B49 File Offset: 0x00007D49
		public unsafe bool isList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_isList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_isList)) = value;
			}
		}

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeFieldInfoPtr_dstruct;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeFieldInfoPtr_ovalue;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeFieldInfoPtr_svalue;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeFieldInfoPtr_xsdtype;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeFieldInfoPtr_dim;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeFieldInfoPtr_isList;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeMethodInfoPtr_get_Dim_Public_get_Int32_0;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeMethodInfoPtr_get_IsList_Public_get_Boolean_0;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDecimal_Public_get_Boolean_0;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr_get_Dvalue_Public_get_Il2CppStructArray_1_Decimal_0;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_XmlSchemaDatatype_0;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_String_XmlSchemaDatatype_0;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr_SetDecimal_Public_Void_0;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeMethodInfoPtr_ListDValueEquals_Private_Boolean_TypedObject_0;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_TypedObject_0;

		// Token: 0x0200022E RID: 558
		public class DecimalStruct : Object
		{
			// Token: 0x06002C33 RID: 11315 RVA: 0x000C5D54 File Offset: 0x000C3F54
			// Note: this type is marked as 'beforefieldinit'.
			static DecimalStruct()
			{
				Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, "DecimalStruct");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr);
				TypedObject.DecimalStruct.NativeFieldInfoPtr_isDecimal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr, "isDecimal");
				TypedObject.DecimalStruct.NativeFieldInfoPtr_dvalue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr, "dvalue");
				TypedObject.DecimalStruct.NativeMethodInfoPtr_get_IsDecimal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr, 100666579);
				TypedObject.DecimalStruct.NativeMethodInfoPtr_set_IsDecimal_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr, 100666580);
				TypedObject.DecimalStruct.NativeMethodInfoPtr_get_Dvalue_Public_get_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr, 100666581);
				TypedObject.DecimalStruct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr, 100666582);
				TypedObject.DecimalStruct.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr, 100666583);
			}

			// Token: 0x17000F14 RID: 3860
			// (get) Token: 0x06002C34 RID: 11316 RVA: 0x000C5E0C File Offset: 0x000C400C
			// (set) Token: 0x06002C35 RID: 11317 RVA: 0x000C5E48 File Offset: 0x000C4048
			public unsafe bool IsDecimal
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.DecimalStruct.NativeMethodInfoPtr_get_IsDecimal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.DecimalStruct.NativeMethodInfoPtr_set_IsDecimal_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000F15 RID: 3861
			// (get) Token: 0x06002C36 RID: 11318 RVA: 0x000C5E88 File Offset: 0x000C4088
			public unsafe Il2CppStructArray<Decimal> Dvalue
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.DecimalStruct.NativeMethodInfoPtr_get_Dvalue_Public_get_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Decimal>>(intPtr3) : null;
				}
			}

			// Token: 0x06002C37 RID: 11319 RVA: 0x000C5EC8 File Offset: 0x000C40C8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 409099, RefRangeEnd = 409100, XrefRangeStart = 409096, XrefRangeEnd = 409099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecimalStruct()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.DecimalStruct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C38 RID: 11320 RVA: 0x000C5F04 File Offset: 0x000C4104
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409100, XrefRangeEnd = 409103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecimalStruct(int dim)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref dim;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.DecimalStruct.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C39 RID: 11321 RVA: 0x00012F65 File Offset: 0x00011165
			public DecimalStruct(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F12 RID: 3858
			// (get) Token: 0x06002C3A RID: 11322 RVA: 0x000C5F4C File Offset: 0x000C414C
			// (set) Token: 0x06002C3B RID: 11323 RVA: 0x00012F6E File Offset: 0x0001116E
			public unsafe bool isDecimal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.DecimalStruct.NativeFieldInfoPtr_isDecimal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.DecimalStruct.NativeFieldInfoPtr_isDecimal)) = value;
				}
			}

			// Token: 0x17000F13 RID: 3859
			// (get) Token: 0x06002C3C RID: 11324 RVA: 0x000C5F74 File Offset: 0x000C4174
			// (set) Token: 0x06002C3D RID: 11325 RVA: 0x00012F89 File Offset: 0x00011189
			public unsafe Il2CppStructArray<Decimal> dvalue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.DecimalStruct.NativeFieldInfoPtr_dvalue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Decimal>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.DecimalStruct.NativeFieldInfoPtr_dvalue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400227A RID: 8826
			private static readonly IntPtr NativeFieldInfoPtr_isDecimal;

			// Token: 0x0400227B RID: 8827
			private static readonly IntPtr NativeFieldInfoPtr_dvalue;

			// Token: 0x0400227C RID: 8828
			private static readonly IntPtr NativeMethodInfoPtr_get_IsDecimal_Public_get_Boolean_0;

			// Token: 0x0400227D RID: 8829
			private static readonly IntPtr NativeMethodInfoPtr_set_IsDecimal_Public_set_Void_Boolean_0;

			// Token: 0x0400227E RID: 8830
			private static readonly IntPtr NativeMethodInfoPtr_get_Dvalue_Public_get_Il2CppStructArray_1_Decimal_0;

			// Token: 0x0400227F RID: 8831
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002280 RID: 8832
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}
	}
}
