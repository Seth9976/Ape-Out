using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A6 RID: 422
	public class XmlSchemaNumericFacet : XmlSchemaFacet
	{
		// Token: 0x060022CD RID: 8909 RVA: 0x0000F0AA File Offset: 0x0000D2AA
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaNumericFacet()
		{
			Il2CppClassPointerStore<XmlSchemaNumericFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaNumericFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaNumericFacet>.NativeClassPtr);
			XmlSchemaNumericFacet.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaNumericFacet>.NativeClassPtr, 100668259);
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x000A28C4 File Offset: 0x000A0AC4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaNumericFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaNumericFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaNumericFacet.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x0000F0E3 File Offset: 0x0000D2E3
		public XmlSchemaNumericFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019EE RID: 6638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
