using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E9 RID: 233
	public class XmlTypeMapMemberList : XmlTypeMapMemberElement
	{
		// Token: 0x060013D9 RID: 5081 RVA: 0x00008CD1 File Offset: 0x00006ED1
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMemberList()
		{
			Il2CppClassPointerStore<XmlTypeMapMemberList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberList>.NativeClassPtr);
			XmlTypeMapMemberList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberList>.NativeClassPtr, 100666374);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00068E34 File Offset: 0x00067034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x00008D0A File Offset: 0x00006F0A
		public XmlTypeMapMemberList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
