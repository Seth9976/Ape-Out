using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000032 RID: 50
	public static class UnsafeUtilityExtensions : Object
	{
		// Token: 0x060001F7 RID: 503 RVA: 0x00002A8E File Offset: 0x00000C8E
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeUtilityExtensions()
		{
			Il2CppClassPointerStore<UnsafeUtilityExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections.LowLevel.Unsafe", "UnsafeUtilityExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeUtilityExtensions>.NativeClassPtr);
			UnsafeUtilityExtensions.NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtilityExtensions>.NativeClassPtr, 100663667);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000DDBC File Offset: 0x0000BFBC
		[CallerCount(0)]
		public unsafe static void* AddressOf<T>([In] ref T value) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtilityExtensions.MethodInfoStoreGeneric_AddressOf_Public_Static_ptr_Void_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return intPtr2;
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002AC7 File Offset: 0x00000CC7
		public UnsafeUtilityExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0;

		// Token: 0x02000061 RID: 97
		private sealed class MethodInfoStoreGeneric_AddressOf_Public_Static_ptr_Void_byref_T_0<T>
		{
			// Token: 0x0400055E RID: 1374
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtilityExtensions.NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0, Il2CppClassPointerStore<UnsafeUtilityExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
