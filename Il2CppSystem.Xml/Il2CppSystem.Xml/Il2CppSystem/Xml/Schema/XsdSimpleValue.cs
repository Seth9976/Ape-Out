using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200011C RID: 284
	public class XsdSimpleValue : Object
	{
		// Token: 0x060016E9 RID: 5865 RVA: 0x000747E8 File Offset: 0x000729E8
		// Note: this type is marked as 'beforefieldinit'.
		static XsdSimpleValue()
		{
			Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdSimpleValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr);
			XsdSimpleValue.NativeFieldInfoPtr_xmlType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, "xmlType");
			XsdSimpleValue.NativeFieldInfoPtr_typedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, "typedValue");
			XsdSimpleValue.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaSimpleType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, 100666730);
			XsdSimpleValue.NativeMethodInfoPtr_get_XmlType_Public_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, 100666731);
			XsdSimpleValue.NativeMethodInfoPtr_get_TypedValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, 100666732);
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x0007487C File Offset: 0x00072A7C
		[CallerCount(76)]
		[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdSimpleValue(XmlSchemaSimpleType st, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdSimpleValue.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaSimpleType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060016EB RID: 5867 RVA: 0x000748DC File Offset: 0x00072ADC
		public unsafe XmlSchemaSimpleType XmlType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdSimpleValue.NativeMethodInfoPtr_get_XmlType_Public_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x0007491C File Offset: 0x00072B1C
		public unsafe Object TypedValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdSimpleValue.NativeMethodInfoPtr_get_TypedValue_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x0000A2D0 File Offset: 0x000084D0
		public XsdSimpleValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x0007495C File Offset: 0x00072B5C
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x0000A2D9 File Offset: 0x000084D9
		public unsafe XmlSchemaSimpleType xmlType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdSimpleValue.NativeFieldInfoPtr_xmlType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdSimpleValue.NativeFieldInfoPtr_xmlType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x0007498C File Offset: 0x00072B8C
		// (set) Token: 0x060016F1 RID: 5873 RVA: 0x0000A2F8 File Offset: 0x000084F8
		public unsafe Object typedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdSimpleValue.NativeFieldInfoPtr_typedValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdSimpleValue.NativeFieldInfoPtr_typedValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeFieldInfoPtr_xmlType;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeFieldInfoPtr_typedValue;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaSimpleType_Object_0;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Public_get_XmlSchemaSimpleType_0;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedValue_Public_get_Object_0;
	}
}
