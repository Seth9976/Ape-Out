using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001AE RID: 430
	public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet
	{
		// Token: 0x060022E5 RID: 8933 RVA: 0x0000F2BA File Offset: 0x0000D4BA
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaMaxExclusiveFacet()
		{
			Il2CppClassPointerStore<XmlSchemaMaxExclusiveFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaMaxExclusiveFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaMaxExclusiveFacet>.NativeClassPtr);
			XmlSchemaMaxExclusiveFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaMaxExclusiveFacet>.NativeClassPtr, 100668267);
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x000A2AA4 File Offset: 0x000A0CA4
		[CallerCount(0)]
		public unsafe XmlSchemaMaxExclusiveFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaMaxExclusiveFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaMaxExclusiveFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x0000F2F3 File Offset: 0x0000D4F3
		public XmlSchemaMaxExclusiveFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019F6 RID: 6646
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
