using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x020001ED RID: 493
	public class ButtonInfo : UIElementInfo
	{
		// Token: 0x06003A15 RID: 14869 RVA: 0x00024B96 File Offset: 0x00022D96
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonInfo()
		{
			Il2CppClassPointerStore<ButtonInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "ButtonInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonInfo>.NativeClassPtr);
			ButtonInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonInfo>.NativeClassPtr, 100668226);
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x000D8CC4 File Offset: 0x000D6EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x00024BCF File Offset: 0x00022DCF
		public ButtonInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040022ED RID: 8941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
