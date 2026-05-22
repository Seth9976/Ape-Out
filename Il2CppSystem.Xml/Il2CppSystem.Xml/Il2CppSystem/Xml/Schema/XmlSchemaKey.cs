using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001BA RID: 442
	public class XmlSchemaKey : XmlSchemaIdentityConstraint
	{
		// Token: 0x06002348 RID: 9032 RVA: 0x0000F640 File Offset: 0x0000D840
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaKey()
		{
			Il2CppClassPointerStore<XmlSchemaKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaKey>.NativeClassPtr);
			XmlSchemaKey.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaKey>.NativeClassPtr, 100668314);
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x000A3EB0 File Offset: 0x000A20B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaKey()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaKey>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaKey.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x0000F679 File Offset: 0x0000D879
		public XmlSchemaKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A38 RID: 6712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
