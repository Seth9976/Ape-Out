using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000176 RID: 374
	public class SchemaDeclBase : Object
	{
		// Token: 0x06001C3D RID: 7229 RVA: 0x0008A81C File Offset: 0x00088A1C
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaDeclBase()
		{
			Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaDeclBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr);
			SchemaDeclBase.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "name");
			SchemaDeclBase.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "prefix");
			SchemaDeclBase.NativeFieldInfoPtr_isDeclaredInExternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "isDeclaredInExternal");
			SchemaDeclBase.NativeFieldInfoPtr_presence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "presence");
			SchemaDeclBase.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "schemaType");
			SchemaDeclBase.NativeFieldInfoPtr_datatype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "datatype");
			SchemaDeclBase.NativeFieldInfoPtr_defaultValueRaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "defaultValueRaw");
			SchemaDeclBase.NativeFieldInfoPtr_defaultValueTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "defaultValueTyped");
			SchemaDeclBase.NativeFieldInfoPtr_maxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "maxLength");
			SchemaDeclBase.NativeFieldInfoPtr_minLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "minLength");
			SchemaDeclBase.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, "values");
			SchemaDeclBase.NativeMethodInfoPtr__ctor_Protected_Void_XmlQualifiedName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667483);
			SchemaDeclBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667484);
			SchemaDeclBase.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667485);
			SchemaDeclBase.NativeMethodInfoPtr_set_Name_Internal_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667486);
			SchemaDeclBase.NativeMethodInfoPtr_get_Prefix_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667487);
			SchemaDeclBase.NativeMethodInfoPtr_set_Prefix_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667488);
			SchemaDeclBase.NativeMethodInfoPtr_get_IsDeclaredInExternal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667489);
			SchemaDeclBase.NativeMethodInfoPtr_set_IsDeclaredInExternal_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667490);
			SchemaDeclBase.NativeMethodInfoPtr_get_Presence_Internal_get_Use_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667491);
			SchemaDeclBase.NativeMethodInfoPtr_set_Presence_Internal_set_Void_Use_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667492);
			SchemaDeclBase.NativeMethodInfoPtr_get_MaxLength_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667493);
			SchemaDeclBase.NativeMethodInfoPtr_set_MaxLength_Internal_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667494);
			SchemaDeclBase.NativeMethodInfoPtr_get_MinLength_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667495);
			SchemaDeclBase.NativeMethodInfoPtr_set_MinLength_Internal_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667496);
			SchemaDeclBase.NativeMethodInfoPtr_get_SchemaType_Internal_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667497);
			SchemaDeclBase.NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667498);
			SchemaDeclBase.NativeMethodInfoPtr_get_Datatype_Internal_get_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667499);
			SchemaDeclBase.NativeMethodInfoPtr_set_Datatype_Internal_set_Void_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667500);
			SchemaDeclBase.NativeMethodInfoPtr_AddValue_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667501);
			SchemaDeclBase.NativeMethodInfoPtr_get_Values_Internal_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667502);
			SchemaDeclBase.NativeMethodInfoPtr_set_Values_Internal_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667503);
			SchemaDeclBase.NativeMethodInfoPtr_get_DefaultValueRaw_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667504);
			SchemaDeclBase.NativeMethodInfoPtr_set_DefaultValueRaw_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667505);
			SchemaDeclBase.NativeMethodInfoPtr_get_DefaultValueTyped_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667506);
			SchemaDeclBase.NativeMethodInfoPtr_set_DefaultValueTyped_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667507);
			SchemaDeclBase.NativeMethodInfoPtr_CheckEnumeration_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667508);
			SchemaDeclBase.NativeMethodInfoPtr_CheckValue_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr, 100667509);
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x0008AB44 File Offset: 0x00088D44
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 420087, RefRangeEnd = 420095, XrefRangeStart = 420083, XrefRangeEnd = 420087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaDeclBase(XmlQualifiedName name, string prefix)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr__ctor_Protected_Void_XmlQualifiedName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x0008ABA4 File Offset: 0x00088DA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 420099, RefRangeEnd = 420102, XrefRangeStart = 420095, XrefRangeEnd = 420099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaDeclBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaDeclBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x0008ABE0 File Offset: 0x00088DE0
		// (set) Token: 0x06001C41 RID: 7233 RVA: 0x0008AC20 File Offset: 0x00088E20
		public unsafe XmlQualifiedName Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_Name_Internal_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x0008AC64 File Offset: 0x00088E64
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x0008AC9C File Offset: 0x00088E9C
		public unsafe string Prefix
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 420104, RefRangeEnd = 420110, XrefRangeStart = 420102, XrefRangeEnd = 420104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_Prefix_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_Prefix_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x0008ACE0 File Offset: 0x00088EE0
		// (set) Token: 0x06001C45 RID: 7237 RVA: 0x0008AD1C File Offset: 0x00088F1C
		public unsafe bool IsDeclaredInExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_IsDeclaredInExternal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_IsDeclaredInExternal_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x0008AD5C File Offset: 0x00088F5C
		// (set) Token: 0x06001C47 RID: 7239 RVA: 0x0008AD98 File Offset: 0x00088F98
		public unsafe SchemaDeclBase.Use Presence
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_Presence_Internal_get_Use_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_Presence_Internal_set_Void_Use_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x0008ADD8 File Offset: 0x00088FD8
		// (set) Token: 0x06001C49 RID: 7241 RVA: 0x0008AE14 File Offset: 0x00089014
		public unsafe long MaxLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_MaxLength_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_MaxLength_Internal_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x0008AE54 File Offset: 0x00089054
		// (set) Token: 0x06001C4B RID: 7243 RVA: 0x0008AE90 File Offset: 0x00089090
		public unsafe long MinLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_MinLength_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_MinLength_Internal_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x0008AED0 File Offset: 0x000890D0
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x0008AF10 File Offset: 0x00089110
		public unsafe XmlSchemaType SchemaType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_SchemaType_Internal_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x0008AF54 File Offset: 0x00089154
		// (set) Token: 0x06001C4F RID: 7247 RVA: 0x0008AF94 File Offset: 0x00089194
		public unsafe XmlSchemaDatatype Datatype
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_Datatype_Internal_get_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_Datatype_Internal_set_Void_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0008AFD8 File Offset: 0x000891D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 420120, RefRangeEnd = 420122, XrefRangeStart = 420110, XrefRangeEnd = 420120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_AddValue_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x0008B01C File Offset: 0x0008921C
		// (set) Token: 0x06001C52 RID: 7250 RVA: 0x0008B05C File Offset: 0x0008925C
		public unsafe List<string> Values
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_Values_Internal_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_Values_Internal_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x0008B0A0 File Offset: 0x000892A0
		// (set) Token: 0x06001C54 RID: 7252 RVA: 0x0008B0D8 File Offset: 0x000892D8
		public unsafe string DefaultValueRaw
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 420124, RefRangeEnd = 420137, XrefRangeStart = 420122, XrefRangeEnd = 420124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_DefaultValueRaw_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_DefaultValueRaw_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x0008B11C File Offset: 0x0008931C
		// (set) Token: 0x06001C56 RID: 7254 RVA: 0x0008B15C File Offset: 0x0008935C
		public unsafe Object DefaultValueTyped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_get_DefaultValueTyped_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_set_DefaultValueTyped_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x0008B1A0 File Offset: 0x000893A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 420138, RefRangeEnd = 420142, XrefRangeStart = 420137, XrefRangeEnd = 420138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckEnumeration(Object pVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pVal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_CheckEnumeration_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x0008B1F0 File Offset: 0x000893F0
		[CallerCount(0)]
		public unsafe bool CheckValue(Object pVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pVal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaDeclBase.NativeMethodInfoPtr_CheckValue_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x0000BD61 File Offset: 0x00009F61
		public SchemaDeclBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x0008B240 File Offset: 0x00089440
		// (set) Token: 0x06001C5B RID: 7259 RVA: 0x0000BD6A File Offset: 0x00009F6A
		public unsafe XmlQualifiedName name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x0008B270 File Offset: 0x00089470
		// (set) Token: 0x06001C5D RID: 7261 RVA: 0x0000BD89 File Offset: 0x00009F89
		public unsafe string prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x0008B298 File Offset: 0x00089498
		// (set) Token: 0x06001C5F RID: 7263 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		public unsafe bool isDeclaredInExternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_isDeclaredInExternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_isDeclaredInExternal)) = value;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x0008B2C0 File Offset: 0x000894C0
		// (set) Token: 0x06001C61 RID: 7265 RVA: 0x0000BDC3 File Offset: 0x00009FC3
		public unsafe SchemaDeclBase.Use presence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_presence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_presence)) = value;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x0008B2E8 File Offset: 0x000894E8
		// (set) Token: 0x06001C63 RID: 7267 RVA: 0x0000BDDE File Offset: 0x00009FDE
		public unsafe XmlSchemaType schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_schemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_schemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x0008B318 File Offset: 0x00089518
		// (set) Token: 0x06001C65 RID: 7269 RVA: 0x0000BDFD File Offset: 0x00009FFD
		public unsafe XmlSchemaDatatype datatype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_datatype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_datatype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x0008B348 File Offset: 0x00089548
		// (set) Token: 0x06001C67 RID: 7271 RVA: 0x0000BE1C File Offset: 0x0000A01C
		public unsafe string defaultValueRaw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_defaultValueRaw);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_defaultValueRaw), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x0008B370 File Offset: 0x00089570
		// (set) Token: 0x06001C69 RID: 7273 RVA: 0x0000BE3B File Offset: 0x0000A03B
		public unsafe Object defaultValueTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_defaultValueTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_defaultValueTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x0008B3A0 File Offset: 0x000895A0
		// (set) Token: 0x06001C6B RID: 7275 RVA: 0x0000BE5A File Offset: 0x0000A05A
		public unsafe long maxLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_maxLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_maxLength)) = value;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x0008B3C8 File Offset: 0x000895C8
		// (set) Token: 0x06001C6D RID: 7277 RVA: 0x0000BE75 File Offset: 0x0000A075
		public unsafe long minLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_minLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_minLength)) = value;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001C6E RID: 7278 RVA: 0x0008B3F0 File Offset: 0x000895F0
		// (set) Token: 0x06001C6F RID: 7279 RVA: 0x0000BE90 File Offset: 0x0000A090
		public unsafe List<string> values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaDeclBase.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeFieldInfoPtr_prefix;

		// Token: 0x04001528 RID: 5416
		private static readonly IntPtr NativeFieldInfoPtr_isDeclaredInExternal;

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeFieldInfoPtr_presence;

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeFieldInfoPtr_schemaType;

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeFieldInfoPtr_datatype;

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeFieldInfoPtr_defaultValueRaw;

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeFieldInfoPtr_defaultValueTyped;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeFieldInfoPtr_maxLength;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeFieldInfoPtr_minLength;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlQualifiedName_String_0;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Internal_set_Void_XmlQualifiedName_0;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Internal_get_String_0;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr_set_Prefix_Internal_set_Void_String_0;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDeclaredInExternal_Internal_get_Boolean_0;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDeclaredInExternal_Internal_set_Void_Boolean_0;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeMethodInfoPtr_get_Presence_Internal_get_Use_0;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr_set_Presence_Internal_set_Void_Use_0;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxLength_Internal_get_Int64_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxLength_Internal_set_Void_Int64_0;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr_get_MinLength_Internal_get_Int64_0;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeMethodInfoPtr_set_MinLength_Internal_set_Void_Int64_0;

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Internal_get_XmlSchemaType_0;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_XmlSchemaType_0;

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeMethodInfoPtr_get_Datatype_Internal_get_XmlSchemaDatatype_0;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeMethodInfoPtr_set_Datatype_Internal_set_Void_XmlSchemaDatatype_0;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Internal_Void_String_0;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Internal_get_List_1_String_0;

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeMethodInfoPtr_set_Values_Internal_set_Void_List_1_String_0;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueRaw_Internal_get_String_0;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValueRaw_Internal_set_Void_String_0;

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueTyped_Internal_get_Object_0;

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValueTyped_Internal_set_Void_Object_0;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeMethodInfoPtr_CheckEnumeration_Internal_Boolean_Object_0;

		// Token: 0x0400154B RID: 5451
		private static readonly IntPtr NativeMethodInfoPtr_CheckValue_Internal_Boolean_Object_0;

		// Token: 0x02000236 RID: 566
		[OriginalName("System.Xml.dll", "", "Use")]
		public enum Use
		{
			// Token: 0x040022C2 RID: 8898
			Default,
			// Token: 0x040022C3 RID: 8899
			Required,
			// Token: 0x040022C4 RID: 8900
			Implied,
			// Token: 0x040022C5 RID: 8901
			Fixed,
			// Token: 0x040022C6 RID: 8902
			RequiredFixed
		}
	}
}
