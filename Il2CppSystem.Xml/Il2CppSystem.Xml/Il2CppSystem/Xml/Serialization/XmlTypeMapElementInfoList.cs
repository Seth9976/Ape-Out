using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E5 RID: 229
	public class XmlTypeMapElementInfoList : ArrayList
	{
		// Token: 0x06001387 RID: 4999 RVA: 0x00008A5E File Offset: 0x00006C5E
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapElementInfoList()
		{
			Il2CppClassPointerStore<XmlTypeMapElementInfoList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapElementInfoList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapElementInfoList>.NativeClassPtr);
			XmlTypeMapElementInfoList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfoList>.NativeClassPtr, 100666336);
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00067C84 File Offset: 0x00065E84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407403, RefRangeEnd = 407404, XrefRangeStart = 407399, XrefRangeEnd = 407403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapElementInfoList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapElementInfoList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfoList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00008A97 File Offset: 0x00006C97
		public XmlTypeMapElementInfoList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
