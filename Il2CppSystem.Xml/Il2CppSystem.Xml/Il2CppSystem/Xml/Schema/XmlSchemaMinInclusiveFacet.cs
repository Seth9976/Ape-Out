using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001AD RID: 429
	public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet
	{
		// Token: 0x060022E2 RID: 8930 RVA: 0x0000F278 File Offset: 0x0000D478
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaMinInclusiveFacet()
		{
			Il2CppClassPointerStore<XmlSchemaMinInclusiveFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaMinInclusiveFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaMinInclusiveFacet>.NativeClassPtr);
			XmlSchemaMinInclusiveFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaMinInclusiveFacet>.NativeClassPtr, 100668266);
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x000A2A68 File Offset: 0x000A0C68
		[CallerCount(0)]
		public unsafe XmlSchemaMinInclusiveFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaMinInclusiveFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaMinInclusiveFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x0000F2B1 File Offset: 0x0000D4B1
		public XmlSchemaMinInclusiveFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019F5 RID: 6645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
