using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;

namespace Il2CppRewired.Data
{
	// Token: 0x0200009C RID: 156
	public class IConfigVars_Internal : Il2CppObjectBase
	{
		// Token: 0x06001293 RID: 4755 RVA: 0x000082F6 File Offset: 0x000064F6
		// Note: this type is marked as 'beforefieldinit'.
		static IConfigVars_Internal()
		{
			Il2CppClassPointerStore<IConfigVars_Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data", "IConfigVars_Internal");
			IConfigVars_Internal.NativeMethodInfoPtr_get_values_Public_Abstract_Virtual_New_get_KeyedGetSetValueStore_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigVars_Internal>.NativeClassPtr, 100666418);
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x00072498 File Offset: 0x00070698
		public unsafe virtual KeyedGetSetValueStore<string> values
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigVars_Internal.NativeMethodInfoPtr_get_values_Public_Abstract_Virtual_New_get_KeyedGetSetValueStore_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<KeyedGetSetValueStore<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00008325 File Offset: 0x00006525
		public IConfigVars_Internal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr_get_values_Public_Abstract_Virtual_New_get_KeyedGetSetValueStore_1_String_0;
	}
}
