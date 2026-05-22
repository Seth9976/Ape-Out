using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Platforms.Windows
{
	// Token: 0x02000008 RID: 8
	public static class Main : Object
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00002262 File Offset: 0x00000462
		// Note: this type is marked as 'beforefieldinit'.
		static Main()
		{
			Il2CppClassPointerStore<Main>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "Rewired.Utils.Platforms.Windows", "Main");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Main>.NativeClassPtr);
			Main.NativeMethodInfoPtr_GetPlatformInitializer_Public_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100663359);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000BC34 File Offset: 0x00009E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetPlatformInitializer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Main.NativeMethodInfoPtr_GetPlatformInitializer_Public_Static_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000229B File Offset: 0x0000049B
		public Main(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformInitializer_Public_Static_Object_0;
	}
}
