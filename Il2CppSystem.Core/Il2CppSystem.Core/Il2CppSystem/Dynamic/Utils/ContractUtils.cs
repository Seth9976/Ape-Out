using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Dynamic.Utils
{
	// Token: 0x0200001C RID: 28
	public static class ContractUtils : Object
	{
		// Token: 0x06000115 RID: 277 RVA: 0x0000268C File Offset: 0x0000088C
		// Note: this type is marked as 'beforefieldinit'.
		static ContractUtils()
		{
			Il2CppClassPointerStore<ContractUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic.Utils", "ContractUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContractUtils>.NativeClassPtr);
			ContractUtils.NativeMethodInfoPtr_get_Unreachable_Public_Static_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractUtils>.NativeClassPtr, 100663562);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00007C5C File Offset: 0x00005E5C
		public unsafe static Exception Unreachable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 363679, RefRangeEnd = 363680, XrefRangeStart = 363673, XrefRangeEnd = 363679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractUtils.NativeMethodInfoPtr_get_Unreachable_Public_Static_get_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000026C5 File Offset: 0x000008C5
		public ContractUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_get_Unreachable_Public_Static_get_Exception_0;
	}
}
