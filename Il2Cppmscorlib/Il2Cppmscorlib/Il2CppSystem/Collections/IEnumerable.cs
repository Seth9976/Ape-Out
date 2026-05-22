using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x0200047C RID: 1148
	public class IEnumerable : Il2CppObjectBase
	{
		// Token: 0x060045DC RID: 17884 RVA: 0x0001A89B File Offset: 0x00018A9B
		// Note: this type is marked as 'beforefieldinit'.
		static IEnumerable()
		{
			Il2CppClassPointerStore<IEnumerable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IEnumerable");
			IEnumerable.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerable>.NativeClassPtr, 100673545);
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x001413C8 File Offset: 0x0013F5C8
		[CallerCount(0)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEnumerable.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x0001A8CA File Offset: 0x00018ACA
		public IEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040038D0 RID: 14544
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_0;
	}
}
