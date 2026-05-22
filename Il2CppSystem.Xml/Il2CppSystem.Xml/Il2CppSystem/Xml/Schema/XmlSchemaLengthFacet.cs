using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A7 RID: 423
	public class XmlSchemaLengthFacet : XmlSchemaNumericFacet
	{
		// Token: 0x060022D0 RID: 8912 RVA: 0x0000F0EC File Offset: 0x0000D2EC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaLengthFacet()
		{
			Il2CppClassPointerStore<XmlSchemaLengthFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaLengthFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaLengthFacet>.NativeClassPtr);
			XmlSchemaLengthFacet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaLengthFacet>.NativeClassPtr, 100668260);
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x000A2900 File Offset: 0x000A0B00
		[CallerCount(0)]
		public unsafe XmlSchemaLengthFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaLengthFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaLengthFacet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x0000F125 File Offset: 0x0000D325
		public XmlSchemaLengthFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
