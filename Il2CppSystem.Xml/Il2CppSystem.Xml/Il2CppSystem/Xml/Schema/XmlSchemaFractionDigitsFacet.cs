using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001B1 RID: 433
	public class XmlSchemaFractionDigitsFacet : XmlSchemaNumericFacet
	{
		// Token: 0x060022EE RID: 8942 RVA: 0x0000F380 File Offset: 0x0000D580
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaFractionDigitsFacet()
		{
			Il2CppClassPointerStore<XmlSchemaFractionDigitsFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaFractionDigitsFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaFractionDigitsFacet>.NativeClassPtr);
			XmlSchemaFractionDigitsFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaFractionDigitsFacet>.NativeClassPtr, 100668270);
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x000A2B58 File Offset: 0x000A0D58
		[CallerCount(0)]
		public unsafe XmlSchemaFractionDigitsFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaFractionDigitsFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaFractionDigitsFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x0000F3B9 File Offset: 0x0000D5B9
		public XmlSchemaFractionDigitsFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019F9 RID: 6649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
