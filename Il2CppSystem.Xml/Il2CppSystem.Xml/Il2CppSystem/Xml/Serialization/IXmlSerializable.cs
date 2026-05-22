using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000BC RID: 188
	public class IXmlSerializable : Il2CppObjectBase
	{
		// Token: 0x06001116 RID: 4374 RVA: 0x0005E76C File Offset: 0x0005C96C
		// Note: this type is marked as 'beforefieldinit'.
		static IXmlSerializable()
		{
			Il2CppClassPointerStore<IXmlSerializable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "IXmlSerializable");
			IXmlSerializable.NativeMethodInfoPtr_GetSchema_Public_Abstract_Virtual_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSerializable>.NativeClassPtr, 100666038);
			IXmlSerializable.NativeMethodInfoPtr_WriteXml_Public_Abstract_Virtual_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSerializable>.NativeClassPtr, 100666039);
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0005E7BC File Offset: 0x0005C9BC
		[CallerCount(0)]
		public unsafe virtual XmlSchema GetSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSerializable.NativeMethodInfoPtr_GetSchema_Public_Abstract_Virtual_New_XmlSchema_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0005E808 File Offset: 0x0005CA08
		[CallerCount(0)]
		public unsafe virtual void WriteXml(XmlWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSerializable.NativeMethodInfoPtr_WriteXml_Public_Abstract_Virtual_New_Void_XmlWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0000791F File Offset: 0x00005B1F
		public IXmlSerializable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr_GetSchema_Public_Abstract_Virtual_New_XmlSchema_0;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr_WriteXml_Public_Abstract_Virtual_New_Void_XmlWriter_0;
	}
}
