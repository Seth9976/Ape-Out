using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x02000094 RID: 148
	public class IPoolableObject_Internal : Il2CppObjectBase
	{
		// Token: 0x0600115D RID: 4445 RVA: 0x0006E018 File Offset: 0x0006C218
		// Note: this type is marked as 'beforefieldinit'.
		static IPoolableObject_Internal()
		{
			Il2CppClassPointerStore<IPoolableObject_Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "IPoolableObject_Internal");
			IPoolableObject_Internal.NativeMethodInfoPtr_get_pool_Public_Abstract_Virtual_New_get_IObjectPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPoolableObject_Internal>.NativeClassPtr, 100666142);
			IPoolableObject_Internal.NativeMethodInfoPtr_set_pool_Public_Abstract_Virtual_New_set_Void_IObjectPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPoolableObject_Internal>.NativeClassPtr, 100666143);
			IPoolableObject_Internal.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPoolableObject_Internal>.NativeClassPtr, 100666144);
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x0006E07C File Offset: 0x0006C27C
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x0006E0C8 File Offset: 0x0006C2C8
		public unsafe virtual IObjectPool pool
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPoolableObject_Internal.NativeMethodInfoPtr_get_pool_Public_Abstract_Virtual_New_get_IObjectPool_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IObjectPool>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPoolableObject_Internal.NativeMethodInfoPtr_set_pool_Public_Abstract_Virtual_New_set_Void_IObjectPool_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x0006E118 File Offset: 0x0006C318
		[CallerCount(0)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPoolableObject_Internal.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00007B75 File Offset: 0x00005D75
		public IPoolableObject_Internal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeMethodInfoPtr_get_pool_Public_Abstract_Virtual_New_get_IObjectPool_0;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr_set_pool_Public_Abstract_Virtual_New_set_Void_IObjectPool_0;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0;
	}
}
