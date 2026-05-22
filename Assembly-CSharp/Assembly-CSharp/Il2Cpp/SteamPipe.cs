using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020001B7 RID: 439
	public class SteamPipe : StaticBreakable
	{
		// Token: 0x060030F4 RID: 12532 RVA: 0x000BB16C File Offset: 0x000B936C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamPipe()
		{
			Il2CppClassPointerStore<SteamPipe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SteamPipe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamPipe>.NativeClassPtr);
			SteamPipe.NativeMethodInfoPtr_Break_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPipe>.NativeClassPtr, 100667133);
			SteamPipe.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamPipe>.NativeClassPtr, 100667134);
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x000BB1C4 File Offset: 0x000B93C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84769, XrefRangeEnd = 84811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Break()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamPipe.NativeMethodInfoPtr_Break_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x000BB200 File Offset: 0x000B9400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamPipe()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamPipe>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamPipe.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x000219DB File Offset: 0x0001FBDB
		public SteamPipe(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CB8 RID: 7352
		private static readonly IntPtr NativeMethodInfoPtr_Break_Public_Virtual_Void_0;

		// Token: 0x04001CB9 RID: 7353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
