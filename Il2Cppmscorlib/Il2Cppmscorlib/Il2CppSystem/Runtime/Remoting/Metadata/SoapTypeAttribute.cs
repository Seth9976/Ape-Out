using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Metadata
{
	// Token: 0x020003DD RID: 989
	public sealed class SoapTypeAttribute : SoapAttribute
	{
		// Token: 0x06003FBD RID: 16317 RVA: 0x0012B278 File Offset: 0x00129478
		// Note: this type is marked as 'beforefieldinit'.
		static SoapTypeAttribute()
		{
			Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Metadata", "SoapTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr);
			SoapTypeAttribute.NativeFieldInfoPtr__useAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_useAttribute");
			SoapTypeAttribute.NativeFieldInfoPtr__xmlElementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_xmlElementName");
			SoapTypeAttribute.NativeFieldInfoPtr__xmlNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_xmlNamespace");
			SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_xmlTypeName");
			SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_xmlTypeNamespace");
			SoapTypeAttribute.NativeFieldInfoPtr__isType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_isType");
			SoapTypeAttribute.NativeFieldInfoPtr__isElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_isElement");
			SoapTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672699);
			SoapTypeAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672700);
			SoapTypeAttribute.NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672701);
			SoapTypeAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672702);
			SoapTypeAttribute.NativeMethodInfoPtr_get_XmlTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672703);
			SoapTypeAttribute.NativeMethodInfoPtr_get_XmlTypeNamespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672704);
			SoapTypeAttribute.NativeMethodInfoPtr_get_IsInteropXmlElement_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672705);
			SoapTypeAttribute.NativeMethodInfoPtr_get_IsInteropXmlType_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672706);
			SoapTypeAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100672707);
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x0012B3E8 File Offset: 0x001295E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoapTypeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06003FBF RID: 16319 RVA: 0x0012B424 File Offset: 0x00129624
		public unsafe override bool UseAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06003FC0 RID: 16320 RVA: 0x0012B460 File Offset: 0x00129660
		public unsafe string XmlElementName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06003FC1 RID: 16321 RVA: 0x0012B498 File Offset: 0x00129698
		public unsafe override string XmlNamespace
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06003FC2 RID: 16322 RVA: 0x0012B4D0 File Offset: 0x001296D0
		public unsafe string XmlTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_XmlTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06003FC3 RID: 16323 RVA: 0x0012B508 File Offset: 0x00129708
		public unsafe string XmlTypeNamespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_XmlTypeNamespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06003FC4 RID: 16324 RVA: 0x0012B540 File Offset: 0x00129740
		public unsafe bool IsInteropXmlElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_IsInteropXmlElement_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06003FC5 RID: 16325 RVA: 0x0012B57C File Offset: 0x0012977C
		public unsafe bool IsInteropXmlType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_IsInteropXmlType_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003FC6 RID: 16326 RVA: 0x0012B5B8 File Offset: 0x001297B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223687, XrefRangeEnd = 223702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetReflectionObject(Object reflectionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x00017DE5 File Offset: 0x00015FE5
		public SoapTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06003FC8 RID: 16328 RVA: 0x0012B5FC File Offset: 0x001297FC
		// (set) Token: 0x06003FC9 RID: 16329 RVA: 0x00017DEE File Offset: 0x00015FEE
		public new unsafe bool _useAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__useAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__useAttribute)) = value;
			}
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06003FCA RID: 16330 RVA: 0x0012B624 File Offset: 0x00129824
		// (set) Token: 0x06003FCB RID: 16331 RVA: 0x00017E09 File Offset: 0x00016009
		public unsafe string _xmlElementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlElementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlElementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06003FCC RID: 16332 RVA: 0x0012B64C File Offset: 0x0012984C
		// (set) Token: 0x06003FCD RID: 16333 RVA: 0x00017E28 File Offset: 0x00016028
		public unsafe string _xmlNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06003FCE RID: 16334 RVA: 0x0012B674 File Offset: 0x00129874
		// (set) Token: 0x06003FCF RID: 16335 RVA: 0x00017E47 File Offset: 0x00016047
		public unsafe string _xmlTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06003FD0 RID: 16336 RVA: 0x0012B69C File Offset: 0x0012989C
		// (set) Token: 0x06003FD1 RID: 16337 RVA: 0x00017E66 File Offset: 0x00016066
		public unsafe string _xmlTypeNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06003FD2 RID: 16338 RVA: 0x0012B6C4 File Offset: 0x001298C4
		// (set) Token: 0x06003FD3 RID: 16339 RVA: 0x00017E85 File Offset: 0x00016085
		public unsafe bool _isType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__isType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__isType)) = value;
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06003FD4 RID: 16340 RVA: 0x0012B6EC File Offset: 0x001298EC
		// (set) Token: 0x06003FD5 RID: 16341 RVA: 0x00017EA0 File Offset: 0x000160A0
		public unsafe bool _isElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__isElement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__isElement)) = value;
			}
		}

		// Token: 0x04003466 RID: 13414
		private static readonly IntPtr NativeFieldInfoPtr__useAttribute;

		// Token: 0x04003467 RID: 13415
		private static readonly IntPtr NativeFieldInfoPtr__xmlElementName;

		// Token: 0x04003468 RID: 13416
		private static readonly IntPtr NativeFieldInfoPtr__xmlNamespace;

		// Token: 0x04003469 RID: 13417
		private static readonly IntPtr NativeFieldInfoPtr__xmlTypeName;

		// Token: 0x0400346A RID: 13418
		private static readonly IntPtr NativeFieldInfoPtr__xmlTypeNamespace;

		// Token: 0x0400346B RID: 13419
		private static readonly IntPtr NativeFieldInfoPtr__isType;

		// Token: 0x0400346C RID: 13420
		private static readonly IntPtr NativeFieldInfoPtr__isElement;

		// Token: 0x0400346D RID: 13421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400346E RID: 13422
		private static readonly IntPtr NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0;

		// Token: 0x0400346F RID: 13423
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0;

		// Token: 0x04003470 RID: 13424
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0;

		// Token: 0x04003471 RID: 13425
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlTypeName_Public_get_String_0;

		// Token: 0x04003472 RID: 13426
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlTypeNamespace_Public_get_String_0;

		// Token: 0x04003473 RID: 13427
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInteropXmlElement_Internal_get_Boolean_0;

		// Token: 0x04003474 RID: 13428
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInteropXmlType_Internal_get_Boolean_0;

		// Token: 0x04003475 RID: 13429
		private static readonly IntPtr NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0;
	}
}
