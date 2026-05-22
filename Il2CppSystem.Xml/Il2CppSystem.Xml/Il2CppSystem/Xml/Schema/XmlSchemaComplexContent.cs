using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000196 RID: 406
	public class XmlSchemaComplexContent : XmlSchemaContentModel
	{
		// Token: 0x0600216F RID: 8559 RVA: 0x0009D008 File Offset: 0x0009B208
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaComplexContent()
		{
			Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaComplexContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr);
			XmlSchemaComplexContent.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, "content");
			XmlSchemaComplexContent.NativeFieldInfoPtr_isMixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, "isMixed");
			XmlSchemaComplexContent.NativeFieldInfoPtr_hasMixedAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, "hasMixedAttribute");
			XmlSchemaComplexContent.NativeMethodInfoPtr_get_IsMixed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, 100668063);
			XmlSchemaComplexContent.NativeMethodInfoPtr_set_IsMixed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, 100668064);
			XmlSchemaComplexContent.NativeMethodInfoPtr_get_Content_Public_Virtual_get_XmlSchemaContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, 100668065);
			XmlSchemaComplexContent.NativeMethodInfoPtr_set_Content_Public_Virtual_set_Void_XmlSchemaContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, 100668066);
			XmlSchemaComplexContent.NativeMethodInfoPtr_get_HasMixedAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, 100668067);
			XmlSchemaComplexContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, 100668068);
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06002170 RID: 8560 RVA: 0x0009D0EC File Offset: 0x0009B2EC
		// (set) Token: 0x06002171 RID: 8561 RVA: 0x0009D128 File Offset: 0x0009B328
		public unsafe bool IsMixed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContent.NativeMethodInfoPtr_get_IsMixed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContent.NativeMethodInfoPtr_set_IsMixed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002172 RID: 8562 RVA: 0x0009D168 File Offset: 0x0009B368
		// (set) Token: 0x06002173 RID: 8563 RVA: 0x0009D1B4 File Offset: 0x0009B3B4
		public unsafe override XmlSchemaContent Content
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaComplexContent.NativeMethodInfoPtr_get_Content_Public_Virtual_get_XmlSchemaContent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaContent>(intPtr3) : null;
			}
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 13543, RefRangeEnd = 13569, XrefRangeStart = 13543, XrefRangeEnd = 13569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaComplexContent.NativeMethodInfoPtr_set_Content_Public_Virtual_set_Void_XmlSchemaContent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x0009D204 File Offset: 0x0009B404
		public unsafe bool HasMixedAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContent.NativeMethodInfoPtr_get_HasMixedAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x0009D240 File Offset: 0x0009B440
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaComplexContent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x0000E88B File Offset: 0x0000CA8B
		public XmlSchemaComplexContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x0009D27C File Offset: 0x0009B47C
		// (set) Token: 0x06002178 RID: 8568 RVA: 0x0000E894 File Offset: 0x0000CA94
		public unsafe XmlSchemaContent content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContent.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContent.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x0009D2AC File Offset: 0x0009B4AC
		// (set) Token: 0x0600217A RID: 8570 RVA: 0x0000E8B3 File Offset: 0x0000CAB3
		public unsafe bool isMixed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContent.NativeFieldInfoPtr_isMixed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContent.NativeFieldInfoPtr_isMixed)) = value;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x0600217B RID: 8571 RVA: 0x0009D2D4 File Offset: 0x0009B4D4
		// (set) Token: 0x0600217C RID: 8572 RVA: 0x0000E8CE File Offset: 0x0000CACE
		public unsafe bool hasMixedAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContent.NativeFieldInfoPtr_hasMixedAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContent.NativeFieldInfoPtr_hasMixedAttribute)) = value;
			}
		}

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeFieldInfoPtr_isMixed;

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeFieldInfoPtr_hasMixedAttribute;

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMixed_Public_get_Boolean_0;

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMixed_Public_set_Void_Boolean_0;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_Virtual_get_XmlSchemaContent_0;

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Public_Virtual_set_Void_XmlSchemaContent_0;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeMethodInfoPtr_get_HasMixedAttribute_Internal_get_Boolean_0;

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
