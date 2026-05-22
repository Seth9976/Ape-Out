using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000F1 RID: 241
	public class ClassMap : ObjectMap
	{
		// Token: 0x06001423 RID: 5155 RVA: 0x00069D04 File Offset: 0x00067F04
		// Note: this type is marked as 'beforefieldinit'.
		static ClassMap()
		{
			Il2CppClassPointerStore<ClassMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "ClassMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassMap>.NativeClassPtr);
			ClassMap.NativeFieldInfoPtr__elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_elements");
			ClassMap.NativeFieldInfoPtr__elementMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_elementMembers");
			ClassMap.NativeFieldInfoPtr__attributeMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_attributeMembers");
			ClassMap.NativeFieldInfoPtr__attributeMembersArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_attributeMembersArray");
			ClassMap.NativeFieldInfoPtr__flatLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_flatLists");
			ClassMap.NativeFieldInfoPtr__allMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_allMembers");
			ClassMap.NativeFieldInfoPtr__membersWithDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_membersWithDefault");
			ClassMap.NativeFieldInfoPtr__listMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_listMembers");
			ClassMap.NativeFieldInfoPtr__defaultAnyElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_defaultAnyElement");
			ClassMap.NativeFieldInfoPtr__defaultAnyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_defaultAnyAttribute");
			ClassMap.NativeFieldInfoPtr__namespaceDeclarations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_namespaceDeclarations");
			ClassMap.NativeFieldInfoPtr__xmlTextCollector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_xmlTextCollector");
			ClassMap.NativeFieldInfoPtr__returnMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_returnMember");
			ClassMap.NativeFieldInfoPtr__ignoreMemberNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_ignoreMemberNamespace");
			ClassMap.NativeFieldInfoPtr__canBeSimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, "_canBeSimpleType");
			ClassMap.NativeMethodInfoPtr_AddMember_Public_Void_XmlTypeMapMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666404);
			ClassMap.NativeMethodInfoPtr_RegisterFlatList_Private_Void_XmlTypeMapMemberExpandable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666405);
			ClassMap.NativeMethodInfoPtr_BuildKey_Private_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666406);
			ClassMap.NativeMethodInfoPtr_get_DefaultAnyAttributeMember_Public_get_XmlTypeMapMemberAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666407);
			ClassMap.NativeMethodInfoPtr_get_NamespaceDeclarations_Public_get_XmlTypeMapMemberNamespaces_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666408);
			ClassMap.NativeMethodInfoPtr_get_AttributeMembers_Public_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666409);
			ClassMap.NativeMethodInfoPtr_get_ElementMembers_Public_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666410);
			ClassMap.NativeMethodInfoPtr_get_XmlTextCollector_Public_get_XmlTypeMapMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666411);
			ClassMap.NativeMethodInfoPtr_get_SimpleContentBaseType_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666412);
			ClassMap.NativeMethodInfoPtr_SetCanBeSimpleType_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666413);
			ClassMap.NativeMethodInfoPtr_get_HasSimpleContent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666414);
			ClassMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassMap>.NativeClassPtr, 100666415);
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x00069F50 File Offset: 0x00068150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407717, RefRangeEnd = 407718, XrefRangeStart = 407686, XrefRangeEnd = 407717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMember(XmlTypeMapMember member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_AddMember_Public_Void_XmlTypeMapMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00069F94 File Offset: 0x00068194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407718, XrefRangeEnd = 407723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterFlatList(XmlTypeMapMemberExpandable member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_RegisterFlatList_Private_Void_XmlTypeMapMemberExpandable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x00069FD8 File Offset: 0x000681D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407723, XrefRangeEnd = 407737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string BuildKey(string name, string ns, int explicitOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref explicitOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_BuildKey_Private_String_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0006A040 File Offset: 0x00068240
		public unsafe XmlTypeMapMemberAnyAttribute DefaultAnyAttributeMember
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_DefaultAnyAttributeMember_Public_get_XmlTypeMapMemberAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMemberAnyAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x0006A080 File Offset: 0x00068280
		public unsafe XmlTypeMapMemberNamespaces NamespaceDeclarations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_NamespaceDeclarations_Public_get_XmlTypeMapMemberNamespaces_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMemberNamespaces>(intPtr3) : null;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x0006A0C0 File Offset: 0x000682C0
		public unsafe ICollection AttributeMembers
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 407761, RefRangeEnd = 407762, XrefRangeStart = 407737, XrefRangeEnd = 407761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_AttributeMembers_Public_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x0006A100 File Offset: 0x00068300
		public unsafe ICollection ElementMembers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_ElementMembers_Public_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x0006A140 File Offset: 0x00068340
		public unsafe XmlTypeMapMember XmlTextCollector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_XmlTextCollector_Public_get_XmlTypeMapMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMember>(intPtr3) : null;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x0006A180 File Offset: 0x00068380
		public unsafe XmlQualifiedName SimpleContentBaseType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 407775, RefRangeEnd = 407776, XrefRangeStart = 407762, XrefRangeEnd = 407775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_SimpleContentBaseType_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0006A1C0 File Offset: 0x000683C0
		[CallerCount(0)]
		public unsafe void SetCanBeSimpleType(bool can)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref can;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_SetCanBeSimpleType_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x0006A200 File Offset: 0x00068400
		public unsafe bool HasSimpleContent
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 407784, RefRangeEnd = 407787, XrefRangeStart = 407776, XrefRangeEnd = 407784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr_get_HasSimpleContent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0006A23C File Offset: 0x0006843C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407787, XrefRangeEnd = 407795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClassMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClassMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x00008F62 File Offset: 0x00007162
		public ClassMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x0006A278 File Offset: 0x00068478
		// (set) Token: 0x06001432 RID: 5170 RVA: 0x00008F6B File Offset: 0x0000716B
		public unsafe Hashtable _elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x0006A2A8 File Offset: 0x000684A8
		// (set) Token: 0x06001434 RID: 5172 RVA: 0x00008F8A File Offset: 0x0000718A
		public unsafe ArrayList _elementMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__elementMembers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__elementMembers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x0006A2D8 File Offset: 0x000684D8
		// (set) Token: 0x06001436 RID: 5174 RVA: 0x00008FA9 File Offset: 0x000071A9
		public unsafe Hashtable _attributeMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__attributeMembers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__attributeMembers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x0006A308 File Offset: 0x00068508
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x00008FC8 File Offset: 0x000071C8
		public unsafe Il2CppReferenceArray<XmlTypeMapMemberAttribute> _attributeMembersArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__attributeMembersArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlTypeMapMemberAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__attributeMembersArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x0006A338 File Offset: 0x00068538
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x00008FE7 File Offset: 0x000071E7
		public unsafe ArrayList _flatLists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__flatLists);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__flatLists), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x0006A368 File Offset: 0x00068568
		// (set) Token: 0x0600143C RID: 5180 RVA: 0x00009006 File Offset: 0x00007206
		public unsafe ArrayList _allMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__allMembers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__allMembers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x0006A398 File Offset: 0x00068598
		// (set) Token: 0x0600143E RID: 5182 RVA: 0x00009025 File Offset: 0x00007225
		public unsafe ArrayList _membersWithDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__membersWithDefault);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__membersWithDefault), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x0006A3C8 File Offset: 0x000685C8
		// (set) Token: 0x06001440 RID: 5184 RVA: 0x00009044 File Offset: 0x00007244
		public unsafe ArrayList _listMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__listMembers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__listMembers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x0006A3F8 File Offset: 0x000685F8
		// (set) Token: 0x06001442 RID: 5186 RVA: 0x00009063 File Offset: 0x00007263
		public unsafe XmlTypeMapMemberAnyElement _defaultAnyElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__defaultAnyElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMemberAnyElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__defaultAnyElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x0006A428 File Offset: 0x00068628
		// (set) Token: 0x06001444 RID: 5188 RVA: 0x00009082 File Offset: 0x00007282
		public unsafe XmlTypeMapMemberAnyAttribute _defaultAnyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__defaultAnyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMemberAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__defaultAnyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x0006A458 File Offset: 0x00068658
		// (set) Token: 0x06001446 RID: 5190 RVA: 0x000090A1 File Offset: 0x000072A1
		public unsafe XmlTypeMapMemberNamespaces _namespaceDeclarations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__namespaceDeclarations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMemberNamespaces>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__namespaceDeclarations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x0006A488 File Offset: 0x00068688
		// (set) Token: 0x06001448 RID: 5192 RVA: 0x000090C0 File Offset: 0x000072C0
		public unsafe XmlTypeMapMember _xmlTextCollector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__xmlTextCollector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMember>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__xmlTextCollector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x0006A4B8 File Offset: 0x000686B8
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x000090DF File Offset: 0x000072DF
		public unsafe XmlTypeMapMember _returnMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__returnMember);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMember>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__returnMember), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x0006A4E8 File Offset: 0x000686E8
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x000090FE File Offset: 0x000072FE
		public unsafe bool _ignoreMemberNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__ignoreMemberNamespace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__ignoreMemberNamespace)) = value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x0006A510 File Offset: 0x00068710
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x00009119 File Offset: 0x00007319
		public unsafe bool _canBeSimpleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__canBeSimpleType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassMap.NativeFieldInfoPtr__canBeSimpleType)) = value;
			}
		}

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeFieldInfoPtr__elements;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeFieldInfoPtr__elementMembers;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeFieldInfoPtr__attributeMembers;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeFieldInfoPtr__attributeMembersArray;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeFieldInfoPtr__flatLists;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeFieldInfoPtr__allMembers;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeFieldInfoPtr__membersWithDefault;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeFieldInfoPtr__listMembers;

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeFieldInfoPtr__defaultAnyElement;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeFieldInfoPtr__defaultAnyAttribute;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeFieldInfoPtr__namespaceDeclarations;

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeFieldInfoPtr__xmlTextCollector;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeFieldInfoPtr__returnMember;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeFieldInfoPtr__ignoreMemberNamespace;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeFieldInfoPtr__canBeSimpleType;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr_AddMember_Public_Void_XmlTypeMapMember_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_RegisterFlatList_Private_Void_XmlTypeMapMemberExpandable_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr_BuildKey_Private_String_String_String_Int32_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultAnyAttributeMember_Public_get_XmlTypeMapMemberAnyAttribute_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceDeclarations_Public_get_XmlTypeMapMemberNamespaces_0;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeMembers_Public_get_ICollection_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementMembers_Public_get_ICollection_0;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlTextCollector_Public_get_XmlTypeMapMember_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr_get_SimpleContentBaseType_Public_get_XmlQualifiedName_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_SetCanBeSimpleType_Public_Void_Boolean_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSimpleContent_Public_get_Boolean_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
