using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000DF RID: 223
	public class XmlSerializationWriterInterpreter : XmlSerializationWriter
	{
		// Token: 0x06001303 RID: 4867 RVA: 0x00065A34 File Offset: 0x00063C34
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializationWriterInterpreter()
		{
			Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializationWriterInterpreter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr);
			XmlSerializationWriterInterpreter.NativeFieldInfoPtr__typeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, "_typeMap");
			XmlSerializationWriterInterpreter.NativeFieldInfoPtr__format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, "_format");
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr__ctor_Public_Void_XmlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666265);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_InitCallbacks_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666266);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteRoot_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666267);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteObject_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666268);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteMessage_Protected_Virtual_New_Void_XmlMembersMapping_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666269);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteObjectElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666270);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteObjectElementAttributes_Protected_Virtual_New_Void_XmlTypeMapping_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666271);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteObjectElementElements_Protected_Virtual_New_Void_XmlTypeMapping_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666272);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteMembers_Private_Void_ClassMap_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666273);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteAttributeMembers_Private_Void_ClassMap_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666274);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteElementMembers_Private_Void_ClassMap_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666275);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_GetMemberValue_Private_Object_XmlTypeMapMember_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666276);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_MemberHasValue_Private_Boolean_XmlTypeMapMember_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666277);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteMemberElement_Private_Void_XmlTypeMapElementInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666278);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_ImplicitConvert_Internal_Static_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666279);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WritePrimitiveValueLiteral_Private_Void_Object_String_String_XmlTypeMapping_TypeData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666280);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WritePrimitiveValueEncoded_Private_Void_Object_String_String_XmlQualifiedName_XmlTypeMapping_TypeData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666281);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteListElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666282);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteListContent_Private_Void_Object_TypeData_ListMap_Object_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666283);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_GetListCount_Private_Int32_TypeData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666284);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteAnyElementContent_Private_Void_XmlTypeMapMemberAnyElement_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666285);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WritePrimitiveElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666286);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteEnumElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666287);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_GetStringValue_Private_String_XmlTypeMapping_TypeData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666288);
			XmlSerializationWriterInterpreter.NativeMethodInfoPtr_GetEnumXmlValue_Private_String_XmlTypeMapping_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, 100666289);
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00065C80 File Offset: 0x00063E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406727, XrefRangeEnd = 406731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializationWriterInterpreter(XmlMapping typeMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr__ctor_Public_Void_XmlMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00065CCC File Offset: 0x00063ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406731, XrefRangeEnd = 406760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_InitCallbacks_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00065D08 File Offset: 0x00063F08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 406781, RefRangeEnd = 406782, XrefRangeStart = 406760, XrefRangeEnd = 406781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteRoot(Object ob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteRoot_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00065D4C File Offset: 0x00063F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406782, XrefRangeEnd = 406832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteObject(XmlTypeMapping typeMap, Object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(element);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namesp);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeWrappingElem;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteObject_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00065DFC File Offset: 0x00063FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406832, XrefRangeEnd = 406850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteMessage(XmlMembersMapping membersMap, Il2CppReferenceArray<Object> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(membersMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteMessage_Protected_Virtual_New_Void_XmlMembersMapping_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00065E5C File Offset: 0x0006405C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406850, XrefRangeEnd = 406860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteObjectElement(XmlTypeMapping typeMap, Object ob, string element, string namesp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(element);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namesp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteObjectElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00065EE0 File Offset: 0x000640E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406860, XrefRangeEnd = 406863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, Object ob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteObjectElementAttributes_Protected_Virtual_New_Void_XmlTypeMapping_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00065F40 File Offset: 0x00064140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406863, XrefRangeEnd = 406866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteObjectElementElements(XmlTypeMapping typeMap, Object ob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteObjectElementElements_Protected_Virtual_New_Void_XmlTypeMapping_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00065FA0 File Offset: 0x000641A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406866, XrefRangeEnd = 406868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMembers(ClassMap map, Object ob, bool isValueList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValueList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteMembers_Private_Void_ClassMap_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00066004 File Offset: 0x00064204
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 406915, RefRangeEnd = 406918, XrefRangeStart = 406868, XrefRangeEnd = 406915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAttributeMembers(ClassMap map, Object ob, bool isValueList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValueList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteAttributeMembers_Private_Void_ClassMap_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00066068 File Offset: 0x00064268
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 406983, RefRangeEnd = 406986, XrefRangeStart = 406918, XrefRangeEnd = 406983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteElementMembers(ClassMap map, Object ob, bool isValueList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValueList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteElementMembers_Private_Void_ClassMap_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x000660CC File Offset: 0x000642CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 406992, RefRangeEnd = 406995, XrefRangeStart = 406986, XrefRangeEnd = 406992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetMemberValue(XmlTypeMapMember member, Object ob, bool isValueList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValueList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_GetMemberValue_Private_Object_XmlTypeMapMember_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0006613C File Offset: 0x0006433C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 407003, RefRangeEnd = 407006, XrefRangeStart = 406995, XrefRangeEnd = 407003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MemberHasValue(XmlTypeMapMember member, Object ob, bool isValueList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValueList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_MemberHasValue_Private_Boolean_XmlTypeMapMember_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x000661AC File Offset: 0x000643AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 407028, RefRangeEnd = 407033, XrefRangeStart = 407006, XrefRangeEnd = 407028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMemberElement(XmlTypeMapElementInfo elem, Object memberValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteMemberElement_Private_Void_XmlTypeMapElementInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00066200 File Offset: 0x00064400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407070, RefRangeEnd = 407071, XrefRangeStart = 407033, XrefRangeEnd = 407070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ImplicitConvert(Object obj, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_ImplicitConvert_Internal_Static_Object_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00066258 File Offset: 0x00064458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407084, RefRangeEnd = 407085, XrefRangeStart = 407071, XrefRangeEnd = 407084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WritePrimitiveValueLiteral(Object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mappedType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapped;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WritePrimitiveValueLiteral_Private_Void_Object_String_String_XmlTypeMapping_TypeData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00066300 File Offset: 0x00064500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407098, RefRangeEnd = 407099, XrefRangeStart = 407085, XrefRangeEnd = 407098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WritePrimitiveValueEncoded(Object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xsiType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mappedType);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapped;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WritePrimitiveValueEncoded_Private_Void_Object_String_String_XmlQualifiedName_XmlTypeMapping_TypeData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x000663BC File Offset: 0x000645BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407099, XrefRangeEnd = 407118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteListElement(XmlTypeMapping typeMap, Object ob, string element, string namesp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(element);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namesp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteListElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00066440 File Offset: 0x00064640
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 407177, RefRangeEnd = 407180, XrefRangeStart = 407118, XrefRangeEnd = 407177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteListContent(Object container, TypeData listType, ListMap map, Object ob, StringBuilder targetString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(map);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteListContent_Private_Void_Object_TypeData_ListMap_Object_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x000664CC File Offset: 0x000646CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407185, RefRangeEnd = 407186, XrefRangeStart = 407180, XrefRangeEnd = 407185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetListCount(TypeData listType, Object ob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_GetListCount_Private_Int32_TypeData_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0006652C File Offset: 0x0006472C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407250, RefRangeEnd = 407251, XrefRangeStart = 407186, XrefRangeEnd = 407250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, Object memberValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteAnyElementContent_Private_Void_XmlTypeMapMemberAnyElement_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00066580 File Offset: 0x00064780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407251, XrefRangeEnd = 407253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WritePrimitiveElement(XmlTypeMapping typeMap, Object ob, string element, string namesp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(element);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namesp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WritePrimitiveElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00066604 File Offset: 0x00064804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407253, XrefRangeEnd = 407259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteEnumElement(XmlTypeMapping typeMap, Object ob, string element, string namesp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(element);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namesp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializationWriterInterpreter.NativeMethodInfoPtr_WriteEnumElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00066688 File Offset: 0x00064888
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 407272, RefRangeEnd = 407278, XrefRangeStart = 407259, XrefRangeEnd = 407272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringValue(XmlTypeMapping typeMap, TypeData type, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_GetStringValue_Private_String_XmlTypeMapping_TypeData_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x000666F4 File Offset: 0x000648F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407278, XrefRangeEnd = 407281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetEnumXmlValue(XmlTypeMapping typeMap, Object ob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ob);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.NativeMethodInfoPtr_GetEnumXmlValue_Private_String_XmlTypeMapping_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00008728 File Offset: 0x00006928
		public XmlSerializationWriterInterpreter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x00066750 File Offset: 0x00064950
		// (set) Token: 0x0600131F RID: 4895 RVA: 0x00008731 File Offset: 0x00006931
		public unsafe XmlMapping _typeMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriterInterpreter.NativeFieldInfoPtr__typeMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlMapping>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriterInterpreter.NativeFieldInfoPtr__typeMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x00066780 File Offset: 0x00064980
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x00008750 File Offset: 0x00006950
		public unsafe SerializationFormat _format
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriterInterpreter.NativeFieldInfoPtr__format);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriterInterpreter.NativeFieldInfoPtr__format)) = value;
			}
		}

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeFieldInfoPtr__typeMap;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeFieldInfoPtr__format;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlMapping_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_InitCallbacks_Protected_Virtual_Void_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_WriteRoot_Public_Void_Object_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_WriteObject_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_Boolean_Boolean_Boolean_0;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr_WriteMessage_Protected_Virtual_New_Void_XmlMembersMapping_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectElementAttributes_Protected_Virtual_New_Void_XmlTypeMapping_Object_0;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectElementElements_Protected_Virtual_New_Void_XmlTypeMapping_Object_0;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr_WriteMembers_Private_Void_ClassMap_Object_Boolean_0;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeMethodInfoPtr_WriteAttributeMembers_Private_Void_ClassMap_Object_Boolean_0;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeMethodInfoPtr_WriteElementMembers_Private_Void_ClassMap_Object_Boolean_0;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberValue_Private_Object_XmlTypeMapMember_Object_Boolean_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr_MemberHasValue_Private_Boolean_XmlTypeMapMember_Object_Boolean_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr_WriteMemberElement_Private_Void_XmlTypeMapElementInfo_Object_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_ImplicitConvert_Internal_Static_Object_Object_Type_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_WritePrimitiveValueLiteral_Private_Void_Object_String_String_XmlTypeMapping_TypeData_Boolean_Boolean_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_WritePrimitiveValueEncoded_Private_Void_Object_String_String_XmlQualifiedName_XmlTypeMapping_TypeData_Boolean_Boolean_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_WriteListElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_WriteListContent_Private_Void_Object_TypeData_ListMap_Object_StringBuilder_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_GetListCount_Private_Int32_TypeData_Object_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_WriteAnyElementContent_Private_Void_XmlTypeMapMemberAnyElement_Object_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_WritePrimitiveElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_WriteEnumElement_Protected_Virtual_New_Void_XmlTypeMapping_Object_String_String_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_GetStringValue_Private_String_XmlTypeMapping_TypeData_Object_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumXmlValue_Private_String_XmlTypeMapping_Object_0;

		// Token: 0x0200022A RID: 554
		public class CallbackInfo : Object
		{
			// Token: 0x06002C15 RID: 11285 RVA: 0x000C57E8 File Offset: 0x000C39E8
			// Note: this type is marked as 'beforefieldinit'.
			static CallbackInfo()
			{
				Il2CppClassPointerStore<XmlSerializationWriterInterpreter.CallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSerializationWriterInterpreter>.NativeClassPtr, "CallbackInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializationWriterInterpreter.CallbackInfo>.NativeClassPtr);
				XmlSerializationWriterInterpreter.CallbackInfo.NativeFieldInfoPtr__swi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriterInterpreter.CallbackInfo>.NativeClassPtr, "_swi");
				XmlSerializationWriterInterpreter.CallbackInfo.NativeFieldInfoPtr__typeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializationWriterInterpreter.CallbackInfo>.NativeClassPtr, "_typeMap");
				XmlSerializationWriterInterpreter.CallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_XmlSerializationWriterInterpreter_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter.CallbackInfo>.NativeClassPtr, 100666290);
				XmlSerializationWriterInterpreter.CallbackInfo.NativeMethodInfoPtr_WriteObject_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter.CallbackInfo>.NativeClassPtr, 100666291);
				XmlSerializationWriterInterpreter.CallbackInfo.NativeMethodInfoPtr_WriteEnum_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationWriterInterpreter.CallbackInfo>.NativeClassPtr, 100666292);
			}

			// Token: 0x06002C16 RID: 11286 RVA: 0x000C5878 File Offset: 0x000C3A78
			[CallerCount(76)]
			[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CallbackInfo(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationWriterInterpreter.CallbackInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(swi);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.CallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_XmlSerializationWriterInterpreter_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C17 RID: 11287 RVA: 0x000C58D8 File Offset: 0x000C3AD8
			[CallerCount(0)]
			public unsafe void WriteObject(Object ob)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.CallbackInfo.NativeMethodInfoPtr_WriteObject_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C18 RID: 11288 RVA: 0x000C591C File Offset: 0x000C3B1C
			[CallerCount(0)]
			public unsafe void WriteEnum(Object ob)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationWriterInterpreter.CallbackInfo.NativeMethodInfoPtr_WriteEnum_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C19 RID: 11289 RVA: 0x00012E56 File Offset: 0x00011056
			public CallbackInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F07 RID: 3847
			// (get) Token: 0x06002C1A RID: 11290 RVA: 0x000C5960 File Offset: 0x000C3B60
			// (set) Token: 0x06002C1B RID: 11291 RVA: 0x00012E5F File Offset: 0x0001105F
			public unsafe XmlSerializationWriterInterpreter _swi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriterInterpreter.CallbackInfo.NativeFieldInfoPtr__swi);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSerializationWriterInterpreter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriterInterpreter.CallbackInfo.NativeFieldInfoPtr__swi), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F08 RID: 3848
			// (get) Token: 0x06002C1C RID: 11292 RVA: 0x000C5990 File Offset: 0x000C3B90
			// (set) Token: 0x06002C1D RID: 11293 RVA: 0x00012E7E File Offset: 0x0001107E
			public unsafe XmlTypeMapping _typeMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriterInterpreter.CallbackInfo.NativeFieldInfoPtr__typeMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializationWriterInterpreter.CallbackInfo.NativeFieldInfoPtr__typeMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002266 RID: 8806
			private static readonly IntPtr NativeFieldInfoPtr__swi;

			// Token: 0x04002267 RID: 8807
			private static readonly IntPtr NativeFieldInfoPtr__typeMap;

			// Token: 0x04002268 RID: 8808
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSerializationWriterInterpreter_XmlTypeMapping_0;

			// Token: 0x04002269 RID: 8809
			private static readonly IntPtr NativeMethodInfoPtr_WriteObject_Internal_Void_Object_0;

			// Token: 0x0400226A RID: 8810
			private static readonly IntPtr NativeMethodInfoPtr_WriteEnum_Internal_Void_Object_0;
		}
	}
}
