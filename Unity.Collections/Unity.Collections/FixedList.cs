using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections
{
	// Token: 0x0200000E RID: 14
	[StructLayout(2)]
	public struct FixedList
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00002237 File Offset: 0x00000437
		// Note: this type is marked as 'beforefieldinit'.
		static FixedList()
		{
			Il2CppClassPointerStore<FixedList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "FixedList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedList>.NativeClassPtr);
			FixedList.NativeMethodInfoPtr_PaddingBytes_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedList>.NativeClassPtr, 100663386);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004690 File Offset: 0x00002890
		[CallerCount(0)]
		public unsafe static int PaddingBytes<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedList.MethodInfoStoreGeneric_PaddingBytes_Internal_Static_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002270 File Offset: 0x00000470
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FixedList>.NativeClassPtr, ref this));
		}

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_PaddingBytes_Internal_Static_Int32_0;

		// Token: 0x0200004B RID: 75
		private sealed class MethodInfoStoreGeneric_PaddingBytes_Internal_Static_Int32_0<T>
		{
			// Token: 0x0400051A RID: 1306
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FixedList.NativeMethodInfoPtr_PaddingBytes_Internal_Static_Int32_0, Il2CppClassPointerStore<FixedList>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
