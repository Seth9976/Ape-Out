using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x02000115 RID: 277
	public static class EmptyArray<T> : Object
	{
		// Token: 0x060014A3 RID: 5283 RVA: 0x00082C48 File Offset: 0x00080E48
		// Note: this type is marked as 'beforefieldinit'.
		static EmptyArray()
		{
			Il2CppClassPointerStore<EmptyArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "EmptyArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyArray<T>>.NativeClassPtr);
			EmptyArray<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyArray<T>>.NativeClassPtr, "Value");
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x0000717F File Offset: 0x0000537F
		public EmptyArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x00082CC8 File Offset: 0x00080EC8
		// (set) Token: 0x060014A6 RID: 5286 RVA: 0x00007188 File Offset: 0x00005388
		public unsafe static Il2CppArrayBase<T> Value
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EmptyArray<T>.NativeFieldInfoPtr_Value, (void*)(&intPtr));
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmptyArray<T>.NativeFieldInfoPtr_Value, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeFieldInfoPtr_Value;
	}
}
