using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Concurrent
{
	// Token: 0x0200048B RID: 1163
	public sealed class IDictionaryDebugView<K, V> : Object
	{
		// Token: 0x06004719 RID: 18201 RVA: 0x001479FC File Offset: 0x00145BFC
		// Note: this type is marked as 'beforefieldinit'.
		static IDictionaryDebugView()
		{
			Il2CppClassPointerStore<IDictionaryDebugView<K, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Concurrent", "IDictionaryDebugView`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IDictionaryDebugView<K, V>>.NativeClassPtr);
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x0001AD7C File Offset: 0x00018F7C
		public IDictionaryDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
