using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x020000BD RID: 189
	public class IDisposable : Il2CppObjectBase
	{
		// Token: 0x06000D41 RID: 3393 RVA: 0x0000575E File Offset: 0x0000395E
		// Note: this type is marked as 'beforefieldinit'.
		static IDisposable()
		{
			Il2CppClassPointerStore<IDisposable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IDisposable");
			IDisposable.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDisposable>.NativeClassPtr, 100665534);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x0005FE14 File Offset: 0x0005E014
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDisposable.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0000578D File Offset: 0x0000398D
		public IDisposable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0;
	}
}
