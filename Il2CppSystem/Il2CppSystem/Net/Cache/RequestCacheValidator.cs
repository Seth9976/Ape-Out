using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x0200016F RID: 367
	public class RequestCacheValidator : Object
	{
		// Token: 0x060016F1 RID: 5873 RVA: 0x0000B6DB File Offset: 0x000098DB
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCacheValidator()
		{
			Il2CppClassPointerStore<RequestCacheValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCacheValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCacheValidator>.NativeClassPtr);
			RequestCacheValidator.NativeMethodInfoPtr_CreateValidator_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheValidator>.NativeClassPtr, 100666525);
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x000669BC File Offset: 0x00064BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388665, XrefRangeEnd = 388670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateValidator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCacheValidator.NativeMethodInfoPtr_CreateValidator_Public_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x0000B714 File Offset: 0x00009914
		public RequestCacheValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_CreateValidator_Public_Object_0;
	}
}
