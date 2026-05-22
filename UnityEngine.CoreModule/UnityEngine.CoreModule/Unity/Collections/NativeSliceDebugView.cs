using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x0200002A RID: 42
	public sealed class NativeSliceDebugView<T> : Object where T : new()
	{
		// Token: 0x06000154 RID: 340 RVA: 0x00018604 File Offset: 0x00016804
		// Note: this type is marked as 'beforefieldinit'.
		static NativeSliceDebugView()
		{
			Il2CppClassPointerStore<NativeSliceDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeSliceDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSliceDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002D26 File Offset: 0x00000F26
		public NativeSliceDebugView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00002D2F File Offset: 0x00000F2F
		public Il2CppArrayBase<T> Items
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
