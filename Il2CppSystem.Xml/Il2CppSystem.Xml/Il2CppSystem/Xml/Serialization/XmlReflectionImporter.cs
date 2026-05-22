using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D8 RID: 216
	public class XmlReflectionImporter : Object
	{
		// Token: 0x0600125E RID: 4702 RVA: 0x000628A8 File Offset: 0x00060AA8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlReflectionImporter()
		{
			Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlReflectionImporter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr);
			XmlReflectionImporter.NativeFieldInfoPtr_initialDefaultNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "initialDefaultNamespace");
			XmlReflectionImporter.NativeFieldInfoPtr_attributeOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "attributeOverrides");
			XmlReflectionImporter.NativeFieldInfoPtr_includedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "includedTypes");
			XmlReflectionImporter.NativeFieldInfoPtr_helper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "helper");
			XmlReflectionImporter.NativeFieldInfoPtr_arrayChoiceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "arrayChoiceCount");
			XmlReflectionImporter.NativeFieldInfoPtr_relatedMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "relatedMaps");
			XmlReflectionImporter.NativeFieldInfoPtr_allowPrivateTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "allowPrivateTypes");
			XmlReflectionImporter.NativeFieldInfoPtr_errSimple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "errSimple");
			XmlReflectionImporter.NativeFieldInfoPtr_errSimple2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "errSimple2");
			XmlReflectionImporter.NativeMethodInfoPtr__ctor_Public_Void_XmlAttributeOverrides_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666166);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666167);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666168);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666169);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666170);
			XmlReflectionImporter.NativeMethodInfoPtr_CreateTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666171);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666172);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666173);
			XmlReflectionImporter.NativeMethodInfoPtr_RegisterDerivedMap_Private_Void_XmlTypeMapping_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666174);
			XmlReflectionImporter.NativeMethodInfoPtr_GetTypeNamespace_Private_String_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666175);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_XmlAttributes_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666176);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_XmlAttributes_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666177);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportXmlNodeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666178);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportPrimitiveMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666179);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportEnumMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666180);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportXmlSerializableMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666181);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportIncludedTypes_Private_Void_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666182);
			XmlReflectionImporter.NativeMethodInfoPtr_GetReflectionMembers_Private_List_1_XmlReflectionMember_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666183);
			XmlReflectionImporter.NativeMethodInfoPtr_CreateMapMember_Private_XmlTypeMapMember_Type_XmlReflectionMember_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666184);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportElementInfo_Private_XmlTypeMapElementInfoList_Type_String_String_Type_XmlTypeMapMemberElement_XmlAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666185);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportAnyElementInfo_Private_XmlTypeMapElementInfoList_String_XmlReflectionMember_XmlTypeMapMemberElement_XmlAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666186);
			XmlReflectionImporter.NativeMethodInfoPtr_ImportTextElementInfo_Private_Void_XmlTypeMapElementInfoList_Type_XmlTypeMapMemberElement_XmlAttributes_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666187);
			XmlReflectionImporter.NativeMethodInfoPtr_CanBeNull_Private_Boolean_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666188);
			XmlReflectionImporter.NativeMethodInfoPtr_IncludeType_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666189);
			XmlReflectionImporter.NativeMethodInfoPtr_GetDefaultValue_Private_Object_TypeData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, 100666190);
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00062B80 File Offset: 0x00060D80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 405098, RefRangeEnd = 405099, XrefRangeStart = 405073, XrefRangeEnd = 405098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReflectionImporter(XmlAttributeOverrides attributeOverrides, string defaultNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeOverrides);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr__ctor_Public_Void_XmlAttributeOverrides_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00062BE0 File Offset: 0x00060DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 405099, XrefRangeEnd = 405100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportTypeMapping(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
			}
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00062C30 File Offset: 0x00060E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 405100, XrefRangeEnd = 405101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00062C94 File Offset: 0x00060E94
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 405130, RefRangeEnd = 405147, XrefRangeStart = 405101, XrefRangeEnd = 405130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00062D08 File Offset: 0x00060F08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 405169, RefRangeEnd = 405170, XrefRangeStart = 405147, XrefRangeEnd = 405169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00062D7C File Offset: 0x00060F7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 405216, RefRangeEnd = 405221, XrefRangeStart = 405170, XrefRangeEnd = 405216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultXmlType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_CreateTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00062E04 File Offset: 0x00061004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 405230, RefRangeEnd = 405232, XrefRangeStart = 405221, XrefRangeEnd = 405230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBaseType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00062E88 File Offset: 0x00061088
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 405378, RefRangeEnd = 405380, XrefRangeStart = 405232, XrefRangeEnd = 405378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBaseType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00062F0C File Offset: 0x0006110C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 405388, RefRangeEnd = 405391, XrefRangeStart = 405380, XrefRangeEnd = 405388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(derivedMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_RegisterDerivedMap_Private_Void_XmlTypeMapping_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00062F60 File Offset: 0x00061160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 405399, RefRangeEnd = 405400, XrefRangeStart = 405391, XrefRangeEnd = 405399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_GetTypeNamespace_Private_String_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00062FCC File Offset: 0x000611CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 405409, RefRangeEnd = 405412, XrefRangeStart = 405400, XrefRangeEnd = 405409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(atts);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nestingLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_XmlAttributes_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00063064 File Offset: 0x00061264
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 405549, RefRangeEnd = 405551, XrefRangeStart = 405412, XrefRangeEnd = 405549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(atts);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nestingLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_XmlAttributes_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x000630FC File Offset: 0x000612FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 405575, RefRangeEnd = 405576, XrefRangeStart = 405551, XrefRangeEnd = 405575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportXmlNodeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00063170 File Offset: 0x00061370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 405589, RefRangeEnd = 405590, XrefRangeStart = 405576, XrefRangeEnd = 405589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportPrimitiveMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x000631E4 File Offset: 0x000613E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 405667, RefRangeEnd = 405668, XrefRangeStart = 405590, XrefRangeEnd = 405667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportEnumMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00063258 File Offset: 0x00061458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 405685, RefRangeEnd = 405686, XrefRangeStart = 405668, XrefRangeEnd = 405685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportXmlSerializableMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x000632CC File Offset: 0x000614CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 405686, XrefRangeEnd = 405697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportIncludedTypes(Type type, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportIncludedTypes_Private_Void_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00063320 File Offset: 0x00061520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 405798, RefRangeEnd = 405799, XrefRangeStart = 405697, XrefRangeEnd = 405798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<XmlReflectionMember> GetReflectionMembers(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_GetReflectionMembers_Private_List_1_XmlReflectionMember_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<XmlReflectionMember>>(intPtr3) : null;
			}
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00063370 File Offset: 0x00061570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 405930, RefRangeEnd = 405931, XrefRangeStart = 405799, XrefRangeEnd = 405930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(declaringType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rmember);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_CreateMapMember_Private_XmlTypeMapMember_Type_XmlReflectionMember_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMember>(intPtr3) : null;
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x000633E4 File Offset: 0x000615E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 406020, RefRangeEnd = 406022, XrefRangeStart = 405931, XrefRangeEnd = 406020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cls);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(atts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportElementInfo_Private_XmlTypeMapElementInfoList_Type_String_String_Type_XmlTypeMapMemberElement_XmlAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfoList>(intPtr3) : null;
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00063494 File Offset: 0x00061694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 406073, RefRangeEnd = 406074, XrefRangeStart = 406022, XrefRangeEnd = 406073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rmember);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(atts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportAnyElementInfo_Private_XmlTypeMapElementInfoList_String_XmlReflectionMember_XmlTypeMapMemberElement_XmlAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfoList>(intPtr3) : null;
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0006351C File Offset: 0x0006171C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 406112, RefRangeEnd = 406114, XrefRangeStart = 406074, XrefRangeEnd = 406112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(atts);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_ImportTextElementInfo_Private_Void_XmlTypeMapElementInfoList_Type_XmlTypeMapMemberElement_XmlAttributes_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x000635A8 File Offset: 0x000617A8
		[CallerCount(0)]
		public unsafe bool CanBeNull(TypeData type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_CanBeNull_Private_Boolean_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x000635F8 File Offset: 0x000617F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 406142, RefRangeEnd = 406143, XrefRangeStart = 406114, XrefRangeEnd = 406142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncludeType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_IncludeType_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0006363C File Offset: 0x0006183C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 406156, RefRangeEnd = 406160, XrefRangeStart = 406143, XrefRangeEnd = 406156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetDefaultValue(TypeData typeData, Object defaultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.NativeMethodInfoPtr_GetDefaultValue_Private_Object_TypeData_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0000837A File Offset: 0x0000657A
		public XmlReflectionImporter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x000636A0 File Offset: 0x000618A0
		// (set) Token: 0x0600127A RID: 4730 RVA: 0x00008383 File Offset: 0x00006583
		public unsafe string initialDefaultNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_initialDefaultNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_initialDefaultNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x000636C8 File Offset: 0x000618C8
		// (set) Token: 0x0600127C RID: 4732 RVA: 0x000083A2 File Offset: 0x000065A2
		public unsafe XmlAttributeOverrides attributeOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_attributeOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlAttributeOverrides>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_attributeOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x000636F8 File Offset: 0x000618F8
		// (set) Token: 0x0600127E RID: 4734 RVA: 0x000083C1 File Offset: 0x000065C1
		public unsafe ArrayList includedTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_includedTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_includedTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x00063728 File Offset: 0x00061928
		// (set) Token: 0x06001280 RID: 4736 RVA: 0x000083E0 File Offset: 0x000065E0
		public unsafe ReflectionHelper helper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_helper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_helper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x00063758 File Offset: 0x00061958
		// (set) Token: 0x06001282 RID: 4738 RVA: 0x000083FF File Offset: 0x000065FF
		public unsafe int arrayChoiceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_arrayChoiceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_arrayChoiceCount)) = value;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x00063780 File Offset: 0x00061980
		// (set) Token: 0x06001284 RID: 4740 RVA: 0x0000841A File Offset: 0x0000661A
		public unsafe ArrayList relatedMaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_relatedMaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_relatedMaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x000637B0 File Offset: 0x000619B0
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x00008439 File Offset: 0x00006639
		public unsafe bool allowPrivateTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_allowPrivateTypes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionImporter.NativeFieldInfoPtr_allowPrivateTypes)) = value;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x000637D8 File Offset: 0x000619D8
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x00008454 File Offset: 0x00006654
		public unsafe static string errSimple
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlReflectionImporter.NativeFieldInfoPtr_errSimple, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlReflectionImporter.NativeFieldInfoPtr_errSimple, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x000637F8 File Offset: 0x000619F8
		// (set) Token: 0x0600128A RID: 4746 RVA: 0x00008466 File Offset: 0x00006666
		public unsafe static string errSimple2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlReflectionImporter.NativeFieldInfoPtr_errSimple2, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlReflectionImporter.NativeFieldInfoPtr_errSimple2, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeFieldInfoPtr_initialDefaultNamespace;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeFieldInfoPtr_attributeOverrides;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeFieldInfoPtr_includedTypes;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeFieldInfoPtr_helper;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeFieldInfoPtr_arrayChoiceCount;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeFieldInfoPtr_relatedMaps;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeFieldInfoPtr_allowPrivateTypes;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeFieldInfoPtr_errSimple;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeFieldInfoPtr_errSimple2;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlAttributeOverrides_String_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_String_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_ImportTypeMapping_Public_XmlTypeMapping_Type_XmlRootAttribute_String_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_ImportTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_CreateTypeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_String_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_Boolean_0;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr_ImportClassMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_Boolean_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDerivedMap_Private_Void_XmlTypeMapping_XmlTypeMapping_0;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeNamespace_Private_String_TypeData_XmlRootAttribute_String_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_Type_XmlRootAttribute_String_XmlAttributes_Int32_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_ImportListMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_XmlAttributes_Int32_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_ImportXmlNodeMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_ImportPrimitiveMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_ImportEnumMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_ImportXmlSerializableMapping_Private_XmlTypeMapping_TypeData_XmlRootAttribute_String_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_ImportIncludedTypes_Private_Void_Type_String_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_GetReflectionMembers_Private_List_1_XmlReflectionMember_Type_0;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr_CreateMapMember_Private_XmlTypeMapMember_Type_XmlReflectionMember_String_0;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeMethodInfoPtr_ImportElementInfo_Private_XmlTypeMapElementInfoList_Type_String_String_Type_XmlTypeMapMemberElement_XmlAttributes_0;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeMethodInfoPtr_ImportAnyElementInfo_Private_XmlTypeMapElementInfoList_String_XmlReflectionMember_XmlTypeMapMemberElement_XmlAttributes_0;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeMethodInfoPtr_ImportTextElementInfo_Private_Void_XmlTypeMapElementInfoList_Type_XmlTypeMapMemberElement_XmlAttributes_String_0;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeMethodInfoPtr_CanBeNull_Private_Boolean_TypeData_0;

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeMethodInfoPtr_IncludeType_Public_Void_Type_0;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultValue_Private_Object_TypeData_Object_0;

		// Token: 0x02000228 RID: 552
		[ObfuscatedName("System.Xml.Serialization.XmlReflectionImporter+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002C02 RID: 11266 RVA: 0x000C5504 File Offset: 0x000C3704
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<XmlReflectionImporter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlReflectionImporter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlReflectionImporter.__c>.NativeClassPtr);
				XmlReflectionImporter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter.__c>.NativeClassPtr, "<>9");
				XmlReflectionImporter.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionImporter.__c>.NativeClassPtr, "<>9__28_0");
				XmlReflectionImporter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter.__c>.NativeClassPtr, 100666193);
				XmlReflectionImporter.__c.NativeMethodInfoPtr__ImportClassMapping_b__28_0_Internal_Int32_XmlReflectionMember_XmlReflectionMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionImporter.__c>.NativeClassPtr, 100666194);
			}

			// Token: 0x06002C03 RID: 11267 RVA: 0x000C5580 File Offset: 0x000C3780
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlReflectionImporter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C04 RID: 11268 RVA: 0x000C55BC File Offset: 0x000C37BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 405069, XrefRangeEnd = 405073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ImportClassMapping_b__28_0(XmlReflectionMember m1, XmlReflectionMember m2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionImporter.__c.NativeMethodInfoPtr__ImportClassMapping_b__28_0_Internal_Int32_XmlReflectionMember_XmlReflectionMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002C05 RID: 11269 RVA: 0x00012DA4 File Offset: 0x00010FA4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F01 RID: 3841
			// (get) Token: 0x06002C06 RID: 11270 RVA: 0x000C561C File Offset: 0x000C381C
			// (set) Token: 0x06002C07 RID: 11271 RVA: 0x00012DAD File Offset: 0x00010FAD
			public unsafe static XmlReflectionImporter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XmlReflectionImporter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReflectionImporter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XmlReflectionImporter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F02 RID: 3842
			// (get) Token: 0x06002C08 RID: 11272 RVA: 0x000C5644 File Offset: 0x000C3844
			// (set) Token: 0x06002C09 RID: 11273 RVA: 0x00012DBF File Offset: 0x00010FBF
			public unsafe static Comparison<XmlReflectionMember> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XmlReflectionImporter.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<XmlReflectionMember>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XmlReflectionImporter.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400225D RID: 8797
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400225E RID: 8798
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x0400225F RID: 8799
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002260 RID: 8800
			private static readonly IntPtr NativeMethodInfoPtr__ImportClassMapping_b__28_0_Internal_Int32_XmlReflectionMember_XmlReflectionMember_0;
		}
	}
}
