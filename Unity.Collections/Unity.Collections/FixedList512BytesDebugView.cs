using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000016 RID: 22
	public sealed class FixedList512BytesDebugView<T> : Object where T : new()
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00006784 File Offset: 0x00004984
		// Note: this type is marked as 'beforefieldinit'.
		static FixedList512BytesDebugView()
		{
			Il2CppClassPointerStore<FixedList512BytesDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "FixedList512BytesDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedList512BytesDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000023E1 File Offset: 0x000005E1
		public FixedList512BytesDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
