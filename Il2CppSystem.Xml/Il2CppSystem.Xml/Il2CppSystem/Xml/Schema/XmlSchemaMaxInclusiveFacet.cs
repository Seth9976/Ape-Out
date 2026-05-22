using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001AF RID: 431
	public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet
	{
		// Token: 0x060022E8 RID: 8936 RVA: 0x0000F2FC File Offset: 0x0000D4FC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaMaxInclusiveFacet()
		{
			Il2CppClassPointerStore<XmlSchemaMaxInclusiveFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaMaxInclusiveFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaMaxInclusiveFacet>.NativeClassPtr);
			XmlSchemaMaxInclusiveFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaMaxInclusiveFacet>.NativeClassPtr, 100668268);
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x000A2AE0 File Offset: 0x000A0CE0
		[CallerCount(0)]
		public unsafe XmlSchemaMaxInclusiveFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaMaxInclusiveFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaMaxInclusiveFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x0000F335 File Offset: 0x0000D535
		public XmlSchemaMaxInclusiveFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019F7 RID: 6647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
