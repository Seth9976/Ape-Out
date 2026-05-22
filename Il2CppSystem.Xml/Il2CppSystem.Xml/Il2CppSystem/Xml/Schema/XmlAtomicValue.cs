using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml.XPath;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000186 RID: 390
	public sealed class XmlAtomicValue : XPathItem
	{
		// Token: 0x06001FDA RID: 8154 RVA: 0x00097078 File Offset: 0x00095278
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAtomicValue()
		{
			Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlAtomicValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr);
			XmlAtomicValue.NativeFieldInfoPtr_xmlType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "xmlType");
			XmlAtomicValue.NativeFieldInfoPtr_objVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "objVal");
			XmlAtomicValue.NativeFieldInfoPtr_clrType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "clrType");
			XmlAtomicValue.NativeFieldInfoPtr_unionVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "unionVal");
			XmlAtomicValue.NativeFieldInfoPtr_nsPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "nsPrefix");
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667853);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667854);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667855);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667856);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667857);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667858);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667859);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667860);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667861);
			XmlAtomicValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667862);
			XmlAtomicValue.NativeMethodInfoPtr_get_XmlType_Public_Virtual_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667863);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667864);
			XmlAtomicValue.NativeMethodInfoPtr_get_TypedValue_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667865);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsBoolean_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667866);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667867);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsDouble_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667868);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsInt_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667869);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsLong_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667870);
			XmlAtomicValue.NativeMethodInfoPtr_ValueAs_Public_Virtual_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667871);
			XmlAtomicValue.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667872);
			XmlAtomicValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667873);
			XmlAtomicValue.NativeMethodInfoPtr_GetPrefixFromQName_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100667874);
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x000972C4 File Offset: 0x000954C4
		[CallerCount(0)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, bool value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x00097320 File Offset: 0x00095520
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425896, RefRangeEnd = 425898, XrefRangeStart = 425896, XrefRangeEnd = 425896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, DateTime value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x0009737C File Offset: 0x0009557C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425898, RefRangeEnd = 425900, XrefRangeStart = 425898, XrefRangeEnd = 425898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, double value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x000973D8 File Offset: 0x000955D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425900, RefRangeEnd = 425902, XrefRangeStart = 425900, XrefRangeEnd = 425900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, int value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x00097434 File Offset: 0x00095634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425902, RefRangeEnd = 425904, XrefRangeStart = 425902, XrefRangeEnd = 425902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, long value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00097490 File Offset: 0x00095690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425904, XrefRangeEnd = 425918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, string value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x000974F0 File Offset: 0x000956F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425918, XrefRangeEnd = 425945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00097560 File Offset: 0x00095760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425945, XrefRangeEnd = 425959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x000975C0 File Offset: 0x000957C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 425973, RefRangeEnd = 425976, XrefRangeStart = 425959, XrefRangeEnd = 425973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, Object value, IXmlNamespaceResolver nsResolver)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00097630 File Offset: 0x00095830
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x00097670 File Offset: 0x00095870
		public unsafe override XmlSchemaType XmlType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_XmlType_Public_Virtual_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x000976B0 File Offset: 0x000958B0
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425976, XrefRangeEnd = 425977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x000976F0 File Offset: 0x000958F0
		public unsafe override Object TypedValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425977, XrefRangeEnd = 425978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_TypedValue_Public_Virtual_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x00097730 File Offset: 0x00095930
		public unsafe override bool ValueAsBoolean
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425978, XrefRangeEnd = 425979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsBoolean_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x0009776C File Offset: 0x0009596C
		public unsafe override DateTime ValueAsDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425979, XrefRangeEnd = 425980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsDateTime_Public_Virtual_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06001FEA RID: 8170 RVA: 0x000977A8 File Offset: 0x000959A8
		public unsafe override double ValueAsDouble
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425980, XrefRangeEnd = 425981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsDouble_Public_Virtual_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x000977E4 File Offset: 0x000959E4
		public unsafe override int ValueAsInt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425981, XrefRangeEnd = 425982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsInt_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x00097820 File Offset: 0x00095A20
		public unsafe override long ValueAsLong
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425982, XrefRangeEnd = 425983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsLong_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x0009785C File Offset: 0x00095A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425983, XrefRangeEnd = 425995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ValueAs(Type type, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_ValueAs_Public_Virtual_Object_Type_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06001FEE RID: 8174 RVA: 0x000978C0 File Offset: 0x00095AC0
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425995, XrefRangeEnd = 425997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x000978F8 File Offset: 0x00095AF8
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00097930 File Offset: 0x00095B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425997, XrefRangeEnd = 426010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPrefixFromQName(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_GetPrefixFromQName_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x0000DE34 File Offset: 0x0000C034
		public XmlAtomicValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x00097978 File Offset: 0x00095B78
		// (set) Token: 0x06001FF3 RID: 8179 RVA: 0x0000DE3D File Offset: 0x0000C03D
		public unsafe XmlSchemaType xmlType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_xmlType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_xmlType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x000979A8 File Offset: 0x00095BA8
		// (set) Token: 0x06001FF5 RID: 8181 RVA: 0x0000DE5C File Offset: 0x0000C05C
		public unsafe Object objVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_objVal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_objVal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x000979D8 File Offset: 0x00095BD8
		// (set) Token: 0x06001FF7 RID: 8183 RVA: 0x0000DE7B File Offset: 0x0000C07B
		public unsafe TypeCode clrType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_clrType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_clrType)) = value;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06001FF8 RID: 8184 RVA: 0x00097A00 File Offset: 0x00095C00
		// (set) Token: 0x06001FF9 RID: 8185 RVA: 0x0000DE96 File Offset: 0x0000C096
		public unsafe XmlAtomicValue.Union unionVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_unionVal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_unionVal)) = value;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06001FFA RID: 8186 RVA: 0x00097A28 File Offset: 0x00095C28
		// (set) Token: 0x06001FFB RID: 8187 RVA: 0x0000DEB1 File Offset: 0x0000C0B1
		public unsafe XmlAtomicValue.NamespacePrefixForQName nsPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_nsPrefix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlAtomicValue.NamespacePrefixForQName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_nsPrefix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017A8 RID: 6056
		private static readonly IntPtr NativeFieldInfoPtr_xmlType;

		// Token: 0x040017A9 RID: 6057
		private static readonly IntPtr NativeFieldInfoPtr_objVal;

		// Token: 0x040017AA RID: 6058
		private static readonly IntPtr NativeFieldInfoPtr_clrType;

		// Token: 0x040017AB RID: 6059
		private static readonly IntPtr NativeFieldInfoPtr_unionVal;

		// Token: 0x040017AC RID: 6060
		private static readonly IntPtr NativeFieldInfoPtr_nsPrefix;

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Boolean_0;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_DateTime_0;

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Double_0;

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int32_0;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int64_0;

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_0;

		// Token: 0x040017B3 RID: 6067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_IXmlNamespaceResolver_0;

		// Token: 0x040017B4 RID: 6068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_0;

		// Token: 0x040017B5 RID: 6069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_IXmlNamespaceResolver_0;

		// Token: 0x040017B6 RID: 6070
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x040017B7 RID: 6071
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Public_Virtual_get_XmlSchemaType_0;

		// Token: 0x040017B8 RID: 6072
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedValue_Public_Virtual_get_Object_0;

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsBoolean_Public_Virtual_get_Boolean_0;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsDouble_Public_Virtual_get_Double_0;

		// Token: 0x040017BD RID: 6077
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsInt_Public_Virtual_get_Int32_0;

		// Token: 0x040017BE RID: 6078
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsLong_Public_Virtual_get_Int64_0;

		// Token: 0x040017BF RID: 6079
		private static readonly IntPtr NativeMethodInfoPtr_ValueAs_Public_Virtual_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x040017C0 RID: 6080
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x040017C1 RID: 6081
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040017C2 RID: 6082
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefixFromQName_Private_String_String_0;

		// Token: 0x02000242 RID: 578
		[StructLayout(2)]
		public struct Union
		{
			// Token: 0x06002D36 RID: 11574 RVA: 0x000C8BE4 File Offset: 0x000C6DE4
			// Note: this type is marked as 'beforefieldinit'.
			static Union()
			{
				Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "Union");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr);
				XmlAtomicValue.Union.NativeFieldInfoPtr_boolVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, "boolVal");
				XmlAtomicValue.Union.NativeFieldInfoPtr_dblVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, "dblVal");
				XmlAtomicValue.Union.NativeFieldInfoPtr_i64Val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, "i64Val");
				XmlAtomicValue.Union.NativeFieldInfoPtr_i32Val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, "i32Val");
				XmlAtomicValue.Union.NativeFieldInfoPtr_dtVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, "dtVal");
			}

			// Token: 0x06002D37 RID: 11575 RVA: 0x00013937 File Offset: 0x00011B37
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, ref this));
			}

			// Token: 0x04002393 RID: 9107
			private static readonly IntPtr NativeFieldInfoPtr_boolVal;

			// Token: 0x04002394 RID: 9108
			private static readonly IntPtr NativeFieldInfoPtr_dblVal;

			// Token: 0x04002395 RID: 9109
			private static readonly IntPtr NativeFieldInfoPtr_i64Val;

			// Token: 0x04002396 RID: 9110
			private static readonly IntPtr NativeFieldInfoPtr_i32Val;

			// Token: 0x04002397 RID: 9111
			private static readonly IntPtr NativeFieldInfoPtr_dtVal;

			// Token: 0x04002398 RID: 9112
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool boolVal;

			// Token: 0x04002399 RID: 9113
			[FieldOffset(0)]
			public double dblVal;

			// Token: 0x0400239A RID: 9114
			[FieldOffset(0)]
			public long i64Val;

			// Token: 0x0400239B RID: 9115
			[FieldOffset(0)]
			public int i32Val;

			// Token: 0x0400239C RID: 9116
			[FieldOffset(0)]
			public DateTime dtVal;
		}

		// Token: 0x02000243 RID: 579
		public class NamespacePrefixForQName : Object
		{
			// Token: 0x06002D38 RID: 11576 RVA: 0x000C8C74 File Offset: 0x000C6E74
			// Note: this type is marked as 'beforefieldinit'.
			static NamespacePrefixForQName()
			{
				Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "NamespacePrefixForQName");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr);
				XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, "prefix");
				XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, "ns");
				XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, 100667875);
				XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, 100667876);
				XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, 100667877);
				XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, 100667878);
			}

			// Token: 0x06002D39 RID: 11577 RVA: 0x000C8D18 File Offset: 0x000C6F18
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 425887, RefRangeEnd = 425889, XrefRangeStart = 425887, XrefRangeEnd = 425887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NamespacePrefixForQName(string prefix, string ns)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D3A RID: 11578 RVA: 0x000C8D78 File Offset: 0x000C6F78
			[CallerCount(0)]
			public unsafe virtual string LookupNamespace(string prefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002D3B RID: 11579 RVA: 0x000C8DC0 File Offset: 0x000C6FC0
			[CallerCount(0)]
			public unsafe virtual string LookupPrefix(string namespaceName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002D3C RID: 11580 RVA: 0x000C8E08 File Offset: 0x000C7008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425889, XrefRangeEnd = 425896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref scope;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
				}
			}

			// Token: 0x06002D3D RID: 11581 RVA: 0x00013949 File Offset: 0x00011B49
			public NamespacePrefixForQName(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F62 RID: 3938
			// (get) Token: 0x06002D3E RID: 11582 RVA: 0x000C8E54 File Offset: 0x000C7054
			// (set) Token: 0x06002D3F RID: 11583 RVA: 0x00013952 File Offset: 0x00011B52
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000F63 RID: 3939
			// (get) Token: 0x06002D40 RID: 11584 RVA: 0x000C8E7C File Offset: 0x000C707C
			// (set) Token: 0x06002D41 RID: 11585 RVA: 0x00013971 File Offset: 0x00011B71
			public unsafe string ns
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_ns);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400239D RID: 9117
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x0400239E RID: 9118
			private static readonly IntPtr NativeFieldInfoPtr_ns;

			// Token: 0x0400239F RID: 9119
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

			// Token: 0x040023A0 RID: 9120
			private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_Final_New_String_String_0;

			// Token: 0x040023A1 RID: 9121
			private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Virtual_Final_New_String_String_0;

			// Token: 0x040023A2 RID: 9122
			private static readonly IntPtr NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0;
		}
	}
}
