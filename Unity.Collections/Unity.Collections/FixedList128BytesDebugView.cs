using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000014 RID: 20
	public sealed class FixedList128BytesDebugView<T> : Object where T : new()
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00005F38 File Offset: 0x00004138
		// Note: this type is marked as 'beforefieldinit'.
		static FixedList128BytesDebugView()
		{
			Il2CppClassPointerStore<FixedList128BytesDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "FixedList128BytesDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedList128BytesDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002387 File Offset: 0x00000587
		public FixedList128BytesDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
