using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D7 RID: 215
	public class XmlNamespaceDeclarationsAttribute : Attribute
	{
		// Token: 0x0600125B RID: 4699 RVA: 0x00008338 File Offset: 0x00006538
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNamespaceDeclarationsAttribute()
		{
			Il2CppClassPointerStore<XmlNamespaceDeclarationsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlNamespaceDeclarationsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamespaceDeclarationsAttribute>.NativeClassPtr);
			XmlNamespaceDeclarationsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceDeclarationsAttribute>.NativeClassPtr, 100666165);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x0006286C File Offset: 0x00060A6C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNamespaceDeclarationsAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamespaceDeclarationsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamespaceDeclarationsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00008371 File Offset: 0x00006571
		public XmlNamespaceDeclarationsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
