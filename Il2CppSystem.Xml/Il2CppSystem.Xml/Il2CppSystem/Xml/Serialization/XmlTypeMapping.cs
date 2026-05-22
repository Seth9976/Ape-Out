using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000EF RID: 239
	public class XmlTypeMapping : XmlMapping
	{
		// Token: 0x060013F4 RID: 5108 RVA: 0x000692AC File Offset: 0x000674AC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapping()
		{
			Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr);
			XmlTypeMapping.NativeFieldInfoPtr_xmlType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "xmlType");
			XmlTypeMapping.NativeFieldInfoPtr_xmlTypeNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "xmlTypeNamespace");
			XmlTypeMapping.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "type");
			XmlTypeMapping.NativeFieldInfoPtr_baseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "baseMap");
			XmlTypeMapping.NativeFieldInfoPtr_multiReferenceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "multiReferenceType");
			XmlTypeMapping.NativeFieldInfoPtr_includeInSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "includeInSchema");
			XmlTypeMapping.NativeFieldInfoPtr_isNullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "isNullable");
			XmlTypeMapping.NativeFieldInfoPtr_isAny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "isAny");
			XmlTypeMapping.NativeFieldInfoPtr__derivedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "_derivedTypes");
			XmlTypeMapping.NativeMethodInfoPtr__ctor_Internal_Void_String_String_TypeData_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666385);
			XmlTypeMapping.NativeMethodInfoPtr_get_TypeFullName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666386);
			XmlTypeMapping.NativeMethodInfoPtr_get_TypeData_Internal_get_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666387);
			XmlTypeMapping.NativeMethodInfoPtr_get_XmlType_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666388);
			XmlTypeMapping.NativeMethodInfoPtr_set_XmlType_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666389);
			XmlTypeMapping.NativeMethodInfoPtr_get_XmlTypeNamespace_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666390);
			XmlTypeMapping.NativeMethodInfoPtr_set_XmlTypeNamespace_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666391);
			XmlTypeMapping.NativeMethodInfoPtr_get_HasXmlTypeNamespace_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666392);
			XmlTypeMapping.NativeMethodInfoPtr_get_DerivedTypes_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666393);
			XmlTypeMapping.NativeMethodInfoPtr_get_MultiReferenceType_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666394);
			XmlTypeMapping.NativeMethodInfoPtr_get_BaseMap_Internal_get_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666395);
			XmlTypeMapping.NativeMethodInfoPtr_set_BaseMap_Internal_set_Void_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666396);
			XmlTypeMapping.NativeMethodInfoPtr_set_IncludeInSchema_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666397);
			XmlTypeMapping.NativeMethodInfoPtr_set_IsNullable_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666398);
			XmlTypeMapping.NativeMethodInfoPtr_get_IsAny_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666399);
			XmlTypeMapping.NativeMethodInfoPtr_set_IsAny_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666400);
			XmlTypeMapping.NativeMethodInfoPtr_GetRealTypeMap_Internal_XmlTypeMapping_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666401);
			XmlTypeMapping.NativeMethodInfoPtr_UpdateRoot_Internal_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666402);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x000694F8 File Offset: 0x000676F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407592, RefRangeEnd = 407594, XrefRangeStart = 407588, XrefRangeEnd = 407592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlTypeNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr__ctor_Internal_Void_String_String_TypeData_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x00069590 File Offset: 0x00067790
		public unsafe string TypeFullName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_TypeFullName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x000695C8 File Offset: 0x000677C8
		public unsafe TypeData TypeData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_TypeData_Internal_get_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x00069608 File Offset: 0x00067808
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x00069640 File Offset: 0x00067840
		public unsafe string XmlType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_XmlType_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_set_XmlType_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x00069684 File Offset: 0x00067884
		// (set) Token: 0x060013FB RID: 5115 RVA: 0x000696BC File Offset: 0x000678BC
		public unsafe string XmlTypeNamespace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 407596, RefRangeEnd = 407597, XrefRangeStart = 407594, XrefRangeEnd = 407596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_XmlTypeNamespace_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14747, RefRangeEnd = 14763, XrefRangeStart = 14747, XrefRangeEnd = 14763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_set_XmlTypeNamespace_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x00069700 File Offset: 0x00067900
		public unsafe bool HasXmlTypeNamespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_HasXmlTypeNamespace_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x0006973C File Offset: 0x0006793C
		public unsafe ArrayList DerivedTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_DerivedTypes_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0006977C File Offset: 0x0006797C
		public unsafe bool MultiReferenceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_MultiReferenceType_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x000697B8 File Offset: 0x000679B8
		// (set) Token: 0x06001400 RID: 5120 RVA: 0x000697F8 File Offset: 0x000679F8
		public unsafe XmlTypeMapping BaseMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_BaseMap_Internal_get_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 17925, RefRangeEnd = 17937, XrefRangeStart = 17925, XrefRangeEnd = 17937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_set_BaseMap_Internal_set_Void_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006AB RID: 1707
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x0006983C File Offset: 0x00067A3C
		public unsafe bool IncludeInSchema
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_set_IncludeInSchema_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006AC RID: 1708
		// (set) Token: 0x06001402 RID: 5122 RVA: 0x0006987C File Offset: 0x00067A7C
		public unsafe bool IsNullable
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_set_IsNullable_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x000698BC File Offset: 0x00067ABC
		// (set) Token: 0x06001404 RID: 5124 RVA: 0x000698F8 File Offset: 0x00067AF8
		public unsafe bool IsAny
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_IsAny_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_set_IsAny_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00069938 File Offset: 0x00067B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407597, XrefRangeEnd = 407605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping GetRealTypeMap(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_GetRealTypeMap_Internal_XmlTypeMapping_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00069988 File Offset: 0x00067B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407605, XrefRangeEnd = 407612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRoot(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_UpdateRoot_Internal_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x00008DEC File Offset: 0x00006FEC
		public XmlTypeMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x000699CC File Offset: 0x00067BCC
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x00008DF5 File Offset: 0x00006FF5
		public unsafe string xmlType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_xmlType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_xmlType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x000699F4 File Offset: 0x00067BF4
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x00008E14 File Offset: 0x00007014
		public unsafe string xmlTypeNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_xmlTypeNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_xmlTypeNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x00069A1C File Offset: 0x00067C1C
		// (set) Token: 0x0600140D RID: 5133 RVA: 0x00008E33 File Offset: 0x00007033
		public unsafe TypeData type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x00069A4C File Offset: 0x00067C4C
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x00008E52 File Offset: 0x00007052
		public unsafe XmlTypeMapping baseMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_baseMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_baseMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x00069A7C File Offset: 0x00067C7C
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x00008E71 File Offset: 0x00007071
		public unsafe bool multiReferenceType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_multiReferenceType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_multiReferenceType)) = value;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x00069AA4 File Offset: 0x00067CA4
		// (set) Token: 0x06001413 RID: 5139 RVA: 0x00008E8C File Offset: 0x0000708C
		public unsafe bool includeInSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_includeInSchema);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_includeInSchema)) = value;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x00069ACC File Offset: 0x00067CCC
		// (set) Token: 0x06001415 RID: 5141 RVA: 0x00008EA7 File Offset: 0x000070A7
		public unsafe bool isNullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_isNullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_isNullable)) = value;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x00069AF4 File Offset: 0x00067CF4
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x00008EC2 File Offset: 0x000070C2
		public unsafe bool isAny
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_isAny);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_isAny)) = value;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x00069B1C File Offset: 0x00067D1C
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x00008EDD File Offset: 0x000070DD
		public unsafe ArrayList _derivedTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr__derivedTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr__derivedTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeFieldInfoPtr_xmlType;

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeFieldInfoPtr_xmlTypeNamespace;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeFieldInfoPtr_baseMap;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeFieldInfoPtr_multiReferenceType;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeFieldInfoPtr_includeInSchema;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeFieldInfoPtr_isNullable;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeFieldInfoPtr_isAny;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeFieldInfoPtr__derivedTypes;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_TypeData_String_String_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeFullName_Public_get_String_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeData_Internal_get_TypeData_0;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Internal_get_String_0;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlType_Internal_set_Void_String_0;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlTypeNamespace_Internal_get_String_0;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlTypeNamespace_Internal_set_Void_String_0;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeMethodInfoPtr_get_HasXmlTypeNamespace_Internal_get_Boolean_0;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeMethodInfoPtr_get_DerivedTypes_Internal_get_ArrayList_0;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeMethodInfoPtr_get_MultiReferenceType_Internal_get_Boolean_0;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseMap_Internal_get_XmlTypeMapping_0;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseMap_Internal_set_Void_XmlTypeMapping_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr_set_IncludeInSchema_Internal_set_Void_Boolean_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr_set_IsNullable_Internal_set_Void_Boolean_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAny_Internal_get_Boolean_0;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAny_Internal_set_Void_Boolean_0;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeMethodInfoPtr_GetRealTypeMap_Internal_XmlTypeMapping_Type_0;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRoot_Internal_Void_XmlQualifiedName_0;
	}
}
