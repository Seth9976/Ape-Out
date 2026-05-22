using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x02000106 RID: 262
	public class IControllerTemplateMapMapping_Internal : Il2CppObjectBase
	{
		// Token: 0x06001988 RID: 6536 RVA: 0x0000A37D File Offset: 0x0000857D
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateMapMapping_Internal()
		{
			Il2CppClassPointerStore<IControllerTemplateMapMapping_Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "IControllerTemplateMapMapping_Internal");
			IControllerTemplateMapMapping_Internal.NativeMethodInfoPtr_GetTargets_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_IControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateMapMapping_Internal>.NativeClassPtr, 100669469);
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x0009176C File Offset: 0x0008F96C
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<IControllerElementTarget> GetTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateMapMapping_Internal.NativeMethodInfoPtr_GetTargets_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_IControllerElementTarget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IControllerElementTarget>>(intPtr3) : null;
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x0000A3AC File Offset: 0x000085AC
		public IControllerTemplateMapMapping_Internal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001633 RID: 5683
		private static readonly IntPtr NativeMethodInfoPtr_GetTargets_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_IControllerElementTarget_0;
	}
}
