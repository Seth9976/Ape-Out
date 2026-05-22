using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A2 RID: 674
	public class SystemThreadingTasks_FutureDebugView<TResult> : Object
	{
		// Token: 0x06002E0A RID: 11786 RVA: 0x000EB71C File Offset: 0x000E991C
		// Note: this type is marked as 'beforefieldinit'.
		static SystemThreadingTasks_FutureDebugView()
		{
			Il2CppClassPointerStore<SystemThreadingTasks_FutureDebugView<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "SystemThreadingTasks_FutureDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemThreadingTasks_FutureDebugView<TResult>>.NativeClassPtr);
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x00010011 File Offset: 0x0000E211
		public SystemThreadingTasks_FutureDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
