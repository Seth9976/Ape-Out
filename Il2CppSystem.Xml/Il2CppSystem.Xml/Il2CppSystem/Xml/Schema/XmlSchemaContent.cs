using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200019A RID: 410
	public class XmlSchemaContent : XmlSchemaAnnotated
	{
		// Token: 0x060021E8 RID: 8680 RVA: 0x0000EB7B File Offset: 0x0000CD7B
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaContent()
		{
			Il2CppClassPointerStore<XmlSchemaContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaContent>.NativeClassPtr);
			XmlSchemaContent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaContent>.NativeClassPtr, 100668127);
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x0009EC68 File Offset: 0x0009CE68
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaContent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaContent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x0000EBB4 File Offset: 0x0000CDB4
		public XmlSchemaContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
