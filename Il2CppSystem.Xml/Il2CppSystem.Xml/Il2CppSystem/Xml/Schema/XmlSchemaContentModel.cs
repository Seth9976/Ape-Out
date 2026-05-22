using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200019B RID: 411
	public class XmlSchemaContentModel : XmlSchemaAnnotated
	{
		// Token: 0x060021EB RID: 8683 RVA: 0x0009ECA4 File Offset: 0x0009CEA4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaContentModel()
		{
			Il2CppClassPointerStore<XmlSchemaContentModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaContentModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaContentModel>.NativeClassPtr);
			XmlSchemaContentModel.NativeMethodInfoPtr_get_Content_Public_Abstract_Virtual_New_get_XmlSchemaContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaContentModel>.NativeClassPtr, 100668128);
			XmlSchemaContentModel.NativeMethodInfoPtr_set_Content_Public_Abstract_Virtual_New_set_Void_XmlSchemaContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaContentModel>.NativeClassPtr, 100668129);
			XmlSchemaContentModel.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaContentModel>.NativeClassPtr, 100668130);
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x060021EC RID: 8684 RVA: 0x0009ED10 File Offset: 0x0009CF10
		// (set) Token: 0x060021ED RID: 8685 RVA: 0x0009ED5C File Offset: 0x0009CF5C
		public unsafe virtual XmlSchemaContent Content
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaContentModel.NativeMethodInfoPtr_get_Content_Public_Abstract_Virtual_New_get_XmlSchemaContent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaContent>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaContentModel.NativeMethodInfoPtr_set_Content_Public_Abstract_Virtual_New_set_Void_XmlSchemaContent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x0009EDAC File Offset: 0x0009CFAC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaContentModel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaContentModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaContentModel.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x0000EBBD File Offset: 0x0000CDBD
		public XmlSchemaContentModel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_Abstract_Virtual_New_get_XmlSchemaContent_0;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Public_Abstract_Virtual_New_set_Void_XmlSchemaContent_0;

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
