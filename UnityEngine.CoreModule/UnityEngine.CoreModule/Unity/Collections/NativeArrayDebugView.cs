using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000028 RID: 40
	public sealed class NativeArrayDebugView<T> : Object where T : new()
	{
		// Token: 0x0600012F RID: 303 RVA: 0x00017DB4 File Offset: 0x00015FB4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArrayDebugView()
		{
			Il2CppClassPointerStore<NativeArrayDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeArrayDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002C64 File Offset: 0x00000E64
		public NativeArrayDebugView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00002C6D File Offset: 0x00000E6D
		public Il2CppArrayBase<T> Items
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
