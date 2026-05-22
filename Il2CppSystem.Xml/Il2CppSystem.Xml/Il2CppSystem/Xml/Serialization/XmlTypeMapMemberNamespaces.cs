using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000EE RID: 238
	public class XmlTypeMapMemberNamespaces : XmlTypeMapMember
	{
		// Token: 0x060013F1 RID: 5105 RVA: 0x00008DAA File Offset: 0x00006FAA
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMemberNamespaces()
		{
			Il2CppClassPointerStore<XmlTypeMapMemberNamespaces>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberNamespaces");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberNamespaces>.NativeClassPtr);
			XmlTypeMapMemberNamespaces.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberNamespaces>.NativeClassPtr, 100666384);
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00069270 File Offset: 0x00067470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberNamespaces()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberNamespaces>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberNamespaces.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00008DE3 File Offset: 0x00006FE3
		public XmlTypeMapMemberNamespaces(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
