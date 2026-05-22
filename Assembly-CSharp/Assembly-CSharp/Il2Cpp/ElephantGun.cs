using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020000BF RID: 191
	public class ElephantGun : GuardGun
	{
		// Token: 0x060016A9 RID: 5801 RVA: 0x000104CF File Offset: 0x0000E6CF
		// Note: this type is marked as 'beforefieldinit'.
		static ElephantGun()
		{
			Il2CppClassPointerStore<ElephantGun>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ElephantGun");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ElephantGun>.NativeClassPtr);
			ElephantGun.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElephantGun>.NativeClassPtr, 100665198);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00074418 File Offset: 0x00072618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ElephantGun()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ElephantGun>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElephantGun.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00010508 File Offset: 0x0000E708
		public ElephantGun(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
