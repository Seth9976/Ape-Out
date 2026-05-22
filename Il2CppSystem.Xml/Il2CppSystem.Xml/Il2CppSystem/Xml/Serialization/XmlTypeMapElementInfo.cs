using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E4 RID: 228
	public class XmlTypeMapElementInfo : Object
	{
		// Token: 0x06001354 RID: 4948 RVA: 0x000670AC File Offset: 0x000652AC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapElementInfo()
		{
			Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapElementInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr);
			XmlTypeMapElementInfo.NativeFieldInfoPtr__elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_elementName");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__namespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_namespace");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_form");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__member = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_member");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__choiceValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_choiceValue");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__isNullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_isNullable");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__nestingLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_nestingLevel");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__mappedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_mappedType");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_type");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__wrappedElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_wrappedElement");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__explicitOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_explicitOrder");
			XmlTypeMapElementInfo.NativeMethodInfoPtr__ctor_Public_Void_XmlTypeMapMember_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666309);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_TypeData_Public_get_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666310);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_ChoiceValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666311);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_ChoiceValue_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666312);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_ElementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666313);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_ElementName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666314);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666315);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666316);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_DataTypeNamespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666317);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_DataTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666318);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666319);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666320);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_MappedType_Public_get_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666321);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_MappedType_Public_set_Void_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666322);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666323);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_IsNullable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666324);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_NestingLevel_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666325);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_WrappedElement_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666326);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_WrappedElement_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666327);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_IsTextElement_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666328);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_IsTextElement_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666329);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_IsUnnamedAnyElement_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666330);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_IsUnnamedAnyElement_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666331);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_ExplicitOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666332);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_ExplicitOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666333);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666334);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666335);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x000673D4 File Offset: 0x000655D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 407370, RefRangeEnd = 407377, XrefRangeStart = 407366, XrefRangeEnd = 407370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapElementInfo(XmlTypeMapMember member, TypeData type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr__ctor_Public_Void_XmlTypeMapMember_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x00067434 File Offset: 0x00065634
		public unsafe TypeData TypeData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_TypeData_Public_get_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00067474 File Offset: 0x00065674
		// (set) Token: 0x06001358 RID: 4952 RVA: 0x000674B4 File Offset: 0x000656B4
		public unsafe Object ChoiceValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_ChoiceValue_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_ChoiceValue_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x000674F8 File Offset: 0x000656F8
		// (set) Token: 0x0600135A RID: 4954 RVA: 0x00067530 File Offset: 0x00065730
		public unsafe string ElementName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_ElementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_ElementName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x00067574 File Offset: 0x00065774
		// (set) Token: 0x0600135C RID: 4956 RVA: 0x000675AC File Offset: 0x000657AC
		public unsafe string Namespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x000675F0 File Offset: 0x000657F0
		public unsafe string DataTypeNamespace
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 407380, RefRangeEnd = 407383, XrefRangeStart = 407377, XrefRangeEnd = 407380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_DataTypeNamespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x00067628 File Offset: 0x00065828
		public unsafe string DataTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_DataTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x00067660 File Offset: 0x00065860
		// (set) Token: 0x06001360 RID: 4960 RVA: 0x0006769C File Offset: 0x0006589C
		public unsafe XmlSchemaForm Form
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x000676DC File Offset: 0x000658DC
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x0006771C File Offset: 0x0006591C
		public unsafe XmlTypeMapping MappedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_MappedType_Public_get_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_MappedType_Public_set_Void_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x00067760 File Offset: 0x00065960
		// (set) Token: 0x06001364 RID: 4964 RVA: 0x0006779C File Offset: 0x0006599C
		public unsafe bool IsNullable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_IsNullable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700066F RID: 1647
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x000677DC File Offset: 0x000659DC
		public unsafe int NestingLevel
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_NestingLevel_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x0006781C File Offset: 0x00065A1C
		// (set) Token: 0x06001367 RID: 4967 RVA: 0x00067858 File Offset: 0x00065A58
		public unsafe bool WrappedElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_WrappedElement_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_WrappedElement_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x00067898 File Offset: 0x00065A98
		// (set) Token: 0x06001369 RID: 4969 RVA: 0x000678D4 File Offset: 0x00065AD4
		public unsafe bool IsTextElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407383, XrefRangeEnd = 407385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_IsTextElement_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407385, XrefRangeEnd = 407389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_IsTextElement_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x00067914 File Offset: 0x00065B14
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x00067950 File Offset: 0x00065B50
		public unsafe bool IsUnnamedAnyElement
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 407391, RefRangeEnd = 407393, XrefRangeStart = 407389, XrefRangeEnd = 407391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_IsUnnamedAnyElement_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 407396, RefRangeEnd = 407397, XrefRangeStart = 407393, XrefRangeEnd = 407396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_IsUnnamedAnyElement_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x00067990 File Offset: 0x00065B90
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x000679CC File Offset: 0x00065BCC
		public unsafe int ExplicitOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_ExplicitOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_ExplicitOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00067A0C File Offset: 0x00065C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407397, XrefRangeEnd = 407399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTypeMapElementInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00067A64 File Offset: 0x00065C64
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTypeMapElementInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00008914 File Offset: 0x00006B14
		public XmlTypeMapElementInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x00067AAC File Offset: 0x00065CAC
		// (set) Token: 0x06001372 RID: 4978 RVA: 0x0000891D File Offset: 0x00006B1D
		public unsafe string _elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x00067AD4 File Offset: 0x00065CD4
		// (set) Token: 0x06001374 RID: 4980 RVA: 0x0000893C File Offset: 0x00006B3C
		public unsafe string _namespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__namespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__namespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x00067AFC File Offset: 0x00065CFC
		// (set) Token: 0x06001376 RID: 4982 RVA: 0x0000895B File Offset: 0x00006B5B
		public unsafe XmlSchemaForm _form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__form);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__form)) = value;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001377 RID: 4983 RVA: 0x00067B24 File Offset: 0x00065D24
		// (set) Token: 0x06001378 RID: 4984 RVA: 0x00008976 File Offset: 0x00006B76
		public unsafe XmlTypeMapMember _member
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__member);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMember>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__member), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x00067B54 File Offset: 0x00065D54
		// (set) Token: 0x0600137A RID: 4986 RVA: 0x00008995 File Offset: 0x00006B95
		public unsafe Object _choiceValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__choiceValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__choiceValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x00067B84 File Offset: 0x00065D84
		// (set) Token: 0x0600137C RID: 4988 RVA: 0x000089B4 File Offset: 0x00006BB4
		public unsafe bool _isNullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__isNullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__isNullable)) = value;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x00067BAC File Offset: 0x00065DAC
		// (set) Token: 0x0600137E RID: 4990 RVA: 0x000089CF File Offset: 0x00006BCF
		public unsafe int _nestingLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__nestingLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__nestingLevel)) = value;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x00067BD4 File Offset: 0x00065DD4
		// (set) Token: 0x06001380 RID: 4992 RVA: 0x000089EA File Offset: 0x00006BEA
		public unsafe XmlTypeMapping _mappedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__mappedType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__mappedType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x00067C04 File Offset: 0x00065E04
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x00008A09 File Offset: 0x00006C09
		public unsafe TypeData _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x00067C34 File Offset: 0x00065E34
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x00008A28 File Offset: 0x00006C28
		public unsafe bool _wrappedElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__wrappedElement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__wrappedElement)) = value;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x00067C5C File Offset: 0x00065E5C
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x00008A43 File Offset: 0x00006C43
		public unsafe int _explicitOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__explicitOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__explicitOrder)) = value;
			}
		}

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeFieldInfoPtr__elementName;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeFieldInfoPtr__namespace;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeFieldInfoPtr__form;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeFieldInfoPtr__member;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeFieldInfoPtr__choiceValue;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeFieldInfoPtr__isNullable;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeFieldInfoPtr__nestingLevel;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeFieldInfoPtr__mappedType;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeFieldInfoPtr__wrappedElement;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeFieldInfoPtr__explicitOrder;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlTypeMapMember_TypeData_0;

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeData_Public_get_TypeData_0;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeMethodInfoPtr_get_ChoiceValue_Public_get_Object_0;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeMethodInfoPtr_set_ChoiceValue_Public_set_Void_Object_0;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementName_Public_get_String_0;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeMethodInfoPtr_set_ElementName_Public_set_Void_String_0;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeMethodInfoPtr_get_DataTypeNamespace_Public_get_String_0;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeMethodInfoPtr_get_DataTypeName_Public_get_String_0;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeMethodInfoPtr_get_MappedType_Public_get_XmlTypeMapping_0;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeMethodInfoPtr_set_MappedType_Public_set_Void_XmlTypeMapping_0;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeMethodInfoPtr_set_IsNullable_Public_set_Void_Boolean_0;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeMethodInfoPtr_set_NestingLevel_Public_set_Void_Int32_0;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeMethodInfoPtr_get_WrappedElement_Public_get_Boolean_0;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeMethodInfoPtr_set_WrappedElement_Public_set_Void_Boolean_0;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTextElement_Public_get_Boolean_0;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeMethodInfoPtr_set_IsTextElement_Public_set_Void_Boolean_0;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnnamedAnyElement_Public_get_Boolean_0;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeMethodInfoPtr_set_IsUnnamedAnyElement_Public_set_Void_Boolean_0;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeMethodInfoPtr_get_ExplicitOrder_Public_get_Int32_0;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeMethodInfoPtr_set_ExplicitOrder_Public_set_Void_Int32_0;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
