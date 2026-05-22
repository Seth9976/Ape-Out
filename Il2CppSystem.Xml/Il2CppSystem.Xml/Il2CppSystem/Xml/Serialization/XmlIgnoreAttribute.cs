using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D1 RID: 209
	public class XmlIgnoreAttribute : Attribute
	{
		// Token: 0x06001233 RID: 4659 RVA: 0x000081A9 File Offset: 0x000063A9
		// Note: this type is marked as 'beforefieldinit'.
		static XmlIgnoreAttribute()
		{
			Il2CppClassPointerStore<XmlIgnoreAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlIgnoreAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlIgnoreAttribute>.NativeClassPtr);
			XmlIgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlIgnoreAttribute>.NativeClassPtr, 100666151);
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00062168 File Offset: 0x00060368
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlIgnoreAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlIgnoreAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlIgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x000081E2 File Offset: 0x000063E2
		public XmlIgnoreAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
