using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Interfaces
{
	// Token: 0x020000FE RID: 254
	public class IGetSetValue<T> : Il2CppObjectBase
	{
		// Token: 0x06001921 RID: 6433 RVA: 0x0008F59C File Offset: 0x0008D79C
		// Note: this type is marked as 'beforefieldinit'.
		static IGetSetValue()
		{
			Il2CppClassPointerStore<IGetSetValue<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Interfaces", "IGetSetValue`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x0000A2E4 File Offset: 0x000084E4
		public IGetSetValue(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
