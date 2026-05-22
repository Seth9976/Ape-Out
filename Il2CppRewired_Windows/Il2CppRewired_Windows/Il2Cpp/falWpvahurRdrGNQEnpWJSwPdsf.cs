using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x020000B1 RID: 177
	public static class falWpvahurRdrGNQEnpWJSwPdsf : Object
	{
		// Token: 0x06000C23 RID: 3107 RVA: 0x00034D48 File Offset: 0x00032F48
		// Note: this type is marked as 'beforefieldinit'.
		static falWpvahurRdrGNQEnpWJSwPdsf()
		{
			Il2CppClassPointerStore<falWpvahurRdrGNQEnpWJSwPdsf>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "falWpvahurRdrGNQEnpWJSwPdsf");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<falWpvahurRdrGNQEnpWJSwPdsf>.NativeClassPtr);
			falWpvahurRdrGNQEnpWJSwPdsf.NativeMethodInfoPtr_zpcAATEMTZUXdOVQUKKQFpOgbhhU_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<falWpvahurRdrGNQEnpWJSwPdsf>.NativeClassPtr, 100665128);
			falWpvahurRdrGNQEnpWJSwPdsf.NativeMethodInfoPtr_CTvImjMEsxcfAUlwoeKKNbOexMx_Public_Static_WPOyThamDxsrbfLsNoTOiGbjxmd_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<falWpvahurRdrGNQEnpWJSwPdsf>.NativeClassPtr, 100665129);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00034DA0 File Offset: 0x00032FA0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 362580, RefRangeEnd = 362586, XrefRangeStart = 362576, XrefRangeEnd = 362580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string zpcAATEMTZUXdOVQUKKQFpOgbhhU(string A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(falWpvahurRdrGNQEnpWJSwPdsf.NativeMethodInfoPtr_zpcAATEMTZUXdOVQUKKQFpOgbhhU_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00034DDC File Offset: 0x00032FDC
		[CallerCount(0)]
		public unsafe static WPOyThamDxsrbfLsNoTOiGbjxmd CTvImjMEsxcfAUlwoeKKNbOexMx(uint A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(falWpvahurRdrGNQEnpWJSwPdsf.NativeMethodInfoPtr_CTvImjMEsxcfAUlwoeKKNbOexMx_Public_Static_WPOyThamDxsrbfLsNoTOiGbjxmd_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00007254 File Offset: 0x00005454
		public falWpvahurRdrGNQEnpWJSwPdsf(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_zpcAATEMTZUXdOVQUKKQFpOgbhhU_Public_Static_String_String_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_CTvImjMEsxcfAUlwoeKKNbOexMx_Public_Static_WPOyThamDxsrbfLsNoTOiGbjxmd_UInt32_0;
	}
}
