using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000178 RID: 376
	public sealed class SchemaEntity : Object
	{
		// Token: 0x06001CB4 RID: 7348 RVA: 0x0008C42C File Offset: 0x0008A62C
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaEntity()
		{
			Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr);
			SchemaEntity.NativeFieldInfoPtr_qname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "qname");
			SchemaEntity.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "url");
			SchemaEntity.NativeFieldInfoPtr_pubid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "pubid");
			SchemaEntity.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "text");
			SchemaEntity.NativeFieldInfoPtr_ndata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "ndata");
			SchemaEntity.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "lineNumber");
			SchemaEntity.NativeFieldInfoPtr_linePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "linePosition");
			SchemaEntity.NativeFieldInfoPtr_isParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "isParameter");
			SchemaEntity.NativeFieldInfoPtr_isExternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "isExternal");
			SchemaEntity.NativeFieldInfoPtr_parsingInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "parsingInProgress");
			SchemaEntity.NativeFieldInfoPtr_isDeclaredInExternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "isDeclaredInExternal");
			SchemaEntity.NativeFieldInfoPtr_baseURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "baseURI");
			SchemaEntity.NativeFieldInfoPtr_declaredURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "declaredURI");
			SchemaEntity.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667547);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Name_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667548);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsExternal_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667549);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667550);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsUnparsedEntity_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667551);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsParameterEntity_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667552);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_BaseUriString_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667553);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_DeclaredUriString_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667554);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_SystemId_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667555);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_PublicId_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667556);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Text_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667557);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667558);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667559);
			SchemaEntity.NativeMethodInfoPtr_IsPredefinedEntity_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667560);
			SchemaEntity.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667561);
			SchemaEntity.NativeMethodInfoPtr_get_Url_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667562);
			SchemaEntity.NativeMethodInfoPtr_set_Url_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667563);
			SchemaEntity.NativeMethodInfoPtr_get_Pubid_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667564);
			SchemaEntity.NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667565);
			SchemaEntity.NativeMethodInfoPtr_get_IsExternal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667566);
			SchemaEntity.NativeMethodInfoPtr_set_IsExternal_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667567);
			SchemaEntity.NativeMethodInfoPtr_get_DeclaredInExternal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667568);
			SchemaEntity.NativeMethodInfoPtr_set_DeclaredInExternal_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667569);
			SchemaEntity.NativeMethodInfoPtr_get_NData_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667570);
			SchemaEntity.NativeMethodInfoPtr_set_NData_Internal_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667571);
			SchemaEntity.NativeMethodInfoPtr_get_Text_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667572);
			SchemaEntity.NativeMethodInfoPtr_set_Text_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667573);
			SchemaEntity.NativeMethodInfoPtr_get_Line_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667574);
			SchemaEntity.NativeMethodInfoPtr_set_Line_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667575);
			SchemaEntity.NativeMethodInfoPtr_get_Pos_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667576);
			SchemaEntity.NativeMethodInfoPtr_set_Pos_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667577);
			SchemaEntity.NativeMethodInfoPtr_get_BaseURI_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667578);
			SchemaEntity.NativeMethodInfoPtr_set_BaseURI_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667579);
			SchemaEntity.NativeMethodInfoPtr_get_ParsingInProgress_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667580);
			SchemaEntity.NativeMethodInfoPtr_set_ParsingInProgress_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667581);
			SchemaEntity.NativeMethodInfoPtr_get_DeclaredURI_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667582);
			SchemaEntity.NativeMethodInfoPtr_set_DeclaredURI_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100667583);
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0008C844 File Offset: 0x0008AA44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 420261, RefRangeEnd = 420264, XrefRangeStart = 420257, XrefRangeEnd = 420261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaEntity(XmlQualifiedName qname, bool isParameter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isParameter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x0008C8A0 File Offset: 0x0008AAA0
		public unsafe string System.Xml.IDtdEntityInfo.Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Name_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001CB7 RID: 7351 RVA: 0x0008C8D8 File Offset: 0x0008AAD8
		public unsafe bool System.Xml.IDtdEntityInfo.IsExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsExternal_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x0008C914 File Offset: 0x0008AB14
		public unsafe bool System.Xml.IDtdEntityInfo.IsDeclaredInExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x0008C950 File Offset: 0x0008AB50
		public unsafe bool System.Xml.IDtdEntityInfo.IsUnparsedEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsUnparsedEntity_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x0008C98C File Offset: 0x0008AB8C
		public unsafe bool System.Xml.IDtdEntityInfo.IsParameterEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsParameterEntity_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x0008C9C8 File Offset: 0x0008ABC8
		public unsafe string System.Xml.IDtdEntityInfo.BaseUriString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 420264, XrefRangeEnd = 420266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_BaseUriString_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x0008CA00 File Offset: 0x0008AC00
		public unsafe string System.Xml.IDtdEntityInfo.DeclaredUriString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 420266, XrefRangeEnd = 420268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_DeclaredUriString_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x0008CA38 File Offset: 0x0008AC38
		public unsafe string System.Xml.IDtdEntityInfo.SystemId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_SystemId_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x0008CA70 File Offset: 0x0008AC70
		public unsafe string System.Xml.IDtdEntityInfo.PublicId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_PublicId_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x0008CAA8 File Offset: 0x0008ACA8
		public unsafe string System.Xml.IDtdEntityInfo.Text
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Text_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x0008CAE0 File Offset: 0x0008ACE0
		public unsafe int System.Xml.IDtdEntityInfo.LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x0008CB1C File Offset: 0x0008AD1C
		public unsafe int System.Xml.IDtdEntityInfo.LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x0008CB58 File Offset: 0x0008AD58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 420278, RefRangeEnd = 420279, XrefRangeStart = 420268, XrefRangeEnd = 420278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPredefinedEntity(string n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_IsPredefinedEntity_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x0008CB9C File Offset: 0x0008AD9C
		public unsafe XmlQualifiedName Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x0008CBDC File Offset: 0x0008ADDC
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x0008CC14 File Offset: 0x0008AE14
		public unsafe string Url
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Url_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_Url_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x0008CC58 File Offset: 0x0008AE58
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x0008CC90 File Offset: 0x0008AE90
		public unsafe string Pubid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Pubid_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x0008CCD4 File Offset: 0x0008AED4
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x0008CD10 File Offset: 0x0008AF10
		public unsafe bool IsExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_IsExternal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_IsExternal_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x0008CD50 File Offset: 0x0008AF50
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x0008CD8C File Offset: 0x0008AF8C
		public unsafe bool DeclaredInExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_DeclaredInExternal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_DeclaredInExternal_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x0008CDCC File Offset: 0x0008AFCC
		// (set) Token: 0x06001CCD RID: 7373 RVA: 0x0008CE0C File Offset: 0x0008B00C
		public unsafe XmlQualifiedName NData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_NData_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_NData_Internal_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x0008CE50 File Offset: 0x0008B050
		// (set) Token: 0x06001CCF RID: 7375 RVA: 0x0008CE88 File Offset: 0x0008B088
		public unsafe string Text
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Text_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 420279, RefRangeEnd = 420282, XrefRangeStart = 420279, XrefRangeEnd = 420279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_Text_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x0008CECC File Offset: 0x0008B0CC
		// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x0008CF08 File Offset: 0x0008B108
		public unsafe int Line
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Line_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_Line_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x0008CF48 File Offset: 0x0008B148
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x0008CF84 File Offset: 0x0008B184
		public unsafe int Pos
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Pos_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_Pos_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x0008CFC4 File Offset: 0x0008B1C4
		// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x0008CFFC File Offset: 0x0008B1FC
		public unsafe string BaseURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 420282, XrefRangeEnd = 420284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_BaseURI_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_BaseURI_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x0008D040 File Offset: 0x0008B240
		// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x0008D07C File Offset: 0x0008B27C
		public unsafe bool ParsingInProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_ParsingInProgress_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_ParsingInProgress_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x0008D0BC File Offset: 0x0008B2BC
		// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x0008D0F4 File Offset: 0x0008B2F4
		public unsafe string DeclaredURI
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 420286, RefRangeEnd = 420288, XrefRangeStart = 420284, XrefRangeEnd = 420286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_DeclaredURI_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 13543, RefRangeEnd = 13569, XrefRangeStart = 13543, XrefRangeEnd = 13569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_DeclaredURI_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x0000C060 File Offset: 0x0000A260
		public SchemaEntity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x0008D138 File Offset: 0x0008B338
		// (set) Token: 0x06001CDC RID: 7388 RVA: 0x0000C069 File Offset: 0x0000A269
		public unsafe XmlQualifiedName qname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_qname);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_qname), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001CDD RID: 7389 RVA: 0x0008D168 File Offset: 0x0008B368
		// (set) Token: 0x06001CDE RID: 7390 RVA: 0x0000C088 File Offset: 0x0000A288
		public unsafe string url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x0008D190 File Offset: 0x0008B390
		// (set) Token: 0x06001CE0 RID: 7392 RVA: 0x0000C0A7 File Offset: 0x0000A2A7
		public unsafe string pubid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_pubid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_pubid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x0008D1B8 File Offset: 0x0008B3B8
		// (set) Token: 0x06001CE2 RID: 7394 RVA: 0x0000C0C6 File Offset: 0x0000A2C6
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x0008D1E0 File Offset: 0x0008B3E0
		// (set) Token: 0x06001CE4 RID: 7396 RVA: 0x0000C0E5 File Offset: 0x0000A2E5
		public unsafe XmlQualifiedName ndata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_ndata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_ndata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x0008D210 File Offset: 0x0008B410
		// (set) Token: 0x06001CE6 RID: 7398 RVA: 0x0000C104 File Offset: 0x0000A304
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x0008D238 File Offset: 0x0008B438
		// (set) Token: 0x06001CE8 RID: 7400 RVA: 0x0000C11F File Offset: 0x0000A31F
		public unsafe int linePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_linePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_linePosition)) = value;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x0008D260 File Offset: 0x0008B460
		// (set) Token: 0x06001CEA RID: 7402 RVA: 0x0000C13A File Offset: 0x0000A33A
		public unsafe bool isParameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isParameter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isParameter)) = value;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x0008D288 File Offset: 0x0008B488
		// (set) Token: 0x06001CEC RID: 7404 RVA: 0x0000C155 File Offset: 0x0000A355
		public unsafe bool isExternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isExternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isExternal)) = value;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x0008D2B0 File Offset: 0x0008B4B0
		// (set) Token: 0x06001CEE RID: 7406 RVA: 0x0000C170 File Offset: 0x0000A370
		public unsafe bool parsingInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_parsingInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_parsingInProgress)) = value;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001CEF RID: 7407 RVA: 0x0008D2D8 File Offset: 0x0008B4D8
		// (set) Token: 0x06001CF0 RID: 7408 RVA: 0x0000C18B File Offset: 0x0000A38B
		public unsafe bool isDeclaredInExternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isDeclaredInExternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isDeclaredInExternal)) = value;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x0008D300 File Offset: 0x0008B500
		// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x0000C1A6 File Offset: 0x0000A3A6
		public unsafe string baseURI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_baseURI);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_baseURI), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x0008D328 File Offset: 0x0008B528
		// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x0000C1C5 File Offset: 0x0000A3C5
		public unsafe string declaredURI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_declaredURI);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_declaredURI), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeFieldInfoPtr_qname;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeFieldInfoPtr_url;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeFieldInfoPtr_pubid;

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeFieldInfoPtr_ndata;

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeFieldInfoPtr_linePosition;

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeFieldInfoPtr_isParameter;

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeFieldInfoPtr_isExternal;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeFieldInfoPtr_parsingInProgress;

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeFieldInfoPtr_isDeclaredInExternal;

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeFieldInfoPtr_baseURI;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeFieldInfoPtr_declaredURI;

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_Boolean_0;

		// Token: 0x0400158D RID: 5517
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Name_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0400158E RID: 5518
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsExternal_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400158F RID: 5519
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001590 RID: 5520
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsUnparsedEntity_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001591 RID: 5521
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsParameterEntity_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001592 RID: 5522
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_BaseUriString_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04001593 RID: 5523
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_DeclaredUriString_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04001594 RID: 5524
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_SystemId_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_PublicId_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Text_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeMethodInfoPtr_IsPredefinedEntity_Internal_Static_Boolean_String_0;

		// Token: 0x0400159A RID: 5530
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0;

		// Token: 0x0400159B RID: 5531
		private static readonly IntPtr NativeMethodInfoPtr_get_Url_Internal_get_String_0;

		// Token: 0x0400159C RID: 5532
		private static readonly IntPtr NativeMethodInfoPtr_set_Url_Internal_set_Void_String_0;

		// Token: 0x0400159D RID: 5533
		private static readonly IntPtr NativeMethodInfoPtr_get_Pubid_Internal_get_String_0;

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0;

		// Token: 0x0400159F RID: 5535
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExternal_Internal_get_Boolean_0;

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeMethodInfoPtr_set_IsExternal_Internal_set_Void_Boolean_0;

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaredInExternal_Internal_get_Boolean_0;

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeMethodInfoPtr_set_DeclaredInExternal_Internal_set_Void_Boolean_0;

		// Token: 0x040015A3 RID: 5539
		private static readonly IntPtr NativeMethodInfoPtr_get_NData_Internal_get_XmlQualifiedName_0;

		// Token: 0x040015A4 RID: 5540
		private static readonly IntPtr NativeMethodInfoPtr_set_NData_Internal_set_Void_XmlQualifiedName_0;

		// Token: 0x040015A5 RID: 5541
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Internal_get_String_0;

		// Token: 0x040015A6 RID: 5542
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Internal_set_Void_String_0;

		// Token: 0x040015A7 RID: 5543
		private static readonly IntPtr NativeMethodInfoPtr_get_Line_Internal_get_Int32_0;

		// Token: 0x040015A8 RID: 5544
		private static readonly IntPtr NativeMethodInfoPtr_set_Line_Internal_set_Void_Int32_0;

		// Token: 0x040015A9 RID: 5545
		private static readonly IntPtr NativeMethodInfoPtr_get_Pos_Internal_get_Int32_0;

		// Token: 0x040015AA RID: 5546
		private static readonly IntPtr NativeMethodInfoPtr_set_Pos_Internal_set_Void_Int32_0;

		// Token: 0x040015AB RID: 5547
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Internal_get_String_0;

		// Token: 0x040015AC RID: 5548
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseURI_Internal_set_Void_String_0;

		// Token: 0x040015AD RID: 5549
		private static readonly IntPtr NativeMethodInfoPtr_get_ParsingInProgress_Internal_get_Boolean_0;

		// Token: 0x040015AE RID: 5550
		private static readonly IntPtr NativeMethodInfoPtr_set_ParsingInProgress_Internal_set_Void_Boolean_0;

		// Token: 0x040015AF RID: 5551
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaredURI_Internal_get_String_0;

		// Token: 0x040015B0 RID: 5552
		private static readonly IntPtr NativeMethodInfoPtr_set_DeclaredURI_Internal_set_Void_String_0;
	}
}
