using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020000D3 RID: 211
	public class FireBomb : Throwable
	{
		// Token: 0x060018D3 RID: 6355 RVA: 0x0007A068 File Offset: 0x00078268
		// Note: this type is marked as 'beforefieldinit'.
		static FireBomb()
		{
			Il2CppClassPointerStore<FireBomb>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FireBomb");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FireBomb>.NativeClassPtr);
			FireBomb.NativeMethodInfoPtr_Break_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireBomb>.NativeClassPtr, 100665336);
			FireBomb.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireBomb>.NativeClassPtr, 100665337);
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0007A0C0 File Offset: 0x000782C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58224, XrefRangeEnd = 58254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Break()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FireBomb.NativeMethodInfoPtr_Break_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0007A0FC File Offset: 0x000782FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FireBomb()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FireBomb>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireBomb.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00011C86 File Offset: 0x0000FE86
		public FireBomb(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_Break_Public_Virtual_Void_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
