using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000ED RID: 237
	public class XmlTypeMapMemberAnyAttribute : XmlTypeMapMember
	{
		// Token: 0x060013EE RID: 5102 RVA: 0x00008D68 File Offset: 0x00006F68
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMemberAnyAttribute()
		{
			Il2CppClassPointerStore<XmlTypeMapMemberAnyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberAnyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberAnyAttribute>.NativeClassPtr);
			XmlTypeMapMemberAnyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAnyAttribute>.NativeClassPtr, 100666383);
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00069234 File Offset: 0x00067434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberAnyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberAnyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAnyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00008DA1 File Offset: 0x00006FA1
		public XmlTypeMapMemberAnyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
