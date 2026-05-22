using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x0200005E RID: 94
	public class lhEJGOxwkJfmYflajRgoXtbCkTe<T, TUpdate> : Il2CppObjectBase where T : new() where TUpdate : new()
	{
		// Token: 0x06000825 RID: 2085 RVA: 0x00027C2C File Offset: 0x00025E2C
		// Note: this type is marked as 'beforefieldinit'.
		static lhEJGOxwkJfmYflajRgoXtbCkTe()
		{
			Il2CppClassPointerStore<lhEJGOxwkJfmYflajRgoXtbCkTe<T, TUpdate>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "lhEJGOxwkJfmYflajRgoXtbCkTe"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TUpdate>.NativeClassPtr))
			})).TypeHandle.value);
			lhEJGOxwkJfmYflajRgoXtbCkTe<T, TUpdate>.NativeMethodInfoPtr_cTbekhGFiqbFKRZtZbZPfHNJWJyM_Public_Abstract_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lhEJGOxwkJfmYflajRgoXtbCkTe<T, TUpdate>>.NativeClassPtr, 100664719);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00027CB4 File Offset: 0x00025EB4
		[CallerCount(0)]
		public unsafe virtual void cTbekhGFiqbFKRZtZbZPfHNJWJyM(IntPtr A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), lhEJGOxwkJfmYflajRgoXtbCkTe<T, TUpdate>.NativeMethodInfoPtr_cTbekhGFiqbFKRZtZbZPfHNJWJyM_Public_Abstract_Virtual_New_Void_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0000598D File Offset: 0x00003B8D
		public lhEJGOxwkJfmYflajRgoXtbCkTe(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr_cTbekhGFiqbFKRZtZbZPfHNJWJyM_Public_Abstract_Virtual_New_Void_IntPtr_0;
	}
}
