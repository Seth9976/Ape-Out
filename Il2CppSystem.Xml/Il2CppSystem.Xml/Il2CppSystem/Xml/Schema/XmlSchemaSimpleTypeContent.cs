using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001CB RID: 459
	public class XmlSchemaSimpleTypeContent : XmlSchemaAnnotated
	{
		// Token: 0x0600249F RID: 9375 RVA: 0x0000FE95 File Offset: 0x0000E095
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSimpleTypeContent()
		{
			Il2CppClassPointerStore<XmlSchemaSimpleTypeContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSimpleTypeContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSimpleTypeContent>.NativeClassPtr);
			XmlSchemaSimpleTypeContent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeContent>.NativeClassPtr, 100668513);
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x000A91BC File Offset: 0x000A73BC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleTypeContent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSimpleTypeContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeContent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x0000FECE File Offset: 0x0000E0CE
		public XmlSchemaSimpleTypeContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001B2D RID: 6957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
