using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Interfaces;
using Il2CppSystem;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x020000AD RID: 173
	public class IHardwareControllerTemplateMap_Internal : Il2CppObjectBase
	{
		// Token: 0x06001515 RID: 5397 RVA: 0x0007BCF0 File Offset: 0x00079EF0
		// Note: this type is marked as 'beforefieldinit'.
		static IHardwareControllerTemplateMap_Internal()
		{
			Il2CppClassPointerStore<IHardwareControllerTemplateMap_Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "IHardwareControllerTemplateMap_Internal");
			IHardwareControllerTemplateMap_Internal.NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHardwareControllerTemplateMap_Internal>.NativeClassPtr, 100668296);
			IHardwareControllerTemplateMap_Internal.NativeMethodInfoPtr_get_typeGuid_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHardwareControllerTemplateMap_Internal>.NativeClassPtr, 100668297);
			IHardwareControllerTemplateMap_Internal.NativeMethodInfoPtr_GetElementIdentifierCount_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHardwareControllerTemplateMap_Internal>.NativeClassPtr, 100668298);
			IHardwareControllerTemplateMap_Internal.NativeMethodInfoPtr_GetTemplateElementIdentifier_Public_Abstract_Virtual_New_IControllerTemplateElementIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHardwareControllerTemplateMap_Internal>.NativeClassPtr, 100668299);
			IHardwareControllerTemplateMap_Internal.NativeMethodInfoPtr_GetTemplateElementIdentifierById_Public_Abstract_Virtual_New_IControllerTemplateElementIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHardwareControllerTemplateMap_Internal>.NativeClassPtr, 100668300);
			IHardwareControllerTemplateMap_Internal.NativeMethodInfoPtr_GetSpecialTemplateElementByElementIdentifierId_Public_Abstract_Virtual_New_IControllerTemplateMapSpecialElement_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHardwareControllerTemplateMap_Internal>.NativeClassPtr, 100668301);
			IHardwareControllerTemplateMap_Internal.NativeMethodInfoPtr_GetAxisTarget_Public_Abstract_Virtual_New_FTRbVIakQDtduAElaDZqEnVrNpq_Controller_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHardwareControllerTemplateMap_Internal>.NativeClassPtr, 100668302);
			IHardwareControllerTemplateMap_Internal.NativeMethodInfoPtr_GetButtonTarget_Public_Abstract_Virtual_New_FTRbVIakQDtduAElaDZqEnVrNpq_Controller_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHardwareControllerTemplateMap_Internal>.NativeClassPtr, 100668303);
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x0007BDB8 File Offset: 0x00079FB8
		public unsafe virtual string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHardwareControllerTemplateMap_Internal.NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x0007BDFC File Offset: 0x00079FFC
		public unsafe virtual Guid typeGuid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHardwareControllerTemplateMap_Internal.NativeMethodInfoPtr_get_typeGuid_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x0007BE44 File Offset: 0x0007A044
		[CallerCount(0)]
		public unsafe virtual int GetElementIdentifierCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHardwareControllerTemplateMap_Internal.NativeMethodInfoPtr_GetElementIdentifierCount_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0007BE8C File Offset: 0x0007A08C
		[CallerCount(0)]
		public unsafe virtual IControllerTemplateElementIdentifier GetTemplateElementIdentifier(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHardwareControllerTemplateMap_Internal.NativeMethodInfoPtr_GetTemplateElementIdentifier_Public_Abstract_Virtual_New_IControllerTemplateElementIdentifier_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElementIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0007BEE4 File Offset: 0x0007A0E4
		[CallerCount(0)]
		public unsafe virtual IControllerTemplateElementIdentifier GetTemplateElementIdentifierById(int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHardwareControllerTemplateMap_Internal.NativeMethodInfoPtr_GetTemplateElementIdentifierById_Public_Abstract_Virtual_New_IControllerTemplateElementIdentifier_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElementIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x0007BF3C File Offset: 0x0007A13C
		[CallerCount(0)]
		public unsafe virtual IControllerTemplateMapSpecialElement_Internal GetSpecialTemplateElementByElementIdentifierId(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHardwareControllerTemplateMap_Internal.NativeMethodInfoPtr_GetSpecialTemplateElementByElementIdentifierId_Public_Abstract_Virtual_New_IControllerTemplateMapSpecialElement_Internal_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateMapSpecialElement_Internal>(intPtr3) : null;
			}
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0007BF94 File Offset: 0x0007A194
		[CallerCount(0)]
		public unsafe virtual FTRbVIakQDtduAElaDZqEnVrNpq GetAxisTarget(Controller controller, int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHardwareControllerTemplateMap_Internal.NativeMethodInfoPtr_GetAxisTarget_Public_Abstract_Virtual_New_FTRbVIakQDtduAElaDZqEnVrNpq_Controller_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FTRbVIakQDtduAElaDZqEnVrNpq>(intPtr3) : null;
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x0007C000 File Offset: 0x0007A200
		[CallerCount(0)]
		public unsafe virtual FTRbVIakQDtduAElaDZqEnVrNpq GetButtonTarget(Controller controller, int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHardwareControllerTemplateMap_Internal.NativeMethodInfoPtr_GetButtonTarget_Public_Abstract_Virtual_New_FTRbVIakQDtduAElaDZqEnVrNpq_Controller_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FTRbVIakQDtduAElaDZqEnVrNpq>(intPtr3) : null;
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00009445 File Offset: 0x00007645
		public IHardwareControllerTemplateMap_Internal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_get_typeGuid_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierCount_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_GetTemplateElementIdentifier_Public_Abstract_Virtual_New_IControllerTemplateElementIdentifier_Int32_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_GetTemplateElementIdentifierById_Public_Abstract_Virtual_New_IControllerTemplateElementIdentifier_Int32_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialTemplateElementByElementIdentifierId_Public_Abstract_Virtual_New_IControllerTemplateMapSpecialElement_Internal_Int32_0;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisTarget_Public_Abstract_Virtual_New_FTRbVIakQDtduAElaDZqEnVrNpq_Controller_Int32_0;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonTarget_Public_Abstract_Virtual_New_FTRbVIakQDtduAElaDZqEnVrNpq_Controller_Int32_0;
	}
}
