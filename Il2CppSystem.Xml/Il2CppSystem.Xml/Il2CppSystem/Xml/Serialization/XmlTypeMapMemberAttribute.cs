using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E7 RID: 231
	public class XmlTypeMapMemberAttribute : XmlTypeMapMember
	{
		// Token: 0x060013B4 RID: 5044 RVA: 0x00068630 File Offset: 0x00066830
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMemberAttribute()
		{
			Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr);
			XmlTypeMapMemberAttribute.NativeFieldInfoPtr__attributeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, "_attributeName");
			XmlTypeMapMemberAttribute.NativeFieldInfoPtr__namespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, "_namespace");
			XmlTypeMapMemberAttribute.NativeFieldInfoPtr__form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, "_form");
			XmlTypeMapMemberAttribute.NativeFieldInfoPtr__mappedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, "_mappedType");
			XmlTypeMapMemberAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, 100666357);
			XmlTypeMapMemberAttribute.NativeMethodInfoPtr_get_AttributeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, 100666358);
			XmlTypeMapMemberAttribute.NativeMethodInfoPtr_set_AttributeName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, 100666359);
			XmlTypeMapMemberAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, 100666360);
			XmlTypeMapMemberAttribute.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, 100666361);
			XmlTypeMapMemberAttribute.NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, 100666362);
			XmlTypeMapMemberAttribute.NativeMethodInfoPtr_get_MappedType_Public_get_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, 100666363);
			XmlTypeMapMemberAttribute.NativeMethodInfoPtr_set_MappedType_Public_set_Void_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, 100666364);
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00068750 File Offset: 0x00066950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407506, XrefRangeEnd = 407509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x0006878C File Offset: 0x0006698C
		// (set) Token: 0x060013B7 RID: 5047 RVA: 0x000687C4 File Offset: 0x000669C4
		public unsafe string AttributeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAttribute.NativeMethodInfoPtr_get_AttributeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAttribute.NativeMethodInfoPtr_set_AttributeName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x00068808 File Offset: 0x00066A08
		// (set) Token: 0x060013B9 RID: 5049 RVA: 0x00068840 File Offset: 0x00066A40
		public unsafe string Namespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAttribute.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700068B RID: 1675
		// (set) Token: 0x060013BA RID: 5050 RVA: 0x00068884 File Offset: 0x00066A84
		public unsafe XmlSchemaForm Form
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAttribute.NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x000688C4 File Offset: 0x00066AC4
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x00068904 File Offset: 0x00066B04
		public unsafe XmlTypeMapping MappedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAttribute.NativeMethodInfoPtr_get_MappedType_Public_get_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 89481, RefRangeEnd = 89490, XrefRangeStart = 89481, XrefRangeEnd = 89490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAttribute.NativeMethodInfoPtr_set_MappedType_Public_set_Void_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x00008BCF File Offset: 0x00006DCF
		public XmlTypeMapMemberAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x00068948 File Offset: 0x00066B48
		// (set) Token: 0x060013BF RID: 5055 RVA: 0x00008BD8 File Offset: 0x00006DD8
		public unsafe string _attributeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberAttribute.NativeFieldInfoPtr__attributeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberAttribute.NativeFieldInfoPtr__attributeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x00068970 File Offset: 0x00066B70
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x00008BF7 File Offset: 0x00006DF7
		public unsafe string _namespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberAttribute.NativeFieldInfoPtr__namespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberAttribute.NativeFieldInfoPtr__namespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x00068998 File Offset: 0x00066B98
		// (set) Token: 0x060013C3 RID: 5059 RVA: 0x00008C16 File Offset: 0x00006E16
		public unsafe XmlSchemaForm _form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberAttribute.NativeFieldInfoPtr__form);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberAttribute.NativeFieldInfoPtr__form)) = value;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x000689C0 File Offset: 0x00066BC0
		// (set) Token: 0x060013C5 RID: 5061 RVA: 0x00008C31 File Offset: 0x00006E31
		public unsafe XmlTypeMapping _mappedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberAttribute.NativeFieldInfoPtr__mappedType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberAttribute.NativeFieldInfoPtr__mappedType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeFieldInfoPtr__attributeName;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeFieldInfoPtr__namespace;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeFieldInfoPtr__form;

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeFieldInfoPtr__mappedType;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeName_Public_get_String_0;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeMethodInfoPtr_set_AttributeName_Public_set_Void_String_0;

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeMethodInfoPtr_get_MappedType_Public_get_XmlTypeMapping_0;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeMethodInfoPtr_set_MappedType_Public_set_Void_XmlTypeMapping_0;
	}
}
