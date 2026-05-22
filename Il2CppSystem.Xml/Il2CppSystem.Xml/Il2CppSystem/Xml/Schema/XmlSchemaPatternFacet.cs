using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001AA RID: 426
	public class XmlSchemaPatternFacet : XmlSchemaFacet
	{
		// Token: 0x060022D9 RID: 8921 RVA: 0x0000F1B2 File Offset: 0x0000D3B2
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaPatternFacet()
		{
			Il2CppClassPointerStore<XmlSchemaPatternFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaPatternFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaPatternFacet>.NativeClassPtr);
			XmlSchemaPatternFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaPatternFacet>.NativeClassPtr, 100668263);
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x000A29B4 File Offset: 0x000A0BB4
		[CallerCount(0)]
		public unsafe XmlSchemaPatternFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaPatternFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaPatternFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x0000F1EB File Offset: 0x0000D3EB
		public XmlSchemaPatternFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019F2 RID: 6642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
