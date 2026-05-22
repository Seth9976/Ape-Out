using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000010 RID: 16
	public sealed class FixedList32BytesDebugView<T> : Object where T : new()
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00004EA0 File Offset: 0x000030A0
		// Note: this type is marked as 'beforefieldinit'.
		static FixedList32BytesDebugView()
		{
			Il2CppClassPointerStore<FixedList32BytesDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "FixedList32BytesDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedList32BytesDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000022D3 File Offset: 0x000004D3
		public FixedList32BytesDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
