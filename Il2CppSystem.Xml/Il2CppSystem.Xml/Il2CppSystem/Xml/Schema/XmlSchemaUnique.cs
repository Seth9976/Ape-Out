using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001B9 RID: 441
	public class XmlSchemaUnique : XmlSchemaIdentityConstraint
	{
		// Token: 0x06002345 RID: 9029 RVA: 0x0000F5FE File Offset: 0x0000D7FE
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaUnique()
		{
			Il2CppClassPointerStore<XmlSchemaUnique>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaUnique");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaUnique>.NativeClassPtr);
			XmlSchemaUnique.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaUnique>.NativeClassPtr, 100668313);
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x000A3E74 File Offset: 0x000A2074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427616, XrefRangeEnd = 427617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaUnique()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaUnique>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaUnique.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x0000F637 File Offset: 0x0000D837
		public XmlSchemaUnique(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A37 RID: 6711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
