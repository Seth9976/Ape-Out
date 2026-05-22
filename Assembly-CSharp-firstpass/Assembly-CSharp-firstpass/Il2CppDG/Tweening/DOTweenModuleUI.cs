using System;
using Il2CppDG.Tweening.Core;
using Il2CppDG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppDG.Tweening
{
	// Token: 0x020001F1 RID: 497
	public static class DOTweenModuleUI : global::Il2CppSystem.Object
	{
		// Token: 0x0600195A RID: 6490 RVA: 0x00072588 File Offset: 0x00070788
		// Note: this type is marked as 'beforefieldinit'.
		static DOTweenModuleUI()
		{
			Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "DG.Tweening", "DOTweenModuleUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr);
			DOTweenModuleUI.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Single_Single_FloatOptions_CanvasGroup_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667130);
			DOTweenModuleUI.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Graphic_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667131);
			DOTweenModuleUI.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Graphic_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667132);
			DOTweenModuleUI.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Image_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667133);
			DOTweenModuleUI.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Image_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667134);
			DOTweenModuleUI.NativeMethodInfoPtr_DOFillAmount_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Image_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667135);
			DOTweenModuleUI.NativeMethodInfoPtr_DOGradientColor_Public_Static_Sequence_Image_Gradient_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667136);
			DOTweenModuleUI.NativeMethodInfoPtr_DOFlexibleSize_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_LayoutElement_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667137);
			DOTweenModuleUI.NativeMethodInfoPtr_DOMinSize_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_LayoutElement_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667138);
			DOTweenModuleUI.NativeMethodInfoPtr_DOPreferredSize_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_LayoutElement_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667139);
			DOTweenModuleUI.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Outline_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667140);
			DOTweenModuleUI.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Outline_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667141);
			DOTweenModuleUI.NativeMethodInfoPtr_DOScale_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Outline_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667142);
			DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorPos_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667143);
			DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorPosX_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667144);
			DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorPosY_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667145);
			DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorPos3D_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_RectTransform_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667146);
			DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorPos3DX_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_RectTransform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667147);
			DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorPos3DY_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_RectTransform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667148);
			DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorPos3DZ_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_RectTransform_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667149);
			DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorMax_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667150);
			DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorMin_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667151);
			DOTweenModuleUI.NativeMethodInfoPtr_DOPivot_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667152);
			DOTweenModuleUI.NativeMethodInfoPtr_DOPivotX_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667153);
			DOTweenModuleUI.NativeMethodInfoPtr_DOPivotY_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667154);
			DOTweenModuleUI.NativeMethodInfoPtr_DOSizeDelta_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667155);
			DOTweenModuleUI.NativeMethodInfoPtr_DOPunchAnchorPos_Public_Static_Tweener_RectTransform_Vector2_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667156);
			DOTweenModuleUI.NativeMethodInfoPtr_DOShakeAnchorPos_Public_Static_Tweener_RectTransform_Single_Single_Int32_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667157);
			DOTweenModuleUI.NativeMethodInfoPtr_DOShakeAnchorPos_Public_Static_Tweener_RectTransform_Single_Vector2_Int32_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667158);
			DOTweenModuleUI.NativeMethodInfoPtr_DOJumpAnchorPos_Public_Static_Sequence_RectTransform_Vector2_Single_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667159);
			DOTweenModuleUI.NativeMethodInfoPtr_DONormalizedPos_Public_Static_Tweener_ScrollRect_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667160);
			DOTweenModuleUI.NativeMethodInfoPtr_DOHorizontalNormalizedPos_Public_Static_Tweener_ScrollRect_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667161);
			DOTweenModuleUI.NativeMethodInfoPtr_DOVerticalNormalizedPos_Public_Static_Tweener_ScrollRect_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667162);
			DOTweenModuleUI.NativeMethodInfoPtr_DOValue_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Slider_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667163);
			DOTweenModuleUI.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Text_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667164);
			DOTweenModuleUI.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Text_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667165);
			DOTweenModuleUI.NativeMethodInfoPtr_DOText_Public_Static_TweenerCore_3_String_String_StringOptions_Text_String_Single_Boolean_ScrambleMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667166);
			DOTweenModuleUI.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Graphic_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667167);
			DOTweenModuleUI.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Image_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667168);
			DOTweenModuleUI.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Text_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, 100667169);
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x000728D8 File Offset: 0x00070AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21593, XrefRangeEnd = 21614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Single_Single_FloatOptions_CanvasGroup_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x00072938 File Offset: 0x00070B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21614, XrefRangeEnd = 21640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Graphic_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x00072998 File Offset: 0x00070B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21640, XrefRangeEnd = 21661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Graphic_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x000729F8 File Offset: 0x00070BF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21687, RefRangeEnd = 21688, XrefRangeStart = 21661, XrefRangeEnd = 21687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Image_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x00072A58 File Offset: 0x00070C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21688, XrefRangeEnd = 21709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Image_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x00072AB8 File Offset: 0x00070CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21709, XrefRangeEnd = 21731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOFillAmount_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Image_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00072B18 File Offset: 0x00070D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21731, XrefRangeEnd = 21750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gradient);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOGradientColor_Public_Static_Sequence_Image_Gradient_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x00072B7C File Offset: 0x00070D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21750, XrefRangeEnd = 21771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOFlexibleSize_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_LayoutElement_Vector2_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x00072BEC File Offset: 0x00070DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21771, XrefRangeEnd = 21792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOMinSize_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_LayoutElement_Vector2_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x00072C5C File Offset: 0x00070E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21792, XrefRangeEnd = 21813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOPreferredSize_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_LayoutElement_Vector2_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00072CCC File Offset: 0x00070ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21813, XrefRangeEnd = 21839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Outline_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x00072D2C File Offset: 0x00070F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21839, XrefRangeEnd = 21860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Outline_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x00072D8C File Offset: 0x00070F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21860, XrefRangeEnd = 21881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOScale_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Outline_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x00072DEC File Offset: 0x00070FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21881, XrefRangeEnd = 21902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorPos_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Vector2_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00072E5C File Offset: 0x0007105C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21902, XrefRangeEnd = 21923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorPosX_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x00072ECC File Offset: 0x000710CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21923, XrefRangeEnd = 21944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorPosY_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x00072F3C File Offset: 0x0007113C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21944, XrefRangeEnd = 21970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorPos3D_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_RectTransform_Vector3_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00072FAC File Offset: 0x000711AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21970, XrefRangeEnd = 21996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorPos3DX_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_RectTransform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x0007301C File Offset: 0x0007121C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21996, XrefRangeEnd = 22022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorPos3DY_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_RectTransform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x0007308C File Offset: 0x0007128C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22022, XrefRangeEnd = 22048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorPos3DZ_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_RectTransform_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Vector3, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x000730FC File Offset: 0x000712FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22048, XrefRangeEnd = 22069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorMax_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Vector2_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x0007316C File Offset: 0x0007136C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22069, XrefRangeEnd = 22090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOAnchorMin_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Vector2_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x000731DC File Offset: 0x000713DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22090, XrefRangeEnd = 22111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOPivot_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x0007323C File Offset: 0x0007143C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22111, XrefRangeEnd = 22132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOPivotX_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x0007329C File Offset: 0x0007149C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22132, XrefRangeEnd = 22153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOPivotY_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x000732FC File Offset: 0x000714FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22153, XrefRangeEnd = 22174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOSizeDelta_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Vector2_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x0007336C File Offset: 0x0007156C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22174, XrefRangeEnd = 22195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref punch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elasticity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOPunchAnchorPos_Public_Static_Tweener_RectTransform_Vector2_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x000733F8 File Offset: 0x000715F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22195, XrefRangeEnd = 22217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOShakeAnchorPos_Public_Static_Tweener_RectTransform_Single_Single_Int32_Single_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00073490 File Offset: 0x00071690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22217, XrefRangeEnd = 22239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrato;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomness;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOShakeAnchorPos_Public_Static_Tweener_RectTransform_Single_Vector2_Int32_Single_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00073528 File Offset: 0x00071728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22239, XrefRangeEnd = 22298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jumpPower;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numJumps;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOJumpAnchorPos_Public_Static_Sequence_RectTransform_Vector2_Single_Int32_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x000735B4 File Offset: 0x000717B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22298, XrefRangeEnd = 22319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DONormalizedPos_Public_Static_Tweener_ScrollRect_Vector2_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00073624 File Offset: 0x00071824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22319, XrefRangeEnd = 22340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOHorizontalNormalizedPos_Public_Static_Tweener_ScrollRect_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00073694 File Offset: 0x00071894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22340, XrefRangeEnd = 22361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOVerticalNormalizedPos_Public_Static_Tweener_ScrollRect_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x00073704 File Offset: 0x00071904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22361, XrefRangeEnd = 22382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref snapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOValue_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Slider_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<float, float, FloatOptions>>(intPtr3) : null;
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00073774 File Offset: 0x00071974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22382, XrefRangeEnd = 22408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Text_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x000737D4 File Offset: 0x000719D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22408, XrefRangeEnd = 22429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Text_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Color, Color, ColorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00073834 File Offset: 0x00071A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22429, XrefRangeEnd = 22473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, string scrambleChars = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(endValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref richTextEnabled;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrambleMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(scrambleChars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOText_Public_Static_TweenerCore_3_String_String_StringOptions_Text_String_Single_Boolean_ScrambleMode_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<string, string, StringOptions>>(intPtr3) : null;
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x000738C8 File Offset: 0x00071AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22473, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Graphic_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00073928 File Offset: 0x00071B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22500, XrefRangeEnd = 22527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Image_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00073988 File Offset: 0x00071B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22527, XrefRangeEnd = 22554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Text_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tweener>(intPtr3) : null;
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00009F10 File Offset: 0x00008110
		public DOTweenModuleUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A49 RID: 6729
		private static readonly IntPtr NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Single_Single_FloatOptions_CanvasGroup_Single_Single_0;

		// Token: 0x04001A4A RID: 6730
		private static readonly IntPtr NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Graphic_Color_Single_0;

		// Token: 0x04001A4B RID: 6731
		private static readonly IntPtr NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Graphic_Single_Single_0;

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Image_Color_Single_0;

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Image_Single_Single_0;

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeMethodInfoPtr_DOFillAmount_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Image_Single_Single_0;

		// Token: 0x04001A4F RID: 6735
		private static readonly IntPtr NativeMethodInfoPtr_DOGradientColor_Public_Static_Sequence_Image_Gradient_Single_0;

		// Token: 0x04001A50 RID: 6736
		private static readonly IntPtr NativeMethodInfoPtr_DOFlexibleSize_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_LayoutElement_Vector2_Single_Boolean_0;

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeMethodInfoPtr_DOMinSize_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_LayoutElement_Vector2_Single_Boolean_0;

		// Token: 0x04001A52 RID: 6738
		private static readonly IntPtr NativeMethodInfoPtr_DOPreferredSize_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_LayoutElement_Vector2_Single_Boolean_0;

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Outline_Color_Single_0;

		// Token: 0x04001A54 RID: 6740
		private static readonly IntPtr NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Outline_Single_Single_0;

		// Token: 0x04001A55 RID: 6741
		private static readonly IntPtr NativeMethodInfoPtr_DOScale_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Outline_Vector2_Single_0;

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeMethodInfoPtr_DOAnchorPos_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Vector2_Single_Boolean_0;

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeMethodInfoPtr_DOAnchorPosX_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Single_Single_Boolean_0;

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeMethodInfoPtr_DOAnchorPosY_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Single_Single_Boolean_0;

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeMethodInfoPtr_DOAnchorPos3D_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_RectTransform_Vector3_Single_Boolean_0;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeMethodInfoPtr_DOAnchorPos3DX_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_RectTransform_Single_Single_Boolean_0;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeMethodInfoPtr_DOAnchorPos3DY_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_RectTransform_Single_Single_Boolean_0;

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeMethodInfoPtr_DOAnchorPos3DZ_Public_Static_TweenerCore_3_Vector3_Vector3_VectorOptions_RectTransform_Single_Single_Boolean_0;

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeMethodInfoPtr_DOAnchorMax_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Vector2_Single_Boolean_0;

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeMethodInfoPtr_DOAnchorMin_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Vector2_Single_Boolean_0;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeMethodInfoPtr_DOPivot_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Vector2_Single_0;

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeMethodInfoPtr_DOPivotX_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Single_Single_0;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeMethodInfoPtr_DOPivotY_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Single_Single_0;

		// Token: 0x04001A62 RID: 6754
		private static readonly IntPtr NativeMethodInfoPtr_DOSizeDelta_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_RectTransform_Vector2_Single_Boolean_0;

		// Token: 0x04001A63 RID: 6755
		private static readonly IntPtr NativeMethodInfoPtr_DOPunchAnchorPos_Public_Static_Tweener_RectTransform_Vector2_Single_Int32_Single_Boolean_0;

		// Token: 0x04001A64 RID: 6756
		private static readonly IntPtr NativeMethodInfoPtr_DOShakeAnchorPos_Public_Static_Tweener_RectTransform_Single_Single_Int32_Single_Boolean_Boolean_0;

		// Token: 0x04001A65 RID: 6757
		private static readonly IntPtr NativeMethodInfoPtr_DOShakeAnchorPos_Public_Static_Tweener_RectTransform_Single_Vector2_Int32_Single_Boolean_Boolean_0;

		// Token: 0x04001A66 RID: 6758
		private static readonly IntPtr NativeMethodInfoPtr_DOJumpAnchorPos_Public_Static_Sequence_RectTransform_Vector2_Single_Int32_Single_Boolean_0;

		// Token: 0x04001A67 RID: 6759
		private static readonly IntPtr NativeMethodInfoPtr_DONormalizedPos_Public_Static_Tweener_ScrollRect_Vector2_Single_Boolean_0;

		// Token: 0x04001A68 RID: 6760
		private static readonly IntPtr NativeMethodInfoPtr_DOHorizontalNormalizedPos_Public_Static_Tweener_ScrollRect_Single_Single_Boolean_0;

		// Token: 0x04001A69 RID: 6761
		private static readonly IntPtr NativeMethodInfoPtr_DOVerticalNormalizedPos_Public_Static_Tweener_ScrollRect_Single_Single_Boolean_0;

		// Token: 0x04001A6A RID: 6762
		private static readonly IntPtr NativeMethodInfoPtr_DOValue_Public_Static_TweenerCore_3_Single_Single_FloatOptions_Slider_Single_Single_Boolean_0;

		// Token: 0x04001A6B RID: 6763
		private static readonly IntPtr NativeMethodInfoPtr_DOColor_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Text_Color_Single_0;

		// Token: 0x04001A6C RID: 6764
		private static readonly IntPtr NativeMethodInfoPtr_DOFade_Public_Static_TweenerCore_3_Color_Color_ColorOptions_Text_Single_Single_0;

		// Token: 0x04001A6D RID: 6765
		private static readonly IntPtr NativeMethodInfoPtr_DOText_Public_Static_TweenerCore_3_String_String_StringOptions_Text_String_Single_Boolean_ScrambleMode_String_0;

		// Token: 0x04001A6E RID: 6766
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Graphic_Color_Single_0;

		// Token: 0x04001A6F RID: 6767
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Image_Color_Single_0;

		// Token: 0x04001A70 RID: 6768
		private static readonly IntPtr NativeMethodInfoPtr_DOBlendableColor_Public_Static_Tweener_Text_Color_Single_0;

		// Token: 0x02000287 RID: 647
		public static class Utils : global::Il2CppSystem.Object
		{
			// Token: 0x060022D2 RID: 8914 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
			// Note: this type is marked as 'beforefieldinit'.
			static Utils()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.Utils>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "Utils");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.Utils>.NativeClassPtr);
				DOTweenModuleUI.Utils.NativeMethodInfoPtr_SwitchToRectTransform_Public_Static_Vector2_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.Utils>.NativeClassPtr, 100667170);
			}

			// Token: 0x060022D3 RID: 8915 RVA: 0x00096208 File Offset: 0x00094408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21496, XrefRangeEnd = 21528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.Utils.NativeMethodInfoPtr_SwitchToRectTransform_Public_Static_Vector2_RectTransform_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060022D4 RID: 8916 RVA: 0x0000D0E4 File Offset: 0x0000B2E4
			public Utils(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040021BD RID: 8637
			private static readonly IntPtr NativeMethodInfoPtr_SwitchToRectTransform_Public_Static_Vector2_RectTransform_RectTransform_0;
		}

		// Token: 0x02000288 RID: 648
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060022D5 RID: 8917 RVA: 0x0009625C File Offset: 0x0009445C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass0_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass0_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass0_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass0_0>.NativeClassPtr, 100667171);
				DOTweenModuleUI.__c__DisplayClass0_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass0_0>.NativeClassPtr, 100667172);
				DOTweenModuleUI.__c__DisplayClass0_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass0_0>.NativeClassPtr, 100667173);
			}

			// Token: 0x060022D6 RID: 8918 RVA: 0x000962D8 File Offset: 0x000944D8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022D7 RID: 8919 RVA: 0x00096314 File Offset: 0x00094514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21528, XrefRangeEnd = 21533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOFade_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass0_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060022D8 RID: 8920 RVA: 0x00096350 File Offset: 0x00094550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21533, XrefRangeEnd = 21538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOFade_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass0_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022D9 RID: 8921 RVA: 0x0000D0ED File Offset: 0x0000B2ED
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000716 RID: 1814
			// (get) Token: 0x060022DA RID: 8922 RVA: 0x00096390 File Offset: 0x00094590
			// (set) Token: 0x060022DB RID: 8923 RVA: 0x0000D0F6 File Offset: 0x0000B2F6
			public unsafe CanvasGroup target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass0_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass0_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021BE RID: 8638
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021BF RID: 8639
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021C0 RID: 8640
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__0_Internal_Single_0;

			// Token: 0x040021C1 RID: 8641
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Single_0;
		}

		// Token: 0x02000289 RID: 649
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060022DC RID: 8924 RVA: 0x000963C0 File Offset: 0x000945C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass1_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass1_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass1_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass1_0>.NativeClassPtr, 100667174);
				DOTweenModuleUI.__c__DisplayClass1_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass1_0>.NativeClassPtr, 100667175);
				DOTweenModuleUI.__c__DisplayClass1_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass1_0>.NativeClassPtr, 100667176);
			}

			// Token: 0x060022DD RID: 8925 RVA: 0x0009643C File Offset: 0x0009463C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022DE RID: 8926 RVA: 0x00096478 File Offset: 0x00094678
			[CallerCount(0)]
			public unsafe Color _DOColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass1_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060022DF RID: 8927 RVA: 0x000964B4 File Offset: 0x000946B4
			[CallerCount(0)]
			public unsafe void _DOColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass1_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022E0 RID: 8928 RVA: 0x0000D115 File Offset: 0x0000B315
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000717 RID: 1815
			// (get) Token: 0x060022E1 RID: 8929 RVA: 0x000964F4 File Offset: 0x000946F4
			// (set) Token: 0x060022E2 RID: 8930 RVA: 0x0000D11E File Offset: 0x0000B31E
			public unsafe Graphic target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass1_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass1_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021C2 RID: 8642
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021C3 RID: 8643
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021C4 RID: 8644
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0;

			// Token: 0x040021C5 RID: 8645
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x0200028A RID: 650
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060022E3 RID: 8931 RVA: 0x00096524 File Offset: 0x00094724
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass2_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass2_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass2_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass2_0>.NativeClassPtr, 100667177);
				DOTweenModuleUI.__c__DisplayClass2_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass2_0>.NativeClassPtr, 100667178);
				DOTweenModuleUI.__c__DisplayClass2_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass2_0>.NativeClassPtr, 100667179);
			}

			// Token: 0x060022E4 RID: 8932 RVA: 0x000965A0 File Offset: 0x000947A0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022E5 RID: 8933 RVA: 0x000965DC File Offset: 0x000947DC
			[CallerCount(0)]
			public unsafe Color _DOFade_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass2_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060022E6 RID: 8934 RVA: 0x00096618 File Offset: 0x00094818
			[CallerCount(0)]
			public unsafe void _DOFade_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass2_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022E7 RID: 8935 RVA: 0x0000D13D File Offset: 0x0000B33D
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000718 RID: 1816
			// (get) Token: 0x060022E8 RID: 8936 RVA: 0x00096658 File Offset: 0x00094858
			// (set) Token: 0x060022E9 RID: 8937 RVA: 0x0000D146 File Offset: 0x0000B346
			public unsafe Graphic target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass2_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass2_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021C6 RID: 8646
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021C7 RID: 8647
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021C8 RID: 8648
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0;

			// Token: 0x040021C9 RID: 8649
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0;
		}

		// Token: 0x0200028B RID: 651
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060022EA RID: 8938 RVA: 0x00096688 File Offset: 0x00094888
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass3_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass3_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass3_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass3_0>.NativeClassPtr, 100667180);
				DOTweenModuleUI.__c__DisplayClass3_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass3_0>.NativeClassPtr, 100667181);
				DOTweenModuleUI.__c__DisplayClass3_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass3_0>.NativeClassPtr, 100667182);
			}

			// Token: 0x060022EB RID: 8939 RVA: 0x00096704 File Offset: 0x00094904
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022EC RID: 8940 RVA: 0x00096740 File Offset: 0x00094940
			[CallerCount(0)]
			public unsafe Color _DOColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass3_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060022ED RID: 8941 RVA: 0x0009677C File Offset: 0x0009497C
			[CallerCount(0)]
			public unsafe void _DOColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass3_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022EE RID: 8942 RVA: 0x0000D165 File Offset: 0x0000B365
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000719 RID: 1817
			// (get) Token: 0x060022EF RID: 8943 RVA: 0x000967BC File Offset: 0x000949BC
			// (set) Token: 0x060022F0 RID: 8944 RVA: 0x0000D16E File Offset: 0x0000B36E
			public unsafe Image target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass3_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass3_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021CA RID: 8650
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021CB RID: 8651
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021CC RID: 8652
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0;

			// Token: 0x040021CD RID: 8653
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x0200028C RID: 652
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060022F1 RID: 8945 RVA: 0x000967EC File Offset: 0x000949EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass4_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass4_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass4_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass4_0>.NativeClassPtr, 100667183);
				DOTweenModuleUI.__c__DisplayClass4_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass4_0>.NativeClassPtr, 100667184);
				DOTweenModuleUI.__c__DisplayClass4_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass4_0>.NativeClassPtr, 100667185);
			}

			// Token: 0x060022F2 RID: 8946 RVA: 0x00096868 File Offset: 0x00094A68
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022F3 RID: 8947 RVA: 0x000968A4 File Offset: 0x00094AA4
			[CallerCount(0)]
			public unsafe Color _DOFade_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass4_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060022F4 RID: 8948 RVA: 0x000968E0 File Offset: 0x00094AE0
			[CallerCount(0)]
			public unsafe void _DOFade_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass4_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022F5 RID: 8949 RVA: 0x0000D18D File Offset: 0x0000B38D
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700071A RID: 1818
			// (get) Token: 0x060022F6 RID: 8950 RVA: 0x00096920 File Offset: 0x00094B20
			// (set) Token: 0x060022F7 RID: 8951 RVA: 0x0000D196 File Offset: 0x0000B396
			public unsafe Image target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass4_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass4_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021CE RID: 8654
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021CF RID: 8655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021D0 RID: 8656
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0;

			// Token: 0x040021D1 RID: 8657
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0;
		}

		// Token: 0x0200028D RID: 653
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060022F8 RID: 8952 RVA: 0x00096950 File Offset: 0x00094B50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass5_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass5_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass5_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass5_0>.NativeClassPtr, 100667186);
				DOTweenModuleUI.__c__DisplayClass5_0.NativeMethodInfoPtr__DOFillAmount_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass5_0>.NativeClassPtr, 100667187);
				DOTweenModuleUI.__c__DisplayClass5_0.NativeMethodInfoPtr__DOFillAmount_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass5_0>.NativeClassPtr, 100667188);
			}

			// Token: 0x060022F9 RID: 8953 RVA: 0x000969CC File Offset: 0x00094BCC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022FA RID: 8954 RVA: 0x00096A08 File Offset: 0x00094C08
			[CallerCount(0)]
			public unsafe float _DOFillAmount_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass5_0.NativeMethodInfoPtr__DOFillAmount_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060022FB RID: 8955 RVA: 0x00096A44 File Offset: 0x00094C44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21538, XrefRangeEnd = 21540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOFillAmount_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass5_0.NativeMethodInfoPtr__DOFillAmount_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022FC RID: 8956 RVA: 0x0000D1B5 File Offset: 0x0000B3B5
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700071B RID: 1819
			// (get) Token: 0x060022FD RID: 8957 RVA: 0x00096A84 File Offset: 0x00094C84
			// (set) Token: 0x060022FE RID: 8958 RVA: 0x0000D1BE File Offset: 0x0000B3BE
			public unsafe Image target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass5_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass5_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021D2 RID: 8658
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021D3 RID: 8659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021D4 RID: 8660
			private static readonly IntPtr NativeMethodInfoPtr__DOFillAmount_b__0_Internal_Single_0;

			// Token: 0x040021D5 RID: 8661
			private static readonly IntPtr NativeMethodInfoPtr__DOFillAmount_b__1_Internal_Void_Single_0;
		}

		// Token: 0x0200028E RID: 654
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060022FF RID: 8959 RVA: 0x00096AB4 File Offset: 0x00094CB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass7_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass7_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass7_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass7_0>.NativeClassPtr, 100667189);
				DOTweenModuleUI.__c__DisplayClass7_0.NativeMethodInfoPtr__DOFlexibleSize_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass7_0>.NativeClassPtr, 100667190);
				DOTweenModuleUI.__c__DisplayClass7_0.NativeMethodInfoPtr__DOFlexibleSize_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass7_0>.NativeClassPtr, 100667191);
			}

			// Token: 0x06002300 RID: 8960 RVA: 0x00096B30 File Offset: 0x00094D30
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002301 RID: 8961 RVA: 0x00096B6C File Offset: 0x00094D6C
			[CallerCount(0)]
			public unsafe Vector2 _DOFlexibleSize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass7_0.NativeMethodInfoPtr__DOFlexibleSize_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002302 RID: 8962 RVA: 0x00096BA8 File Offset: 0x00094DA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21540, XrefRangeEnd = 21541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOFlexibleSize_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass7_0.NativeMethodInfoPtr__DOFlexibleSize_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002303 RID: 8963 RVA: 0x0000D1DD File Offset: 0x0000B3DD
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700071C RID: 1820
			// (get) Token: 0x06002304 RID: 8964 RVA: 0x00096BE8 File Offset: 0x00094DE8
			// (set) Token: 0x06002305 RID: 8965 RVA: 0x0000D1E6 File Offset: 0x0000B3E6
			public unsafe LayoutElement target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass7_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass7_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021D6 RID: 8662
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021D7 RID: 8663
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021D8 RID: 8664
			private static readonly IntPtr NativeMethodInfoPtr__DOFlexibleSize_b__0_Internal_Vector2_0;

			// Token: 0x040021D9 RID: 8665
			private static readonly IntPtr NativeMethodInfoPtr__DOFlexibleSize_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x0200028F RID: 655
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002306 RID: 8966 RVA: 0x00096C18 File Offset: 0x00094E18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass8_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass8_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass8_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass8_0>.NativeClassPtr, 100667192);
				DOTweenModuleUI.__c__DisplayClass8_0.NativeMethodInfoPtr__DOMinSize_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass8_0>.NativeClassPtr, 100667193);
				DOTweenModuleUI.__c__DisplayClass8_0.NativeMethodInfoPtr__DOMinSize_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass8_0>.NativeClassPtr, 100667194);
			}

			// Token: 0x06002307 RID: 8967 RVA: 0x00096C94 File Offset: 0x00094E94
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002308 RID: 8968 RVA: 0x00096CD0 File Offset: 0x00094ED0
			[CallerCount(0)]
			public unsafe Vector2 _DOMinSize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass8_0.NativeMethodInfoPtr__DOMinSize_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002309 RID: 8969 RVA: 0x00096D0C File Offset: 0x00094F0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21541, XrefRangeEnd = 21542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOMinSize_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass8_0.NativeMethodInfoPtr__DOMinSize_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600230A RID: 8970 RVA: 0x0000D205 File Offset: 0x0000B405
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700071D RID: 1821
			// (get) Token: 0x0600230B RID: 8971 RVA: 0x00096D4C File Offset: 0x00094F4C
			// (set) Token: 0x0600230C RID: 8972 RVA: 0x0000D20E File Offset: 0x0000B40E
			public unsafe LayoutElement target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass8_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass8_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021DA RID: 8666
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021DB RID: 8667
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021DC RID: 8668
			private static readonly IntPtr NativeMethodInfoPtr__DOMinSize_b__0_Internal_Vector2_0;

			// Token: 0x040021DD RID: 8669
			private static readonly IntPtr NativeMethodInfoPtr__DOMinSize_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x02000290 RID: 656
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600230D RID: 8973 RVA: 0x00096D7C File Offset: 0x00094F7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass9_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass9_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass9_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass9_0>.NativeClassPtr, 100667195);
				DOTweenModuleUI.__c__DisplayClass9_0.NativeMethodInfoPtr__DOPreferredSize_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass9_0>.NativeClassPtr, 100667196);
				DOTweenModuleUI.__c__DisplayClass9_0.NativeMethodInfoPtr__DOPreferredSize_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass9_0>.NativeClassPtr, 100667197);
			}

			// Token: 0x0600230E RID: 8974 RVA: 0x00096DF8 File Offset: 0x00094FF8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600230F RID: 8975 RVA: 0x00096E34 File Offset: 0x00095034
			[CallerCount(0)]
			public unsafe Vector2 _DOPreferredSize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass9_0.NativeMethodInfoPtr__DOPreferredSize_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002310 RID: 8976 RVA: 0x00096E70 File Offset: 0x00095070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21542, XrefRangeEnd = 21543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPreferredSize_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass9_0.NativeMethodInfoPtr__DOPreferredSize_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002311 RID: 8977 RVA: 0x0000D22D File Offset: 0x0000B42D
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700071E RID: 1822
			// (get) Token: 0x06002312 RID: 8978 RVA: 0x00096EB0 File Offset: 0x000950B0
			// (set) Token: 0x06002313 RID: 8979 RVA: 0x0000D236 File Offset: 0x0000B436
			public unsafe LayoutElement target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass9_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass9_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021DE RID: 8670
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021DF RID: 8671
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021E0 RID: 8672
			private static readonly IntPtr NativeMethodInfoPtr__DOPreferredSize_b__0_Internal_Vector2_0;

			// Token: 0x040021E1 RID: 8673
			private static readonly IntPtr NativeMethodInfoPtr__DOPreferredSize_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x02000291 RID: 657
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002314 RID: 8980 RVA: 0x00096EE0 File Offset: 0x000950E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass10_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass10_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass10_0>.NativeClassPtr, 100667198);
				DOTweenModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass10_0>.NativeClassPtr, 100667199);
				DOTweenModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass10_0>.NativeClassPtr, 100667200);
			}

			// Token: 0x06002315 RID: 8981 RVA: 0x00096F5C File Offset: 0x0009515C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002316 RID: 8982 RVA: 0x00096F98 File Offset: 0x00095198
			[CallerCount(0)]
			public unsafe Color _DOColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002317 RID: 8983 RVA: 0x00096FD4 File Offset: 0x000951D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21543, XrefRangeEnd = 21544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass10_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002318 RID: 8984 RVA: 0x0000D255 File Offset: 0x0000B455
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700071F RID: 1823
			// (get) Token: 0x06002319 RID: 8985 RVA: 0x00097014 File Offset: 0x00095214
			// (set) Token: 0x0600231A RID: 8986 RVA: 0x0000D25E File Offset: 0x0000B45E
			public unsafe Outline target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outline>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass10_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021E2 RID: 8674
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021E3 RID: 8675
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021E4 RID: 8676
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0;

			// Token: 0x040021E5 RID: 8677
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x02000292 RID: 658
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600231B RID: 8987 RVA: 0x00097044 File Offset: 0x00095244
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass11_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass11_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass11_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass11_0>.NativeClassPtr, 100667201);
				DOTweenModuleUI.__c__DisplayClass11_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass11_0>.NativeClassPtr, 100667202);
				DOTweenModuleUI.__c__DisplayClass11_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass11_0>.NativeClassPtr, 100667203);
			}

			// Token: 0x0600231C RID: 8988 RVA: 0x000970C0 File Offset: 0x000952C0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600231D RID: 8989 RVA: 0x000970FC File Offset: 0x000952FC
			[CallerCount(0)]
			public unsafe Color _DOFade_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass11_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600231E RID: 8990 RVA: 0x00097138 File Offset: 0x00095338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOFade_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass11_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600231F RID: 8991 RVA: 0x0000D27D File Offset: 0x0000B47D
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000720 RID: 1824
			// (get) Token: 0x06002320 RID: 8992 RVA: 0x00097178 File Offset: 0x00095378
			// (set) Token: 0x06002321 RID: 8993 RVA: 0x0000D286 File Offset: 0x0000B486
			public unsafe Outline target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass11_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outline>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass11_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021E6 RID: 8678
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021E7 RID: 8679
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021E8 RID: 8680
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0;

			// Token: 0x040021E9 RID: 8681
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0;
		}

		// Token: 0x02000293 RID: 659
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002322 RID: 8994 RVA: 0x000971A8 File Offset: 0x000953A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass12_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass12_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass12_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass12_0>.NativeClassPtr, 100667204);
				DOTweenModuleUI.__c__DisplayClass12_0.NativeMethodInfoPtr__DOScale_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass12_0>.NativeClassPtr, 100667205);
				DOTweenModuleUI.__c__DisplayClass12_0.NativeMethodInfoPtr__DOScale_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass12_0>.NativeClassPtr, 100667206);
			}

			// Token: 0x06002323 RID: 8995 RVA: 0x00097224 File Offset: 0x00095424
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002324 RID: 8996 RVA: 0x00097260 File Offset: 0x00095460
			[CallerCount(0)]
			public unsafe Vector2 _DOScale_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass12_0.NativeMethodInfoPtr__DOScale_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002325 RID: 8997 RVA: 0x0009729C File Offset: 0x0009549C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21544, XrefRangeEnd = 21546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOScale_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass12_0.NativeMethodInfoPtr__DOScale_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002326 RID: 8998 RVA: 0x0000D2A5 File Offset: 0x0000B4A5
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000721 RID: 1825
			// (get) Token: 0x06002327 RID: 8999 RVA: 0x000972DC File Offset: 0x000954DC
			// (set) Token: 0x06002328 RID: 9000 RVA: 0x0000D2AE File Offset: 0x0000B4AE
			public unsafe Outline target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass12_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outline>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass12_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021EA RID: 8682
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021EB RID: 8683
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021EC RID: 8684
			private static readonly IntPtr NativeMethodInfoPtr__DOScale_b__0_Internal_Vector2_0;

			// Token: 0x040021ED RID: 8685
			private static readonly IntPtr NativeMethodInfoPtr__DOScale_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x02000294 RID: 660
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002329 RID: 9001 RVA: 0x0009730C File Offset: 0x0009550C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass13_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass13_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass13_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass13_0>.NativeClassPtr, 100667207);
				DOTweenModuleUI.__c__DisplayClass13_0.NativeMethodInfoPtr__DOAnchorPos_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass13_0>.NativeClassPtr, 100667208);
				DOTweenModuleUI.__c__DisplayClass13_0.NativeMethodInfoPtr__DOAnchorPos_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass13_0>.NativeClassPtr, 100667209);
			}

			// Token: 0x0600232A RID: 9002 RVA: 0x00097388 File Offset: 0x00095588
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600232B RID: 9003 RVA: 0x000973C4 File Offset: 0x000955C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21546, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOAnchorPos_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass13_0.NativeMethodInfoPtr__DOAnchorPos_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600232C RID: 9004 RVA: 0x00097400 File Offset: 0x00095600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21548, XrefRangeEnd = 21550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOAnchorPos_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass13_0.NativeMethodInfoPtr__DOAnchorPos_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600232D RID: 9005 RVA: 0x0000D2CD File Offset: 0x0000B4CD
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000722 RID: 1826
			// (get) Token: 0x0600232E RID: 9006 RVA: 0x00097440 File Offset: 0x00095640
			// (set) Token: 0x0600232F RID: 9007 RVA: 0x0000D2D6 File Offset: 0x0000B4D6
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass13_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass13_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021EE RID: 8686
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021EF RID: 8687
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021F0 RID: 8688
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorPos_b__0_Internal_Vector2_0;

			// Token: 0x040021F1 RID: 8689
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorPos_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x02000295 RID: 661
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002330 RID: 9008 RVA: 0x00097470 File Offset: 0x00095670
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass14_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass14_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass14_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass14_0>.NativeClassPtr, 100667210);
				DOTweenModuleUI.__c__DisplayClass14_0.NativeMethodInfoPtr__DOAnchorPosX_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass14_0>.NativeClassPtr, 100667211);
				DOTweenModuleUI.__c__DisplayClass14_0.NativeMethodInfoPtr__DOAnchorPosX_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass14_0>.NativeClassPtr, 100667212);
			}

			// Token: 0x06002331 RID: 9009 RVA: 0x000974EC File Offset: 0x000956EC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002332 RID: 9010 RVA: 0x00097528 File Offset: 0x00095728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOAnchorPosX_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass14_0.NativeMethodInfoPtr__DOAnchorPosX_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002333 RID: 9011 RVA: 0x00097564 File Offset: 0x00095764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOAnchorPosX_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass14_0.NativeMethodInfoPtr__DOAnchorPosX_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002334 RID: 9012 RVA: 0x0000D2F5 File Offset: 0x0000B4F5
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000723 RID: 1827
			// (get) Token: 0x06002335 RID: 9013 RVA: 0x000975A4 File Offset: 0x000957A4
			// (set) Token: 0x06002336 RID: 9014 RVA: 0x0000D2FE File Offset: 0x0000B4FE
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass14_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass14_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021F2 RID: 8690
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021F3 RID: 8691
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021F4 RID: 8692
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorPosX_b__0_Internal_Vector2_0;

			// Token: 0x040021F5 RID: 8693
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorPosX_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x02000296 RID: 662
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002337 RID: 9015 RVA: 0x000975D4 File Offset: 0x000957D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass15_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass15_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass15_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass15_0>.NativeClassPtr, 100667213);
				DOTweenModuleUI.__c__DisplayClass15_0.NativeMethodInfoPtr__DOAnchorPosY_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass15_0>.NativeClassPtr, 100667214);
				DOTweenModuleUI.__c__DisplayClass15_0.NativeMethodInfoPtr__DOAnchorPosY_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass15_0>.NativeClassPtr, 100667215);
			}

			// Token: 0x06002338 RID: 9016 RVA: 0x00097650 File Offset: 0x00095850
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002339 RID: 9017 RVA: 0x0009768C File Offset: 0x0009588C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOAnchorPosY_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass15_0.NativeMethodInfoPtr__DOAnchorPosY_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600233A RID: 9018 RVA: 0x000976C8 File Offset: 0x000958C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOAnchorPosY_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass15_0.NativeMethodInfoPtr__DOAnchorPosY_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600233B RID: 9019 RVA: 0x0000D31D File Offset: 0x0000B51D
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x0600233C RID: 9020 RVA: 0x00097708 File Offset: 0x00095908
			// (set) Token: 0x0600233D RID: 9021 RVA: 0x0000D326 File Offset: 0x0000B526
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass15_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass15_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021F6 RID: 8694
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021F7 RID: 8695
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021F8 RID: 8696
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorPosY_b__0_Internal_Vector2_0;

			// Token: 0x040021F9 RID: 8697
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorPosY_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x02000297 RID: 663
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600233E RID: 9022 RVA: 0x00097738 File Offset: 0x00095938
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass16_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass16_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass16_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass16_0>.NativeClassPtr, 100667216);
				DOTweenModuleUI.__c__DisplayClass16_0.NativeMethodInfoPtr__DOAnchorPos3D_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass16_0>.NativeClassPtr, 100667217);
				DOTweenModuleUI.__c__DisplayClass16_0.NativeMethodInfoPtr__DOAnchorPos3D_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass16_0>.NativeClassPtr, 100667218);
			}

			// Token: 0x0600233F RID: 9023 RVA: 0x000977B4 File Offset: 0x000959B4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002340 RID: 9024 RVA: 0x000977F0 File Offset: 0x000959F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21550, XrefRangeEnd = 21551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOAnchorPos3D_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass16_0.NativeMethodInfoPtr__DOAnchorPos3D_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002341 RID: 9025 RVA: 0x0009782C File Offset: 0x00095A2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21551, XrefRangeEnd = 21552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOAnchorPos3D_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass16_0.NativeMethodInfoPtr__DOAnchorPos3D_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002342 RID: 9026 RVA: 0x0000D345 File Offset: 0x0000B545
			public __c__DisplayClass16_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000725 RID: 1829
			// (get) Token: 0x06002343 RID: 9027 RVA: 0x0009786C File Offset: 0x00095A6C
			// (set) Token: 0x06002344 RID: 9028 RVA: 0x0000D34E File Offset: 0x0000B54E
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass16_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass16_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021FA RID: 8698
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021FB RID: 8699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021FC RID: 8700
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorPos3D_b__0_Internal_Vector3_0;

			// Token: 0x040021FD RID: 8701
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorPos3D_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000298 RID: 664
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002345 RID: 9029 RVA: 0x0009789C File Offset: 0x00095A9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass17_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass17_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass17_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass17_0>.NativeClassPtr, 100667219);
				DOTweenModuleUI.__c__DisplayClass17_0.NativeMethodInfoPtr__DOAnchorPos3DX_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass17_0>.NativeClassPtr, 100667220);
				DOTweenModuleUI.__c__DisplayClass17_0.NativeMethodInfoPtr__DOAnchorPos3DX_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass17_0>.NativeClassPtr, 100667221);
			}

			// Token: 0x06002346 RID: 9030 RVA: 0x00097918 File Offset: 0x00095B18
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002347 RID: 9031 RVA: 0x00097954 File Offset: 0x00095B54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOAnchorPos3DX_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass17_0.NativeMethodInfoPtr__DOAnchorPos3DX_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002348 RID: 9032 RVA: 0x00097990 File Offset: 0x00095B90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOAnchorPos3DX_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass17_0.NativeMethodInfoPtr__DOAnchorPos3DX_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002349 RID: 9033 RVA: 0x0000D36D File Offset: 0x0000B56D
			public __c__DisplayClass17_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x0600234A RID: 9034 RVA: 0x000979D0 File Offset: 0x00095BD0
			// (set) Token: 0x0600234B RID: 9035 RVA: 0x0000D376 File Offset: 0x0000B576
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass17_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass17_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021FE RID: 8702
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040021FF RID: 8703
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002200 RID: 8704
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorPos3DX_b__0_Internal_Vector3_0;

			// Token: 0x04002201 RID: 8705
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorPos3DX_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x02000299 RID: 665
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600234C RID: 9036 RVA: 0x00097A00 File Offset: 0x00095C00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass18_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass18_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass18_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass18_0>.NativeClassPtr, 100667222);
				DOTweenModuleUI.__c__DisplayClass18_0.NativeMethodInfoPtr__DOAnchorPos3DY_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass18_0>.NativeClassPtr, 100667223);
				DOTweenModuleUI.__c__DisplayClass18_0.NativeMethodInfoPtr__DOAnchorPos3DY_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass18_0>.NativeClassPtr, 100667224);
			}

			// Token: 0x0600234D RID: 9037 RVA: 0x00097A7C File Offset: 0x00095C7C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600234E RID: 9038 RVA: 0x00097AB8 File Offset: 0x00095CB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOAnchorPos3DY_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass18_0.NativeMethodInfoPtr__DOAnchorPos3DY_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600234F RID: 9039 RVA: 0x00097AF4 File Offset: 0x00095CF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOAnchorPos3DY_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass18_0.NativeMethodInfoPtr__DOAnchorPos3DY_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002350 RID: 9040 RVA: 0x0000D395 File Offset: 0x0000B595
			public __c__DisplayClass18_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000727 RID: 1831
			// (get) Token: 0x06002351 RID: 9041 RVA: 0x00097B34 File Offset: 0x00095D34
			// (set) Token: 0x06002352 RID: 9042 RVA: 0x0000D39E File Offset: 0x0000B59E
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass18_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass18_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002202 RID: 8706
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002203 RID: 8707
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002204 RID: 8708
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorPos3DY_b__0_Internal_Vector3_0;

			// Token: 0x04002205 RID: 8709
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorPos3DY_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200029A RID: 666
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002353 RID: 9043 RVA: 0x00097B64 File Offset: 0x00095D64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass19_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass19_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass19_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass19_0>.NativeClassPtr, 100667225);
				DOTweenModuleUI.__c__DisplayClass19_0.NativeMethodInfoPtr__DOAnchorPos3DZ_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass19_0>.NativeClassPtr, 100667226);
				DOTweenModuleUI.__c__DisplayClass19_0.NativeMethodInfoPtr__DOAnchorPos3DZ_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass19_0>.NativeClassPtr, 100667227);
			}

			// Token: 0x06002354 RID: 9044 RVA: 0x00097BE0 File Offset: 0x00095DE0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002355 RID: 9045 RVA: 0x00097C1C File Offset: 0x00095E1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOAnchorPos3DZ_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass19_0.NativeMethodInfoPtr__DOAnchorPos3DZ_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002356 RID: 9046 RVA: 0x00097C58 File Offset: 0x00095E58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOAnchorPos3DZ_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass19_0.NativeMethodInfoPtr__DOAnchorPos3DZ_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002357 RID: 9047 RVA: 0x0000D3BD File Offset: 0x0000B5BD
			public __c__DisplayClass19_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000728 RID: 1832
			// (get) Token: 0x06002358 RID: 9048 RVA: 0x00097C98 File Offset: 0x00095E98
			// (set) Token: 0x06002359 RID: 9049 RVA: 0x0000D3C6 File Offset: 0x0000B5C6
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass19_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass19_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002206 RID: 8710
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002207 RID: 8711
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002208 RID: 8712
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorPos3DZ_b__0_Internal_Vector3_0;

			// Token: 0x04002209 RID: 8713
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorPos3DZ_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x0200029B RID: 667
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600235A RID: 9050 RVA: 0x00097CC8 File Offset: 0x00095EC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass20_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass20_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass20_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass20_0>.NativeClassPtr, 100667228);
				DOTweenModuleUI.__c__DisplayClass20_0.NativeMethodInfoPtr__DOAnchorMax_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass20_0>.NativeClassPtr, 100667229);
				DOTweenModuleUI.__c__DisplayClass20_0.NativeMethodInfoPtr__DOAnchorMax_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass20_0>.NativeClassPtr, 100667230);
			}

			// Token: 0x0600235B RID: 9051 RVA: 0x00097D44 File Offset: 0x00095F44
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600235C RID: 9052 RVA: 0x00097D80 File Offset: 0x00095F80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21552, XrefRangeEnd = 21554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOAnchorMax_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass20_0.NativeMethodInfoPtr__DOAnchorMax_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600235D RID: 9053 RVA: 0x00097DBC File Offset: 0x00095FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21554, XrefRangeEnd = 21556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOAnchorMax_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass20_0.NativeMethodInfoPtr__DOAnchorMax_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600235E RID: 9054 RVA: 0x0000D3E5 File Offset: 0x0000B5E5
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000729 RID: 1833
			// (get) Token: 0x0600235F RID: 9055 RVA: 0x00097DFC File Offset: 0x00095FFC
			// (set) Token: 0x06002360 RID: 9056 RVA: 0x0000D3EE File Offset: 0x0000B5EE
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass20_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass20_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400220A RID: 8714
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400220B RID: 8715
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400220C RID: 8716
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorMax_b__0_Internal_Vector2_0;

			// Token: 0x0400220D RID: 8717
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorMax_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x0200029C RID: 668
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002361 RID: 9057 RVA: 0x00097E2C File Offset: 0x0009602C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass21_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass21_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass21_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass21_0>.NativeClassPtr, 100667231);
				DOTweenModuleUI.__c__DisplayClass21_0.NativeMethodInfoPtr__DOAnchorMin_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass21_0>.NativeClassPtr, 100667232);
				DOTweenModuleUI.__c__DisplayClass21_0.NativeMethodInfoPtr__DOAnchorMin_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass21_0>.NativeClassPtr, 100667233);
			}

			// Token: 0x06002362 RID: 9058 RVA: 0x00097EA8 File Offset: 0x000960A8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002363 RID: 9059 RVA: 0x00097EE4 File Offset: 0x000960E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21556, XrefRangeEnd = 21558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOAnchorMin_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass21_0.NativeMethodInfoPtr__DOAnchorMin_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002364 RID: 9060 RVA: 0x00097F20 File Offset: 0x00096120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21558, XrefRangeEnd = 21560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOAnchorMin_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass21_0.NativeMethodInfoPtr__DOAnchorMin_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002365 RID: 9061 RVA: 0x0000D40D File Offset: 0x0000B60D
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700072A RID: 1834
			// (get) Token: 0x06002366 RID: 9062 RVA: 0x00097F60 File Offset: 0x00096160
			// (set) Token: 0x06002367 RID: 9063 RVA: 0x0000D416 File Offset: 0x0000B616
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass21_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass21_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400220E RID: 8718
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400220F RID: 8719
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002210 RID: 8720
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorMin_b__0_Internal_Vector2_0;

			// Token: 0x04002211 RID: 8721
			private static readonly IntPtr NativeMethodInfoPtr__DOAnchorMin_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x0200029D RID: 669
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002368 RID: 9064 RVA: 0x00097F90 File Offset: 0x00096190
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass22_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass22_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass22_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass22_0>.NativeClassPtr, 100667234);
				DOTweenModuleUI.__c__DisplayClass22_0.NativeMethodInfoPtr__DOPivot_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass22_0>.NativeClassPtr, 100667235);
				DOTweenModuleUI.__c__DisplayClass22_0.NativeMethodInfoPtr__DOPivot_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass22_0>.NativeClassPtr, 100667236);
			}

			// Token: 0x06002369 RID: 9065 RVA: 0x0009800C File Offset: 0x0009620C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600236A RID: 9066 RVA: 0x00098048 File Offset: 0x00096248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21560, XrefRangeEnd = 21562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOPivot_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass22_0.NativeMethodInfoPtr__DOPivot_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600236B RID: 9067 RVA: 0x00098084 File Offset: 0x00096284
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21562, XrefRangeEnd = 21564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPivot_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass22_0.NativeMethodInfoPtr__DOPivot_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600236C RID: 9068 RVA: 0x0000D435 File Offset: 0x0000B635
			public __c__DisplayClass22_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700072B RID: 1835
			// (get) Token: 0x0600236D RID: 9069 RVA: 0x000980C4 File Offset: 0x000962C4
			// (set) Token: 0x0600236E RID: 9070 RVA: 0x0000D43E File Offset: 0x0000B63E
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass22_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass22_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002212 RID: 8722
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002213 RID: 8723
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002214 RID: 8724
			private static readonly IntPtr NativeMethodInfoPtr__DOPivot_b__0_Internal_Vector2_0;

			// Token: 0x04002215 RID: 8725
			private static readonly IntPtr NativeMethodInfoPtr__DOPivot_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x0200029E RID: 670
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600236F RID: 9071 RVA: 0x000980F4 File Offset: 0x000962F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass23_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass23_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass23_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass23_0>.NativeClassPtr, 100667237);
				DOTweenModuleUI.__c__DisplayClass23_0.NativeMethodInfoPtr__DOPivotX_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass23_0>.NativeClassPtr, 100667238);
				DOTweenModuleUI.__c__DisplayClass23_0.NativeMethodInfoPtr__DOPivotX_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass23_0>.NativeClassPtr, 100667239);
			}

			// Token: 0x06002370 RID: 9072 RVA: 0x00098170 File Offset: 0x00096370
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002371 RID: 9073 RVA: 0x000981AC File Offset: 0x000963AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOPivotX_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass23_0.NativeMethodInfoPtr__DOPivotX_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002372 RID: 9074 RVA: 0x000981E8 File Offset: 0x000963E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPivotX_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass23_0.NativeMethodInfoPtr__DOPivotX_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002373 RID: 9075 RVA: 0x0000D45D File Offset: 0x0000B65D
			public __c__DisplayClass23_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700072C RID: 1836
			// (get) Token: 0x06002374 RID: 9076 RVA: 0x00098228 File Offset: 0x00096428
			// (set) Token: 0x06002375 RID: 9077 RVA: 0x0000D466 File Offset: 0x0000B666
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass23_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass23_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002216 RID: 8726
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002217 RID: 8727
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002218 RID: 8728
			private static readonly IntPtr NativeMethodInfoPtr__DOPivotX_b__0_Internal_Vector2_0;

			// Token: 0x04002219 RID: 8729
			private static readonly IntPtr NativeMethodInfoPtr__DOPivotX_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x0200029F RID: 671
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002376 RID: 9078 RVA: 0x00098258 File Offset: 0x00096458
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass24_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass24_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass24_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass24_0>.NativeClassPtr, 100667240);
				DOTweenModuleUI.__c__DisplayClass24_0.NativeMethodInfoPtr__DOPivotY_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass24_0>.NativeClassPtr, 100667241);
				DOTweenModuleUI.__c__DisplayClass24_0.NativeMethodInfoPtr__DOPivotY_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass24_0>.NativeClassPtr, 100667242);
			}

			// Token: 0x06002377 RID: 9079 RVA: 0x000982D4 File Offset: 0x000964D4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002378 RID: 9080 RVA: 0x00098310 File Offset: 0x00096510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOPivotY_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass24_0.NativeMethodInfoPtr__DOPivotY_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002379 RID: 9081 RVA: 0x0009834C File Offset: 0x0009654C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPivotY_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass24_0.NativeMethodInfoPtr__DOPivotY_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600237A RID: 9082 RVA: 0x0000D485 File Offset: 0x0000B685
			public __c__DisplayClass24_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700072D RID: 1837
			// (get) Token: 0x0600237B RID: 9083 RVA: 0x0009838C File Offset: 0x0009658C
			// (set) Token: 0x0600237C RID: 9084 RVA: 0x0000D48E File Offset: 0x0000B68E
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass24_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass24_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400221A RID: 8730
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400221B RID: 8731
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400221C RID: 8732
			private static readonly IntPtr NativeMethodInfoPtr__DOPivotY_b__0_Internal_Vector2_0;

			// Token: 0x0400221D RID: 8733
			private static readonly IntPtr NativeMethodInfoPtr__DOPivotY_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x020002A0 RID: 672
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600237D RID: 9085 RVA: 0x000983BC File Offset: 0x000965BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass25_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass25_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass25_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass25_0>.NativeClassPtr, 100667243);
				DOTweenModuleUI.__c__DisplayClass25_0.NativeMethodInfoPtr__DOSizeDelta_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass25_0>.NativeClassPtr, 100667244);
				DOTweenModuleUI.__c__DisplayClass25_0.NativeMethodInfoPtr__DOSizeDelta_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass25_0>.NativeClassPtr, 100667245);
			}

			// Token: 0x0600237E RID: 9086 RVA: 0x00098438 File Offset: 0x00096638
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600237F RID: 9087 RVA: 0x00098474 File Offset: 0x00096674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21564, XrefRangeEnd = 21566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOSizeDelta_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass25_0.NativeMethodInfoPtr__DOSizeDelta_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002380 RID: 9088 RVA: 0x000984B0 File Offset: 0x000966B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21566, XrefRangeEnd = 21568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOSizeDelta_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass25_0.NativeMethodInfoPtr__DOSizeDelta_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002381 RID: 9089 RVA: 0x0000D4AD File Offset: 0x0000B6AD
			public __c__DisplayClass25_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700072E RID: 1838
			// (get) Token: 0x06002382 RID: 9090 RVA: 0x000984F0 File Offset: 0x000966F0
			// (set) Token: 0x06002383 RID: 9091 RVA: 0x0000D4B6 File Offset: 0x0000B6B6
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass25_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass25_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400221E RID: 8734
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400221F RID: 8735
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002220 RID: 8736
			private static readonly IntPtr NativeMethodInfoPtr__DOSizeDelta_b__0_Internal_Vector2_0;

			// Token: 0x04002221 RID: 8737
			private static readonly IntPtr NativeMethodInfoPtr__DOSizeDelta_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x020002A1 RID: 673
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002384 RID: 9092 RVA: 0x00098520 File Offset: 0x00096720
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass26_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass26_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass26_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass26_0>.NativeClassPtr, 100667246);
				DOTweenModuleUI.__c__DisplayClass26_0.NativeMethodInfoPtr__DOPunchAnchorPos_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass26_0>.NativeClassPtr, 100667247);
				DOTweenModuleUI.__c__DisplayClass26_0.NativeMethodInfoPtr__DOPunchAnchorPos_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass26_0>.NativeClassPtr, 100667248);
			}

			// Token: 0x06002385 RID: 9093 RVA: 0x0009859C File Offset: 0x0009679C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002386 RID: 9094 RVA: 0x000985D8 File Offset: 0x000967D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21568, XrefRangeEnd = 21570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOPunchAnchorPos_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass26_0.NativeMethodInfoPtr__DOPunchAnchorPos_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002387 RID: 9095 RVA: 0x00098614 File Offset: 0x00096814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21570, XrefRangeEnd = 21572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOPunchAnchorPos_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass26_0.NativeMethodInfoPtr__DOPunchAnchorPos_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002388 RID: 9096 RVA: 0x0000D4D5 File Offset: 0x0000B6D5
			public __c__DisplayClass26_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700072F RID: 1839
			// (get) Token: 0x06002389 RID: 9097 RVA: 0x00098654 File Offset: 0x00096854
			// (set) Token: 0x0600238A RID: 9098 RVA: 0x0000D4DE File Offset: 0x0000B6DE
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass26_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass26_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002222 RID: 8738
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002223 RID: 8739
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002224 RID: 8740
			private static readonly IntPtr NativeMethodInfoPtr__DOPunchAnchorPos_b__0_Internal_Vector3_0;

			// Token: 0x04002225 RID: 8741
			private static readonly IntPtr NativeMethodInfoPtr__DOPunchAnchorPos_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020002A2 RID: 674
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600238B RID: 9099 RVA: 0x00098684 File Offset: 0x00096884
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass27_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass27_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass27_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass27_0>.NativeClassPtr, 100667249);
				DOTweenModuleUI.__c__DisplayClass27_0.NativeMethodInfoPtr__DOShakeAnchorPos_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass27_0>.NativeClassPtr, 100667250);
				DOTweenModuleUI.__c__DisplayClass27_0.NativeMethodInfoPtr__DOShakeAnchorPos_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass27_0>.NativeClassPtr, 100667251);
			}

			// Token: 0x0600238C RID: 9100 RVA: 0x00098700 File Offset: 0x00096900
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600238D RID: 9101 RVA: 0x0009873C File Offset: 0x0009693C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakeAnchorPos_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass27_0.NativeMethodInfoPtr__DOShakeAnchorPos_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600238E RID: 9102 RVA: 0x00098778 File Offset: 0x00096978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakeAnchorPos_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass27_0.NativeMethodInfoPtr__DOShakeAnchorPos_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600238F RID: 9103 RVA: 0x0000D4FD File Offset: 0x0000B6FD
			public __c__DisplayClass27_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000730 RID: 1840
			// (get) Token: 0x06002390 RID: 9104 RVA: 0x000987B8 File Offset: 0x000969B8
			// (set) Token: 0x06002391 RID: 9105 RVA: 0x0000D506 File Offset: 0x0000B706
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass27_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass27_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002226 RID: 8742
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002227 RID: 8743
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002228 RID: 8744
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeAnchorPos_b__0_Internal_Vector3_0;

			// Token: 0x04002229 RID: 8745
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeAnchorPos_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020002A3 RID: 675
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002392 RID: 9106 RVA: 0x000987E8 File Offset: 0x000969E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass28_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass28_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass28_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass28_0>.NativeClassPtr, 100667252);
				DOTweenModuleUI.__c__DisplayClass28_0.NativeMethodInfoPtr__DOShakeAnchorPos_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass28_0>.NativeClassPtr, 100667253);
				DOTweenModuleUI.__c__DisplayClass28_0.NativeMethodInfoPtr__DOShakeAnchorPos_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass28_0>.NativeClassPtr, 100667254);
			}

			// Token: 0x06002393 RID: 9107 RVA: 0x00098864 File Offset: 0x00096A64
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002394 RID: 9108 RVA: 0x000988A0 File Offset: 0x00096AA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _DOShakeAnchorPos_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass28_0.NativeMethodInfoPtr__DOShakeAnchorPos_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002395 RID: 9109 RVA: 0x000988DC File Offset: 0x00096ADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOShakeAnchorPos_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass28_0.NativeMethodInfoPtr__DOShakeAnchorPos_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002396 RID: 9110 RVA: 0x0000D525 File Offset: 0x0000B725
			public __c__DisplayClass28_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000731 RID: 1841
			// (get) Token: 0x06002397 RID: 9111 RVA: 0x0009891C File Offset: 0x00096B1C
			// (set) Token: 0x06002398 RID: 9112 RVA: 0x0000D52E File Offset: 0x0000B72E
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass28_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass28_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400222A RID: 8746
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400222B RID: 8747
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400222C RID: 8748
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeAnchorPos_b__0_Internal_Vector3_0;

			// Token: 0x0400222D RID: 8749
			private static readonly IntPtr NativeMethodInfoPtr__DOShakeAnchorPos_b__1_Internal_Void_Vector3_0;
		}

		// Token: 0x020002A4 RID: 676
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002399 RID: 9113 RVA: 0x0009894C File Offset: 0x00096B4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass29_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass29_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_startPosY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass29_0>.NativeClassPtr, "startPosY");
				DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_offsetYSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass29_0>.NativeClassPtr, "offsetYSet");
				DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_offsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass29_0>.NativeClassPtr, "offsetY");
				DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass29_0>.NativeClassPtr, "s");
				DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_endValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass29_0>.NativeClassPtr, "endValue");
				DOTweenModuleUI.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass29_0>.NativeClassPtr, 100667255);
				DOTweenModuleUI.__c__DisplayClass29_0.NativeMethodInfoPtr__DOJumpAnchorPos_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass29_0>.NativeClassPtr, 100667256);
				DOTweenModuleUI.__c__DisplayClass29_0.NativeMethodInfoPtr__DOJumpAnchorPos_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass29_0>.NativeClassPtr, 100667257);
				DOTweenModuleUI.__c__DisplayClass29_0.NativeMethodInfoPtr__DOJumpAnchorPos_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass29_0>.NativeClassPtr, 100667258);
				DOTweenModuleUI.__c__DisplayClass29_0.NativeMethodInfoPtr__DOJumpAnchorPos_b__3_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass29_0>.NativeClassPtr, 100667259);
				DOTweenModuleUI.__c__DisplayClass29_0.NativeMethodInfoPtr__DOJumpAnchorPos_b__4_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass29_0>.NativeClassPtr, 100667260);
				DOTweenModuleUI.__c__DisplayClass29_0.NativeMethodInfoPtr__DOJumpAnchorPos_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass29_0>.NativeClassPtr, 100667261);
			}

			// Token: 0x0600239A RID: 9114 RVA: 0x00098A7C File Offset: 0x00096C7C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600239B RID: 9115 RVA: 0x00098AB8 File Offset: 0x00096CB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOJumpAnchorPos_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass29_0.NativeMethodInfoPtr__DOJumpAnchorPos_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600239C RID: 9116 RVA: 0x00098AF4 File Offset: 0x00096CF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJumpAnchorPos_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass29_0.NativeMethodInfoPtr__DOJumpAnchorPos_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600239D RID: 9117 RVA: 0x00098B34 File Offset: 0x00096D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21572, XrefRangeEnd = 21574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJumpAnchorPos_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass29_0.NativeMethodInfoPtr__DOJumpAnchorPos_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600239E RID: 9118 RVA: 0x00098B68 File Offset: 0x00096D68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOJumpAnchorPos_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass29_0.NativeMethodInfoPtr__DOJumpAnchorPos_b__3_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600239F RID: 9119 RVA: 0x00098BA4 File Offset: 0x00096DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJumpAnchorPos_b__4(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass29_0.NativeMethodInfoPtr__DOJumpAnchorPos_b__4_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023A0 RID: 9120 RVA: 0x00098BE4 File Offset: 0x00096DE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21574, XrefRangeEnd = 21580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOJumpAnchorPos_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass29_0.NativeMethodInfoPtr__DOJumpAnchorPos_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023A1 RID: 9121 RVA: 0x0000D54D File Offset: 0x0000B74D
			public __c__DisplayClass29_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000732 RID: 1842
			// (get) Token: 0x060023A2 RID: 9122 RVA: 0x00098C18 File Offset: 0x00096E18
			// (set) Token: 0x060023A3 RID: 9123 RVA: 0x0000D556 File Offset: 0x0000B756
			public unsafe RectTransform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000733 RID: 1843
			// (get) Token: 0x060023A4 RID: 9124 RVA: 0x00098C48 File Offset: 0x00096E48
			// (set) Token: 0x060023A5 RID: 9125 RVA: 0x0000D575 File Offset: 0x0000B775
			public unsafe float startPosY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_startPosY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_startPosY)) = value;
				}
			}

			// Token: 0x17000734 RID: 1844
			// (get) Token: 0x060023A6 RID: 9126 RVA: 0x00098C70 File Offset: 0x00096E70
			// (set) Token: 0x060023A7 RID: 9127 RVA: 0x0000D590 File Offset: 0x0000B790
			public unsafe bool offsetYSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_offsetYSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_offsetYSet)) = value;
				}
			}

			// Token: 0x17000735 RID: 1845
			// (get) Token: 0x060023A8 RID: 9128 RVA: 0x00098C98 File Offset: 0x00096E98
			// (set) Token: 0x060023A9 RID: 9129 RVA: 0x0000D5AB File Offset: 0x0000B7AB
			public unsafe float offsetY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_offsetY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_offsetY)) = value;
				}
			}

			// Token: 0x17000736 RID: 1846
			// (get) Token: 0x060023AA RID: 9130 RVA: 0x00098CC0 File Offset: 0x00096EC0
			// (set) Token: 0x060023AB RID: 9131 RVA: 0x0000D5C6 File Offset: 0x0000B7C6
			public unsafe Sequence s
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_s);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_s), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000737 RID: 1847
			// (get) Token: 0x060023AC RID: 9132 RVA: 0x00098CF0 File Offset: 0x00096EF0
			// (set) Token: 0x060023AD RID: 9133 RVA: 0x0000D5E5 File Offset: 0x0000B7E5
			public unsafe Vector2 endValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_endValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass29_0.NativeFieldInfoPtr_endValue)) = value;
				}
			}

			// Token: 0x0400222E RID: 8750
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400222F RID: 8751
			private static readonly IntPtr NativeFieldInfoPtr_startPosY;

			// Token: 0x04002230 RID: 8752
			private static readonly IntPtr NativeFieldInfoPtr_offsetYSet;

			// Token: 0x04002231 RID: 8753
			private static readonly IntPtr NativeFieldInfoPtr_offsetY;

			// Token: 0x04002232 RID: 8754
			private static readonly IntPtr NativeFieldInfoPtr_s;

			// Token: 0x04002233 RID: 8755
			private static readonly IntPtr NativeFieldInfoPtr_endValue;

			// Token: 0x04002234 RID: 8756
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002235 RID: 8757
			private static readonly IntPtr NativeMethodInfoPtr__DOJumpAnchorPos_b__0_Internal_Vector2_0;

			// Token: 0x04002236 RID: 8758
			private static readonly IntPtr NativeMethodInfoPtr__DOJumpAnchorPos_b__1_Internal_Void_Vector2_0;

			// Token: 0x04002237 RID: 8759
			private static readonly IntPtr NativeMethodInfoPtr__DOJumpAnchorPos_b__2_Internal_Void_0;

			// Token: 0x04002238 RID: 8760
			private static readonly IntPtr NativeMethodInfoPtr__DOJumpAnchorPos_b__3_Internal_Vector2_0;

			// Token: 0x04002239 RID: 8761
			private static readonly IntPtr NativeMethodInfoPtr__DOJumpAnchorPos_b__4_Internal_Void_Vector2_0;

			// Token: 0x0400223A RID: 8762
			private static readonly IntPtr NativeMethodInfoPtr__DOJumpAnchorPos_b__5_Internal_Void_0;
		}

		// Token: 0x020002A5 RID: 677
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060023AE RID: 9134 RVA: 0x00098D18 File Offset: 0x00096F18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass30_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass30_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass30_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass30_0>.NativeClassPtr, 100667262);
				DOTweenModuleUI.__c__DisplayClass30_0.NativeMethodInfoPtr__DONormalizedPos_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass30_0>.NativeClassPtr, 100667263);
				DOTweenModuleUI.__c__DisplayClass30_0.NativeMethodInfoPtr__DONormalizedPos_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass30_0>.NativeClassPtr, 100667264);
			}

			// Token: 0x060023AF RID: 9135 RVA: 0x00098D94 File Offset: 0x00096F94
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023B0 RID: 9136 RVA: 0x00098DD0 File Offset: 0x00096FD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21580, XrefRangeEnd = 21582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DONormalizedPos_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass30_0.NativeMethodInfoPtr__DONormalizedPos_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023B1 RID: 9137 RVA: 0x00098E0C File Offset: 0x0009700C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21582, XrefRangeEnd = 21583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DONormalizedPos_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass30_0.NativeMethodInfoPtr__DONormalizedPos_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023B2 RID: 9138 RVA: 0x0000D600 File Offset: 0x0000B800
			public __c__DisplayClass30_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000738 RID: 1848
			// (get) Token: 0x060023B3 RID: 9139 RVA: 0x00098E4C File Offset: 0x0009704C
			// (set) Token: 0x060023B4 RID: 9140 RVA: 0x0000D609 File Offset: 0x0000B809
			public unsafe ScrollRect target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass30_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass30_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400223B RID: 8763
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400223C RID: 8764
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400223D RID: 8765
			private static readonly IntPtr NativeMethodInfoPtr__DONormalizedPos_b__0_Internal_Vector2_0;

			// Token: 0x0400223E RID: 8766
			private static readonly IntPtr NativeMethodInfoPtr__DONormalizedPos_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x020002A6 RID: 678
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060023B5 RID: 9141 RVA: 0x00098E7C File Offset: 0x0009707C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass31_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass31_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass31_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass31_0>.NativeClassPtr, 100667265);
				DOTweenModuleUI.__c__DisplayClass31_0.NativeMethodInfoPtr__DOHorizontalNormalizedPos_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass31_0>.NativeClassPtr, 100667266);
				DOTweenModuleUI.__c__DisplayClass31_0.NativeMethodInfoPtr__DOHorizontalNormalizedPos_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass31_0>.NativeClassPtr, 100667267);
			}

			// Token: 0x060023B6 RID: 9142 RVA: 0x00098EF8 File Offset: 0x000970F8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023B7 RID: 9143 RVA: 0x00098F34 File Offset: 0x00097134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21583, XrefRangeEnd = 21585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOHorizontalNormalizedPos_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass31_0.NativeMethodInfoPtr__DOHorizontalNormalizedPos_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023B8 RID: 9144 RVA: 0x00098F70 File Offset: 0x00097170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21585, XrefRangeEnd = 21586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOHorizontalNormalizedPos_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass31_0.NativeMethodInfoPtr__DOHorizontalNormalizedPos_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023B9 RID: 9145 RVA: 0x0000D628 File Offset: 0x0000B828
			public __c__DisplayClass31_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000739 RID: 1849
			// (get) Token: 0x060023BA RID: 9146 RVA: 0x00098FB0 File Offset: 0x000971B0
			// (set) Token: 0x060023BB RID: 9147 RVA: 0x0000D631 File Offset: 0x0000B831
			public unsafe ScrollRect target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass31_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass31_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400223F RID: 8767
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002240 RID: 8768
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002241 RID: 8769
			private static readonly IntPtr NativeMethodInfoPtr__DOHorizontalNormalizedPos_b__0_Internal_Single_0;

			// Token: 0x04002242 RID: 8770
			private static readonly IntPtr NativeMethodInfoPtr__DOHorizontalNormalizedPos_b__1_Internal_Void_Single_0;
		}

		// Token: 0x020002A7 RID: 679
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060023BC RID: 9148 RVA: 0x00098FE0 File Offset: 0x000971E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass32_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass32_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass32_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass32_0>.NativeClassPtr, 100667268);
				DOTweenModuleUI.__c__DisplayClass32_0.NativeMethodInfoPtr__DOVerticalNormalizedPos_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass32_0>.NativeClassPtr, 100667269);
				DOTweenModuleUI.__c__DisplayClass32_0.NativeMethodInfoPtr__DOVerticalNormalizedPos_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass32_0>.NativeClassPtr, 100667270);
			}

			// Token: 0x060023BD RID: 9149 RVA: 0x0009905C File Offset: 0x0009725C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023BE RID: 9150 RVA: 0x00099098 File Offset: 0x00097298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21586, XrefRangeEnd = 21588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOVerticalNormalizedPos_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass32_0.NativeMethodInfoPtr__DOVerticalNormalizedPos_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023BF RID: 9151 RVA: 0x000990D4 File Offset: 0x000972D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21588, XrefRangeEnd = 21589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOVerticalNormalizedPos_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass32_0.NativeMethodInfoPtr__DOVerticalNormalizedPos_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023C0 RID: 9152 RVA: 0x0000D650 File Offset: 0x0000B850
			public __c__DisplayClass32_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700073A RID: 1850
			// (get) Token: 0x060023C1 RID: 9153 RVA: 0x00099114 File Offset: 0x00097314
			// (set) Token: 0x060023C2 RID: 9154 RVA: 0x0000D659 File Offset: 0x0000B859
			public unsafe ScrollRect target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass32_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass32_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002243 RID: 8771
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002244 RID: 8772
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002245 RID: 8773
			private static readonly IntPtr NativeMethodInfoPtr__DOVerticalNormalizedPos_b__0_Internal_Single_0;

			// Token: 0x04002246 RID: 8774
			private static readonly IntPtr NativeMethodInfoPtr__DOVerticalNormalizedPos_b__1_Internal_Void_Single_0;
		}

		// Token: 0x020002A8 RID: 680
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060023C3 RID: 9155 RVA: 0x00099144 File Offset: 0x00097344
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass33_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass33_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass33_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass33_0>.NativeClassPtr, 100667271);
				DOTweenModuleUI.__c__DisplayClass33_0.NativeMethodInfoPtr__DOValue_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass33_0>.NativeClassPtr, 100667272);
				DOTweenModuleUI.__c__DisplayClass33_0.NativeMethodInfoPtr__DOValue_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass33_0>.NativeClassPtr, 100667273);
			}

			// Token: 0x060023C4 RID: 9156 RVA: 0x000991C0 File Offset: 0x000973C0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023C5 RID: 9157 RVA: 0x000991FC File Offset: 0x000973FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21589, XrefRangeEnd = 21590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DOValue_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass33_0.NativeMethodInfoPtr__DOValue_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023C6 RID: 9158 RVA: 0x00099238 File Offset: 0x00097438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21590, XrefRangeEnd = 21591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOValue_b__1(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass33_0.NativeMethodInfoPtr__DOValue_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023C7 RID: 9159 RVA: 0x0000D678 File Offset: 0x0000B878
			public __c__DisplayClass33_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700073B RID: 1851
			// (get) Token: 0x060023C8 RID: 9160 RVA: 0x00099278 File Offset: 0x00097478
			// (set) Token: 0x060023C9 RID: 9161 RVA: 0x0000D681 File Offset: 0x0000B881
			public unsafe Slider target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass33_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass33_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002247 RID: 8775
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002248 RID: 8776
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002249 RID: 8777
			private static readonly IntPtr NativeMethodInfoPtr__DOValue_b__0_Internal_Single_0;

			// Token: 0x0400224A RID: 8778
			private static readonly IntPtr NativeMethodInfoPtr__DOValue_b__1_Internal_Void_Single_0;
		}

		// Token: 0x020002A9 RID: 681
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060023CA RID: 9162 RVA: 0x000992A8 File Offset: 0x000974A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass34_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass34_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass34_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass34_0>.NativeClassPtr, 100667274);
				DOTweenModuleUI.__c__DisplayClass34_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass34_0>.NativeClassPtr, 100667275);
				DOTweenModuleUI.__c__DisplayClass34_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass34_0>.NativeClassPtr, 100667276);
			}

			// Token: 0x060023CB RID: 9163 RVA: 0x00099324 File Offset: 0x00097524
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023CC RID: 9164 RVA: 0x00099360 File Offset: 0x00097560
			[CallerCount(0)]
			public unsafe Color _DOColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass34_0.NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023CD RID: 9165 RVA: 0x0009939C File Offset: 0x0009759C
			[CallerCount(0)]
			public unsafe void _DOColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass34_0.NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023CE RID: 9166 RVA: 0x0000D6A0 File Offset: 0x0000B8A0
			public __c__DisplayClass34_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700073C RID: 1852
			// (get) Token: 0x060023CF RID: 9167 RVA: 0x000993DC File Offset: 0x000975DC
			// (set) Token: 0x060023D0 RID: 9168 RVA: 0x0000D6A9 File Offset: 0x0000B8A9
			public unsafe Text target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass34_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass34_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400224B RID: 8779
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400224C RID: 8780
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400224D RID: 8781
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__0_Internal_Color_0;

			// Token: 0x0400224E RID: 8782
			private static readonly IntPtr NativeMethodInfoPtr__DOColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x020002AA RID: 682
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060023D1 RID: 9169 RVA: 0x0009940C File Offset: 0x0009760C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass35_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass35_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass35_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass35_0>.NativeClassPtr, 100667277);
				DOTweenModuleUI.__c__DisplayClass35_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass35_0>.NativeClassPtr, 100667278);
				DOTweenModuleUI.__c__DisplayClass35_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass35_0>.NativeClassPtr, 100667279);
			}

			// Token: 0x060023D2 RID: 9170 RVA: 0x00099488 File Offset: 0x00097688
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023D3 RID: 9171 RVA: 0x000994C4 File Offset: 0x000976C4
			[CallerCount(0)]
			public unsafe Color _DOFade_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass35_0.NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023D4 RID: 9172 RVA: 0x00099500 File Offset: 0x00097700
			[CallerCount(0)]
			public unsafe void _DOFade_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass35_0.NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023D5 RID: 9173 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
			public __c__DisplayClass35_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700073D RID: 1853
			// (get) Token: 0x060023D6 RID: 9174 RVA: 0x00099540 File Offset: 0x00097740
			// (set) Token: 0x060023D7 RID: 9175 RVA: 0x0000D6D1 File Offset: 0x0000B8D1
			public unsafe Text target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass35_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass35_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400224F RID: 8783
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002250 RID: 8784
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002251 RID: 8785
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__0_Internal_Color_0;

			// Token: 0x04002252 RID: 8786
			private static readonly IntPtr NativeMethodInfoPtr__DOFade_b__1_Internal_Void_Color_0;
		}

		// Token: 0x020002AB RID: 683
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060023D8 RID: 9176 RVA: 0x00099570 File Offset: 0x00097770
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass36_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass36_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass36_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass36_0>.NativeClassPtr, 100667280);
				DOTweenModuleUI.__c__DisplayClass36_0.NativeMethodInfoPtr__DOText_b__0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass36_0>.NativeClassPtr, 100667281);
				DOTweenModuleUI.__c__DisplayClass36_0.NativeMethodInfoPtr__DOText_b__1_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass36_0>.NativeClassPtr, 100667282);
			}

			// Token: 0x060023D9 RID: 9177 RVA: 0x000995EC File Offset: 0x000977EC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023DA RID: 9178 RVA: 0x00099628 File Offset: 0x00097828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21591, XrefRangeEnd = 21592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _DOText_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass36_0.NativeMethodInfoPtr__DOText_b__0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060023DB RID: 9179 RVA: 0x00099660 File Offset: 0x00097860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21592, XrefRangeEnd = 21593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOText_b__1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass36_0.NativeMethodInfoPtr__DOText_b__1_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023DC RID: 9180 RVA: 0x0000D6F0 File Offset: 0x0000B8F0
			public __c__DisplayClass36_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700073E RID: 1854
			// (get) Token: 0x060023DD RID: 9181 RVA: 0x000996A4 File Offset: 0x000978A4
			// (set) Token: 0x060023DE RID: 9182 RVA: 0x0000D6F9 File Offset: 0x0000B8F9
			public unsafe Text target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass36_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass36_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002253 RID: 8787
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002254 RID: 8788
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002255 RID: 8789
			private static readonly IntPtr NativeMethodInfoPtr__DOText_b__0_Internal_String_0;

			// Token: 0x04002256 RID: 8790
			private static readonly IntPtr NativeMethodInfoPtr__DOText_b__1_Internal_Void_String_0;
		}

		// Token: 0x020002AC RID: 684
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060023DF RID: 9183 RVA: 0x000996D4 File Offset: 0x000978D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass37_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass37_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass37_0>.NativeClassPtr, "to");
				DOTweenModuleUI.__c__DisplayClass37_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass37_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass37_0>.NativeClassPtr, 100667283);
				DOTweenModuleUI.__c__DisplayClass37_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass37_0>.NativeClassPtr, 100667284);
				DOTweenModuleUI.__c__DisplayClass37_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass37_0>.NativeClassPtr, 100667285);
			}

			// Token: 0x060023E0 RID: 9184 RVA: 0x00099764 File Offset: 0x00097964
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023E1 RID: 9185 RVA: 0x000997A0 File Offset: 0x000979A0
			[CallerCount(0)]
			public unsafe Color _DOBlendableColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass37_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023E2 RID: 9186 RVA: 0x000997DC File Offset: 0x000979DC
			[CallerCount(0)]
			public unsafe void _DOBlendableColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass37_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023E3 RID: 9187 RVA: 0x0000D718 File Offset: 0x0000B918
			public __c__DisplayClass37_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700073F RID: 1855
			// (get) Token: 0x060023E4 RID: 9188 RVA: 0x0009981C File Offset: 0x00097A1C
			// (set) Token: 0x060023E5 RID: 9189 RVA: 0x0000D721 File Offset: 0x0000B921
			public unsafe Color to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass37_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass37_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x17000740 RID: 1856
			// (get) Token: 0x060023E6 RID: 9190 RVA: 0x00099844 File Offset: 0x00097A44
			// (set) Token: 0x060023E7 RID: 9191 RVA: 0x0000D73C File Offset: 0x0000B93C
			public unsafe Graphic target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass37_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass37_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002257 RID: 8791
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x04002258 RID: 8792
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002259 RID: 8793
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400225A RID: 8794
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0;

			// Token: 0x0400225B RID: 8795
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x020002AD RID: 685
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060023E8 RID: 9192 RVA: 0x00099874 File Offset: 0x00097A74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass38_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass38_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass38_0>.NativeClassPtr, "to");
				DOTweenModuleUI.__c__DisplayClass38_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass38_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass38_0>.NativeClassPtr, 100667286);
				DOTweenModuleUI.__c__DisplayClass38_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass38_0>.NativeClassPtr, 100667287);
				DOTweenModuleUI.__c__DisplayClass38_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass38_0>.NativeClassPtr, 100667288);
			}

			// Token: 0x060023E9 RID: 9193 RVA: 0x00099904 File Offset: 0x00097B04
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023EA RID: 9194 RVA: 0x00099940 File Offset: 0x00097B40
			[CallerCount(0)]
			public unsafe Color _DOBlendableColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass38_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023EB RID: 9195 RVA: 0x0009997C File Offset: 0x00097B7C
			[CallerCount(0)]
			public unsafe void _DOBlendableColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass38_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023EC RID: 9196 RVA: 0x0000D75B File Offset: 0x0000B95B
			public __c__DisplayClass38_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000741 RID: 1857
			// (get) Token: 0x060023ED RID: 9197 RVA: 0x000999BC File Offset: 0x00097BBC
			// (set) Token: 0x060023EE RID: 9198 RVA: 0x0000D764 File Offset: 0x0000B964
			public unsafe Color to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass38_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass38_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x17000742 RID: 1858
			// (get) Token: 0x060023EF RID: 9199 RVA: 0x000999E4 File Offset: 0x00097BE4
			// (set) Token: 0x060023F0 RID: 9200 RVA: 0x0000D77F File Offset: 0x0000B97F
			public unsafe Image target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass38_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass38_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400225C RID: 8796
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x0400225D RID: 8797
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400225E RID: 8798
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400225F RID: 8799
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0;

			// Token: 0x04002260 RID: 8800
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0;
		}

		// Token: 0x020002AE RID: 686
		[ObfuscatedName("DG.Tweening.DOTweenModuleUI+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060023F1 RID: 9201 RVA: 0x00099A14 File Offset: 0x00097C14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUI>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass39_0>.NativeClassPtr);
				DOTweenModuleUI.__c__DisplayClass39_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass39_0>.NativeClassPtr, "to");
				DOTweenModuleUI.__c__DisplayClass39_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass39_0>.NativeClassPtr, "target");
				DOTweenModuleUI.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass39_0>.NativeClassPtr, 100667289);
				DOTweenModuleUI.__c__DisplayClass39_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass39_0>.NativeClassPtr, 100667290);
				DOTweenModuleUI.__c__DisplayClass39_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass39_0>.NativeClassPtr, 100667291);
			}

			// Token: 0x060023F2 RID: 9202 RVA: 0x00099AA4 File Offset: 0x00097CA4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUI.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023F3 RID: 9203 RVA: 0x00099AE0 File Offset: 0x00097CE0
			[CallerCount(0)]
			public unsafe Color _DOBlendableColor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass39_0.NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023F4 RID: 9204 RVA: 0x00099B1C File Offset: 0x00097D1C
			[CallerCount(0)]
			public unsafe void _DOBlendableColor_b__1(Color x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUI.__c__DisplayClass39_0.NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023F5 RID: 9205 RVA: 0x0000D79E File Offset: 0x0000B99E
			public __c__DisplayClass39_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000743 RID: 1859
			// (get) Token: 0x060023F6 RID: 9206 RVA: 0x00099B5C File Offset: 0x00097D5C
			// (set) Token: 0x060023F7 RID: 9207 RVA: 0x0000D7A7 File Offset: 0x0000B9A7
			public unsafe Color to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass39_0.NativeFieldInfoPtr_to);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass39_0.NativeFieldInfoPtr_to)) = value;
				}
			}

			// Token: 0x17000744 RID: 1860
			// (get) Token: 0x060023F8 RID: 9208 RVA: 0x00099B84 File Offset: 0x00097D84
			// (set) Token: 0x060023F9 RID: 9209 RVA: 0x0000D7C2 File Offset: 0x0000B9C2
			public unsafe Text target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass39_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUI.__c__DisplayClass39_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002261 RID: 8801
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x04002262 RID: 8802
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002263 RID: 8803
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002264 RID: 8804
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__0_Internal_Color_0;

			// Token: 0x04002265 RID: 8805
			private static readonly IntPtr NativeMethodInfoPtr__DOBlendableColor_b__1_Internal_Void_Color_0;
		}
	}
}
