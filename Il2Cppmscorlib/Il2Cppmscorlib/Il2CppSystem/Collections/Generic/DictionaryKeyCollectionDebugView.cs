using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000496 RID: 1174
	public sealed class DictionaryKeyCollectionDebugView<TKey, TValue> : Object
	{
		// Token: 0x060047A7 RID: 18343 RVA: 0x0014AAFC File Offset: 0x00148CFC
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryKeyCollectionDebugView()
		{
			Il2CppClassPointerStore<DictionaryKeyCollectionDebugView<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "DictionaryKeyCollectionDebugView`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryKeyCollectionDebugView<TKey, TValue>>.NativeClassPtr);
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x0001AFB3 File Offset: 0x000191B3
		public DictionaryKeyCollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
