using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000288 RID: 648
	public static class _ThreadPoolWaitCallback : Object
	{
		// Token: 0x06002CA3 RID: 11427 RVA: 0x0000F61E File Offset: 0x0000D81E
		// Note: this type is marked as 'beforefieldinit'.
		static _ThreadPoolWaitCallback()
		{
			Il2CppClassPointerStore<_ThreadPoolWaitCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "_ThreadPoolWaitCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_ThreadPoolWaitCallback>.NativeClassPtr);
			_ThreadPoolWaitCallback.NativeMethodInfoPtr_PerformWaitCallback_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ThreadPoolWaitCallback>.NativeClassPtr, 100670461);
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x000E62C0 File Offset: 0x000E44C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204394, XrefRangeEnd = 204398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PerformWaitCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_ThreadPoolWaitCallback.NativeMethodInfoPtr_PerformWaitCallback_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x0000F657 File Offset: 0x0000D857
		public _ThreadPoolWaitCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040026DA RID: 9946
		private static readonly IntPtr NativeMethodInfoPtr_PerformWaitCallback_Internal_Static_Boolean_0;
	}
}
