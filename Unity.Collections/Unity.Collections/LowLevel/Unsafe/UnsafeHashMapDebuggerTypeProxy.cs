using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200002F RID: 47
	public sealed class UnsafeHashMapDebuggerTypeProxy<TKey, TValue> : Object where TKey : new() where TValue : new()
	{
		// Token: 0x060001D3 RID: 467 RVA: 0x0000D41C File Offset: 0x0000B61C
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeHashMapDebuggerTypeProxy()
		{
			Il2CppClassPointerStore<UnsafeHashMapDebuggerTypeProxy<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections.LowLevel.Unsafe", "UnsafeHashMapDebuggerTypeProxy`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeHashMapDebuggerTypeProxy<TKey, TValue>>.NativeClassPtr);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000029DA File Offset: 0x00000BDA
		public UnsafeHashMapDebuggerTypeProxy(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
