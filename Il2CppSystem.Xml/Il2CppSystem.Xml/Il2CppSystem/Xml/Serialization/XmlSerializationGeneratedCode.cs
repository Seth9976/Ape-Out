using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000DC RID: 220
	public class XmlSerializationGeneratedCode : Object
	{
		// Token: 0x060012B3 RID: 4787 RVA: 0x000085BD File Offset: 0x000067BD
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializationGeneratedCode()
		{
			Il2CppClassPointerStore<XmlSerializationGeneratedCode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializationGeneratedCode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializationGeneratedCode>.NativeClassPtr);
			XmlSerializationGeneratedCode.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationGeneratedCode>.NativeClassPtr, 100666209);
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00063FC8 File Offset: 0x000621C8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializationGeneratedCode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationGeneratedCode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationGeneratedCode.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x000085F6 File Offset: 0x000067F6
		public XmlSerializationGeneratedCode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
