using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000065 RID: 101
	public class RegexRunnerFactory : Object
	{
		// Token: 0x06000738 RID: 1848 RVA: 0x00004C37 File Offset: 0x00002E37
		// Note: this type is marked as 'beforefieldinit'.
		static RegexRunnerFactory()
		{
			Il2CppClassPointerStore<RegexRunnerFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexRunnerFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexRunnerFactory>.NativeClassPtr);
			RegexRunnerFactory.NativeMethodInfoPtr_CreateInstance_FamOrAssem_Abstract_Virtual_New_RegexRunner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunnerFactory>.NativeClassPtr, 100664380);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0002C6F0 File Offset: 0x0002A8F0
		[CallerCount(0)]
		public unsafe virtual RegexRunner CreateInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegexRunnerFactory.NativeMethodInfoPtr_CreateInstance_FamOrAssem_Abstract_Virtual_New_RegexRunner_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexRunner>(intPtr3) : null;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00004C70 File Offset: 0x00002E70
		public RegexRunnerFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_FamOrAssem_Abstract_Virtual_New_RegexRunner_0;
	}
}
