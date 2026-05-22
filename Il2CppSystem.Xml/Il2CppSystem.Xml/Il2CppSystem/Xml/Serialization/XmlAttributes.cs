using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000CB RID: 203
	public class XmlAttributes : Object
	{
		// Token: 0x060011D2 RID: 4562 RVA: 0x00060DD8 File Offset: 0x0005EFD8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAttributes()
		{
			Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr);
			XmlAttributes.NativeFieldInfoPtr_xmlAnyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlAnyAttribute");
			XmlAttributes.NativeFieldInfoPtr_xmlAnyElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlAnyElements");
			XmlAttributes.NativeFieldInfoPtr_xmlArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlArray");
			XmlAttributes.NativeFieldInfoPtr_xmlArrayItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlArrayItems");
			XmlAttributes.NativeFieldInfoPtr_xmlAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlAttribute");
			XmlAttributes.NativeFieldInfoPtr_xmlChoiceIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlChoiceIdentifier");
			XmlAttributes.NativeFieldInfoPtr_xmlDefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlDefaultValue");
			XmlAttributes.NativeFieldInfoPtr_xmlElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlElements");
			XmlAttributes.NativeFieldInfoPtr_xmlEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlEnum");
			XmlAttributes.NativeFieldInfoPtr_xmlIgnore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlIgnore");
			XmlAttributes.NativeFieldInfoPtr_xmlns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlns");
			XmlAttributes.NativeFieldInfoPtr_xmlRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlRoot");
			XmlAttributes.NativeFieldInfoPtr_xmlText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlText");
			XmlAttributes.NativeFieldInfoPtr_xmlType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlType");
			XmlAttributes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666113);
			XmlAttributes.NativeMethodInfoPtr__ctor_Public_Void_ICustomAttributeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666114);
			XmlAttributes.NativeMethodInfoPtr_get_XmlAnyAttribute_Public_get_XmlAnyAttributeAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666115);
			XmlAttributes.NativeMethodInfoPtr_get_XmlAnyElements_Public_get_XmlAnyElementAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666116);
			XmlAttributes.NativeMethodInfoPtr_get_XmlArray_Public_get_XmlArrayAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666117);
			XmlAttributes.NativeMethodInfoPtr_get_XmlArrayItems_Public_get_XmlArrayItemAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666118);
			XmlAttributes.NativeMethodInfoPtr_get_XmlAttribute_Public_get_XmlAttributeAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666119);
			XmlAttributes.NativeMethodInfoPtr_get_XmlChoiceIdentifier_Public_get_XmlChoiceIdentifierAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666120);
			XmlAttributes.NativeMethodInfoPtr_get_XmlDefaultValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666121);
			XmlAttributes.NativeMethodInfoPtr_get_XmlElements_Public_get_XmlElementAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666122);
			XmlAttributes.NativeMethodInfoPtr_get_XmlIgnore_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666123);
			XmlAttributes.NativeMethodInfoPtr_get_Xmlns_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666124);
			XmlAttributes.NativeMethodInfoPtr_get_XmlRoot_Public_get_XmlRootAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666125);
			XmlAttributes.NativeMethodInfoPtr_get_XmlText_Public_get_XmlTextAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666126);
			XmlAttributes.NativeMethodInfoPtr_get_XmlType_Public_get_XmlTypeAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666127);
			XmlAttributes.NativeMethodInfoPtr_get_Order_Internal_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666128);
			XmlAttributes.NativeMethodInfoPtr_get_SortableOrder_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666129);
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00061074 File Offset: 0x0005F274
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 404805, RefRangeEnd = 404807, XrefRangeStart = 404789, XrefRangeEnd = 404805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttributes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x000610B0 File Offset: 0x0005F2B0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 404886, RefRangeEnd = 404894, XrefRangeStart = 404807, XrefRangeEnd = 404886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttributes(ICustomAttributeProvider provider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr__ctor_Public_Void_ICustomAttributeProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x000610FC File Offset: 0x0005F2FC
		public unsafe XmlAnyAttributeAttribute XmlAnyAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlAnyAttribute_Public_get_XmlAnyAttributeAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAnyAttributeAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0006113C File Offset: 0x0005F33C
		public unsafe XmlAnyElementAttributes XmlAnyElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlAnyElements_Public_get_XmlAnyElementAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAnyElementAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0006117C File Offset: 0x0005F37C
		public unsafe XmlArrayAttribute XmlArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlArray_Public_get_XmlArrayAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlArrayAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x000611BC File Offset: 0x0005F3BC
		public unsafe XmlArrayItemAttributes XmlArrayItems
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlArrayItems_Public_get_XmlArrayItemAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlArrayItemAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x000611FC File Offset: 0x0005F3FC
		public unsafe XmlAttributeAttribute XmlAttribute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlAttribute_Public_get_XmlAttributeAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttributeAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x0006123C File Offset: 0x0005F43C
		public unsafe XmlChoiceIdentifierAttribute XmlChoiceIdentifier
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlChoiceIdentifier_Public_get_XmlChoiceIdentifierAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlChoiceIdentifierAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x0006127C File Offset: 0x0005F47C
		public unsafe Object XmlDefaultValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlDefaultValue_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x000612BC File Offset: 0x0005F4BC
		public unsafe XmlElementAttributes XmlElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlElements_Public_get_XmlElementAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlElementAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x000612FC File Offset: 0x0005F4FC
		public unsafe bool XmlIgnore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlIgnore_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x00061338 File Offset: 0x0005F538
		public unsafe bool Xmlns
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_Xmlns_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x00061374 File Offset: 0x0005F574
		public unsafe XmlRootAttribute XmlRoot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlRoot_Public_get_XmlRootAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlRootAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x000613B4 File Offset: 0x0005F5B4
		public unsafe XmlTextAttribute XmlText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlText_Public_get_XmlTextAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x000613F4 File Offset: 0x0005F5F4
		public unsafe XmlTypeAttribute XmlType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlType_Public_get_XmlTypeAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x00061434 File Offset: 0x0005F634
		public unsafe Nullable<int> Order
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 404896, RefRangeEnd = 404899, XrefRangeStart = 404894, XrefRangeEnd = 404896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_Order_Internal_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x0006146C File Offset: 0x0005F66C
		public unsafe int SortableOrder
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 404904, RefRangeEnd = 404906, XrefRangeStart = 404899, XrefRangeEnd = 404904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_SortableOrder_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00007EAC File Offset: 0x000060AC
		public XmlAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x000614A8 File Offset: 0x0005F6A8
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x00007EB5 File Offset: 0x000060B5
		public unsafe XmlAnyAttributeAttribute xmlAnyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlAnyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlAnyAttributeAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlAnyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x000614D8 File Offset: 0x0005F6D8
		// (set) Token: 0x060011E8 RID: 4584 RVA: 0x00007ED4 File Offset: 0x000060D4
		public unsafe XmlAnyElementAttributes xmlAnyElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlAnyElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlAnyElementAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlAnyElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x00061508 File Offset: 0x0005F708
		// (set) Token: 0x060011EA RID: 4586 RVA: 0x00007EF3 File Offset: 0x000060F3
		public unsafe XmlArrayAttribute xmlArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlArrayAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x00061538 File Offset: 0x0005F738
		// (set) Token: 0x060011EC RID: 4588 RVA: 0x00007F12 File Offset: 0x00006112
		public unsafe XmlArrayItemAttributes xmlArrayItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlArrayItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlArrayItemAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlArrayItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x00061568 File Offset: 0x0005F768
		// (set) Token: 0x060011EE RID: 4590 RVA: 0x00007F31 File Offset: 0x00006131
		public unsafe XmlAttributeAttribute xmlAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlAttributeAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x00061598 File Offset: 0x0005F798
		// (set) Token: 0x060011F0 RID: 4592 RVA: 0x00007F50 File Offset: 0x00006150
		public unsafe XmlChoiceIdentifierAttribute xmlChoiceIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlChoiceIdentifier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlChoiceIdentifierAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlChoiceIdentifier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x000615C8 File Offset: 0x0005F7C8
		// (set) Token: 0x060011F2 RID: 4594 RVA: 0x00007F6F File Offset: 0x0000616F
		public unsafe Object xmlDefaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlDefaultValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlDefaultValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x000615F8 File Offset: 0x0005F7F8
		// (set) Token: 0x060011F4 RID: 4596 RVA: 0x00007F8E File Offset: 0x0000618E
		public unsafe XmlElementAttributes xmlElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlElementAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x00061628 File Offset: 0x0005F828
		// (set) Token: 0x060011F6 RID: 4598 RVA: 0x00007FAD File Offset: 0x000061AD
		public unsafe XmlEnumAttribute xmlEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlEnum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlEnumAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x00061658 File Offset: 0x0005F858
		// (set) Token: 0x060011F8 RID: 4600 RVA: 0x00007FCC File Offset: 0x000061CC
		public unsafe bool xmlIgnore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlIgnore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlIgnore)) = value;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x00061680 File Offset: 0x0005F880
		// (set) Token: 0x060011FA RID: 4602 RVA: 0x00007FE7 File Offset: 0x000061E7
		public unsafe bool xmlns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlns);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlns)) = value;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x000616A8 File Offset: 0x0005F8A8
		// (set) Token: 0x060011FC RID: 4604 RVA: 0x00008002 File Offset: 0x00006202
		public unsafe XmlRootAttribute xmlRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlRootAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x000616D8 File Offset: 0x0005F8D8
		// (set) Token: 0x060011FE RID: 4606 RVA: 0x00008021 File Offset: 0x00006221
		public unsafe XmlTextAttribute xmlText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x00061708 File Offset: 0x0005F908
		// (set) Token: 0x06001200 RID: 4608 RVA: 0x00008040 File Offset: 0x00006240
		public unsafe XmlTypeAttribute xmlType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeFieldInfoPtr_xmlAnyAttribute;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeFieldInfoPtr_xmlAnyElements;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeFieldInfoPtr_xmlArray;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeFieldInfoPtr_xmlArrayItems;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeFieldInfoPtr_xmlAttribute;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeFieldInfoPtr_xmlChoiceIdentifier;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeFieldInfoPtr_xmlDefaultValue;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeFieldInfoPtr_xmlElements;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeFieldInfoPtr_xmlEnum;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeFieldInfoPtr_xmlIgnore;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeFieldInfoPtr_xmlns;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeFieldInfoPtr_xmlRoot;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeFieldInfoPtr_xmlText;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeFieldInfoPtr_xmlType;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ICustomAttributeProvider_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlAnyAttribute_Public_get_XmlAnyAttributeAttribute_0;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlAnyElements_Public_get_XmlAnyElementAttributes_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlArray_Public_get_XmlArrayAttribute_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlArrayItems_Public_get_XmlArrayItemAttributes_0;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlAttribute_Public_get_XmlAttributeAttribute_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlChoiceIdentifier_Public_get_XmlChoiceIdentifierAttribute_0;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlDefaultValue_Public_get_Object_0;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlElements_Public_get_XmlElementAttributes_0;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlIgnore_Public_get_Boolean_0;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeMethodInfoPtr_get_Xmlns_Public_get_Boolean_0;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlRoot_Public_get_XmlRootAttribute_0;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlText_Public_get_XmlTextAttribute_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Public_get_XmlTypeAttribute_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Internal_get_Nullable_1_Int32_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_get_SortableOrder_Internal_get_Int32_0;
	}
}
