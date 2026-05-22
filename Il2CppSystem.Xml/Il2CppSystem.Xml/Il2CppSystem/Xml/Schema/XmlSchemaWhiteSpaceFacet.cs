using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001B2 RID: 434
	public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet
	{
		// Token: 0x060022F1 RID: 8945 RVA: 0x0000F3C2 File Offset: 0x0000D5C2
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaWhiteSpaceFacet()
		{
			Il2CppClassPointerStore<XmlSchemaWhiteSpaceFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaWhiteSpaceFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaWhiteSpaceFacet>.NativeClassPtr);
			XmlSchemaWhiteSpaceFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaWhiteSpaceFacet>.NativeClassPtr, 100668271);
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x000A2B94 File Offset: 0x000A0D94
		[CallerCount(0)]
		public unsafe XmlSchemaWhiteSpaceFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaWhiteSpaceFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaWhiteSpaceFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x0000F3FB File Offset: 0x0000D5FB
		public XmlSchemaWhiteSpaceFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019FA RID: 6650
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
