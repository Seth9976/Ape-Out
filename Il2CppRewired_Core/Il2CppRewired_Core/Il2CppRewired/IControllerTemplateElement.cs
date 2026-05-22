using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired
{
	// Token: 0x02000073 RID: 115
	public class IControllerTemplateElement : Il2CppObjectBase
	{
		// Token: 0x06001000 RID: 4096 RVA: 0x00068B8C File Offset: 0x00066D8C
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateElement()
		{
			Il2CppClassPointerStore<IControllerTemplateElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerTemplateElement");
			IControllerTemplateElement.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateElement>.NativeClassPtr, 100665957);
			IControllerTemplateElement.NativeMethodInfoPtr_get_descriptiveName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateElement>.NativeClassPtr, 100665958);
			IControllerTemplateElement.NativeMethodInfoPtr_get_type_Public_Abstract_Virtual_New_get_ControllerTemplateElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateElement>.NativeClassPtr, 100665959);
			IControllerTemplateElement.NativeMethodInfoPtr_get_exists_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateElement>.NativeClassPtr, 100665960);
			IControllerTemplateElement.NativeMethodInfoPtr_get_source_Public_Abstract_Virtual_New_get_IControllerTemplateElementSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateElement>.NativeClassPtr, 100665961);
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x00068C18 File Offset: 0x00066E18
		public unsafe virtual int id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateElement.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x00068C60 File Offset: 0x00066E60
		public unsafe virtual string descriptiveName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateElement.NativeMethodInfoPtr_get_descriptiveName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x00068CA4 File Offset: 0x00066EA4
		public unsafe virtual ControllerTemplateElementType type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateElement.NativeMethodInfoPtr_get_type_Public_Abstract_Virtual_New_get_ControllerTemplateElementType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x00068CEC File Offset: 0x00066EEC
		public unsafe virtual bool exists
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateElement.NativeMethodInfoPtr_get_exists_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x00068D34 File Offset: 0x00066F34
		public unsafe virtual IControllerTemplateElementSource source
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateElement.NativeMethodInfoPtr_get_source_Public_Abstract_Virtual_New_get_IControllerTemplateElementSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElementSource>(intPtr3) : null;
			}
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0000744B File Offset: 0x0000564B
		public IControllerTemplateElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr_get_descriptiveName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_Abstract_Virtual_New_get_ControllerTemplateElementType_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr_get_exists_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr_get_source_Public_Abstract_Virtual_New_get_IControllerTemplateElementSource_0;
	}
}
