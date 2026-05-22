using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000022 RID: 34
	public class IIndexable<T> : Il2CppObjectBase where T : new()
	{
		// Token: 0x060000EC RID: 236 RVA: 0x00009598 File Offset: 0x00007798
		// Note: this type is marked as 'beforefieldinit'.
		static IIndexable()
		{
			Il2CppClassPointerStore<IIndexable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "IIndexable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IIndexable<T>.NativeMethodInfoPtr_ElementAt_Public_Abstract_Virtual_New_byref_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIndexable<T>>.NativeClassPtr, 100663493);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00009610 File Offset: 0x00007810
		[CallerCount(0)]
		public unsafe virtual ref T ElementAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIndexable<T>.NativeMethodInfoPtr_ElementAt_Public_Abstract_Virtual_New_byref_T_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002539 File Offset: 0x00000739
		public IIndexable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_ElementAt_Public_Abstract_Virtual_New_byref_T_Int32_0;
	}
}
