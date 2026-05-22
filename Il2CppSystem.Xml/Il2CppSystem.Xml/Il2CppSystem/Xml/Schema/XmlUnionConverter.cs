using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001E8 RID: 488
	public class XmlUnionConverter : XmlBaseConverter
	{
		// Token: 0x06002797 RID: 10135 RVA: 0x000B7680 File Offset: 0x000B5880
		// Note: this type is marked as 'beforefieldinit'.
		static XmlUnionConverter()
		{
			Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlUnionConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr);
			XmlUnionConverter.NativeFieldInfoPtr_converters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, "converters");
			XmlUnionConverter.NativeFieldInfoPtr_hasAtomicMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, "hasAtomicMember");
			XmlUnionConverter.NativeFieldInfoPtr_hasListMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, "hasListMember");
			XmlUnionConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, 100669005);
			XmlUnionConverter.NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, 100669006);
			XmlUnionConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, 100669007);
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x000B7728 File Offset: 0x000B5928
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 436918, RefRangeEnd = 436920, XrefRangeStart = 436897, XrefRangeEnd = 436918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlUnionConverter(XmlSchemaType schemaType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUnionConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x000B7774 File Offset: 0x000B5974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436920, XrefRangeEnd = 436924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUnionConverter.NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x000B77B8 File Offset: 0x000B59B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436924, XrefRangeEnd = 436942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUnionConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x00010B01 File Offset: 0x0000ED01
		public XmlUnionConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x0600279C RID: 10140 RVA: 0x000B7838 File Offset: 0x000B5A38
		// (set) Token: 0x0600279D RID: 10141 RVA: 0x00010B0A File Offset: 0x0000ED0A
		public unsafe Il2CppReferenceArray<XmlValueConverter> converters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUnionConverter.NativeFieldInfoPtr_converters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlValueConverter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUnionConverter.NativeFieldInfoPtr_converters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x0600279E RID: 10142 RVA: 0x000B7868 File Offset: 0x000B5A68
		// (set) Token: 0x0600279F RID: 10143 RVA: 0x00010B29 File Offset: 0x0000ED29
		public unsafe bool hasAtomicMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUnionConverter.NativeFieldInfoPtr_hasAtomicMember);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUnionConverter.NativeFieldInfoPtr_hasAtomicMember)) = value;
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x000B7890 File Offset: 0x000B5A90
		// (set) Token: 0x060027A1 RID: 10145 RVA: 0x00010B44 File Offset: 0x0000ED44
		public unsafe bool hasListMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUnionConverter.NativeFieldInfoPtr_hasListMember);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUnionConverter.NativeFieldInfoPtr_hasListMember)) = value;
			}
		}

		// Token: 0x04001DDC RID: 7644
		private static readonly IntPtr NativeFieldInfoPtr_converters;

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeFieldInfoPtr_hasAtomicMember;

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeFieldInfoPtr_hasListMember;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0;

		// Token: 0x04001DE0 RID: 7648
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0;

		// Token: 0x04001DE1 RID: 7649
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0;
	}
}
