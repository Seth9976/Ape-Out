using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020000D4 RID: 212
	public static class EnumerableHelpers : Object
	{
		// Token: 0x06000C0E RID: 3086 RVA: 0x00006BF1 File Offset: 0x00004DF1
		// Note: this type is marked as 'beforefieldinit'.
		static EnumerableHelpers()
		{
			Il2CppClassPointerStore<EnumerableHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "EnumerableHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumerableHelpers>.NativeClassPtr);
			EnumerableHelpers.NativeMethodInfoPtr_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableHelpers>.NativeClassPtr, 100665052);
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x0003E134 File Offset: 0x0003C334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376293, XrefRangeEnd = 376316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> ToArray<T>(IEnumerable<T> source, out int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableHelpers.MethodInfoStoreGeneric_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_byref_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00006C2A File Offset: 0x00004E2A
		public EnumerableHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_byref_Int32_0;

		// Token: 0x020001CA RID: 458
		private sealed class MethodInfoStoreGeneric_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_byref_Int32_0<T>
		{
			// Token: 0x04001436 RID: 5174
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumerableHelpers.NativeMethodInfoPtr_ToArray_Internal_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_byref_Int32_0, Il2CppClassPointerStore<EnumerableHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
