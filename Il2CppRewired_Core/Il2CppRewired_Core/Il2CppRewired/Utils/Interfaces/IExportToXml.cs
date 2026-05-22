using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Xml;

namespace Il2CppRewired.Utils.Interfaces
{
	// Token: 0x020000F8 RID: 248
	public class IExportToXml : Il2CppObjectBase
	{
		// Token: 0x0600190E RID: 6414 RVA: 0x0008EFF8 File Offset: 0x0008D1F8
		// Note: this type is marked as 'beforefieldinit'.
		static IExportToXml()
		{
			Il2CppClassPointerStore<IExportToXml>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Interfaces", "IExportToXml");
			IExportToXml.NativeMethodInfoPtr_get_writesOwnElementTag_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExportToXml>.NativeClassPtr, 100669375);
			IExportToXml.NativeMethodInfoPtr_WriteXml_Public_Abstract_Virtual_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExportToXml>.NativeClassPtr, 100669376);
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x0008F048 File Offset: 0x0008D248
		public unsafe virtual bool writesOwnElementTag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExportToXml.NativeMethodInfoPtr_get_writesOwnElementTag_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x0008F090 File Offset: 0x0008D290
		[CallerCount(0)]
		public unsafe virtual void WriteXml(XmlWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExportToXml.NativeMethodInfoPtr_WriteXml_Public_Abstract_Virtual_New_Void_XmlWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x0000A27F File Offset: 0x0000847F
		public IExportToXml(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015D5 RID: 5589
		private static readonly IntPtr NativeMethodInfoPtr_get_writesOwnElementTag_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040015D6 RID: 5590
		private static readonly IntPtr NativeMethodInfoPtr_WriteXml_Public_Abstract_Virtual_New_Void_XmlWriter_0;
	}
}
