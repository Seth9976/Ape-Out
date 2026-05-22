using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000C3 RID: 195
	public class XmlAnyAttributeAttribute : Attribute
	{
		// Token: 0x06001177 RID: 4471 RVA: 0x00007BC4 File Offset: 0x00005DC4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAnyAttributeAttribute()
		{
			Il2CppClassPointerStore<XmlAnyAttributeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlAnyAttributeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAnyAttributeAttribute>.NativeClassPtr);
			XmlAnyAttributeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyAttributeAttribute>.NativeClassPtr, 100666080);
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0005FCD0 File Offset: 0x0005DED0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAnyAttributeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAnyAttributeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyAttributeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00007BFD File Offset: 0x00005DFD
		public XmlAnyAttributeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
