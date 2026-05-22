using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x020001EF RID: 495
	public class CanvasScalerExt : CanvasScaler
	{
		// Token: 0x06003A85 RID: 14981 RVA: 0x000DA1E8 File Offset: 0x000D83E8
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasScalerExt()
		{
			Il2CppClassPointerStore<CanvasScalerExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "CanvasScalerExt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasScalerExt>.NativeClassPtr);
			CanvasScalerExt.NativeMethodInfoPtr_ForceRefresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerExt>.NativeClassPtr, 100668264);
			CanvasScalerExt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerExt>.NativeClassPtr, 100668265);
		}

		// Token: 0x06003A86 RID: 14982 RVA: 0x000DA240 File Offset: 0x000D8440
		[CallerCount(0)]
		public unsafe void ForceRefresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScalerExt.NativeMethodInfoPtr_ForceRefresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A87 RID: 14983 RVA: 0x000DA274 File Offset: 0x000D8474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91100, XrefRangeEnd = 91103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasScalerExt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasScalerExt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScalerExt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x00025012 File Offset: 0x00023212
		public CanvasScalerExt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002335 RID: 9013
		private static readonly IntPtr NativeMethodInfoPtr_ForceRefresh_Public_Void_0;

		// Token: 0x04002336 RID: 9014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
