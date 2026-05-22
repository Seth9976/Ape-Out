using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x02000207 RID: 519
	public class IObjectPool : Il2CppObjectBase
	{
		// Token: 0x06003634 RID: 13876 RVA: 0x0010C6F4 File Offset: 0x0010A8F4
		// Note: this type is marked as 'beforefieldinit'.
		static IObjectPool()
		{
			Il2CppClassPointerStore<IObjectPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "IObjectPool");
			IObjectPool.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectPool>.NativeClassPtr, 100676696);
			IObjectPool.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectPool>.NativeClassPtr, 100676697);
			IObjectPool.NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectPool>.NativeClassPtr, 100676698);
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x0010C758 File Offset: 0x0010A958
		[CallerCount(0)]
		public unsafe virtual void Clear(bool reduceSize = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reduceSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IObjectPool.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x0010C7A4 File Offset: 0x0010A9A4
		[CallerCount(0)]
		public unsafe virtual Object Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IObjectPool.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x0010C7F0 File Offset: 0x0010A9F0
		[CallerCount(0)]
		public unsafe virtual bool Return(Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IObjectPool.NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x00012BC4 File Offset: 0x00010DC4
		public IObjectPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002DFE RID: 11774
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x04002DFF RID: 11775
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Object_0;

		// Token: 0x04002E00 RID: 11776
		private static readonly IntPtr NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_Boolean_Object_0;
	}
}
