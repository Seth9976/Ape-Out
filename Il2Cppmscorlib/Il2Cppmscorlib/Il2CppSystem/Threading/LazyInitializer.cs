using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000262 RID: 610
	public static class LazyInitializer : Object
	{
		// Token: 0x06002A9B RID: 10907 RVA: 0x000DEB08 File Offset: 0x000DCD08
		// Note: this type is marked as 'beforefieldinit'.
		static LazyInitializer()
		{
			Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "LazyInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr);
			LazyInitializer.NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr, 100670153);
			LazyInitializer.NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr, 100670154);
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x000DEB60 File Offset: 0x000DCD60
		[CallerCount(0)]
		public unsafe static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueFactory);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LazyInitializer.MethodInfoStoreGeneric_EnsureInitialized_Public_Static_T_byref_T_Func_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			target = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x000DEBCC File Offset: 0x000DCDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200502, XrefRangeEnd = 200503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueFactory);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LazyInitializer.MethodInfoStoreGeneric_EnsureInitializedCore_Private_Static_T_byref_T_Func_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			target = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x0000EB84 File Offset: 0x0000CD84
		public LazyInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002571 RID: 9585
		private static readonly IntPtr NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_Func_1_T_0;

		// Token: 0x04002572 RID: 9586
		private static readonly IntPtr NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_Func_1_T_0;

		// Token: 0x020005E9 RID: 1513
		private sealed class MethodInfoStoreGeneric_EnsureInitialized_Public_Static_T_byref_T_Func_1_T_0<T>
		{
			// Token: 0x04004411 RID: 17425
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LazyInitializer.NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_Func_1_T_0, Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005EA RID: 1514
		private sealed class MethodInfoStoreGeneric_EnsureInitializedCore_Private_Static_T_byref_T_Func_1_T_0<T>
		{
			// Token: 0x04004412 RID: 17426
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LazyInitializer.NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_Func_1_T_0, Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
