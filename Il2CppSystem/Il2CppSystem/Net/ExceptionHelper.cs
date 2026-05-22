using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000F2 RID: 242
	public static class ExceptionHelper : Object
	{
		// Token: 0x06000D40 RID: 3392 RVA: 0x0004246C File Offset: 0x0004066C
		// Note: this type is marked as 'beforefieldinit'.
		static ExceptionHelper()
		{
			Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ExceptionHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr);
			ExceptionHelper.NativeMethodInfoPtr_get_MethodNotImplementedException_Internal_Static_get_NotImplementedException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100665206);
			ExceptionHelper.NativeMethodInfoPtr_get_PropertyNotImplementedException_Internal_Static_get_NotImplementedException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100665207);
			ExceptionHelper.NativeMethodInfoPtr_get_PropertyNotSupportedException_Internal_Static_get_NotSupportedException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100665208);
			ExceptionHelper.NativeMethodInfoPtr_get_RequestAbortedException_Internal_Static_get_WebException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100665209);
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x000424EC File Offset: 0x000406EC
		public unsafe static NotImplementedException MethodNotImplementedException
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 376791, RefRangeEnd = 376798, XrefRangeStart = 376785, XrefRangeEnd = 376791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHelper.NativeMethodInfoPtr_get_MethodNotImplementedException_Internal_Static_get_NotImplementedException_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NotImplementedException>(intPtr3) : null;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x00042520 File Offset: 0x00040720
		public unsafe static NotImplementedException PropertyNotImplementedException
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 376804, RefRangeEnd = 376818, XrefRangeStart = 376798, XrefRangeEnd = 376804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHelper.NativeMethodInfoPtr_get_PropertyNotImplementedException_Internal_Static_get_NotImplementedException_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NotImplementedException>(intPtr3) : null;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x00042554 File Offset: 0x00040754
		public unsafe static NotSupportedException PropertyNotSupportedException
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 376824, RefRangeEnd = 376825, XrefRangeStart = 376818, XrefRangeEnd = 376824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHelper.NativeMethodInfoPtr_get_PropertyNotSupportedException_Internal_Static_get_NotSupportedException_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NotSupportedException>(intPtr3) : null;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x00042588 File Offset: 0x00040788
		public unsafe static WebException RequestAbortedException
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376825, XrefRangeEnd = 376832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHelper.NativeMethodInfoPtr_get_RequestAbortedException_Internal_Static_get_WebException_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
			}
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x000073E0 File Offset: 0x000055E0
		public ExceptionHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodNotImplementedException_Internal_Static_get_NotImplementedException_0;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyNotImplementedException_Internal_Static_get_NotImplementedException_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyNotSupportedException_Internal_Static_get_NotSupportedException_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestAbortedException_Internal_Static_get_WebException_0;
	}
}
