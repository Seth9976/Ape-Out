using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A8 RID: 424
	public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet
	{
		// Token: 0x060022D3 RID: 8915 RVA: 0x0000F12E File Offset: 0x0000D32E
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaMinLengthFacet()
		{
			Il2CppClassPointerStore<XmlSchemaMinLengthFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaMinLengthFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaMinLengthFacet>.NativeClassPtr);
			XmlSchemaMinLengthFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaMinLengthFacet>.NativeClassPtr, 100668261);
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x000A293C File Offset: 0x000A0B3C
		[CallerCount(0)]
		public unsafe XmlSchemaMinLengthFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaMinLengthFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaMinLengthFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x0000F167 File Offset: 0x0000D367
		public XmlSchemaMinLengthFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
