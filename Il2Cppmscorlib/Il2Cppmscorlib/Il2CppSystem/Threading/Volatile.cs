using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200029B RID: 667
	public static class Volatile : Object
	{
		// Token: 0x06002DDC RID: 11740 RVA: 0x000EA3B0 File Offset: 0x000E85B0
		// Note: this type is marked as 'beforefieldinit'.
		static Volatile()
		{
			Il2CppClassPointerStore<Volatile>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Volatile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Volatile>.NativeClassPtr);
			Volatile.NativeMethodInfoPtr_Read_Public_Static_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volatile>.NativeClassPtr, 100670589);
			Volatile.NativeMethodInfoPtr_Read_Public_Static_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volatile>.NativeClassPtr, 100670590);
			Volatile.NativeMethodInfoPtr_Write_Public_Static_Void_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volatile>.NativeClassPtr, 100670591);
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x000EA41C File Offset: 0x000E861C
		[CallerCount(0)]
		public unsafe static bool Read(ref bool location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volatile.NativeMethodInfoPtr_Read_Public_Static_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x000EA45C File Offset: 0x000E865C
		[CallerCount(0)]
		public unsafe static T Read<T>(ref T location) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(location);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Volatile.MethodInfoStoreGeneric_Read_Public_Static_T_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				location = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x000EA4B4 File Offset: 0x000E86B4
		[CallerCount(0)]
		public unsafe static void Write<T>(ref T location, T value) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location);
				ptr2 = &intPtr;
			}
			IntPtr* ptr3 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr5;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr4 = (ptr5 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr4) != null)
					{
						ptr5 = ref ptr4;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr4)))
						{
							ptr5 = IL2CPP.il2cpp_object_unbox(ref ptr4);
						}
					}
				}
				else
				{
					ptr5 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr5 = ref value;
			}
			*ptr3 = ref ptr5;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Volatile.MethodInfoStoreGeneric_Write_Public_Static_Void_byref_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			location = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x0000FFD2 File Offset: 0x0000E1D2
		public Volatile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040027AE RID: 10158
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Boolean_byref_Boolean_0;

		// Token: 0x040027AF RID: 10159
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_T_byref_T_0;

		// Token: 0x040027B0 RID: 10160
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_byref_T_T_0;

		// Token: 0x020005FC RID: 1532
		private sealed class MethodInfoStoreGeneric_Read_Public_Static_T_byref_T_0<T>
		{
			// Token: 0x0400446F RID: 17519
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Volatile.NativeMethodInfoPtr_Read_Public_Static_T_byref_T_0, Il2CppClassPointerStore<Volatile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005FD RID: 1533
		private sealed class MethodInfoStoreGeneric_Write_Public_Static_Void_byref_T_T_0<T>
		{
			// Token: 0x04004470 RID: 17520
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Volatile.NativeMethodInfoPtr_Write_Public_Static_Void_byref_T_T_0, Il2CppClassPointerStore<Volatile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
