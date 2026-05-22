using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200048F RID: 1167
	public static class IntrospectiveSortUtilities : Object
	{
		// Token: 0x0600472D RID: 18221 RVA: 0x00148104 File Offset: 0x00146304
		// Note: this type is marked as 'beforefieldinit'.
		static IntrospectiveSortUtilities()
		{
			Il2CppClassPointerStore<IntrospectiveSortUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "IntrospectiveSortUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntrospectiveSortUtilities>.NativeClassPtr);
			IntrospectiveSortUtilities.NativeMethodInfoPtr_FloorLog2_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntrospectiveSortUtilities>.NativeClassPtr, 100673879);
			IntrospectiveSortUtilities.NativeMethodInfoPtr_ThrowOrIgnoreBadComparer_Internal_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntrospectiveSortUtilities>.NativeClassPtr, 100673880);
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x0014815C File Offset: 0x0014635C
		[CallerCount(0)]
		public unsafe static int FloorLog2(int n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntrospectiveSortUtilities.NativeMethodInfoPtr_FloorLog2_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x0014819C File Offset: 0x0014639C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230497, XrefRangeEnd = 230504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowOrIgnoreBadComparer(Object comparer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntrospectiveSortUtilities.NativeMethodInfoPtr_ThrowOrIgnoreBadComparer_Internal_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x0001ADEB File Offset: 0x00018FEB
		public IntrospectiveSortUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040039D5 RID: 14805
		private static readonly IntPtr NativeMethodInfoPtr_FloorLog2_Internal_Static_Int32_Int32_0;

		// Token: 0x040039D6 RID: 14806
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOrIgnoreBadComparer_Internal_Static_Void_Object_0;
	}
}
