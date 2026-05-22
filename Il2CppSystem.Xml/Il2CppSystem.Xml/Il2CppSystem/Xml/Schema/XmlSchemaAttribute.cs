using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200018E RID: 398
	public class XmlSchemaAttribute : XmlSchemaAnnotated
	{
		// Token: 0x060020C6 RID: 8390 RVA: 0x0009A8A0 File Offset: 0x00098AA0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaAttribute()
		{
			Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr);
			XmlSchemaAttribute.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "defaultValue");
			XmlSchemaAttribute.NativeFieldInfoPtr_fixedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "fixedValue");
			XmlSchemaAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "name");
			XmlSchemaAttribute.NativeFieldInfoPtr_form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "form");
			XmlSchemaAttribute.NativeFieldInfoPtr_use = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "use");
			XmlSchemaAttribute.NativeFieldInfoPtr_refName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "refName");
			XmlSchemaAttribute.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "typeName");
			XmlSchemaAttribute.NativeFieldInfoPtr_qualifiedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "qualifiedName");
			XmlSchemaAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "type");
			XmlSchemaAttribute.NativeFieldInfoPtr_attributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "attributeType");
			XmlSchemaAttribute.NativeFieldInfoPtr_attDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "attDef");
			XmlSchemaAttribute.NativeMethodInfoPtr_get_DefaultValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667978);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667979);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_FixedValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667980);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_FixedValue_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667981);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667982);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667983);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667984);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667985);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667986);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667987);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_SchemaTypeName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667988);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_SchemaTypeName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667989);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_SchemaType_Public_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667990);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667991);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_Use_Public_get_XmlSchemaUse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667992);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_Use_Public_set_Void_XmlSchemaUse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667993);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667994);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_AttributeSchemaType_Public_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667995);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_Datatype_Internal_get_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667996);
			XmlSchemaAttribute.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667997);
			XmlSchemaAttribute.NativeMethodInfoPtr_SetAttributeType_Internal_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667998);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_AttDef_Internal_get_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100667999);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_AttDef_Internal_set_Void_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668000);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668001);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668002);
			XmlSchemaAttribute.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668003);
			XmlSchemaAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668004);
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x0009ABC8 File Offset: 0x00098DC8
		// (set) Token: 0x060020C8 RID: 8392 RVA: 0x0009AC00 File Offset: 0x00098E00
		public unsafe string DefaultValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_DefaultValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x0009AC44 File Offset: 0x00098E44
		// (set) Token: 0x060020CA RID: 8394 RVA: 0x0009AC7C File Offset: 0x00098E7C
		public unsafe string FixedValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_FixedValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 17925, RefRangeEnd = 17937, XrefRangeStart = 17925, XrefRangeEnd = 17937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_FixedValue_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x0009ACC0 File Offset: 0x00098EC0
		// (set) Token: 0x060020CC RID: 8396 RVA: 0x0009ACFC File Offset: 0x00098EFC
		public unsafe XmlSchemaForm Form
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x0009AD3C File Offset: 0x00098F3C
		// (set) Token: 0x060020CE RID: 8398 RVA: 0x0009AD74 File Offset: 0x00098F74
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x0009ADB8 File Offset: 0x00098FB8
		// (set) Token: 0x060020D0 RID: 8400 RVA: 0x0009ADF8 File Offset: 0x00098FF8
		public unsafe XmlQualifiedName RefName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 426366, RefRangeEnd = 426369, XrefRangeStart = 426360, XrefRangeEnd = 426366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x0009AE3C File Offset: 0x0009903C
		// (set) Token: 0x060020D2 RID: 8402 RVA: 0x0009AE7C File Offset: 0x0009907C
		public unsafe XmlQualifiedName SchemaTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_SchemaTypeName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426369, XrefRangeEnd = 426375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_SchemaTypeName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x060020D3 RID: 8403 RVA: 0x0009AEC0 File Offset: 0x000990C0
		// (set) Token: 0x060020D4 RID: 8404 RVA: 0x0009AF00 File Offset: 0x00099100
		public unsafe XmlSchemaSimpleType SchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_SchemaType_Public_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 161221, RefRangeEnd = 161228, XrefRangeStart = 161221, XrefRangeEnd = 161228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x060020D5 RID: 8405 RVA: 0x0009AF44 File Offset: 0x00099144
		// (set) Token: 0x060020D6 RID: 8406 RVA: 0x0009AF80 File Offset: 0x00099180
		public unsafe XmlSchemaUse Use
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_Use_Public_get_XmlSchemaUse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_Use_Public_set_Void_XmlSchemaUse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x0009AFC0 File Offset: 0x000991C0
		public unsafe XmlQualifiedName QualifiedName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x0009B000 File Offset: 0x00099200
		public unsafe XmlSchemaSimpleType AttributeSchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_AttributeSchemaType_Public_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x060020D9 RID: 8409 RVA: 0x0009B040 File Offset: 0x00099240
		public unsafe XmlSchemaDatatype Datatype
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_Datatype_Internal_get_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x0009B080 File Offset: 0x00099280
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 382561, RefRangeEnd = 382571, XrefRangeStart = 382561, XrefRangeEnd = 382571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQualifiedName(XmlQualifiedName value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x0009B0C4 File Offset: 0x000992C4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 388203, RefRangeEnd = 388211, XrefRangeStart = 388203, XrefRangeEnd = 388211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAttributeType(XmlSchemaSimpleType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_SetAttributeType_Internal_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x0009B108 File Offset: 0x00099308
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x0009B148 File Offset: 0x00099348
		public unsafe SchemaAttDef AttDef
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_AttDef_Internal_get_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 224553, RefRangeEnd = 224561, XrefRangeStart = 224553, XrefRangeEnd = 224561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_AttDef_Internal_set_Void_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x0009B18C File Offset: 0x0009938C
		// (set) Token: 0x060020DF RID: 8415 RVA: 0x0009B1D0 File Offset: 0x000993D0
		public unsafe override string NameAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAttribute.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAttribute.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x0009B220 File Offset: 0x00099420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426375, XrefRangeEnd = 426382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlSchemaObject Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAttribute.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x0009B26C File Offset: 0x0009946C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 426388, RefRangeEnd = 426395, XrefRangeStart = 426382, XrefRangeEnd = 426388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x0000E43D File Offset: 0x0000C63D
		public XmlSchemaAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x0009B2A8 File Offset: 0x000994A8
		// (set) Token: 0x060020E4 RID: 8420 RVA: 0x0000E446 File Offset: 0x0000C646
		public unsafe string defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_defaultValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_defaultValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x0009B2D0 File Offset: 0x000994D0
		// (set) Token: 0x060020E6 RID: 8422 RVA: 0x0000E465 File Offset: 0x0000C665
		public unsafe string fixedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_fixedValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_fixedValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x060020E7 RID: 8423 RVA: 0x0009B2F8 File Offset: 0x000994F8
		// (set) Token: 0x060020E8 RID: 8424 RVA: 0x0000E484 File Offset: 0x0000C684
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x0009B320 File Offset: 0x00099520
		// (set) Token: 0x060020EA RID: 8426 RVA: 0x0000E4A3 File Offset: 0x0000C6A3
		public unsafe XmlSchemaForm form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_form);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_form)) = value;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x060020EB RID: 8427 RVA: 0x0009B348 File Offset: 0x00099548
		// (set) Token: 0x060020EC RID: 8428 RVA: 0x0000E4BE File Offset: 0x0000C6BE
		public unsafe XmlSchemaUse use
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_use);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_use)) = value;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x060020ED RID: 8429 RVA: 0x0009B370 File Offset: 0x00099570
		// (set) Token: 0x060020EE RID: 8430 RVA: 0x0000E4D9 File Offset: 0x0000C6D9
		public unsafe XmlQualifiedName refName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_refName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_refName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x0009B3A0 File Offset: 0x000995A0
		// (set) Token: 0x060020F0 RID: 8432 RVA: 0x0000E4F8 File Offset: 0x0000C6F8
		public unsafe XmlQualifiedName typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_typeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_typeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060020F1 RID: 8433 RVA: 0x0009B3D0 File Offset: 0x000995D0
		// (set) Token: 0x060020F2 RID: 8434 RVA: 0x0000E517 File Offset: 0x0000C717
		public unsafe XmlQualifiedName qualifiedName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_qualifiedName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_qualifiedName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060020F3 RID: 8435 RVA: 0x0009B400 File Offset: 0x00099600
		// (set) Token: 0x060020F4 RID: 8436 RVA: 0x0000E536 File Offset: 0x0000C736
		public unsafe XmlSchemaSimpleType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x0009B430 File Offset: 0x00099630
		// (set) Token: 0x060020F6 RID: 8438 RVA: 0x0000E555 File Offset: 0x0000C755
		public unsafe XmlSchemaSimpleType attributeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_attributeType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_attributeType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x0009B460 File Offset: 0x00099660
		// (set) Token: 0x060020F8 RID: 8440 RVA: 0x0000E574 File Offset: 0x0000C774
		public unsafe SchemaAttDef attDef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_attDef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_attDef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeFieldInfoPtr_defaultValue;

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeFieldInfoPtr_fixedValue;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeFieldInfoPtr_form;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeFieldInfoPtr_use;

		// Token: 0x04001857 RID: 6231
		private static readonly IntPtr NativeFieldInfoPtr_refName;

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeFieldInfoPtr_qualifiedName;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeFieldInfoPtr_attributeType;

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeFieldInfoPtr_attDef;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_get_String_0;

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_String_0;

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeMethodInfoPtr_get_FixedValue_Public_get_String_0;

		// Token: 0x04001860 RID: 6240
		private static readonly IntPtr NativeMethodInfoPtr_set_FixedValue_Public_set_Void_String_0;

		// Token: 0x04001861 RID: 6241
		private static readonly IntPtr NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0;

		// Token: 0x04001862 RID: 6242
		private static readonly IntPtr NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0;

		// Token: 0x04001863 RID: 6243
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001864 RID: 6244
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaTypeName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaTypeName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001869 RID: 6249
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Public_get_XmlSchemaSimpleType_0;

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaSimpleType_0;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeMethodInfoPtr_get_Use_Public_get_XmlSchemaUse_0;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeMethodInfoPtr_set_Use_Public_set_Void_XmlSchemaUse_0;

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0;

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeSchemaType_Public_get_XmlSchemaSimpleType_0;

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeMethodInfoPtr_get_Datatype_Internal_get_XmlSchemaDatatype_0;

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributeType_Internal_Void_XmlSchemaSimpleType_0;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeMethodInfoPtr_get_AttDef_Internal_get_SchemaAttDef_0;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeMethodInfoPtr_set_AttDef_Internal_set_Void_SchemaAttDef_0;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0;

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0;

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0;

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
