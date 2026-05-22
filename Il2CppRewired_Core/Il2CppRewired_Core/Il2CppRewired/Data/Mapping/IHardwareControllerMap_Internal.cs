using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Interfaces;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x020000A9 RID: 169
	public class IHardwareControllerMap_Internal : Il2CppObjectBase
	{
		// Token: 0x06001486 RID: 5254 RVA: 0x00079DE0 File Offset: 0x00077FE0
		// Note: this type is marked as 'beforefieldinit'.
		static IHardwareControllerMap_Internal()
		{
			Il2CppClassPointerStore<IHardwareControllerMap_Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "IHardwareControllerMap_Internal");
			IHardwareControllerMap_Internal.NativeMethodInfoPtr_get_ElementIdentifiers_Public_Abstract_Virtual_New_get_IEnumerable_1_IControllerElementIdentifierCommon_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHardwareControllerMap_Internal>.NativeClassPtr, 100666758);
			IHardwareControllerMap_Internal.NativeMethodInfoPtr_GetElementIdentifier_Public_Abstract_Virtual_New_IControllerElementIdentifierCommon_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHardwareControllerMap_Internal>.NativeClassPtr, 100666759);
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x00079E30 File Offset: 0x00078030
		public unsafe virtual IEnumerable<IControllerElementIdentifierCommon_Internal> ElementIdentifiers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHardwareControllerMap_Internal.NativeMethodInfoPtr_get_ElementIdentifiers_Public_Abstract_Virtual_New_get_IEnumerable_1_IControllerElementIdentifierCommon_Internal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IControllerElementIdentifierCommon_Internal>>(intPtr3) : null;
			}
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00079E7C File Offset: 0x0007807C
		[CallerCount(0)]
		public unsafe virtual IControllerElementIdentifierCommon_Internal GetElementIdentifier(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHardwareControllerMap_Internal.NativeMethodInfoPtr_GetElementIdentifier_Public_Abstract_Virtual_New_IControllerElementIdentifierCommon_Internal_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerElementIdentifierCommon_Internal>(intPtr3) : null;
			}
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00008E5D File Offset: 0x0000705D
		public IHardwareControllerMap_Internal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementIdentifiers_Public_Abstract_Virtual_New_get_IEnumerable_1_IControllerElementIdentifierCommon_Internal_0;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifier_Public_Abstract_Virtual_New_IControllerElementIdentifierCommon_Internal_Int32_0;
	}
}
