using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001AC RID: 428
	public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet
	{
		// Token: 0x060022DF RID: 8927 RVA: 0x0000F236 File Offset: 0x0000D436
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaMinExclusiveFacet()
		{
			Il2CppClassPointerStore<XmlSchemaMinExclusiveFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaMinExclusiveFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaMinExclusiveFacet>.NativeClassPtr);
			XmlSchemaMinExclusiveFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaMinExclusiveFacet>.NativeClassPtr, 100668265);
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x000A2A2C File Offset: 0x000A0C2C
		[CallerCount(0)]
		public unsafe XmlSchemaMinExclusiveFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaMinExclusiveFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaMinExclusiveFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x0000F26F File Offset: 0x0000D46F
		public XmlSchemaMinExclusiveFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019F4 RID: 6644
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
