using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200041B RID: 1051
	public class IAsyncStateMachine : Il2CppObjectBase
	{
		// Token: 0x060042DB RID: 17115 RVA: 0x00136754 File Offset: 0x00134954
		// Note: this type is marked as 'beforefieldinit'.
		static IAsyncStateMachine()
		{
			Il2CppClassPointerStore<IAsyncStateMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "IAsyncStateMachine");
			IAsyncStateMachine.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncStateMachine>.NativeClassPtr, 100673081);
			IAsyncStateMachine.NativeMethodInfoPtr_SetStateMachine_Public_Abstract_Virtual_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncStateMachine>.NativeClassPtr, 100673082);
		}

		// Token: 0x060042DC RID: 17116 RVA: 0x001367A4 File Offset: 0x001349A4
		[CallerCount(0)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncStateMachine.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042DD RID: 17117 RVA: 0x001367E0 File Offset: 0x001349E0
		[CallerCount(0)]
		public unsafe virtual void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncStateMachine.NativeMethodInfoPtr_SetStateMachine_Public_Abstract_Virtual_New_Void_IAsyncStateMachine_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042DE RID: 17118 RVA: 0x00019468 File Offset: 0x00017668
		public IAsyncStateMachine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003677 RID: 13943
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04003678 RID: 13944
		private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Abstract_Virtual_New_Void_IAsyncStateMachine_0;
	}
}
