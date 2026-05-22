using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A9 RID: 425
	public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet
	{
		// Token: 0x060022D6 RID: 8918 RVA: 0x0000F170 File Offset: 0x0000D370
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaMaxLengthFacet()
		{
			Il2CppClassPointerStore<XmlSchemaMaxLengthFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaMaxLengthFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaMaxLengthFacet>.NativeClassPtr);
			XmlSchemaMaxLengthFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaMaxLengthFacet>.NativeClassPtr, 100668262);
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x000A2978 File Offset: 0x000A0B78
		[CallerCount(0)]
		public unsafe XmlSchemaMaxLengthFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaMaxLengthFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaMaxLengthFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x0000F1A9 File Offset: 0x0000D3A9
		public XmlSchemaMaxLengthFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019F1 RID: 6641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
