using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x020001FB RID: 507
	public class ScrollRectSelectableChild : MonoBehaviour
	{
		// Token: 0x06003E97 RID: 16023 RVA: 0x000EA6E0 File Offset: 0x000E88E0
		// Note: this type is marked as 'beforefieldinit'.
		static ScrollRectSelectableChild()
		{
			Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "ScrollRectSelectableChild");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr);
			ScrollRectSelectableChild.NativeFieldInfoPtr_useCustomEdgePadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, "useCustomEdgePadding");
			ScrollRectSelectableChild.NativeFieldInfoPtr_customEdgePadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, "customEdgePadding");
			ScrollRectSelectableChild.NativeFieldInfoPtr_parentScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, "parentScrollRect");
			ScrollRectSelectableChild.NativeFieldInfoPtr__selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, "_selectable");
			ScrollRectSelectableChild.NativeMethodInfoPtr_get_parentScrollRectContentTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, 100669201);
			ScrollRectSelectableChild.NativeMethodInfoPtr_get_selectable_Private_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, 100669202);
			ScrollRectSelectableChild.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, 100669203);
			ScrollRectSelectableChild.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, 100669204);
			ScrollRectSelectableChild.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, 100669205);
			ScrollRectSelectableChild.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, 100669206);
		}

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06003E98 RID: 16024 RVA: 0x000EA7D8 File Offset: 0x000E89D8
		public unsafe RectTransform parentScrollRectContentTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectSelectableChild.NativeMethodInfoPtr_get_parentScrollRectContentTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06003E99 RID: 16025 RVA: 0x000EA818 File Offset: 0x000E8A18
		public unsafe Selectable selectable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99098, XrefRangeEnd = 99101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectSelectableChild.NativeMethodInfoPtr_get_selectable_Private_get_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06003E9A RID: 16026 RVA: 0x000EA858 File Offset: 0x000E8A58
		public unsafe RectTransform rectTransform
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 99104, RefRangeEnd = 99105, XrefRangeStart = 99101, XrefRangeEnd = 99104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectSelectableChild.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x000EA898 File Offset: 0x000E8A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99105, XrefRangeEnd = 99128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectSelectableChild.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E9C RID: 16028 RVA: 0x000EA8CC File Offset: 0x000E8ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99128, XrefRangeEnd = 99171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectSelectableChild.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E9D RID: 16029 RVA: 0x000EA910 File Offset: 0x000E8B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99171, XrefRangeEnd = 99174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollRectSelectableChild()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectSelectableChild.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E9E RID: 16030 RVA: 0x000268BD File Offset: 0x00024ABD
		public ScrollRectSelectableChild(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x06003E9F RID: 16031 RVA: 0x000EA94C File Offset: 0x000E8B4C
		// (set) Token: 0x06003EA0 RID: 16032 RVA: 0x000268C6 File Offset: 0x00024AC6
		public unsafe bool useCustomEdgePadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectSelectableChild.NativeFieldInfoPtr_useCustomEdgePadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectSelectableChild.NativeFieldInfoPtr_useCustomEdgePadding)) = value;
			}
		}

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x06003EA1 RID: 16033 RVA: 0x000EA974 File Offset: 0x000E8B74
		// (set) Token: 0x06003EA2 RID: 16034 RVA: 0x000268E1 File Offset: 0x00024AE1
		public unsafe float customEdgePadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectSelectableChild.NativeFieldInfoPtr_customEdgePadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectSelectableChild.NativeFieldInfoPtr_customEdgePadding)) = value;
			}
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x06003EA3 RID: 16035 RVA: 0x000EA99C File Offset: 0x000E8B9C
		// (set) Token: 0x06003EA4 RID: 16036 RVA: 0x000268FC File Offset: 0x00024AFC
		public unsafe ScrollRect parentScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectSelectableChild.NativeFieldInfoPtr_parentScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectSelectableChild.NativeFieldInfoPtr_parentScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x06003EA5 RID: 16037 RVA: 0x000EA9CC File Offset: 0x000E8BCC
		// (set) Token: 0x06003EA6 RID: 16038 RVA: 0x0002691B File Offset: 0x00024B1B
		public unsafe Selectable _selectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectSelectableChild.NativeFieldInfoPtr__selectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectSelectableChild.NativeFieldInfoPtr__selectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002655 RID: 9813
		private static readonly IntPtr NativeFieldInfoPtr_useCustomEdgePadding;

		// Token: 0x04002656 RID: 9814
		private static readonly IntPtr NativeFieldInfoPtr_customEdgePadding;

		// Token: 0x04002657 RID: 9815
		private static readonly IntPtr NativeFieldInfoPtr_parentScrollRect;

		// Token: 0x04002658 RID: 9816
		private static readonly IntPtr NativeFieldInfoPtr__selectable;

		// Token: 0x04002659 RID: 9817
		private static readonly IntPtr NativeMethodInfoPtr_get_parentScrollRectContentTransform_Private_get_RectTransform_0;

		// Token: 0x0400265A RID: 9818
		private static readonly IntPtr NativeMethodInfoPtr_get_selectable_Private_get_Selectable_0;

		// Token: 0x0400265B RID: 9819
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0;

		// Token: 0x0400265C RID: 9820
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400265D RID: 9821
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x0400265E RID: 9822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
