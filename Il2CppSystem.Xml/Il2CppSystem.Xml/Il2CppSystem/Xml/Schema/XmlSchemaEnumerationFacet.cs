using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001AB RID: 427
	public class XmlSchemaEnumerationFacet : XmlSchemaFacet
	{
		// Token: 0x060022DC RID: 8924 RVA: 0x0000F1F4 File Offset: 0x0000D3F4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaEnumerationFacet()
		{
			Il2CppClassPointerStore<XmlSchemaEnumerationFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaEnumerationFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaEnumerationFacet>.NativeClassPtr);
			XmlSchemaEnumerationFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaEnumerationFacet>.NativeClassPtr, 100668264);
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x000A29F0 File Offset: 0x000A0BF0
		[CallerCount(0)]
		public unsafe XmlSchemaEnumerationFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaEnumerationFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaEnumerationFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x0000F22D File Offset: 0x0000D42D
		public XmlSchemaEnumerationFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019F3 RID: 6643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
