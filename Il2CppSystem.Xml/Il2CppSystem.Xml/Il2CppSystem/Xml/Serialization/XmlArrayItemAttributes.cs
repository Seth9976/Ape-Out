using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000C8 RID: 200
	[DefaultMember("Item")]
	public class XmlArrayItemAttributes : CollectionBase
	{
		// Token: 0x060011B6 RID: 4534 RVA: 0x000607D0 File Offset: 0x0005E9D0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlArrayItemAttributes()
		{
			Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlArrayItemAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr);
			XmlArrayItemAttributes.NativeMethodInfoPtr_Add_Public_Int32_XmlArrayItemAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr, 100666101);
			XmlArrayItemAttributes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr, 100666102);
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00060828 File Offset: 0x0005EA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404755, XrefRangeEnd = 404759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(XmlArrayItemAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttributes.NativeMethodInfoPtr_Add_Public_Int32_XmlArrayItemAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00060878 File Offset: 0x0005EA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlArrayItemAttributes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttributes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00007DFA File Offset: 0x00005FFA
		public XmlArrayItemAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_XmlArrayItemAttribute_0;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
