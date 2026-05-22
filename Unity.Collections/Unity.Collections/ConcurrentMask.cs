using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections
{
	// Token: 0x0200000D RID: 13
	public class ConcurrentMask : Object
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00004504 File Offset: 0x00002704
		// Note: this type is marked as 'beforefieldinit'.
		static ConcurrentMask()
		{
			Il2CppClassPointerStore<ConcurrentMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "ConcurrentMask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentMask>.NativeClassPtr);
			ConcurrentMask.NativeMethodInfoPtr_MakeMask_Internal_Static_Int64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentMask>.NativeClassPtr, 100663383);
			ConcurrentMask.NativeMethodInfoPtr_TryFree_Internal_Static_Int32_byref_Int64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentMask>.NativeClassPtr, 100663384);
			ConcurrentMask.NativeMethodInfoPtr_TryFree_Internal_Static_Int32_byref_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentMask>.NativeClassPtr, 100663385);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004570 File Offset: 0x00002770
		[CallerCount(0)]
		public unsafe static long MakeMask(int offset, int bits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentMask.NativeMethodInfoPtr_MakeMask_Internal_Static_Int64_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000045BC File Offset: 0x000027BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 440189, RefRangeEnd = 440191, XrefRangeStart = 440189, XrefRangeEnd = 440189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TryFree(ref long l, int offset, int bits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &l;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentMask.NativeMethodInfoPtr_TryFree_Internal_Static_Int32_byref_Int64_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004618 File Offset: 0x00002818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440191, XrefRangeEnd = 440199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TryFree<T>(ref T t, int offset, int bits)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(t);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConcurrentMask.MethodInfoStoreGeneric_TryFree_Internal_Static_Int32_byref_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			t = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000222E File Offset: 0x0000042E
		public ConcurrentMask(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_MakeMask_Internal_Static_Int64_Int32_Int32_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_TryFree_Internal_Static_Int32_byref_Int64_Int32_Int32_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_TryFree_Internal_Static_Int32_byref_T_Int32_Int32_0;

		// Token: 0x0200004A RID: 74
		private sealed class MethodInfoStoreGeneric_TryFree_Internal_Static_Int32_byref_T_Int32_Int32_0<T>
		{
			// Token: 0x04000519 RID: 1305
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ConcurrentMask.NativeMethodInfoPtr_TryFree_Internal_Static_Int32_byref_T_Int32_Int32_0, Il2CppClassPointerStore<ConcurrentMask>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
