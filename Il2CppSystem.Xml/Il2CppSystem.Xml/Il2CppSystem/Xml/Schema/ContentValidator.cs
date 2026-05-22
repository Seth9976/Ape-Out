using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000114 RID: 276
	public class ContentValidator : Object
	{
		// Token: 0x06001654 RID: 5716 RVA: 0x00072208 File Offset: 0x00070408
		// Note: this type is marked as 'beforefieldinit'.
		static ContentValidator()
		{
			Il2CppClassPointerStore<ContentValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ContentValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr);
			ContentValidator.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "contentType");
			ContentValidator.NativeFieldInfoPtr_isOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "isOpen");
			ContentValidator.NativeFieldInfoPtr_isEmptiable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "isEmptiable");
			ContentValidator.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "Empty");
			ContentValidator.NativeFieldInfoPtr_TextOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "TextOnly");
			ContentValidator.NativeFieldInfoPtr_Mixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "Mixed");
			ContentValidator.NativeFieldInfoPtr_Any = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "Any");
			ContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100666663);
			ContentValidator.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaContentType_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100666664);
			ContentValidator.NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100666665);
			ContentValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100666666);
			ContentValidator.NativeMethodInfoPtr_get_IsEmptiable_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100666667);
			ContentValidator.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100666668);
			ContentValidator.NativeMethodInfoPtr_set_IsOpen_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100666669);
			ContentValidator.NativeMethodInfoPtr_InitValidation_Public_Virtual_New_Void_ValidationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100666670);
			ContentValidator.NativeMethodInfoPtr_ValidateElement_Public_Virtual_New_Object_XmlQualifiedName_ValidationState_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100666671);
			ContentValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_New_Boolean_ValidationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100666672);
			ContentValidator.NativeMethodInfoPtr_ExpectedElements_Public_Virtual_New_ArrayList_ValidationState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100666673);
			ContentValidator.NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_New_ArrayList_ValidationState_Boolean_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100666674);
			ContentValidator.NativeMethodInfoPtr_AddParticleToExpected_Public_Static_Void_XmlSchemaParticle_XmlSchemaSet_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100666675);
			ContentValidator.NativeMethodInfoPtr_AddParticleToExpected_Public_Static_Void_XmlSchemaParticle_XmlSchemaSet_ArrayList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100666676);
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x000723DC File Offset: 0x000705DC
		[CallerCount(0)]
		public unsafe ContentValidator(XmlSchemaContentType contentType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00072424 File Offset: 0x00070624
		[CallerCount(0)]
		public unsafe ContentValidator(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOpen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEmptiable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaContentType_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001657 RID: 5719 RVA: 0x00072488 File Offset: 0x00070688
		public unsafe XmlSchemaContentType ContentType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x000724C4 File Offset: 0x000706C4
		public unsafe bool PreserveWhitespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x00072500 File Offset: 0x00070700
		public unsafe virtual bool IsEmptiable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentValidator.NativeMethodInfoPtr_get_IsEmptiable_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x00072548 File Offset: 0x00070748
		// (set) Token: 0x0600165B RID: 5723 RVA: 0x00072584 File Offset: 0x00070784
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr_set_IsOpen_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x000725C4 File Offset: 0x000707C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitValidation(ValidationState context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentValidator.NativeMethodInfoPtr_InitValidation_Public_Virtual_New_Void_ValidationState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00072614 File Offset: 0x00070814
		[CallerCount(0)]
		public unsafe virtual Object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentValidator.NativeMethodInfoPtr_ValidateElement_Public_Virtual_New_Object_XmlQualifiedName_ValidationState_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00072690 File Offset: 0x00070890
		[CallerCount(0)]
		public unsafe virtual bool CompleteValidation(ValidationState context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_New_Boolean_ValidationState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x000726E8 File Offset: 0x000708E8
		[CallerCount(0)]
		public unsafe virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRequiredOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentValidator.NativeMethodInfoPtr_ExpectedElements_Public_Virtual_New_ArrayList_ValidationState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00072754 File Offset: 0x00070954
		[CallerCount(0)]
		public unsafe virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRequiredOnly;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentValidator.NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_New_ArrayList_ValidationState_Boolean_XmlSchemaSet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x000727D0 File Offset: 0x000709D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 409531, RefRangeEnd = 409535, XrefRangeStart = 409527, XrefRangeEnd = 409531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr_AddParticleToExpected_Public_Static_Void_XmlSchemaParticle_XmlSchemaSet_ArrayList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x0007282C File Offset: 0x00070A2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 409543, RefRangeEnd = 409544, XrefRangeStart = 409535, XrefRangeEnd = 409543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particles);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref global;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr_AddParticleToExpected_Public_Static_Void_XmlSchemaParticle_XmlSchemaSet_ArrayList_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00009EBD File Offset: 0x000080BD
		public ContentValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x00072894 File Offset: 0x00070A94
		// (set) Token: 0x06001665 RID: 5733 RVA: 0x00009EC6 File Offset: 0x000080C6
		public unsafe XmlSchemaContentType contentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_contentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_contentType)) = value;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x000728BC File Offset: 0x00070ABC
		// (set) Token: 0x06001667 RID: 5735 RVA: 0x00009EE1 File Offset: 0x000080E1
		public unsafe bool isOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_isOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_isOpen)) = value;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x000728E4 File Offset: 0x00070AE4
		// (set) Token: 0x06001669 RID: 5737 RVA: 0x00009EFC File Offset: 0x000080FC
		public unsafe bool isEmptiable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_isEmptiable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_isEmptiable)) = value;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x0007290C File Offset: 0x00070B0C
		// (set) Token: 0x0600166B RID: 5739 RVA: 0x00009F17 File Offset: 0x00008117
		public unsafe static ContentValidator Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContentValidator.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContentValidator.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x00072934 File Offset: 0x00070B34
		// (set) Token: 0x0600166D RID: 5741 RVA: 0x00009F29 File Offset: 0x00008129
		public unsafe static ContentValidator TextOnly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContentValidator.NativeFieldInfoPtr_TextOnly, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContentValidator.NativeFieldInfoPtr_TextOnly, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x0007295C File Offset: 0x00070B5C
		// (set) Token: 0x0600166F RID: 5743 RVA: 0x00009F3B File Offset: 0x0000813B
		public unsafe static ContentValidator Mixed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContentValidator.NativeFieldInfoPtr_Mixed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContentValidator.NativeFieldInfoPtr_Mixed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x00072984 File Offset: 0x00070B84
		// (set) Token: 0x06001671 RID: 5745 RVA: 0x00009F4D File Offset: 0x0000814D
		public unsafe static ContentValidator Any
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContentValidator.NativeFieldInfoPtr_Any, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContentValidator.NativeFieldInfoPtr_Any, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeFieldInfoPtr_contentType;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeFieldInfoPtr_isOpen;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeFieldInfoPtr_isEmptiable;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeFieldInfoPtr_TextOnly;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeFieldInfoPtr_Mixed;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeFieldInfoPtr_Any;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaContentType_Boolean_Boolean_0;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeMethodInfoPtr_get_PreserveWhitespace_Public_get_Boolean_0;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptiable_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Public_set_Void_Boolean_0;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeMethodInfoPtr_InitValidation_Public_Virtual_New_Void_ValidationState_0;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Public_Virtual_New_Object_XmlQualifiedName_ValidationState_byref_Int32_0;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidation_Public_Virtual_New_Boolean_ValidationState_0;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeMethodInfoPtr_ExpectedElements_Public_Virtual_New_ArrayList_ValidationState_Boolean_0;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeMethodInfoPtr_ExpectedParticles_Public_Virtual_New_ArrayList_ValidationState_Boolean_XmlSchemaSet_0;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeMethodInfoPtr_AddParticleToExpected_Public_Static_Void_XmlSchemaParticle_XmlSchemaSet_ArrayList_0;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeMethodInfoPtr_AddParticleToExpected_Public_Static_Void_XmlSchemaParticle_XmlSchemaSet_ArrayList_Boolean_0;
	}
}
