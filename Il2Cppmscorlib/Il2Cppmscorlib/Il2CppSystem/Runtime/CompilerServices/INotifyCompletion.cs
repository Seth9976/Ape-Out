using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200041C RID: 1052
	public class INotifyCompletion : Il2CppObjectBase
	{
		// Token: 0x060042DF RID: 17119 RVA: 0x00019471 File Offset: 0x00017671
		// Note: this type is marked as 'beforefieldinit'.
		static INotifyCompletion()
		{
			Il2CppClassPointerStore<INotifyCompletion>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "INotifyCompletion");
			INotifyCompletion.NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotifyCompletion>.NativeClassPtr, 100673083);
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x00136830 File Offset: 0x00134A30
		[CallerCount(0)]
		public unsafe virtual void OnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotifyCompletion.NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042E1 RID: 17121 RVA: 0x000194A0 File Offset: 0x000176A0
		public INotifyCompletion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003679 RID: 13945
		private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_0;
	}
}
