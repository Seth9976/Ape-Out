using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020001A7 RID: 423
	public class IScriptableRuntimeReflectionSystem : Il2CppObjectBase
	{
		// Token: 0x06001F46 RID: 8006 RVA: 0x000102E5 File Offset: 0x0000E4E5
		// Note: this type is marked as 'beforefieldinit'.
		static IScriptableRuntimeReflectionSystem()
		{
			Il2CppClassPointerStore<IScriptableRuntimeReflectionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "IScriptableRuntimeReflectionSystem");
			IScriptableRuntimeReflectionSystem.NativeMethodInfoPtr_TickRealtimeProbes_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScriptableRuntimeReflectionSystem>.NativeClassPtr, 100666165);
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x00072FCC File Offset: 0x000711CC
		[CallerCount(0)]
		public unsafe virtual bool TickRealtimeProbes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScriptableRuntimeReflectionSystem.NativeMethodInfoPtr_TickRealtimeProbes_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00010314 File Offset: 0x0000E514
		public IScriptableRuntimeReflectionSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040018A3 RID: 6307
		private static readonly IntPtr NativeMethodInfoPtr_TickRealtimeProbes_Public_Abstract_Virtual_New_Boolean_0;
	}
}
