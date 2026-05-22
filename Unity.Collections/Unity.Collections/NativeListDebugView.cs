using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000024 RID: 36
	public sealed class NativeListDebugView<T> : Object where T : new()
	{
		// Token: 0x06000108 RID: 264 RVA: 0x00009E5C File Offset: 0x0000805C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeListDebugView()
		{
			Il2CppClassPointerStore<NativeListDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "NativeListDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeListDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002593 File Offset: 0x00000793
		public NativeListDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
