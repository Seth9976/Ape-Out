using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000B8 RID: 184
	public class ICloneable : Il2CppObjectBase
	{
		// Token: 0x06000D22 RID: 3362 RVA: 0x000056A4 File Offset: 0x000038A4
		// Note: this type is marked as 'beforefieldinit'.
		static ICloneable()
		{
			Il2CppClassPointerStore<ICloneable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ICloneable");
			ICloneable.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICloneable>.NativeClassPtr, 100665513);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0005F484 File Offset: 0x0005D684
		[CallerCount(0)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICloneable.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x000056D3 File Offset: 0x000038D3
		public ICloneable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0;
	}
}
