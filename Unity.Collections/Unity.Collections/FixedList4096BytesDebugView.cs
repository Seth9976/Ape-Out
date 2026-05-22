using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000018 RID: 24
	public sealed class FixedList4096BytesDebugView<T> : Object where T : new()
	{
		// Token: 0x060000CE RID: 206 RVA: 0x000070E4 File Offset: 0x000052E4
		// Note: this type is marked as 'beforefieldinit'.
		static FixedList4096BytesDebugView()
		{
			Il2CppClassPointerStore<FixedList4096BytesDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "FixedList4096BytesDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedList4096BytesDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000243B File Offset: 0x0000063B
		public FixedList4096BytesDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
