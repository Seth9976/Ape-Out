using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000021 RID: 33
	public sealed class NativeHashMapDebuggerTypeProxy<TKey, TValue> : Object where TKey : new() where TValue : new()
	{
		// Token: 0x060000EA RID: 234 RVA: 0x00009518 File Offset: 0x00007718
		// Note: this type is marked as 'beforefieldinit'.
		static NativeHashMapDebuggerTypeProxy()
		{
			Il2CppClassPointerStore<NativeHashMapDebuggerTypeProxy<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "NativeHashMapDebuggerTypeProxy`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeHashMapDebuggerTypeProxy<TKey, TValue>>.NativeClassPtr);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002530 File Offset: 0x00000730
		public NativeHashMapDebuggerTypeProxy(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
