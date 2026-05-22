using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000497 RID: 1175
	public sealed class DictionaryValueCollectionDebugView<TKey, TValue> : Object
	{
		// Token: 0x060047A9 RID: 18345 RVA: 0x0014AB7C File Offset: 0x00148D7C
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryValueCollectionDebugView()
		{
			Il2CppClassPointerStore<DictionaryValueCollectionDebugView<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "DictionaryValueCollectionDebugView`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryValueCollectionDebugView<TKey, TValue>>.NativeClassPtr);
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x0001AFBC File Offset: 0x000191BC
		public DictionaryValueCollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
