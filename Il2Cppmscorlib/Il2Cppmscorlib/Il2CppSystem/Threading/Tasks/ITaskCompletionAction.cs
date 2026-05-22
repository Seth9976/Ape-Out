using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002AE RID: 686
	public class ITaskCompletionAction : Il2CppObjectBase
	{
		// Token: 0x06002F11 RID: 12049 RVA: 0x00010483 File Offset: 0x0000E683
		// Note: this type is marked as 'beforefieldinit'.
		static ITaskCompletionAction()
		{
			Il2CppClassPointerStore<ITaskCompletionAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "ITaskCompletionAction");
			ITaskCompletionAction.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITaskCompletionAction>.NativeClassPtr, 100670804);
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x000EFD48 File Offset: 0x000EDF48
		[CallerCount(0)]
		public unsafe virtual void Invoke(Task completingTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITaskCompletionAction.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x000104B2 File Offset: 0x0000E6B2
		public ITaskCompletionAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040028D6 RID: 10454
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Task_0;
	}
}
