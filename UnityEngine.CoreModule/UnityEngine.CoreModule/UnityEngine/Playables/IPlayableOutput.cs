using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Playables
{
	// Token: 0x02000180 RID: 384
	public class IPlayableOutput : Il2CppObjectBase
	{
		// Token: 0x06001D3F RID: 7487 RVA: 0x0000FA67 File Offset: 0x0000DC67
		// Note: this type is marked as 'beforefieldinit'.
		static IPlayableOutput()
		{
			Il2CppClassPointerStore<IPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "IPlayableOutput");
			IPlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableOutput>.NativeClassPtr, 100665911);
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x0006B634 File Offset: 0x00069834
		[CallerCount(0)]
		public unsafe virtual PlayableOutputHandle GetHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableOutputHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x0000FA96 File Offset: 0x0000DC96
		public IPlayableOutput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001680 RID: 5760
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableOutputHandle_0;
	}
}
