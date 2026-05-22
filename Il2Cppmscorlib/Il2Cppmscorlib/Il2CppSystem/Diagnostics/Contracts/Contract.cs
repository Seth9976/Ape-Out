using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Diagnostics.Contracts
{
	// Token: 0x020004C1 RID: 1217
	public static class Contract : Object
	{
		// Token: 0x0600491D RID: 18717 RVA: 0x0001B519 File Offset: 0x00019719
		// Note: this type is marked as 'beforefieldinit'.
		static Contract()
		{
			Il2CppClassPointerStore<Contract>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Contracts", "Contract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contract>.NativeClassPtr);
			Contract.NativeMethodInfoPtr_ForAll_Public_Static_Boolean_IEnumerable_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100674241);
		}

		// Token: 0x0600491E RID: 18718 RVA: 0x00152AB0 File Offset: 0x00150CB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233487, RefRangeEnd = 233488, XrefRangeStart = 233475, XrefRangeEnd = 233487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.MethodInfoStoreGeneric_ForAll_Public_Static_Boolean_IEnumerable_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600491F RID: 18719 RVA: 0x0001B552 File Offset: 0x00019752
		public Contract(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003B3C RID: 15164
		private static readonly IntPtr NativeMethodInfoPtr_ForAll_Public_Static_Boolean_IEnumerable_1_T_Predicate_1_T_0;

		// Token: 0x02000673 RID: 1651
		private sealed class MethodInfoStoreGeneric_ForAll_Public_Static_Boolean_IEnumerable_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x040046D9 RID: 18137
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Contract.NativeMethodInfoPtr_ForAll_Public_Static_Boolean_IEnumerable_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Contract>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
