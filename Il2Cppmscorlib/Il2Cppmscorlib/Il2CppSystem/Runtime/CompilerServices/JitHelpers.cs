using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000438 RID: 1080
	public static class JitHelpers : Object
	{
		// Token: 0x06004371 RID: 17265 RVA: 0x0013824C File Offset: 0x0013644C
		// Note: this type is marked as 'beforefieldinit'.
		static JitHelpers()
		{
			Il2CppClassPointerStore<JitHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "JitHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JitHelpers>.NativeClassPtr);
			JitHelpers.NativeMethodInfoPtr_UnsafeCast_Internal_Static_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JitHelpers>.NativeClassPtr, 100673147);
			JitHelpers.NativeMethodInfoPtr_UnsafeEnumCast_Internal_Static_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JitHelpers>.NativeClassPtr, 100673148);
			JitHelpers.NativeMethodInfoPtr_UnsafeEnumCastLong_Internal_Static_Int64_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JitHelpers>.NativeClassPtr, 100673149);
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x001382B8 File Offset: 0x001364B8
		[CallerCount(0)]
		public unsafe static T UnsafeCast<T>(Object o) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JitHelpers.MethodInfoStoreGeneric_UnsafeCast_Internal_Static_T_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x001382F8 File Offset: 0x001364F8
		[CallerCount(0)]
		public unsafe static int UnsafeEnumCast<T>(T val) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = val;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref val;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JitHelpers.MethodInfoStoreGeneric_UnsafeEnumCast_Internal_Static_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x00138384 File Offset: 0x00136584
		[CallerCount(0)]
		public unsafe static long UnsafeEnumCastLong<T>(T val) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = val;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref val;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JitHelpers.MethodInfoStoreGeneric_UnsafeEnumCastLong_Internal_Static_Int64_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x000199E2 File Offset: 0x00017BE2
		public JitHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040036C6 RID: 14022
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeCast_Internal_Static_T_Object_0;

		// Token: 0x040036C7 RID: 14023
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeEnumCast_Internal_Static_Int32_T_0;

		// Token: 0x040036C8 RID: 14024
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeEnumCastLong_Internal_Static_Int64_T_0;

		// Token: 0x02000644 RID: 1604
		private sealed class MethodInfoStoreGeneric_UnsafeCast_Internal_Static_T_Object_0<T>
		{
			// Token: 0x0400458E RID: 17806
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JitHelpers.NativeMethodInfoPtr_UnsafeCast_Internal_Static_T_Object_0, Il2CppClassPointerStore<JitHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000645 RID: 1605
		private sealed class MethodInfoStoreGeneric_UnsafeEnumCast_Internal_Static_Int32_T_0<T>
		{
			// Token: 0x0400458F RID: 17807
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JitHelpers.NativeMethodInfoPtr_UnsafeEnumCast_Internal_Static_Int32_T_0, Il2CppClassPointerStore<JitHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000646 RID: 1606
		private sealed class MethodInfoStoreGeneric_UnsafeEnumCastLong_Internal_Static_Int64_T_0<T>
		{
			// Token: 0x04004590 RID: 17808
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JitHelpers.NativeMethodInfoPtr_UnsafeEnumCastLong_Internal_Static_Int64_T_0, Il2CppClassPointerStore<JitHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
