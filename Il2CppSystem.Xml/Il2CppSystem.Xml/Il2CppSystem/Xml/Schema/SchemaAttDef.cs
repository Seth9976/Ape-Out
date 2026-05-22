using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000172 RID: 370
	public sealed class SchemaAttDef : SchemaDeclBase
	{
		// Token: 0x06001B79 RID: 7033 RVA: 0x00086C28 File Offset: 0x00084E28
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaAttDef()
		{
			Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaAttDef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr);
			SchemaAttDef.NativeFieldInfoPtr_defExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "defExpanded");
			SchemaAttDef.NativeFieldInfoPtr_lineNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "lineNum");
			SchemaAttDef.NativeFieldInfoPtr_linePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "linePos");
			SchemaAttDef.NativeFieldInfoPtr_valueLineNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "valueLineNum");
			SchemaAttDef.NativeFieldInfoPtr_valueLinePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "valueLinePos");
			SchemaAttDef.NativeFieldInfoPtr_reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "reserved");
			SchemaAttDef.NativeFieldInfoPtr_defaultValueChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "defaultValueChecked");
			SchemaAttDef.NativeFieldInfoPtr_schemaAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "schemaAttribute");
			SchemaAttDef.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "Empty");
			SchemaAttDef.NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667342);
			SchemaAttDef.NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667343);
			SchemaAttDef.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667344);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_Prefix_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667345);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LocalName_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667346);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667347);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667348);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsNonCDataType_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667349);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667350);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsXmlAttribute_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667351);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueExpanded_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667352);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueTyped_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667353);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLineNumber_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667354);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLinePosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667355);
			SchemaAttDef.NativeMethodInfoPtr_get_LinePosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667356);
			SchemaAttDef.NativeMethodInfoPtr_set_LinePosition_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667357);
			SchemaAttDef.NativeMethodInfoPtr_get_LineNumber_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667358);
			SchemaAttDef.NativeMethodInfoPtr_set_LineNumber_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667359);
			SchemaAttDef.NativeMethodInfoPtr_get_ValueLinePosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667360);
			SchemaAttDef.NativeMethodInfoPtr_set_ValueLinePosition_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667361);
			SchemaAttDef.NativeMethodInfoPtr_get_ValueLineNumber_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667362);
			SchemaAttDef.NativeMethodInfoPtr_set_ValueLineNumber_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667363);
			SchemaAttDef.NativeMethodInfoPtr_get_DefaultValueExpanded_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667364);
			SchemaAttDef.NativeMethodInfoPtr_set_DefaultValueExpanded_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667365);
			SchemaAttDef.NativeMethodInfoPtr_get_TokenizedType_Internal_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667366);
			SchemaAttDef.NativeMethodInfoPtr_set_TokenizedType_Internal_set_Void_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667367);
			SchemaAttDef.NativeMethodInfoPtr_get_Reserved_Internal_get_Reserve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667368);
			SchemaAttDef.NativeMethodInfoPtr_set_Reserved_Internal_set_Void_Reserve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667369);
			SchemaAttDef.NativeMethodInfoPtr_get_DefaultValueChecked_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667370);
			SchemaAttDef.NativeMethodInfoPtr_get_SchemaAttribute_Internal_get_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667371);
			SchemaAttDef.NativeMethodInfoPtr_set_SchemaAttribute_Internal_set_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667372);
			SchemaAttDef.NativeMethodInfoPtr_CheckXmlSpace_Internal_Void_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667373);
			SchemaAttDef.NativeMethodInfoPtr_Clone_Internal_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667374);
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x00086FA0 File Offset: 0x000851A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415922, XrefRangeEnd = 415923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef(XmlQualifiedName name, string prefix)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x00087000 File Offset: 0x00085200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415923, XrefRangeEnd = 415924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef(XmlQualifiedName name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0008704C File Offset: 0x0008524C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415924, XrefRangeEnd = 415925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x00087088 File Offset: 0x00085288
		public unsafe string System.Xml.IDtdAttributeInfo.Prefix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415925, XrefRangeEnd = 415927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_Prefix_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x000870C0 File Offset: 0x000852C0
		public unsafe string System.Xml.IDtdAttributeInfo.LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LocalName_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x000870F8 File Offset: 0x000852F8
		public unsafe int System.Xml.IDtdAttributeInfo.LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001B80 RID: 7040 RVA: 0x00087134 File Offset: 0x00085334
		public unsafe int System.Xml.IDtdAttributeInfo.LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x00087170 File Offset: 0x00085370
		public unsafe bool System.Xml.IDtdAttributeInfo.IsNonCDataType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsNonCDataType_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x000871AC File Offset: 0x000853AC
		public unsafe bool System.Xml.IDtdAttributeInfo.IsDeclaredInExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x000871E8 File Offset: 0x000853E8
		public unsafe bool System.Xml.IDtdAttributeInfo.IsXmlAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsXmlAttribute_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x00087224 File Offset: 0x00085424
		public unsafe string System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415927, XrefRangeEnd = 415929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueExpanded_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001B85 RID: 7045 RVA: 0x0008725C File Offset: 0x0008545C
		public unsafe Object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueTyped_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x0008729C File Offset: 0x0008549C
		public unsafe int System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLineNumber_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x000872D8 File Offset: 0x000854D8
		public unsafe int System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLinePosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x00087314 File Offset: 0x00085514
		// (set) Token: 0x06001B89 RID: 7049 RVA: 0x00087350 File Offset: 0x00085550
		public unsafe int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_LinePosition_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_LinePosition_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x00087390 File Offset: 0x00085590
		// (set) Token: 0x06001B8B RID: 7051 RVA: 0x000873CC File Offset: 0x000855CC
		public unsafe int LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_LineNumber_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_LineNumber_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001B8C RID: 7052 RVA: 0x0008740C File Offset: 0x0008560C
		// (set) Token: 0x06001B8D RID: 7053 RVA: 0x00087448 File Offset: 0x00085648
		public unsafe int ValueLinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_ValueLinePosition_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_ValueLinePosition_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001B8E RID: 7054 RVA: 0x00087488 File Offset: 0x00085688
		// (set) Token: 0x06001B8F RID: 7055 RVA: 0x000874C4 File Offset: 0x000856C4
		public unsafe int ValueLineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_ValueLineNumber_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_ValueLineNumber_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x00087504 File Offset: 0x00085704
		// (set) Token: 0x06001B91 RID: 7057 RVA: 0x0008753C File Offset: 0x0008573C
		public unsafe string DefaultValueExpanded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415929, XrefRangeEnd = 415931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_DefaultValueExpanded_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 214194, RefRangeEnd = 214233, XrefRangeStart = 214194, XrefRangeEnd = 214233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_DefaultValueExpanded_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x00087580 File Offset: 0x00085780
		// (set) Token: 0x06001B93 RID: 7059 RVA: 0x000875BC File Offset: 0x000857BC
		public unsafe XmlTokenizedType TokenizedType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415931, XrefRangeEnd = 415932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_TokenizedType_Internal_get_XmlTokenizedType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 415933, RefRangeEnd = 415934, XrefRangeStart = 415932, XrefRangeEnd = 415933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_TokenizedType_Internal_set_Void_XmlTokenizedType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x000875FC File Offset: 0x000857FC
		// (set) Token: 0x06001B95 RID: 7061 RVA: 0x00087638 File Offset: 0x00085838
		public unsafe SchemaAttDef.Reserve Reserved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_Reserved_Internal_get_Reserve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_Reserved_Internal_set_Void_Reserve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001B96 RID: 7062 RVA: 0x00087678 File Offset: 0x00085878
		public unsafe bool DefaultValueChecked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_DefaultValueChecked_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x000876B4 File Offset: 0x000858B4
		// (set) Token: 0x06001B98 RID: 7064 RVA: 0x000876F4 File Offset: 0x000858F4
		public unsafe XmlSchemaAttribute SchemaAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_SchemaAttribute_Internal_get_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 382561, RefRangeEnd = 382571, XrefRangeStart = 382561, XrefRangeEnd = 382571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_SchemaAttribute_Internal_set_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x00087738 File Offset: 0x00085938
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 415944, RefRangeEnd = 415946, XrefRangeStart = 415934, XrefRangeEnd = 415944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckXmlSpace(IValidationEventHandling validationEventHandling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validationEventHandling);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_CheckXmlSpace_Internal_Void_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x0008777C File Offset: 0x0008597C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 415949, RefRangeEnd = 415954, XrefRangeStart = 415946, XrefRangeEnd = 415949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_Clone_Internal_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr3) : null;
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x0000BA92 File Offset: 0x00009C92
		public SchemaAttDef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x000877BC File Offset: 0x000859BC
		// (set) Token: 0x06001B9D RID: 7069 RVA: 0x0000BA9B File Offset: 0x00009C9B
		public unsafe string defExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_defExpanded);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_defExpanded), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001B9E RID: 7070 RVA: 0x000877E4 File Offset: 0x000859E4
		// (set) Token: 0x06001B9F RID: 7071 RVA: 0x0000BABA File Offset: 0x00009CBA
		public unsafe int lineNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_lineNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_lineNum)) = value;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x0008780C File Offset: 0x00085A0C
		// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x0000BAD5 File Offset: 0x00009CD5
		public unsafe int linePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_linePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_linePos)) = value;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x00087834 File Offset: 0x00085A34
		// (set) Token: 0x06001BA3 RID: 7075 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		public unsafe int valueLineNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_valueLineNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_valueLineNum)) = value;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x0008785C File Offset: 0x00085A5C
		// (set) Token: 0x06001BA5 RID: 7077 RVA: 0x0000BB0B File Offset: 0x00009D0B
		public unsafe int valueLinePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_valueLinePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_valueLinePos)) = value;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x00087884 File Offset: 0x00085A84
		// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x0000BB26 File Offset: 0x00009D26
		public unsafe SchemaAttDef.Reserve reserved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_reserved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_reserved)) = value;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x000878AC File Offset: 0x00085AAC
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x0000BB41 File Offset: 0x00009D41
		public unsafe bool defaultValueChecked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_defaultValueChecked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_defaultValueChecked)) = value;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x000878D4 File Offset: 0x00085AD4
		// (set) Token: 0x06001BAB RID: 7083 RVA: 0x0000BB5C File Offset: 0x00009D5C
		public unsafe XmlSchemaAttribute schemaAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_schemaAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_schemaAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x00087904 File Offset: 0x00085B04
		// (set) Token: 0x06001BAD RID: 7085 RVA: 0x0000BB7B File Offset: 0x00009D7B
		public unsafe static SchemaAttDef Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SchemaAttDef.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SchemaAttDef.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeFieldInfoPtr_defExpanded;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeFieldInfoPtr_lineNum;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeFieldInfoPtr_linePos;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeFieldInfoPtr_valueLineNum;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeFieldInfoPtr_valueLinePos;

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeFieldInfoPtr_reserved;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeFieldInfoPtr_defaultValueChecked;

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeFieldInfoPtr_schemaAttribute;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_String_0;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_0;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_Prefix_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LocalName_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsNonCDataType_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsXmlAttribute_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueExpanded_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueTyped_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLineNumber_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLinePosition_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Internal_get_Int32_0;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr_set_LinePosition_Internal_set_Void_Int32_0;

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Internal_get_Int32_0;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr_set_LineNumber_Internal_set_Void_Int32_0;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueLinePosition_Internal_get_Int32_0;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueLinePosition_Internal_set_Void_Int32_0;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueLineNumber_Internal_get_Int32_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueLineNumber_Internal_set_Void_Int32_0;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueExpanded_Internal_get_String_0;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValueExpanded_Internal_set_Void_String_0;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Internal_get_XmlTokenizedType_0;

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeMethodInfoPtr_set_TokenizedType_Internal_set_Void_XmlTokenizedType_0;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_get_Reserved_Internal_get_Reserve_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr_set_Reserved_Internal_set_Void_Reserve_0;

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueChecked_Internal_get_Boolean_0;

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaAttribute_Internal_get_XmlSchemaAttribute_0;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaAttribute_Internal_set_Void_XmlSchemaAttribute_0;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeMethodInfoPtr_CheckXmlSpace_Internal_Void_IValidationEventHandling_0;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_SchemaAttDef_0;

		// Token: 0x02000234 RID: 564
		[OriginalName("System.Xml.dll", "", "Reserve")]
		public enum Reserve
		{
			// Token: 0x040022BA RID: 8890
			None,
			// Token: 0x040022BB RID: 8891
			XmlSpace,
			// Token: 0x040022BC RID: 8892
			XmlLang
		}
	}
}
