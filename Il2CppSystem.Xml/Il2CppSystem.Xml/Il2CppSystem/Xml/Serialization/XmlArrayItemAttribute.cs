using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000C7 RID: 199
	public class XmlArrayItemAttribute : Attribute
	{
		// Token: 0x0600119C RID: 4508 RVA: 0x00060340 File Offset: 0x0005E540
		// Note: this type is marked as 'beforefieldinit'.
		static XmlArrayItemAttribute()
		{
			Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlArrayItemAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr);
			XmlArrayItemAttribute.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, "dataType");
			XmlArrayItemAttribute.NativeFieldInfoPtr_elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, "elementName");
			XmlArrayItemAttribute.NativeFieldInfoPtr_form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, "form");
			XmlArrayItemAttribute.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, "ns");
			XmlArrayItemAttribute.NativeFieldInfoPtr_isNullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, "isNullable");
			XmlArrayItemAttribute.NativeFieldInfoPtr_isNullableSpecified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, "isNullableSpecified");
			XmlArrayItemAttribute.NativeFieldInfoPtr_nestingLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, "nestingLevel");
			XmlArrayItemAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, "type");
			XmlArrayItemAttribute.NativeMethodInfoPtr_get_DataType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666093);
			XmlArrayItemAttribute.NativeMethodInfoPtr_get_ElementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666094);
			XmlArrayItemAttribute.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666095);
			XmlArrayItemAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666096);
			XmlArrayItemAttribute.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666097);
			XmlArrayItemAttribute.NativeMethodInfoPtr_get_IsNullableSpecified_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666098);
			XmlArrayItemAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666099);
			XmlArrayItemAttribute.NativeMethodInfoPtr_get_NestingLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666100);
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x000604B0 File Offset: 0x0005E6B0
		public unsafe string DataType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 404750, RefRangeEnd = 404751, XrefRangeStart = 404748, XrefRangeEnd = 404750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_get_DataType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x000604E8 File Offset: 0x0005E6E8
		public unsafe string ElementName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 404753, RefRangeEnd = 404755, XrefRangeStart = 404751, XrefRangeEnd = 404753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_get_ElementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x00060520 File Offset: 0x0005E720
		public unsafe XmlSchemaForm Form
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x0006055C File Offset: 0x0005E75C
		public unsafe string Namespace
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x00060594 File Offset: 0x0005E794
		public unsafe bool IsNullable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x000605D0 File Offset: 0x0005E7D0
		public unsafe bool IsNullableSpecified
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_get_IsNullableSpecified_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x0006060C File Offset: 0x0005E80C
		public unsafe Type Type
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x0006064C File Offset: 0x0005E84C
		public unsafe int NestingLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_get_NestingLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00007D09 File Offset: 0x00005F09
		public XmlArrayItemAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00060688 File Offset: 0x0005E888
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x00007D12 File Offset: 0x00005F12
		public unsafe string dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_dataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_dataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x000606B0 File Offset: 0x0005E8B0
		// (set) Token: 0x060011A9 RID: 4521 RVA: 0x00007D31 File Offset: 0x00005F31
		public unsafe string elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x000606D8 File Offset: 0x0005E8D8
		// (set) Token: 0x060011AB RID: 4523 RVA: 0x00007D50 File Offset: 0x00005F50
		public unsafe XmlSchemaForm form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_form);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_form)) = value;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00060700 File Offset: 0x0005E900
		// (set) Token: 0x060011AD RID: 4525 RVA: 0x00007D6B File Offset: 0x00005F6B
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x00060728 File Offset: 0x0005E928
		// (set) Token: 0x060011AF RID: 4527 RVA: 0x00007D8A File Offset: 0x00005F8A
		public unsafe bool isNullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_isNullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_isNullable)) = value;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x00060750 File Offset: 0x0005E950
		// (set) Token: 0x060011B1 RID: 4529 RVA: 0x00007DA5 File Offset: 0x00005FA5
		public unsafe bool isNullableSpecified
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_isNullableSpecified);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_isNullableSpecified)) = value;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x00060778 File Offset: 0x0005E978
		// (set) Token: 0x060011B3 RID: 4531 RVA: 0x00007DC0 File Offset: 0x00005FC0
		public unsafe int nestingLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_nestingLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_nestingLevel)) = value;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x000607A0 File Offset: 0x0005E9A0
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x00007DDB File Offset: 0x00005FDB
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeFieldInfoPtr_elementName;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeFieldInfoPtr_form;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeFieldInfoPtr_isNullable;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeFieldInfoPtr_isNullableSpecified;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeFieldInfoPtr_nestingLevel;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_String_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementName_Public_get_String_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullableSpecified_Internal_get_Boolean_0;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeMethodInfoPtr_get_NestingLevel_Public_get_Int32_0;
	}
}
