using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000012 RID: 18
	public sealed class FixedList64BytesDebugView<T> : Object where T : new()
	{
		// Token: 0x0600007B RID: 123 RVA: 0x000056EC File Offset: 0x000038EC
		// Note: this type is marked as 'beforefieldinit'.
		static FixedList64BytesDebugView()
		{
			Il2CppClassPointerStore<FixedList64BytesDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "FixedList64BytesDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedList64BytesDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000232D File Offset: 0x0000052D
		public FixedList64BytesDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
