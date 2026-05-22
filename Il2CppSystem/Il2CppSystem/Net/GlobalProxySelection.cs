using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000E4 RID: 228
	public class GlobalProxySelection : Object
	{
		// Token: 0x06000CB1 RID: 3249 RVA: 0x000409A8 File Offset: 0x0003EBA8
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalProxySelection()
		{
			Il2CppClassPointerStore<GlobalProxySelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "GlobalProxySelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalProxySelection>.NativeClassPtr);
			GlobalProxySelection.NativeMethodInfoPtr_get_Select_Public_Static_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalProxySelection>.NativeClassPtr, 100665155);
			GlobalProxySelection.NativeMethodInfoPtr_GetEmptyWebProxy_Public_Static_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalProxySelection>.NativeClassPtr, 100665156);
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00040A00 File Offset: 0x0003EC00
		public unsafe static IWebProxy Select
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376605, XrefRangeEnd = 376615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalProxySelection.NativeMethodInfoPtr_get_Select_Public_Static_get_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00040A34 File Offset: 0x0003EC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376615, XrefRangeEnd = 376618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IWebProxy GetEmptyWebProxy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalProxySelection.NativeMethodInfoPtr_GetEmptyWebProxy_Public_Static_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00006FBE File Offset: 0x000051BE
		public GlobalProxySelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_get_Select_Public_Static_get_IWebProxy_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_GetEmptyWebProxy_Public_Static_IWebProxy_0;
	}
}
