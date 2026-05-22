using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x020001FF RID: 511
	public class ToggleInfo : InputFieldInfo
	{
		// Token: 0x06003EE2 RID: 16098 RVA: 0x00026BDC File Offset: 0x00024DDC
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleInfo()
		{
			Il2CppClassPointerStore<ToggleInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "ToggleInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleInfo>.NativeClassPtr);
			ToggleInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleInfo>.NativeClassPtr, 100669301);
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x000EB404 File Offset: 0x000E9604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x00026C15 File Offset: 0x00024E15
		public ToggleInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400267F RID: 9855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
