using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000031 RID: 49
	public sealed class UnsafeListTDebugView<T> : Object where T : new()
	{
		// Token: 0x060001F5 RID: 501 RVA: 0x0000DD50 File Offset: 0x0000BF50
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeListTDebugView()
		{
			Il2CppClassPointerStore<UnsafeListTDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections.LowLevel.Unsafe", "UnsafeListTDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeListTDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002A85 File Offset: 0x00000C85
		public UnsafeListTDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
