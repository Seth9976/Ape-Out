using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security
{
	// Token: 0x020002C5 RID: 709
	public static class SecurityManager : Object
	{
		// Token: 0x06003032 RID: 12338 RVA: 0x000F4500 File Offset: 0x000F2700
		// Note: this type is marked as 'beforefieldinit'.
		static SecurityManager()
		{
			Il2CppClassPointerStore<SecurityManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "SecurityManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityManager>.NativeClassPtr);
			SecurityManager.NativeMethodInfoPtr_CheckElevatedPermissions_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityManager>.NativeClassPtr, 100670978);
			SecurityManager.NativeMethodInfoPtr_EnsureElevatedPermissions_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityManager>.NativeClassPtr, 100670979);
		}

		// Token: 0x06003033 RID: 12339 RVA: 0x000F4558 File Offset: 0x000F2758
		[CallerCount(0)]
		public unsafe static bool CheckElevatedPermissions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityManager.NativeMethodInfoPtr_CheckElevatedPermissions_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x000F4588 File Offset: 0x000F2788
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureElevatedPermissions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityManager.NativeMethodInfoPtr_EnsureElevatedPermissions_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x00010A84 File Offset: 0x0000EC84
		public SecurityManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400299D RID: 10653
		private static readonly IntPtr NativeMethodInfoPtr_CheckElevatedPermissions_Internal_Static_Boolean_0;

		// Token: 0x0400299E RID: 10654
		private static readonly IntPtr NativeMethodInfoPtr_EnsureElevatedPermissions_Internal_Static_Void_0;
	}
}
