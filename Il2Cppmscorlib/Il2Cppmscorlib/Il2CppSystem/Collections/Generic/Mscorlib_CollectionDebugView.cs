using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200049E RID: 1182
	public sealed class Mscorlib_CollectionDebugView<T> : Object
	{
		// Token: 0x060047D2 RID: 18386 RVA: 0x0014B934 File Offset: 0x00149B34
		// Note: this type is marked as 'beforefieldinit'.
		static Mscorlib_CollectionDebugView()
		{
			Il2CppClassPointerStore<Mscorlib_CollectionDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "Mscorlib_CollectionDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mscorlib_CollectionDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x0001B01F File Offset: 0x0001921F
		public Mscorlib_CollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
