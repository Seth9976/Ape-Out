using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E1 RID: 225
	public class XmlSerializerImplementation : Object
	{
		// Token: 0x0600133D RID: 4925 RVA: 0x00008829 File Offset: 0x00006A29
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializerImplementation()
		{
			Il2CppClassPointerStore<XmlSerializerImplementation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializerImplementation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializerImplementation>.NativeClassPtr);
			XmlSerializerImplementation.NativeMethodInfoPtr_get_Writer_Public_Virtual_New_get_XmlSerializationWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializerImplementation>.NativeClassPtr, 100666302);
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x00066CF4 File Offset: 0x00064EF4
		public unsafe virtual XmlSerializationWriter Writer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407356, XrefRangeEnd = 407361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializerImplementation.NativeMethodInfoPtr_get_Writer_Public_Virtual_New_get_XmlSerializationWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializationWriter>(intPtr3) : null;
			}
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00008862 File Offset: 0x00006A62
		public XmlSerializerImplementation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr_get_Writer_Public_Virtual_New_get_XmlSerializationWriter_0;
	}
}
