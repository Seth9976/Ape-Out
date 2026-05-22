using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x020000C1 RID: 193
	public class IControllerMapStore : Il2CppObjectBase
	{
		// Token: 0x060017D9 RID: 6105 RVA: 0x000889F8 File Offset: 0x00086BF8
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerMapStore()
		{
			Il2CppClassPointerStore<IControllerMapStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "IControllerMapStore");
			IControllerMapStore.NativeMethodInfoPtr_SaveControllerMap_Public_Abstract_Virtual_New_Void_Int32_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerMapStore>.NativeClassPtr, 100669136);
			IControllerMapStore.NativeMethodInfoPtr_LoadControllerMap_Public_Abstract_Virtual_New_ControllerMap_Int32_ControllerIdentifier_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerMapStore>.NativeClassPtr, 100669137);
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00088A48 File Offset: 0x00086C48
		[CallerCount(0)]
		public unsafe virtual void SaveControllerMap(int playerId, ControllerMap controllerMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controllerMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerMapStore.NativeMethodInfoPtr_SaveControllerMap_Public_Abstract_Virtual_New_Void_Int32_ControllerMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00088AA4 File Offset: 0x00086CA4
		[CallerCount(0)]
		public unsafe virtual ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(controllerIdentifier));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layoutId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerMapStore.NativeMethodInfoPtr_LoadControllerMap_Public_Abstract_Virtual_New_ControllerMap_Int32_ControllerIdentifier_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr3) : null;
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x0000A06F File Offset: 0x0000826F
		public IControllerMapStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeMethodInfoPtr_SaveControllerMap_Public_Abstract_Virtual_New_Void_Int32_ControllerMap_0;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeMethodInfoPtr_LoadControllerMap_Public_Abstract_Virtual_New_ControllerMap_Int32_ControllerIdentifier_Int32_Int32_0;
	}
}
