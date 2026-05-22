using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001E6 RID: 486
	public class XmlAnyListConverter : XmlListConverter
	{
		// Token: 0x0600277F RID: 10111 RVA: 0x000B6F24 File Offset: 0x000B5124
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAnyListConverter()
		{
			Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlAnyListConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr);
			XmlAnyListConverter.NativeFieldInfoPtr_ItemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr, "ItemList");
			XmlAnyListConverter.NativeFieldInfoPtr_AnyAtomicList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr, "AnyAtomicList");
			XmlAnyListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr, 100668990);
			XmlAnyListConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr, 100668991);
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x000B6FA4 File Offset: 0x000B51A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436373, XrefRangeEnd = 436374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAnyListConverter(XmlBaseConverter atomicConverter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(atomicConverter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x000B6FF0 File Offset: 0x000B51F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436374, XrefRangeEnd = 436431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyListConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x00010AAC File Offset: 0x0000ECAC
		public XmlAnyListConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06002783 RID: 10115 RVA: 0x000B7070 File Offset: 0x000B5270
		// (set) Token: 0x06002784 RID: 10116 RVA: 0x00010AB5 File Offset: 0x0000ECB5
		public unsafe static XmlValueConverter ItemList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlAnyListConverter.NativeFieldInfoPtr_ItemList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlAnyListConverter.NativeFieldInfoPtr_ItemList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x000B7098 File Offset: 0x000B5298
		// (set) Token: 0x06002786 RID: 10118 RVA: 0x00010AC7 File Offset: 0x0000ECC7
		public unsafe static XmlValueConverter AnyAtomicList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlAnyListConverter.NativeFieldInfoPtr_AnyAtomicList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlAnyListConverter.NativeFieldInfoPtr_AnyAtomicList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeFieldInfoPtr_ItemList;

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeFieldInfoPtr_AnyAtomicList;

		// Token: 0x04001DCD RID: 7629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0;

		// Token: 0x04001DCE RID: 7630
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0;
	}
}
