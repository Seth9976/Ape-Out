using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A0 RID: 416
	public class XmlSchemaDocumentation : XmlSchemaObject
	{
		// Token: 0x06002210 RID: 8720 RVA: 0x0009FADC File Offset: 0x0009DCDC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaDocumentation()
		{
			Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaDocumentation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr);
			XmlSchemaDocumentation.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr, "source");
			XmlSchemaDocumentation.NativeFieldInfoPtr_language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr, "language");
			XmlSchemaDocumentation.NativeFieldInfoPtr_markup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr, "markup");
			XmlSchemaDocumentation.NativeFieldInfoPtr_languageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr, "languageType");
			XmlSchemaDocumentation.NativeMethodInfoPtr_set_Source_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr, 100668161);
			XmlSchemaDocumentation.NativeMethodInfoPtr_set_Language_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr, 100668162);
			XmlSchemaDocumentation.NativeMethodInfoPtr_set_Markup_Public_set_Void_Il2CppReferenceArray_1_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr, 100668163);
			XmlSchemaDocumentation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr, 100668164);
		}

		// Token: 0x17000BE7 RID: 3047
		// (set) Token: 0x06002211 RID: 8721 RVA: 0x0009FBAC File Offset: 0x0009DDAC
		public unsafe string Source
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDocumentation.NativeMethodInfoPtr_set_Source_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (set) Token: 0x06002212 RID: 8722 RVA: 0x0009FBF0 File Offset: 0x0009DDF0
		public unsafe string Language
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427140, XrefRangeEnd = 427146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDocumentation.NativeMethodInfoPtr_set_Language_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (set) Token: 0x06002213 RID: 8723 RVA: 0x0009FC34 File Offset: 0x0009DE34
		public unsafe Il2CppReferenceArray<XmlNode> Markup
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14747, RefRangeEnd = 14763, XrefRangeStart = 14747, XrefRangeEnd = 14763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDocumentation.NativeMethodInfoPtr_set_Markup_Public_set_Void_Il2CppReferenceArray_1_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x0009FC78 File Offset: 0x0009DE78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaDocumentation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDocumentation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x0000EBCF File Offset: 0x0000CDCF
		public XmlSchemaDocumentation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x0009FCB4 File Offset: 0x0009DEB4
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x0000EBD8 File Offset: 0x0000CDD8
		public unsafe string source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaDocumentation.NativeFieldInfoPtr_source);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaDocumentation.NativeFieldInfoPtr_source), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x0009FCDC File Offset: 0x0009DEDC
		// (set) Token: 0x06002219 RID: 8729 RVA: 0x0000EBF7 File Offset: 0x0000CDF7
		public unsafe string language
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaDocumentation.NativeFieldInfoPtr_language);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaDocumentation.NativeFieldInfoPtr_language), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x0009FD04 File Offset: 0x0009DF04
		// (set) Token: 0x0600221B RID: 8731 RVA: 0x0000EC16 File Offset: 0x0000CE16
		public unsafe Il2CppReferenceArray<XmlNode> markup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaDocumentation.NativeFieldInfoPtr_markup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaDocumentation.NativeFieldInfoPtr_markup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x0009FD34 File Offset: 0x0009DF34
		// (set) Token: 0x0600221D RID: 8733 RVA: 0x0000EC35 File Offset: 0x0000CE35
		public unsafe static XmlSchemaSimpleType languageType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaDocumentation.NativeFieldInfoPtr_languageType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaDocumentation.NativeFieldInfoPtr_languageType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001956 RID: 6486
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04001957 RID: 6487
		private static readonly IntPtr NativeFieldInfoPtr_language;

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeFieldInfoPtr_markup;

		// Token: 0x04001959 RID: 6489
		private static readonly IntPtr NativeFieldInfoPtr_languageType;

		// Token: 0x0400195A RID: 6490
		private static readonly IntPtr NativeMethodInfoPtr_set_Source_Public_set_Void_String_0;

		// Token: 0x0400195B RID: 6491
		private static readonly IntPtr NativeMethodInfoPtr_set_Language_Public_set_Void_String_0;

		// Token: 0x0400195C RID: 6492
		private static readonly IntPtr NativeMethodInfoPtr_set_Markup_Public_set_Void_Il2CppReferenceArray_1_XmlNode_0;

		// Token: 0x0400195D RID: 6493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
