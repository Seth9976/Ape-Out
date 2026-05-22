using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x020001FC RID: 508
	public class ScrollbarVisibilityHelper : MonoBehaviour
	{
		// Token: 0x06003EA7 RID: 16039 RVA: 0x000EA9FC File Offset: 0x000E8BFC
		// Note: this type is marked as 'beforefieldinit'.
		static ScrollbarVisibilityHelper()
		{
			Il2CppClassPointerStore<ScrollbarVisibilityHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "ScrollbarVisibilityHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollbarVisibilityHelper>.NativeClassPtr);
			ScrollbarVisibilityHelper.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollbarVisibilityHelper>.NativeClassPtr, "scrollRect");
			ScrollbarVisibilityHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollbarVisibilityHelper>.NativeClassPtr, 100669207);
		}

		// Token: 0x06003EA8 RID: 16040 RVA: 0x000EAA54 File Offset: 0x000E8C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollbarVisibilityHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollbarVisibilityHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollbarVisibilityHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EA9 RID: 16041 RVA: 0x0002693A File Offset: 0x00024B3A
		public ScrollbarVisibilityHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06003EAA RID: 16042 RVA: 0x000EAA90 File Offset: 0x000E8C90
		// (set) Token: 0x06003EAB RID: 16043 RVA: 0x00026943 File Offset: 0x00024B43
		public unsafe ScrollRect scrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollbarVisibilityHelper.NativeFieldInfoPtr_scrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollbarVisibilityHelper.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400265F RID: 9823
		private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x04002660 RID: 9824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
