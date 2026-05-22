using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200041D RID: 1053
	public class ICriticalNotifyCompletion : Il2CppObjectBase
	{
		// Token: 0x060042E2 RID: 17122 RVA: 0x000194A9 File Offset: 0x000176A9
		// Note: this type is marked as 'beforefieldinit'.
		static ICriticalNotifyCompletion()
		{
			Il2CppClassPointerStore<ICriticalNotifyCompletion>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ICriticalNotifyCompletion");
			ICriticalNotifyCompletion.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Abstract_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICriticalNotifyCompletion>.NativeClassPtr, 100673084);
		}

		// Token: 0x060042E3 RID: 17123 RVA: 0x00136880 File Offset: 0x00134A80
		[CallerCount(0)]
		public unsafe virtual void UnsafeOnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICriticalNotifyCompletion.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Abstract_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042E4 RID: 17124 RVA: 0x000194D8 File Offset: 0x000176D8
		public ICriticalNotifyCompletion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400367A RID: 13946
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Abstract_Virtual_New_Void_Action_0;
	}
}
