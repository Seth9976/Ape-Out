using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Playables
{
	// Token: 0x0200017E RID: 382
	public class IPlayable : Il2CppObjectBase
	{
		// Token: 0x06001D32 RID: 7474 RVA: 0x0000FA26 File Offset: 0x0000DC26
		// Note: this type is marked as 'beforefieldinit'.
		static IPlayable()
		{
			Il2CppClassPointerStore<IPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "IPlayable");
			IPlayable.NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayable>.NativeClassPtr, 100665902);
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x0006B280 File Offset: 0x00069480
		[CallerCount(0)]
		public unsafe virtual PlayableHandle GetHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayable.NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x0000FA55 File Offset: 0x0000DC55
		public IPlayable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001677 RID: 5751
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableHandle_0;
	}
}
