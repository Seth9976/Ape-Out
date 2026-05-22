using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001B0 RID: 432
	public class XmlSchemaTotalDigitsFacet : XmlSchemaNumericFacet
	{
		// Token: 0x060022EB RID: 8939 RVA: 0x0000F33E File Offset: 0x0000D53E
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaTotalDigitsFacet()
		{
			Il2CppClassPointerStore<XmlSchemaTotalDigitsFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaTotalDigitsFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaTotalDigitsFacet>.NativeClassPtr);
			XmlSchemaTotalDigitsFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaTotalDigitsFacet>.NativeClassPtr, 100668269);
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x000A2B1C File Offset: 0x000A0D1C
		[CallerCount(0)]
		public unsafe XmlSchemaTotalDigitsFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaTotalDigitsFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaTotalDigitsFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x0000F377 File Offset: 0x0000D577
		public XmlSchemaTotalDigitsFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019F8 RID: 6648
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
